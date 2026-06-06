namespace Selenium.WebDriver.BiDi.Cdp.Generator.Protocol;

internal record BrowserProtocol(Version Version, IReadOnlyList<DomainInfo> Domains);

internal record Version(string Major, string Minor);
