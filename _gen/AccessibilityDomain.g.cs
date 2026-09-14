#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Accessibility;

/// <summary>
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public interface IAccessibility
{
    /// <summary>
    /// Disables the accessibility domain.
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
    /// Enables the accessibility domain which causes <b>AXNodeId</b>s to remain consistent between method calls.
    /// This turns on accessibility for the page, which can impact performance until accessibility is disabled.
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
    /// Fetches the accessibility node and partial accessibility tree for this DOM node, if it exists.
    /// </summary>
    /// <param name="nodeId">
    /// Identifier of the node to get the partial accessibility tree for.
    /// </param>
    /// <param name="backendNodeId">
    /// Identifier of the backend node to get the partial accessibility tree for.
    /// </param>
    /// <param name="objectId">
    /// JavaScript object id of the node wrapper to get the partial accessibility tree for.
    /// </param>
    /// <param name="fetchRelatives">
    /// Whether to fetch this node's ancestors, siblings and children. Defaults to true.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetPartialAXTreeResult"/>.
    /// </returns>
    Task<GetPartialAXTreeResult> GetPartialAXTreeAsync(DOM.NodeId? nodeId = null, DOM.BackendNodeId? backendNodeId = null, Runtime.RemoteObjectId? objectId = null, bool? fetchRelatives = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Fetches the entire accessibility tree for the root Document
    /// </summary>
    /// <param name="depth">
    /// The maximum depth at which descendants of the root node should be retrieved.
    /// If omitted, the full tree is returned.
    /// </param>
    /// <param name="frameId">
    /// The frame for whose document the AX tree should be retrieved.
    /// If omitted, the root frame is used.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetFullAXTreeResult"/>.
    /// </returns>
    Task<GetFullAXTreeResult> GetFullAXTreeAsync(long? depth = null, Page.FrameId? frameId = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Fetches the root node.
    /// Requires <b>enable()</b> to have been called previously.
    /// </summary>
    /// <param name="frameId">
    /// The frame in whose document the node resides.
    /// If omitted, the root frame is used.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetRootAXNodeResult"/>.
    /// </returns>
    Task<GetRootAXNodeResult> GetRootAXNodeAsync(Page.FrameId? frameId = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Fetches a node and all ancestors up to and including the root.
    /// Requires <b>enable()</b> to have been called previously.
    /// </summary>
    /// <param name="nodeId">
    /// Identifier of the node to get.
    /// </param>
    /// <param name="backendNodeId">
    /// Identifier of the backend node to get.
    /// </param>
    /// <param name="objectId">
    /// JavaScript object id of the node wrapper to get.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetAXNodeAndAncestorsResult"/>.
    /// </returns>
    Task<GetAXNodeAndAncestorsResult> GetAXNodeAndAncestorsAsync(DOM.NodeId? nodeId = null, DOM.BackendNodeId? backendNodeId = null, Runtime.RemoteObjectId? objectId = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Fetches a particular accessibility node by AXNodeId.
    /// Requires <b>enable()</b> to have been called previously.
    /// </summary>
    /// <param name="id">
    /// </param>
    /// <param name="frameId">
    /// The frame in whose document the node resides.
    /// If omitted, the root frame is used.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetChildAXNodesResult"/>.
    /// </returns>
    Task<GetChildAXNodesResult> GetChildAXNodesAsync(AXNodeId id, Page.FrameId? frameId = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Query a DOM node's accessibility subtree for accessible name and role.
    /// This command computes the name and role for all nodes in the subtree, including those that are
    /// ignored for accessibility, and returns those that match the specified name and role. If no DOM
    /// node is specified, or the DOM node does not exist, the command returns an error. If neither
    /// <b>accessibleName</b> or <b>role</b> is specified, it returns all the accessibility nodes in the subtree.
    /// </summary>
    /// <param name="nodeId">
    /// Identifier of the node for the root to query.
    /// </param>
    /// <param name="backendNodeId">
    /// Identifier of the backend node for the root to query.
    /// </param>
    /// <param name="objectId">
    /// JavaScript object id of the node wrapper for the root to query.
    /// </param>
    /// <param name="accessibleName">
    /// Find nodes with this computed name.
    /// </param>
    /// <param name="role">
    /// Find nodes with this computed role.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="QueryAXTreeResult"/>.
    /// </returns>
    Task<QueryAXTreeResult> QueryAXTreeAsync(DOM.NodeId? nodeId = null, DOM.BackendNodeId? backendNodeId = null, Runtime.RemoteObjectId? objectId = null, string? accessibleName = null, string? role = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// The loadComplete event mirrors the load complete event sent by the browser to assistive
    /// technology when the web page has finished loading.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="LoadCompleteEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Root</b> - New document root node.</description></item>
    /// </list>
    /// </remarks>
    IEventSource<LoadCompleteEventArgs> LoadComplete { get; }

    /// <summary>
    /// The nodesUpdated event is sent every time a previously requested node has changed the in tree.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="NodesUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Nodes</b> - Updated node data.</description></item>
    /// </list>
    /// </remarks>
    IEventSource<NodesUpdatedEventArgs> NodesUpdated { get; }

}

[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
internal sealed class AccessibilityDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), IAccessibility
{
    private static readonly AccessibilityJsonSerializerContext JsonContext = AccessibilityJsonSerializerContext.Default;

    public async Task<DisableResult> DisableAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync("Accessibility.disable", @params, JsonContext.DisableCommandParameters, JsonContext.DisableResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<EnableResult> EnableAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters();
        return await ExecuteCommandAsync("Accessibility.enable", @params, JsonContext.EnableCommandParameters, JsonContext.EnableResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<GetPartialAXTreeResult> GetPartialAXTreeAsync(DOM.NodeId? nodeId = null, DOM.BackendNodeId? backendNodeId = null, Runtime.RemoteObjectId? objectId = null, bool? fetchRelatives = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetPartialAXTreeCommandParameters(NodeId: nodeId, BackendNodeId: backendNodeId, ObjectId: objectId, FetchRelatives: fetchRelatives);
        return await ExecuteCommandAsync("Accessibility.getPartialAXTree", @params, JsonContext.GetPartialAXTreeCommandParameters, JsonContext.GetPartialAXTreeResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<GetFullAXTreeResult> GetFullAXTreeAsync(long? depth = null, Page.FrameId? frameId = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetFullAXTreeCommandParameters(Depth: depth, FrameId: frameId);
        return await ExecuteCommandAsync("Accessibility.getFullAXTree", @params, JsonContext.GetFullAXTreeCommandParameters, JsonContext.GetFullAXTreeResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<GetRootAXNodeResult> GetRootAXNodeAsync(Page.FrameId? frameId = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetRootAXNodeCommandParameters(FrameId: frameId);
        return await ExecuteCommandAsync("Accessibility.getRootAXNode", @params, JsonContext.GetRootAXNodeCommandParameters, JsonContext.GetRootAXNodeResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<GetAXNodeAndAncestorsResult> GetAXNodeAndAncestorsAsync(DOM.NodeId? nodeId = null, DOM.BackendNodeId? backendNodeId = null, Runtime.RemoteObjectId? objectId = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetAXNodeAndAncestorsCommandParameters(NodeId: nodeId, BackendNodeId: backendNodeId, ObjectId: objectId);
        return await ExecuteCommandAsync("Accessibility.getAXNodeAndAncestors", @params, JsonContext.GetAXNodeAndAncestorsCommandParameters, JsonContext.GetAXNodeAndAncestorsResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<GetChildAXNodesResult> GetChildAXNodesAsync(AXNodeId id, Page.FrameId? frameId = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetChildAXNodesCommandParameters(Id: id, FrameId: frameId);
        return await ExecuteCommandAsync("Accessibility.getChildAXNodes", @params, JsonContext.GetChildAXNodesCommandParameters, JsonContext.GetChildAXNodesResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<QueryAXTreeResult> QueryAXTreeAsync(DOM.NodeId? nodeId = null, DOM.BackendNodeId? backendNodeId = null, Runtime.RemoteObjectId? objectId = null, string? accessibleName = null, string? role = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new QueryAXTreeCommandParameters(NodeId: nodeId, BackendNodeId: backendNodeId, ObjectId: objectId, AccessibleName: accessibleName, Role: role);
        return await ExecuteCommandAsync("Accessibility.queryAXTree", @params, JsonContext.QueryAXTreeCommandParameters, JsonContext.QueryAXTreeResult, session, cancellationToken).ConfigureAwait(false);
    }

    public IEventSource<LoadCompleteEventArgs> LoadComplete => CreateCdpEventSource(AccessibilityDomainEvent.LoadComplete);
    public IEventSource<NodesUpdatedEventArgs> NodesUpdated => CreateCdpEventSource(AccessibilityDomainEvent.NodesUpdated);
}

internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IAccessibility.DisableAsync"/> command.
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IAccessibility.EnableAsync"/> command.
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record GetPartialAXTreeCommandParameters(DOM.NodeId? NodeId, DOM.BackendNodeId? BackendNodeId, Runtime.RemoteObjectId? ObjectId, bool? FetchRelatives) : Parameters;

/// <summary>
/// Result of the <see cref="IAccessibility.GetPartialAXTreeAsync"/> command.
/// </summary>
/// <param name="Nodes">
/// The <b>Accessibility.AXNode</b> for this DOM node, if it exists, plus its ancestors, siblings and
/// children, if requested.
/// </param>
public sealed record GetPartialAXTreeResult(ImmutableArray<AXNode> Nodes) : EmptyResult;


internal sealed record GetFullAXTreeCommandParameters(long? Depth, Page.FrameId? FrameId) : Parameters;

/// <summary>
/// Result of the <see cref="IAccessibility.GetFullAXTreeAsync"/> command.
/// </summary>
/// <param name="Nodes">
/// </param>
public sealed record GetFullAXTreeResult(ImmutableArray<AXNode> Nodes) : EmptyResult;


internal sealed record GetRootAXNodeCommandParameters(Page.FrameId? FrameId) : Parameters;

/// <summary>
/// Result of the <see cref="IAccessibility.GetRootAXNodeAsync"/> command.
/// </summary>
/// <param name="Node">
/// </param>
public sealed record GetRootAXNodeResult(AXNode Node) : EmptyResult;


internal sealed record GetAXNodeAndAncestorsCommandParameters(DOM.NodeId? NodeId, DOM.BackendNodeId? BackendNodeId, Runtime.RemoteObjectId? ObjectId) : Parameters;

/// <summary>
/// Result of the <see cref="IAccessibility.GetAXNodeAndAncestorsAsync"/> command.
/// </summary>
/// <param name="Nodes">
/// </param>
public sealed record GetAXNodeAndAncestorsResult(ImmutableArray<AXNode> Nodes) : EmptyResult;


internal sealed record GetChildAXNodesCommandParameters(AXNodeId Id, Page.FrameId? FrameId) : Parameters;

/// <summary>
/// Result of the <see cref="IAccessibility.GetChildAXNodesAsync"/> command.
/// </summary>
/// <param name="Nodes">
/// </param>
public sealed record GetChildAXNodesResult(ImmutableArray<AXNode> Nodes) : EmptyResult;


internal sealed record QueryAXTreeCommandParameters(DOM.NodeId? NodeId, DOM.BackendNodeId? BackendNodeId, Runtime.RemoteObjectId? ObjectId, string? AccessibleName, string? Role) : Parameters;

/// <summary>
/// Result of the <see cref="IAccessibility.QueryAXTreeAsync"/> command.
/// </summary>
/// <param name="Nodes">
/// A list of <b>Accessibility.AXNode</b> matching the specified attributes,
/// including nodes that are ignored for accessibility.
/// </param>
public sealed record QueryAXTreeResult(ImmutableArray<AXNode> Nodes) : EmptyResult;


/// <summary>
/// The loadComplete event mirrors the load complete event sent by the browser to assistive
/// technology when the web page has finished loading.
/// </summary>
/// <param name="Root">
/// New document root node.
/// </param>
public sealed record LoadCompleteEventArgs(AXNode Root) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// The nodesUpdated event is sent every time a previously requested node has changed the in tree.
/// </summary>
/// <param name="Nodes">
/// Updated node data.
/// </param>
public sealed record NodesUpdatedEventArgs(ImmutableArray<AXNode> Nodes) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Unique accessibility node identifier.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<AXNodeId>))]
public record AXNodeId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Enum of possible property types.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<AXValueType>))]
public enum AXValueType
{
    /// <summary>
    /// Corresponds to the <c>"boolean"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("boolean")]
    Boolean,
    /// <summary>
    /// Corresponds to the <c>"tristate"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("tristate")]
    Tristate,
    /// <summary>
    /// Corresponds to the <c>"booleanOrUndefined"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("booleanOrUndefined")]
    BooleanOrUndefined,
    /// <summary>
    /// Corresponds to the <c>"idref"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("idref")]
    Idref,
    /// <summary>
    /// Corresponds to the <c>"idrefList"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("idrefList")]
    IdrefList,
    /// <summary>
    /// Corresponds to the <c>"integer"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("integer")]
    Integer,
    /// <summary>
    /// Corresponds to the <c>"node"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("node")]
    Node,
    /// <summary>
    /// Corresponds to the <c>"nodeList"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("nodeList")]
    NodeList,
    /// <summary>
    /// Corresponds to the <c>"number"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("number")]
    Number,
    /// <summary>
    /// Corresponds to the <c>"string"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("string")]
    String,
    /// <summary>
    /// Corresponds to the <c>"computedString"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("computedString")]
    ComputedString,
    /// <summary>
    /// Corresponds to the <c>"token"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("token")]
    Token,
    /// <summary>
    /// Corresponds to the <c>"tokenList"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("tokenList")]
    TokenList,
    /// <summary>
    /// Corresponds to the <c>"domRelation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("domRelation")]
    DomRelation,
    /// <summary>
    /// Corresponds to the <c>"role"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("role")]
    Role,
    /// <summary>
    /// Corresponds to the <c>"internalRole"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("internalRole")]
    InternalRole,
    /// <summary>
    /// Corresponds to the <c>"valueUndefined"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("valueUndefined")]
    ValueUndefined,
}

/// <summary>
/// Enum of possible property sources.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<AXValueSourceType>))]
public enum AXValueSourceType
{
    /// <summary>
    /// Corresponds to the <c>"attribute"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("attribute")]
    Attribute,
    /// <summary>
    /// Corresponds to the <c>"implicit"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("implicit")]
    Implicit,
    /// <summary>
    /// Corresponds to the <c>"style"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("style")]
    Style,
    /// <summary>
    /// Corresponds to the <c>"contents"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("contents")]
    Contents,
    /// <summary>
    /// Corresponds to the <c>"placeholder"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("placeholder")]
    Placeholder,
    /// <summary>
    /// Corresponds to the <c>"relatedElement"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("relatedElement")]
    RelatedElement,
}

/// <summary>
/// Enum of possible native property sources (as a subtype of a particular AXValueSourceType).
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<AXValueNativeSourceType>))]
public enum AXValueNativeSourceType
{
    /// <summary>
    /// Corresponds to the <c>"description"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("description")]
    Description,
    /// <summary>
    /// Corresponds to the <c>"figcaption"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("figcaption")]
    Figcaption,
    /// <summary>
    /// Corresponds to the <c>"label"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("label")]
    Label,
    /// <summary>
    /// Corresponds to the <c>"labelfor"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("labelfor")]
    Labelfor,
    /// <summary>
    /// Corresponds to the <c>"labelwrapped"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("labelwrapped")]
    Labelwrapped,
    /// <summary>
    /// Corresponds to the <c>"legend"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("legend")]
    Legend,
    /// <summary>
    /// Corresponds to the <c>"rubyannotation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("rubyannotation")]
    Rubyannotation,
    /// <summary>
    /// Corresponds to the <c>"tablecaption"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("tablecaption")]
    Tablecaption,
    /// <summary>
    /// Corresponds to the <c>"title"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("title")]
    Title,
    /// <summary>
    /// Corresponds to the <c>"other"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("other")]
    Other,
}

/// <summary>
/// A single source for a computed AX property.
/// </summary>
/// <param name="Type">
/// What type of source this is.
/// </param>
public sealed record AXValueSource(AXValueSourceType Type)
{
    /// <summary>
    /// The value of this property source.
    /// </summary>
    public AXValue? Value { get; init; }

    /// <summary>
    /// The name of the relevant attribute, if any.
    /// </summary>
    public string? Attribute { get; init; }

    /// <summary>
    /// The value of the relevant attribute, if any.
    /// </summary>
    public AXValue? AttributeValue { get; init; }

    /// <summary>
    /// Whether this source is superseded by a higher priority source.
    /// </summary>
    public bool? Superseded { get; init; }

    /// <summary>
    /// The native markup source for this value, e.g. a <b>&lt;label&gt;</b> element.
    /// </summary>
    public AXValueNativeSourceType? NativeSource { get; init; }

    /// <summary>
    /// The value, such as a node or node list, of the native source.
    /// </summary>
    public AXValue? NativeSourceValue { get; init; }

    /// <summary>
    /// Whether the value for this property is invalid.
    /// </summary>
    public bool? Invalid { get; init; }

    /// <summary>
    /// Reason for the value being invalid, if it is.
    /// </summary>
    public string? InvalidReason { get; init; }
}

/// <summary>
/// </summary>
/// <param name="BackendDOMNodeId">
/// The BackendNodeId of the related DOM node.
/// </param>
public sealed record AXRelatedNode(DOM.BackendNodeId BackendDOMNodeId)
{
    /// <summary>
    /// The IDRef value provided, if any.
    /// </summary>
    public string? Idref { get; init; }

    /// <summary>
    /// The text alternative of this node in the current context.
    /// </summary>
    public string? Text { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Name">
/// The name of this property.
/// </param>
/// <param name="Value">
/// The value of this property.
/// </param>
public sealed record AXProperty(AXPropertyName Name, AXValue Value)
{
}

/// <summary>
/// A single computed AX property.
/// </summary>
/// <param name="Type">
/// The type of this value.
/// </param>
public sealed record AXValue(AXValueType Type)
{
    /// <summary>
    /// The computed value of this property.
    /// </summary>
    public global::System.Text.Json.JsonElement? Value { get; init; }

    /// <summary>
    /// One or more related nodes, if applicable.
    /// </summary>
    public ImmutableArray<AXRelatedNode>? RelatedNodes { get; init; }

    /// <summary>
    /// The sources which contributed to the computation of this property.
    /// </summary>
    public ImmutableArray<AXValueSource>? Sources { get; init; }
}

/// <summary>
/// Values of AXProperty name:
/// - from 'busy' to 'roledescription': states which apply to every AX node
/// - from 'live' to 'root': attributes which apply to nodes in live regions
/// - from 'autocomplete' to 'valuetext': attributes which apply to widgets
/// - from 'checked' to 'selected': states which apply to widgets
/// - from 'activedescendant' to 'owns': relationships between elements other than parent/child/sibling
/// - from 'activeFullscreenElement' to 'uninteresting': reasons why this noode is hidden
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<AXPropertyName>))]
public enum AXPropertyName
{
    /// <summary>
    /// Corresponds to the <c>"actions"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("actions")]
    Actions,
    /// <summary>
    /// Corresponds to the <c>"busy"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("busy")]
    Busy,
    /// <summary>
    /// Corresponds to the <c>"disabled"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("disabled")]
    Disabled,
    /// <summary>
    /// Corresponds to the <c>"editable"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("editable")]
    Editable,
    /// <summary>
    /// Corresponds to the <c>"focusable"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("focusable")]
    Focusable,
    /// <summary>
    /// Corresponds to the <c>"focused"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("focused")]
    Focused,
    /// <summary>
    /// Corresponds to the <c>"hidden"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("hidden")]
    Hidden,
    /// <summary>
    /// Corresponds to the <c>"hiddenRoot"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("hiddenRoot")]
    HiddenRoot,
    /// <summary>
    /// Corresponds to the <c>"invalid"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("invalid")]
    Invalid,
    /// <summary>
    /// Corresponds to the <c>"keyshortcuts"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("keyshortcuts")]
    Keyshortcuts,
    /// <summary>
    /// Corresponds to the <c>"settable"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("settable")]
    Settable,
    /// <summary>
    /// Corresponds to the <c>"roledescription"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("roledescription")]
    Roledescription,
    /// <summary>
    /// Corresponds to the <c>"live"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("live")]
    Live,
    /// <summary>
    /// Corresponds to the <c>"atomic"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("atomic")]
    Atomic,
    /// <summary>
    /// Corresponds to the <c>"relevant"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("relevant")]
    Relevant,
    /// <summary>
    /// Corresponds to the <c>"root"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("root")]
    Root,
    /// <summary>
    /// Corresponds to the <c>"autocomplete"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("autocomplete")]
    Autocomplete,
    /// <summary>
    /// Corresponds to the <c>"hasPopup"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("hasPopup")]
    HasPopup,
    /// <summary>
    /// Corresponds to the <c>"level"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("level")]
    Level,
    /// <summary>
    /// Corresponds to the <c>"multiselectable"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("multiselectable")]
    Multiselectable,
    /// <summary>
    /// Corresponds to the <c>"orientation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("orientation")]
    Orientation,
    /// <summary>
    /// Corresponds to the <c>"multiline"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("multiline")]
    Multiline,
    /// <summary>
    /// Corresponds to the <c>"readonly"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("readonly")]
    Readonly,
    /// <summary>
    /// Corresponds to the <c>"required"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("required")]
    Required,
    /// <summary>
    /// Corresponds to the <c>"valuemin"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("valuemin")]
    Valuemin,
    /// <summary>
    /// Corresponds to the <c>"valuemax"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("valuemax")]
    Valuemax,
    /// <summary>
    /// Corresponds to the <c>"valuetext"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("valuetext")]
    Valuetext,
    /// <summary>
    /// Corresponds to the <c>"checked"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("checked")]
    Checked,
    /// <summary>
    /// Corresponds to the <c>"expanded"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("expanded")]
    Expanded,
    /// <summary>
    /// Corresponds to the <c>"modal"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("modal")]
    Modal,
    /// <summary>
    /// Corresponds to the <c>"pressed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("pressed")]
    Pressed,
    /// <summary>
    /// Corresponds to the <c>"selected"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("selected")]
    Selected,
    /// <summary>
    /// Corresponds to the <c>"activedescendant"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("activedescendant")]
    Activedescendant,
    /// <summary>
    /// Corresponds to the <c>"controls"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("controls")]
    Controls,
    /// <summary>
    /// Corresponds to the <c>"describedby"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("describedby")]
    Describedby,
    /// <summary>
    /// Corresponds to the <c>"details"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("details")]
    Details,
    /// <summary>
    /// Corresponds to the <c>"errormessage"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("errormessage")]
    Errormessage,
    /// <summary>
    /// Corresponds to the <c>"flowto"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("flowto")]
    Flowto,
    /// <summary>
    /// Corresponds to the <c>"labelledby"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("labelledby")]
    Labelledby,
    /// <summary>
    /// Corresponds to the <c>"owns"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("owns")]
    Owns,
    /// <summary>
    /// Corresponds to the <c>"url"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("url")]
    Url,
    /// <summary>
    /// Corresponds to the <c>"activeFullscreenElement"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("activeFullscreenElement")]
    ActiveFullscreenElement,
    /// <summary>
    /// Corresponds to the <c>"activeModalDialog"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("activeModalDialog")]
    ActiveModalDialog,
    /// <summary>
    /// Corresponds to the <c>"activeAriaModalDialog"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("activeAriaModalDialog")]
    ActiveAriaModalDialog,
    /// <summary>
    /// Corresponds to the <c>"ariaHiddenElement"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ariaHiddenElement")]
    AriaHiddenElement,
    /// <summary>
    /// Corresponds to the <c>"ariaHiddenSubtree"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ariaHiddenSubtree")]
    AriaHiddenSubtree,
    /// <summary>
    /// Corresponds to the <c>"emptyAlt"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("emptyAlt")]
    EmptyAlt,
    /// <summary>
    /// Corresponds to the <c>"emptyText"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("emptyText")]
    EmptyText,
    /// <summary>
    /// Corresponds to the <c>"inertElement"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("inertElement")]
    InertElement,
    /// <summary>
    /// Corresponds to the <c>"inertSubtree"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("inertSubtree")]
    InertSubtree,
    /// <summary>
    /// Corresponds to the <c>"labelContainer"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("labelContainer")]
    LabelContainer,
    /// <summary>
    /// Corresponds to the <c>"labelFor"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("labelFor")]
    LabelFor,
    /// <summary>
    /// Corresponds to the <c>"notRendered"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("notRendered")]
    NotRendered,
    /// <summary>
    /// Corresponds to the <c>"notVisible"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("notVisible")]
    NotVisible,
    /// <summary>
    /// Corresponds to the <c>"presentationalRole"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("presentationalRole")]
    PresentationalRole,
    /// <summary>
    /// Corresponds to the <c>"probablyPresentational"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("probablyPresentational")]
    ProbablyPresentational,
    /// <summary>
    /// Corresponds to the <c>"inactiveCarouselTabContent"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("inactiveCarouselTabContent")]
    InactiveCarouselTabContent,
    /// <summary>
    /// Corresponds to the <c>"uninteresting"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("uninteresting")]
    Uninteresting,
}

/// <summary>
/// A node in the accessibility tree.
/// </summary>
/// <param name="NodeId">
/// Unique identifier for this node.
/// </param>
/// <param name="Ignored">
/// Whether this node is ignored for accessibility
/// </param>
public sealed record AXNode(AXNodeId NodeId, bool Ignored)
{
    /// <summary>
    /// Collection of reasons why this node is hidden.
    /// </summary>
    public ImmutableArray<AXProperty>? IgnoredReasons { get; init; }

    /// <summary>
    /// This <b>Node</b>'s role, whether explicit or implicit.
    /// </summary>
    public AXValue? Role { get; init; }

    /// <summary>
    /// This <b>Node</b>'s Chrome raw role.
    /// </summary>
    public AXValue? ChromeRole { get; init; }

    /// <summary>
    /// The accessible name for this <b>Node</b>.
    /// </summary>
    public AXValue? Name { get; init; }

    /// <summary>
    /// The accessible description for this <b>Node</b>.
    /// </summary>
    public AXValue? Description { get; init; }

    /// <summary>
    /// The value for this <b>Node</b>.
    /// </summary>
    public AXValue? Value { get; init; }

    /// <summary>
    /// All other properties
    /// </summary>
    public ImmutableArray<AXProperty>? Properties { get; init; }

    /// <summary>
    /// ID for this node's parent.
    /// </summary>
    public AXNodeId? ParentId { get; init; }

    /// <summary>
    /// IDs for each of this node's child nodes.
    /// </summary>
    public ImmutableArray<AXNodeId>? ChildIds { get; init; }

    /// <summary>
    /// The backend ID for the associated DOM node, if any.
    /// </summary>
    public DOM.BackendNodeId? BackendDOMNodeId { get; init; }

    /// <summary>
    /// The frame ID for the frame associated with this nodes document.
    /// </summary>
    public Page.FrameId? FrameId { get; init; }
}

[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(GetPartialAXTreeCommandParameters), TypeInfoPropertyName = "GetPartialAXTreeCommandParameters")]
[JsonSerializable(typeof(GetPartialAXTreeResult), TypeInfoPropertyName = "GetPartialAXTreeResult")]
[JsonSerializable(typeof(GetFullAXTreeCommandParameters), TypeInfoPropertyName = "GetFullAXTreeCommandParameters")]
[JsonSerializable(typeof(GetFullAXTreeResult), TypeInfoPropertyName = "GetFullAXTreeResult")]
[JsonSerializable(typeof(GetRootAXNodeCommandParameters), TypeInfoPropertyName = "GetRootAXNodeCommandParameters")]
[JsonSerializable(typeof(GetRootAXNodeResult), TypeInfoPropertyName = "GetRootAXNodeResult")]
[JsonSerializable(typeof(GetAXNodeAndAncestorsCommandParameters), TypeInfoPropertyName = "GetAXNodeAndAncestorsCommandParameters")]
[JsonSerializable(typeof(GetAXNodeAndAncestorsResult), TypeInfoPropertyName = "GetAXNodeAndAncestorsResult")]
[JsonSerializable(typeof(GetChildAXNodesCommandParameters), TypeInfoPropertyName = "GetChildAXNodesCommandParameters")]
[JsonSerializable(typeof(GetChildAXNodesResult), TypeInfoPropertyName = "GetChildAXNodesResult")]
[JsonSerializable(typeof(QueryAXTreeCommandParameters), TypeInfoPropertyName = "QueryAXTreeCommandParameters")]
[JsonSerializable(typeof(QueryAXTreeResult), TypeInfoPropertyName = "QueryAXTreeResult")]
[JsonSerializable(typeof(CdpEventArgs<LoadCompleteEventArgs>), TypeInfoPropertyName = "LoadCompleteCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<NodesUpdatedEventArgs>), TypeInfoPropertyName = "NodesUpdatedCdpEventArgs")]
[JsonSerializable(typeof(AXNodeId), TypeInfoPropertyName = "AccessibilityAXNodeId")]
[JsonSerializable(typeof(AXValueType), TypeInfoPropertyName = "AccessibilityAXValueType")]
[JsonSerializable(typeof(AXValueSourceType), TypeInfoPropertyName = "AccessibilityAXValueSourceType")]
[JsonSerializable(typeof(AXValueNativeSourceType), TypeInfoPropertyName = "AccessibilityAXValueNativeSourceType")]
[JsonSerializable(typeof(AXValueSource), TypeInfoPropertyName = "AccessibilityAXValueSource")]
[JsonSerializable(typeof(AXRelatedNode), TypeInfoPropertyName = "AccessibilityAXRelatedNode")]
[JsonSerializable(typeof(AXProperty), TypeInfoPropertyName = "AccessibilityAXProperty")]
[JsonSerializable(typeof(AXValue), TypeInfoPropertyName = "AccessibilityAXValue")]
[JsonSerializable(typeof(AXPropertyName), TypeInfoPropertyName = "AccessibilityAXPropertyName")]
[JsonSerializable(typeof(AXNode), TypeInfoPropertyName = "AccessibilityAXNode")]
[JsonSerializable(typeof(ImmutableArray<AXNode>), TypeInfoPropertyName = "ImmutableArrayAccessibilityAXNode")]
[JsonSerializable(typeof(ImmutableArray<AXRelatedNode>), TypeInfoPropertyName = "ImmutableArrayAccessibilityAXRelatedNode")]
[JsonSerializable(typeof(ImmutableArray<AXValueSource>), TypeInfoPropertyName = "ImmutableArrayAccessibilityAXValueSource")]
[JsonSerializable(typeof(ImmutableArray<AXProperty>), TypeInfoPropertyName = "ImmutableArrayAccessibilityAXProperty")]
[JsonSerializable(typeof(ImmutableArray<AXNodeId>), TypeInfoPropertyName = "ImmutableArrayAccessibilityAXNodeId")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class AccessibilityJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="IAccessibility"/>.
/// </summary>
public static class AccessibilityDomainEvent
{
    /// <summary>
    /// The loadComplete event mirrors the load complete event sent by the browser to assistive
    /// technology when the web page has finished loading.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<LoadCompleteEventArgs>> LoadComplete =>
        _loadComplete ?? global::System.Threading.Interlocked.CompareExchange(ref _loadComplete, EventDescriptor<CdpEventArgs<LoadCompleteEventArgs>>.Create(
            "goog:cdp.Accessibility.loadComplete",
            AccessibilityJsonSerializerContext.Default.LoadCompleteCdpEventArgs), null) ?? _loadComplete;
    private static EventDescriptor<CdpEventArgs<LoadCompleteEventArgs>>? _loadComplete;

    /// <summary>
    /// The nodesUpdated event is sent every time a previously requested node has changed the in tree.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<NodesUpdatedEventArgs>> NodesUpdated =>
        _nodesUpdated ?? global::System.Threading.Interlocked.CompareExchange(ref _nodesUpdated, EventDescriptor<CdpEventArgs<NodesUpdatedEventArgs>>.Create(
            "goog:cdp.Accessibility.nodesUpdated",
            AccessibilityJsonSerializerContext.Default.NodesUpdatedCdpEventArgs), null) ?? _nodesUpdated;
    private static EventDescriptor<CdpEventArgs<NodesUpdatedEventArgs>>? _nodesUpdated;

}
