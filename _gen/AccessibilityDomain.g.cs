#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Accessibility;

/// <summary>
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class AccessibilityDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static AccessibilityJsonSerializerContext JsonContext = AccessibilityJsonSerializerContext.Default;

    /// <summary>
    /// Disables the accessibility domain.
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
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("Accessibility.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Enables the accessibility domain which causes <b>AXNodeId</b>s to remain consistent between method calls.
    /// This turns on accessibility for the page, which can impact performance until accessibility is disabled.
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
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("Accessibility.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Fetches the accessibility node and partial accessibility tree for this DOM node, if it exists.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>NodeId</b> - Identifier of the node to get the partial accessibility tree for.</description></item>
    /// <item><description><b>BackendNodeId</b> - Identifier of the backend node to get the partial accessibility tree for.</description></item>
    /// <item><description><b>ObjectId</b> - JavaScript object id of the node wrapper to get the partial accessibility tree for.</description></item>
    /// <item><description><b>FetchRelatives</b> - Whether to fetch this node's ancestors, siblings and children. Defaults to true.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetPartialAXTreeCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetPartialAXTreeResult"/>.
    /// </returns>
    public async Task<GetPartialAXTreeResult> GetPartialAXTreeAsync(GetPartialAXTreeCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetPartialAXTreeCommandParameters(NodeId: options?.NodeId, BackendNodeId: options?.BackendNodeId, ObjectId: options?.ObjectId, FetchRelatives: options?.FetchRelatives);
        return await ExecuteCommandAsync(GetPartialAXTreeCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetPartialAXTreeCommandParameters, GetPartialAXTreeResult> GetPartialAXTreeCommand = new("Accessibility.getPartialAXTree", JsonContext.GetPartialAXTreeCommandParameters, JsonContext.GetPartialAXTreeResult);

    /// <summary>
    /// Fetches the entire accessibility tree for the root Document
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Depth</b> - The maximum depth at which descendants of the root node should be retrieved. If omitted, the full tree is returned.</description></item>
    /// <item><description><b>FrameId</b> - The frame for whose document the AX tree should be retrieved. If omitted, the root frame is used.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetFullAXTreeCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetFullAXTreeResult"/>.
    /// </returns>
    public async Task<GetFullAXTreeResult> GetFullAXTreeAsync(GetFullAXTreeCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetFullAXTreeCommandParameters(Depth: options?.Depth, FrameId: options?.FrameId);
        return await ExecuteCommandAsync(GetFullAXTreeCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetFullAXTreeCommandParameters, GetFullAXTreeResult> GetFullAXTreeCommand = new("Accessibility.getFullAXTree", JsonContext.GetFullAXTreeCommandParameters, JsonContext.GetFullAXTreeResult);

    /// <summary>
    /// Fetches the root node.
    /// Requires <b>enable()</b> to have been called previously.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>FrameId</b> - The frame in whose document the node resides. If omitted, the root frame is used.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetRootAXNodeCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetRootAXNodeResult"/>.
    /// </returns>
    public async Task<GetRootAXNodeResult> GetRootAXNodeAsync(GetRootAXNodeCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetRootAXNodeCommandParameters(FrameId: options?.FrameId);
        return await ExecuteCommandAsync(GetRootAXNodeCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetRootAXNodeCommandParameters, GetRootAXNodeResult> GetRootAXNodeCommand = new("Accessibility.getRootAXNode", JsonContext.GetRootAXNodeCommandParameters, JsonContext.GetRootAXNodeResult);

    /// <summary>
    /// Fetches a node and all ancestors up to and including the root.
    /// Requires <b>enable()</b> to have been called previously.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>NodeId</b> - Identifier of the node to get.</description></item>
    /// <item><description><b>BackendNodeId</b> - Identifier of the backend node to get.</description></item>
    /// <item><description><b>ObjectId</b> - JavaScript object id of the node wrapper to get.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetAXNodeAndAncestorsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetAXNodeAndAncestorsResult"/>.
    /// </returns>
    public async Task<GetAXNodeAndAncestorsResult> GetAXNodeAndAncestorsAsync(GetAXNodeAndAncestorsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetAXNodeAndAncestorsCommandParameters(NodeId: options?.NodeId, BackendNodeId: options?.BackendNodeId, ObjectId: options?.ObjectId);
        return await ExecuteCommandAsync(GetAXNodeAndAncestorsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetAXNodeAndAncestorsCommandParameters, GetAXNodeAndAncestorsResult> GetAXNodeAndAncestorsCommand = new("Accessibility.getAXNodeAndAncestors", JsonContext.GetAXNodeAndAncestorsCommandParameters, JsonContext.GetAXNodeAndAncestorsResult);

    /// <summary>
    /// Fetches a particular accessibility node by AXNodeId.
    /// Requires <b>enable()</b> to have been called previously.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>FrameId</b> - The frame in whose document the node resides. If omitted, the root frame is used.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="id">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetChildAXNodesCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetChildAXNodesResult"/>.
    /// </returns>
    public async Task<GetChildAXNodesResult> GetChildAXNodesAsync(AXNodeId id, GetChildAXNodesCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetChildAXNodesCommandParameters(Id: id, FrameId: options?.FrameId);
        return await ExecuteCommandAsync(GetChildAXNodesCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetChildAXNodesCommandParameters, GetChildAXNodesResult> GetChildAXNodesCommand = new("Accessibility.getChildAXNodes", JsonContext.GetChildAXNodesCommandParameters, JsonContext.GetChildAXNodesResult);

    /// <summary>
    /// Query a DOM node's accessibility subtree for accessible name and role.
    /// This command computes the name and role for all nodes in the subtree, including those that are
    /// ignored for accessibility, and returns those that match the specified name and role. If no DOM
    /// node is specified, or the DOM node does not exist, the command returns an error. If neither
    /// <b>accessibleName</b> or <b>role</b> is specified, it returns all the accessibility nodes in the subtree.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>NodeId</b> - Identifier of the node for the root to query.</description></item>
    /// <item><description><b>BackendNodeId</b> - Identifier of the backend node for the root to query.</description></item>
    /// <item><description><b>ObjectId</b> - JavaScript object id of the node wrapper for the root to query.</description></item>
    /// <item><description><b>AccessibleName</b> - Find nodes with this computed name.</description></item>
    /// <item><description><b>Role</b> - Find nodes with this computed role.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="QueryAXTreeCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="QueryAXTreeResult"/>.
    /// </returns>
    public async Task<QueryAXTreeResult> QueryAXTreeAsync(QueryAXTreeCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new QueryAXTreeCommandParameters(NodeId: options?.NodeId, BackendNodeId: options?.BackendNodeId, ObjectId: options?.ObjectId, AccessibleName: options?.AccessibleName, Role: options?.Role);
        return await ExecuteCommandAsync(QueryAXTreeCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<QueryAXTreeCommandParameters, QueryAXTreeResult> QueryAXTreeCommand = new("Accessibility.queryAXTree", JsonContext.QueryAXTreeCommandParameters, JsonContext.QueryAXTreeResult);

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
    public IEventSource<LoadCompleteEventArgs> LoadComplete => CreateCdpEventSource(AccessibilityDomainEvent.LoadComplete);
    /// <summary>
    /// The nodesUpdated event is sent every time a previously requested node has changed the in tree.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="NodesUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Nodes</b> - Updated node data.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<NodesUpdatedEventArgs> NodesUpdated => CreateCdpEventSource(AccessibilityDomainEvent.NodesUpdated);
}

internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="AccessibilityDomain.DisableAsync"/>.
/// </summary>
public sealed record DisableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="AccessibilityDomain.EnableAsync"/>.
/// </summary>
public sealed record EnableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record GetPartialAXTreeCommandParameters(DOM.NodeId? NodeId, DOM.BackendNodeId? BackendNodeId, Runtime.RemoteObjectId? ObjectId, bool? FetchRelatives) : Parameters;

/// <summary>
/// Optional parameters for <see cref="AccessibilityDomain.GetPartialAXTreeAsync"/>.
/// </summary>
public sealed record GetPartialAXTreeCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Identifier of the node to get the partial accessibility tree for.
    /// </summary>
    public DOM.NodeId? NodeId { get; init; }

    /// <summary>
    /// Identifier of the backend node to get the partial accessibility tree for.
    /// </summary>
    public DOM.BackendNodeId? BackendNodeId { get; init; }

    /// <summary>
    /// JavaScript object id of the node wrapper to get the partial accessibility tree for.
    /// </summary>
    public Runtime.RemoteObjectId? ObjectId { get; init; }

    /// <summary>
    /// Whether to fetch this node's ancestors, siblings and children. Defaults to true.
    /// </summary>
    public bool? FetchRelatives { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Nodes">
/// The <b>Accessibility.AXNode</b> for this DOM node, if it exists, plus its ancestors, siblings and
/// children, if requested.
/// </param>
public sealed record GetPartialAXTreeResult(IReadOnlyList<AXNode> Nodes) : EmptyResult;


internal sealed record GetFullAXTreeCommandParameters(long? Depth, Page.FrameId? FrameId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="AccessibilityDomain.GetFullAXTreeAsync"/>.
/// </summary>
public sealed record GetFullAXTreeCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// The maximum depth at which descendants of the root node should be retrieved.
    /// If omitted, the full tree is returned.
    /// </summary>
    public long? Depth { get; init; }

    /// <summary>
    /// The frame for whose document the AX tree should be retrieved.
    /// If omitted, the root frame is used.
    /// </summary>
    public Page.FrameId? FrameId { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Nodes">
/// </param>
public sealed record GetFullAXTreeResult(IReadOnlyList<AXNode> Nodes) : EmptyResult;


internal sealed record GetRootAXNodeCommandParameters(Page.FrameId? FrameId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="AccessibilityDomain.GetRootAXNodeAsync"/>.
/// </summary>
public sealed record GetRootAXNodeCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// The frame in whose document the node resides.
    /// If omitted, the root frame is used.
    /// </summary>
    public Page.FrameId? FrameId { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Node">
/// </param>
public sealed record GetRootAXNodeResult(AXNode Node) : EmptyResult;


internal sealed record GetAXNodeAndAncestorsCommandParameters(DOM.NodeId? NodeId, DOM.BackendNodeId? BackendNodeId, Runtime.RemoteObjectId? ObjectId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="AccessibilityDomain.GetAXNodeAndAncestorsAsync"/>.
/// </summary>
public sealed record GetAXNodeAndAncestorsCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Identifier of the node to get.
    /// </summary>
    public DOM.NodeId? NodeId { get; init; }

    /// <summary>
    /// Identifier of the backend node to get.
    /// </summary>
    public DOM.BackendNodeId? BackendNodeId { get; init; }

    /// <summary>
    /// JavaScript object id of the node wrapper to get.
    /// </summary>
    public Runtime.RemoteObjectId? ObjectId { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Nodes">
/// </param>
public sealed record GetAXNodeAndAncestorsResult(IReadOnlyList<AXNode> Nodes) : EmptyResult;


internal sealed record GetChildAXNodesCommandParameters(AXNodeId Id, Page.FrameId? FrameId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="AccessibilityDomain.GetChildAXNodesAsync"/>.
/// </summary>
public sealed record GetChildAXNodesCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// The frame in whose document the node resides.
    /// If omitted, the root frame is used.
    /// </summary>
    public Page.FrameId? FrameId { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Nodes">
/// </param>
public sealed record GetChildAXNodesResult(IReadOnlyList<AXNode> Nodes) : EmptyResult;


internal sealed record QueryAXTreeCommandParameters(DOM.NodeId? NodeId, DOM.BackendNodeId? BackendNodeId, Runtime.RemoteObjectId? ObjectId, string? AccessibleName, string? Role) : Parameters;

/// <summary>
/// Optional parameters for <see cref="AccessibilityDomain.QueryAXTreeAsync"/>.
/// </summary>
public sealed record QueryAXTreeCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Identifier of the node for the root to query.
    /// </summary>
    public DOM.NodeId? NodeId { get; init; }

    /// <summary>
    /// Identifier of the backend node for the root to query.
    /// </summary>
    public DOM.BackendNodeId? BackendNodeId { get; init; }

    /// <summary>
    /// JavaScript object id of the node wrapper for the root to query.
    /// </summary>
    public Runtime.RemoteObjectId? ObjectId { get; init; }

    /// <summary>
    /// Find nodes with this computed name.
    /// </summary>
    public string? AccessibleName { get; init; }

    /// <summary>
    /// Find nodes with this computed role.
    /// </summary>
    public string? Role { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Nodes">
/// A list of <b>Accessibility.AXNode</b> matching the specified attributes,
/// including nodes that are ignored for accessibility.
/// </param>
public sealed record QueryAXTreeResult(IReadOnlyList<AXNode> Nodes) : EmptyResult;


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
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("boolean")]
    Boolean,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("tristate")]
    Tristate,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("booleanOrUndefined")]
    BooleanOrUndefined,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("idref")]
    Idref,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("idrefList")]
    IdrefList,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("integer")]
    Integer,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("node")]
    Node,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("nodeList")]
    NodeList,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("number")]
    Number,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("string")]
    String,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("computedString")]
    ComputedString,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("token")]
    Token,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("tokenList")]
    TokenList,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("domRelation")]
    DomRelation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("role")]
    Role,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("internalRole")]
    InternalRole,
    /// <summary>
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
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("attribute")]
    Attribute,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("implicit")]
    Implicit,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("style")]
    Style,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("contents")]
    Contents,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("placeholder")]
    Placeholder,
    /// <summary>
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
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("description")]
    Description,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("figcaption")]
    Figcaption,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("label")]
    Label,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("labelfor")]
    Labelfor,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("labelwrapped")]
    Labelwrapped,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("legend")]
    Legend,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("rubyannotation")]
    Rubyannotation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("tablecaption")]
    Tablecaption,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("title")]
    Title,
    /// <summary>
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
    public IReadOnlyList<AXRelatedNode>? RelatedNodes { get; init; }

    /// <summary>
    /// The sources which contributed to the computation of this property.
    /// </summary>
    public IReadOnlyList<AXValueSource>? Sources { get; init; }
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
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("actions")]
    Actions,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("busy")]
    Busy,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("disabled")]
    Disabled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("editable")]
    Editable,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("focusable")]
    Focusable,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("focused")]
    Focused,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("hidden")]
    Hidden,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("hiddenRoot")]
    HiddenRoot,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("invalid")]
    Invalid,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("keyshortcuts")]
    Keyshortcuts,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("settable")]
    Settable,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("roledescription")]
    Roledescription,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("live")]
    Live,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("atomic")]
    Atomic,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("relevant")]
    Relevant,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("root")]
    Root,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("autocomplete")]
    Autocomplete,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("hasPopup")]
    HasPopup,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("level")]
    Level,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("multiselectable")]
    Multiselectable,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("orientation")]
    Orientation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("multiline")]
    Multiline,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("readonly")]
    Readonly,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("required")]
    Required,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("valuemin")]
    Valuemin,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("valuemax")]
    Valuemax,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("valuetext")]
    Valuetext,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("checked")]
    Checked,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("expanded")]
    Expanded,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("modal")]
    Modal,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("pressed")]
    Pressed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("selected")]
    Selected,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("activedescendant")]
    Activedescendant,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("controls")]
    Controls,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("describedby")]
    Describedby,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("details")]
    Details,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("errormessage")]
    Errormessage,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("flowto")]
    Flowto,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("labelledby")]
    Labelledby,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("owns")]
    Owns,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("url")]
    Url,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("activeFullscreenElement")]
    ActiveFullscreenElement,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("activeModalDialog")]
    ActiveModalDialog,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("activeAriaModalDialog")]
    ActiveAriaModalDialog,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ariaHiddenElement")]
    AriaHiddenElement,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ariaHiddenSubtree")]
    AriaHiddenSubtree,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("emptyAlt")]
    EmptyAlt,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("emptyText")]
    EmptyText,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("inertElement")]
    InertElement,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("inertSubtree")]
    InertSubtree,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("labelContainer")]
    LabelContainer,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("labelFor")]
    LabelFor,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("notRendered")]
    NotRendered,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("notVisible")]
    NotVisible,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("presentationalRole")]
    PresentationalRole,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("probablyPresentational")]
    ProbablyPresentational,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("inactiveCarouselTabContent")]
    InactiveCarouselTabContent,
    /// <summary>
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
    public IReadOnlyList<AXProperty>? IgnoredReasons { get; init; }

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
    public IReadOnlyList<AXProperty>? Properties { get; init; }

    /// <summary>
    /// ID for this node's parent.
    /// </summary>
    public AXNodeId? ParentId { get; init; }

    /// <summary>
    /// IDs for each of this node's child nodes.
    /// </summary>
    public IReadOnlyList<AXNodeId>? ChildIds { get; init; }

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
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<AXNode>), TypeInfoPropertyName = "IReadOnlyListAccessibilityAXNode")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<AXRelatedNode>), TypeInfoPropertyName = "IReadOnlyListAccessibilityAXRelatedNode")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<AXValueSource>), TypeInfoPropertyName = "IReadOnlyListAccessibilityAXValueSource")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<AXProperty>), TypeInfoPropertyName = "IReadOnlyListAccessibilityAXProperty")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<AXNodeId>), TypeInfoPropertyName = "IReadOnlyListAccessibilityAXNodeId")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class AccessibilityJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="AccessibilityDomain"/>.
/// </summary>
public static class AccessibilityDomainEvent
{
    /// <summary>
    /// The loadComplete event mirrors the load complete event sent by the browser to assistive
    /// technology when the web page has finished loading.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<LoadCompleteEventArgs>> LoadComplete { get; } =
        EventDescriptor<CdpEventArgs<LoadCompleteEventArgs>>.Create(
            "goog:cdp.Accessibility.loadComplete",
            AccessibilityJsonSerializerContext.Default.LoadCompleteCdpEventArgs);

    /// <summary>
    /// The nodesUpdated event is sent every time a previously requested node has changed the in tree.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<NodesUpdatedEventArgs>> NodesUpdated { get; } =
        EventDescriptor<CdpEventArgs<NodesUpdatedEventArgs>>.Create(
            "goog:cdp.Accessibility.nodesUpdated",
            AccessibilityJsonSerializerContext.Default.NodesUpdatedCdpEventArgs);

}
