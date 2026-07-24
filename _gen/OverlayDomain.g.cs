#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Overlay;

/// <summary>
/// This domain provides various functionality related to drawing atop the inspected page.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class OverlayDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static OverlayJsonSerializerContext JsonContext = OverlayJsonSerializerContext.Default;

    /// <summary>
    /// Disables domain notifications.
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
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("Overlay.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Enables domain notifications.
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
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("Overlay.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// For testing.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>IncludeDistance</b> - Whether to include distance info.</description></item>
    /// <item><description><b>IncludeStyle</b> - Whether to include style info.</description></item>
    /// <item><description><b>ColorFormat</b> - The color format to get config with (default: hex).</description></item>
    /// <item><description><b>ShowAccessibilityInfo</b> - Whether to show accessibility info (default: true).</description></item>
    /// </list>
    /// </remarks>
    /// <param name="nodeId">
    /// Id of the node to get highlight object for.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetHighlightObjectForTestCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetHighlightObjectForTestResult"/>.
    /// </returns>
    public async Task<GetHighlightObjectForTestResult> GetHighlightObjectForTestAsync(DOM.NodeId nodeId, GetHighlightObjectForTestCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetHighlightObjectForTestCommandParameters(NodeId: nodeId, IncludeDistance: options?.IncludeDistance, IncludeStyle: options?.IncludeStyle, ColorFormat: options?.ColorFormat, ShowAccessibilityInfo: options?.ShowAccessibilityInfo);
        return await ExecuteCommandAsync(GetHighlightObjectForTestCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetHighlightObjectForTestCommandParameters, GetHighlightObjectForTestResult> GetHighlightObjectForTestCommand = new("Overlay.getHighlightObjectForTest", JsonContext.GetHighlightObjectForTestCommandParameters, JsonContext.GetHighlightObjectForTestResult);

    /// <summary>
    /// For Persistent Grid testing.
    /// </summary>
    /// <param name="nodeIds">
    /// Ids of the node to get highlight object for.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetGridHighlightObjectsForTestCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetGridHighlightObjectsForTestResult"/>.
    /// </returns>
    public async Task<GetGridHighlightObjectsForTestResult> GetGridHighlightObjectsForTestAsync(ImmutableArray<DOM.NodeId> nodeIds, GetGridHighlightObjectsForTestCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetGridHighlightObjectsForTestCommandParameters(NodeIds: nodeIds);
        return await ExecuteCommandAsync(GetGridHighlightObjectsForTestCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetGridHighlightObjectsForTestCommandParameters, GetGridHighlightObjectsForTestResult> GetGridHighlightObjectsForTestCommand = new("Overlay.getGridHighlightObjectsForTest", JsonContext.GetGridHighlightObjectsForTestCommandParameters, JsonContext.GetGridHighlightObjectsForTestResult);

    /// <summary>
    /// For Source Order Viewer testing.
    /// </summary>
    /// <param name="nodeId">
    /// Id of the node to highlight.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetSourceOrderHighlightObjectForTestCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetSourceOrderHighlightObjectForTestResult"/>.
    /// </returns>
    public async Task<GetSourceOrderHighlightObjectForTestResult> GetSourceOrderHighlightObjectForTestAsync(DOM.NodeId nodeId, GetSourceOrderHighlightObjectForTestCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetSourceOrderHighlightObjectForTestCommandParameters(NodeId: nodeId);
        return await ExecuteCommandAsync(GetSourceOrderHighlightObjectForTestCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetSourceOrderHighlightObjectForTestCommandParameters, GetSourceOrderHighlightObjectForTestResult> GetSourceOrderHighlightObjectForTestCommand = new("Overlay.getSourceOrderHighlightObjectForTest", JsonContext.GetSourceOrderHighlightObjectForTestCommandParameters, JsonContext.GetSourceOrderHighlightObjectForTestResult);

    /// <summary>
    /// Hides any highlight.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="HideHighlightCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="HideHighlightResult"/>.
    /// </returns>
    public async Task<HideHighlightResult> HideHighlightAsync(HideHighlightCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new HideHighlightCommandParameters();
        return await ExecuteCommandAsync(HideHighlightCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<HideHighlightCommandParameters, HideHighlightResult> HideHighlightCommand = new("Overlay.hideHighlight", JsonContext.HideHighlightCommandParameters, JsonContext.HideHighlightResult);

    /// <summary>
    /// Highlights owner element of the frame with given id.
    /// Deprecated: Doesn't work reliably and cannot be fixed due to process
    /// separation (the owner node might be in a different process). Determine
    /// the owner node in the client and use highlightNode.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>ContentColor</b> - The content box highlight fill color (default: transparent).</description></item>
    /// <item><description><b>ContentOutlineColor</b> - The content box highlight outline color (default: transparent).</description></item>
    /// </list>
    /// </remarks>
    /// <param name="frameId">
    /// Identifier of the frame to highlight.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="HighlightFrameCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="HighlightFrameResult"/>.
    /// </returns>
    [global::System.Obsolete]
    public async Task<HighlightFrameResult> HighlightFrameAsync(Page.FrameId frameId, HighlightFrameCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new HighlightFrameCommandParameters(FrameId: frameId, ContentColor: options?.ContentColor, ContentOutlineColor: options?.ContentOutlineColor);
        return await ExecuteCommandAsync(HighlightFrameCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<HighlightFrameCommandParameters, HighlightFrameResult> HighlightFrameCommand = new("Overlay.highlightFrame", JsonContext.HighlightFrameCommandParameters, JsonContext.HighlightFrameResult);

    /// <summary>
    /// Highlights DOM node with given id or with the given JavaScript object wrapper. Either nodeId or
    /// objectId must be specified.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>NodeId</b> - Identifier of the node to highlight.</description></item>
    /// <item><description><b>BackendNodeId</b> - Identifier of the backend node to highlight.</description></item>
    /// <item><description><b>ObjectId</b> - JavaScript object id of the node to be highlighted.</description></item>
    /// <item><description><b>Selector</b> - Selectors to highlight relevant nodes.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="highlightConfig">
    /// A descriptor for the highlight appearance.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="HighlightNodeCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="HighlightNodeResult"/>.
    /// </returns>
    public async Task<HighlightNodeResult> HighlightNodeAsync(HighlightConfig highlightConfig, HighlightNodeCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new HighlightNodeCommandParameters(HighlightConfig: highlightConfig, NodeId: options?.NodeId, BackendNodeId: options?.BackendNodeId, ObjectId: options?.ObjectId, Selector: options?.Selector);
        return await ExecuteCommandAsync(HighlightNodeCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<HighlightNodeCommandParameters, HighlightNodeResult> HighlightNodeCommand = new("Overlay.highlightNode", JsonContext.HighlightNodeCommandParameters, JsonContext.HighlightNodeResult);

    /// <summary>
    /// Highlights given quad. Coordinates are absolute with respect to the main frame viewport.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Color</b> - The highlight fill color (default: transparent).</description></item>
    /// <item><description><b>OutlineColor</b> - The highlight outline color (default: transparent).</description></item>
    /// </list>
    /// </remarks>
    /// <param name="quad">
    /// Quad to highlight
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="HighlightQuadCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="HighlightQuadResult"/>.
    /// </returns>
    public async Task<HighlightQuadResult> HighlightQuadAsync(ImmutableArray<double> quad, HighlightQuadCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new HighlightQuadCommandParameters(Quad: quad, Color: options?.Color, OutlineColor: options?.OutlineColor);
        return await ExecuteCommandAsync(HighlightQuadCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<HighlightQuadCommandParameters, HighlightQuadResult> HighlightQuadCommand = new("Overlay.highlightQuad", JsonContext.HighlightQuadCommandParameters, JsonContext.HighlightQuadResult);

    /// <summary>
    /// Highlights given rectangle. Coordinates are absolute with respect to the main frame viewport.
    /// Issue: the method does not handle device pixel ratio (DPR) correctly.
    /// The coordinates currently have to be adjusted by the client
    /// if DPR is not 1 (see crbug.com/437807128).
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Color</b> - The highlight fill color (default: transparent).</description></item>
    /// <item><description><b>OutlineColor</b> - The highlight outline color (default: transparent).</description></item>
    /// </list>
    /// </remarks>
    /// <param name="x">
    /// X coordinate
    /// </param>
    /// <param name="y">
    /// Y coordinate
    /// </param>
    /// <param name="width">
    /// Rectangle width
    /// </param>
    /// <param name="height">
    /// Rectangle height
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="HighlightRectCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="HighlightRectResult"/>.
    /// </returns>
    public async Task<HighlightRectResult> HighlightRectAsync(long x, long y, long width, long height, HighlightRectCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new HighlightRectCommandParameters(X: x, Y: y, Width: width, Height: height, Color: options?.Color, OutlineColor: options?.OutlineColor);
        return await ExecuteCommandAsync(HighlightRectCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<HighlightRectCommandParameters, HighlightRectResult> HighlightRectCommand = new("Overlay.highlightRect", JsonContext.HighlightRectCommandParameters, JsonContext.HighlightRectResult);

    /// <summary>
    /// Highlights the source order of the children of the DOM node with given id or with the given
    /// JavaScript object wrapper. Either nodeId or objectId must be specified.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>NodeId</b> - Identifier of the node to highlight.</description></item>
    /// <item><description><b>BackendNodeId</b> - Identifier of the backend node to highlight.</description></item>
    /// <item><description><b>ObjectId</b> - JavaScript object id of the node to be highlighted.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="sourceOrderConfig">
    /// A descriptor for the appearance of the overlay drawing.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="HighlightSourceOrderCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="HighlightSourceOrderResult"/>.
    /// </returns>
    public async Task<HighlightSourceOrderResult> HighlightSourceOrderAsync(SourceOrderConfig sourceOrderConfig, HighlightSourceOrderCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new HighlightSourceOrderCommandParameters(SourceOrderConfig: sourceOrderConfig, NodeId: options?.NodeId, BackendNodeId: options?.BackendNodeId, ObjectId: options?.ObjectId);
        return await ExecuteCommandAsync(HighlightSourceOrderCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<HighlightSourceOrderCommandParameters, HighlightSourceOrderResult> HighlightSourceOrderCommand = new("Overlay.highlightSourceOrder", JsonContext.HighlightSourceOrderCommandParameters, JsonContext.HighlightSourceOrderResult);

    /// <summary>
    /// Enters the 'inspect' mode. In this mode, elements that user is hovering over are highlighted.
    /// Backend then generates 'inspectNodeRequested' event upon element selection.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>HighlightConfig</b> - A descriptor for the highlight appearance of hovered-over nodes. May be omitted if `enabled == false`.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="mode">
    /// Set an inspection mode.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetInspectModeCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetInspectModeResult"/>.
    /// </returns>
    public async Task<SetInspectModeResult> SetInspectModeAsync(InspectMode mode, SetInspectModeCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetInspectModeCommandParameters(Mode: mode, HighlightConfig: options?.HighlightConfig);
        return await ExecuteCommandAsync(SetInspectModeCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetInspectModeCommandParameters, SetInspectModeResult> SetInspectModeCommand = new("Overlay.setInspectMode", JsonContext.SetInspectModeCommandParameters, JsonContext.SetInspectModeResult);

    /// <summary>
    /// Highlights owner element of all frames detected to be ads.
    /// </summary>
    /// <param name="show">
    /// True for showing ad highlights
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetShowAdHighlightsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetShowAdHighlightsResult"/>.
    /// </returns>
    public async Task<SetShowAdHighlightsResult> SetShowAdHighlightsAsync(bool show, SetShowAdHighlightsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetShowAdHighlightsCommandParameters(Show: show);
        return await ExecuteCommandAsync(SetShowAdHighlightsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetShowAdHighlightsCommandParameters, SetShowAdHighlightsResult> SetShowAdHighlightsCommand = new("Overlay.setShowAdHighlights", JsonContext.SetShowAdHighlightsCommandParameters, JsonContext.SetShowAdHighlightsResult);

    /// <summary>
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Message</b> - The message to display, also triggers resume and step over controls.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetPausedInDebuggerMessageCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetPausedInDebuggerMessageResult"/>.
    /// </returns>
    public async Task<SetPausedInDebuggerMessageResult> SetPausedInDebuggerMessageAsync(SetPausedInDebuggerMessageCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetPausedInDebuggerMessageCommandParameters(Message: options?.Message);
        return await ExecuteCommandAsync(SetPausedInDebuggerMessageCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetPausedInDebuggerMessageCommandParameters, SetPausedInDebuggerMessageResult> SetPausedInDebuggerMessageCommand = new("Overlay.setPausedInDebuggerMessage", JsonContext.SetPausedInDebuggerMessageCommandParameters, JsonContext.SetPausedInDebuggerMessageResult);

    /// <summary>
    /// Requests that backend shows debug borders on layers
    /// </summary>
    /// <param name="show">
    /// True for showing debug borders
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetShowDebugBordersCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetShowDebugBordersResult"/>.
    /// </returns>
    public async Task<SetShowDebugBordersResult> SetShowDebugBordersAsync(bool show, SetShowDebugBordersCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetShowDebugBordersCommandParameters(Show: show);
        return await ExecuteCommandAsync(SetShowDebugBordersCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetShowDebugBordersCommandParameters, SetShowDebugBordersResult> SetShowDebugBordersCommand = new("Overlay.setShowDebugBorders", JsonContext.SetShowDebugBordersCommandParameters, JsonContext.SetShowDebugBordersResult);

    /// <summary>
    /// Requests that backend shows the FPS counter
    /// </summary>
    /// <param name="show">
    /// True for showing the FPS counter
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetShowFPSCounterCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetShowFPSCounterResult"/>.
    /// </returns>
    public async Task<SetShowFPSCounterResult> SetShowFPSCounterAsync(bool show, SetShowFPSCounterCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetShowFPSCounterCommandParameters(Show: show);
        return await ExecuteCommandAsync(SetShowFPSCounterCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetShowFPSCounterCommandParameters, SetShowFPSCounterResult> SetShowFPSCounterCommand = new("Overlay.setShowFPSCounter", JsonContext.SetShowFPSCounterCommandParameters, JsonContext.SetShowFPSCounterResult);

    /// <summary>
    /// Highlight multiple elements with the CSS Grid overlay.
    /// </summary>
    /// <param name="gridNodeHighlightConfigs">
    /// An array of node identifiers and descriptors for the highlight appearance.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetShowGridOverlaysCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetShowGridOverlaysResult"/>.
    /// </returns>
    public async Task<SetShowGridOverlaysResult> SetShowGridOverlaysAsync(ImmutableArray<GridNodeHighlightConfig> gridNodeHighlightConfigs, SetShowGridOverlaysCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetShowGridOverlaysCommandParameters(GridNodeHighlightConfigs: gridNodeHighlightConfigs);
        return await ExecuteCommandAsync(SetShowGridOverlaysCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetShowGridOverlaysCommandParameters, SetShowGridOverlaysResult> SetShowGridOverlaysCommand = new("Overlay.setShowGridOverlays", JsonContext.SetShowGridOverlaysCommandParameters, JsonContext.SetShowGridOverlaysResult);

    /// <summary>
    /// </summary>
    /// <param name="flexNodeHighlightConfigs">
    /// An array of node identifiers and descriptors for the highlight appearance.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetShowFlexOverlaysCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetShowFlexOverlaysResult"/>.
    /// </returns>
    public async Task<SetShowFlexOverlaysResult> SetShowFlexOverlaysAsync(ImmutableArray<FlexNodeHighlightConfig> flexNodeHighlightConfigs, SetShowFlexOverlaysCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetShowFlexOverlaysCommandParameters(FlexNodeHighlightConfigs: flexNodeHighlightConfigs);
        return await ExecuteCommandAsync(SetShowFlexOverlaysCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetShowFlexOverlaysCommandParameters, SetShowFlexOverlaysResult> SetShowFlexOverlaysCommand = new("Overlay.setShowFlexOverlays", JsonContext.SetShowFlexOverlaysCommandParameters, JsonContext.SetShowFlexOverlaysResult);

    /// <summary>
    /// </summary>
    /// <param name="scrollSnapHighlightConfigs">
    /// An array of node identifiers and descriptors for the highlight appearance.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetShowScrollSnapOverlaysCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetShowScrollSnapOverlaysResult"/>.
    /// </returns>
    public async Task<SetShowScrollSnapOverlaysResult> SetShowScrollSnapOverlaysAsync(ImmutableArray<ScrollSnapHighlightConfig> scrollSnapHighlightConfigs, SetShowScrollSnapOverlaysCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetShowScrollSnapOverlaysCommandParameters(ScrollSnapHighlightConfigs: scrollSnapHighlightConfigs);
        return await ExecuteCommandAsync(SetShowScrollSnapOverlaysCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetShowScrollSnapOverlaysCommandParameters, SetShowScrollSnapOverlaysResult> SetShowScrollSnapOverlaysCommand = new("Overlay.setShowScrollSnapOverlays", JsonContext.SetShowScrollSnapOverlaysCommandParameters, JsonContext.SetShowScrollSnapOverlaysResult);

    /// <summary>
    /// </summary>
    /// <param name="containerQueryHighlightConfigs">
    /// An array of node identifiers and descriptors for the highlight appearance.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetShowContainerQueryOverlaysCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetShowContainerQueryOverlaysResult"/>.
    /// </returns>
    public async Task<SetShowContainerQueryOverlaysResult> SetShowContainerQueryOverlaysAsync(ImmutableArray<ContainerQueryHighlightConfig> containerQueryHighlightConfigs, SetShowContainerQueryOverlaysCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetShowContainerQueryOverlaysCommandParameters(ContainerQueryHighlightConfigs: containerQueryHighlightConfigs);
        return await ExecuteCommandAsync(SetShowContainerQueryOverlaysCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetShowContainerQueryOverlaysCommandParameters, SetShowContainerQueryOverlaysResult> SetShowContainerQueryOverlaysCommand = new("Overlay.setShowContainerQueryOverlays", JsonContext.SetShowContainerQueryOverlaysCommandParameters, JsonContext.SetShowContainerQueryOverlaysResult);

    /// <summary>
    /// </summary>
    /// <param name="inspectedElementAnchorConfig">
    /// Node identifier for which to show an anchor for.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetShowInspectedElementAnchorCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetShowInspectedElementAnchorResult"/>.
    /// </returns>
    public async Task<SetShowInspectedElementAnchorResult> SetShowInspectedElementAnchorAsync(InspectedElementAnchorConfig inspectedElementAnchorConfig, SetShowInspectedElementAnchorCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetShowInspectedElementAnchorCommandParameters(InspectedElementAnchorConfig: inspectedElementAnchorConfig);
        return await ExecuteCommandAsync(SetShowInspectedElementAnchorCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetShowInspectedElementAnchorCommandParameters, SetShowInspectedElementAnchorResult> SetShowInspectedElementAnchorCommand = new("Overlay.setShowInspectedElementAnchor", JsonContext.SetShowInspectedElementAnchorCommandParameters, JsonContext.SetShowInspectedElementAnchorResult);

    /// <summary>
    /// Requests that backend shows paint rectangles
    /// </summary>
    /// <param name="result">
    /// True for showing paint rectangles
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetShowPaintRectsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetShowPaintRectsResult"/>.
    /// </returns>
    public async Task<SetShowPaintRectsResult> SetShowPaintRectsAsync(bool result, SetShowPaintRectsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetShowPaintRectsCommandParameters(Result: result);
        return await ExecuteCommandAsync(SetShowPaintRectsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetShowPaintRectsCommandParameters, SetShowPaintRectsResult> SetShowPaintRectsCommand = new("Overlay.setShowPaintRects", JsonContext.SetShowPaintRectsCommandParameters, JsonContext.SetShowPaintRectsResult);

    /// <summary>
    /// Requests that backend shows layout shift regions
    /// </summary>
    /// <param name="result">
    /// True for showing layout shift regions
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetShowLayoutShiftRegionsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetShowLayoutShiftRegionsResult"/>.
    /// </returns>
    public async Task<SetShowLayoutShiftRegionsResult> SetShowLayoutShiftRegionsAsync(bool result, SetShowLayoutShiftRegionsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetShowLayoutShiftRegionsCommandParameters(Result: result);
        return await ExecuteCommandAsync(SetShowLayoutShiftRegionsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetShowLayoutShiftRegionsCommandParameters, SetShowLayoutShiftRegionsResult> SetShowLayoutShiftRegionsCommand = new("Overlay.setShowLayoutShiftRegions", JsonContext.SetShowLayoutShiftRegionsCommandParameters, JsonContext.SetShowLayoutShiftRegionsResult);

    /// <summary>
    /// Requests that backend shows scroll bottleneck rects
    /// </summary>
    /// <param name="show">
    /// True for showing scroll bottleneck rects
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetShowScrollBottleneckRectsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetShowScrollBottleneckRectsResult"/>.
    /// </returns>
    public async Task<SetShowScrollBottleneckRectsResult> SetShowScrollBottleneckRectsAsync(bool show, SetShowScrollBottleneckRectsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetShowScrollBottleneckRectsCommandParameters(Show: show);
        return await ExecuteCommandAsync(SetShowScrollBottleneckRectsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetShowScrollBottleneckRectsCommandParameters, SetShowScrollBottleneckRectsResult> SetShowScrollBottleneckRectsCommand = new("Overlay.setShowScrollBottleneckRects", JsonContext.SetShowScrollBottleneckRectsCommandParameters, JsonContext.SetShowScrollBottleneckRectsResult);

    /// <summary>
    /// Deprecated, no longer has any effect.
    /// </summary>
    /// <param name="show">
    /// True for showing hit-test borders
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetShowHitTestBordersCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetShowHitTestBordersResult"/>.
    /// </returns>
    [global::System.Obsolete]
    public async Task<SetShowHitTestBordersResult> SetShowHitTestBordersAsync(bool show, SetShowHitTestBordersCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetShowHitTestBordersCommandParameters(Show: show);
        return await ExecuteCommandAsync(SetShowHitTestBordersCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetShowHitTestBordersCommandParameters, SetShowHitTestBordersResult> SetShowHitTestBordersCommand = new("Overlay.setShowHitTestBorders", JsonContext.SetShowHitTestBordersCommandParameters, JsonContext.SetShowHitTestBordersResult);

    /// <summary>
    /// Deprecated, no longer has any effect.
    /// </summary>
    /// <param name="show">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetShowWebVitalsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetShowWebVitalsResult"/>.
    /// </returns>
    [global::System.Obsolete]
    public async Task<SetShowWebVitalsResult> SetShowWebVitalsAsync(bool show, SetShowWebVitalsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetShowWebVitalsCommandParameters(Show: show);
        return await ExecuteCommandAsync(SetShowWebVitalsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetShowWebVitalsCommandParameters, SetShowWebVitalsResult> SetShowWebVitalsCommand = new("Overlay.setShowWebVitals", JsonContext.SetShowWebVitalsCommandParameters, JsonContext.SetShowWebVitalsResult);

    /// <summary>
    /// Paints viewport size upon main frame resize.
    /// </summary>
    /// <param name="show">
    /// Whether to paint size or not.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetShowViewportSizeOnResizeCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetShowViewportSizeOnResizeResult"/>.
    /// </returns>
    public async Task<SetShowViewportSizeOnResizeResult> SetShowViewportSizeOnResizeAsync(bool show, SetShowViewportSizeOnResizeCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetShowViewportSizeOnResizeCommandParameters(Show: show);
        return await ExecuteCommandAsync(SetShowViewportSizeOnResizeCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetShowViewportSizeOnResizeCommandParameters, SetShowViewportSizeOnResizeResult> SetShowViewportSizeOnResizeCommand = new("Overlay.setShowViewportSizeOnResize", JsonContext.SetShowViewportSizeOnResizeCommandParameters, JsonContext.SetShowViewportSizeOnResizeResult);

    /// <summary>
    /// Add a dual screen device hinge
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>HingeConfig</b> - hinge data, null means hideHinge</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetShowHingeCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetShowHingeResult"/>.
    /// </returns>
    public async Task<SetShowHingeResult> SetShowHingeAsync(SetShowHingeCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetShowHingeCommandParameters(HingeConfig: options?.HingeConfig);
        return await ExecuteCommandAsync(SetShowHingeCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetShowHingeCommandParameters, SetShowHingeResult> SetShowHingeCommand = new("Overlay.setShowHinge", JsonContext.SetShowHingeCommandParameters, JsonContext.SetShowHingeResult);

    /// <summary>
    /// Add a display cutout overlay.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>DisplayCutoutConfig</b> - display cutout data, null means hide display cutout</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetShowDisplayCutoutCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetShowDisplayCutoutResult"/>.
    /// </returns>
    public async Task<SetShowDisplayCutoutResult> SetShowDisplayCutoutAsync(SetShowDisplayCutoutCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetShowDisplayCutoutCommandParameters(DisplayCutoutConfig: options?.DisplayCutoutConfig);
        return await ExecuteCommandAsync(SetShowDisplayCutoutCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetShowDisplayCutoutCommandParameters, SetShowDisplayCutoutResult> SetShowDisplayCutoutCommand = new("Overlay.setShowDisplayCutout", JsonContext.SetShowDisplayCutoutCommandParameters, JsonContext.SetShowDisplayCutoutResult);

    /// <summary>
    /// Show elements in isolation mode with overlays.
    /// </summary>
    /// <param name="isolatedElementHighlightConfigs">
    /// An array of node identifiers and descriptors for the highlight appearance.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetShowIsolatedElementsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetShowIsolatedElementsResult"/>.
    /// </returns>
    public async Task<SetShowIsolatedElementsResult> SetShowIsolatedElementsAsync(ImmutableArray<IsolatedElementHighlightConfig> isolatedElementHighlightConfigs, SetShowIsolatedElementsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetShowIsolatedElementsCommandParameters(IsolatedElementHighlightConfigs: isolatedElementHighlightConfigs);
        return await ExecuteCommandAsync(SetShowIsolatedElementsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetShowIsolatedElementsCommandParameters, SetShowIsolatedElementsResult> SetShowIsolatedElementsCommand = new("Overlay.setShowIsolatedElements", JsonContext.SetShowIsolatedElementsCommandParameters, JsonContext.SetShowIsolatedElementsResult);

    /// <summary>
    /// Show Window Controls Overlay for PWA
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>WindowControlsOverlayConfig</b> - Window Controls Overlay data, null means hide Window Controls Overlay</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetShowWindowControlsOverlayCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetShowWindowControlsOverlayResult"/>.
    /// </returns>
    public async Task<SetShowWindowControlsOverlayResult> SetShowWindowControlsOverlayAsync(SetShowWindowControlsOverlayCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetShowWindowControlsOverlayCommandParameters(WindowControlsOverlayConfig: options?.WindowControlsOverlayConfig);
        return await ExecuteCommandAsync(SetShowWindowControlsOverlayCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetShowWindowControlsOverlayCommandParameters, SetShowWindowControlsOverlayResult> SetShowWindowControlsOverlayCommand = new("Overlay.setShowWindowControlsOverlay", JsonContext.SetShowWindowControlsOverlayCommandParameters, JsonContext.SetShowWindowControlsOverlayResult);

    /// <summary>
    /// Fired when the node should be inspected. This happens after call to <b>setInspectMode</b> or when
    /// user manually inspects an element.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="InspectNodeRequestedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>BackendNodeId</b> - Id of the node to inspect.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<InspectNodeRequestedEventArgs> InspectNodeRequested => CreateCdpEventSource(OverlayDomainEvent.InspectNodeRequested);
    /// <summary>
    /// Fired when the node should be highlighted. This happens after call to <b>setInspectMode</b>.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="NodeHighlightRequestedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>NodeId</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<NodeHighlightRequestedEventArgs> NodeHighlightRequested => CreateCdpEventSource(OverlayDomainEvent.NodeHighlightRequested);
    /// <summary>
    /// Fired when user asks to capture screenshot of some area on the page.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ScreenshotRequestedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Viewport</b> - Viewport to capture, in device independent pixels (dip).</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ScreenshotRequestedEventArgs> ScreenshotRequested => CreateCdpEventSource(OverlayDomainEvent.ScreenshotRequested);
    /// <summary>
    /// Fired when user asks to show the Inspect panel.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="InspectPanelShowRequestedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>BackendNodeId</b> - Id of the node to show in the panel.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<InspectPanelShowRequestedEventArgs> InspectPanelShowRequested => CreateCdpEventSource(OverlayDomainEvent.InspectPanelShowRequested);
    /// <summary>
    /// Fired when user asks to restore the Inspected Element floating window.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="InspectedElementWindowRestoredEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>BackendNodeId</b> - Id of the node to restore the floating window for.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<InspectedElementWindowRestoredEventArgs> InspectedElementWindowRestored => CreateCdpEventSource(OverlayDomainEvent.InspectedElementWindowRestored);
    /// <summary>
    /// Fired when user cancels the inspect mode.
    /// </summary>
    public IEventSource<InspectModeCanceledEventArgs> InspectModeCanceled => CreateCdpEventSource(OverlayDomainEvent.InspectModeCanceled);
}

internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.DisableAsync"/>.
/// </summary>
public sealed record DisableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.EnableAsync"/>.
/// </summary>
public sealed record EnableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record GetHighlightObjectForTestCommandParameters(DOM.NodeId NodeId, bool? IncludeDistance, bool? IncludeStyle, ColorFormat? ColorFormat, bool? ShowAccessibilityInfo) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.GetHighlightObjectForTestAsync"/>.
/// </summary>
public sealed record GetHighlightObjectForTestCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Whether to include distance info.
    /// </summary>
    public bool? IncludeDistance { get; init; }

    /// <summary>
    /// Whether to include style info.
    /// </summary>
    public bool? IncludeStyle { get; init; }

    /// <summary>
    /// The color format to get config with (default: hex).
    /// </summary>
    public ColorFormat? ColorFormat { get; init; }

    /// <summary>
    /// Whether to show accessibility info (default: true).
    /// </summary>
    public bool? ShowAccessibilityInfo { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Highlight">
/// Highlight data for the node.
/// </param>
public sealed record GetHighlightObjectForTestResult(global::System.Text.Json.JsonElement Highlight) : EmptyResult;


internal sealed record GetGridHighlightObjectsForTestCommandParameters(ImmutableArray<DOM.NodeId> NodeIds) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.GetGridHighlightObjectsForTestAsync"/>.
/// </summary>
public sealed record GetGridHighlightObjectsForTestCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Highlights">
/// Grid Highlight data for the node ids provided.
/// </param>
public sealed record GetGridHighlightObjectsForTestResult(global::System.Text.Json.JsonElement Highlights) : EmptyResult;


internal sealed record GetSourceOrderHighlightObjectForTestCommandParameters(DOM.NodeId NodeId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.GetSourceOrderHighlightObjectForTestAsync"/>.
/// </summary>
public sealed record GetSourceOrderHighlightObjectForTestCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Highlight">
/// Source order highlight data for the node id provided.
/// </param>
public sealed record GetSourceOrderHighlightObjectForTestResult(global::System.Text.Json.JsonElement Highlight) : EmptyResult;


internal sealed record HideHighlightCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.HideHighlightAsync"/>.
/// </summary>
public sealed record HideHighlightCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record HideHighlightResult() : EmptyResult;


internal sealed record HighlightFrameCommandParameters(Page.FrameId FrameId, DOM.RGBA? ContentColor, DOM.RGBA? ContentOutlineColor) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.HighlightFrameAsync"/>.
/// </summary>
public sealed record HighlightFrameCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// The content box highlight fill color (default: transparent).
    /// </summary>
    public DOM.RGBA? ContentColor { get; init; }

    /// <summary>
    /// The content box highlight outline color (default: transparent).
    /// </summary>
    public DOM.RGBA? ContentOutlineColor { get; init; }
}

/// <summary>
/// </summary>
public sealed record HighlightFrameResult() : EmptyResult;


internal sealed record HighlightNodeCommandParameters(HighlightConfig HighlightConfig, DOM.NodeId? NodeId, DOM.BackendNodeId? BackendNodeId, Runtime.RemoteObjectId? ObjectId, string? Selector) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.HighlightNodeAsync"/>.
/// </summary>
public sealed record HighlightNodeCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Identifier of the node to highlight.
    /// </summary>
    public DOM.NodeId? NodeId { get; init; }

    /// <summary>
    /// Identifier of the backend node to highlight.
    /// </summary>
    public DOM.BackendNodeId? BackendNodeId { get; init; }

    /// <summary>
    /// JavaScript object id of the node to be highlighted.
    /// </summary>
    public Runtime.RemoteObjectId? ObjectId { get; init; }

    /// <summary>
    /// Selectors to highlight relevant nodes.
    /// </summary>
    public string? Selector { get; init; }
}

/// <summary>
/// </summary>
public sealed record HighlightNodeResult() : EmptyResult;


internal sealed record HighlightQuadCommandParameters(ImmutableArray<double> Quad, DOM.RGBA? Color, DOM.RGBA? OutlineColor) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.HighlightQuadAsync"/>.
/// </summary>
public sealed record HighlightQuadCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// The highlight fill color (default: transparent).
    /// </summary>
    public DOM.RGBA? Color { get; init; }

    /// <summary>
    /// The highlight outline color (default: transparent).
    /// </summary>
    public DOM.RGBA? OutlineColor { get; init; }
}

/// <summary>
/// </summary>
public sealed record HighlightQuadResult() : EmptyResult;


internal sealed record HighlightRectCommandParameters(long X, long Y, long Width, long Height, DOM.RGBA? Color, DOM.RGBA? OutlineColor) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.HighlightRectAsync"/>.
/// </summary>
public sealed record HighlightRectCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// The highlight fill color (default: transparent).
    /// </summary>
    public DOM.RGBA? Color { get; init; }

    /// <summary>
    /// The highlight outline color (default: transparent).
    /// </summary>
    public DOM.RGBA? OutlineColor { get; init; }
}

/// <summary>
/// </summary>
public sealed record HighlightRectResult() : EmptyResult;


internal sealed record HighlightSourceOrderCommandParameters(SourceOrderConfig SourceOrderConfig, DOM.NodeId? NodeId, DOM.BackendNodeId? BackendNodeId, Runtime.RemoteObjectId? ObjectId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.HighlightSourceOrderAsync"/>.
/// </summary>
public sealed record HighlightSourceOrderCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Identifier of the node to highlight.
    /// </summary>
    public DOM.NodeId? NodeId { get; init; }

    /// <summary>
    /// Identifier of the backend node to highlight.
    /// </summary>
    public DOM.BackendNodeId? BackendNodeId { get; init; }

    /// <summary>
    /// JavaScript object id of the node to be highlighted.
    /// </summary>
    public Runtime.RemoteObjectId? ObjectId { get; init; }
}

/// <summary>
/// </summary>
public sealed record HighlightSourceOrderResult() : EmptyResult;


internal sealed record SetInspectModeCommandParameters(InspectMode Mode, HighlightConfig? HighlightConfig) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.SetInspectModeAsync"/>.
/// </summary>
public sealed record SetInspectModeCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// A descriptor for the highlight appearance of hovered-over nodes. May be omitted if `enabled
    /// == false`.
    /// </summary>
    public HighlightConfig? HighlightConfig { get; init; }
}

/// <summary>
/// </summary>
public sealed record SetInspectModeResult() : EmptyResult;


internal sealed record SetShowAdHighlightsCommandParameters(bool Show) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.SetShowAdHighlightsAsync"/>.
/// </summary>
public sealed record SetShowAdHighlightsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetShowAdHighlightsResult() : EmptyResult;


internal sealed record SetPausedInDebuggerMessageCommandParameters(string? Message) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.SetPausedInDebuggerMessageAsync"/>.
/// </summary>
public sealed record SetPausedInDebuggerMessageCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// The message to display, also triggers resume and step over controls.
    /// </summary>
    public string? Message { get; init; }
}

/// <summary>
/// </summary>
public sealed record SetPausedInDebuggerMessageResult() : EmptyResult;


internal sealed record SetShowDebugBordersCommandParameters(bool Show) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.SetShowDebugBordersAsync"/>.
/// </summary>
public sealed record SetShowDebugBordersCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetShowDebugBordersResult() : EmptyResult;


internal sealed record SetShowFPSCounterCommandParameters(bool Show) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.SetShowFPSCounterAsync"/>.
/// </summary>
public sealed record SetShowFPSCounterCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetShowFPSCounterResult() : EmptyResult;


internal sealed record SetShowGridOverlaysCommandParameters(ImmutableArray<GridNodeHighlightConfig> GridNodeHighlightConfigs) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.SetShowGridOverlaysAsync"/>.
/// </summary>
public sealed record SetShowGridOverlaysCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetShowGridOverlaysResult() : EmptyResult;


internal sealed record SetShowFlexOverlaysCommandParameters(ImmutableArray<FlexNodeHighlightConfig> FlexNodeHighlightConfigs) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.SetShowFlexOverlaysAsync"/>.
/// </summary>
public sealed record SetShowFlexOverlaysCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetShowFlexOverlaysResult() : EmptyResult;


internal sealed record SetShowScrollSnapOverlaysCommandParameters(ImmutableArray<ScrollSnapHighlightConfig> ScrollSnapHighlightConfigs) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.SetShowScrollSnapOverlaysAsync"/>.
/// </summary>
public sealed record SetShowScrollSnapOverlaysCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetShowScrollSnapOverlaysResult() : EmptyResult;


internal sealed record SetShowContainerQueryOverlaysCommandParameters(ImmutableArray<ContainerQueryHighlightConfig> ContainerQueryHighlightConfigs) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.SetShowContainerQueryOverlaysAsync"/>.
/// </summary>
public sealed record SetShowContainerQueryOverlaysCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetShowContainerQueryOverlaysResult() : EmptyResult;


internal sealed record SetShowInspectedElementAnchorCommandParameters(InspectedElementAnchorConfig InspectedElementAnchorConfig) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.SetShowInspectedElementAnchorAsync"/>.
/// </summary>
public sealed record SetShowInspectedElementAnchorCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetShowInspectedElementAnchorResult() : EmptyResult;


internal sealed record SetShowPaintRectsCommandParameters(bool Result) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.SetShowPaintRectsAsync"/>.
/// </summary>
public sealed record SetShowPaintRectsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetShowPaintRectsResult() : EmptyResult;


internal sealed record SetShowLayoutShiftRegionsCommandParameters(bool Result) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.SetShowLayoutShiftRegionsAsync"/>.
/// </summary>
public sealed record SetShowLayoutShiftRegionsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetShowLayoutShiftRegionsResult() : EmptyResult;


internal sealed record SetShowScrollBottleneckRectsCommandParameters(bool Show) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.SetShowScrollBottleneckRectsAsync"/>.
/// </summary>
public sealed record SetShowScrollBottleneckRectsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetShowScrollBottleneckRectsResult() : EmptyResult;


internal sealed record SetShowHitTestBordersCommandParameters(bool Show) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.SetShowHitTestBordersAsync"/>.
/// </summary>
public sealed record SetShowHitTestBordersCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetShowHitTestBordersResult() : EmptyResult;


internal sealed record SetShowWebVitalsCommandParameters(bool Show) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.SetShowWebVitalsAsync"/>.
/// </summary>
public sealed record SetShowWebVitalsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetShowWebVitalsResult() : EmptyResult;


internal sealed record SetShowViewportSizeOnResizeCommandParameters(bool Show) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.SetShowViewportSizeOnResizeAsync"/>.
/// </summary>
public sealed record SetShowViewportSizeOnResizeCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetShowViewportSizeOnResizeResult() : EmptyResult;


internal sealed record SetShowHingeCommandParameters(HingeConfig? HingeConfig) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.SetShowHingeAsync"/>.
/// </summary>
public sealed record SetShowHingeCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// hinge data, null means hideHinge
    /// </summary>
    public HingeConfig? HingeConfig { get; init; }
}

/// <summary>
/// </summary>
public sealed record SetShowHingeResult() : EmptyResult;


internal sealed record SetShowDisplayCutoutCommandParameters(DisplayCutoutConfig? DisplayCutoutConfig) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.SetShowDisplayCutoutAsync"/>.
/// </summary>
public sealed record SetShowDisplayCutoutCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// display cutout data, null means hide display cutout
    /// </summary>
    public DisplayCutoutConfig? DisplayCutoutConfig { get; init; }
}

/// <summary>
/// </summary>
public sealed record SetShowDisplayCutoutResult() : EmptyResult;


internal sealed record SetShowIsolatedElementsCommandParameters(ImmutableArray<IsolatedElementHighlightConfig> IsolatedElementHighlightConfigs) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.SetShowIsolatedElementsAsync"/>.
/// </summary>
public sealed record SetShowIsolatedElementsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetShowIsolatedElementsResult() : EmptyResult;


internal sealed record SetShowWindowControlsOverlayCommandParameters(WindowControlsOverlayConfig? WindowControlsOverlayConfig) : Parameters;

/// <summary>
/// Optional parameters for <see cref="OverlayDomain.SetShowWindowControlsOverlayAsync"/>.
/// </summary>
public sealed record SetShowWindowControlsOverlayCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Window Controls Overlay data, null means hide Window Controls Overlay
    /// </summary>
    public WindowControlsOverlayConfig? WindowControlsOverlayConfig { get; init; }
}

/// <summary>
/// </summary>
public sealed record SetShowWindowControlsOverlayResult() : EmptyResult;


/// <summary>
/// Fired when the node should be inspected. This happens after call to <b>setInspectMode</b> or when
/// user manually inspects an element.
/// </summary>
/// <param name="BackendNodeId">
/// Id of the node to inspect.
/// </param>
public sealed record InspectNodeRequestedEventArgs(DOM.BackendNodeId BackendNodeId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when the node should be highlighted. This happens after call to <b>setInspectMode</b>.
/// </summary>
/// <param name="NodeId">
/// </param>
public sealed record NodeHighlightRequestedEventArgs(DOM.NodeId NodeId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when user asks to capture screenshot of some area on the page.
/// </summary>
/// <param name="Viewport">
/// Viewport to capture, in device independent pixels (dip).
/// </param>
public sealed record ScreenshotRequestedEventArgs(Page.Viewport Viewport) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when user asks to show the Inspect panel.
/// </summary>
/// <param name="BackendNodeId">
/// Id of the node to show in the panel.
/// </param>
public sealed record InspectPanelShowRequestedEventArgs(DOM.BackendNodeId BackendNodeId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when user asks to restore the Inspected Element floating window.
/// </summary>
/// <param name="BackendNodeId">
/// Id of the node to restore the floating window for.
/// </param>
public sealed record InspectedElementWindowRestoredEventArgs(DOM.BackendNodeId BackendNodeId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when user cancels the inspect mode.
/// </summary>
public sealed record InspectModeCanceledEventArgs() : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Configuration data for drawing the source order of an elements children.
/// </summary>
/// <param name="ParentOutlineColor">
/// the color to outline the given element in.
/// </param>
/// <param name="ChildOutlineColor">
/// the color to outline the child elements in.
/// </param>
public sealed record SourceOrderConfig(DOM.RGBA ParentOutlineColor, DOM.RGBA ChildOutlineColor)
{
}

/// <summary>
/// Configuration data for the highlighting of Grid elements.
/// </summary>
public sealed record GridHighlightConfig()
{
    /// <summary>
    /// Whether the extension lines from grid cells to the rulers should be shown (default: false).
    /// </summary>
    public bool? ShowGridExtensionLines { get; init; }

    /// <summary>
    /// Show Positive line number labels (default: false).
    /// </summary>
    public bool? ShowPositiveLineNumbers { get; init; }

    /// <summary>
    /// Show Negative line number labels (default: false).
    /// </summary>
    public bool? ShowNegativeLineNumbers { get; init; }

    /// <summary>
    /// Show area name labels (default: false).
    /// </summary>
    public bool? ShowAreaNames { get; init; }

    /// <summary>
    /// Show line name labels (default: false).
    /// </summary>
    public bool? ShowLineNames { get; init; }

    /// <summary>
    /// Show track size labels (default: false).
    /// </summary>
    public bool? ShowTrackSizes { get; init; }

    /// <summary>
    /// The grid container border highlight color (default: transparent).
    /// </summary>
    public DOM.RGBA? GridBorderColor { get; init; }

    /// <summary>
    /// The cell border color (default: transparent). Deprecated, please use rowLineColor and columnLineColor instead.
    /// </summary>
    [global::System.Obsolete]
    public DOM.RGBA? CellBorderColor { get; init; }

    /// <summary>
    /// The row line color (default: transparent).
    /// </summary>
    public DOM.RGBA? RowLineColor { get; init; }

    /// <summary>
    /// The column line color (default: transparent).
    /// </summary>
    public DOM.RGBA? ColumnLineColor { get; init; }

    /// <summary>
    /// Whether the grid border is dashed (default: false).
    /// </summary>
    public bool? GridBorderDash { get; init; }

    /// <summary>
    /// Whether the cell border is dashed (default: false). Deprecated, please us rowLineDash and columnLineDash instead.
    /// </summary>
    [global::System.Obsolete]
    public bool? CellBorderDash { get; init; }

    /// <summary>
    /// Whether row lines are dashed (default: false).
    /// </summary>
    public bool? RowLineDash { get; init; }

    /// <summary>
    /// Whether column lines are dashed (default: false).
    /// </summary>
    public bool? ColumnLineDash { get; init; }

    /// <summary>
    /// The row gap highlight fill color (default: transparent).
    /// </summary>
    public DOM.RGBA? RowGapColor { get; init; }

    /// <summary>
    /// The row gap hatching fill color (default: transparent).
    /// </summary>
    public DOM.RGBA? RowHatchColor { get; init; }

    /// <summary>
    /// The column gap highlight fill color (default: transparent).
    /// </summary>
    public DOM.RGBA? ColumnGapColor { get; init; }

    /// <summary>
    /// The column gap hatching fill color (default: transparent).
    /// </summary>
    public DOM.RGBA? ColumnHatchColor { get; init; }

    /// <summary>
    /// The named grid areas border color (Default: transparent).
    /// </summary>
    public DOM.RGBA? AreaBorderColor { get; init; }

    /// <summary>
    /// The grid container background color (Default: transparent).
    /// </summary>
    public DOM.RGBA? GridBackgroundColor { get; init; }
}

/// <summary>
/// Configuration data for the highlighting of Flex container elements.
/// </summary>
public sealed record FlexContainerHighlightConfig()
{
    /// <summary>
    /// The style of the container border
    /// </summary>
    public LineStyle? ContainerBorder { get; init; }

    /// <summary>
    /// The style of the separator between lines
    /// </summary>
    public LineStyle? LineSeparator { get; init; }

    /// <summary>
    /// The style of the separator between items
    /// </summary>
    public LineStyle? ItemSeparator { get; init; }

    /// <summary>
    /// Style of content-distribution space on the main axis (justify-content).
    /// </summary>
    public BoxStyle? MainDistributedSpace { get; init; }

    /// <summary>
    /// Style of content-distribution space on the cross axis (align-content).
    /// </summary>
    public BoxStyle? CrossDistributedSpace { get; init; }

    /// <summary>
    /// Style of empty space caused by row gaps (gap/row-gap).
    /// </summary>
    public BoxStyle? RowGapSpace { get; init; }

    /// <summary>
    /// Style of empty space caused by columns gaps (gap/column-gap).
    /// </summary>
    public BoxStyle? ColumnGapSpace { get; init; }

    /// <summary>
    /// Style of the self-alignment line (align-items).
    /// </summary>
    public LineStyle? CrossAlignment { get; init; }
}

/// <summary>
/// Configuration data for the highlighting of Flex item elements.
/// </summary>
public sealed record FlexItemHighlightConfig()
{
    /// <summary>
    /// Style of the box representing the item's base size
    /// </summary>
    public BoxStyle? BaseSizeBox { get; init; }

    /// <summary>
    /// Style of the border around the box representing the item's base size
    /// </summary>
    public LineStyle? BaseSizeBorder { get; init; }

    /// <summary>
    /// Style of the arrow representing if the item grew or shrank
    /// </summary>
    public LineStyle? FlexibilityArrow { get; init; }
}

/// <summary>
/// Style information for drawing a line.
/// </summary>
public sealed record LineStyle()
{
    /// <summary>
    /// The color of the line (default: transparent)
    /// </summary>
    public DOM.RGBA? Color { get; init; }

    /// <summary>
    /// The line pattern (default: solid)
    /// </summary>
    public string? Pattern { get; init; }
}

/// <summary>
/// Style information for drawing a box.
/// </summary>
public sealed record BoxStyle()
{
    /// <summary>
    /// The background color for the box (default: transparent)
    /// </summary>
    public DOM.RGBA? FillColor { get; init; }

    /// <summary>
    /// The hatching color for the box (default: transparent)
    /// </summary>
    public DOM.RGBA? HatchColor { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ContrastAlgorithm>))]
public enum ContrastAlgorithm
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("aa")]
    Aa,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("aaa")]
    Aaa,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("apca")]
    Apca,
}

/// <summary>
/// Configuration data for the highlighting of page elements.
/// </summary>
public sealed record HighlightConfig()
{
    /// <summary>
    /// Whether the node info tooltip should be shown (default: false).
    /// </summary>
    public bool? ShowInfo { get; init; }

    /// <summary>
    /// Whether the node styles in the tooltip (default: false).
    /// </summary>
    public bool? ShowStyles { get; init; }

    /// <summary>
    /// Whether the rulers should be shown (default: false).
    /// </summary>
    public bool? ShowRulers { get; init; }

    /// <summary>
    /// Whether the a11y info should be shown (default: true).
    /// </summary>
    public bool? ShowAccessibilityInfo { get; init; }

    /// <summary>
    /// Whether the extension lines from node to the rulers should be shown (default: false).
    /// </summary>
    public bool? ShowExtensionLines { get; init; }

    /// <summary>
    /// The content box highlight fill color (default: transparent).
    /// </summary>
    public DOM.RGBA? ContentColor { get; init; }

    /// <summary>
    /// The padding highlight fill color (default: transparent).
    /// </summary>
    public DOM.RGBA? PaddingColor { get; init; }

    /// <summary>
    /// The border highlight fill color (default: transparent).
    /// </summary>
    public DOM.RGBA? BorderColor { get; init; }

    /// <summary>
    /// The margin highlight fill color (default: transparent).
    /// </summary>
    public DOM.RGBA? MarginColor { get; init; }

    /// <summary>
    /// The event target element highlight fill color (default: transparent).
    /// </summary>
    public DOM.RGBA? EventTargetColor { get; init; }

    /// <summary>
    /// The shape outside fill color (default: transparent).
    /// </summary>
    public DOM.RGBA? ShapeColor { get; init; }

    /// <summary>
    /// The shape margin fill color (default: transparent).
    /// </summary>
    public DOM.RGBA? ShapeMarginColor { get; init; }

    /// <summary>
    /// The grid layout color (default: transparent).
    /// </summary>
    public DOM.RGBA? CssGridColor { get; init; }

    /// <summary>
    /// The color format used to format color styles (default: hex).
    /// </summary>
    public ColorFormat? ColorFormat { get; init; }

    /// <summary>
    /// The grid layout highlight configuration (default: all transparent).
    /// </summary>
    public GridHighlightConfig? GridHighlightConfig { get; init; }

    /// <summary>
    /// The flex container highlight configuration (default: all transparent).
    /// </summary>
    public FlexContainerHighlightConfig? FlexContainerHighlightConfig { get; init; }

    /// <summary>
    /// The flex item highlight configuration (default: all transparent).
    /// </summary>
    public FlexItemHighlightConfig? FlexItemHighlightConfig { get; init; }

    /// <summary>
    /// The contrast algorithm to use for the contrast ratio (default: aa).
    /// </summary>
    public ContrastAlgorithm? ContrastAlgorithm { get; init; }

    /// <summary>
    /// The container query container highlight configuration (default: all transparent).
    /// </summary>
    public ContainerQueryContainerHighlightConfig? ContainerQueryContainerHighlightConfig { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ColorFormat>))]
public enum ColorFormat
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("rgb")]
    Rgb,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("hsl")]
    Hsl,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("hwb")]
    Hwb,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("hex")]
    Hex,
}

/// <summary>
/// Configurations for Persistent Grid Highlight
/// </summary>
/// <param name="GridHighlightConfig">
/// A descriptor for the highlight appearance.
/// </param>
/// <param name="NodeId">
/// Identifier of the node to highlight.
/// </param>
public sealed record GridNodeHighlightConfig(GridHighlightConfig GridHighlightConfig, DOM.NodeId NodeId)
{
}

/// <summary>
/// </summary>
/// <param name="FlexContainerHighlightConfig">
/// A descriptor for the highlight appearance of flex containers.
/// </param>
/// <param name="NodeId">
/// Identifier of the node to highlight.
/// </param>
public sealed record FlexNodeHighlightConfig(FlexContainerHighlightConfig FlexContainerHighlightConfig, DOM.NodeId NodeId)
{
}

/// <summary>
/// </summary>
public sealed record ScrollSnapContainerHighlightConfig()
{
    /// <summary>
    /// The style of the snapport border (default: transparent)
    /// </summary>
    public LineStyle? SnapportBorder { get; init; }

    /// <summary>
    /// The style of the snap area border (default: transparent)
    /// </summary>
    public LineStyle? SnapAreaBorder { get; init; }

    /// <summary>
    /// The margin highlight fill color (default: transparent).
    /// </summary>
    public DOM.RGBA? ScrollMarginColor { get; init; }

    /// <summary>
    /// The padding highlight fill color (default: transparent).
    /// </summary>
    public DOM.RGBA? ScrollPaddingColor { get; init; }
}

/// <summary>
/// </summary>
/// <param name="ScrollSnapContainerHighlightConfig">
/// A descriptor for the highlight appearance of scroll snap containers.
/// </param>
/// <param name="NodeId">
/// Identifier of the node to highlight.
/// </param>
public sealed record ScrollSnapHighlightConfig(ScrollSnapContainerHighlightConfig ScrollSnapContainerHighlightConfig, DOM.NodeId NodeId)
{
}

/// <summary>
/// Configuration for dual screen hinge
/// </summary>
/// <param name="Rect">
/// A rectangle represent hinge
/// </param>
public sealed record HingeConfig(DOM.Rect Rect)
{
    /// <summary>
    /// The content box highlight fill color (default: a dark color).
    /// </summary>
    public DOM.RGBA? ContentColor { get; init; }

    /// <summary>
    /// The content box highlight outline color (default: transparent).
    /// </summary>
    public DOM.RGBA? OutlineColor { get; init; }
}

/// <summary>
/// Supported display cutout shapes.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<DisplayCutoutShape>))]
public enum DisplayCutoutShape
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("pill")]
    Pill,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("notch")]
    Notch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("circle")]
    Circle,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("rectangle")]
    Rectangle,
}

/// <summary>
/// Configuration for a display cutout.
/// </summary>
/// <param name="Rect">
/// A rectangle representing the cutout bounds.
/// </param>
/// <param name="Shape">
/// Shape used to draw the cutout.
/// </param>
public sealed record DisplayCutoutConfig(DOM.Rect Rect, DisplayCutoutShape Shape)
{
    /// <summary>
    /// Border radius for rounded cutout shapes.
    /// </summary>
    public long? BorderRadius { get; init; }

    /// <summary>
    /// Upper shoulder radius for notch cutout shapes.
    /// </summary>
    public long? UpperRadius { get; init; }

    /// <summary>
    /// Lower transition radius for notch cutout shapes.
    /// </summary>
    public long? LowerRadius { get; init; }

    /// <summary>
    /// Center x coordinate for circle cutout shapes.
    /// </summary>
    public long? Cx { get; init; }

    /// <summary>
    /// Center y coordinate for circle cutout shapes.
    /// </summary>
    public long? Cy { get; init; }

    /// <summary>
    /// Radius for circle cutout shapes.
    /// </summary>
    public long? Radius { get; init; }

    /// <summary>
    /// The cutout fill color (default: black).
    /// </summary>
    public DOM.RGBA? ContentColor { get; init; }
}

/// <summary>
/// Configuration for Window Controls Overlay
/// </summary>
/// <param name="ShowCSS">
/// Whether the title bar CSS should be shown when emulating the Window Controls Overlay.
/// </param>
/// <param name="SelectedPlatform">
/// Selected platforms to show the overlay.
/// </param>
/// <param name="ThemeColor">
/// The theme color defined in app manifest.
/// </param>
public sealed record WindowControlsOverlayConfig(bool ShowCSS, string SelectedPlatform, string ThemeColor)
{
}

/// <summary>
/// </summary>
/// <param name="ContainerQueryContainerHighlightConfig">
/// A descriptor for the highlight appearance of container query containers.
/// </param>
/// <param name="NodeId">
/// Identifier of the container node to highlight.
/// </param>
public sealed record ContainerQueryHighlightConfig(ContainerQueryContainerHighlightConfig ContainerQueryContainerHighlightConfig, DOM.NodeId NodeId)
{
}

/// <summary>
/// </summary>
public sealed record ContainerQueryContainerHighlightConfig()
{
    /// <summary>
    /// The style of the container border.
    /// </summary>
    public LineStyle? ContainerBorder { get; init; }

    /// <summary>
    /// The style of the descendants' borders.
    /// </summary>
    public LineStyle? DescendantBorder { get; init; }
}

/// <summary>
/// </summary>
/// <param name="IsolationModeHighlightConfig">
/// A descriptor for the highlight appearance of an element in isolation mode.
/// </param>
/// <param name="NodeId">
/// Identifier of the isolated element to highlight.
/// </param>
public sealed record IsolatedElementHighlightConfig(IsolationModeHighlightConfig IsolationModeHighlightConfig, DOM.NodeId NodeId)
{
}

/// <summary>
/// </summary>
public sealed record IsolationModeHighlightConfig()
{
    /// <summary>
    /// The fill color of the resizers (default: transparent).
    /// </summary>
    public DOM.RGBA? ResizerColor { get; init; }

    /// <summary>
    /// The fill color for resizer handles (default: transparent).
    /// </summary>
    public DOM.RGBA? ResizerHandleColor { get; init; }

    /// <summary>
    /// The fill color for the mask covering non-isolated elements (default: transparent).
    /// </summary>
    public DOM.RGBA? MaskColor { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<InspectMode>))]
public enum InspectMode
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("searchForNode")]
    SearchForNode,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("searchForUAShadowDOM")]
    SearchForUAShadowDOM,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("captureAreaScreenshot")]
    CaptureAreaScreenshot,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("none")]
    None,
}

/// <summary>
/// </summary>
public sealed record InspectedElementAnchorConfig()
{
    /// <summary>
    /// Identifier of the node to highlight.
    /// </summary>
    public DOM.NodeId? NodeId { get; init; }

    /// <summary>
    /// Identifier of the backend node to highlight.
    /// </summary>
    public DOM.BackendNodeId? BackendNodeId { get; init; }
}

[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(GetHighlightObjectForTestCommandParameters), TypeInfoPropertyName = "GetHighlightObjectForTestCommandParameters")]
[JsonSerializable(typeof(GetHighlightObjectForTestResult), TypeInfoPropertyName = "GetHighlightObjectForTestResult")]
[JsonSerializable(typeof(GetGridHighlightObjectsForTestCommandParameters), TypeInfoPropertyName = "GetGridHighlightObjectsForTestCommandParameters")]
[JsonSerializable(typeof(GetGridHighlightObjectsForTestResult), TypeInfoPropertyName = "GetGridHighlightObjectsForTestResult")]
[JsonSerializable(typeof(GetSourceOrderHighlightObjectForTestCommandParameters), TypeInfoPropertyName = "GetSourceOrderHighlightObjectForTestCommandParameters")]
[JsonSerializable(typeof(GetSourceOrderHighlightObjectForTestResult), TypeInfoPropertyName = "GetSourceOrderHighlightObjectForTestResult")]
[JsonSerializable(typeof(HideHighlightCommandParameters), TypeInfoPropertyName = "HideHighlightCommandParameters")]
[JsonSerializable(typeof(HideHighlightResult), TypeInfoPropertyName = "HideHighlightResult")]
[JsonSerializable(typeof(HighlightFrameCommandParameters), TypeInfoPropertyName = "HighlightFrameCommandParameters")]
[JsonSerializable(typeof(HighlightFrameResult), TypeInfoPropertyName = "HighlightFrameResult")]
[JsonSerializable(typeof(HighlightNodeCommandParameters), TypeInfoPropertyName = "HighlightNodeCommandParameters")]
[JsonSerializable(typeof(HighlightNodeResult), TypeInfoPropertyName = "HighlightNodeResult")]
[JsonSerializable(typeof(HighlightQuadCommandParameters), TypeInfoPropertyName = "HighlightQuadCommandParameters")]
[JsonSerializable(typeof(HighlightQuadResult), TypeInfoPropertyName = "HighlightQuadResult")]
[JsonSerializable(typeof(HighlightRectCommandParameters), TypeInfoPropertyName = "HighlightRectCommandParameters")]
[JsonSerializable(typeof(HighlightRectResult), TypeInfoPropertyName = "HighlightRectResult")]
[JsonSerializable(typeof(HighlightSourceOrderCommandParameters), TypeInfoPropertyName = "HighlightSourceOrderCommandParameters")]
[JsonSerializable(typeof(HighlightSourceOrderResult), TypeInfoPropertyName = "HighlightSourceOrderResult")]
[JsonSerializable(typeof(SetInspectModeCommandParameters), TypeInfoPropertyName = "SetInspectModeCommandParameters")]
[JsonSerializable(typeof(SetInspectModeResult), TypeInfoPropertyName = "SetInspectModeResult")]
[JsonSerializable(typeof(SetShowAdHighlightsCommandParameters), TypeInfoPropertyName = "SetShowAdHighlightsCommandParameters")]
[JsonSerializable(typeof(SetShowAdHighlightsResult), TypeInfoPropertyName = "SetShowAdHighlightsResult")]
[JsonSerializable(typeof(SetPausedInDebuggerMessageCommandParameters), TypeInfoPropertyName = "SetPausedInDebuggerMessageCommandParameters")]
[JsonSerializable(typeof(SetPausedInDebuggerMessageResult), TypeInfoPropertyName = "SetPausedInDebuggerMessageResult")]
[JsonSerializable(typeof(SetShowDebugBordersCommandParameters), TypeInfoPropertyName = "SetShowDebugBordersCommandParameters")]
[JsonSerializable(typeof(SetShowDebugBordersResult), TypeInfoPropertyName = "SetShowDebugBordersResult")]
[JsonSerializable(typeof(SetShowFPSCounterCommandParameters), TypeInfoPropertyName = "SetShowFPSCounterCommandParameters")]
[JsonSerializable(typeof(SetShowFPSCounterResult), TypeInfoPropertyName = "SetShowFPSCounterResult")]
[JsonSerializable(typeof(SetShowGridOverlaysCommandParameters), TypeInfoPropertyName = "SetShowGridOverlaysCommandParameters")]
[JsonSerializable(typeof(SetShowGridOverlaysResult), TypeInfoPropertyName = "SetShowGridOverlaysResult")]
[JsonSerializable(typeof(SetShowFlexOverlaysCommandParameters), TypeInfoPropertyName = "SetShowFlexOverlaysCommandParameters")]
[JsonSerializable(typeof(SetShowFlexOverlaysResult), TypeInfoPropertyName = "SetShowFlexOverlaysResult")]
[JsonSerializable(typeof(SetShowScrollSnapOverlaysCommandParameters), TypeInfoPropertyName = "SetShowScrollSnapOverlaysCommandParameters")]
[JsonSerializable(typeof(SetShowScrollSnapOverlaysResult), TypeInfoPropertyName = "SetShowScrollSnapOverlaysResult")]
[JsonSerializable(typeof(SetShowContainerQueryOverlaysCommandParameters), TypeInfoPropertyName = "SetShowContainerQueryOverlaysCommandParameters")]
[JsonSerializable(typeof(SetShowContainerQueryOverlaysResult), TypeInfoPropertyName = "SetShowContainerQueryOverlaysResult")]
[JsonSerializable(typeof(SetShowInspectedElementAnchorCommandParameters), TypeInfoPropertyName = "SetShowInspectedElementAnchorCommandParameters")]
[JsonSerializable(typeof(SetShowInspectedElementAnchorResult), TypeInfoPropertyName = "SetShowInspectedElementAnchorResult")]
[JsonSerializable(typeof(SetShowPaintRectsCommandParameters), TypeInfoPropertyName = "SetShowPaintRectsCommandParameters")]
[JsonSerializable(typeof(SetShowPaintRectsResult), TypeInfoPropertyName = "SetShowPaintRectsResult")]
[JsonSerializable(typeof(SetShowLayoutShiftRegionsCommandParameters), TypeInfoPropertyName = "SetShowLayoutShiftRegionsCommandParameters")]
[JsonSerializable(typeof(SetShowLayoutShiftRegionsResult), TypeInfoPropertyName = "SetShowLayoutShiftRegionsResult")]
[JsonSerializable(typeof(SetShowScrollBottleneckRectsCommandParameters), TypeInfoPropertyName = "SetShowScrollBottleneckRectsCommandParameters")]
[JsonSerializable(typeof(SetShowScrollBottleneckRectsResult), TypeInfoPropertyName = "SetShowScrollBottleneckRectsResult")]
[JsonSerializable(typeof(SetShowHitTestBordersCommandParameters), TypeInfoPropertyName = "SetShowHitTestBordersCommandParameters")]
[JsonSerializable(typeof(SetShowHitTestBordersResult), TypeInfoPropertyName = "SetShowHitTestBordersResult")]
[JsonSerializable(typeof(SetShowWebVitalsCommandParameters), TypeInfoPropertyName = "SetShowWebVitalsCommandParameters")]
[JsonSerializable(typeof(SetShowWebVitalsResult), TypeInfoPropertyName = "SetShowWebVitalsResult")]
[JsonSerializable(typeof(SetShowViewportSizeOnResizeCommandParameters), TypeInfoPropertyName = "SetShowViewportSizeOnResizeCommandParameters")]
[JsonSerializable(typeof(SetShowViewportSizeOnResizeResult), TypeInfoPropertyName = "SetShowViewportSizeOnResizeResult")]
[JsonSerializable(typeof(SetShowHingeCommandParameters), TypeInfoPropertyName = "SetShowHingeCommandParameters")]
[JsonSerializable(typeof(SetShowHingeResult), TypeInfoPropertyName = "SetShowHingeResult")]
[JsonSerializable(typeof(SetShowDisplayCutoutCommandParameters), TypeInfoPropertyName = "SetShowDisplayCutoutCommandParameters")]
[JsonSerializable(typeof(SetShowDisplayCutoutResult), TypeInfoPropertyName = "SetShowDisplayCutoutResult")]
[JsonSerializable(typeof(SetShowIsolatedElementsCommandParameters), TypeInfoPropertyName = "SetShowIsolatedElementsCommandParameters")]
[JsonSerializable(typeof(SetShowIsolatedElementsResult), TypeInfoPropertyName = "SetShowIsolatedElementsResult")]
[JsonSerializable(typeof(SetShowWindowControlsOverlayCommandParameters), TypeInfoPropertyName = "SetShowWindowControlsOverlayCommandParameters")]
[JsonSerializable(typeof(SetShowWindowControlsOverlayResult), TypeInfoPropertyName = "SetShowWindowControlsOverlayResult")]
[JsonSerializable(typeof(CdpEventArgs<InspectNodeRequestedEventArgs>), TypeInfoPropertyName = "InspectNodeRequestedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<NodeHighlightRequestedEventArgs>), TypeInfoPropertyName = "NodeHighlightRequestedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ScreenshotRequestedEventArgs>), TypeInfoPropertyName = "ScreenshotRequestedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<InspectPanelShowRequestedEventArgs>), TypeInfoPropertyName = "InspectPanelShowRequestedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<InspectedElementWindowRestoredEventArgs>), TypeInfoPropertyName = "InspectedElementWindowRestoredCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<InspectModeCanceledEventArgs>), TypeInfoPropertyName = "InspectModeCanceledCdpEventArgs")]
[JsonSerializable(typeof(SourceOrderConfig), TypeInfoPropertyName = "OverlaySourceOrderConfig")]
[JsonSerializable(typeof(GridHighlightConfig), TypeInfoPropertyName = "OverlayGridHighlightConfig")]
[JsonSerializable(typeof(FlexContainerHighlightConfig), TypeInfoPropertyName = "OverlayFlexContainerHighlightConfig")]
[JsonSerializable(typeof(FlexItemHighlightConfig), TypeInfoPropertyName = "OverlayFlexItemHighlightConfig")]
[JsonSerializable(typeof(LineStyle), TypeInfoPropertyName = "OverlayLineStyle")]
[JsonSerializable(typeof(BoxStyle), TypeInfoPropertyName = "OverlayBoxStyle")]
[JsonSerializable(typeof(ContrastAlgorithm), TypeInfoPropertyName = "OverlayContrastAlgorithm")]
[JsonSerializable(typeof(HighlightConfig), TypeInfoPropertyName = "OverlayHighlightConfig")]
[JsonSerializable(typeof(ColorFormat), TypeInfoPropertyName = "OverlayColorFormat")]
[JsonSerializable(typeof(GridNodeHighlightConfig), TypeInfoPropertyName = "OverlayGridNodeHighlightConfig")]
[JsonSerializable(typeof(FlexNodeHighlightConfig), TypeInfoPropertyName = "OverlayFlexNodeHighlightConfig")]
[JsonSerializable(typeof(ScrollSnapContainerHighlightConfig), TypeInfoPropertyName = "OverlayScrollSnapContainerHighlightConfig")]
[JsonSerializable(typeof(ScrollSnapHighlightConfig), TypeInfoPropertyName = "OverlayScrollSnapHighlightConfig")]
[JsonSerializable(typeof(HingeConfig), TypeInfoPropertyName = "OverlayHingeConfig")]
[JsonSerializable(typeof(DisplayCutoutShape), TypeInfoPropertyName = "OverlayDisplayCutoutShape")]
[JsonSerializable(typeof(DisplayCutoutConfig), TypeInfoPropertyName = "OverlayDisplayCutoutConfig")]
[JsonSerializable(typeof(WindowControlsOverlayConfig), TypeInfoPropertyName = "OverlayWindowControlsOverlayConfig")]
[JsonSerializable(typeof(ContainerQueryHighlightConfig), TypeInfoPropertyName = "OverlayContainerQueryHighlightConfig")]
[JsonSerializable(typeof(ContainerQueryContainerHighlightConfig), TypeInfoPropertyName = "OverlayContainerQueryContainerHighlightConfig")]
[JsonSerializable(typeof(IsolatedElementHighlightConfig), TypeInfoPropertyName = "OverlayIsolatedElementHighlightConfig")]
[JsonSerializable(typeof(IsolationModeHighlightConfig), TypeInfoPropertyName = "OverlayIsolationModeHighlightConfig")]
[JsonSerializable(typeof(InspectMode), TypeInfoPropertyName = "OverlayInspectMode")]
[JsonSerializable(typeof(InspectedElementAnchorConfig), TypeInfoPropertyName = "OverlayInspectedElementAnchorConfig")]
[JsonSerializable(typeof(ImmutableArray<DOM.NodeId>), TypeInfoPropertyName = "ImmutableArrayDOMNodeId")]
[JsonSerializable(typeof(ImmutableArray<GridNodeHighlightConfig>), TypeInfoPropertyName = "ImmutableArrayOverlayGridNodeHighlightConfig")]
[JsonSerializable(typeof(ImmutableArray<FlexNodeHighlightConfig>), TypeInfoPropertyName = "ImmutableArrayOverlayFlexNodeHighlightConfig")]
[JsonSerializable(typeof(ImmutableArray<ScrollSnapHighlightConfig>), TypeInfoPropertyName = "ImmutableArrayOverlayScrollSnapHighlightConfig")]
[JsonSerializable(typeof(ImmutableArray<ContainerQueryHighlightConfig>), TypeInfoPropertyName = "ImmutableArrayOverlayContainerQueryHighlightConfig")]
[JsonSerializable(typeof(ImmutableArray<IsolatedElementHighlightConfig>), TypeInfoPropertyName = "ImmutableArrayOverlayIsolatedElementHighlightConfig")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class OverlayJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="OverlayDomain"/>.
/// </summary>
public static class OverlayDomainEvent
{
    /// <summary>
    /// Fired when the node should be inspected. This happens after call to <b>setInspectMode</b> or when
    /// user manually inspects an element.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<InspectNodeRequestedEventArgs>> InspectNodeRequested { get; } =
        EventDescriptor<CdpEventArgs<InspectNodeRequestedEventArgs>>.Create(
            "goog:cdp.Overlay.inspectNodeRequested",
            OverlayJsonSerializerContext.Default.InspectNodeRequestedCdpEventArgs);

    /// <summary>
    /// Fired when the node should be highlighted. This happens after call to <b>setInspectMode</b>.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<NodeHighlightRequestedEventArgs>> NodeHighlightRequested { get; } =
        EventDescriptor<CdpEventArgs<NodeHighlightRequestedEventArgs>>.Create(
            "goog:cdp.Overlay.nodeHighlightRequested",
            OverlayJsonSerializerContext.Default.NodeHighlightRequestedCdpEventArgs);

    /// <summary>
    /// Fired when user asks to capture screenshot of some area on the page.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ScreenshotRequestedEventArgs>> ScreenshotRequested { get; } =
        EventDescriptor<CdpEventArgs<ScreenshotRequestedEventArgs>>.Create(
            "goog:cdp.Overlay.screenshotRequested",
            OverlayJsonSerializerContext.Default.ScreenshotRequestedCdpEventArgs);

    /// <summary>
    /// Fired when user asks to show the Inspect panel.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<InspectPanelShowRequestedEventArgs>> InspectPanelShowRequested { get; } =
        EventDescriptor<CdpEventArgs<InspectPanelShowRequestedEventArgs>>.Create(
            "goog:cdp.Overlay.inspectPanelShowRequested",
            OverlayJsonSerializerContext.Default.InspectPanelShowRequestedCdpEventArgs);

    /// <summary>
    /// Fired when user asks to restore the Inspected Element floating window.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<InspectedElementWindowRestoredEventArgs>> InspectedElementWindowRestored { get; } =
        EventDescriptor<CdpEventArgs<InspectedElementWindowRestoredEventArgs>>.Create(
            "goog:cdp.Overlay.inspectedElementWindowRestored",
            OverlayJsonSerializerContext.Default.InspectedElementWindowRestoredCdpEventArgs);

    /// <summary>
    /// Fired when user cancels the inspect mode.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<InspectModeCanceledEventArgs>> InspectModeCanceled { get; } =
        EventDescriptor<CdpEventArgs<InspectModeCanceledEventArgs>>.Create(
            "goog:cdp.Overlay.inspectModeCanceled",
            OverlayJsonSerializerContext.Default.InspectModeCanceledCdpEventArgs);

}
