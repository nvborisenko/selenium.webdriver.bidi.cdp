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
    private static InspectorJsonSerializerContext JsonContext = InspectorJsonSerializerContext.Default;

    public async Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync(DisableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("Inspector.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    public async Task<EnableResult> EnableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters();
        return await ExecuteCommandAsync(EnableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("Inspector.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

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
    public static EventDescriptor<CdpEventArgs<DetachedEventArgs>> Detached { get; } =
        EventDescriptor<CdpEventArgs<DetachedEventArgs>>.Create(
            "goog:cdp.Inspector.detached",
            InspectorJsonSerializerContext.Default.DetachedCdpEventArgs);

    /// <summary>
    /// Fired when debugging target has crashed
    /// </summary>
    public static EventDescriptor<CdpEventArgs<TargetCrashedEventArgs>> TargetCrashed { get; } =
        EventDescriptor<CdpEventArgs<TargetCrashedEventArgs>>.Create(
            "goog:cdp.Inspector.targetCrashed",
            InspectorJsonSerializerContext.Default.TargetCrashedCdpEventArgs);

    /// <summary>
    /// Fired when debugging target has reloaded after crash
    /// </summary>
    public static EventDescriptor<CdpEventArgs<TargetReloadedAfterCrashEventArgs>> TargetReloadedAfterCrash { get; } =
        EventDescriptor<CdpEventArgs<TargetReloadedAfterCrashEventArgs>>.Create(
            "goog:cdp.Inspector.targetReloadedAfterCrash",
            InspectorJsonSerializerContext.Default.TargetReloadedAfterCrashCdpEventArgs);

    /// <summary>
    /// Fired on worker targets when main worker script and any imported scripts have been evaluated.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<WorkerScriptLoadedEventArgs>> WorkerScriptLoaded { get; } =
        EventDescriptor<CdpEventArgs<WorkerScriptLoadedEventArgs>>.Create(
            "goog:cdp.Inspector.workerScriptLoaded",
            InspectorJsonSerializerContext.Default.WorkerScriptLoadedCdpEventArgs);

}
