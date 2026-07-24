#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Log;

/// <summary>
/// Provides access to log entries.
/// </summary>
public interface ILog
{
    /// <summary>
    /// Clears the log.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearResult"/>.
    /// </returns>
    Task<ClearResult> ClearAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disables log domain, prevents further log entries from being reported to the client.
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
    /// Enables log domain, sends the entries collected so far to the client by means of the
    /// <b>entryAdded</b> notification.
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
    /// start violation reporting.
    /// </summary>
    /// <param name="config">
    /// Configuration for violations.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StartViolationsReportResult"/>.
    /// </returns>
    Task<StartViolationsReportResult> StartViolationsReportAsync(ImmutableArray<ViolationSetting> config, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Stop violation reporting.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StopViolationsReportResult"/>.
    /// </returns>
    Task<StopViolationsReportResult> StopViolationsReportAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Issued when new message was logged.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="EntryAddedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Entry</b> - The entry.</description></item>
    /// </list>
    /// </remarks>
    IEventSource<EntryAddedEventArgs> EntryAdded { get; }

}

internal sealed class LogDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), ILog
{
    private static LogJsonSerializerContext JsonContext = LogJsonSerializerContext.Default;

    public async Task<ClearResult> ClearAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearCommandParameters();
        return await ExecuteCommandAsync(ClearCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearCommandParameters, ClearResult> ClearCommand = new("Log.clear", JsonContext.ClearCommandParameters, JsonContext.ClearResult);

    public async Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync(DisableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("Log.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    public async Task<EnableResult> EnableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters();
        return await ExecuteCommandAsync(EnableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("Log.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    public async Task<StartViolationsReportResult> StartViolationsReportAsync(ImmutableArray<ViolationSetting> config, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new StartViolationsReportCommandParameters(Config: config);
        return await ExecuteCommandAsync(StartViolationsReportCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StartViolationsReportCommandParameters, StartViolationsReportResult> StartViolationsReportCommand = new("Log.startViolationsReport", JsonContext.StartViolationsReportCommandParameters, JsonContext.StartViolationsReportResult);

    public async Task<StopViolationsReportResult> StopViolationsReportAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new StopViolationsReportCommandParameters();
        return await ExecuteCommandAsync(StopViolationsReportCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StopViolationsReportCommandParameters, StopViolationsReportResult> StopViolationsReportCommand = new("Log.stopViolationsReport", JsonContext.StopViolationsReportCommandParameters, JsonContext.StopViolationsReportResult);

    public IEventSource<EntryAddedEventArgs> EntryAdded => CreateCdpEventSource(LogDomainEvent.EntryAdded);
}

internal sealed record ClearCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record ClearResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record StartViolationsReportCommandParameters(ImmutableArray<ViolationSetting> Config) : Parameters;

/// <summary>
/// </summary>
public sealed record StartViolationsReportResult() : EmptyResult;


internal sealed record StopViolationsReportCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record StopViolationsReportResult() : EmptyResult;


/// <summary>
/// Issued when new message was logged.
/// </summary>
/// <param name="Entry">
/// The entry.
/// </param>
public sealed record EntryAddedEventArgs(LogEntry Entry) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Log entry.
/// </summary>
/// <param name="Source">
/// Log entry source.
/// </param>
/// <param name="Level">
/// Log entry severity.
/// </param>
/// <param name="Text">
/// Logged text.
/// </param>
/// <param name="Timestamp">
/// Timestamp when this entry was added.
/// </param>
public sealed record LogEntry(string Source, string Level, string Text, Runtime.Timestamp Timestamp)
{
    /// <summary>
    /// </summary>
    public string? Category { get; init; }

    /// <summary>
    /// URL of the resource if known.
    /// </summary>
    public string? Url { get; init; }

    /// <summary>
    /// Line number in the resource.
    /// </summary>
    public long? LineNumber { get; init; }

    /// <summary>
    /// JavaScript stack trace.
    /// </summary>
    public Runtime.StackTrace? StackTrace { get; init; }

    /// <summary>
    /// Identifier of the network request associated with this entry.
    /// </summary>
    public Network.RequestId? NetworkRequestId { get; init; }

    /// <summary>
    /// Identifier of the worker associated with this entry.
    /// </summary>
    public string? WorkerId { get; init; }

    /// <summary>
    /// Call arguments.
    /// </summary>
    public ImmutableArray<Runtime.RemoteObject>? Args { get; init; }
}

/// <summary>
/// Violation configuration setting.
/// </summary>
/// <param name="Name">
/// Violation type.
/// </param>
/// <param name="Threshold">
/// Time threshold to trigger upon.
/// </param>
public sealed record ViolationSetting(string Name, double Threshold)
{
}

[JsonSerializable(typeof(ClearCommandParameters), TypeInfoPropertyName = "ClearCommandParameters")]
[JsonSerializable(typeof(ClearResult), TypeInfoPropertyName = "ClearResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(StartViolationsReportCommandParameters), TypeInfoPropertyName = "StartViolationsReportCommandParameters")]
[JsonSerializable(typeof(StartViolationsReportResult), TypeInfoPropertyName = "StartViolationsReportResult")]
[JsonSerializable(typeof(StopViolationsReportCommandParameters), TypeInfoPropertyName = "StopViolationsReportCommandParameters")]
[JsonSerializable(typeof(StopViolationsReportResult), TypeInfoPropertyName = "StopViolationsReportResult")]
[JsonSerializable(typeof(CdpEventArgs<EntryAddedEventArgs>), TypeInfoPropertyName = "EntryAddedCdpEventArgs")]
[JsonSerializable(typeof(LogEntry), TypeInfoPropertyName = "LogLogEntry")]
[JsonSerializable(typeof(ViolationSetting), TypeInfoPropertyName = "LogViolationSetting")]
[JsonSerializable(typeof(ImmutableArray<ViolationSetting>), TypeInfoPropertyName = "ImmutableArrayLogViolationSetting")]
[JsonSerializable(typeof(ImmutableArray<Runtime.RemoteObject>), TypeInfoPropertyName = "ImmutableArrayRuntimeRemoteObject")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class LogJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="ILog"/>.
/// </summary>
public static class LogDomainEvent
{
    /// <summary>
    /// Issued when new message was logged.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<EntryAddedEventArgs>> EntryAdded { get; } =
        EventDescriptor<CdpEventArgs<EntryAddedEventArgs>>.Create(
            "goog:cdp.Log.entryAdded",
            LogJsonSerializerContext.Default.EntryAddedCdpEventArgs);

}
