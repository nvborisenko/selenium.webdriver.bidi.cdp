#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.BackgroundService;

/// <summary>
/// Defines events for background web platform features.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public interface IBackgroundService
{
    /// <summary>
    /// Enables event updates for the service.
    /// </summary>
    /// <param name="service">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StartObservingResult"/>.
    /// </returns>
    Task<StartObservingResult> StartObservingAsync(ServiceName service, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disables event updates for the service.
    /// </summary>
    /// <param name="service">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StopObservingResult"/>.
    /// </returns>
    Task<StopObservingResult> StopObservingAsync(ServiceName service, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Set the recording state for the service.
    /// </summary>
    /// <param name="shouldRecord">
    /// </param>
    /// <param name="service">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetRecordingResult"/>.
    /// </returns>
    Task<SetRecordingResult> SetRecordingAsync(bool shouldRecord, ServiceName service, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Clears all stored data for the service.
    /// </summary>
    /// <param name="service">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearEventsResult"/>.
    /// </returns>
    Task<ClearEventsResult> ClearEventsAsync(ServiceName service, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Called when the recording state for the service has been updated.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="RecordingStateChangedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>IsRecording</b></description></item>
    /// <item><description><b>Service</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<RecordingStateChangedEventArgs> RecordingStateChanged { get; }

    /// <summary>
    /// Called with all existing backgroundServiceEvents when enabled, and all new
    /// events afterwards if enabled and recording.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="BackgroundServiceEventReceivedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>BackgroundServiceEvent</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<BackgroundServiceEventReceivedEventArgs> BackgroundServiceEventReceived { get; }

}

[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
internal sealed class BackgroundServiceDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), IBackgroundService
{
    private static BackgroundServiceJsonSerializerContext JsonContext = BackgroundServiceJsonSerializerContext.Default;

    public async Task<StartObservingResult> StartObservingAsync(ServiceName service, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new StartObservingCommandParameters(Service: service);
        return await ExecuteCommandAsync(StartObservingCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StartObservingCommandParameters, StartObservingResult> StartObservingCommand = new("BackgroundService.startObserving", JsonContext.StartObservingCommandParameters, JsonContext.StartObservingResult);

    public async Task<StopObservingResult> StopObservingAsync(ServiceName service, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new StopObservingCommandParameters(Service: service);
        return await ExecuteCommandAsync(StopObservingCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StopObservingCommandParameters, StopObservingResult> StopObservingCommand = new("BackgroundService.stopObserving", JsonContext.StopObservingCommandParameters, JsonContext.StopObservingResult);

    public async Task<SetRecordingResult> SetRecordingAsync(bool shouldRecord, ServiceName service, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetRecordingCommandParameters(ShouldRecord: shouldRecord, Service: service);
        return await ExecuteCommandAsync(SetRecordingCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetRecordingCommandParameters, SetRecordingResult> SetRecordingCommand = new("BackgroundService.setRecording", JsonContext.SetRecordingCommandParameters, JsonContext.SetRecordingResult);

    public async Task<ClearEventsResult> ClearEventsAsync(ServiceName service, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearEventsCommandParameters(Service: service);
        return await ExecuteCommandAsync(ClearEventsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearEventsCommandParameters, ClearEventsResult> ClearEventsCommand = new("BackgroundService.clearEvents", JsonContext.ClearEventsCommandParameters, JsonContext.ClearEventsResult);

    public IEventSource<RecordingStateChangedEventArgs> RecordingStateChanged => CreateCdpEventSource(BackgroundServiceDomainEvent.RecordingStateChanged);
    public IEventSource<BackgroundServiceEventReceivedEventArgs> BackgroundServiceEventReceived => CreateCdpEventSource(BackgroundServiceDomainEvent.BackgroundServiceEventReceived);
}

internal sealed record StartObservingCommandParameters(ServiceName Service) : Parameters;

/// <summary>
/// </summary>
public sealed record StartObservingResult() : EmptyResult;


internal sealed record StopObservingCommandParameters(ServiceName Service) : Parameters;

/// <summary>
/// </summary>
public sealed record StopObservingResult() : EmptyResult;


internal sealed record SetRecordingCommandParameters(bool ShouldRecord, ServiceName Service) : Parameters;

/// <summary>
/// </summary>
public sealed record SetRecordingResult() : EmptyResult;


internal sealed record ClearEventsCommandParameters(ServiceName Service) : Parameters;

/// <summary>
/// </summary>
public sealed record ClearEventsResult() : EmptyResult;


/// <summary>
/// Called when the recording state for the service has been updated.
/// </summary>
/// <param name="IsRecording">
/// </param>
/// <param name="Service">
/// </param>
public sealed record RecordingStateChangedEventArgs(bool IsRecording, ServiceName Service) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Called with all existing backgroundServiceEvents when enabled, and all new
/// events afterwards if enabled and recording.
/// </summary>
/// <param name="BackgroundServiceEvent">
/// </param>
public sealed record BackgroundServiceEventReceivedEventArgs(BackgroundServiceEvent BackgroundServiceEvent) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// The Background Service that will be associated with the commands/events.
/// Every Background Service operates independently, but they share the same
/// API.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ServiceName>))]
public enum ServiceName
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("backgroundFetch")]
    BackgroundFetch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("backgroundSync")]
    BackgroundSync,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("pushMessaging")]
    PushMessaging,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("notifications")]
    Notifications,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("paymentHandler")]
    PaymentHandler,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("periodicBackgroundSync")]
    PeriodicBackgroundSync,
}

/// <summary>
/// A key-value pair for additional event information to pass along.
/// </summary>
/// <param name="Key">
/// </param>
/// <param name="Value">
/// </param>
public sealed record EventMetadata(string Key, string Value)
{
}

/// <summary>
/// </summary>
/// <param name="Timestamp">
/// Timestamp of the event (in seconds).
/// </param>
/// <param name="Origin">
/// The origin this event belongs to.
/// </param>
/// <param name="ServiceWorkerRegistrationId">
/// The Service Worker ID that initiated the event.
/// </param>
/// <param name="Service">
/// The Background Service this event belongs to.
/// </param>
/// <param name="EventName">
/// A description of the event.
/// </param>
/// <param name="InstanceId">
/// An identifier that groups related events together.
/// </param>
/// <param name="EventMetadata">
/// A list of event-specific information.
/// </param>
/// <param name="StorageKey">
/// Storage key this event belongs to.
/// </param>
public sealed record BackgroundServiceEvent(Network.TimeSinceEpoch Timestamp, string Origin, ServiceWorker.RegistrationID ServiceWorkerRegistrationId, ServiceName Service, string EventName, string InstanceId, ImmutableArray<EventMetadata> EventMetadata, string StorageKey)
{
}

[JsonSerializable(typeof(StartObservingCommandParameters), TypeInfoPropertyName = "StartObservingCommandParameters")]
[JsonSerializable(typeof(StartObservingResult), TypeInfoPropertyName = "StartObservingResult")]
[JsonSerializable(typeof(StopObservingCommandParameters), TypeInfoPropertyName = "StopObservingCommandParameters")]
[JsonSerializable(typeof(StopObservingResult), TypeInfoPropertyName = "StopObservingResult")]
[JsonSerializable(typeof(SetRecordingCommandParameters), TypeInfoPropertyName = "SetRecordingCommandParameters")]
[JsonSerializable(typeof(SetRecordingResult), TypeInfoPropertyName = "SetRecordingResult")]
[JsonSerializable(typeof(ClearEventsCommandParameters), TypeInfoPropertyName = "ClearEventsCommandParameters")]
[JsonSerializable(typeof(ClearEventsResult), TypeInfoPropertyName = "ClearEventsResult")]
[JsonSerializable(typeof(CdpEventArgs<RecordingStateChangedEventArgs>), TypeInfoPropertyName = "RecordingStateChangedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<BackgroundServiceEventReceivedEventArgs>), TypeInfoPropertyName = "BackgroundServiceEventReceivedCdpEventArgs")]
[JsonSerializable(typeof(ServiceName), TypeInfoPropertyName = "BackgroundServiceServiceName")]
[JsonSerializable(typeof(EventMetadata), TypeInfoPropertyName = "BackgroundServiceEventMetadata")]
[JsonSerializable(typeof(BackgroundServiceEvent), TypeInfoPropertyName = "BackgroundServiceBackgroundServiceEvent")]
[JsonSerializable(typeof(ImmutableArray<EventMetadata>), TypeInfoPropertyName = "ImmutableArrayBackgroundServiceEventMetadata")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class BackgroundServiceJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="IBackgroundService"/>.
/// </summary>
public static class BackgroundServiceDomainEvent
{
    /// <summary>
    /// Called when the recording state for the service has been updated.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<RecordingStateChangedEventArgs>> RecordingStateChanged { get; } =
        EventDescriptor<CdpEventArgs<RecordingStateChangedEventArgs>>.Create(
            "goog:cdp.BackgroundService.recordingStateChanged",
            BackgroundServiceJsonSerializerContext.Default.RecordingStateChangedCdpEventArgs);

    /// <summary>
    /// Called with all existing backgroundServiceEvents when enabled, and all new
    /// events afterwards if enabled and recording.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<BackgroundServiceEventReceivedEventArgs>> BackgroundServiceEventReceived { get; } =
        EventDescriptor<CdpEventArgs<BackgroundServiceEventReceivedEventArgs>>.Create(
            "goog:cdp.BackgroundService.backgroundServiceEventReceived",
            BackgroundServiceJsonSerializerContext.Default.BackgroundServiceEventReceivedCdpEventArgs);

}
