#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.DOMDebugger;

/// <summary>
/// DOM debugging allows setting breakpoints on particular DOM operations and events. JavaScript
/// execution will stop on these operations as if there was a regular breakpoint set.
/// </summary>
public sealed class DOMDebuggerDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static DOMDebuggerJsonSerializerContext JsonContext = DOMDebuggerJsonSerializerContext.Default;

    /// <summary>
    /// Returns event listeners of the given object.
    /// </summary>
    /// <param name="objectId">
    /// Identifier of the object to return listeners for.
    /// </param>
    /// <param name="depth">
    /// The maximum depth at which Node children should be retrieved, defaults to 1. Use -1 for the
    /// entire subtree or provide an integer larger than 0.
    /// </param>
    /// <param name="pierce">
    /// Whether or not iframes and shadow roots should be traversed when returning the subtree
    /// (default is false). Reports listeners for all contexts if pierce is enabled.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetEventListenersResult"/>.
    /// </returns>
    public async Task<GetEventListenersResult> GetEventListenersAsync(Runtime.RemoteObjectId objectId, long? depth = default, bool? pierce = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetEventListenersCommandParameters(ObjectId: objectId, Depth: depth, Pierce: pierce);
        return await ExecuteCommandAsync(GetEventListenersCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetEventListenersCommandParameters, GetEventListenersResult> GetEventListenersCommand = new("DOMDebugger.getEventListeners", JsonContext.GetEventListenersCommandParameters, JsonContext.GetEventListenersResult);

    /// <summary>
    /// Removes DOM breakpoint that was set using <b>setDOMBreakpoint</b>.
    /// </summary>
    /// <param name="nodeId">
    /// Identifier of the node to remove breakpoint from.
    /// </param>
    /// <param name="type">
    /// Type of the breakpoint to remove.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RemoveDOMBreakpointResult"/>.
    /// </returns>
    public async Task<RemoveDOMBreakpointResult> RemoveDOMBreakpointAsync(DOM.NodeId nodeId, DOMBreakpointType type, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveDOMBreakpointCommandParameters(NodeId: nodeId, Type: type);
        return await ExecuteCommandAsync(RemoveDOMBreakpointCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RemoveDOMBreakpointCommandParameters, RemoveDOMBreakpointResult> RemoveDOMBreakpointCommand = new("DOMDebugger.removeDOMBreakpoint", JsonContext.RemoveDOMBreakpointCommandParameters, JsonContext.RemoveDOMBreakpointResult);

    /// <summary>
    /// Removes breakpoint on particular DOM event.
    /// </summary>
    /// <param name="eventName">
    /// Event name.
    /// </param>
    /// <param name="targetName">
    /// EventTarget interface name.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RemoveEventListenerBreakpointResult"/>.
    /// </returns>
    public async Task<RemoveEventListenerBreakpointResult> RemoveEventListenerBreakpointAsync(string eventName, string? targetName = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveEventListenerBreakpointCommandParameters(EventName: eventName, TargetName: targetName);
        return await ExecuteCommandAsync(RemoveEventListenerBreakpointCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RemoveEventListenerBreakpointCommandParameters, RemoveEventListenerBreakpointResult> RemoveEventListenerBreakpointCommand = new("DOMDebugger.removeEventListenerBreakpoint", JsonContext.RemoveEventListenerBreakpointCommandParameters, JsonContext.RemoveEventListenerBreakpointResult);

    /// <summary>
    /// Removes breakpoint on particular native event.
    /// </summary>
    /// <param name="eventName">
    /// Instrumentation name to stop on.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RemoveInstrumentationBreakpointResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<RemoveInstrumentationBreakpointResult> RemoveInstrumentationBreakpointAsync(string eventName, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveInstrumentationBreakpointCommandParameters(EventName: eventName);
        return await ExecuteCommandAsync(RemoveInstrumentationBreakpointCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RemoveInstrumentationBreakpointCommandParameters, RemoveInstrumentationBreakpointResult> RemoveInstrumentationBreakpointCommand = new("DOMDebugger.removeInstrumentationBreakpoint", JsonContext.RemoveInstrumentationBreakpointCommandParameters, JsonContext.RemoveInstrumentationBreakpointResult);

    /// <summary>
    /// Removes breakpoint from XMLHttpRequest.
    /// </summary>
    /// <param name="url">
    /// Resource URL substring.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RemoveXHRBreakpointResult"/>.
    /// </returns>
    public async Task<RemoveXHRBreakpointResult> RemoveXHRBreakpointAsync(string url, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveXHRBreakpointCommandParameters(Url: url);
        return await ExecuteCommandAsync(RemoveXHRBreakpointCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RemoveXHRBreakpointCommandParameters, RemoveXHRBreakpointResult> RemoveXHRBreakpointCommand = new("DOMDebugger.removeXHRBreakpoint", JsonContext.RemoveXHRBreakpointCommandParameters, JsonContext.RemoveXHRBreakpointResult);

    /// <summary>
    /// Sets breakpoint on particular CSP violations.
    /// </summary>
    /// <param name="violationTypes">
    /// CSP Violations to stop upon.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetBreakOnCSPViolationResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetBreakOnCSPViolationResult> SetBreakOnCSPViolationAsync(ImmutableArray<CSPViolationType> violationTypes, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetBreakOnCSPViolationCommandParameters(ViolationTypes: violationTypes);
        return await ExecuteCommandAsync(SetBreakOnCSPViolationCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetBreakOnCSPViolationCommandParameters, SetBreakOnCSPViolationResult> SetBreakOnCSPViolationCommand = new("DOMDebugger.setBreakOnCSPViolation", JsonContext.SetBreakOnCSPViolationCommandParameters, JsonContext.SetBreakOnCSPViolationResult);

    /// <summary>
    /// Sets breakpoint on particular operation with DOM.
    /// </summary>
    /// <param name="nodeId">
    /// Identifier of the node to set breakpoint on.
    /// </param>
    /// <param name="type">
    /// Type of the operation to stop upon.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetDOMBreakpointResult"/>.
    /// </returns>
    public async Task<SetDOMBreakpointResult> SetDOMBreakpointAsync(DOM.NodeId nodeId, DOMBreakpointType type, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetDOMBreakpointCommandParameters(NodeId: nodeId, Type: type);
        return await ExecuteCommandAsync(SetDOMBreakpointCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetDOMBreakpointCommandParameters, SetDOMBreakpointResult> SetDOMBreakpointCommand = new("DOMDebugger.setDOMBreakpoint", JsonContext.SetDOMBreakpointCommandParameters, JsonContext.SetDOMBreakpointResult);

    /// <summary>
    /// Sets breakpoint on particular DOM event.
    /// </summary>
    /// <param name="eventName">
    /// DOM Event name to stop on (any DOM event will do).
    /// </param>
    /// <param name="targetName">
    /// EventTarget interface name to stop on. If equal to <b>"*"</b> or not provided, will stop on any
    /// EventTarget.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetEventListenerBreakpointResult"/>.
    /// </returns>
    public async Task<SetEventListenerBreakpointResult> SetEventListenerBreakpointAsync(string eventName, string? targetName = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetEventListenerBreakpointCommandParameters(EventName: eventName, TargetName: targetName);
        return await ExecuteCommandAsync(SetEventListenerBreakpointCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetEventListenerBreakpointCommandParameters, SetEventListenerBreakpointResult> SetEventListenerBreakpointCommand = new("DOMDebugger.setEventListenerBreakpoint", JsonContext.SetEventListenerBreakpointCommandParameters, JsonContext.SetEventListenerBreakpointResult);

    /// <summary>
    /// Sets breakpoint on particular native event.
    /// </summary>
    /// <param name="eventName">
    /// Instrumentation name to stop on.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetInstrumentationBreakpointResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<SetInstrumentationBreakpointResult> SetInstrumentationBreakpointAsync(string eventName, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetInstrumentationBreakpointCommandParameters(EventName: eventName);
        return await ExecuteCommandAsync(SetInstrumentationBreakpointCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetInstrumentationBreakpointCommandParameters, SetInstrumentationBreakpointResult> SetInstrumentationBreakpointCommand = new("DOMDebugger.setInstrumentationBreakpoint", JsonContext.SetInstrumentationBreakpointCommandParameters, JsonContext.SetInstrumentationBreakpointResult);

    /// <summary>
    /// Sets breakpoint on XMLHttpRequest.
    /// </summary>
    /// <param name="url">
    /// Resource URL substring. All XHRs having this substring in the URL will get stopped upon.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetXHRBreakpointResult"/>.
    /// </returns>
    public async Task<SetXHRBreakpointResult> SetXHRBreakpointAsync(string url, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetXHRBreakpointCommandParameters(Url: url);
        return await ExecuteCommandAsync(SetXHRBreakpointCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetXHRBreakpointCommandParameters, SetXHRBreakpointResult> SetXHRBreakpointCommand = new("DOMDebugger.setXHRBreakpoint", JsonContext.SetXHRBreakpointCommandParameters, JsonContext.SetXHRBreakpointResult);

}

internal sealed record GetEventListenersCommandParameters(Runtime.RemoteObjectId ObjectId, long? Depth, bool? Pierce) : Parameters;

/// <summary>
/// </summary>
/// <param name="Listeners">
/// Array of relevant listeners.
/// </param>
public sealed record GetEventListenersResult(ImmutableArray<EventListener> Listeners) : EmptyResult;


internal sealed record RemoveDOMBreakpointCommandParameters(DOM.NodeId NodeId, DOMBreakpointType Type) : Parameters;

/// <summary>
/// </summary>
public sealed record RemoveDOMBreakpointResult() : EmptyResult;


internal sealed record RemoveEventListenerBreakpointCommandParameters(string EventName, string? TargetName) : Parameters;

/// <summary>
/// </summary>
public sealed record RemoveEventListenerBreakpointResult() : EmptyResult;


internal sealed record RemoveInstrumentationBreakpointCommandParameters(string EventName) : Parameters;

/// <summary>
/// </summary>
public sealed record RemoveInstrumentationBreakpointResult() : EmptyResult;


internal sealed record RemoveXHRBreakpointCommandParameters(string Url) : Parameters;

/// <summary>
/// </summary>
public sealed record RemoveXHRBreakpointResult() : EmptyResult;


internal sealed record SetBreakOnCSPViolationCommandParameters(ImmutableArray<CSPViolationType> ViolationTypes) : Parameters;

/// <summary>
/// </summary>
public sealed record SetBreakOnCSPViolationResult() : EmptyResult;


internal sealed record SetDOMBreakpointCommandParameters(DOM.NodeId NodeId, DOMBreakpointType Type) : Parameters;

/// <summary>
/// </summary>
public sealed record SetDOMBreakpointResult() : EmptyResult;


internal sealed record SetEventListenerBreakpointCommandParameters(string EventName, string? TargetName) : Parameters;

/// <summary>
/// </summary>
public sealed record SetEventListenerBreakpointResult() : EmptyResult;


internal sealed record SetInstrumentationBreakpointCommandParameters(string EventName) : Parameters;

/// <summary>
/// </summary>
public sealed record SetInstrumentationBreakpointResult() : EmptyResult;


internal sealed record SetXHRBreakpointCommandParameters(string Url) : Parameters;

/// <summary>
/// </summary>
public sealed record SetXHRBreakpointResult() : EmptyResult;


/// <summary>
/// DOM breakpoint type.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<DOMBreakpointType>))]
public enum DOMBreakpointType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("subtree-modified")]
    SubtreeModified,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("attribute-modified")]
    AttributeModified,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("node-removed")]
    NodeRemoved,
}

/// <summary>
/// CSP Violation type.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<CSPViolationType>))]
public enum CSPViolationType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("trustedtype-sink-violation")]
    TrustedtypeSinkViolation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("trustedtype-policy-violation")]
    TrustedtypePolicyViolation,
}

/// <summary>
/// Object event listener.
/// </summary>
/// <param name="Type">
/// <b>EventListener</b>'s type.
/// </param>
/// <param name="UseCapture">
/// <b>EventListener</b>'s useCapture.
/// </param>
/// <param name="Passive">
/// <b>EventListener</b>'s passive flag.
/// </param>
/// <param name="Once">
/// <b>EventListener</b>'s once flag.
/// </param>
/// <param name="ScriptId">
/// Script id of the handler code.
/// </param>
/// <param name="LineNumber">
/// Line number in the script (0-based).
/// </param>
/// <param name="ColumnNumber">
/// Column number in the script (0-based).
/// </param>
public sealed record EventListener(string Type, bool UseCapture, bool Passive, bool Once, Runtime.ScriptId ScriptId, long LineNumber, long ColumnNumber)
{
    /// <summary>
    /// Event handler function value.
    /// </summary>
    public Runtime.RemoteObject? Handler { get; init; }

    /// <summary>
    /// Event original handler function value.
    /// </summary>
    public Runtime.RemoteObject? OriginalHandler { get; init; }

    /// <summary>
    /// Node the listener is added to (if any).
    /// </summary>
    public DOM.BackendNodeId? BackendNodeId { get; init; }
}

[JsonSerializable(typeof(GetEventListenersCommandParameters), TypeInfoPropertyName = "GetEventListenersCommandParameters")]
[JsonSerializable(typeof(GetEventListenersResult), TypeInfoPropertyName = "GetEventListenersResult")]
[JsonSerializable(typeof(RemoveDOMBreakpointCommandParameters), TypeInfoPropertyName = "RemoveDOMBreakpointCommandParameters")]
[JsonSerializable(typeof(RemoveDOMBreakpointResult), TypeInfoPropertyName = "RemoveDOMBreakpointResult")]
[JsonSerializable(typeof(RemoveEventListenerBreakpointCommandParameters), TypeInfoPropertyName = "RemoveEventListenerBreakpointCommandParameters")]
[JsonSerializable(typeof(RemoveEventListenerBreakpointResult), TypeInfoPropertyName = "RemoveEventListenerBreakpointResult")]
[JsonSerializable(typeof(RemoveInstrumentationBreakpointCommandParameters), TypeInfoPropertyName = "RemoveInstrumentationBreakpointCommandParameters")]
[JsonSerializable(typeof(RemoveInstrumentationBreakpointResult), TypeInfoPropertyName = "RemoveInstrumentationBreakpointResult")]
[JsonSerializable(typeof(RemoveXHRBreakpointCommandParameters), TypeInfoPropertyName = "RemoveXHRBreakpointCommandParameters")]
[JsonSerializable(typeof(RemoveXHRBreakpointResult), TypeInfoPropertyName = "RemoveXHRBreakpointResult")]
[JsonSerializable(typeof(SetBreakOnCSPViolationCommandParameters), TypeInfoPropertyName = "SetBreakOnCSPViolationCommandParameters")]
[JsonSerializable(typeof(SetBreakOnCSPViolationResult), TypeInfoPropertyName = "SetBreakOnCSPViolationResult")]
[JsonSerializable(typeof(SetDOMBreakpointCommandParameters), TypeInfoPropertyName = "SetDOMBreakpointCommandParameters")]
[JsonSerializable(typeof(SetDOMBreakpointResult), TypeInfoPropertyName = "SetDOMBreakpointResult")]
[JsonSerializable(typeof(SetEventListenerBreakpointCommandParameters), TypeInfoPropertyName = "SetEventListenerBreakpointCommandParameters")]
[JsonSerializable(typeof(SetEventListenerBreakpointResult), TypeInfoPropertyName = "SetEventListenerBreakpointResult")]
[JsonSerializable(typeof(SetInstrumentationBreakpointCommandParameters), TypeInfoPropertyName = "SetInstrumentationBreakpointCommandParameters")]
[JsonSerializable(typeof(SetInstrumentationBreakpointResult), TypeInfoPropertyName = "SetInstrumentationBreakpointResult")]
[JsonSerializable(typeof(SetXHRBreakpointCommandParameters), TypeInfoPropertyName = "SetXHRBreakpointCommandParameters")]
[JsonSerializable(typeof(SetXHRBreakpointResult), TypeInfoPropertyName = "SetXHRBreakpointResult")]
[JsonSerializable(typeof(DOMBreakpointType), TypeInfoPropertyName = "DOMDebuggerDOMBreakpointType")]
[JsonSerializable(typeof(CSPViolationType), TypeInfoPropertyName = "DOMDebuggerCSPViolationType")]
[JsonSerializable(typeof(EventListener), TypeInfoPropertyName = "DOMDebuggerEventListener")]
[JsonSerializable(typeof(ImmutableArray<EventListener>), TypeInfoPropertyName = "ImmutableArrayDOMDebuggerEventListener")]
[JsonSerializable(typeof(ImmutableArray<CSPViolationType>), TypeInfoPropertyName = "ImmutableArrayDOMDebuggerCSPViolationType")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class DOMDebuggerJsonSerializerContext : JsonSerializerContext;

