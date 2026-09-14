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
    Task<ClearResult> ClearAsync(string? session = null, CancellationToken cancellationToken = default);

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
    Task<DisableResult> DisableAsync(string? session = null, CancellationToken cancellationToken = default);

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
    Task<EnableResult> EnableAsync(string? session = null, CancellationToken cancellationToken = default);

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
    Task<StartViolationsReportResult> StartViolationsReportAsync(ImmutableArray<ViolationSetting> config, string? session = null, CancellationToken cancellationToken = default);

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
    Task<StopViolationsReportResult> StopViolationsReportAsync(string? session = null, CancellationToken cancellationToken = default);

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
    private static readonly LogJsonSerializerContext JsonContext = LogJsonSerializerContext.Default;

    public async Task<ClearResult> ClearAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new ClearCommandParameters();
        return await ExecuteCommandAsync("Log.clear", @params, JsonContext.ClearCommandParameters, JsonContext.ClearResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<DisableResult> DisableAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync("Log.disable", @params, JsonContext.DisableCommandParameters, JsonContext.DisableResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<EnableResult> EnableAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters();
        return await ExecuteCommandAsync("Log.enable", @params, JsonContext.EnableCommandParameters, JsonContext.EnableResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<StartViolationsReportResult> StartViolationsReportAsync(ImmutableArray<ViolationSetting> config, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new StartViolationsReportCommandParameters(Config: config);
        return await ExecuteCommandAsync("Log.startViolationsReport", @params, JsonContext.StartViolationsReportCommandParameters, JsonContext.StartViolationsReportResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<StopViolationsReportResult> StopViolationsReportAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new StopViolationsReportCommandParameters();
        return await ExecuteCommandAsync("Log.stopViolationsReport", @params, JsonContext.StopViolationsReportCommandParameters, JsonContext.StopViolationsReportResult, session, cancellationToken).ConfigureAwait(false);
    }

    public IEventSource<EntryAddedEventArgs> EntryAdded => CreateCdpEventSource(LogDomainEvent.EntryAdded);
}

internal sealed record ClearCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="ILog.ClearAsync"/> command.
/// </summary>
public sealed record ClearResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="ILog.DisableAsync"/> command.
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="ILog.EnableAsync"/> command.
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record StartViolationsReportCommandParameters(ImmutableArray<ViolationSetting> Config) : Parameters;

/// <summary>
/// Result of the <see cref="ILog.StartViolationsReportAsync"/> command.
/// </summary>
public sealed record StartViolationsReportResult() : EmptyResult;


internal sealed record StopViolationsReportCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="ILog.StopViolationsReportAsync"/> command.
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
public sealed record LogEntry(LogEntrySource Source, LogEntryLevel Level, string Text, Runtime.Timestamp Timestamp)
{
    /// <summary>
    /// </summary>
    public LogEntryCategory? Category { get; init; }

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
public sealed record ViolationSetting(ViolationSettingName Name, double Threshold)
{
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<LogEntrySource>))]
public enum LogEntrySource
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
    /// Corresponds to the <c>"deprecation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("deprecation")]
    Deprecation,
    /// <summary>
    /// Corresponds to the <c>"worker"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("worker")]
    Worker,
    /// <summary>
    /// Corresponds to the <c>"violation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("violation")]
    Violation,
    /// <summary>
    /// Corresponds to the <c>"intervention"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("intervention")]
    Intervention,
    /// <summary>
    /// Corresponds to the <c>"recommendation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("recommendation")]
    Recommendation,
    /// <summary>
    /// Corresponds to the <c>"other"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("other")]
    Other,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<LogEntryLevel>))]
public enum LogEntryLevel
{
    /// <summary>
    /// Corresponds to the <c>"verbose"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("verbose")]
    Verbose,
    /// <summary>
    /// Corresponds to the <c>"info"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("info")]
    Info,
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
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<LogEntryCategory>))]
public enum LogEntryCategory
{
    /// <summary>
    /// Corresponds to the <c>"cors"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("cors")]
    Cors,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ViolationSettingName>))]
public enum ViolationSettingName
{
    /// <summary>
    /// Corresponds to the <c>"longTask"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("longTask")]
    LongTask,
    /// <summary>
    /// Corresponds to the <c>"longLayout"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("longLayout")]
    LongLayout,
    /// <summary>
    /// Corresponds to the <c>"blockedEvent"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("blockedEvent")]
    BlockedEvent,
    /// <summary>
    /// Corresponds to the <c>"blockedParser"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("blockedParser")]
    BlockedParser,
    /// <summary>
    /// Corresponds to the <c>"discouragedAPIUse"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("discouragedAPIUse")]
    DiscouragedAPIUse,
    /// <summary>
    /// Corresponds to the <c>"handler"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("handler")]
    Handler,
    /// <summary>
    /// Corresponds to the <c>"recurringHandler"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("recurringHandler")]
    RecurringHandler,
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
    public static EventDescriptor<CdpEventArgs<EntryAddedEventArgs>> EntryAdded =>
        _entryAdded ?? global::System.Threading.Interlocked.CompareExchange(ref _entryAdded, EventDescriptor<CdpEventArgs<EntryAddedEventArgs>>.Create(
            "goog:cdp.Log.entryAdded",
            LogJsonSerializerContext.Default.EntryAddedCdpEventArgs), null) ?? _entryAdded;
    private static EventDescriptor<CdpEventArgs<EntryAddedEventArgs>>? _entryAdded;

}
