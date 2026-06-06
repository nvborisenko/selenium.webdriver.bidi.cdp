using Selenium.WebDriver.BiDi.Cdp.Profiler;

namespace Selenium.WebDriver.BiDi.Cdp.Tests;

public class ProfilerTests : CdpTestFixture
{
    private const string SimpleTestPage = "https://www.selenium.dev";

    [Test]
    public async Task SimpleStartStopAndGetProfiler()
    {
        await Cdp.Profiler.EnableAsync();
        await Cdp.Profiler.StartAsync();
        var response = await Cdp.Profiler.StopAsync();

        await ValidateProfile(response.Profile);
    }

    [Test]
    public async Task SampleGetBestEffortProfiler()
    {
        await Cdp.Profiler.EnableAsync();
        await Cdp.Page.NavigateAsync(SimpleTestPage);
        await Cdp.Profiler.SetSamplingIntervalAsync(30);

        var response = await Cdp.Profiler.GetBestEffortCoverageAsync();

        await Assert.That(response.Result).IsNotNull();
        await Assert.That(response.Result.Count).IsGreaterThan(0);
    }

    [Test]
    public async Task SampleSetStartPreciseCoverage()
    {
        await Cdp.Profiler.EnableAsync();
        await Cdp.Page.NavigateAsync(SimpleTestPage);

        await Cdp.Profiler.StartPreciseCoverageAsync(new() { CallCount = true, Detailed = true });
        await Cdp.Profiler.StartAsync();

        var coverageResponse = await Cdp.Profiler.TakePreciseCoverageAsync();

        await Assert.That(coverageResponse.Result).IsNotNull();

        var response = await Cdp.Profiler.StopAsync();

        await ValidateProfile(response.Profile);
    }

    [Test]
    public async Task SampleProfileEvents()
    {
        await Cdp.Profiler.EnableAsync();
        await Cdp.Runtime.EnableAsync();

        await using var consoleProfileStartedStream = await Cdp.Profiler.ConsoleProfileStarted.StreamAsync();
        await using var consoleProfileFinishedStream = await Cdp.Profiler.ConsoleProfileFinished.StreamAsync();

        await Cdp.Runtime.EvaluateAsync("console.profile('test')");

        var started = await consoleProfileStartedStream.FirstAsync().AsTask().WaitAsync(TimeSpan.FromSeconds(5));
        await Assert.That(started).IsNotNull();

        await Cdp.Runtime.EvaluateAsync("console.profileEnd('test')");

        var finished = await consoleProfileFinishedStream.FirstAsync().AsTask().WaitAsync(TimeSpan.FromSeconds(5));
        await Assert.That(finished).IsNotNull();

        await ValidateProfile(finished.Profile);
    }

    private static async Task ValidateProfile(Profile profile)
    {
        await Assert.That(profile).IsNotNull();
        await Assert.That(profile.Nodes).IsNotNull();
        await Assert.That(profile.StartTime).IsNotEqualTo(0);
        await Assert.That(profile.EndTime).IsNotEqualTo(0);
    }
}
