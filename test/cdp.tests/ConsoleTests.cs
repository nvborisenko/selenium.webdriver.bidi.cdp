namespace Selenium.WebDriver.BiDi.Cdp.Tests;

#pragma warning disable CS0612
public class ConsoleTests : CdpTestFixture
{
    [Test]
    public async Task VerifyMessageAdded()
    {
        string consoleMessage = "Hello Selenium";

        await Cdp.Console.EnableAsync();

        await using var messageAddedStream = await Cdp.Console.MessageAdded.StreamAsync();

        await Cdp.Page.NavigateAsync("data:text/html,<html><body><script>console.log('" + consoleMessage + "');</script></body></html>");

        var messageAdded = await messageAddedStream.ReadAllAsync().FirstAsync().AsTask().WaitAsync(TimeSpan.FromSeconds(5));

        await Assert.That(messageAdded.Message.Text).IsEqualTo(consoleMessage);
    }
}
#pragma warning restore CS0612
