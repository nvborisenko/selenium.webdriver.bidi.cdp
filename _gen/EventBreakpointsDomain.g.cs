#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.EventBreakpoints;

/// <summary>
/// EventBreakpoints permits setting JavaScript breakpoints on operations and events
/// occurring in native code invoked from JavaScript. Once breakpoint is hit, it is
/// reported through Debugger domain, similarly to regular breakpoints being hit.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public interface IEventBreakpoints
{
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
    Task<SetInstrumentationBreakpointResult> SetInstrumentationBreakpointAsync(string eventName, string? session = default, CancellationToken cancellationToken = default);

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
    Task<RemoveInstrumentationBreakpointResult> RemoveInstrumentationBreakpointAsync(string eventName, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Removes all breakpoints
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

}

[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
internal sealed class EventBreakpointsDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), IEventBreakpoints
{
    private static EventBreakpointsJsonSerializerContext JsonContext = EventBreakpointsJsonSerializerContext.Default;

    public async Task<SetInstrumentationBreakpointResult> SetInstrumentationBreakpointAsync(string eventName, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetInstrumentationBreakpointCommandParameters(EventName: eventName);
        return await ExecuteCommandAsync(SetInstrumentationBreakpointCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetInstrumentationBreakpointCommandParameters, SetInstrumentationBreakpointResult> SetInstrumentationBreakpointCommand = new("EventBreakpoints.setInstrumentationBreakpoint", JsonContext.SetInstrumentationBreakpointCommandParameters, JsonContext.SetInstrumentationBreakpointResult);

    public async Task<RemoveInstrumentationBreakpointResult> RemoveInstrumentationBreakpointAsync(string eventName, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveInstrumentationBreakpointCommandParameters(EventName: eventName);
        return await ExecuteCommandAsync(RemoveInstrumentationBreakpointCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RemoveInstrumentationBreakpointCommandParameters, RemoveInstrumentationBreakpointResult> RemoveInstrumentationBreakpointCommand = new("EventBreakpoints.removeInstrumentationBreakpoint", JsonContext.RemoveInstrumentationBreakpointCommandParameters, JsonContext.RemoveInstrumentationBreakpointResult);

    public async Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync(DisableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("EventBreakpoints.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

}

internal sealed record SetInstrumentationBreakpointCommandParameters(string EventName) : Parameters;

/// <summary>
/// </summary>
public sealed record SetInstrumentationBreakpointResult() : EmptyResult;


internal sealed record RemoveInstrumentationBreakpointCommandParameters(string EventName) : Parameters;

/// <summary>
/// </summary>
public sealed record RemoveInstrumentationBreakpointResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


[JsonSerializable(typeof(SetInstrumentationBreakpointCommandParameters), TypeInfoPropertyName = "SetInstrumentationBreakpointCommandParameters")]
[JsonSerializable(typeof(SetInstrumentationBreakpointResult), TypeInfoPropertyName = "SetInstrumentationBreakpointResult")]
[JsonSerializable(typeof(RemoveInstrumentationBreakpointCommandParameters), TypeInfoPropertyName = "RemoveInstrumentationBreakpointCommandParameters")]
[JsonSerializable(typeof(RemoveInstrumentationBreakpointResult), TypeInfoPropertyName = "RemoveInstrumentationBreakpointResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class EventBreakpointsJsonSerializerContext : JsonSerializerContext;

