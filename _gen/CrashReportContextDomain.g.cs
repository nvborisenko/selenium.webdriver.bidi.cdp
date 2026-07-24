#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.CrashReportContext;

/// <summary>
/// This domain exposes the current state of the CrashReportContext API.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public interface ICrashReportContext
{
    /// <summary>
    /// Returns all entries in the CrashReportContext across all frames in the page.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetEntriesResult"/>.
    /// </returns>
    Task<GetEntriesResult> GetEntriesAsync(string? session = default, CancellationToken cancellationToken = default);

}

[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
internal sealed class CrashReportContextDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), ICrashReportContext
{
    private static CrashReportContextJsonSerializerContext JsonContext = CrashReportContextJsonSerializerContext.Default;

    public async Task<GetEntriesResult> GetEntriesAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetEntriesCommandParameters();
        return await ExecuteCommandAsync(GetEntriesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetEntriesCommandParameters, GetEntriesResult> GetEntriesCommand = new("CrashReportContext.getEntries", JsonContext.GetEntriesCommandParameters, JsonContext.GetEntriesResult);

}

internal sealed record GetEntriesCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="Entries">
/// </param>
public sealed record GetEntriesResult(ImmutableArray<CrashReportContextEntry> Entries) : EmptyResult;


/// <summary>
/// Key-value pair in CrashReportContext.
/// </summary>
/// <param name="Key">
/// </param>
/// <param name="Value">
/// </param>
/// <param name="FrameId">
/// The ID of the frame where the key-value pair was set.
/// </param>
public sealed record CrashReportContextEntry(string Key, string Value, Page.FrameId FrameId)
{
}

[JsonSerializable(typeof(GetEntriesCommandParameters), TypeInfoPropertyName = "GetEntriesCommandParameters")]
[JsonSerializable(typeof(GetEntriesResult), TypeInfoPropertyName = "GetEntriesResult")]
[JsonSerializable(typeof(CrashReportContextEntry), TypeInfoPropertyName = "CrashReportContextCrashReportContextEntry")]
[JsonSerializable(typeof(ImmutableArray<CrashReportContextEntry>), TypeInfoPropertyName = "ImmutableArrayCrashReportContextCrashReportContextEntry")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class CrashReportContextJsonSerializerContext : JsonSerializerContext;

