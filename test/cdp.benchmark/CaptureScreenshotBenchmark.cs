using BenchmarkDotNet.Attributes;
using OpenQA.Selenium.BiDi;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.DevTools.V150.Page;
using DevToolsSessionDomains = OpenQA.Selenium.DevTools.V150.DevToolsSessionDomains;

namespace Selenium.WebDriver.BiDi.Cdp.Benchmark;

[MemoryDiagnoser]
public class CaptureScreenshotBenchmark
{
    private ChromeDriver _driver = null!;
    private IBiDi _bidi = null!;
    private CdpModule _cdp = null!;
    private DevToolsSession _devToolsSession = null!;

    [GlobalSetup]
    public async Task Setup()
    {
        var options = new ChromeOptions { UseWebSocketUrl = true };
        options.AddArgument("--headless=new");

        _driver = new ChromeDriver(options);
        _bidi = await _driver.AsBiDiAsync();
        var context = (await _bidi.BrowsingContext.GetTreeAsync()).Contexts[0].Context;
        await context.NavigateAsync("https://selenium.dev", new() { Wait = OpenQA.Selenium.BiDi.BrowsingContext.ReadinessState.Complete });
        _cdp = await context.AsCdpAsync();

        _devToolsSession = _driver.GetDevToolsSession();
    }

    [Benchmark(Baseline = true)]
    public async Task CaptureScreenshotSeleniumDevTools()
    {
        var domains = _devToolsSession.GetVersionSpecificDomains<DevToolsSessionDomains>();

        await domains.Page.CaptureScreenshot(new CaptureScreenshotCommandSettings());
    }

    [Benchmark]
    public async Task CaptureScreenshotBiDiCdp()
    {
        await _cdp.Page.CaptureScreenshotAsync();
    }

    [GlobalCleanup]
    public async Task Cleanup()
    {
        _devToolsSession?.Dispose();
        await _bidi.DisposeAsync();
        await _driver.DisposeAsync();
    }
}
