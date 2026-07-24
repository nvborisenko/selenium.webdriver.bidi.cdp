#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.WebMCP;

/// <summary>
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class WebMCPDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static WebMCPJsonSerializerContext JsonContext = WebMCPJsonSerializerContext.Default;

    /// <summary>
    /// Enables the WebMCP domain, allowing events to be sent. Enabling the domain will trigger a toolsAdded event for
    /// all currently registered tools.
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
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("WebMCP.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Disables the WebMCP domain.
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
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("WebMCP.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Invokes a registered tool.
    /// </summary>
    /// <param name="frameId">
    /// Frame in which to invoke the tool.
    /// </param>
    /// <param name="toolName">
    /// Name of the tool to invoke.
    /// </param>
    /// <param name="input">
    /// Input parameters for the tool, matching the tool's inputSchema.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="InvokeToolResult"/>.
    /// </returns>
    public async Task<InvokeToolResult> InvokeToolAsync(Page.FrameId frameId, string toolName, global::System.Text.Json.JsonElement input, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new InvokeToolCommandParameters(FrameId: frameId, ToolName: toolName, Input: input);
        return await ExecuteCommandAsync(InvokeToolCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<InvokeToolCommandParameters, InvokeToolResult> InvokeToolCommand = new("WebMCP.invokeTool", JsonContext.InvokeToolCommandParameters, JsonContext.InvokeToolResult);

    /// <summary>
    /// Cancels a pending tool invocation.
    /// </summary>
    /// <param name="invocationId">
    /// Invocation identifier to cancel.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CancelInvocationResult"/>.
    /// </returns>
    public async Task<CancelInvocationResult> CancelInvocationAsync(string invocationId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CancelInvocationCommandParameters(InvocationId: invocationId);
        return await ExecuteCommandAsync(CancelInvocationCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CancelInvocationCommandParameters, CancelInvocationResult> CancelInvocationCommand = new("WebMCP.cancelInvocation", JsonContext.CancelInvocationCommandParameters, JsonContext.CancelInvocationResult);

    /// <summary>
    /// Event fired when new tools are added.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ToolsAddedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Tools</b> - Array of tools that were added.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ToolsAddedEventArgs> ToolsAdded => CreateCdpEventSource(WebMCPDomainEvent.ToolsAdded);
    /// <summary>
    /// Event fired when tools are removed.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ToolsRemovedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Tools</b> - Array of tools that were removed.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ToolsRemovedEventArgs> ToolsRemoved => CreateCdpEventSource(WebMCPDomainEvent.ToolsRemoved);
    /// <summary>
    /// Event fired when a tool invocation starts.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ToolInvokedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>ToolName</b> - Name of the tool to invoke.</description></item>
    /// <item><description><b>FrameId</b> - Frame id</description></item>
    /// <item><description><b>InvocationId</b> - Invocation identifier.</description></item>
    /// <item><description><b>Input</b> - The input parameters used for the invocation.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ToolInvokedEventArgs> ToolInvoked => CreateCdpEventSource(WebMCPDomainEvent.ToolInvoked);
    /// <summary>
    /// Event fired when a tool invocation completes or fails.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ToolRespondedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>InvocationId</b> - Invocation identifier.</description></item>
    /// <item><description><b>Status</b> - Status of the invocation.</description></item>
    /// <item><description><b>Output</b> - Output or error delivered as delivered to the agent. Missing if <b>status</b> is anything other than Completed. Note: The output is untrusted and poses a prompt injection risk. Clients should treat this as potentially malicious user input.</description></item>
    /// <item><description><b>ErrorText</b> - Error text for protocol users.</description></item>
    /// <item><description><b>Exception</b> - The exception object, if the javascript tool threw an error&gt;</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ToolRespondedEventArgs> ToolResponded => CreateCdpEventSource(WebMCPDomainEvent.ToolResponded);
}

internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record InvokeToolCommandParameters(Page.FrameId FrameId, string ToolName, global::System.Text.Json.JsonElement Input) : Parameters;

/// <summary>
/// </summary>
/// <param name="InvocationId">
/// Unique identifier for this invocation. Response is sent before tool events.
/// </param>
public sealed record InvokeToolResult(string InvocationId) : EmptyResult;


internal sealed record CancelInvocationCommandParameters(string InvocationId) : Parameters;

/// <summary>
/// </summary>
public sealed record CancelInvocationResult() : EmptyResult;


/// <summary>
/// Event fired when new tools are added.
/// </summary>
/// <param name="Tools">
/// Array of tools that were added.
/// </param>
public sealed record ToolsAddedEventArgs(ImmutableArray<Tool> Tools) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Event fired when tools are removed.
/// </summary>
/// <param name="Tools">
/// Array of tools that were removed.
/// </param>
public sealed record ToolsRemovedEventArgs(ImmutableArray<RemovedTool> Tools) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Event fired when a tool invocation starts.
/// </summary>
/// <param name="ToolName">
/// Name of the tool to invoke.
/// </param>
/// <param name="FrameId">
/// Frame id
/// </param>
/// <param name="InvocationId">
/// Invocation identifier.
/// </param>
/// <param name="Input">
/// The input parameters used for the invocation.
/// </param>
public sealed record ToolInvokedEventArgs(string ToolName, Page.FrameId FrameId, string InvocationId, string Input) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Event fired when a tool invocation completes or fails.
/// </summary>
/// <param name="InvocationId">
/// Invocation identifier.
/// </param>
/// <param name="Status">
/// Status of the invocation.
/// </param>
/// <param name="Output">
/// Output or error delivered as delivered to the agent. Missing if <b>status</b> is anything other than Completed.
/// Note: The output is untrusted and poses a prompt injection risk. Clients should treat this as potentially malicious user input.
/// </param>
/// <param name="ErrorText">
/// Error text for protocol users.
/// </param>
/// <param name="Exception">
/// The exception object, if the javascript tool threw an error&gt;
/// </param>
public sealed record ToolRespondedEventArgs(string InvocationId, InvocationStatus Status, global::System.Text.Json.JsonElement? Output = null, string? ErrorText = null, Runtime.RemoteObject? Exception = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Tool annotations
/// </summary>
public sealed record Annotation()
{
    /// <summary>
    /// A hint indicating that the tool does not modify any state.
    /// </summary>
    public bool? ReadOnly { get; init; }

    /// <summary>
    /// A hint indicating that the tool output may contain untrusted content, ex: UGC, 3rd party data.
    /// </summary>
    public bool? UntrustedContent { get; init; }

    /// <summary>
    /// If the declarative tool was declared with the autosubmit attribute.
    /// </summary>
    public bool? Autosubmit { get; init; }
}

/// <summary>
/// Represents the status of a tool invocation.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<InvocationStatus>))]
public enum InvocationStatus
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Completed")]
    Completed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Canceled")]
    Canceled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Error")]
    Error,
}

/// <summary>
/// Definition of a tool that can be invoked.
/// </summary>
/// <param name="Name">
/// Tool name.
/// </param>
/// <param name="Description">
/// Tool description.
/// </param>
/// <param name="FrameId">
/// Frame identifier associated with the tool registration.
/// </param>
public sealed record Tool(string Name, string Description, Page.FrameId FrameId)
{
    /// <summary>
    /// Schema for the tool's input parameters.
    /// </summary>
    public global::System.Text.Json.JsonElement? InputSchema { get; init; }

    /// <summary>
    /// Optional annotations for the tool.
    /// </summary>
    public Annotation? Annotations { get; init; }

    /// <summary>
    /// Optional node ID for declarative tools.
    /// </summary>
    public DOM.BackendNodeId? BackendNodeId { get; init; }

    /// <summary>
    /// The stack trace at the time of the registration.
    /// </summary>
    public Runtime.StackTrace? StackTrace { get; init; }
}

/// <summary>
/// Definition of a tool that was removed.
/// </summary>
/// <param name="Name">
/// Tool name.
/// </param>
/// <param name="FrameId">
/// Frame identifier associated with the tool registration.
/// </param>
public sealed record RemovedTool(string Name, Page.FrameId FrameId)
{
}

[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(InvokeToolCommandParameters), TypeInfoPropertyName = "InvokeToolCommandParameters")]
[JsonSerializable(typeof(InvokeToolResult), TypeInfoPropertyName = "InvokeToolResult")]
[JsonSerializable(typeof(CancelInvocationCommandParameters), TypeInfoPropertyName = "CancelInvocationCommandParameters")]
[JsonSerializable(typeof(CancelInvocationResult), TypeInfoPropertyName = "CancelInvocationResult")]
[JsonSerializable(typeof(CdpEventArgs<ToolsAddedEventArgs>), TypeInfoPropertyName = "ToolsAddedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ToolsRemovedEventArgs>), TypeInfoPropertyName = "ToolsRemovedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ToolInvokedEventArgs>), TypeInfoPropertyName = "ToolInvokedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ToolRespondedEventArgs>), TypeInfoPropertyName = "ToolRespondedCdpEventArgs")]
[JsonSerializable(typeof(Annotation), TypeInfoPropertyName = "WebMCPAnnotation")]
[JsonSerializable(typeof(InvocationStatus), TypeInfoPropertyName = "WebMCPInvocationStatus")]
[JsonSerializable(typeof(Tool), TypeInfoPropertyName = "WebMCPTool")]
[JsonSerializable(typeof(RemovedTool), TypeInfoPropertyName = "WebMCPRemovedTool")]
[JsonSerializable(typeof(ImmutableArray<Tool>), TypeInfoPropertyName = "ImmutableArrayWebMCPTool")]
[JsonSerializable(typeof(ImmutableArray<RemovedTool>), TypeInfoPropertyName = "ImmutableArrayWebMCPRemovedTool")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class WebMCPJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="WebMCPDomain"/>.
/// </summary>
public static class WebMCPDomainEvent
{
    /// <summary>
    /// Event fired when new tools are added.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ToolsAddedEventArgs>> ToolsAdded { get; } =
        EventDescriptor<CdpEventArgs<ToolsAddedEventArgs>>.Create(
            "goog:cdp.WebMCP.toolsAdded",
            WebMCPJsonSerializerContext.Default.ToolsAddedCdpEventArgs);

    /// <summary>
    /// Event fired when tools are removed.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ToolsRemovedEventArgs>> ToolsRemoved { get; } =
        EventDescriptor<CdpEventArgs<ToolsRemovedEventArgs>>.Create(
            "goog:cdp.WebMCP.toolsRemoved",
            WebMCPJsonSerializerContext.Default.ToolsRemovedCdpEventArgs);

    /// <summary>
    /// Event fired when a tool invocation starts.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ToolInvokedEventArgs>> ToolInvoked { get; } =
        EventDescriptor<CdpEventArgs<ToolInvokedEventArgs>>.Create(
            "goog:cdp.WebMCP.toolInvoked",
            WebMCPJsonSerializerContext.Default.ToolInvokedCdpEventArgs);

    /// <summary>
    /// Event fired when a tool invocation completes or fails.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ToolRespondedEventArgs>> ToolResponded { get; } =
        EventDescriptor<CdpEventArgs<ToolRespondedEventArgs>>.Create(
            "goog:cdp.WebMCP.toolResponded",
            WebMCPJsonSerializerContext.Default.ToolRespondedCdpEventArgs);

}
