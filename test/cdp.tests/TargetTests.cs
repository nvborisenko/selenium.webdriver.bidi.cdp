namespace Selenium.WebDriver.BiDi.Cdp.Tests;

public class TargetTests : CdpTestFixture
{
    [Test]
    public async Task GetTargetActivateAndAttach()
    {
        await Cdp.Page.NavigateAsync("https://www.selenium.dev");

        var response = await Cdp.Target.GetTargetsAsync();
        var allTargets = response.TargetInfos;

        await Assert.That(allTargets).IsNotNull();
        await Assert.That(allTargets.Count).IsGreaterThan(0);

        foreach (var targetInfo in allTargets)
        {
            await Assert.That(targetInfo.TargetId).IsNotNull();
            await Assert.That(targetInfo.Title).IsNotNull();
            await Assert.That(targetInfo.Type).IsNotNull();
            await Assert.That(targetInfo.Url).IsNotNull();

            await Cdp.Target.ActivateTargetAsync(targetInfo.TargetId);

            var attachResponse = await Cdp.Target.AttachToTargetAsync(targetInfo.TargetId, new() { Flatten = true });
            await Assert.That(attachResponse.SessionId).IsNotNull();

            var getInfoResponse = await Cdp.Target.GetTargetInfoAsync(new() { TargetId = targetInfo.TargetId });
            await Assert.That(getInfoResponse.TargetInfo).IsNotNull();
            await Assert.That(getInfoResponse.TargetInfo.TargetId).IsNotNull();
        }
    }

    [Test]
    public async Task CreateAndContentLifeCycle()
    {
        await using var targetInfoChangedStream = await Cdp.Target.TargetInfoChanged.StreamAsync();

        var response = await Cdp.Target.CreateTargetAsync("https://www.selenium.dev", new() { NewWindow = true, Background = false });

        await Assert.That(response.TargetId).IsNotNull();

        await Cdp.Target.SetDiscoverTargetsAsync(true);

        var closeResponse = await Cdp.Target.CloseTargetAsync(response.TargetId);

        await Assert.That(closeResponse).IsNotNull();
        await Assert.That(closeResponse.Success).IsTrue();
    }
}
