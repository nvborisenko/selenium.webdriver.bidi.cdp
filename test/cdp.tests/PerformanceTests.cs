namespace Selenium.WebDriver.BiDi.Cdp.Tests;

public class PerformanceTests : CdpTestFixture
{
    private const string SimpleTestPage = "https://www.selenium.dev";

    [Test]
    public async Task EnableAndDisablePerformance()
    {
        await Cdp.Performance.EnableAsync();
        await Cdp.Page.NavigateAsync(SimpleTestPage);
    }

    [Test]
    public async Task DisablePerformance()
    {
        await Cdp.Performance.DisableAsync();
        await Cdp.Page.NavigateAsync(SimpleTestPage);
    }

    [Test]
    public async Task SetTimeDomainTimeTickPerformance()
    {
        await Cdp.Performance.DisableAsync();
        await Cdp.Performance.SetTimeDomainAsync("timeTicks");
        await Cdp.Performance.EnableAsync();
        await Cdp.Page.NavigateAsync(SimpleTestPage);
    }

    [Test]
    public async Task SetTimeDomainThreadTicksPerformance()
    {
        await Cdp.Performance.DisableAsync();
        await Cdp.Performance.SetTimeDomainAsync("threadTicks");
        await Cdp.Performance.EnableAsync();
        await Cdp.Page.NavigateAsync(SimpleTestPage);
    }

    [Test]
    public async Task GetMetricsByTimeTicks()
    {
        await Cdp.Performance.SetTimeDomainAsync("timeTicks");
        await Cdp.Performance.EnableAsync();
        await Cdp.Page.NavigateAsync(SimpleTestPage);

        var response = await Cdp.Performance.GetMetricsAsync();

        await Assert.That(response.Metrics).IsNotNull();
        await Assert.That(response.Metrics.Count).IsGreaterThan(0);
    }

    [Test]
    public async Task GetMetricsByThreadTicks()
    {
        await Cdp.Performance.SetTimeDomainAsync("threadTicks");
        await Cdp.Performance.EnableAsync();
        await Cdp.Page.NavigateAsync(SimpleTestPage);

        var response = await Cdp.Performance.GetMetricsAsync();

        await Assert.That(response.Metrics).IsNotNull();
        await Assert.That(response.Metrics.Count).IsGreaterThan(0);
    }
}
