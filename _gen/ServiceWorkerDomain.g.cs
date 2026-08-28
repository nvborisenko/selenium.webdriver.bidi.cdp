#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.ServiceWorker;

/// <summary>
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public interface IServiceWorker
{
    /// <summary>
    /// </summary>
    /// <param name="origin">
    /// </param>
    /// <param name="registrationId">
    /// </param>
    /// <param name="data">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DeliverPushMessageResult"/>.
    /// </returns>
    Task<DeliverPushMessageResult> DeliverPushMessageAsync(string origin, RegistrationID registrationId, string data, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
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
    /// </summary>
    /// <param name="origin">
    /// </param>
    /// <param name="registrationId">
    /// </param>
    /// <param name="tag">
    /// </param>
    /// <param name="lastChance">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DispatchSyncEventResult"/>.
    /// </returns>
    Task<DispatchSyncEventResult> DispatchSyncEventAsync(string origin, RegistrationID registrationId, string tag, bool lastChance, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <param name="origin">
    /// </param>
    /// <param name="registrationId">
    /// </param>
    /// <param name="tag">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DispatchPeriodicSyncEventResult"/>.
    /// </returns>
    Task<DispatchPeriodicSyncEventResult> DispatchPeriodicSyncEventAsync(string origin, RegistrationID registrationId, string tag, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
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
    /// </summary>
    /// <param name="forceUpdateOnPageLoad">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetForceUpdateOnPageLoadResult"/>.
    /// </returns>
    Task<SetForceUpdateOnPageLoadResult> SetForceUpdateOnPageLoadAsync(bool forceUpdateOnPageLoad, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <param name="scopeURL">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SkipWaitingResult"/>.
    /// </returns>
    Task<SkipWaitingResult> SkipWaitingAsync(string scopeURL, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <param name="scopeURL">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StartWorkerResult"/>.
    /// </returns>
    Task<StartWorkerResult> StartWorkerAsync(string scopeURL, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StopAllWorkersResult"/>.
    /// </returns>
    Task<StopAllWorkersResult> StopAllWorkersAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <param name="versionId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StopWorkerResult"/>.
    /// </returns>
    Task<StopWorkerResult> StopWorkerAsync(string versionId, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <param name="scopeURL">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="UnregisterResult"/>.
    /// </returns>
    Task<UnregisterResult> UnregisterAsync(string scopeURL, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <param name="scopeURL">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="UpdateRegistrationResult"/>.
    /// </returns>
    Task<UpdateRegistrationResult> UpdateRegistrationAsync(string scopeURL, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="WorkerErrorReportedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>ErrorMessage</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<WorkerErrorReportedEventArgs> WorkerErrorReported { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="WorkerRegistrationUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Registrations</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<WorkerRegistrationUpdatedEventArgs> WorkerRegistrationUpdated { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="WorkerVersionUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Versions</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<WorkerVersionUpdatedEventArgs> WorkerVersionUpdated { get; }

}

[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
internal sealed class ServiceWorkerDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), IServiceWorker
{
    private static readonly ServiceWorkerJsonSerializerContext JsonContext = ServiceWorkerJsonSerializerContext.Default;

    public async Task<DeliverPushMessageResult> DeliverPushMessageAsync(string origin, RegistrationID registrationId, string data, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DeliverPushMessageCommandParameters(Origin: origin, RegistrationId: registrationId, Data: data);
        var command = new CdpCommand<DeliverPushMessageCommandParameters, DeliverPushMessageResult>("ServiceWorker.deliverPushMessage", JsonContext.DeliverPushMessageCommandParameters, JsonContext.DeliverPushMessageResult);
        return await ExecuteCommandAsync(command, @params, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        var command = new CdpCommand<DisableCommandParameters, DisableResult>("ServiceWorker.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);
        return await ExecuteCommandAsync(command, @params, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<DispatchSyncEventResult> DispatchSyncEventAsync(string origin, RegistrationID registrationId, string tag, bool lastChance, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DispatchSyncEventCommandParameters(Origin: origin, RegistrationId: registrationId, Tag: tag, LastChance: lastChance);
        var command = new CdpCommand<DispatchSyncEventCommandParameters, DispatchSyncEventResult>("ServiceWorker.dispatchSyncEvent", JsonContext.DispatchSyncEventCommandParameters, JsonContext.DispatchSyncEventResult);
        return await ExecuteCommandAsync(command, @params, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<DispatchPeriodicSyncEventResult> DispatchPeriodicSyncEventAsync(string origin, RegistrationID registrationId, string tag, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DispatchPeriodicSyncEventCommandParameters(Origin: origin, RegistrationId: registrationId, Tag: tag);
        var command = new CdpCommand<DispatchPeriodicSyncEventCommandParameters, DispatchPeriodicSyncEventResult>("ServiceWorker.dispatchPeriodicSyncEvent", JsonContext.DispatchPeriodicSyncEventCommandParameters, JsonContext.DispatchPeriodicSyncEventResult);
        return await ExecuteCommandAsync(command, @params, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<EnableResult> EnableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters();
        var command = new CdpCommand<EnableCommandParameters, EnableResult>("ServiceWorker.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);
        return await ExecuteCommandAsync(command, @params, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<SetForceUpdateOnPageLoadResult> SetForceUpdateOnPageLoadAsync(bool forceUpdateOnPageLoad, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetForceUpdateOnPageLoadCommandParameters(ForceUpdateOnPageLoad: forceUpdateOnPageLoad);
        var command = new CdpCommand<SetForceUpdateOnPageLoadCommandParameters, SetForceUpdateOnPageLoadResult>("ServiceWorker.setForceUpdateOnPageLoad", JsonContext.SetForceUpdateOnPageLoadCommandParameters, JsonContext.SetForceUpdateOnPageLoadResult);
        return await ExecuteCommandAsync(command, @params, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<SkipWaitingResult> SkipWaitingAsync(string scopeURL, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SkipWaitingCommandParameters(ScopeURL: scopeURL);
        var command = new CdpCommand<SkipWaitingCommandParameters, SkipWaitingResult>("ServiceWorker.skipWaiting", JsonContext.SkipWaitingCommandParameters, JsonContext.SkipWaitingResult);
        return await ExecuteCommandAsync(command, @params, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<StartWorkerResult> StartWorkerAsync(string scopeURL, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new StartWorkerCommandParameters(ScopeURL: scopeURL);
        var command = new CdpCommand<StartWorkerCommandParameters, StartWorkerResult>("ServiceWorker.startWorker", JsonContext.StartWorkerCommandParameters, JsonContext.StartWorkerResult);
        return await ExecuteCommandAsync(command, @params, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<StopAllWorkersResult> StopAllWorkersAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new StopAllWorkersCommandParameters();
        var command = new CdpCommand<StopAllWorkersCommandParameters, StopAllWorkersResult>("ServiceWorker.stopAllWorkers", JsonContext.StopAllWorkersCommandParameters, JsonContext.StopAllWorkersResult);
        return await ExecuteCommandAsync(command, @params, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<StopWorkerResult> StopWorkerAsync(string versionId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new StopWorkerCommandParameters(VersionId: versionId);
        var command = new CdpCommand<StopWorkerCommandParameters, StopWorkerResult>("ServiceWorker.stopWorker", JsonContext.StopWorkerCommandParameters, JsonContext.StopWorkerResult);
        return await ExecuteCommandAsync(command, @params, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<UnregisterResult> UnregisterAsync(string scopeURL, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new UnregisterCommandParameters(ScopeURL: scopeURL);
        var command = new CdpCommand<UnregisterCommandParameters, UnregisterResult>("ServiceWorker.unregister", JsonContext.UnregisterCommandParameters, JsonContext.UnregisterResult);
        return await ExecuteCommandAsync(command, @params, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<UpdateRegistrationResult> UpdateRegistrationAsync(string scopeURL, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new UpdateRegistrationCommandParameters(ScopeURL: scopeURL);
        var command = new CdpCommand<UpdateRegistrationCommandParameters, UpdateRegistrationResult>("ServiceWorker.updateRegistration", JsonContext.UpdateRegistrationCommandParameters, JsonContext.UpdateRegistrationResult);
        return await ExecuteCommandAsync(command, @params, session, cancellationToken).ConfigureAwait(false);
    }

    public IEventSource<WorkerErrorReportedEventArgs> WorkerErrorReported => CreateCdpEventSource(ServiceWorkerDomainEvent.WorkerErrorReported);
    public IEventSource<WorkerRegistrationUpdatedEventArgs> WorkerRegistrationUpdated => CreateCdpEventSource(ServiceWorkerDomainEvent.WorkerRegistrationUpdated);
    public IEventSource<WorkerVersionUpdatedEventArgs> WorkerVersionUpdated => CreateCdpEventSource(ServiceWorkerDomainEvent.WorkerVersionUpdated);
}

internal sealed record DeliverPushMessageCommandParameters(string Origin, RegistrationID RegistrationId, string Data) : Parameters;

/// <summary>
/// </summary>
public sealed record DeliverPushMessageResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record DispatchSyncEventCommandParameters(string Origin, RegistrationID RegistrationId, string Tag, bool LastChance) : Parameters;

/// <summary>
/// </summary>
public sealed record DispatchSyncEventResult() : EmptyResult;


internal sealed record DispatchPeriodicSyncEventCommandParameters(string Origin, RegistrationID RegistrationId, string Tag) : Parameters;

/// <summary>
/// </summary>
public sealed record DispatchPeriodicSyncEventResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record SetForceUpdateOnPageLoadCommandParameters(bool ForceUpdateOnPageLoad) : Parameters;

/// <summary>
/// </summary>
public sealed record SetForceUpdateOnPageLoadResult() : EmptyResult;


internal sealed record SkipWaitingCommandParameters(string ScopeURL) : Parameters;

/// <summary>
/// </summary>
public sealed record SkipWaitingResult() : EmptyResult;


internal sealed record StartWorkerCommandParameters(string ScopeURL) : Parameters;

/// <summary>
/// </summary>
public sealed record StartWorkerResult() : EmptyResult;


internal sealed record StopAllWorkersCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record StopAllWorkersResult() : EmptyResult;


internal sealed record StopWorkerCommandParameters(string VersionId) : Parameters;

/// <summary>
/// </summary>
public sealed record StopWorkerResult() : EmptyResult;


internal sealed record UnregisterCommandParameters(string ScopeURL) : Parameters;

/// <summary>
/// </summary>
public sealed record UnregisterResult() : EmptyResult;


internal sealed record UpdateRegistrationCommandParameters(string ScopeURL) : Parameters;

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
[global::System.Text.Json.Serialization.JsonConverter(typeof(RegistrationID.Converter))]
public readonly record struct RegistrationID
{
    internal RegistrationID(string id) => _id = id;

    private readonly string _id;

    internal sealed class Converter : global::System.Text.Json.Serialization.JsonConverter<RegistrationID>
    {
        public override RegistrationID Read(ref global::System.Text.Json.Utf8JsonReader reader, global::System.Type typeToConvert, global::System.Text.Json.JsonSerializerOptions options) => new(reader.GetString()!);

        public override void Write(global::System.Text.Json.Utf8JsonWriter writer, RegistrationID value, global::System.Text.Json.JsonSerializerOptions options) => writer.WriteStringValue(value._id);
    }
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
/// Mostly corresponds to <b>RouterCondition</b> in ServiceWorker spec
/// (https://www.w3.org/TR/service-workers/#dictdef-routercondition) while this
/// currently lacks support for the nested conditions ("or" and "not").
/// TODO(crbug.com/540469610): Support recursive conditions.
/// </summary>
public sealed record ServiceWorkerRouterCondition()
{
    /// <summary>
    /// Plain text, or JSON serialization of URLPatternInit or URLPattern
    /// </summary>
    public string? UrlPattern { get; init; }

    /// <summary>
    /// </summary>
    public string? RequestMethod { get; init; }

    /// <summary>
    /// </summary>
    public string? RequestMode { get; init; }

    /// <summary>
    /// </summary>
    public string? RequestDestination { get; init; }

    /// <summary>
    /// </summary>
    public ServiceWorkerVersionRunningStatus? RunningStatus { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ServiceWorkerRouterSourceType>))]
public enum ServiceWorkerRouterSourceType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("cache")]
    Cache,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("fetchEvent")]
    FetchEvent,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("network")]
    Network,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("raceNetworkAndFetchHandler")]
    RaceNetworkAndFetchHandler,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("raceNetworkAndCache")]
    RaceNetworkAndCache,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("sourceDict")]
    SourceDict,
}

/// <summary>
/// https://www.w3.org/TR/service-workers/#dictdef-routersourcedict
/// </summary>
/// <param name="CacheName">
/// </param>
public sealed record ServiceWorkerRouterSourceDict(string CacheName)
{
}

/// <summary>
/// Corresponds to <b>RouterSource</b> in the spec while the representation is different as follows.
/// (https://www.w3.org/TR/service-workers/#typedefdef-routersource)
/// - <b>RouterSourceEnum</b>: <b>type</b> equals <b>cache</b>, <b>sourceDict</b> is null.
/// - <b>RouterSourceDict</b>: <b>type</b> equals <b>sourceDict</b>, <b>sourceDict</b> has valid value.
/// </summary>
/// <param name="Type">
/// </param>
public sealed record ServiceWorkerRouterSource(ServiceWorkerRouterSourceType Type)
{
    /// <summary>
    /// Non-empty iff <b>type</b> equals "sourceDict".
    /// </summary>
    public ServiceWorkerRouterSourceDict? SourceDict { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Condition">
/// </param>
/// <param name="Source">
/// </param>
/// <param name="Id">
/// Rule ID assigned by the browser. Unique within each ServiceWorkerVersion.
/// </param>
public sealed record ServiceWorkerRouterRule(ServiceWorkerRouterCondition Condition, ServiceWorkerRouterSource Source, long Id)
{
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
    /// Migration to <b>typedRouterRules</b> is in progress. The browser sends either
    /// <b>routerRules</b> or <b>typedRouterRules</b>.
    /// TODO(crbug.com/540469610): Remove <b>routerRules</b> after the migration.
    /// </summary>
    public string? RouterRules { get; init; }

    /// <summary>
    /// </summary>
    public ImmutableArray<ServiceWorkerRouterRule>? TypedRouterRules { get; init; }
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
[JsonSerializable(typeof(ServiceWorkerRouterCondition), TypeInfoPropertyName = "ServiceWorkerServiceWorkerRouterCondition")]
[JsonSerializable(typeof(ServiceWorkerRouterSourceType), TypeInfoPropertyName = "ServiceWorkerServiceWorkerRouterSourceType")]
[JsonSerializable(typeof(ServiceWorkerRouterSourceDict), TypeInfoPropertyName = "ServiceWorkerServiceWorkerRouterSourceDict")]
[JsonSerializable(typeof(ServiceWorkerRouterSource), TypeInfoPropertyName = "ServiceWorkerServiceWorkerRouterSource")]
[JsonSerializable(typeof(ServiceWorkerRouterRule), TypeInfoPropertyName = "ServiceWorkerServiceWorkerRouterRule")]
[JsonSerializable(typeof(ServiceWorkerVersion), TypeInfoPropertyName = "ServiceWorkerServiceWorkerVersion")]
[JsonSerializable(typeof(ServiceWorkerErrorMessage), TypeInfoPropertyName = "ServiceWorkerServiceWorkerErrorMessage")]
[JsonSerializable(typeof(ImmutableArray<ServiceWorkerRegistration>), TypeInfoPropertyName = "ImmutableArrayServiceWorkerServiceWorkerRegistration")]
[JsonSerializable(typeof(ImmutableArray<ServiceWorkerVersion>), TypeInfoPropertyName = "ImmutableArrayServiceWorkerServiceWorkerVersion")]
[JsonSerializable(typeof(ImmutableArray<Target.TargetID>), TypeInfoPropertyName = "ImmutableArrayTargetTargetID")]
[JsonSerializable(typeof(ImmutableArray<ServiceWorkerRouterRule>), TypeInfoPropertyName = "ImmutableArrayServiceWorkerServiceWorkerRouterRule")]
[JsonSerializable(typeof(Target.TargetID?), TypeInfoPropertyName = "NullableTargetTargetID")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class ServiceWorkerJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="IServiceWorker"/>.
/// </summary>
public static class ServiceWorkerDomainEvent
{
    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<WorkerErrorReportedEventArgs>> WorkerErrorReported =>
        _workerErrorReported ?? global::System.Threading.Interlocked.CompareExchange(ref _workerErrorReported, EventDescriptor<CdpEventArgs<WorkerErrorReportedEventArgs>>.Create(
            "goog:cdp.ServiceWorker.workerErrorReported",
            ServiceWorkerJsonSerializerContext.Default.WorkerErrorReportedCdpEventArgs), null) ?? _workerErrorReported;
    private static EventDescriptor<CdpEventArgs<WorkerErrorReportedEventArgs>>? _workerErrorReported;

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<WorkerRegistrationUpdatedEventArgs>> WorkerRegistrationUpdated =>
        _workerRegistrationUpdated ?? global::System.Threading.Interlocked.CompareExchange(ref _workerRegistrationUpdated, EventDescriptor<CdpEventArgs<WorkerRegistrationUpdatedEventArgs>>.Create(
            "goog:cdp.ServiceWorker.workerRegistrationUpdated",
            ServiceWorkerJsonSerializerContext.Default.WorkerRegistrationUpdatedCdpEventArgs), null) ?? _workerRegistrationUpdated;
    private static EventDescriptor<CdpEventArgs<WorkerRegistrationUpdatedEventArgs>>? _workerRegistrationUpdated;

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<WorkerVersionUpdatedEventArgs>> WorkerVersionUpdated =>
        _workerVersionUpdated ?? global::System.Threading.Interlocked.CompareExchange(ref _workerVersionUpdated, EventDescriptor<CdpEventArgs<WorkerVersionUpdatedEventArgs>>.Create(
            "goog:cdp.ServiceWorker.workerVersionUpdated",
            ServiceWorkerJsonSerializerContext.Default.WorkerVersionUpdatedCdpEventArgs), null) ?? _workerVersionUpdated;
    private static EventDescriptor<CdpEventArgs<WorkerVersionUpdatedEventArgs>>? _workerVersionUpdated;

}
