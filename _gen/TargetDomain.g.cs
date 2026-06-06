#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Target;

/// <summary>
/// Supports additional targets discovery and allows to attach to them.
/// </summary>
public sealed class TargetDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static TargetJsonSerializerContext JsonContext = TargetJsonSerializerContext.Default;

    /// <summary>
    /// Activates (focuses) the target.
    /// </summary>
    /// <param name="targetId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ActivateTargetCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ActivateTargetResult"/>.
    /// </returns>
    public async Task<ActivateTargetResult> ActivateTargetAsync(TargetID targetId, ActivateTargetCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ActivateTargetCommandParameters(TargetId: targetId);
        return await ExecuteCommandAsync(ActivateTargetCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ActivateTargetCommandParameters, ActivateTargetResult> ActivateTargetCommand = new("Target.activateTarget", JsonContext.ActivateTargetCommandParameters, JsonContext.ActivateTargetResult);

    /// <summary>
    /// Attaches to the target with given id.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Flatten</b> - Enables "flat" access to the session via specifying sessionId attribute in the commands. We plan to make this the default, deprecate non-flattened mode, and eventually retire it. See crbug.com/991325.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="targetId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="AttachToTargetCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AttachToTargetResult"/>.
    /// </returns>
    public async Task<AttachToTargetResult> AttachToTargetAsync(TargetID targetId, AttachToTargetCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new AttachToTargetCommandParameters(TargetId: targetId, Flatten: options?.Flatten);
        return await ExecuteCommandAsync(AttachToTargetCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AttachToTargetCommandParameters, AttachToTargetResult> AttachToTargetCommand = new("Target.attachToTarget", JsonContext.AttachToTargetCommandParameters, JsonContext.AttachToTargetResult);

    /// <summary>
    /// Attaches to the browser target, only uses flat sessionId mode.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="AttachToBrowserTargetCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AttachToBrowserTargetResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<AttachToBrowserTargetResult> AttachToBrowserTargetAsync(AttachToBrowserTargetCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new AttachToBrowserTargetCommandParameters();
        return await ExecuteCommandAsync(AttachToBrowserTargetCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AttachToBrowserTargetCommandParameters, AttachToBrowserTargetResult> AttachToBrowserTargetCommand = new("Target.attachToBrowserTarget", JsonContext.AttachToBrowserTargetCommandParameters, JsonContext.AttachToBrowserTargetResult);

    /// <summary>
    /// Closes the target. If the target is a page that gets closed too.
    /// </summary>
    /// <param name="targetId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="CloseTargetCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CloseTargetResult"/>.
    /// </returns>
    public async Task<CloseTargetResult> CloseTargetAsync(TargetID targetId, CloseTargetCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new CloseTargetCommandParameters(TargetId: targetId);
        return await ExecuteCommandAsync(CloseTargetCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CloseTargetCommandParameters, CloseTargetResult> CloseTargetCommand = new("Target.closeTarget", JsonContext.CloseTargetCommandParameters, JsonContext.CloseTargetResult);

    /// <summary>
    /// Inject object to the target's main frame that provides a communication
    /// channel with browser target.
    /// 
    /// Injected object will be available as <b>window[bindingName]</b>.
    /// 
    /// The object has the following API:
    /// - <b>binding.send(json)</b> - a method to send messages over the remote debugging protocol
    /// - <b>binding.onmessage = json =&gt; handleMessage(json)</b> - a callback that will be called for the protocol notifications and command responses.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>BindingName</b> - Binding name, 'cdp' if not specified.</description></item>
    /// <item><description><b>InheritPermissions</b> - If true, inherits the current root session's permissions (default: false).</description></item>
    /// </list>
    /// </remarks>
    /// <param name="targetId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ExposeDevToolsProtocolCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ExposeDevToolsProtocolResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<ExposeDevToolsProtocolResult> ExposeDevToolsProtocolAsync(TargetID targetId, ExposeDevToolsProtocolCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ExposeDevToolsProtocolCommandParameters(TargetId: targetId, BindingName: options?.BindingName, InheritPermissions: options?.InheritPermissions);
        return await ExecuteCommandAsync(ExposeDevToolsProtocolCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ExposeDevToolsProtocolCommandParameters, ExposeDevToolsProtocolResult> ExposeDevToolsProtocolCommand = new("Target.exposeDevToolsProtocol", JsonContext.ExposeDevToolsProtocolCommandParameters, JsonContext.ExposeDevToolsProtocolResult);

    /// <summary>
    /// Creates a new empty BrowserContext. Similar to an incognito profile but you can have more than
    /// one.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>DisposeOnDetach</b> - If specified, disposes this context when debugging session disconnects.</description></item>
    /// <item><description><b>ProxyServer</b> - Proxy server, similar to the one passed to --proxy-server</description></item>
    /// <item><description><b>ProxyBypassList</b> - Proxy bypass list, similar to the one passed to --proxy-bypass-list</description></item>
    /// <item><description><b>OriginsWithUniversalNetworkAccess</b> - An optional list of origins to grant unlimited cross-origin access to. Parts of the URL other than those constituting origin are ignored.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="CreateBrowserContextCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CreateBrowserContextResult"/>.
    /// </returns>
    public async Task<CreateBrowserContextResult> CreateBrowserContextAsync(CreateBrowserContextCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new CreateBrowserContextCommandParameters(DisposeOnDetach: options?.DisposeOnDetach, ProxyServer: options?.ProxyServer, ProxyBypassList: options?.ProxyBypassList, OriginsWithUniversalNetworkAccess: options?.OriginsWithUniversalNetworkAccess);
        return await ExecuteCommandAsync(CreateBrowserContextCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CreateBrowserContextCommandParameters, CreateBrowserContextResult> CreateBrowserContextCommand = new("Target.createBrowserContext", JsonContext.CreateBrowserContextCommandParameters, JsonContext.CreateBrowserContextResult);

    /// <summary>
    /// Returns all browser contexts created with <b>Target.createBrowserContext</b> method.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetBrowserContextsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetBrowserContextsResult"/>.
    /// </returns>
    public async Task<GetBrowserContextsResult> GetBrowserContextsAsync(GetBrowserContextsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetBrowserContextsCommandParameters();
        return await ExecuteCommandAsync(GetBrowserContextsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetBrowserContextsCommandParameters, GetBrowserContextsResult> GetBrowserContextsCommand = new("Target.getBrowserContexts", JsonContext.GetBrowserContextsCommandParameters, JsonContext.GetBrowserContextsResult);

    /// <summary>
    /// Creates a new page.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Left</b> - Frame left origin in DIP (requires newWindow to be true or headless shell).</description></item>
    /// <item><description><b>Top</b> - Frame top origin in DIP (requires newWindow to be true or headless shell).</description></item>
    /// <item><description><b>Width</b> - Frame width in DIP (requires newWindow to be true or headless shell).</description></item>
    /// <item><description><b>Height</b> - Frame height in DIP (requires newWindow to be true or headless shell).</description></item>
    /// <item><description><b>WindowState</b> - Frame window state (requires newWindow to be true or headless shell). Default is normal.</description></item>
    /// <item><description><b>BrowserContextId</b> - The browser context to create the page in.</description></item>
    /// <item><description><b>EnableBeginFrameControl</b> - Whether BeginFrames for this target will be controlled via DevTools (headless shell only, not supported on MacOS yet, false by default).</description></item>
    /// <item><description><b>NewWindow</b> - Whether to create a new Window or Tab (false by default, not supported by headless shell).</description></item>
    /// <item><description><b>Background</b> - Whether to create the target in background or foreground (false by default, not supported by headless shell).</description></item>
    /// <item><description><b>ForTab</b> - Whether to create the target of type "tab".</description></item>
    /// <item><description><b>Hidden</b> - Whether to create a hidden target. The hidden target is observable via protocol, but not present in the tab UI strip. Cannot be created with <b>forTab: true</b>, <b>newWindow: true</b> or <b>background: false</b>. The life-time of the tab is limited to the life-time of the session.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="url">
    /// The initial URL the page will be navigated to. An empty string indicates about:blank.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="CreateTargetCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CreateTargetResult"/>.
    /// </returns>
    public async Task<CreateTargetResult> CreateTargetAsync(string url, CreateTargetCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new CreateTargetCommandParameters(Url: url, Left: options?.Left, Top: options?.Top, Width: options?.Width, Height: options?.Height, WindowState: options?.WindowState, BrowserContextId: options?.BrowserContextId, EnableBeginFrameControl: options?.EnableBeginFrameControl, NewWindow: options?.NewWindow, Background: options?.Background, ForTab: options?.ForTab, Hidden: options?.Hidden);
        return await ExecuteCommandAsync(CreateTargetCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CreateTargetCommandParameters, CreateTargetResult> CreateTargetCommand = new("Target.createTarget", JsonContext.CreateTargetCommandParameters, JsonContext.CreateTargetResult);

    /// <summary>
    /// Detaches session with given id.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>SessionId</b> - Session to detach.</description></item>
    /// <item><description><b>TargetId</b> - Deprecated.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="DetachFromTargetCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DetachFromTargetResult"/>.
    /// </returns>
    public async Task<DetachFromTargetResult> DetachFromTargetAsync(DetachFromTargetCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new DetachFromTargetCommandParameters(SessionId: options?.SessionId, TargetId: options?.TargetId);
        return await ExecuteCommandAsync(DetachFromTargetCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DetachFromTargetCommandParameters, DetachFromTargetResult> DetachFromTargetCommand = new("Target.detachFromTarget", JsonContext.DetachFromTargetCommandParameters, JsonContext.DetachFromTargetResult);

    /// <summary>
    /// Deletes a BrowserContext. All the belonging pages will be closed without calling their
    /// beforeunload hooks.
    /// </summary>
    /// <param name="browserContextId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="DisposeBrowserContextCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DisposeBrowserContextResult"/>.
    /// </returns>
    public async Task<DisposeBrowserContextResult> DisposeBrowserContextAsync(Browser.BrowserContextID browserContextId, DisposeBrowserContextCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisposeBrowserContextCommandParameters(BrowserContextId: browserContextId);
        return await ExecuteCommandAsync(DisposeBrowserContextCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DisposeBrowserContextCommandParameters, DisposeBrowserContextResult> DisposeBrowserContextCommand = new("Target.disposeBrowserContext", JsonContext.DisposeBrowserContextCommandParameters, JsonContext.DisposeBrowserContextResult);

    /// <summary>
    /// Returns information about a target.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>TargetId</b></description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetTargetInfoCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetTargetInfoResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetTargetInfoResult> GetTargetInfoAsync(GetTargetInfoCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetTargetInfoCommandParameters(TargetId: options?.TargetId);
        return await ExecuteCommandAsync(GetTargetInfoCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetTargetInfoCommandParameters, GetTargetInfoResult> GetTargetInfoCommand = new("Target.getTargetInfo", JsonContext.GetTargetInfoCommandParameters, JsonContext.GetTargetInfoResult);

    /// <summary>
    /// Retrieves a list of available targets.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Filter</b> - Only targets matching filter will be reported. If filter is not specified and target discovery is currently enabled, a filter used for target discovery is used for consistency.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetTargetsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetTargetsResult"/>.
    /// </returns>
    public async Task<GetTargetsResult> GetTargetsAsync(GetTargetsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetTargetsCommandParameters(Filter: options?.Filter);
        return await ExecuteCommandAsync(GetTargetsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetTargetsCommandParameters, GetTargetsResult> GetTargetsCommand = new("Target.getTargets", JsonContext.GetTargetsCommandParameters, JsonContext.GetTargetsResult);

    /// <summary>
    /// Sends protocol message over session with given id.
    /// Consider using flat mode instead; see commands attachToTarget, setAutoAttach,
    /// and crbug.com/991325.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>SessionId</b> - Identifier of the session.</description></item>
    /// <item><description><b>TargetId</b> - Deprecated.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="message">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SendMessageToTargetCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SendMessageToTargetResult"/>.
    /// </returns>
    [global::System.Obsolete]
    public async Task<SendMessageToTargetResult> SendMessageToTargetAsync(string message, SendMessageToTargetCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SendMessageToTargetCommandParameters(Message: message, SessionId: options?.SessionId, TargetId: options?.TargetId);
        return await ExecuteCommandAsync(SendMessageToTargetCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SendMessageToTargetCommandParameters, SendMessageToTargetResult> SendMessageToTargetCommand = new("Target.sendMessageToTarget", JsonContext.SendMessageToTargetCommandParameters, JsonContext.SendMessageToTargetResult);

    /// <summary>
    /// Controls whether to automatically attach to new targets which are considered
    /// to be directly related to this one (for example, iframes or workers).
    /// When turned on, attaches to all existing related targets as well. When turned off,
    /// automatically detaches from all currently attached targets.
    /// This also clears all targets added by <b>autoAttachRelated</b> from the list of targets to watch
    /// for creation of related targets.
    /// You might want to call this recursively for auto-attached targets to attach
    /// to all available targets.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Flatten</b> - Enables "flat" access to the session via specifying sessionId attribute in the commands. We plan to make this the default, deprecate non-flattened mode, and eventually retire it. See crbug.com/991325.</description></item>
    /// <item><description><b>Filter</b> - Only targets matching filter will be attached.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="autoAttach">
    /// Whether to auto-attach to related targets.
    /// </param>
    /// <param name="waitForDebuggerOnStart">
    /// Whether to pause new targets when attaching to them. Use <b>Runtime.runIfWaitingForDebugger</b>
    /// to run paused targets.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetAutoAttachCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetAutoAttachResult"/>.
    /// </returns>
    public async Task<SetAutoAttachResult> SetAutoAttachAsync(bool autoAttach, bool waitForDebuggerOnStart, SetAutoAttachCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetAutoAttachCommandParameters(AutoAttach: autoAttach, WaitForDebuggerOnStart: waitForDebuggerOnStart, Flatten: options?.Flatten, Filter: options?.Filter);
        return await ExecuteCommandAsync(SetAutoAttachCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetAutoAttachCommandParameters, SetAutoAttachResult> SetAutoAttachCommand = new("Target.setAutoAttach", JsonContext.SetAutoAttachCommandParameters, JsonContext.SetAutoAttachResult);

    /// <summary>
    /// Adds the specified target to the list of targets that will be monitored for any related target
    /// creation (such as child frames, child workers and new versions of service worker) and reported
    /// through <b>attachedToTarget</b>. The specified target is also auto-attached.
    /// This cancels the effect of any previous <b>setAutoAttach</b> and is also cancelled by subsequent
    /// <b>setAutoAttach</b>. Only available at the Browser target.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Filter</b> - Only targets matching filter will be attached.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="targetId">
    /// </param>
    /// <param name="waitForDebuggerOnStart">
    /// Whether to pause new targets when attaching to them. Use <b>Runtime.runIfWaitingForDebugger</b>
    /// to run paused targets.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="AutoAttachRelatedCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AutoAttachRelatedResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<AutoAttachRelatedResult> AutoAttachRelatedAsync(TargetID targetId, bool waitForDebuggerOnStart, AutoAttachRelatedCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new AutoAttachRelatedCommandParameters(TargetId: targetId, WaitForDebuggerOnStart: waitForDebuggerOnStart, Filter: options?.Filter);
        return await ExecuteCommandAsync(AutoAttachRelatedCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AutoAttachRelatedCommandParameters, AutoAttachRelatedResult> AutoAttachRelatedCommand = new("Target.autoAttachRelated", JsonContext.AutoAttachRelatedCommandParameters, JsonContext.AutoAttachRelatedResult);

    /// <summary>
    /// Controls whether to discover available targets and notify via
    /// <b>targetCreated/targetInfoChanged/targetDestroyed</b> events.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Filter</b> - Only targets matching filter will be attached. If <b>discover</b> is false, <b>filter</b> must be omitted or empty.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="discover">
    /// Whether to discover available targets.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetDiscoverTargetsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetDiscoverTargetsResult"/>.
    /// </returns>
    public async Task<SetDiscoverTargetsResult> SetDiscoverTargetsAsync(bool discover, SetDiscoverTargetsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetDiscoverTargetsCommandParameters(Discover: discover, Filter: options?.Filter);
        return await ExecuteCommandAsync(SetDiscoverTargetsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetDiscoverTargetsCommandParameters, SetDiscoverTargetsResult> SetDiscoverTargetsCommand = new("Target.setDiscoverTargets", JsonContext.SetDiscoverTargetsCommandParameters, JsonContext.SetDiscoverTargetsResult);

    /// <summary>
    /// Enables target discovery for the specified locations, when <b>setDiscoverTargets</b> was set to
    /// <b>true</b>.
    /// </summary>
    /// <param name="locations">
    /// List of remote locations.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetRemoteLocationsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetRemoteLocationsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetRemoteLocationsResult> SetRemoteLocationsAsync(IEnumerable<RemoteLocation> locations, SetRemoteLocationsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetRemoteLocationsCommandParameters(Locations: locations);
        return await ExecuteCommandAsync(SetRemoteLocationsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetRemoteLocationsCommandParameters, SetRemoteLocationsResult> SetRemoteLocationsCommand = new("Target.setRemoteLocations", JsonContext.SetRemoteLocationsCommandParameters, JsonContext.SetRemoteLocationsResult);

    /// <summary>
    /// Issued when attached to target because of auto-attach or <b>attachToTarget</b> command.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="AttachedToTargetEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>SessionId</b> - Identifier assigned to the session used to send/receive messages.</description></item>
    /// <item><description><b>TargetInfo</b></description></item>
    /// <item><description><b>WaitingForDebugger</b></description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<AttachedToTargetEventArgs> AttachedToTarget => CreateCdpEventSource(TargetDomainEvent.AttachedToTarget);
    /// <summary>
    /// Issued when detached from target for any reason (including <b>detachFromTarget</b> command). Can be
    /// issued multiple times per target if multiple sessions have been attached to it.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DetachedFromTargetEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>SessionId</b> - Detached session identifier.</description></item>
    /// <item><description><b>TargetId</b> - Deprecated.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DetachedFromTargetEventArgs> DetachedFromTarget => CreateCdpEventSource(TargetDomainEvent.DetachedFromTarget);
    /// <summary>
    /// Notifies about a new protocol message received from the session (as reported in
    /// <b>attachedToTarget</b> event).
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ReceivedMessageFromTargetEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>SessionId</b> - Identifier of a session which sends a message.</description></item>
    /// <item><description><b>Message</b></description></item>
    /// <item><description><b>TargetId</b> - Deprecated.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ReceivedMessageFromTargetEventArgs> ReceivedMessageFromTarget => CreateCdpEventSource(TargetDomainEvent.ReceivedMessageFromTarget);
    /// <summary>
    /// Issued when a possible inspection target is created.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="TargetCreatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>TargetInfo</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<TargetCreatedEventArgs> TargetCreated => CreateCdpEventSource(TargetDomainEvent.TargetCreated);
    /// <summary>
    /// Issued when a target is destroyed.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="TargetDestroyedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>TargetId</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<TargetDestroyedEventArgs> TargetDestroyed => CreateCdpEventSource(TargetDomainEvent.TargetDestroyed);
    /// <summary>
    /// Issued when a target has crashed.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="TargetCrashedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>TargetId</b></description></item>
    /// <item><description><b>Status</b> - Termination status type.</description></item>
    /// <item><description><b>ErrorCode</b> - Termination error code.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<TargetCrashedEventArgs> TargetCrashed => CreateCdpEventSource(TargetDomainEvent.TargetCrashed);
    /// <summary>
    /// Issued when some information about a target has changed. This only happens between
    /// <b>targetCreated</b> and <b>targetDestroyed</b>.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="TargetInfoChangedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>TargetInfo</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<TargetInfoChangedEventArgs> TargetInfoChanged => CreateCdpEventSource(TargetDomainEvent.TargetInfoChanged);
}

internal sealed record ActivateTargetCommandParameters(TargetID TargetId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="TargetDomain.ActivateTargetAsync"/>.
/// </summary>
public sealed record ActivateTargetCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ActivateTargetResult() : EmptyResult;


internal sealed record AttachToTargetCommandParameters(TargetID TargetId, bool? Flatten) : Parameters;

/// <summary>
/// Optional parameters for <see cref="TargetDomain.AttachToTargetAsync"/>.
/// </summary>
public sealed record AttachToTargetCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Enables "flat" access to the session via specifying sessionId attribute in the commands.
    /// We plan to make this the default, deprecate non-flattened mode,
    /// and eventually retire it. See crbug.com/991325.
    /// </summary>
    public bool? Flatten { get; init; }
}

/// <summary>
/// </summary>
/// <param name="SessionId">
/// Id assigned to the session.
/// </param>
public sealed record AttachToTargetResult(SessionID SessionId) : EmptyResult;


internal sealed record AttachToBrowserTargetCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="TargetDomain.AttachToBrowserTargetAsync"/>.
/// </summary>
public sealed record AttachToBrowserTargetCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="SessionId">
/// Id assigned to the session.
/// </param>
public sealed record AttachToBrowserTargetResult(SessionID SessionId) : EmptyResult;


internal sealed record CloseTargetCommandParameters(TargetID TargetId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="TargetDomain.CloseTargetAsync"/>.
/// </summary>
public sealed record CloseTargetCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Success">
/// Always set to true. If an error occurs, the response indicates protocol error.
/// </param>
public sealed record CloseTargetResult(bool Success) : EmptyResult;


internal sealed record ExposeDevToolsProtocolCommandParameters(TargetID TargetId, string? BindingName, bool? InheritPermissions) : Parameters;

/// <summary>
/// Optional parameters for <see cref="TargetDomain.ExposeDevToolsProtocolAsync"/>.
/// </summary>
public sealed record ExposeDevToolsProtocolCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Binding name, 'cdp' if not specified.
    /// </summary>
    public string? BindingName { get; init; }

    /// <summary>
    /// If true, inherits the current root session's permissions (default: false).
    /// </summary>
    public bool? InheritPermissions { get; init; }
}

/// <summary>
/// </summary>
public sealed record ExposeDevToolsProtocolResult() : EmptyResult;


internal sealed record CreateBrowserContextCommandParameters(bool? DisposeOnDetach, string? ProxyServer, string? ProxyBypassList, IEnumerable<string>? OriginsWithUniversalNetworkAccess) : Parameters;

/// <summary>
/// Optional parameters for <see cref="TargetDomain.CreateBrowserContextAsync"/>.
/// </summary>
public sealed record CreateBrowserContextCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// If specified, disposes this context when debugging session disconnects.
    /// </summary>
    public bool? DisposeOnDetach { get; init; }

    /// <summary>
    /// Proxy server, similar to the one passed to --proxy-server
    /// </summary>
    public string? ProxyServer { get; init; }

    /// <summary>
    /// Proxy bypass list, similar to the one passed to --proxy-bypass-list
    /// </summary>
    public string? ProxyBypassList { get; init; }

    /// <summary>
    /// An optional list of origins to grant unlimited cross-origin access to.
    /// Parts of the URL other than those constituting origin are ignored.
    /// </summary>
    public IEnumerable<string>? OriginsWithUniversalNetworkAccess { get; init; }
}

/// <summary>
/// </summary>
/// <param name="BrowserContextId">
/// The id of the context created.
/// </param>
public sealed record CreateBrowserContextResult(Browser.BrowserContextID BrowserContextId) : EmptyResult;


internal sealed record GetBrowserContextsCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="TargetDomain.GetBrowserContextsAsync"/>.
/// </summary>
public sealed record GetBrowserContextsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="BrowserContextIds">
/// An array of browser context ids.
/// </param>
public sealed record GetBrowserContextsResult(IReadOnlyList<Browser.BrowserContextID> BrowserContextIds) : EmptyResult;


internal sealed record CreateTargetCommandParameters(string Url, long? Left, long? Top, long? Width, long? Height, WindowState? WindowState, Browser.BrowserContextID? BrowserContextId, bool? EnableBeginFrameControl, bool? NewWindow, bool? Background, bool? ForTab, bool? Hidden) : Parameters;

/// <summary>
/// Optional parameters for <see cref="TargetDomain.CreateTargetAsync"/>.
/// </summary>
public sealed record CreateTargetCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Frame left origin in DIP (requires newWindow to be true or headless shell).
    /// </summary>
    public long? Left { get; init; }

    /// <summary>
    /// Frame top origin in DIP (requires newWindow to be true or headless shell).
    /// </summary>
    public long? Top { get; init; }

    /// <summary>
    /// Frame width in DIP (requires newWindow to be true or headless shell).
    /// </summary>
    public long? Width { get; init; }

    /// <summary>
    /// Frame height in DIP (requires newWindow to be true or headless shell).
    /// </summary>
    public long? Height { get; init; }

    /// <summary>
    /// Frame window state (requires newWindow to be true or headless shell).
    /// Default is normal.
    /// </summary>
    public WindowState? WindowState { get; init; }

    /// <summary>
    /// The browser context to create the page in.
    /// </summary>
    public Browser.BrowserContextID? BrowserContextId { get; init; }

    /// <summary>
    /// Whether BeginFrames for this target will be controlled via DevTools (headless shell only,
    /// not supported on MacOS yet, false by default).
    /// </summary>
    public bool? EnableBeginFrameControl { get; init; }

    /// <summary>
    /// Whether to create a new Window or Tab (false by default, not supported by headless shell).
    /// </summary>
    public bool? NewWindow { get; init; }

    /// <summary>
    /// Whether to create the target in background or foreground (false by default, not supported
    /// by headless shell).
    /// </summary>
    public bool? Background { get; init; }

    /// <summary>
    /// Whether to create the target of type "tab".
    /// </summary>
    public bool? ForTab { get; init; }

    /// <summary>
    /// Whether to create a hidden target. The hidden target is observable via protocol, but not
    /// present in the tab UI strip. Cannot be created with <b>forTab: true</b>, <b>newWindow: true</b> or
    /// <b>background: false</b>. The life-time of the tab is limited to the life-time of the session.
    /// </summary>
    public bool? Hidden { get; init; }
}

/// <summary>
/// </summary>
/// <param name="TargetId">
/// The id of the page opened.
/// </param>
public sealed record CreateTargetResult(TargetID TargetId) : EmptyResult;


internal sealed record DetachFromTargetCommandParameters(SessionID? SessionId, TargetID? TargetId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="TargetDomain.DetachFromTargetAsync"/>.
/// </summary>
public sealed record DetachFromTargetCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Session to detach.
    /// </summary>
    public SessionID? SessionId { get; init; }

    /// <summary>
    /// Deprecated.
    /// </summary>
    [global::System.Obsolete]
    public TargetID? TargetId { get; init; }
}

/// <summary>
/// </summary>
public sealed record DetachFromTargetResult() : EmptyResult;


internal sealed record DisposeBrowserContextCommandParameters(Browser.BrowserContextID BrowserContextId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="TargetDomain.DisposeBrowserContextAsync"/>.
/// </summary>
public sealed record DisposeBrowserContextCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DisposeBrowserContextResult() : EmptyResult;


internal sealed record GetTargetInfoCommandParameters(TargetID? TargetId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="TargetDomain.GetTargetInfoAsync"/>.
/// </summary>
public sealed record GetTargetInfoCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// </summary>
    public TargetID? TargetId { get; init; }
}

/// <summary>
/// </summary>
/// <param name="TargetInfo">
/// </param>
public sealed record GetTargetInfoResult(TargetInfo TargetInfo) : EmptyResult;


internal sealed record GetTargetsCommandParameters(IReadOnlyList<FilterEntry>? Filter) : Parameters;

/// <summary>
/// Optional parameters for <see cref="TargetDomain.GetTargetsAsync"/>.
/// </summary>
public sealed record GetTargetsCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Only targets matching filter will be reported. If filter is not specified
    /// and target discovery is currently enabled, a filter used for target discovery
    /// is used for consistency.
    /// </summary>
    public IReadOnlyList<FilterEntry>? Filter { get; init; }
}

/// <summary>
/// </summary>
/// <param name="TargetInfos">
/// The list of targets.
/// </param>
public sealed record GetTargetsResult(IReadOnlyList<TargetInfo> TargetInfos) : EmptyResult;


internal sealed record SendMessageToTargetCommandParameters(string Message, SessionID? SessionId, TargetID? TargetId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="TargetDomain.SendMessageToTargetAsync"/>.
/// </summary>
public sealed record SendMessageToTargetCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Identifier of the session.
    /// </summary>
    public SessionID? SessionId { get; init; }

    /// <summary>
    /// Deprecated.
    /// </summary>
    [global::System.Obsolete]
    public TargetID? TargetId { get; init; }
}

/// <summary>
/// </summary>
public sealed record SendMessageToTargetResult() : EmptyResult;


internal sealed record SetAutoAttachCommandParameters(bool AutoAttach, bool WaitForDebuggerOnStart, bool? Flatten, IReadOnlyList<FilterEntry>? Filter) : Parameters;

/// <summary>
/// Optional parameters for <see cref="TargetDomain.SetAutoAttachAsync"/>.
/// </summary>
public sealed record SetAutoAttachCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Enables "flat" access to the session via specifying sessionId attribute in the commands.
    /// We plan to make this the default, deprecate non-flattened mode,
    /// and eventually retire it. See crbug.com/991325.
    /// </summary>
    public bool? Flatten { get; init; }

    /// <summary>
    /// Only targets matching filter will be attached.
    /// </summary>
    public IReadOnlyList<FilterEntry>? Filter { get; init; }
}

/// <summary>
/// </summary>
public sealed record SetAutoAttachResult() : EmptyResult;


internal sealed record AutoAttachRelatedCommandParameters(TargetID TargetId, bool WaitForDebuggerOnStart, IReadOnlyList<FilterEntry>? Filter) : Parameters;

/// <summary>
/// Optional parameters for <see cref="TargetDomain.AutoAttachRelatedAsync"/>.
/// </summary>
public sealed record AutoAttachRelatedCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Only targets matching filter will be attached.
    /// </summary>
    public IReadOnlyList<FilterEntry>? Filter { get; init; }
}

/// <summary>
/// </summary>
public sealed record AutoAttachRelatedResult() : EmptyResult;


internal sealed record SetDiscoverTargetsCommandParameters(bool Discover, IReadOnlyList<FilterEntry>? Filter) : Parameters;

/// <summary>
/// Optional parameters for <see cref="TargetDomain.SetDiscoverTargetsAsync"/>.
/// </summary>
public sealed record SetDiscoverTargetsCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Only targets matching filter will be attached. If <b>discover</b> is false,
    /// <b>filter</b> must be omitted or empty.
    /// </summary>
    public IReadOnlyList<FilterEntry>? Filter { get; init; }
}

/// <summary>
/// </summary>
public sealed record SetDiscoverTargetsResult() : EmptyResult;


internal sealed record SetRemoteLocationsCommandParameters(IEnumerable<RemoteLocation> Locations) : Parameters;

/// <summary>
/// Optional parameters for <see cref="TargetDomain.SetRemoteLocationsAsync"/>.
/// </summary>
public sealed record SetRemoteLocationsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetRemoteLocationsResult() : EmptyResult;


/// <summary>
/// Issued when attached to target because of auto-attach or <b>attachToTarget</b> command.
/// </summary>
/// <param name="SessionId">
/// Identifier assigned to the session used to send/receive messages.
/// </param>
/// <param name="TargetInfo">
/// </param>
/// <param name="WaitingForDebugger">
/// </param>
public sealed record AttachedToTargetEventArgs(SessionID SessionId, TargetInfo TargetInfo, bool WaitingForDebugger) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Issued when detached from target for any reason (including <b>detachFromTarget</b> command). Can be
/// issued multiple times per target if multiple sessions have been attached to it.
/// </summary>
/// <param name="SessionId">
/// Detached session identifier.
/// </param>
/// <param name="TargetId">
/// Deprecated.
/// </param>
public sealed record DetachedFromTargetEventArgs(SessionID SessionId, TargetID? TargetId = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Notifies about a new protocol message received from the session (as reported in
/// <b>attachedToTarget</b> event).
/// </summary>
/// <param name="SessionId">
/// Identifier of a session which sends a message.
/// </param>
/// <param name="Message">
/// </param>
/// <param name="TargetId">
/// Deprecated.
/// </param>
public sealed record ReceivedMessageFromTargetEventArgs(SessionID SessionId, string Message, TargetID? TargetId = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Issued when a possible inspection target is created.
/// </summary>
/// <param name="TargetInfo">
/// </param>
public sealed record TargetCreatedEventArgs(TargetInfo TargetInfo) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Issued when a target is destroyed.
/// </summary>
/// <param name="TargetId">
/// </param>
public sealed record TargetDestroyedEventArgs(TargetID TargetId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Issued when a target has crashed.
/// </summary>
/// <param name="TargetId">
/// </param>
/// <param name="Status">
/// Termination status type.
/// </param>
/// <param name="ErrorCode">
/// Termination error code.
/// </param>
public sealed record TargetCrashedEventArgs(TargetID TargetId, string Status, long ErrorCode) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Issued when some information about a target has changed. This only happens between
/// <b>targetCreated</b> and <b>targetDestroyed</b>.
/// </summary>
/// <param name="TargetInfo">
/// </param>
public sealed record TargetInfoChangedEventArgs(TargetInfo TargetInfo) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<TargetID>))]
public record TargetID : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Unique identifier of attached debugging session.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<SessionID>))]
public record SessionID : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// </summary>
/// <param name="TargetId">
/// </param>
/// <param name="Type">
/// List of types: https://source.chromium.org/chromium/chromium/src/+/main:content/browser/devtools/devtools_agent_host_impl.cc?ss=chromium&amp;q=f:devtools%20-f:out%20%22::kTypeTab%5B%5D%22
/// </param>
/// <param name="Title">
/// </param>
/// <param name="Url">
/// </param>
/// <param name="Attached">
/// Whether the target has an attached client.
/// </param>
/// <param name="CanAccessOpener">
/// Whether the target has access to the originating window.
/// </param>
public sealed record TargetInfo(TargetID TargetId, string Type, string Title, string Url, bool Attached, bool CanAccessOpener)
{
    /// <summary>
    /// Opener target Id
    /// </summary>
    public TargetID? OpenerId { get; init; }

    /// <summary>
    /// Frame id of originating window (is only set if target has an opener).
    /// </summary>
    public Page.FrameId? OpenerFrameId { get; init; }

    /// <summary>
    /// </summary>
    public Browser.BrowserContextID? BrowserContextId { get; init; }

    /// <summary>
    /// Provides additional details for specific target types. For example, for
    /// the type of "page", this may be set to "prerender".
    /// </summary>
    public string? Subtype { get; init; }
}

/// <summary>
/// A filter used by target query/discovery/auto-attach operations.
/// </summary>
public sealed record FilterEntry()
{
    /// <summary>
    /// If set, causes exclusion of matching targets from the list.
    /// </summary>
    public bool? Exclude { get; init; }

    /// <summary>
    /// If not present, matches any type.
    /// </summary>
    public string? Type { get; init; }
}

/// <summary>
/// The entries in TargetFilter are matched sequentially against targets and
/// the first entry that matches determines if the target is included or not,
/// depending on the value of <b>exclude</b> field in the entry.
/// If filter is not specified, the one assumed is
/// [{type: "browser", exclude: true}, {type: "tab", exclude: true}, {}]
/// (i.e. include everything but <b>browser</b> and <b>tab</b>).
/// </summary>

/// <summary>
/// </summary>
/// <param name="Host">
/// </param>
/// <param name="Port">
/// </param>
public sealed record RemoteLocation(string Host, long Port)
{
}

/// <summary>
/// The state of the target window.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<WindowState>))]
public enum WindowState
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("normal")]
    Normal,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("minimized")]
    Minimized,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("maximized")]
    Maximized,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("fullscreen")]
    Fullscreen,
}

[JsonSerializable(typeof(ActivateTargetCommandParameters), TypeInfoPropertyName = "ActivateTargetCommandParameters")]
[JsonSerializable(typeof(ActivateTargetResult), TypeInfoPropertyName = "ActivateTargetResult")]
[JsonSerializable(typeof(AttachToTargetCommandParameters), TypeInfoPropertyName = "AttachToTargetCommandParameters")]
[JsonSerializable(typeof(AttachToTargetResult), TypeInfoPropertyName = "AttachToTargetResult")]
[JsonSerializable(typeof(AttachToBrowserTargetCommandParameters), TypeInfoPropertyName = "AttachToBrowserTargetCommandParameters")]
[JsonSerializable(typeof(AttachToBrowserTargetResult), TypeInfoPropertyName = "AttachToBrowserTargetResult")]
[JsonSerializable(typeof(CloseTargetCommandParameters), TypeInfoPropertyName = "CloseTargetCommandParameters")]
[JsonSerializable(typeof(CloseTargetResult), TypeInfoPropertyName = "CloseTargetResult")]
[JsonSerializable(typeof(ExposeDevToolsProtocolCommandParameters), TypeInfoPropertyName = "ExposeDevToolsProtocolCommandParameters")]
[JsonSerializable(typeof(ExposeDevToolsProtocolResult), TypeInfoPropertyName = "ExposeDevToolsProtocolResult")]
[JsonSerializable(typeof(CreateBrowserContextCommandParameters), TypeInfoPropertyName = "CreateBrowserContextCommandParameters")]
[JsonSerializable(typeof(CreateBrowserContextResult), TypeInfoPropertyName = "CreateBrowserContextResult")]
[JsonSerializable(typeof(GetBrowserContextsCommandParameters), TypeInfoPropertyName = "GetBrowserContextsCommandParameters")]
[JsonSerializable(typeof(GetBrowserContextsResult), TypeInfoPropertyName = "GetBrowserContextsResult")]
[JsonSerializable(typeof(CreateTargetCommandParameters), TypeInfoPropertyName = "CreateTargetCommandParameters")]
[JsonSerializable(typeof(CreateTargetResult), TypeInfoPropertyName = "CreateTargetResult")]
[JsonSerializable(typeof(DetachFromTargetCommandParameters), TypeInfoPropertyName = "DetachFromTargetCommandParameters")]
[JsonSerializable(typeof(DetachFromTargetResult), TypeInfoPropertyName = "DetachFromTargetResult")]
[JsonSerializable(typeof(DisposeBrowserContextCommandParameters), TypeInfoPropertyName = "DisposeBrowserContextCommandParameters")]
[JsonSerializable(typeof(DisposeBrowserContextResult), TypeInfoPropertyName = "DisposeBrowserContextResult")]
[JsonSerializable(typeof(GetTargetInfoCommandParameters), TypeInfoPropertyName = "GetTargetInfoCommandParameters")]
[JsonSerializable(typeof(GetTargetInfoResult), TypeInfoPropertyName = "GetTargetInfoResult")]
[JsonSerializable(typeof(GetTargetsCommandParameters), TypeInfoPropertyName = "GetTargetsCommandParameters")]
[JsonSerializable(typeof(GetTargetsResult), TypeInfoPropertyName = "GetTargetsResult")]
[JsonSerializable(typeof(SendMessageToTargetCommandParameters), TypeInfoPropertyName = "SendMessageToTargetCommandParameters")]
[JsonSerializable(typeof(SendMessageToTargetResult), TypeInfoPropertyName = "SendMessageToTargetResult")]
[JsonSerializable(typeof(SetAutoAttachCommandParameters), TypeInfoPropertyName = "SetAutoAttachCommandParameters")]
[JsonSerializable(typeof(SetAutoAttachResult), TypeInfoPropertyName = "SetAutoAttachResult")]
[JsonSerializable(typeof(AutoAttachRelatedCommandParameters), TypeInfoPropertyName = "AutoAttachRelatedCommandParameters")]
[JsonSerializable(typeof(AutoAttachRelatedResult), TypeInfoPropertyName = "AutoAttachRelatedResult")]
[JsonSerializable(typeof(SetDiscoverTargetsCommandParameters), TypeInfoPropertyName = "SetDiscoverTargetsCommandParameters")]
[JsonSerializable(typeof(SetDiscoverTargetsResult), TypeInfoPropertyName = "SetDiscoverTargetsResult")]
[JsonSerializable(typeof(SetRemoteLocationsCommandParameters), TypeInfoPropertyName = "SetRemoteLocationsCommandParameters")]
[JsonSerializable(typeof(SetRemoteLocationsResult), TypeInfoPropertyName = "SetRemoteLocationsResult")]
[JsonSerializable(typeof(CdpEventArgs<AttachedToTargetEventArgs>), TypeInfoPropertyName = "AttachedToTargetCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DetachedFromTargetEventArgs>), TypeInfoPropertyName = "DetachedFromTargetCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ReceivedMessageFromTargetEventArgs>), TypeInfoPropertyName = "ReceivedMessageFromTargetCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<TargetCreatedEventArgs>), TypeInfoPropertyName = "TargetCreatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<TargetDestroyedEventArgs>), TypeInfoPropertyName = "TargetDestroyedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<TargetCrashedEventArgs>), TypeInfoPropertyName = "TargetCrashedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<TargetInfoChangedEventArgs>), TypeInfoPropertyName = "TargetInfoChangedCdpEventArgs")]
[JsonSerializable(typeof(TargetID), TypeInfoPropertyName = "TargetTargetID")]
[JsonSerializable(typeof(SessionID), TypeInfoPropertyName = "TargetSessionID")]
[JsonSerializable(typeof(TargetInfo), TypeInfoPropertyName = "TargetTargetInfo")]
[JsonSerializable(typeof(FilterEntry), TypeInfoPropertyName = "TargetFilterEntry")]
[JsonSerializable(typeof(RemoteLocation), TypeInfoPropertyName = "TargetRemoteLocation")]
[JsonSerializable(typeof(WindowState), TypeInfoPropertyName = "TargetWindowState")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<Browser.BrowserContextID>), TypeInfoPropertyName = "IReadOnlyListBrowserBrowserContextID")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<TargetInfo>), TypeInfoPropertyName = "IReadOnlyListTargetTargetInfo")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<RemoteLocation>), TypeInfoPropertyName = "IReadOnlyListTargetRemoteLocation")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class TargetJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="TargetDomain"/>.
/// </summary>
public static class TargetDomainEvent
{
    /// <summary>
    /// Issued when attached to target because of auto-attach or <b>attachToTarget</b> command.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<AttachedToTargetEventArgs>> AttachedToTarget { get; } =
        EventDescriptor<CdpEventArgs<AttachedToTargetEventArgs>>.Create(
            "goog:cdp.Target.attachedToTarget",
            TargetJsonSerializerContext.Default.AttachedToTargetCdpEventArgs);

    /// <summary>
    /// Issued when detached from target for any reason (including <b>detachFromTarget</b> command). Can be
    /// issued multiple times per target if multiple sessions have been attached to it.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DetachedFromTargetEventArgs>> DetachedFromTarget { get; } =
        EventDescriptor<CdpEventArgs<DetachedFromTargetEventArgs>>.Create(
            "goog:cdp.Target.detachedFromTarget",
            TargetJsonSerializerContext.Default.DetachedFromTargetCdpEventArgs);

    /// <summary>
    /// Notifies about a new protocol message received from the session (as reported in
    /// <b>attachedToTarget</b> event).
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ReceivedMessageFromTargetEventArgs>> ReceivedMessageFromTarget { get; } =
        EventDescriptor<CdpEventArgs<ReceivedMessageFromTargetEventArgs>>.Create(
            "goog:cdp.Target.receivedMessageFromTarget",
            TargetJsonSerializerContext.Default.ReceivedMessageFromTargetCdpEventArgs);

    /// <summary>
    /// Issued when a possible inspection target is created.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<TargetCreatedEventArgs>> TargetCreated { get; } =
        EventDescriptor<CdpEventArgs<TargetCreatedEventArgs>>.Create(
            "goog:cdp.Target.targetCreated",
            TargetJsonSerializerContext.Default.TargetCreatedCdpEventArgs);

    /// <summary>
    /// Issued when a target is destroyed.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<TargetDestroyedEventArgs>> TargetDestroyed { get; } =
        EventDescriptor<CdpEventArgs<TargetDestroyedEventArgs>>.Create(
            "goog:cdp.Target.targetDestroyed",
            TargetJsonSerializerContext.Default.TargetDestroyedCdpEventArgs);

    /// <summary>
    /// Issued when a target has crashed.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<TargetCrashedEventArgs>> TargetCrashed { get; } =
        EventDescriptor<CdpEventArgs<TargetCrashedEventArgs>>.Create(
            "goog:cdp.Target.targetCrashed",
            TargetJsonSerializerContext.Default.TargetCrashedCdpEventArgs);

    /// <summary>
    /// Issued when some information about a target has changed. This only happens between
    /// <b>targetCreated</b> and <b>targetDestroyed</b>.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<TargetInfoChangedEventArgs>> TargetInfoChanged { get; } =
        EventDescriptor<CdpEventArgs<TargetInfoChangedEventArgs>>.Create(
            "goog:cdp.Target.targetInfoChanged",
            TargetJsonSerializerContext.Default.TargetInfoChangedCdpEventArgs);

}
