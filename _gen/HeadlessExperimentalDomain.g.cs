#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.HeadlessExperimental;

/// <summary>
/// This domain provides experimental commands only supported in headless mode.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class HeadlessExperimentalDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static HeadlessExperimentalJsonSerializerContext JsonContext = HeadlessExperimentalJsonSerializerContext.Default;

    /// <summary>
    /// Sends a BeginFrame to the target and returns when the frame was completed. Optionally captures a
    /// screenshot from the resulting frame. Requires that the target was created with enabled
    /// BeginFrameControl. Designed for use with --run-all-compositor-stages-before-draw, see also
    /// https://goo.gle/chrome-headless-rendering for more background.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>FrameTimeTicks</b> - Timestamp of this BeginFrame in Renderer TimeTicks (milliseconds of uptime). If not set, the current time will be used.</description></item>
    /// <item><description><b>Interval</b> - The interval between BeginFrames that is reported to the compositor, in milliseconds. Defaults to a 60 frames/second interval, i.e. about 16.666 milliseconds.</description></item>
    /// <item><description><b>NoDisplayUpdates</b> - Whether updates should not be committed and drawn onto the display. False by default. If true, only side effects of the BeginFrame will be run, such as layout and animations, but any visual updates may not be visible on the display or in screenshots.</description></item>
    /// <item><description><b>Screenshot</b> - If set, a screenshot of the frame will be captured and returned in the response. Otherwise, no screenshot will be captured. Note that capturing a screenshot can fail, for example, during renderer initialization. In such a case, no screenshot data will be returned.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="BeginFrameCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="BeginFrameResult"/>.
    /// </returns>
    public async Task<BeginFrameResult> BeginFrameAsync(BeginFrameCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new BeginFrameCommandParameters(FrameTimeTicks: options?.FrameTimeTicks, Interval: options?.Interval, NoDisplayUpdates: options?.NoDisplayUpdates, Screenshot: options?.Screenshot);
        return await ExecuteCommandAsync(BeginFrameCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<BeginFrameCommandParameters, BeginFrameResult> BeginFrameCommand = new("HeadlessExperimental.beginFrame", JsonContext.BeginFrameCommandParameters, JsonContext.BeginFrameResult);

    /// <summary>
    /// Disables headless events for the target.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="DisableCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DisableResult"/>.
    /// </returns>
    [global::System.Obsolete]
    public async Task<DisableResult> DisableAsync(DisableCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync(DisableCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("HeadlessExperimental.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Enables headless events for the target.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="EnableCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="EnableResult"/>.
    /// </returns>
    [global::System.Obsolete]
    public async Task<EnableResult> EnableAsync(EnableCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters();
        return await ExecuteCommandAsync(EnableCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("HeadlessExperimental.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

}

internal sealed record BeginFrameCommandParameters(double? FrameTimeTicks, double? Interval, bool? NoDisplayUpdates, ScreenshotParams? Screenshot) : Parameters;

/// <summary>
/// Optional parameters for <see cref="HeadlessExperimentalDomain.BeginFrameAsync"/>.
/// </summary>
public sealed record BeginFrameCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Timestamp of this BeginFrame in Renderer TimeTicks (milliseconds of uptime). If not set,
    /// the current time will be used.
    /// </summary>
    public double? FrameTimeTicks { get; init; }

    /// <summary>
    /// The interval between BeginFrames that is reported to the compositor, in milliseconds.
    /// Defaults to a 60 frames/second interval, i.e. about 16.666 milliseconds.
    /// </summary>
    public double? Interval { get; init; }

    /// <summary>
    /// Whether updates should not be committed and drawn onto the display. False by default. If
    /// true, only side effects of the BeginFrame will be run, such as layout and animations, but
    /// any visual updates may not be visible on the display or in screenshots.
    /// </summary>
    public bool? NoDisplayUpdates { get; init; }

    /// <summary>
    /// If set, a screenshot of the frame will be captured and returned in the response. Otherwise,
    /// no screenshot will be captured. Note that capturing a screenshot can fail, for example,
    /// during renderer initialization. In such a case, no screenshot data will be returned.
    /// </summary>
    public ScreenshotParams? Screenshot { get; init; }
}

/// <summary>
/// </summary>
/// <param name="HasDamage">
/// Whether the BeginFrame resulted in damage and, thus, a new frame was committed to the
/// display. Reported for diagnostic uses, may be removed in the future.
/// </param>
/// <param name="ScreenshotData">
/// Base64-encoded image data of the screenshot, if one was requested and successfully taken. (Encoded as a base64 string when passed over JSON)
/// </param>
public sealed record BeginFrameResult(bool HasDamage, string? ScreenshotData) : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="HeadlessExperimentalDomain.DisableAsync"/>.
/// </summary>
public sealed record DisableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="HeadlessExperimentalDomain.EnableAsync"/>.
/// </summary>
public sealed record EnableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


/// <summary>
/// Encoding options for a screenshot.
/// </summary>
public sealed record ScreenshotParams()
{
    /// <summary>
    /// Image compression format (defaults to png).
    /// </summary>
    public string? Format { get; init; }

    /// <summary>
    /// Compression quality from range [0..100] (jpeg and webp only).
    /// </summary>
    public long? Quality { get; init; }

    /// <summary>
    /// Optimize image encoding for speed, not for resulting size (defaults to false)
    /// </summary>
    public bool? OptimizeForSpeed { get; init; }
}

[JsonSerializable(typeof(BeginFrameCommandParameters), TypeInfoPropertyName = "BeginFrameCommandParameters")]
[JsonSerializable(typeof(BeginFrameResult), TypeInfoPropertyName = "BeginFrameResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(ScreenshotParams), TypeInfoPropertyName = "HeadlessExperimentalScreenshotParams")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class HeadlessExperimentalJsonSerializerContext : JsonSerializerContext;

