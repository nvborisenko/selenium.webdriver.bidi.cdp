namespace Selenium.WebDriver.BiDi.Cdp.Tests;

public class SecurityTests : CdpTestFixture
{
    [Test]
    public async Task LoadSecureWebsite()
    {
        await Cdp.Security.SetIgnoreCertificateErrorsAsync(true);

        await Cdp.Page.NavigateAsync("https://expired.badssl.com");
    }
}
