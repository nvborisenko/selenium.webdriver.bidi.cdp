using Selenium.WebDriver.BiDi.Cdp.Fetch;

namespace Selenium.WebDriver.BiDi.Cdp.Tests;

public class FetchTests : CdpTestFixture
{
    /// <summary>
    /// Workaround: when using the CDP Fetch domain through goog:cdp.sendCommand, the BiDi mapper
    /// will auto-continue any Fetch.requestPaused event unless a matching BiDi network intercept
    /// is registered AND the corresponding network event is subscribed to. Without this, our CDP
    /// fulfill/continue/fail commands race with the mapper and fail with
    /// "Invalid state for continueInterceptedRequest".
    /// See https://github.com/GoogleChromeLabs/chromium-bidi NetworkRequest.onRequestPaused.
    /// </summary>
    private async Task<IAsyncDisposable> BlockBiDiNetworkPhasesAsync()
    {
        var subscription = await BiDi.Network.BeforeRequestSent.SubscribeAsync(_ => { });
        await BiDi.Network.AddInterceptAsync(
            [OpenQA.Selenium.BiDi.Network.InterceptPhase.BeforeRequestSent]);
        return subscription;
    }

    [Test]
    public async Task InterceptAndMockResponse()
    {
        await using var _ = await BlockBiDiNetworkPhasesAsync();

        await Cdp.Fetch.EnableAsync(new()
        {
            Patterns = [new RequestPattern { UrlPattern = "*" }]
        });

        await using var requestPausedStream = await Cdp.Fetch.RequestPaused.StreamAsync();

        // Navigate in background since it will be paused
        var navigateTask = Cdp.Page.NavigateAsync("https://www.example.com");

        var requestPaused = await requestPausedStream.ReadAllAsync().FirstAsync().AsTask().WaitAsync(TimeSpan.FromSeconds(10));

        await Assert.That(requestPaused.RequestId).IsNotNull();
        await Assert.That(requestPaused.Request.Url).Contains("example.com");

        // Fulfill with a mock response
        string mockBody = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("<html><body><h1>Mocked!</h1></body></html>"));
        await Cdp.Fetch.FulfillRequestAsync(
            requestPaused.RequestId,
            200,
            new()
            {
                ResponseHeaders = [new HeaderEntry("Content-Type", "text/html")],
                Body = mockBody
            });

        await navigateTask;

        // Verify the mocked content is rendered
        var result = await Cdp.Runtime.EvaluateAsync("document.querySelector('h1').textContent");
        await Assert.That(result.Result.Value?.ToString()).IsEqualTo("Mocked!");
    }

    [Test]
    public async Task InterceptAndModifyRequestUrl()
    {
        await using var _ = await BlockBiDiNetworkPhasesAsync();

        await Cdp.Fetch.EnableAsync(new()
        {
            Patterns = [new RequestPattern { UrlPattern = "*://www.example.com/*" }]
        });

        await using var requestPausedStream = await Cdp.Fetch.RequestPaused.StreamAsync();

        var navigateTask = Cdp.Page.NavigateAsync("https://www.example.com");

        var requestPaused = await requestPausedStream.ReadAllAsync().FirstAsync().AsTask().WaitAsync(TimeSpan.FromSeconds(10));

        // Redirect to a different URL
        await Cdp.Fetch.ContinueRequestAsync(requestPaused.RequestId, new()
        {
            Url = "https://www.selenium.dev"
        });

        await navigateTask;

        var result = await Cdp.Runtime.EvaluateAsync("document.title");
        await Assert.That(result.Result.Value?.ToString()).IsNotEqualTo("Example Domain");
    }

    [Test]
    public async Task InterceptAndFailRequest()
    {
        await using var _ = await BlockBiDiNetworkPhasesAsync();

        await Cdp.Fetch.EnableAsync(new()
        {
            Patterns = [new RequestPattern
            {
                UrlPattern = "*.png",
                ResourceType = Network.ResourceType.Image
            }]
        });

        await using var requestPausedStream = await Cdp.Fetch.RequestPaused.StreamAsync();

        // Navigate to a page with images
        var navigateTask = Task.Run(async () =>
        {
            try { await Cdp.Page.NavigateAsync("data:text/html,<html><body><img src='https://www.selenium.dev/images/selenium_logo_square_green.png'></body></html>"); }
            catch { /* image failure may propagate */ }
        });

        var requestPaused = await requestPausedStream.ReadAllAsync().FirstAsync().AsTask().WaitAsync(TimeSpan.FromSeconds(10));

        // Block the image request
        await Cdp.Fetch.FailRequestAsync(requestPaused.RequestId, Network.ErrorReason.BlockedByClient);

        await navigateTask;
    }

    [Test]
    public async Task InterceptByResourceType()
    {
        await using var _ = await BlockBiDiNetworkPhasesAsync();

        await Cdp.Fetch.EnableAsync(new()
        {
            Patterns = [new RequestPattern
            {
                UrlPattern = "*",
                ResourceType = Network.ResourceType.Document,
                RequestStage = RequestStage.Request
            }]
        });

        await using var requestPausedStream = await Cdp.Fetch.RequestPaused.StreamAsync();

        var navigateTask = Cdp.Page.NavigateAsync("https://www.example.com");

        var requestPaused = await requestPausedStream.ReadAllAsync().FirstAsync().AsTask().WaitAsync(TimeSpan.FromSeconds(10));

        await Assert.That(requestPaused.ResourceType).IsEqualTo(Network.ResourceType.Document);

        await Cdp.Fetch.ContinueRequestAsync(requestPaused.RequestId);

        await navigateTask;
    }

    [Test]
    public async Task InterceptAndAddRequestHeaders()
    {
        await using var _ = await BlockBiDiNetworkPhasesAsync();

        await Cdp.Fetch.EnableAsync(new()
        {
            Patterns = [new RequestPattern { UrlPattern = "*" }]
        });

        await using var requestPausedStream = await Cdp.Fetch.RequestPaused.StreamAsync();

        var navigateTask = Cdp.Page.NavigateAsync("https://www.example.com");

        var requestPaused = await requestPausedStream.ReadAllAsync().FirstAsync().AsTask().WaitAsync(TimeSpan.FromSeconds(10));

        // Continue with an extra header
        await Cdp.Fetch.ContinueRequestAsync(requestPaused.RequestId, new()
        {
            Headers =
            [
                new HeaderEntry("X-Custom-Auth", "Bearer test-token"),
                new HeaderEntry("Accept", "text/html")
            ]
        });

        await navigateTask;
    }
}
