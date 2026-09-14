#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Console;

/// <summary>
/// This domain is deprecated - use Runtime or Log instead.
/// </summary>
[global::System.Obsolete]
public interface IConsole
{
    /// <summary>
    /// Does nothing.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearMessagesResult"/>.
    /// </returns>
    Task<ClearMessagesResult> ClearMessagesAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disables console domain, prevents further console messages from being reported to the client.
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
    Task<DisableResult> DisableAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Enables console domain, sends the messages collected so far to the client by means of the
    /// <b>messageAdded</b> notification.
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
    Task<EnableResult> EnableAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Issued when new console message is added.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="MessageAddedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Message</b> - Console message that has been added.</description></item>
    /// </list>
    /// </remarks>
    IEventSource<MessageAddedEventArgs> MessageAdded { get; }

}

[global::System.Obsolete]
internal sealed class ConsoleDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), IConsole
{
    private static readonly ConsoleJsonSerializerContext JsonContext = ConsoleJsonSerializerContext.Default;

    public async Task<ClearMessagesResult> ClearMessagesAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new ClearMessagesCommandParameters();
        return await ExecuteCommandAsync("Console.clearMessages", @params, JsonContext.ClearMessagesCommandParameters, JsonContext.ClearMessagesResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<DisableResult> DisableAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync("Console.disable", @params, JsonContext.DisableCommandParameters, JsonContext.DisableResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<EnableResult> EnableAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters();
        return await ExecuteCommandAsync("Console.enable", @params, JsonContext.EnableCommandParameters, JsonContext.EnableResult, session, cancellationToken).ConfigureAwait(false);
    }

    public IEventSource<MessageAddedEventArgs> MessageAdded => CreateCdpEventSource(ConsoleDomainEvent.MessageAdded);
}

internal sealed record ClearMessagesCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IConsole.ClearMessagesAsync"/> command.
/// </summary>
public sealed record ClearMessagesResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IConsole.DisableAsync"/> command.
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IConsole.EnableAsync"/> command.
/// </summary>
public sealed record EnableResult() : EmptyResult;


/// <summary>
/// Issued when new console message is added.
/// </summary>
/// <param name="Message">
/// Console message that has been added.
/// </param>
public sealed record MessageAddedEventArgs(ConsoleMessage Message) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Console message.
/// </summary>
/// <param name="Source">
/// Message source.
/// </param>
/// <param name="Level">
/// Message severity.
/// </param>
/// <param name="Text">
/// Message text.
/// </param>
public sealed record ConsoleMessage(ConsoleMessageSource Source, ConsoleMessageLevel Level, string Text)
{
    /// <summary>
    /// URL of the message origin.
    /// </summary>
    public string? Url { get; init; }

    /// <summary>
    /// Line number in the resource that generated this message (1-based).
    /// </summary>
    public long? Line { get; init; }

    /// <summary>
    /// Column number in the resource that generated this message (1-based).
    /// </summary>
    public long? Column { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ConsoleMessageSource>))]
public enum ConsoleMessageSource
{
    /// <summary>
    /// Corresponds to the <c>"xml"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("xml")]
    Xml,
    /// <summary>
    /// Corresponds to the <c>"javascript"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("javascript")]
    Javascript,
    /// <summary>
    /// Corresponds to the <c>"network"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("network")]
    Network,
    /// <summary>
    /// Corresponds to the <c>"console-api"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("console-api")]
    ConsoleApi,
    /// <summary>
    /// Corresponds to the <c>"storage"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("storage")]
    Storage,
    /// <summary>
    /// Corresponds to the <c>"appcache"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("appcache")]
    Appcache,
    /// <summary>
    /// Corresponds to the <c>"rendering"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("rendering")]
    Rendering,
    /// <summary>
    /// Corresponds to the <c>"security"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("security")]
    Security,
    /// <summary>
    /// Corresponds to the <c>"other"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("other")]
    Other,
    /// <summary>
    /// Corresponds to the <c>"deprecation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("deprecation")]
    Deprecation,
    /// <summary>
    /// Corresponds to the <c>"worker"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("worker")]
    Worker,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ConsoleMessageLevel>))]
public enum ConsoleMessageLevel
{
    /// <summary>
    /// Corresponds to the <c>"log"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("log")]
    Log,
    /// <summary>
    /// Corresponds to the <c>"warning"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("warning")]
    Warning,
    /// <summary>
    /// Corresponds to the <c>"error"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("error")]
    Error,
    /// <summary>
    /// Corresponds to the <c>"debug"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("debug")]
    Debug,
    /// <summary>
    /// Corresponds to the <c>"info"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("info")]
    Info,
}

[JsonSerializable(typeof(ClearMessagesCommandParameters), TypeInfoPropertyName = "ClearMessagesCommandParameters")]
[JsonSerializable(typeof(ClearMessagesResult), TypeInfoPropertyName = "ClearMessagesResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(CdpEventArgs<MessageAddedEventArgs>), TypeInfoPropertyName = "MessageAddedCdpEventArgs")]
[JsonSerializable(typeof(ConsoleMessage), TypeInfoPropertyName = "ConsoleConsoleMessage")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class ConsoleJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="IConsole"/>.
/// </summary>
public static class ConsoleDomainEvent
{
    /// <summary>
    /// Issued when new console message is added.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<MessageAddedEventArgs>> MessageAdded =>
        _messageAdded ?? global::System.Threading.Interlocked.CompareExchange(ref _messageAdded, EventDescriptor<CdpEventArgs<MessageAddedEventArgs>>.Create(
            "goog:cdp.Console.messageAdded",
            ConsoleJsonSerializerContext.Default.MessageAddedCdpEventArgs), null) ?? _messageAdded;
    private static EventDescriptor<CdpEventArgs<MessageAddedEventArgs>>? _messageAdded;

}
