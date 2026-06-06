using System.Text.Json;
using System.Text.Json.Nodes;
using OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp;

internal sealed record SendCommandParameters(string Method, JsonObject Params, string? Session) : Parameters;

/// <summary>
/// Options for sending a CDP command.
/// </summary>
public record SendCommandOptions : CommandOptions
{
    /// <summary>
    /// The CDP session identifier to use. If not specified, the default session is used.
    /// </summary>
    public string? Session { get; init; }
}

/// <summary>
/// Result of a CDP send command operation.
/// </summary>
/// <param name="Result">The raw JSON result from the CDP command.</param>
/// <param name="Session">The CDP session identifier the command was executed on.</param>
public sealed record SendCommandResult(JsonElement Result, string Session) : EmptyResult;
