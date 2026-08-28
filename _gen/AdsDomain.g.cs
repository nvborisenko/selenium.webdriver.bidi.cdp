#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Ads;

/// <summary>
/// A domain for ad-related metrics and data.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public interface IAds
{
    /// <summary>
    /// Retrieves ad metrics for the current page.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetAdMetricsResult"/>.
    /// </returns>
    Task<GetAdMetricsResult> GetAdMetricsAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves ad scripts for the current page. To minimize payload size, this
    /// only returns the newly tracked ad scripts since the last call to
    /// getAdScripts (i.e., the delta).
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetAdScriptsResult"/>.
    /// </returns>
    Task<GetAdScriptsResult> GetAdScriptsAsync(string? session = default, CancellationToken cancellationToken = default);

}

[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
internal sealed class AdsDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), IAds
{
    private static readonly AdsJsonSerializerContext JsonContext = AdsJsonSerializerContext.Default;

    public async Task<GetAdMetricsResult> GetAdMetricsAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetAdMetricsCommandParameters();
        var command = new CdpCommand<GetAdMetricsCommandParameters, GetAdMetricsResult>("Ads.getAdMetrics", JsonContext.GetAdMetricsCommandParameters, JsonContext.GetAdMetricsResult);
        return await ExecuteCommandAsync(command, @params, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<GetAdScriptsResult> GetAdScriptsAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetAdScriptsCommandParameters();
        var command = new CdpCommand<GetAdScriptsCommandParameters, GetAdScriptsResult>("Ads.getAdScripts", JsonContext.GetAdScriptsCommandParameters, JsonContext.GetAdScriptsResult);
        return await ExecuteCommandAsync(command, @params, session, cancellationToken).ConfigureAwait(false);
    }

}

internal sealed record GetAdMetricsCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="Metrics">
/// </param>
public sealed record GetAdMetricsResult(AdMetrics Metrics) : EmptyResult;


internal sealed record GetAdScriptsCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="NewScripts">
/// </param>
public sealed record GetAdScriptsResult(ImmutableArray<AdScript> NewScripts) : EmptyResult;


/// <summary>
/// Ad frame data.
/// </summary>
/// <param name="FrameId">
/// The DevTools frame token.
/// </param>
/// <param name="NetworkBytes">
/// The network bytes of the frame.
/// </param>
/// <param name="CpuTime">
/// The CPU time of the frame, in milliseconds.
/// </param>
public sealed record AdFrameData(Page.FrameId FrameId, double NetworkBytes, double CpuTime)
{
    /// <summary>
    /// The initial origin of the frame. To minimize the payload size, this is
    /// only sent once per frame.
    /// </summary>
    public string? InitialOrigin { get; init; }
}

/// <summary>
/// Ad metrics for a page.
/// </summary>
/// <param name="ViewportAdDensityByArea">
/// The viewport ad density by area, represented as a percentage (an integer
/// between 0 and 100).
/// </param>
/// <param name="AverageViewportAdDensityByArea">
/// The time-weighted average of the viewport ad density by area, measured
/// across the duration of the page.
/// </param>
/// <param name="ViewportAdCount">
/// The number of ads currently visible within the viewport.
/// </param>
/// <param name="AverageViewportAdCount">
/// The time-weighted average of the viewport ad count, measured across the
/// duration of the page.
/// </param>
/// <param name="TotalAdCpuTime">
/// The total ad CPU usage, in milliseconds.
/// </param>
/// <param name="TotalAdNetworkBytes">
/// The total ad network bytes.
/// </param>
/// <param name="UpdateAdFrames">
/// The list of ad frames that have been updated since the last event.
/// </param>
/// <param name="RemoveAdFrames">
/// The list of ad frame IDs that have been removed since the last event.
/// </param>
public sealed record AdMetrics(long ViewportAdDensityByArea, double AverageViewportAdDensityByArea, long ViewportAdCount, double AverageViewportAdCount, double TotalAdCpuTime, double TotalAdNetworkBytes, ImmutableArray<AdFrameData> UpdateAdFrames, ImmutableArray<Page.FrameId> RemoveAdFrames)
{
}

/// <summary>
/// An ad script.
/// Note: when the script is a transitive ad script, we only fill in the
/// immediate ancestor script in the provenance's adScriptAncestry field (as its
/// first entry), rather than filling in the full ancestry. This saves work for
/// the backend, and the frontend can reconstruct the full ancestry if
/// necessary.
/// </summary>
/// <param name="ScriptId">
/// The script ID.
/// </param>
/// <param name="Provenance">
/// The ad provenance.
/// </param>
public sealed record AdScript(Runtime.ScriptId ScriptId, Network.AdProvenance Provenance)
{
}

[JsonSerializable(typeof(GetAdMetricsCommandParameters), TypeInfoPropertyName = "GetAdMetricsCommandParameters")]
[JsonSerializable(typeof(GetAdMetricsResult), TypeInfoPropertyName = "GetAdMetricsResult")]
[JsonSerializable(typeof(GetAdScriptsCommandParameters), TypeInfoPropertyName = "GetAdScriptsCommandParameters")]
[JsonSerializable(typeof(GetAdScriptsResult), TypeInfoPropertyName = "GetAdScriptsResult")]
[JsonSerializable(typeof(AdFrameData), TypeInfoPropertyName = "AdsAdFrameData")]
[JsonSerializable(typeof(AdMetrics), TypeInfoPropertyName = "AdsAdMetrics")]
[JsonSerializable(typeof(AdScript), TypeInfoPropertyName = "AdsAdScript")]
[JsonSerializable(typeof(ImmutableArray<AdScript>), TypeInfoPropertyName = "ImmutableArrayAdsAdScript")]
[JsonSerializable(typeof(ImmutableArray<AdFrameData>), TypeInfoPropertyName = "ImmutableArrayAdsAdFrameData")]
[JsonSerializable(typeof(ImmutableArray<Page.FrameId>), TypeInfoPropertyName = "ImmutableArrayPageFrameId")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class AdsJsonSerializerContext : JsonSerializerContext;

