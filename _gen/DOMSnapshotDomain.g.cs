#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.DOMSnapshot;

/// <summary>
/// This domain facilitates obtaining document snapshots with DOM, layout, and style information.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class DOMSnapshotDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static DOMSnapshotJsonSerializerContext JsonContext = DOMSnapshotJsonSerializerContext.Default;

    /// <summary>
    /// Disables DOM snapshot agent for the given page.
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
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("DOMSnapshot.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Enables DOM snapshot agent for the given page.
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
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("DOMSnapshot.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Returns a document snapshot, including the full DOM tree of the root node (including iframes,
    /// template contents, and imported documents) in a flattened array, as well as layout and
    /// white-listed computed style information for the nodes. Shadow DOM in the returned DOM tree is
    /// flattened.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>IncludeEventListeners</b> - Whether or not to retrieve details of DOM listeners (default false).</description></item>
    /// <item><description><b>IncludePaintOrder</b> - Whether to determine and include the paint order index of LayoutTreeNodes (default false).</description></item>
    /// <item><description><b>IncludeUserAgentShadowTree</b> - Whether to include UA shadow tree in the snapshot (default false).</description></item>
    /// </list>
    /// </remarks>
    /// <param name="computedStyleWhitelist">
    /// Whitelist of computed styles to return.
    /// </param>
    /// <param name="includeEventListeners">
    /// Whether or not to retrieve details of DOM listeners (default false).
    /// </param>
    /// <param name="includePaintOrder">
    /// Whether to determine and include the paint order index of LayoutTreeNodes (default false).
    /// </param>
    /// <param name="includeUserAgentShadowTree">
    /// Whether to include UA shadow tree in the snapshot (default false).
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetSnapshotResult"/>.
    /// </returns>
    [global::System.Obsolete]
    public async Task<GetSnapshotResult> GetSnapshotAsync(ImmutableArray<string> computedStyleWhitelist, bool? includeEventListeners = default, bool? includePaintOrder = default, bool? includeUserAgentShadowTree = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetSnapshotCommandParameters(ComputedStyleWhitelist: computedStyleWhitelist, IncludeEventListeners: includeEventListeners, IncludePaintOrder: includePaintOrder, IncludeUserAgentShadowTree: includeUserAgentShadowTree);
        return await ExecuteCommandAsync(GetSnapshotCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetSnapshotCommandParameters, GetSnapshotResult> GetSnapshotCommand = new("DOMSnapshot.getSnapshot", JsonContext.GetSnapshotCommandParameters, JsonContext.GetSnapshotResult);

    /// <summary>
    /// Returns a document snapshot, including the full DOM tree of the root node (including iframes,
    /// template contents, and imported documents) in a flattened array, as well as layout and
    /// white-listed computed style information for the nodes. Shadow DOM in the returned DOM tree is
    /// flattened.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>IncludePaintOrder</b> - Whether to include layout object paint orders into the snapshot.</description></item>
    /// <item><description><b>IncludeDOMRects</b> - Whether to include DOM rectangles (offsetRects, clientRects, scrollRects) into the snapshot</description></item>
    /// <item><description><b>IncludeBlendedBackgroundColors</b> - Whether to include blended background colors in the snapshot (default: false). Blended background color is achieved by blending background colors of all elements that overlap with the current element.</description></item>
    /// <item><description><b>IncludeTextColorOpacities</b> - Whether to include text color opacity in the snapshot (default: false). An element might have the opacity property set that affects the text color of the element. The final text color opacity is computed based on the opacity of all overlapping elements.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="computedStyles">
    /// Whitelist of computed styles to return.
    /// </param>
    /// <param name="includePaintOrder">
    /// Whether to include layout object paint orders into the snapshot.
    /// </param>
    /// <param name="includeDOMRects">
    /// Whether to include DOM rectangles (offsetRects, clientRects, scrollRects) into the snapshot
    /// </param>
    /// <param name="includeBlendedBackgroundColors">
    /// Whether to include blended background colors in the snapshot (default: false).
    /// Blended background color is achieved by blending background colors of all elements
    /// that overlap with the current element.
    /// </param>
    /// <param name="includeTextColorOpacities">
    /// Whether to include text color opacity in the snapshot (default: false).
    /// An element might have the opacity property set that affects the text color of the element.
    /// The final text color opacity is computed based on the opacity of all overlapping elements.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CaptureSnapshotResult"/>.
    /// </returns>
    public async Task<CaptureSnapshotResult> CaptureSnapshotAsync(ImmutableArray<string> computedStyles, bool? includePaintOrder = default, bool? includeDOMRects = default, bool? includeBlendedBackgroundColors = default, bool? includeTextColorOpacities = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CaptureSnapshotCommandParameters(ComputedStyles: computedStyles, IncludePaintOrder: includePaintOrder, IncludeDOMRects: includeDOMRects, IncludeBlendedBackgroundColors: includeBlendedBackgroundColors, IncludeTextColorOpacities: includeTextColorOpacities);
        return await ExecuteCommandAsync(CaptureSnapshotCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CaptureSnapshotCommandParameters, CaptureSnapshotResult> CaptureSnapshotCommand = new("DOMSnapshot.captureSnapshot", JsonContext.CaptureSnapshotCommandParameters, JsonContext.CaptureSnapshotResult);

}

internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record GetSnapshotCommandParameters(ImmutableArray<string> ComputedStyleWhitelist, bool? IncludeEventListeners, bool? IncludePaintOrder, bool? IncludeUserAgentShadowTree) : Parameters;

/// <summary>
/// </summary>
/// <param name="DomNodes">
/// The nodes in the DOM tree. The DOMNode at index 0 corresponds to the root document.
/// </param>
/// <param name="LayoutTreeNodes">
/// The nodes in the layout tree.
/// </param>
/// <param name="ComputedStyles">
/// Whitelisted ComputedStyle properties for each node in the layout tree.
/// </param>
public sealed record GetSnapshotResult(ImmutableArray<DOMNode> DomNodes, ImmutableArray<LayoutTreeNode> LayoutTreeNodes, ImmutableArray<ComputedStyle> ComputedStyles) : EmptyResult;


internal sealed record CaptureSnapshotCommandParameters(ImmutableArray<string> ComputedStyles, bool? IncludePaintOrder, bool? IncludeDOMRects, bool? IncludeBlendedBackgroundColors, bool? IncludeTextColorOpacities) : Parameters;

/// <summary>
/// </summary>
/// <param name="Documents">
/// The nodes in the DOM tree. The DOMNode at index 0 corresponds to the root document.
/// </param>
/// <param name="Strings">
/// Shared string table that all string properties refer to with indexes.
/// </param>
public sealed record CaptureSnapshotResult(ImmutableArray<DocumentSnapshot> Documents, ImmutableArray<string> Strings) : EmptyResult;


/// <summary>
/// A Node in the DOM tree.
/// </summary>
/// <param name="NodeType">
/// <b>Node</b>'s nodeType.
/// </param>
/// <param name="NodeName">
/// <b>Node</b>'s nodeName.
/// </param>
/// <param name="NodeValue">
/// <b>Node</b>'s nodeValue.
/// </param>
/// <param name="BackendNodeId">
/// <b>Node</b>'s id, corresponds to DOM.Node.backendNodeId.
/// </param>
public sealed record DOMNode(long NodeType, string NodeName, string NodeValue, DOM.BackendNodeId BackendNodeId)
{
    /// <summary>
    /// Only set for textarea elements, contains the text value.
    /// </summary>
    public string? TextValue { get; init; }

    /// <summary>
    /// Only set for input elements, contains the input's associated text value.
    /// </summary>
    public string? InputValue { get; init; }

    /// <summary>
    /// Only set for radio and checkbox input elements, indicates if the element has been checked
    /// </summary>
    public bool? InputChecked { get; init; }

    /// <summary>
    /// Only set for option elements, indicates if the element has been selected
    /// </summary>
    public bool? OptionSelected { get; init; }

    /// <summary>
    /// The indexes of the node's child nodes in the <b>domNodes</b> array returned by <b>getSnapshot</b>, if
    /// any.
    /// </summary>
    public ImmutableArray<long>? ChildNodeIndexes { get; init; }

    /// <summary>
    /// Attributes of an <b>Element</b> node.
    /// </summary>
    public ImmutableArray<NameValue>? Attributes { get; init; }

    /// <summary>
    /// Indexes of pseudo elements associated with this node in the <b>domNodes</b> array returned by
    /// <b>getSnapshot</b>, if any.
    /// </summary>
    public ImmutableArray<long>? PseudoElementIndexes { get; init; }

    /// <summary>
    /// The index of the node's related layout tree node in the <b>layoutTreeNodes</b> array returned by
    /// <b>getSnapshot</b>, if any.
    /// </summary>
    public long? LayoutNodeIndex { get; init; }

    /// <summary>
    /// Document URL that <b>Document</b> or <b>FrameOwner</b> node points to.
    /// </summary>
    public string? DocumentURL { get; init; }

    /// <summary>
    /// Base URL that <b>Document</b> or <b>FrameOwner</b> node uses for URL completion.
    /// </summary>
    public string? BaseURL { get; init; }

    /// <summary>
    /// Only set for documents, contains the document's content language.
    /// </summary>
    public string? ContentLanguage { get; init; }

    /// <summary>
    /// Only set for documents, contains the document's character set encoding.
    /// </summary>
    public string? DocumentEncoding { get; init; }

    /// <summary>
    /// <b>DocumentType</b> node's publicId.
    /// </summary>
    public string? PublicId { get; init; }

    /// <summary>
    /// <b>DocumentType</b> node's systemId.
    /// </summary>
    public string? SystemId { get; init; }

    /// <summary>
    /// Frame ID for frame owner elements and also for the document node.
    /// </summary>
    public Page.FrameId? FrameId { get; init; }

    /// <summary>
    /// The index of a frame owner element's content document in the <b>domNodes</b> array returned by
    /// <b>getSnapshot</b>, if any.
    /// </summary>
    public long? ContentDocumentIndex { get; init; }

    /// <summary>
    /// Type of a pseudo element node.
    /// </summary>
    public DOM.PseudoType? PseudoType { get; init; }

    /// <summary>
    /// Shadow root type.
    /// </summary>
    public DOM.ShadowRootType? ShadowRootType { get; init; }

    /// <summary>
    /// Whether this DOM node responds to mouse clicks. This includes nodes that have had click
    /// event listeners attached via JavaScript as well as anchor tags that naturally navigate when
    /// clicked.
    /// </summary>
    public bool? IsClickable { get; init; }

    /// <summary>
    /// Details of the node's event listeners, if any.
    /// </summary>
    public ImmutableArray<DOMDebugger.EventListener>? EventListeners { get; init; }

    /// <summary>
    /// The selected url for nodes with a srcset attribute.
    /// </summary>
    public string? CurrentSourceURL { get; init; }

    /// <summary>
    /// The url of the script (if any) that generates this node.
    /// </summary>
    public string? OriginURL { get; init; }

    /// <summary>
    /// Scroll offsets, set when this node is a Document.
    /// </summary>
    public double? ScrollOffsetX { get; init; }

    /// <summary>
    /// </summary>
    public double? ScrollOffsetY { get; init; }
}

/// <summary>
/// Details of post layout rendered text positions. The exact layout should not be regarded as
/// stable and may change between versions.
/// </summary>
/// <param name="BoundingBox">
/// The bounding box in document coordinates. Note that scroll offset of the document is ignored.
/// </param>
/// <param name="StartCharacterIndex">
/// The starting index in characters, for this post layout textbox substring. Characters that
/// would be represented as a surrogate pair in UTF-16 have length 2.
/// </param>
/// <param name="NumCharacters">
/// The number of characters in this post layout textbox substring. Characters that would be
/// represented as a surrogate pair in UTF-16 have length 2.
/// </param>
public sealed record InlineTextBox(DOM.Rect BoundingBox, long StartCharacterIndex, long NumCharacters)
{
}

/// <summary>
/// Details of an element in the DOM tree with a LayoutObject.
/// </summary>
/// <param name="DomNodeIndex">
/// The index of the related DOM node in the <b>domNodes</b> array returned by <b>getSnapshot</b>.
/// </param>
/// <param name="BoundingBox">
/// The bounding box in document coordinates. Note that scroll offset of the document is ignored.
/// </param>
public sealed record LayoutTreeNode(long DomNodeIndex, DOM.Rect BoundingBox)
{
    /// <summary>
    /// Contents of the LayoutText, if any.
    /// </summary>
    public string? LayoutText { get; init; }

    /// <summary>
    /// The post-layout inline text nodes, if any.
    /// </summary>
    public ImmutableArray<InlineTextBox>? InlineTextNodes { get; init; }

    /// <summary>
    /// Index into the <b>computedStyles</b> array returned by <b>getSnapshot</b>.
    /// </summary>
    public long? StyleIndex { get; init; }

    /// <summary>
    /// Global paint order index, which is determined by the stacking order of the nodes. Nodes
    /// that are painted together will have the same index. Only provided if includePaintOrder in
    /// getSnapshot was true.
    /// </summary>
    public long? PaintOrder { get; init; }

    /// <summary>
    /// Set to true to indicate the element begins a new stacking context.
    /// </summary>
    public bool? IsStackingContext { get; init; }
}

/// <summary>
/// A subset of the full ComputedStyle as defined by the request whitelist.
/// </summary>
/// <param name="Properties">
/// Name/value pairs of computed style properties.
/// </param>
public sealed record ComputedStyle(ImmutableArray<NameValue> Properties)
{
}

/// <summary>
/// A name/value pair.
/// </summary>
/// <param name="Name">
/// Attribute/property name.
/// </param>
/// <param name="Value">
/// Attribute/property value.
/// </param>
public sealed record NameValue(string Name, string Value)
{
}

/// <summary>
/// Index of the string in the strings table.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.NumberRemoteIdConverter<StringIndex>))]
public record StringIndex : INumberRemoteId
{
    double INumberRemoteId.Id { get; init; }
}

/// <summary>
/// Index of the string in the strings table.
/// </summary>

/// <summary>
/// Data that is only present on rare nodes.
/// </summary>
/// <param name="Index">
/// </param>
/// <param name="Value">
/// </param>
public sealed record RareStringData(ImmutableArray<long> Index, ImmutableArray<StringIndex> Value)
{
}

/// <summary>
/// </summary>
/// <param name="Index">
/// </param>
public sealed record RareBooleanData(ImmutableArray<long> Index)
{
}

/// <summary>
/// </summary>
/// <param name="Index">
/// </param>
/// <param name="Value">
/// </param>
public sealed record RareIntegerData(ImmutableArray<long> Index, ImmutableArray<long> Value)
{
}

/// <summary>
/// </summary>

/// <summary>
/// Document snapshot.
/// </summary>
/// <param name="DocumentURL">
/// Document URL that <b>Document</b> or <b>FrameOwner</b> node points to.
/// </param>
/// <param name="Title">
/// Document title.
/// </param>
/// <param name="BaseURL">
/// Base URL that <b>Document</b> or <b>FrameOwner</b> node uses for URL completion.
/// </param>
/// <param name="ContentLanguage">
/// Contains the document's content language.
/// </param>
/// <param name="EncodingName">
/// Contains the document's character set encoding.
/// </param>
/// <param name="PublicId">
/// <b>DocumentType</b> node's publicId.
/// </param>
/// <param name="SystemId">
/// <b>DocumentType</b> node's systemId.
/// </param>
/// <param name="FrameId">
/// Frame ID for frame owner elements and also for the document node.
/// </param>
/// <param name="Nodes">
/// A table with dom nodes.
/// </param>
/// <param name="Layout">
/// The nodes in the layout tree.
/// </param>
/// <param name="TextBoxes">
/// The post-layout inline text nodes.
/// </param>
public sealed record DocumentSnapshot(StringIndex DocumentURL, StringIndex Title, StringIndex BaseURL, StringIndex ContentLanguage, StringIndex EncodingName, StringIndex PublicId, StringIndex SystemId, StringIndex FrameId, NodeTreeSnapshot Nodes, LayoutTreeSnapshot Layout, TextBoxSnapshot TextBoxes)
{
    /// <summary>
    /// Horizontal scroll offset.
    /// </summary>
    public double? ScrollOffsetX { get; init; }

    /// <summary>
    /// Vertical scroll offset.
    /// </summary>
    public double? ScrollOffsetY { get; init; }

    /// <summary>
    /// Document content width.
    /// </summary>
    public double? ContentWidth { get; init; }

    /// <summary>
    /// Document content height.
    /// </summary>
    public double? ContentHeight { get; init; }
}

/// <summary>
/// Table containing nodes.
/// </summary>
public sealed record NodeTreeSnapshot()
{
    /// <summary>
    /// Parent node index.
    /// </summary>
    public ImmutableArray<long>? ParentIndex { get; init; }

    /// <summary>
    /// <b>Node</b>'s nodeType.
    /// </summary>
    public ImmutableArray<long>? NodeType { get; init; }

    /// <summary>
    /// Type of the shadow root the <b>Node</b> is in. String values are equal to the <b>ShadowRootType</b> enum.
    /// </summary>
    public RareStringData? ShadowRootType { get; init; }

    /// <summary>
    /// <b>Node</b>'s nodeName.
    /// </summary>
    public ImmutableArray<StringIndex>? NodeName { get; init; }

    /// <summary>
    /// <b>Node</b>'s nodeValue.
    /// </summary>
    public ImmutableArray<StringIndex>? NodeValue { get; init; }

    /// <summary>
    /// <b>Node</b>'s id, corresponds to DOM.Node.backendNodeId.
    /// </summary>
    public ImmutableArray<DOM.BackendNodeId>? BackendNodeId { get; init; }

    /// <summary>
    /// Attributes of an <b>Element</b> node. Flatten name, value pairs.
    /// </summary>
    public ImmutableArray<ImmutableArray<StringIndex>>? Attributes { get; init; }

    /// <summary>
    /// Only set for textarea elements, contains the text value.
    /// </summary>
    public RareStringData? TextValue { get; init; }

    /// <summary>
    /// Only set for input elements, contains the input's associated text value.
    /// </summary>
    public RareStringData? InputValue { get; init; }

    /// <summary>
    /// Only set for radio and checkbox input elements, indicates if the element has been checked
    /// </summary>
    public RareBooleanData? InputChecked { get; init; }

    /// <summary>
    /// Only set for option elements, indicates if the element has been selected
    /// </summary>
    public RareBooleanData? OptionSelected { get; init; }

    /// <summary>
    /// The index of the document in the list of the snapshot documents.
    /// </summary>
    public RareIntegerData? ContentDocumentIndex { get; init; }

    /// <summary>
    /// Type of a pseudo element node.
    /// </summary>
    public RareStringData? PseudoType { get; init; }

    /// <summary>
    /// Pseudo element identifier for this node. Only present if there is a
    /// valid pseudoType.
    /// </summary>
    public RareStringData? PseudoIdentifier { get; init; }

    /// <summary>
    /// Whether this DOM node responds to mouse clicks. This includes nodes that have had click
    /// event listeners attached via JavaScript as well as anchor tags that naturally navigate when
    /// clicked.
    /// </summary>
    public RareBooleanData? IsClickable { get; init; }

    /// <summary>
    /// The selected url for nodes with a srcset attribute.
    /// </summary>
    public RareStringData? CurrentSourceURL { get; init; }

    /// <summary>
    /// The url of the script (if any) that generates this node.
    /// </summary>
    public RareStringData? OriginURL { get; init; }
}

/// <summary>
/// Table of details of an element in the DOM tree with a LayoutObject.
/// </summary>
/// <param name="NodeIndex">
/// Index of the corresponding node in the <b>NodeTreeSnapshot</b> array returned by <b>captureSnapshot</b>.
/// </param>
/// <param name="Styles">
/// Array of indexes specifying computed style strings, filtered according to the <b>computedStyles</b> parameter passed to <b>captureSnapshot</b>.
/// </param>
/// <param name="Bounds">
/// The absolute position bounding box.
/// </param>
/// <param name="Text">
/// Contents of the LayoutText, if any.
/// </param>
/// <param name="StackingContexts">
/// Stacking context information.
/// </param>
public sealed record LayoutTreeSnapshot(ImmutableArray<long> NodeIndex, ImmutableArray<ImmutableArray<StringIndex>> Styles, ImmutableArray<ImmutableArray<double>> Bounds, ImmutableArray<StringIndex> Text, RareBooleanData StackingContexts)
{
    /// <summary>
    /// Global paint order index, which is determined by the stacking order of the nodes. Nodes
    /// that are painted together will have the same index. Only provided if includePaintOrder in
    /// captureSnapshot was true.
    /// </summary>
    public ImmutableArray<long>? PaintOrders { get; init; }

    /// <summary>
    /// The offset rect of nodes. Only available when includeDOMRects is set to true
    /// </summary>
    public ImmutableArray<ImmutableArray<double>>? OffsetRects { get; init; }

    /// <summary>
    /// The scroll rect of nodes. Only available when includeDOMRects is set to true
    /// </summary>
    public ImmutableArray<ImmutableArray<double>>? ScrollRects { get; init; }

    /// <summary>
    /// The client rect of nodes. Only available when includeDOMRects is set to true
    /// </summary>
    public ImmutableArray<ImmutableArray<double>>? ClientRects { get; init; }

    /// <summary>
    /// The list of background colors that are blended with colors of overlapping elements.
    /// </summary>
    public ImmutableArray<StringIndex>? BlendedBackgroundColors { get; init; }

    /// <summary>
    /// The list of computed text opacities.
    /// </summary>
    public ImmutableArray<double>? TextColorOpacities { get; init; }
}

/// <summary>
/// Table of details of the post layout rendered text positions. The exact layout should not be regarded as
/// stable and may change between versions.
/// </summary>
/// <param name="LayoutIndex">
/// Index of the layout tree node that owns this box collection.
/// </param>
/// <param name="Bounds">
/// The absolute position bounding box.
/// </param>
/// <param name="Start">
/// The starting index in characters, for this post layout textbox substring. Characters that
/// would be represented as a surrogate pair in UTF-16 have length 2.
/// </param>
/// <param name="Length">
/// The number of characters in this post layout textbox substring. Characters that would be
/// represented as a surrogate pair in UTF-16 have length 2.
/// </param>
public sealed record TextBoxSnapshot(ImmutableArray<long> LayoutIndex, ImmutableArray<ImmutableArray<double>> Bounds, ImmutableArray<long> Start, ImmutableArray<long> Length)
{
}

[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(GetSnapshotCommandParameters), TypeInfoPropertyName = "GetSnapshotCommandParameters")]
[JsonSerializable(typeof(GetSnapshotResult), TypeInfoPropertyName = "GetSnapshotResult")]
[JsonSerializable(typeof(CaptureSnapshotCommandParameters), TypeInfoPropertyName = "CaptureSnapshotCommandParameters")]
[JsonSerializable(typeof(CaptureSnapshotResult), TypeInfoPropertyName = "CaptureSnapshotResult")]
[JsonSerializable(typeof(DOMNode), TypeInfoPropertyName = "DOMSnapshotDOMNode")]
[JsonSerializable(typeof(InlineTextBox), TypeInfoPropertyName = "DOMSnapshotInlineTextBox")]
[JsonSerializable(typeof(LayoutTreeNode), TypeInfoPropertyName = "DOMSnapshotLayoutTreeNode")]
[JsonSerializable(typeof(ComputedStyle), TypeInfoPropertyName = "DOMSnapshotComputedStyle")]
[JsonSerializable(typeof(NameValue), TypeInfoPropertyName = "DOMSnapshotNameValue")]
[JsonSerializable(typeof(StringIndex), TypeInfoPropertyName = "DOMSnapshotStringIndex")]
[JsonSerializable(typeof(RareStringData), TypeInfoPropertyName = "DOMSnapshotRareStringData")]
[JsonSerializable(typeof(RareBooleanData), TypeInfoPropertyName = "DOMSnapshotRareBooleanData")]
[JsonSerializable(typeof(RareIntegerData), TypeInfoPropertyName = "DOMSnapshotRareIntegerData")]
[JsonSerializable(typeof(DocumentSnapshot), TypeInfoPropertyName = "DOMSnapshotDocumentSnapshot")]
[JsonSerializable(typeof(NodeTreeSnapshot), TypeInfoPropertyName = "DOMSnapshotNodeTreeSnapshot")]
[JsonSerializable(typeof(LayoutTreeSnapshot), TypeInfoPropertyName = "DOMSnapshotLayoutTreeSnapshot")]
[JsonSerializable(typeof(TextBoxSnapshot), TypeInfoPropertyName = "DOMSnapshotTextBoxSnapshot")]
[JsonSerializable(typeof(ImmutableArray<DOMNode>), TypeInfoPropertyName = "ImmutableArrayDOMSnapshotDOMNode")]
[JsonSerializable(typeof(ImmutableArray<LayoutTreeNode>), TypeInfoPropertyName = "ImmutableArrayDOMSnapshotLayoutTreeNode")]
[JsonSerializable(typeof(ImmutableArray<ComputedStyle>), TypeInfoPropertyName = "ImmutableArrayDOMSnapshotComputedStyle")]
[JsonSerializable(typeof(ImmutableArray<DocumentSnapshot>), TypeInfoPropertyName = "ImmutableArrayDOMSnapshotDocumentSnapshot")]
[JsonSerializable(typeof(ImmutableArray<NameValue>), TypeInfoPropertyName = "ImmutableArrayDOMSnapshotNameValue")]
[JsonSerializable(typeof(ImmutableArray<DOMDebugger.EventListener>), TypeInfoPropertyName = "ImmutableArrayDOMDebuggerEventListener")]
[JsonSerializable(typeof(ImmutableArray<InlineTextBox>), TypeInfoPropertyName = "ImmutableArrayDOMSnapshotInlineTextBox")]
[JsonSerializable(typeof(ImmutableArray<StringIndex>), TypeInfoPropertyName = "ImmutableArrayDOMSnapshotStringIndex")]
[JsonSerializable(typeof(ImmutableArray<DOM.BackendNodeId>), TypeInfoPropertyName = "ImmutableArrayDOMBackendNodeId")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class DOMSnapshotJsonSerializerContext : JsonSerializerContext;

