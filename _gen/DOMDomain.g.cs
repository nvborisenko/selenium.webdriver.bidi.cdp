#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.DOM;

/// <summary>
/// This domain exposes DOM read/write operations. Each DOM Node is represented with its mirror object
/// that has an <b>id</b>. This <b>id</b> can be used to get additional information on the Node, resolve it into
/// the JavaScript object wrapper, etc. It is important that client receives DOM events only for the
/// nodes that are known to the client. Backend keeps track of the nodes that were sent to the client
/// and never sends the same node twice. It is client's responsibility to collect information about
/// the nodes that were sent to the client. Note that <b>iframe</b> owner elements will return
/// corresponding document elements as their child nodes.
/// </summary>
public interface IDOM
{
    /// <summary>
    /// Collects class names for the node with given id and all of it's child nodes.
    /// </summary>
    /// <param name="nodeId">
    /// Id of the node to collect class names.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CollectClassNamesFromSubtreeResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<CollectClassNamesFromSubtreeResult> CollectClassNamesFromSubtreeAsync(NodeId nodeId, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a deep copy of the specified node and places it into the target container before the
    /// given anchor.
    /// </summary>
    /// <param name="nodeId">
    /// Id of the node to copy.
    /// </param>
    /// <param name="targetNodeId">
    /// Id of the element to drop the copy into.
    /// </param>
    /// <param name="insertBeforeNodeId">
    /// Drop the copy before this node (if absent, the copy becomes the last child of
    /// <b>targetNodeId</b>).
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CopyToResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<CopyToResult> CopyToAsync(NodeId nodeId, NodeId targetNodeId, NodeId? insertBeforeNodeId = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Describes node given its id, does not require domain to be enabled. Does not start tracking any
    /// objects, can be used for automation.
    /// </summary>
    /// <param name="nodeId">
    /// Identifier of the node.
    /// </param>
    /// <param name="backendNodeId">
    /// Identifier of the backend node.
    /// </param>
    /// <param name="objectId">
    /// JavaScript object id of the node wrapper.
    /// </param>
    /// <param name="depth">
    /// The maximum depth at which children should be retrieved, defaults to 1. Use -1 for the
    /// entire subtree or provide an integer larger than 0.
    /// </param>
    /// <param name="pierce">
    /// Whether or not iframes and shadow roots should be traversed when returning the subtree
    /// (default is false).
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DescribeNodeResult"/>.
    /// </returns>
    Task<DescribeNodeResult> DescribeNodeAsync(NodeId? nodeId = default, BackendNodeId? backendNodeId = default, Runtime.RemoteObjectId? objectId = default, long? depth = default, bool? pierce = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Scrolls the specified rect of the given node into view if not already visible.
    /// Note: exactly one between nodeId, backendNodeId and objectId should be passed
    /// to identify the node.
    /// </summary>
    /// <param name="nodeId">
    /// Identifier of the node.
    /// </param>
    /// <param name="backendNodeId">
    /// Identifier of the backend node.
    /// </param>
    /// <param name="objectId">
    /// JavaScript object id of the node wrapper.
    /// </param>
    /// <param name="rect">
    /// The rect to be scrolled into view, relative to the node's border box, in CSS pixels.
    /// When omitted, center of the node will be used, similar to Element.scrollIntoView.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ScrollIntoViewIfNeededResult"/>.
    /// </returns>
    Task<ScrollIntoViewIfNeededResult> ScrollIntoViewIfNeededAsync(NodeId? nodeId = default, BackendNodeId? backendNodeId = default, Runtime.RemoteObjectId? objectId = default, Rect? rect = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disables DOM agent for the given page.
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
    /// Discards search results from the session with the given id. <b>getSearchResults</b> should no longer
    /// be called for that search.
    /// </summary>
    /// <param name="searchId">
    /// Unique search session identifier.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DiscardSearchResultsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<DiscardSearchResultsResult> DiscardSearchResultsAsync(string searchId, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Enables DOM agent for the given page.
    /// </summary>
    /// <param name="includeWhitespace">
    /// Whether to include whitespaces in the children array of returned Nodes.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="EnableResult"/>.
    /// </returns>
    Task<EnableResult> EnableAsync(string? includeWhitespace = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Focuses the given element.
    /// </summary>
    /// <param name="nodeId">
    /// Identifier of the node.
    /// </param>
    /// <param name="backendNodeId">
    /// Identifier of the backend node.
    /// </param>
    /// <param name="objectId">
    /// JavaScript object id of the node wrapper.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="FocusResult"/>.
    /// </returns>
    Task<FocusResult> FocusAsync(NodeId? nodeId = default, BackendNodeId? backendNodeId = default, Runtime.RemoteObjectId? objectId = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns attributes for the specified node.
    /// </summary>
    /// <param name="nodeId">
    /// Id of the node to retrieve attributes for.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetAttributesResult"/>.
    /// </returns>
    Task<GetAttributesResult> GetAttributesAsync(NodeId nodeId, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns boxes for the given node.
    /// </summary>
    /// <param name="nodeId">
    /// Identifier of the node.
    /// </param>
    /// <param name="backendNodeId">
    /// Identifier of the backend node.
    /// </param>
    /// <param name="objectId">
    /// JavaScript object id of the node wrapper.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetBoxModelResult"/>.
    /// </returns>
    Task<GetBoxModelResult> GetBoxModelAsync(NodeId? nodeId = default, BackendNodeId? backendNodeId = default, Runtime.RemoteObjectId? objectId = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns quads that describe node position on the page. This method
    /// might return multiple quads for inline nodes.
    /// </summary>
    /// <param name="nodeId">
    /// Identifier of the node.
    /// </param>
    /// <param name="backendNodeId">
    /// Identifier of the backend node.
    /// </param>
    /// <param name="objectId">
    /// JavaScript object id of the node wrapper.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetContentQuadsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetContentQuadsResult> GetContentQuadsAsync(NodeId? nodeId = default, BackendNodeId? backendNodeId = default, Runtime.RemoteObjectId? objectId = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the root DOM node (and optionally the subtree) to the caller.
    /// Implicitly enables the DOM domain events for the current target.
    /// </summary>
    /// <param name="depth">
    /// The maximum depth at which children should be retrieved, defaults to 1. Use -1 for the
    /// entire subtree or provide an integer larger than 0.
    /// </param>
    /// <param name="pierce">
    /// Whether or not iframes and shadow roots should be traversed when returning the subtree
    /// (default is false).
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetDocumentResult"/>.
    /// </returns>
    Task<GetDocumentResult> GetDocumentAsync(long? depth = default, bool? pierce = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the root DOM node (and optionally the subtree) to the caller.
    /// Deprecated, as it is not designed to work well with the rest of the DOM agent.
    /// Use DOMSnapshot.captureSnapshot instead.
    /// </summary>
    /// <param name="depth">
    /// The maximum depth at which children should be retrieved, defaults to 1. Use -1 for the
    /// entire subtree or provide an integer larger than 0.
    /// </param>
    /// <param name="pierce">
    /// Whether or not iframes and shadow roots should be traversed when returning the subtree
    /// (default is false).
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetFlattenedDocumentResult"/>.
    /// </returns>
    [global::System.Obsolete]
    Task<GetFlattenedDocumentResult> GetFlattenedDocumentAsync(long? depth = default, bool? pierce = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Finds nodes with a given computed style in a subtree.
    /// </summary>
    /// <param name="nodeId">
    /// Node ID pointing to the root of a subtree.
    /// </param>
    /// <param name="computedStyles">
    /// The style to filter nodes by (includes nodes if any of properties matches).
    /// </param>
    /// <param name="pierce">
    /// Whether or not iframes and shadow roots in the same target should be traversed when returning the
    /// results (default is false).
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetNodesForSubtreeByStyleResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetNodesForSubtreeByStyleResult> GetNodesForSubtreeByStyleAsync(NodeId nodeId, ImmutableArray<CSSComputedStyleProperty> computedStyles, bool? pierce = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns node id at given location. Depending on whether DOM domain is enabled, nodeId is
    /// either returned or not.
    /// </summary>
    /// <param name="x">
    /// X coordinate.
    /// </param>
    /// <param name="y">
    /// Y coordinate.
    /// </param>
    /// <param name="includeUserAgentShadowDOM">
    /// False to skip to the nearest non-UA shadow root ancestor (default: false).
    /// </param>
    /// <param name="ignorePointerEventsNone">
    /// Whether to ignore pointer-events: none on elements and hit test them.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetNodeForLocationResult"/>.
    /// </returns>
    Task<GetNodeForLocationResult> GetNodeForLocationAsync(long x, long y, bool? includeUserAgentShadowDOM = default, bool? ignorePointerEventsNone = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns node's HTML markup.
    /// </summary>
    /// <param name="nodeId">
    /// Identifier of the node.
    /// </param>
    /// <param name="backendNodeId">
    /// Identifier of the backend node.
    /// </param>
    /// <param name="objectId">
    /// JavaScript object id of the node wrapper.
    /// </param>
    /// <param name="includeShadowDOM">
    /// Include all shadow roots. Equals to false if not specified.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetOuterHTMLResult"/>.
    /// </returns>
    Task<GetOuterHTMLResult> GetOuterHTMLAsync(NodeId? nodeId = default, BackendNodeId? backendNodeId = default, Runtime.RemoteObjectId? objectId = default, bool? includeShadowDOM = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the id of the nearest ancestor that is a relayout boundary.
    /// </summary>
    /// <param name="nodeId">
    /// Id of the node.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetRelayoutBoundaryResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetRelayoutBoundaryResult> GetRelayoutBoundaryAsync(NodeId nodeId, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns search results from given <b>fromIndex</b> to given <b>toIndex</b> from the search with the given
    /// identifier.
    /// </summary>
    /// <param name="searchId">
    /// Unique search session identifier.
    /// </param>
    /// <param name="fromIndex">
    /// Start index of the search result to be returned.
    /// </param>
    /// <param name="toIndex">
    /// End index of the search result to be returned.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetSearchResultsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetSearchResultsResult> GetSearchResultsAsync(string searchId, long fromIndex, long toIndex, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Hides any highlight.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="HideHighlightResult"/>.
    /// </returns>
    Task<HideHighlightResult> HideHighlightAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Highlights DOM node.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="HighlightNodeResult"/>.
    /// </returns>
    Task<HighlightNodeResult> HighlightNodeAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Highlights given rectangle.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="HighlightRectResult"/>.
    /// </returns>
    Task<HighlightRectResult> HighlightRectAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Marks last undoable state.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="MarkUndoableStateResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<MarkUndoableStateResult> MarkUndoableStateAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Moves node into the new container, places it before the given anchor.
    /// </summary>
    /// <param name="nodeId">
    /// Id of the node to move.
    /// </param>
    /// <param name="targetNodeId">
    /// Id of the element to drop the moved node into.
    /// </param>
    /// <param name="insertBeforeNodeId">
    /// Drop node before this one (if absent, the moved node becomes the last child of
    /// <b>targetNodeId</b>).
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="MoveToResult"/>.
    /// </returns>
    Task<MoveToResult> MoveToAsync(NodeId nodeId, NodeId targetNodeId, NodeId? insertBeforeNodeId = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Searches for a given string in the DOM tree. Use <b>getSearchResults</b> to access search results or
    /// <b>cancelSearch</b> to end this search session.
    /// </summary>
    /// <param name="query">
    /// Plain text or query selector or XPath search query.
    /// </param>
    /// <param name="includeUserAgentShadowDOM">
    /// True to search in user agent shadow DOM.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="PerformSearchResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<PerformSearchResult> PerformSearchAsync(string query, bool? includeUserAgentShadowDOM = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Requests that the node is sent to the caller given its path. // FIXME, use XPath
    /// </summary>
    /// <param name="path">
    /// Path to node in the proprietary format.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="PushNodeByPathToFrontendResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<PushNodeByPathToFrontendResult> PushNodeByPathToFrontendAsync(string path, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Requests that a batch of nodes is sent to the caller given their backend node ids.
    /// </summary>
    /// <param name="backendNodeIds">
    /// The array of backend node ids.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="PushNodesByBackendIdsToFrontendResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<PushNodesByBackendIdsToFrontendResult> PushNodesByBackendIdsToFrontendAsync(ImmutableArray<BackendNodeId> backendNodeIds, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Executes <b>querySelector</b> on a given node.
    /// </summary>
    /// <param name="nodeId">
    /// Id of the node to query upon.
    /// </param>
    /// <param name="selector">
    /// Selector string.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="QuerySelectorResult"/>.
    /// </returns>
    Task<QuerySelectorResult> QuerySelectorAsync(NodeId nodeId, string selector, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Executes <b>querySelectorAll</b> on a given node.
    /// </summary>
    /// <param name="nodeId">
    /// Id of the node to query upon.
    /// </param>
    /// <param name="selector">
    /// Selector string.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="QuerySelectorAllResult"/>.
    /// </returns>
    Task<QuerySelectorAllResult> QuerySelectorAllAsync(NodeId nodeId, string selector, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns NodeIds of current top layer elements.
    /// Top layer is rendered closest to the user within a viewport, therefore its elements always
    /// appear on top of all other content.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetTopLayerElementsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetTopLayerElementsResult> GetTopLayerElementsAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the NodeId of the matched element according to certain relations.
    /// </summary>
    /// <param name="nodeId">
    /// Id of the node from which to query the relation.
    /// </param>
    /// <param name="relation">
    /// Type of relation to get.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetElementByRelationResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetElementByRelationResult> GetElementByRelationAsync(NodeId nodeId, string relation, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Re-does the last undone action.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RedoResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<RedoResult> RedoAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Removes attribute with given name from an element with given id.
    /// </summary>
    /// <param name="nodeId">
    /// Id of the element to remove attribute from.
    /// </param>
    /// <param name="name">
    /// Name of the attribute to remove.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RemoveAttributeResult"/>.
    /// </returns>
    Task<RemoveAttributeResult> RemoveAttributeAsync(NodeId nodeId, string name, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Removes node with given id.
    /// </summary>
    /// <param name="nodeId">
    /// Id of the node to remove.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RemoveNodeResult"/>.
    /// </returns>
    Task<RemoveNodeResult> RemoveNodeAsync(NodeId nodeId, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Requests that children of the node with given id are returned to the caller in form of
    /// <b>setChildNodes</b> events where not only immediate children are retrieved, but all children down to
    /// the specified depth.
    /// </summary>
    /// <param name="nodeId">
    /// Id of the node to get children for.
    /// </param>
    /// <param name="depth">
    /// The maximum depth at which children should be retrieved, defaults to 1. Use -1 for the
    /// entire subtree or provide an integer larger than 0.
    /// </param>
    /// <param name="pierce">
    /// Whether or not iframes and shadow roots should be traversed when returning the sub-tree
    /// (default is false).
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RequestChildNodesResult"/>.
    /// </returns>
    Task<RequestChildNodesResult> RequestChildNodesAsync(NodeId nodeId, long? depth = default, bool? pierce = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Requests that the node is sent to the caller given the JavaScript node object reference. All
    /// nodes that form the path from the node to the root are also sent to the client as a series of
    /// <b>setChildNodes</b> notifications.
    /// </summary>
    /// <param name="objectId">
    /// JavaScript object id to convert into node.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RequestNodeResult"/>.
    /// </returns>
    Task<RequestNodeResult> RequestNodeAsync(Runtime.RemoteObjectId objectId, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Resolves the JavaScript node object for a given NodeId or BackendNodeId.
    /// </summary>
    /// <param name="nodeId">
    /// Id of the node to resolve.
    /// </param>
    /// <param name="backendNodeId">
    /// Backend identifier of the node to resolve.
    /// </param>
    /// <param name="objectGroup">
    /// Symbolic group name that can be used to release multiple objects.
    /// </param>
    /// <param name="executionContextId">
    /// Execution context in which to resolve the node.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ResolveNodeResult"/>.
    /// </returns>
    Task<ResolveNodeResult> ResolveNodeAsync(NodeId? nodeId = default, DOM.BackendNodeId? backendNodeId = default, string? objectGroup = default, Runtime.ExecutionContextId? executionContextId = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Sets attribute for an element with given id.
    /// </summary>
    /// <param name="nodeId">
    /// Id of the element to set attribute for.
    /// </param>
    /// <param name="name">
    /// Attribute name.
    /// </param>
    /// <param name="value">
    /// Attribute value.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetAttributeValueResult"/>.
    /// </returns>
    Task<SetAttributeValueResult> SetAttributeValueAsync(NodeId nodeId, string name, string value, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Sets attributes on element with given id. This method is useful when user edits some existing
    /// attribute value and types in several attribute name/value pairs.
    /// </summary>
    /// <param name="nodeId">
    /// Id of the element to set attributes for.
    /// </param>
    /// <param name="text">
    /// Text with a number of attributes. Will parse this text using HTML parser.
    /// </param>
    /// <param name="name">
    /// Attribute name to replace with new attributes derived from text in case text parsed
    /// successfully.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetAttributesAsTextResult"/>.
    /// </returns>
    Task<SetAttributesAsTextResult> SetAttributesAsTextAsync(NodeId nodeId, string text, string? name = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Sets files for the given file input element.
    /// </summary>
    /// <param name="files">
    /// Array of file paths to set.
    /// </param>
    /// <param name="nodeId">
    /// Identifier of the node.
    /// </param>
    /// <param name="backendNodeId">
    /// Identifier of the backend node.
    /// </param>
    /// <param name="objectId">
    /// JavaScript object id of the node wrapper.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetFileInputFilesResult"/>.
    /// </returns>
    Task<SetFileInputFilesResult> SetFileInputFilesAsync(ImmutableArray<string> files, NodeId? nodeId = default, BackendNodeId? backendNodeId = default, Runtime.RemoteObjectId? objectId = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Sets if stack traces should be captured for Nodes. See <b>Node.getNodeStackTraces</b>. Default is disabled.
    /// </summary>
    /// <param name="enable">
    /// Enable or disable.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetNodeStackTracesEnabledResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<SetNodeStackTracesEnabledResult> SetNodeStackTracesEnabledAsync(bool enable, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets stack traces associated with a Node. As of now, only provides stack trace for Node creation.
    /// </summary>
    /// <param name="nodeId">
    /// Id of the node to get stack traces for.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetNodeStackTracesResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetNodeStackTracesResult> GetNodeStackTracesAsync(NodeId nodeId, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns file information for the given
    /// File wrapper.
    /// </summary>
    /// <param name="objectId">
    /// JavaScript object id of the node wrapper.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetFileInfoResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetFileInfoResult> GetFileInfoAsync(Runtime.RemoteObjectId objectId, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns list of detached nodes
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetDetachedDomNodesResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetDetachedDomNodesResult> GetDetachedDomNodesAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Enables console to refer to the node with given id via $x (see Command Line API for more details
    /// $x functions).
    /// </summary>
    /// <param name="nodeId">
    /// DOM node id to be accessible by means of $x command line API.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetInspectedNodeResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<SetInspectedNodeResult> SetInspectedNodeAsync(NodeId nodeId, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Sets node name for a node with given id.
    /// </summary>
    /// <param name="nodeId">
    /// Id of the node to set name for.
    /// </param>
    /// <param name="name">
    /// New node's name.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetNodeNameResult"/>.
    /// </returns>
    Task<SetNodeNameResult> SetNodeNameAsync(NodeId nodeId, string name, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Sets node value for a node with given id.
    /// </summary>
    /// <param name="nodeId">
    /// Id of the node to set value for.
    /// </param>
    /// <param name="value">
    /// New node's value.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetNodeValueResult"/>.
    /// </returns>
    Task<SetNodeValueResult> SetNodeValueAsync(NodeId nodeId, string value, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Sets node HTML markup, returns new node id.
    /// </summary>
    /// <param name="nodeId">
    /// Id of the node to set markup for.
    /// </param>
    /// <param name="outerHTML">
    /// Outer HTML markup to set.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetOuterHTMLResult"/>.
    /// </returns>
    Task<SetOuterHTMLResult> SetOuterHTMLAsync(NodeId nodeId, string outerHTML, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Undoes the last performed action.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="UndoResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<UndoResult> UndoAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns iframe node that owns iframe with the given domain.
    /// </summary>
    /// <param name="frameId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetFrameOwnerResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetFrameOwnerResult> GetFrameOwnerAsync(Page.FrameId frameId, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the query container of the given node based on container query
    /// conditions: containerName, physical and logical axes, and whether it queries
    /// scroll-state or anchored elements. If no axes are provided and
    /// queriesScrollState is false, the style container is returned, which is the
    /// direct parent or the closest element with a matching container-name.
    /// </summary>
    /// <param name="nodeId">
    /// </param>
    /// <param name="containerName">
    /// </param>
    /// <param name="physicalAxes">
    /// </param>
    /// <param name="logicalAxes">
    /// </param>
    /// <param name="queriesScrollState">
    /// </param>
    /// <param name="queriesAnchored">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetContainerForNodeResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetContainerForNodeResult> GetContainerForNodeAsync(NodeId nodeId, string? containerName = default, PhysicalAxes? physicalAxes = default, LogicalAxes? logicalAxes = default, bool? queriesScrollState = default, bool? queriesAnchored = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the descendants of a container query container that have
    /// container queries against this container.
    /// </summary>
    /// <param name="nodeId">
    /// Id of the container node to find querying descendants from.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetQueryingDescendantsForContainerResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetQueryingDescendantsForContainerResult> GetQueryingDescendantsForContainerAsync(NodeId nodeId, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the target anchor element of the given anchor query according to
    /// https://www.w3.org/TR/css-anchor-position-1/#target.
    /// </summary>
    /// <param name="nodeId">
    /// Id of the positioned element from which to find the anchor.
    /// </param>
    /// <param name="anchorSpecifier">
    /// An optional anchor specifier, as defined in
    /// https://www.w3.org/TR/css-anchor-position-1/#anchor-specifier.
    /// If not provided, it will return the implicit anchor element for
    /// the given positioned element.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetAnchorElementResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetAnchorElementResult> GetAnchorElementAsync(NodeId nodeId, string? anchorSpecifier = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// When enabling, this API force-opens the popover identified by nodeId
    /// and keeps it open until disabled.
    /// </summary>
    /// <param name="nodeId">
    /// Id of the popover HTMLElement
    /// </param>
    /// <param name="enable">
    /// If true, opens the popover and keeps it open. If false, closes the
    /// popover if it was previously force-opened.
    /// </param>
    /// <param name="invokerNodeId">
    /// Optional ID of the element invoking this popover, used to establish the implicit anchor.
    /// If not provided, it will fall back to the first invoker in the document, preferring
    /// elements with a popovertarget attribute over those with a commandfor attribute. Note that
    /// if there are multiple invokers, this is just an estimate.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ForceShowPopoverResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<ForceShowPopoverResult> ForceShowPopoverAsync(NodeId nodeId, bool enable, BackendNodeId? invokerNodeId = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Fired when <b>Element</b>'s attribute is modified.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="AttributeModifiedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>NodeId</b> - Id of the node that has changed.</description></item>
    /// <item><description><b>Name</b> - Attribute name.</description></item>
    /// <item><description><b>Value</b> - Attribute value.</description></item>
    /// </list>
    /// </remarks>
    IEventSource<AttributeModifiedEventArgs> AttributeModified { get; }

    /// <summary>
    /// Fired when <b>Element</b>'s adoptedStyleSheets are modified.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="AdoptedStyleSheetsModifiedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>NodeId</b> - Id of the node that has changed.</description></item>
    /// <item><description><b>AdoptedStyleSheets</b> - New adoptedStyleSheets array.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    IEventSource<AdoptedStyleSheetsModifiedEventArgs> AdoptedStyleSheetsModified { get; }

    /// <summary>
    /// Fired when <b>Element</b>'s attribute is removed.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="AttributeRemovedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>NodeId</b> - Id of the node that has changed.</description></item>
    /// <item><description><b>Name</b> - A ttribute name.</description></item>
    /// </list>
    /// </remarks>
    IEventSource<AttributeRemovedEventArgs> AttributeRemoved { get; }

    /// <summary>
    /// Mirrors <b>DOMCharacterDataModified</b> event.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="CharacterDataModifiedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>NodeId</b> - Id of the node that has changed.</description></item>
    /// <item><description><b>CharacterData</b> - New text value.</description></item>
    /// </list>
    /// </remarks>
    IEventSource<CharacterDataModifiedEventArgs> CharacterDataModified { get; }

    /// <summary>
    /// Fired when <b>Container</b>'s child node count has changed.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ChildNodeCountUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>NodeId</b> - Id of the node that has changed.</description></item>
    /// <item><description><b>ChildNodeCount</b> - New node count.</description></item>
    /// </list>
    /// </remarks>
    IEventSource<ChildNodeCountUpdatedEventArgs> ChildNodeCountUpdated { get; }

    /// <summary>
    /// Mirrors <b>DOMNodeInserted</b> event.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ChildNodeInsertedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>ParentNodeId</b> - Id of the node that has changed.</description></item>
    /// <item><description><b>PreviousNodeId</b> - Id of the previous sibling.</description></item>
    /// <item><description><b>Node</b> - Inserted node data.</description></item>
    /// </list>
    /// </remarks>
    IEventSource<ChildNodeInsertedEventArgs> ChildNodeInserted { get; }

    /// <summary>
    /// Mirrors <b>DOMNodeRemoved</b> event.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ChildNodeRemovedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>ParentNodeId</b> - Parent id.</description></item>
    /// <item><description><b>NodeId</b> - Id of the node that has been removed.</description></item>
    /// </list>
    /// </remarks>
    IEventSource<ChildNodeRemovedEventArgs> ChildNodeRemoved { get; }

    /// <summary>
    /// Called when distribution is changed.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DistributedNodesUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>InsertionPointId</b> - Insertion point where distributed nodes were updated.</description></item>
    /// <item><description><b>DistributedNodes</b> - Distributed nodes for given insertion point.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    IEventSource<DistributedNodesUpdatedEventArgs> DistributedNodesUpdated { get; }

    /// <summary>
    /// Fired when <b>Document</b> has been totally updated. Node ids are no longer valid.
    /// </summary>
    IEventSource<DocumentUpdatedEventArgs> DocumentUpdated { get; }

    /// <summary>
    /// Fired when <b>Element</b>'s inline style is modified via a CSS property modification.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="InlineStyleInvalidatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>NodeIds</b> - Ids of the nodes for which the inline styles have been invalidated.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    IEventSource<InlineStyleInvalidatedEventArgs> InlineStyleInvalidated { get; }

    /// <summary>
    /// Called when a pseudo element is added to an element.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="PseudoElementAddedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>ParentId</b> - Pseudo element's parent element id.</description></item>
    /// <item><description><b>PseudoElement</b> - The added pseudo element.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    IEventSource<PseudoElementAddedEventArgs> PseudoElementAdded { get; }

    /// <summary>
    /// Called when top layer elements are changed.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    IEventSource<TopLayerElementsUpdatedEventArgs> TopLayerElementsUpdated { get; }

    /// <summary>
    /// Fired when a node's scrollability state changes.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ScrollableFlagUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>NodeId</b> - The id of the node.</description></item>
    /// <item><description><b>IsScrollable</b> - If the node is scrollable.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    IEventSource<ScrollableFlagUpdatedEventArgs> ScrollableFlagUpdated { get; }

    /// <summary>
    /// Fired when a node's ad related state changes.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="AdRelatedStateUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>NodeId</b> - The id of the node.</description></item>
    /// <item><description><b>AdProvenance</b> - The provenance of the ad related node, if it is ad related.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    IEventSource<AdRelatedStateUpdatedEventArgs> AdRelatedStateUpdated { get; }

    /// <summary>
    /// Fired when a node's starting styles changes.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="AffectedByStartingStylesFlagUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>NodeId</b> - The id of the node.</description></item>
    /// <item><description><b>AffectedByStartingStyles</b> - If the node has starting styles.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    IEventSource<AffectedByStartingStylesFlagUpdatedEventArgs> AffectedByStartingStylesFlagUpdated { get; }

    /// <summary>
    /// Called when a pseudo element is removed from an element.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="PseudoElementRemovedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>ParentId</b> - Pseudo element's parent element id.</description></item>
    /// <item><description><b>PseudoElementId</b> - The removed pseudo element id.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    IEventSource<PseudoElementRemovedEventArgs> PseudoElementRemoved { get; }

    /// <summary>
    /// Fired when backend wants to provide client with the missing DOM structure. This happens upon
    /// most of the calls requesting node ids.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="SetChildNodesEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>ParentId</b> - Parent node id to populate with children.</description></item>
    /// <item><description><b>Nodes</b> - Child nodes array.</description></item>
    /// </list>
    /// </remarks>
    IEventSource<SetChildNodesEventArgs> SetChildNodes { get; }

    /// <summary>
    /// Called when shadow root is popped from the element.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ShadowRootPoppedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>HostId</b> - Host element id.</description></item>
    /// <item><description><b>RootId</b> - Shadow root id.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    IEventSource<ShadowRootPoppedEventArgs> ShadowRootPopped { get; }

    /// <summary>
    /// Called when shadow root is pushed into the element.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ShadowRootPushedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>HostId</b> - Host element id.</description></item>
    /// <item><description><b>Root</b> - Shadow root.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    IEventSource<ShadowRootPushedEventArgs> ShadowRootPushed { get; }

}

internal sealed class DOMDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), IDOM
{
    private static DOMJsonSerializerContext JsonContext = DOMJsonSerializerContext.Default;

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<CollectClassNamesFromSubtreeResult> CollectClassNamesFromSubtreeAsync(NodeId nodeId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CollectClassNamesFromSubtreeCommandParameters(NodeId: nodeId);
        return await ExecuteCommandAsync(CollectClassNamesFromSubtreeCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CollectClassNamesFromSubtreeCommandParameters, CollectClassNamesFromSubtreeResult> CollectClassNamesFromSubtreeCommand = new("DOM.collectClassNamesFromSubtree", JsonContext.CollectClassNamesFromSubtreeCommandParameters, JsonContext.CollectClassNamesFromSubtreeResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<CopyToResult> CopyToAsync(NodeId nodeId, NodeId targetNodeId, NodeId? insertBeforeNodeId = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CopyToCommandParameters(NodeId: nodeId, TargetNodeId: targetNodeId, InsertBeforeNodeId: insertBeforeNodeId);
        return await ExecuteCommandAsync(CopyToCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CopyToCommandParameters, CopyToResult> CopyToCommand = new("DOM.copyTo", JsonContext.CopyToCommandParameters, JsonContext.CopyToResult);

    public async Task<DescribeNodeResult> DescribeNodeAsync(NodeId? nodeId = default, BackendNodeId? backendNodeId = default, Runtime.RemoteObjectId? objectId = default, long? depth = default, bool? pierce = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DescribeNodeCommandParameters(NodeId: nodeId, BackendNodeId: backendNodeId, ObjectId: objectId, Depth: depth, Pierce: pierce);
        return await ExecuteCommandAsync(DescribeNodeCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DescribeNodeCommandParameters, DescribeNodeResult> DescribeNodeCommand = new("DOM.describeNode", JsonContext.DescribeNodeCommandParameters, JsonContext.DescribeNodeResult);

    public async Task<ScrollIntoViewIfNeededResult> ScrollIntoViewIfNeededAsync(NodeId? nodeId = default, BackendNodeId? backendNodeId = default, Runtime.RemoteObjectId? objectId = default, Rect? rect = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ScrollIntoViewIfNeededCommandParameters(NodeId: nodeId, BackendNodeId: backendNodeId, ObjectId: objectId, Rect: rect);
        return await ExecuteCommandAsync(ScrollIntoViewIfNeededCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ScrollIntoViewIfNeededCommandParameters, ScrollIntoViewIfNeededResult> ScrollIntoViewIfNeededCommand = new("DOM.scrollIntoViewIfNeeded", JsonContext.ScrollIntoViewIfNeededCommandParameters, JsonContext.ScrollIntoViewIfNeededResult);

    public async Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync(DisableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("DOM.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<DiscardSearchResultsResult> DiscardSearchResultsAsync(string searchId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DiscardSearchResultsCommandParameters(SearchId: searchId);
        return await ExecuteCommandAsync(DiscardSearchResultsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DiscardSearchResultsCommandParameters, DiscardSearchResultsResult> DiscardSearchResultsCommand = new("DOM.discardSearchResults", JsonContext.DiscardSearchResultsCommandParameters, JsonContext.DiscardSearchResultsResult);

    public async Task<EnableResult> EnableAsync(string? includeWhitespace = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters(IncludeWhitespace: includeWhitespace);
        return await ExecuteCommandAsync(EnableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("DOM.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    public async Task<FocusResult> FocusAsync(NodeId? nodeId = default, BackendNodeId? backendNodeId = default, Runtime.RemoteObjectId? objectId = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new FocusCommandParameters(NodeId: nodeId, BackendNodeId: backendNodeId, ObjectId: objectId);
        return await ExecuteCommandAsync(FocusCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<FocusCommandParameters, FocusResult> FocusCommand = new("DOM.focus", JsonContext.FocusCommandParameters, JsonContext.FocusResult);

    public async Task<GetAttributesResult> GetAttributesAsync(NodeId nodeId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetAttributesCommandParameters(NodeId: nodeId);
        return await ExecuteCommandAsync(GetAttributesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetAttributesCommandParameters, GetAttributesResult> GetAttributesCommand = new("DOM.getAttributes", JsonContext.GetAttributesCommandParameters, JsonContext.GetAttributesResult);

    public async Task<GetBoxModelResult> GetBoxModelAsync(NodeId? nodeId = default, BackendNodeId? backendNodeId = default, Runtime.RemoteObjectId? objectId = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetBoxModelCommandParameters(NodeId: nodeId, BackendNodeId: backendNodeId, ObjectId: objectId);
        return await ExecuteCommandAsync(GetBoxModelCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetBoxModelCommandParameters, GetBoxModelResult> GetBoxModelCommand = new("DOM.getBoxModel", JsonContext.GetBoxModelCommandParameters, JsonContext.GetBoxModelResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetContentQuadsResult> GetContentQuadsAsync(NodeId? nodeId = default, BackendNodeId? backendNodeId = default, Runtime.RemoteObjectId? objectId = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetContentQuadsCommandParameters(NodeId: nodeId, BackendNodeId: backendNodeId, ObjectId: objectId);
        return await ExecuteCommandAsync(GetContentQuadsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetContentQuadsCommandParameters, GetContentQuadsResult> GetContentQuadsCommand = new("DOM.getContentQuads", JsonContext.GetContentQuadsCommandParameters, JsonContext.GetContentQuadsResult);

    public async Task<GetDocumentResult> GetDocumentAsync(long? depth = default, bool? pierce = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetDocumentCommandParameters(Depth: depth, Pierce: pierce);
        return await ExecuteCommandAsync(GetDocumentCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetDocumentCommandParameters, GetDocumentResult> GetDocumentCommand = new("DOM.getDocument", JsonContext.GetDocumentCommandParameters, JsonContext.GetDocumentResult);

    [global::System.Obsolete]
    public async Task<GetFlattenedDocumentResult> GetFlattenedDocumentAsync(long? depth = default, bool? pierce = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetFlattenedDocumentCommandParameters(Depth: depth, Pierce: pierce);
        return await ExecuteCommandAsync(GetFlattenedDocumentCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetFlattenedDocumentCommandParameters, GetFlattenedDocumentResult> GetFlattenedDocumentCommand = new("DOM.getFlattenedDocument", JsonContext.GetFlattenedDocumentCommandParameters, JsonContext.GetFlattenedDocumentResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetNodesForSubtreeByStyleResult> GetNodesForSubtreeByStyleAsync(NodeId nodeId, ImmutableArray<CSSComputedStyleProperty> computedStyles, bool? pierce = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetNodesForSubtreeByStyleCommandParameters(NodeId: nodeId, ComputedStyles: computedStyles, Pierce: pierce);
        return await ExecuteCommandAsync(GetNodesForSubtreeByStyleCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetNodesForSubtreeByStyleCommandParameters, GetNodesForSubtreeByStyleResult> GetNodesForSubtreeByStyleCommand = new("DOM.getNodesForSubtreeByStyle", JsonContext.GetNodesForSubtreeByStyleCommandParameters, JsonContext.GetNodesForSubtreeByStyleResult);

    public async Task<GetNodeForLocationResult> GetNodeForLocationAsync(long x, long y, bool? includeUserAgentShadowDOM = default, bool? ignorePointerEventsNone = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetNodeForLocationCommandParameters(X: x, Y: y, IncludeUserAgentShadowDOM: includeUserAgentShadowDOM, IgnorePointerEventsNone: ignorePointerEventsNone);
        return await ExecuteCommandAsync(GetNodeForLocationCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetNodeForLocationCommandParameters, GetNodeForLocationResult> GetNodeForLocationCommand = new("DOM.getNodeForLocation", JsonContext.GetNodeForLocationCommandParameters, JsonContext.GetNodeForLocationResult);

    public async Task<GetOuterHTMLResult> GetOuterHTMLAsync(NodeId? nodeId = default, BackendNodeId? backendNodeId = default, Runtime.RemoteObjectId? objectId = default, bool? includeShadowDOM = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetOuterHTMLCommandParameters(NodeId: nodeId, BackendNodeId: backendNodeId, ObjectId: objectId, IncludeShadowDOM: includeShadowDOM);
        return await ExecuteCommandAsync(GetOuterHTMLCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetOuterHTMLCommandParameters, GetOuterHTMLResult> GetOuterHTMLCommand = new("DOM.getOuterHTML", JsonContext.GetOuterHTMLCommandParameters, JsonContext.GetOuterHTMLResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetRelayoutBoundaryResult> GetRelayoutBoundaryAsync(NodeId nodeId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetRelayoutBoundaryCommandParameters(NodeId: nodeId);
        return await ExecuteCommandAsync(GetRelayoutBoundaryCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetRelayoutBoundaryCommandParameters, GetRelayoutBoundaryResult> GetRelayoutBoundaryCommand = new("DOM.getRelayoutBoundary", JsonContext.GetRelayoutBoundaryCommandParameters, JsonContext.GetRelayoutBoundaryResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetSearchResultsResult> GetSearchResultsAsync(string searchId, long fromIndex, long toIndex, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetSearchResultsCommandParameters(SearchId: searchId, FromIndex: fromIndex, ToIndex: toIndex);
        return await ExecuteCommandAsync(GetSearchResultsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetSearchResultsCommandParameters, GetSearchResultsResult> GetSearchResultsCommand = new("DOM.getSearchResults", JsonContext.GetSearchResultsCommandParameters, JsonContext.GetSearchResultsResult);

    public async Task<HideHighlightResult> HideHighlightAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new HideHighlightCommandParameters();
        return await ExecuteCommandAsync(HideHighlightCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<HideHighlightCommandParameters, HideHighlightResult> HideHighlightCommand = new("DOM.hideHighlight", JsonContext.HideHighlightCommandParameters, JsonContext.HideHighlightResult);

    public async Task<HighlightNodeResult> HighlightNodeAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new HighlightNodeCommandParameters();
        return await ExecuteCommandAsync(HighlightNodeCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<HighlightNodeCommandParameters, HighlightNodeResult> HighlightNodeCommand = new("DOM.highlightNode", JsonContext.HighlightNodeCommandParameters, JsonContext.HighlightNodeResult);

    public async Task<HighlightRectResult> HighlightRectAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new HighlightRectCommandParameters();
        return await ExecuteCommandAsync(HighlightRectCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<HighlightRectCommandParameters, HighlightRectResult> HighlightRectCommand = new("DOM.highlightRect", JsonContext.HighlightRectCommandParameters, JsonContext.HighlightRectResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<MarkUndoableStateResult> MarkUndoableStateAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new MarkUndoableStateCommandParameters();
        return await ExecuteCommandAsync(MarkUndoableStateCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<MarkUndoableStateCommandParameters, MarkUndoableStateResult> MarkUndoableStateCommand = new("DOM.markUndoableState", JsonContext.MarkUndoableStateCommandParameters, JsonContext.MarkUndoableStateResult);

    public async Task<MoveToResult> MoveToAsync(NodeId nodeId, NodeId targetNodeId, NodeId? insertBeforeNodeId = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new MoveToCommandParameters(NodeId: nodeId, TargetNodeId: targetNodeId, InsertBeforeNodeId: insertBeforeNodeId);
        return await ExecuteCommandAsync(MoveToCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<MoveToCommandParameters, MoveToResult> MoveToCommand = new("DOM.moveTo", JsonContext.MoveToCommandParameters, JsonContext.MoveToResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<PerformSearchResult> PerformSearchAsync(string query, bool? includeUserAgentShadowDOM = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new PerformSearchCommandParameters(Query: query, IncludeUserAgentShadowDOM: includeUserAgentShadowDOM);
        return await ExecuteCommandAsync(PerformSearchCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<PerformSearchCommandParameters, PerformSearchResult> PerformSearchCommand = new("DOM.performSearch", JsonContext.PerformSearchCommandParameters, JsonContext.PerformSearchResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<PushNodeByPathToFrontendResult> PushNodeByPathToFrontendAsync(string path, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new PushNodeByPathToFrontendCommandParameters(Path: path);
        return await ExecuteCommandAsync(PushNodeByPathToFrontendCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<PushNodeByPathToFrontendCommandParameters, PushNodeByPathToFrontendResult> PushNodeByPathToFrontendCommand = new("DOM.pushNodeByPathToFrontend", JsonContext.PushNodeByPathToFrontendCommandParameters, JsonContext.PushNodeByPathToFrontendResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<PushNodesByBackendIdsToFrontendResult> PushNodesByBackendIdsToFrontendAsync(ImmutableArray<BackendNodeId> backendNodeIds, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new PushNodesByBackendIdsToFrontendCommandParameters(BackendNodeIds: backendNodeIds);
        return await ExecuteCommandAsync(PushNodesByBackendIdsToFrontendCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<PushNodesByBackendIdsToFrontendCommandParameters, PushNodesByBackendIdsToFrontendResult> PushNodesByBackendIdsToFrontendCommand = new("DOM.pushNodesByBackendIdsToFrontend", JsonContext.PushNodesByBackendIdsToFrontendCommandParameters, JsonContext.PushNodesByBackendIdsToFrontendResult);

    public async Task<QuerySelectorResult> QuerySelectorAsync(NodeId nodeId, string selector, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new QuerySelectorCommandParameters(NodeId: nodeId, Selector: selector);
        return await ExecuteCommandAsync(QuerySelectorCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<QuerySelectorCommandParameters, QuerySelectorResult> QuerySelectorCommand = new("DOM.querySelector", JsonContext.QuerySelectorCommandParameters, JsonContext.QuerySelectorResult);

    public async Task<QuerySelectorAllResult> QuerySelectorAllAsync(NodeId nodeId, string selector, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new QuerySelectorAllCommandParameters(NodeId: nodeId, Selector: selector);
        return await ExecuteCommandAsync(QuerySelectorAllCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<QuerySelectorAllCommandParameters, QuerySelectorAllResult> QuerySelectorAllCommand = new("DOM.querySelectorAll", JsonContext.QuerySelectorAllCommandParameters, JsonContext.QuerySelectorAllResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetTopLayerElementsResult> GetTopLayerElementsAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetTopLayerElementsCommandParameters();
        return await ExecuteCommandAsync(GetTopLayerElementsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetTopLayerElementsCommandParameters, GetTopLayerElementsResult> GetTopLayerElementsCommand = new("DOM.getTopLayerElements", JsonContext.GetTopLayerElementsCommandParameters, JsonContext.GetTopLayerElementsResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetElementByRelationResult> GetElementByRelationAsync(NodeId nodeId, string relation, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetElementByRelationCommandParameters(NodeId: nodeId, Relation: relation);
        return await ExecuteCommandAsync(GetElementByRelationCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetElementByRelationCommandParameters, GetElementByRelationResult> GetElementByRelationCommand = new("DOM.getElementByRelation", JsonContext.GetElementByRelationCommandParameters, JsonContext.GetElementByRelationResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<RedoResult> RedoAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RedoCommandParameters();
        return await ExecuteCommandAsync(RedoCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RedoCommandParameters, RedoResult> RedoCommand = new("DOM.redo", JsonContext.RedoCommandParameters, JsonContext.RedoResult);

    public async Task<RemoveAttributeResult> RemoveAttributeAsync(NodeId nodeId, string name, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveAttributeCommandParameters(NodeId: nodeId, Name: name);
        return await ExecuteCommandAsync(RemoveAttributeCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RemoveAttributeCommandParameters, RemoveAttributeResult> RemoveAttributeCommand = new("DOM.removeAttribute", JsonContext.RemoveAttributeCommandParameters, JsonContext.RemoveAttributeResult);

    public async Task<RemoveNodeResult> RemoveNodeAsync(NodeId nodeId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveNodeCommandParameters(NodeId: nodeId);
        return await ExecuteCommandAsync(RemoveNodeCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RemoveNodeCommandParameters, RemoveNodeResult> RemoveNodeCommand = new("DOM.removeNode", JsonContext.RemoveNodeCommandParameters, JsonContext.RemoveNodeResult);

    public async Task<RequestChildNodesResult> RequestChildNodesAsync(NodeId nodeId, long? depth = default, bool? pierce = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RequestChildNodesCommandParameters(NodeId: nodeId, Depth: depth, Pierce: pierce);
        return await ExecuteCommandAsync(RequestChildNodesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RequestChildNodesCommandParameters, RequestChildNodesResult> RequestChildNodesCommand = new("DOM.requestChildNodes", JsonContext.RequestChildNodesCommandParameters, JsonContext.RequestChildNodesResult);

    public async Task<RequestNodeResult> RequestNodeAsync(Runtime.RemoteObjectId objectId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RequestNodeCommandParameters(ObjectId: objectId);
        return await ExecuteCommandAsync(RequestNodeCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RequestNodeCommandParameters, RequestNodeResult> RequestNodeCommand = new("DOM.requestNode", JsonContext.RequestNodeCommandParameters, JsonContext.RequestNodeResult);

    public async Task<ResolveNodeResult> ResolveNodeAsync(NodeId? nodeId = default, DOM.BackendNodeId? backendNodeId = default, string? objectGroup = default, Runtime.ExecutionContextId? executionContextId = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ResolveNodeCommandParameters(NodeId: nodeId, BackendNodeId: backendNodeId, ObjectGroup: objectGroup, ExecutionContextId: executionContextId);
        return await ExecuteCommandAsync(ResolveNodeCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ResolveNodeCommandParameters, ResolveNodeResult> ResolveNodeCommand = new("DOM.resolveNode", JsonContext.ResolveNodeCommandParameters, JsonContext.ResolveNodeResult);

    public async Task<SetAttributeValueResult> SetAttributeValueAsync(NodeId nodeId, string name, string value, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetAttributeValueCommandParameters(NodeId: nodeId, Name: name, Value: value);
        return await ExecuteCommandAsync(SetAttributeValueCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetAttributeValueCommandParameters, SetAttributeValueResult> SetAttributeValueCommand = new("DOM.setAttributeValue", JsonContext.SetAttributeValueCommandParameters, JsonContext.SetAttributeValueResult);

    public async Task<SetAttributesAsTextResult> SetAttributesAsTextAsync(NodeId nodeId, string text, string? name = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetAttributesAsTextCommandParameters(NodeId: nodeId, Text: text, Name: name);
        return await ExecuteCommandAsync(SetAttributesAsTextCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetAttributesAsTextCommandParameters, SetAttributesAsTextResult> SetAttributesAsTextCommand = new("DOM.setAttributesAsText", JsonContext.SetAttributesAsTextCommandParameters, JsonContext.SetAttributesAsTextResult);

    public async Task<SetFileInputFilesResult> SetFileInputFilesAsync(ImmutableArray<string> files, NodeId? nodeId = default, BackendNodeId? backendNodeId = default, Runtime.RemoteObjectId? objectId = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetFileInputFilesCommandParameters(Files: files, NodeId: nodeId, BackendNodeId: backendNodeId, ObjectId: objectId);
        return await ExecuteCommandAsync(SetFileInputFilesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetFileInputFilesCommandParameters, SetFileInputFilesResult> SetFileInputFilesCommand = new("DOM.setFileInputFiles", JsonContext.SetFileInputFilesCommandParameters, JsonContext.SetFileInputFilesResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetNodeStackTracesEnabledResult> SetNodeStackTracesEnabledAsync(bool enable, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetNodeStackTracesEnabledCommandParameters(Enable: enable);
        return await ExecuteCommandAsync(SetNodeStackTracesEnabledCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetNodeStackTracesEnabledCommandParameters, SetNodeStackTracesEnabledResult> SetNodeStackTracesEnabledCommand = new("DOM.setNodeStackTracesEnabled", JsonContext.SetNodeStackTracesEnabledCommandParameters, JsonContext.SetNodeStackTracesEnabledResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetNodeStackTracesResult> GetNodeStackTracesAsync(NodeId nodeId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetNodeStackTracesCommandParameters(NodeId: nodeId);
        return await ExecuteCommandAsync(GetNodeStackTracesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetNodeStackTracesCommandParameters, GetNodeStackTracesResult> GetNodeStackTracesCommand = new("DOM.getNodeStackTraces", JsonContext.GetNodeStackTracesCommandParameters, JsonContext.GetNodeStackTracesResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetFileInfoResult> GetFileInfoAsync(Runtime.RemoteObjectId objectId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetFileInfoCommandParameters(ObjectId: objectId);
        return await ExecuteCommandAsync(GetFileInfoCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetFileInfoCommandParameters, GetFileInfoResult> GetFileInfoCommand = new("DOM.getFileInfo", JsonContext.GetFileInfoCommandParameters, JsonContext.GetFileInfoResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetDetachedDomNodesResult> GetDetachedDomNodesAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetDetachedDomNodesCommandParameters();
        return await ExecuteCommandAsync(GetDetachedDomNodesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetDetachedDomNodesCommandParameters, GetDetachedDomNodesResult> GetDetachedDomNodesCommand = new("DOM.getDetachedDomNodes", JsonContext.GetDetachedDomNodesCommandParameters, JsonContext.GetDetachedDomNodesResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetInspectedNodeResult> SetInspectedNodeAsync(NodeId nodeId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetInspectedNodeCommandParameters(NodeId: nodeId);
        return await ExecuteCommandAsync(SetInspectedNodeCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetInspectedNodeCommandParameters, SetInspectedNodeResult> SetInspectedNodeCommand = new("DOM.setInspectedNode", JsonContext.SetInspectedNodeCommandParameters, JsonContext.SetInspectedNodeResult);

    public async Task<SetNodeNameResult> SetNodeNameAsync(NodeId nodeId, string name, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetNodeNameCommandParameters(NodeId: nodeId, Name: name);
        return await ExecuteCommandAsync(SetNodeNameCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetNodeNameCommandParameters, SetNodeNameResult> SetNodeNameCommand = new("DOM.setNodeName", JsonContext.SetNodeNameCommandParameters, JsonContext.SetNodeNameResult);

    public async Task<SetNodeValueResult> SetNodeValueAsync(NodeId nodeId, string value, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetNodeValueCommandParameters(NodeId: nodeId, Value: value);
        return await ExecuteCommandAsync(SetNodeValueCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetNodeValueCommandParameters, SetNodeValueResult> SetNodeValueCommand = new("DOM.setNodeValue", JsonContext.SetNodeValueCommandParameters, JsonContext.SetNodeValueResult);

    public async Task<SetOuterHTMLResult> SetOuterHTMLAsync(NodeId nodeId, string outerHTML, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetOuterHTMLCommandParameters(NodeId: nodeId, OuterHTML: outerHTML);
        return await ExecuteCommandAsync(SetOuterHTMLCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetOuterHTMLCommandParameters, SetOuterHTMLResult> SetOuterHTMLCommand = new("DOM.setOuterHTML", JsonContext.SetOuterHTMLCommandParameters, JsonContext.SetOuterHTMLResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<UndoResult> UndoAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new UndoCommandParameters();
        return await ExecuteCommandAsync(UndoCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<UndoCommandParameters, UndoResult> UndoCommand = new("DOM.undo", JsonContext.UndoCommandParameters, JsonContext.UndoResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetFrameOwnerResult> GetFrameOwnerAsync(Page.FrameId frameId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetFrameOwnerCommandParameters(FrameId: frameId);
        return await ExecuteCommandAsync(GetFrameOwnerCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetFrameOwnerCommandParameters, GetFrameOwnerResult> GetFrameOwnerCommand = new("DOM.getFrameOwner", JsonContext.GetFrameOwnerCommandParameters, JsonContext.GetFrameOwnerResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetContainerForNodeResult> GetContainerForNodeAsync(NodeId nodeId, string? containerName = default, PhysicalAxes? physicalAxes = default, LogicalAxes? logicalAxes = default, bool? queriesScrollState = default, bool? queriesAnchored = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetContainerForNodeCommandParameters(NodeId: nodeId, ContainerName: containerName, PhysicalAxes: physicalAxes, LogicalAxes: logicalAxes, QueriesScrollState: queriesScrollState, QueriesAnchored: queriesAnchored);
        return await ExecuteCommandAsync(GetContainerForNodeCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetContainerForNodeCommandParameters, GetContainerForNodeResult> GetContainerForNodeCommand = new("DOM.getContainerForNode", JsonContext.GetContainerForNodeCommandParameters, JsonContext.GetContainerForNodeResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetQueryingDescendantsForContainerResult> GetQueryingDescendantsForContainerAsync(NodeId nodeId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetQueryingDescendantsForContainerCommandParameters(NodeId: nodeId);
        return await ExecuteCommandAsync(GetQueryingDescendantsForContainerCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetQueryingDescendantsForContainerCommandParameters, GetQueryingDescendantsForContainerResult> GetQueryingDescendantsForContainerCommand = new("DOM.getQueryingDescendantsForContainer", JsonContext.GetQueryingDescendantsForContainerCommandParameters, JsonContext.GetQueryingDescendantsForContainerResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetAnchorElementResult> GetAnchorElementAsync(NodeId nodeId, string? anchorSpecifier = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetAnchorElementCommandParameters(NodeId: nodeId, AnchorSpecifier: anchorSpecifier);
        return await ExecuteCommandAsync(GetAnchorElementCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetAnchorElementCommandParameters, GetAnchorElementResult> GetAnchorElementCommand = new("DOM.getAnchorElement", JsonContext.GetAnchorElementCommandParameters, JsonContext.GetAnchorElementResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<ForceShowPopoverResult> ForceShowPopoverAsync(NodeId nodeId, bool enable, BackendNodeId? invokerNodeId = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ForceShowPopoverCommandParameters(NodeId: nodeId, Enable: enable, InvokerNodeId: invokerNodeId);
        return await ExecuteCommandAsync(ForceShowPopoverCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ForceShowPopoverCommandParameters, ForceShowPopoverResult> ForceShowPopoverCommand = new("DOM.forceShowPopover", JsonContext.ForceShowPopoverCommandParameters, JsonContext.ForceShowPopoverResult);

    public IEventSource<AttributeModifiedEventArgs> AttributeModified => CreateCdpEventSource(DOMDomainEvent.AttributeModified);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<AdoptedStyleSheetsModifiedEventArgs> AdoptedStyleSheetsModified => CreateCdpEventSource(DOMDomainEvent.AdoptedStyleSheetsModified);
    public IEventSource<AttributeRemovedEventArgs> AttributeRemoved => CreateCdpEventSource(DOMDomainEvent.AttributeRemoved);
    public IEventSource<CharacterDataModifiedEventArgs> CharacterDataModified => CreateCdpEventSource(DOMDomainEvent.CharacterDataModified);
    public IEventSource<ChildNodeCountUpdatedEventArgs> ChildNodeCountUpdated => CreateCdpEventSource(DOMDomainEvent.ChildNodeCountUpdated);
    public IEventSource<ChildNodeInsertedEventArgs> ChildNodeInserted => CreateCdpEventSource(DOMDomainEvent.ChildNodeInserted);
    public IEventSource<ChildNodeRemovedEventArgs> ChildNodeRemoved => CreateCdpEventSource(DOMDomainEvent.ChildNodeRemoved);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DistributedNodesUpdatedEventArgs> DistributedNodesUpdated => CreateCdpEventSource(DOMDomainEvent.DistributedNodesUpdated);
    public IEventSource<DocumentUpdatedEventArgs> DocumentUpdated => CreateCdpEventSource(DOMDomainEvent.DocumentUpdated);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<InlineStyleInvalidatedEventArgs> InlineStyleInvalidated => CreateCdpEventSource(DOMDomainEvent.InlineStyleInvalidated);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<PseudoElementAddedEventArgs> PseudoElementAdded => CreateCdpEventSource(DOMDomainEvent.PseudoElementAdded);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<TopLayerElementsUpdatedEventArgs> TopLayerElementsUpdated => CreateCdpEventSource(DOMDomainEvent.TopLayerElementsUpdated);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<ScrollableFlagUpdatedEventArgs> ScrollableFlagUpdated => CreateCdpEventSource(DOMDomainEvent.ScrollableFlagUpdated);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<AdRelatedStateUpdatedEventArgs> AdRelatedStateUpdated => CreateCdpEventSource(DOMDomainEvent.AdRelatedStateUpdated);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<AffectedByStartingStylesFlagUpdatedEventArgs> AffectedByStartingStylesFlagUpdated => CreateCdpEventSource(DOMDomainEvent.AffectedByStartingStylesFlagUpdated);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<PseudoElementRemovedEventArgs> PseudoElementRemoved => CreateCdpEventSource(DOMDomainEvent.PseudoElementRemoved);
    public IEventSource<SetChildNodesEventArgs> SetChildNodes => CreateCdpEventSource(DOMDomainEvent.SetChildNodes);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<ShadowRootPoppedEventArgs> ShadowRootPopped => CreateCdpEventSource(DOMDomainEvent.ShadowRootPopped);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<ShadowRootPushedEventArgs> ShadowRootPushed => CreateCdpEventSource(DOMDomainEvent.ShadowRootPushed);
}

internal sealed record CollectClassNamesFromSubtreeCommandParameters(NodeId NodeId) : Parameters;

/// <summary>
/// </summary>
/// <param name="ClassNames">
/// Class name list.
/// </param>
public sealed record CollectClassNamesFromSubtreeResult(ImmutableArray<string> ClassNames) : EmptyResult;


internal sealed record CopyToCommandParameters(NodeId NodeId, NodeId TargetNodeId, NodeId? InsertBeforeNodeId) : Parameters;

/// <summary>
/// </summary>
/// <param name="NodeId">
/// Id of the node clone.
/// </param>
public sealed record CopyToResult(NodeId NodeId) : EmptyResult;


internal sealed record DescribeNodeCommandParameters(NodeId? NodeId, BackendNodeId? BackendNodeId, Runtime.RemoteObjectId? ObjectId, long? Depth, bool? Pierce) : Parameters;

/// <summary>
/// </summary>
/// <param name="Node">
/// Node description.
/// </param>
public sealed record DescribeNodeResult(Node Node) : EmptyResult;


internal sealed record ScrollIntoViewIfNeededCommandParameters(NodeId? NodeId, BackendNodeId? BackendNodeId, Runtime.RemoteObjectId? ObjectId, Rect? Rect) : Parameters;

/// <summary>
/// </summary>
public sealed record ScrollIntoViewIfNeededResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record DiscardSearchResultsCommandParameters(string SearchId) : Parameters;

/// <summary>
/// </summary>
public sealed record DiscardSearchResultsResult() : EmptyResult;


internal sealed record EnableCommandParameters(string? IncludeWhitespace) : Parameters;

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record FocusCommandParameters(NodeId? NodeId, BackendNodeId? BackendNodeId, Runtime.RemoteObjectId? ObjectId) : Parameters;

/// <summary>
/// </summary>
public sealed record FocusResult() : EmptyResult;


internal sealed record GetAttributesCommandParameters(NodeId NodeId) : Parameters;

/// <summary>
/// </summary>
/// <param name="Attributes">
/// An interleaved array of node attribute names and values.
/// </param>
public sealed record GetAttributesResult(ImmutableArray<string> Attributes) : EmptyResult;


internal sealed record GetBoxModelCommandParameters(NodeId? NodeId, BackendNodeId? BackendNodeId, Runtime.RemoteObjectId? ObjectId) : Parameters;

/// <summary>
/// </summary>
/// <param name="Model">
/// Box model for the node.
/// </param>
public sealed record GetBoxModelResult(BoxModel Model) : EmptyResult;


internal sealed record GetContentQuadsCommandParameters(NodeId? NodeId, BackendNodeId? BackendNodeId, Runtime.RemoteObjectId? ObjectId) : Parameters;

/// <summary>
/// </summary>
/// <param name="Quads">
/// Quads that describe node layout relative to viewport.
/// </param>
public sealed record GetContentQuadsResult(ImmutableArray<ImmutableArray<double>> Quads) : EmptyResult;


internal sealed record GetDocumentCommandParameters(long? Depth, bool? Pierce) : Parameters;

/// <summary>
/// </summary>
/// <param name="Root">
/// Resulting node.
/// </param>
public sealed record GetDocumentResult(Node Root) : EmptyResult;


internal sealed record GetFlattenedDocumentCommandParameters(long? Depth, bool? Pierce) : Parameters;

/// <summary>
/// </summary>
/// <param name="Nodes">
/// Resulting node.
/// </param>
public sealed record GetFlattenedDocumentResult(ImmutableArray<Node> Nodes) : EmptyResult;


internal sealed record GetNodesForSubtreeByStyleCommandParameters(NodeId NodeId, ImmutableArray<CSSComputedStyleProperty> ComputedStyles, bool? Pierce) : Parameters;

/// <summary>
/// </summary>
/// <param name="NodeIds">
/// Resulting nodes.
/// </param>
public sealed record GetNodesForSubtreeByStyleResult(ImmutableArray<NodeId> NodeIds) : EmptyResult;


internal sealed record GetNodeForLocationCommandParameters(long X, long Y, bool? IncludeUserAgentShadowDOM, bool? IgnorePointerEventsNone) : Parameters;

/// <summary>
/// </summary>
/// <param name="BackendNodeId">
/// Resulting node.
/// </param>
/// <param name="FrameId">
/// Frame this node belongs to.
/// </param>
/// <param name="NodeId">
/// Id of the node at given coordinates, only when enabled and requested document.
/// </param>
public sealed record GetNodeForLocationResult(BackendNodeId BackendNodeId, Page.FrameId FrameId, NodeId? NodeId) : EmptyResult;


internal sealed record GetOuterHTMLCommandParameters(NodeId? NodeId, BackendNodeId? BackendNodeId, Runtime.RemoteObjectId? ObjectId, bool? IncludeShadowDOM) : Parameters;

/// <summary>
/// </summary>
/// <param name="OuterHTML">
/// Outer HTML markup.
/// </param>
public sealed record GetOuterHTMLResult(string OuterHTML) : EmptyResult;


internal sealed record GetRelayoutBoundaryCommandParameters(NodeId NodeId) : Parameters;

/// <summary>
/// </summary>
/// <param name="NodeId">
/// Relayout boundary node id for the given node.
/// </param>
public sealed record GetRelayoutBoundaryResult(NodeId NodeId) : EmptyResult;


internal sealed record GetSearchResultsCommandParameters(string SearchId, long FromIndex, long ToIndex) : Parameters;

/// <summary>
/// </summary>
/// <param name="NodeIds">
/// Ids of the search result nodes.
/// </param>
public sealed record GetSearchResultsResult(ImmutableArray<NodeId> NodeIds) : EmptyResult;


internal sealed record HideHighlightCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record HideHighlightResult() : EmptyResult;


internal sealed record HighlightNodeCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record HighlightNodeResult() : EmptyResult;


internal sealed record HighlightRectCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record HighlightRectResult() : EmptyResult;


internal sealed record MarkUndoableStateCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record MarkUndoableStateResult() : EmptyResult;


internal sealed record MoveToCommandParameters(NodeId NodeId, NodeId TargetNodeId, NodeId? InsertBeforeNodeId) : Parameters;

/// <summary>
/// </summary>
/// <param name="NodeId">
/// New id of the moved node.
/// </param>
public sealed record MoveToResult(NodeId NodeId) : EmptyResult;


internal sealed record PerformSearchCommandParameters(string Query, bool? IncludeUserAgentShadowDOM) : Parameters;

/// <summary>
/// </summary>
/// <param name="SearchId">
/// Unique search session identifier.
/// </param>
/// <param name="ResultCount">
/// Number of search results.
/// </param>
public sealed record PerformSearchResult(string SearchId, long ResultCount) : EmptyResult;


internal sealed record PushNodeByPathToFrontendCommandParameters(string Path) : Parameters;

/// <summary>
/// </summary>
/// <param name="NodeId">
/// Id of the node for given path.
/// </param>
public sealed record PushNodeByPathToFrontendResult(NodeId NodeId) : EmptyResult;


internal sealed record PushNodesByBackendIdsToFrontendCommandParameters(ImmutableArray<BackendNodeId> BackendNodeIds) : Parameters;

/// <summary>
/// </summary>
/// <param name="NodeIds">
/// The array of ids of pushed nodes that correspond to the backend ids specified in
/// backendNodeIds.
/// </param>
public sealed record PushNodesByBackendIdsToFrontendResult(ImmutableArray<NodeId> NodeIds) : EmptyResult;


internal sealed record QuerySelectorCommandParameters(NodeId NodeId, string Selector) : Parameters;

/// <summary>
/// </summary>
/// <param name="NodeId">
/// Query selector result.
/// </param>
public sealed record QuerySelectorResult(NodeId NodeId) : EmptyResult;


internal sealed record QuerySelectorAllCommandParameters(NodeId NodeId, string Selector) : Parameters;

/// <summary>
/// </summary>
/// <param name="NodeIds">
/// Query selector result.
/// </param>
public sealed record QuerySelectorAllResult(ImmutableArray<NodeId> NodeIds) : EmptyResult;


internal sealed record GetTopLayerElementsCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="NodeIds">
/// NodeIds of top layer elements
/// </param>
public sealed record GetTopLayerElementsResult(ImmutableArray<NodeId> NodeIds) : EmptyResult;


internal sealed record GetElementByRelationCommandParameters(NodeId NodeId, string Relation) : Parameters;

/// <summary>
/// </summary>
/// <param name="NodeId">
/// NodeId of the element matching the queried relation.
/// </param>
public sealed record GetElementByRelationResult(NodeId NodeId) : EmptyResult;


internal sealed record RedoCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record RedoResult() : EmptyResult;


internal sealed record RemoveAttributeCommandParameters(NodeId NodeId, string Name) : Parameters;

/// <summary>
/// </summary>
public sealed record RemoveAttributeResult() : EmptyResult;


internal sealed record RemoveNodeCommandParameters(NodeId NodeId) : Parameters;

/// <summary>
/// </summary>
public sealed record RemoveNodeResult() : EmptyResult;


internal sealed record RequestChildNodesCommandParameters(NodeId NodeId, long? Depth, bool? Pierce) : Parameters;

/// <summary>
/// </summary>
public sealed record RequestChildNodesResult() : EmptyResult;


internal sealed record RequestNodeCommandParameters(Runtime.RemoteObjectId ObjectId) : Parameters;

/// <summary>
/// </summary>
/// <param name="NodeId">
/// Node id for given object.
/// </param>
public sealed record RequestNodeResult(NodeId NodeId) : EmptyResult;


internal sealed record ResolveNodeCommandParameters(NodeId? NodeId, DOM.BackendNodeId? BackendNodeId, string? ObjectGroup, Runtime.ExecutionContextId? ExecutionContextId) : Parameters;

/// <summary>
/// </summary>
/// <param name="Object">
/// JavaScript object wrapper for given node.
/// </param>
public sealed record ResolveNodeResult(Runtime.RemoteObject Object) : EmptyResult;


internal sealed record SetAttributeValueCommandParameters(NodeId NodeId, string Name, string Value) : Parameters;

/// <summary>
/// </summary>
public sealed record SetAttributeValueResult() : EmptyResult;


internal sealed record SetAttributesAsTextCommandParameters(NodeId NodeId, string Text, string? Name) : Parameters;

/// <summary>
/// </summary>
public sealed record SetAttributesAsTextResult() : EmptyResult;


internal sealed record SetFileInputFilesCommandParameters(ImmutableArray<string> Files, NodeId? NodeId, BackendNodeId? BackendNodeId, Runtime.RemoteObjectId? ObjectId) : Parameters;

/// <summary>
/// </summary>
public sealed record SetFileInputFilesResult() : EmptyResult;


internal sealed record SetNodeStackTracesEnabledCommandParameters(bool Enable) : Parameters;

/// <summary>
/// </summary>
public sealed record SetNodeStackTracesEnabledResult() : EmptyResult;


internal sealed record GetNodeStackTracesCommandParameters(NodeId NodeId) : Parameters;

/// <summary>
/// </summary>
/// <param name="Creation">
/// Creation stack trace, if available.
/// </param>
public sealed record GetNodeStackTracesResult(Runtime.StackTrace? Creation) : EmptyResult;


internal sealed record GetFileInfoCommandParameters(Runtime.RemoteObjectId ObjectId) : Parameters;

/// <summary>
/// </summary>
/// <param name="Path">
/// </param>
public sealed record GetFileInfoResult(string Path) : EmptyResult;


internal sealed record GetDetachedDomNodesCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="DetachedNodes">
/// The list of detached nodes
/// </param>
public sealed record GetDetachedDomNodesResult(ImmutableArray<DetachedElementInfo> DetachedNodes) : EmptyResult;


internal sealed record SetInspectedNodeCommandParameters(NodeId NodeId) : Parameters;

/// <summary>
/// </summary>
public sealed record SetInspectedNodeResult() : EmptyResult;


internal sealed record SetNodeNameCommandParameters(NodeId NodeId, string Name) : Parameters;

/// <summary>
/// </summary>
/// <param name="NodeId">
/// New node's id.
/// </param>
public sealed record SetNodeNameResult(NodeId NodeId) : EmptyResult;


internal sealed record SetNodeValueCommandParameters(NodeId NodeId, string Value) : Parameters;

/// <summary>
/// </summary>
public sealed record SetNodeValueResult() : EmptyResult;


internal sealed record SetOuterHTMLCommandParameters(NodeId NodeId, string OuterHTML) : Parameters;

/// <summary>
/// </summary>
public sealed record SetOuterHTMLResult() : EmptyResult;


internal sealed record UndoCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record UndoResult() : EmptyResult;


internal sealed record GetFrameOwnerCommandParameters(Page.FrameId FrameId) : Parameters;

/// <summary>
/// </summary>
/// <param name="BackendNodeId">
/// Resulting node.
/// </param>
/// <param name="NodeId">
/// Id of the node at given coordinates, only when enabled and requested document.
/// </param>
public sealed record GetFrameOwnerResult(BackendNodeId BackendNodeId, NodeId? NodeId) : EmptyResult;


internal sealed record GetContainerForNodeCommandParameters(NodeId NodeId, string? ContainerName, PhysicalAxes? PhysicalAxes, LogicalAxes? LogicalAxes, bool? QueriesScrollState, bool? QueriesAnchored) : Parameters;

/// <summary>
/// </summary>
/// <param name="NodeId">
/// The container node for the given node, or null if not found.
/// </param>
public sealed record GetContainerForNodeResult(NodeId? NodeId) : EmptyResult;


internal sealed record GetQueryingDescendantsForContainerCommandParameters(NodeId NodeId) : Parameters;

/// <summary>
/// </summary>
/// <param name="NodeIds">
/// Descendant nodes with container queries against the given container.
/// </param>
public sealed record GetQueryingDescendantsForContainerResult(ImmutableArray<NodeId> NodeIds) : EmptyResult;


internal sealed record GetAnchorElementCommandParameters(NodeId NodeId, string? AnchorSpecifier) : Parameters;

/// <summary>
/// </summary>
/// <param name="NodeId">
/// The anchor element of the given anchor query.
/// </param>
public sealed record GetAnchorElementResult(NodeId NodeId) : EmptyResult;


internal sealed record ForceShowPopoverCommandParameters(NodeId NodeId, bool Enable, BackendNodeId? InvokerNodeId) : Parameters;

/// <summary>
/// </summary>
/// <param name="NodeIds">
/// List of popovers that were closed in order to respect popover stacking order.
/// </param>
public sealed record ForceShowPopoverResult(ImmutableArray<NodeId> NodeIds) : EmptyResult;


/// <summary>
/// Fired when <b>Element</b>'s attribute is modified.
/// </summary>
/// <param name="NodeId">
/// Id of the node that has changed.
/// </param>
/// <param name="Name">
/// Attribute name.
/// </param>
/// <param name="Value">
/// Attribute value.
/// </param>
public sealed record AttributeModifiedEventArgs(NodeId NodeId, string Name, string Value) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when <b>Element</b>'s adoptedStyleSheets are modified.
/// </summary>
/// <param name="NodeId">
/// Id of the node that has changed.
/// </param>
/// <param name="AdoptedStyleSheets">
/// New adoptedStyleSheets array.
/// </param>
public sealed record AdoptedStyleSheetsModifiedEventArgs(NodeId NodeId, ImmutableArray<StyleSheetId> AdoptedStyleSheets) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when <b>Element</b>'s attribute is removed.
/// </summary>
/// <param name="NodeId">
/// Id of the node that has changed.
/// </param>
/// <param name="Name">
/// A ttribute name.
/// </param>
public sealed record AttributeRemovedEventArgs(NodeId NodeId, string Name) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Mirrors <b>DOMCharacterDataModified</b> event.
/// </summary>
/// <param name="NodeId">
/// Id of the node that has changed.
/// </param>
/// <param name="CharacterData">
/// New text value.
/// </param>
public sealed record CharacterDataModifiedEventArgs(NodeId NodeId, string CharacterData) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when <b>Container</b>'s child node count has changed.
/// </summary>
/// <param name="NodeId">
/// Id of the node that has changed.
/// </param>
/// <param name="ChildNodeCount">
/// New node count.
/// </param>
public sealed record ChildNodeCountUpdatedEventArgs(NodeId NodeId, long ChildNodeCount) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Mirrors <b>DOMNodeInserted</b> event.
/// </summary>
/// <param name="ParentNodeId">
/// Id of the node that has changed.
/// </param>
/// <param name="PreviousNodeId">
/// Id of the previous sibling.
/// </param>
/// <param name="Node">
/// Inserted node data.
/// </param>
public sealed record ChildNodeInsertedEventArgs(NodeId ParentNodeId, NodeId PreviousNodeId, Node Node) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Mirrors <b>DOMNodeRemoved</b> event.
/// </summary>
/// <param name="ParentNodeId">
/// Parent id.
/// </param>
/// <param name="NodeId">
/// Id of the node that has been removed.
/// </param>
public sealed record ChildNodeRemovedEventArgs(NodeId ParentNodeId, NodeId NodeId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Called when distribution is changed.
/// </summary>
/// <param name="InsertionPointId">
/// Insertion point where distributed nodes were updated.
/// </param>
/// <param name="DistributedNodes">
/// Distributed nodes for given insertion point.
/// </param>
public sealed record DistributedNodesUpdatedEventArgs(NodeId InsertionPointId, ImmutableArray<BackendNode> DistributedNodes) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when <b>Document</b> has been totally updated. Node ids are no longer valid.
/// </summary>
public sealed record DocumentUpdatedEventArgs() : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when <b>Element</b>'s inline style is modified via a CSS property modification.
/// </summary>
/// <param name="NodeIds">
/// Ids of the nodes for which the inline styles have been invalidated.
/// </param>
public sealed record InlineStyleInvalidatedEventArgs(ImmutableArray<NodeId> NodeIds) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Called when a pseudo element is added to an element.
/// </summary>
/// <param name="ParentId">
/// Pseudo element's parent element id.
/// </param>
/// <param name="PseudoElement">
/// The added pseudo element.
/// </param>
public sealed record PseudoElementAddedEventArgs(NodeId ParentId, Node PseudoElement) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Called when top layer elements are changed.
/// </summary>
public sealed record TopLayerElementsUpdatedEventArgs() : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when a node's scrollability state changes.
/// </summary>
/// <param name="NodeId">
/// The id of the node.
/// </param>
/// <param name="IsScrollable">
/// If the node is scrollable.
/// </param>
public sealed record ScrollableFlagUpdatedEventArgs(DOM.NodeId NodeId, bool IsScrollable) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when a node's ad related state changes.
/// </summary>
/// <param name="NodeId">
/// The id of the node.
/// </param>
/// <param name="AdProvenance">
/// The provenance of the ad related node, if it is ad related.
/// </param>
public sealed record AdRelatedStateUpdatedEventArgs(DOM.NodeId NodeId, Network.AdProvenance? AdProvenance = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when a node's starting styles changes.
/// </summary>
/// <param name="NodeId">
/// The id of the node.
/// </param>
/// <param name="AffectedByStartingStyles">
/// If the node has starting styles.
/// </param>
public sealed record AffectedByStartingStylesFlagUpdatedEventArgs(DOM.NodeId NodeId, bool AffectedByStartingStyles) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Called when a pseudo element is removed from an element.
/// </summary>
/// <param name="ParentId">
/// Pseudo element's parent element id.
/// </param>
/// <param name="PseudoElementId">
/// The removed pseudo element id.
/// </param>
public sealed record PseudoElementRemovedEventArgs(NodeId ParentId, NodeId PseudoElementId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when backend wants to provide client with the missing DOM structure. This happens upon
/// most of the calls requesting node ids.
/// </summary>
/// <param name="ParentId">
/// Parent node id to populate with children.
/// </param>
/// <param name="Nodes">
/// Child nodes array.
/// </param>
public sealed record SetChildNodesEventArgs(NodeId ParentId, ImmutableArray<Node> Nodes) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Called when shadow root is popped from the element.
/// </summary>
/// <param name="HostId">
/// Host element id.
/// </param>
/// <param name="RootId">
/// Shadow root id.
/// </param>
public sealed record ShadowRootPoppedEventArgs(NodeId HostId, NodeId RootId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Called when shadow root is pushed into the element.
/// </summary>
/// <param name="HostId">
/// Host element id.
/// </param>
/// <param name="Root">
/// Shadow root.
/// </param>
public sealed record ShadowRootPushedEventArgs(NodeId HostId, Node Root) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Unique DOM node identifier.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.NumberRemoteIdConverter<NodeId>))]
public record NodeId : INumberRemoteId
{
    double INumberRemoteId.Id { get; init; }
}

/// <summary>
/// Unique DOM node identifier used to reference a node that may not have been pushed to the
/// front-end.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.NumberRemoteIdConverter<BackendNodeId>))]
public record BackendNodeId : INumberRemoteId
{
    double INumberRemoteId.Id { get; init; }
}

/// <summary>
/// Unique identifier for a CSS stylesheet.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<StyleSheetId>))]
public record StyleSheetId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Backend node with a friendly name.
/// </summary>
/// <param name="NodeType">
/// <b>Node</b>'s nodeType.
/// </param>
/// <param name="NodeName">
/// <b>Node</b>'s nodeName.
/// </param>
/// <param name="BackendNodeId">
/// </param>
public sealed record BackendNode(long NodeType, string NodeName, BackendNodeId BackendNodeId)
{
}

/// <summary>
/// Pseudo element type.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<PseudoType>))]
public enum PseudoType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("first-line")]
    FirstLine,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("first-letter")]
    FirstLetter,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("checkmark")]
    Checkmark,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("before")]
    Before,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("after")]
    After,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("expand-icon")]
    ExpandIcon,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("picker-icon")]
    PickerIcon,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("interest-button")]
    InterestButton,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("marker")]
    Marker,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("backdrop")]
    Backdrop,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("column")]
    Column,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("selection")]
    Selection,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("search-text")]
    SearchText,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("target-text")]
    TargetText,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("spelling-error")]
    SpellingError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("grammar-error")]
    GrammarError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("highlight")]
    Highlight,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("first-line-inherited")]
    FirstLineInherited,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("scroll-marker")]
    ScrollMarker,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("scroll-marker-group")]
    ScrollMarkerGroup,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("scroll-button")]
    ScrollButton,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("scrollbar")]
    Scrollbar,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("scrollbar-thumb")]
    ScrollbarThumb,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("scrollbar-button")]
    ScrollbarButton,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("scrollbar-track")]
    ScrollbarTrack,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("scrollbar-track-piece")]
    ScrollbarTrackPiece,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("scrollbar-corner")]
    ScrollbarCorner,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("resizer")]
    Resizer,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("input-list-button")]
    InputListButton,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("view-transition")]
    ViewTransition,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("view-transition-group")]
    ViewTransitionGroup,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("view-transition-image-pair")]
    ViewTransitionImagePair,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("view-transition-group-children")]
    ViewTransitionGroupChildren,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("view-transition-old")]
    ViewTransitionOld,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("view-transition-new")]
    ViewTransitionNew,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("placeholder")]
    Placeholder,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("file-selector-button")]
    FileSelectorButton,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("details-content")]
    DetailsContent,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("picker")]
    Picker,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("select-listbox")]
    SelectListbox,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("permission-icon")]
    PermissionIcon,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("overscroll-area-parent")]
    OverscrollAreaParent,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("overscroll-backdrop")]
    OverscrollBackdrop,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("skeleton")]
    Skeleton,
}

/// <summary>
/// Shadow root type.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ShadowRootType>))]
public enum ShadowRootType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("user-agent")]
    UserAgent,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("open")]
    Open,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("closed")]
    Closed,
}

/// <summary>
/// Document compatibility mode.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<CompatibilityMode>))]
public enum CompatibilityMode
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("QuirksMode")]
    QuirksMode,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("LimitedQuirksMode")]
    LimitedQuirksMode,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NoQuirksMode")]
    NoQuirksMode,
}

/// <summary>
/// ContainerSelector physical axes
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<PhysicalAxes>))]
public enum PhysicalAxes
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Horizontal")]
    Horizontal,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Vertical")]
    Vertical,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Both")]
    Both,
}

/// <summary>
/// ContainerSelector logical axes
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<LogicalAxes>))]
public enum LogicalAxes
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Inline")]
    Inline,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Block")]
    Block,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Both")]
    Both,
}

/// <summary>
/// Physical scroll orientation
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ScrollOrientation>))]
public enum ScrollOrientation
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("horizontal")]
    Horizontal,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("vertical")]
    Vertical,
}

/// <summary>
/// DOM interaction is implemented in terms of mirror objects that represent the actual DOM nodes.
/// DOMNode is a base node mirror type.
/// </summary>
/// <param name="NodeId">
/// Node identifier that is passed into the rest of the DOM messages as the <b>nodeId</b>. Backend
/// will only push node with given <b>id</b> once. It is aware of all requested nodes and will only
/// fire DOM events for nodes known to the client.
/// </param>
/// <param name="BackendNodeId">
/// The BackendNodeId for this node.
/// </param>
/// <param name="NodeType">
/// <b>Node</b>'s nodeType.
/// </param>
/// <param name="NodeName">
/// <b>Node</b>'s nodeName.
/// </param>
/// <param name="LocalName">
/// <b>Node</b>'s localName.
/// </param>
/// <param name="NodeValue">
/// <b>Node</b>'s nodeValue.
/// </param>
public sealed record Node(NodeId NodeId, BackendNodeId BackendNodeId, long NodeType, string NodeName, string LocalName, string NodeValue)
{
    /// <summary>
    /// The id of the parent node if any.
    /// </summary>
    public NodeId? ParentId { get; init; }

    /// <summary>
    /// Child count for <b>Container</b> nodes.
    /// </summary>
    public long? ChildNodeCount { get; init; }

    /// <summary>
    /// Child nodes of this node when requested with children.
    /// </summary>
    public ImmutableArray<Node>? Children { get; init; }

    /// <summary>
    /// Attributes of the <b>Element</b> node in the form of flat array <b>[name1, value1, name2, value2]</b>.
    /// </summary>
    public ImmutableArray<string>? Attributes { get; init; }

    /// <summary>
    /// Document URL that <b>Document</b> or <b>FrameOwner</b> node points to.
    /// </summary>
    public string? DocumentURL { get; init; }

    /// <summary>
    /// Base URL that <b>Document</b> or <b>FrameOwner</b> node uses for URL completion.
    /// </summary>
    public string? BaseURL { get; init; }

    /// <summary>
    /// <b>DocumentType</b>'s publicId.
    /// </summary>
    public string? PublicId { get; init; }

    /// <summary>
    /// <b>DocumentType</b>'s systemId.
    /// </summary>
    public string? SystemId { get; init; }

    /// <summary>
    /// <b>DocumentType</b>'s internalSubset.
    /// </summary>
    public string? InternalSubset { get; init; }

    /// <summary>
    /// <b>Document</b>'s XML version in case of XML documents.
    /// </summary>
    public string? XmlVersion { get; init; }

    /// <summary>
    /// <b>Attr</b>'s name.
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// <b>Attr</b>'s value.
    /// </summary>
    public string? Value { get; init; }

    /// <summary>
    /// Pseudo element type for this node.
    /// </summary>
    public PseudoType? PseudoType { get; init; }

    /// <summary>
    /// Pseudo element identifier for this node. Only present if there is a
    /// valid pseudoType.
    /// </summary>
    public string? PseudoIdentifier { get; init; }

    /// <summary>
    /// Shadow root type.
    /// </summary>
    public ShadowRootType? ShadowRootType { get; init; }

    /// <summary>
    /// Frame ID for frame owner elements.
    /// </summary>
    public Page.FrameId? FrameId { get; init; }

    /// <summary>
    /// Content document for frame owner elements.
    /// </summary>
    public Node? ContentDocument { get; init; }

    /// <summary>
    /// Shadow root list for given element host.
    /// </summary>
    public ImmutableArray<Node>? ShadowRoots { get; init; }

    /// <summary>
    /// Content document fragment for template elements.
    /// </summary>
    public Node? TemplateContent { get; init; }

    /// <summary>
    /// Pseudo elements associated with this node.
    /// </summary>
    public ImmutableArray<Node>? PseudoElements { get; init; }

    /// <summary>
    /// Deprecated, as the HTML Imports API has been removed (crbug.com/937746).
    /// This property used to return the imported document for the HTMLImport links.
    /// The property is always undefined now.
    /// </summary>
    [global::System.Obsolete]
    public Node? ImportedDocument { get; init; }

    /// <summary>
    /// Distributed nodes for given insertion point.
    /// </summary>
    public ImmutableArray<BackendNode>? DistributedNodes { get; init; }

    /// <summary>
    /// Whether the node is SVG.
    /// </summary>
    public bool? IsSVG { get; init; }

    /// <summary>
    /// </summary>
    public CompatibilityMode? CompatibilityMode { get; init; }

    /// <summary>
    /// </summary>
    public BackendNode? AssignedSlot { get; init; }

    /// <summary>
    /// </summary>
    public bool? IsScrollable { get; init; }

    /// <summary>
    /// </summary>
    public bool? AffectedByStartingStyles { get; init; }

    /// <summary>
    /// </summary>
    public ImmutableArray<StyleSheetId>? AdoptedStyleSheets { get; init; }

    /// <summary>
    /// </summary>
    public Network.AdProvenance? AdProvenance { get; init; }
}

/// <summary>
/// A structure to hold the top-level node of a detached tree and an array of its retained descendants.
/// </summary>
/// <param name="TreeNode">
/// </param>
/// <param name="RetainedNodeIds">
/// </param>
public sealed record DetachedElementInfo(Node TreeNode, ImmutableArray<NodeId> RetainedNodeIds)
{
}

/// <summary>
/// A structure holding an RGBA color.
/// </summary>
/// <param name="R">
/// The red component, in the [0-255] range.
/// </param>
/// <param name="G">
/// The green component, in the [0-255] range.
/// </param>
/// <param name="B">
/// The blue component, in the [0-255] range.
/// </param>
public sealed record RGBA(long R, long G, long B)
{
    /// <summary>
    /// The alpha component, in the [0-1] range (default: 1).
    /// </summary>
    public double? A { get; init; }
}

/// <summary>
/// An array of quad vertices, x immediately followed by y for each point, points clock-wise.
/// </summary>

/// <summary>
/// Box model.
/// </summary>
/// <param name="Content">
/// Content box
/// </param>
/// <param name="Padding">
/// Padding box
/// </param>
/// <param name="Border">
/// Border box
/// </param>
/// <param name="Margin">
/// Margin box
/// </param>
/// <param name="Width">
/// Node width
/// </param>
/// <param name="Height">
/// Node height
/// </param>
public sealed record BoxModel(ImmutableArray<double> Content, ImmutableArray<double> Padding, ImmutableArray<double> Border, ImmutableArray<double> Margin, long Width, long Height)
{
    /// <summary>
    /// Shape outside coordinates
    /// </summary>
    public ShapeOutsideInfo? ShapeOutside { get; init; }
}

/// <summary>
/// CSS Shape Outside details.
/// </summary>
/// <param name="Bounds">
/// Shape bounds
/// </param>
/// <param name="Shape">
/// Shape coordinate details
/// </param>
/// <param name="MarginShape">
/// Margin shape bounds
/// </param>
public sealed record ShapeOutsideInfo(ImmutableArray<double> Bounds, ImmutableArray<global::System.Text.Json.JsonElement> Shape, ImmutableArray<global::System.Text.Json.JsonElement> MarginShape)
{
}

/// <summary>
/// Rectangle.
/// </summary>
/// <param name="X">
/// X coordinate
/// </param>
/// <param name="Y">
/// Y coordinate
/// </param>
/// <param name="Width">
/// Rectangle width
/// </param>
/// <param name="Height">
/// Rectangle height
/// </param>
public sealed record Rect(double X, double Y, double Width, double Height)
{
}

/// <summary>
/// </summary>
/// <param name="Name">
/// Computed style property name.
/// </param>
/// <param name="Value">
/// Computed style property value.
/// </param>
public sealed record CSSComputedStyleProperty(string Name, string Value)
{
}

[JsonSerializable(typeof(CollectClassNamesFromSubtreeCommandParameters), TypeInfoPropertyName = "CollectClassNamesFromSubtreeCommandParameters")]
[JsonSerializable(typeof(CollectClassNamesFromSubtreeResult), TypeInfoPropertyName = "CollectClassNamesFromSubtreeResult")]
[JsonSerializable(typeof(CopyToCommandParameters), TypeInfoPropertyName = "CopyToCommandParameters")]
[JsonSerializable(typeof(CopyToResult), TypeInfoPropertyName = "CopyToResult")]
[JsonSerializable(typeof(DescribeNodeCommandParameters), TypeInfoPropertyName = "DescribeNodeCommandParameters")]
[JsonSerializable(typeof(DescribeNodeResult), TypeInfoPropertyName = "DescribeNodeResult")]
[JsonSerializable(typeof(ScrollIntoViewIfNeededCommandParameters), TypeInfoPropertyName = "ScrollIntoViewIfNeededCommandParameters")]
[JsonSerializable(typeof(ScrollIntoViewIfNeededResult), TypeInfoPropertyName = "ScrollIntoViewIfNeededResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(DiscardSearchResultsCommandParameters), TypeInfoPropertyName = "DiscardSearchResultsCommandParameters")]
[JsonSerializable(typeof(DiscardSearchResultsResult), TypeInfoPropertyName = "DiscardSearchResultsResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(FocusCommandParameters), TypeInfoPropertyName = "FocusCommandParameters")]
[JsonSerializable(typeof(FocusResult), TypeInfoPropertyName = "FocusResult")]
[JsonSerializable(typeof(GetAttributesCommandParameters), TypeInfoPropertyName = "GetAttributesCommandParameters")]
[JsonSerializable(typeof(GetAttributesResult), TypeInfoPropertyName = "GetAttributesResult")]
[JsonSerializable(typeof(GetBoxModelCommandParameters), TypeInfoPropertyName = "GetBoxModelCommandParameters")]
[JsonSerializable(typeof(GetBoxModelResult), TypeInfoPropertyName = "GetBoxModelResult")]
[JsonSerializable(typeof(GetContentQuadsCommandParameters), TypeInfoPropertyName = "GetContentQuadsCommandParameters")]
[JsonSerializable(typeof(GetContentQuadsResult), TypeInfoPropertyName = "GetContentQuadsResult")]
[JsonSerializable(typeof(GetDocumentCommandParameters), TypeInfoPropertyName = "GetDocumentCommandParameters")]
[JsonSerializable(typeof(GetDocumentResult), TypeInfoPropertyName = "GetDocumentResult")]
[JsonSerializable(typeof(GetFlattenedDocumentCommandParameters), TypeInfoPropertyName = "GetFlattenedDocumentCommandParameters")]
[JsonSerializable(typeof(GetFlattenedDocumentResult), TypeInfoPropertyName = "GetFlattenedDocumentResult")]
[JsonSerializable(typeof(GetNodesForSubtreeByStyleCommandParameters), TypeInfoPropertyName = "GetNodesForSubtreeByStyleCommandParameters")]
[JsonSerializable(typeof(GetNodesForSubtreeByStyleResult), TypeInfoPropertyName = "GetNodesForSubtreeByStyleResult")]
[JsonSerializable(typeof(GetNodeForLocationCommandParameters), TypeInfoPropertyName = "GetNodeForLocationCommandParameters")]
[JsonSerializable(typeof(GetNodeForLocationResult), TypeInfoPropertyName = "GetNodeForLocationResult")]
[JsonSerializable(typeof(GetOuterHTMLCommandParameters), TypeInfoPropertyName = "GetOuterHTMLCommandParameters")]
[JsonSerializable(typeof(GetOuterHTMLResult), TypeInfoPropertyName = "GetOuterHTMLResult")]
[JsonSerializable(typeof(GetRelayoutBoundaryCommandParameters), TypeInfoPropertyName = "GetRelayoutBoundaryCommandParameters")]
[JsonSerializable(typeof(GetRelayoutBoundaryResult), TypeInfoPropertyName = "GetRelayoutBoundaryResult")]
[JsonSerializable(typeof(GetSearchResultsCommandParameters), TypeInfoPropertyName = "GetSearchResultsCommandParameters")]
[JsonSerializable(typeof(GetSearchResultsResult), TypeInfoPropertyName = "GetSearchResultsResult")]
[JsonSerializable(typeof(HideHighlightCommandParameters), TypeInfoPropertyName = "HideHighlightCommandParameters")]
[JsonSerializable(typeof(HideHighlightResult), TypeInfoPropertyName = "HideHighlightResult")]
[JsonSerializable(typeof(HighlightNodeCommandParameters), TypeInfoPropertyName = "HighlightNodeCommandParameters")]
[JsonSerializable(typeof(HighlightNodeResult), TypeInfoPropertyName = "HighlightNodeResult")]
[JsonSerializable(typeof(HighlightRectCommandParameters), TypeInfoPropertyName = "HighlightRectCommandParameters")]
[JsonSerializable(typeof(HighlightRectResult), TypeInfoPropertyName = "HighlightRectResult")]
[JsonSerializable(typeof(MarkUndoableStateCommandParameters), TypeInfoPropertyName = "MarkUndoableStateCommandParameters")]
[JsonSerializable(typeof(MarkUndoableStateResult), TypeInfoPropertyName = "MarkUndoableStateResult")]
[JsonSerializable(typeof(MoveToCommandParameters), TypeInfoPropertyName = "MoveToCommandParameters")]
[JsonSerializable(typeof(MoveToResult), TypeInfoPropertyName = "MoveToResult")]
[JsonSerializable(typeof(PerformSearchCommandParameters), TypeInfoPropertyName = "PerformSearchCommandParameters")]
[JsonSerializable(typeof(PerformSearchResult), TypeInfoPropertyName = "PerformSearchResult")]
[JsonSerializable(typeof(PushNodeByPathToFrontendCommandParameters), TypeInfoPropertyName = "PushNodeByPathToFrontendCommandParameters")]
[JsonSerializable(typeof(PushNodeByPathToFrontendResult), TypeInfoPropertyName = "PushNodeByPathToFrontendResult")]
[JsonSerializable(typeof(PushNodesByBackendIdsToFrontendCommandParameters), TypeInfoPropertyName = "PushNodesByBackendIdsToFrontendCommandParameters")]
[JsonSerializable(typeof(PushNodesByBackendIdsToFrontendResult), TypeInfoPropertyName = "PushNodesByBackendIdsToFrontendResult")]
[JsonSerializable(typeof(QuerySelectorCommandParameters), TypeInfoPropertyName = "QuerySelectorCommandParameters")]
[JsonSerializable(typeof(QuerySelectorResult), TypeInfoPropertyName = "QuerySelectorResult")]
[JsonSerializable(typeof(QuerySelectorAllCommandParameters), TypeInfoPropertyName = "QuerySelectorAllCommandParameters")]
[JsonSerializable(typeof(QuerySelectorAllResult), TypeInfoPropertyName = "QuerySelectorAllResult")]
[JsonSerializable(typeof(GetTopLayerElementsCommandParameters), TypeInfoPropertyName = "GetTopLayerElementsCommandParameters")]
[JsonSerializable(typeof(GetTopLayerElementsResult), TypeInfoPropertyName = "GetTopLayerElementsResult")]
[JsonSerializable(typeof(GetElementByRelationCommandParameters), TypeInfoPropertyName = "GetElementByRelationCommandParameters")]
[JsonSerializable(typeof(GetElementByRelationResult), TypeInfoPropertyName = "GetElementByRelationResult")]
[JsonSerializable(typeof(RedoCommandParameters), TypeInfoPropertyName = "RedoCommandParameters")]
[JsonSerializable(typeof(RedoResult), TypeInfoPropertyName = "RedoResult")]
[JsonSerializable(typeof(RemoveAttributeCommandParameters), TypeInfoPropertyName = "RemoveAttributeCommandParameters")]
[JsonSerializable(typeof(RemoveAttributeResult), TypeInfoPropertyName = "RemoveAttributeResult")]
[JsonSerializable(typeof(RemoveNodeCommandParameters), TypeInfoPropertyName = "RemoveNodeCommandParameters")]
[JsonSerializable(typeof(RemoveNodeResult), TypeInfoPropertyName = "RemoveNodeResult")]
[JsonSerializable(typeof(RequestChildNodesCommandParameters), TypeInfoPropertyName = "RequestChildNodesCommandParameters")]
[JsonSerializable(typeof(RequestChildNodesResult), TypeInfoPropertyName = "RequestChildNodesResult")]
[JsonSerializable(typeof(RequestNodeCommandParameters), TypeInfoPropertyName = "RequestNodeCommandParameters")]
[JsonSerializable(typeof(RequestNodeResult), TypeInfoPropertyName = "RequestNodeResult")]
[JsonSerializable(typeof(ResolveNodeCommandParameters), TypeInfoPropertyName = "ResolveNodeCommandParameters")]
[JsonSerializable(typeof(ResolveNodeResult), TypeInfoPropertyName = "ResolveNodeResult")]
[JsonSerializable(typeof(SetAttributeValueCommandParameters), TypeInfoPropertyName = "SetAttributeValueCommandParameters")]
[JsonSerializable(typeof(SetAttributeValueResult), TypeInfoPropertyName = "SetAttributeValueResult")]
[JsonSerializable(typeof(SetAttributesAsTextCommandParameters), TypeInfoPropertyName = "SetAttributesAsTextCommandParameters")]
[JsonSerializable(typeof(SetAttributesAsTextResult), TypeInfoPropertyName = "SetAttributesAsTextResult")]
[JsonSerializable(typeof(SetFileInputFilesCommandParameters), TypeInfoPropertyName = "SetFileInputFilesCommandParameters")]
[JsonSerializable(typeof(SetFileInputFilesResult), TypeInfoPropertyName = "SetFileInputFilesResult")]
[JsonSerializable(typeof(SetNodeStackTracesEnabledCommandParameters), TypeInfoPropertyName = "SetNodeStackTracesEnabledCommandParameters")]
[JsonSerializable(typeof(SetNodeStackTracesEnabledResult), TypeInfoPropertyName = "SetNodeStackTracesEnabledResult")]
[JsonSerializable(typeof(GetNodeStackTracesCommandParameters), TypeInfoPropertyName = "GetNodeStackTracesCommandParameters")]
[JsonSerializable(typeof(GetNodeStackTracesResult), TypeInfoPropertyName = "GetNodeStackTracesResult")]
[JsonSerializable(typeof(GetFileInfoCommandParameters), TypeInfoPropertyName = "GetFileInfoCommandParameters")]
[JsonSerializable(typeof(GetFileInfoResult), TypeInfoPropertyName = "GetFileInfoResult")]
[JsonSerializable(typeof(GetDetachedDomNodesCommandParameters), TypeInfoPropertyName = "GetDetachedDomNodesCommandParameters")]
[JsonSerializable(typeof(GetDetachedDomNodesResult), TypeInfoPropertyName = "GetDetachedDomNodesResult")]
[JsonSerializable(typeof(SetInspectedNodeCommandParameters), TypeInfoPropertyName = "SetInspectedNodeCommandParameters")]
[JsonSerializable(typeof(SetInspectedNodeResult), TypeInfoPropertyName = "SetInspectedNodeResult")]
[JsonSerializable(typeof(SetNodeNameCommandParameters), TypeInfoPropertyName = "SetNodeNameCommandParameters")]
[JsonSerializable(typeof(SetNodeNameResult), TypeInfoPropertyName = "SetNodeNameResult")]
[JsonSerializable(typeof(SetNodeValueCommandParameters), TypeInfoPropertyName = "SetNodeValueCommandParameters")]
[JsonSerializable(typeof(SetNodeValueResult), TypeInfoPropertyName = "SetNodeValueResult")]
[JsonSerializable(typeof(SetOuterHTMLCommandParameters), TypeInfoPropertyName = "SetOuterHTMLCommandParameters")]
[JsonSerializable(typeof(SetOuterHTMLResult), TypeInfoPropertyName = "SetOuterHTMLResult")]
[JsonSerializable(typeof(UndoCommandParameters), TypeInfoPropertyName = "UndoCommandParameters")]
[JsonSerializable(typeof(UndoResult), TypeInfoPropertyName = "UndoResult")]
[JsonSerializable(typeof(GetFrameOwnerCommandParameters), TypeInfoPropertyName = "GetFrameOwnerCommandParameters")]
[JsonSerializable(typeof(GetFrameOwnerResult), TypeInfoPropertyName = "GetFrameOwnerResult")]
[JsonSerializable(typeof(GetContainerForNodeCommandParameters), TypeInfoPropertyName = "GetContainerForNodeCommandParameters")]
[JsonSerializable(typeof(GetContainerForNodeResult), TypeInfoPropertyName = "GetContainerForNodeResult")]
[JsonSerializable(typeof(GetQueryingDescendantsForContainerCommandParameters), TypeInfoPropertyName = "GetQueryingDescendantsForContainerCommandParameters")]
[JsonSerializable(typeof(GetQueryingDescendantsForContainerResult), TypeInfoPropertyName = "GetQueryingDescendantsForContainerResult")]
[JsonSerializable(typeof(GetAnchorElementCommandParameters), TypeInfoPropertyName = "GetAnchorElementCommandParameters")]
[JsonSerializable(typeof(GetAnchorElementResult), TypeInfoPropertyName = "GetAnchorElementResult")]
[JsonSerializable(typeof(ForceShowPopoverCommandParameters), TypeInfoPropertyName = "ForceShowPopoverCommandParameters")]
[JsonSerializable(typeof(ForceShowPopoverResult), TypeInfoPropertyName = "ForceShowPopoverResult")]
[JsonSerializable(typeof(CdpEventArgs<AttributeModifiedEventArgs>), TypeInfoPropertyName = "AttributeModifiedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<AdoptedStyleSheetsModifiedEventArgs>), TypeInfoPropertyName = "AdoptedStyleSheetsModifiedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<AttributeRemovedEventArgs>), TypeInfoPropertyName = "AttributeRemovedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<CharacterDataModifiedEventArgs>), TypeInfoPropertyName = "CharacterDataModifiedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ChildNodeCountUpdatedEventArgs>), TypeInfoPropertyName = "ChildNodeCountUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ChildNodeInsertedEventArgs>), TypeInfoPropertyName = "ChildNodeInsertedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ChildNodeRemovedEventArgs>), TypeInfoPropertyName = "ChildNodeRemovedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DistributedNodesUpdatedEventArgs>), TypeInfoPropertyName = "DistributedNodesUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DocumentUpdatedEventArgs>), TypeInfoPropertyName = "DocumentUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<InlineStyleInvalidatedEventArgs>), TypeInfoPropertyName = "InlineStyleInvalidatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<PseudoElementAddedEventArgs>), TypeInfoPropertyName = "PseudoElementAddedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<TopLayerElementsUpdatedEventArgs>), TypeInfoPropertyName = "TopLayerElementsUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ScrollableFlagUpdatedEventArgs>), TypeInfoPropertyName = "ScrollableFlagUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<AdRelatedStateUpdatedEventArgs>), TypeInfoPropertyName = "AdRelatedStateUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<AffectedByStartingStylesFlagUpdatedEventArgs>), TypeInfoPropertyName = "AffectedByStartingStylesFlagUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<PseudoElementRemovedEventArgs>), TypeInfoPropertyName = "PseudoElementRemovedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<SetChildNodesEventArgs>), TypeInfoPropertyName = "SetChildNodesCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ShadowRootPoppedEventArgs>), TypeInfoPropertyName = "ShadowRootPoppedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ShadowRootPushedEventArgs>), TypeInfoPropertyName = "ShadowRootPushedCdpEventArgs")]
[JsonSerializable(typeof(NodeId), TypeInfoPropertyName = "DOMNodeId")]
[JsonSerializable(typeof(BackendNodeId), TypeInfoPropertyName = "DOMBackendNodeId")]
[JsonSerializable(typeof(StyleSheetId), TypeInfoPropertyName = "DOMStyleSheetId")]
[JsonSerializable(typeof(BackendNode), TypeInfoPropertyName = "DOMBackendNode")]
[JsonSerializable(typeof(PseudoType), TypeInfoPropertyName = "DOMPseudoType")]
[JsonSerializable(typeof(ShadowRootType), TypeInfoPropertyName = "DOMShadowRootType")]
[JsonSerializable(typeof(CompatibilityMode), TypeInfoPropertyName = "DOMCompatibilityMode")]
[JsonSerializable(typeof(PhysicalAxes), TypeInfoPropertyName = "DOMPhysicalAxes")]
[JsonSerializable(typeof(LogicalAxes), TypeInfoPropertyName = "DOMLogicalAxes")]
[JsonSerializable(typeof(ScrollOrientation), TypeInfoPropertyName = "DOMScrollOrientation")]
[JsonSerializable(typeof(Node), TypeInfoPropertyName = "DOMNode")]
[JsonSerializable(typeof(DetachedElementInfo), TypeInfoPropertyName = "DOMDetachedElementInfo")]
[JsonSerializable(typeof(RGBA), TypeInfoPropertyName = "DOMRGBA")]
[JsonSerializable(typeof(BoxModel), TypeInfoPropertyName = "DOMBoxModel")]
[JsonSerializable(typeof(ShapeOutsideInfo), TypeInfoPropertyName = "DOMShapeOutsideInfo")]
[JsonSerializable(typeof(Rect), TypeInfoPropertyName = "DOMRect")]
[JsonSerializable(typeof(CSSComputedStyleProperty), TypeInfoPropertyName = "DOMCSSComputedStyleProperty")]
[JsonSerializable(typeof(ImmutableArray<Node>), TypeInfoPropertyName = "ImmutableArrayDOMNode")]
[JsonSerializable(typeof(ImmutableArray<CSSComputedStyleProperty>), TypeInfoPropertyName = "ImmutableArrayDOMCSSComputedStyleProperty")]
[JsonSerializable(typeof(ImmutableArray<NodeId>), TypeInfoPropertyName = "ImmutableArrayDOMNodeId")]
[JsonSerializable(typeof(ImmutableArray<BackendNodeId>), TypeInfoPropertyName = "ImmutableArrayDOMBackendNodeId")]
[JsonSerializable(typeof(ImmutableArray<DetachedElementInfo>), TypeInfoPropertyName = "ImmutableArrayDOMDetachedElementInfo")]
[JsonSerializable(typeof(ImmutableArray<StyleSheetId>), TypeInfoPropertyName = "ImmutableArrayDOMStyleSheetId")]
[JsonSerializable(typeof(ImmutableArray<BackendNode>), TypeInfoPropertyName = "ImmutableArrayDOMBackendNode")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class DOMJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="IDOM"/>.
/// </summary>
public static class DOMDomainEvent
{
    /// <summary>
    /// Fired when <b>Element</b>'s attribute is modified.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<AttributeModifiedEventArgs>> AttributeModified { get; } =
        EventDescriptor<CdpEventArgs<AttributeModifiedEventArgs>>.Create(
            "goog:cdp.DOM.attributeModified",
            DOMJsonSerializerContext.Default.AttributeModifiedCdpEventArgs);

    /// <summary>
    /// Fired when <b>Element</b>'s adoptedStyleSheets are modified.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<AdoptedStyleSheetsModifiedEventArgs>> AdoptedStyleSheetsModified { get; } =
        EventDescriptor<CdpEventArgs<AdoptedStyleSheetsModifiedEventArgs>>.Create(
            "goog:cdp.DOM.adoptedStyleSheetsModified",
            DOMJsonSerializerContext.Default.AdoptedStyleSheetsModifiedCdpEventArgs);

    /// <summary>
    /// Fired when <b>Element</b>'s attribute is removed.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<AttributeRemovedEventArgs>> AttributeRemoved { get; } =
        EventDescriptor<CdpEventArgs<AttributeRemovedEventArgs>>.Create(
            "goog:cdp.DOM.attributeRemoved",
            DOMJsonSerializerContext.Default.AttributeRemovedCdpEventArgs);

    /// <summary>
    /// Mirrors <b>DOMCharacterDataModified</b> event.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<CharacterDataModifiedEventArgs>> CharacterDataModified { get; } =
        EventDescriptor<CdpEventArgs<CharacterDataModifiedEventArgs>>.Create(
            "goog:cdp.DOM.characterDataModified",
            DOMJsonSerializerContext.Default.CharacterDataModifiedCdpEventArgs);

    /// <summary>
    /// Fired when <b>Container</b>'s child node count has changed.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ChildNodeCountUpdatedEventArgs>> ChildNodeCountUpdated { get; } =
        EventDescriptor<CdpEventArgs<ChildNodeCountUpdatedEventArgs>>.Create(
            "goog:cdp.DOM.childNodeCountUpdated",
            DOMJsonSerializerContext.Default.ChildNodeCountUpdatedCdpEventArgs);

    /// <summary>
    /// Mirrors <b>DOMNodeInserted</b> event.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ChildNodeInsertedEventArgs>> ChildNodeInserted { get; } =
        EventDescriptor<CdpEventArgs<ChildNodeInsertedEventArgs>>.Create(
            "goog:cdp.DOM.childNodeInserted",
            DOMJsonSerializerContext.Default.ChildNodeInsertedCdpEventArgs);

    /// <summary>
    /// Mirrors <b>DOMNodeRemoved</b> event.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ChildNodeRemovedEventArgs>> ChildNodeRemoved { get; } =
        EventDescriptor<CdpEventArgs<ChildNodeRemovedEventArgs>>.Create(
            "goog:cdp.DOM.childNodeRemoved",
            DOMJsonSerializerContext.Default.ChildNodeRemovedCdpEventArgs);

    /// <summary>
    /// Called when distribution is changed.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DistributedNodesUpdatedEventArgs>> DistributedNodesUpdated { get; } =
        EventDescriptor<CdpEventArgs<DistributedNodesUpdatedEventArgs>>.Create(
            "goog:cdp.DOM.distributedNodesUpdated",
            DOMJsonSerializerContext.Default.DistributedNodesUpdatedCdpEventArgs);

    /// <summary>
    /// Fired when <b>Document</b> has been totally updated. Node ids are no longer valid.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DocumentUpdatedEventArgs>> DocumentUpdated { get; } =
        EventDescriptor<CdpEventArgs<DocumentUpdatedEventArgs>>.Create(
            "goog:cdp.DOM.documentUpdated",
            DOMJsonSerializerContext.Default.DocumentUpdatedCdpEventArgs);

    /// <summary>
    /// Fired when <b>Element</b>'s inline style is modified via a CSS property modification.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<InlineStyleInvalidatedEventArgs>> InlineStyleInvalidated { get; } =
        EventDescriptor<CdpEventArgs<InlineStyleInvalidatedEventArgs>>.Create(
            "goog:cdp.DOM.inlineStyleInvalidated",
            DOMJsonSerializerContext.Default.InlineStyleInvalidatedCdpEventArgs);

    /// <summary>
    /// Called when a pseudo element is added to an element.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<PseudoElementAddedEventArgs>> PseudoElementAdded { get; } =
        EventDescriptor<CdpEventArgs<PseudoElementAddedEventArgs>>.Create(
            "goog:cdp.DOM.pseudoElementAdded",
            DOMJsonSerializerContext.Default.PseudoElementAddedCdpEventArgs);

    /// <summary>
    /// Called when top layer elements are changed.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<TopLayerElementsUpdatedEventArgs>> TopLayerElementsUpdated { get; } =
        EventDescriptor<CdpEventArgs<TopLayerElementsUpdatedEventArgs>>.Create(
            "goog:cdp.DOM.topLayerElementsUpdated",
            DOMJsonSerializerContext.Default.TopLayerElementsUpdatedCdpEventArgs);

    /// <summary>
    /// Fired when a node's scrollability state changes.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ScrollableFlagUpdatedEventArgs>> ScrollableFlagUpdated { get; } =
        EventDescriptor<CdpEventArgs<ScrollableFlagUpdatedEventArgs>>.Create(
            "goog:cdp.DOM.scrollableFlagUpdated",
            DOMJsonSerializerContext.Default.ScrollableFlagUpdatedCdpEventArgs);

    /// <summary>
    /// Fired when a node's ad related state changes.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<AdRelatedStateUpdatedEventArgs>> AdRelatedStateUpdated { get; } =
        EventDescriptor<CdpEventArgs<AdRelatedStateUpdatedEventArgs>>.Create(
            "goog:cdp.DOM.adRelatedStateUpdated",
            DOMJsonSerializerContext.Default.AdRelatedStateUpdatedCdpEventArgs);

    /// <summary>
    /// Fired when a node's starting styles changes.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<AffectedByStartingStylesFlagUpdatedEventArgs>> AffectedByStartingStylesFlagUpdated { get; } =
        EventDescriptor<CdpEventArgs<AffectedByStartingStylesFlagUpdatedEventArgs>>.Create(
            "goog:cdp.DOM.affectedByStartingStylesFlagUpdated",
            DOMJsonSerializerContext.Default.AffectedByStartingStylesFlagUpdatedCdpEventArgs);

    /// <summary>
    /// Called when a pseudo element is removed from an element.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<PseudoElementRemovedEventArgs>> PseudoElementRemoved { get; } =
        EventDescriptor<CdpEventArgs<PseudoElementRemovedEventArgs>>.Create(
            "goog:cdp.DOM.pseudoElementRemoved",
            DOMJsonSerializerContext.Default.PseudoElementRemovedCdpEventArgs);

    /// <summary>
    /// Fired when backend wants to provide client with the missing DOM structure. This happens upon
    /// most of the calls requesting node ids.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<SetChildNodesEventArgs>> SetChildNodes { get; } =
        EventDescriptor<CdpEventArgs<SetChildNodesEventArgs>>.Create(
            "goog:cdp.DOM.setChildNodes",
            DOMJsonSerializerContext.Default.SetChildNodesCdpEventArgs);

    /// <summary>
    /// Called when shadow root is popped from the element.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ShadowRootPoppedEventArgs>> ShadowRootPopped { get; } =
        EventDescriptor<CdpEventArgs<ShadowRootPoppedEventArgs>>.Create(
            "goog:cdp.DOM.shadowRootPopped",
            DOMJsonSerializerContext.Default.ShadowRootPoppedCdpEventArgs);

    /// <summary>
    /// Called when shadow root is pushed into the element.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ShadowRootPushedEventArgs>> ShadowRootPushed { get; } =
        EventDescriptor<CdpEventArgs<ShadowRootPushedEventArgs>>.Create(
            "goog:cdp.DOM.shadowRootPushed",
            DOMJsonSerializerContext.Default.ShadowRootPushedCdpEventArgs);

}
