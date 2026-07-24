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
    Task<ClearMessagesResult> ClearMessagesAsync(string? session = default, CancellationToken cancellationToken = default);

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
    Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default);

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
    Task<EnableResult> EnableAsync(string? session = default, CancellationToken cancellationToken = default);

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
    private static ConsoleJsonSerializerContext JsonContext = ConsoleJsonSerializerContext.Default;

    public async Task<ClearMessagesResult> ClearMessagesAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearMessagesCommandParameters();
        return await ExecuteCommandAsync(ClearMessagesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearMessagesCommandParameters, ClearMessagesResult> ClearMessagesCommand = new("Console.clearMessages", JsonContext.ClearMessagesCommandParameters, JsonContext.ClearMessagesResult);

    public async Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync(DisableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("Console.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    public async Task<EnableResult> EnableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters();
        return await ExecuteCommandAsync(EnableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("Console.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    public IEventSource<MessageAddedEventArgs> MessageAdded => CreateCdpEventSource(ConsoleDomainEvent.MessageAdded);
}

internal sealed record ClearMessagesCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record ClearMessagesResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
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
public sealed record ConsoleMessage(string Source, string Level, string Text)
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
    public static EventDescriptor<CdpEventArgs<MessageAddedEventArgs>> MessageAdded { get; } =
        EventDescriptor<CdpEventArgs<MessageAddedEventArgs>>.Create(
            "goog:cdp.Console.messageAdded",
            ConsoleJsonSerializerContext.Default.MessageAddedCdpEventArgs);

}
