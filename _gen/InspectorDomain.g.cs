#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Inspector;

/// <summary>
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public interface IInspector
{
    /// <summary>
    /// Disables inspector domain notifications.
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
    /// Enables inspector domain notifications.
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
    /// Fired when remote debugging connection is about to be terminated. Contains detach reason.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DetachedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Reason</b> - The reason why connection has been terminated.</description></item>
    /// </list>
    /// </remarks>
    IEventSource<DetachedEventArgs> Detached { get; }

    /// <summary>
    /// Fired when debugging target has crashed
    /// </summary>
    IEventSource<TargetCrashedEventArgs> TargetCrashed { get; }

    /// <summary>
    /// Fired when debugging target has reloaded after crash
    /// </summary>
    IEventSource<TargetReloadedAfterCrashEventArgs> TargetReloadedAfterCrash { get; }

    /// <summary>
    /// Fired on worker targets when main worker script and any imported scripts have been evaluated.
    /// </summary>
    IEventSource<WorkerScriptLoadedEventArgs> WorkerScriptLoaded { get; }

}

[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
internal sealed class InspectorDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), IInspector
{
    private static readonly InspectorJsonSerializerContext JsonContext = InspectorJsonSerializerContext.Default;

    public async Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        var command = new CdpCommand<DisableCommandParameters, DisableResult>("Inspector.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);
        return await ExecuteCommandAsync(command, @params, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<EnableResult> EnableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters();
        var command = new CdpCommand<EnableCommandParameters, EnableResult>("Inspector.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);
        return await ExecuteCommandAsync(command, @params, session, cancellationToken).ConfigureAwait(false);
    }

    public IEventSource<DetachedEventArgs> Detached => CreateCdpEventSource(InspectorDomainEvent.Detached);
    public IEventSource<TargetCrashedEventArgs> TargetCrashed => CreateCdpEventSource(InspectorDomainEvent.TargetCrashed);
    public IEventSource<TargetReloadedAfterCrashEventArgs> TargetReloadedAfterCrash => CreateCdpEventSource(InspectorDomainEvent.TargetReloadedAfterCrash);
    public IEventSource<WorkerScriptLoadedEventArgs> WorkerScriptLoaded => CreateCdpEventSource(InspectorDomainEvent.WorkerScriptLoaded);
}

internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


/// <summary>
/// Fired when remote debugging connection is about to be terminated. Contains detach reason.
/// </summary>
/// <param name="Reason">
/// The reason why connection has been terminated.
/// </param>
public sealed record DetachedEventArgs(string Reason) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when debugging target has crashed
/// </summary>
public sealed record TargetCrashedEventArgs() : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when debugging target has reloaded after crash
/// </summary>
public sealed record TargetReloadedAfterCrashEventArgs() : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired on worker targets when main worker script and any imported scripts have been evaluated.
/// </summary>
public sealed record WorkerScriptLoadedEventArgs() : OpenQA.Selenium.BiDi.EventArgs;

[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(CdpEventArgs<DetachedEventArgs>), TypeInfoPropertyName = "DetachedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<TargetCrashedEventArgs>), TypeInfoPropertyName = "TargetCrashedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<TargetReloadedAfterCrashEventArgs>), TypeInfoPropertyName = "TargetReloadedAfterCrashCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<WorkerScriptLoadedEventArgs>), TypeInfoPropertyName = "WorkerScriptLoadedCdpEventArgs")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class InspectorJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="IInspector"/>.
/// </summary>
public static class InspectorDomainEvent
{
    /// <summary>
    /// Fired when remote debugging connection is about to be terminated. Contains detach reason.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DetachedEventArgs>> Detached =>
        _detached ?? global::System.Threading.Interlocked.CompareExchange(ref _detached, EventDescriptor<CdpEventArgs<DetachedEventArgs>>.Create(
            "goog:cdp.Inspector.detached",
            InspectorJsonSerializerContext.Default.DetachedCdpEventArgs), null) ?? _detached;
    private static EventDescriptor<CdpEventArgs<DetachedEventArgs>>? _detached;

    /// <summary>
    /// Fired when debugging target has crashed
    /// </summary>
    public static EventDescriptor<CdpEventArgs<TargetCrashedEventArgs>> TargetCrashed =>
        _targetCrashed ?? global::System.Threading.Interlocked.CompareExchange(ref _targetCrashed, EventDescriptor<CdpEventArgs<TargetCrashedEventArgs>>.Create(
            "goog:cdp.Inspector.targetCrashed",
            InspectorJsonSerializerContext.Default.TargetCrashedCdpEventArgs), null) ?? _targetCrashed;
    private static EventDescriptor<CdpEventArgs<TargetCrashedEventArgs>>? _targetCrashed;

    /// <summary>
    /// Fired when debugging target has reloaded after crash
    /// </summary>
    public static EventDescriptor<CdpEventArgs<TargetReloadedAfterCrashEventArgs>> TargetReloadedAfterCrash =>
        _targetReloadedAfterCrash ?? global::System.Threading.Interlocked.CompareExchange(ref _targetReloadedAfterCrash, EventDescriptor<CdpEventArgs<TargetReloadedAfterCrashEventArgs>>.Create(
            "goog:cdp.Inspector.targetReloadedAfterCrash",
            InspectorJsonSerializerContext.Default.TargetReloadedAfterCrashCdpEventArgs), null) ?? _targetReloadedAfterCrash;
    private static EventDescriptor<CdpEventArgs<TargetReloadedAfterCrashEventArgs>>? _targetReloadedAfterCrash;

    /// <summary>
    /// Fired on worker targets when main worker script and any imported scripts have been evaluated.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<WorkerScriptLoadedEventArgs>> WorkerScriptLoaded =>
        _workerScriptLoaded ?? global::System.Threading.Interlocked.CompareExchange(ref _workerScriptLoaded, EventDescriptor<CdpEventArgs<WorkerScriptLoadedEventArgs>>.Create(
            "goog:cdp.Inspector.workerScriptLoaded",
            InspectorJsonSerializerContext.Default.WorkerScriptLoadedCdpEventArgs), null) ?? _workerScriptLoaded;
    private static EventDescriptor<CdpEventArgs<WorkerScriptLoadedEventArgs>>? _workerScriptLoaded;

}
