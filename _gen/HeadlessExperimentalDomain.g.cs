#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.HeadlessExperimental;

/// <summary>
/// This domain provides experimental commands only supported in headless mode.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public interface IHeadlessExperimental
{
    /// <summary>
    /// Sends a BeginFrame to the target and returns when the frame was completed. Optionally captures a
    /// screenshot from the resulting frame. Requires that the target was created with enabled
    /// BeginFrameControl. Designed for use with --run-all-compositor-stages-before-draw, see also
    /// https://goo.gle/chrome-headless-rendering for more background.
    /// </summary>
    /// <param name="frameTimeTicks">
    /// Timestamp of this BeginFrame in Renderer TimeTicks (milliseconds of uptime). If not set,
    /// the current time will be used.
    /// </param>
    /// <param name="interval">
    /// The interval between BeginFrames that is reported to the compositor, in milliseconds.
    /// Defaults to a 60 frames/second interval, i.e. about 16.666 milliseconds.
    /// </param>
    /// <param name="noDisplayUpdates">
    /// Whether updates should not be committed and drawn onto the display. False by default. If
    /// true, only side effects of the BeginFrame will be run, such as layout and animations, but
    /// any visual updates may not be visible on the display or in screenshots.
    /// </param>
    /// <param name="screenshot">
    /// If set, a screenshot of the frame will be captured and returned in the response. Otherwise,
    /// no screenshot will be captured. Note that capturing a screenshot can fail, for example,
    /// during renderer initialization. In such a case, no screenshot data will be returned.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="BeginFrameResult"/>.
    /// </returns>
    Task<BeginFrameResult> BeginFrameAsync(double? frameTimeTicks = default, double? interval = default, bool? noDisplayUpdates = default, ScreenshotParams? screenshot = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disables headless events for the target.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DisableResult"/>.
    /// </returns>
    [global::System.Obsolete]
    Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Enables headless events for the target.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="EnableResult"/>.
    /// </returns>
    [global::System.Obsolete]
    Task<EnableResult> EnableAsync(string? session = default, CancellationToken cancellationToken = default);

}

[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
internal sealed class HeadlessExperimentalDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), IHeadlessExperimental
{
    private static HeadlessExperimentalJsonSerializerContext JsonContext = HeadlessExperimentalJsonSerializerContext.Default;

    public async Task<BeginFrameResult> BeginFrameAsync(double? frameTimeTicks = default, double? interval = default, bool? noDisplayUpdates = default, ScreenshotParams? screenshot = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new BeginFrameCommandParameters(FrameTimeTicks: frameTimeTicks, Interval: interval, NoDisplayUpdates: noDisplayUpdates, Screenshot: screenshot);
        return await ExecuteCommandAsync(BeginFrameCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<BeginFrameCommandParameters, BeginFrameResult> BeginFrameCommand = new("HeadlessExperimental.beginFrame", JsonContext.BeginFrameCommandParameters, JsonContext.BeginFrameResult);

    [global::System.Obsolete]
    public async Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync(DisableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("HeadlessExperimental.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    [global::System.Obsolete]
    public async Task<EnableResult> EnableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters();
        return await ExecuteCommandAsync(EnableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("HeadlessExperimental.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

}

internal sealed record BeginFrameCommandParameters(double? FrameTimeTicks, double? Interval, bool? NoDisplayUpdates, ScreenshotParams? Screenshot) : Parameters;

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
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

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

