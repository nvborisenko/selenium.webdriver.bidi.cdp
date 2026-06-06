using OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp;

internal sealed record GetSessionParameters(OpenQA.Selenium.BiDi.BrowsingContext.BrowsingContext Context) : Parameters;

/// <summary>
/// Options for the CDP get session command.
/// </summary>
public sealed record GetSessionOptions : CommandOptions;

/// <summary>
/// Result of the CDP get session command.
/// </summary>
/// <param name="Session">The CDP session identifier.</param>
public sealed record GetSessionResult(string Session) : EmptyResult;
