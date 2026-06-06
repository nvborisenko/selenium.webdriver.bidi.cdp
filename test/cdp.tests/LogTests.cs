namespace Selenium.WebDriver.BiDi.Cdp.Tests;

public class LogTests : CdpTestFixture
{
    [Test]
    public async Task VerifyEntryAddedAndClearLog()
    {
        await Cdp.Log.EnableAsync();

        await using var entryAddedStream = await Cdp.Log.EntryAdded.StreamAsync();

        await Cdp.Page.NavigateAsync("data:text/html,<html><body><img src='http://localhost:1/does_not_exist.png'></body></html>");

        var entryAdded = await entryAddedStream.FirstAsync().AsTask().WaitAsync(TimeSpan.FromSeconds(5));

        await Assert.That(entryAdded.Entry).IsNotNull();
        await Assert.That(entryAdded.Entry.Level).IsEqualTo("error");

        await Cdp.Log.ClearAsync();
    }
}
