#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.WebAudio;

/// <summary>
/// This domain allows inspection of Web Audio API.
/// https://webaudio.github.io/web-audio-api/
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class WebAudioDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static WebAudioJsonSerializerContext JsonContext = WebAudioJsonSerializerContext.Default;

    /// <summary>
    /// Enables the WebAudio domain and starts sending context lifetime events.
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
    public async Task<EnableResult> EnableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters();
        return await ExecuteCommandAsync(EnableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("WebAudio.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Disables the WebAudio domain.
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
    public async Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync(DisableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("WebAudio.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Fetch the realtime data from the registered contexts.
    /// </summary>
    /// <param name="contextId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetRealtimeDataResult"/>.
    /// </returns>
    public async Task<GetRealtimeDataResult> GetRealtimeDataAsync(GraphObjectId contextId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetRealtimeDataCommandParameters(ContextId: contextId);
        return await ExecuteCommandAsync(GetRealtimeDataCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetRealtimeDataCommandParameters, GetRealtimeDataResult> GetRealtimeDataCommand = new("WebAudio.getRealtimeData", JsonContext.GetRealtimeDataCommandParameters, JsonContext.GetRealtimeDataResult);

    /// <summary>
    /// Notifies that a new BaseAudioContext has been created.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ContextCreatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Context</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ContextCreatedEventArgs> ContextCreated => CreateCdpEventSource(WebAudioDomainEvent.ContextCreated);
    /// <summary>
    /// Notifies that an existing BaseAudioContext will be destroyed.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ContextWillBeDestroyedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>ContextId</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ContextWillBeDestroyedEventArgs> ContextWillBeDestroyed => CreateCdpEventSource(WebAudioDomainEvent.ContextWillBeDestroyed);
    /// <summary>
    /// Notifies that existing BaseAudioContext has changed some properties (id stays the same)..
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ContextChangedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Context</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ContextChangedEventArgs> ContextChanged => CreateCdpEventSource(WebAudioDomainEvent.ContextChanged);
    /// <summary>
    /// Notifies that the construction of an AudioListener has finished.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="AudioListenerCreatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Listener</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<AudioListenerCreatedEventArgs> AudioListenerCreated => CreateCdpEventSource(WebAudioDomainEvent.AudioListenerCreated);
    /// <summary>
    /// Notifies that a new AudioListener has been created.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="AudioListenerWillBeDestroyedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>ContextId</b></description></item>
    /// <item><description><b>ListenerId</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<AudioListenerWillBeDestroyedEventArgs> AudioListenerWillBeDestroyed => CreateCdpEventSource(WebAudioDomainEvent.AudioListenerWillBeDestroyed);
    /// <summary>
    /// Notifies that a new AudioNode has been created.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="AudioNodeCreatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Node</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<AudioNodeCreatedEventArgs> AudioNodeCreated => CreateCdpEventSource(WebAudioDomainEvent.AudioNodeCreated);
    /// <summary>
    /// Notifies that an existing AudioNode has been destroyed.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="AudioNodeWillBeDestroyedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>ContextId</b></description></item>
    /// <item><description><b>NodeId</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<AudioNodeWillBeDestroyedEventArgs> AudioNodeWillBeDestroyed => CreateCdpEventSource(WebAudioDomainEvent.AudioNodeWillBeDestroyed);
    /// <summary>
    /// Notifies that a new AudioParam has been created.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="AudioParamCreatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Param</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<AudioParamCreatedEventArgs> AudioParamCreated => CreateCdpEventSource(WebAudioDomainEvent.AudioParamCreated);
    /// <summary>
    /// Notifies that an existing AudioParam has been destroyed.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="AudioParamWillBeDestroyedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>ContextId</b></description></item>
    /// <item><description><b>NodeId</b></description></item>
    /// <item><description><b>ParamId</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<AudioParamWillBeDestroyedEventArgs> AudioParamWillBeDestroyed => CreateCdpEventSource(WebAudioDomainEvent.AudioParamWillBeDestroyed);
    /// <summary>
    /// Notifies that two AudioNodes are connected.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="NodesConnectedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>ContextId</b></description></item>
    /// <item><description><b>SourceId</b></description></item>
    /// <item><description><b>DestinationId</b></description></item>
    /// <item><description><b>SourceOutputIndex</b></description></item>
    /// <item><description><b>DestinationInputIndex</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<NodesConnectedEventArgs> NodesConnected => CreateCdpEventSource(WebAudioDomainEvent.NodesConnected);
    /// <summary>
    /// Notifies that AudioNodes are disconnected. The destination can be null, and it means all the outgoing connections from the source are disconnected.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="NodesDisconnectedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>ContextId</b></description></item>
    /// <item><description><b>SourceId</b></description></item>
    /// <item><description><b>DestinationId</b></description></item>
    /// <item><description><b>SourceOutputIndex</b></description></item>
    /// <item><description><b>DestinationInputIndex</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<NodesDisconnectedEventArgs> NodesDisconnected => CreateCdpEventSource(WebAudioDomainEvent.NodesDisconnected);
    /// <summary>
    /// Notifies that an AudioNode is connected to an AudioParam.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="NodeParamConnectedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>ContextId</b></description></item>
    /// <item><description><b>SourceId</b></description></item>
    /// <item><description><b>DestinationId</b></description></item>
    /// <item><description><b>SourceOutputIndex</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<NodeParamConnectedEventArgs> NodeParamConnected => CreateCdpEventSource(WebAudioDomainEvent.NodeParamConnected);
    /// <summary>
    /// Notifies that an AudioNode is disconnected to an AudioParam.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="NodeParamDisconnectedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>ContextId</b></description></item>
    /// <item><description><b>SourceId</b></description></item>
    /// <item><description><b>DestinationId</b></description></item>
    /// <item><description><b>SourceOutputIndex</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<NodeParamDisconnectedEventArgs> NodeParamDisconnected => CreateCdpEventSource(WebAudioDomainEvent.NodeParamDisconnected);
}

internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record GetRealtimeDataCommandParameters(GraphObjectId ContextId) : Parameters;

/// <summary>
/// </summary>
/// <param name="RealtimeData">
/// </param>
public sealed record GetRealtimeDataResult(ContextRealtimeData RealtimeData) : EmptyResult;


/// <summary>
/// Notifies that a new BaseAudioContext has been created.
/// </summary>
/// <param name="Context">
/// </param>
public sealed record ContextCreatedEventArgs(BaseAudioContext Context) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Notifies that an existing BaseAudioContext will be destroyed.
/// </summary>
/// <param name="ContextId">
/// </param>
public sealed record ContextWillBeDestroyedEventArgs(GraphObjectId ContextId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Notifies that existing BaseAudioContext has changed some properties (id stays the same)..
/// </summary>
/// <param name="Context">
/// </param>
public sealed record ContextChangedEventArgs(BaseAudioContext Context) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Notifies that the construction of an AudioListener has finished.
/// </summary>
/// <param name="Listener">
/// </param>
public sealed record AudioListenerCreatedEventArgs(AudioListener Listener) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Notifies that a new AudioListener has been created.
/// </summary>
/// <param name="ContextId">
/// </param>
/// <param name="ListenerId">
/// </param>
public sealed record AudioListenerWillBeDestroyedEventArgs(GraphObjectId ContextId, GraphObjectId ListenerId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Notifies that a new AudioNode has been created.
/// </summary>
/// <param name="Node">
/// </param>
public sealed record AudioNodeCreatedEventArgs(AudioNode Node) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Notifies that an existing AudioNode has been destroyed.
/// </summary>
/// <param name="ContextId">
/// </param>
/// <param name="NodeId">
/// </param>
public sealed record AudioNodeWillBeDestroyedEventArgs(GraphObjectId ContextId, GraphObjectId NodeId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Notifies that a new AudioParam has been created.
/// </summary>
/// <param name="Param">
/// </param>
public sealed record AudioParamCreatedEventArgs(AudioParam Param) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Notifies that an existing AudioParam has been destroyed.
/// </summary>
/// <param name="ContextId">
/// </param>
/// <param name="NodeId">
/// </param>
/// <param name="ParamId">
/// </param>
public sealed record AudioParamWillBeDestroyedEventArgs(GraphObjectId ContextId, GraphObjectId NodeId, GraphObjectId ParamId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Notifies that two AudioNodes are connected.
/// </summary>
/// <param name="ContextId">
/// </param>
/// <param name="SourceId">
/// </param>
/// <param name="DestinationId">
/// </param>
/// <param name="SourceOutputIndex">
/// </param>
/// <param name="DestinationInputIndex">
/// </param>
public sealed record NodesConnectedEventArgs(GraphObjectId ContextId, GraphObjectId SourceId, GraphObjectId DestinationId, double? SourceOutputIndex = null, double? DestinationInputIndex = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Notifies that AudioNodes are disconnected. The destination can be null, and it means all the outgoing connections from the source are disconnected.
/// </summary>
/// <param name="ContextId">
/// </param>
/// <param name="SourceId">
/// </param>
/// <param name="DestinationId">
/// </param>
/// <param name="SourceOutputIndex">
/// </param>
/// <param name="DestinationInputIndex">
/// </param>
public sealed record NodesDisconnectedEventArgs(GraphObjectId ContextId, GraphObjectId SourceId, GraphObjectId DestinationId, double? SourceOutputIndex = null, double? DestinationInputIndex = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Notifies that an AudioNode is connected to an AudioParam.
/// </summary>
/// <param name="ContextId">
/// </param>
/// <param name="SourceId">
/// </param>
/// <param name="DestinationId">
/// </param>
/// <param name="SourceOutputIndex">
/// </param>
public sealed record NodeParamConnectedEventArgs(GraphObjectId ContextId, GraphObjectId SourceId, GraphObjectId DestinationId, double? SourceOutputIndex = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Notifies that an AudioNode is disconnected to an AudioParam.
/// </summary>
/// <param name="ContextId">
/// </param>
/// <param name="SourceId">
/// </param>
/// <param name="DestinationId">
/// </param>
/// <param name="SourceOutputIndex">
/// </param>
public sealed record NodeParamDisconnectedEventArgs(GraphObjectId ContextId, GraphObjectId SourceId, GraphObjectId DestinationId, double? SourceOutputIndex = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// An unique ID for a graph object (AudioContext, AudioNode, AudioParam) in Web Audio API
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<GraphObjectId>))]
public record GraphObjectId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Enum of BaseAudioContext types
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ContextType>))]
public enum ContextType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("realtime")]
    Realtime,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("offline")]
    Offline,
}

/// <summary>
/// Enum of AudioContextState from the spec
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ContextState>))]
public enum ContextState
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("suspended")]
    Suspended,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("running")]
    Running,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("closed")]
    Closed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("interrupted")]
    Interrupted,
}

/// <summary>
/// Enum of AudioNode types
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<NodeType>))]
public record NodeType : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Enum of AudioNode::ChannelCountMode from the spec
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ChannelCountMode>))]
public enum ChannelCountMode
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("clamped-max")]
    ClampedMax,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("explicit")]
    Explicit,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("max")]
    Max,
}

/// <summary>
/// Enum of AudioNode::ChannelInterpretation from the spec
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ChannelInterpretation>))]
public enum ChannelInterpretation
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("discrete")]
    Discrete,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("speakers")]
    Speakers,
}

/// <summary>
/// Enum of AudioParam types
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<ParamType>))]
public record ParamType : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Enum of AudioParam::AutomationRate from the spec
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<AutomationRate>))]
public enum AutomationRate
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("a-rate")]
    ARate,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("k-rate")]
    KRate,
}

/// <summary>
/// Fields in AudioContext that change in real-time.
/// </summary>
/// <param name="CurrentTime">
/// The current context time in second in BaseAudioContext.
/// </param>
/// <param name="RenderCapacity">
/// The time spent on rendering graph divided by render quantum duration,
/// and multiplied by 100. 100 means the audio renderer reached the full
/// capacity and glitch may occur.
/// </param>
/// <param name="CallbackIntervalMean">
/// A running mean of callback interval.
/// </param>
/// <param name="CallbackIntervalVariance">
/// A running variance of callback interval.
/// </param>
public sealed record ContextRealtimeData(double CurrentTime, double RenderCapacity, double CallbackIntervalMean, double CallbackIntervalVariance)
{
}

/// <summary>
/// Protocol object for BaseAudioContext
/// </summary>
/// <param name="ContextId">
/// </param>
/// <param name="ContextType">
/// </param>
/// <param name="ContextState">
/// </param>
/// <param name="CallbackBufferSize">
/// Platform-dependent callback buffer size.
/// </param>
/// <param name="MaxOutputChannelCount">
/// Number of output channels supported by audio hardware in use.
/// </param>
/// <param name="SampleRate">
/// Context sample rate.
/// </param>
public sealed record BaseAudioContext(GraphObjectId ContextId, ContextType ContextType, ContextState ContextState, double CallbackBufferSize, double MaxOutputChannelCount, double SampleRate)
{
    /// <summary>
    /// </summary>
    public ContextRealtimeData? RealtimeData { get; init; }
}

/// <summary>
/// Protocol object for AudioListener
/// </summary>
/// <param name="ListenerId">
/// </param>
/// <param name="ContextId">
/// </param>
public sealed record AudioListener(GraphObjectId ListenerId, GraphObjectId ContextId)
{
}

/// <summary>
/// Protocol object for AudioNode
/// </summary>
/// <param name="NodeId">
/// </param>
/// <param name="ContextId">
/// </param>
/// <param name="NodeType">
/// </param>
/// <param name="NumberOfInputs">
/// </param>
/// <param name="NumberOfOutputs">
/// </param>
/// <param name="ChannelCount">
/// </param>
/// <param name="ChannelCountMode">
/// </param>
/// <param name="ChannelInterpretation">
/// </param>
public sealed record AudioNode(GraphObjectId NodeId, GraphObjectId ContextId, NodeType NodeType, double NumberOfInputs, double NumberOfOutputs, double ChannelCount, ChannelCountMode ChannelCountMode, ChannelInterpretation ChannelInterpretation)
{
}

/// <summary>
/// Protocol object for AudioParam
/// </summary>
/// <param name="ParamId">
/// </param>
/// <param name="NodeId">
/// </param>
/// <param name="ContextId">
/// </param>
/// <param name="ParamType">
/// </param>
/// <param name="Rate">
/// </param>
/// <param name="DefaultValue">
/// </param>
/// <param name="MinValue">
/// </param>
/// <param name="MaxValue">
/// </param>
public sealed record AudioParam(GraphObjectId ParamId, GraphObjectId NodeId, GraphObjectId ContextId, ParamType ParamType, AutomationRate Rate, double DefaultValue, double MinValue, double MaxValue)
{
}

[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(GetRealtimeDataCommandParameters), TypeInfoPropertyName = "GetRealtimeDataCommandParameters")]
[JsonSerializable(typeof(GetRealtimeDataResult), TypeInfoPropertyName = "GetRealtimeDataResult")]
[JsonSerializable(typeof(CdpEventArgs<ContextCreatedEventArgs>), TypeInfoPropertyName = "ContextCreatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ContextWillBeDestroyedEventArgs>), TypeInfoPropertyName = "ContextWillBeDestroyedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ContextChangedEventArgs>), TypeInfoPropertyName = "ContextChangedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<AudioListenerCreatedEventArgs>), TypeInfoPropertyName = "AudioListenerCreatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<AudioListenerWillBeDestroyedEventArgs>), TypeInfoPropertyName = "AudioListenerWillBeDestroyedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<AudioNodeCreatedEventArgs>), TypeInfoPropertyName = "AudioNodeCreatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<AudioNodeWillBeDestroyedEventArgs>), TypeInfoPropertyName = "AudioNodeWillBeDestroyedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<AudioParamCreatedEventArgs>), TypeInfoPropertyName = "AudioParamCreatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<AudioParamWillBeDestroyedEventArgs>), TypeInfoPropertyName = "AudioParamWillBeDestroyedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<NodesConnectedEventArgs>), TypeInfoPropertyName = "NodesConnectedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<NodesDisconnectedEventArgs>), TypeInfoPropertyName = "NodesDisconnectedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<NodeParamConnectedEventArgs>), TypeInfoPropertyName = "NodeParamConnectedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<NodeParamDisconnectedEventArgs>), TypeInfoPropertyName = "NodeParamDisconnectedCdpEventArgs")]
[JsonSerializable(typeof(GraphObjectId), TypeInfoPropertyName = "WebAudioGraphObjectId")]
[JsonSerializable(typeof(ContextType), TypeInfoPropertyName = "WebAudioContextType")]
[JsonSerializable(typeof(ContextState), TypeInfoPropertyName = "WebAudioContextState")]
[JsonSerializable(typeof(NodeType), TypeInfoPropertyName = "WebAudioNodeType")]
[JsonSerializable(typeof(ChannelCountMode), TypeInfoPropertyName = "WebAudioChannelCountMode")]
[JsonSerializable(typeof(ChannelInterpretation), TypeInfoPropertyName = "WebAudioChannelInterpretation")]
[JsonSerializable(typeof(ParamType), TypeInfoPropertyName = "WebAudioParamType")]
[JsonSerializable(typeof(AutomationRate), TypeInfoPropertyName = "WebAudioAutomationRate")]
[JsonSerializable(typeof(ContextRealtimeData), TypeInfoPropertyName = "WebAudioContextRealtimeData")]
[JsonSerializable(typeof(BaseAudioContext), TypeInfoPropertyName = "WebAudioBaseAudioContext")]
[JsonSerializable(typeof(AudioListener), TypeInfoPropertyName = "WebAudioAudioListener")]
[JsonSerializable(typeof(AudioNode), TypeInfoPropertyName = "WebAudioAudioNode")]
[JsonSerializable(typeof(AudioParam), TypeInfoPropertyName = "WebAudioAudioParam")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class WebAudioJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="WebAudioDomain"/>.
/// </summary>
public static class WebAudioDomainEvent
{
    /// <summary>
    /// Notifies that a new BaseAudioContext has been created.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ContextCreatedEventArgs>> ContextCreated { get; } =
        EventDescriptor<CdpEventArgs<ContextCreatedEventArgs>>.Create(
            "goog:cdp.WebAudio.contextCreated",
            WebAudioJsonSerializerContext.Default.ContextCreatedCdpEventArgs);

    /// <summary>
    /// Notifies that an existing BaseAudioContext will be destroyed.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ContextWillBeDestroyedEventArgs>> ContextWillBeDestroyed { get; } =
        EventDescriptor<CdpEventArgs<ContextWillBeDestroyedEventArgs>>.Create(
            "goog:cdp.WebAudio.contextWillBeDestroyed",
            WebAudioJsonSerializerContext.Default.ContextWillBeDestroyedCdpEventArgs);

    /// <summary>
    /// Notifies that existing BaseAudioContext has changed some properties (id stays the same)..
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ContextChangedEventArgs>> ContextChanged { get; } =
        EventDescriptor<CdpEventArgs<ContextChangedEventArgs>>.Create(
            "goog:cdp.WebAudio.contextChanged",
            WebAudioJsonSerializerContext.Default.ContextChangedCdpEventArgs);

    /// <summary>
    /// Notifies that the construction of an AudioListener has finished.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<AudioListenerCreatedEventArgs>> AudioListenerCreated { get; } =
        EventDescriptor<CdpEventArgs<AudioListenerCreatedEventArgs>>.Create(
            "goog:cdp.WebAudio.audioListenerCreated",
            WebAudioJsonSerializerContext.Default.AudioListenerCreatedCdpEventArgs);

    /// <summary>
    /// Notifies that a new AudioListener has been created.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<AudioListenerWillBeDestroyedEventArgs>> AudioListenerWillBeDestroyed { get; } =
        EventDescriptor<CdpEventArgs<AudioListenerWillBeDestroyedEventArgs>>.Create(
            "goog:cdp.WebAudio.audioListenerWillBeDestroyed",
            WebAudioJsonSerializerContext.Default.AudioListenerWillBeDestroyedCdpEventArgs);

    /// <summary>
    /// Notifies that a new AudioNode has been created.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<AudioNodeCreatedEventArgs>> AudioNodeCreated { get; } =
        EventDescriptor<CdpEventArgs<AudioNodeCreatedEventArgs>>.Create(
            "goog:cdp.WebAudio.audioNodeCreated",
            WebAudioJsonSerializerContext.Default.AudioNodeCreatedCdpEventArgs);

    /// <summary>
    /// Notifies that an existing AudioNode has been destroyed.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<AudioNodeWillBeDestroyedEventArgs>> AudioNodeWillBeDestroyed { get; } =
        EventDescriptor<CdpEventArgs<AudioNodeWillBeDestroyedEventArgs>>.Create(
            "goog:cdp.WebAudio.audioNodeWillBeDestroyed",
            WebAudioJsonSerializerContext.Default.AudioNodeWillBeDestroyedCdpEventArgs);

    /// <summary>
    /// Notifies that a new AudioParam has been created.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<AudioParamCreatedEventArgs>> AudioParamCreated { get; } =
        EventDescriptor<CdpEventArgs<AudioParamCreatedEventArgs>>.Create(
            "goog:cdp.WebAudio.audioParamCreated",
            WebAudioJsonSerializerContext.Default.AudioParamCreatedCdpEventArgs);

    /// <summary>
    /// Notifies that an existing AudioParam has been destroyed.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<AudioParamWillBeDestroyedEventArgs>> AudioParamWillBeDestroyed { get; } =
        EventDescriptor<CdpEventArgs<AudioParamWillBeDestroyedEventArgs>>.Create(
            "goog:cdp.WebAudio.audioParamWillBeDestroyed",
            WebAudioJsonSerializerContext.Default.AudioParamWillBeDestroyedCdpEventArgs);

    /// <summary>
    /// Notifies that two AudioNodes are connected.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<NodesConnectedEventArgs>> NodesConnected { get; } =
        EventDescriptor<CdpEventArgs<NodesConnectedEventArgs>>.Create(
            "goog:cdp.WebAudio.nodesConnected",
            WebAudioJsonSerializerContext.Default.NodesConnectedCdpEventArgs);

    /// <summary>
    /// Notifies that AudioNodes are disconnected. The destination can be null, and it means all the outgoing connections from the source are disconnected.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<NodesDisconnectedEventArgs>> NodesDisconnected { get; } =
        EventDescriptor<CdpEventArgs<NodesDisconnectedEventArgs>>.Create(
            "goog:cdp.WebAudio.nodesDisconnected",
            WebAudioJsonSerializerContext.Default.NodesDisconnectedCdpEventArgs);

    /// <summary>
    /// Notifies that an AudioNode is connected to an AudioParam.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<NodeParamConnectedEventArgs>> NodeParamConnected { get; } =
        EventDescriptor<CdpEventArgs<NodeParamConnectedEventArgs>>.Create(
            "goog:cdp.WebAudio.nodeParamConnected",
            WebAudioJsonSerializerContext.Default.NodeParamConnectedCdpEventArgs);

    /// <summary>
    /// Notifies that an AudioNode is disconnected to an AudioParam.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<NodeParamDisconnectedEventArgs>> NodeParamDisconnected { get; } =
        EventDescriptor<CdpEventArgs<NodeParamDisconnectedEventArgs>>.Create(
            "goog:cdp.WebAudio.nodeParamDisconnected",
            WebAudioJsonSerializerContext.Default.NodeParamDisconnectedCdpEventArgs);

}
