using OpenQA.Selenium.BiDi;
using OpenQA.Selenium.Chrome;

namespace Selenium.WebDriver.BiDi.Cdp.Tests;

public class PlaygroundTests
{
    [Test]
    public async Task Dummy()
    {
        // OpenQA.Selenium.Internal.Logging.Log.SetLevel(OpenQA.Selenium.Internal.Logging.LogEventLevel.Trace);

        await using var driver = new ChromeDriver(new ChromeOptions { UseWebSocketUrl = true });

        await using var bidi = await driver.AsBiDiAsync();

        var context = (await bidi.BrowsingContext.GetTreeAsync()).Contexts[0].Context;

        var cdp = await context.AsCdpAsync();

        var sessionResult = await cdp.GetSessionAsync(context);

        await Assert.That(sessionResult).IsNotNull();

        await context.NavigateAsync("https://www.example.com");

        // Network
        await cdp.Network.EnableAsync(new() { Session = sessionResult.Session, MaxResourceBufferSize = 999 });

        await using var requestWillBeSentStream = await cdp.Network.RequestWillBeSent.StreamAsync();

        await cdp.Page.ReloadAsync();
        // await context.ReloadAsync();

        var requestWillBeSent = await requestWillBeSentStream.ReadAllAsync().FirstAsync().AsTask().WaitAsync(TimeSpan.FromSeconds(5));
        System.Console.WriteLine($"Request will be sent: RequestId={requestWillBeSent.RequestId}, Url={requestWillBeSent.Request.Url}");

        var stopwatch = System.Diagnostics.Stopwatch.StartNew();

        for (int i = 0; i < 500; i++)
        {
            await cdp.Network.SetBlockedURLsAsync(["https://www.example.com/*"]);
        }

        System.Console.WriteLine($"Took {stopwatch.Elapsed}");

        await cdp.Network.SetExtraHTTPHeadersAsync(new Dictionary<string, string>
        {
            ["Authorization"] = "Bearer token",
            ["X-Custom-Header"] = "custom-value"
        });

        await cdp.Runtime.EvaluateAsync("1+1");
    }
}
