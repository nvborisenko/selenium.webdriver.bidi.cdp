#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Animation;

/// <summary>
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class AnimationDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static AnimationJsonSerializerContext JsonContext = AnimationJsonSerializerContext.Default;

    /// <summary>
    /// Disables animation domain notifications.
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
    public async Task<DisableResult> DisableAsync(DisableCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync(DisableCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("Animation.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Enables animation domain notifications.
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
    public async Task<EnableResult> EnableAsync(EnableCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters();
        return await ExecuteCommandAsync(EnableCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("Animation.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Returns the current time of the an animation.
    /// </summary>
    /// <param name="id">
    /// Id of animation.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetCurrentTimeCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetCurrentTimeResult"/>.
    /// </returns>
    public async Task<GetCurrentTimeResult> GetCurrentTimeAsync(string id, GetCurrentTimeCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetCurrentTimeCommandParameters(Id: id);
        return await ExecuteCommandAsync(GetCurrentTimeCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetCurrentTimeCommandParameters, GetCurrentTimeResult> GetCurrentTimeCommand = new("Animation.getCurrentTime", JsonContext.GetCurrentTimeCommandParameters, JsonContext.GetCurrentTimeResult);

    /// <summary>
    /// Gets the playback rate of the document timeline.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetPlaybackRateCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetPlaybackRateResult"/>.
    /// </returns>
    public async Task<GetPlaybackRateResult> GetPlaybackRateAsync(GetPlaybackRateCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetPlaybackRateCommandParameters();
        return await ExecuteCommandAsync(GetPlaybackRateCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetPlaybackRateCommandParameters, GetPlaybackRateResult> GetPlaybackRateCommand = new("Animation.getPlaybackRate", JsonContext.GetPlaybackRateCommandParameters, JsonContext.GetPlaybackRateResult);

    /// <summary>
    /// Releases a set of animations to no longer be manipulated.
    /// </summary>
    /// <param name="animations">
    /// List of animation ids to seek.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ReleaseAnimationsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ReleaseAnimationsResult"/>.
    /// </returns>
    public async Task<ReleaseAnimationsResult> ReleaseAnimationsAsync(IEnumerable<string> animations, ReleaseAnimationsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ReleaseAnimationsCommandParameters(Animations: animations);
        return await ExecuteCommandAsync(ReleaseAnimationsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ReleaseAnimationsCommandParameters, ReleaseAnimationsResult> ReleaseAnimationsCommand = new("Animation.releaseAnimations", JsonContext.ReleaseAnimationsCommandParameters, JsonContext.ReleaseAnimationsResult);

    /// <summary>
    /// Gets the remote object of the Animation.
    /// </summary>
    /// <param name="animationId">
    /// Animation id.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ResolveAnimationCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ResolveAnimationResult"/>.
    /// </returns>
    public async Task<ResolveAnimationResult> ResolveAnimationAsync(string animationId, ResolveAnimationCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ResolveAnimationCommandParameters(AnimationId: animationId);
        return await ExecuteCommandAsync(ResolveAnimationCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ResolveAnimationCommandParameters, ResolveAnimationResult> ResolveAnimationCommand = new("Animation.resolveAnimation", JsonContext.ResolveAnimationCommandParameters, JsonContext.ResolveAnimationResult);

    /// <summary>
    /// Seek a set of animations to a particular time within each animation.
    /// </summary>
    /// <param name="animations">
    /// List of animation ids to seek.
    /// </param>
    /// <param name="currentTime">
    /// Set the current time of each animation.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SeekAnimationsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SeekAnimationsResult"/>.
    /// </returns>
    public async Task<SeekAnimationsResult> SeekAnimationsAsync(IEnumerable<string> animations, double currentTime, SeekAnimationsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SeekAnimationsCommandParameters(Animations: animations, CurrentTime: currentTime);
        return await ExecuteCommandAsync(SeekAnimationsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SeekAnimationsCommandParameters, SeekAnimationsResult> SeekAnimationsCommand = new("Animation.seekAnimations", JsonContext.SeekAnimationsCommandParameters, JsonContext.SeekAnimationsResult);

    /// <summary>
    /// Sets the paused state of a set of animations.
    /// </summary>
    /// <param name="animations">
    /// Animations to set the pause state of.
    /// </param>
    /// <param name="paused">
    /// Paused state to set to.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetPausedCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetPausedResult"/>.
    /// </returns>
    public async Task<SetPausedResult> SetPausedAsync(IEnumerable<string> animations, bool paused, SetPausedCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetPausedCommandParameters(Animations: animations, Paused: paused);
        return await ExecuteCommandAsync(SetPausedCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetPausedCommandParameters, SetPausedResult> SetPausedCommand = new("Animation.setPaused", JsonContext.SetPausedCommandParameters, JsonContext.SetPausedResult);

    /// <summary>
    /// Sets the playback rate of the document timeline.
    /// </summary>
    /// <param name="playbackRate">
    /// Playback rate for animations on page
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetPlaybackRateCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetPlaybackRateResult"/>.
    /// </returns>
    public async Task<SetPlaybackRateResult> SetPlaybackRateAsync(double playbackRate, SetPlaybackRateCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetPlaybackRateCommandParameters(PlaybackRate: playbackRate);
        return await ExecuteCommandAsync(SetPlaybackRateCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetPlaybackRateCommandParameters, SetPlaybackRateResult> SetPlaybackRateCommand = new("Animation.setPlaybackRate", JsonContext.SetPlaybackRateCommandParameters, JsonContext.SetPlaybackRateResult);

    /// <summary>
    /// Sets the timing of an animation node.
    /// </summary>
    /// <param name="animationId">
    /// Animation id.
    /// </param>
    /// <param name="duration">
    /// Duration of the animation.
    /// </param>
    /// <param name="delay">
    /// Delay of the animation.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetTimingCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetTimingResult"/>.
    /// </returns>
    public async Task<SetTimingResult> SetTimingAsync(string animationId, double duration, double delay, SetTimingCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetTimingCommandParameters(AnimationId: animationId, Duration: duration, Delay: delay);
        return await ExecuteCommandAsync(SetTimingCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetTimingCommandParameters, SetTimingResult> SetTimingCommand = new("Animation.setTiming", JsonContext.SetTimingCommandParameters, JsonContext.SetTimingResult);

    /// <summary>
    /// Event for when an animation has been cancelled.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="AnimationCanceledEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Id</b> - Id of the animation that was cancelled.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<AnimationCanceledEventArgs> AnimationCanceled => CreateCdpEventSource(AnimationDomainEvent.AnimationCanceled);
    /// <summary>
    /// Event for each animation that has been created.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="AnimationCreatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Id</b> - Id of the animation that was created.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<AnimationCreatedEventArgs> AnimationCreated => CreateCdpEventSource(AnimationDomainEvent.AnimationCreated);
    /// <summary>
    /// Event for animation that has been started.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="AnimationStartedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Animation</b> - Animation that was started.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<AnimationStartedEventArgs> AnimationStarted => CreateCdpEventSource(AnimationDomainEvent.AnimationStarted);
    /// <summary>
    /// Event for animation that has been updated.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="AnimationUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Animation</b> - Animation that was updated.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<AnimationUpdatedEventArgs> AnimationUpdated => CreateCdpEventSource(AnimationDomainEvent.AnimationUpdated);
}

internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="AnimationDomain.DisableAsync"/>.
/// </summary>
public sealed record DisableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="AnimationDomain.EnableAsync"/>.
/// </summary>
public sealed record EnableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record GetCurrentTimeCommandParameters(string Id) : Parameters;

/// <summary>
/// Optional parameters for <see cref="AnimationDomain.GetCurrentTimeAsync"/>.
/// </summary>
public sealed record GetCurrentTimeCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="CurrentTime">
/// Current time of the page.
/// </param>
public sealed record GetCurrentTimeResult(double CurrentTime) : EmptyResult;


internal sealed record GetPlaybackRateCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="AnimationDomain.GetPlaybackRateAsync"/>.
/// </summary>
public sealed record GetPlaybackRateCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="PlaybackRate">
/// Playback rate for animations on page.
/// </param>
public sealed record GetPlaybackRateResult(double PlaybackRate) : EmptyResult;


internal sealed record ReleaseAnimationsCommandParameters(IEnumerable<string> Animations) : Parameters;

/// <summary>
/// Optional parameters for <see cref="AnimationDomain.ReleaseAnimationsAsync"/>.
/// </summary>
public sealed record ReleaseAnimationsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ReleaseAnimationsResult() : EmptyResult;


internal sealed record ResolveAnimationCommandParameters(string AnimationId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="AnimationDomain.ResolveAnimationAsync"/>.
/// </summary>
public sealed record ResolveAnimationCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="RemoteObject">
/// Corresponding remote object.
/// </param>
public sealed record ResolveAnimationResult(Runtime.RemoteObject RemoteObject) : EmptyResult;


internal sealed record SeekAnimationsCommandParameters(IEnumerable<string> Animations, double CurrentTime) : Parameters;

/// <summary>
/// Optional parameters for <see cref="AnimationDomain.SeekAnimationsAsync"/>.
/// </summary>
public sealed record SeekAnimationsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SeekAnimationsResult() : EmptyResult;


internal sealed record SetPausedCommandParameters(IEnumerable<string> Animations, bool Paused) : Parameters;

/// <summary>
/// Optional parameters for <see cref="AnimationDomain.SetPausedAsync"/>.
/// </summary>
public sealed record SetPausedCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetPausedResult() : EmptyResult;


internal sealed record SetPlaybackRateCommandParameters(double PlaybackRate) : Parameters;

/// <summary>
/// Optional parameters for <see cref="AnimationDomain.SetPlaybackRateAsync"/>.
/// </summary>
public sealed record SetPlaybackRateCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetPlaybackRateResult() : EmptyResult;


internal sealed record SetTimingCommandParameters(string AnimationId, double Duration, double Delay) : Parameters;

/// <summary>
/// Optional parameters for <see cref="AnimationDomain.SetTimingAsync"/>.
/// </summary>
public sealed record SetTimingCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetTimingResult() : EmptyResult;


/// <summary>
/// Event for when an animation has been cancelled.
/// </summary>
/// <param name="Id">
/// Id of the animation that was cancelled.
/// </param>
public sealed record AnimationCanceledEventArgs(string Id) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Event for each animation that has been created.
/// </summary>
/// <param name="Id">
/// Id of the animation that was created.
/// </param>
public sealed record AnimationCreatedEventArgs(string Id) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Event for animation that has been started.
/// </summary>
/// <param name="Animation">
/// Animation that was started.
/// </param>
public sealed record AnimationStartedEventArgs(Animation Animation) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Event for animation that has been updated.
/// </summary>
/// <param name="Animation">
/// Animation that was updated.
/// </param>
public sealed record AnimationUpdatedEventArgs(Animation Animation) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Animation instance.
/// </summary>
/// <param name="Id">
/// <b>Animation</b>'s id.
/// </param>
/// <param name="Name">
/// <b>Animation</b>'s name.
/// </param>
/// <param name="PausedState">
/// <b>Animation</b>'s internal paused state.
/// </param>
/// <param name="PlayState">
/// <b>Animation</b>'s play state.
/// </param>
/// <param name="PlaybackRate">
/// <b>Animation</b>'s playback rate.
/// </param>
/// <param name="StartTime">
/// <b>Animation</b>'s start time.
/// Milliseconds for time based animations and
/// percentage [0 - 100] for scroll driven animations
/// (i.e. when viewOrScrollTimeline exists).
/// </param>
/// <param name="CurrentTime">
/// <b>Animation</b>'s current time.
/// </param>
/// <param name="Type">
/// Animation type of <b>Animation</b>.
/// </param>
public sealed record Animation(string Id, string Name, bool PausedState, string PlayState, double PlaybackRate, double StartTime, double CurrentTime, string Type)
{
    /// <summary>
    /// <b>Animation</b>'s source animation node.
    /// </summary>
    public AnimationEffect? Source { get; init; }

    /// <summary>
    /// A unique ID for <b>Animation</b> representing the sources that triggered this CSS
    /// animation/transition.
    /// </summary>
    public string? CssId { get; init; }

    /// <summary>
    /// View or scroll timeline
    /// </summary>
    public ViewOrScrollTimeline? ViewOrScrollTimeline { get; init; }
}

/// <summary>
/// Timeline instance
/// </summary>
/// <param name="Axis">
/// Orientation of the scroll
/// </param>
public sealed record ViewOrScrollTimeline(DOM.ScrollOrientation Axis)
{
    /// <summary>
    /// Scroll container node
    /// </summary>
    public DOM.BackendNodeId? SourceNodeId { get; init; }

    /// <summary>
    /// Represents the starting scroll position of the timeline
    /// as a length offset in pixels from scroll origin.
    /// </summary>
    public double? StartOffset { get; init; }

    /// <summary>
    /// Represents the ending scroll position of the timeline
    /// as a length offset in pixels from scroll origin.
    /// </summary>
    public double? EndOffset { get; init; }

    /// <summary>
    /// The element whose principal box's visibility in the
    /// scrollport defined the progress of the timeline.
    /// Does not exist for animations with ScrollTimeline
    /// </summary>
    public DOM.BackendNodeId? SubjectNodeId { get; init; }
}

/// <summary>
/// AnimationEffect instance
/// </summary>
/// <param name="Delay">
/// <b>AnimationEffect</b>'s delay.
/// </param>
/// <param name="EndDelay">
/// <b>AnimationEffect</b>'s end delay.
/// </param>
/// <param name="IterationStart">
/// <b>AnimationEffect</b>'s iteration start.
/// </param>
/// <param name="Iterations">
/// <b>AnimationEffect</b>'s iterations.
/// </param>
/// <param name="Duration">
/// <b>AnimationEffect</b>'s iteration duration.
/// Milliseconds for time based animations and
/// percentage [0 - 100] for scroll driven animations
/// (i.e. when viewOrScrollTimeline exists).
/// </param>
/// <param name="Direction">
/// <b>AnimationEffect</b>'s playback direction.
/// </param>
/// <param name="Fill">
/// <b>AnimationEffect</b>'s fill mode.
/// </param>
/// <param name="Easing">
/// <b>AnimationEffect</b>'s timing function.
/// </param>
public sealed record AnimationEffect(double Delay, double EndDelay, double IterationStart, double Iterations, double Duration, string Direction, string Fill, string Easing)
{
    /// <summary>
    /// <b>AnimationEffect</b>'s target node.
    /// </summary>
    public DOM.BackendNodeId? BackendNodeId { get; init; }

    /// <summary>
    /// <b>AnimationEffect</b>'s keyframes.
    /// </summary>
    public KeyframesRule? KeyframesRule { get; init; }
}

/// <summary>
/// Keyframes Rule
/// </summary>
/// <param name="Keyframes">
/// List of animation keyframes.
/// </param>
public sealed record KeyframesRule(IReadOnlyList<KeyframeStyle> Keyframes)
{
    /// <summary>
    /// CSS keyframed animation's name.
    /// </summary>
    public string? Name { get; init; }
}

/// <summary>
/// Keyframe Style
/// </summary>
/// <param name="Offset">
/// Keyframe's time offset.
/// </param>
/// <param name="Easing">
/// <b>AnimationEffect</b>'s timing function.
/// </param>
public sealed record KeyframeStyle(string Offset, string Easing)
{
}

[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(GetCurrentTimeCommandParameters), TypeInfoPropertyName = "GetCurrentTimeCommandParameters")]
[JsonSerializable(typeof(GetCurrentTimeResult), TypeInfoPropertyName = "GetCurrentTimeResult")]
[JsonSerializable(typeof(GetPlaybackRateCommandParameters), TypeInfoPropertyName = "GetPlaybackRateCommandParameters")]
[JsonSerializable(typeof(GetPlaybackRateResult), TypeInfoPropertyName = "GetPlaybackRateResult")]
[JsonSerializable(typeof(ReleaseAnimationsCommandParameters), TypeInfoPropertyName = "ReleaseAnimationsCommandParameters")]
[JsonSerializable(typeof(ReleaseAnimationsResult), TypeInfoPropertyName = "ReleaseAnimationsResult")]
[JsonSerializable(typeof(ResolveAnimationCommandParameters), TypeInfoPropertyName = "ResolveAnimationCommandParameters")]
[JsonSerializable(typeof(ResolveAnimationResult), TypeInfoPropertyName = "ResolveAnimationResult")]
[JsonSerializable(typeof(SeekAnimationsCommandParameters), TypeInfoPropertyName = "SeekAnimationsCommandParameters")]
[JsonSerializable(typeof(SeekAnimationsResult), TypeInfoPropertyName = "SeekAnimationsResult")]
[JsonSerializable(typeof(SetPausedCommandParameters), TypeInfoPropertyName = "SetPausedCommandParameters")]
[JsonSerializable(typeof(SetPausedResult), TypeInfoPropertyName = "SetPausedResult")]
[JsonSerializable(typeof(SetPlaybackRateCommandParameters), TypeInfoPropertyName = "SetPlaybackRateCommandParameters")]
[JsonSerializable(typeof(SetPlaybackRateResult), TypeInfoPropertyName = "SetPlaybackRateResult")]
[JsonSerializable(typeof(SetTimingCommandParameters), TypeInfoPropertyName = "SetTimingCommandParameters")]
[JsonSerializable(typeof(SetTimingResult), TypeInfoPropertyName = "SetTimingResult")]
[JsonSerializable(typeof(CdpEventArgs<AnimationCanceledEventArgs>), TypeInfoPropertyName = "AnimationCanceledCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<AnimationCreatedEventArgs>), TypeInfoPropertyName = "AnimationCreatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<AnimationStartedEventArgs>), TypeInfoPropertyName = "AnimationStartedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<AnimationUpdatedEventArgs>), TypeInfoPropertyName = "AnimationUpdatedCdpEventArgs")]
[JsonSerializable(typeof(Animation), TypeInfoPropertyName = "AnimationAnimation")]
[JsonSerializable(typeof(ViewOrScrollTimeline), TypeInfoPropertyName = "AnimationViewOrScrollTimeline")]
[JsonSerializable(typeof(AnimationEffect), TypeInfoPropertyName = "AnimationAnimationEffect")]
[JsonSerializable(typeof(KeyframesRule), TypeInfoPropertyName = "AnimationKeyframesRule")]
[JsonSerializable(typeof(KeyframeStyle), TypeInfoPropertyName = "AnimationKeyframeStyle")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<KeyframeStyle>), TypeInfoPropertyName = "IReadOnlyListAnimationKeyframeStyle")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class AnimationJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="AnimationDomain"/>.
/// </summary>
public static class AnimationDomainEvent
{
    /// <summary>
    /// Event for when an animation has been cancelled.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<AnimationCanceledEventArgs>> AnimationCanceled { get; } =
        EventDescriptor<CdpEventArgs<AnimationCanceledEventArgs>>.Create(
            "goog:cdp.Animation.animationCanceled",
            AnimationJsonSerializerContext.Default.AnimationCanceledCdpEventArgs);

    /// <summary>
    /// Event for each animation that has been created.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<AnimationCreatedEventArgs>> AnimationCreated { get; } =
        EventDescriptor<CdpEventArgs<AnimationCreatedEventArgs>>.Create(
            "goog:cdp.Animation.animationCreated",
            AnimationJsonSerializerContext.Default.AnimationCreatedCdpEventArgs);

    /// <summary>
    /// Event for animation that has been started.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<AnimationStartedEventArgs>> AnimationStarted { get; } =
        EventDescriptor<CdpEventArgs<AnimationStartedEventArgs>>.Create(
            "goog:cdp.Animation.animationStarted",
            AnimationJsonSerializerContext.Default.AnimationStartedCdpEventArgs);

    /// <summary>
    /// Event for animation that has been updated.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<AnimationUpdatedEventArgs>> AnimationUpdated { get; } =
        EventDescriptor<CdpEventArgs<AnimationUpdatedEventArgs>>.Create(
            "goog:cdp.Animation.animationUpdated",
            AnimationJsonSerializerContext.Default.AnimationUpdatedCdpEventArgs);

}
