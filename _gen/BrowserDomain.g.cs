#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Browser;

/// <summary>
/// The Browser domain defines methods and events for browser managing.
/// </summary>
public sealed class BrowserDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static BrowserJsonSerializerContext JsonContext = BrowserJsonSerializerContext.Default;

    /// <summary>
    /// Set permission settings for given embedding and embedded origins.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Origin</b> - Embedding origin the permission applies to, all origins if not specified.</description></item>
    /// <item><description><b>EmbeddedOrigin</b> - Embedded origin the permission applies to. It is ignored unless the embedding origin is present and valid. If the embedding origin is provided but the embedded origin isn't, the embedding origin is used as the embedded origin.</description></item>
    /// <item><description><b>BrowserContextId</b> - Context to override. When omitted, default browser context is used.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="permission">
    /// Descriptor of permission to override.
    /// </param>
    /// <param name="setting">
    /// Setting of the permission.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetPermissionCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetPermissionResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetPermissionResult> SetPermissionAsync(PermissionDescriptor permission, PermissionSetting setting, SetPermissionCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetPermissionCommandParameters(Permission: permission, Setting: setting, Origin: options?.Origin, EmbeddedOrigin: options?.EmbeddedOrigin, BrowserContextId: options?.BrowserContextId);
        return await ExecuteCommandAsync(SetPermissionCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetPermissionCommandParameters, SetPermissionResult> SetPermissionCommand = new("Browser.setPermission", JsonContext.SetPermissionCommandParameters, JsonContext.SetPermissionResult);

    /// <summary>
    /// Grant specific permissions to the given origin and reject all others. Deprecated. Use
    /// setPermission instead.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Origin</b> - Origin the permission applies to, all origins if not specified.</description></item>
    /// <item><description><b>BrowserContextId</b> - BrowserContext to override permissions. When omitted, default browser context is used.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="permissions">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GrantPermissionsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GrantPermissionsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<GrantPermissionsResult> GrantPermissionsAsync(IEnumerable<PermissionType> permissions, GrantPermissionsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GrantPermissionsCommandParameters(Permissions: permissions, Origin: options?.Origin, BrowserContextId: options?.BrowserContextId);
        return await ExecuteCommandAsync(GrantPermissionsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GrantPermissionsCommandParameters, GrantPermissionsResult> GrantPermissionsCommand = new("Browser.grantPermissions", JsonContext.GrantPermissionsCommandParameters, JsonContext.GrantPermissionsResult);

    /// <summary>
    /// Reset all permission management for all origins.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>BrowserContextId</b> - BrowserContext to reset permissions. When omitted, default browser context is used.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="ResetPermissionsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ResetPermissionsResult"/>.
    /// </returns>
    public async Task<ResetPermissionsResult> ResetPermissionsAsync(ResetPermissionsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ResetPermissionsCommandParameters(BrowserContextId: options?.BrowserContextId);
        return await ExecuteCommandAsync(ResetPermissionsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ResetPermissionsCommandParameters, ResetPermissionsResult> ResetPermissionsCommand = new("Browser.resetPermissions", JsonContext.ResetPermissionsCommandParameters, JsonContext.ResetPermissionsResult);

    /// <summary>
    /// Set the behavior when downloading a file.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>BrowserContextId</b> - BrowserContext to set download behavior. When omitted, default browser context is used.</description></item>
    /// <item><description><b>DownloadPath</b> - The default path to save downloaded files to. This is required if behavior is set to 'allow' or 'allowAndName'.</description></item>
    /// <item><description><b>EventsEnabled</b> - Whether to emit download events (defaults to false).</description></item>
    /// </list>
    /// </remarks>
    /// <param name="behavior">
    /// Whether to allow all or deny all download requests, or use default Chrome behavior if
    /// available (otherwise deny). |allowAndName| allows download and names files according to
    /// their download guids.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetDownloadBehaviorCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetDownloadBehaviorResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetDownloadBehaviorResult> SetDownloadBehaviorAsync(string behavior, SetDownloadBehaviorCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetDownloadBehaviorCommandParameters(Behavior: behavior, BrowserContextId: options?.BrowserContextId, DownloadPath: options?.DownloadPath, EventsEnabled: options?.EventsEnabled);
        return await ExecuteCommandAsync(SetDownloadBehaviorCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetDownloadBehaviorCommandParameters, SetDownloadBehaviorResult> SetDownloadBehaviorCommand = new("Browser.setDownloadBehavior", JsonContext.SetDownloadBehaviorCommandParameters, JsonContext.SetDownloadBehaviorResult);

    /// <summary>
    /// Cancel a download if in progress
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>BrowserContextId</b> - BrowserContext to perform the action in. When omitted, default browser context is used.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="guid">
    /// Global unique identifier of the download.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="CancelDownloadCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CancelDownloadResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<CancelDownloadResult> CancelDownloadAsync(string guid, CancelDownloadCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new CancelDownloadCommandParameters(Guid: guid, BrowserContextId: options?.BrowserContextId);
        return await ExecuteCommandAsync(CancelDownloadCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CancelDownloadCommandParameters, CancelDownloadResult> CancelDownloadCommand = new("Browser.cancelDownload", JsonContext.CancelDownloadCommandParameters, JsonContext.CancelDownloadResult);

    /// <summary>
    /// Close browser gracefully.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="CloseCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CloseResult"/>.
    /// </returns>
    public async Task<CloseResult> CloseAsync(CloseCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new CloseCommandParameters();
        return await ExecuteCommandAsync(CloseCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CloseCommandParameters, CloseResult> CloseCommand = new("Browser.close", JsonContext.CloseCommandParameters, JsonContext.CloseResult);

    /// <summary>
    /// Crashes browser on the main thread.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="CrashCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CrashResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<CrashResult> CrashAsync(CrashCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new CrashCommandParameters();
        return await ExecuteCommandAsync(CrashCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CrashCommandParameters, CrashResult> CrashCommand = new("Browser.crash", JsonContext.CrashCommandParameters, JsonContext.CrashResult);

    /// <summary>
    /// Crashes GPU process.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="CrashGpuProcessCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CrashGpuProcessResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<CrashGpuProcessResult> CrashGpuProcessAsync(CrashGpuProcessCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new CrashGpuProcessCommandParameters();
        return await ExecuteCommandAsync(CrashGpuProcessCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CrashGpuProcessCommandParameters, CrashGpuProcessResult> CrashGpuProcessCommand = new("Browser.crashGpuProcess", JsonContext.CrashGpuProcessCommandParameters, JsonContext.CrashGpuProcessResult);

    /// <summary>
    /// Returns version information.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetVersionCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetVersionResult"/>.
    /// </returns>
    public async Task<GetVersionResult> GetVersionAsync(GetVersionCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetVersionCommandParameters();
        return await ExecuteCommandAsync(GetVersionCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetVersionCommandParameters, GetVersionResult> GetVersionCommand = new("Browser.getVersion", JsonContext.GetVersionCommandParameters, JsonContext.GetVersionResult);

    /// <summary>
    /// Returns the command line switches for the browser process if, and only if
    /// --enable-automation is on the commandline.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetBrowserCommandLineCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetBrowserCommandLineResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetBrowserCommandLineResult> GetBrowserCommandLineAsync(GetBrowserCommandLineCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetBrowserCommandLineCommandParameters();
        return await ExecuteCommandAsync(GetBrowserCommandLineCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetBrowserCommandLineCommandParameters, GetBrowserCommandLineResult> GetBrowserCommandLineCommand = new("Browser.getBrowserCommandLine", JsonContext.GetBrowserCommandLineCommandParameters, JsonContext.GetBrowserCommandLineResult);

    /// <summary>
    /// Get Chrome histograms.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Query</b> - Requested substring in name. Only histograms which have query as a substring in their name are extracted. An empty or absent query returns all histograms.</description></item>
    /// <item><description><b>Delta</b> - If true, retrieve delta since last delta call.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetHistogramsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetHistogramsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetHistogramsResult> GetHistogramsAsync(GetHistogramsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetHistogramsCommandParameters(Query: options?.Query, Delta: options?.Delta);
        return await ExecuteCommandAsync(GetHistogramsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetHistogramsCommandParameters, GetHistogramsResult> GetHistogramsCommand = new("Browser.getHistograms", JsonContext.GetHistogramsCommandParameters, JsonContext.GetHistogramsResult);

    /// <summary>
    /// Get a Chrome histogram by name.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Delta</b> - If true, retrieve delta since last delta call.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="name">
    /// Requested histogram name.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetHistogramCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetHistogramResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetHistogramResult> GetHistogramAsync(string name, GetHistogramCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetHistogramCommandParameters(Name: name, Delta: options?.Delta);
        return await ExecuteCommandAsync(GetHistogramCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetHistogramCommandParameters, GetHistogramResult> GetHistogramCommand = new("Browser.getHistogram", JsonContext.GetHistogramCommandParameters, JsonContext.GetHistogramResult);

    /// <summary>
    /// Get position and size of the browser window.
    /// </summary>
    /// <param name="windowId">
    /// Browser window id.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetWindowBoundsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetWindowBoundsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetWindowBoundsResult> GetWindowBoundsAsync(WindowID windowId, GetWindowBoundsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetWindowBoundsCommandParameters(WindowId: windowId);
        return await ExecuteCommandAsync(GetWindowBoundsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetWindowBoundsCommandParameters, GetWindowBoundsResult> GetWindowBoundsCommand = new("Browser.getWindowBounds", JsonContext.GetWindowBoundsCommandParameters, JsonContext.GetWindowBoundsResult);

    /// <summary>
    /// Get the browser window that contains the devtools target.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>TargetId</b> - Devtools agent host id. If called as a part of the session, associated targetId is used.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetWindowForTargetCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetWindowForTargetResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetWindowForTargetResult> GetWindowForTargetAsync(GetWindowForTargetCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetWindowForTargetCommandParameters(TargetId: options?.TargetId);
        return await ExecuteCommandAsync(GetWindowForTargetCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetWindowForTargetCommandParameters, GetWindowForTargetResult> GetWindowForTargetCommand = new("Browser.getWindowForTarget", JsonContext.GetWindowForTargetCommandParameters, JsonContext.GetWindowForTargetResult);

    /// <summary>
    /// Set position and/or size of the browser window.
    /// </summary>
    /// <param name="windowId">
    /// Browser window id.
    /// </param>
    /// <param name="bounds">
    /// New window bounds. The 'minimized', 'maximized' and 'fullscreen' states cannot be combined
    /// with 'left', 'top', 'width' or 'height'. Leaves unspecified fields unchanged.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetWindowBoundsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetWindowBoundsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetWindowBoundsResult> SetWindowBoundsAsync(WindowID windowId, Bounds bounds, SetWindowBoundsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetWindowBoundsCommandParameters(WindowId: windowId, Bounds: bounds);
        return await ExecuteCommandAsync(SetWindowBoundsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetWindowBoundsCommandParameters, SetWindowBoundsResult> SetWindowBoundsCommand = new("Browser.setWindowBounds", JsonContext.SetWindowBoundsCommandParameters, JsonContext.SetWindowBoundsResult);

    /// <summary>
    /// Set size of the browser contents resizing browser window as necessary.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Width</b> - The window contents width in DIP. Assumes current width if omitted. Must be specified if 'height' is omitted.</description></item>
    /// <item><description><b>Height</b> - The window contents height in DIP. Assumes current height if omitted. Must be specified if 'width' is omitted.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="windowId">
    /// Browser window id.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetContentsSizeCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetContentsSizeResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetContentsSizeResult> SetContentsSizeAsync(WindowID windowId, SetContentsSizeCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetContentsSizeCommandParameters(WindowId: windowId, Width: options?.Width, Height: options?.Height);
        return await ExecuteCommandAsync(SetContentsSizeCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetContentsSizeCommandParameters, SetContentsSizeResult> SetContentsSizeCommand = new("Browser.setContentsSize", JsonContext.SetContentsSizeCommandParameters, JsonContext.SetContentsSizeResult);

    /// <summary>
    /// Set dock tile details, platform-specific.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>BadgeLabel</b></description></item>
    /// <item><description><b>Image</b> - Png encoded image. (Encoded as a base64 string when passed over JSON)</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetDockTileCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetDockTileResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetDockTileResult> SetDockTileAsync(SetDockTileCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetDockTileCommandParameters(BadgeLabel: options?.BadgeLabel, Image: options?.Image);
        return await ExecuteCommandAsync(SetDockTileCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetDockTileCommandParameters, SetDockTileResult> SetDockTileCommand = new("Browser.setDockTile", JsonContext.SetDockTileCommandParameters, JsonContext.SetDockTileResult);

    /// <summary>
    /// Invoke custom browser commands used by telemetry.
    /// </summary>
    /// <param name="commandId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ExecuteBrowserCommandCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ExecuteBrowserCommandResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<ExecuteBrowserCommandResult> ExecuteBrowserCommandAsync(BrowserCommandId commandId, ExecuteBrowserCommandCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ExecuteBrowserCommandCommandParameters(CommandId: commandId);
        return await ExecuteCommandAsync(ExecuteBrowserCommandCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ExecuteBrowserCommandCommandParameters, ExecuteBrowserCommandResult> ExecuteBrowserCommandCommand = new("Browser.executeBrowserCommand", JsonContext.ExecuteBrowserCommandCommandParameters, JsonContext.ExecuteBrowserCommandResult);

    /// <summary>
    /// Allows a site to use privacy sandbox features that require enrollment
    /// without the site actually being enrolled. Only supported on page targets.
    /// </summary>
    /// <param name="url">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="AddPrivacySandboxEnrollmentOverrideCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AddPrivacySandboxEnrollmentOverrideResult"/>.
    /// </returns>
    public async Task<AddPrivacySandboxEnrollmentOverrideResult> AddPrivacySandboxEnrollmentOverrideAsync(string url, AddPrivacySandboxEnrollmentOverrideCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new AddPrivacySandboxEnrollmentOverrideCommandParameters(Url: url);
        return await ExecuteCommandAsync(AddPrivacySandboxEnrollmentOverrideCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AddPrivacySandboxEnrollmentOverrideCommandParameters, AddPrivacySandboxEnrollmentOverrideResult> AddPrivacySandboxEnrollmentOverrideCommand = new("Browser.addPrivacySandboxEnrollmentOverride", JsonContext.AddPrivacySandboxEnrollmentOverrideCommandParameters, JsonContext.AddPrivacySandboxEnrollmentOverrideResult);

    /// <summary>
    /// Configures encryption keys used with a given privacy sandbox API to talk
    /// to a trusted coordinator.  Since this is intended for test automation only,
    /// coordinatorOrigin must be a .test domain. No existing coordinator
    /// configuration for the origin may exist.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>BrowserContextId</b> - BrowserContext to perform the action in. When omitted, default browser context is used.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="api">
    /// </param>
    /// <param name="coordinatorOrigin">
    /// </param>
    /// <param name="keyConfig">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="AddPrivacySandboxCoordinatorKeyConfigCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AddPrivacySandboxCoordinatorKeyConfigResult"/>.
    /// </returns>
    public async Task<AddPrivacySandboxCoordinatorKeyConfigResult> AddPrivacySandboxCoordinatorKeyConfigAsync(PrivacySandboxAPI api, string coordinatorOrigin, string keyConfig, AddPrivacySandboxCoordinatorKeyConfigCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new AddPrivacySandboxCoordinatorKeyConfigCommandParameters(Api: api, CoordinatorOrigin: coordinatorOrigin, KeyConfig: keyConfig, BrowserContextId: options?.BrowserContextId);
        return await ExecuteCommandAsync(AddPrivacySandboxCoordinatorKeyConfigCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AddPrivacySandboxCoordinatorKeyConfigCommandParameters, AddPrivacySandboxCoordinatorKeyConfigResult> AddPrivacySandboxCoordinatorKeyConfigCommand = new("Browser.addPrivacySandboxCoordinatorKeyConfig", JsonContext.AddPrivacySandboxCoordinatorKeyConfigCommandParameters, JsonContext.AddPrivacySandboxCoordinatorKeyConfigResult);

    /// <summary>
    /// Fired when page is about to start a download.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DownloadWillBeginEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>FrameId</b> - Id of the frame that caused the download to begin.</description></item>
    /// <item><description><b>Guid</b> - Global unique identifier of the download.</description></item>
    /// <item><description><b>Url</b> - URL of the resource being downloaded.</description></item>
    /// <item><description><b>SuggestedFilename</b> - Suggested file name of the resource (the actual name of the file saved on disk may differ).</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DownloadWillBeginEventArgs> DownloadWillBegin => CreateCdpEventSource(BrowserDomainEvent.DownloadWillBegin);
    /// <summary>
    /// Fired when download makes progress. Last call has |done| == true.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DownloadProgressEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Guid</b> - Global unique identifier of the download.</description></item>
    /// <item><description><b>TotalBytes</b> - Total expected bytes to download.</description></item>
    /// <item><description><b>ReceivedBytes</b> - Total bytes received.</description></item>
    /// <item><description><b>State</b> - Download status.</description></item>
    /// <item><description><b>FilePath</b> - If download is "completed", provides the path of the downloaded file. Depending on the platform, it is not guaranteed to be set, nor the file is guaranteed to exist.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DownloadProgressEventArgs> DownloadProgress => CreateCdpEventSource(BrowserDomainEvent.DownloadProgress);
}

internal sealed record SetPermissionCommandParameters(PermissionDescriptor Permission, PermissionSetting Setting, string? Origin, string? EmbeddedOrigin, BrowserContextID? BrowserContextId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="BrowserDomain.SetPermissionAsync"/>.
/// </summary>
public sealed record SetPermissionCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Embedding origin the permission applies to, all origins if not specified.
    /// </summary>
    public string? Origin { get; init; }

    /// <summary>
    /// Embedded origin the permission applies to. It is ignored unless the embedding origin is
    /// present and valid. If the embedding origin is provided but the embedded origin isn't, the
    /// embedding origin is used as the embedded origin.
    /// </summary>
    public string? EmbeddedOrigin { get; init; }

    /// <summary>
    /// Context to override. When omitted, default browser context is used.
    /// </summary>
    public BrowserContextID? BrowserContextId { get; init; }
}

/// <summary>
/// </summary>
public sealed record SetPermissionResult() : EmptyResult;


internal sealed record GrantPermissionsCommandParameters(IEnumerable<PermissionType> Permissions, string? Origin, BrowserContextID? BrowserContextId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="BrowserDomain.GrantPermissionsAsync"/>.
/// </summary>
public sealed record GrantPermissionsCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Origin the permission applies to, all origins if not specified.
    /// </summary>
    public string? Origin { get; init; }

    /// <summary>
    /// BrowserContext to override permissions. When omitted, default browser context is used.
    /// </summary>
    public BrowserContextID? BrowserContextId { get; init; }
}

/// <summary>
/// </summary>
public sealed record GrantPermissionsResult() : EmptyResult;


internal sealed record ResetPermissionsCommandParameters(BrowserContextID? BrowserContextId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="BrowserDomain.ResetPermissionsAsync"/>.
/// </summary>
public sealed record ResetPermissionsCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// BrowserContext to reset permissions. When omitted, default browser context is used.
    /// </summary>
    public BrowserContextID? BrowserContextId { get; init; }
}

/// <summary>
/// </summary>
public sealed record ResetPermissionsResult() : EmptyResult;


internal sealed record SetDownloadBehaviorCommandParameters(string Behavior, BrowserContextID? BrowserContextId, string? DownloadPath, bool? EventsEnabled) : Parameters;

/// <summary>
/// Optional parameters for <see cref="BrowserDomain.SetDownloadBehaviorAsync"/>.
/// </summary>
public sealed record SetDownloadBehaviorCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// BrowserContext to set download behavior. When omitted, default browser context is used.
    /// </summary>
    public BrowserContextID? BrowserContextId { get; init; }

    /// <summary>
    /// The default path to save downloaded files to. This is required if behavior is set to 'allow'
    /// or 'allowAndName'.
    /// </summary>
    public string? DownloadPath { get; init; }

    /// <summary>
    /// Whether to emit download events (defaults to false).
    /// </summary>
    public bool? EventsEnabled { get; init; }
}

/// <summary>
/// </summary>
public sealed record SetDownloadBehaviorResult() : EmptyResult;


internal sealed record CancelDownloadCommandParameters(string Guid, BrowserContextID? BrowserContextId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="BrowserDomain.CancelDownloadAsync"/>.
/// </summary>
public sealed record CancelDownloadCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// BrowserContext to perform the action in. When omitted, default browser context is used.
    /// </summary>
    public BrowserContextID? BrowserContextId { get; init; }
}

/// <summary>
/// </summary>
public sealed record CancelDownloadResult() : EmptyResult;


internal sealed record CloseCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="BrowserDomain.CloseAsync"/>.
/// </summary>
public sealed record CloseCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record CloseResult() : EmptyResult;


internal sealed record CrashCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="BrowserDomain.CrashAsync"/>.
/// </summary>
public sealed record CrashCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record CrashResult() : EmptyResult;


internal sealed record CrashGpuProcessCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="BrowserDomain.CrashGpuProcessAsync"/>.
/// </summary>
public sealed record CrashGpuProcessCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record CrashGpuProcessResult() : EmptyResult;


internal sealed record GetVersionCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="BrowserDomain.GetVersionAsync"/>.
/// </summary>
public sealed record GetVersionCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="ProtocolVersion">
/// Protocol version.
/// </param>
/// <param name="Product">
/// Product name.
/// </param>
/// <param name="Revision">
/// Product revision.
/// </param>
/// <param name="UserAgent">
/// User-Agent.
/// </param>
/// <param name="JsVersion">
/// V8 version.
/// </param>
public sealed record GetVersionResult(string ProtocolVersion, string Product, string Revision, string UserAgent, string JsVersion) : EmptyResult;


internal sealed record GetBrowserCommandLineCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="BrowserDomain.GetBrowserCommandLineAsync"/>.
/// </summary>
public sealed record GetBrowserCommandLineCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Arguments">
/// Commandline parameters
/// </param>
public sealed record GetBrowserCommandLineResult(IReadOnlyList<string> Arguments) : EmptyResult;


internal sealed record GetHistogramsCommandParameters(string? Query, bool? Delta) : Parameters;

/// <summary>
/// Optional parameters for <see cref="BrowserDomain.GetHistogramsAsync"/>.
/// </summary>
public sealed record GetHistogramsCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Requested substring in name. Only histograms which have query as a
    /// substring in their name are extracted. An empty or absent query returns
    /// all histograms.
    /// </summary>
    public string? Query { get; init; }

    /// <summary>
    /// If true, retrieve delta since last delta call.
    /// </summary>
    public bool? Delta { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Histograms">
/// Histograms.
/// </param>
public sealed record GetHistogramsResult(IReadOnlyList<Histogram> Histograms) : EmptyResult;


internal sealed record GetHistogramCommandParameters(string Name, bool? Delta) : Parameters;

/// <summary>
/// Optional parameters for <see cref="BrowserDomain.GetHistogramAsync"/>.
/// </summary>
public sealed record GetHistogramCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// If true, retrieve delta since last delta call.
    /// </summary>
    public bool? Delta { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Histogram">
/// Histogram.
/// </param>
public sealed record GetHistogramResult(Histogram Histogram) : EmptyResult;


internal sealed record GetWindowBoundsCommandParameters(WindowID WindowId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="BrowserDomain.GetWindowBoundsAsync"/>.
/// </summary>
public sealed record GetWindowBoundsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Bounds">
/// Bounds information of the window. When window state is 'minimized', the restored window
/// position and size are returned.
/// </param>
public sealed record GetWindowBoundsResult(Bounds Bounds) : EmptyResult;


internal sealed record GetWindowForTargetCommandParameters(Target.TargetID? TargetId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="BrowserDomain.GetWindowForTargetAsync"/>.
/// </summary>
public sealed record GetWindowForTargetCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Devtools agent host id. If called as a part of the session, associated targetId is used.
    /// </summary>
    public Target.TargetID? TargetId { get; init; }
}

/// <summary>
/// </summary>
/// <param name="WindowId">
/// Browser window id.
/// </param>
/// <param name="Bounds">
/// Bounds information of the window. When window state is 'minimized', the restored window
/// position and size are returned.
/// </param>
public sealed record GetWindowForTargetResult(WindowID WindowId, Bounds Bounds) : EmptyResult;


internal sealed record SetWindowBoundsCommandParameters(WindowID WindowId, Bounds Bounds) : Parameters;

/// <summary>
/// Optional parameters for <see cref="BrowserDomain.SetWindowBoundsAsync"/>.
/// </summary>
public sealed record SetWindowBoundsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetWindowBoundsResult() : EmptyResult;


internal sealed record SetContentsSizeCommandParameters(WindowID WindowId, long? Width, long? Height) : Parameters;

/// <summary>
/// Optional parameters for <see cref="BrowserDomain.SetContentsSizeAsync"/>.
/// </summary>
public sealed record SetContentsSizeCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// The window contents width in DIP. Assumes current width if omitted.
    /// Must be specified if 'height' is omitted.
    /// </summary>
    public long? Width { get; init; }

    /// <summary>
    /// The window contents height in DIP. Assumes current height if omitted.
    /// Must be specified if 'width' is omitted.
    /// </summary>
    public long? Height { get; init; }
}

/// <summary>
/// </summary>
public sealed record SetContentsSizeResult() : EmptyResult;


internal sealed record SetDockTileCommandParameters(string? BadgeLabel, string? Image) : Parameters;

/// <summary>
/// Optional parameters for <see cref="BrowserDomain.SetDockTileAsync"/>.
/// </summary>
public sealed record SetDockTileCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// </summary>
    public string? BadgeLabel { get; init; }

    /// <summary>
    /// Png encoded image. (Encoded as a base64 string when passed over JSON)
    /// </summary>
    public string? Image { get; init; }
}

/// <summary>
/// </summary>
public sealed record SetDockTileResult() : EmptyResult;


internal sealed record ExecuteBrowserCommandCommandParameters(BrowserCommandId CommandId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="BrowserDomain.ExecuteBrowserCommandAsync"/>.
/// </summary>
public sealed record ExecuteBrowserCommandCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ExecuteBrowserCommandResult() : EmptyResult;


internal sealed record AddPrivacySandboxEnrollmentOverrideCommandParameters(string Url) : Parameters;

/// <summary>
/// Optional parameters for <see cref="BrowserDomain.AddPrivacySandboxEnrollmentOverrideAsync"/>.
/// </summary>
public sealed record AddPrivacySandboxEnrollmentOverrideCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record AddPrivacySandboxEnrollmentOverrideResult() : EmptyResult;


internal sealed record AddPrivacySandboxCoordinatorKeyConfigCommandParameters(PrivacySandboxAPI Api, string CoordinatorOrigin, string KeyConfig, BrowserContextID? BrowserContextId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="BrowserDomain.AddPrivacySandboxCoordinatorKeyConfigAsync"/>.
/// </summary>
public sealed record AddPrivacySandboxCoordinatorKeyConfigCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// BrowserContext to perform the action in. When omitted, default browser
    /// context is used.
    /// </summary>
    public BrowserContextID? BrowserContextId { get; init; }
}

/// <summary>
/// </summary>
public sealed record AddPrivacySandboxCoordinatorKeyConfigResult() : EmptyResult;


/// <summary>
/// Fired when page is about to start a download.
/// </summary>
/// <param name="FrameId">
/// Id of the frame that caused the download to begin.
/// </param>
/// <param name="Guid">
/// Global unique identifier of the download.
/// </param>
/// <param name="Url">
/// URL of the resource being downloaded.
/// </param>
/// <param name="SuggestedFilename">
/// Suggested file name of the resource (the actual name of the file saved on disk may differ).
/// </param>
public sealed record DownloadWillBeginEventArgs(Page.FrameId FrameId, string Guid, string Url, string SuggestedFilename) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when download makes progress. Last call has |done| == true.
/// </summary>
/// <param name="Guid">
/// Global unique identifier of the download.
/// </param>
/// <param name="TotalBytes">
/// Total expected bytes to download.
/// </param>
/// <param name="ReceivedBytes">
/// Total bytes received.
/// </param>
/// <param name="State">
/// Download status.
/// </param>
/// <param name="FilePath">
/// If download is "completed", provides the path of the downloaded file.
/// Depending on the platform, it is not guaranteed to be set, nor the file
/// is guaranteed to exist.
/// </param>
public sealed record DownloadProgressEventArgs(string Guid, double TotalBytes, double ReceivedBytes, string State, string? FilePath = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<BrowserContextID>))]
public record BrowserContextID : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.NumberRemoteIdConverter<WindowID>))]
public record WindowID : INumberRemoteId
{
    double INumberRemoteId.Id { get; init; }
}

/// <summary>
/// The state of the browser window.
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

/// <summary>
/// Browser window bounds information
/// </summary>
public sealed record Bounds()
{
    /// <summary>
    /// The offset from the left edge of the screen to the window in pixels.
    /// </summary>
    public long? Left { get; init; }

    /// <summary>
    /// The offset from the top edge of the screen to the window in pixels.
    /// </summary>
    public long? Top { get; init; }

    /// <summary>
    /// The window width in pixels.
    /// </summary>
    public long? Width { get; init; }

    /// <summary>
    /// The window height in pixels.
    /// </summary>
    public long? Height { get; init; }

    /// <summary>
    /// The window state. Default to normal.
    /// </summary>
    public WindowState? WindowState { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<PermissionType>))]
public enum PermissionType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ar")]
    Ar,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("audioCapture")]
    AudioCapture,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("automaticFullscreen")]
    AutomaticFullscreen,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("backgroundFetch")]
    BackgroundFetch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("backgroundSync")]
    BackgroundSync,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("cameraPanTiltZoom")]
    CameraPanTiltZoom,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("capturedSurfaceControl")]
    CapturedSurfaceControl,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("clipboardReadWrite")]
    ClipboardReadWrite,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("clipboardSanitizedWrite")]
    ClipboardSanitizedWrite,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("displayCapture")]
    DisplayCapture,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("durableStorage")]
    DurableStorage,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("geolocation")]
    Geolocation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("handTracking")]
    HandTracking,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("idleDetection")]
    IdleDetection,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("keyboardLock")]
    KeyboardLock,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("localFonts")]
    LocalFonts,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("localNetwork")]
    LocalNetwork,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("localNetworkAccess")]
    LocalNetworkAccess,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("loopbackNetwork")]
    LoopbackNetwork,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("midi")]
    Midi,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("midiSysex")]
    MidiSysex,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("nfc")]
    Nfc,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("notifications")]
    Notifications,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("paymentHandler")]
    PaymentHandler,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("periodicBackgroundSync")]
    PeriodicBackgroundSync,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("pointerLock")]
    PointerLock,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("protectedMediaIdentifier")]
    ProtectedMediaIdentifier,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("sensors")]
    Sensors,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("smartCard")]
    SmartCard,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("speakerSelection")]
    SpeakerSelection,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("storageAccess")]
    StorageAccess,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("topLevelStorageAccess")]
    TopLevelStorageAccess,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("videoCapture")]
    VideoCapture,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("vr")]
    Vr,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("wakeLockScreen")]
    WakeLockScreen,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("wakeLockSystem")]
    WakeLockSystem,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("webAppInstallation")]
    WebAppInstallation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("webPrinting")]
    WebPrinting,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("windowManagement")]
    WindowManagement,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<PermissionSetting>))]
public enum PermissionSetting
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("granted")]
    Granted,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("denied")]
    Denied,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("prompt")]
    Prompt,
}

/// <summary>
/// Definition of PermissionDescriptor defined in the Permissions API:
/// https://w3c.github.io/permissions/#dom-permissiondescriptor.
/// </summary>
/// <param name="Name">
/// Name of permission.
/// See https://cs.chromium.org/chromium/src/third_party/blink/renderer/modules/permissions/permission_descriptor.idl for valid permission names.
/// </param>
public sealed record PermissionDescriptor(string Name)
{
    /// <summary>
    /// For "midi" permission, may also specify sysex control.
    /// </summary>
    public bool? Sysex { get; init; }

    /// <summary>
    /// For "push" permission, may specify userVisibleOnly.
    /// Note that userVisibleOnly = true is the only currently supported type.
    /// </summary>
    public bool? UserVisibleOnly { get; init; }

    /// <summary>
    /// For "clipboard" permission, may specify allowWithoutSanitization.
    /// </summary>
    public bool? AllowWithoutSanitization { get; init; }

    /// <summary>
    /// For "fullscreen" permission, must specify allowWithoutGesture:true.
    /// </summary>
    public bool? AllowWithoutGesture { get; init; }

    /// <summary>
    /// For "camera" permission, may specify panTiltZoom.
    /// </summary>
    public bool? PanTiltZoom { get; init; }
}

/// <summary>
/// Browser command ids used by executeBrowserCommand.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<BrowserCommandId>))]
public enum BrowserCommandId
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("openTabSearch")]
    OpenTabSearch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("closeTabSearch")]
    CloseTabSearch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("openGlic")]
    OpenGlic,
}

/// <summary>
/// Chrome histogram bucket.
/// </summary>
/// <param name="Low">
/// Minimum value (inclusive).
/// </param>
/// <param name="High">
/// Maximum value (exclusive).
/// </param>
/// <param name="Count">
/// Number of samples.
/// </param>
public sealed record Bucket(long Low, long High, long Count)
{
}

/// <summary>
/// Chrome histogram.
/// </summary>
/// <param name="Name">
/// Name.
/// </param>
/// <param name="Sum">
/// Sum of sample values.
/// </param>
/// <param name="Count">
/// Total number of samples.
/// </param>
/// <param name="Buckets">
/// Buckets.
/// </param>
public sealed record Histogram(string Name, long Sum, long Count, IReadOnlyList<Bucket> Buckets)
{
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<PrivacySandboxAPI>))]
public enum PrivacySandboxAPI
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BiddingAndAuctionServices")]
    BiddingAndAuctionServices,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TrustedKeyValue")]
    TrustedKeyValue,
}

[JsonSerializable(typeof(SetPermissionCommandParameters), TypeInfoPropertyName = "SetPermissionCommandParameters")]
[JsonSerializable(typeof(SetPermissionResult), TypeInfoPropertyName = "SetPermissionResult")]
[JsonSerializable(typeof(GrantPermissionsCommandParameters), TypeInfoPropertyName = "GrantPermissionsCommandParameters")]
[JsonSerializable(typeof(GrantPermissionsResult), TypeInfoPropertyName = "GrantPermissionsResult")]
[JsonSerializable(typeof(ResetPermissionsCommandParameters), TypeInfoPropertyName = "ResetPermissionsCommandParameters")]
[JsonSerializable(typeof(ResetPermissionsResult), TypeInfoPropertyName = "ResetPermissionsResult")]
[JsonSerializable(typeof(SetDownloadBehaviorCommandParameters), TypeInfoPropertyName = "SetDownloadBehaviorCommandParameters")]
[JsonSerializable(typeof(SetDownloadBehaviorResult), TypeInfoPropertyName = "SetDownloadBehaviorResult")]
[JsonSerializable(typeof(CancelDownloadCommandParameters), TypeInfoPropertyName = "CancelDownloadCommandParameters")]
[JsonSerializable(typeof(CancelDownloadResult), TypeInfoPropertyName = "CancelDownloadResult")]
[JsonSerializable(typeof(CloseCommandParameters), TypeInfoPropertyName = "CloseCommandParameters")]
[JsonSerializable(typeof(CloseResult), TypeInfoPropertyName = "CloseResult")]
[JsonSerializable(typeof(CrashCommandParameters), TypeInfoPropertyName = "CrashCommandParameters")]
[JsonSerializable(typeof(CrashResult), TypeInfoPropertyName = "CrashResult")]
[JsonSerializable(typeof(CrashGpuProcessCommandParameters), TypeInfoPropertyName = "CrashGpuProcessCommandParameters")]
[JsonSerializable(typeof(CrashGpuProcessResult), TypeInfoPropertyName = "CrashGpuProcessResult")]
[JsonSerializable(typeof(GetVersionCommandParameters), TypeInfoPropertyName = "GetVersionCommandParameters")]
[JsonSerializable(typeof(GetVersionResult), TypeInfoPropertyName = "GetVersionResult")]
[JsonSerializable(typeof(GetBrowserCommandLineCommandParameters), TypeInfoPropertyName = "GetBrowserCommandLineCommandParameters")]
[JsonSerializable(typeof(GetBrowserCommandLineResult), TypeInfoPropertyName = "GetBrowserCommandLineResult")]
[JsonSerializable(typeof(GetHistogramsCommandParameters), TypeInfoPropertyName = "GetHistogramsCommandParameters")]
[JsonSerializable(typeof(GetHistogramsResult), TypeInfoPropertyName = "GetHistogramsResult")]
[JsonSerializable(typeof(GetHistogramCommandParameters), TypeInfoPropertyName = "GetHistogramCommandParameters")]
[JsonSerializable(typeof(GetHistogramResult), TypeInfoPropertyName = "GetHistogramResult")]
[JsonSerializable(typeof(GetWindowBoundsCommandParameters), TypeInfoPropertyName = "GetWindowBoundsCommandParameters")]
[JsonSerializable(typeof(GetWindowBoundsResult), TypeInfoPropertyName = "GetWindowBoundsResult")]
[JsonSerializable(typeof(GetWindowForTargetCommandParameters), TypeInfoPropertyName = "GetWindowForTargetCommandParameters")]
[JsonSerializable(typeof(GetWindowForTargetResult), TypeInfoPropertyName = "GetWindowForTargetResult")]
[JsonSerializable(typeof(SetWindowBoundsCommandParameters), TypeInfoPropertyName = "SetWindowBoundsCommandParameters")]
[JsonSerializable(typeof(SetWindowBoundsResult), TypeInfoPropertyName = "SetWindowBoundsResult")]
[JsonSerializable(typeof(SetContentsSizeCommandParameters), TypeInfoPropertyName = "SetContentsSizeCommandParameters")]
[JsonSerializable(typeof(SetContentsSizeResult), TypeInfoPropertyName = "SetContentsSizeResult")]
[JsonSerializable(typeof(SetDockTileCommandParameters), TypeInfoPropertyName = "SetDockTileCommandParameters")]
[JsonSerializable(typeof(SetDockTileResult), TypeInfoPropertyName = "SetDockTileResult")]
[JsonSerializable(typeof(ExecuteBrowserCommandCommandParameters), TypeInfoPropertyName = "ExecuteBrowserCommandCommandParameters")]
[JsonSerializable(typeof(ExecuteBrowserCommandResult), TypeInfoPropertyName = "ExecuteBrowserCommandResult")]
[JsonSerializable(typeof(AddPrivacySandboxEnrollmentOverrideCommandParameters), TypeInfoPropertyName = "AddPrivacySandboxEnrollmentOverrideCommandParameters")]
[JsonSerializable(typeof(AddPrivacySandboxEnrollmentOverrideResult), TypeInfoPropertyName = "AddPrivacySandboxEnrollmentOverrideResult")]
[JsonSerializable(typeof(AddPrivacySandboxCoordinatorKeyConfigCommandParameters), TypeInfoPropertyName = "AddPrivacySandboxCoordinatorKeyConfigCommandParameters")]
[JsonSerializable(typeof(AddPrivacySandboxCoordinatorKeyConfigResult), TypeInfoPropertyName = "AddPrivacySandboxCoordinatorKeyConfigResult")]
[JsonSerializable(typeof(CdpEventArgs<DownloadWillBeginEventArgs>), TypeInfoPropertyName = "DownloadWillBeginCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DownloadProgressEventArgs>), TypeInfoPropertyName = "DownloadProgressCdpEventArgs")]
[JsonSerializable(typeof(BrowserContextID), TypeInfoPropertyName = "BrowserBrowserContextID")]
[JsonSerializable(typeof(WindowID), TypeInfoPropertyName = "BrowserWindowID")]
[JsonSerializable(typeof(WindowState), TypeInfoPropertyName = "BrowserWindowState")]
[JsonSerializable(typeof(Bounds), TypeInfoPropertyName = "BrowserBounds")]
[JsonSerializable(typeof(PermissionType), TypeInfoPropertyName = "BrowserPermissionType")]
[JsonSerializable(typeof(PermissionSetting), TypeInfoPropertyName = "BrowserPermissionSetting")]
[JsonSerializable(typeof(PermissionDescriptor), TypeInfoPropertyName = "BrowserPermissionDescriptor")]
[JsonSerializable(typeof(BrowserCommandId), TypeInfoPropertyName = "BrowserBrowserCommandId")]
[JsonSerializable(typeof(Bucket), TypeInfoPropertyName = "BrowserBucket")]
[JsonSerializable(typeof(Histogram), TypeInfoPropertyName = "BrowserHistogram")]
[JsonSerializable(typeof(PrivacySandboxAPI), TypeInfoPropertyName = "BrowserPrivacySandboxAPI")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<PermissionType>), TypeInfoPropertyName = "IReadOnlyListBrowserPermissionType")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<Histogram>), TypeInfoPropertyName = "IReadOnlyListBrowserHistogram")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<Bucket>), TypeInfoPropertyName = "IReadOnlyListBrowserBucket")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class BrowserJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="BrowserDomain"/>.
/// </summary>
public static class BrowserDomainEvent
{
    /// <summary>
    /// Fired when page is about to start a download.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DownloadWillBeginEventArgs>> DownloadWillBegin { get; } =
        EventDescriptor<CdpEventArgs<DownloadWillBeginEventArgs>>.Create(
            "goog:cdp.Browser.downloadWillBegin",
            BrowserJsonSerializerContext.Default.DownloadWillBeginCdpEventArgs);

    /// <summary>
    /// Fired when download makes progress. Last call has |done| == true.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DownloadProgressEventArgs>> DownloadProgress { get; } =
        EventDescriptor<CdpEventArgs<DownloadProgressEventArgs>>.Create(
            "goog:cdp.Browser.downloadProgress",
            BrowserJsonSerializerContext.Default.DownloadProgressCdpEventArgs);

}
