using Selenium.WebDriver.BiDi.Cdp.Browser;

namespace Selenium.WebDriver.BiDi.Cdp.Tests;

public class EmulationTests : CdpTestFixture
{
    [Test]
    public async Task SetGeolocationOverride()
    {
        await Cdp.Browser.GrantPermissionsAsync([PermissionType.Geolocation]);

        await Cdp.Emulation.SetGeolocationOverrideAsync(new()
        {
            Latitude = 48.8566,
            Longitude = 2.3522,
            Accuracy = 1
        });

        await Cdp.Page.NavigateAsync("https://www.example.com");

        var result = await Cdp.Runtime.EvaluateAsync("""
            new Promise((resolve, reject) => {
                navigator.geolocation.getCurrentPosition(
                    pos => resolve(JSON.stringify({ lat: pos.coords.latitude, lng: pos.coords.longitude })),
                    err => reject(err.message)
                );
            })
            """, new() { AwaitPromise = true });

        await Assert.That(result.Result.Value?.ToString()).Contains("48.8566");
        await Assert.That(result.Result.Value?.ToString()).Contains("2.3522");
    }

    [Test]
    public async Task SetDeviceMetricsOverrideMobile()
    {
        await Cdp.Emulation.SetDeviceMetricsOverrideAsync(
            width: 375,
            height: 812,
            deviceScaleFactor: 3,
            mobile: true);

        await Cdp.Emulation.SetUserAgentOverrideAsync(
            "Mozilla/5.0 (iPhone; CPU iPhone OS 15_0 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/15.0 Mobile/15E148 Safari/604.1");

        await Cdp.Page.NavigateAsync("https://www.selenium.dev");

        var result = await Cdp.Runtime.EvaluateAsync("JSON.stringify({ width: window.innerWidth, height: window.innerHeight })");

        await Assert.That(result.Result.Value?.ToString()).Contains("375");
    }

    [Test]
    public async Task SetTimezoneOverride()
    {
        await Cdp.Emulation.SetTimezoneOverrideAsync("Pacific/Auckland");

        var result = await Cdp.Runtime.EvaluateAsync("Intl.DateTimeFormat().resolvedOptions().timeZone");

        await Assert.That(result.Result.Value?.ToString()).IsEqualTo("Pacific/Auckland");
    }

    [Test]
    public async Task SetLocaleOverride()
    {
        await Cdp.Emulation.SetLocaleOverrideAsync(new() { Locale = "de-DE" });

        var result = await Cdp.Runtime.EvaluateAsync("Intl.NumberFormat().resolvedOptions().locale");

        await Assert.That(result.Result.Value?.ToString()).IsEqualTo("de-DE");
    }

    [Test]
    public async Task ClearGeolocationOverride()
    {
        await Cdp.Emulation.SetGeolocationOverrideAsync(new()
        {
            Latitude = 51.5074,
            Longitude = -0.1278,
            Accuracy = 1
        });

        // Clear by calling without parameters
        await Cdp.Emulation.ClearGeolocationOverrideAsync();
    }
}
