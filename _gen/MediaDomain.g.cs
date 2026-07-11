#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Media;

/// <summary>
/// This domain allows detailed inspection of media elements.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class MediaDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static MediaJsonSerializerContext JsonContext = MediaJsonSerializerContext.Default;

    /// <summary>
    /// Enables the Media domain
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
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("Media.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Disables the Media domain.
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
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("Media.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// This can be called multiple times, and can be used to set / override /
    /// remove player properties. A null propValue indicates removal.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="PlayerPropertiesChangedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>PlayerId</b></description></item>
    /// <item><description><b>Properties</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<PlayerPropertiesChangedEventArgs> PlayerPropertiesChanged => CreateCdpEventSource(MediaDomainEvent.PlayerPropertiesChanged);
    /// <summary>
    /// Send events as a list, allowing them to be batched on the browser for less
    /// congestion. If batched, events must ALWAYS be in chronological order.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="PlayerEventsAddedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>PlayerId</b></description></item>
    /// <item><description><b>Events</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<PlayerEventsAddedEventArgs> PlayerEventsAdded => CreateCdpEventSource(MediaDomainEvent.PlayerEventsAdded);
    /// <summary>
    /// Send a list of any messages that need to be delivered.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="PlayerMessagesLoggedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>PlayerId</b></description></item>
    /// <item><description><b>Messages</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<PlayerMessagesLoggedEventArgs> PlayerMessagesLogged => CreateCdpEventSource(MediaDomainEvent.PlayerMessagesLogged);
    /// <summary>
    /// Send a list of any errors that need to be delivered.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="PlayerErrorsRaisedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>PlayerId</b></description></item>
    /// <item><description><b>Errors</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<PlayerErrorsRaisedEventArgs> PlayerErrorsRaised => CreateCdpEventSource(MediaDomainEvent.PlayerErrorsRaised);
    /// <summary>
    /// Called whenever a player is created, or when a new agent joins and receives
    /// a list of active players. If an agent is restored, it will receive one
    /// event for each active player.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="PlayerCreatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Player</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<PlayerCreatedEventArgs> PlayerCreated => CreateCdpEventSource(MediaDomainEvent.PlayerCreated);
}

internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="MediaDomain.EnableAsync"/>.
/// </summary>
public sealed record EnableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="MediaDomain.DisableAsync"/>.
/// </summary>
public sealed record DisableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


/// <summary>
/// This can be called multiple times, and can be used to set / override /
/// remove player properties. A null propValue indicates removal.
/// </summary>
/// <param name="PlayerId">
/// </param>
/// <param name="Properties">
/// </param>
public sealed record PlayerPropertiesChangedEventArgs(PlayerId PlayerId, IEnumerable<PlayerProperty> Properties) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Send events as a list, allowing them to be batched on the browser for less
/// congestion. If batched, events must ALWAYS be in chronological order.
/// </summary>
/// <param name="PlayerId">
/// </param>
/// <param name="Events">
/// </param>
public sealed record PlayerEventsAddedEventArgs(PlayerId PlayerId, IEnumerable<PlayerEvent> Events) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Send a list of any messages that need to be delivered.
/// </summary>
/// <param name="PlayerId">
/// </param>
/// <param name="Messages">
/// </param>
public sealed record PlayerMessagesLoggedEventArgs(PlayerId PlayerId, IEnumerable<PlayerMessage> Messages) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Send a list of any errors that need to be delivered.
/// </summary>
/// <param name="PlayerId">
/// </param>
/// <param name="Errors">
/// </param>
public sealed record PlayerErrorsRaisedEventArgs(PlayerId PlayerId, IEnumerable<PlayerError> Errors) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Called whenever a player is created, or when a new agent joins and receives
/// a list of active players. If an agent is restored, it will receive one
/// event for each active player.
/// </summary>
/// <param name="Player">
/// </param>
public sealed record PlayerCreatedEventArgs(Player Player) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Players will get an ID that is unique within the agent context.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<PlayerId>))]
public record PlayerId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.NumberRemoteIdConverter<Timestamp>))]
public record Timestamp : INumberRemoteId
{
    double INumberRemoteId.Id { get; init; }
}

/// <summary>
/// Have one type per entry in MediaLogRecord::Type
/// Corresponds to kMessage
/// </summary>
/// <param name="Level">
/// Keep in sync with MediaLogMessageLevel
/// We are currently keeping the message level 'error' separate from the
/// PlayerError type because right now they represent different things,
/// this one being a DVLOG(ERROR) style log message that gets printed
/// based on what log level is selected in the UI, and the other is a
/// representation of a media::PipelineStatus object. Soon however we're
/// going to be moving away from using PipelineStatus for errors and
/// introducing a new error type which should hopefully let us integrate
/// the error log level into the PlayerError type.
/// </param>
/// <param name="Message">
/// </param>
public sealed record PlayerMessage(string Level, string Message)
{
}

/// <summary>
/// Corresponds to kMediaPropertyChange
/// </summary>
/// <param name="Name">
/// </param>
/// <param name="Value">
/// </param>
public sealed record PlayerProperty(string Name, string Value)
{
}

/// <summary>
/// Corresponds to kMediaEventTriggered
/// </summary>
/// <param name="Timestamp">
/// </param>
/// <param name="Value">
/// </param>
public sealed record PlayerEvent(Timestamp Timestamp, string Value)
{
}

/// <summary>
/// Represents logged source line numbers reported in an error.
/// NOTE: file and line are from chromium c++ implementation code, not js.
/// </summary>
/// <param name="File">
/// </param>
/// <param name="Line">
/// </param>
public sealed record PlayerErrorSourceLocation(string File, long Line)
{
}

/// <summary>
/// Corresponds to kMediaError
/// </summary>
/// <param name="ErrorType">
/// </param>
/// <param name="Code">
/// Code is the numeric enum entry for a specific set of error codes, such
/// as PipelineStatusCodes in media/base/pipeline_status.h
/// </param>
/// <param name="Stack">
/// A trace of where this error was caused / where it passed through.
/// </param>
/// <param name="Cause">
/// Errors potentially have a root cause error, ie, a DecoderError might be
/// caused by an WindowsError
/// </param>
/// <param name="Data">
/// Extra data attached to an error, such as an HRESULT, Video Codec, etc.
/// </param>
public sealed record PlayerError(string ErrorType, long Code, IReadOnlyList<PlayerErrorSourceLocation> Stack, IReadOnlyList<PlayerError> Cause, global::System.Text.Json.JsonElement Data)
{
}

/// <summary>
/// </summary>
/// <param name="PlayerId">
/// </param>
public sealed record Player(PlayerId PlayerId)
{
    /// <summary>
    /// </summary>
    public DOM.BackendNodeId? DomNodeId { get; init; }
}

[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(CdpEventArgs<PlayerPropertiesChangedEventArgs>), TypeInfoPropertyName = "PlayerPropertiesChangedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<PlayerEventsAddedEventArgs>), TypeInfoPropertyName = "PlayerEventsAddedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<PlayerMessagesLoggedEventArgs>), TypeInfoPropertyName = "PlayerMessagesLoggedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<PlayerErrorsRaisedEventArgs>), TypeInfoPropertyName = "PlayerErrorsRaisedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<PlayerCreatedEventArgs>), TypeInfoPropertyName = "PlayerCreatedCdpEventArgs")]
[JsonSerializable(typeof(PlayerId), TypeInfoPropertyName = "MediaPlayerId")]
[JsonSerializable(typeof(Timestamp), TypeInfoPropertyName = "MediaTimestamp")]
[JsonSerializable(typeof(PlayerMessage), TypeInfoPropertyName = "MediaPlayerMessage")]
[JsonSerializable(typeof(PlayerProperty), TypeInfoPropertyName = "MediaPlayerProperty")]
[JsonSerializable(typeof(PlayerEvent), TypeInfoPropertyName = "MediaPlayerEvent")]
[JsonSerializable(typeof(PlayerErrorSourceLocation), TypeInfoPropertyName = "MediaPlayerErrorSourceLocation")]
[JsonSerializable(typeof(PlayerError), TypeInfoPropertyName = "MediaPlayerError")]
[JsonSerializable(typeof(Player), TypeInfoPropertyName = "MediaPlayer")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<PlayerProperty>), TypeInfoPropertyName = "IReadOnlyListMediaPlayerProperty")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<PlayerEvent>), TypeInfoPropertyName = "IReadOnlyListMediaPlayerEvent")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<PlayerMessage>), TypeInfoPropertyName = "IReadOnlyListMediaPlayerMessage")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<PlayerError>), TypeInfoPropertyName = "IReadOnlyListMediaPlayerError")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<PlayerErrorSourceLocation>), TypeInfoPropertyName = "IReadOnlyListMediaPlayerErrorSourceLocation")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class MediaJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="MediaDomain"/>.
/// </summary>
public static class MediaDomainEvent
{
    /// <summary>
    /// This can be called multiple times, and can be used to set / override /
    /// remove player properties. A null propValue indicates removal.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<PlayerPropertiesChangedEventArgs>> PlayerPropertiesChanged { get; } =
        EventDescriptor<CdpEventArgs<PlayerPropertiesChangedEventArgs>>.Create(
            "goog:cdp.Media.playerPropertiesChanged",
            MediaJsonSerializerContext.Default.PlayerPropertiesChangedCdpEventArgs);

    /// <summary>
    /// Send events as a list, allowing them to be batched on the browser for less
    /// congestion. If batched, events must ALWAYS be in chronological order.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<PlayerEventsAddedEventArgs>> PlayerEventsAdded { get; } =
        EventDescriptor<CdpEventArgs<PlayerEventsAddedEventArgs>>.Create(
            "goog:cdp.Media.playerEventsAdded",
            MediaJsonSerializerContext.Default.PlayerEventsAddedCdpEventArgs);

    /// <summary>
    /// Send a list of any messages that need to be delivered.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<PlayerMessagesLoggedEventArgs>> PlayerMessagesLogged { get; } =
        EventDescriptor<CdpEventArgs<PlayerMessagesLoggedEventArgs>>.Create(
            "goog:cdp.Media.playerMessagesLogged",
            MediaJsonSerializerContext.Default.PlayerMessagesLoggedCdpEventArgs);

    /// <summary>
    /// Send a list of any errors that need to be delivered.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<PlayerErrorsRaisedEventArgs>> PlayerErrorsRaised { get; } =
        EventDescriptor<CdpEventArgs<PlayerErrorsRaisedEventArgs>>.Create(
            "goog:cdp.Media.playerErrorsRaised",
            MediaJsonSerializerContext.Default.PlayerErrorsRaisedCdpEventArgs);

    /// <summary>
    /// Called whenever a player is created, or when a new agent joins and receives
    /// a list of active players. If an agent is restored, it will receive one
    /// event for each active player.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<PlayerCreatedEventArgs>> PlayerCreated { get; } =
        EventDescriptor<CdpEventArgs<PlayerCreatedEventArgs>>.Create(
            "goog:cdp.Media.playerCreated",
            MediaJsonSerializerContext.Default.PlayerCreatedCdpEventArgs);

}
