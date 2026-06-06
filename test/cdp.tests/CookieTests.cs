namespace Selenium.WebDriver.BiDi.Cdp.Tests;

public class CookieTests : CdpTestFixture
{
    [Test]
    public async Task SetAndGetCookies()
    {
        await Cdp.Page.NavigateAsync("https://www.example.com");

        var setResult = await Cdp.Network.SetCookieAsync("test_cookie", "test_value", new()
        {
            Domain = ".example.com",
            Path = "/",
            Secure = false,
            HttpOnly = false
        });

        await Assert.That(setResult.Success).IsTrue();

        var getResult = await Cdp.Network.GetCookiesAsync(new() { Urls = ["https://www.example.com"] });

        await Assert.That(getResult.Cookies.Count).IsGreaterThan(0);

        var cookie = getResult.Cookies.FirstOrDefault(c => c.Name == "test_cookie");
        await Assert.That(cookie).IsNotNull();
        await Assert.That(cookie!.Value).IsEqualTo("test_value");
    }

    [Test]
    public async Task DeleteCookies()
    {
        await Cdp.Page.NavigateAsync("https://www.example.com");

        await Cdp.Network.SetCookieAsync("to_delete", "value", new()
        {
            Domain = ".example.com",
            Path = "/"
        });

        // Verify it exists
        var before = await Cdp.Network.GetCookiesAsync(new() { Urls = ["https://www.example.com"] });
        await Assert.That(before.Cookies.Any(c => c.Name == "to_delete")).IsTrue();

        // Delete it
        await Cdp.Network.DeleteCookiesAsync("to_delete", new()
        {
            Domain = ".example.com",
            Path = "/"
        });

        // Verify it's gone
        var after = await Cdp.Network.GetCookiesAsync(new() { Urls = ["https://www.example.com"] });
        await Assert.That(after.Cookies.Any(c => c.Name == "to_delete")).IsFalse();
    }

    [Test]
    public async Task ClearBrowserCookies()
    {
        await Cdp.Page.NavigateAsync("https://www.example.com");

        await Cdp.Network.SetCookieAsync("cookie1", "value1", new() { Domain = ".example.com" });
        await Cdp.Network.SetCookieAsync("cookie2", "value2", new() { Domain = ".example.com" });

        await Cdp.Network.ClearBrowserCookiesAsync();

        var result = await Cdp.Network.GetCookiesAsync(new() { Urls = ["https://www.example.com"] });
        await Assert.That(result.Cookies.Count).IsEqualTo(0);
    }

    [Test]
    public async Task SetSecureHttpOnlyCookie()
    {
        await Cdp.Page.NavigateAsync("https://www.example.com");

        var setResult = await Cdp.Network.SetCookieAsync("secure_cookie", "secret", new()
        {
            Domain = ".example.com",
            Path = "/",
            Secure = true,
            HttpOnly = true,
            SameSite = Network.CookieSameSite.Strict
        });

        await Assert.That(setResult.Success).IsTrue();

        var cookies = await Cdp.Network.GetCookiesAsync(new() { Urls = ["https://www.example.com"] });
        var cookie = cookies.Cookies.FirstOrDefault(c => c.Name == "secure_cookie");

        await Assert.That(cookie).IsNotNull();
        await Assert.That(cookie!.Secure).IsTrue();
        await Assert.That(cookie.HttpOnly).IsTrue();
    }
}
