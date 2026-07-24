#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.CSS;

/// <summary>
/// This domain exposes CSS read/write operations. All CSS objects (stylesheets, rules, and styles)
/// have an associated <b>id</b> used in subsequent operations on the related object. Each object type has
/// a specific <b>id</b> structure, and those are not interchangeable between objects of different kinds.
/// CSS objects can be loaded using the <b>get*ForNode()</b> calls (which accept a DOM node id). A client
/// can also keep track of stylesheets via the <b>styleSheetAdded</b>/<b>styleSheetRemoved</b> events and
/// subsequently load the required stylesheet contents using the <b>getStyleSheet[Text]()</b> methods.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class CSSDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static CSSJsonSerializerContext JsonContext = CSSJsonSerializerContext.Default;

    /// <summary>
    /// Inserts a new rule with the given <b>ruleText</b> in a stylesheet with given <b>styleSheetId</b>, at the
    /// position specified by <b>location</b>.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>NodeForPropertySyntaxValidation</b> - NodeId for the DOM node in whose context custom property declarations for registered properties should be validated. If omitted, declarations in the new rule text can only be validated statically, which may produce incorrect results if the declaration contains a var() for example.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="styleSheetId">
    /// The css style sheet identifier where a new rule should be inserted.
    /// </param>
    /// <param name="ruleText">
    /// The text of a new rule.
    /// </param>
    /// <param name="location">
    /// Text position of a new rule in the target style sheet.
    /// </param>
    /// <param name="nodeForPropertySyntaxValidation">
    /// NodeId for the DOM node in whose context custom property declarations for registered properties should be
    /// validated. If omitted, declarations in the new rule text can only be validated statically, which may produce
    /// incorrect results if the declaration contains a var() for example.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AddRuleResult"/>.
    /// </returns>
    public async Task<AddRuleResult> AddRuleAsync(DOM.StyleSheetId styleSheetId, string ruleText, SourceRange location, DOM.NodeId? nodeForPropertySyntaxValidation = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new AddRuleCommandParameters(StyleSheetId: styleSheetId, RuleText: ruleText, Location: location, NodeForPropertySyntaxValidation: nodeForPropertySyntaxValidation);
        return await ExecuteCommandAsync(AddRuleCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AddRuleCommandParameters, AddRuleResult> AddRuleCommand = new("CSS.addRule", JsonContext.AddRuleCommandParameters, JsonContext.AddRuleResult);

    /// <summary>
    /// Returns all class names from specified stylesheet.
    /// </summary>
    /// <param name="styleSheetId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CollectClassNamesResult"/>.
    /// </returns>
    public async Task<CollectClassNamesResult> CollectClassNamesAsync(DOM.StyleSheetId styleSheetId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CollectClassNamesCommandParameters(StyleSheetId: styleSheetId);
        return await ExecuteCommandAsync(CollectClassNamesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CollectClassNamesCommandParameters, CollectClassNamesResult> CollectClassNamesCommand = new("CSS.collectClassNames", JsonContext.CollectClassNamesCommandParameters, JsonContext.CollectClassNamesResult);

    /// <summary>
    /// Creates a new special "via-inspector" stylesheet in the frame with given <b>frameId</b>.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>Force</b> - If true, creates a new stylesheet for every call. If false, returns a stylesheet previously created by a call with force=false for the frame's document if it exists or creates a new stylesheet (default: false).</description></item>
    /// </list>
    /// </remarks>
    /// <param name="frameId">
    /// Identifier of the frame where "via-inspector" stylesheet should be created.
    /// </param>
    /// <param name="force">
    /// If true, creates a new stylesheet for every call. If false,
    /// returns a stylesheet previously created by a call with force=false
    /// for the frame's document if it exists or creates a new stylesheet
    /// (default: false).
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CreateStyleSheetResult"/>.
    /// </returns>
    public async Task<CreateStyleSheetResult> CreateStyleSheetAsync(Page.FrameId frameId, bool? force = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CreateStyleSheetCommandParameters(FrameId: frameId, Force: force);
        return await ExecuteCommandAsync(CreateStyleSheetCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CreateStyleSheetCommandParameters, CreateStyleSheetResult> CreateStyleSheetCommand = new("CSS.createStyleSheet", JsonContext.CreateStyleSheetCommandParameters, JsonContext.CreateStyleSheetResult);

    /// <summary>
    /// Disables the CSS agent for the given page.
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
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("CSS.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Enables the CSS agent for the given page. Clients should not assume that the CSS agent has been
    /// enabled until the result of this command is received.
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
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("CSS.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Ensures that the given node will have specified pseudo-classes whenever its style is computed by
    /// the browser.
    /// </summary>
    /// <param name="nodeId">
    /// The element id for which to force the pseudo state.
    /// </param>
    /// <param name="forcedPseudoClasses">
    /// Element pseudo classes to force when computing the element's style.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ForcePseudoStateResult"/>.
    /// </returns>
    public async Task<ForcePseudoStateResult> ForcePseudoStateAsync(DOM.NodeId nodeId, ImmutableArray<string> forcedPseudoClasses, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ForcePseudoStateCommandParameters(NodeId: nodeId, ForcedPseudoClasses: forcedPseudoClasses);
        return await ExecuteCommandAsync(ForcePseudoStateCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ForcePseudoStateCommandParameters, ForcePseudoStateResult> ForcePseudoStateCommand = new("CSS.forcePseudoState", JsonContext.ForcePseudoStateCommandParameters, JsonContext.ForcePseudoStateResult);

    /// <summary>
    /// Ensures that the given node is in its starting-style state.
    /// </summary>
    /// <param name="nodeId">
    /// The element id for which to force the starting-style state.
    /// </param>
    /// <param name="forced">
    /// Boolean indicating if this is on or off.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ForceStartingStyleResult"/>.
    /// </returns>
    public async Task<ForceStartingStyleResult> ForceStartingStyleAsync(DOM.NodeId nodeId, bool forced, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ForceStartingStyleCommandParameters(NodeId: nodeId, Forced: forced);
        return await ExecuteCommandAsync(ForceStartingStyleCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ForceStartingStyleCommandParameters, ForceStartingStyleResult> ForceStartingStyleCommand = new("CSS.forceStartingStyle", JsonContext.ForceStartingStyleCommandParameters, JsonContext.ForceStartingStyleResult);

    /// <summary>
    /// </summary>
    /// <param name="nodeId">
    /// Id of the node to get background colors for.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetBackgroundColorsResult"/>.
    /// </returns>
    public async Task<GetBackgroundColorsResult> GetBackgroundColorsAsync(DOM.NodeId nodeId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetBackgroundColorsCommandParameters(NodeId: nodeId);
        return await ExecuteCommandAsync(GetBackgroundColorsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetBackgroundColorsCommandParameters, GetBackgroundColorsResult> GetBackgroundColorsCommand = new("CSS.getBackgroundColors", JsonContext.GetBackgroundColorsCommandParameters, JsonContext.GetBackgroundColorsResult);

    /// <summary>
    /// Returns the computed style for a DOM node identified by <b>nodeId</b>.
    /// </summary>
    /// <param name="nodeId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetComputedStyleForNodeResult"/>.
    /// </returns>
    public async Task<GetComputedStyleForNodeResult> GetComputedStyleForNodeAsync(DOM.NodeId nodeId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetComputedStyleForNodeCommandParameters(NodeId: nodeId);
        return await ExecuteCommandAsync(GetComputedStyleForNodeCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetComputedStyleForNodeCommandParameters, GetComputedStyleForNodeResult> GetComputedStyleForNodeCommand = new("CSS.getComputedStyleForNode", JsonContext.GetComputedStyleForNodeCommandParameters, JsonContext.GetComputedStyleForNodeResult);

    /// <summary>
    /// Resolve the specified values in the context of the provided element.
    /// For example, a value of '1em' is evaluated according to the computed
    /// 'font-size' of the element and a value 'calc(1px + 2px)' will be
    /// resolved to '3px'.
    /// If the <b>propertyName</b> was specified the <b>values</b> are resolved as if
    /// they were property's declaration. If a value cannot be parsed according
    /// to the provided property syntax, the value is parsed using combined
    /// syntax as if null <b>propertyName</b> was provided. If the value cannot be
    /// resolved even then, return the provided value without any changes.
    /// Note: this function currently does not resolve CSS random() function,
    /// it returns unmodified random() function parts.`
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>PropertyName</b> - Only longhands and custom property names are accepted.</description></item>
    /// <item><description><b>PseudoType</b> - Pseudo element type, only works for pseudo elements that generate elements in the tree, such as ::before and ::after.</description></item>
    /// <item><description><b>PseudoIdentifier</b> - Pseudo element custom ident.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="values">
    /// Cascade-dependent keywords (revert/revert-layer) do not work.
    /// </param>
    /// <param name="nodeId">
    /// Id of the node in whose context the expression is evaluated
    /// </param>
    /// <param name="propertyName">
    /// Only longhands and custom property names are accepted.
    /// </param>
    /// <param name="pseudoType">
    /// Pseudo element type, only works for pseudo elements that generate
    /// elements in the tree, such as ::before and ::after.
    /// </param>
    /// <param name="pseudoIdentifier">
    /// Pseudo element custom ident.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ResolveValuesResult"/>.
    /// </returns>
    public async Task<ResolveValuesResult> ResolveValuesAsync(ImmutableArray<string> values, DOM.NodeId nodeId, string? propertyName = default, DOM.PseudoType? pseudoType = default, string? pseudoIdentifier = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ResolveValuesCommandParameters(Values: values, NodeId: nodeId, PropertyName: propertyName, PseudoType: pseudoType, PseudoIdentifier: pseudoIdentifier);
        return await ExecuteCommandAsync(ResolveValuesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ResolveValuesCommandParameters, ResolveValuesResult> ResolveValuesCommand = new("CSS.resolveValues", JsonContext.ResolveValuesCommandParameters, JsonContext.ResolveValuesResult);

    /// <summary>
    /// </summary>
    /// <param name="shorthandName">
    /// </param>
    /// <param name="value">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetLonghandPropertiesResult"/>.
    /// </returns>
    public async Task<GetLonghandPropertiesResult> GetLonghandPropertiesAsync(string shorthandName, string value, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetLonghandPropertiesCommandParameters(ShorthandName: shorthandName, Value: value);
        return await ExecuteCommandAsync(GetLonghandPropertiesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetLonghandPropertiesCommandParameters, GetLonghandPropertiesResult> GetLonghandPropertiesCommand = new("CSS.getLonghandProperties", JsonContext.GetLonghandPropertiesCommandParameters, JsonContext.GetLonghandPropertiesResult);

    /// <summary>
    /// Returns the styles defined inline (explicitly in the "style" attribute and implicitly, using DOM
    /// attributes) for a DOM node identified by <b>nodeId</b>.
    /// </summary>
    /// <param name="nodeId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetInlineStylesForNodeResult"/>.
    /// </returns>
    public async Task<GetInlineStylesForNodeResult> GetInlineStylesForNodeAsync(DOM.NodeId nodeId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetInlineStylesForNodeCommandParameters(NodeId: nodeId);
        return await ExecuteCommandAsync(GetInlineStylesForNodeCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetInlineStylesForNodeCommandParameters, GetInlineStylesForNodeResult> GetInlineStylesForNodeCommand = new("CSS.getInlineStylesForNode", JsonContext.GetInlineStylesForNodeCommandParameters, JsonContext.GetInlineStylesForNodeResult);

    /// <summary>
    /// Returns the styles coming from animations &amp; transitions
    /// including the animation &amp; transition styles coming from inheritance chain.
    /// </summary>
    /// <param name="nodeId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetAnimatedStylesForNodeResult"/>.
    /// </returns>
    public async Task<GetAnimatedStylesForNodeResult> GetAnimatedStylesForNodeAsync(DOM.NodeId nodeId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetAnimatedStylesForNodeCommandParameters(NodeId: nodeId);
        return await ExecuteCommandAsync(GetAnimatedStylesForNodeCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetAnimatedStylesForNodeCommandParameters, GetAnimatedStylesForNodeResult> GetAnimatedStylesForNodeCommand = new("CSS.getAnimatedStylesForNode", JsonContext.GetAnimatedStylesForNodeCommandParameters, JsonContext.GetAnimatedStylesForNodeResult);

    /// <summary>
    /// Returns requested styles for a DOM node identified by <b>nodeId</b>.
    /// </summary>
    /// <param name="nodeId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetMatchedStylesForNodeResult"/>.
    /// </returns>
    public async Task<GetMatchedStylesForNodeResult> GetMatchedStylesForNodeAsync(DOM.NodeId nodeId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetMatchedStylesForNodeCommandParameters(NodeId: nodeId);
        return await ExecuteCommandAsync(GetMatchedStylesForNodeCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetMatchedStylesForNodeCommandParameters, GetMatchedStylesForNodeResult> GetMatchedStylesForNodeCommand = new("CSS.getMatchedStylesForNode", JsonContext.GetMatchedStylesForNodeCommandParameters, JsonContext.GetMatchedStylesForNodeResult);

    /// <summary>
    /// Returns the values of the default UA-defined environment variables used in env()
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetEnvironmentVariablesResult"/>.
    /// </returns>
    public async Task<GetEnvironmentVariablesResult> GetEnvironmentVariablesAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetEnvironmentVariablesCommandParameters();
        return await ExecuteCommandAsync(GetEnvironmentVariablesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetEnvironmentVariablesCommandParameters, GetEnvironmentVariablesResult> GetEnvironmentVariablesCommand = new("CSS.getEnvironmentVariables", JsonContext.GetEnvironmentVariablesCommandParameters, JsonContext.GetEnvironmentVariablesResult);

    /// <summary>
    /// Returns all media queries parsed by the rendering engine.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetMediaQueriesResult"/>.
    /// </returns>
    public async Task<GetMediaQueriesResult> GetMediaQueriesAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetMediaQueriesCommandParameters();
        return await ExecuteCommandAsync(GetMediaQueriesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetMediaQueriesCommandParameters, GetMediaQueriesResult> GetMediaQueriesCommand = new("CSS.getMediaQueries", JsonContext.GetMediaQueriesCommandParameters, JsonContext.GetMediaQueriesResult);

    /// <summary>
    /// Requests information about platform fonts which we used to render child TextNodes in the given
    /// node.
    /// </summary>
    /// <param name="nodeId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetPlatformFontsForNodeResult"/>.
    /// </returns>
    public async Task<GetPlatformFontsForNodeResult> GetPlatformFontsForNodeAsync(DOM.NodeId nodeId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetPlatformFontsForNodeCommandParameters(NodeId: nodeId);
        return await ExecuteCommandAsync(GetPlatformFontsForNodeCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetPlatformFontsForNodeCommandParameters, GetPlatformFontsForNodeResult> GetPlatformFontsForNodeCommand = new("CSS.getPlatformFontsForNode", JsonContext.GetPlatformFontsForNodeCommandParameters, JsonContext.GetPlatformFontsForNodeResult);

    /// <summary>
    /// Returns the current textual content for a stylesheet.
    /// </summary>
    /// <param name="styleSheetId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetStyleSheetTextResult"/>.
    /// </returns>
    public async Task<GetStyleSheetTextResult> GetStyleSheetTextAsync(DOM.StyleSheetId styleSheetId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetStyleSheetTextCommandParameters(StyleSheetId: styleSheetId);
        return await ExecuteCommandAsync(GetStyleSheetTextCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetStyleSheetTextCommandParameters, GetStyleSheetTextResult> GetStyleSheetTextCommand = new("CSS.getStyleSheetText", JsonContext.GetStyleSheetTextCommandParameters, JsonContext.GetStyleSheetTextResult);

    /// <summary>
    /// Returns all layers parsed by the rendering engine for the tree scope of a node.
    /// Given a DOM element identified by nodeId, getLayersForNode returns the root
    /// layer for the nearest ancestor document or shadow root. The layer root contains
    /// the full layer tree for the tree scope and their ordering.
    /// </summary>
    /// <param name="nodeId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetLayersForNodeResult"/>.
    /// </returns>
    public async Task<GetLayersForNodeResult> GetLayersForNodeAsync(DOM.NodeId nodeId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetLayersForNodeCommandParameters(NodeId: nodeId);
        return await ExecuteCommandAsync(GetLayersForNodeCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetLayersForNodeCommandParameters, GetLayersForNodeResult> GetLayersForNodeCommand = new("CSS.getLayersForNode", JsonContext.GetLayersForNodeCommandParameters, JsonContext.GetLayersForNodeResult);

    /// <summary>
    /// Given a CSS selector text and a style sheet ID, getLocationForSelector
    /// returns an array of locations of the CSS selector in the style sheet.
    /// </summary>
    /// <param name="styleSheetId">
    /// </param>
    /// <param name="selectorText">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetLocationForSelectorResult"/>.
    /// </returns>
    public async Task<GetLocationForSelectorResult> GetLocationForSelectorAsync(DOM.StyleSheetId styleSheetId, string selectorText, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetLocationForSelectorCommandParameters(StyleSheetId: styleSheetId, SelectorText: selectorText);
        return await ExecuteCommandAsync(GetLocationForSelectorCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetLocationForSelectorCommandParameters, GetLocationForSelectorResult> GetLocationForSelectorCommand = new("CSS.getLocationForSelector", JsonContext.GetLocationForSelectorCommandParameters, JsonContext.GetLocationForSelectorResult);

    /// <summary>
    /// Starts tracking the given node for the computed style updates
    /// and whenever the computed style is updated for node, it queues
    /// a <b>computedStyleUpdated</b> event with throttling.
    /// There can only be 1 node tracked for computed style updates
    /// so passing a new node id removes tracking from the previous node.
    /// Pass <b>undefined</b> to disable tracking.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>NodeId</b></description></item>
    /// </list>
    /// </remarks>
    /// <param name="nodeId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="TrackComputedStyleUpdatesForNodeResult"/>.
    /// </returns>
    public async Task<TrackComputedStyleUpdatesForNodeResult> TrackComputedStyleUpdatesForNodeAsync(DOM.NodeId? nodeId = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new TrackComputedStyleUpdatesForNodeCommandParameters(NodeId: nodeId);
        return await ExecuteCommandAsync(TrackComputedStyleUpdatesForNodeCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<TrackComputedStyleUpdatesForNodeCommandParameters, TrackComputedStyleUpdatesForNodeResult> TrackComputedStyleUpdatesForNodeCommand = new("CSS.trackComputedStyleUpdatesForNode", JsonContext.TrackComputedStyleUpdatesForNodeCommandParameters, JsonContext.TrackComputedStyleUpdatesForNodeResult);

    /// <summary>
    /// Starts tracking the given computed styles for updates. The specified array of properties
    /// replaces the one previously specified. Pass empty array to disable tracking.
    /// Use takeComputedStyleUpdates to retrieve the list of nodes that had properties modified.
    /// The changes to computed style properties are only tracked for nodes pushed to the front-end
    /// by the DOM agent. If no changes to the tracked properties occur after the node has been pushed
    /// to the front-end, no updates will be issued for the node.
    /// </summary>
    /// <param name="propertiesToTrack">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="TrackComputedStyleUpdatesResult"/>.
    /// </returns>
    public async Task<TrackComputedStyleUpdatesResult> TrackComputedStyleUpdatesAsync(ImmutableArray<CSSComputedStyleProperty> propertiesToTrack, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new TrackComputedStyleUpdatesCommandParameters(PropertiesToTrack: propertiesToTrack);
        return await ExecuteCommandAsync(TrackComputedStyleUpdatesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<TrackComputedStyleUpdatesCommandParameters, TrackComputedStyleUpdatesResult> TrackComputedStyleUpdatesCommand = new("CSS.trackComputedStyleUpdates", JsonContext.TrackComputedStyleUpdatesCommandParameters, JsonContext.TrackComputedStyleUpdatesResult);

    /// <summary>
    /// Polls the next batch of computed style updates.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="TakeComputedStyleUpdatesResult"/>.
    /// </returns>
    public async Task<TakeComputedStyleUpdatesResult> TakeComputedStyleUpdatesAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new TakeComputedStyleUpdatesCommandParameters();
        return await ExecuteCommandAsync(TakeComputedStyleUpdatesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<TakeComputedStyleUpdatesCommandParameters, TakeComputedStyleUpdatesResult> TakeComputedStyleUpdatesCommand = new("CSS.takeComputedStyleUpdates", JsonContext.TakeComputedStyleUpdatesCommandParameters, JsonContext.TakeComputedStyleUpdatesResult);

    /// <summary>
    /// Find a rule with the given active property for the given node and set the new value for this
    /// property
    /// </summary>
    /// <param name="nodeId">
    /// The element id for which to set property.
    /// </param>
    /// <param name="propertyName">
    /// </param>
    /// <param name="value">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetEffectivePropertyValueForNodeResult"/>.
    /// </returns>
    public async Task<SetEffectivePropertyValueForNodeResult> SetEffectivePropertyValueForNodeAsync(DOM.NodeId nodeId, string propertyName, string value, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetEffectivePropertyValueForNodeCommandParameters(NodeId: nodeId, PropertyName: propertyName, Value: value);
        return await ExecuteCommandAsync(SetEffectivePropertyValueForNodeCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetEffectivePropertyValueForNodeCommandParameters, SetEffectivePropertyValueForNodeResult> SetEffectivePropertyValueForNodeCommand = new("CSS.setEffectivePropertyValueForNode", JsonContext.SetEffectivePropertyValueForNodeCommandParameters, JsonContext.SetEffectivePropertyValueForNodeResult);

    /// <summary>
    /// Modifies the property rule property name.
    /// </summary>
    /// <param name="styleSheetId">
    /// </param>
    /// <param name="range">
    /// </param>
    /// <param name="propertyName">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetPropertyRulePropertyNameResult"/>.
    /// </returns>
    public async Task<SetPropertyRulePropertyNameResult> SetPropertyRulePropertyNameAsync(DOM.StyleSheetId styleSheetId, SourceRange range, string propertyName, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetPropertyRulePropertyNameCommandParameters(StyleSheetId: styleSheetId, Range: range, PropertyName: propertyName);
        return await ExecuteCommandAsync(SetPropertyRulePropertyNameCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetPropertyRulePropertyNameCommandParameters, SetPropertyRulePropertyNameResult> SetPropertyRulePropertyNameCommand = new("CSS.setPropertyRulePropertyName", JsonContext.SetPropertyRulePropertyNameCommandParameters, JsonContext.SetPropertyRulePropertyNameResult);

    /// <summary>
    /// Modifies the keyframe rule key text.
    /// </summary>
    /// <param name="styleSheetId">
    /// </param>
    /// <param name="range">
    /// </param>
    /// <param name="keyText">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetKeyframeKeyResult"/>.
    /// </returns>
    public async Task<SetKeyframeKeyResult> SetKeyframeKeyAsync(DOM.StyleSheetId styleSheetId, SourceRange range, string keyText, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetKeyframeKeyCommandParameters(StyleSheetId: styleSheetId, Range: range, KeyText: keyText);
        return await ExecuteCommandAsync(SetKeyframeKeyCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetKeyframeKeyCommandParameters, SetKeyframeKeyResult> SetKeyframeKeyCommand = new("CSS.setKeyframeKey", JsonContext.SetKeyframeKeyCommandParameters, JsonContext.SetKeyframeKeyResult);

    /// <summary>
    /// Modifies the rule selector.
    /// </summary>
    /// <param name="styleSheetId">
    /// </param>
    /// <param name="range">
    /// </param>
    /// <param name="text">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetMediaTextResult"/>.
    /// </returns>
    public async Task<SetMediaTextResult> SetMediaTextAsync(DOM.StyleSheetId styleSheetId, SourceRange range, string text, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetMediaTextCommandParameters(StyleSheetId: styleSheetId, Range: range, Text: text);
        return await ExecuteCommandAsync(SetMediaTextCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetMediaTextCommandParameters, SetMediaTextResult> SetMediaTextCommand = new("CSS.setMediaText", JsonContext.SetMediaTextCommandParameters, JsonContext.SetMediaTextResult);

    /// <summary>
    /// Modifies the expression of a container query.
    /// Deprecated. Use setContainerQueryConditionText instead.
    /// </summary>
    /// <param name="styleSheetId">
    /// </param>
    /// <param name="range">
    /// </param>
    /// <param name="text">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetContainerQueryTextResult"/>.
    /// </returns>
    [global::System.Obsolete]
    public async Task<SetContainerQueryTextResult> SetContainerQueryTextAsync(DOM.StyleSheetId styleSheetId, SourceRange range, string text, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetContainerQueryTextCommandParameters(StyleSheetId: styleSheetId, Range: range, Text: text);
        return await ExecuteCommandAsync(SetContainerQueryTextCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetContainerQueryTextCommandParameters, SetContainerQueryTextResult> SetContainerQueryTextCommand = new("CSS.setContainerQueryText", JsonContext.SetContainerQueryTextCommandParameters, JsonContext.SetContainerQueryTextResult);

    /// <summary>
    /// </summary>
    /// <param name="styleSheetId">
    /// </param>
    /// <param name="range">
    /// </param>
    /// <param name="text">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetContainerQueryConditionTextResult"/>.
    /// </returns>
    public async Task<SetContainerQueryConditionTextResult> SetContainerQueryConditionTextAsync(DOM.StyleSheetId styleSheetId, SourceRange range, string text, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetContainerQueryConditionTextCommandParameters(StyleSheetId: styleSheetId, Range: range, Text: text);
        return await ExecuteCommandAsync(SetContainerQueryConditionTextCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetContainerQueryConditionTextCommandParameters, SetContainerQueryConditionTextResult> SetContainerQueryConditionTextCommand = new("CSS.setContainerQueryConditionText", JsonContext.SetContainerQueryConditionTextCommandParameters, JsonContext.SetContainerQueryConditionTextResult);

    /// <summary>
    /// Modifies the expression of a supports at-rule.
    /// </summary>
    /// <param name="styleSheetId">
    /// </param>
    /// <param name="range">
    /// </param>
    /// <param name="text">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetSupportsTextResult"/>.
    /// </returns>
    public async Task<SetSupportsTextResult> SetSupportsTextAsync(DOM.StyleSheetId styleSheetId, SourceRange range, string text, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetSupportsTextCommandParameters(StyleSheetId: styleSheetId, Range: range, Text: text);
        return await ExecuteCommandAsync(SetSupportsTextCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetSupportsTextCommandParameters, SetSupportsTextResult> SetSupportsTextCommand = new("CSS.setSupportsText", JsonContext.SetSupportsTextCommandParameters, JsonContext.SetSupportsTextResult);

    /// <summary>
    /// Modifies the expression of a navigation at-rule.
    /// </summary>
    /// <param name="styleSheetId">
    /// </param>
    /// <param name="range">
    /// </param>
    /// <param name="text">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetNavigationTextResult"/>.
    /// </returns>
    public async Task<SetNavigationTextResult> SetNavigationTextAsync(DOM.StyleSheetId styleSheetId, SourceRange range, string text, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetNavigationTextCommandParameters(StyleSheetId: styleSheetId, Range: range, Text: text);
        return await ExecuteCommandAsync(SetNavigationTextCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetNavigationTextCommandParameters, SetNavigationTextResult> SetNavigationTextCommand = new("CSS.setNavigationText", JsonContext.SetNavigationTextCommandParameters, JsonContext.SetNavigationTextResult);

    /// <summary>
    /// Modifies the expression of a scope at-rule.
    /// </summary>
    /// <param name="styleSheetId">
    /// </param>
    /// <param name="range">
    /// </param>
    /// <param name="text">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetScopeTextResult"/>.
    /// </returns>
    public async Task<SetScopeTextResult> SetScopeTextAsync(DOM.StyleSheetId styleSheetId, SourceRange range, string text, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetScopeTextCommandParameters(StyleSheetId: styleSheetId, Range: range, Text: text);
        return await ExecuteCommandAsync(SetScopeTextCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetScopeTextCommandParameters, SetScopeTextResult> SetScopeTextCommand = new("CSS.setScopeText", JsonContext.SetScopeTextCommandParameters, JsonContext.SetScopeTextResult);

    /// <summary>
    /// Modifies the rule selector.
    /// </summary>
    /// <param name="styleSheetId">
    /// </param>
    /// <param name="range">
    /// </param>
    /// <param name="selector">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetRuleSelectorResult"/>.
    /// </returns>
    public async Task<SetRuleSelectorResult> SetRuleSelectorAsync(DOM.StyleSheetId styleSheetId, SourceRange range, string selector, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetRuleSelectorCommandParameters(StyleSheetId: styleSheetId, Range: range, Selector: selector);
        return await ExecuteCommandAsync(SetRuleSelectorCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetRuleSelectorCommandParameters, SetRuleSelectorResult> SetRuleSelectorCommand = new("CSS.setRuleSelector", JsonContext.SetRuleSelectorCommandParameters, JsonContext.SetRuleSelectorResult);

    /// <summary>
    /// Sets the new stylesheet text.
    /// </summary>
    /// <param name="styleSheetId">
    /// </param>
    /// <param name="text">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetStyleSheetTextResult"/>.
    /// </returns>
    public async Task<SetStyleSheetTextResult> SetStyleSheetTextAsync(DOM.StyleSheetId styleSheetId, string text, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetStyleSheetTextCommandParameters(StyleSheetId: styleSheetId, Text: text);
        return await ExecuteCommandAsync(SetStyleSheetTextCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetStyleSheetTextCommandParameters, SetStyleSheetTextResult> SetStyleSheetTextCommand = new("CSS.setStyleSheetText", JsonContext.SetStyleSheetTextCommandParameters, JsonContext.SetStyleSheetTextResult);

    /// <summary>
    /// Applies specified style edits one after another in the given order.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>NodeForPropertySyntaxValidation</b> - NodeId for the DOM node in whose context custom property declarations for registered properties should be validated. If omitted, declarations in the new rule text can only be validated statically, which may produce incorrect results if the declaration contains a var() for example.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="edits">
    /// </param>
    /// <param name="nodeForPropertySyntaxValidation">
    /// NodeId for the DOM node in whose context custom property declarations for registered properties should be
    /// validated. If omitted, declarations in the new rule text can only be validated statically, which may produce
    /// incorrect results if the declaration contains a var() for example.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetStyleTextsResult"/>.
    /// </returns>
    public async Task<SetStyleTextsResult> SetStyleTextsAsync(ImmutableArray<StyleDeclarationEdit> edits, DOM.NodeId? nodeForPropertySyntaxValidation = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetStyleTextsCommandParameters(Edits: edits, NodeForPropertySyntaxValidation: nodeForPropertySyntaxValidation);
        return await ExecuteCommandAsync(SetStyleTextsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetStyleTextsCommandParameters, SetStyleTextsResult> SetStyleTextsCommand = new("CSS.setStyleTexts", JsonContext.SetStyleTextsCommandParameters, JsonContext.SetStyleTextsResult);

    /// <summary>
    /// Enables the selector recording.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StartRuleUsageTrackingResult"/>.
    /// </returns>
    public async Task<StartRuleUsageTrackingResult> StartRuleUsageTrackingAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new StartRuleUsageTrackingCommandParameters();
        return await ExecuteCommandAsync(StartRuleUsageTrackingCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StartRuleUsageTrackingCommandParameters, StartRuleUsageTrackingResult> StartRuleUsageTrackingCommand = new("CSS.startRuleUsageTracking", JsonContext.StartRuleUsageTrackingCommandParameters, JsonContext.StartRuleUsageTrackingResult);

    /// <summary>
    /// Stop tracking rule usage and return the list of rules that were used since last call to
    /// <b>takeCoverageDelta</b> (or since start of coverage instrumentation).
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StopRuleUsageTrackingResult"/>.
    /// </returns>
    public async Task<StopRuleUsageTrackingResult> StopRuleUsageTrackingAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new StopRuleUsageTrackingCommandParameters();
        return await ExecuteCommandAsync(StopRuleUsageTrackingCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StopRuleUsageTrackingCommandParameters, StopRuleUsageTrackingResult> StopRuleUsageTrackingCommand = new("CSS.stopRuleUsageTracking", JsonContext.StopRuleUsageTrackingCommandParameters, JsonContext.StopRuleUsageTrackingResult);

    /// <summary>
    /// Obtain list of rules that became used since last call to this method (or since start of coverage
    /// instrumentation).
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="TakeCoverageDeltaResult"/>.
    /// </returns>
    public async Task<TakeCoverageDeltaResult> TakeCoverageDeltaAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new TakeCoverageDeltaCommandParameters();
        return await ExecuteCommandAsync(TakeCoverageDeltaCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<TakeCoverageDeltaCommandParameters, TakeCoverageDeltaResult> TakeCoverageDeltaCommand = new("CSS.takeCoverageDelta", JsonContext.TakeCoverageDeltaCommandParameters, JsonContext.TakeCoverageDeltaResult);

    /// <summary>
    /// Enables/disables rendering of local CSS fonts (enabled by default).
    /// </summary>
    /// <param name="enabled">
    /// Whether rendering of local fonts is enabled.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetLocalFontsEnabledResult"/>.
    /// </returns>
    public async Task<SetLocalFontsEnabledResult> SetLocalFontsEnabledAsync(bool enabled, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetLocalFontsEnabledCommandParameters(Enabled: enabled);
        return await ExecuteCommandAsync(SetLocalFontsEnabledCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetLocalFontsEnabledCommandParameters, SetLocalFontsEnabledResult> SetLocalFontsEnabledCommand = new("CSS.setLocalFontsEnabled", JsonContext.SetLocalFontsEnabledCommandParameters, JsonContext.SetLocalFontsEnabledResult);

    /// <summary>
    /// Fires whenever a web font is updated.  A non-empty font parameter indicates a successfully loaded
    /// web font.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="FontsUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Font</b> - The web font that has loaded.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<FontsUpdatedEventArgs> FontsUpdated => CreateCdpEventSource(CSSDomainEvent.FontsUpdated);
    /// <summary>
    /// Fires whenever a MediaQuery result changes (for example, after a browser window has been
    /// resized.) The current implementation considers only viewport-dependent media features.
    /// </summary>
    public IEventSource<MediaQueryResultChangedEventArgs> MediaQueryResultChanged => CreateCdpEventSource(CSSDomainEvent.MediaQueryResultChanged);
    /// <summary>
    /// Fired whenever an active document stylesheet is added.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="StyleSheetAddedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Header</b> - Added stylesheet metainfo.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<StyleSheetAddedEventArgs> StyleSheetAdded => CreateCdpEventSource(CSSDomainEvent.StyleSheetAdded);
    /// <summary>
    /// Fired whenever a stylesheet is changed as a result of the client operation.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="StyleSheetChangedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>StyleSheetId</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<StyleSheetChangedEventArgs> StyleSheetChanged => CreateCdpEventSource(CSSDomainEvent.StyleSheetChanged);
    /// <summary>
    /// Fired whenever an active document stylesheet is removed.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="StyleSheetRemovedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>StyleSheetId</b> - Identifier of the removed stylesheet.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<StyleSheetRemovedEventArgs> StyleSheetRemoved => CreateCdpEventSource(CSSDomainEvent.StyleSheetRemoved);
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ComputedStyleUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>NodeId</b> - The node id that has updated computed styles.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ComputedStyleUpdatedEventArgs> ComputedStyleUpdated => CreateCdpEventSource(CSSDomainEvent.ComputedStyleUpdated);
}

internal sealed record AddRuleCommandParameters(DOM.StyleSheetId StyleSheetId, string RuleText, SourceRange Location, DOM.NodeId? NodeForPropertySyntaxValidation) : Parameters;

/// <summary>
/// </summary>
/// <param name="Rule">
/// The newly created rule.
/// </param>
public sealed record AddRuleResult(CSSRule Rule) : EmptyResult;


internal sealed record CollectClassNamesCommandParameters(DOM.StyleSheetId StyleSheetId) : Parameters;

/// <summary>
/// </summary>
/// <param name="ClassNames">
/// Class name list.
/// </param>
public sealed record CollectClassNamesResult(ImmutableArray<string> ClassNames) : EmptyResult;


internal sealed record CreateStyleSheetCommandParameters(Page.FrameId FrameId, bool? Force) : Parameters;

/// <summary>
/// </summary>
/// <param name="StyleSheetId">
/// Identifier of the created "via-inspector" stylesheet.
/// </param>
public sealed record CreateStyleSheetResult(DOM.StyleSheetId StyleSheetId) : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record ForcePseudoStateCommandParameters(DOM.NodeId NodeId, ImmutableArray<string> ForcedPseudoClasses) : Parameters;

/// <summary>
/// </summary>
public sealed record ForcePseudoStateResult() : EmptyResult;


internal sealed record ForceStartingStyleCommandParameters(DOM.NodeId NodeId, bool Forced) : Parameters;

/// <summary>
/// </summary>
public sealed record ForceStartingStyleResult() : EmptyResult;


internal sealed record GetBackgroundColorsCommandParameters(DOM.NodeId NodeId) : Parameters;

/// <summary>
/// </summary>
/// <param name="BackgroundColors">
/// The range of background colors behind this element, if it contains any visible text. If no
/// visible text is present, this will be undefined. In the case of a flat background color,
/// this will consist of simply that color. In the case of a gradient, this will consist of each
/// of the color stops. For anything more complicated, this will be an empty array. Images will
/// be ignored (as if the image had failed to load).
/// </param>
/// <param name="ComputedFontSize">
/// The computed font size for this node, as a CSS computed value string (e.g. '12px').
/// </param>
/// <param name="ComputedFontWeight">
/// The computed font weight for this node, as a CSS computed value string (e.g. 'normal' or
/// '100').
/// </param>
public sealed record GetBackgroundColorsResult(ImmutableArray<string>? BackgroundColors, string? ComputedFontSize, string? ComputedFontWeight) : EmptyResult;


internal sealed record GetComputedStyleForNodeCommandParameters(DOM.NodeId NodeId) : Parameters;

/// <summary>
/// </summary>
/// <param name="ComputedStyle">
/// Computed style for the specified DOM node.
/// </param>
/// <param name="ExtraFields">
/// A list of non-standard "extra fields" which blink stores alongside each
/// computed style.
/// </param>
public sealed record GetComputedStyleForNodeResult(ImmutableArray<CSSComputedStyleProperty> ComputedStyle, ComputedStyleExtraFields ExtraFields) : EmptyResult;


internal sealed record ResolveValuesCommandParameters(ImmutableArray<string> Values, DOM.NodeId NodeId, string? PropertyName, DOM.PseudoType? PseudoType, string? PseudoIdentifier) : Parameters;

/// <summary>
/// </summary>
/// <param name="Results">
/// </param>
public sealed record ResolveValuesResult(ImmutableArray<string> Results) : EmptyResult;


internal sealed record GetLonghandPropertiesCommandParameters(string ShorthandName, string Value) : Parameters;

/// <summary>
/// </summary>
/// <param name="LonghandProperties">
/// </param>
public sealed record GetLonghandPropertiesResult(ImmutableArray<CSSProperty> LonghandProperties) : EmptyResult;


internal sealed record GetInlineStylesForNodeCommandParameters(DOM.NodeId NodeId) : Parameters;

/// <summary>
/// </summary>
/// <param name="InlineStyle">
/// Inline style for the specified DOM node.
/// </param>
/// <param name="AttributesStyle">
/// Attribute-defined element style (e.g. resulting from "width=20 height=100%").
/// </param>
public sealed record GetInlineStylesForNodeResult(CSSStyle? InlineStyle, CSSStyle? AttributesStyle) : EmptyResult;


internal sealed record GetAnimatedStylesForNodeCommandParameters(DOM.NodeId NodeId) : Parameters;

/// <summary>
/// </summary>
/// <param name="AnimationStyles">
/// Styles coming from animations.
/// </param>
/// <param name="TransitionsStyle">
/// Style coming from transitions.
/// </param>
/// <param name="Inherited">
/// Inherited style entries for animationsStyle and transitionsStyle from
/// the inheritance chain of the element.
/// </param>
public sealed record GetAnimatedStylesForNodeResult(ImmutableArray<CSSAnimationStyle>? AnimationStyles, CSSStyle? TransitionsStyle, ImmutableArray<InheritedAnimatedStyleEntry>? Inherited) : EmptyResult;


internal sealed record GetMatchedStylesForNodeCommandParameters(DOM.NodeId NodeId) : Parameters;

/// <summary>
/// </summary>
/// <param name="InlineStyle">
/// Inline style for the specified DOM node.
/// </param>
/// <param name="AttributesStyle">
/// Attribute-defined element style (e.g. resulting from "width=20 height=100%").
/// </param>
/// <param name="MatchedCSSRules">
/// CSS rules matching this node, from all applicable stylesheets.
/// </param>
/// <param name="PseudoElements">
/// Pseudo style matches for this node.
/// </param>
/// <param name="Inherited">
/// A chain of inherited styles (from the immediate node parent up to the DOM tree root).
/// </param>
/// <param name="InheritedPseudoElements">
/// A chain of inherited pseudo element styles (from the immediate node parent up to the DOM tree root).
/// </param>
/// <param name="CssKeyframesRules">
/// A list of CSS keyframed animations matching this node.
/// </param>
/// <param name="CssPositionTryRules">
/// A list of CSS @position-try rules matching this node, based on the position-try-fallbacks property.
/// </param>
/// <param name="ActivePositionFallbackIndex">
/// Index of the active fallback in the applied position-try-fallback property,
/// will not be set if there is no active position-try fallback.
/// </param>
/// <param name="CssPropertyRules">
/// A list of CSS at-property rules matching this node.
/// </param>
/// <param name="CssPropertyRegistrations">
/// A list of CSS property registrations matching this node.
/// </param>
/// <param name="CssAtRules">
/// A list of simple @rules matching this node or its pseudo-elements.
/// </param>
/// <param name="ParentLayoutNodeId">
/// Id of the first parent element that does not have display: contents.
/// </param>
/// <param name="CssFunctionRules">
/// A list of CSS at-function rules referenced by styles of this node.
/// </param>
public sealed record GetMatchedStylesForNodeResult(CSSStyle? InlineStyle, CSSStyle? AttributesStyle, ImmutableArray<RuleMatch>? MatchedCSSRules, ImmutableArray<PseudoElementMatches>? PseudoElements, ImmutableArray<InheritedStyleEntry>? Inherited, ImmutableArray<InheritedPseudoElementMatches>? InheritedPseudoElements, ImmutableArray<CSSKeyframesRule>? CssKeyframesRules, ImmutableArray<CSSPositionTryRule>? CssPositionTryRules, long? ActivePositionFallbackIndex, ImmutableArray<CSSPropertyRule>? CssPropertyRules, ImmutableArray<CSSPropertyRegistration>? CssPropertyRegistrations, ImmutableArray<CSSAtRule>? CssAtRules, DOM.NodeId? ParentLayoutNodeId, ImmutableArray<CSSFunctionRule>? CssFunctionRules) : EmptyResult;


internal sealed record GetEnvironmentVariablesCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="EnvironmentVariables">
/// </param>
public sealed record GetEnvironmentVariablesResult(global::System.Text.Json.JsonElement EnvironmentVariables) : EmptyResult;


internal sealed record GetMediaQueriesCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="Medias">
/// </param>
public sealed record GetMediaQueriesResult(ImmutableArray<CSSMedia> Medias) : EmptyResult;


internal sealed record GetPlatformFontsForNodeCommandParameters(DOM.NodeId NodeId) : Parameters;

/// <summary>
/// </summary>
/// <param name="Fonts">
/// Usage statistics for every employed platform font.
/// </param>
public sealed record GetPlatformFontsForNodeResult(ImmutableArray<PlatformFontUsage> Fonts) : EmptyResult;


internal sealed record GetStyleSheetTextCommandParameters(DOM.StyleSheetId StyleSheetId) : Parameters;

/// <summary>
/// </summary>
/// <param name="Text">
/// The stylesheet text.
/// </param>
public sealed record GetStyleSheetTextResult(string Text) : EmptyResult;


internal sealed record GetLayersForNodeCommandParameters(DOM.NodeId NodeId) : Parameters;

/// <summary>
/// </summary>
/// <param name="RootLayer">
/// </param>
public sealed record GetLayersForNodeResult(CSSLayerData RootLayer) : EmptyResult;


internal sealed record GetLocationForSelectorCommandParameters(DOM.StyleSheetId StyleSheetId, string SelectorText) : Parameters;

/// <summary>
/// </summary>
/// <param name="Ranges">
/// </param>
public sealed record GetLocationForSelectorResult(ImmutableArray<SourceRange> Ranges) : EmptyResult;


internal sealed record TrackComputedStyleUpdatesForNodeCommandParameters(DOM.NodeId? NodeId) : Parameters;

/// <summary>
/// </summary>
public sealed record TrackComputedStyleUpdatesForNodeResult() : EmptyResult;


internal sealed record TrackComputedStyleUpdatesCommandParameters(ImmutableArray<CSSComputedStyleProperty> PropertiesToTrack) : Parameters;

/// <summary>
/// </summary>
public sealed record TrackComputedStyleUpdatesResult() : EmptyResult;


internal sealed record TakeComputedStyleUpdatesCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="NodeIds">
/// The list of node Ids that have their tracked computed styles updated.
/// </param>
public sealed record TakeComputedStyleUpdatesResult(ImmutableArray<DOM.NodeId> NodeIds) : EmptyResult;


internal sealed record SetEffectivePropertyValueForNodeCommandParameters(DOM.NodeId NodeId, string PropertyName, string Value) : Parameters;

/// <summary>
/// </summary>
public sealed record SetEffectivePropertyValueForNodeResult() : EmptyResult;


internal sealed record SetPropertyRulePropertyNameCommandParameters(DOM.StyleSheetId StyleSheetId, SourceRange Range, string PropertyName) : Parameters;

/// <summary>
/// </summary>
/// <param name="PropertyName">
/// The resulting key text after modification.
/// </param>
public sealed record SetPropertyRulePropertyNameResult(Value PropertyName) : EmptyResult;


internal sealed record SetKeyframeKeyCommandParameters(DOM.StyleSheetId StyleSheetId, SourceRange Range, string KeyText) : Parameters;

/// <summary>
/// </summary>
/// <param name="KeyText">
/// The resulting key text after modification.
/// </param>
public sealed record SetKeyframeKeyResult(Value KeyText) : EmptyResult;


internal sealed record SetMediaTextCommandParameters(DOM.StyleSheetId StyleSheetId, SourceRange Range, string Text) : Parameters;

/// <summary>
/// </summary>
/// <param name="Media">
/// The resulting CSS media rule after modification.
/// </param>
public sealed record SetMediaTextResult(CSSMedia Media) : EmptyResult;


internal sealed record SetContainerQueryTextCommandParameters(DOM.StyleSheetId StyleSheetId, SourceRange Range, string Text) : Parameters;

/// <summary>
/// </summary>
/// <param name="ContainerQuery">
/// The resulting CSS container query rule after modification.
/// </param>
public sealed record SetContainerQueryTextResult(CSSContainerQuery ContainerQuery) : EmptyResult;


internal sealed record SetContainerQueryConditionTextCommandParameters(DOM.StyleSheetId StyleSheetId, SourceRange Range, string Text) : Parameters;

/// <summary>
/// </summary>
/// <param name="ContainerQuery">
/// The resulting CSS container query rule after modification.
/// </param>
public sealed record SetContainerQueryConditionTextResult(CSSContainerQuery ContainerQuery) : EmptyResult;


internal sealed record SetSupportsTextCommandParameters(DOM.StyleSheetId StyleSheetId, SourceRange Range, string Text) : Parameters;

/// <summary>
/// </summary>
/// <param name="Supports">
/// The resulting CSS Supports rule after modification.
/// </param>
public sealed record SetSupportsTextResult(CSSSupports Supports) : EmptyResult;


internal sealed record SetNavigationTextCommandParameters(DOM.StyleSheetId StyleSheetId, SourceRange Range, string Text) : Parameters;

/// <summary>
/// </summary>
/// <param name="Navigation">
/// The resulting CSS Navigation rule after modification.
/// </param>
public sealed record SetNavigationTextResult(CSSNavigation Navigation) : EmptyResult;


internal sealed record SetScopeTextCommandParameters(DOM.StyleSheetId StyleSheetId, SourceRange Range, string Text) : Parameters;

/// <summary>
/// </summary>
/// <param name="Scope">
/// The resulting CSS Scope rule after modification.
/// </param>
public sealed record SetScopeTextResult(CSSScope Scope) : EmptyResult;


internal sealed record SetRuleSelectorCommandParameters(DOM.StyleSheetId StyleSheetId, SourceRange Range, string Selector) : Parameters;

/// <summary>
/// </summary>
/// <param name="SelectorList">
/// The resulting selector list after modification.
/// </param>
public sealed record SetRuleSelectorResult(SelectorList SelectorList) : EmptyResult;


internal sealed record SetStyleSheetTextCommandParameters(DOM.StyleSheetId StyleSheetId, string Text) : Parameters;

/// <summary>
/// </summary>
/// <param name="SourceMapURL">
/// URL of source map associated with script (if any).
/// </param>
public sealed record SetStyleSheetTextResult(string? SourceMapURL) : EmptyResult;


internal sealed record SetStyleTextsCommandParameters(ImmutableArray<StyleDeclarationEdit> Edits, DOM.NodeId? NodeForPropertySyntaxValidation) : Parameters;

/// <summary>
/// </summary>
/// <param name="Styles">
/// The resulting styles after modification.
/// </param>
public sealed record SetStyleTextsResult(ImmutableArray<CSSStyle> Styles) : EmptyResult;


internal sealed record StartRuleUsageTrackingCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record StartRuleUsageTrackingResult() : EmptyResult;


internal sealed record StopRuleUsageTrackingCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="RuleUsage">
/// </param>
public sealed record StopRuleUsageTrackingResult(ImmutableArray<RuleUsage> RuleUsage) : EmptyResult;


internal sealed record TakeCoverageDeltaCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="Coverage">
/// </param>
/// <param name="Timestamp">
/// Monotonically increasing time, in seconds.
/// </param>
public sealed record TakeCoverageDeltaResult(ImmutableArray<RuleUsage> Coverage, double Timestamp) : EmptyResult;


internal sealed record SetLocalFontsEnabledCommandParameters(bool Enabled) : Parameters;

/// <summary>
/// </summary>
public sealed record SetLocalFontsEnabledResult() : EmptyResult;


/// <summary>
/// Fires whenever a web font is updated.  A non-empty font parameter indicates a successfully loaded
/// web font.
/// </summary>
/// <param name="Font">
/// The web font that has loaded.
/// </param>
public sealed record FontsUpdatedEventArgs(FontFace? Font = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fires whenever a MediaQuery result changes (for example, after a browser window has been
/// resized.) The current implementation considers only viewport-dependent media features.
/// </summary>
public sealed record MediaQueryResultChangedEventArgs() : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired whenever an active document stylesheet is added.
/// </summary>
/// <param name="Header">
/// Added stylesheet metainfo.
/// </param>
public sealed record StyleSheetAddedEventArgs(CSSStyleSheetHeader Header) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired whenever a stylesheet is changed as a result of the client operation.
/// </summary>
/// <param name="StyleSheetId">
/// </param>
public sealed record StyleSheetChangedEventArgs(DOM.StyleSheetId StyleSheetId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired whenever an active document stylesheet is removed.
/// </summary>
/// <param name="StyleSheetId">
/// Identifier of the removed stylesheet.
/// </param>
public sealed record StyleSheetRemovedEventArgs(DOM.StyleSheetId StyleSheetId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
/// <param name="NodeId">
/// The node id that has updated computed styles.
/// </param>
public sealed record ComputedStyleUpdatedEventArgs(DOM.NodeId NodeId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Stylesheet type: "injected" for stylesheets injected via extension, "user-agent" for user-agent
/// stylesheets, "inspector" for stylesheets created by the inspector (i.e. those holding the "via
/// inspector" rules), "regular" for regular stylesheets.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<StyleSheetOrigin>))]
public enum StyleSheetOrigin
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("injected")]
    Injected,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("user-agent")]
    UserAgent,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("inspector")]
    Inspector,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("regular")]
    Regular,
}

/// <summary>
/// CSS rule collection for a single pseudo style.
/// </summary>
/// <param name="PseudoType">
/// Pseudo element type.
/// </param>
/// <param name="Matches">
/// Matches of CSS rules applicable to the pseudo style.
/// </param>
public sealed record PseudoElementMatches(DOM.PseudoType PseudoType, ImmutableArray<RuleMatch> Matches)
{
    /// <summary>
    /// Pseudo element custom ident.
    /// </summary>
    public string? PseudoIdentifier { get; init; }
}

/// <summary>
/// CSS style coming from animations with the name of the animation.
/// </summary>
/// <param name="Style">
/// The style coming from the animation.
/// </param>
public sealed record CSSAnimationStyle(CSSStyle Style)
{
    /// <summary>
    /// The name of the animation.
    /// </summary>
    public string? Name { get; init; }
}

/// <summary>
/// Inherited CSS rule collection from ancestor node.
/// </summary>
/// <param name="MatchedCSSRules">
/// Matches of CSS rules matching the ancestor node in the style inheritance chain.
/// </param>
public sealed record InheritedStyleEntry(ImmutableArray<RuleMatch> MatchedCSSRules)
{
    /// <summary>
    /// The ancestor node's inline style, if any, in the style inheritance chain.
    /// </summary>
    public CSSStyle? InlineStyle { get; init; }
}

/// <summary>
/// Inherited CSS style collection for animated styles from ancestor node.
/// </summary>
public sealed record InheritedAnimatedStyleEntry()
{
    /// <summary>
    /// Styles coming from the animations of the ancestor, if any, in the style inheritance chain.
    /// </summary>
    public ImmutableArray<CSSAnimationStyle>? AnimationStyles { get; init; }

    /// <summary>
    /// The style coming from the transitions of the ancestor, if any, in the style inheritance chain.
    /// </summary>
    public CSSStyle? TransitionsStyle { get; init; }
}

/// <summary>
/// Inherited pseudo element matches from pseudos of an ancestor node.
/// </summary>
/// <param name="PseudoElements">
/// Matches of pseudo styles from the pseudos of an ancestor node.
/// </param>
public sealed record InheritedPseudoElementMatches(ImmutableArray<PseudoElementMatches> PseudoElements)
{
}

/// <summary>
/// Match data for a CSS rule.
/// </summary>
/// <param name="Rule">
/// CSS rule in the match.
/// </param>
/// <param name="MatchingSelectors">
/// Matching selector indices in the rule's selectorList selectors (0-based).
/// </param>
public sealed record RuleMatch(CSSRule Rule, ImmutableArray<long> MatchingSelectors)
{
}

/// <summary>
/// Data for a simple selector (these are delimited by commas in a selector list).
/// </summary>
/// <param name="Text">
/// Value text.
/// </param>
public sealed record Value(string Text)
{
    /// <summary>
    /// Value range in the underlying resource (if available).
    /// </summary>
    public SourceRange? Range { get; init; }

    /// <summary>
    /// Specificity of the selector.
    /// </summary>
    public Specificity? Specificity { get; init; }
}

/// <summary>
/// Contribution of an individual simple selector to specificity.
/// </summary>
/// <param name="Text">
/// The simple selector text that contributes to specificity.
/// </param>
/// <param name="A">
/// The a component contribution.
/// </param>
/// <param name="B">
/// The b component contribution.
/// </param>
/// <param name="C">
/// The c component contribution.
/// </param>
public sealed record SpecificityComponent(string Text, long A, long B, long C)
{
}

/// <summary>
/// Specificity:
/// https://drafts.csswg.org/selectors/#specificity-rules
/// </summary>
/// <param name="A">
/// The a component, which represents the number of ID selectors.
/// </param>
/// <param name="B">
/// The b component, which represents the number of class selectors, attributes selectors, and
/// pseudo-classes.
/// </param>
/// <param name="C">
/// The c component, which represents the number of type selectors and pseudo-elements.
/// </param>
public sealed record Specificity(long A, long B, long C)
{
    /// <summary>
    /// Per-simple-selector contributions used to explain this specificity.
    /// </summary>
    public ImmutableArray<SpecificityComponent>? Components { get; init; }
}

/// <summary>
/// Selector list data.
/// </summary>
/// <param name="Selectors">
/// Selectors in the list.
/// </param>
/// <param name="Text">
/// Rule selector text.
/// </param>
public sealed record SelectorList(ImmutableArray<Value> Selectors, string Text)
{
}

/// <summary>
/// CSS stylesheet metainformation.
/// </summary>
/// <param name="StyleSheetId">
/// The stylesheet identifier.
/// </param>
/// <param name="FrameId">
/// Owner frame identifier.
/// </param>
/// <param name="SourceURL">
/// Stylesheet resource URL. Empty if this is a constructed stylesheet created using
/// new CSSStyleSheet() (but non-empty if this is a constructed stylesheet imported
/// as a CSS module script).
/// </param>
/// <param name="Origin">
/// Stylesheet origin.
/// </param>
/// <param name="Title">
/// Stylesheet title.
/// </param>
/// <param name="Disabled">
/// Denotes whether the stylesheet is disabled.
/// </param>
/// <param name="IsInline">
/// Whether this stylesheet is created for STYLE tag by parser. This flag is not set for
/// document.written STYLE tags.
/// </param>
/// <param name="IsMutable">
/// Whether this stylesheet is mutable. Inline stylesheets become mutable
/// after they have been modified via CSSOM API.
/// <b>&lt;link&gt;</b> element's stylesheets become mutable only if DevTools modifies them.
/// Constructed stylesheets (new CSSStyleSheet()) are mutable immediately after creation.
/// </param>
/// <param name="IsConstructed">
/// True if this stylesheet is created through new CSSStyleSheet() or imported as a
/// CSS module script.
/// </param>
/// <param name="StartLine">
/// Line offset of the stylesheet within the resource (zero based).
/// </param>
/// <param name="StartColumn">
/// Column offset of the stylesheet within the resource (zero based).
/// </param>
/// <param name="Length">
/// Size of the content (in characters).
/// </param>
/// <param name="EndLine">
/// Line offset of the end of the stylesheet within the resource (zero based).
/// </param>
/// <param name="EndColumn">
/// Column offset of the end of the stylesheet within the resource (zero based).
/// </param>
public sealed record CSSStyleSheetHeader(DOM.StyleSheetId StyleSheetId, Page.FrameId FrameId, string SourceURL, StyleSheetOrigin Origin, string Title, bool Disabled, bool IsInline, bool IsMutable, bool IsConstructed, double StartLine, double StartColumn, double Length, double EndLine, double EndColumn)
{
    /// <summary>
    /// URL of source map associated with the stylesheet (if any).
    /// </summary>
    public string? SourceMapURL { get; init; }

    /// <summary>
    /// The backend id for the owner node of the stylesheet.
    /// </summary>
    public DOM.BackendNodeId? OwnerNode { get; init; }

    /// <summary>
    /// Whether the sourceURL field value comes from the sourceURL comment.
    /// </summary>
    public bool? HasSourceURL { get; init; }

    /// <summary>
    /// If the style sheet was loaded from a network resource, this indicates when the resource failed to load
    /// </summary>
    public bool? LoadingFailed { get; init; }
}

/// <summary>
/// CSS rule representation.
/// </summary>
/// <param name="SelectorList">
/// Rule selector data.
/// </param>
/// <param name="Origin">
/// Parent stylesheet's origin.
/// </param>
/// <param name="Style">
/// Associated style declaration.
/// </param>
public sealed record CSSRule(SelectorList SelectorList, StyleSheetOrigin Origin, CSSStyle Style)
{
    /// <summary>
    /// The css style sheet identifier (absent for user agent stylesheet and user-specified
    /// stylesheet rules) this rule came from.
    /// </summary>
    public DOM.StyleSheetId? StyleSheetId { get; init; }

    /// <summary>
    /// Array of selectors from ancestor style rules, sorted by distance from the current rule.
    /// </summary>
    public ImmutableArray<string>? NestingSelectors { get; init; }

    /// <summary>
    /// The BackendNodeId of the DOM node that constitutes the origin tree scope of this rule.
    /// </summary>
    public DOM.BackendNodeId? OriginTreeScopeNodeId { get; init; }

    /// <summary>
    /// Media list array (for rules involving media queries). The array enumerates media queries
    /// starting with the innermost one, going outwards.
    /// </summary>
    public ImmutableArray<CSSMedia>? Media { get; init; }

    /// <summary>
    /// Container query list array (for rules involving container queries).
    /// The array enumerates container queries starting with the innermost one, going outwards.
    /// </summary>
    public ImmutableArray<CSSContainerQuery>? ContainerQueries { get; init; }

    /// <summary>
    /// @supports CSS at-rule array.
    /// The array enumerates @supports at-rules starting with the innermost one, going outwards.
    /// </summary>
    public ImmutableArray<CSSSupports>? Supports { get; init; }

    /// <summary>
    /// Cascade layer array. Contains the layer hierarchy that this rule belongs to starting
    /// with the innermost layer and going outwards.
    /// </summary>
    public ImmutableArray<CSSLayer>? Layers { get; init; }

    /// <summary>
    /// @scope CSS at-rule array.
    /// The array enumerates @scope at-rules starting with the innermost one, going outwards.
    /// </summary>
    public ImmutableArray<CSSScope>? Scopes { get; init; }

    /// <summary>
    /// The array keeps the types of ancestor CSSRules from the innermost going outwards.
    /// </summary>
    public ImmutableArray<CSSRuleType>? RuleTypes { get; init; }

    /// <summary>
    /// @starting-style CSS at-rule array.
    /// The array enumerates @starting-style at-rules starting with the innermost one, going outwards.
    /// </summary>
    public ImmutableArray<CSSStartingStyle>? StartingStyles { get; init; }

    /// <summary>
    /// @navigation CSS at-rule array.
    /// The array enumerates @navigation at-rules starting with the innermost one, going outwards.
    /// </summary>
    public ImmutableArray<CSSNavigation>? Navigations { get; init; }
}

/// <summary>
/// Enum indicating the type of a CSS rule, used to represent the order of a style rule's ancestors.
/// This list only contains rule types that are collected during the ancestor rule collection.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<CSSRuleType>))]
public enum CSSRuleType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MediaRule")]
    MediaRule,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SupportsRule")]
    SupportsRule,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContainerRule")]
    ContainerRule,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("LayerRule")]
    LayerRule,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ScopeRule")]
    ScopeRule,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("StyleRule")]
    StyleRule,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("StartingStyleRule")]
    StartingStyleRule,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NavigationRule")]
    NavigationRule,
}

/// <summary>
/// CSS coverage information.
/// </summary>
/// <param name="StyleSheetId">
/// The css style sheet identifier (absent for user agent stylesheet and user-specified
/// stylesheet rules) this rule came from.
/// </param>
/// <param name="StartOffset">
/// Offset of the start of the rule (including selector) from the beginning of the stylesheet.
/// </param>
/// <param name="EndOffset">
/// Offset of the end of the rule body from the beginning of the stylesheet.
/// </param>
/// <param name="Used">
/// Indicates whether the rule was actually used by some element in the page.
/// </param>
public sealed record RuleUsage(DOM.StyleSheetId StyleSheetId, double StartOffset, double EndOffset, bool Used)
{
}

/// <summary>
/// Text range within a resource. All numbers are zero-based.
/// </summary>
/// <param name="StartLine">
/// Start line of range.
/// </param>
/// <param name="StartColumn">
/// Start column of range (inclusive).
/// </param>
/// <param name="EndLine">
/// End line of range
/// </param>
/// <param name="EndColumn">
/// End column of range (exclusive).
/// </param>
public sealed record SourceRange(long StartLine, long StartColumn, long EndLine, long EndColumn)
{
}

/// <summary>
/// </summary>
/// <param name="Name">
/// Shorthand name.
/// </param>
/// <param name="Value">
/// Shorthand value.
/// </param>
public sealed record ShorthandEntry(string Name, string Value)
{
    /// <summary>
    /// Whether the property has "!important" annotation (implies <b>false</b> if absent).
    /// </summary>
    public bool? Important { get; init; }
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

/// <summary>
/// </summary>
/// <param name="IsAppearanceBase">
/// Returns whether or not this node is being rendered with base appearance,
/// which happens when it has its appearance property set to base/base-select
/// or it is in the subtree of an element being rendered with base appearance.
/// </param>
public sealed record ComputedStyleExtraFields(bool IsAppearanceBase)
{
}

/// <summary>
/// CSS style representation.
/// </summary>
/// <param name="CssProperties">
/// CSS properties in the style.
/// </param>
/// <param name="ShorthandEntries">
/// Computed values for all shorthands found in the style.
/// </param>
public sealed record CSSStyle(ImmutableArray<CSSProperty> CssProperties, ImmutableArray<ShorthandEntry> ShorthandEntries)
{
    /// <summary>
    /// The css style sheet identifier (absent for user agent stylesheet and user-specified
    /// stylesheet rules) this rule came from.
    /// </summary>
    public DOM.StyleSheetId? StyleSheetId { get; init; }

    /// <summary>
    /// Style declaration text (if available).
    /// </summary>
    public string? CssText { get; init; }

    /// <summary>
    /// Style declaration range in the enclosing stylesheet (if available).
    /// </summary>
    public SourceRange? Range { get; init; }
}

/// <summary>
/// CSS property declaration data.
/// </summary>
/// <param name="Name">
/// The property name.
/// </param>
/// <param name="Value">
/// The property value.
/// </param>
public sealed record CSSProperty(string Name, string Value)
{
    /// <summary>
    /// Whether the property has "!important" annotation (implies <b>false</b> if absent).
    /// </summary>
    public bool? Important { get; init; }

    /// <summary>
    /// Whether the property is implicit (implies <b>false</b> if absent).
    /// </summary>
    public bool? Implicit { get; init; }

    /// <summary>
    /// The full property text as specified in the style.
    /// </summary>
    public string? Text { get; init; }

    /// <summary>
    /// Whether the property is understood by the browser (implies <b>true</b> if absent).
    /// </summary>
    public bool? ParsedOk { get; init; }

    /// <summary>
    /// Whether the property is disabled by the user (present for source-based properties only).
    /// </summary>
    public bool? Disabled { get; init; }

    /// <summary>
    /// The entire property range in the enclosing style declaration (if available).
    /// </summary>
    public SourceRange? Range { get; init; }

    /// <summary>
    /// Parsed longhand components of this property if it is a shorthand.
    /// This field will be empty if the given property is not a shorthand.
    /// </summary>
    public ImmutableArray<CSSProperty>? LonghandProperties { get; init; }
}

/// <summary>
/// CSS media rule descriptor.
/// </summary>
/// <param name="Text">
/// Media query text.
/// </param>
/// <param name="Source">
/// Source of the media query: "mediaRule" if specified by a @media rule, "importRule" if
/// specified by an @import rule, "linkedSheet" if specified by a "media" attribute in a linked
/// stylesheet's LINK tag, "inlineSheet" if specified by a "media" attribute in an inline
/// stylesheet's STYLE tag.
/// </param>
public sealed record CSSMedia(string Text, string Source)
{
    /// <summary>
    /// URL of the document containing the media query description.
    /// </summary>
    public string? SourceURL { get; init; }

    /// <summary>
    /// The associated rule (@media or @import) header range in the enclosing stylesheet (if
    /// available).
    /// </summary>
    public SourceRange? Range { get; init; }

    /// <summary>
    /// Identifier of the stylesheet containing this object (if exists).
    /// </summary>
    public DOM.StyleSheetId? StyleSheetId { get; init; }

    /// <summary>
    /// Array of media queries.
    /// </summary>
    public ImmutableArray<MediaQuery>? MediaList { get; init; }
}

/// <summary>
/// Media query descriptor.
/// </summary>
/// <param name="Expressions">
/// Array of media query expressions.
/// </param>
/// <param name="Active">
/// Whether the media query condition is satisfied.
/// </param>
public sealed record MediaQuery(ImmutableArray<MediaQueryExpression> Expressions, bool Active)
{
}

/// <summary>
/// Media query expression descriptor.
/// </summary>
/// <param name="Value">
/// Media query expression value.
/// </param>
/// <param name="Unit">
/// Media query expression units.
/// </param>
/// <param name="Feature">
/// Media query expression feature.
/// </param>
public sealed record MediaQueryExpression(double Value, string Unit, string Feature)
{
    /// <summary>
    /// The associated range of the value text in the enclosing stylesheet (if available).
    /// </summary>
    public SourceRange? ValueRange { get; init; }

    /// <summary>
    /// Computed length of media query expression (if applicable).
    /// </summary>
    public double? ComputedLength { get; init; }
}

/// <summary>
/// CSS container query rule descriptor.
/// </summary>
/// <param name="Text">
/// Container query text.
/// Contains the query part without the container name for a single query.
/// Deprecated in favor of conditionText which contains the full prelude
/// after @container.
/// </param>
/// <param name="ConditionText">
/// CSSContainerRule.conditionText
/// </param>
public sealed record CSSContainerQuery(string Text, string ConditionText)
{
    /// <summary>
    /// The associated rule header range in the enclosing stylesheet (if
    /// available).
    /// </summary>
    public SourceRange? Range { get; init; }

    /// <summary>
    /// Identifier of the stylesheet containing this object (if exists).
    /// </summary>
    public DOM.StyleSheetId? StyleSheetId { get; init; }

    /// <summary>
    /// Optional name for the container.
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// Optional physical axes queried for the container.
    /// </summary>
    public DOM.PhysicalAxes? PhysicalAxes { get; init; }

    /// <summary>
    /// Optional logical axes queried for the container.
    /// </summary>
    public DOM.LogicalAxes? LogicalAxes { get; init; }

    /// <summary>
    /// true if the query contains scroll-state() queries.
    /// </summary>
    public bool? QueriesScrollState { get; init; }

    /// <summary>
    /// true if the query contains anchored() queries.
    /// </summary>
    public bool? QueriesAnchored { get; init; }
}

/// <summary>
/// CSS Supports at-rule descriptor.
/// </summary>
/// <param name="Text">
/// Supports rule text.
/// </param>
/// <param name="Active">
/// Whether the supports condition is satisfied.
/// </param>
public sealed record CSSSupports(string Text, bool Active)
{
    /// <summary>
    /// The associated rule header range in the enclosing stylesheet (if
    /// available).
    /// </summary>
    public SourceRange? Range { get; init; }

    /// <summary>
    /// Identifier of the stylesheet containing this object (if exists).
    /// </summary>
    public DOM.StyleSheetId? StyleSheetId { get; init; }
}

/// <summary>
/// CSS Navigation at-rule descriptor.
/// </summary>
/// <param name="Text">
/// Navigation rule text.
/// </param>
public sealed record CSSNavigation(string Text)
{
    /// <summary>
    /// Whether the navigation condition is satisfied.
    /// </summary>
    public bool? Active { get; init; }

    /// <summary>
    /// The associated rule header range in the enclosing stylesheet (if
    /// available).
    /// </summary>
    public SourceRange? Range { get; init; }

    /// <summary>
    /// Identifier of the stylesheet containing this object (if exists).
    /// </summary>
    public DOM.StyleSheetId? StyleSheetId { get; init; }
}

/// <summary>
/// CSS Scope at-rule descriptor.
/// </summary>
/// <param name="Text">
/// Scope rule text.
/// </param>
public sealed record CSSScope(string Text)
{
    /// <summary>
    /// The associated rule header range in the enclosing stylesheet (if
    /// available).
    /// </summary>
    public SourceRange? Range { get; init; }

    /// <summary>
    /// Identifier of the stylesheet containing this object (if exists).
    /// </summary>
    public DOM.StyleSheetId? StyleSheetId { get; init; }
}

/// <summary>
/// CSS Layer at-rule descriptor.
/// </summary>
/// <param name="Text">
/// Layer name.
/// </param>
public sealed record CSSLayer(string Text)
{
    /// <summary>
    /// The associated rule header range in the enclosing stylesheet (if
    /// available).
    /// </summary>
    public SourceRange? Range { get; init; }

    /// <summary>
    /// Identifier of the stylesheet containing this object (if exists).
    /// </summary>
    public DOM.StyleSheetId? StyleSheetId { get; init; }
}

/// <summary>
/// CSS Starting Style at-rule descriptor.
/// </summary>
public sealed record CSSStartingStyle()
{
    /// <summary>
    /// The associated rule header range in the enclosing stylesheet (if
    /// available).
    /// </summary>
    public SourceRange? Range { get; init; }

    /// <summary>
    /// Identifier of the stylesheet containing this object (if exists).
    /// </summary>
    public DOM.StyleSheetId? StyleSheetId { get; init; }
}

/// <summary>
/// CSS Layer data.
/// </summary>
/// <param name="Name">
/// Layer name.
/// </param>
/// <param name="Order">
/// Layer order. The order determines the order of the layer in the cascade order.
/// A higher number has higher priority in the cascade order.
/// </param>
public sealed record CSSLayerData(string Name, double Order)
{
    /// <summary>
    /// Direct sub-layers
    /// </summary>
    public ImmutableArray<CSSLayerData>? SubLayers { get; init; }
}

/// <summary>
/// Information about amount of glyphs that were rendered with given font.
/// </summary>
/// <param name="FamilyName">
/// Font's family name reported by platform.
/// </param>
/// <param name="PostScriptName">
/// Font's PostScript name reported by platform.
/// </param>
/// <param name="IsCustomFont">
/// Indicates if the font was downloaded or resolved locally.
/// </param>
/// <param name="GlyphCount">
/// Amount of glyphs that were rendered with this font.
/// </param>
public sealed record PlatformFontUsage(string FamilyName, string PostScriptName, bool IsCustomFont, double GlyphCount)
{
}

/// <summary>
/// Information about font variation axes for variable fonts
/// </summary>
/// <param name="Tag">
/// The font-variation-setting tag (a.k.a. "axis tag").
/// </param>
/// <param name="Name">
/// Human-readable variation name in the default language (normally, "en").
/// </param>
/// <param name="MinValue">
/// The minimum value (inclusive) the font supports for this tag.
/// </param>
/// <param name="MaxValue">
/// The maximum value (inclusive) the font supports for this tag.
/// </param>
/// <param name="DefaultValue">
/// The default value.
/// </param>
public sealed record FontVariationAxis(string Tag, string Name, double MinValue, double MaxValue, double DefaultValue)
{
}

/// <summary>
/// Properties of a web font: https://www.w3.org/TR/2008/REC-CSS2-20080411/fonts.html#font-descriptions
/// and additional information such as platformFontFamily and fontVariationAxes.
/// </summary>
/// <param name="FontFamily">
/// The font-family.
/// </param>
/// <param name="FontStyle">
/// The font-style.
/// </param>
/// <param name="FontVariant">
/// The font-variant.
/// </param>
/// <param name="FontWeight">
/// The font-weight.
/// </param>
/// <param name="FontStretch">
/// The font-stretch.
/// </param>
/// <param name="FontDisplay">
/// The font-display.
/// </param>
/// <param name="UnicodeRange">
/// The unicode-range.
/// </param>
/// <param name="Src">
/// The src.
/// </param>
/// <param name="PlatformFontFamily">
/// The resolved platform font family
/// </param>
public sealed record FontFace(string FontFamily, string FontStyle, string FontVariant, string FontWeight, string FontStretch, string FontDisplay, string UnicodeRange, string Src, string PlatformFontFamily)
{
    /// <summary>
    /// Available variation settings (a.k.a. "axes").
    /// </summary>
    public ImmutableArray<FontVariationAxis>? FontVariationAxes { get; init; }
}

/// <summary>
/// CSS try rule representation.
/// </summary>
/// <param name="Origin">
/// Parent stylesheet's origin.
/// </param>
/// <param name="Style">
/// Associated style declaration.
/// </param>
public sealed record CSSTryRule(StyleSheetOrigin Origin, CSSStyle Style)
{
    /// <summary>
    /// The css style sheet identifier (absent for user agent stylesheet and user-specified
    /// stylesheet rules) this rule came from.
    /// </summary>
    public DOM.StyleSheetId? StyleSheetId { get; init; }
}

/// <summary>
/// CSS @position-try rule representation.
/// </summary>
/// <param name="Name">
/// The prelude dashed-ident name
/// </param>
/// <param name="Origin">
/// Parent stylesheet's origin.
/// </param>
/// <param name="Style">
/// Associated style declaration.
/// </param>
/// <param name="Active">
/// </param>
public sealed record CSSPositionTryRule(Value Name, StyleSheetOrigin Origin, CSSStyle Style, bool Active)
{
    /// <summary>
    /// The css style sheet identifier (absent for user agent stylesheet and user-specified
    /// stylesheet rules) this rule came from.
    /// </summary>
    public DOM.StyleSheetId? StyleSheetId { get; init; }
}

/// <summary>
/// CSS keyframes rule representation.
/// </summary>
/// <param name="AnimationName">
/// Animation name.
/// </param>
/// <param name="Keyframes">
/// List of keyframes.
/// </param>
public sealed record CSSKeyframesRule(Value AnimationName, ImmutableArray<CSSKeyframeRule> Keyframes)
{
}

/// <summary>
/// Representation of a custom property registration through CSS.registerProperty
/// </summary>
/// <param name="PropertyName">
/// </param>
/// <param name="Inherits">
/// </param>
/// <param name="Syntax">
/// </param>
public sealed record CSSPropertyRegistration(string PropertyName, bool Inherits, string Syntax)
{
    /// <summary>
    /// </summary>
    public Value? InitialValue { get; init; }
}

/// <summary>
/// CSS generic @rule representation.
/// </summary>
/// <param name="Type">
/// Type of at-rule.
/// </param>
/// <param name="Origin">
/// Parent stylesheet's origin.
/// </param>
/// <param name="Style">
/// Associated style declaration.
/// </param>
public sealed record CSSAtRule(string Type, StyleSheetOrigin Origin, CSSStyle Style)
{
    /// <summary>
    /// Subsection of font-feature-values, if this is a subsection.
    /// </summary>
    public string? Subsection { get; init; }

    /// <summary>
    /// LINT.ThenChange(//third_party/blink/renderer/core/inspector/inspector_style_sheet.cc:FontVariantAlternatesFeatureType,//third_party/blink/renderer/core/inspector/inspector_css_agent.cc:FontVariantAlternatesFeatureType)
    /// Associated name, if applicable.
    /// </summary>
    public Value? Name { get; init; }

    /// <summary>
    /// The css style sheet identifier (absent for user agent stylesheet and user-specified
    /// stylesheet rules) this rule came from.
    /// </summary>
    public DOM.StyleSheetId? StyleSheetId { get; init; }
}

/// <summary>
/// CSS property at-rule representation.
/// </summary>
/// <param name="Origin">
/// Parent stylesheet's origin.
/// </param>
/// <param name="PropertyName">
/// Associated property name.
/// </param>
/// <param name="Style">
/// Associated style declaration.
/// </param>
public sealed record CSSPropertyRule(StyleSheetOrigin Origin, Value PropertyName, CSSStyle Style)
{
    /// <summary>
    /// The css style sheet identifier (absent for user agent stylesheet and user-specified
    /// stylesheet rules) this rule came from.
    /// </summary>
    public DOM.StyleSheetId? StyleSheetId { get; init; }
}

/// <summary>
/// CSS function argument representation.
/// </summary>
/// <param name="Name">
/// The parameter name.
/// </param>
/// <param name="Type">
/// The parameter type.
/// </param>
public sealed record CSSFunctionParameter(string Name, string Type)
{
}

/// <summary>
/// CSS function conditional block representation.
/// </summary>
/// <param name="Children">
/// Block body.
/// </param>
/// <param name="ConditionText">
/// The condition text.
/// </param>
public sealed record CSSFunctionConditionNode(ImmutableArray<CSSFunctionNode> Children, string ConditionText)
{
    /// <summary>
    /// Media query for this conditional block. Only one type of condition should be set.
    /// </summary>
    public CSSMedia? Media { get; init; }

    /// <summary>
    /// Container query for this conditional block. Only one type of condition should be set.
    /// </summary>
    public CSSContainerQuery? ContainerQueries { get; init; }

    /// <summary>
    /// @supports CSS at-rule condition. Only one type of condition should be set.
    /// </summary>
    public CSSSupports? Supports { get; init; }

    /// <summary>
    /// @navigation condition. Only one type of condition should be set.
    /// </summary>
    public CSSNavigation? Navigation { get; init; }
}

/// <summary>
/// Section of the body of a CSS function rule.
/// </summary>
public sealed record CSSFunctionNode()
{
    /// <summary>
    /// A conditional block. If set, style should not be set.
    /// </summary>
    public CSSFunctionConditionNode? Condition { get; init; }

    /// <summary>
    /// Values set by this node. If set, condition should not be set.
    /// </summary>
    public CSSStyle? Style { get; init; }
}

/// <summary>
/// CSS function at-rule representation.
/// </summary>
/// <param name="Name">
/// Name of the function.
/// </param>
/// <param name="Origin">
/// Parent stylesheet's origin.
/// </param>
/// <param name="Parameters">
/// List of parameters.
/// </param>
/// <param name="Children">
/// Function body.
/// </param>
public sealed record CSSFunctionRule(Value Name, StyleSheetOrigin Origin, ImmutableArray<CSSFunctionParameter> Parameters, ImmutableArray<CSSFunctionNode> Children)
{
    /// <summary>
    /// The css style sheet identifier (absent for user agent stylesheet and user-specified
    /// stylesheet rules) this rule came from.
    /// </summary>
    public DOM.StyleSheetId? StyleSheetId { get; init; }

    /// <summary>
    /// The BackendNodeId of the DOM node that constitutes the origin tree scope of this rule.
    /// </summary>
    public DOM.BackendNodeId? OriginTreeScopeNodeId { get; init; }
}

/// <summary>
/// CSS keyframe rule representation.
/// </summary>
/// <param name="Origin">
/// Parent stylesheet's origin.
/// </param>
/// <param name="KeyText">
/// Associated key text.
/// </param>
/// <param name="Style">
/// Associated style declaration.
/// </param>
public sealed record CSSKeyframeRule(StyleSheetOrigin Origin, Value KeyText, CSSStyle Style)
{
    /// <summary>
    /// The css style sheet identifier (absent for user agent stylesheet and user-specified
    /// stylesheet rules) this rule came from.
    /// </summary>
    public DOM.StyleSheetId? StyleSheetId { get; init; }
}

/// <summary>
/// A descriptor of operation to mutate style declaration text.
/// </summary>
/// <param name="StyleSheetId">
/// The css style sheet identifier.
/// </param>
/// <param name="Range">
/// The range of the style text in the enclosing stylesheet.
/// </param>
/// <param name="Text">
/// New style text.
/// </param>
public sealed record StyleDeclarationEdit(DOM.StyleSheetId StyleSheetId, SourceRange Range, string Text)
{
}

[JsonSerializable(typeof(AddRuleCommandParameters), TypeInfoPropertyName = "AddRuleCommandParameters")]
[JsonSerializable(typeof(AddRuleResult), TypeInfoPropertyName = "AddRuleResult")]
[JsonSerializable(typeof(CollectClassNamesCommandParameters), TypeInfoPropertyName = "CollectClassNamesCommandParameters")]
[JsonSerializable(typeof(CollectClassNamesResult), TypeInfoPropertyName = "CollectClassNamesResult")]
[JsonSerializable(typeof(CreateStyleSheetCommandParameters), TypeInfoPropertyName = "CreateStyleSheetCommandParameters")]
[JsonSerializable(typeof(CreateStyleSheetResult), TypeInfoPropertyName = "CreateStyleSheetResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(ForcePseudoStateCommandParameters), TypeInfoPropertyName = "ForcePseudoStateCommandParameters")]
[JsonSerializable(typeof(ForcePseudoStateResult), TypeInfoPropertyName = "ForcePseudoStateResult")]
[JsonSerializable(typeof(ForceStartingStyleCommandParameters), TypeInfoPropertyName = "ForceStartingStyleCommandParameters")]
[JsonSerializable(typeof(ForceStartingStyleResult), TypeInfoPropertyName = "ForceStartingStyleResult")]
[JsonSerializable(typeof(GetBackgroundColorsCommandParameters), TypeInfoPropertyName = "GetBackgroundColorsCommandParameters")]
[JsonSerializable(typeof(GetBackgroundColorsResult), TypeInfoPropertyName = "GetBackgroundColorsResult")]
[JsonSerializable(typeof(GetComputedStyleForNodeCommandParameters), TypeInfoPropertyName = "GetComputedStyleForNodeCommandParameters")]
[JsonSerializable(typeof(GetComputedStyleForNodeResult), TypeInfoPropertyName = "GetComputedStyleForNodeResult")]
[JsonSerializable(typeof(ResolveValuesCommandParameters), TypeInfoPropertyName = "ResolveValuesCommandParameters")]
[JsonSerializable(typeof(ResolveValuesResult), TypeInfoPropertyName = "ResolveValuesResult")]
[JsonSerializable(typeof(GetLonghandPropertiesCommandParameters), TypeInfoPropertyName = "GetLonghandPropertiesCommandParameters")]
[JsonSerializable(typeof(GetLonghandPropertiesResult), TypeInfoPropertyName = "GetLonghandPropertiesResult")]
[JsonSerializable(typeof(GetInlineStylesForNodeCommandParameters), TypeInfoPropertyName = "GetInlineStylesForNodeCommandParameters")]
[JsonSerializable(typeof(GetInlineStylesForNodeResult), TypeInfoPropertyName = "GetInlineStylesForNodeResult")]
[JsonSerializable(typeof(GetAnimatedStylesForNodeCommandParameters), TypeInfoPropertyName = "GetAnimatedStylesForNodeCommandParameters")]
[JsonSerializable(typeof(GetAnimatedStylesForNodeResult), TypeInfoPropertyName = "GetAnimatedStylesForNodeResult")]
[JsonSerializable(typeof(GetMatchedStylesForNodeCommandParameters), TypeInfoPropertyName = "GetMatchedStylesForNodeCommandParameters")]
[JsonSerializable(typeof(GetMatchedStylesForNodeResult), TypeInfoPropertyName = "GetMatchedStylesForNodeResult")]
[JsonSerializable(typeof(GetEnvironmentVariablesCommandParameters), TypeInfoPropertyName = "GetEnvironmentVariablesCommandParameters")]
[JsonSerializable(typeof(GetEnvironmentVariablesResult), TypeInfoPropertyName = "GetEnvironmentVariablesResult")]
[JsonSerializable(typeof(GetMediaQueriesCommandParameters), TypeInfoPropertyName = "GetMediaQueriesCommandParameters")]
[JsonSerializable(typeof(GetMediaQueriesResult), TypeInfoPropertyName = "GetMediaQueriesResult")]
[JsonSerializable(typeof(GetPlatformFontsForNodeCommandParameters), TypeInfoPropertyName = "GetPlatformFontsForNodeCommandParameters")]
[JsonSerializable(typeof(GetPlatformFontsForNodeResult), TypeInfoPropertyName = "GetPlatformFontsForNodeResult")]
[JsonSerializable(typeof(GetStyleSheetTextCommandParameters), TypeInfoPropertyName = "GetStyleSheetTextCommandParameters")]
[JsonSerializable(typeof(GetStyleSheetTextResult), TypeInfoPropertyName = "GetStyleSheetTextResult")]
[JsonSerializable(typeof(GetLayersForNodeCommandParameters), TypeInfoPropertyName = "GetLayersForNodeCommandParameters")]
[JsonSerializable(typeof(GetLayersForNodeResult), TypeInfoPropertyName = "GetLayersForNodeResult")]
[JsonSerializable(typeof(GetLocationForSelectorCommandParameters), TypeInfoPropertyName = "GetLocationForSelectorCommandParameters")]
[JsonSerializable(typeof(GetLocationForSelectorResult), TypeInfoPropertyName = "GetLocationForSelectorResult")]
[JsonSerializable(typeof(TrackComputedStyleUpdatesForNodeCommandParameters), TypeInfoPropertyName = "TrackComputedStyleUpdatesForNodeCommandParameters")]
[JsonSerializable(typeof(TrackComputedStyleUpdatesForNodeResult), TypeInfoPropertyName = "TrackComputedStyleUpdatesForNodeResult")]
[JsonSerializable(typeof(TrackComputedStyleUpdatesCommandParameters), TypeInfoPropertyName = "TrackComputedStyleUpdatesCommandParameters")]
[JsonSerializable(typeof(TrackComputedStyleUpdatesResult), TypeInfoPropertyName = "TrackComputedStyleUpdatesResult")]
[JsonSerializable(typeof(TakeComputedStyleUpdatesCommandParameters), TypeInfoPropertyName = "TakeComputedStyleUpdatesCommandParameters")]
[JsonSerializable(typeof(TakeComputedStyleUpdatesResult), TypeInfoPropertyName = "TakeComputedStyleUpdatesResult")]
[JsonSerializable(typeof(SetEffectivePropertyValueForNodeCommandParameters), TypeInfoPropertyName = "SetEffectivePropertyValueForNodeCommandParameters")]
[JsonSerializable(typeof(SetEffectivePropertyValueForNodeResult), TypeInfoPropertyName = "SetEffectivePropertyValueForNodeResult")]
[JsonSerializable(typeof(SetPropertyRulePropertyNameCommandParameters), TypeInfoPropertyName = "SetPropertyRulePropertyNameCommandParameters")]
[JsonSerializable(typeof(SetPropertyRulePropertyNameResult), TypeInfoPropertyName = "SetPropertyRulePropertyNameResult")]
[JsonSerializable(typeof(SetKeyframeKeyCommandParameters), TypeInfoPropertyName = "SetKeyframeKeyCommandParameters")]
[JsonSerializable(typeof(SetKeyframeKeyResult), TypeInfoPropertyName = "SetKeyframeKeyResult")]
[JsonSerializable(typeof(SetMediaTextCommandParameters), TypeInfoPropertyName = "SetMediaTextCommandParameters")]
[JsonSerializable(typeof(SetMediaTextResult), TypeInfoPropertyName = "SetMediaTextResult")]
[JsonSerializable(typeof(SetContainerQueryTextCommandParameters), TypeInfoPropertyName = "SetContainerQueryTextCommandParameters")]
[JsonSerializable(typeof(SetContainerQueryTextResult), TypeInfoPropertyName = "SetContainerQueryTextResult")]
[JsonSerializable(typeof(SetContainerQueryConditionTextCommandParameters), TypeInfoPropertyName = "SetContainerQueryConditionTextCommandParameters")]
[JsonSerializable(typeof(SetContainerQueryConditionTextResult), TypeInfoPropertyName = "SetContainerQueryConditionTextResult")]
[JsonSerializable(typeof(SetSupportsTextCommandParameters), TypeInfoPropertyName = "SetSupportsTextCommandParameters")]
[JsonSerializable(typeof(SetSupportsTextResult), TypeInfoPropertyName = "SetSupportsTextResult")]
[JsonSerializable(typeof(SetNavigationTextCommandParameters), TypeInfoPropertyName = "SetNavigationTextCommandParameters")]
[JsonSerializable(typeof(SetNavigationTextResult), TypeInfoPropertyName = "SetNavigationTextResult")]
[JsonSerializable(typeof(SetScopeTextCommandParameters), TypeInfoPropertyName = "SetScopeTextCommandParameters")]
[JsonSerializable(typeof(SetScopeTextResult), TypeInfoPropertyName = "SetScopeTextResult")]
[JsonSerializable(typeof(SetRuleSelectorCommandParameters), TypeInfoPropertyName = "SetRuleSelectorCommandParameters")]
[JsonSerializable(typeof(SetRuleSelectorResult), TypeInfoPropertyName = "SetRuleSelectorResult")]
[JsonSerializable(typeof(SetStyleSheetTextCommandParameters), TypeInfoPropertyName = "SetStyleSheetTextCommandParameters")]
[JsonSerializable(typeof(SetStyleSheetTextResult), TypeInfoPropertyName = "SetStyleSheetTextResult")]
[JsonSerializable(typeof(SetStyleTextsCommandParameters), TypeInfoPropertyName = "SetStyleTextsCommandParameters")]
[JsonSerializable(typeof(SetStyleTextsResult), TypeInfoPropertyName = "SetStyleTextsResult")]
[JsonSerializable(typeof(StartRuleUsageTrackingCommandParameters), TypeInfoPropertyName = "StartRuleUsageTrackingCommandParameters")]
[JsonSerializable(typeof(StartRuleUsageTrackingResult), TypeInfoPropertyName = "StartRuleUsageTrackingResult")]
[JsonSerializable(typeof(StopRuleUsageTrackingCommandParameters), TypeInfoPropertyName = "StopRuleUsageTrackingCommandParameters")]
[JsonSerializable(typeof(StopRuleUsageTrackingResult), TypeInfoPropertyName = "StopRuleUsageTrackingResult")]
[JsonSerializable(typeof(TakeCoverageDeltaCommandParameters), TypeInfoPropertyName = "TakeCoverageDeltaCommandParameters")]
[JsonSerializable(typeof(TakeCoverageDeltaResult), TypeInfoPropertyName = "TakeCoverageDeltaResult")]
[JsonSerializable(typeof(SetLocalFontsEnabledCommandParameters), TypeInfoPropertyName = "SetLocalFontsEnabledCommandParameters")]
[JsonSerializable(typeof(SetLocalFontsEnabledResult), TypeInfoPropertyName = "SetLocalFontsEnabledResult")]
[JsonSerializable(typeof(CdpEventArgs<FontsUpdatedEventArgs>), TypeInfoPropertyName = "FontsUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<MediaQueryResultChangedEventArgs>), TypeInfoPropertyName = "MediaQueryResultChangedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<StyleSheetAddedEventArgs>), TypeInfoPropertyName = "StyleSheetAddedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<StyleSheetChangedEventArgs>), TypeInfoPropertyName = "StyleSheetChangedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<StyleSheetRemovedEventArgs>), TypeInfoPropertyName = "StyleSheetRemovedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ComputedStyleUpdatedEventArgs>), TypeInfoPropertyName = "ComputedStyleUpdatedCdpEventArgs")]
[JsonSerializable(typeof(StyleSheetOrigin), TypeInfoPropertyName = "CSSStyleSheetOrigin")]
[JsonSerializable(typeof(PseudoElementMatches), TypeInfoPropertyName = "CSSPseudoElementMatches")]
[JsonSerializable(typeof(CSSAnimationStyle), TypeInfoPropertyName = "CSSCSSAnimationStyle")]
[JsonSerializable(typeof(InheritedStyleEntry), TypeInfoPropertyName = "CSSInheritedStyleEntry")]
[JsonSerializable(typeof(InheritedAnimatedStyleEntry), TypeInfoPropertyName = "CSSInheritedAnimatedStyleEntry")]
[JsonSerializable(typeof(InheritedPseudoElementMatches), TypeInfoPropertyName = "CSSInheritedPseudoElementMatches")]
[JsonSerializable(typeof(RuleMatch), TypeInfoPropertyName = "CSSRuleMatch")]
[JsonSerializable(typeof(Value), TypeInfoPropertyName = "CSSValue")]
[JsonSerializable(typeof(SpecificityComponent), TypeInfoPropertyName = "CSSSpecificityComponent")]
[JsonSerializable(typeof(Specificity), TypeInfoPropertyName = "CSSSpecificity")]
[JsonSerializable(typeof(SelectorList), TypeInfoPropertyName = "CSSSelectorList")]
[JsonSerializable(typeof(CSSStyleSheetHeader), TypeInfoPropertyName = "CSSCSSStyleSheetHeader")]
[JsonSerializable(typeof(CSSRule), TypeInfoPropertyName = "CSSCSSRule")]
[JsonSerializable(typeof(CSSRuleType), TypeInfoPropertyName = "CSSCSSRuleType")]
[JsonSerializable(typeof(RuleUsage), TypeInfoPropertyName = "CSSRuleUsage")]
[JsonSerializable(typeof(SourceRange), TypeInfoPropertyName = "CSSSourceRange")]
[JsonSerializable(typeof(ShorthandEntry), TypeInfoPropertyName = "CSSShorthandEntry")]
[JsonSerializable(typeof(CSSComputedStyleProperty), TypeInfoPropertyName = "CSSCSSComputedStyleProperty")]
[JsonSerializable(typeof(ComputedStyleExtraFields), TypeInfoPropertyName = "CSSComputedStyleExtraFields")]
[JsonSerializable(typeof(CSSStyle), TypeInfoPropertyName = "CSSCSSStyle")]
[JsonSerializable(typeof(CSSProperty), TypeInfoPropertyName = "CSSCSSProperty")]
[JsonSerializable(typeof(CSSMedia), TypeInfoPropertyName = "CSSCSSMedia")]
[JsonSerializable(typeof(MediaQuery), TypeInfoPropertyName = "CSSMediaQuery")]
[JsonSerializable(typeof(MediaQueryExpression), TypeInfoPropertyName = "CSSMediaQueryExpression")]
[JsonSerializable(typeof(CSSContainerQuery), TypeInfoPropertyName = "CSSCSSContainerQuery")]
[JsonSerializable(typeof(CSSSupports), TypeInfoPropertyName = "CSSCSSSupports")]
[JsonSerializable(typeof(CSSNavigation), TypeInfoPropertyName = "CSSCSSNavigation")]
[JsonSerializable(typeof(CSSScope), TypeInfoPropertyName = "CSSCSSScope")]
[JsonSerializable(typeof(CSSLayer), TypeInfoPropertyName = "CSSCSSLayer")]
[JsonSerializable(typeof(CSSStartingStyle), TypeInfoPropertyName = "CSSCSSStartingStyle")]
[JsonSerializable(typeof(CSSLayerData), TypeInfoPropertyName = "CSSCSSLayerData")]
[JsonSerializable(typeof(PlatformFontUsage), TypeInfoPropertyName = "CSSPlatformFontUsage")]
[JsonSerializable(typeof(FontVariationAxis), TypeInfoPropertyName = "CSSFontVariationAxis")]
[JsonSerializable(typeof(FontFace), TypeInfoPropertyName = "CSSFontFace")]
[JsonSerializable(typeof(CSSTryRule), TypeInfoPropertyName = "CSSCSSTryRule")]
[JsonSerializable(typeof(CSSPositionTryRule), TypeInfoPropertyName = "CSSCSSPositionTryRule")]
[JsonSerializable(typeof(CSSKeyframesRule), TypeInfoPropertyName = "CSSCSSKeyframesRule")]
[JsonSerializable(typeof(CSSPropertyRegistration), TypeInfoPropertyName = "CSSCSSPropertyRegistration")]
[JsonSerializable(typeof(CSSAtRule), TypeInfoPropertyName = "CSSCSSAtRule")]
[JsonSerializable(typeof(CSSPropertyRule), TypeInfoPropertyName = "CSSCSSPropertyRule")]
[JsonSerializable(typeof(CSSFunctionParameter), TypeInfoPropertyName = "CSSCSSFunctionParameter")]
[JsonSerializable(typeof(CSSFunctionConditionNode), TypeInfoPropertyName = "CSSCSSFunctionConditionNode")]
[JsonSerializable(typeof(CSSFunctionNode), TypeInfoPropertyName = "CSSCSSFunctionNode")]
[JsonSerializable(typeof(CSSFunctionRule), TypeInfoPropertyName = "CSSCSSFunctionRule")]
[JsonSerializable(typeof(CSSKeyframeRule), TypeInfoPropertyName = "CSSCSSKeyframeRule")]
[JsonSerializable(typeof(StyleDeclarationEdit), TypeInfoPropertyName = "CSSStyleDeclarationEdit")]
[JsonSerializable(typeof(ImmutableArray<CSSComputedStyleProperty>), TypeInfoPropertyName = "ImmutableArrayCSSCSSComputedStyleProperty")]
[JsonSerializable(typeof(ImmutableArray<CSSProperty>), TypeInfoPropertyName = "ImmutableArrayCSSCSSProperty")]
[JsonSerializable(typeof(ImmutableArray<CSSAnimationStyle>), TypeInfoPropertyName = "ImmutableArrayCSSCSSAnimationStyle")]
[JsonSerializable(typeof(ImmutableArray<InheritedAnimatedStyleEntry>), TypeInfoPropertyName = "ImmutableArrayCSSInheritedAnimatedStyleEntry")]
[JsonSerializable(typeof(ImmutableArray<RuleMatch>), TypeInfoPropertyName = "ImmutableArrayCSSRuleMatch")]
[JsonSerializable(typeof(ImmutableArray<PseudoElementMatches>), TypeInfoPropertyName = "ImmutableArrayCSSPseudoElementMatches")]
[JsonSerializable(typeof(ImmutableArray<InheritedStyleEntry>), TypeInfoPropertyName = "ImmutableArrayCSSInheritedStyleEntry")]
[JsonSerializable(typeof(ImmutableArray<InheritedPseudoElementMatches>), TypeInfoPropertyName = "ImmutableArrayCSSInheritedPseudoElementMatches")]
[JsonSerializable(typeof(ImmutableArray<CSSKeyframesRule>), TypeInfoPropertyName = "ImmutableArrayCSSCSSKeyframesRule")]
[JsonSerializable(typeof(ImmutableArray<CSSPositionTryRule>), TypeInfoPropertyName = "ImmutableArrayCSSCSSPositionTryRule")]
[JsonSerializable(typeof(ImmutableArray<CSSPropertyRule>), TypeInfoPropertyName = "ImmutableArrayCSSCSSPropertyRule")]
[JsonSerializable(typeof(ImmutableArray<CSSPropertyRegistration>), TypeInfoPropertyName = "ImmutableArrayCSSCSSPropertyRegistration")]
[JsonSerializable(typeof(ImmutableArray<CSSAtRule>), TypeInfoPropertyName = "ImmutableArrayCSSCSSAtRule")]
[JsonSerializable(typeof(ImmutableArray<CSSFunctionRule>), TypeInfoPropertyName = "ImmutableArrayCSSCSSFunctionRule")]
[JsonSerializable(typeof(ImmutableArray<CSSMedia>), TypeInfoPropertyName = "ImmutableArrayCSSCSSMedia")]
[JsonSerializable(typeof(ImmutableArray<PlatformFontUsage>), TypeInfoPropertyName = "ImmutableArrayCSSPlatformFontUsage")]
[JsonSerializable(typeof(ImmutableArray<SourceRange>), TypeInfoPropertyName = "ImmutableArrayCSSSourceRange")]
[JsonSerializable(typeof(ImmutableArray<DOM.NodeId>), TypeInfoPropertyName = "ImmutableArrayDOMNodeId")]
[JsonSerializable(typeof(ImmutableArray<StyleDeclarationEdit>), TypeInfoPropertyName = "ImmutableArrayCSSStyleDeclarationEdit")]
[JsonSerializable(typeof(ImmutableArray<CSSStyle>), TypeInfoPropertyName = "ImmutableArrayCSSCSSStyle")]
[JsonSerializable(typeof(ImmutableArray<RuleUsage>), TypeInfoPropertyName = "ImmutableArrayCSSRuleUsage")]
[JsonSerializable(typeof(ImmutableArray<SpecificityComponent>), TypeInfoPropertyName = "ImmutableArrayCSSSpecificityComponent")]
[JsonSerializable(typeof(ImmutableArray<Value>), TypeInfoPropertyName = "ImmutableArrayCSSValue")]
[JsonSerializable(typeof(ImmutableArray<CSSContainerQuery>), TypeInfoPropertyName = "ImmutableArrayCSSCSSContainerQuery")]
[JsonSerializable(typeof(ImmutableArray<CSSSupports>), TypeInfoPropertyName = "ImmutableArrayCSSCSSSupports")]
[JsonSerializable(typeof(ImmutableArray<CSSLayer>), TypeInfoPropertyName = "ImmutableArrayCSSCSSLayer")]
[JsonSerializable(typeof(ImmutableArray<CSSScope>), TypeInfoPropertyName = "ImmutableArrayCSSCSSScope")]
[JsonSerializable(typeof(ImmutableArray<CSSRuleType>), TypeInfoPropertyName = "ImmutableArrayCSSCSSRuleType")]
[JsonSerializable(typeof(ImmutableArray<CSSStartingStyle>), TypeInfoPropertyName = "ImmutableArrayCSSCSSStartingStyle")]
[JsonSerializable(typeof(ImmutableArray<CSSNavigation>), TypeInfoPropertyName = "ImmutableArrayCSSCSSNavigation")]
[JsonSerializable(typeof(ImmutableArray<ShorthandEntry>), TypeInfoPropertyName = "ImmutableArrayCSSShorthandEntry")]
[JsonSerializable(typeof(ImmutableArray<MediaQuery>), TypeInfoPropertyName = "ImmutableArrayCSSMediaQuery")]
[JsonSerializable(typeof(ImmutableArray<MediaQueryExpression>), TypeInfoPropertyName = "ImmutableArrayCSSMediaQueryExpression")]
[JsonSerializable(typeof(ImmutableArray<CSSLayerData>), TypeInfoPropertyName = "ImmutableArrayCSSCSSLayerData")]
[JsonSerializable(typeof(ImmutableArray<FontVariationAxis>), TypeInfoPropertyName = "ImmutableArrayCSSFontVariationAxis")]
[JsonSerializable(typeof(ImmutableArray<CSSKeyframeRule>), TypeInfoPropertyName = "ImmutableArrayCSSCSSKeyframeRule")]
[JsonSerializable(typeof(ImmutableArray<CSSFunctionNode>), TypeInfoPropertyName = "ImmutableArrayCSSCSSFunctionNode")]
[JsonSerializable(typeof(ImmutableArray<CSSFunctionParameter>), TypeInfoPropertyName = "ImmutableArrayCSSCSSFunctionParameter")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class CSSJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="CSSDomain"/>.
/// </summary>
public static class CSSDomainEvent
{
    /// <summary>
    /// Fires whenever a web font is updated.  A non-empty font parameter indicates a successfully loaded
    /// web font.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FontsUpdatedEventArgs>> FontsUpdated { get; } =
        EventDescriptor<CdpEventArgs<FontsUpdatedEventArgs>>.Create(
            "goog:cdp.CSS.fontsUpdated",
            CSSJsonSerializerContext.Default.FontsUpdatedCdpEventArgs);

    /// <summary>
    /// Fires whenever a MediaQuery result changes (for example, after a browser window has been
    /// resized.) The current implementation considers only viewport-dependent media features.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<MediaQueryResultChangedEventArgs>> MediaQueryResultChanged { get; } =
        EventDescriptor<CdpEventArgs<MediaQueryResultChangedEventArgs>>.Create(
            "goog:cdp.CSS.mediaQueryResultChanged",
            CSSJsonSerializerContext.Default.MediaQueryResultChangedCdpEventArgs);

    /// <summary>
    /// Fired whenever an active document stylesheet is added.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<StyleSheetAddedEventArgs>> StyleSheetAdded { get; } =
        EventDescriptor<CdpEventArgs<StyleSheetAddedEventArgs>>.Create(
            "goog:cdp.CSS.styleSheetAdded",
            CSSJsonSerializerContext.Default.StyleSheetAddedCdpEventArgs);

    /// <summary>
    /// Fired whenever a stylesheet is changed as a result of the client operation.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<StyleSheetChangedEventArgs>> StyleSheetChanged { get; } =
        EventDescriptor<CdpEventArgs<StyleSheetChangedEventArgs>>.Create(
            "goog:cdp.CSS.styleSheetChanged",
            CSSJsonSerializerContext.Default.StyleSheetChangedCdpEventArgs);

    /// <summary>
    /// Fired whenever an active document stylesheet is removed.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<StyleSheetRemovedEventArgs>> StyleSheetRemoved { get; } =
        EventDescriptor<CdpEventArgs<StyleSheetRemovedEventArgs>>.Create(
            "goog:cdp.CSS.styleSheetRemoved",
            CSSJsonSerializerContext.Default.StyleSheetRemovedCdpEventArgs);

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ComputedStyleUpdatedEventArgs>> ComputedStyleUpdated { get; } =
        EventDescriptor<CdpEventArgs<ComputedStyleUpdatedEventArgs>>.Create(
            "goog:cdp.CSS.computedStyleUpdated",
            CSSJsonSerializerContext.Default.ComputedStyleUpdatedCdpEventArgs);

}
