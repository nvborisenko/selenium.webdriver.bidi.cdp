using System.Text.Json;
using OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp;

internal sealed record SendCommandParameters(string Method, JsonElement Params, string? Session) : Parameters;

/// <summary>
/// Result of a CDP send command operation.
/// </summary>
/// <param name="Result">The raw JSON result from the CDP command.</param>
/// <param name="Session">The CDP session identifier the command was executed on.</param>
public sealed record SendCommandResult(JsonElement Result, string Session) : EmptyResult;
