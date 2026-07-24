#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.ServiceWorker;

/// <summary>
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class ServiceWorkerDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static ServiceWorkerJsonSerializerContext JsonContext = ServiceWorkerJsonSerializerContext.Default;

    /// <summary>
    /// </summary>
    /// <param name="origin">
    /// </param>
    /// <param name="registrationId">
    /// </param>
    /// <param name="data">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="DeliverPushMessageCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DeliverPushMessageResult"/>.
    /// </returns>
    public async Task<DeliverPushMessageResult> DeliverPushMessageAsync(string origin, RegistrationID registrationId, string data, DeliverPushMessageCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new DeliverPushMessageCommandParameters(Origin: origin, RegistrationId: registrationId, Data: data);
        return await ExecuteCommandAsync(DeliverPushMessageCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DeliverPushMessageCommandParameters, DeliverPushMessageResult> DeliverPushMessageCommand = new("ServiceWorker.deliverPushMessage", JsonContext.DeliverPushMessageCommandParameters, JsonContext.DeliverPushMessageResult);

    /// <summary>
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
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("ServiceWorker.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// </summary>
    /// <param name="origin">
    /// </param>
    /// <param name="registrationId">
    /// </param>
    /// <param name="tag">
    /// </param>
    /// <param name="lastChance">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="DispatchSyncEventCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DispatchSyncEventResult"/>.
    /// </returns>
    public async Task<DispatchSyncEventResult> DispatchSyncEventAsync(string origin, RegistrationID registrationId, string tag, bool lastChance, DispatchSyncEventCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new DispatchSyncEventCommandParameters(Origin: origin, RegistrationId: registrationId, Tag: tag, LastChance: lastChance);
        return await ExecuteCommandAsync(DispatchSyncEventCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DispatchSyncEventCommandParameters, DispatchSyncEventResult> DispatchSyncEventCommand = new("ServiceWorker.dispatchSyncEvent", JsonContext.DispatchSyncEventCommandParameters, JsonContext.DispatchSyncEventResult);

    /// <summary>
    /// </summary>
    /// <param name="origin">
    /// </param>
    /// <param name="registrationId">
    /// </param>
    /// <param name="tag">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="DispatchPeriodicSyncEventCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DispatchPeriodicSyncEventResult"/>.
    /// </returns>
    public async Task<DispatchPeriodicSyncEventResult> DispatchPeriodicSyncEventAsync(string origin, RegistrationID registrationId, string tag, DispatchPeriodicSyncEventCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new DispatchPeriodicSyncEventCommandParameters(Origin: origin, RegistrationId: registrationId, Tag: tag);
        return await ExecuteCommandAsync(DispatchPeriodicSyncEventCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DispatchPeriodicSyncEventCommandParameters, DispatchPeriodicSyncEventResult> DispatchPeriodicSyncEventCommand = new("ServiceWorker.dispatchPeriodicSyncEvent", JsonContext.DispatchPeriodicSyncEventCommandParameters, JsonContext.DispatchPeriodicSyncEventResult);

    /// <summary>
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
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("ServiceWorker.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// </summary>
    /// <param name="forceUpdateOnPageLoad">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetForceUpdateOnPageLoadCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetForceUpdateOnPageLoadResult"/>.
    /// </returns>
    public async Task<SetForceUpdateOnPageLoadResult> SetForceUpdateOnPageLoadAsync(bool forceUpdateOnPageLoad, SetForceUpdateOnPageLoadCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetForceUpdateOnPageLoadCommandParameters(ForceUpdateOnPageLoad: forceUpdateOnPageLoad);
        return await ExecuteCommandAsync(SetForceUpdateOnPageLoadCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetForceUpdateOnPageLoadCommandParameters, SetForceUpdateOnPageLoadResult> SetForceUpdateOnPageLoadCommand = new("ServiceWorker.setForceUpdateOnPageLoad", JsonContext.SetForceUpdateOnPageLoadCommandParameters, JsonContext.SetForceUpdateOnPageLoadResult);

    /// <summary>
    /// </summary>
    /// <param name="scopeURL">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SkipWaitingCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SkipWaitingResult"/>.
    /// </returns>
    public async Task<SkipWaitingResult> SkipWaitingAsync(string scopeURL, SkipWaitingCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SkipWaitingCommandParameters(ScopeURL: scopeURL);
        return await ExecuteCommandAsync(SkipWaitingCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SkipWaitingCommandParameters, SkipWaitingResult> SkipWaitingCommand = new("ServiceWorker.skipWaiting", JsonContext.SkipWaitingCommandParameters, JsonContext.SkipWaitingResult);

    /// <summary>
    /// </summary>
    /// <param name="scopeURL">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="StartWorkerCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StartWorkerResult"/>.
    /// </returns>
    public async Task<StartWorkerResult> StartWorkerAsync(string scopeURL, StartWorkerCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new StartWorkerCommandParameters(ScopeURL: scopeURL);
        return await ExecuteCommandAsync(StartWorkerCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StartWorkerCommandParameters, StartWorkerResult> StartWorkerCommand = new("ServiceWorker.startWorker", JsonContext.StartWorkerCommandParameters, JsonContext.StartWorkerResult);

    /// <summary>
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="StopAllWorkersCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StopAllWorkersResult"/>.
    /// </returns>
    public async Task<StopAllWorkersResult> StopAllWorkersAsync(StopAllWorkersCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new StopAllWorkersCommandParameters();
        return await ExecuteCommandAsync(StopAllWorkersCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StopAllWorkersCommandParameters, StopAllWorkersResult> StopAllWorkersCommand = new("ServiceWorker.stopAllWorkers", JsonContext.StopAllWorkersCommandParameters, JsonContext.StopAllWorkersResult);

    /// <summary>
    /// </summary>
    /// <param name="versionId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="StopWorkerCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StopWorkerResult"/>.
    /// </returns>
    public async Task<StopWorkerResult> StopWorkerAsync(string versionId, StopWorkerCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new StopWorkerCommandParameters(VersionId: versionId);
        return await ExecuteCommandAsync(StopWorkerCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StopWorkerCommandParameters, StopWorkerResult> StopWorkerCommand = new("ServiceWorker.stopWorker", JsonContext.StopWorkerCommandParameters, JsonContext.StopWorkerResult);

    /// <summary>
    /// </summary>
    /// <param name="scopeURL">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="UnregisterCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="UnregisterResult"/>.
    /// </returns>
    public async Task<UnregisterResult> UnregisterAsync(string scopeURL, UnregisterCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new UnregisterCommandParameters(ScopeURL: scopeURL);
        return await ExecuteCommandAsync(UnregisterCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<UnregisterCommandParameters, UnregisterResult> UnregisterCommand = new("ServiceWorker.unregister", JsonContext.UnregisterCommandParameters, JsonContext.UnregisterResult);

    /// <summary>
    /// </summary>
    /// <param name="scopeURL">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="UpdateRegistrationCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="UpdateRegistrationResult"/>.
    /// </returns>
    public async Task<UpdateRegistrationResult> UpdateRegistrationAsync(string scopeURL, UpdateRegistrationCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new UpdateRegistrationCommandParameters(ScopeURL: scopeURL);
        return await ExecuteCommandAsync(UpdateRegistrationCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<UpdateRegistrationCommandParameters, UpdateRegistrationResult> UpdateRegistrationCommand = new("ServiceWorker.updateRegistration", JsonContext.UpdateRegistrationCommandParameters, JsonContext.UpdateRegistrationResult);

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="WorkerErrorReportedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>ErrorMessage</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<WorkerErrorReportedEventArgs> WorkerErrorReported => CreateCdpEventSource(ServiceWorkerDomainEvent.WorkerErrorReported);
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="WorkerRegistrationUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Registrations</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<WorkerRegistrationUpdatedEventArgs> WorkerRegistrationUpdated => CreateCdpEventSource(ServiceWorkerDomainEvent.WorkerRegistrationUpdated);
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="WorkerVersionUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Versions</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<WorkerVersionUpdatedEventArgs> WorkerVersionUpdated => CreateCdpEventSource(ServiceWorkerDomainEvent.WorkerVersionUpdated);
}

internal sealed record DeliverPushMessageCommandParameters(string Origin, RegistrationID RegistrationId, string Data) : Parameters;

/// <summary>
/// Optional parameters for <see cref="ServiceWorkerDomain.DeliverPushMessageAsync"/>.
/// </summary>
public sealed record DeliverPushMessageCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DeliverPushMessageResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="ServiceWorkerDomain.DisableAsync"/>.
/// </summary>
public sealed record DisableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record DispatchSyncEventCommandParameters(string Origin, RegistrationID RegistrationId, string Tag, bool LastChance) : Parameters;

/// <summary>
/// Optional parameters for <see cref="ServiceWorkerDomain.DispatchSyncEventAsync"/>.
/// </summary>
public sealed record DispatchSyncEventCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DispatchSyncEventResult() : EmptyResult;


internal sealed record DispatchPeriodicSyncEventCommandParameters(string Origin, RegistrationID RegistrationId, string Tag) : Parameters;

/// <summary>
/// Optional parameters for <see cref="ServiceWorkerDomain.DispatchPeriodicSyncEventAsync"/>.
/// </summary>
public sealed record DispatchPeriodicSyncEventCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DispatchPeriodicSyncEventResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="ServiceWorkerDomain.EnableAsync"/>.
/// </summary>
public sealed record EnableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record SetForceUpdateOnPageLoadCommandParameters(bool ForceUpdateOnPageLoad) : Parameters;

/// <summary>
/// Optional parameters for <see cref="ServiceWorkerDomain.SetForceUpdateOnPageLoadAsync"/>.
/// </summary>
public sealed record SetForceUpdateOnPageLoadCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetForceUpdateOnPageLoadResult() : EmptyResult;


internal sealed record SkipWaitingCommandParameters(string ScopeURL) : Parameters;

/// <summary>
/// Optional parameters for <see cref="ServiceWorkerDomain.SkipWaitingAsync"/>.
/// </summary>
public sealed record SkipWaitingCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SkipWaitingResult() : EmptyResult;


internal sealed record StartWorkerCommandParameters(string ScopeURL) : Parameters;

/// <summary>
/// Optional parameters for <see cref="ServiceWorkerDomain.StartWorkerAsync"/>.
/// </summary>
public sealed record StartWorkerCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record StartWorkerResult() : EmptyResult;


internal sealed record StopAllWorkersCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="ServiceWorkerDomain.StopAllWorkersAsync"/>.
/// </summary>
public sealed record StopAllWorkersCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record StopAllWorkersResult() : EmptyResult;


internal sealed record StopWorkerCommandParameters(string VersionId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="ServiceWorkerDomain.StopWorkerAsync"/>.
/// </summary>
public sealed record StopWorkerCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record StopWorkerResult() : EmptyResult;


internal sealed record UnregisterCommandParameters(string ScopeURL) : Parameters;

/// <summary>
/// Optional parameters for <see cref="ServiceWorkerDomain.UnregisterAsync"/>.
/// </summary>
public sealed record UnregisterCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record UnregisterResult() : EmptyResult;


internal sealed record UpdateRegistrationCommandParameters(string ScopeURL) : Parameters;

/// <summary>
/// Optional parameters for <see cref="ServiceWorkerDomain.UpdateRegistrationAsync"/>.
/// </summary>
public sealed record UpdateRegistrationCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record UpdateRegistrationResult() : EmptyResult;


/// <summary>
/// </summary>
/// <param name="ErrorMessage">
/// </param>
public sealed record WorkerErrorReportedEventArgs(ServiceWorkerErrorMessage ErrorMessage) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
/// <param name="Registrations">
/// </param>
public sealed record WorkerRegistrationUpdatedEventArgs(ImmutableArray<ServiceWorkerRegistration> Registrations) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
/// <param name="Versions">
/// </param>
public sealed record WorkerVersionUpdatedEventArgs(ImmutableArray<ServiceWorkerVersion> Versions) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<RegistrationID>))]
public record RegistrationID : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// ServiceWorker registration.
/// </summary>
/// <param name="RegistrationId">
/// </param>
/// <param name="ScopeURL">
/// </param>
/// <param name="IsDeleted">
/// </param>
public sealed record ServiceWorkerRegistration(RegistrationID RegistrationId, string ScopeURL, bool IsDeleted)
{
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ServiceWorkerVersionRunningStatus>))]
public enum ServiceWorkerVersionRunningStatus
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("stopped")]
    Stopped,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("starting")]
    Starting,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("running")]
    Running,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("stopping")]
    Stopping,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ServiceWorkerVersionStatus>))]
public enum ServiceWorkerVersionStatus
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("new")]
    New,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("installing")]
    Installing,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("installed")]
    Installed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("activating")]
    Activating,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("activated")]
    Activated,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("redundant")]
    Redundant,
}

/// <summary>
/// ServiceWorker version.
/// </summary>
/// <param name="VersionId">
/// </param>
/// <param name="RegistrationId">
/// </param>
/// <param name="ScriptURL">
/// </param>
/// <param name="RunningStatus">
/// </param>
/// <param name="Status">
/// </param>
public sealed record ServiceWorkerVersion(string VersionId, RegistrationID RegistrationId, string ScriptURL, ServiceWorkerVersionRunningStatus RunningStatus, ServiceWorkerVersionStatus Status)
{
    /// <summary>
    /// The Last-Modified header value of the main script.
    /// </summary>
    public double? ScriptLastModified { get; init; }

    /// <summary>
    /// The time at which the response headers of the main script were received from the server.
    /// For cached script it is the last time the cache entry was validated.
    /// </summary>
    public double? ScriptResponseTime { get; init; }

    /// <summary>
    /// </summary>
    public ImmutableArray<Target.TargetID>? ControlledClients { get; init; }

    /// <summary>
    /// </summary>
    public Target.TargetID? TargetId { get; init; }

    /// <summary>
    /// </summary>
    public string? RouterRules { get; init; }
}

/// <summary>
/// ServiceWorker error message.
/// </summary>
/// <param name="ErrorMessage">
/// </param>
/// <param name="RegistrationId">
/// </param>
/// <param name="VersionId">
/// </param>
/// <param name="SourceURL">
/// </param>
/// <param name="LineNumber">
/// </param>
/// <param name="ColumnNumber">
/// </param>
public sealed record ServiceWorkerErrorMessage(string ErrorMessage, RegistrationID RegistrationId, string VersionId, string SourceURL, long LineNumber, long ColumnNumber)
{
}

[JsonSerializable(typeof(DeliverPushMessageCommandParameters), TypeInfoPropertyName = "DeliverPushMessageCommandParameters")]
[JsonSerializable(typeof(DeliverPushMessageResult), TypeInfoPropertyName = "DeliverPushMessageResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(DispatchSyncEventCommandParameters), TypeInfoPropertyName = "DispatchSyncEventCommandParameters")]
[JsonSerializable(typeof(DispatchSyncEventResult), TypeInfoPropertyName = "DispatchSyncEventResult")]
[JsonSerializable(typeof(DispatchPeriodicSyncEventCommandParameters), TypeInfoPropertyName = "DispatchPeriodicSyncEventCommandParameters")]
[JsonSerializable(typeof(DispatchPeriodicSyncEventResult), TypeInfoPropertyName = "DispatchPeriodicSyncEventResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(SetForceUpdateOnPageLoadCommandParameters), TypeInfoPropertyName = "SetForceUpdateOnPageLoadCommandParameters")]
[JsonSerializable(typeof(SetForceUpdateOnPageLoadResult), TypeInfoPropertyName = "SetForceUpdateOnPageLoadResult")]
[JsonSerializable(typeof(SkipWaitingCommandParameters), TypeInfoPropertyName = "SkipWaitingCommandParameters")]
[JsonSerializable(typeof(SkipWaitingResult), TypeInfoPropertyName = "SkipWaitingResult")]
[JsonSerializable(typeof(StartWorkerCommandParameters), TypeInfoPropertyName = "StartWorkerCommandParameters")]
[JsonSerializable(typeof(StartWorkerResult), TypeInfoPropertyName = "StartWorkerResult")]
[JsonSerializable(typeof(StopAllWorkersCommandParameters), TypeInfoPropertyName = "StopAllWorkersCommandParameters")]
[JsonSerializable(typeof(StopAllWorkersResult), TypeInfoPropertyName = "StopAllWorkersResult")]
[JsonSerializable(typeof(StopWorkerCommandParameters), TypeInfoPropertyName = "StopWorkerCommandParameters")]
[JsonSerializable(typeof(StopWorkerResult), TypeInfoPropertyName = "StopWorkerResult")]
[JsonSerializable(typeof(UnregisterCommandParameters), TypeInfoPropertyName = "UnregisterCommandParameters")]
[JsonSerializable(typeof(UnregisterResult), TypeInfoPropertyName = "UnregisterResult")]
[JsonSerializable(typeof(UpdateRegistrationCommandParameters), TypeInfoPropertyName = "UpdateRegistrationCommandParameters")]
[JsonSerializable(typeof(UpdateRegistrationResult), TypeInfoPropertyName = "UpdateRegistrationResult")]
[JsonSerializable(typeof(CdpEventArgs<WorkerErrorReportedEventArgs>), TypeInfoPropertyName = "WorkerErrorReportedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<WorkerRegistrationUpdatedEventArgs>), TypeInfoPropertyName = "WorkerRegistrationUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<WorkerVersionUpdatedEventArgs>), TypeInfoPropertyName = "WorkerVersionUpdatedCdpEventArgs")]
[JsonSerializable(typeof(RegistrationID), TypeInfoPropertyName = "ServiceWorkerRegistrationID")]
[JsonSerializable(typeof(ServiceWorkerRegistration), TypeInfoPropertyName = "ServiceWorkerServiceWorkerRegistration")]
[JsonSerializable(typeof(ServiceWorkerVersionRunningStatus), TypeInfoPropertyName = "ServiceWorkerServiceWorkerVersionRunningStatus")]
[JsonSerializable(typeof(ServiceWorkerVersionStatus), TypeInfoPropertyName = "ServiceWorkerServiceWorkerVersionStatus")]
[JsonSerializable(typeof(ServiceWorkerVersion), TypeInfoPropertyName = "ServiceWorkerServiceWorkerVersion")]
[JsonSerializable(typeof(ServiceWorkerErrorMessage), TypeInfoPropertyName = "ServiceWorkerServiceWorkerErrorMessage")]
[JsonSerializable(typeof(ImmutableArray<ServiceWorkerRegistration>), TypeInfoPropertyName = "ImmutableArrayServiceWorkerServiceWorkerRegistration")]
[JsonSerializable(typeof(ImmutableArray<ServiceWorkerVersion>), TypeInfoPropertyName = "ImmutableArrayServiceWorkerServiceWorkerVersion")]
[JsonSerializable(typeof(ImmutableArray<Target.TargetID>), TypeInfoPropertyName = "ImmutableArrayTargetTargetID")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class ServiceWorkerJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="ServiceWorkerDomain"/>.
/// </summary>
public static class ServiceWorkerDomainEvent
{
    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<WorkerErrorReportedEventArgs>> WorkerErrorReported { get; } =
        EventDescriptor<CdpEventArgs<WorkerErrorReportedEventArgs>>.Create(
            "goog:cdp.ServiceWorker.workerErrorReported",
            ServiceWorkerJsonSerializerContext.Default.WorkerErrorReportedCdpEventArgs);

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<WorkerRegistrationUpdatedEventArgs>> WorkerRegistrationUpdated { get; } =
        EventDescriptor<CdpEventArgs<WorkerRegistrationUpdatedEventArgs>>.Create(
            "goog:cdp.ServiceWorker.workerRegistrationUpdated",
            ServiceWorkerJsonSerializerContext.Default.WorkerRegistrationUpdatedCdpEventArgs);

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<WorkerVersionUpdatedEventArgs>> WorkerVersionUpdated { get; } =
        EventDescriptor<CdpEventArgs<WorkerVersionUpdatedEventArgs>>.Create(
            "goog:cdp.ServiceWorker.workerVersionUpdated",
            ServiceWorkerJsonSerializerContext.Default.WorkerVersionUpdatedCdpEventArgs);

}
