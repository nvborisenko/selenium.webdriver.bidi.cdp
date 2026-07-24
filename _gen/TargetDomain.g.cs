#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Target;

/// <summary>
/// Supports additional targets discovery and allows to attach to them.
/// </summary>
public interface ITarget
{
    /// <summary>
    /// Activates (focuses) the target.
    /// </summary>
    /// <param name="targetId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ActivateTargetResult"/>.
    /// </returns>
    Task<ActivateTargetResult> ActivateTargetAsync(TargetID targetId, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Attaches to the target with given id.
    /// </summary>
    /// <param name="targetId">
    /// </param>
    /// <param name="flatten">
    /// Enables "flat" access to the session via specifying sessionId attribute in the commands.
    /// We plan to make this the default, deprecate non-flattened mode,
    /// and eventually retire it. See crbug.com/991325.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AttachToTargetResult"/>.
    /// </returns>
    Task<AttachToTargetResult> AttachToTargetAsync(TargetID targetId, bool? flatten = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Attaches to the browser target, only uses flat sessionId mode.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AttachToBrowserTargetResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<AttachToBrowserTargetResult> AttachToBrowserTargetAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Closes the target. If the target is a page that gets closed too.
    /// </summary>
    /// <param name="targetId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CloseTargetResult"/>.
    /// </returns>
    Task<CloseTargetResult> CloseTargetAsync(TargetID targetId, string? session = default, CancellationToken cancellationToken = default);

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
    /// <param name="targetId">
    /// </param>
    /// <param name="bindingName">
    /// Binding name, 'cdp' if not specified.
    /// </param>
    /// <param name="inheritPermissions">
    /// If true, inherits the current root session's permissions (default: false).
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ExposeDevToolsProtocolResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<ExposeDevToolsProtocolResult> ExposeDevToolsProtocolAsync(TargetID targetId, string? bindingName = default, bool? inheritPermissions = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a new empty BrowserContext. Similar to an incognito profile but you can have more than
    /// one.
    /// </summary>
    /// <param name="disposeOnDetach">
    /// If specified, disposes this context when debugging session disconnects.
    /// </param>
    /// <param name="proxyServer">
    /// Proxy server, similar to the one passed to --proxy-server
    /// </param>
    /// <param name="proxyBypassList">
    /// Proxy bypass list, similar to the one passed to --proxy-bypass-list
    /// </param>
    /// <param name="originsWithUniversalNetworkAccess">
    /// An optional list of origins to grant unlimited cross-origin access to.
    /// Parts of the URL other than those constituting origin are ignored.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CreateBrowserContextResult"/>.
    /// </returns>
    Task<CreateBrowserContextResult> CreateBrowserContextAsync(bool? disposeOnDetach = default, string? proxyServer = default, string? proxyBypassList = default, ImmutableArray<string>? originsWithUniversalNetworkAccess = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns all browser contexts created with <b>Target.createBrowserContext</b> method.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetBrowserContextsResult"/>.
    /// </returns>
    Task<GetBrowserContextsResult> GetBrowserContextsAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a new page.
    /// </summary>
    /// <param name="url">
    /// The initial URL the page will be navigated to. An empty string indicates about:blank.
    /// </param>
    /// <param name="left">
    /// Frame left origin in DIP (requires newWindow to be true or headless shell).
    /// </param>
    /// <param name="top">
    /// Frame top origin in DIP (requires newWindow to be true or headless shell).
    /// </param>
    /// <param name="width">
    /// Frame width in DIP (requires newWindow to be true or headless shell).
    /// </param>
    /// <param name="height">
    /// Frame height in DIP (requires newWindow to be true or headless shell).
    /// </param>
    /// <param name="windowState">
    /// Frame window state (requires newWindow to be true or headless shell).
    /// Default is normal.
    /// </param>
    /// <param name="browserContextId">
    /// The browser context to create the page in.
    /// </param>
    /// <param name="enableBeginFrameControl">
    /// Whether BeginFrames for this target will be controlled via DevTools (headless shell only,
    /// not supported on MacOS yet, false by default).
    /// </param>
    /// <param name="newWindow">
    /// Whether to create a new Window or Tab (false by default, not supported by headless shell).
    /// </param>
    /// <param name="background">
    /// Whether to create the target in background or foreground (false by default, not supported
    /// by headless shell).
    /// </param>
    /// <param name="forTab">
    /// Whether to create the target of type "tab".
    /// </param>
    /// <param name="hidden">
    /// Whether to create a hidden target. The hidden target is observable via protocol, but not
    /// present in the tab UI strip. Cannot be created with <b>forTab: true</b>, <b>newWindow: true</b> or
    /// <b>background: false</b>. The life-time of the tab is limited to the life-time of the session.
    /// </param>
    /// <param name="focus">
    /// If specified, determines whether the new target should be focused.
    /// By default, the focus behavior depends on the <b>background</b> parameter:
    /// - If <b>background</b> is false (default) and <b>focus</b> is omitted, the new target is focused and the browser window is brought to the foreground.
    /// - If <b>background</b> is false and <b>focus</b> is false, the target is opened but the browser window's focus remains unchanged (e.g., if the window was in the background, it stays there).
    /// - If <b>background</b> is true, setting <b>focus</b> to true is not supported and will result in an error.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CreateTargetResult"/>.
    /// </returns>
    Task<CreateTargetResult> CreateTargetAsync(string url, long? left = default, long? top = default, long? width = default, long? height = default, WindowState? windowState = default, Browser.BrowserContextID? browserContextId = default, bool? enableBeginFrameControl = default, bool? newWindow = default, bool? background = default, bool? forTab = default, bool? hidden = default, bool? focus = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Detaches session with given id.
    /// </summary>
    /// <param name="sessionId">
    /// Session to detach.
    /// </param>
    /// <param name="targetId">
    /// Deprecated.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DetachFromTargetResult"/>.
    /// </returns>
    Task<DetachFromTargetResult> DetachFromTargetAsync(SessionID? sessionId = default, TargetID? targetId = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a BrowserContext. All the belonging pages will be closed without calling their
    /// beforeunload hooks.
    /// </summary>
    /// <param name="browserContextId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DisposeBrowserContextResult"/>.
    /// </returns>
    Task<DisposeBrowserContextResult> DisposeBrowserContextAsync(Browser.BrowserContextID browserContextId, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns information about a target.
    /// </summary>
    /// <param name="targetId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetTargetInfoResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetTargetInfoResult> GetTargetInfoAsync(TargetID? targetId = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a list of available targets.
    /// </summary>
    /// <param name="filter">
    /// Only targets matching filter will be reported. If filter is not specified
    /// and target discovery is currently enabled, a filter used for target discovery
    /// is used for consistency.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetTargetsResult"/>.
    /// </returns>
    Task<GetTargetsResult> GetTargetsAsync(ImmutableArray<FilterEntry>? filter = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Sends protocol message over session with given id.
    /// Consider using flat mode instead; see commands attachToTarget, setAutoAttach,
    /// and crbug.com/991325.
    /// </summary>
    /// <param name="message">
    /// </param>
    /// <param name="sessionId">
    /// Identifier of the session.
    /// </param>
    /// <param name="targetId">
    /// Deprecated.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SendMessageToTargetResult"/>.
    /// </returns>
    [global::System.Obsolete]
    Task<SendMessageToTargetResult> SendMessageToTargetAsync(string message, SessionID? sessionId = default, TargetID? targetId = default, string? session = default, CancellationToken cancellationToken = default);

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
    /// <param name="autoAttach">
    /// Whether to auto-attach to related targets.
    /// </param>
    /// <param name="waitForDebuggerOnStart">
    /// Whether to pause new targets when attaching to them. Use <b>Runtime.runIfWaitingForDebugger</b>
    /// to run paused targets.
    /// </param>
    /// <param name="flatten">
    /// Enables "flat" access to the session via specifying sessionId attribute in the commands.
    /// We plan to make this the default, deprecate non-flattened mode,
    /// and eventually retire it. See crbug.com/991325.
    /// </param>
    /// <param name="filter">
    /// Only targets matching filter will be attached.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetAutoAttachResult"/>.
    /// </returns>
    Task<SetAutoAttachResult> SetAutoAttachAsync(bool autoAttach, bool waitForDebuggerOnStart, bool? flatten = default, ImmutableArray<FilterEntry>? filter = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Adds the specified target to the list of targets that will be monitored for any related target
    /// creation (such as child frames, child workers and new versions of service worker) and reported
    /// through <b>attachedToTarget</b>. The specified target is also auto-attached.
    /// This cancels the effect of any previous <b>setAutoAttach</b> and is also cancelled by subsequent
    /// <b>setAutoAttach</b>. Only available at the Browser target.
    /// </summary>
    /// <param name="targetId">
    /// </param>
    /// <param name="waitForDebuggerOnStart">
    /// Whether to pause new targets when attaching to them. Use <b>Runtime.runIfWaitingForDebugger</b>
    /// to run paused targets.
    /// </param>
    /// <param name="filter">
    /// Only targets matching filter will be attached.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AutoAttachRelatedResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<AutoAttachRelatedResult> AutoAttachRelatedAsync(TargetID targetId, bool waitForDebuggerOnStart, ImmutableArray<FilterEntry>? filter = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Controls whether to discover available targets and notify via
    /// <b>targetCreated/targetInfoChanged/targetDestroyed</b> events.
    /// </summary>
    /// <param name="discover">
    /// Whether to discover available targets.
    /// </param>
    /// <param name="filter">
    /// Only targets matching filter will be attached. If <b>discover</b> is false,
    /// <b>filter</b> must be omitted or empty.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetDiscoverTargetsResult"/>.
    /// </returns>
    Task<SetDiscoverTargetsResult> SetDiscoverTargetsAsync(bool discover, ImmutableArray<FilterEntry>? filter = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Enables target discovery for the specified locations, when <b>setDiscoverTargets</b> was set to
    /// <b>true</b>.
    /// </summary>
    /// <param name="locations">
    /// List of remote locations.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetRemoteLocationsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<SetRemoteLocationsResult> SetRemoteLocationsAsync(ImmutableArray<RemoteLocation> locations, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the targetId of the DevTools page target opened for the given target
    /// (if any).
    /// </summary>
    /// <param name="targetId">
    /// Page or tab target ID.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetDevToolsTargetResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetDevToolsTargetResult> GetDevToolsTargetAsync(TargetID targetId, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Opens a DevTools window for the target.
    /// </summary>
    /// <param name="targetId">
    /// This can be the page or tab target ID.
    /// </param>
    /// <param name="panelId">
    /// The id of the panel we want DevTools to open initially. Currently
    /// supported panels are elements, console, network, sources, resources,
    /// timeline, chrome-recorder, heap-profiler, lighthouse, and security.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="OpenDevToolsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<OpenDevToolsResult> OpenDevToolsAsync(TargetID targetId, string? panelId = default, string? session = default, CancellationToken cancellationToken = default);

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
    IEventSource<AttachedToTargetEventArgs> AttachedToTarget { get; }

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
    IEventSource<DetachedFromTargetEventArgs> DetachedFromTarget { get; }

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
    IEventSource<ReceivedMessageFromTargetEventArgs> ReceivedMessageFromTarget { get; }

    /// <summary>
    /// Issued when a possible inspection target is created.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="TargetCreatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>TargetInfo</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<TargetCreatedEventArgs> TargetCreated { get; }

    /// <summary>
    /// Issued when a target is destroyed.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="TargetDestroyedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>TargetId</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<TargetDestroyedEventArgs> TargetDestroyed { get; }

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
    IEventSource<TargetCrashedEventArgs> TargetCrashed { get; }

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
    IEventSource<TargetInfoChangedEventArgs> TargetInfoChanged { get; }

}

internal sealed class TargetDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), ITarget
{
    private static TargetJsonSerializerContext JsonContext = TargetJsonSerializerContext.Default;

    public async Task<ActivateTargetResult> ActivateTargetAsync(TargetID targetId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ActivateTargetCommandParameters(TargetId: targetId);
        return await ExecuteCommandAsync(ActivateTargetCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ActivateTargetCommandParameters, ActivateTargetResult> ActivateTargetCommand = new("Target.activateTarget", JsonContext.ActivateTargetCommandParameters, JsonContext.ActivateTargetResult);

    public async Task<AttachToTargetResult> AttachToTargetAsync(TargetID targetId, bool? flatten = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new AttachToTargetCommandParameters(TargetId: targetId, Flatten: flatten);
        return await ExecuteCommandAsync(AttachToTargetCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AttachToTargetCommandParameters, AttachToTargetResult> AttachToTargetCommand = new("Target.attachToTarget", JsonContext.AttachToTargetCommandParameters, JsonContext.AttachToTargetResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<AttachToBrowserTargetResult> AttachToBrowserTargetAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new AttachToBrowserTargetCommandParameters();
        return await ExecuteCommandAsync(AttachToBrowserTargetCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AttachToBrowserTargetCommandParameters, AttachToBrowserTargetResult> AttachToBrowserTargetCommand = new("Target.attachToBrowserTarget", JsonContext.AttachToBrowserTargetCommandParameters, JsonContext.AttachToBrowserTargetResult);

    public async Task<CloseTargetResult> CloseTargetAsync(TargetID targetId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CloseTargetCommandParameters(TargetId: targetId);
        return await ExecuteCommandAsync(CloseTargetCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CloseTargetCommandParameters, CloseTargetResult> CloseTargetCommand = new("Target.closeTarget", JsonContext.CloseTargetCommandParameters, JsonContext.CloseTargetResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<ExposeDevToolsProtocolResult> ExposeDevToolsProtocolAsync(TargetID targetId, string? bindingName = default, bool? inheritPermissions = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ExposeDevToolsProtocolCommandParameters(TargetId: targetId, BindingName: bindingName, InheritPermissions: inheritPermissions);
        return await ExecuteCommandAsync(ExposeDevToolsProtocolCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ExposeDevToolsProtocolCommandParameters, ExposeDevToolsProtocolResult> ExposeDevToolsProtocolCommand = new("Target.exposeDevToolsProtocol", JsonContext.ExposeDevToolsProtocolCommandParameters, JsonContext.ExposeDevToolsProtocolResult);

    public async Task<CreateBrowserContextResult> CreateBrowserContextAsync(bool? disposeOnDetach = default, string? proxyServer = default, string? proxyBypassList = default, ImmutableArray<string>? originsWithUniversalNetworkAccess = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CreateBrowserContextCommandParameters(DisposeOnDetach: disposeOnDetach, ProxyServer: proxyServer, ProxyBypassList: proxyBypassList, OriginsWithUniversalNetworkAccess: originsWithUniversalNetworkAccess);
        return await ExecuteCommandAsync(CreateBrowserContextCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CreateBrowserContextCommandParameters, CreateBrowserContextResult> CreateBrowserContextCommand = new("Target.createBrowserContext", JsonContext.CreateBrowserContextCommandParameters, JsonContext.CreateBrowserContextResult);

    public async Task<GetBrowserContextsResult> GetBrowserContextsAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetBrowserContextsCommandParameters();
        return await ExecuteCommandAsync(GetBrowserContextsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetBrowserContextsCommandParameters, GetBrowserContextsResult> GetBrowserContextsCommand = new("Target.getBrowserContexts", JsonContext.GetBrowserContextsCommandParameters, JsonContext.GetBrowserContextsResult);

    public async Task<CreateTargetResult> CreateTargetAsync(string url, long? left = default, long? top = default, long? width = default, long? height = default, WindowState? windowState = default, Browser.BrowserContextID? browserContextId = default, bool? enableBeginFrameControl = default, bool? newWindow = default, bool? background = default, bool? forTab = default, bool? hidden = default, bool? focus = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CreateTargetCommandParameters(Url: url, Left: left, Top: top, Width: width, Height: height, WindowState: windowState, BrowserContextId: browserContextId, EnableBeginFrameControl: enableBeginFrameControl, NewWindow: newWindow, Background: background, ForTab: forTab, Hidden: hidden, Focus: focus);
        return await ExecuteCommandAsync(CreateTargetCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CreateTargetCommandParameters, CreateTargetResult> CreateTargetCommand = new("Target.createTarget", JsonContext.CreateTargetCommandParameters, JsonContext.CreateTargetResult);

    public async Task<DetachFromTargetResult> DetachFromTargetAsync(SessionID? sessionId = default, TargetID? targetId = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DetachFromTargetCommandParameters(SessionId: sessionId, TargetId: targetId);
        return await ExecuteCommandAsync(DetachFromTargetCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DetachFromTargetCommandParameters, DetachFromTargetResult> DetachFromTargetCommand = new("Target.detachFromTarget", JsonContext.DetachFromTargetCommandParameters, JsonContext.DetachFromTargetResult);

    public async Task<DisposeBrowserContextResult> DisposeBrowserContextAsync(Browser.BrowserContextID browserContextId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisposeBrowserContextCommandParameters(BrowserContextId: browserContextId);
        return await ExecuteCommandAsync(DisposeBrowserContextCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DisposeBrowserContextCommandParameters, DisposeBrowserContextResult> DisposeBrowserContextCommand = new("Target.disposeBrowserContext", JsonContext.DisposeBrowserContextCommandParameters, JsonContext.DisposeBrowserContextResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetTargetInfoResult> GetTargetInfoAsync(TargetID? targetId = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetTargetInfoCommandParameters(TargetId: targetId);
        return await ExecuteCommandAsync(GetTargetInfoCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetTargetInfoCommandParameters, GetTargetInfoResult> GetTargetInfoCommand = new("Target.getTargetInfo", JsonContext.GetTargetInfoCommandParameters, JsonContext.GetTargetInfoResult);

    public async Task<GetTargetsResult> GetTargetsAsync(ImmutableArray<FilterEntry>? filter = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetTargetsCommandParameters(Filter: filter);
        return await ExecuteCommandAsync(GetTargetsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetTargetsCommandParameters, GetTargetsResult> GetTargetsCommand = new("Target.getTargets", JsonContext.GetTargetsCommandParameters, JsonContext.GetTargetsResult);

    [global::System.Obsolete]
    public async Task<SendMessageToTargetResult> SendMessageToTargetAsync(string message, SessionID? sessionId = default, TargetID? targetId = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SendMessageToTargetCommandParameters(Message: message, SessionId: sessionId, TargetId: targetId);
        return await ExecuteCommandAsync(SendMessageToTargetCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SendMessageToTargetCommandParameters, SendMessageToTargetResult> SendMessageToTargetCommand = new("Target.sendMessageToTarget", JsonContext.SendMessageToTargetCommandParameters, JsonContext.SendMessageToTargetResult);

    public async Task<SetAutoAttachResult> SetAutoAttachAsync(bool autoAttach, bool waitForDebuggerOnStart, bool? flatten = default, ImmutableArray<FilterEntry>? filter = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetAutoAttachCommandParameters(AutoAttach: autoAttach, WaitForDebuggerOnStart: waitForDebuggerOnStart, Flatten: flatten, Filter: filter);
        return await ExecuteCommandAsync(SetAutoAttachCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetAutoAttachCommandParameters, SetAutoAttachResult> SetAutoAttachCommand = new("Target.setAutoAttach", JsonContext.SetAutoAttachCommandParameters, JsonContext.SetAutoAttachResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<AutoAttachRelatedResult> AutoAttachRelatedAsync(TargetID targetId, bool waitForDebuggerOnStart, ImmutableArray<FilterEntry>? filter = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new AutoAttachRelatedCommandParameters(TargetId: targetId, WaitForDebuggerOnStart: waitForDebuggerOnStart, Filter: filter);
        return await ExecuteCommandAsync(AutoAttachRelatedCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AutoAttachRelatedCommandParameters, AutoAttachRelatedResult> AutoAttachRelatedCommand = new("Target.autoAttachRelated", JsonContext.AutoAttachRelatedCommandParameters, JsonContext.AutoAttachRelatedResult);

    public async Task<SetDiscoverTargetsResult> SetDiscoverTargetsAsync(bool discover, ImmutableArray<FilterEntry>? filter = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetDiscoverTargetsCommandParameters(Discover: discover, Filter: filter);
        return await ExecuteCommandAsync(SetDiscoverTargetsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetDiscoverTargetsCommandParameters, SetDiscoverTargetsResult> SetDiscoverTargetsCommand = new("Target.setDiscoverTargets", JsonContext.SetDiscoverTargetsCommandParameters, JsonContext.SetDiscoverTargetsResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetRemoteLocationsResult> SetRemoteLocationsAsync(ImmutableArray<RemoteLocation> locations, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetRemoteLocationsCommandParameters(Locations: locations);
        return await ExecuteCommandAsync(SetRemoteLocationsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetRemoteLocationsCommandParameters, SetRemoteLocationsResult> SetRemoteLocationsCommand = new("Target.setRemoteLocations", JsonContext.SetRemoteLocationsCommandParameters, JsonContext.SetRemoteLocationsResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetDevToolsTargetResult> GetDevToolsTargetAsync(TargetID targetId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetDevToolsTargetCommandParameters(TargetId: targetId);
        return await ExecuteCommandAsync(GetDevToolsTargetCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetDevToolsTargetCommandParameters, GetDevToolsTargetResult> GetDevToolsTargetCommand = new("Target.getDevToolsTarget", JsonContext.GetDevToolsTargetCommandParameters, JsonContext.GetDevToolsTargetResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<OpenDevToolsResult> OpenDevToolsAsync(TargetID targetId, string? panelId = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new OpenDevToolsCommandParameters(TargetId: targetId, PanelId: panelId);
        return await ExecuteCommandAsync(OpenDevToolsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<OpenDevToolsCommandParameters, OpenDevToolsResult> OpenDevToolsCommand = new("Target.openDevTools", JsonContext.OpenDevToolsCommandParameters, JsonContext.OpenDevToolsResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<AttachedToTargetEventArgs> AttachedToTarget => CreateCdpEventSource(TargetDomainEvent.AttachedToTarget);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DetachedFromTargetEventArgs> DetachedFromTarget => CreateCdpEventSource(TargetDomainEvent.DetachedFromTarget);
    public IEventSource<ReceivedMessageFromTargetEventArgs> ReceivedMessageFromTarget => CreateCdpEventSource(TargetDomainEvent.ReceivedMessageFromTarget);
    public IEventSource<TargetCreatedEventArgs> TargetCreated => CreateCdpEventSource(TargetDomainEvent.TargetCreated);
    public IEventSource<TargetDestroyedEventArgs> TargetDestroyed => CreateCdpEventSource(TargetDomainEvent.TargetDestroyed);
    public IEventSource<TargetCrashedEventArgs> TargetCrashed => CreateCdpEventSource(TargetDomainEvent.TargetCrashed);
    public IEventSource<TargetInfoChangedEventArgs> TargetInfoChanged => CreateCdpEventSource(TargetDomainEvent.TargetInfoChanged);
}

internal sealed record ActivateTargetCommandParameters(TargetID TargetId) : Parameters;

/// <summary>
/// </summary>
public sealed record ActivateTargetResult() : EmptyResult;


internal sealed record AttachToTargetCommandParameters(TargetID TargetId, bool? Flatten) : Parameters;

/// <summary>
/// </summary>
/// <param name="SessionId">
/// Id assigned to the session.
/// </param>
public sealed record AttachToTargetResult(SessionID SessionId) : EmptyResult;


internal sealed record AttachToBrowserTargetCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="SessionId">
/// Id assigned to the session.
/// </param>
public sealed record AttachToBrowserTargetResult(SessionID SessionId) : EmptyResult;


internal sealed record CloseTargetCommandParameters(TargetID TargetId) : Parameters;

/// <summary>
/// </summary>
/// <param name="Success">
/// Always set to true. If an error occurs, the response indicates protocol error.
/// </param>
public sealed record CloseTargetResult(bool Success) : EmptyResult;


internal sealed record ExposeDevToolsProtocolCommandParameters(TargetID TargetId, string? BindingName, bool? InheritPermissions) : Parameters;

/// <summary>
/// </summary>
public sealed record ExposeDevToolsProtocolResult() : EmptyResult;


internal sealed record CreateBrowserContextCommandParameters(bool? DisposeOnDetach, string? ProxyServer, string? ProxyBypassList, ImmutableArray<string>? OriginsWithUniversalNetworkAccess) : Parameters;

/// <summary>
/// </summary>
/// <param name="BrowserContextId">
/// The id of the context created.
/// </param>
public sealed record CreateBrowserContextResult(Browser.BrowserContextID BrowserContextId) : EmptyResult;


internal sealed record GetBrowserContextsCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="BrowserContextIds">
/// An array of browser context ids.
/// </param>
/// <param name="DefaultBrowserContextId">
/// The id of the default browser context if available.
/// </param>
public sealed record GetBrowserContextsResult(ImmutableArray<Browser.BrowserContextID> BrowserContextIds, Browser.BrowserContextID? DefaultBrowserContextId) : EmptyResult;


internal sealed record CreateTargetCommandParameters(string Url, long? Left, long? Top, long? Width, long? Height, WindowState? WindowState, Browser.BrowserContextID? BrowserContextId, bool? EnableBeginFrameControl, bool? NewWindow, bool? Background, bool? ForTab, bool? Hidden, bool? Focus) : Parameters;

/// <summary>
/// </summary>
/// <param name="TargetId">
/// The id of the page opened.
/// </param>
public sealed record CreateTargetResult(TargetID TargetId) : EmptyResult;


internal sealed record DetachFromTargetCommandParameters(SessionID? SessionId, TargetID? TargetId) : Parameters;

/// <summary>
/// </summary>
public sealed record DetachFromTargetResult() : EmptyResult;


internal sealed record DisposeBrowserContextCommandParameters(Browser.BrowserContextID BrowserContextId) : Parameters;

/// <summary>
/// </summary>
public sealed record DisposeBrowserContextResult() : EmptyResult;


internal sealed record GetTargetInfoCommandParameters(TargetID? TargetId) : Parameters;

/// <summary>
/// </summary>
/// <param name="TargetInfo">
/// </param>
public sealed record GetTargetInfoResult(TargetInfo TargetInfo) : EmptyResult;


internal sealed record GetTargetsCommandParameters(ImmutableArray<FilterEntry>? Filter) : Parameters;

/// <summary>
/// </summary>
/// <param name="TargetInfos">
/// The list of targets.
/// </param>
public sealed record GetTargetsResult(ImmutableArray<TargetInfo> TargetInfos) : EmptyResult;


internal sealed record SendMessageToTargetCommandParameters(string Message, SessionID? SessionId, TargetID? TargetId) : Parameters;

/// <summary>
/// </summary>
public sealed record SendMessageToTargetResult() : EmptyResult;


internal sealed record SetAutoAttachCommandParameters(bool AutoAttach, bool WaitForDebuggerOnStart, bool? Flatten, ImmutableArray<FilterEntry>? Filter) : Parameters;

/// <summary>
/// </summary>
public sealed record SetAutoAttachResult() : EmptyResult;


internal sealed record AutoAttachRelatedCommandParameters(TargetID TargetId, bool WaitForDebuggerOnStart, ImmutableArray<FilterEntry>? Filter) : Parameters;

/// <summary>
/// </summary>
public sealed record AutoAttachRelatedResult() : EmptyResult;


internal sealed record SetDiscoverTargetsCommandParameters(bool Discover, ImmutableArray<FilterEntry>? Filter) : Parameters;

/// <summary>
/// </summary>
public sealed record SetDiscoverTargetsResult() : EmptyResult;


internal sealed record SetRemoteLocationsCommandParameters(ImmutableArray<RemoteLocation> Locations) : Parameters;

/// <summary>
/// </summary>
public sealed record SetRemoteLocationsResult() : EmptyResult;


internal sealed record GetDevToolsTargetCommandParameters(TargetID TargetId) : Parameters;

/// <summary>
/// </summary>
/// <param name="TargetId">
/// The targetId of DevTools page target if exists.
/// </param>
public sealed record GetDevToolsTargetResult(TargetID? TargetId) : EmptyResult;


internal sealed record OpenDevToolsCommandParameters(TargetID TargetId, string? PanelId) : Parameters;

/// <summary>
/// </summary>
/// <param name="TargetId">
/// The targetId of DevTools page target.
/// </param>
public sealed record OpenDevToolsResult(TargetID TargetId) : EmptyResult;


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
    /// Id of the parent target, if any. For example, "iframe" target may have a "page" parent.
    /// </summary>
    public TargetID? ParentId { get; init; }

    /// <summary>
    /// Opener target Id
    /// </summary>
    public TargetID? OpenerId { get; init; }

    /// <summary>
    /// Frame id of originating window (is only set if target has an opener).
    /// </summary>
    public Page.FrameId? OpenerFrameId { get; init; }

    /// <summary>
    /// Id of the parent frame, present for "iframe" and "worker" targets. For nested workers,
    /// this is the "ancestor" frame that created the first worker in the nested chain.
    /// </summary>
    public Page.FrameId? ParentFrameId { get; init; }

    /// <summary>
    /// </summary>
    public Browser.BrowserContextID? BrowserContextId { get; init; }

    /// <summary>
    /// Provides additional details for specific target types. For example, for
    /// the type of "page", this may be set to "prerender".
    /// </summary>
    public string? Subtype { get; init; }

    /// <summary>
    /// Embedder-specific target metadata. This is only set for targets of
    /// type "tab".
    /// </summary>
    public global::System.Text.Json.JsonElement? EmbedderData { get; init; }
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
[JsonSerializable(typeof(GetDevToolsTargetCommandParameters), TypeInfoPropertyName = "GetDevToolsTargetCommandParameters")]
[JsonSerializable(typeof(GetDevToolsTargetResult), TypeInfoPropertyName = "GetDevToolsTargetResult")]
[JsonSerializable(typeof(OpenDevToolsCommandParameters), TypeInfoPropertyName = "OpenDevToolsCommandParameters")]
[JsonSerializable(typeof(OpenDevToolsResult), TypeInfoPropertyName = "OpenDevToolsResult")]
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
[JsonSerializable(typeof(ImmutableArray<Browser.BrowserContextID>), TypeInfoPropertyName = "ImmutableArrayBrowserBrowserContextID")]
[JsonSerializable(typeof(ImmutableArray<TargetInfo>), TypeInfoPropertyName = "ImmutableArrayTargetTargetInfo")]
[JsonSerializable(typeof(ImmutableArray<RemoteLocation>), TypeInfoPropertyName = "ImmutableArrayTargetRemoteLocation")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class TargetJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="ITarget"/>.
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
