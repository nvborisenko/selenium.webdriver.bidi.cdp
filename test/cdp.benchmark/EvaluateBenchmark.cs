using BenchmarkDotNet.Attributes;
using OpenQA.Selenium.BiDi;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.DevTools.V148.Runtime;
using DevToolsSessionDomains = OpenQA.Selenium.DevTools.V148.DevToolsSessionDomains;

namespace Selenium.WebDriver.BiDi.Cdp.Benchmark;

[MemoryDiagnoser]
public class EvaluateBenchmark
{
    private ChromeDriver _driver = null!;
    private IBiDi _bidi = null!;
    private CdpModule _cdp = null!;
    private DevToolsSession _devToolsSession = null!;

    [GlobalSetup]
    public async Task Setup()
    {
        _driver = new ChromeDriver(new ChromeOptions { UseWebSocketUrl = true });
        _bidi = await _driver.AsBiDiAsync();
        var context = (await _bidi.BrowsingContext.GetTreeAsync()).Contexts[0].Context;
        _cdp = await context.AsCdpAsync();

        _devToolsSession = _driver.GetDevToolsSession();

    }

    [Benchmark(Baseline = true)]
    public async Task EvaluateSeleniumDevTools()
    {
        var domains = _devToolsSession.GetVersionSpecificDomains<DevToolsSessionDomains>();

        await domains.Runtime.Evaluate(new EvaluateCommandSettings
        {
            Expression = "1+1"
        });
    }

    [Benchmark]
    public async Task EvaluateBiDiCdp()
    {
        await _cdp.Runtime.EvaluateAsync("1+1");
    }

    [GlobalCleanup]
    public async Task Cleanup()
    {
        _devToolsSession?.Dispose();
        await _bidi.DisposeAsync();
        await _driver.DisposeAsync();
    }
}
