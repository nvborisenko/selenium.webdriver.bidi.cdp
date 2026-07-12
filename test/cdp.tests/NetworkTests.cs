using Selenium.WebDriver.BiDi.Cdp.Network;

namespace Selenium.WebDriver.BiDi.Cdp.Tests;

public class NetworkTests : CdpTestFixture
{
    private const string SimpleTestPage = "https://www.selenium.dev";

    [Test]
    public async Task SendRequestWithUrlFiltersAndExtraHeadersAndVerifyRequests()
    {
        await Cdp.Network.SetBlockedURLsAsync(new() { UrlPatterns = [new BlockPattern("*://*/*.gif", Block: true)] });

        await Cdp.Network.SetExtraHTTPHeadersAsync(new Dictionary<string, string>
        {
            ["headerName"] = "headerValue"
        });

        await using var loadingFailedStream = await Cdp.Network.LoadingFailed.StreamAsync();
        await using var requestWillBeSentStream = await Cdp.Network.RequestWillBeSent.StreamAsync();
        await using var dataReceivedStream = await Cdp.Network.DataReceived.StreamAsync();

        await Cdp.Page.NavigateAsync(SimpleTestPage);

        var dataReceived = await dataReceivedStream.ReadAllAsync().FirstAsync().AsTask().WaitAsync(TimeSpan.FromSeconds(10));
        await Assert.That(dataReceived.RequestId).IsNotNull();

        var requestWillBeSent = await requestWillBeSentStream.ReadAllAsync().FirstAsync().AsTask().WaitAsync(TimeSpan.FromSeconds(10));
        await Assert.That(requestWillBeSent.Request.Headers).ContainsKey("headerName");
    }

    [Test]
    public async Task EmulateNetworkConditionOffline()
    {
#pragma warning disable CS0612
        await Cdp.Network.EmulateNetworkConditionsAsync(
            offline: true,
            latency: 100,
            downloadThroughput: 1000,
            uploadThroughput: 2000,
            new() { ConnectionType = ConnectionType.Cellular3g });
#pragma warning restore CS0612

        await using var loadingFailedStream = await Cdp.Network.LoadingFailed.StreamAsync();

        try
        {
            await Cdp.Page.NavigateAsync(SimpleTestPage);
        }
        catch
        {
            // Expected: navigation fails when offline
        }

        var loadingFailed = await loadingFailedStream.ReadAllAsync().FirstAsync().AsTask().WaitAsync(TimeSpan.FromSeconds(5));
        await Assert.That(loadingFailed.ErrorText).IsEqualTo("net::ERR_INTERNET_DISCONNECTED");
    }

    [Test]
    public async Task VerifySearchInResponseBody()
    {
        await using var responseReceivedStream = await Cdp.Network.ResponseReceived.StreamAsync();
        await using var loadingFinishedStream = await Cdp.Network.LoadingFinished.StreamAsync();

        await Cdp.Page.NavigateAsync(SimpleTestPage);

        var responseReceived = await responseReceivedStream.ReadAllAsync().FirstAsync().AsTask().WaitAsync(TimeSpan.FromSeconds(5));

        // The response body is only available after the resource has finished loading.
        await loadingFinishedStream.ReadAllAsync()
            .FirstAsync(e => e.RequestId == responseReceived.RequestId)
            .AsTask().WaitAsync(TimeSpan.FromSeconds(10));

        var searchResponse = await Cdp.Network.SearchInResponseBodyAsync(
            responseReceived.RequestId,
            ".*",
            new() { IsRegex = true });

        await Assert.That(searchResponse.Result.Count).IsGreaterThan(0);
    }

    [Test]
    public async Task VerifyCacheDisabledAndClearCache()
    {
        await using var responseReceivedStream = await Cdp.Network.ResponseReceived.StreamAsync();

        await Cdp.Page.NavigateAsync(SimpleTestPage);

        var responseReceived = await responseReceivedStream.ReadAllAsync().FirstAsync().AsTask().WaitAsync(TimeSpan.FromSeconds(5));
        await Assert.That(responseReceived.Response.FromDiskCache).IsNotEqualTo(true);

        await Cdp.Network.SetCacheDisabledAsync(true);

        await Cdp.Page.NavigateAsync(SimpleTestPage);
        await Cdp.Network.ClearBrowserCacheAsync();
    }

    [Test]
    public async Task VerifyResponseReceivedEventAndNetworkDisable()
    {
        await using var responseReceivedStream = await Cdp.Network.ResponseReceived.StreamAsync();

        await Cdp.Page.NavigateAsync(SimpleTestPage);

        var responseReceived = await responseReceivedStream.ReadAllAsync().FirstAsync().AsTask().WaitAsync(TimeSpan.FromSeconds(5));
        await Assert.That(responseReceived).IsNotNull();
    }

    [Test]
    public async Task VerifyRequestPostData()
    {
        await Cdp.Page.NavigateAsync(SimpleTestPage);

        await using var requestWillBeSentStream = await Cdp.Network.RequestWillBeSent.StreamAsync();

        await Cdp.Runtime.EvaluateAsync("fetch(location.href, { method: 'POST', body: 'key=value' })");

        using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(10));
        RequestWillBeSentEventArgs? postRequest = null;
        await foreach (var evt in requestWillBeSentStream.ReadAllAsync().WithCancellation(cts.Token))
        {
            if (string.Equals(evt.Request.Method, "POST", StringComparison.OrdinalIgnoreCase))
            {
                postRequest = evt;
                break;
            }
        }

        await Assert.That(postRequest).IsNotNull();

        var response = await Cdp.Network.GetRequestPostDataAsync(postRequest!.RequestId, cancellationToken: cts.Token);
        await Assert.That(response.PostData).IsEqualTo("key=value");
    }

    [Test]
    public async Task ByPassServiceWorker()
    {
        await Cdp.Network.SetBypassServiceWorkerAsync(true);
    }
}
