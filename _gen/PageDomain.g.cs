#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Page;

/// <summary>
/// Actions and events related to the inspected page belong to the page domain.
/// </summary>
public sealed class PageDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static PageJsonSerializerContext JsonContext = PageJsonSerializerContext.Default;

    /// <summary>
    /// Deprecated, please use addScriptToEvaluateOnNewDocument instead.
    /// </summary>
    /// <param name="scriptSource">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="AddScriptToEvaluateOnLoadCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AddScriptToEvaluateOnLoadResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<AddScriptToEvaluateOnLoadResult> AddScriptToEvaluateOnLoadAsync(string scriptSource, AddScriptToEvaluateOnLoadCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new AddScriptToEvaluateOnLoadCommandParameters(ScriptSource: scriptSource);
        return await ExecuteCommandAsync(AddScriptToEvaluateOnLoadCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AddScriptToEvaluateOnLoadCommandParameters, AddScriptToEvaluateOnLoadResult> AddScriptToEvaluateOnLoadCommand = new("Page.addScriptToEvaluateOnLoad", JsonContext.AddScriptToEvaluateOnLoadCommandParameters, JsonContext.AddScriptToEvaluateOnLoadResult);

    /// <summary>
    /// Evaluates given script in every frame upon creation (before loading frame's scripts).
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>WorldName</b> - If specified, creates an isolated world with the given name and evaluates given script in it. This world name will be used as the ExecutionContextDescription::name when the corresponding event is emitted.</description></item>
    /// <item><description><b>IncludeCommandLineAPI</b> - Specifies whether command line API should be available to the script, defaults to false.</description></item>
    /// <item><description><b>RunImmediately</b> - If true, runs the script immediately on existing execution contexts or worlds. Default: false.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="source">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="AddScriptToEvaluateOnNewDocumentCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AddScriptToEvaluateOnNewDocumentResult"/>.
    /// </returns>
    public async Task<AddScriptToEvaluateOnNewDocumentResult> AddScriptToEvaluateOnNewDocumentAsync(string source, AddScriptToEvaluateOnNewDocumentCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new AddScriptToEvaluateOnNewDocumentCommandParameters(Source: source, WorldName: options?.WorldName, IncludeCommandLineAPI: options?.IncludeCommandLineAPI, RunImmediately: options?.RunImmediately);
        return await ExecuteCommandAsync(AddScriptToEvaluateOnNewDocumentCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AddScriptToEvaluateOnNewDocumentCommandParameters, AddScriptToEvaluateOnNewDocumentResult> AddScriptToEvaluateOnNewDocumentCommand = new("Page.addScriptToEvaluateOnNewDocument", JsonContext.AddScriptToEvaluateOnNewDocumentCommandParameters, JsonContext.AddScriptToEvaluateOnNewDocumentResult);

    /// <summary>
    /// Brings page to front (activates tab).
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="BringToFrontCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="BringToFrontResult"/>.
    /// </returns>
    public async Task<BringToFrontResult> BringToFrontAsync(BringToFrontCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new BringToFrontCommandParameters();
        return await ExecuteCommandAsync(BringToFrontCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<BringToFrontCommandParameters, BringToFrontResult> BringToFrontCommand = new("Page.bringToFront", JsonContext.BringToFrontCommandParameters, JsonContext.BringToFrontResult);

    /// <summary>
    /// Capture page screenshot.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Format</b> - Image compression format (defaults to png).</description></item>
    /// <item><description><b>Quality</b> - Compression quality from range [0..100] (jpeg only).</description></item>
    /// <item><description><b>Clip</b> - Capture the screenshot of a given region only.</description></item>
    /// <item><description><b>FromSurface</b> - Capture the screenshot from the surface, rather than the view. Defaults to true.</description></item>
    /// <item><description><b>CaptureBeyondViewport</b> - Capture the screenshot beyond the viewport. Defaults to false.</description></item>
    /// <item><description><b>OptimizeForSpeed</b> - Optimize image encoding for speed, not for resulting size (defaults to false)</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="CaptureScreenshotCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CaptureScreenshotResult"/>.
    /// </returns>
    public async Task<CaptureScreenshotResult> CaptureScreenshotAsync(CaptureScreenshotCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new CaptureScreenshotCommandParameters(Format: options?.Format, Quality: options?.Quality, Clip: options?.Clip, FromSurface: options?.FromSurface, CaptureBeyondViewport: options?.CaptureBeyondViewport, OptimizeForSpeed: options?.OptimizeForSpeed);
        return await ExecuteCommandAsync(CaptureScreenshotCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CaptureScreenshotCommandParameters, CaptureScreenshotResult> CaptureScreenshotCommand = new("Page.captureScreenshot", JsonContext.CaptureScreenshotCommandParameters, JsonContext.CaptureScreenshotResult);

    /// <summary>
    /// Returns a snapshot of the page as a string. For MHTML format, the serialization includes
    /// iframes, shadow DOM, external resources, and element-inline styles.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Format</b> - Format (defaults to mhtml).</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="CaptureSnapshotCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CaptureSnapshotResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<CaptureSnapshotResult> CaptureSnapshotAsync(CaptureSnapshotCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new CaptureSnapshotCommandParameters(Format: options?.Format);
        return await ExecuteCommandAsync(CaptureSnapshotCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CaptureSnapshotCommandParameters, CaptureSnapshotResult> CaptureSnapshotCommand = new("Page.captureSnapshot", JsonContext.CaptureSnapshotCommandParameters, JsonContext.CaptureSnapshotResult);

    /// <summary>
    /// Clears the overridden device metrics.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="ClearDeviceMetricsOverrideCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearDeviceMetricsOverrideResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<ClearDeviceMetricsOverrideResult> ClearDeviceMetricsOverrideAsync(ClearDeviceMetricsOverrideCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearDeviceMetricsOverrideCommandParameters();
        return await ExecuteCommandAsync(ClearDeviceMetricsOverrideCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearDeviceMetricsOverrideCommandParameters, ClearDeviceMetricsOverrideResult> ClearDeviceMetricsOverrideCommand = new("Page.clearDeviceMetricsOverride", JsonContext.ClearDeviceMetricsOverrideCommandParameters, JsonContext.ClearDeviceMetricsOverrideResult);

    /// <summary>
    /// Clears the overridden Device Orientation.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="ClearDeviceOrientationOverrideCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearDeviceOrientationOverrideResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<ClearDeviceOrientationOverrideResult> ClearDeviceOrientationOverrideAsync(ClearDeviceOrientationOverrideCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearDeviceOrientationOverrideCommandParameters();
        return await ExecuteCommandAsync(ClearDeviceOrientationOverrideCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearDeviceOrientationOverrideCommandParameters, ClearDeviceOrientationOverrideResult> ClearDeviceOrientationOverrideCommand = new("Page.clearDeviceOrientationOverride", JsonContext.ClearDeviceOrientationOverrideCommandParameters, JsonContext.ClearDeviceOrientationOverrideResult);

    /// <summary>
    /// Clears the overridden Geolocation Position and Error.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="ClearGeolocationOverrideCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearGeolocationOverrideResult"/>.
    /// </returns>
    [global::System.Obsolete]
    public async Task<ClearGeolocationOverrideResult> ClearGeolocationOverrideAsync(ClearGeolocationOverrideCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearGeolocationOverrideCommandParameters();
        return await ExecuteCommandAsync(ClearGeolocationOverrideCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearGeolocationOverrideCommandParameters, ClearGeolocationOverrideResult> ClearGeolocationOverrideCommand = new("Page.clearGeolocationOverride", JsonContext.ClearGeolocationOverrideCommandParameters, JsonContext.ClearGeolocationOverrideResult);

    /// <summary>
    /// Creates an isolated world for the given frame.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>WorldName</b> - An optional name which is reported in the Execution Context.</description></item>
    /// <item><description><b>GrantUniveralAccess</b> - Whether or not universal access should be granted to the isolated world. This is a powerful option, use with caution.</description></item>
    /// <item><description><b>ContentSecurityPolicy</b> - An optional content security policy to set for the isolated world. If omitted, any existing CSP for the world will be cleared. Note that clearing or updating the CSP does not immediately affect the active context in the same document because LocalDOMWindow caches the ContentSecurityPolicy object. The change takes effect on subsequent navigations when a new window context is created.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="frameId">
    /// Id of the frame in which the isolated world should be created.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="CreateIsolatedWorldCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CreateIsolatedWorldResult"/>.
    /// </returns>
    public async Task<CreateIsolatedWorldResult> CreateIsolatedWorldAsync(FrameId frameId, CreateIsolatedWorldCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new CreateIsolatedWorldCommandParameters(FrameId: frameId, WorldName: options?.WorldName, GrantUniveralAccess: options?.GrantUniveralAccess, ContentSecurityPolicy: options?.ContentSecurityPolicy);
        return await ExecuteCommandAsync(CreateIsolatedWorldCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CreateIsolatedWorldCommandParameters, CreateIsolatedWorldResult> CreateIsolatedWorldCommand = new("Page.createIsolatedWorld", JsonContext.CreateIsolatedWorldCommandParameters, JsonContext.CreateIsolatedWorldResult);

    /// <summary>
    /// Deletes browser cookie with given name, domain and path.
    /// </summary>
    /// <param name="cookieName">
    /// Name of the cookie to remove.
    /// </param>
    /// <param name="url">
    /// URL to match cooke domain and path.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="DeleteCookieCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DeleteCookieResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<DeleteCookieResult> DeleteCookieAsync(string cookieName, string url, DeleteCookieCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new DeleteCookieCommandParameters(CookieName: cookieName, Url: url);
        return await ExecuteCommandAsync(DeleteCookieCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DeleteCookieCommandParameters, DeleteCookieResult> DeleteCookieCommand = new("Page.deleteCookie", JsonContext.DeleteCookieCommandParameters, JsonContext.DeleteCookieResult);

    /// <summary>
    /// Disables page domain notifications.
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
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("Page.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Enables page domain notifications.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>EnableFileChooserOpenedEvent</b> - If true, the <b>Page.fileChooserOpened</b> event will be emitted regardless of the state set by <b>Page.setInterceptFileChooserDialog</b> command (default: false).</description></item>
    /// </list>
    /// </remarks>
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
        var @params = new EnableCommandParameters(EnableFileChooserOpenedEvent: options?.EnableFileChooserOpenedEvent);
        return await ExecuteCommandAsync(EnableCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("Page.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Gets the processed manifest for this current document.
    ///   This API always waits for the manifest to be loaded.
    ///   If manifestId is provided, and it does not match the manifest of the
    ///     current document, this API errors out.
    ///   If there is not a loaded page, this API errors out immediately.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>ManifestId</b></description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetAppManifestCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetAppManifestResult"/>.
    /// </returns>
    public async Task<GetAppManifestResult> GetAppManifestAsync(GetAppManifestCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetAppManifestCommandParameters(ManifestId: options?.ManifestId);
        return await ExecuteCommandAsync(GetAppManifestCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetAppManifestCommandParameters, GetAppManifestResult> GetAppManifestCommand = new("Page.getAppManifest", JsonContext.GetAppManifestCommandParameters, JsonContext.GetAppManifestResult);

    /// <summary>
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetInstallabilityErrorsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetInstallabilityErrorsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetInstallabilityErrorsResult> GetInstallabilityErrorsAsync(GetInstallabilityErrorsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetInstallabilityErrorsCommandParameters();
        return await ExecuteCommandAsync(GetInstallabilityErrorsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetInstallabilityErrorsCommandParameters, GetInstallabilityErrorsResult> GetInstallabilityErrorsCommand = new("Page.getInstallabilityErrors", JsonContext.GetInstallabilityErrorsCommandParameters, JsonContext.GetInstallabilityErrorsResult);

    /// <summary>
    /// Deprecated because it's not guaranteed that the returned icon is in fact the one used for PWA installation.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetManifestIconsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetManifestIconsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<GetManifestIconsResult> GetManifestIconsAsync(GetManifestIconsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetManifestIconsCommandParameters();
        return await ExecuteCommandAsync(GetManifestIconsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetManifestIconsCommandParameters, GetManifestIconsResult> GetManifestIconsCommand = new("Page.getManifestIcons", JsonContext.GetManifestIconsCommandParameters, JsonContext.GetManifestIconsResult);

    /// <summary>
    /// Returns the unique (PWA) app id.
    /// Only returns values if the feature flag 'WebAppEnableManifestId' is enabled
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetAppIdCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetAppIdResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetAppIdResult> GetAppIdAsync(GetAppIdCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetAppIdCommandParameters();
        return await ExecuteCommandAsync(GetAppIdCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetAppIdCommandParameters, GetAppIdResult> GetAppIdCommand = new("Page.getAppId", JsonContext.GetAppIdCommandParameters, JsonContext.GetAppIdResult);

    /// <summary>
    /// </summary>
    /// <param name="frameId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetAdScriptAncestryCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetAdScriptAncestryResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetAdScriptAncestryResult> GetAdScriptAncestryAsync(FrameId frameId, GetAdScriptAncestryCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetAdScriptAncestryCommandParameters(FrameId: frameId);
        return await ExecuteCommandAsync(GetAdScriptAncestryCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetAdScriptAncestryCommandParameters, GetAdScriptAncestryResult> GetAdScriptAncestryCommand = new("Page.getAdScriptAncestry", JsonContext.GetAdScriptAncestryCommandParameters, JsonContext.GetAdScriptAncestryResult);

    /// <summary>
    /// Returns present frame tree structure.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetFrameTreeCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetFrameTreeResult"/>.
    /// </returns>
    public async Task<GetFrameTreeResult> GetFrameTreeAsync(GetFrameTreeCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetFrameTreeCommandParameters();
        return await ExecuteCommandAsync(GetFrameTreeCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetFrameTreeCommandParameters, GetFrameTreeResult> GetFrameTreeCommand = new("Page.getFrameTree", JsonContext.GetFrameTreeCommandParameters, JsonContext.GetFrameTreeResult);

    /// <summary>
    /// Returns metrics relating to the layouting of the page, such as viewport bounds/scale.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetLayoutMetricsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetLayoutMetricsResult"/>.
    /// </returns>
    public async Task<GetLayoutMetricsResult> GetLayoutMetricsAsync(GetLayoutMetricsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetLayoutMetricsCommandParameters();
        return await ExecuteCommandAsync(GetLayoutMetricsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetLayoutMetricsCommandParameters, GetLayoutMetricsResult> GetLayoutMetricsCommand = new("Page.getLayoutMetrics", JsonContext.GetLayoutMetricsCommandParameters, JsonContext.GetLayoutMetricsResult);

    /// <summary>
    /// Returns navigation history for the current page.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetNavigationHistoryCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetNavigationHistoryResult"/>.
    /// </returns>
    public async Task<GetNavigationHistoryResult> GetNavigationHistoryAsync(GetNavigationHistoryCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetNavigationHistoryCommandParameters();
        return await ExecuteCommandAsync(GetNavigationHistoryCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetNavigationHistoryCommandParameters, GetNavigationHistoryResult> GetNavigationHistoryCommand = new("Page.getNavigationHistory", JsonContext.GetNavigationHistoryCommandParameters, JsonContext.GetNavigationHistoryResult);

    /// <summary>
    /// Resets navigation history for the current page.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="ResetNavigationHistoryCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ResetNavigationHistoryResult"/>.
    /// </returns>
    public async Task<ResetNavigationHistoryResult> ResetNavigationHistoryAsync(ResetNavigationHistoryCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ResetNavigationHistoryCommandParameters();
        return await ExecuteCommandAsync(ResetNavigationHistoryCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ResetNavigationHistoryCommandParameters, ResetNavigationHistoryResult> ResetNavigationHistoryCommand = new("Page.resetNavigationHistory", JsonContext.ResetNavigationHistoryCommandParameters, JsonContext.ResetNavigationHistoryResult);

    /// <summary>
    /// Returns content of the given resource.
    /// </summary>
    /// <param name="frameId">
    /// Frame id to get resource for.
    /// </param>
    /// <param name="url">
    /// URL of the resource to get content for.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetResourceContentCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetResourceContentResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetResourceContentResult> GetResourceContentAsync(FrameId frameId, string url, GetResourceContentCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetResourceContentCommandParameters(FrameId: frameId, Url: url);
        return await ExecuteCommandAsync(GetResourceContentCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetResourceContentCommandParameters, GetResourceContentResult> GetResourceContentCommand = new("Page.getResourceContent", JsonContext.GetResourceContentCommandParameters, JsonContext.GetResourceContentResult);

    /// <summary>
    /// Returns present frame / resource tree structure.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetResourceTreeCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetResourceTreeResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetResourceTreeResult> GetResourceTreeAsync(GetResourceTreeCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetResourceTreeCommandParameters();
        return await ExecuteCommandAsync(GetResourceTreeCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetResourceTreeCommandParameters, GetResourceTreeResult> GetResourceTreeCommand = new("Page.getResourceTree", JsonContext.GetResourceTreeCommandParameters, JsonContext.GetResourceTreeResult);

    /// <summary>
    /// Accepts or dismisses a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload).
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>PromptText</b> - The text to enter into the dialog prompt before accepting. Used only if this is a prompt dialog.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="accept">
    /// Whether to accept or dismiss the dialog.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="HandleJavaScriptDialogCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="HandleJavaScriptDialogResult"/>.
    /// </returns>
    public async Task<HandleJavaScriptDialogResult> HandleJavaScriptDialogAsync(bool accept, HandleJavaScriptDialogCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new HandleJavaScriptDialogCommandParameters(Accept: accept, PromptText: options?.PromptText);
        return await ExecuteCommandAsync(HandleJavaScriptDialogCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<HandleJavaScriptDialogCommandParameters, HandleJavaScriptDialogResult> HandleJavaScriptDialogCommand = new("Page.handleJavaScriptDialog", JsonContext.HandleJavaScriptDialogCommandParameters, JsonContext.HandleJavaScriptDialogResult);

    /// <summary>
    /// Navigates current page to the given URL.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Referrer</b> - Referrer URL.</description></item>
    /// <item><description><b>TransitionType</b> - Intended transition type.</description></item>
    /// <item><description><b>FrameId</b> - Frame id to navigate, if not specified navigates the top frame.</description></item>
    /// <item><description><b>ReferrerPolicy</b> - Referrer-policy used for the navigation.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="url">
    /// URL to navigate the page to.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="NavigateCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="NavigateResult"/>.
    /// </returns>
    public async Task<NavigateResult> NavigateAsync(string url, NavigateCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new NavigateCommandParameters(Url: url, Referrer: options?.Referrer, TransitionType: options?.TransitionType, FrameId: options?.FrameId, ReferrerPolicy: options?.ReferrerPolicy);
        return await ExecuteCommandAsync(NavigateCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<NavigateCommandParameters, NavigateResult> NavigateCommand = new("Page.navigate", JsonContext.NavigateCommandParameters, JsonContext.NavigateResult);

    /// <summary>
    /// Navigates current page to the given history entry.
    /// </summary>
    /// <param name="entryId">
    /// Unique id of the entry to navigate to.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="NavigateToHistoryEntryCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="NavigateToHistoryEntryResult"/>.
    /// </returns>
    public async Task<NavigateToHistoryEntryResult> NavigateToHistoryEntryAsync(long entryId, NavigateToHistoryEntryCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new NavigateToHistoryEntryCommandParameters(EntryId: entryId);
        return await ExecuteCommandAsync(NavigateToHistoryEntryCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<NavigateToHistoryEntryCommandParameters, NavigateToHistoryEntryResult> NavigateToHistoryEntryCommand = new("Page.navigateToHistoryEntry", JsonContext.NavigateToHistoryEntryCommandParameters, JsonContext.NavigateToHistoryEntryResult);

    /// <summary>
    /// Print page as PDF.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Landscape</b> - Paper orientation. Defaults to false.</description></item>
    /// <item><description><b>DisplayHeaderFooter</b> - Display header and footer. Defaults to false.</description></item>
    /// <item><description><b>PrintBackground</b> - Print background graphics. Defaults to false.</description></item>
    /// <item><description><b>Scale</b> - Scale of the webpage rendering. Defaults to 1.</description></item>
    /// <item><description><b>PaperWidth</b> - Paper width in inches. Defaults to 8.5 inches.</description></item>
    /// <item><description><b>PaperHeight</b> - Paper height in inches. Defaults to 11 inches.</description></item>
    /// <item><description><b>MarginTop</b> - Top margin in inches. Defaults to 1cm (~0.4 inches).</description></item>
    /// <item><description><b>MarginBottom</b> - Bottom margin in inches. Defaults to 1cm (~0.4 inches).</description></item>
    /// <item><description><b>MarginLeft</b> - Left margin in inches. Defaults to 1cm (~0.4 inches).</description></item>
    /// <item><description><b>MarginRight</b> - Right margin in inches. Defaults to 1cm (~0.4 inches).</description></item>
    /// <item><description><b>PageRanges</b> - Paper ranges to print, one based, e.g., '1-5, 8, 11-13'. Pages are printed in the document order, not in the order specified, and no more than once. Defaults to empty string, which implies the entire document is printed. The page numbers are quietly capped to actual page count of the document, and ranges beyond the end of the document are ignored. If this results in no pages to print, an error is reported. It is an error to specify a range with start greater than end.</description></item>
    /// <item><description><b>HeaderTemplate</b> - HTML template for the print header. Should be valid HTML markup with following classes used to inject printing values into them: - <b>date</b>: formatted print date - <b>title</b>: document title - <b>url</b>: document location - <b>pageNumber</b>: current page number - <b>totalPages</b>: total pages in the document  For example, <b>&lt;span class=title&gt;&lt;/span&gt;</b> would generate span containing the title.</description></item>
    /// <item><description><b>FooterTemplate</b> - HTML template for the print footer. Should use the same format as the <b>headerTemplate</b>.</description></item>
    /// <item><description><b>PreferCSSPageSize</b> - Whether or not to prefer page size as defined by css. Defaults to false, in which case the content will be scaled to fit the paper size.</description></item>
    /// <item><description><b>TransferMode</b> - return as stream</description></item>
    /// <item><description><b>GenerateTaggedPDF</b> - Whether or not to generate tagged (accessible) PDF. Defaults to embedder choice.</description></item>
    /// <item><description><b>GenerateDocumentOutline</b> - Whether or not to embed the document outline into the PDF.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="PrintToPDFCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="PrintToPDFResult"/>.
    /// </returns>
    public async Task<PrintToPDFResult> PrintToPDFAsync(PrintToPDFCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new PrintToPDFCommandParameters(Landscape: options?.Landscape, DisplayHeaderFooter: options?.DisplayHeaderFooter, PrintBackground: options?.PrintBackground, Scale: options?.Scale, PaperWidth: options?.PaperWidth, PaperHeight: options?.PaperHeight, MarginTop: options?.MarginTop, MarginBottom: options?.MarginBottom, MarginLeft: options?.MarginLeft, MarginRight: options?.MarginRight, PageRanges: options?.PageRanges, HeaderTemplate: options?.HeaderTemplate, FooterTemplate: options?.FooterTemplate, PreferCSSPageSize: options?.PreferCSSPageSize, TransferMode: options?.TransferMode, GenerateTaggedPDF: options?.GenerateTaggedPDF, GenerateDocumentOutline: options?.GenerateDocumentOutline);
        return await ExecuteCommandAsync(PrintToPDFCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<PrintToPDFCommandParameters, PrintToPDFResult> PrintToPDFCommand = new("Page.printToPDF", JsonContext.PrintToPDFCommandParameters, JsonContext.PrintToPDFResult);

    /// <summary>
    /// Reloads given page optionally ignoring the cache.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>IgnoreCache</b> - If true, browser cache is ignored (as if the user pressed Shift+refresh).</description></item>
    /// <item><description><b>ScriptToEvaluateOnLoad</b> - If set, the script will be injected into all frames of the inspected page after reload. Argument will be ignored if reloading dataURL origin.</description></item>
    /// <item><description><b>LoaderId</b> - If set, an error will be thrown if the target page's main frame's loader id does not match the provided id. This prevents accidentally reloading an unintended target in case there's a racing navigation.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="ReloadCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ReloadResult"/>.
    /// </returns>
    public async Task<ReloadResult> ReloadAsync(ReloadCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ReloadCommandParameters(IgnoreCache: options?.IgnoreCache, ScriptToEvaluateOnLoad: options?.ScriptToEvaluateOnLoad, LoaderId: options?.LoaderId);
        return await ExecuteCommandAsync(ReloadCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ReloadCommandParameters, ReloadResult> ReloadCommand = new("Page.reload", JsonContext.ReloadCommandParameters, JsonContext.ReloadResult);

    /// <summary>
    /// Deprecated, please use removeScriptToEvaluateOnNewDocument instead.
    /// </summary>
    /// <param name="identifier">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="RemoveScriptToEvaluateOnLoadCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RemoveScriptToEvaluateOnLoadResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<RemoveScriptToEvaluateOnLoadResult> RemoveScriptToEvaluateOnLoadAsync(ScriptIdentifier identifier, RemoveScriptToEvaluateOnLoadCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveScriptToEvaluateOnLoadCommandParameters(Identifier: identifier);
        return await ExecuteCommandAsync(RemoveScriptToEvaluateOnLoadCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RemoveScriptToEvaluateOnLoadCommandParameters, RemoveScriptToEvaluateOnLoadResult> RemoveScriptToEvaluateOnLoadCommand = new("Page.removeScriptToEvaluateOnLoad", JsonContext.RemoveScriptToEvaluateOnLoadCommandParameters, JsonContext.RemoveScriptToEvaluateOnLoadResult);

    /// <summary>
    /// Removes given script from the list.
    /// </summary>
    /// <param name="identifier">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="RemoveScriptToEvaluateOnNewDocumentCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RemoveScriptToEvaluateOnNewDocumentResult"/>.
    /// </returns>
    public async Task<RemoveScriptToEvaluateOnNewDocumentResult> RemoveScriptToEvaluateOnNewDocumentAsync(ScriptIdentifier identifier, RemoveScriptToEvaluateOnNewDocumentCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveScriptToEvaluateOnNewDocumentCommandParameters(Identifier: identifier);
        return await ExecuteCommandAsync(RemoveScriptToEvaluateOnNewDocumentCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RemoveScriptToEvaluateOnNewDocumentCommandParameters, RemoveScriptToEvaluateOnNewDocumentResult> RemoveScriptToEvaluateOnNewDocumentCommand = new("Page.removeScriptToEvaluateOnNewDocument", JsonContext.RemoveScriptToEvaluateOnNewDocumentCommandParameters, JsonContext.RemoveScriptToEvaluateOnNewDocumentResult);

    /// <summary>
    /// Acknowledges that a screencast frame has been received by the frontend.
    /// </summary>
    /// <param name="sessionId">
    /// Frame number.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ScreencastFrameAckCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ScreencastFrameAckResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<ScreencastFrameAckResult> ScreencastFrameAckAsync(long sessionId, ScreencastFrameAckCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ScreencastFrameAckCommandParameters(SessionId: sessionId);
        return await ExecuteCommandAsync(ScreencastFrameAckCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ScreencastFrameAckCommandParameters, ScreencastFrameAckResult> ScreencastFrameAckCommand = new("Page.screencastFrameAck", JsonContext.ScreencastFrameAckCommandParameters, JsonContext.ScreencastFrameAckResult);

    /// <summary>
    /// Searches for given string in resource content.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>CaseSensitive</b> - If true, search is case sensitive.</description></item>
    /// <item><description><b>IsRegex</b> - If true, treats string parameter as regex.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="frameId">
    /// Frame id for resource to search in.
    /// </param>
    /// <param name="url">
    /// URL of the resource to search in.
    /// </param>
    /// <param name="query">
    /// String to search for.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SearchInResourceCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SearchInResourceResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SearchInResourceResult> SearchInResourceAsync(FrameId frameId, string url, string query, SearchInResourceCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SearchInResourceCommandParameters(FrameId: frameId, Url: url, Query: query, CaseSensitive: options?.CaseSensitive, IsRegex: options?.IsRegex);
        return await ExecuteCommandAsync(SearchInResourceCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SearchInResourceCommandParameters, SearchInResourceResult> SearchInResourceCommand = new("Page.searchInResource", JsonContext.SearchInResourceCommandParameters, JsonContext.SearchInResourceResult);

    /// <summary>
    /// Enable Chrome's experimental ad filter on all sites.
    /// </summary>
    /// <param name="enabled">
    /// Whether to block ads.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetAdBlockingEnabledCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetAdBlockingEnabledResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetAdBlockingEnabledResult> SetAdBlockingEnabledAsync(bool enabled, SetAdBlockingEnabledCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetAdBlockingEnabledCommandParameters(Enabled: enabled);
        return await ExecuteCommandAsync(SetAdBlockingEnabledCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetAdBlockingEnabledCommandParameters, SetAdBlockingEnabledResult> SetAdBlockingEnabledCommand = new("Page.setAdBlockingEnabled", JsonContext.SetAdBlockingEnabledCommandParameters, JsonContext.SetAdBlockingEnabledResult);

    /// <summary>
    /// Enable page Content Security Policy by-passing.
    /// </summary>
    /// <param name="enabled">
    /// Whether to bypass page CSP.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetBypassCSPCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetBypassCSPResult"/>.
    /// </returns>
    public async Task<SetBypassCSPResult> SetBypassCSPAsync(bool enabled, SetBypassCSPCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetBypassCSPCommandParameters(Enabled: enabled);
        return await ExecuteCommandAsync(SetBypassCSPCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetBypassCSPCommandParameters, SetBypassCSPResult> SetBypassCSPCommand = new("Page.setBypassCSP", JsonContext.SetBypassCSPCommandParameters, JsonContext.SetBypassCSPResult);

    /// <summary>
    /// Get Permissions Policy state on given frame.
    /// </summary>
    /// <param name="frameId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetPermissionsPolicyStateCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetPermissionsPolicyStateResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetPermissionsPolicyStateResult> GetPermissionsPolicyStateAsync(FrameId frameId, GetPermissionsPolicyStateCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetPermissionsPolicyStateCommandParameters(FrameId: frameId);
        return await ExecuteCommandAsync(GetPermissionsPolicyStateCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetPermissionsPolicyStateCommandParameters, GetPermissionsPolicyStateResult> GetPermissionsPolicyStateCommand = new("Page.getPermissionsPolicyState", JsonContext.GetPermissionsPolicyStateCommandParameters, JsonContext.GetPermissionsPolicyStateResult);

    /// <summary>
    /// Get Origin Trials on given frame.
    /// </summary>
    /// <param name="frameId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetOriginTrialsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetOriginTrialsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetOriginTrialsResult> GetOriginTrialsAsync(FrameId frameId, GetOriginTrialsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetOriginTrialsCommandParameters(FrameId: frameId);
        return await ExecuteCommandAsync(GetOriginTrialsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetOriginTrialsCommandParameters, GetOriginTrialsResult> GetOriginTrialsCommand = new("Page.getOriginTrials", JsonContext.GetOriginTrialsCommandParameters, JsonContext.GetOriginTrialsResult);

    /// <summary>
    /// Overrides the values of device screen dimensions (window.screen.width, window.screen.height,
    /// window.innerWidth, window.innerHeight, and "device-width"/"device-height"-related CSS media
    /// query results).
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Scale</b> - Scale to apply to resulting view image.</description></item>
    /// <item><description><b>ScreenWidth</b> - Overriding screen width value in pixels (minimum 0, maximum 10000000).</description></item>
    /// <item><description><b>ScreenHeight</b> - Overriding screen height value in pixels (minimum 0, maximum 10000000).</description></item>
    /// <item><description><b>PositionX</b> - Overriding view X position on screen in pixels (minimum 0, maximum 10000000).</description></item>
    /// <item><description><b>PositionY</b> - Overriding view Y position on screen in pixels (minimum 0, maximum 10000000).</description></item>
    /// <item><description><b>DontSetVisibleSize</b> - Do not set visible view size, rely upon explicit setVisibleSize call.</description></item>
    /// <item><description><b>ScreenOrientation</b> - Screen orientation override.</description></item>
    /// <item><description><b>Viewport</b> - The viewport dimensions and scale. If not set, the override is cleared.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="width">
    /// Overriding width value in pixels (minimum 0, maximum 10000000). 0 disables the override.
    /// </param>
    /// <param name="height">
    /// Overriding height value in pixels (minimum 0, maximum 10000000). 0 disables the override.
    /// </param>
    /// <param name="deviceScaleFactor">
    /// Overriding device scale factor value. 0 disables the override.
    /// </param>
    /// <param name="mobile">
    /// Whether to emulate mobile device. This includes viewport meta tag, overlay scrollbars, text
    /// autosizing and more.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetDeviceMetricsOverrideCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetDeviceMetricsOverrideResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<SetDeviceMetricsOverrideResult> SetDeviceMetricsOverrideAsync(long width, long height, double deviceScaleFactor, bool mobile, SetDeviceMetricsOverrideCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetDeviceMetricsOverrideCommandParameters(Width: width, Height: height, DeviceScaleFactor: deviceScaleFactor, Mobile: mobile, Scale: options?.Scale, ScreenWidth: options?.ScreenWidth, ScreenHeight: options?.ScreenHeight, PositionX: options?.PositionX, PositionY: options?.PositionY, DontSetVisibleSize: options?.DontSetVisibleSize, ScreenOrientation: options?.ScreenOrientation, Viewport: options?.Viewport);
        return await ExecuteCommandAsync(SetDeviceMetricsOverrideCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetDeviceMetricsOverrideCommandParameters, SetDeviceMetricsOverrideResult> SetDeviceMetricsOverrideCommand = new("Page.setDeviceMetricsOverride", JsonContext.SetDeviceMetricsOverrideCommandParameters, JsonContext.SetDeviceMetricsOverrideResult);

    /// <summary>
    /// Overrides the Device Orientation.
    /// </summary>
    /// <param name="alpha">
    /// Mock alpha
    /// </param>
    /// <param name="beta">
    /// Mock beta
    /// </param>
    /// <param name="gamma">
    /// Mock gamma
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetDeviceOrientationOverrideCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetDeviceOrientationOverrideResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<SetDeviceOrientationOverrideResult> SetDeviceOrientationOverrideAsync(double alpha, double beta, double gamma, SetDeviceOrientationOverrideCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetDeviceOrientationOverrideCommandParameters(Alpha: alpha, Beta: beta, Gamma: gamma);
        return await ExecuteCommandAsync(SetDeviceOrientationOverrideCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetDeviceOrientationOverrideCommandParameters, SetDeviceOrientationOverrideResult> SetDeviceOrientationOverrideCommand = new("Page.setDeviceOrientationOverride", JsonContext.SetDeviceOrientationOverrideCommandParameters, JsonContext.SetDeviceOrientationOverrideResult);

    /// <summary>
    /// Set generic font families.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>ForScripts</b> - Specifies font families to set for individual scripts.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="fontFamilies">
    /// Specifies font families to set. If a font family is not specified, it won't be changed.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetFontFamiliesCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetFontFamiliesResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetFontFamiliesResult> SetFontFamiliesAsync(FontFamilies fontFamilies, SetFontFamiliesCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetFontFamiliesCommandParameters(FontFamilies: fontFamilies, ForScripts: options?.ForScripts);
        return await ExecuteCommandAsync(SetFontFamiliesCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetFontFamiliesCommandParameters, SetFontFamiliesResult> SetFontFamiliesCommand = new("Page.setFontFamilies", JsonContext.SetFontFamiliesCommandParameters, JsonContext.SetFontFamiliesResult);

    /// <summary>
    /// Set default font sizes.
    /// </summary>
    /// <param name="fontSizes">
    /// Specifies font sizes to set. If a font size is not specified, it won't be changed.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetFontSizesCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetFontSizesResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetFontSizesResult> SetFontSizesAsync(FontSizes fontSizes, SetFontSizesCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetFontSizesCommandParameters(FontSizes: fontSizes);
        return await ExecuteCommandAsync(SetFontSizesCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetFontSizesCommandParameters, SetFontSizesResult> SetFontSizesCommand = new("Page.setFontSizes", JsonContext.SetFontSizesCommandParameters, JsonContext.SetFontSizesResult);

    /// <summary>
    /// Sets given markup as the document's HTML.
    /// </summary>
    /// <param name="frameId">
    /// Frame id to set HTML for.
    /// </param>
    /// <param name="html">
    /// HTML content to set.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetDocumentContentCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetDocumentContentResult"/>.
    /// </returns>
    public async Task<SetDocumentContentResult> SetDocumentContentAsync(FrameId frameId, string html, SetDocumentContentCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetDocumentContentCommandParameters(FrameId: frameId, Html: html);
        return await ExecuteCommandAsync(SetDocumentContentCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetDocumentContentCommandParameters, SetDocumentContentResult> SetDocumentContentCommand = new("Page.setDocumentContent", JsonContext.SetDocumentContentCommandParameters, JsonContext.SetDocumentContentResult);

    /// <summary>
    /// Set the behavior when downloading a file.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>DownloadPath</b> - The default path to save downloaded files to. This is required if behavior is set to 'allow'</description></item>
    /// </list>
    /// </remarks>
    /// <param name="behavior">
    /// Whether to allow all or deny all download requests, or use default Chrome behavior if
    /// available (otherwise deny).
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
    [global::System.Obsolete]
    public async Task<SetDownloadBehaviorResult> SetDownloadBehaviorAsync(string behavior, SetDownloadBehaviorCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetDownloadBehaviorCommandParameters(Behavior: behavior, DownloadPath: options?.DownloadPath);
        return await ExecuteCommandAsync(SetDownloadBehaviorCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetDownloadBehaviorCommandParameters, SetDownloadBehaviorResult> SetDownloadBehaviorCommand = new("Page.setDownloadBehavior", JsonContext.SetDownloadBehaviorCommandParameters, JsonContext.SetDownloadBehaviorResult);

    /// <summary>
    /// Overrides the Geolocation Position or Error. Omitting any of the parameters emulates position
    /// unavailable.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Latitude</b> - Mock latitude</description></item>
    /// <item><description><b>Longitude</b> - Mock longitude</description></item>
    /// <item><description><b>Accuracy</b> - Mock accuracy</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetGeolocationOverrideCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetGeolocationOverrideResult"/>.
    /// </returns>
    [global::System.Obsolete]
    public async Task<SetGeolocationOverrideResult> SetGeolocationOverrideAsync(SetGeolocationOverrideCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetGeolocationOverrideCommandParameters(Latitude: options?.Latitude, Longitude: options?.Longitude, Accuracy: options?.Accuracy);
        return await ExecuteCommandAsync(SetGeolocationOverrideCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetGeolocationOverrideCommandParameters, SetGeolocationOverrideResult> SetGeolocationOverrideCommand = new("Page.setGeolocationOverride", JsonContext.SetGeolocationOverrideCommandParameters, JsonContext.SetGeolocationOverrideResult);

    /// <summary>
    /// Controls whether page will emit lifecycle events.
    /// </summary>
    /// <param name="enabled">
    /// If true, starts emitting lifecycle events.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetLifecycleEventsEnabledCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetLifecycleEventsEnabledResult"/>.
    /// </returns>
    public async Task<SetLifecycleEventsEnabledResult> SetLifecycleEventsEnabledAsync(bool enabled, SetLifecycleEventsEnabledCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetLifecycleEventsEnabledCommandParameters(Enabled: enabled);
        return await ExecuteCommandAsync(SetLifecycleEventsEnabledCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetLifecycleEventsEnabledCommandParameters, SetLifecycleEventsEnabledResult> SetLifecycleEventsEnabledCommand = new("Page.setLifecycleEventsEnabled", JsonContext.SetLifecycleEventsEnabledCommandParameters, JsonContext.SetLifecycleEventsEnabledResult);

    /// <summary>
    /// Toggles mouse event-based touch event emulation.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Configuration</b> - Touch/gesture events configuration. Default: current platform.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="enabled">
    /// Whether the touch event emulation should be enabled.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetTouchEmulationEnabledCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetTouchEmulationEnabledResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<SetTouchEmulationEnabledResult> SetTouchEmulationEnabledAsync(bool enabled, SetTouchEmulationEnabledCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetTouchEmulationEnabledCommandParameters(Enabled: enabled, Configuration: options?.Configuration);
        return await ExecuteCommandAsync(SetTouchEmulationEnabledCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetTouchEmulationEnabledCommandParameters, SetTouchEmulationEnabledResult> SetTouchEmulationEnabledCommand = new("Page.setTouchEmulationEnabled", JsonContext.SetTouchEmulationEnabledCommandParameters, JsonContext.SetTouchEmulationEnabledResult);

    /// <summary>
    /// Starts sending each frame using the <b>screencastFrame</b> event.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Format</b> - Image compression format.</description></item>
    /// <item><description><b>Quality</b> - Compression quality from range [0..100].</description></item>
    /// <item><description><b>MaxWidth</b> - Maximum screenshot width.</description></item>
    /// <item><description><b>MaxHeight</b> - Maximum screenshot height.</description></item>
    /// <item><description><b>EveryNthFrame</b> - Send every n-th frame.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="StartScreencastCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StartScreencastResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<StartScreencastResult> StartScreencastAsync(StartScreencastCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new StartScreencastCommandParameters(Format: options?.Format, Quality: options?.Quality, MaxWidth: options?.MaxWidth, MaxHeight: options?.MaxHeight, EveryNthFrame: options?.EveryNthFrame);
        return await ExecuteCommandAsync(StartScreencastCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StartScreencastCommandParameters, StartScreencastResult> StartScreencastCommand = new("Page.startScreencast", JsonContext.StartScreencastCommandParameters, JsonContext.StartScreencastResult);

    /// <summary>
    /// Force the page stop all navigations and pending resource fetches.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="StopLoadingCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StopLoadingResult"/>.
    /// </returns>
    public async Task<StopLoadingResult> StopLoadingAsync(StopLoadingCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new StopLoadingCommandParameters();
        return await ExecuteCommandAsync(StopLoadingCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StopLoadingCommandParameters, StopLoadingResult> StopLoadingCommand = new("Page.stopLoading", JsonContext.StopLoadingCommandParameters, JsonContext.StopLoadingResult);

    /// <summary>
    /// Crashes renderer on the IO thread, generates minidumps.
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
    private static readonly CdpCommand<CrashCommandParameters, CrashResult> CrashCommand = new("Page.crash", JsonContext.CrashCommandParameters, JsonContext.CrashResult);

    /// <summary>
    /// Tries to close page, running its beforeunload hooks, if any.
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
    private static readonly CdpCommand<CloseCommandParameters, CloseResult> CloseCommand = new("Page.close", JsonContext.CloseCommandParameters, JsonContext.CloseResult);

    /// <summary>
    /// Tries to update the web lifecycle state of the page.
    /// It will transition the page to the given state according to:
    /// https://github.com/WICG/web-lifecycle/
    /// </summary>
    /// <param name="state">
    /// Target lifecycle state
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetWebLifecycleStateCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetWebLifecycleStateResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetWebLifecycleStateResult> SetWebLifecycleStateAsync(string state, SetWebLifecycleStateCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetWebLifecycleStateCommandParameters(State: state);
        return await ExecuteCommandAsync(SetWebLifecycleStateCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetWebLifecycleStateCommandParameters, SetWebLifecycleStateResult> SetWebLifecycleStateCommand = new("Page.setWebLifecycleState", JsonContext.SetWebLifecycleStateCommandParameters, JsonContext.SetWebLifecycleStateResult);

    /// <summary>
    /// Stops sending each frame in the <b>screencastFrame</b>.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="StopScreencastCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StopScreencastResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<StopScreencastResult> StopScreencastAsync(StopScreencastCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new StopScreencastCommandParameters();
        return await ExecuteCommandAsync(StopScreencastCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StopScreencastCommandParameters, StopScreencastResult> StopScreencastCommand = new("Page.stopScreencast", JsonContext.StopScreencastCommandParameters, JsonContext.StopScreencastResult);

    /// <summary>
    /// Requests backend to produce compilation cache for the specified scripts.
    /// <b>scripts</b> are appended to the list of scripts for which the cache
    /// would be produced. The list may be reset during page navigation.
    /// When script with a matching URL is encountered, the cache is optionally
    /// produced upon backend discretion, based on internal heuristics.
    /// See also: <b>Page.compilationCacheProduced</b>.
    /// </summary>
    /// <param name="scripts">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ProduceCompilationCacheCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ProduceCompilationCacheResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<ProduceCompilationCacheResult> ProduceCompilationCacheAsync(IEnumerable<CompilationCacheParams> scripts, ProduceCompilationCacheCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ProduceCompilationCacheCommandParameters(Scripts: scripts);
        return await ExecuteCommandAsync(ProduceCompilationCacheCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ProduceCompilationCacheCommandParameters, ProduceCompilationCacheResult> ProduceCompilationCacheCommand = new("Page.produceCompilationCache", JsonContext.ProduceCompilationCacheCommandParameters, JsonContext.ProduceCompilationCacheResult);

    /// <summary>
    /// Seeds compilation cache for given url. Compilation cache does not survive
    /// cross-process navigation.
    /// </summary>
    /// <param name="url">
    /// </param>
    /// <param name="data">
    /// Base64-encoded data (Encoded as a base64 string when passed over JSON)
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="AddCompilationCacheCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AddCompilationCacheResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<AddCompilationCacheResult> AddCompilationCacheAsync(string url, string data, AddCompilationCacheCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new AddCompilationCacheCommandParameters(Url: url, Data: data);
        return await ExecuteCommandAsync(AddCompilationCacheCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AddCompilationCacheCommandParameters, AddCompilationCacheResult> AddCompilationCacheCommand = new("Page.addCompilationCache", JsonContext.AddCompilationCacheCommandParameters, JsonContext.AddCompilationCacheResult);

    /// <summary>
    /// Clears seeded compilation cache.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="ClearCompilationCacheCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearCompilationCacheResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<ClearCompilationCacheResult> ClearCompilationCacheAsync(ClearCompilationCacheCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearCompilationCacheCommandParameters();
        return await ExecuteCommandAsync(ClearCompilationCacheCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearCompilationCacheCommandParameters, ClearCompilationCacheResult> ClearCompilationCacheCommand = new("Page.clearCompilationCache", JsonContext.ClearCompilationCacheCommandParameters, JsonContext.ClearCompilationCacheResult);

    /// <summary>
    /// Sets the Secure Payment Confirmation transaction mode.
    /// https://w3c.github.io/secure-payment-confirmation/#sctn-automation-set-spc-transaction-mode
    /// </summary>
    /// <param name="mode">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetSPCTransactionModeCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetSPCTransactionModeResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetSPCTransactionModeResult> SetSPCTransactionModeAsync(string mode, SetSPCTransactionModeCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetSPCTransactionModeCommandParameters(Mode: mode);
        return await ExecuteCommandAsync(SetSPCTransactionModeCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetSPCTransactionModeCommandParameters, SetSPCTransactionModeResult> SetSPCTransactionModeCommand = new("Page.setSPCTransactionMode", JsonContext.SetSPCTransactionModeCommandParameters, JsonContext.SetSPCTransactionModeResult);

    /// <summary>
    /// Extensions for Custom Handlers API:
    /// https://html.spec.whatwg.org/multipage/system-state.html#rph-automation
    /// </summary>
    /// <param name="mode">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetRPHRegistrationModeCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetRPHRegistrationModeResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetRPHRegistrationModeResult> SetRPHRegistrationModeAsync(string mode, SetRPHRegistrationModeCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetRPHRegistrationModeCommandParameters(Mode: mode);
        return await ExecuteCommandAsync(SetRPHRegistrationModeCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetRPHRegistrationModeCommandParameters, SetRPHRegistrationModeResult> SetRPHRegistrationModeCommand = new("Page.setRPHRegistrationMode", JsonContext.SetRPHRegistrationModeCommandParameters, JsonContext.SetRPHRegistrationModeResult);

    /// <summary>
    /// Generates a report for testing.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Group</b> - Specifies the endpoint group to deliver the report to.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="message">
    /// Message to be displayed in the report.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GenerateTestReportCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GenerateTestReportResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GenerateTestReportResult> GenerateTestReportAsync(string message, GenerateTestReportCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GenerateTestReportCommandParameters(Message: message, Group: options?.Group);
        return await ExecuteCommandAsync(GenerateTestReportCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GenerateTestReportCommandParameters, GenerateTestReportResult> GenerateTestReportCommand = new("Page.generateTestReport", JsonContext.GenerateTestReportCommandParameters, JsonContext.GenerateTestReportResult);

    /// <summary>
    /// Pauses page execution. Can be resumed using generic Runtime.runIfWaitingForDebugger.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="WaitForDebuggerCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="WaitForDebuggerResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<WaitForDebuggerResult> WaitForDebuggerAsync(WaitForDebuggerCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new WaitForDebuggerCommandParameters();
        return await ExecuteCommandAsync(WaitForDebuggerCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<WaitForDebuggerCommandParameters, WaitForDebuggerResult> WaitForDebuggerCommand = new("Page.waitForDebugger", JsonContext.WaitForDebuggerCommandParameters, JsonContext.WaitForDebuggerResult);

    /// <summary>
    /// Intercept file chooser requests and transfer control to protocol clients.
    /// When file chooser interception is enabled, native file chooser dialog is not shown.
    /// Instead, a protocol event <b>Page.fileChooserOpened</b> is emitted.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Cancel</b> - If true, cancels the dialog by emitting relevant events (if any) in addition to not showing it if the interception is enabled (default: false).</description></item>
    /// </list>
    /// </remarks>
    /// <param name="enabled">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetInterceptFileChooserDialogCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetInterceptFileChooserDialogResult"/>.
    /// </returns>
    public async Task<SetInterceptFileChooserDialogResult> SetInterceptFileChooserDialogAsync(bool enabled, SetInterceptFileChooserDialogCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetInterceptFileChooserDialogCommandParameters(Enabled: enabled, Cancel: options?.Cancel);
        return await ExecuteCommandAsync(SetInterceptFileChooserDialogCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetInterceptFileChooserDialogCommandParameters, SetInterceptFileChooserDialogResult> SetInterceptFileChooserDialogCommand = new("Page.setInterceptFileChooserDialog", JsonContext.SetInterceptFileChooserDialogCommandParameters, JsonContext.SetInterceptFileChooserDialogResult);

    /// <summary>
    /// Enable/disable prerendering manually.
    /// 
    /// This command is a short-term solution for https://crbug.com/1440085.
    /// See https://docs.google.com/document/d/12HVmFxYj5Jc-eJr5OmWsa2bqTJsbgGLKI6ZIyx0_wpA
    /// for more details.
    /// 
    /// TODO(https://crbug.com/1440085): Remove this once Puppeteer supports tab targets.
    /// </summary>
    /// <param name="isAllowed">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetPrerenderingAllowedCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetPrerenderingAllowedResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetPrerenderingAllowedResult> SetPrerenderingAllowedAsync(bool isAllowed, SetPrerenderingAllowedCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetPrerenderingAllowedCommandParameters(IsAllowed: isAllowed);
        return await ExecuteCommandAsync(SetPrerenderingAllowedCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetPrerenderingAllowedCommandParameters, SetPrerenderingAllowedResult> SetPrerenderingAllowedCommand = new("Page.setPrerenderingAllowed", JsonContext.SetPrerenderingAllowedCommandParameters, JsonContext.SetPrerenderingAllowedResult);

    /// <summary>
    /// Get the annotated page content for the main frame.
    /// This is an experimental command that is subject to change.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>IncludeActionableInformation</b> - Whether to include actionable information. Defaults to true.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetAnnotatedPageContentCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetAnnotatedPageContentResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetAnnotatedPageContentResult> GetAnnotatedPageContentAsync(GetAnnotatedPageContentCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetAnnotatedPageContentCommandParameters(IncludeActionableInformation: options?.IncludeActionableInformation);
        return await ExecuteCommandAsync(GetAnnotatedPageContentCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetAnnotatedPageContentCommandParameters, GetAnnotatedPageContentResult> GetAnnotatedPageContentCommand = new("Page.getAnnotatedPageContent", JsonContext.GetAnnotatedPageContentCommandParameters, JsonContext.GetAnnotatedPageContentResult);

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DomContentEventFiredEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Timestamp</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<DomContentEventFiredEventArgs> DomContentEventFired => CreateCdpEventSource(PageDomainEvent.DomContentEventFired);
    /// <summary>
    /// Emitted only when <b>page.interceptFileChooser</b> is enabled.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="FileChooserOpenedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>FrameId</b> - Id of the frame containing input node.</description></item>
    /// <item><description><b>Mode</b> - Input mode.</description></item>
    /// <item><description><b>BackendNodeId</b> - Input node id. Only present for file choosers opened via an <b>&lt;input type="file"&gt;</b> element.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<FileChooserOpenedEventArgs> FileChooserOpened => CreateCdpEventSource(PageDomainEvent.FileChooserOpened);
    /// <summary>
    /// Fired when frame has been attached to its parent.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="FrameAttachedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>FrameId</b> - Id of the frame that has been attached.</description></item>
    /// <item><description><b>ParentFrameId</b> - Parent frame identifier.</description></item>
    /// <item><description><b>Stack</b> - JavaScript stack trace of when frame was attached, only set if frame initiated from script.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<FrameAttachedEventArgs> FrameAttached => CreateCdpEventSource(PageDomainEvent.FrameAttached);
    /// <summary>
    /// Fired when frame no longer has a scheduled navigation.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="FrameClearedScheduledNavigationEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>FrameId</b> - Id of the frame that has cleared its scheduled navigation.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Obsolete]
    public IEventSource<FrameClearedScheduledNavigationEventArgs> FrameClearedScheduledNavigation => CreateCdpEventSource(PageDomainEvent.FrameClearedScheduledNavigation);
    /// <summary>
    /// Fired when frame has been detached from its parent.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="FrameDetachedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>FrameId</b> - Id of the frame that has been detached.</description></item>
    /// <item><description><b>Reason</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<FrameDetachedEventArgs> FrameDetached => CreateCdpEventSource(PageDomainEvent.FrameDetached);
    /// <summary>
    /// Fired before frame subtree is detached. Emitted before any frame of the
    /// subtree is actually detached.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="FrameSubtreeWillBeDetachedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>FrameId</b> - Id of the frame that is the root of the subtree that will be detached.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<FrameSubtreeWillBeDetachedEventArgs> FrameSubtreeWillBeDetached => CreateCdpEventSource(PageDomainEvent.FrameSubtreeWillBeDetached);
    /// <summary>
    /// Fired once navigation of the frame has completed. Frame is now associated with the new loader.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="FrameNavigatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Frame</b> - Frame object.</description></item>
    /// <item><description><b>Type</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<FrameNavigatedEventArgs> FrameNavigated => CreateCdpEventSource(PageDomainEvent.FrameNavigated);
    /// <summary>
    /// Fired when opening document to write to.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DocumentOpenedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Frame</b> - Frame object.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DocumentOpenedEventArgs> DocumentOpened => CreateCdpEventSource(PageDomainEvent.DocumentOpened);
    /// <summary>
    /// 
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<FrameResizedEventArgs> FrameResized => CreateCdpEventSource(PageDomainEvent.FrameResized);
    /// <summary>
    /// Fired when a navigation starts. This event is fired for both
    /// renderer-initiated and browser-initiated navigations. For renderer-initiated
    /// navigations, the event is fired after <b>frameRequestedNavigation</b>.
    /// Navigation may still be cancelled after the event is issued. Multiple events
    /// can be fired for a single navigation, for example, when a same-document
    /// navigation becomes a cross-document navigation (such as in the case of a
    /// frameset).
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="FrameStartedNavigatingEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>FrameId</b> - ID of the frame that is being navigated.</description></item>
    /// <item><description><b>Url</b> - The URL the navigation started with. The final URL can be different.</description></item>
    /// <item><description><b>LoaderId</b> - Loader identifier. Even though it is present in case of same-document navigation, the previously committed loaderId would not change unless the navigation changes from a same-document to a cross-document navigation.</description></item>
    /// <item><description><b>NavigationType</b></description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<FrameStartedNavigatingEventArgs> FrameStartedNavigating => CreateCdpEventSource(PageDomainEvent.FrameStartedNavigating);
    /// <summary>
    /// Fired when a renderer-initiated navigation is requested.
    /// Navigation may still be cancelled after the event is issued.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="FrameRequestedNavigationEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>FrameId</b> - Id of the frame that is being navigated.</description></item>
    /// <item><description><b>Reason</b> - The reason for the navigation.</description></item>
    /// <item><description><b>Url</b> - The destination URL for the requested navigation.</description></item>
    /// <item><description><b>Disposition</b> - The disposition for the navigation.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<FrameRequestedNavigationEventArgs> FrameRequestedNavigation => CreateCdpEventSource(PageDomainEvent.FrameRequestedNavigation);
    /// <summary>
    /// Fired when frame schedules a potential navigation.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="FrameScheduledNavigationEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>FrameId</b> - Id of the frame that has scheduled a navigation.</description></item>
    /// <item><description><b>Delay</b> - Delay (in seconds) until the navigation is scheduled to begin. The navigation is not guaranteed to start.</description></item>
    /// <item><description><b>Reason</b> - The reason for the navigation.</description></item>
    /// <item><description><b>Url</b> - The destination URL for the scheduled navigation.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Obsolete]
    public IEventSource<FrameScheduledNavigationEventArgs> FrameScheduledNavigation => CreateCdpEventSource(PageDomainEvent.FrameScheduledNavigation);
    /// <summary>
    /// Fired when frame has started loading.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="FrameStartedLoadingEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>FrameId</b> - Id of the frame that has started loading.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<FrameStartedLoadingEventArgs> FrameStartedLoading => CreateCdpEventSource(PageDomainEvent.FrameStartedLoading);
    /// <summary>
    /// Fired when frame has stopped loading.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="FrameStoppedLoadingEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>FrameId</b> - Id of the frame that has stopped loading.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<FrameStoppedLoadingEventArgs> FrameStoppedLoading => CreateCdpEventSource(PageDomainEvent.FrameStoppedLoading);
    /// <summary>
    /// Fired when page is about to start a download.
    /// Deprecated. Use Browser.downloadWillBegin instead.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DownloadWillBeginEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>FrameId</b> - Id of the frame that caused download to begin.</description></item>
    /// <item><description><b>Guid</b> - Global unique identifier of the download.</description></item>
    /// <item><description><b>Url</b> - URL of the resource being downloaded.</description></item>
    /// <item><description><b>SuggestedFilename</b> - Suggested file name of the resource (the actual name of the file saved on disk may differ).</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public IEventSource<DownloadWillBeginEventArgs> DownloadWillBegin => CreateCdpEventSource(PageDomainEvent.DownloadWillBegin);
    /// <summary>
    /// Fired when download makes progress. Last call has |done| == true.
    /// Deprecated. Use Browser.downloadProgress instead.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DownloadProgressEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Guid</b> - Global unique identifier of the download.</description></item>
    /// <item><description><b>TotalBytes</b> - Total expected bytes to download.</description></item>
    /// <item><description><b>ReceivedBytes</b> - Total bytes received.</description></item>
    /// <item><description><b>State</b> - Download status.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public IEventSource<DownloadProgressEventArgs> DownloadProgress => CreateCdpEventSource(PageDomainEvent.DownloadProgress);
    /// <summary>
    /// Fired when interstitial page was hidden
    /// </summary>
    public IEventSource<InterstitialHiddenEventArgs> InterstitialHidden => CreateCdpEventSource(PageDomainEvent.InterstitialHidden);
    /// <summary>
    /// Fired when interstitial page was shown
    /// </summary>
    public IEventSource<InterstitialShownEventArgs> InterstitialShown => CreateCdpEventSource(PageDomainEvent.InterstitialShown);
    /// <summary>
    /// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) has been
    /// closed.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="JavascriptDialogClosedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>FrameId</b> - Frame id.</description></item>
    /// <item><description><b>Result</b> - Whether dialog was confirmed.</description></item>
    /// <item><description><b>UserInput</b> - User input in case of prompt.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<JavascriptDialogClosedEventArgs> JavascriptDialogClosed => CreateCdpEventSource(PageDomainEvent.JavascriptDialogClosed);
    /// <summary>
    /// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) is about to
    /// open.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="JavascriptDialogOpeningEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Url</b> - Frame url.</description></item>
    /// <item><description><b>FrameId</b> - Frame id.</description></item>
    /// <item><description><b>Message</b> - Message that will be displayed by the dialog.</description></item>
    /// <item><description><b>Type</b> - Dialog type.</description></item>
    /// <item><description><b>HasBrowserHandler</b> - True iff browser is capable showing or acting on the given dialog. When browser has no dialog handler for given target, calling alert while Page domain is engaged will stall the page execution. Execution can be resumed via calling Page.handleJavaScriptDialog.</description></item>
    /// <item><description><b>DefaultPrompt</b> - Default dialog prompt.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<JavascriptDialogOpeningEventArgs> JavascriptDialogOpening => CreateCdpEventSource(PageDomainEvent.JavascriptDialogOpening);
    /// <summary>
    /// Fired for lifecycle events (navigation, load, paint, etc) in the current
    /// target (including local frames).
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="LifecycleEventEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>FrameId</b> - Id of the frame.</description></item>
    /// <item><description><b>LoaderId</b> - Loader identifier. Empty string if the request is fetched from worker.</description></item>
    /// <item><description><b>Name</b></description></item>
    /// <item><description><b>Timestamp</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<LifecycleEventEventArgs> LifecycleEvent => CreateCdpEventSource(PageDomainEvent.LifecycleEvent);
    /// <summary>
    /// Fired for failed bfcache history navigations if BackForwardCache feature is enabled. Do
    /// not assume any ordering with the Page.frameNavigated event. This event is fired only for
    /// main-frame history navigation where the document changes (non-same-document navigations),
    /// when bfcache navigation fails.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="BackForwardCacheNotUsedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>LoaderId</b> - The loader id for the associated navigation.</description></item>
    /// <item><description><b>FrameId</b> - The frame id of the associated frame.</description></item>
    /// <item><description><b>NotRestoredExplanations</b> - Array of reasons why the page could not be cached. This must not be empty.</description></item>
    /// <item><description><b>NotRestoredExplanationsTree</b> - Tree structure of reasons why the page could not be cached for each frame.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<BackForwardCacheNotUsedEventArgs> BackForwardCacheNotUsed => CreateCdpEventSource(PageDomainEvent.BackForwardCacheNotUsed);
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="LoadEventFiredEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Timestamp</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<LoadEventFiredEventArgs> LoadEventFired => CreateCdpEventSource(PageDomainEvent.LoadEventFired);
    /// <summary>
    /// Fired when same-document navigation happens, e.g. due to history API usage or anchor navigation.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="NavigatedWithinDocumentEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>FrameId</b> - Id of the frame.</description></item>
    /// <item><description><b>Url</b> - Frame's new url.</description></item>
    /// <item><description><b>NavigationType</b> - Navigation type</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<NavigatedWithinDocumentEventArgs> NavigatedWithinDocument => CreateCdpEventSource(PageDomainEvent.NavigatedWithinDocument);
    /// <summary>
    /// Compressed image data requested by the <b>startScreencast</b>.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ScreencastFrameEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Data</b> - Base64-encoded compressed image. (Encoded as a base64 string when passed over JSON)</description></item>
    /// <item><description><b>Metadata</b> - Screencast frame metadata.</description></item>
    /// <item><description><b>SessionId</b> - Frame number.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<ScreencastFrameEventArgs> ScreencastFrame => CreateCdpEventSource(PageDomainEvent.ScreencastFrame);
    /// <summary>
    /// Fired when the page with currently enabled screencast was shown or hidden `.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ScreencastVisibilityChangedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Visible</b> - True if the page is visible.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<ScreencastVisibilityChangedEventArgs> ScreencastVisibilityChanged => CreateCdpEventSource(PageDomainEvent.ScreencastVisibilityChanged);
    /// <summary>
    /// Fired when a new window is going to be opened, via window.open(), link click, form submission,
    /// etc.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="WindowOpenEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Url</b> - The URL for the new window.</description></item>
    /// <item><description><b>WindowName</b> - Window name.</description></item>
    /// <item><description><b>WindowFeatures</b> - An array of enabled window features.</description></item>
    /// <item><description><b>UserGesture</b> - Whether or not it was triggered by user gesture.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<WindowOpenEventArgs> WindowOpen => CreateCdpEventSource(PageDomainEvent.WindowOpen);
    /// <summary>
    /// Issued for every compilation cache generated.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="CompilationCacheProducedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Url</b></description></item>
    /// <item><description><b>Data</b> - Base64-encoded data (Encoded as a base64 string when passed over JSON)</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<CompilationCacheProducedEventArgs> CompilationCacheProduced => CreateCdpEventSource(PageDomainEvent.CompilationCacheProduced);
}

internal sealed record AddScriptToEvaluateOnLoadCommandParameters(string ScriptSource) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.AddScriptToEvaluateOnLoadAsync"/>.
/// </summary>
public sealed record AddScriptToEvaluateOnLoadCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Identifier">
/// Identifier of the added script.
/// </param>
public sealed record AddScriptToEvaluateOnLoadResult(ScriptIdentifier Identifier) : EmptyResult;


internal sealed record AddScriptToEvaluateOnNewDocumentCommandParameters(string Source, string? WorldName, bool? IncludeCommandLineAPI, bool? RunImmediately) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.AddScriptToEvaluateOnNewDocumentAsync"/>.
/// </summary>
public sealed record AddScriptToEvaluateOnNewDocumentCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// If specified, creates an isolated world with the given name and evaluates given script in it.
    /// This world name will be used as the ExecutionContextDescription::name when the corresponding
    /// event is emitted.
    /// </summary>
    public string? WorldName { get; init; }

    /// <summary>
    /// Specifies whether command line API should be available to the script, defaults
    /// to false.
    /// </summary>
    public bool? IncludeCommandLineAPI { get; init; }

    /// <summary>
    /// If true, runs the script immediately on existing execution contexts or worlds.
    /// Default: false.
    /// </summary>
    public bool? RunImmediately { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Identifier">
/// Identifier of the added script.
/// </param>
public sealed record AddScriptToEvaluateOnNewDocumentResult(ScriptIdentifier Identifier) : EmptyResult;


internal sealed record BringToFrontCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.BringToFrontAsync"/>.
/// </summary>
public sealed record BringToFrontCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record BringToFrontResult() : EmptyResult;


internal sealed record CaptureScreenshotCommandParameters(string? Format, long? Quality, Viewport? Clip, bool? FromSurface, bool? CaptureBeyondViewport, bool? OptimizeForSpeed) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.CaptureScreenshotAsync"/>.
/// </summary>
public sealed record CaptureScreenshotCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Image compression format (defaults to png).
    /// </summary>
    public string? Format { get; init; }

    /// <summary>
    /// Compression quality from range [0..100] (jpeg only).
    /// </summary>
    public long? Quality { get; init; }

    /// <summary>
    /// Capture the screenshot of a given region only.
    /// </summary>
    public Viewport? Clip { get; init; }

    /// <summary>
    /// Capture the screenshot from the surface, rather than the view. Defaults to true.
    /// </summary>
    public bool? FromSurface { get; init; }

    /// <summary>
    /// Capture the screenshot beyond the viewport. Defaults to false.
    /// </summary>
    public bool? CaptureBeyondViewport { get; init; }

    /// <summary>
    /// Optimize image encoding for speed, not for resulting size (defaults to false)
    /// </summary>
    public bool? OptimizeForSpeed { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Data">
/// Base64-encoded image data. (Encoded as a base64 string when passed over JSON)
/// </param>
public sealed record CaptureScreenshotResult(string Data) : EmptyResult;


internal sealed record CaptureSnapshotCommandParameters(string? Format) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.CaptureSnapshotAsync"/>.
/// </summary>
public sealed record CaptureSnapshotCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Format (defaults to mhtml).
    /// </summary>
    public string? Format { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Data">
/// Serialized page data.
/// </param>
public sealed record CaptureSnapshotResult(string Data) : EmptyResult;


internal sealed record ClearDeviceMetricsOverrideCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.ClearDeviceMetricsOverrideAsync"/>.
/// </summary>
public sealed record ClearDeviceMetricsOverrideCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ClearDeviceMetricsOverrideResult() : EmptyResult;


internal sealed record ClearDeviceOrientationOverrideCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.ClearDeviceOrientationOverrideAsync"/>.
/// </summary>
public sealed record ClearDeviceOrientationOverrideCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ClearDeviceOrientationOverrideResult() : EmptyResult;


internal sealed record ClearGeolocationOverrideCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.ClearGeolocationOverrideAsync"/>.
/// </summary>
public sealed record ClearGeolocationOverrideCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ClearGeolocationOverrideResult() : EmptyResult;


internal sealed record CreateIsolatedWorldCommandParameters(FrameId FrameId, string? WorldName, bool? GrantUniveralAccess, string? ContentSecurityPolicy) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.CreateIsolatedWorldAsync"/>.
/// </summary>
public sealed record CreateIsolatedWorldCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// An optional name which is reported in the Execution Context.
    /// </summary>
    public string? WorldName { get; init; }

    /// <summary>
    /// Whether or not universal access should be granted to the isolated world. This is a powerful
    /// option, use with caution.
    /// </summary>
    public bool? GrantUniveralAccess { get; init; }

    /// <summary>
    /// An optional content security policy to set for the isolated world.
    /// If omitted, any existing CSP for the world will be cleared.
    /// Note that clearing or updating the CSP does not immediately affect the active
    /// context in the same document because LocalDOMWindow caches the
    /// ContentSecurityPolicy object. The change takes effect on subsequent
    /// navigations when a new window context is created.
    /// </summary>
    public string? ContentSecurityPolicy { get; init; }
}

/// <summary>
/// </summary>
/// <param name="ExecutionContextId">
/// Execution context of the isolated world.
/// </param>
public sealed record CreateIsolatedWorldResult(Runtime.ExecutionContextId ExecutionContextId) : EmptyResult;


internal sealed record DeleteCookieCommandParameters(string CookieName, string Url) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.DeleteCookieAsync"/>.
/// </summary>
public sealed record DeleteCookieCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DeleteCookieResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.DisableAsync"/>.
/// </summary>
public sealed record DisableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters(bool? EnableFileChooserOpenedEvent) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.EnableAsync"/>.
/// </summary>
public sealed record EnableCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// If true, the <b>Page.fileChooserOpened</b> event will be emitted regardless of the state set by
    /// <b>Page.setInterceptFileChooserDialog</b> command (default: false).
    /// </summary>
    public bool? EnableFileChooserOpenedEvent { get; init; }
}

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record GetAppManifestCommandParameters(string? ManifestId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.GetAppManifestAsync"/>.
/// </summary>
public sealed record GetAppManifestCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// </summary>
    public string? ManifestId { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Url">
/// Manifest location.
/// </param>
/// <param name="Errors">
/// </param>
/// <param name="Data">
/// Manifest content.
/// </param>
/// <param name="Parsed">
/// Parsed manifest properties. Deprecated, use manifest instead.
/// </param>
/// <param name="Manifest">
/// </param>
public sealed record GetAppManifestResult(string Url, IReadOnlyList<AppManifestError> Errors, string? Data, AppManifestParsedProperties? Parsed, WebAppManifest Manifest) : EmptyResult;


internal sealed record GetInstallabilityErrorsCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.GetInstallabilityErrorsAsync"/>.
/// </summary>
public sealed record GetInstallabilityErrorsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="InstallabilityErrors">
/// </param>
public sealed record GetInstallabilityErrorsResult(IReadOnlyList<InstallabilityError> InstallabilityErrors) : EmptyResult;


internal sealed record GetManifestIconsCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.GetManifestIconsAsync"/>.
/// </summary>
public sealed record GetManifestIconsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="PrimaryIcon">
/// </param>
public sealed record GetManifestIconsResult(string? PrimaryIcon) : EmptyResult;


internal sealed record GetAppIdCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.GetAppIdAsync"/>.
/// </summary>
public sealed record GetAppIdCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="AppId">
/// App id, either from manifest's id attribute or computed from start_url
/// </param>
/// <param name="RecommendedId">
/// Recommendation for manifest's id attribute to match current id computed from start_url
/// </param>
public sealed record GetAppIdResult(string? AppId, string? RecommendedId) : EmptyResult;


internal sealed record GetAdScriptAncestryCommandParameters(FrameId FrameId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.GetAdScriptAncestryAsync"/>.
/// </summary>
public sealed record GetAdScriptAncestryCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="AdScriptAncestry">
/// The ancestry chain of ad script identifiers leading to this frame's
/// creation, along with the root script's filterlist rule. The ancestry
/// chain is ordered from the most immediate script (in the frame creation
/// stack) to more distant ancestors (that created the immediately preceding
/// script). Only sent if frame is labelled as an ad and ids are available.
/// </param>
public sealed record GetAdScriptAncestryResult(Network.AdAncestry? AdScriptAncestry) : EmptyResult;


internal sealed record GetFrameTreeCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.GetFrameTreeAsync"/>.
/// </summary>
public sealed record GetFrameTreeCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="FrameTree">
/// Present frame tree structure.
/// </param>
public sealed record GetFrameTreeResult(FrameTree FrameTree) : EmptyResult;


internal sealed record GetLayoutMetricsCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.GetLayoutMetricsAsync"/>.
/// </summary>
public sealed record GetLayoutMetricsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="LayoutViewport">
/// Deprecated metrics relating to the layout viewport. Is in device pixels. Use <b>cssLayoutViewport</b> instead.
/// </param>
/// <param name="VisualViewport">
/// Deprecated metrics relating to the visual viewport. Is in device pixels. Use <b>cssVisualViewport</b> instead.
/// </param>
/// <param name="ContentSize">
/// Deprecated size of scrollable area. Is in DP. Use <b>cssContentSize</b> instead.
/// </param>
/// <param name="CssLayoutViewport">
/// Metrics relating to the layout viewport in CSS pixels.
/// </param>
/// <param name="CssVisualViewport">
/// Metrics relating to the visual viewport in CSS pixels.
/// </param>
/// <param name="CssContentSize">
/// Size of scrollable area in CSS pixels.
/// </param>
public sealed record GetLayoutMetricsResult(LayoutViewport LayoutViewport, VisualViewport VisualViewport, DOM.Rect ContentSize, LayoutViewport CssLayoutViewport, VisualViewport CssVisualViewport, DOM.Rect CssContentSize) : EmptyResult;


internal sealed record GetNavigationHistoryCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.GetNavigationHistoryAsync"/>.
/// </summary>
public sealed record GetNavigationHistoryCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="CurrentIndex">
/// Index of the current navigation history entry.
/// </param>
/// <param name="Entries">
/// Array of navigation history entries.
/// </param>
public sealed record GetNavigationHistoryResult(long CurrentIndex, IReadOnlyList<NavigationEntry> Entries) : EmptyResult;


internal sealed record ResetNavigationHistoryCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.ResetNavigationHistoryAsync"/>.
/// </summary>
public sealed record ResetNavigationHistoryCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ResetNavigationHistoryResult() : EmptyResult;


internal sealed record GetResourceContentCommandParameters(FrameId FrameId, string Url) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.GetResourceContentAsync"/>.
/// </summary>
public sealed record GetResourceContentCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Content">
/// Resource content.
/// </param>
/// <param name="Base64Encoded">
/// True, if content was served as base64.
/// </param>
public sealed record GetResourceContentResult(string Content, bool Base64Encoded) : EmptyResult;


internal sealed record GetResourceTreeCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.GetResourceTreeAsync"/>.
/// </summary>
public sealed record GetResourceTreeCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="FrameTree">
/// Present frame / resource tree structure.
/// </param>
public sealed record GetResourceTreeResult(FrameResourceTree FrameTree) : EmptyResult;


internal sealed record HandleJavaScriptDialogCommandParameters(bool Accept, string? PromptText) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.HandleJavaScriptDialogAsync"/>.
/// </summary>
public sealed record HandleJavaScriptDialogCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// The text to enter into the dialog prompt before accepting. Used only if this is a prompt
    /// dialog.
    /// </summary>
    public string? PromptText { get; init; }
}

/// <summary>
/// </summary>
public sealed record HandleJavaScriptDialogResult() : EmptyResult;


internal sealed record NavigateCommandParameters(string Url, string? Referrer, TransitionType? TransitionType, FrameId? FrameId, ReferrerPolicy? ReferrerPolicy) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.NavigateAsync"/>.
/// </summary>
public sealed record NavigateCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Referrer URL.
    /// </summary>
    public string? Referrer { get; init; }

    /// <summary>
    /// Intended transition type.
    /// </summary>
    public TransitionType? TransitionType { get; init; }

    /// <summary>
    /// Frame id to navigate, if not specified navigates the top frame.
    /// </summary>
    public FrameId? FrameId { get; init; }

    /// <summary>
    /// Referrer-policy used for the navigation.
    /// </summary>
    public ReferrerPolicy? ReferrerPolicy { get; init; }
}

/// <summary>
/// </summary>
/// <param name="FrameId">
/// Frame id that has navigated (or failed to navigate)
/// </param>
/// <param name="LoaderId">
/// Loader identifier. This is omitted in case of same-document navigation,
/// as the previously committed loaderId would not change.
/// </param>
/// <param name="ErrorText">
/// User friendly error message, present if and only if navigation has failed.
/// </param>
/// <param name="IsDownload">
/// Whether the navigation resulted in a download.
/// </param>
public sealed record NavigateResult(FrameId FrameId, Network.LoaderId? LoaderId, string? ErrorText, bool? IsDownload) : EmptyResult;


internal sealed record NavigateToHistoryEntryCommandParameters(long EntryId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.NavigateToHistoryEntryAsync"/>.
/// </summary>
public sealed record NavigateToHistoryEntryCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record NavigateToHistoryEntryResult() : EmptyResult;


internal sealed record PrintToPDFCommandParameters(bool? Landscape, bool? DisplayHeaderFooter, bool? PrintBackground, double? Scale, double? PaperWidth, double? PaperHeight, double? MarginTop, double? MarginBottom, double? MarginLeft, double? MarginRight, string? PageRanges, string? HeaderTemplate, string? FooterTemplate, bool? PreferCSSPageSize, string? TransferMode, bool? GenerateTaggedPDF, bool? GenerateDocumentOutline) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.PrintToPDFAsync"/>.
/// </summary>
public sealed record PrintToPDFCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Paper orientation. Defaults to false.
    /// </summary>
    public bool? Landscape { get; init; }

    /// <summary>
    /// Display header and footer. Defaults to false.
    /// </summary>
    public bool? DisplayHeaderFooter { get; init; }

    /// <summary>
    /// Print background graphics. Defaults to false.
    /// </summary>
    public bool? PrintBackground { get; init; }

    /// <summary>
    /// Scale of the webpage rendering. Defaults to 1.
    /// </summary>
    public double? Scale { get; init; }

    /// <summary>
    /// Paper width in inches. Defaults to 8.5 inches.
    /// </summary>
    public double? PaperWidth { get; init; }

    /// <summary>
    /// Paper height in inches. Defaults to 11 inches.
    /// </summary>
    public double? PaperHeight { get; init; }

    /// <summary>
    /// Top margin in inches. Defaults to 1cm (~0.4 inches).
    /// </summary>
    public double? MarginTop { get; init; }

    /// <summary>
    /// Bottom margin in inches. Defaults to 1cm (~0.4 inches).
    /// </summary>
    public double? MarginBottom { get; init; }

    /// <summary>
    /// Left margin in inches. Defaults to 1cm (~0.4 inches).
    /// </summary>
    public double? MarginLeft { get; init; }

    /// <summary>
    /// Right margin in inches. Defaults to 1cm (~0.4 inches).
    /// </summary>
    public double? MarginRight { get; init; }

    /// <summary>
    /// Paper ranges to print, one based, e.g., '1-5, 8, 11-13'. Pages are
    /// printed in the document order, not in the order specified, and no
    /// more than once.
    /// Defaults to empty string, which implies the entire document is printed.
    /// The page numbers are quietly capped to actual page count of the
    /// document, and ranges beyond the end of the document are ignored.
    /// If this results in no pages to print, an error is reported.
    /// It is an error to specify a range with start greater than end.
    /// </summary>
    public string? PageRanges { get; init; }

    /// <summary>
    /// HTML template for the print header. Should be valid HTML markup with following
    /// classes used to inject printing values into them:
    /// - <b>date</b>: formatted print date
    /// - <b>title</b>: document title
    /// - <b>url</b>: document location
    /// - <b>pageNumber</b>: current page number
    /// - <b>totalPages</b>: total pages in the document
    /// 
    /// For example, <b>&lt;span class=title&gt;&lt;/span&gt;</b> would generate span containing the title.
    /// </summary>
    public string? HeaderTemplate { get; init; }

    /// <summary>
    /// HTML template for the print footer. Should use the same format as the <b>headerTemplate</b>.
    /// </summary>
    public string? FooterTemplate { get; init; }

    /// <summary>
    /// Whether or not to prefer page size as defined by css. Defaults to false,
    /// in which case the content will be scaled to fit the paper size.
    /// </summary>
    public bool? PreferCSSPageSize { get; init; }

    /// <summary>
    /// return as stream
    /// </summary>
    public string? TransferMode { get; init; }

    /// <summary>
    /// Whether or not to generate tagged (accessible) PDF. Defaults to embedder choice.
    /// </summary>
    public bool? GenerateTaggedPDF { get; init; }

    /// <summary>
    /// Whether or not to embed the document outline into the PDF.
    /// </summary>
    public bool? GenerateDocumentOutline { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Data">
/// Base64-encoded pdf data. Empty if |returnAsStream| is specified. (Encoded as a base64 string when passed over JSON)
/// </param>
/// <param name="Stream">
/// A handle of the stream that holds resulting PDF data.
/// </param>
public sealed record PrintToPDFResult(string Data, IO.StreamHandle? Stream) : EmptyResult;


internal sealed record ReloadCommandParameters(bool? IgnoreCache, string? ScriptToEvaluateOnLoad, Network.LoaderId? LoaderId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.ReloadAsync"/>.
/// </summary>
public sealed record ReloadCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// If true, browser cache is ignored (as if the user pressed Shift+refresh).
    /// </summary>
    public bool? IgnoreCache { get; init; }

    /// <summary>
    /// If set, the script will be injected into all frames of the inspected page after reload.
    /// Argument will be ignored if reloading dataURL origin.
    /// </summary>
    public string? ScriptToEvaluateOnLoad { get; init; }

    /// <summary>
    /// If set, an error will be thrown if the target page's main frame's
    /// loader id does not match the provided id. This prevents accidentally
    /// reloading an unintended target in case there's a racing navigation.
    /// </summary>
    public Network.LoaderId? LoaderId { get; init; }
}

/// <summary>
/// </summary>
public sealed record ReloadResult() : EmptyResult;


internal sealed record RemoveScriptToEvaluateOnLoadCommandParameters(ScriptIdentifier Identifier) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.RemoveScriptToEvaluateOnLoadAsync"/>.
/// </summary>
public sealed record RemoveScriptToEvaluateOnLoadCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record RemoveScriptToEvaluateOnLoadResult() : EmptyResult;


internal sealed record RemoveScriptToEvaluateOnNewDocumentCommandParameters(ScriptIdentifier Identifier) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.RemoveScriptToEvaluateOnNewDocumentAsync"/>.
/// </summary>
public sealed record RemoveScriptToEvaluateOnNewDocumentCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record RemoveScriptToEvaluateOnNewDocumentResult() : EmptyResult;


internal sealed record ScreencastFrameAckCommandParameters(long SessionId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.ScreencastFrameAckAsync"/>.
/// </summary>
public sealed record ScreencastFrameAckCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ScreencastFrameAckResult() : EmptyResult;


internal sealed record SearchInResourceCommandParameters(FrameId FrameId, string Url, string Query, bool? CaseSensitive, bool? IsRegex) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.SearchInResourceAsync"/>.
/// </summary>
public sealed record SearchInResourceCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// If true, search is case sensitive.
    /// </summary>
    public bool? CaseSensitive { get; init; }

    /// <summary>
    /// If true, treats string parameter as regex.
    /// </summary>
    public bool? IsRegex { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Result">
/// List of search matches.
/// </param>
public sealed record SearchInResourceResult(IReadOnlyList<Debugger.SearchMatch> Result) : EmptyResult;


internal sealed record SetAdBlockingEnabledCommandParameters(bool Enabled) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.SetAdBlockingEnabledAsync"/>.
/// </summary>
public sealed record SetAdBlockingEnabledCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetAdBlockingEnabledResult() : EmptyResult;


internal sealed record SetBypassCSPCommandParameters(bool Enabled) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.SetBypassCSPAsync"/>.
/// </summary>
public sealed record SetBypassCSPCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetBypassCSPResult() : EmptyResult;


internal sealed record GetPermissionsPolicyStateCommandParameters(FrameId FrameId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.GetPermissionsPolicyStateAsync"/>.
/// </summary>
public sealed record GetPermissionsPolicyStateCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="States">
/// </param>
public sealed record GetPermissionsPolicyStateResult(IReadOnlyList<PermissionsPolicyFeatureState> States) : EmptyResult;


internal sealed record GetOriginTrialsCommandParameters(FrameId FrameId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.GetOriginTrialsAsync"/>.
/// </summary>
public sealed record GetOriginTrialsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="OriginTrials">
/// </param>
public sealed record GetOriginTrialsResult(IReadOnlyList<OriginTrial> OriginTrials) : EmptyResult;


internal sealed record SetDeviceMetricsOverrideCommandParameters(long Width, long Height, double DeviceScaleFactor, bool Mobile, double? Scale, long? ScreenWidth, long? ScreenHeight, long? PositionX, long? PositionY, bool? DontSetVisibleSize, Emulation.ScreenOrientation? ScreenOrientation, Viewport? Viewport) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.SetDeviceMetricsOverrideAsync"/>.
/// </summary>
public sealed record SetDeviceMetricsOverrideCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Scale to apply to resulting view image.
    /// </summary>
    public double? Scale { get; init; }

    /// <summary>
    /// Overriding screen width value in pixels (minimum 0, maximum 10000000).
    /// </summary>
    public long? ScreenWidth { get; init; }

    /// <summary>
    /// Overriding screen height value in pixels (minimum 0, maximum 10000000).
    /// </summary>
    public long? ScreenHeight { get; init; }

    /// <summary>
    /// Overriding view X position on screen in pixels (minimum 0, maximum 10000000).
    /// </summary>
    public long? PositionX { get; init; }

    /// <summary>
    /// Overriding view Y position on screen in pixels (minimum 0, maximum 10000000).
    /// </summary>
    public long? PositionY { get; init; }

    /// <summary>
    /// Do not set visible view size, rely upon explicit setVisibleSize call.
    /// </summary>
    public bool? DontSetVisibleSize { get; init; }

    /// <summary>
    /// Screen orientation override.
    /// </summary>
    public Emulation.ScreenOrientation? ScreenOrientation { get; init; }

    /// <summary>
    /// The viewport dimensions and scale. If not set, the override is cleared.
    /// </summary>
    public Viewport? Viewport { get; init; }
}

/// <summary>
/// </summary>
public sealed record SetDeviceMetricsOverrideResult() : EmptyResult;


internal sealed record SetDeviceOrientationOverrideCommandParameters(double Alpha, double Beta, double Gamma) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.SetDeviceOrientationOverrideAsync"/>.
/// </summary>
public sealed record SetDeviceOrientationOverrideCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetDeviceOrientationOverrideResult() : EmptyResult;


internal sealed record SetFontFamiliesCommandParameters(FontFamilies FontFamilies, IEnumerable<ScriptFontFamilies>? ForScripts) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.SetFontFamiliesAsync"/>.
/// </summary>
public sealed record SetFontFamiliesCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Specifies font families to set for individual scripts.
    /// </summary>
    public IEnumerable<ScriptFontFamilies>? ForScripts { get; init; }
}

/// <summary>
/// </summary>
public sealed record SetFontFamiliesResult() : EmptyResult;


internal sealed record SetFontSizesCommandParameters(FontSizes FontSizes) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.SetFontSizesAsync"/>.
/// </summary>
public sealed record SetFontSizesCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetFontSizesResult() : EmptyResult;


internal sealed record SetDocumentContentCommandParameters(FrameId FrameId, string Html) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.SetDocumentContentAsync"/>.
/// </summary>
public sealed record SetDocumentContentCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetDocumentContentResult() : EmptyResult;


internal sealed record SetDownloadBehaviorCommandParameters(string Behavior, string? DownloadPath) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.SetDownloadBehaviorAsync"/>.
/// </summary>
public sealed record SetDownloadBehaviorCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// The default path to save downloaded files to. This is required if behavior is set to 'allow'
    /// </summary>
    public string? DownloadPath { get; init; }
}

/// <summary>
/// </summary>
public sealed record SetDownloadBehaviorResult() : EmptyResult;


internal sealed record SetGeolocationOverrideCommandParameters(double? Latitude, double? Longitude, double? Accuracy) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.SetGeolocationOverrideAsync"/>.
/// </summary>
public sealed record SetGeolocationOverrideCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Mock latitude
    /// </summary>
    public double? Latitude { get; init; }

    /// <summary>
    /// Mock longitude
    /// </summary>
    public double? Longitude { get; init; }

    /// <summary>
    /// Mock accuracy
    /// </summary>
    public double? Accuracy { get; init; }
}

/// <summary>
/// </summary>
public sealed record SetGeolocationOverrideResult() : EmptyResult;


internal sealed record SetLifecycleEventsEnabledCommandParameters(bool Enabled) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.SetLifecycleEventsEnabledAsync"/>.
/// </summary>
public sealed record SetLifecycleEventsEnabledCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetLifecycleEventsEnabledResult() : EmptyResult;


internal sealed record SetTouchEmulationEnabledCommandParameters(bool Enabled, string? Configuration) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.SetTouchEmulationEnabledAsync"/>.
/// </summary>
public sealed record SetTouchEmulationEnabledCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Touch/gesture events configuration. Default: current platform.
    /// </summary>
    public string? Configuration { get; init; }
}

/// <summary>
/// </summary>
public sealed record SetTouchEmulationEnabledResult() : EmptyResult;


internal sealed record StartScreencastCommandParameters(string? Format, long? Quality, long? MaxWidth, long? MaxHeight, long? EveryNthFrame) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.StartScreencastAsync"/>.
/// </summary>
public sealed record StartScreencastCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Image compression format.
    /// </summary>
    public string? Format { get; init; }

    /// <summary>
    /// Compression quality from range [0..100].
    /// </summary>
    public long? Quality { get; init; }

    /// <summary>
    /// Maximum screenshot width.
    /// </summary>
    public long? MaxWidth { get; init; }

    /// <summary>
    /// Maximum screenshot height.
    /// </summary>
    public long? MaxHeight { get; init; }

    /// <summary>
    /// Send every n-th frame.
    /// </summary>
    public long? EveryNthFrame { get; init; }
}

/// <summary>
/// </summary>
public sealed record StartScreencastResult() : EmptyResult;


internal sealed record StopLoadingCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.StopLoadingAsync"/>.
/// </summary>
public sealed record StopLoadingCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record StopLoadingResult() : EmptyResult;


internal sealed record CrashCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.CrashAsync"/>.
/// </summary>
public sealed record CrashCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record CrashResult() : EmptyResult;


internal sealed record CloseCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.CloseAsync"/>.
/// </summary>
public sealed record CloseCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record CloseResult() : EmptyResult;


internal sealed record SetWebLifecycleStateCommandParameters(string State) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.SetWebLifecycleStateAsync"/>.
/// </summary>
public sealed record SetWebLifecycleStateCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetWebLifecycleStateResult() : EmptyResult;


internal sealed record StopScreencastCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.StopScreencastAsync"/>.
/// </summary>
public sealed record StopScreencastCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record StopScreencastResult() : EmptyResult;


internal sealed record ProduceCompilationCacheCommandParameters(IEnumerable<CompilationCacheParams> Scripts) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.ProduceCompilationCacheAsync"/>.
/// </summary>
public sealed record ProduceCompilationCacheCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ProduceCompilationCacheResult() : EmptyResult;


internal sealed record AddCompilationCacheCommandParameters(string Url, string Data) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.AddCompilationCacheAsync"/>.
/// </summary>
public sealed record AddCompilationCacheCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record AddCompilationCacheResult() : EmptyResult;


internal sealed record ClearCompilationCacheCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.ClearCompilationCacheAsync"/>.
/// </summary>
public sealed record ClearCompilationCacheCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ClearCompilationCacheResult() : EmptyResult;


internal sealed record SetSPCTransactionModeCommandParameters(string Mode) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.SetSPCTransactionModeAsync"/>.
/// </summary>
public sealed record SetSPCTransactionModeCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetSPCTransactionModeResult() : EmptyResult;


internal sealed record SetRPHRegistrationModeCommandParameters(string Mode) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.SetRPHRegistrationModeAsync"/>.
/// </summary>
public sealed record SetRPHRegistrationModeCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetRPHRegistrationModeResult() : EmptyResult;


internal sealed record GenerateTestReportCommandParameters(string Message, string? Group) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.GenerateTestReportAsync"/>.
/// </summary>
public sealed record GenerateTestReportCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Specifies the endpoint group to deliver the report to.
    /// </summary>
    public string? Group { get; init; }
}

/// <summary>
/// </summary>
public sealed record GenerateTestReportResult() : EmptyResult;


internal sealed record WaitForDebuggerCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.WaitForDebuggerAsync"/>.
/// </summary>
public sealed record WaitForDebuggerCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record WaitForDebuggerResult() : EmptyResult;


internal sealed record SetInterceptFileChooserDialogCommandParameters(bool Enabled, bool? Cancel) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.SetInterceptFileChooserDialogAsync"/>.
/// </summary>
public sealed record SetInterceptFileChooserDialogCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// If true, cancels the dialog by emitting relevant events (if any)
    /// in addition to not showing it if the interception is enabled
    /// (default: false).
    /// </summary>
    public bool? Cancel { get; init; }
}

/// <summary>
/// </summary>
public sealed record SetInterceptFileChooserDialogResult() : EmptyResult;


internal sealed record SetPrerenderingAllowedCommandParameters(bool IsAllowed) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.SetPrerenderingAllowedAsync"/>.
/// </summary>
public sealed record SetPrerenderingAllowedCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetPrerenderingAllowedResult() : EmptyResult;


internal sealed record GetAnnotatedPageContentCommandParameters(bool? IncludeActionableInformation) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PageDomain.GetAnnotatedPageContentAsync"/>.
/// </summary>
public sealed record GetAnnotatedPageContentCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Whether to include actionable information. Defaults to true.
    /// </summary>
    public bool? IncludeActionableInformation { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Content">
/// The annotated page content as a base64 encoded protobuf.
/// The format is defined by the <b>AnnotatedPageContent</b> message in
/// components/optimization_guide/proto/features/common_quality_data.proto (Encoded as a base64 string when passed over JSON)
/// </param>
public sealed record GetAnnotatedPageContentResult(string Content) : EmptyResult;


/// <summary>
/// </summary>
/// <param name="Timestamp">
/// </param>
public sealed record DomContentEventFiredEventArgs(Network.MonotonicTime Timestamp) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Emitted only when <b>page.interceptFileChooser</b> is enabled.
/// </summary>
/// <param name="FrameId">
/// Id of the frame containing input node.
/// </param>
/// <param name="Mode">
/// Input mode.
/// </param>
/// <param name="BackendNodeId">
/// Input node id. Only present for file choosers opened via an <b>&lt;input type="file"&gt;</b> element.
/// </param>
public sealed record FileChooserOpenedEventArgs(FrameId FrameId, string Mode, DOM.BackendNodeId? BackendNodeId = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when frame has been attached to its parent.
/// </summary>
/// <param name="FrameId">
/// Id of the frame that has been attached.
/// </param>
/// <param name="ParentFrameId">
/// Parent frame identifier.
/// </param>
/// <param name="Stack">
/// JavaScript stack trace of when frame was attached, only set if frame initiated from script.
/// </param>
public sealed record FrameAttachedEventArgs(FrameId FrameId, FrameId ParentFrameId, Runtime.StackTrace? Stack = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when frame no longer has a scheduled navigation.
/// </summary>
/// <param name="FrameId">
/// Id of the frame that has cleared its scheduled navigation.
/// </param>
public sealed record FrameClearedScheduledNavigationEventArgs(FrameId FrameId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when frame has been detached from its parent.
/// </summary>
/// <param name="FrameId">
/// Id of the frame that has been detached.
/// </param>
/// <param name="Reason">
/// </param>
public sealed record FrameDetachedEventArgs(FrameId FrameId, string Reason) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired before frame subtree is detached. Emitted before any frame of the
/// subtree is actually detached.
/// </summary>
/// <param name="FrameId">
/// Id of the frame that is the root of the subtree that will be detached.
/// </param>
public sealed record FrameSubtreeWillBeDetachedEventArgs(FrameId FrameId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired once navigation of the frame has completed. Frame is now associated with the new loader.
/// </summary>
/// <param name="Frame">
/// Frame object.
/// </param>
/// <param name="Type">
/// </param>
public sealed record FrameNavigatedEventArgs(Frame Frame, NavigationType Type) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when opening document to write to.
/// </summary>
/// <param name="Frame">
/// Frame object.
/// </param>
public sealed record DocumentOpenedEventArgs(Frame Frame) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
public sealed record FrameResizedEventArgs() : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when a navigation starts. This event is fired for both
/// renderer-initiated and browser-initiated navigations. For renderer-initiated
/// navigations, the event is fired after <b>frameRequestedNavigation</b>.
/// Navigation may still be cancelled after the event is issued. Multiple events
/// can be fired for a single navigation, for example, when a same-document
/// navigation becomes a cross-document navigation (such as in the case of a
/// frameset).
/// </summary>
/// <param name="FrameId">
/// ID of the frame that is being navigated.
/// </param>
/// <param name="Url">
/// The URL the navigation started with. The final URL can be different.
/// </param>
/// <param name="LoaderId">
/// Loader identifier. Even though it is present in case of same-document
/// navigation, the previously committed loaderId would not change unless
/// the navigation changes from a same-document to a cross-document
/// navigation.
/// </param>
/// <param name="NavigationType">
/// </param>
public sealed record FrameStartedNavigatingEventArgs(FrameId FrameId, string Url, Network.LoaderId LoaderId, string NavigationType) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when a renderer-initiated navigation is requested.
/// Navigation may still be cancelled after the event is issued.
/// </summary>
/// <param name="FrameId">
/// Id of the frame that is being navigated.
/// </param>
/// <param name="Reason">
/// The reason for the navigation.
/// </param>
/// <param name="Url">
/// The destination URL for the requested navigation.
/// </param>
/// <param name="Disposition">
/// The disposition for the navigation.
/// </param>
public sealed record FrameRequestedNavigationEventArgs(FrameId FrameId, ClientNavigationReason Reason, string Url, ClientNavigationDisposition Disposition) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when frame schedules a potential navigation.
/// </summary>
/// <param name="FrameId">
/// Id of the frame that has scheduled a navigation.
/// </param>
/// <param name="Delay">
/// Delay (in seconds) until the navigation is scheduled to begin. The navigation is not
/// guaranteed to start.
/// </param>
/// <param name="Reason">
/// The reason for the navigation.
/// </param>
/// <param name="Url">
/// The destination URL for the scheduled navigation.
/// </param>
public sealed record FrameScheduledNavigationEventArgs(FrameId FrameId, double Delay, ClientNavigationReason Reason, string Url) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when frame has started loading.
/// </summary>
/// <param name="FrameId">
/// Id of the frame that has started loading.
/// </param>
public sealed record FrameStartedLoadingEventArgs(FrameId FrameId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when frame has stopped loading.
/// </summary>
/// <param name="FrameId">
/// Id of the frame that has stopped loading.
/// </param>
public sealed record FrameStoppedLoadingEventArgs(FrameId FrameId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when page is about to start a download.
/// Deprecated. Use Browser.downloadWillBegin instead.
/// </summary>
/// <param name="FrameId">
/// Id of the frame that caused download to begin.
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
public sealed record DownloadWillBeginEventArgs(FrameId FrameId, string Guid, string Url, string SuggestedFilename) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when download makes progress. Last call has |done| == true.
/// Deprecated. Use Browser.downloadProgress instead.
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
public sealed record DownloadProgressEventArgs(string Guid, double TotalBytes, double ReceivedBytes, string State) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when interstitial page was hidden
/// </summary>
public sealed record InterstitialHiddenEventArgs() : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when interstitial page was shown
/// </summary>
public sealed record InterstitialShownEventArgs() : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) has been
/// closed.
/// </summary>
/// <param name="FrameId">
/// Frame id.
/// </param>
/// <param name="Result">
/// Whether dialog was confirmed.
/// </param>
/// <param name="UserInput">
/// User input in case of prompt.
/// </param>
public sealed record JavascriptDialogClosedEventArgs(FrameId FrameId, bool Result, string UserInput) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) is about to
/// open.
/// </summary>
/// <param name="Url">
/// Frame url.
/// </param>
/// <param name="FrameId">
/// Frame id.
/// </param>
/// <param name="Message">
/// Message that will be displayed by the dialog.
/// </param>
/// <param name="Type">
/// Dialog type.
/// </param>
/// <param name="HasBrowserHandler">
/// True iff browser is capable showing or acting on the given dialog. When browser has no
/// dialog handler for given target, calling alert while Page domain is engaged will stall
/// the page execution. Execution can be resumed via calling Page.handleJavaScriptDialog.
/// </param>
/// <param name="DefaultPrompt">
/// Default dialog prompt.
/// </param>
public sealed record JavascriptDialogOpeningEventArgs(string Url, FrameId FrameId, string Message, DialogType Type, bool HasBrowserHandler, string? DefaultPrompt = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired for lifecycle events (navigation, load, paint, etc) in the current
/// target (including local frames).
/// </summary>
/// <param name="FrameId">
/// Id of the frame.
/// </param>
/// <param name="LoaderId">
/// Loader identifier. Empty string if the request is fetched from worker.
/// </param>
/// <param name="Name">
/// </param>
/// <param name="Timestamp">
/// </param>
public sealed record LifecycleEventEventArgs(FrameId FrameId, Network.LoaderId LoaderId, string Name, Network.MonotonicTime Timestamp) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired for failed bfcache history navigations if BackForwardCache feature is enabled. Do
/// not assume any ordering with the Page.frameNavigated event. This event is fired only for
/// main-frame history navigation where the document changes (non-same-document navigations),
/// when bfcache navigation fails.
/// </summary>
/// <param name="LoaderId">
/// The loader id for the associated navigation.
/// </param>
/// <param name="FrameId">
/// The frame id of the associated frame.
/// </param>
/// <param name="NotRestoredExplanations">
/// Array of reasons why the page could not be cached. This must not be empty.
/// </param>
/// <param name="NotRestoredExplanationsTree">
/// Tree structure of reasons why the page could not be cached for each frame.
/// </param>
public sealed record BackForwardCacheNotUsedEventArgs(Network.LoaderId LoaderId, FrameId FrameId, IEnumerable<BackForwardCacheNotRestoredExplanation> NotRestoredExplanations, BackForwardCacheNotRestoredExplanationTree? NotRestoredExplanationsTree = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
/// <param name="Timestamp">
/// </param>
public sealed record LoadEventFiredEventArgs(Network.MonotonicTime Timestamp) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when same-document navigation happens, e.g. due to history API usage or anchor navigation.
/// </summary>
/// <param name="FrameId">
/// Id of the frame.
/// </param>
/// <param name="Url">
/// Frame's new url.
/// </param>
/// <param name="NavigationType">
/// Navigation type
/// </param>
public sealed record NavigatedWithinDocumentEventArgs(FrameId FrameId, string Url, string NavigationType) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Compressed image data requested by the <b>startScreencast</b>.
/// </summary>
/// <param name="Data">
/// Base64-encoded compressed image. (Encoded as a base64 string when passed over JSON)
/// </param>
/// <param name="Metadata">
/// Screencast frame metadata.
/// </param>
/// <param name="SessionId">
/// Frame number.
/// </param>
public sealed record ScreencastFrameEventArgs(string Data, ScreencastFrameMetadata Metadata, long SessionId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when the page with currently enabled screencast was shown or hidden `.
/// </summary>
/// <param name="Visible">
/// True if the page is visible.
/// </param>
public sealed record ScreencastVisibilityChangedEventArgs(bool Visible) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when a new window is going to be opened, via window.open(), link click, form submission,
/// etc.
/// </summary>
/// <param name="Url">
/// The URL for the new window.
/// </param>
/// <param name="WindowName">
/// Window name.
/// </param>
/// <param name="WindowFeatures">
/// An array of enabled window features.
/// </param>
/// <param name="UserGesture">
/// Whether or not it was triggered by user gesture.
/// </param>
public sealed record WindowOpenEventArgs(string Url, string WindowName, IEnumerable<string> WindowFeatures, bool UserGesture) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Issued for every compilation cache generated.
/// </summary>
/// <param name="Url">
/// </param>
/// <param name="Data">
/// Base64-encoded data (Encoded as a base64 string when passed over JSON)
/// </param>
public sealed record CompilationCacheProducedEventArgs(string Url, string Data) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Unique frame identifier.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<FrameId>))]
public record FrameId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Indicates whether a frame has been identified as an ad.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<AdFrameType>))]
public enum AdFrameType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("none")]
    None,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("child")]
    Child,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("root")]
    Root,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<AdFrameExplanation>))]
public enum AdFrameExplanation
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ParentIsAd")]
    ParentIsAd,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CreatedByAdScript")]
    CreatedByAdScript,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MatchedBlockingRule")]
    MatchedBlockingRule,
}

/// <summary>
/// Indicates whether a frame has been identified as an ad and why.
/// </summary>
/// <param name="AdFrameType">
/// </param>
public sealed record AdFrameStatus(AdFrameType AdFrameType)
{
    /// <summary>
    /// </summary>
    public IReadOnlyList<AdFrameExplanation>? Explanations { get; init; }
}

/// <summary>
/// Indicates whether the frame is a secure context and why it is the case.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<SecureContextType>))]
public enum SecureContextType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Secure")]
    Secure,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SecureLocalhost")]
    SecureLocalhost,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InsecureScheme")]
    InsecureScheme,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InsecureAncestor")]
    InsecureAncestor,
}

/// <summary>
/// Indicates whether the frame is cross-origin isolated and why it is the case.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<CrossOriginIsolatedContextType>))]
public enum CrossOriginIsolatedContextType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Isolated")]
    Isolated,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NotIsolated")]
    NotIsolated,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NotIsolatedFeatureDisabled")]
    NotIsolatedFeatureDisabled,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<GatedAPIFeatures>))]
public enum GatedAPIFeatures
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SharedArrayBuffers")]
    SharedArrayBuffers,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SharedArrayBuffersTransferAllowed")]
    SharedArrayBuffersTransferAllowed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PerformanceMeasureMemory")]
    PerformanceMeasureMemory,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PerformanceProfile")]
    PerformanceProfile,
}

/// <summary>
/// All Permissions Policy features. This enum should match the one defined
/// in services/network/public/cpp/permissions_policy/permissions_policy_features.json5.
/// LINT.IfChange(PermissionsPolicyFeature)
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<PermissionsPolicyFeature>))]
public enum PermissionsPolicyFeature
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("accelerometer")]
    Accelerometer,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("all-screens-capture")]
    AllScreensCapture,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ambient-light-sensor")]
    AmbientLightSensor,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("aria-notify")]
    AriaNotify,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("autofill")]
    Autofill,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("autoplay")]
    Autoplay,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("bluetooth")]
    Bluetooth,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("browsing-topics")]
    BrowsingTopics,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("camera")]
    Camera,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("captured-surface-control")]
    CapturedSurfaceControl,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-dpr")]
    ChDpr,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-device-memory")]
    ChDeviceMemory,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-downlink")]
    ChDownlink,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ect")]
    ChEct,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-prefers-color-scheme")]
    ChPrefersColorScheme,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-prefers-reduced-motion")]
    ChPrefersReducedMotion,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-prefers-reduced-transparency")]
    ChPrefersReducedTransparency,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-rtt")]
    ChRtt,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-save-data")]
    ChSaveData,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua")]
    ChUa,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua-arch")]
    ChUaArch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua-bitness")]
    ChUaBitness,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua-high-entropy-values")]
    ChUaHighEntropyValues,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua-platform")]
    ChUaPlatform,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua-model")]
    ChUaModel,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua-mobile")]
    ChUaMobile,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua-form-factors")]
    ChUaFormFactors,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua-full-version")]
    ChUaFullVersion,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua-full-version-list")]
    ChUaFullVersionList,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua-platform-version")]
    ChUaPlatformVersion,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua-wow64")]
    ChUaWow64,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-viewport-height")]
    ChViewportHeight,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-viewport-width")]
    ChViewportWidth,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-width")]
    ChWidth,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("clipboard-read")]
    ClipboardRead,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("clipboard-write")]
    ClipboardWrite,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("compute-pressure")]
    ComputePressure,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("controlled-frame")]
    ControlledFrame,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("cross-origin-isolated")]
    CrossOriginIsolated,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("deferred-fetch")]
    DeferredFetch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("deferred-fetch-minimal")]
    DeferredFetchMinimal,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("device-attributes")]
    DeviceAttributes,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("digital-credentials-create")]
    DigitalCredentialsCreate,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("digital-credentials-get")]
    DigitalCredentialsGet,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("direct-sockets")]
    DirectSockets,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("direct-sockets-multicast")]
    DirectSocketsMulticast,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("display-capture")]
    DisplayCapture,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("document-domain")]
    DocumentDomain,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("encrypted-media")]
    EncryptedMedia,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("execution-while-out-of-viewport")]
    ExecutionWhileOutOfViewport,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("execution-while-not-rendered")]
    ExecutionWhileNotRendered,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("focus-without-user-activation")]
    FocusWithoutUserActivation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("fullscreen")]
    Fullscreen,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("frobulate")]
    Frobulate,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("gamepad")]
    Gamepad,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("geolocation")]
    Geolocation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("gyroscope")]
    Gyroscope,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("hid")]
    Hid,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("identity-credentials-get")]
    IdentityCredentialsGet,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("idle-detection")]
    IdleDetection,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("interest-cohort")]
    InterestCohort,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("join-ad-interest-group")]
    JoinAdInterestGroup,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("keyboard-map")]
    KeyboardMap,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("language-detector")]
    LanguageDetector,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("language-model")]
    LanguageModel,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("local-fonts")]
    LocalFonts,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("local-network")]
    LocalNetwork,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("local-network-access")]
    LocalNetworkAccess,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("loopback-network")]
    LoopbackNetwork,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("magnetometer")]
    Magnetometer,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("manual-text")]
    ManualText,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("media-playback-while-not-visible")]
    MediaPlaybackWhileNotVisible,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("microphone")]
    Microphone,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("midi")]
    Midi,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("on-device-speech-recognition")]
    OnDeviceSpeechRecognition,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("otp-credentials")]
    OtpCredentials,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("payment")]
    Payment,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("picture-in-picture")]
    PictureInPicture,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("private-aggregation")]
    PrivateAggregation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("private-state-token-issuance")]
    PrivateStateTokenIssuance,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("private-state-token-redemption")]
    PrivateStateTokenRedemption,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("publickey-credentials-create")]
    PublickeyCredentialsCreate,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("publickey-credentials-get")]
    PublickeyCredentialsGet,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("record-ad-auction-events")]
    RecordAdAuctionEvents,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("rewriter")]
    Rewriter,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("run-ad-auction")]
    RunAdAuction,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("screen-wake-lock")]
    ScreenWakeLock,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("serial")]
    Serial,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("shared-storage")]
    SharedStorage,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("shared-storage-select-url")]
    SharedStorageSelectUrl,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("smart-card")]
    SmartCard,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("speaker-selection")]
    SpeakerSelection,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("storage-access")]
    StorageAccess,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("sub-apps")]
    SubApps,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("summarizer")]
    Summarizer,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("sync-xhr")]
    SyncXhr,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("tools")]
    Tools,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("translator")]
    Translator,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("unload")]
    Unload,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("usb")]
    Usb,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("usb-unrestricted")]
    UsbUnrestricted,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("vertical-scroll")]
    VerticalScroll,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("web-app-installation")]
    WebAppInstallation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("webnn")]
    Webnn,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("web-printing")]
    WebPrinting,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("web-share")]
    WebShare,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("window-management")]
    WindowManagement,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("writer")]
    Writer,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("xr-spatial-tracking")]
    XrSpatialTracking,
}

/// <summary>
/// Reason for a permissions policy feature to be disabled.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<PermissionsPolicyBlockReason>))]
public enum PermissionsPolicyBlockReason
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Header")]
    Header,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IframeAttribute")]
    IframeAttribute,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InFencedFrameTree")]
    InFencedFrameTree,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InIsolatedApp")]
    InIsolatedApp,
}

/// <summary>
/// </summary>
/// <param name="FrameId">
/// </param>
/// <param name="BlockReason">
/// </param>
public sealed record PermissionsPolicyBlockLocator(FrameId FrameId, PermissionsPolicyBlockReason BlockReason)
{
}

/// <summary>
/// </summary>
/// <param name="Feature">
/// </param>
/// <param name="Allowed">
/// </param>
public sealed record PermissionsPolicyFeatureState(PermissionsPolicyFeature Feature, bool Allowed)
{
    /// <summary>
    /// </summary>
    public PermissionsPolicyBlockLocator? Locator { get; init; }
}

/// <summary>
/// Origin Trial(https://www.chromium.org/blink/origin-trials) support.
/// Status for an Origin Trial token.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<OriginTrialTokenStatus>))]
public enum OriginTrialTokenStatus
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Success")]
    Success,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NotSupported")]
    NotSupported,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Insecure")]
    Insecure,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Expired")]
    Expired,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WrongOrigin")]
    WrongOrigin,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidSignature")]
    InvalidSignature,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Malformed")]
    Malformed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WrongVersion")]
    WrongVersion,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FeatureDisabled")]
    FeatureDisabled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenDisabled")]
    TokenDisabled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FeatureDisabledForUser")]
    FeatureDisabledForUser,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UnknownTrial")]
    UnknownTrial,
}

/// <summary>
/// Status for an Origin Trial.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<OriginTrialStatus>))]
public enum OriginTrialStatus
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Enabled")]
    Enabled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ValidTokenNotProvided")]
    ValidTokenNotProvided,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("OSNotSupported")]
    OSNotSupported,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TrialNotAllowed")]
    TrialNotAllowed,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<OriginTrialUsageRestriction>))]
public enum OriginTrialUsageRestriction
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("None")]
    None,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Subset")]
    Subset,
}

/// <summary>
/// </summary>
/// <param name="Origin">
/// </param>
/// <param name="MatchSubDomains">
/// </param>
/// <param name="TrialName">
/// </param>
/// <param name="ExpiryTime">
/// </param>
/// <param name="IsThirdParty">
/// </param>
/// <param name="UsageRestriction">
/// </param>
public sealed record OriginTrialToken(string Origin, bool MatchSubDomains, string TrialName, Network.TimeSinceEpoch ExpiryTime, bool IsThirdParty, OriginTrialUsageRestriction UsageRestriction)
{
}

/// <summary>
/// </summary>
/// <param name="RawTokenText">
/// </param>
/// <param name="Status">
/// </param>
public sealed record OriginTrialTokenWithStatus(string RawTokenText, OriginTrialTokenStatus Status)
{
    /// <summary>
    /// <b>parsedToken</b> is present only when the token is extractable and
    /// parsable.
    /// </summary>
    public OriginTrialToken? ParsedToken { get; init; }
}

/// <summary>
/// </summary>
/// <param name="TrialName">
/// </param>
/// <param name="Status">
/// </param>
/// <param name="TokensWithStatus">
/// </param>
public sealed record OriginTrial(string TrialName, OriginTrialStatus Status, IReadOnlyList<OriginTrialTokenWithStatus> TokensWithStatus)
{
}

/// <summary>
/// Additional information about the frame document's security origin.
/// </summary>
/// <param name="IsLocalhost">
/// Indicates whether the frame document's security origin is one
/// of the local hostnames (e.g. "localhost") or IP addresses (IPv4
/// 127.0.0.0/8 or IPv6 ::1).
/// </param>
public sealed record SecurityOriginDetails(bool IsLocalhost)
{
}

/// <summary>
/// Information about the Frame on the page.
/// </summary>
/// <param name="Id">
/// Frame unique identifier.
/// </param>
/// <param name="LoaderId">
/// Identifier of the loader associated with this frame.
/// </param>
/// <param name="Url">
/// Frame document's URL without fragment.
/// </param>
/// <param name="DomainAndRegistry">
/// Frame document's registered domain, taking the public suffixes list into account.
/// Extracted from the Frame's url.
/// Example URLs: http://www.google.com/file.html -&gt; "google.com"
///               http://a.b.co.uk/file.html      -&gt; "b.co.uk"
/// </param>
/// <param name="SecurityOrigin">
/// Frame document's security origin.
/// </param>
/// <param name="MimeType">
/// Frame document's mimeType as determined by the browser.
/// </param>
/// <param name="SecureContextType">
/// Indicates whether the main document is a secure context and explains why that is the case.
/// </param>
/// <param name="CrossOriginIsolatedContextType">
/// Indicates whether this is a cross origin isolated context.
/// </param>
/// <param name="GatedAPIFeatures">
/// Indicated which gated APIs / features are available.
/// </param>
public sealed record Frame(FrameId Id, Network.LoaderId LoaderId, string Url, string DomainAndRegistry, string SecurityOrigin, string MimeType, SecureContextType SecureContextType, CrossOriginIsolatedContextType CrossOriginIsolatedContextType, IReadOnlyList<GatedAPIFeatures> GatedAPIFeatures)
{
    /// <summary>
    /// Parent frame identifier.
    /// </summary>
    public FrameId? ParentId { get; init; }

    /// <summary>
    /// Frame's name as specified in the tag.
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// Frame document's URL fragment including the '#'.
    /// </summary>
    public string? UrlFragment { get; init; }

    /// <summary>
    /// Additional details about the frame document's security origin.
    /// </summary>
    public SecurityOriginDetails? SecurityOriginDetails { get; init; }

    /// <summary>
    /// If the frame failed to load, this contains the URL that could not be loaded. Note that unlike url above, this URL may contain a fragment.
    /// </summary>
    public string? UnreachableUrl { get; init; }

    /// <summary>
    /// Indicates whether this frame was tagged as an ad and why.
    /// </summary>
    public AdFrameStatus? AdFrameStatus { get; init; }
}

/// <summary>
/// Information about the Resource on the page.
/// </summary>
/// <param name="Url">
/// Resource URL.
/// </param>
/// <param name="Type">
/// Type of this resource.
/// </param>
/// <param name="MimeType">
/// Resource mimeType as determined by the browser.
/// </param>
public sealed record FrameResource(string Url, Network.ResourceType Type, string MimeType)
{
    /// <summary>
    /// last-modified timestamp as reported by server.
    /// </summary>
    public Network.TimeSinceEpoch? LastModified { get; init; }

    /// <summary>
    /// Resource content size.
    /// </summary>
    public double? ContentSize { get; init; }

    /// <summary>
    /// True if the resource failed to load.
    /// </summary>
    public bool? Failed { get; init; }

    /// <summary>
    /// True if the resource was canceled during loading.
    /// </summary>
    public bool? Canceled { get; init; }
}

/// <summary>
/// Information about the Frame hierarchy along with their cached resources.
/// </summary>
/// <param name="Frame">
/// Frame information for this tree item.
/// </param>
/// <param name="Resources">
/// Information about frame resources.
/// </param>
public sealed record FrameResourceTree(Frame Frame, IReadOnlyList<FrameResource> Resources)
{
    /// <summary>
    /// Child frames.
    /// </summary>
    public IReadOnlyList<FrameResourceTree>? ChildFrames { get; init; }
}

/// <summary>
/// Information about the Frame hierarchy.
/// </summary>
/// <param name="Frame">
/// Frame information for this tree item.
/// </param>
public sealed record FrameTree(Frame Frame)
{
    /// <summary>
    /// Child frames.
    /// </summary>
    public IReadOnlyList<FrameTree>? ChildFrames { get; init; }
}

/// <summary>
/// Unique script identifier.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<ScriptIdentifier>))]
public record ScriptIdentifier : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Transition type.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<TransitionType>))]
public enum TransitionType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("link")]
    Link,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("typed")]
    Typed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("address_bar")]
    AddressBar,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("auto_bookmark")]
    AutoBookmark,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("auto_subframe")]
    AutoSubframe,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("manual_subframe")]
    ManualSubframe,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("generated")]
    Generated,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("auto_toplevel")]
    AutoToplevel,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("form_submit")]
    FormSubmit,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("reload")]
    Reload,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("keyword")]
    Keyword,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("keyword_generated")]
    KeywordGenerated,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("other")]
    Other,
}

/// <summary>
/// Navigation history entry.
/// </summary>
/// <param name="Id">
/// Unique id of the navigation history entry.
/// </param>
/// <param name="Url">
/// URL of the navigation history entry.
/// </param>
/// <param name="UserTypedURL">
/// URL that the user typed in the url bar.
/// </param>
/// <param name="Title">
/// Title of the navigation history entry.
/// </param>
/// <param name="TransitionType">
/// Transition type.
/// </param>
public sealed record NavigationEntry(long Id, string Url, string UserTypedURL, string Title, TransitionType TransitionType)
{
}

/// <summary>
/// Screencast frame metadata.
/// </summary>
/// <param name="OffsetTop">
/// Top offset in DIP.
/// </param>
/// <param name="PageScaleFactor">
/// Page scale factor.
/// </param>
/// <param name="DeviceWidth">
/// Device screen width in DIP.
/// </param>
/// <param name="DeviceHeight">
/// Device screen height in DIP.
/// </param>
/// <param name="ScrollOffsetX">
/// Position of horizontal scroll in CSS pixels.
/// </param>
/// <param name="ScrollOffsetY">
/// Position of vertical scroll in CSS pixels.
/// </param>
public sealed record ScreencastFrameMetadata(double OffsetTop, double PageScaleFactor, double DeviceWidth, double DeviceHeight, double ScrollOffsetX, double ScrollOffsetY)
{
    /// <summary>
    /// Frame swap timestamp.
    /// </summary>
    public Network.TimeSinceEpoch? Timestamp { get; init; }
}

/// <summary>
/// Javascript dialog type.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<DialogType>))]
public enum DialogType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("alert")]
    Alert,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("confirm")]
    Confirm,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("prompt")]
    Prompt,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("beforeunload")]
    Beforeunload,
}

/// <summary>
/// Error while paring app manifest.
/// </summary>
/// <param name="Message">
/// Error message.
/// </param>
/// <param name="Critical">
/// If critical, this is a non-recoverable parse error.
/// </param>
/// <param name="Line">
/// Error line.
/// </param>
/// <param name="Column">
/// Error column.
/// </param>
public sealed record AppManifestError(string Message, long Critical, long Line, long Column)
{
}

/// <summary>
/// Parsed app manifest properties.
/// </summary>
/// <param name="Scope">
/// Computed scope value
/// </param>
public sealed record AppManifestParsedProperties(string Scope)
{
}

/// <summary>
/// Layout viewport position and dimensions.
/// </summary>
/// <param name="PageX">
/// Horizontal offset relative to the document (CSS pixels).
/// </param>
/// <param name="PageY">
/// Vertical offset relative to the document (CSS pixels).
/// </param>
/// <param name="ClientWidth">
/// Width (CSS pixels), excludes scrollbar if present.
/// </param>
/// <param name="ClientHeight">
/// Height (CSS pixels), excludes scrollbar if present.
/// </param>
public sealed record LayoutViewport(long PageX, long PageY, long ClientWidth, long ClientHeight)
{
}

/// <summary>
/// Visual viewport position, dimensions, and scale.
/// </summary>
/// <param name="OffsetX">
/// Horizontal offset relative to the layout viewport (CSS pixels).
/// </param>
/// <param name="OffsetY">
/// Vertical offset relative to the layout viewport (CSS pixels).
/// </param>
/// <param name="PageX">
/// Horizontal offset relative to the document (CSS pixels).
/// </param>
/// <param name="PageY">
/// Vertical offset relative to the document (CSS pixels).
/// </param>
/// <param name="ClientWidth">
/// Width (CSS pixels), excludes scrollbar if present.
/// </param>
/// <param name="ClientHeight">
/// Height (CSS pixels), excludes scrollbar if present.
/// </param>
/// <param name="Scale">
/// Scale relative to the ideal viewport (size at width=device-width).
/// </param>
public sealed record VisualViewport(double OffsetX, double OffsetY, double PageX, double PageY, double ClientWidth, double ClientHeight, double Scale)
{
    /// <summary>
    /// Page zoom factor (CSS to device independent pixels ratio).
    /// </summary>
    public double? Zoom { get; init; }
}

/// <summary>
/// Viewport for capturing screenshot.
/// </summary>
/// <param name="X">
/// X offset in device independent pixels (dip).
/// </param>
/// <param name="Y">
/// Y offset in device independent pixels (dip).
/// </param>
/// <param name="Width">
/// Rectangle width in device independent pixels (dip).
/// </param>
/// <param name="Height">
/// Rectangle height in device independent pixels (dip).
/// </param>
/// <param name="Scale">
/// Page scale factor.
/// </param>
public sealed record Viewport(double X, double Y, double Width, double Height, double Scale)
{
}

/// <summary>
/// Generic font families collection.
/// </summary>
public sealed record FontFamilies()
{
    /// <summary>
    /// The standard font-family.
    /// </summary>
    public string? Standard { get; init; }

    /// <summary>
    /// The fixed font-family.
    /// </summary>
    public string? Fixed { get; init; }

    /// <summary>
    /// The serif font-family.
    /// </summary>
    public string? Serif { get; init; }

    /// <summary>
    /// The sansSerif font-family.
    /// </summary>
    public string? SansSerif { get; init; }

    /// <summary>
    /// The cursive font-family.
    /// </summary>
    public string? Cursive { get; init; }

    /// <summary>
    /// The fantasy font-family.
    /// </summary>
    public string? Fantasy { get; init; }

    /// <summary>
    /// The math font-family.
    /// </summary>
    public string? Math { get; init; }
}

/// <summary>
/// Font families collection for a script.
/// </summary>
/// <param name="Script">
/// Name of the script which these font families are defined for.
/// </param>
/// <param name="FontFamilies">
/// Generic font families collection for the script.
/// </param>
public sealed record ScriptFontFamilies(string Script, FontFamilies FontFamilies)
{
}

/// <summary>
/// Default font sizes.
/// </summary>
public sealed record FontSizes()
{
    /// <summary>
    /// Default standard font size.
    /// </summary>
    public long? Standard { get; init; }

    /// <summary>
    /// Default fixed font size.
    /// </summary>
    public long? Fixed { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ClientNavigationReason>))]
public enum ClientNavigationReason
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("anchorClick")]
    AnchorClick,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("formSubmissionGet")]
    FormSubmissionGet,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("formSubmissionPost")]
    FormSubmissionPost,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("httpHeaderRefresh")]
    HttpHeaderRefresh,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("initialFrameNavigation")]
    InitialFrameNavigation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("metaTagRefresh")]
    MetaTagRefresh,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("other")]
    Other,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("pageBlockInterstitial")]
    PageBlockInterstitial,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("reload")]
    Reload,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("scriptInitiated")]
    ScriptInitiated,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ClientNavigationDisposition>))]
public enum ClientNavigationDisposition
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("currentTab")]
    CurrentTab,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("newTab")]
    NewTab,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("newWindow")]
    NewWindow,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("download")]
    Download,
}

/// <summary>
/// </summary>
/// <param name="Name">
/// Argument name (e.g. name:'minimum-icon-size-in-pixels').
/// </param>
/// <param name="Value">
/// Argument value (e.g. value:'64').
/// </param>
public sealed record InstallabilityErrorArgument(string Name, string Value)
{
}

/// <summary>
/// The installability error
/// </summary>
/// <param name="ErrorId">
/// The error id (e.g. 'manifest-missing-suitable-icon').
/// </param>
/// <param name="ErrorArguments">
/// The list of error arguments (e.g. {name:'minimum-icon-size-in-pixels', value:'64'}).
/// </param>
public sealed record InstallabilityError(string ErrorId, IReadOnlyList<InstallabilityErrorArgument> ErrorArguments)
{
}

/// <summary>
/// The referring-policy used for the navigation.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ReferrerPolicy>))]
public enum ReferrerPolicy
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("noReferrer")]
    NoReferrer,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("noReferrerWhenDowngrade")]
    NoReferrerWhenDowngrade,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("origin")]
    Origin,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("originWhenCrossOrigin")]
    OriginWhenCrossOrigin,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("sameOrigin")]
    SameOrigin,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("strictOrigin")]
    StrictOrigin,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("strictOriginWhenCrossOrigin")]
    StrictOriginWhenCrossOrigin,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("unsafeUrl")]
    UnsafeUrl,
}

/// <summary>
/// Per-script compilation cache parameters for <b>Page.produceCompilationCache</b>
/// </summary>
/// <param name="Url">
/// The URL of the script to produce a compilation cache entry for.
/// </param>
public sealed record CompilationCacheParams(string Url)
{
    /// <summary>
    /// A hint to the backend whether eager compilation is recommended.
    /// (the actual compilation mode used is upon backend discretion).
    /// </summary>
    public bool? Eager { get; init; }
}

/// <summary>
/// </summary>
public sealed record FileFilter()
{
    /// <summary>
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// </summary>
    public IReadOnlyList<string>? Accepts { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Action">
/// </param>
/// <param name="Name">
/// </param>
/// <param name="LaunchType">
/// Won't repeat the enums, using string for easy comparison. Same as the
/// other enums below.
/// </param>
public sealed record FileHandler(string Action, string Name, string LaunchType)
{
    /// <summary>
    /// </summary>
    public IReadOnlyList<ImageResource>? Icons { get; init; }

    /// <summary>
    /// Mimic a map, name is the key, accepts is the value.
    /// </summary>
    public IReadOnlyList<FileFilter>? Accepts { get; init; }
}

/// <summary>
/// The image definition used in both icon and screenshot.
/// </summary>
/// <param name="Url">
/// The src field in the definition, but changing to url in favor of
/// consistency.
/// </param>
public sealed record ImageResource(string Url)
{
    /// <summary>
    /// </summary>
    public string? Sizes { get; init; }

    /// <summary>
    /// </summary>
    public string? Type { get; init; }
}

/// <summary>
/// </summary>
/// <param name="ClientMode">
/// </param>
public sealed record LaunchHandler(string ClientMode)
{
}

/// <summary>
/// </summary>
/// <param name="Protocol">
/// </param>
/// <param name="Url">
/// </param>
public sealed record ProtocolHandler(string Protocol, string Url)
{
}

/// <summary>
/// </summary>
/// <param name="Url">
/// </param>
public sealed record RelatedApplication(string Url)
{
    /// <summary>
    /// </summary>
    public string? Id { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Origin">
/// Instead of using tuple, this field always returns the serialized string
/// for easy understanding and comparison.
/// </param>
/// <param name="HasOriginWildcard">
/// </param>
public sealed record ScopeExtension(string Origin, bool HasOriginWildcard)
{
}

/// <summary>
/// </summary>
/// <param name="Image">
/// </param>
/// <param name="FormFactor">
/// </param>
public sealed record Screenshot(ImageResource Image, string FormFactor)
{
    /// <summary>
    /// </summary>
    public string? Label { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Action">
/// </param>
/// <param name="Method">
/// </param>
/// <param name="Enctype">
/// </param>
public sealed record ShareTarget(string Action, string Method, string Enctype)
{
    /// <summary>
    /// Embed the ShareTargetParams
    /// </summary>
    public string? Title { get; init; }

    /// <summary>
    /// </summary>
    public string? Text { get; init; }

    /// <summary>
    /// </summary>
    public string? Url { get; init; }

    /// <summary>
    /// </summary>
    public IReadOnlyList<FileFilter>? Files { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Name">
/// </param>
/// <param name="Url">
/// </param>
public sealed record Shortcut(string Name, string Url)
{
}

/// <summary>
/// </summary>
public sealed record WebAppManifest()
{
    /// <summary>
    /// </summary>
    public string? BackgroundColor { get; init; }

    /// <summary>
    /// The extra description provided by the manifest.
    /// </summary>
    public string? Description { get; init; }

    /// <summary>
    /// </summary>
    public string? Dir { get; init; }

    /// <summary>
    /// </summary>
    public string? Display { get; init; }

    /// <summary>
    /// The overrided display mode controlled by the user.
    /// </summary>
    public IReadOnlyList<string>? DisplayOverrides { get; init; }

    /// <summary>
    /// The handlers to open files.
    /// </summary>
    public IReadOnlyList<FileHandler>? FileHandlers { get; init; }

    /// <summary>
    /// </summary>
    public IReadOnlyList<ImageResource>? Icons { get; init; }

    /// <summary>
    /// </summary>
    public string? Id { get; init; }

    /// <summary>
    /// </summary>
    public string? Lang { get; init; }

    /// <summary>
    /// TODO(crbug.com/1231886): This field is non-standard and part of a Chrome
    /// experiment. See:
    /// https://github.com/WICG/web-app-launch/blob/main/launch_handler.md
    /// </summary>
    public LaunchHandler? LaunchHandler { get; init; }

    /// <summary>
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// </summary>
    public string? Orientation { get; init; }

    /// <summary>
    /// </summary>
    public bool? PreferRelatedApplications { get; init; }

    /// <summary>
    /// The handlers to open protocols.
    /// </summary>
    public IReadOnlyList<ProtocolHandler>? ProtocolHandlers { get; init; }

    /// <summary>
    /// </summary>
    public IReadOnlyList<RelatedApplication>? RelatedApplications { get; init; }

    /// <summary>
    /// </summary>
    public string? Scope { get; init; }

    /// <summary>
    /// Non-standard, see
    /// https://github.com/WICG/manifest-incubations/blob/gh-pages/scope_extensions-explainer.md
    /// </summary>
    public IReadOnlyList<ScopeExtension>? ScopeExtensions { get; init; }

    /// <summary>
    /// The screenshots used by chromium.
    /// </summary>
    public IReadOnlyList<Screenshot>? Screenshots { get; init; }

    /// <summary>
    /// </summary>
    public ShareTarget? ShareTarget { get; init; }

    /// <summary>
    /// </summary>
    public string? ShortName { get; init; }

    /// <summary>
    /// </summary>
    public IReadOnlyList<Shortcut>? Shortcuts { get; init; }

    /// <summary>
    /// </summary>
    public string? StartUrl { get; init; }

    /// <summary>
    /// </summary>
    public string? ThemeColor { get; init; }
}

/// <summary>
/// The type of a frameNavigated event.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<NavigationType>))]
public enum NavigationType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Navigation")]
    Navigation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BackForwardCacheRestore")]
    BackForwardCacheRestore,
}

/// <summary>
/// List of not restored reasons for back-forward cache.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<BackForwardCacheNotRestoredReason>))]
public enum BackForwardCacheNotRestoredReason
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NotPrimaryMainFrame")]
    NotPrimaryMainFrame,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BackForwardCacheDisabled")]
    BackForwardCacheDisabled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RelatedActiveContentsExist")]
    RelatedActiveContentsExist,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("HTTPStatusNotOK")]
    HTTPStatusNotOK,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SchemeNotHTTPOrHTTPS")]
    SchemeNotHTTPOrHTTPS,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Loading")]
    Loading,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WasGrantedMediaAccess")]
    WasGrantedMediaAccess,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DisableForRenderFrameHostCalled")]
    DisableForRenderFrameHostCalled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DomainNotAllowed")]
    DomainNotAllowed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("HTTPMethodNotGET")]
    HTTPMethodNotGET,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SubframeIsNavigating")]
    SubframeIsNavigating,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Timeout")]
    Timeout,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CacheLimit")]
    CacheLimit,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("JavaScriptExecution")]
    JavaScriptExecution,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RendererProcessKilled")]
    RendererProcessKilled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RendererProcessCrashed")]
    RendererProcessCrashed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SchedulerTrackedFeatureUsed")]
    SchedulerTrackedFeatureUsed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ConflictingBrowsingInstance")]
    ConflictingBrowsingInstance,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CacheFlushed")]
    CacheFlushed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ServiceWorkerVersionActivation")]
    ServiceWorkerVersionActivation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SessionRestored")]
    SessionRestored,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ServiceWorkerPostMessage")]
    ServiceWorkerPostMessage,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EnteredBackForwardCacheBeforeServiceWorkerHostAdded")]
    EnteredBackForwardCacheBeforeServiceWorkerHostAdded,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RenderFrameHostReused_SameSite")]
    RenderFrameHostReusedSameSite,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RenderFrameHostReused_CrossSite")]
    RenderFrameHostReusedCrossSite,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ServiceWorkerClaim")]
    ServiceWorkerClaim,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IgnoreEventAndEvict")]
    IgnoreEventAndEvict,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("HaveInnerContents")]
    HaveInnerContents,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TimeoutPuttingInCache")]
    TimeoutPuttingInCache,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BackForwardCacheDisabledByLowMemory")]
    BackForwardCacheDisabledByLowMemory,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BackForwardCacheDisabledByCommandLine")]
    BackForwardCacheDisabledByCommandLine,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NetworkRequestDatapipeDrainedAsBytesConsumer")]
    NetworkRequestDatapipeDrainedAsBytesConsumer,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NetworkRequestRedirected")]
    NetworkRequestRedirected,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NetworkRequestTimeout")]
    NetworkRequestTimeout,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NetworkExceedsBufferLimit")]
    NetworkExceedsBufferLimit,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NavigationCancelledWhileRestoring")]
    NavigationCancelledWhileRestoring,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NotMostRecentNavigationEntry")]
    NotMostRecentNavigationEntry,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BackForwardCacheDisabledForPrerender")]
    BackForwardCacheDisabledForPrerender,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UserAgentOverrideDiffers")]
    UserAgentOverrideDiffers,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ForegroundCacheLimit")]
    ForegroundCacheLimit,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ForwardCacheDisabled")]
    ForwardCacheDisabled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BrowsingInstanceNotSwapped")]
    BrowsingInstanceNotSwapped,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BackForwardCacheDisabledForDelegate")]
    BackForwardCacheDisabledForDelegate,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UnloadHandlerExistsInMainFrame")]
    UnloadHandlerExistsInMainFrame,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UnloadHandlerExistsInSubFrame")]
    UnloadHandlerExistsInSubFrame,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ServiceWorkerUnregistration")]
    ServiceWorkerUnregistration,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CacheControlNoStore")]
    CacheControlNoStore,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CacheControlNoStoreCookieModified")]
    CacheControlNoStoreCookieModified,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CacheControlNoStoreHTTPOnlyCookieModified")]
    CacheControlNoStoreHTTPOnlyCookieModified,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NoResponseHead")]
    NoResponseHead,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Unknown")]
    Unknown,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ActivationNavigationsDisallowedForBug1234857")]
    ActivationNavigationsDisallowedForBug1234857,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ErrorDocument")]
    ErrorDocument,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FencedFramesEmbedder")]
    FencedFramesEmbedder,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CookieDisabled")]
    CookieDisabled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("HTTPAuthRequired")]
    HTTPAuthRequired,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CookieFlushed")]
    CookieFlushed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BroadcastChannelOnMessage")]
    BroadcastChannelOnMessage,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebViewSettingsChanged")]
    WebViewSettingsChanged,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebViewJavaScriptObjectChanged")]
    WebViewJavaScriptObjectChanged,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebViewMessageListenerInjected")]
    WebViewMessageListenerInjected,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebViewSafeBrowsingAllowlistChanged")]
    WebViewSafeBrowsingAllowlistChanged,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebViewDocumentStartJavascriptChanged")]
    WebViewDocumentStartJavascriptChanged,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebSocket")]
    WebSocket,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebTransport")]
    WebTransport,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebRTC")]
    WebRTC,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MainResourceHasCacheControlNoStore")]
    MainResourceHasCacheControlNoStore,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MainResourceHasCacheControlNoCache")]
    MainResourceHasCacheControlNoCache,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SubresourceHasCacheControlNoStore")]
    SubresourceHasCacheControlNoStore,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SubresourceHasCacheControlNoCache")]
    SubresourceHasCacheControlNoCache,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContainsPlugins")]
    ContainsPlugins,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DocumentLoaded")]
    DocumentLoaded,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("OutstandingNetworkRequestOthers")]
    OutstandingNetworkRequestOthers,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RequestedMIDIPermission")]
    RequestedMIDIPermission,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RequestedAudioCapturePermission")]
    RequestedAudioCapturePermission,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RequestedVideoCapturePermission")]
    RequestedVideoCapturePermission,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RequestedBackForwardCacheBlockedSensors")]
    RequestedBackForwardCacheBlockedSensors,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RequestedBackgroundWorkPermission")]
    RequestedBackgroundWorkPermission,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BroadcastChannel")]
    BroadcastChannel,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebXR")]
    WebXR,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SharedWorker")]
    SharedWorker,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SharedWorkerMessage")]
    SharedWorkerMessage,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SharedWorkerWithNoActiveClient")]
    SharedWorkerWithNoActiveClient,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebLocks")]
    WebLocks,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebLocksContention")]
    WebLocksContention,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebHID")]
    WebHID,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebBluetooth")]
    WebBluetooth,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebShare")]
    WebShare,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RequestedStorageAccessGrant")]
    RequestedStorageAccessGrant,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebNfc")]
    WebNfc,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("OutstandingNetworkRequestFetch")]
    OutstandingNetworkRequestFetch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("OutstandingNetworkRequestXHR")]
    OutstandingNetworkRequestXHR,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AppBanner")]
    AppBanner,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Printing")]
    Printing,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebDatabase")]
    WebDatabase,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PictureInPicture")]
    PictureInPicture,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SpeechRecognizer")]
    SpeechRecognizer,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IdleManager")]
    IdleManager,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PaymentManager")]
    PaymentManager,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SpeechSynthesis")]
    SpeechSynthesis,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("KeyboardLock")]
    KeyboardLock,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebOTPService")]
    WebOTPService,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("OutstandingNetworkRequestDirectSocket")]
    OutstandingNetworkRequestDirectSocket,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InjectedJavascript")]
    InjectedJavascript,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InjectedStyleSheet")]
    InjectedStyleSheet,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("KeepaliveRequest")]
    KeepaliveRequest,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IndexedDBEvent")]
    IndexedDBEvent,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Dummy")]
    Dummy,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("JsNetworkRequestReceivedCacheControlNoStoreResource")]
    JsNetworkRequestReceivedCacheControlNoStoreResource,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebRTCUsedWithCCNS")]
    WebRTCUsedWithCCNS,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebTransportUsedWithCCNS")]
    WebTransportUsedWithCCNS,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebSocketUsedWithCCNS")]
    WebSocketUsedWithCCNS,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SmartCard")]
    SmartCard,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("LiveMediaStreamTrack")]
    LiveMediaStreamTrack,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UnloadHandler")]
    UnloadHandler,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ParserAborted")]
    ParserAborted,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentSecurityHandler")]
    ContentSecurityHandler,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentWebAuthenticationAPI")]
    ContentWebAuthenticationAPI,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentFileChooser")]
    ContentFileChooser,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentSerial")]
    ContentSerial,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentFileSystemAccess")]
    ContentFileSystemAccess,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentMediaDevicesDispatcherHost")]
    ContentMediaDevicesDispatcherHost,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentWebBluetooth")]
    ContentWebBluetooth,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentWebUSB")]
    ContentWebUSB,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentMediaSessionService")]
    ContentMediaSessionService,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentScreenReader")]
    ContentScreenReader,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentDiscarded")]
    ContentDiscarded,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderPopupBlockerTabHelper")]
    EmbedderPopupBlockerTabHelper,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderSafeBrowsingTriggeredPopupBlocker")]
    EmbedderSafeBrowsingTriggeredPopupBlocker,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderSafeBrowsingThreatDetails")]
    EmbedderSafeBrowsingThreatDetails,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderAppBannerManager")]
    EmbedderAppBannerManager,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderDomDistillerViewerSource")]
    EmbedderDomDistillerViewerSource,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderDomDistillerSelfDeletingRequestDelegate")]
    EmbedderDomDistillerSelfDeletingRequestDelegate,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderOomInterventionTabHelper")]
    EmbedderOomInterventionTabHelper,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderOfflinePage")]
    EmbedderOfflinePage,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderChromePasswordManagerClientBindCredentialManager")]
    EmbedderChromePasswordManagerClientBindCredentialManager,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderPermissionRequestManager")]
    EmbedderPermissionRequestManager,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderModalDialog")]
    EmbedderModalDialog,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderExtensions")]
    EmbedderExtensions,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderExtensionMessaging")]
    EmbedderExtensionMessaging,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderExtensionMessagingForOpenPort")]
    EmbedderExtensionMessagingForOpenPort,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderExtensionSentMessageToCachedFrame")]
    EmbedderExtensionSentMessageToCachedFrame,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderExtensionFrame")]
    EmbedderExtensionFrame,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RequestedByWebViewClient")]
    RequestedByWebViewClient,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PostMessageByWebViewClient")]
    PostMessageByWebViewClient,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CacheControlNoStoreDeviceBoundSessionTerminated")]
    CacheControlNoStoreDeviceBoundSessionTerminated,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CacheLimitPrunedOnModerateMemoryPressure")]
    CacheLimitPrunedOnModerateMemoryPressure,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CacheLimitPrunedOnCriticalMemoryPressure")]
    CacheLimitPrunedOnCriticalMemoryPressure,
}

/// <summary>
/// Types of not restored reasons for back-forward cache.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<BackForwardCacheNotRestoredReasonType>))]
public enum BackForwardCacheNotRestoredReasonType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SupportPending")]
    SupportPending,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PageSupportNeeded")]
    PageSupportNeeded,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Circumstantial")]
    Circumstantial,
}

/// <summary>
/// </summary>
/// <param name="LineNumber">
/// Line number in the script (0-based).
/// </param>
/// <param name="ColumnNumber">
/// Column number in the script (0-based).
/// </param>
public sealed record BackForwardCacheBlockingDetails(long LineNumber, long ColumnNumber)
{
    /// <summary>
    /// Url of the file where blockage happened. Optional because of tests.
    /// </summary>
    public string? Url { get; init; }

    /// <summary>
    /// Function name where blockage happened. Optional because of anonymous functions and tests.
    /// </summary>
    public string? Function { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Type">
/// Type of the reason
/// </param>
/// <param name="Reason">
/// Not restored reason
/// </param>
public sealed record BackForwardCacheNotRestoredExplanation(BackForwardCacheNotRestoredReasonType Type, BackForwardCacheNotRestoredReason Reason)
{
    /// <summary>
    /// Context associated with the reason. The meaning of this context is
    /// dependent on the reason:
    /// - EmbedderExtensionSentMessageToCachedFrame: the extension ID.
    /// </summary>
    public string? Context { get; init; }

    /// <summary>
    /// </summary>
    public IReadOnlyList<BackForwardCacheBlockingDetails>? Details { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Url">
/// URL of each frame
/// </param>
/// <param name="Explanations">
/// Not restored reasons of each frame
/// </param>
/// <param name="Children">
/// Array of children frame
/// </param>
public sealed record BackForwardCacheNotRestoredExplanationTree(string Url, IReadOnlyList<BackForwardCacheNotRestoredExplanation> Explanations, IReadOnlyList<BackForwardCacheNotRestoredExplanationTree> Children)
{
}

[JsonSerializable(typeof(AddScriptToEvaluateOnLoadCommandParameters), TypeInfoPropertyName = "AddScriptToEvaluateOnLoadCommandParameters")]
[JsonSerializable(typeof(AddScriptToEvaluateOnLoadResult), TypeInfoPropertyName = "AddScriptToEvaluateOnLoadResult")]
[JsonSerializable(typeof(AddScriptToEvaluateOnNewDocumentCommandParameters), TypeInfoPropertyName = "AddScriptToEvaluateOnNewDocumentCommandParameters")]
[JsonSerializable(typeof(AddScriptToEvaluateOnNewDocumentResult), TypeInfoPropertyName = "AddScriptToEvaluateOnNewDocumentResult")]
[JsonSerializable(typeof(BringToFrontCommandParameters), TypeInfoPropertyName = "BringToFrontCommandParameters")]
[JsonSerializable(typeof(BringToFrontResult), TypeInfoPropertyName = "BringToFrontResult")]
[JsonSerializable(typeof(CaptureScreenshotCommandParameters), TypeInfoPropertyName = "CaptureScreenshotCommandParameters")]
[JsonSerializable(typeof(CaptureScreenshotResult), TypeInfoPropertyName = "CaptureScreenshotResult")]
[JsonSerializable(typeof(CaptureSnapshotCommandParameters), TypeInfoPropertyName = "CaptureSnapshotCommandParameters")]
[JsonSerializable(typeof(CaptureSnapshotResult), TypeInfoPropertyName = "CaptureSnapshotResult")]
[JsonSerializable(typeof(ClearDeviceMetricsOverrideCommandParameters), TypeInfoPropertyName = "ClearDeviceMetricsOverrideCommandParameters")]
[JsonSerializable(typeof(ClearDeviceMetricsOverrideResult), TypeInfoPropertyName = "ClearDeviceMetricsOverrideResult")]
[JsonSerializable(typeof(ClearDeviceOrientationOverrideCommandParameters), TypeInfoPropertyName = "ClearDeviceOrientationOverrideCommandParameters")]
[JsonSerializable(typeof(ClearDeviceOrientationOverrideResult), TypeInfoPropertyName = "ClearDeviceOrientationOverrideResult")]
[JsonSerializable(typeof(ClearGeolocationOverrideCommandParameters), TypeInfoPropertyName = "ClearGeolocationOverrideCommandParameters")]
[JsonSerializable(typeof(ClearGeolocationOverrideResult), TypeInfoPropertyName = "ClearGeolocationOverrideResult")]
[JsonSerializable(typeof(CreateIsolatedWorldCommandParameters), TypeInfoPropertyName = "CreateIsolatedWorldCommandParameters")]
[JsonSerializable(typeof(CreateIsolatedWorldResult), TypeInfoPropertyName = "CreateIsolatedWorldResult")]
[JsonSerializable(typeof(DeleteCookieCommandParameters), TypeInfoPropertyName = "DeleteCookieCommandParameters")]
[JsonSerializable(typeof(DeleteCookieResult), TypeInfoPropertyName = "DeleteCookieResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(GetAppManifestCommandParameters), TypeInfoPropertyName = "GetAppManifestCommandParameters")]
[JsonSerializable(typeof(GetAppManifestResult), TypeInfoPropertyName = "GetAppManifestResult")]
[JsonSerializable(typeof(GetInstallabilityErrorsCommandParameters), TypeInfoPropertyName = "GetInstallabilityErrorsCommandParameters")]
[JsonSerializable(typeof(GetInstallabilityErrorsResult), TypeInfoPropertyName = "GetInstallabilityErrorsResult")]
[JsonSerializable(typeof(GetManifestIconsCommandParameters), TypeInfoPropertyName = "GetManifestIconsCommandParameters")]
[JsonSerializable(typeof(GetManifestIconsResult), TypeInfoPropertyName = "GetManifestIconsResult")]
[JsonSerializable(typeof(GetAppIdCommandParameters), TypeInfoPropertyName = "GetAppIdCommandParameters")]
[JsonSerializable(typeof(GetAppIdResult), TypeInfoPropertyName = "GetAppIdResult")]
[JsonSerializable(typeof(GetAdScriptAncestryCommandParameters), TypeInfoPropertyName = "GetAdScriptAncestryCommandParameters")]
[JsonSerializable(typeof(GetAdScriptAncestryResult), TypeInfoPropertyName = "GetAdScriptAncestryResult")]
[JsonSerializable(typeof(GetFrameTreeCommandParameters), TypeInfoPropertyName = "GetFrameTreeCommandParameters")]
[JsonSerializable(typeof(GetFrameTreeResult), TypeInfoPropertyName = "GetFrameTreeResult")]
[JsonSerializable(typeof(GetLayoutMetricsCommandParameters), TypeInfoPropertyName = "GetLayoutMetricsCommandParameters")]
[JsonSerializable(typeof(GetLayoutMetricsResult), TypeInfoPropertyName = "GetLayoutMetricsResult")]
[JsonSerializable(typeof(GetNavigationHistoryCommandParameters), TypeInfoPropertyName = "GetNavigationHistoryCommandParameters")]
[JsonSerializable(typeof(GetNavigationHistoryResult), TypeInfoPropertyName = "GetNavigationHistoryResult")]
[JsonSerializable(typeof(ResetNavigationHistoryCommandParameters), TypeInfoPropertyName = "ResetNavigationHistoryCommandParameters")]
[JsonSerializable(typeof(ResetNavigationHistoryResult), TypeInfoPropertyName = "ResetNavigationHistoryResult")]
[JsonSerializable(typeof(GetResourceContentCommandParameters), TypeInfoPropertyName = "GetResourceContentCommandParameters")]
[JsonSerializable(typeof(GetResourceContentResult), TypeInfoPropertyName = "GetResourceContentResult")]
[JsonSerializable(typeof(GetResourceTreeCommandParameters), TypeInfoPropertyName = "GetResourceTreeCommandParameters")]
[JsonSerializable(typeof(GetResourceTreeResult), TypeInfoPropertyName = "GetResourceTreeResult")]
[JsonSerializable(typeof(HandleJavaScriptDialogCommandParameters), TypeInfoPropertyName = "HandleJavaScriptDialogCommandParameters")]
[JsonSerializable(typeof(HandleJavaScriptDialogResult), TypeInfoPropertyName = "HandleJavaScriptDialogResult")]
[JsonSerializable(typeof(NavigateCommandParameters), TypeInfoPropertyName = "NavigateCommandParameters")]
[JsonSerializable(typeof(NavigateResult), TypeInfoPropertyName = "NavigateResult")]
[JsonSerializable(typeof(NavigateToHistoryEntryCommandParameters), TypeInfoPropertyName = "NavigateToHistoryEntryCommandParameters")]
[JsonSerializable(typeof(NavigateToHistoryEntryResult), TypeInfoPropertyName = "NavigateToHistoryEntryResult")]
[JsonSerializable(typeof(PrintToPDFCommandParameters), TypeInfoPropertyName = "PrintToPDFCommandParameters")]
[JsonSerializable(typeof(PrintToPDFResult), TypeInfoPropertyName = "PrintToPDFResult")]
[JsonSerializable(typeof(ReloadCommandParameters), TypeInfoPropertyName = "ReloadCommandParameters")]
[JsonSerializable(typeof(ReloadResult), TypeInfoPropertyName = "ReloadResult")]
[JsonSerializable(typeof(RemoveScriptToEvaluateOnLoadCommandParameters), TypeInfoPropertyName = "RemoveScriptToEvaluateOnLoadCommandParameters")]
[JsonSerializable(typeof(RemoveScriptToEvaluateOnLoadResult), TypeInfoPropertyName = "RemoveScriptToEvaluateOnLoadResult")]
[JsonSerializable(typeof(RemoveScriptToEvaluateOnNewDocumentCommandParameters), TypeInfoPropertyName = "RemoveScriptToEvaluateOnNewDocumentCommandParameters")]
[JsonSerializable(typeof(RemoveScriptToEvaluateOnNewDocumentResult), TypeInfoPropertyName = "RemoveScriptToEvaluateOnNewDocumentResult")]
[JsonSerializable(typeof(ScreencastFrameAckCommandParameters), TypeInfoPropertyName = "ScreencastFrameAckCommandParameters")]
[JsonSerializable(typeof(ScreencastFrameAckResult), TypeInfoPropertyName = "ScreencastFrameAckResult")]
[JsonSerializable(typeof(SearchInResourceCommandParameters), TypeInfoPropertyName = "SearchInResourceCommandParameters")]
[JsonSerializable(typeof(SearchInResourceResult), TypeInfoPropertyName = "SearchInResourceResult")]
[JsonSerializable(typeof(SetAdBlockingEnabledCommandParameters), TypeInfoPropertyName = "SetAdBlockingEnabledCommandParameters")]
[JsonSerializable(typeof(SetAdBlockingEnabledResult), TypeInfoPropertyName = "SetAdBlockingEnabledResult")]
[JsonSerializable(typeof(SetBypassCSPCommandParameters), TypeInfoPropertyName = "SetBypassCSPCommandParameters")]
[JsonSerializable(typeof(SetBypassCSPResult), TypeInfoPropertyName = "SetBypassCSPResult")]
[JsonSerializable(typeof(GetPermissionsPolicyStateCommandParameters), TypeInfoPropertyName = "GetPermissionsPolicyStateCommandParameters")]
[JsonSerializable(typeof(GetPermissionsPolicyStateResult), TypeInfoPropertyName = "GetPermissionsPolicyStateResult")]
[JsonSerializable(typeof(GetOriginTrialsCommandParameters), TypeInfoPropertyName = "GetOriginTrialsCommandParameters")]
[JsonSerializable(typeof(GetOriginTrialsResult), TypeInfoPropertyName = "GetOriginTrialsResult")]
[JsonSerializable(typeof(SetDeviceMetricsOverrideCommandParameters), TypeInfoPropertyName = "SetDeviceMetricsOverrideCommandParameters")]
[JsonSerializable(typeof(SetDeviceMetricsOverrideResult), TypeInfoPropertyName = "SetDeviceMetricsOverrideResult")]
[JsonSerializable(typeof(SetDeviceOrientationOverrideCommandParameters), TypeInfoPropertyName = "SetDeviceOrientationOverrideCommandParameters")]
[JsonSerializable(typeof(SetDeviceOrientationOverrideResult), TypeInfoPropertyName = "SetDeviceOrientationOverrideResult")]
[JsonSerializable(typeof(SetFontFamiliesCommandParameters), TypeInfoPropertyName = "SetFontFamiliesCommandParameters")]
[JsonSerializable(typeof(SetFontFamiliesResult), TypeInfoPropertyName = "SetFontFamiliesResult")]
[JsonSerializable(typeof(SetFontSizesCommandParameters), TypeInfoPropertyName = "SetFontSizesCommandParameters")]
[JsonSerializable(typeof(SetFontSizesResult), TypeInfoPropertyName = "SetFontSizesResult")]
[JsonSerializable(typeof(SetDocumentContentCommandParameters), TypeInfoPropertyName = "SetDocumentContentCommandParameters")]
[JsonSerializable(typeof(SetDocumentContentResult), TypeInfoPropertyName = "SetDocumentContentResult")]
[JsonSerializable(typeof(SetDownloadBehaviorCommandParameters), TypeInfoPropertyName = "SetDownloadBehaviorCommandParameters")]
[JsonSerializable(typeof(SetDownloadBehaviorResult), TypeInfoPropertyName = "SetDownloadBehaviorResult")]
[JsonSerializable(typeof(SetGeolocationOverrideCommandParameters), TypeInfoPropertyName = "SetGeolocationOverrideCommandParameters")]
[JsonSerializable(typeof(SetGeolocationOverrideResult), TypeInfoPropertyName = "SetGeolocationOverrideResult")]
[JsonSerializable(typeof(SetLifecycleEventsEnabledCommandParameters), TypeInfoPropertyName = "SetLifecycleEventsEnabledCommandParameters")]
[JsonSerializable(typeof(SetLifecycleEventsEnabledResult), TypeInfoPropertyName = "SetLifecycleEventsEnabledResult")]
[JsonSerializable(typeof(SetTouchEmulationEnabledCommandParameters), TypeInfoPropertyName = "SetTouchEmulationEnabledCommandParameters")]
[JsonSerializable(typeof(SetTouchEmulationEnabledResult), TypeInfoPropertyName = "SetTouchEmulationEnabledResult")]
[JsonSerializable(typeof(StartScreencastCommandParameters), TypeInfoPropertyName = "StartScreencastCommandParameters")]
[JsonSerializable(typeof(StartScreencastResult), TypeInfoPropertyName = "StartScreencastResult")]
[JsonSerializable(typeof(StopLoadingCommandParameters), TypeInfoPropertyName = "StopLoadingCommandParameters")]
[JsonSerializable(typeof(StopLoadingResult), TypeInfoPropertyName = "StopLoadingResult")]
[JsonSerializable(typeof(CrashCommandParameters), TypeInfoPropertyName = "CrashCommandParameters")]
[JsonSerializable(typeof(CrashResult), TypeInfoPropertyName = "CrashResult")]
[JsonSerializable(typeof(CloseCommandParameters), TypeInfoPropertyName = "CloseCommandParameters")]
[JsonSerializable(typeof(CloseResult), TypeInfoPropertyName = "CloseResult")]
[JsonSerializable(typeof(SetWebLifecycleStateCommandParameters), TypeInfoPropertyName = "SetWebLifecycleStateCommandParameters")]
[JsonSerializable(typeof(SetWebLifecycleStateResult), TypeInfoPropertyName = "SetWebLifecycleStateResult")]
[JsonSerializable(typeof(StopScreencastCommandParameters), TypeInfoPropertyName = "StopScreencastCommandParameters")]
[JsonSerializable(typeof(StopScreencastResult), TypeInfoPropertyName = "StopScreencastResult")]
[JsonSerializable(typeof(ProduceCompilationCacheCommandParameters), TypeInfoPropertyName = "ProduceCompilationCacheCommandParameters")]
[JsonSerializable(typeof(ProduceCompilationCacheResult), TypeInfoPropertyName = "ProduceCompilationCacheResult")]
[JsonSerializable(typeof(AddCompilationCacheCommandParameters), TypeInfoPropertyName = "AddCompilationCacheCommandParameters")]
[JsonSerializable(typeof(AddCompilationCacheResult), TypeInfoPropertyName = "AddCompilationCacheResult")]
[JsonSerializable(typeof(ClearCompilationCacheCommandParameters), TypeInfoPropertyName = "ClearCompilationCacheCommandParameters")]
[JsonSerializable(typeof(ClearCompilationCacheResult), TypeInfoPropertyName = "ClearCompilationCacheResult")]
[JsonSerializable(typeof(SetSPCTransactionModeCommandParameters), TypeInfoPropertyName = "SetSPCTransactionModeCommandParameters")]
[JsonSerializable(typeof(SetSPCTransactionModeResult), TypeInfoPropertyName = "SetSPCTransactionModeResult")]
[JsonSerializable(typeof(SetRPHRegistrationModeCommandParameters), TypeInfoPropertyName = "SetRPHRegistrationModeCommandParameters")]
[JsonSerializable(typeof(SetRPHRegistrationModeResult), TypeInfoPropertyName = "SetRPHRegistrationModeResult")]
[JsonSerializable(typeof(GenerateTestReportCommandParameters), TypeInfoPropertyName = "GenerateTestReportCommandParameters")]
[JsonSerializable(typeof(GenerateTestReportResult), TypeInfoPropertyName = "GenerateTestReportResult")]
[JsonSerializable(typeof(WaitForDebuggerCommandParameters), TypeInfoPropertyName = "WaitForDebuggerCommandParameters")]
[JsonSerializable(typeof(WaitForDebuggerResult), TypeInfoPropertyName = "WaitForDebuggerResult")]
[JsonSerializable(typeof(SetInterceptFileChooserDialogCommandParameters), TypeInfoPropertyName = "SetInterceptFileChooserDialogCommandParameters")]
[JsonSerializable(typeof(SetInterceptFileChooserDialogResult), TypeInfoPropertyName = "SetInterceptFileChooserDialogResult")]
[JsonSerializable(typeof(SetPrerenderingAllowedCommandParameters), TypeInfoPropertyName = "SetPrerenderingAllowedCommandParameters")]
[JsonSerializable(typeof(SetPrerenderingAllowedResult), TypeInfoPropertyName = "SetPrerenderingAllowedResult")]
[JsonSerializable(typeof(GetAnnotatedPageContentCommandParameters), TypeInfoPropertyName = "GetAnnotatedPageContentCommandParameters")]
[JsonSerializable(typeof(GetAnnotatedPageContentResult), TypeInfoPropertyName = "GetAnnotatedPageContentResult")]
[JsonSerializable(typeof(CdpEventArgs<DomContentEventFiredEventArgs>), TypeInfoPropertyName = "DomContentEventFiredCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<FileChooserOpenedEventArgs>), TypeInfoPropertyName = "FileChooserOpenedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<FrameAttachedEventArgs>), TypeInfoPropertyName = "FrameAttachedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<FrameClearedScheduledNavigationEventArgs>), TypeInfoPropertyName = "FrameClearedScheduledNavigationCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<FrameDetachedEventArgs>), TypeInfoPropertyName = "FrameDetachedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<FrameSubtreeWillBeDetachedEventArgs>), TypeInfoPropertyName = "FrameSubtreeWillBeDetachedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<FrameNavigatedEventArgs>), TypeInfoPropertyName = "FrameNavigatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DocumentOpenedEventArgs>), TypeInfoPropertyName = "DocumentOpenedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<FrameResizedEventArgs>), TypeInfoPropertyName = "FrameResizedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<FrameStartedNavigatingEventArgs>), TypeInfoPropertyName = "FrameStartedNavigatingCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<FrameRequestedNavigationEventArgs>), TypeInfoPropertyName = "FrameRequestedNavigationCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<FrameScheduledNavigationEventArgs>), TypeInfoPropertyName = "FrameScheduledNavigationCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<FrameStartedLoadingEventArgs>), TypeInfoPropertyName = "FrameStartedLoadingCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<FrameStoppedLoadingEventArgs>), TypeInfoPropertyName = "FrameStoppedLoadingCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DownloadWillBeginEventArgs>), TypeInfoPropertyName = "DownloadWillBeginCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DownloadProgressEventArgs>), TypeInfoPropertyName = "DownloadProgressCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<InterstitialHiddenEventArgs>), TypeInfoPropertyName = "InterstitialHiddenCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<InterstitialShownEventArgs>), TypeInfoPropertyName = "InterstitialShownCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<JavascriptDialogClosedEventArgs>), TypeInfoPropertyName = "JavascriptDialogClosedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<JavascriptDialogOpeningEventArgs>), TypeInfoPropertyName = "JavascriptDialogOpeningCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<LifecycleEventEventArgs>), TypeInfoPropertyName = "LifecycleEventCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<BackForwardCacheNotUsedEventArgs>), TypeInfoPropertyName = "BackForwardCacheNotUsedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<LoadEventFiredEventArgs>), TypeInfoPropertyName = "LoadEventFiredCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<NavigatedWithinDocumentEventArgs>), TypeInfoPropertyName = "NavigatedWithinDocumentCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ScreencastFrameEventArgs>), TypeInfoPropertyName = "ScreencastFrameCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ScreencastVisibilityChangedEventArgs>), TypeInfoPropertyName = "ScreencastVisibilityChangedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<WindowOpenEventArgs>), TypeInfoPropertyName = "WindowOpenCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<CompilationCacheProducedEventArgs>), TypeInfoPropertyName = "CompilationCacheProducedCdpEventArgs")]
[JsonSerializable(typeof(FrameId), TypeInfoPropertyName = "PageFrameId")]
[JsonSerializable(typeof(AdFrameType), TypeInfoPropertyName = "PageAdFrameType")]
[JsonSerializable(typeof(AdFrameExplanation), TypeInfoPropertyName = "PageAdFrameExplanation")]
[JsonSerializable(typeof(AdFrameStatus), TypeInfoPropertyName = "PageAdFrameStatus")]
[JsonSerializable(typeof(SecureContextType), TypeInfoPropertyName = "PageSecureContextType")]
[JsonSerializable(typeof(CrossOriginIsolatedContextType), TypeInfoPropertyName = "PageCrossOriginIsolatedContextType")]
[JsonSerializable(typeof(GatedAPIFeatures), TypeInfoPropertyName = "PageGatedAPIFeatures")]
[JsonSerializable(typeof(PermissionsPolicyFeature), TypeInfoPropertyName = "PagePermissionsPolicyFeature")]
[JsonSerializable(typeof(PermissionsPolicyBlockReason), TypeInfoPropertyName = "PagePermissionsPolicyBlockReason")]
[JsonSerializable(typeof(PermissionsPolicyBlockLocator), TypeInfoPropertyName = "PagePermissionsPolicyBlockLocator")]
[JsonSerializable(typeof(PermissionsPolicyFeatureState), TypeInfoPropertyName = "PagePermissionsPolicyFeatureState")]
[JsonSerializable(typeof(OriginTrialTokenStatus), TypeInfoPropertyName = "PageOriginTrialTokenStatus")]
[JsonSerializable(typeof(OriginTrialStatus), TypeInfoPropertyName = "PageOriginTrialStatus")]
[JsonSerializable(typeof(OriginTrialUsageRestriction), TypeInfoPropertyName = "PageOriginTrialUsageRestriction")]
[JsonSerializable(typeof(OriginTrialToken), TypeInfoPropertyName = "PageOriginTrialToken")]
[JsonSerializable(typeof(OriginTrialTokenWithStatus), TypeInfoPropertyName = "PageOriginTrialTokenWithStatus")]
[JsonSerializable(typeof(OriginTrial), TypeInfoPropertyName = "PageOriginTrial")]
[JsonSerializable(typeof(SecurityOriginDetails), TypeInfoPropertyName = "PageSecurityOriginDetails")]
[JsonSerializable(typeof(Frame), TypeInfoPropertyName = "PageFrame")]
[JsonSerializable(typeof(FrameResource), TypeInfoPropertyName = "PageFrameResource")]
[JsonSerializable(typeof(FrameResourceTree), TypeInfoPropertyName = "PageFrameResourceTree")]
[JsonSerializable(typeof(FrameTree), TypeInfoPropertyName = "PageFrameTree")]
[JsonSerializable(typeof(ScriptIdentifier), TypeInfoPropertyName = "PageScriptIdentifier")]
[JsonSerializable(typeof(TransitionType), TypeInfoPropertyName = "PageTransitionType")]
[JsonSerializable(typeof(NavigationEntry), TypeInfoPropertyName = "PageNavigationEntry")]
[JsonSerializable(typeof(ScreencastFrameMetadata), TypeInfoPropertyName = "PageScreencastFrameMetadata")]
[JsonSerializable(typeof(DialogType), TypeInfoPropertyName = "PageDialogType")]
[JsonSerializable(typeof(AppManifestError), TypeInfoPropertyName = "PageAppManifestError")]
[JsonSerializable(typeof(AppManifestParsedProperties), TypeInfoPropertyName = "PageAppManifestParsedProperties")]
[JsonSerializable(typeof(LayoutViewport), TypeInfoPropertyName = "PageLayoutViewport")]
[JsonSerializable(typeof(VisualViewport), TypeInfoPropertyName = "PageVisualViewport")]
[JsonSerializable(typeof(Viewport), TypeInfoPropertyName = "PageViewport")]
[JsonSerializable(typeof(FontFamilies), TypeInfoPropertyName = "PageFontFamilies")]
[JsonSerializable(typeof(ScriptFontFamilies), TypeInfoPropertyName = "PageScriptFontFamilies")]
[JsonSerializable(typeof(FontSizes), TypeInfoPropertyName = "PageFontSizes")]
[JsonSerializable(typeof(ClientNavigationReason), TypeInfoPropertyName = "PageClientNavigationReason")]
[JsonSerializable(typeof(ClientNavigationDisposition), TypeInfoPropertyName = "PageClientNavigationDisposition")]
[JsonSerializable(typeof(InstallabilityErrorArgument), TypeInfoPropertyName = "PageInstallabilityErrorArgument")]
[JsonSerializable(typeof(InstallabilityError), TypeInfoPropertyName = "PageInstallabilityError")]
[JsonSerializable(typeof(ReferrerPolicy), TypeInfoPropertyName = "PageReferrerPolicy")]
[JsonSerializable(typeof(CompilationCacheParams), TypeInfoPropertyName = "PageCompilationCacheParams")]
[JsonSerializable(typeof(FileFilter), TypeInfoPropertyName = "PageFileFilter")]
[JsonSerializable(typeof(FileHandler), TypeInfoPropertyName = "PageFileHandler")]
[JsonSerializable(typeof(ImageResource), TypeInfoPropertyName = "PageImageResource")]
[JsonSerializable(typeof(LaunchHandler), TypeInfoPropertyName = "PageLaunchHandler")]
[JsonSerializable(typeof(ProtocolHandler), TypeInfoPropertyName = "PageProtocolHandler")]
[JsonSerializable(typeof(RelatedApplication), TypeInfoPropertyName = "PageRelatedApplication")]
[JsonSerializable(typeof(ScopeExtension), TypeInfoPropertyName = "PageScopeExtension")]
[JsonSerializable(typeof(Screenshot), TypeInfoPropertyName = "PageScreenshot")]
[JsonSerializable(typeof(ShareTarget), TypeInfoPropertyName = "PageShareTarget")]
[JsonSerializable(typeof(Shortcut), TypeInfoPropertyName = "PageShortcut")]
[JsonSerializable(typeof(WebAppManifest), TypeInfoPropertyName = "PageWebAppManifest")]
[JsonSerializable(typeof(NavigationType), TypeInfoPropertyName = "PageNavigationType")]
[JsonSerializable(typeof(BackForwardCacheNotRestoredReason), TypeInfoPropertyName = "PageBackForwardCacheNotRestoredReason")]
[JsonSerializable(typeof(BackForwardCacheNotRestoredReasonType), TypeInfoPropertyName = "PageBackForwardCacheNotRestoredReasonType")]
[JsonSerializable(typeof(BackForwardCacheBlockingDetails), TypeInfoPropertyName = "PageBackForwardCacheBlockingDetails")]
[JsonSerializable(typeof(BackForwardCacheNotRestoredExplanation), TypeInfoPropertyName = "PageBackForwardCacheNotRestoredExplanation")]
[JsonSerializable(typeof(BackForwardCacheNotRestoredExplanationTree), TypeInfoPropertyName = "PageBackForwardCacheNotRestoredExplanationTree")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<AppManifestError>), TypeInfoPropertyName = "IReadOnlyListPageAppManifestError")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<InstallabilityError>), TypeInfoPropertyName = "IReadOnlyListPageInstallabilityError")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<NavigationEntry>), TypeInfoPropertyName = "IReadOnlyListPageNavigationEntry")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<Debugger.SearchMatch>), TypeInfoPropertyName = "IReadOnlyListDebuggerSearchMatch")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<PermissionsPolicyFeatureState>), TypeInfoPropertyName = "IReadOnlyListPagePermissionsPolicyFeatureState")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<OriginTrial>), TypeInfoPropertyName = "IReadOnlyListPageOriginTrial")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<ScriptFontFamilies>), TypeInfoPropertyName = "IReadOnlyListPageScriptFontFamilies")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<CompilationCacheParams>), TypeInfoPropertyName = "IReadOnlyListPageCompilationCacheParams")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<BackForwardCacheNotRestoredExplanation>), TypeInfoPropertyName = "IReadOnlyListPageBackForwardCacheNotRestoredExplanation")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<AdFrameExplanation>), TypeInfoPropertyName = "IReadOnlyListPageAdFrameExplanation")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<OriginTrialTokenWithStatus>), TypeInfoPropertyName = "IReadOnlyListPageOriginTrialTokenWithStatus")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<GatedAPIFeatures>), TypeInfoPropertyName = "IReadOnlyListPageGatedAPIFeatures")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<FrameResourceTree>), TypeInfoPropertyName = "IReadOnlyListPageFrameResourceTree")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<FrameResource>), TypeInfoPropertyName = "IReadOnlyListPageFrameResource")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<FrameTree>), TypeInfoPropertyName = "IReadOnlyListPageFrameTree")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<InstallabilityErrorArgument>), TypeInfoPropertyName = "IReadOnlyListPageInstallabilityErrorArgument")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<ImageResource>), TypeInfoPropertyName = "IReadOnlyListPageImageResource")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<FileFilter>), TypeInfoPropertyName = "IReadOnlyListPageFileFilter")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<FileHandler>), TypeInfoPropertyName = "IReadOnlyListPageFileHandler")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<ProtocolHandler>), TypeInfoPropertyName = "IReadOnlyListPageProtocolHandler")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<RelatedApplication>), TypeInfoPropertyName = "IReadOnlyListPageRelatedApplication")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<ScopeExtension>), TypeInfoPropertyName = "IReadOnlyListPageScopeExtension")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<Screenshot>), TypeInfoPropertyName = "IReadOnlyListPageScreenshot")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<Shortcut>), TypeInfoPropertyName = "IReadOnlyListPageShortcut")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<BackForwardCacheBlockingDetails>), TypeInfoPropertyName = "IReadOnlyListPageBackForwardCacheBlockingDetails")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<BackForwardCacheNotRestoredExplanationTree>), TypeInfoPropertyName = "IReadOnlyListPageBackForwardCacheNotRestoredExplanationTree")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class PageJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="PageDomain"/>.
/// </summary>
public static class PageDomainEvent
{
    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DomContentEventFiredEventArgs>> DomContentEventFired { get; } =
        EventDescriptor<CdpEventArgs<DomContentEventFiredEventArgs>>.Create(
            "goog:cdp.Page.domContentEventFired",
            PageJsonSerializerContext.Default.DomContentEventFiredCdpEventArgs);

    /// <summary>
    /// Emitted only when <b>page.interceptFileChooser</b> is enabled.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FileChooserOpenedEventArgs>> FileChooserOpened { get; } =
        EventDescriptor<CdpEventArgs<FileChooserOpenedEventArgs>>.Create(
            "goog:cdp.Page.fileChooserOpened",
            PageJsonSerializerContext.Default.FileChooserOpenedCdpEventArgs);

    /// <summary>
    /// Fired when frame has been attached to its parent.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FrameAttachedEventArgs>> FrameAttached { get; } =
        EventDescriptor<CdpEventArgs<FrameAttachedEventArgs>>.Create(
            "goog:cdp.Page.frameAttached",
            PageJsonSerializerContext.Default.FrameAttachedCdpEventArgs);

    /// <summary>
    /// Fired when frame no longer has a scheduled navigation.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FrameClearedScheduledNavigationEventArgs>> FrameClearedScheduledNavigation { get; } =
        EventDescriptor<CdpEventArgs<FrameClearedScheduledNavigationEventArgs>>.Create(
            "goog:cdp.Page.frameClearedScheduledNavigation",
            PageJsonSerializerContext.Default.FrameClearedScheduledNavigationCdpEventArgs);

    /// <summary>
    /// Fired when frame has been detached from its parent.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FrameDetachedEventArgs>> FrameDetached { get; } =
        EventDescriptor<CdpEventArgs<FrameDetachedEventArgs>>.Create(
            "goog:cdp.Page.frameDetached",
            PageJsonSerializerContext.Default.FrameDetachedCdpEventArgs);

    /// <summary>
    /// Fired before frame subtree is detached. Emitted before any frame of the
    /// subtree is actually detached.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FrameSubtreeWillBeDetachedEventArgs>> FrameSubtreeWillBeDetached { get; } =
        EventDescriptor<CdpEventArgs<FrameSubtreeWillBeDetachedEventArgs>>.Create(
            "goog:cdp.Page.frameSubtreeWillBeDetached",
            PageJsonSerializerContext.Default.FrameSubtreeWillBeDetachedCdpEventArgs);

    /// <summary>
    /// Fired once navigation of the frame has completed. Frame is now associated with the new loader.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FrameNavigatedEventArgs>> FrameNavigated { get; } =
        EventDescriptor<CdpEventArgs<FrameNavigatedEventArgs>>.Create(
            "goog:cdp.Page.frameNavigated",
            PageJsonSerializerContext.Default.FrameNavigatedCdpEventArgs);

    /// <summary>
    /// Fired when opening document to write to.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DocumentOpenedEventArgs>> DocumentOpened { get; } =
        EventDescriptor<CdpEventArgs<DocumentOpenedEventArgs>>.Create(
            "goog:cdp.Page.documentOpened",
            PageJsonSerializerContext.Default.DocumentOpenedCdpEventArgs);

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FrameResizedEventArgs>> FrameResized { get; } =
        EventDescriptor<CdpEventArgs<FrameResizedEventArgs>>.Create(
            "goog:cdp.Page.frameResized",
            PageJsonSerializerContext.Default.FrameResizedCdpEventArgs);

    /// <summary>
    /// Fired when a navigation starts. This event is fired for both
    /// renderer-initiated and browser-initiated navigations. For renderer-initiated
    /// navigations, the event is fired after <b>frameRequestedNavigation</b>.
    /// Navigation may still be cancelled after the event is issued. Multiple events
    /// can be fired for a single navigation, for example, when a same-document
    /// navigation becomes a cross-document navigation (such as in the case of a
    /// frameset).
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FrameStartedNavigatingEventArgs>> FrameStartedNavigating { get; } =
        EventDescriptor<CdpEventArgs<FrameStartedNavigatingEventArgs>>.Create(
            "goog:cdp.Page.frameStartedNavigating",
            PageJsonSerializerContext.Default.FrameStartedNavigatingCdpEventArgs);

    /// <summary>
    /// Fired when a renderer-initiated navigation is requested.
    /// Navigation may still be cancelled after the event is issued.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FrameRequestedNavigationEventArgs>> FrameRequestedNavigation { get; } =
        EventDescriptor<CdpEventArgs<FrameRequestedNavigationEventArgs>>.Create(
            "goog:cdp.Page.frameRequestedNavigation",
            PageJsonSerializerContext.Default.FrameRequestedNavigationCdpEventArgs);

    /// <summary>
    /// Fired when frame schedules a potential navigation.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FrameScheduledNavigationEventArgs>> FrameScheduledNavigation { get; } =
        EventDescriptor<CdpEventArgs<FrameScheduledNavigationEventArgs>>.Create(
            "goog:cdp.Page.frameScheduledNavigation",
            PageJsonSerializerContext.Default.FrameScheduledNavigationCdpEventArgs);

    /// <summary>
    /// Fired when frame has started loading.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FrameStartedLoadingEventArgs>> FrameStartedLoading { get; } =
        EventDescriptor<CdpEventArgs<FrameStartedLoadingEventArgs>>.Create(
            "goog:cdp.Page.frameStartedLoading",
            PageJsonSerializerContext.Default.FrameStartedLoadingCdpEventArgs);

    /// <summary>
    /// Fired when frame has stopped loading.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FrameStoppedLoadingEventArgs>> FrameStoppedLoading { get; } =
        EventDescriptor<CdpEventArgs<FrameStoppedLoadingEventArgs>>.Create(
            "goog:cdp.Page.frameStoppedLoading",
            PageJsonSerializerContext.Default.FrameStoppedLoadingCdpEventArgs);

    /// <summary>
    /// Fired when page is about to start a download.
    /// Deprecated. Use Browser.downloadWillBegin instead.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DownloadWillBeginEventArgs>> DownloadWillBegin { get; } =
        EventDescriptor<CdpEventArgs<DownloadWillBeginEventArgs>>.Create(
            "goog:cdp.Page.downloadWillBegin",
            PageJsonSerializerContext.Default.DownloadWillBeginCdpEventArgs);

    /// <summary>
    /// Fired when download makes progress. Last call has |done| == true.
    /// Deprecated. Use Browser.downloadProgress instead.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DownloadProgressEventArgs>> DownloadProgress { get; } =
        EventDescriptor<CdpEventArgs<DownloadProgressEventArgs>>.Create(
            "goog:cdp.Page.downloadProgress",
            PageJsonSerializerContext.Default.DownloadProgressCdpEventArgs);

    /// <summary>
    /// Fired when interstitial page was hidden
    /// </summary>
    public static EventDescriptor<CdpEventArgs<InterstitialHiddenEventArgs>> InterstitialHidden { get; } =
        EventDescriptor<CdpEventArgs<InterstitialHiddenEventArgs>>.Create(
            "goog:cdp.Page.interstitialHidden",
            PageJsonSerializerContext.Default.InterstitialHiddenCdpEventArgs);

    /// <summary>
    /// Fired when interstitial page was shown
    /// </summary>
    public static EventDescriptor<CdpEventArgs<InterstitialShownEventArgs>> InterstitialShown { get; } =
        EventDescriptor<CdpEventArgs<InterstitialShownEventArgs>>.Create(
            "goog:cdp.Page.interstitialShown",
            PageJsonSerializerContext.Default.InterstitialShownCdpEventArgs);

    /// <summary>
    /// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) has been
    /// closed.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<JavascriptDialogClosedEventArgs>> JavascriptDialogClosed { get; } =
        EventDescriptor<CdpEventArgs<JavascriptDialogClosedEventArgs>>.Create(
            "goog:cdp.Page.javascriptDialogClosed",
            PageJsonSerializerContext.Default.JavascriptDialogClosedCdpEventArgs);

    /// <summary>
    /// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) is about to
    /// open.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<JavascriptDialogOpeningEventArgs>> JavascriptDialogOpening { get; } =
        EventDescriptor<CdpEventArgs<JavascriptDialogOpeningEventArgs>>.Create(
            "goog:cdp.Page.javascriptDialogOpening",
            PageJsonSerializerContext.Default.JavascriptDialogOpeningCdpEventArgs);

    /// <summary>
    /// Fired for lifecycle events (navigation, load, paint, etc) in the current
    /// target (including local frames).
    /// </summary>
    public static EventDescriptor<CdpEventArgs<LifecycleEventEventArgs>> LifecycleEvent { get; } =
        EventDescriptor<CdpEventArgs<LifecycleEventEventArgs>>.Create(
            "goog:cdp.Page.lifecycleEvent",
            PageJsonSerializerContext.Default.LifecycleEventCdpEventArgs);

    /// <summary>
    /// Fired for failed bfcache history navigations if BackForwardCache feature is enabled. Do
    /// not assume any ordering with the Page.frameNavigated event. This event is fired only for
    /// main-frame history navigation where the document changes (non-same-document navigations),
    /// when bfcache navigation fails.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<BackForwardCacheNotUsedEventArgs>> BackForwardCacheNotUsed { get; } =
        EventDescriptor<CdpEventArgs<BackForwardCacheNotUsedEventArgs>>.Create(
            "goog:cdp.Page.backForwardCacheNotUsed",
            PageJsonSerializerContext.Default.BackForwardCacheNotUsedCdpEventArgs);

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<LoadEventFiredEventArgs>> LoadEventFired { get; } =
        EventDescriptor<CdpEventArgs<LoadEventFiredEventArgs>>.Create(
            "goog:cdp.Page.loadEventFired",
            PageJsonSerializerContext.Default.LoadEventFiredCdpEventArgs);

    /// <summary>
    /// Fired when same-document navigation happens, e.g. due to history API usage or anchor navigation.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<NavigatedWithinDocumentEventArgs>> NavigatedWithinDocument { get; } =
        EventDescriptor<CdpEventArgs<NavigatedWithinDocumentEventArgs>>.Create(
            "goog:cdp.Page.navigatedWithinDocument",
            PageJsonSerializerContext.Default.NavigatedWithinDocumentCdpEventArgs);

    /// <summary>
    /// Compressed image data requested by the <b>startScreencast</b>.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ScreencastFrameEventArgs>> ScreencastFrame { get; } =
        EventDescriptor<CdpEventArgs<ScreencastFrameEventArgs>>.Create(
            "goog:cdp.Page.screencastFrame",
            PageJsonSerializerContext.Default.ScreencastFrameCdpEventArgs);

    /// <summary>
    /// Fired when the page with currently enabled screencast was shown or hidden `.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ScreencastVisibilityChangedEventArgs>> ScreencastVisibilityChanged { get; } =
        EventDescriptor<CdpEventArgs<ScreencastVisibilityChangedEventArgs>>.Create(
            "goog:cdp.Page.screencastVisibilityChanged",
            PageJsonSerializerContext.Default.ScreencastVisibilityChangedCdpEventArgs);

    /// <summary>
    /// Fired when a new window is going to be opened, via window.open(), link click, form submission,
    /// etc.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<WindowOpenEventArgs>> WindowOpen { get; } =
        EventDescriptor<CdpEventArgs<WindowOpenEventArgs>>.Create(
            "goog:cdp.Page.windowOpen",
            PageJsonSerializerContext.Default.WindowOpenCdpEventArgs);

    /// <summary>
    /// Issued for every compilation cache generated.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<CompilationCacheProducedEventArgs>> CompilationCacheProduced { get; } =
        EventDescriptor<CdpEventArgs<CompilationCacheProducedEventArgs>>.Create(
            "goog:cdp.Page.compilationCacheProduced",
            PageJsonSerializerContext.Default.CompilationCacheProducedCdpEventArgs);

}
