namespace Selenium.WebDriver.BiDi.Cdp;

/// <summary>
/// Wire-format envelope for <c>goog:cdp</c> events: <c>{ "params": TParams, "session": string }</c>.
/// </summary>
public record CdpEventArgs<TParams>(TParams Params, string? Session) : OpenQA.Selenium.BiDi.EventArgs;
