#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.FindInPage;

/// <summary>
/// This domain provides commands to trigger the "Find in page" feature.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public interface IFindInPage
{
    /// <summary>
    /// Forwards <b>query</b> to the find-in-page facility, starting a new find session.
    /// Where exactly the search starts from is implementation-specific.
    /// </summary>
    /// <param name="query">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="FindFirstResult"/>.
    /// </returns>
    Task<FindFirstResult> FindFirstAsync(string query, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Moves to the next match for the query passed to the most recent
    /// findFirst() call.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="FindNextResult"/>.
    /// </returns>
    Task<FindNextResult> FindNextAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Moves to the previous match for the query passed to the most recent
    /// findFirst() call.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="FindPrevResult"/>.
    /// </returns>
    Task<FindPrevResult> FindPrevAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Ends the current find session, if any, and clears its highlighting.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StopResult"/>.
    /// </returns>
    Task<StopResult> StopAsync(string? session = null, CancellationToken cancellationToken = default);

}

[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
internal sealed class FindInPageDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), IFindInPage
{
    private static readonly FindInPageJsonSerializerContext JsonContext = FindInPageJsonSerializerContext.Default;

    public async Task<FindFirstResult> FindFirstAsync(string query, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new FindFirstCommandParameters(Query: query);
        return await ExecuteCommandAsync("FindInPage.findFirst", @params, JsonContext.FindFirstCommandParameters, JsonContext.FindFirstResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<FindNextResult> FindNextAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new FindNextCommandParameters();
        return await ExecuteCommandAsync("FindInPage.findNext", @params, JsonContext.FindNextCommandParameters, JsonContext.FindNextResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<FindPrevResult> FindPrevAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new FindPrevCommandParameters();
        return await ExecuteCommandAsync("FindInPage.findPrev", @params, JsonContext.FindPrevCommandParameters, JsonContext.FindPrevResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<StopResult> StopAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new StopCommandParameters();
        return await ExecuteCommandAsync("FindInPage.stop", @params, JsonContext.StopCommandParameters, JsonContext.StopResult, session, cancellationToken).ConfigureAwait(false);
    }

}

internal sealed record FindFirstCommandParameters(string Query) : Parameters;

/// <summary>
/// Result of the <see cref="IFindInPage.FindFirstAsync"/> command.
/// </summary>
public sealed record FindFirstResult() : EmptyResult;


internal sealed record FindNextCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IFindInPage.FindNextAsync"/> command.
/// </summary>
public sealed record FindNextResult() : EmptyResult;


internal sealed record FindPrevCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IFindInPage.FindPrevAsync"/> command.
/// </summary>
public sealed record FindPrevResult() : EmptyResult;


internal sealed record StopCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IFindInPage.StopAsync"/> command.
/// </summary>
public sealed record StopResult() : EmptyResult;


[JsonSerializable(typeof(FindFirstCommandParameters), TypeInfoPropertyName = "FindFirstCommandParameters")]
[JsonSerializable(typeof(FindFirstResult), TypeInfoPropertyName = "FindFirstResult")]
[JsonSerializable(typeof(FindNextCommandParameters), TypeInfoPropertyName = "FindNextCommandParameters")]
[JsonSerializable(typeof(FindNextResult), TypeInfoPropertyName = "FindNextResult")]
[JsonSerializable(typeof(FindPrevCommandParameters), TypeInfoPropertyName = "FindPrevCommandParameters")]
[JsonSerializable(typeof(FindPrevResult), TypeInfoPropertyName = "FindPrevResult")]
[JsonSerializable(typeof(StopCommandParameters), TypeInfoPropertyName = "StopCommandParameters")]
[JsonSerializable(typeof(StopResult), TypeInfoPropertyName = "StopResult")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class FindInPageJsonSerializerContext : JsonSerializerContext;

