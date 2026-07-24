#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Ads;

/// <summary>
/// A domain for ad-related metrics and data.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class AdsDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static AdsJsonSerializerContext JsonContext = AdsJsonSerializerContext.Default;

    /// <summary>
    /// Retrieves ad metrics for the current page.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetAdMetricsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetAdMetricsResult"/>.
    /// </returns>
    public async Task<GetAdMetricsResult> GetAdMetricsAsync(GetAdMetricsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetAdMetricsCommandParameters();
        return await ExecuteCommandAsync(GetAdMetricsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetAdMetricsCommandParameters, GetAdMetricsResult> GetAdMetricsCommand = new("Ads.getAdMetrics", JsonContext.GetAdMetricsCommandParameters, JsonContext.GetAdMetricsResult);

}

internal sealed record GetAdMetricsCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="AdsDomain.GetAdMetricsAsync"/>.
/// </summary>
public sealed record GetAdMetricsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Metrics">
/// </param>
public sealed record GetAdMetricsResult(AdMetrics Metrics) : EmptyResult;


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

[JsonSerializable(typeof(GetAdMetricsCommandParameters), TypeInfoPropertyName = "GetAdMetricsCommandParameters")]
[JsonSerializable(typeof(GetAdMetricsResult), TypeInfoPropertyName = "GetAdMetricsResult")]
[JsonSerializable(typeof(AdFrameData), TypeInfoPropertyName = "AdsAdFrameData")]
[JsonSerializable(typeof(AdMetrics), TypeInfoPropertyName = "AdsAdMetrics")]
[JsonSerializable(typeof(ImmutableArray<AdFrameData>), TypeInfoPropertyName = "ImmutableArrayAdsAdFrameData")]
[JsonSerializable(typeof(ImmutableArray<Page.FrameId>), TypeInfoPropertyName = "ImmutableArrayPageFrameId")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class AdsJsonSerializerContext : JsonSerializerContext;

