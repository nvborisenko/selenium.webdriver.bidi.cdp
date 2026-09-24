#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Page;

/// <summary>
/// Actions and events related to the inspected page belong to the page domain.
/// </summary>
public interface IPage
{
    /// <summary>
    /// Deprecated, please use addScriptToEvaluateOnNewDocument instead.
    /// </summary>
    /// <param name="scriptSource">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AddScriptToEvaluateOnLoadResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    Task<AddScriptToEvaluateOnLoadResult> AddScriptToEvaluateOnLoadAsync(string scriptSource, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Evaluates given script in every frame upon creation (before loading frame's scripts).
    /// </summary>
    /// <param name="source">
    /// </param>
    /// <param name="worldName">
    /// If specified, creates an isolated world with the given name and evaluates given script in it.
    /// This world name will be used as the ExecutionContextDescription::name when the corresponding
    /// event is emitted.
    /// </param>
    /// <param name="includeCommandLineAPI">
    /// Specifies whether command line API should be available to the script, defaults
    /// to false.
    /// </param>
    /// <param name="runImmediately">
    /// If true, runs the script immediately on existing execution contexts or worlds.
    /// Default: false.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AddScriptToEvaluateOnNewDocumentResult"/>.
    /// </returns>
    Task<AddScriptToEvaluateOnNewDocumentResult> AddScriptToEvaluateOnNewDocumentAsync(string source, string? worldName = null, bool? includeCommandLineAPI = null, bool? runImmediately = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Brings page to front (activates tab).
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="BringToFrontResult"/>.
    /// </returns>
    Task<BringToFrontResult> BringToFrontAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Capture page screenshot.
    /// </summary>
    /// <param name="format">
    /// Image compression format (defaults to png).
    /// </param>
    /// <param name="quality">
    /// Compression quality from range [0..100] (jpeg only).
    /// </param>
    /// <param name="clip">
    /// Capture the screenshot of a given region only.
    /// </param>
    /// <param name="fromSurface">
    /// Capture the screenshot from the surface, rather than the view. Defaults to true.
    /// </param>
    /// <param name="captureBeyondViewport">
    /// Capture the screenshot beyond the viewport. Defaults to false.
    /// </param>
    /// <param name="optimizeForSpeed">
    /// Optimize image encoding for speed, not for resulting size (defaults to false)
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CaptureScreenshotResult"/>.
    /// </returns>
    Task<CaptureScreenshotResult> CaptureScreenshotAsync(CaptureScreenshotFormat? format = null, long? quality = null, Viewport? clip = null, bool? fromSurface = null, bool? captureBeyondViewport = null, bool? optimizeForSpeed = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns a snapshot of the page as a string. For MHTML format, the serialization includes
    /// iframes, shadow DOM, external resources, and element-inline styles.
    /// </summary>
    /// <param name="format">
    /// Format (defaults to mhtml).
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
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<CaptureSnapshotResult> CaptureSnapshotAsync(CaptureSnapshotFormat? format = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Clears the overridden device metrics.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearDeviceMetricsOverrideResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    Task<ClearDeviceMetricsOverrideResult> ClearDeviceMetricsOverrideAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Clears the overridden Device Orientation.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearDeviceOrientationOverrideResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    Task<ClearDeviceOrientationOverrideResult> ClearDeviceOrientationOverrideAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Clears the overridden Geolocation Position and Error.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearGeolocationOverrideResult"/>.
    /// </returns>
    [global::System.Obsolete]
    Task<ClearGeolocationOverrideResult> ClearGeolocationOverrideAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates an isolated world for the given frame.
    /// </summary>
    /// <param name="frameId">
    /// Id of the frame in which the isolated world should be created.
    /// </param>
    /// <param name="worldName">
    /// An optional name which is reported in the Execution Context.
    /// </param>
    /// <param name="grantUniveralAccess">
    /// Whether or not universal access should be granted to the isolated world. This is a powerful
    /// option, use with caution.
    /// </param>
    /// <param name="contentSecurityPolicy">
    /// An optional content security policy to set for the isolated world.
    /// If omitted, any existing CSP for the world will be cleared.
    /// Note that clearing or updating the CSP does not immediately affect the active
    /// context in the same document because LocalDOMWindow caches the
    /// ContentSecurityPolicy object. The change takes effect on subsequent
    /// navigations when a new window context is created.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CreateIsolatedWorldResult"/>.
    /// </returns>
    Task<CreateIsolatedWorldResult> CreateIsolatedWorldAsync(FrameId frameId, string? worldName = null, bool? grantUniveralAccess = null, string? contentSecurityPolicy = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes browser cookie with given name, domain and path.
    /// </summary>
    /// <param name="cookieName">
    /// Name of the cookie to remove.
    /// </param>
    /// <param name="url">
    /// URL to match cooke domain and path.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DeleteCookieResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    Task<DeleteCookieResult> DeleteCookieAsync(string cookieName, string url, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disables page domain notifications.
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
    /// Enables page domain notifications.
    /// </summary>
    /// <param name="enableFileChooserOpenedEvent">
    /// If true, the <b>Page.fileChooserOpened</b> event will be emitted regardless of the state set by
    /// <b>Page.setInterceptFileChooserDialog</b> command (default: false).
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
    Task<EnableResult> EnableAsync(bool? enableFileChooserOpenedEvent = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the processed manifest for this current document.
    ///   This API always waits for the manifest to be loaded.
    ///   If manifestId is provided, and it does not match the manifest of the
    ///     current document, this API errors out.
    ///   If there is not a loaded page, this API errors out immediately.
    /// </summary>
    /// <param name="manifestId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetAppManifestResult"/>.
    /// </returns>
    Task<GetAppManifestResult> GetAppManifestAsync(string? manifestId = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetInstallabilityErrorsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetInstallabilityErrorsResult> GetInstallabilityErrorsAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deprecated because it's not guaranteed that the returned icon is in fact the one used for PWA installation.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetManifestIconsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    Task<GetManifestIconsResult> GetManifestIconsAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the unique (PWA) app id, along with IWA bundle ID and parent app info.
    /// Only returns values if the feature flag 'WebAppEnableManifestId' is enabled
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetAppIdResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetAppIdResult> GetAppIdAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the list of installed child Sub-Apps for the inspected parent app.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetSubAppsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetSubAppsResult> GetSubAppsAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the list of sibling Sub-Apps sharing the same parent app if the inspected context is a Sub-App.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetSiblingSubAppsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetSiblingSubAppsResult> GetSiblingSubAppsAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
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
    /// A task representing the asynchronous operation, containing a <see cref="GetAdScriptAncestryResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetAdScriptAncestryResult> GetAdScriptAncestryAsync(FrameId frameId, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns present frame tree structure.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetFrameTreeResult"/>.
    /// </returns>
    Task<GetFrameTreeResult> GetFrameTreeAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns metrics relating to the layouting of the page, such as viewport bounds/scale.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetLayoutMetricsResult"/>.
    /// </returns>
    Task<GetLayoutMetricsResult> GetLayoutMetricsAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns navigation history for the current page.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetNavigationHistoryResult"/>.
    /// </returns>
    Task<GetNavigationHistoryResult> GetNavigationHistoryAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Resets navigation history for the current page.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ResetNavigationHistoryResult"/>.
    /// </returns>
    Task<ResetNavigationHistoryResult> ResetNavigationHistoryAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns content of the given resource.
    /// </summary>
    /// <param name="frameId">
    /// Frame id to get resource for.
    /// </param>
    /// <param name="url">
    /// URL of the resource to get content for.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetResourceContentResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetResourceContentResult> GetResourceContentAsync(FrameId frameId, string url, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns present frame / resource tree structure.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetResourceTreeResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetResourceTreeResult> GetResourceTreeAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Accepts or dismisses a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload).
    /// </summary>
    /// <param name="accept">
    /// Whether to accept or dismiss the dialog.
    /// </param>
    /// <param name="promptText">
    /// The text to enter into the dialog prompt before accepting. Used only if this is a prompt
    /// dialog.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="HandleJavaScriptDialogResult"/>.
    /// </returns>
    Task<HandleJavaScriptDialogResult> HandleJavaScriptDialogAsync(bool accept, string? promptText = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Navigates current page to the given URL.
    /// </summary>
    /// <param name="url">
    /// URL to navigate the page to.
    /// </param>
    /// <param name="referrer">
    /// Referrer URL.
    /// </param>
    /// <param name="transitionType">
    /// Intended transition type.
    /// </param>
    /// <param name="frameId">
    /// Frame id to navigate, if not specified navigates the top frame.
    /// </param>
    /// <param name="referrerPolicy">
    /// Referrer-policy used for the navigation.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="NavigateResult"/>.
    /// </returns>
    Task<NavigateResult> NavigateAsync(string url, string? referrer = null, TransitionType? transitionType = null, FrameId? frameId = null, ReferrerPolicy? referrerPolicy = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Navigates current page to the given history entry.
    /// </summary>
    /// <param name="entryId">
    /// Unique id of the entry to navigate to.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="NavigateToHistoryEntryResult"/>.
    /// </returns>
    Task<NavigateToHistoryEntryResult> NavigateToHistoryEntryAsync(long entryId, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Print page as PDF.
    /// </summary>
    /// <param name="landscape">
    /// Paper orientation. Defaults to false.
    /// </param>
    /// <param name="displayHeaderFooter">
    /// Display header and footer. Defaults to false.
    /// </param>
    /// <param name="printBackground">
    /// Print background graphics. Defaults to false.
    /// </param>
    /// <param name="scale">
    /// Scale of the webpage rendering. Defaults to 1.
    /// </param>
    /// <param name="paperWidth">
    /// Paper width in inches. Defaults to 8.5 inches.
    /// </param>
    /// <param name="paperHeight">
    /// Paper height in inches. Defaults to 11 inches.
    /// </param>
    /// <param name="marginTop">
    /// Top margin in inches. Defaults to 1cm (~0.4 inches).
    /// </param>
    /// <param name="marginBottom">
    /// Bottom margin in inches. Defaults to 1cm (~0.4 inches).
    /// </param>
    /// <param name="marginLeft">
    /// Left margin in inches. Defaults to 1cm (~0.4 inches).
    /// </param>
    /// <param name="marginRight">
    /// Right margin in inches. Defaults to 1cm (~0.4 inches).
    /// </param>
    /// <param name="pageRanges">
    /// Paper ranges to print, one based, e.g., '1-5, 8, 11-13'. Pages are
    /// printed in the document order, not in the order specified, and no
    /// more than once.
    /// Defaults to empty string, which implies the entire document is printed.
    /// The page numbers are quietly capped to actual page count of the
    /// document, and ranges beyond the end of the document are ignored.
    /// If this results in no pages to print, an error is reported.
    /// It is an error to specify a range with start greater than end.
    /// </param>
    /// <param name="headerTemplate">
    /// HTML template for the print header. Should be valid HTML markup with following
    /// classes used to inject printing values into them:
    /// - <b>date</b>: formatted print date
    /// - <b>title</b>: document title
    /// - <b>url</b>: document location
    /// - <b>pageNumber</b>: current page number
    /// - <b>totalPages</b>: total pages in the document
    /// 
    /// For example, <b>&lt;span class=title&gt;&lt;/span&gt;</b> would generate span containing the title.
    /// </param>
    /// <param name="footerTemplate">
    /// HTML template for the print footer. Should use the same format as the <b>headerTemplate</b>.
    /// </param>
    /// <param name="preferCSSPageSize">
    /// Whether or not to prefer page size as defined by css. Defaults to false,
    /// in which case the content will be scaled to fit the paper size.
    /// </param>
    /// <param name="transferMode">
    /// return as stream
    /// </param>
    /// <param name="generateTaggedPDF">
    /// Whether or not to generate tagged (accessible) PDF. Defaults to embedder choice.
    /// </param>
    /// <param name="generateDocumentOutline">
    /// Whether or not to embed the document outline into the PDF.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="PrintToPDFResult"/>.
    /// </returns>
    Task<PrintToPDFResult> PrintToPDFAsync(bool? landscape = null, bool? displayHeaderFooter = null, bool? printBackground = null, double? scale = null, double? paperWidth = null, double? paperHeight = null, double? marginTop = null, double? marginBottom = null, double? marginLeft = null, double? marginRight = null, string? pageRanges = null, string? headerTemplate = null, string? footerTemplate = null, bool? preferCSSPageSize = null, PrintToPDFTransferMode? transferMode = null, bool? generateTaggedPDF = null, bool? generateDocumentOutline = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Reloads given page optionally ignoring the cache.
    /// </summary>
    /// <param name="ignoreCache">
    /// If true, browser cache is ignored (as if the user pressed Shift+refresh).
    /// </param>
    /// <param name="scriptToEvaluateOnLoad">
    /// If set, the script will be injected into all frames of the inspected page after reload.
    /// Argument will be ignored if reloading dataURL origin.
    /// </param>
    /// <param name="loaderId">
    /// If set, an error will be thrown if the target page's main frame's
    /// loader id does not match the provided id. This prevents accidentally
    /// reloading an unintended target in case there's a racing navigation.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ReloadResult"/>.
    /// </returns>
    Task<ReloadResult> ReloadAsync(bool? ignoreCache = null, string? scriptToEvaluateOnLoad = null, Network.LoaderId? loaderId = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deprecated, please use removeScriptToEvaluateOnNewDocument instead.
    /// </summary>
    /// <param name="identifier">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RemoveScriptToEvaluateOnLoadResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    Task<RemoveScriptToEvaluateOnLoadResult> RemoveScriptToEvaluateOnLoadAsync(ScriptIdentifier identifier, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Removes given script from the list.
    /// </summary>
    /// <param name="identifier">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RemoveScriptToEvaluateOnNewDocumentResult"/>.
    /// </returns>
    Task<RemoveScriptToEvaluateOnNewDocumentResult> RemoveScriptToEvaluateOnNewDocumentAsync(ScriptIdentifier identifier, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Acknowledges that a screencast frame has been received by the frontend.
    /// </summary>
    /// <param name="sessionId">
    /// Frame number.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ScreencastFrameAckResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<ScreencastFrameAckResult> ScreencastFrameAckAsync(long sessionId, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Searches for given string in resource content.
    /// </summary>
    /// <param name="frameId">
    /// Frame id for resource to search in.
    /// </param>
    /// <param name="url">
    /// URL of the resource to search in.
    /// </param>
    /// <param name="query">
    /// String to search for.
    /// </param>
    /// <param name="caseSensitive">
    /// If true, search is case sensitive.
    /// </param>
    /// <param name="isRegex">
    /// If true, treats string parameter as regex.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SearchInResourceResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<SearchInResourceResult> SearchInResourceAsync(FrameId frameId, string url, string query, bool? caseSensitive = null, bool? isRegex = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Enable Chrome's experimental ad filter on all sites.
    /// </summary>
    /// <param name="enabled">
    /// Whether to block ads.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetAdBlockingEnabledResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<SetAdBlockingEnabledResult> SetAdBlockingEnabledAsync(bool enabled, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Enable page Content Security Policy by-passing.
    /// </summary>
    /// <param name="enabled">
    /// Whether to bypass page CSP.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetBypassCSPResult"/>.
    /// </returns>
    Task<SetBypassCSPResult> SetBypassCSPAsync(bool enabled, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Permissions Policy state on given frame.
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
    /// A task representing the asynchronous operation, containing a <see cref="GetPermissionsPolicyStateResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetPermissionsPolicyStateResult> GetPermissionsPolicyStateAsync(FrameId frameId, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get Origin Trials on given frame.
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
    /// A task representing the asynchronous operation, containing a <see cref="GetOriginTrialsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetOriginTrialsResult> GetOriginTrialsAsync(FrameId frameId, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Overrides the values of device screen dimensions (window.screen.width, window.screen.height,
    /// window.innerWidth, window.innerHeight, and "device-width"/"device-height"-related CSS media
    /// query results).
    /// </summary>
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
    /// <param name="scale">
    /// Scale to apply to resulting view image.
    /// </param>
    /// <param name="screenWidth">
    /// Overriding screen width value in pixels (minimum 0, maximum 10000000).
    /// </param>
    /// <param name="screenHeight">
    /// Overriding screen height value in pixels (minimum 0, maximum 10000000).
    /// </param>
    /// <param name="positionX">
    /// Overriding view X position on screen in pixels (minimum 0, maximum 10000000).
    /// </param>
    /// <param name="positionY">
    /// Overriding view Y position on screen in pixels (minimum 0, maximum 10000000).
    /// </param>
    /// <param name="dontSetVisibleSize">
    /// Do not set visible view size, rely upon explicit setVisibleSize call.
    /// </param>
    /// <param name="screenOrientation">
    /// Screen orientation override.
    /// </param>
    /// <param name="viewport">
    /// The viewport dimensions and scale. If not set, the override is cleared.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetDeviceMetricsOverrideResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    Task<SetDeviceMetricsOverrideResult> SetDeviceMetricsOverrideAsync(long width, long height, double deviceScaleFactor, bool mobile, double? scale = null, long? screenWidth = null, long? screenHeight = null, long? positionX = null, long? positionY = null, bool? dontSetVisibleSize = null, Emulation.ScreenOrientation? screenOrientation = null, Viewport? viewport = null, string? session = null, CancellationToken cancellationToken = default);

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
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetDeviceOrientationOverrideResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    Task<SetDeviceOrientationOverrideResult> SetDeviceOrientationOverrideAsync(double alpha, double beta, double gamma, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Set generic font families.
    /// </summary>
    /// <param name="fontFamilies">
    /// Specifies font families to set. If a font family is not specified, it won't be changed.
    /// </param>
    /// <param name="forScripts">
    /// Specifies font families to set for individual scripts.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetFontFamiliesResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<SetFontFamiliesResult> SetFontFamiliesAsync(FontFamilies fontFamilies, ImmutableArray<ScriptFontFamilies>? forScripts = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Set default font sizes.
    /// </summary>
    /// <param name="fontSizes">
    /// Specifies font sizes to set. If a font size is not specified, it won't be changed.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetFontSizesResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<SetFontSizesResult> SetFontSizesAsync(FontSizes fontSizes, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Sets given markup as the document's HTML.
    /// </summary>
    /// <param name="frameId">
    /// Frame id to set HTML for.
    /// </param>
    /// <param name="html">
    /// HTML content to set.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetDocumentContentResult"/>.
    /// </returns>
    Task<SetDocumentContentResult> SetDocumentContentAsync(FrameId frameId, string html, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Set the behavior when downloading a file.
    /// </summary>
    /// <param name="behavior">
    /// Whether to allow all or deny all download requests, or use default Chrome behavior if
    /// available (otherwise deny).
    /// </param>
    /// <param name="downloadPath">
    /// The default path to save downloaded files to. This is required if behavior is set to 'allow'
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetDownloadBehaviorResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    Task<SetDownloadBehaviorResult> SetDownloadBehaviorAsync(SetDownloadBehaviorBehavior behavior, string? downloadPath = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Overrides the Geolocation Position or Error. Omitting any of the parameters emulates position
    /// unavailable.
    /// </summary>
    /// <param name="latitude">
    /// Mock latitude
    /// </param>
    /// <param name="longitude">
    /// Mock longitude
    /// </param>
    /// <param name="accuracy">
    /// Mock accuracy
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetGeolocationOverrideResult"/>.
    /// </returns>
    [global::System.Obsolete]
    Task<SetGeolocationOverrideResult> SetGeolocationOverrideAsync(double? latitude = null, double? longitude = null, double? accuracy = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Controls whether page will emit lifecycle events.
    /// </summary>
    /// <param name="enabled">
    /// If true, starts emitting lifecycle events.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetLifecycleEventsEnabledResult"/>.
    /// </returns>
    Task<SetLifecycleEventsEnabledResult> SetLifecycleEventsEnabledAsync(bool enabled, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Toggles mouse event-based touch event emulation.
    /// </summary>
    /// <param name="enabled">
    /// Whether the touch event emulation should be enabled.
    /// </param>
    /// <param name="configuration">
    /// Touch/gesture events configuration. Default: current platform.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetTouchEmulationEnabledResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    Task<SetTouchEmulationEnabledResult> SetTouchEmulationEnabledAsync(bool enabled, SetTouchEmulationEnabledConfiguration? configuration = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Starts sending each frame using the <b>screencastFrame</b> event.
    /// </summary>
    /// <param name="format">
    /// Image compression format.
    /// </param>
    /// <param name="quality">
    /// Compression quality from range [0..100].
    /// </param>
    /// <param name="maxWidth">
    /// Maximum screenshot width.
    /// </param>
    /// <param name="maxHeight">
    /// Maximum screenshot height.
    /// </param>
    /// <param name="everyNthFrame">
    /// Send every n-th frame. Must be a positive integer.
    /// </param>
    /// <param name="maxFramesInFlight">
    /// Maximum number of frames sent until screencastFrameAck is required.
    /// Defaults to 3. Must be a positive integer.
    /// </param>
    /// <param name="sendLastFrame">
    /// By default, after screencastFrameAck arrives, the next produced frame is sent.
    /// Passing this flag enables storing the last produced frame in memory, which is
    /// immediately sent upon screencastFrameAck. This way, overall performance is
    /// traded for a better latency.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StartScreencastResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<StartScreencastResult> StartScreencastAsync(StartScreencastFormat? format = null, long? quality = null, long? maxWidth = null, long? maxHeight = null, long? everyNthFrame = null, long? maxFramesInFlight = null, bool? sendLastFrame = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Starts screencast video recording.
    /// </summary>
    /// <param name="audio">
    /// </param>
    /// <param name="maxWidth">
    /// Maximum frame width in pixels.
    /// </param>
    /// <param name="maxHeight">
    /// Maximum frame height in pixels.
    /// </param>
    /// <param name="frameRate">
    /// Maximum frame rate in frames per second.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StartScreenRecordingResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<StartScreenRecordingResult> StartScreenRecordingAsync(bool? audio = null, long? maxWidth = null, long? maxHeight = null, long? frameRate = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Stops screencast video recording.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StopScreenRecordingResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<StopScreenRecordingResult> StopScreenRecordingAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Force the page stop all navigations and pending resource fetches.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StopLoadingResult"/>.
    /// </returns>
    Task<StopLoadingResult> StopLoadingAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Crashes renderer on the IO thread, generates minidumps.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CrashResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<CrashResult> CrashAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Tries to close page, running its beforeunload hooks, if any.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CloseResult"/>.
    /// </returns>
    Task<CloseResult> CloseAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Tries to update the web lifecycle state of the page.
    /// It will transition the page to the given state according to:
    /// https://github.com/WICG/web-lifecycle/
    /// </summary>
    /// <param name="state">
    /// Target lifecycle state
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetWebLifecycleStateResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<SetWebLifecycleStateResult> SetWebLifecycleStateAsync(SetWebLifecycleStateState state, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Stops sending each frame in the <b>screencastFrame</b>.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StopScreencastResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<StopScreencastResult> StopScreencastAsync(string? session = null, CancellationToken cancellationToken = default);

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
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ProduceCompilationCacheResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<ProduceCompilationCacheResult> ProduceCompilationCacheAsync(ImmutableArray<CompilationCacheParams> scripts, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Seeds compilation cache for given url. Compilation cache does not survive
    /// cross-process navigation.
    /// </summary>
    /// <param name="url">
    /// </param>
    /// <param name="data">
    /// Base64-encoded data (Encoded as a base64 string when passed over JSON)
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AddCompilationCacheResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<AddCompilationCacheResult> AddCompilationCacheAsync(string url, string data, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Clears seeded compilation cache.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearCompilationCacheResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<ClearCompilationCacheResult> ClearCompilationCacheAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Sets the Secure Payment Confirmation transaction mode.
    /// https://w3c.github.io/secure-payment-confirmation/#sctn-automation-set-spc-transaction-mode
    /// </summary>
    /// <param name="mode">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetSPCTransactionModeResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<SetSPCTransactionModeResult> SetSPCTransactionModeAsync(SetSPCTransactionModeMode mode, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Extensions for Custom Handlers API:
    /// https://html.spec.whatwg.org/multipage/system-state.html#rph-automation
    /// </summary>
    /// <param name="mode">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetRPHRegistrationModeResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<SetRPHRegistrationModeResult> SetRPHRegistrationModeAsync(SetRPHRegistrationModeMode mode, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Generates a report for testing.
    /// </summary>
    /// <param name="message">
    /// Message to be displayed in the report.
    /// </param>
    /// <param name="group">
    /// Specifies the endpoint group to deliver the report to.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GenerateTestReportResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GenerateTestReportResult> GenerateTestReportAsync(string message, string? group = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Pauses page execution. Can be resumed using generic Runtime.runIfWaitingForDebugger.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="WaitForDebuggerResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<WaitForDebuggerResult> WaitForDebuggerAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Intercept file chooser requests and transfer control to protocol clients.
    /// When file chooser interception is enabled, native file chooser dialog is not shown.
    /// Instead, a protocol event <b>Page.fileChooserOpened</b> is emitted.
    /// </summary>
    /// <param name="enabled">
    /// </param>
    /// <param name="cancel">
    /// If true, cancels the dialog by emitting relevant events (if any)
    /// in addition to not showing it if the interception is enabled
    /// (default: false).
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetInterceptFileChooserDialogResult"/>.
    /// </returns>
    Task<SetInterceptFileChooserDialogResult> SetInterceptFileChooserDialogAsync(bool enabled, bool? cancel = null, string? session = null, CancellationToken cancellationToken = default);

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
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetPrerenderingAllowedResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<SetPrerenderingAllowedResult> SetPrerenderingAllowedAsync(bool isAllowed, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get the annotated page content for the main frame.
    /// This is an experimental command that is subject to change.
    /// </summary>
    /// <param name="includeActionableInformation">
    /// Whether to include actionable information. Defaults to true.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetAnnotatedPageContentResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    Task<GetAnnotatedPageContentResult> GetAnnotatedPageContentAsync(bool? includeActionableInformation = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DomContentEventFiredEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Timestamp</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<DomContentEventFiredEventArgs> DomContentEventFired { get; }

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
    IEventSource<FileChooserOpenedEventArgs> FileChooserOpened { get; }

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
    IEventSource<FrameAttachedEventArgs> FrameAttached { get; }

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
    IEventSource<FrameClearedScheduledNavigationEventArgs> FrameClearedScheduledNavigation { get; }

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
    IEventSource<FrameDetachedEventArgs> FrameDetached { get; }

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
    IEventSource<FrameSubtreeWillBeDetachedEventArgs> FrameSubtreeWillBeDetached { get; }

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
    IEventSource<FrameNavigatedEventArgs> FrameNavigated { get; }

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
    IEventSource<DocumentOpenedEventArgs> DocumentOpened { get; }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    IEventSource<FrameResizedEventArgs> FrameResized { get; }

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
    IEventSource<FrameStartedNavigatingEventArgs> FrameStartedNavigating { get; }

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
    IEventSource<FrameRequestedNavigationEventArgs> FrameRequestedNavigation { get; }

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
    IEventSource<FrameScheduledNavigationEventArgs> FrameScheduledNavigation { get; }

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
    IEventSource<FrameStartedLoadingEventArgs> FrameStartedLoading { get; }

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
    IEventSource<FrameStoppedLoadingEventArgs> FrameStoppedLoading { get; }

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
    IEventSource<DownloadWillBeginEventArgs> DownloadWillBegin { get; }

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
    IEventSource<DownloadProgressEventArgs> DownloadProgress { get; }

    /// <summary>
    /// Fired when interstitial page was hidden
    /// </summary>
    IEventSource<InterstitialHiddenEventArgs> InterstitialHidden { get; }

    /// <summary>
    /// Fired when interstitial page was shown
    /// </summary>
    IEventSource<InterstitialShownEventArgs> InterstitialShown { get; }

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
    IEventSource<JavascriptDialogClosedEventArgs> JavascriptDialogClosed { get; }

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
    IEventSource<JavascriptDialogOpeningEventArgs> JavascriptDialogOpening { get; }

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
    IEventSource<LifecycleEventEventArgs> LifecycleEvent { get; }

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
    IEventSource<BackForwardCacheNotUsedEventArgs> BackForwardCacheNotUsed { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="LoadEventFiredEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Timestamp</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<LoadEventFiredEventArgs> LoadEventFired { get; }

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
    IEventSource<NavigatedWithinDocumentEventArgs> NavigatedWithinDocument { get; }

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
    IEventSource<ScreencastFrameEventArgs> ScreencastFrame { get; }

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
    IEventSource<ScreencastVisibilityChangedEventArgs> ScreencastVisibilityChanged { get; }

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
    IEventSource<WindowOpenEventArgs> WindowOpen { get; }

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
    IEventSource<CompilationCacheProducedEventArgs> CompilationCacheProduced { get; }

}

internal sealed class PageDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), IPage
{
    private static readonly PageJsonSerializerContext JsonContext = PageJsonSerializerContext.Default;

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<AddScriptToEvaluateOnLoadResult> AddScriptToEvaluateOnLoadAsync(string scriptSource, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new AddScriptToEvaluateOnLoadCommandParameters(ScriptSource: scriptSource);
        return await ExecuteCommandAsync("Page.addScriptToEvaluateOnLoad", @params, JsonContext.AddScriptToEvaluateOnLoadCommandParameters, JsonContext.AddScriptToEvaluateOnLoadResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<AddScriptToEvaluateOnNewDocumentResult> AddScriptToEvaluateOnNewDocumentAsync(string source, string? worldName = null, bool? includeCommandLineAPI = null, bool? runImmediately = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new AddScriptToEvaluateOnNewDocumentCommandParameters(Source: source, WorldName: worldName, IncludeCommandLineAPI: includeCommandLineAPI, RunImmediately: runImmediately);
        return await ExecuteCommandAsync("Page.addScriptToEvaluateOnNewDocument", @params, JsonContext.AddScriptToEvaluateOnNewDocumentCommandParameters, JsonContext.AddScriptToEvaluateOnNewDocumentResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<BringToFrontResult> BringToFrontAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new BringToFrontCommandParameters();
        return await ExecuteCommandAsync("Page.bringToFront", @params, JsonContext.BringToFrontCommandParameters, JsonContext.BringToFrontResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<CaptureScreenshotResult> CaptureScreenshotAsync(CaptureScreenshotFormat? format = null, long? quality = null, Viewport? clip = null, bool? fromSurface = null, bool? captureBeyondViewport = null, bool? optimizeForSpeed = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new CaptureScreenshotCommandParameters(Format: format, Quality: quality, Clip: clip, FromSurface: fromSurface, CaptureBeyondViewport: captureBeyondViewport, OptimizeForSpeed: optimizeForSpeed);
        return await ExecuteCommandAsync("Page.captureScreenshot", @params, JsonContext.CaptureScreenshotCommandParameters, JsonContext.CaptureScreenshotResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<CaptureSnapshotResult> CaptureSnapshotAsync(CaptureSnapshotFormat? format = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new CaptureSnapshotCommandParameters(Format: format);
        return await ExecuteCommandAsync("Page.captureSnapshot", @params, JsonContext.CaptureSnapshotCommandParameters, JsonContext.CaptureSnapshotResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<ClearDeviceMetricsOverrideResult> ClearDeviceMetricsOverrideAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new ClearDeviceMetricsOverrideCommandParameters();
        return await ExecuteCommandAsync("Page.clearDeviceMetricsOverride", @params, JsonContext.ClearDeviceMetricsOverrideCommandParameters, JsonContext.ClearDeviceMetricsOverrideResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<ClearDeviceOrientationOverrideResult> ClearDeviceOrientationOverrideAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new ClearDeviceOrientationOverrideCommandParameters();
        return await ExecuteCommandAsync("Page.clearDeviceOrientationOverride", @params, JsonContext.ClearDeviceOrientationOverrideCommandParameters, JsonContext.ClearDeviceOrientationOverrideResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Obsolete]
    public async Task<ClearGeolocationOverrideResult> ClearGeolocationOverrideAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new ClearGeolocationOverrideCommandParameters();
        return await ExecuteCommandAsync("Page.clearGeolocationOverride", @params, JsonContext.ClearGeolocationOverrideCommandParameters, JsonContext.ClearGeolocationOverrideResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<CreateIsolatedWorldResult> CreateIsolatedWorldAsync(FrameId frameId, string? worldName = null, bool? grantUniveralAccess = null, string? contentSecurityPolicy = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new CreateIsolatedWorldCommandParameters(FrameId: frameId, WorldName: worldName, GrantUniveralAccess: grantUniveralAccess, ContentSecurityPolicy: contentSecurityPolicy);
        return await ExecuteCommandAsync("Page.createIsolatedWorld", @params, JsonContext.CreateIsolatedWorldCommandParameters, JsonContext.CreateIsolatedWorldResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<DeleteCookieResult> DeleteCookieAsync(string cookieName, string url, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new DeleteCookieCommandParameters(CookieName: cookieName, Url: url);
        return await ExecuteCommandAsync("Page.deleteCookie", @params, JsonContext.DeleteCookieCommandParameters, JsonContext.DeleteCookieResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<DisableResult> DisableAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync("Page.disable", @params, JsonContext.DisableCommandParameters, JsonContext.DisableResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<EnableResult> EnableAsync(bool? enableFileChooserOpenedEvent = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters(EnableFileChooserOpenedEvent: enableFileChooserOpenedEvent);
        return await ExecuteCommandAsync("Page.enable", @params, JsonContext.EnableCommandParameters, JsonContext.EnableResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<GetAppManifestResult> GetAppManifestAsync(string? manifestId = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetAppManifestCommandParameters(ManifestId: manifestId);
        return await ExecuteCommandAsync("Page.getAppManifest", @params, JsonContext.GetAppManifestCommandParameters, JsonContext.GetAppManifestResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetInstallabilityErrorsResult> GetInstallabilityErrorsAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetInstallabilityErrorsCommandParameters();
        return await ExecuteCommandAsync("Page.getInstallabilityErrors", @params, JsonContext.GetInstallabilityErrorsCommandParameters, JsonContext.GetInstallabilityErrorsResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<GetManifestIconsResult> GetManifestIconsAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetManifestIconsCommandParameters();
        return await ExecuteCommandAsync("Page.getManifestIcons", @params, JsonContext.GetManifestIconsCommandParameters, JsonContext.GetManifestIconsResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetAppIdResult> GetAppIdAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetAppIdCommandParameters();
        return await ExecuteCommandAsync("Page.getAppId", @params, JsonContext.GetAppIdCommandParameters, JsonContext.GetAppIdResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetSubAppsResult> GetSubAppsAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetSubAppsCommandParameters();
        return await ExecuteCommandAsync("Page.getSubApps", @params, JsonContext.GetSubAppsCommandParameters, JsonContext.GetSubAppsResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetSiblingSubAppsResult> GetSiblingSubAppsAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetSiblingSubAppsCommandParameters();
        return await ExecuteCommandAsync("Page.getSiblingSubApps", @params, JsonContext.GetSiblingSubAppsCommandParameters, JsonContext.GetSiblingSubAppsResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetAdScriptAncestryResult> GetAdScriptAncestryAsync(FrameId frameId, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetAdScriptAncestryCommandParameters(FrameId: frameId);
        return await ExecuteCommandAsync("Page.getAdScriptAncestry", @params, JsonContext.GetAdScriptAncestryCommandParameters, JsonContext.GetAdScriptAncestryResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<GetFrameTreeResult> GetFrameTreeAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetFrameTreeCommandParameters();
        return await ExecuteCommandAsync("Page.getFrameTree", @params, JsonContext.GetFrameTreeCommandParameters, JsonContext.GetFrameTreeResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<GetLayoutMetricsResult> GetLayoutMetricsAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetLayoutMetricsCommandParameters();
        return await ExecuteCommandAsync("Page.getLayoutMetrics", @params, JsonContext.GetLayoutMetricsCommandParameters, JsonContext.GetLayoutMetricsResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<GetNavigationHistoryResult> GetNavigationHistoryAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetNavigationHistoryCommandParameters();
        return await ExecuteCommandAsync("Page.getNavigationHistory", @params, JsonContext.GetNavigationHistoryCommandParameters, JsonContext.GetNavigationHistoryResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<ResetNavigationHistoryResult> ResetNavigationHistoryAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new ResetNavigationHistoryCommandParameters();
        return await ExecuteCommandAsync("Page.resetNavigationHistory", @params, JsonContext.ResetNavigationHistoryCommandParameters, JsonContext.ResetNavigationHistoryResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetResourceContentResult> GetResourceContentAsync(FrameId frameId, string url, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetResourceContentCommandParameters(FrameId: frameId, Url: url);
        return await ExecuteCommandAsync("Page.getResourceContent", @params, JsonContext.GetResourceContentCommandParameters, JsonContext.GetResourceContentResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetResourceTreeResult> GetResourceTreeAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetResourceTreeCommandParameters();
        return await ExecuteCommandAsync("Page.getResourceTree", @params, JsonContext.GetResourceTreeCommandParameters, JsonContext.GetResourceTreeResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<HandleJavaScriptDialogResult> HandleJavaScriptDialogAsync(bool accept, string? promptText = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new HandleJavaScriptDialogCommandParameters(Accept: accept, PromptText: promptText);
        return await ExecuteCommandAsync("Page.handleJavaScriptDialog", @params, JsonContext.HandleJavaScriptDialogCommandParameters, JsonContext.HandleJavaScriptDialogResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<NavigateResult> NavigateAsync(string url, string? referrer = null, TransitionType? transitionType = null, FrameId? frameId = null, ReferrerPolicy? referrerPolicy = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new NavigateCommandParameters(Url: url, Referrer: referrer, TransitionType: transitionType, FrameId: frameId, ReferrerPolicy: referrerPolicy);
        return await ExecuteCommandAsync("Page.navigate", @params, JsonContext.NavigateCommandParameters, JsonContext.NavigateResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<NavigateToHistoryEntryResult> NavigateToHistoryEntryAsync(long entryId, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new NavigateToHistoryEntryCommandParameters(EntryId: entryId);
        return await ExecuteCommandAsync("Page.navigateToHistoryEntry", @params, JsonContext.NavigateToHistoryEntryCommandParameters, JsonContext.NavigateToHistoryEntryResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<PrintToPDFResult> PrintToPDFAsync(bool? landscape = null, bool? displayHeaderFooter = null, bool? printBackground = null, double? scale = null, double? paperWidth = null, double? paperHeight = null, double? marginTop = null, double? marginBottom = null, double? marginLeft = null, double? marginRight = null, string? pageRanges = null, string? headerTemplate = null, string? footerTemplate = null, bool? preferCSSPageSize = null, PrintToPDFTransferMode? transferMode = null, bool? generateTaggedPDF = null, bool? generateDocumentOutline = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new PrintToPDFCommandParameters(Landscape: landscape, DisplayHeaderFooter: displayHeaderFooter, PrintBackground: printBackground, Scale: scale, PaperWidth: paperWidth, PaperHeight: paperHeight, MarginTop: marginTop, MarginBottom: marginBottom, MarginLeft: marginLeft, MarginRight: marginRight, PageRanges: pageRanges, HeaderTemplate: headerTemplate, FooterTemplate: footerTemplate, PreferCSSPageSize: preferCSSPageSize, TransferMode: transferMode, GenerateTaggedPDF: generateTaggedPDF, GenerateDocumentOutline: generateDocumentOutline);
        return await ExecuteCommandAsync("Page.printToPDF", @params, JsonContext.PrintToPDFCommandParameters, JsonContext.PrintToPDFResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<ReloadResult> ReloadAsync(bool? ignoreCache = null, string? scriptToEvaluateOnLoad = null, Network.LoaderId? loaderId = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new ReloadCommandParameters(IgnoreCache: ignoreCache, ScriptToEvaluateOnLoad: scriptToEvaluateOnLoad, LoaderId: loaderId);
        return await ExecuteCommandAsync("Page.reload", @params, JsonContext.ReloadCommandParameters, JsonContext.ReloadResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<RemoveScriptToEvaluateOnLoadResult> RemoveScriptToEvaluateOnLoadAsync(ScriptIdentifier identifier, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveScriptToEvaluateOnLoadCommandParameters(Identifier: identifier);
        return await ExecuteCommandAsync("Page.removeScriptToEvaluateOnLoad", @params, JsonContext.RemoveScriptToEvaluateOnLoadCommandParameters, JsonContext.RemoveScriptToEvaluateOnLoadResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<RemoveScriptToEvaluateOnNewDocumentResult> RemoveScriptToEvaluateOnNewDocumentAsync(ScriptIdentifier identifier, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveScriptToEvaluateOnNewDocumentCommandParameters(Identifier: identifier);
        return await ExecuteCommandAsync("Page.removeScriptToEvaluateOnNewDocument", @params, JsonContext.RemoveScriptToEvaluateOnNewDocumentCommandParameters, JsonContext.RemoveScriptToEvaluateOnNewDocumentResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<ScreencastFrameAckResult> ScreencastFrameAckAsync(long sessionId, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new ScreencastFrameAckCommandParameters(SessionId: sessionId);
        return await ExecuteCommandAsync("Page.screencastFrameAck", @params, JsonContext.ScreencastFrameAckCommandParameters, JsonContext.ScreencastFrameAckResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SearchInResourceResult> SearchInResourceAsync(FrameId frameId, string url, string query, bool? caseSensitive = null, bool? isRegex = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SearchInResourceCommandParameters(FrameId: frameId, Url: url, Query: query, CaseSensitive: caseSensitive, IsRegex: isRegex);
        return await ExecuteCommandAsync("Page.searchInResource", @params, JsonContext.SearchInResourceCommandParameters, JsonContext.SearchInResourceResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetAdBlockingEnabledResult> SetAdBlockingEnabledAsync(bool enabled, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SetAdBlockingEnabledCommandParameters(Enabled: enabled);
        return await ExecuteCommandAsync("Page.setAdBlockingEnabled", @params, JsonContext.SetAdBlockingEnabledCommandParameters, JsonContext.SetAdBlockingEnabledResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<SetBypassCSPResult> SetBypassCSPAsync(bool enabled, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SetBypassCSPCommandParameters(Enabled: enabled);
        return await ExecuteCommandAsync("Page.setBypassCSP", @params, JsonContext.SetBypassCSPCommandParameters, JsonContext.SetBypassCSPResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetPermissionsPolicyStateResult> GetPermissionsPolicyStateAsync(FrameId frameId, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetPermissionsPolicyStateCommandParameters(FrameId: frameId);
        return await ExecuteCommandAsync("Page.getPermissionsPolicyState", @params, JsonContext.GetPermissionsPolicyStateCommandParameters, JsonContext.GetPermissionsPolicyStateResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetOriginTrialsResult> GetOriginTrialsAsync(FrameId frameId, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetOriginTrialsCommandParameters(FrameId: frameId);
        return await ExecuteCommandAsync("Page.getOriginTrials", @params, JsonContext.GetOriginTrialsCommandParameters, JsonContext.GetOriginTrialsResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<SetDeviceMetricsOverrideResult> SetDeviceMetricsOverrideAsync(long width, long height, double deviceScaleFactor, bool mobile, double? scale = null, long? screenWidth = null, long? screenHeight = null, long? positionX = null, long? positionY = null, bool? dontSetVisibleSize = null, Emulation.ScreenOrientation? screenOrientation = null, Viewport? viewport = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SetDeviceMetricsOverrideCommandParameters(Width: width, Height: height, DeviceScaleFactor: deviceScaleFactor, Mobile: mobile, Scale: scale, ScreenWidth: screenWidth, ScreenHeight: screenHeight, PositionX: positionX, PositionY: positionY, DontSetVisibleSize: dontSetVisibleSize, ScreenOrientation: screenOrientation, Viewport: viewport);
        return await ExecuteCommandAsync("Page.setDeviceMetricsOverride", @params, JsonContext.SetDeviceMetricsOverrideCommandParameters, JsonContext.SetDeviceMetricsOverrideResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<SetDeviceOrientationOverrideResult> SetDeviceOrientationOverrideAsync(double alpha, double beta, double gamma, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SetDeviceOrientationOverrideCommandParameters(Alpha: alpha, Beta: beta, Gamma: gamma);
        return await ExecuteCommandAsync("Page.setDeviceOrientationOverride", @params, JsonContext.SetDeviceOrientationOverrideCommandParameters, JsonContext.SetDeviceOrientationOverrideResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetFontFamiliesResult> SetFontFamiliesAsync(FontFamilies fontFamilies, ImmutableArray<ScriptFontFamilies>? forScripts = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SetFontFamiliesCommandParameters(FontFamilies: fontFamilies, ForScripts: forScripts);
        return await ExecuteCommandAsync("Page.setFontFamilies", @params, JsonContext.SetFontFamiliesCommandParameters, JsonContext.SetFontFamiliesResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetFontSizesResult> SetFontSizesAsync(FontSizes fontSizes, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SetFontSizesCommandParameters(FontSizes: fontSizes);
        return await ExecuteCommandAsync("Page.setFontSizes", @params, JsonContext.SetFontSizesCommandParameters, JsonContext.SetFontSizesResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<SetDocumentContentResult> SetDocumentContentAsync(FrameId frameId, string html, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SetDocumentContentCommandParameters(FrameId: frameId, Html: html);
        return await ExecuteCommandAsync("Page.setDocumentContent", @params, JsonContext.SetDocumentContentCommandParameters, JsonContext.SetDocumentContentResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<SetDownloadBehaviorResult> SetDownloadBehaviorAsync(SetDownloadBehaviorBehavior behavior, string? downloadPath = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SetDownloadBehaviorCommandParameters(Behavior: behavior, DownloadPath: downloadPath);
        return await ExecuteCommandAsync("Page.setDownloadBehavior", @params, JsonContext.SetDownloadBehaviorCommandParameters, JsonContext.SetDownloadBehaviorResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Obsolete]
    public async Task<SetGeolocationOverrideResult> SetGeolocationOverrideAsync(double? latitude = null, double? longitude = null, double? accuracy = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SetGeolocationOverrideCommandParameters(Latitude: latitude, Longitude: longitude, Accuracy: accuracy);
        return await ExecuteCommandAsync("Page.setGeolocationOverride", @params, JsonContext.SetGeolocationOverrideCommandParameters, JsonContext.SetGeolocationOverrideResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<SetLifecycleEventsEnabledResult> SetLifecycleEventsEnabledAsync(bool enabled, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SetLifecycleEventsEnabledCommandParameters(Enabled: enabled);
        return await ExecuteCommandAsync("Page.setLifecycleEventsEnabled", @params, JsonContext.SetLifecycleEventsEnabledCommandParameters, JsonContext.SetLifecycleEventsEnabledResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<SetTouchEmulationEnabledResult> SetTouchEmulationEnabledAsync(bool enabled, SetTouchEmulationEnabledConfiguration? configuration = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SetTouchEmulationEnabledCommandParameters(Enabled: enabled, Configuration: configuration);
        return await ExecuteCommandAsync("Page.setTouchEmulationEnabled", @params, JsonContext.SetTouchEmulationEnabledCommandParameters, JsonContext.SetTouchEmulationEnabledResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<StartScreencastResult> StartScreencastAsync(StartScreencastFormat? format = null, long? quality = null, long? maxWidth = null, long? maxHeight = null, long? everyNthFrame = null, long? maxFramesInFlight = null, bool? sendLastFrame = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new StartScreencastCommandParameters(Format: format, Quality: quality, MaxWidth: maxWidth, MaxHeight: maxHeight, EveryNthFrame: everyNthFrame, MaxFramesInFlight: maxFramesInFlight, SendLastFrame: sendLastFrame);
        return await ExecuteCommandAsync("Page.startScreencast", @params, JsonContext.StartScreencastCommandParameters, JsonContext.StartScreencastResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<StartScreenRecordingResult> StartScreenRecordingAsync(bool? audio = null, long? maxWidth = null, long? maxHeight = null, long? frameRate = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new StartScreenRecordingCommandParameters(Audio: audio, MaxWidth: maxWidth, MaxHeight: maxHeight, FrameRate: frameRate);
        return await ExecuteCommandAsync("Page.startScreenRecording", @params, JsonContext.StartScreenRecordingCommandParameters, JsonContext.StartScreenRecordingResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<StopScreenRecordingResult> StopScreenRecordingAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new StopScreenRecordingCommandParameters();
        return await ExecuteCommandAsync("Page.stopScreenRecording", @params, JsonContext.StopScreenRecordingCommandParameters, JsonContext.StopScreenRecordingResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<StopLoadingResult> StopLoadingAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new StopLoadingCommandParameters();
        return await ExecuteCommandAsync("Page.stopLoading", @params, JsonContext.StopLoadingCommandParameters, JsonContext.StopLoadingResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<CrashResult> CrashAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new CrashCommandParameters();
        return await ExecuteCommandAsync("Page.crash", @params, JsonContext.CrashCommandParameters, JsonContext.CrashResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<CloseResult> CloseAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new CloseCommandParameters();
        return await ExecuteCommandAsync("Page.close", @params, JsonContext.CloseCommandParameters, JsonContext.CloseResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetWebLifecycleStateResult> SetWebLifecycleStateAsync(SetWebLifecycleStateState state, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SetWebLifecycleStateCommandParameters(State: state);
        return await ExecuteCommandAsync("Page.setWebLifecycleState", @params, JsonContext.SetWebLifecycleStateCommandParameters, JsonContext.SetWebLifecycleStateResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<StopScreencastResult> StopScreencastAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new StopScreencastCommandParameters();
        return await ExecuteCommandAsync("Page.stopScreencast", @params, JsonContext.StopScreencastCommandParameters, JsonContext.StopScreencastResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<ProduceCompilationCacheResult> ProduceCompilationCacheAsync(ImmutableArray<CompilationCacheParams> scripts, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new ProduceCompilationCacheCommandParameters(Scripts: scripts);
        return await ExecuteCommandAsync("Page.produceCompilationCache", @params, JsonContext.ProduceCompilationCacheCommandParameters, JsonContext.ProduceCompilationCacheResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<AddCompilationCacheResult> AddCompilationCacheAsync(string url, string data, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new AddCompilationCacheCommandParameters(Url: url, Data: data);
        return await ExecuteCommandAsync("Page.addCompilationCache", @params, JsonContext.AddCompilationCacheCommandParameters, JsonContext.AddCompilationCacheResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<ClearCompilationCacheResult> ClearCompilationCacheAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new ClearCompilationCacheCommandParameters();
        return await ExecuteCommandAsync("Page.clearCompilationCache", @params, JsonContext.ClearCompilationCacheCommandParameters, JsonContext.ClearCompilationCacheResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetSPCTransactionModeResult> SetSPCTransactionModeAsync(SetSPCTransactionModeMode mode, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SetSPCTransactionModeCommandParameters(Mode: mode);
        return await ExecuteCommandAsync("Page.setSPCTransactionMode", @params, JsonContext.SetSPCTransactionModeCommandParameters, JsonContext.SetSPCTransactionModeResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetRPHRegistrationModeResult> SetRPHRegistrationModeAsync(SetRPHRegistrationModeMode mode, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SetRPHRegistrationModeCommandParameters(Mode: mode);
        return await ExecuteCommandAsync("Page.setRPHRegistrationMode", @params, JsonContext.SetRPHRegistrationModeCommandParameters, JsonContext.SetRPHRegistrationModeResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GenerateTestReportResult> GenerateTestReportAsync(string message, string? group = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GenerateTestReportCommandParameters(Message: message, Group: group);
        return await ExecuteCommandAsync("Page.generateTestReport", @params, JsonContext.GenerateTestReportCommandParameters, JsonContext.GenerateTestReportResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<WaitForDebuggerResult> WaitForDebuggerAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new WaitForDebuggerCommandParameters();
        return await ExecuteCommandAsync("Page.waitForDebugger", @params, JsonContext.WaitForDebuggerCommandParameters, JsonContext.WaitForDebuggerResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<SetInterceptFileChooserDialogResult> SetInterceptFileChooserDialogAsync(bool enabled, bool? cancel = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SetInterceptFileChooserDialogCommandParameters(Enabled: enabled, Cancel: cancel);
        return await ExecuteCommandAsync("Page.setInterceptFileChooserDialog", @params, JsonContext.SetInterceptFileChooserDialogCommandParameters, JsonContext.SetInterceptFileChooserDialogResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetPrerenderingAllowedResult> SetPrerenderingAllowedAsync(bool isAllowed, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SetPrerenderingAllowedCommandParameters(IsAllowed: isAllowed);
        return await ExecuteCommandAsync("Page.setPrerenderingAllowed", @params, JsonContext.SetPrerenderingAllowedCommandParameters, JsonContext.SetPrerenderingAllowedResult, session, cancellationToken).ConfigureAwait(false);
    }

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetAnnotatedPageContentResult> GetAnnotatedPageContentAsync(bool? includeActionableInformation = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetAnnotatedPageContentCommandParameters(IncludeActionableInformation: includeActionableInformation);
        return await ExecuteCommandAsync("Page.getAnnotatedPageContent", @params, JsonContext.GetAnnotatedPageContentCommandParameters, JsonContext.GetAnnotatedPageContentResult, session, cancellationToken).ConfigureAwait(false);
    }

    public IEventSource<DomContentEventFiredEventArgs> DomContentEventFired => CreateCdpEventSource(PageDomainEvent.DomContentEventFired);
    public IEventSource<FileChooserOpenedEventArgs> FileChooserOpened => CreateCdpEventSource(PageDomainEvent.FileChooserOpened);
    public IEventSource<FrameAttachedEventArgs> FrameAttached => CreateCdpEventSource(PageDomainEvent.FrameAttached);
    [global::System.Obsolete]
    public IEventSource<FrameClearedScheduledNavigationEventArgs> FrameClearedScheduledNavigation => CreateCdpEventSource(PageDomainEvent.FrameClearedScheduledNavigation);
    public IEventSource<FrameDetachedEventArgs> FrameDetached => CreateCdpEventSource(PageDomainEvent.FrameDetached);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<FrameSubtreeWillBeDetachedEventArgs> FrameSubtreeWillBeDetached => CreateCdpEventSource(PageDomainEvent.FrameSubtreeWillBeDetached);
    public IEventSource<FrameNavigatedEventArgs> FrameNavigated => CreateCdpEventSource(PageDomainEvent.FrameNavigated);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DocumentOpenedEventArgs> DocumentOpened => CreateCdpEventSource(PageDomainEvent.DocumentOpened);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<FrameResizedEventArgs> FrameResized => CreateCdpEventSource(PageDomainEvent.FrameResized);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<FrameStartedNavigatingEventArgs> FrameStartedNavigating => CreateCdpEventSource(PageDomainEvent.FrameStartedNavigating);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<FrameRequestedNavigationEventArgs> FrameRequestedNavigation => CreateCdpEventSource(PageDomainEvent.FrameRequestedNavigation);
    [global::System.Obsolete]
    public IEventSource<FrameScheduledNavigationEventArgs> FrameScheduledNavigation => CreateCdpEventSource(PageDomainEvent.FrameScheduledNavigation);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<FrameStartedLoadingEventArgs> FrameStartedLoading => CreateCdpEventSource(PageDomainEvent.FrameStartedLoading);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<FrameStoppedLoadingEventArgs> FrameStoppedLoading => CreateCdpEventSource(PageDomainEvent.FrameStoppedLoading);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public IEventSource<DownloadWillBeginEventArgs> DownloadWillBegin => CreateCdpEventSource(PageDomainEvent.DownloadWillBegin);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public IEventSource<DownloadProgressEventArgs> DownloadProgress => CreateCdpEventSource(PageDomainEvent.DownloadProgress);
    public IEventSource<InterstitialHiddenEventArgs> InterstitialHidden => CreateCdpEventSource(PageDomainEvent.InterstitialHidden);
    public IEventSource<InterstitialShownEventArgs> InterstitialShown => CreateCdpEventSource(PageDomainEvent.InterstitialShown);
    public IEventSource<JavascriptDialogClosedEventArgs> JavascriptDialogClosed => CreateCdpEventSource(PageDomainEvent.JavascriptDialogClosed);
    public IEventSource<JavascriptDialogOpeningEventArgs> JavascriptDialogOpening => CreateCdpEventSource(PageDomainEvent.JavascriptDialogOpening);
    public IEventSource<LifecycleEventEventArgs> LifecycleEvent => CreateCdpEventSource(PageDomainEvent.LifecycleEvent);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<BackForwardCacheNotUsedEventArgs> BackForwardCacheNotUsed => CreateCdpEventSource(PageDomainEvent.BackForwardCacheNotUsed);
    public IEventSource<LoadEventFiredEventArgs> LoadEventFired => CreateCdpEventSource(PageDomainEvent.LoadEventFired);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<NavigatedWithinDocumentEventArgs> NavigatedWithinDocument => CreateCdpEventSource(PageDomainEvent.NavigatedWithinDocument);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<ScreencastFrameEventArgs> ScreencastFrame => CreateCdpEventSource(PageDomainEvent.ScreencastFrame);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<ScreencastVisibilityChangedEventArgs> ScreencastVisibilityChanged => CreateCdpEventSource(PageDomainEvent.ScreencastVisibilityChanged);
    public IEventSource<WindowOpenEventArgs> WindowOpen => CreateCdpEventSource(PageDomainEvent.WindowOpen);
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<CompilationCacheProducedEventArgs> CompilationCacheProduced => CreateCdpEventSource(PageDomainEvent.CompilationCacheProduced);
}

internal sealed record AddScriptToEvaluateOnLoadCommandParameters(string ScriptSource) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.AddScriptToEvaluateOnLoadAsync"/> command.
/// </summary>
/// <param name="Identifier">
/// Identifier of the added script.
/// </param>
public sealed record AddScriptToEvaluateOnLoadResult(ScriptIdentifier Identifier) : EmptyResult;


internal sealed record AddScriptToEvaluateOnNewDocumentCommandParameters(string Source, string? WorldName, bool? IncludeCommandLineAPI, bool? RunImmediately) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.AddScriptToEvaluateOnNewDocumentAsync"/> command.
/// </summary>
/// <param name="Identifier">
/// Identifier of the added script.
/// </param>
public sealed record AddScriptToEvaluateOnNewDocumentResult(ScriptIdentifier Identifier) : EmptyResult;


internal sealed record BringToFrontCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IPage.BringToFrontAsync"/> command.
/// </summary>
public sealed record BringToFrontResult() : EmptyResult;


internal sealed record CaptureScreenshotCommandParameters(CaptureScreenshotFormat? Format, long? Quality, Viewport? Clip, bool? FromSurface, bool? CaptureBeyondViewport, bool? OptimizeForSpeed) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.CaptureScreenshotAsync"/> command.
/// </summary>
/// <param name="Data">
/// Base64-encoded image data. (Encoded as a base64 string when passed over JSON)
/// </param>
public sealed record CaptureScreenshotResult(string Data) : EmptyResult;


internal sealed record CaptureSnapshotCommandParameters(CaptureSnapshotFormat? Format) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.CaptureSnapshotAsync"/> command.
/// </summary>
/// <param name="Data">
/// Serialized page data.
/// </param>
public sealed record CaptureSnapshotResult(string Data) : EmptyResult;


internal sealed record ClearDeviceMetricsOverrideCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IPage.ClearDeviceMetricsOverrideAsync"/> command.
/// </summary>
public sealed record ClearDeviceMetricsOverrideResult() : EmptyResult;


internal sealed record ClearDeviceOrientationOverrideCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IPage.ClearDeviceOrientationOverrideAsync"/> command.
/// </summary>
public sealed record ClearDeviceOrientationOverrideResult() : EmptyResult;


internal sealed record ClearGeolocationOverrideCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IPage.ClearGeolocationOverrideAsync"/> command.
/// </summary>
public sealed record ClearGeolocationOverrideResult() : EmptyResult;


internal sealed record CreateIsolatedWorldCommandParameters(FrameId FrameId, string? WorldName, bool? GrantUniveralAccess, string? ContentSecurityPolicy) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.CreateIsolatedWorldAsync"/> command.
/// </summary>
/// <param name="ExecutionContextId">
/// Execution context of the isolated world.
/// </param>
public sealed record CreateIsolatedWorldResult(Runtime.ExecutionContextId ExecutionContextId) : EmptyResult;


internal sealed record DeleteCookieCommandParameters(string CookieName, string Url) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.DeleteCookieAsync"/> command.
/// </summary>
public sealed record DeleteCookieResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IPage.DisableAsync"/> command.
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters(bool? EnableFileChooserOpenedEvent) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.EnableAsync"/> command.
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record GetAppManifestCommandParameters(string? ManifestId) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.GetAppManifestAsync"/> command.
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
public sealed record GetAppManifestResult(string Url, ImmutableArray<AppManifestError> Errors, string? Data, AppManifestParsedProperties? Parsed, WebAppManifest Manifest) : EmptyResult;


internal sealed record GetInstallabilityErrorsCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IPage.GetInstallabilityErrorsAsync"/> command.
/// </summary>
/// <param name="InstallabilityErrors">
/// </param>
public sealed record GetInstallabilityErrorsResult(ImmutableArray<InstallabilityError> InstallabilityErrors) : EmptyResult;


internal sealed record GetManifestIconsCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IPage.GetManifestIconsAsync"/> command.
/// </summary>
/// <param name="PrimaryIcon">
/// </param>
public sealed record GetManifestIconsResult(string? PrimaryIcon) : EmptyResult;


internal sealed record GetAppIdCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IPage.GetAppIdAsync"/> command.
/// </summary>
/// <param name="AppId">
/// App id, either from manifest's id attribute or computed from start_url
/// </param>
/// <param name="RecommendedId">
/// Recommendation for manifest's id attribute to match current id computed from start_url
/// </param>
/// <param name="BundleId">
/// The bundle ID for an Isolated Web App (IWA)
/// </param>
/// <param name="ParentAppName">
/// The name of the parent app if this app is a Sub-App
/// </param>
public sealed record GetAppIdResult(string? AppId, string? RecommendedId, string? BundleId, string? ParentAppName) : EmptyResult;


internal sealed record GetSubAppsCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IPage.GetSubAppsAsync"/> command.
/// </summary>
/// <param name="SubApps">
/// </param>
public sealed record GetSubAppsResult(ImmutableArray<SubApp> SubApps) : EmptyResult;


internal sealed record GetSiblingSubAppsCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IPage.GetSiblingSubAppsAsync"/> command.
/// </summary>
/// <param name="SubApps">
/// </param>
public sealed record GetSiblingSubAppsResult(ImmutableArray<SubApp> SubApps) : EmptyResult;


internal sealed record GetAdScriptAncestryCommandParameters(FrameId FrameId) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.GetAdScriptAncestryAsync"/> command.
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
/// Result of the <see cref="IPage.GetFrameTreeAsync"/> command.
/// </summary>
/// <param name="FrameTree">
/// Present frame tree structure.
/// </param>
public sealed record GetFrameTreeResult(FrameTree FrameTree) : EmptyResult;


internal sealed record GetLayoutMetricsCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IPage.GetLayoutMetricsAsync"/> command.
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
/// Result of the <see cref="IPage.GetNavigationHistoryAsync"/> command.
/// </summary>
/// <param name="CurrentIndex">
/// Index of the current navigation history entry.
/// </param>
/// <param name="Entries">
/// Array of navigation history entries.
/// </param>
public sealed record GetNavigationHistoryResult(long CurrentIndex, ImmutableArray<NavigationEntry> Entries) : EmptyResult;


internal sealed record ResetNavigationHistoryCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IPage.ResetNavigationHistoryAsync"/> command.
/// </summary>
public sealed record ResetNavigationHistoryResult() : EmptyResult;


internal sealed record GetResourceContentCommandParameters(FrameId FrameId, string Url) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.GetResourceContentAsync"/> command.
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
/// Result of the <see cref="IPage.GetResourceTreeAsync"/> command.
/// </summary>
/// <param name="FrameTree">
/// Present frame / resource tree structure.
/// </param>
public sealed record GetResourceTreeResult(FrameResourceTree FrameTree) : EmptyResult;


internal sealed record HandleJavaScriptDialogCommandParameters(bool Accept, string? PromptText) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.HandleJavaScriptDialogAsync"/> command.
/// </summary>
public sealed record HandleJavaScriptDialogResult() : EmptyResult;


internal sealed record NavigateCommandParameters(string Url, string? Referrer, TransitionType? TransitionType, FrameId? FrameId, ReferrerPolicy? ReferrerPolicy) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.NavigateAsync"/> command.
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
/// Result of the <see cref="IPage.NavigateToHistoryEntryAsync"/> command.
/// </summary>
public sealed record NavigateToHistoryEntryResult() : EmptyResult;


internal sealed record PrintToPDFCommandParameters(bool? Landscape, bool? DisplayHeaderFooter, bool? PrintBackground, double? Scale, double? PaperWidth, double? PaperHeight, double? MarginTop, double? MarginBottom, double? MarginLeft, double? MarginRight, string? PageRanges, string? HeaderTemplate, string? FooterTemplate, bool? PreferCSSPageSize, PrintToPDFTransferMode? TransferMode, bool? GenerateTaggedPDF, bool? GenerateDocumentOutline) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.PrintToPDFAsync"/> command.
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
/// Result of the <see cref="IPage.ReloadAsync"/> command.
/// </summary>
public sealed record ReloadResult() : EmptyResult;


internal sealed record RemoveScriptToEvaluateOnLoadCommandParameters(ScriptIdentifier Identifier) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.RemoveScriptToEvaluateOnLoadAsync"/> command.
/// </summary>
public sealed record RemoveScriptToEvaluateOnLoadResult() : EmptyResult;


internal sealed record RemoveScriptToEvaluateOnNewDocumentCommandParameters(ScriptIdentifier Identifier) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.RemoveScriptToEvaluateOnNewDocumentAsync"/> command.
/// </summary>
public sealed record RemoveScriptToEvaluateOnNewDocumentResult() : EmptyResult;


internal sealed record ScreencastFrameAckCommandParameters(long SessionId) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.ScreencastFrameAckAsync"/> command.
/// </summary>
public sealed record ScreencastFrameAckResult() : EmptyResult;


internal sealed record SearchInResourceCommandParameters(FrameId FrameId, string Url, string Query, bool? CaseSensitive, bool? IsRegex) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.SearchInResourceAsync"/> command.
/// </summary>
/// <param name="Result">
/// List of search matches.
/// </param>
public sealed record SearchInResourceResult(ImmutableArray<Debugger.SearchMatch> Result) : EmptyResult;


internal sealed record SetAdBlockingEnabledCommandParameters(bool Enabled) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.SetAdBlockingEnabledAsync"/> command.
/// </summary>
public sealed record SetAdBlockingEnabledResult() : EmptyResult;


internal sealed record SetBypassCSPCommandParameters(bool Enabled) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.SetBypassCSPAsync"/> command.
/// </summary>
public sealed record SetBypassCSPResult() : EmptyResult;


internal sealed record GetPermissionsPolicyStateCommandParameters(FrameId FrameId) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.GetPermissionsPolicyStateAsync"/> command.
/// </summary>
/// <param name="States">
/// </param>
public sealed record GetPermissionsPolicyStateResult(ImmutableArray<PermissionsPolicyFeatureState> States) : EmptyResult;


internal sealed record GetOriginTrialsCommandParameters(FrameId FrameId) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.GetOriginTrialsAsync"/> command.
/// </summary>
/// <param name="OriginTrials">
/// </param>
public sealed record GetOriginTrialsResult(ImmutableArray<OriginTrial> OriginTrials) : EmptyResult;


internal sealed record SetDeviceMetricsOverrideCommandParameters(long Width, long Height, double DeviceScaleFactor, bool Mobile, double? Scale, long? ScreenWidth, long? ScreenHeight, long? PositionX, long? PositionY, bool? DontSetVisibleSize, Emulation.ScreenOrientation? ScreenOrientation, Viewport? Viewport) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.SetDeviceMetricsOverrideAsync"/> command.
/// </summary>
public sealed record SetDeviceMetricsOverrideResult() : EmptyResult;


internal sealed record SetDeviceOrientationOverrideCommandParameters(double Alpha, double Beta, double Gamma) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.SetDeviceOrientationOverrideAsync"/> command.
/// </summary>
public sealed record SetDeviceOrientationOverrideResult() : EmptyResult;


internal sealed record SetFontFamiliesCommandParameters(FontFamilies FontFamilies, ImmutableArray<ScriptFontFamilies>? ForScripts) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.SetFontFamiliesAsync"/> command.
/// </summary>
public sealed record SetFontFamiliesResult() : EmptyResult;


internal sealed record SetFontSizesCommandParameters(FontSizes FontSizes) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.SetFontSizesAsync"/> command.
/// </summary>
public sealed record SetFontSizesResult() : EmptyResult;


internal sealed record SetDocumentContentCommandParameters(FrameId FrameId, string Html) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.SetDocumentContentAsync"/> command.
/// </summary>
public sealed record SetDocumentContentResult() : EmptyResult;


internal sealed record SetDownloadBehaviorCommandParameters(SetDownloadBehaviorBehavior Behavior, string? DownloadPath) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.SetDownloadBehaviorAsync"/> command.
/// </summary>
public sealed record SetDownloadBehaviorResult() : EmptyResult;


internal sealed record SetGeolocationOverrideCommandParameters(double? Latitude, double? Longitude, double? Accuracy) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.SetGeolocationOverrideAsync"/> command.
/// </summary>
public sealed record SetGeolocationOverrideResult() : EmptyResult;


internal sealed record SetLifecycleEventsEnabledCommandParameters(bool Enabled) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.SetLifecycleEventsEnabledAsync"/> command.
/// </summary>
public sealed record SetLifecycleEventsEnabledResult() : EmptyResult;


internal sealed record SetTouchEmulationEnabledCommandParameters(bool Enabled, SetTouchEmulationEnabledConfiguration? Configuration) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.SetTouchEmulationEnabledAsync"/> command.
/// </summary>
public sealed record SetTouchEmulationEnabledResult() : EmptyResult;


internal sealed record StartScreencastCommandParameters(StartScreencastFormat? Format, long? Quality, long? MaxWidth, long? MaxHeight, long? EveryNthFrame, long? MaxFramesInFlight, bool? SendLastFrame) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.StartScreencastAsync"/> command.
/// </summary>
public sealed record StartScreencastResult() : EmptyResult;


internal sealed record StartScreenRecordingCommandParameters(bool? Audio, long? MaxWidth, long? MaxHeight, long? FrameRate) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.StartScreenRecordingAsync"/> command.
/// </summary>
/// <param name="Stream">
/// A handle of the stream that holds resulting screencast data.
/// </param>
public sealed record StartScreenRecordingResult(IO.StreamHandle Stream) : EmptyResult;


internal sealed record StopScreenRecordingCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IPage.StopScreenRecordingAsync"/> command.
/// </summary>
/// <param name="Stream">
/// A handle of the stream that holds resulting screencast data.
/// </param>
public sealed record StopScreenRecordingResult(IO.StreamHandle Stream) : EmptyResult;


internal sealed record StopLoadingCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IPage.StopLoadingAsync"/> command.
/// </summary>
public sealed record StopLoadingResult() : EmptyResult;


internal sealed record CrashCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IPage.CrashAsync"/> command.
/// </summary>
public sealed record CrashResult() : EmptyResult;


internal sealed record CloseCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IPage.CloseAsync"/> command.
/// </summary>
public sealed record CloseResult() : EmptyResult;


internal sealed record SetWebLifecycleStateCommandParameters(SetWebLifecycleStateState State) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.SetWebLifecycleStateAsync"/> command.
/// </summary>
public sealed record SetWebLifecycleStateResult() : EmptyResult;


internal sealed record StopScreencastCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IPage.StopScreencastAsync"/> command.
/// </summary>
public sealed record StopScreencastResult() : EmptyResult;


internal sealed record ProduceCompilationCacheCommandParameters(ImmutableArray<CompilationCacheParams> Scripts) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.ProduceCompilationCacheAsync"/> command.
/// </summary>
public sealed record ProduceCompilationCacheResult() : EmptyResult;


internal sealed record AddCompilationCacheCommandParameters(string Url, string Data) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.AddCompilationCacheAsync"/> command.
/// </summary>
public sealed record AddCompilationCacheResult() : EmptyResult;


internal sealed record ClearCompilationCacheCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IPage.ClearCompilationCacheAsync"/> command.
/// </summary>
public sealed record ClearCompilationCacheResult() : EmptyResult;


internal sealed record SetSPCTransactionModeCommandParameters(SetSPCTransactionModeMode Mode) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.SetSPCTransactionModeAsync"/> command.
/// </summary>
public sealed record SetSPCTransactionModeResult() : EmptyResult;


internal sealed record SetRPHRegistrationModeCommandParameters(SetRPHRegistrationModeMode Mode) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.SetRPHRegistrationModeAsync"/> command.
/// </summary>
public sealed record SetRPHRegistrationModeResult() : EmptyResult;


internal sealed record GenerateTestReportCommandParameters(string Message, string? Group) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.GenerateTestReportAsync"/> command.
/// </summary>
public sealed record GenerateTestReportResult() : EmptyResult;


internal sealed record WaitForDebuggerCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IPage.WaitForDebuggerAsync"/> command.
/// </summary>
public sealed record WaitForDebuggerResult() : EmptyResult;


internal sealed record SetInterceptFileChooserDialogCommandParameters(bool Enabled, bool? Cancel) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.SetInterceptFileChooserDialogAsync"/> command.
/// </summary>
public sealed record SetInterceptFileChooserDialogResult() : EmptyResult;


internal sealed record SetPrerenderingAllowedCommandParameters(bool IsAllowed) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.SetPrerenderingAllowedAsync"/> command.
/// </summary>
public sealed record SetPrerenderingAllowedResult() : EmptyResult;


internal sealed record GetAnnotatedPageContentCommandParameters(bool? IncludeActionableInformation) : Parameters;

/// <summary>
/// Result of the <see cref="IPage.GetAnnotatedPageContentAsync"/> command.
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
public sealed record FileChooserOpenedEventArgs(FrameId FrameId, FileChooserOpenedMode Mode, DOM.BackendNodeId? BackendNodeId = null) : OpenQA.Selenium.BiDi.EventArgs;

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
public sealed record FrameDetachedEventArgs(FrameId FrameId, FrameDetachedReason Reason) : OpenQA.Selenium.BiDi.EventArgs;

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
public sealed record FrameStartedNavigatingEventArgs(FrameId FrameId, string Url, Network.LoaderId LoaderId, FrameStartedNavigatingNavigationType NavigationType) : OpenQA.Selenium.BiDi.EventArgs;

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
public sealed record DownloadProgressEventArgs(string Guid, double TotalBytes, double ReceivedBytes, DownloadProgressState State) : OpenQA.Selenium.BiDi.EventArgs;

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
public sealed record BackForwardCacheNotUsedEventArgs(Network.LoaderId LoaderId, FrameId FrameId, ImmutableArray<BackForwardCacheNotRestoredExplanation> NotRestoredExplanations, BackForwardCacheNotRestoredExplanationTree? NotRestoredExplanationsTree = null) : OpenQA.Selenium.BiDi.EventArgs;

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
public sealed record NavigatedWithinDocumentEventArgs(FrameId FrameId, string Url, NavigatedWithinDocumentNavigationType NavigationType) : OpenQA.Selenium.BiDi.EventArgs;

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
public sealed record WindowOpenEventArgs(string Url, string WindowName, ImmutableArray<string> WindowFeatures, bool UserGesture) : OpenQA.Selenium.BiDi.EventArgs;

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
    /// Corresponds to the <c>"none"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("none")]
    None,
    /// <summary>
    /// Corresponds to the <c>"child"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("child")]
    Child,
    /// <summary>
    /// Corresponds to the <c>"root"</c> wire value.
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
    /// Corresponds to the <c>"ParentIsAd"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ParentIsAd")]
    ParentIsAd,
    /// <summary>
    /// Corresponds to the <c>"CreatedByAdScript"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CreatedByAdScript")]
    CreatedByAdScript,
    /// <summary>
    /// Corresponds to the <c>"MatchedBlockingRule"</c> wire value.
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
    public ImmutableArray<AdFrameExplanation>? Explanations { get; init; }
}

/// <summary>
/// Indicates whether the frame is a secure context and why it is the case.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<SecureContextType>))]
public enum SecureContextType
{
    /// <summary>
    /// Corresponds to the <c>"Secure"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Secure")]
    Secure,
    /// <summary>
    /// Corresponds to the <c>"SecureLocalhost"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SecureLocalhost")]
    SecureLocalhost,
    /// <summary>
    /// Corresponds to the <c>"InsecureScheme"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InsecureScheme")]
    InsecureScheme,
    /// <summary>
    /// Corresponds to the <c>"InsecureAncestor"</c> wire value.
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
    /// Corresponds to the <c>"Isolated"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Isolated")]
    Isolated,
    /// <summary>
    /// Corresponds to the <c>"NotIsolated"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NotIsolated")]
    NotIsolated,
    /// <summary>
    /// Corresponds to the <c>"NotIsolatedFeatureDisabled"</c> wire value.
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
    /// Corresponds to the <c>"SharedArrayBuffers"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SharedArrayBuffers")]
    SharedArrayBuffers,
    /// <summary>
    /// Corresponds to the <c>"SharedArrayBuffersTransferAllowed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SharedArrayBuffersTransferAllowed")]
    SharedArrayBuffersTransferAllowed,
    /// <summary>
    /// Corresponds to the <c>"PerformanceMeasureMemory"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PerformanceMeasureMemory")]
    PerformanceMeasureMemory,
    /// <summary>
    /// Corresponds to the <c>"PerformanceProfile"</c> wire value.
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
    /// Corresponds to the <c>"accelerometer"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("accelerometer")]
    Accelerometer,
    /// <summary>
    /// Corresponds to the <c>"all-screens-capture"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("all-screens-capture")]
    AllScreensCapture,
    /// <summary>
    /// Corresponds to the <c>"ambient-light-sensor"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ambient-light-sensor")]
    AmbientLightSensor,
    /// <summary>
    /// Corresponds to the <c>"aria-notify"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("aria-notify")]
    AriaNotify,
    /// <summary>
    /// Corresponds to the <c>"autofill"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("autofill")]
    Autofill,
    /// <summary>
    /// Corresponds to the <c>"autoplay"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("autoplay")]
    Autoplay,
    /// <summary>
    /// Corresponds to the <c>"bluetooth"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("bluetooth")]
    Bluetooth,
    /// <summary>
    /// Corresponds to the <c>"browsing-topics"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("browsing-topics")]
    BrowsingTopics,
    /// <summary>
    /// Corresponds to the <c>"camera"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("camera")]
    Camera,
    /// <summary>
    /// Corresponds to the <c>"captured-surface-control"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("captured-surface-control")]
    CapturedSurfaceControl,
    /// <summary>
    /// Corresponds to the <c>"ch-dpr"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-dpr")]
    ChDpr,
    /// <summary>
    /// Corresponds to the <c>"ch-device-memory"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-device-memory")]
    ChDeviceMemory,
    /// <summary>
    /// Corresponds to the <c>"ch-downlink"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-downlink")]
    ChDownlink,
    /// <summary>
    /// Corresponds to the <c>"ch-ect"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ect")]
    ChEct,
    /// <summary>
    /// Corresponds to the <c>"ch-prefers-color-scheme"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-prefers-color-scheme")]
    ChPrefersColorScheme,
    /// <summary>
    /// Corresponds to the <c>"ch-prefers-reduced-motion"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-prefers-reduced-motion")]
    ChPrefersReducedMotion,
    /// <summary>
    /// Corresponds to the <c>"ch-prefers-reduced-transparency"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-prefers-reduced-transparency")]
    ChPrefersReducedTransparency,
    /// <summary>
    /// Corresponds to the <c>"ch-rtt"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-rtt")]
    ChRtt,
    /// <summary>
    /// Corresponds to the <c>"ch-save-data"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-save-data")]
    ChSaveData,
    /// <summary>
    /// Corresponds to the <c>"ch-ua"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua")]
    ChUa,
    /// <summary>
    /// Corresponds to the <c>"ch-ua-arch"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua-arch")]
    ChUaArch,
    /// <summary>
    /// Corresponds to the <c>"ch-ua-bitness"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua-bitness")]
    ChUaBitness,
    /// <summary>
    /// Corresponds to the <c>"ch-ua-high-entropy-values"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua-high-entropy-values")]
    ChUaHighEntropyValues,
    /// <summary>
    /// Corresponds to the <c>"ch-ua-platform"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua-platform")]
    ChUaPlatform,
    /// <summary>
    /// Corresponds to the <c>"ch-ua-model"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua-model")]
    ChUaModel,
    /// <summary>
    /// Corresponds to the <c>"ch-ua-mobile"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua-mobile")]
    ChUaMobile,
    /// <summary>
    /// Corresponds to the <c>"ch-ua-form-factors"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua-form-factors")]
    ChUaFormFactors,
    /// <summary>
    /// Corresponds to the <c>"ch-ua-full-version"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua-full-version")]
    ChUaFullVersion,
    /// <summary>
    /// Corresponds to the <c>"ch-ua-full-version-list"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua-full-version-list")]
    ChUaFullVersionList,
    /// <summary>
    /// Corresponds to the <c>"ch-ua-platform-version"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua-platform-version")]
    ChUaPlatformVersion,
    /// <summary>
    /// Corresponds to the <c>"ch-ua-wow64"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-ua-wow64")]
    ChUaWow64,
    /// <summary>
    /// Corresponds to the <c>"ch-viewport-height"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-viewport-height")]
    ChViewportHeight,
    /// <summary>
    /// Corresponds to the <c>"ch-viewport-width"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-viewport-width")]
    ChViewportWidth,
    /// <summary>
    /// Corresponds to the <c>"ch-width"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ch-width")]
    ChWidth,
    /// <summary>
    /// Corresponds to the <c>"clipboard-read"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("clipboard-read")]
    ClipboardRead,
    /// <summary>
    /// Corresponds to the <c>"clipboard-write"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("clipboard-write")]
    ClipboardWrite,
    /// <summary>
    /// Corresponds to the <c>"compute-pressure"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("compute-pressure")]
    ComputePressure,
    /// <summary>
    /// Corresponds to the <c>"controlled-frame"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("controlled-frame")]
    ControlledFrame,
    /// <summary>
    /// Corresponds to the <c>"cross-origin-isolated"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("cross-origin-isolated")]
    CrossOriginIsolated,
    /// <summary>
    /// Corresponds to the <c>"deferred-fetch"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("deferred-fetch")]
    DeferredFetch,
    /// <summary>
    /// Corresponds to the <c>"deferred-fetch-minimal"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("deferred-fetch-minimal")]
    DeferredFetchMinimal,
    /// <summary>
    /// Corresponds to the <c>"device-attributes"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("device-attributes")]
    DeviceAttributes,
    /// <summary>
    /// Corresponds to the <c>"digital-credentials-create"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("digital-credentials-create")]
    DigitalCredentialsCreate,
    /// <summary>
    /// Corresponds to the <c>"digital-credentials-get"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("digital-credentials-get")]
    DigitalCredentialsGet,
    /// <summary>
    /// Corresponds to the <c>"direct-sockets"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("direct-sockets")]
    DirectSockets,
    /// <summary>
    /// Corresponds to the <c>"direct-sockets-multicast"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("direct-sockets-multicast")]
    DirectSocketsMulticast,
    /// <summary>
    /// Corresponds to the <c>"display-capture"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("display-capture")]
    DisplayCapture,
    /// <summary>
    /// Corresponds to the <c>"document-domain"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("document-domain")]
    DocumentDomain,
    /// <summary>
    /// Corresponds to the <c>"encrypted-media"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("encrypted-media")]
    EncryptedMedia,
    /// <summary>
    /// Corresponds to the <c>"execution-while-out-of-viewport"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("execution-while-out-of-viewport")]
    ExecutionWhileOutOfViewport,
    /// <summary>
    /// Corresponds to the <c>"execution-while-not-rendered"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("execution-while-not-rendered")]
    ExecutionWhileNotRendered,
    /// <summary>
    /// Corresponds to the <c>"focus-without-user-activation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("focus-without-user-activation")]
    FocusWithoutUserActivation,
    /// <summary>
    /// Corresponds to the <c>"fullscreen"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("fullscreen")]
    Fullscreen,
    /// <summary>
    /// Corresponds to the <c>"frobulate"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("frobulate")]
    Frobulate,
    /// <summary>
    /// Corresponds to the <c>"gamepad"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("gamepad")]
    Gamepad,
    /// <summary>
    /// Corresponds to the <c>"geolocation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("geolocation")]
    Geolocation,
    /// <summary>
    /// Corresponds to the <c>"gyroscope"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("gyroscope")]
    Gyroscope,
    /// <summary>
    /// Corresponds to the <c>"haptics"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("haptics")]
    Haptics,
    /// <summary>
    /// Corresponds to the <c>"hid"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("hid")]
    Hid,
    /// <summary>
    /// Corresponds to the <c>"identity-credentials-get"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("identity-credentials-get")]
    IdentityCredentialsGet,
    /// <summary>
    /// Corresponds to the <c>"idle-detection"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("idle-detection")]
    IdleDetection,
    /// <summary>
    /// Corresponds to the <c>"interest-cohort"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("interest-cohort")]
    InterestCohort,
    /// <summary>
    /// Corresponds to the <c>"keyboard-map"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("keyboard-map")]
    KeyboardMap,
    /// <summary>
    /// Corresponds to the <c>"language-detector"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("language-detector")]
    LanguageDetector,
    /// <summary>
    /// Corresponds to the <c>"language-model"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("language-model")]
    LanguageModel,
    /// <summary>
    /// Corresponds to the <c>"local-fonts"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("local-fonts")]
    LocalFonts,
    /// <summary>
    /// Corresponds to the <c>"local-network"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("local-network")]
    LocalNetwork,
    /// <summary>
    /// Corresponds to the <c>"local-network-access"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("local-network-access")]
    LocalNetworkAccess,
    /// <summary>
    /// Corresponds to the <c>"loopback-network"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("loopback-network")]
    LoopbackNetwork,
    /// <summary>
    /// Corresponds to the <c>"magnetometer"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("magnetometer")]
    Magnetometer,
    /// <summary>
    /// Corresponds to the <c>"manual-text"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("manual-text")]
    ManualText,
    /// <summary>
    /// Corresponds to the <c>"media-playback-while-not-visible"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("media-playback-while-not-visible")]
    MediaPlaybackWhileNotVisible,
    /// <summary>
    /// Corresponds to the <c>"microphone"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("microphone")]
    Microphone,
    /// <summary>
    /// Corresponds to the <c>"midi"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("midi")]
    Midi,
    /// <summary>
    /// Corresponds to the <c>"on-device-speech-recognition"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("on-device-speech-recognition")]
    OnDeviceSpeechRecognition,
    /// <summary>
    /// Corresponds to the <c>"otp-credentials"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("otp-credentials")]
    OtpCredentials,
    /// <summary>
    /// Corresponds to the <c>"payment"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("payment")]
    Payment,
    /// <summary>
    /// Corresponds to the <c>"picture-in-picture"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("picture-in-picture")]
    PictureInPicture,
    /// <summary>
    /// Corresponds to the <c>"private-state-token-issuance"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("private-state-token-issuance")]
    PrivateStateTokenIssuance,
    /// <summary>
    /// Corresponds to the <c>"private-state-token-redemption"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("private-state-token-redemption")]
    PrivateStateTokenRedemption,
    /// <summary>
    /// Corresponds to the <c>"publickey-credentials-create"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("publickey-credentials-create")]
    PublickeyCredentialsCreate,
    /// <summary>
    /// Corresponds to the <c>"publickey-credentials-get"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("publickey-credentials-get")]
    PublickeyCredentialsGet,
    /// <summary>
    /// Corresponds to the <c>"rewriter"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("rewriter")]
    Rewriter,
    /// <summary>
    /// Corresponds to the <c>"screen-wake-lock"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("screen-wake-lock")]
    ScreenWakeLock,
    /// <summary>
    /// Corresponds to the <c>"serial"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("serial")]
    Serial,
    /// <summary>
    /// Corresponds to the <c>"shared-storage"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("shared-storage")]
    SharedStorage,
    /// <summary>
    /// Corresponds to the <c>"shared-storage-select-url"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("shared-storage-select-url")]
    SharedStorageSelectUrl,
    /// <summary>
    /// Corresponds to the <c>"smart-card"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("smart-card")]
    SmartCard,
    /// <summary>
    /// Corresponds to the <c>"speaker-selection"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("speaker-selection")]
    SpeakerSelection,
    /// <summary>
    /// Corresponds to the <c>"storage-access"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("storage-access")]
    StorageAccess,
    /// <summary>
    /// Corresponds to the <c>"sub-apps"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("sub-apps")]
    SubApps,
    /// <summary>
    /// Corresponds to the <c>"summarizer"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("summarizer")]
    Summarizer,
    /// <summary>
    /// Corresponds to the <c>"sync-xhr"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("sync-xhr")]
    SyncXhr,
    /// <summary>
    /// Corresponds to the <c>"tools"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("tools")]
    Tools,
    /// <summary>
    /// Corresponds to the <c>"translator"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("translator")]
    Translator,
    /// <summary>
    /// Corresponds to the <c>"unload"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("unload")]
    Unload,
    /// <summary>
    /// Corresponds to the <c>"usb"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("usb")]
    Usb,
    /// <summary>
    /// Corresponds to the <c>"usb-unrestricted"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("usb-unrestricted")]
    UsbUnrestricted,
    /// <summary>
    /// Corresponds to the <c>"vertical-scroll"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("vertical-scroll")]
    VerticalScroll,
    /// <summary>
    /// Corresponds to the <c>"web-app-installation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("web-app-installation")]
    WebAppInstallation,
    /// <summary>
    /// Corresponds to the <c>"webnn"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("webnn")]
    Webnn,
    /// <summary>
    /// Corresponds to the <c>"web-printing"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("web-printing")]
    WebPrinting,
    /// <summary>
    /// Corresponds to the <c>"web-share"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("web-share")]
    WebShare,
    /// <summary>
    /// Corresponds to the <c>"window-management"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("window-management")]
    WindowManagement,
    /// <summary>
    /// Corresponds to the <c>"writer"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("writer")]
    Writer,
    /// <summary>
    /// Corresponds to the <c>"xr-spatial-tracking"</c> wire value.
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
    /// Corresponds to the <c>"Header"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Header")]
    Header,
    /// <summary>
    /// Corresponds to the <c>"IframeAttribute"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IframeAttribute")]
    IframeAttribute,
    /// <summary>
    /// Corresponds to the <c>"InFencedFrameTree"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InFencedFrameTree")]
    InFencedFrameTree,
    /// <summary>
    /// Corresponds to the <c>"InIsolatedApp"</c> wire value.
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
    /// Corresponds to the <c>"Success"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Success")]
    Success,
    /// <summary>
    /// Corresponds to the <c>"NotSupported"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NotSupported")]
    NotSupported,
    /// <summary>
    /// Corresponds to the <c>"Insecure"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Insecure")]
    Insecure,
    /// <summary>
    /// Corresponds to the <c>"Expired"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Expired")]
    Expired,
    /// <summary>
    /// Corresponds to the <c>"WrongOrigin"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WrongOrigin")]
    WrongOrigin,
    /// <summary>
    /// Corresponds to the <c>"InvalidSignature"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidSignature")]
    InvalidSignature,
    /// <summary>
    /// Corresponds to the <c>"Malformed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Malformed")]
    Malformed,
    /// <summary>
    /// Corresponds to the <c>"WrongVersion"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WrongVersion")]
    WrongVersion,
    /// <summary>
    /// Corresponds to the <c>"FeatureDisabled"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FeatureDisabled")]
    FeatureDisabled,
    /// <summary>
    /// Corresponds to the <c>"TokenDisabled"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenDisabled")]
    TokenDisabled,
    /// <summary>
    /// Corresponds to the <c>"FeatureDisabledForUser"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FeatureDisabledForUser")]
    FeatureDisabledForUser,
    /// <summary>
    /// Corresponds to the <c>"UnknownTrial"</c> wire value.
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
    /// Corresponds to the <c>"Enabled"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Enabled")]
    Enabled,
    /// <summary>
    /// Corresponds to the <c>"ValidTokenNotProvided"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ValidTokenNotProvided")]
    ValidTokenNotProvided,
    /// <summary>
    /// Corresponds to the <c>"OSNotSupported"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("OSNotSupported")]
    OSNotSupported,
    /// <summary>
    /// Corresponds to the <c>"TrialNotAllowed"</c> wire value.
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
    /// Corresponds to the <c>"None"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("None")]
    None,
    /// <summary>
    /// Corresponds to the <c>"Subset"</c> wire value.
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
public sealed record OriginTrial(string TrialName, OriginTrialStatus Status, ImmutableArray<OriginTrialTokenWithStatus> TokensWithStatus)
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
public sealed record Frame(FrameId Id, Network.LoaderId LoaderId, string Url, string DomainAndRegistry, string SecurityOrigin, string MimeType, SecureContextType SecureContextType, CrossOriginIsolatedContextType CrossOriginIsolatedContextType, ImmutableArray<GatedAPIFeatures> GatedAPIFeatures)
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
public sealed record FrameResourceTree(Frame Frame, ImmutableArray<FrameResource> Resources)
{
    /// <summary>
    /// Child frames.
    /// </summary>
    public ImmutableArray<FrameResourceTree>? ChildFrames { get; init; }
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
    public ImmutableArray<FrameTree>? ChildFrames { get; init; }
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
    /// Corresponds to the <c>"link"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("link")]
    Link,
    /// <summary>
    /// Corresponds to the <c>"typed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("typed")]
    Typed,
    /// <summary>
    /// Corresponds to the <c>"address_bar"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("address_bar")]
    AddressBar,
    /// <summary>
    /// Corresponds to the <c>"auto_bookmark"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("auto_bookmark")]
    AutoBookmark,
    /// <summary>
    /// Corresponds to the <c>"auto_subframe"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("auto_subframe")]
    AutoSubframe,
    /// <summary>
    /// Corresponds to the <c>"manual_subframe"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("manual_subframe")]
    ManualSubframe,
    /// <summary>
    /// Corresponds to the <c>"generated"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("generated")]
    Generated,
    /// <summary>
    /// Corresponds to the <c>"auto_toplevel"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("auto_toplevel")]
    AutoToplevel,
    /// <summary>
    /// Corresponds to the <c>"form_submit"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("form_submit")]
    FormSubmit,
    /// <summary>
    /// Corresponds to the <c>"reload"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("reload")]
    Reload,
    /// <summary>
    /// Corresponds to the <c>"keyword"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("keyword")]
    Keyword,
    /// <summary>
    /// Corresponds to the <c>"keyword_generated"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("keyword_generated")]
    KeywordGenerated,
    /// <summary>
    /// Corresponds to the <c>"other"</c> wire value.
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

    /// <summary>
    /// Frame swap timestamp as monotonic time.
    /// </summary>
    public Network.MonotonicTime? MonotonicTimestamp { get; init; }
}

/// <summary>
/// Javascript dialog type.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<DialogType>))]
public enum DialogType
{
    /// <summary>
    /// Corresponds to the <c>"alert"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("alert")]
    Alert,
    /// <summary>
    /// Corresponds to the <c>"confirm"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("confirm")]
    Confirm,
    /// <summary>
    /// Corresponds to the <c>"prompt"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("prompt")]
    Prompt,
    /// <summary>
    /// Corresponds to the <c>"beforeunload"</c> wire value.
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
    /// Corresponds to the <c>"anchorClick"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("anchorClick")]
    AnchorClick,
    /// <summary>
    /// Corresponds to the <c>"formSubmissionGet"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("formSubmissionGet")]
    FormSubmissionGet,
    /// <summary>
    /// Corresponds to the <c>"formSubmissionPost"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("formSubmissionPost")]
    FormSubmissionPost,
    /// <summary>
    /// Corresponds to the <c>"httpHeaderRefresh"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("httpHeaderRefresh")]
    HttpHeaderRefresh,
    /// <summary>
    /// Corresponds to the <c>"initialFrameNavigation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("initialFrameNavigation")]
    InitialFrameNavigation,
    /// <summary>
    /// Corresponds to the <c>"metaTagRefresh"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("metaTagRefresh")]
    MetaTagRefresh,
    /// <summary>
    /// Corresponds to the <c>"other"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("other")]
    Other,
    /// <summary>
    /// Corresponds to the <c>"pageBlockInterstitial"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("pageBlockInterstitial")]
    PageBlockInterstitial,
    /// <summary>
    /// Corresponds to the <c>"reload"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("reload")]
    Reload,
    /// <summary>
    /// Corresponds to the <c>"scriptInitiated"</c> wire value.
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
    /// Corresponds to the <c>"currentTab"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("currentTab")]
    CurrentTab,
    /// <summary>
    /// Corresponds to the <c>"newTab"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("newTab")]
    NewTab,
    /// <summary>
    /// Corresponds to the <c>"newWindow"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("newWindow")]
    NewWindow,
    /// <summary>
    /// Corresponds to the <c>"download"</c> wire value.
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
public sealed record InstallabilityError(string ErrorId, ImmutableArray<InstallabilityErrorArgument> ErrorArguments)
{
}

/// <summary>
/// The referring-policy used for the navigation.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ReferrerPolicy>))]
public enum ReferrerPolicy
{
    /// <summary>
    /// Corresponds to the <c>"noReferrer"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("noReferrer")]
    NoReferrer,
    /// <summary>
    /// Corresponds to the <c>"noReferrerWhenDowngrade"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("noReferrerWhenDowngrade")]
    NoReferrerWhenDowngrade,
    /// <summary>
    /// Corresponds to the <c>"origin"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("origin")]
    Origin,
    /// <summary>
    /// Corresponds to the <c>"originWhenCrossOrigin"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("originWhenCrossOrigin")]
    OriginWhenCrossOrigin,
    /// <summary>
    /// Corresponds to the <c>"sameOrigin"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("sameOrigin")]
    SameOrigin,
    /// <summary>
    /// Corresponds to the <c>"strictOrigin"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("strictOrigin")]
    StrictOrigin,
    /// <summary>
    /// Corresponds to the <c>"strictOriginWhenCrossOrigin"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("strictOriginWhenCrossOrigin")]
    StrictOriginWhenCrossOrigin,
    /// <summary>
    /// Corresponds to the <c>"unsafeUrl"</c> wire value.
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
    public ImmutableArray<string>? Accepts { get; init; }
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
    /// Mimic a map, name is the key, accepts is the value.
    /// </summary>
    public ImmutableArray<FileFilter>? Accepts { get; init; }
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
    public ImmutableArray<FileFilter>? Files { get; init; }
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
    public ImmutableArray<string>? DisplayOverrides { get; init; }

    /// <summary>
    /// The handlers to open files.
    /// </summary>
    public ImmutableArray<FileHandler>? FileHandlers { get; init; }

    /// <summary>
    /// </summary>
    public ImmutableArray<ImageResource>? Icons { get; init; }

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
    public ImmutableArray<ProtocolHandler>? ProtocolHandlers { get; init; }

    /// <summary>
    /// </summary>
    public ImmutableArray<RelatedApplication>? RelatedApplications { get; init; }

    /// <summary>
    /// </summary>
    public string? Scope { get; init; }

    /// <summary>
    /// Non-standard, see
    /// https://github.com/WICG/manifest-incubations/blob/gh-pages/scope_extensions-explainer.md
    /// </summary>
    public ImmutableArray<ScopeExtension>? ScopeExtensions { get; init; }

    /// <summary>
    /// The screenshots used by chromium.
    /// </summary>
    public ImmutableArray<Screenshot>? Screenshots { get; init; }

    /// <summary>
    /// </summary>
    public ShareTarget? ShareTarget { get; init; }

    /// <summary>
    /// </summary>
    public string? ShortName { get; init; }

    /// <summary>
    /// </summary>
    public ImmutableArray<Shortcut>? Shortcuts { get; init; }

    /// <summary>
    /// </summary>
    public string? StartUrl { get; init; }

    /// <summary>
    /// </summary>
    public string? ThemeColor { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Name">
/// Display name of the sub-app.
/// </param>
/// <param name="Scope">
/// Scope of the sub-app.
/// </param>
/// <param name="ManifestId">
/// Manifest id of the sub-app.
/// </param>
/// <param name="StartUrl">
/// Start URL of the sub-app.
/// </param>
public sealed record SubApp(string Name, string Scope, string ManifestId, string StartUrl)
{
}

/// <summary>
/// The type of a frameNavigated event.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<NavigationType>))]
public enum NavigationType
{
    /// <summary>
    /// Corresponds to the <c>"Navigation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Navigation")]
    Navigation,
    /// <summary>
    /// Corresponds to the <c>"BackForwardCacheRestore"</c> wire value.
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
    /// Corresponds to the <c>"NotPrimaryMainFrame"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NotPrimaryMainFrame")]
    NotPrimaryMainFrame,
    /// <summary>
    /// Corresponds to the <c>"BackForwardCacheDisabled"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BackForwardCacheDisabled")]
    BackForwardCacheDisabled,
    /// <summary>
    /// Corresponds to the <c>"RelatedActiveContentsExist"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RelatedActiveContentsExist")]
    RelatedActiveContentsExist,
    /// <summary>
    /// Corresponds to the <c>"HTTPStatusNotOK"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("HTTPStatusNotOK")]
    HTTPStatusNotOK,
    /// <summary>
    /// Corresponds to the <c>"SchemeNotHTTPOrHTTPS"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SchemeNotHTTPOrHTTPS")]
    SchemeNotHTTPOrHTTPS,
    /// <summary>
    /// Corresponds to the <c>"Loading"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Loading")]
    Loading,
    /// <summary>
    /// Corresponds to the <c>"WasGrantedMediaAccess"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WasGrantedMediaAccess")]
    WasGrantedMediaAccess,
    /// <summary>
    /// Corresponds to the <c>"DisableForRenderFrameHostCalled"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DisableForRenderFrameHostCalled")]
    DisableForRenderFrameHostCalled,
    /// <summary>
    /// Corresponds to the <c>"DomainNotAllowed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DomainNotAllowed")]
    DomainNotAllowed,
    /// <summary>
    /// Corresponds to the <c>"HTTPMethodNotGET"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("HTTPMethodNotGET")]
    HTTPMethodNotGET,
    /// <summary>
    /// Corresponds to the <c>"SubframeIsNavigating"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SubframeIsNavigating")]
    SubframeIsNavigating,
    /// <summary>
    /// Corresponds to the <c>"Timeout"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Timeout")]
    Timeout,
    /// <summary>
    /// Corresponds to the <c>"CacheLimit"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CacheLimit")]
    CacheLimit,
    /// <summary>
    /// Corresponds to the <c>"JavaScriptExecution"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("JavaScriptExecution")]
    JavaScriptExecution,
    /// <summary>
    /// Corresponds to the <c>"RendererProcessKilled"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RendererProcessKilled")]
    RendererProcessKilled,
    /// <summary>
    /// Corresponds to the <c>"RendererProcessCrashed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RendererProcessCrashed")]
    RendererProcessCrashed,
    /// <summary>
    /// Corresponds to the <c>"SchedulerTrackedFeatureUsed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SchedulerTrackedFeatureUsed")]
    SchedulerTrackedFeatureUsed,
    /// <summary>
    /// Corresponds to the <c>"ConflictingBrowsingInstance"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ConflictingBrowsingInstance")]
    ConflictingBrowsingInstance,
    /// <summary>
    /// Corresponds to the <c>"CacheFlushed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CacheFlushed")]
    CacheFlushed,
    /// <summary>
    /// Corresponds to the <c>"ServiceWorkerVersionActivation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ServiceWorkerVersionActivation")]
    ServiceWorkerVersionActivation,
    /// <summary>
    /// Corresponds to the <c>"SessionRestored"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SessionRestored")]
    SessionRestored,
    /// <summary>
    /// Corresponds to the <c>"ServiceWorkerPostMessage"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ServiceWorkerPostMessage")]
    ServiceWorkerPostMessage,
    /// <summary>
    /// Corresponds to the <c>"EnteredBackForwardCacheBeforeServiceWorkerHostAdded"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EnteredBackForwardCacheBeforeServiceWorkerHostAdded")]
    EnteredBackForwardCacheBeforeServiceWorkerHostAdded,
    /// <summary>
    /// Corresponds to the <c>"RenderFrameHostReused_SameSite"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RenderFrameHostReused_SameSite")]
    RenderFrameHostReusedSameSite,
    /// <summary>
    /// Corresponds to the <c>"RenderFrameHostReused_CrossSite"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RenderFrameHostReused_CrossSite")]
    RenderFrameHostReusedCrossSite,
    /// <summary>
    /// Corresponds to the <c>"ServiceWorkerClaim"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ServiceWorkerClaim")]
    ServiceWorkerClaim,
    /// <summary>
    /// Corresponds to the <c>"IgnoreEventAndEvict"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IgnoreEventAndEvict")]
    IgnoreEventAndEvict,
    /// <summary>
    /// Corresponds to the <c>"HaveInnerContents"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("HaveInnerContents")]
    HaveInnerContents,
    /// <summary>
    /// Corresponds to the <c>"TimeoutPuttingInCache"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TimeoutPuttingInCache")]
    TimeoutPuttingInCache,
    /// <summary>
    /// Corresponds to the <c>"BackForwardCacheDisabledByLowMemory"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BackForwardCacheDisabledByLowMemory")]
    BackForwardCacheDisabledByLowMemory,
    /// <summary>
    /// Corresponds to the <c>"BackForwardCacheDisabledByCommandLine"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BackForwardCacheDisabledByCommandLine")]
    BackForwardCacheDisabledByCommandLine,
    /// <summary>
    /// Corresponds to the <c>"NetworkRequestDatapipeDrainedAsBytesConsumer"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NetworkRequestDatapipeDrainedAsBytesConsumer")]
    NetworkRequestDatapipeDrainedAsBytesConsumer,
    /// <summary>
    /// Corresponds to the <c>"NetworkRequestRedirected"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NetworkRequestRedirected")]
    NetworkRequestRedirected,
    /// <summary>
    /// Corresponds to the <c>"NetworkRequestTimeout"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NetworkRequestTimeout")]
    NetworkRequestTimeout,
    /// <summary>
    /// Corresponds to the <c>"NetworkExceedsBufferLimit"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NetworkExceedsBufferLimit")]
    NetworkExceedsBufferLimit,
    /// <summary>
    /// Corresponds to the <c>"NavigationCancelledWhileRestoring"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NavigationCancelledWhileRestoring")]
    NavigationCancelledWhileRestoring,
    /// <summary>
    /// Corresponds to the <c>"NotMostRecentNavigationEntry"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NotMostRecentNavigationEntry")]
    NotMostRecentNavigationEntry,
    /// <summary>
    /// Corresponds to the <c>"BackForwardCacheDisabledForPrerender"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BackForwardCacheDisabledForPrerender")]
    BackForwardCacheDisabledForPrerender,
    /// <summary>
    /// Corresponds to the <c>"UserAgentOverrideDiffers"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UserAgentOverrideDiffers")]
    UserAgentOverrideDiffers,
    /// <summary>
    /// Corresponds to the <c>"ForegroundCacheLimit"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ForegroundCacheLimit")]
    ForegroundCacheLimit,
    /// <summary>
    /// Corresponds to the <c>"ForwardCacheDisabled"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ForwardCacheDisabled")]
    ForwardCacheDisabled,
    /// <summary>
    /// Corresponds to the <c>"BrowsingInstanceNotSwapped"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BrowsingInstanceNotSwapped")]
    BrowsingInstanceNotSwapped,
    /// <summary>
    /// Corresponds to the <c>"BackForwardCacheDisabledForDelegate"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BackForwardCacheDisabledForDelegate")]
    BackForwardCacheDisabledForDelegate,
    /// <summary>
    /// Corresponds to the <c>"UnloadHandlerExistsInMainFrame"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UnloadHandlerExistsInMainFrame")]
    UnloadHandlerExistsInMainFrame,
    /// <summary>
    /// Corresponds to the <c>"UnloadHandlerExistsInSubFrame"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UnloadHandlerExistsInSubFrame")]
    UnloadHandlerExistsInSubFrame,
    /// <summary>
    /// Corresponds to the <c>"ServiceWorkerUnregistration"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ServiceWorkerUnregistration")]
    ServiceWorkerUnregistration,
    /// <summary>
    /// Corresponds to the <c>"CacheControlNoStore"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CacheControlNoStore")]
    CacheControlNoStore,
    /// <summary>
    /// Corresponds to the <c>"CacheControlNoStoreCookieModified"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CacheControlNoStoreCookieModified")]
    CacheControlNoStoreCookieModified,
    /// <summary>
    /// Corresponds to the <c>"CacheControlNoStoreHTTPOnlyCookieModified"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CacheControlNoStoreHTTPOnlyCookieModified")]
    CacheControlNoStoreHTTPOnlyCookieModified,
    /// <summary>
    /// Corresponds to the <c>"NoResponseHead"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NoResponseHead")]
    NoResponseHead,
    /// <summary>
    /// Corresponds to the <c>"Unknown"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Unknown")]
    Unknown,
    /// <summary>
    /// Corresponds to the <c>"ActivationNavigationsDisallowedForBug1234857"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ActivationNavigationsDisallowedForBug1234857")]
    ActivationNavigationsDisallowedForBug1234857,
    /// <summary>
    /// Corresponds to the <c>"ErrorDocument"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ErrorDocument")]
    ErrorDocument,
    /// <summary>
    /// Corresponds to the <c>"FencedFramesEmbedder"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FencedFramesEmbedder")]
    FencedFramesEmbedder,
    /// <summary>
    /// Corresponds to the <c>"CookieDisabled"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CookieDisabled")]
    CookieDisabled,
    /// <summary>
    /// Corresponds to the <c>"HTTPAuthRequired"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("HTTPAuthRequired")]
    HTTPAuthRequired,
    /// <summary>
    /// Corresponds to the <c>"CookieFlushed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CookieFlushed")]
    CookieFlushed,
    /// <summary>
    /// Corresponds to the <c>"BroadcastChannelOnMessage"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BroadcastChannelOnMessage")]
    BroadcastChannelOnMessage,
    /// <summary>
    /// Corresponds to the <c>"WebViewSettingsChanged"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebViewSettingsChanged")]
    WebViewSettingsChanged,
    /// <summary>
    /// Corresponds to the <c>"WebViewJavaScriptObjectChanged"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebViewJavaScriptObjectChanged")]
    WebViewJavaScriptObjectChanged,
    /// <summary>
    /// Corresponds to the <c>"WebViewMessageListenerInjected"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebViewMessageListenerInjected")]
    WebViewMessageListenerInjected,
    /// <summary>
    /// Corresponds to the <c>"WebViewSafeBrowsingAllowlistChanged"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebViewSafeBrowsingAllowlistChanged")]
    WebViewSafeBrowsingAllowlistChanged,
    /// <summary>
    /// Corresponds to the <c>"WebViewDocumentStartJavascriptChanged"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebViewDocumentStartJavascriptChanged")]
    WebViewDocumentStartJavascriptChanged,
    /// <summary>
    /// Corresponds to the <c>"WebSocket"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebSocket")]
    WebSocket,
    /// <summary>
    /// Corresponds to the <c>"WebTransport"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebTransport")]
    WebTransport,
    /// <summary>
    /// Corresponds to the <c>"WebRTC"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebRTC")]
    WebRTC,
    /// <summary>
    /// Corresponds to the <c>"MainResourceHasCacheControlNoStore"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MainResourceHasCacheControlNoStore")]
    MainResourceHasCacheControlNoStore,
    /// <summary>
    /// Corresponds to the <c>"MainResourceHasCacheControlNoCache"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MainResourceHasCacheControlNoCache")]
    MainResourceHasCacheControlNoCache,
    /// <summary>
    /// Corresponds to the <c>"SubresourceHasCacheControlNoStore"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SubresourceHasCacheControlNoStore")]
    SubresourceHasCacheControlNoStore,
    /// <summary>
    /// Corresponds to the <c>"SubresourceHasCacheControlNoCache"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SubresourceHasCacheControlNoCache")]
    SubresourceHasCacheControlNoCache,
    /// <summary>
    /// Corresponds to the <c>"ContainsPlugins"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContainsPlugins")]
    ContainsPlugins,
    /// <summary>
    /// Corresponds to the <c>"DocumentLoaded"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DocumentLoaded")]
    DocumentLoaded,
    /// <summary>
    /// Corresponds to the <c>"OutstandingNetworkRequestOthers"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("OutstandingNetworkRequestOthers")]
    OutstandingNetworkRequestOthers,
    /// <summary>
    /// Corresponds to the <c>"RequestedMIDIPermission"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RequestedMIDIPermission")]
    RequestedMIDIPermission,
    /// <summary>
    /// Corresponds to the <c>"RequestedAudioCapturePermission"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RequestedAudioCapturePermission")]
    RequestedAudioCapturePermission,
    /// <summary>
    /// Corresponds to the <c>"RequestedVideoCapturePermission"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RequestedVideoCapturePermission")]
    RequestedVideoCapturePermission,
    /// <summary>
    /// Corresponds to the <c>"RequestedBackForwardCacheBlockedSensors"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RequestedBackForwardCacheBlockedSensors")]
    RequestedBackForwardCacheBlockedSensors,
    /// <summary>
    /// Corresponds to the <c>"RequestedBackgroundWorkPermission"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RequestedBackgroundWorkPermission")]
    RequestedBackgroundWorkPermission,
    /// <summary>
    /// Corresponds to the <c>"BroadcastChannel"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BroadcastChannel")]
    BroadcastChannel,
    /// <summary>
    /// Corresponds to the <c>"WebXR"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebXR")]
    WebXR,
    /// <summary>
    /// Corresponds to the <c>"SharedWorker"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SharedWorker")]
    SharedWorker,
    /// <summary>
    /// Corresponds to the <c>"SharedWorkerMessage"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SharedWorkerMessage")]
    SharedWorkerMessage,
    /// <summary>
    /// Corresponds to the <c>"SharedWorkerWithNoActiveClient"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SharedWorkerWithNoActiveClient")]
    SharedWorkerWithNoActiveClient,
    /// <summary>
    /// Corresponds to the <c>"WebLocks"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebLocks")]
    WebLocks,
    /// <summary>
    /// Corresponds to the <c>"WebLocksContention"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebLocksContention")]
    WebLocksContention,
    /// <summary>
    /// Corresponds to the <c>"WebHID"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebHID")]
    WebHID,
    /// <summary>
    /// Corresponds to the <c>"WebBluetooth"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebBluetooth")]
    WebBluetooth,
    /// <summary>
    /// Corresponds to the <c>"WebShare"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebShare")]
    WebShare,
    /// <summary>
    /// Corresponds to the <c>"RequestedStorageAccessGrant"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RequestedStorageAccessGrant")]
    RequestedStorageAccessGrant,
    /// <summary>
    /// Corresponds to the <c>"WebNfc"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebNfc")]
    WebNfc,
    /// <summary>
    /// Corresponds to the <c>"OutstandingNetworkRequestFetch"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("OutstandingNetworkRequestFetch")]
    OutstandingNetworkRequestFetch,
    /// <summary>
    /// Corresponds to the <c>"OutstandingNetworkRequestXHR"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("OutstandingNetworkRequestXHR")]
    OutstandingNetworkRequestXHR,
    /// <summary>
    /// Corresponds to the <c>"AppBanner"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AppBanner")]
    AppBanner,
    /// <summary>
    /// Corresponds to the <c>"Printing"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Printing")]
    Printing,
    /// <summary>
    /// Corresponds to the <c>"WebDatabase"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebDatabase")]
    WebDatabase,
    /// <summary>
    /// Corresponds to the <c>"PictureInPicture"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PictureInPicture")]
    PictureInPicture,
    /// <summary>
    /// Corresponds to the <c>"SpeechRecognizer"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SpeechRecognizer")]
    SpeechRecognizer,
    /// <summary>
    /// Corresponds to the <c>"IdleManager"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IdleManager")]
    IdleManager,
    /// <summary>
    /// Corresponds to the <c>"PaymentManager"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PaymentManager")]
    PaymentManager,
    /// <summary>
    /// Corresponds to the <c>"SpeechSynthesis"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SpeechSynthesis")]
    SpeechSynthesis,
    /// <summary>
    /// Corresponds to the <c>"KeyboardLock"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("KeyboardLock")]
    KeyboardLock,
    /// <summary>
    /// Corresponds to the <c>"WebOTPService"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebOTPService")]
    WebOTPService,
    /// <summary>
    /// Corresponds to the <c>"OutstandingNetworkRequestDirectSocket"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("OutstandingNetworkRequestDirectSocket")]
    OutstandingNetworkRequestDirectSocket,
    /// <summary>
    /// Corresponds to the <c>"InjectedJavascript"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InjectedJavascript")]
    InjectedJavascript,
    /// <summary>
    /// Corresponds to the <c>"InjectedStyleSheet"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InjectedStyleSheet")]
    InjectedStyleSheet,
    /// <summary>
    /// Corresponds to the <c>"KeepaliveRequest"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("KeepaliveRequest")]
    KeepaliveRequest,
    /// <summary>
    /// Corresponds to the <c>"IndexedDBEvent"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IndexedDBEvent")]
    IndexedDBEvent,
    /// <summary>
    /// Corresponds to the <c>"Dummy"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Dummy")]
    Dummy,
    /// <summary>
    /// Corresponds to the <c>"JsNetworkRequestReceivedCacheControlNoStoreResource"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("JsNetworkRequestReceivedCacheControlNoStoreResource")]
    JsNetworkRequestReceivedCacheControlNoStoreResource,
    /// <summary>
    /// Corresponds to the <c>"WebRTCUsedWithCCNS"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebRTCUsedWithCCNS")]
    WebRTCUsedWithCCNS,
    /// <summary>
    /// Corresponds to the <c>"WebTransportUsedWithCCNS"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebTransportUsedWithCCNS")]
    WebTransportUsedWithCCNS,
    /// <summary>
    /// Corresponds to the <c>"WebSocketUsedWithCCNS"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebSocketUsedWithCCNS")]
    WebSocketUsedWithCCNS,
    /// <summary>
    /// Corresponds to the <c>"SmartCard"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SmartCard")]
    SmartCard,
    /// <summary>
    /// Corresponds to the <c>"LiveMediaStreamTrack"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("LiveMediaStreamTrack")]
    LiveMediaStreamTrack,
    /// <summary>
    /// Corresponds to the <c>"UnloadHandler"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UnloadHandler")]
    UnloadHandler,
    /// <summary>
    /// Corresponds to the <c>"ParserAborted"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ParserAborted")]
    ParserAborted,
    /// <summary>
    /// Corresponds to the <c>"ContentSecurityHandler"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentSecurityHandler")]
    ContentSecurityHandler,
    /// <summary>
    /// Corresponds to the <c>"ContentWebAuthenticationAPI"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentWebAuthenticationAPI")]
    ContentWebAuthenticationAPI,
    /// <summary>
    /// Corresponds to the <c>"ContentFileChooser"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentFileChooser")]
    ContentFileChooser,
    /// <summary>
    /// Corresponds to the <c>"ContentSerial"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentSerial")]
    ContentSerial,
    /// <summary>
    /// Corresponds to the <c>"ContentFileSystemAccess"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentFileSystemAccess")]
    ContentFileSystemAccess,
    /// <summary>
    /// Corresponds to the <c>"ContentMediaDevicesDispatcherHost"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentMediaDevicesDispatcherHost")]
    ContentMediaDevicesDispatcherHost,
    /// <summary>
    /// Corresponds to the <c>"ContentWebBluetooth"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentWebBluetooth")]
    ContentWebBluetooth,
    /// <summary>
    /// Corresponds to the <c>"ContentWebUSB"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentWebUSB")]
    ContentWebUSB,
    /// <summary>
    /// Corresponds to the <c>"ContentMediaSessionService"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentMediaSessionService")]
    ContentMediaSessionService,
    /// <summary>
    /// Corresponds to the <c>"ContentScreenReader"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentScreenReader")]
    ContentScreenReader,
    /// <summary>
    /// Corresponds to the <c>"ContentDiscarded"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentDiscarded")]
    ContentDiscarded,
    /// <summary>
    /// Corresponds to the <c>"EmbedderPopupBlockerTabHelper"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderPopupBlockerTabHelper")]
    EmbedderPopupBlockerTabHelper,
    /// <summary>
    /// Corresponds to the <c>"EmbedderSafeBrowsingTriggeredPopupBlocker"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderSafeBrowsingTriggeredPopupBlocker")]
    EmbedderSafeBrowsingTriggeredPopupBlocker,
    /// <summary>
    /// Corresponds to the <c>"EmbedderSafeBrowsingThreatDetails"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderSafeBrowsingThreatDetails")]
    EmbedderSafeBrowsingThreatDetails,
    /// <summary>
    /// Corresponds to the <c>"EmbedderAppBannerManager"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderAppBannerManager")]
    EmbedderAppBannerManager,
    /// <summary>
    /// Corresponds to the <c>"EmbedderDomDistillerViewerSource"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderDomDistillerViewerSource")]
    EmbedderDomDistillerViewerSource,
    /// <summary>
    /// Corresponds to the <c>"EmbedderDomDistillerSelfDeletingRequestDelegate"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderDomDistillerSelfDeletingRequestDelegate")]
    EmbedderDomDistillerSelfDeletingRequestDelegate,
    /// <summary>
    /// Corresponds to the <c>"EmbedderOomInterventionTabHelper"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderOomInterventionTabHelper")]
    EmbedderOomInterventionTabHelper,
    /// <summary>
    /// Corresponds to the <c>"EmbedderOfflinePage"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderOfflinePage")]
    EmbedderOfflinePage,
    /// <summary>
    /// Corresponds to the <c>"EmbedderChromePasswordManagerClientBindCredentialManager"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderChromePasswordManagerClientBindCredentialManager")]
    EmbedderChromePasswordManagerClientBindCredentialManager,
    /// <summary>
    /// Corresponds to the <c>"EmbedderPermissionRequestManager"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderPermissionRequestManager")]
    EmbedderPermissionRequestManager,
    /// <summary>
    /// Corresponds to the <c>"EmbedderModalDialog"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderModalDialog")]
    EmbedderModalDialog,
    /// <summary>
    /// Corresponds to the <c>"EmbedderExtensions"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderExtensions")]
    EmbedderExtensions,
    /// <summary>
    /// Corresponds to the <c>"EmbedderExtensionMessaging"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderExtensionMessaging")]
    EmbedderExtensionMessaging,
    /// <summary>
    /// Corresponds to the <c>"EmbedderExtensionMessagingForOpenPort"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderExtensionMessagingForOpenPort")]
    EmbedderExtensionMessagingForOpenPort,
    /// <summary>
    /// Corresponds to the <c>"EmbedderExtensionSentMessageToCachedFrame"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderExtensionSentMessageToCachedFrame")]
    EmbedderExtensionSentMessageToCachedFrame,
    /// <summary>
    /// Corresponds to the <c>"EmbedderExtensionFrame"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderExtensionFrame")]
    EmbedderExtensionFrame,
    /// <summary>
    /// Corresponds to the <c>"EmbedderPrivilegedWebContents"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderPrivilegedWebContents")]
    EmbedderPrivilegedWebContents,
    /// <summary>
    /// Corresponds to the <c>"RequestedByWebViewClient"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RequestedByWebViewClient")]
    RequestedByWebViewClient,
    /// <summary>
    /// Corresponds to the <c>"PostMessageByWebViewClient"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PostMessageByWebViewClient")]
    PostMessageByWebViewClient,
    /// <summary>
    /// Corresponds to the <c>"CacheControlNoStoreDeviceBoundSessionTerminated"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CacheControlNoStoreDeviceBoundSessionTerminated")]
    CacheControlNoStoreDeviceBoundSessionTerminated,
    /// <summary>
    /// Corresponds to the <c>"CacheLimitPrunedOnModerateMemoryPressure"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CacheLimitPrunedOnModerateMemoryPressure")]
    CacheLimitPrunedOnModerateMemoryPressure,
    /// <summary>
    /// Corresponds to the <c>"CacheLimitPrunedOnCriticalMemoryPressure"</c> wire value.
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
    /// Corresponds to the <c>"SupportPending"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SupportPending")]
    SupportPending,
    /// <summary>
    /// Corresponds to the <c>"PageSupportNeeded"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PageSupportNeeded")]
    PageSupportNeeded,
    /// <summary>
    /// Corresponds to the <c>"Circumstantial"</c> wire value.
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
    public ImmutableArray<BackForwardCacheBlockingDetails>? Details { get; init; }
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
public sealed record BackForwardCacheNotRestoredExplanationTree(string Url, ImmutableArray<BackForwardCacheNotRestoredExplanation> Explanations, ImmutableArray<BackForwardCacheNotRestoredExplanationTree> Children)
{
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<CaptureScreenshotFormat>))]
public enum CaptureScreenshotFormat
{
    /// <summary>
    /// Corresponds to the <c>"jpeg"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("jpeg")]
    Jpeg,
    /// <summary>
    /// Corresponds to the <c>"png"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("png")]
    Png,
    /// <summary>
    /// Corresponds to the <c>"webp"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("webp")]
    Webp,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<CaptureSnapshotFormat>))]
public enum CaptureSnapshotFormat
{
    /// <summary>
    /// Corresponds to the <c>"mhtml"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("mhtml")]
    Mhtml,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<PrintToPDFTransferMode>))]
public enum PrintToPDFTransferMode
{
    /// <summary>
    /// Corresponds to the <c>"ReturnAsBase64"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ReturnAsBase64")]
    ReturnAsBase64,
    /// <summary>
    /// Corresponds to the <c>"ReturnAsStream"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ReturnAsStream")]
    ReturnAsStream,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<SetDownloadBehaviorBehavior>))]
public enum SetDownloadBehaviorBehavior
{
    /// <summary>
    /// Corresponds to the <c>"deny"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("deny")]
    Deny,
    /// <summary>
    /// Corresponds to the <c>"allow"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("allow")]
    Allow,
    /// <summary>
    /// Corresponds to the <c>"default"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("default")]
    Default,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<SetTouchEmulationEnabledConfiguration>))]
public enum SetTouchEmulationEnabledConfiguration
{
    /// <summary>
    /// Corresponds to the <c>"mobile"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("mobile")]
    Mobile,
    /// <summary>
    /// Corresponds to the <c>"desktop"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("desktop")]
    Desktop,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<StartScreencastFormat>))]
public enum StartScreencastFormat
{
    /// <summary>
    /// Corresponds to the <c>"jpeg"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("jpeg")]
    Jpeg,
    /// <summary>
    /// Corresponds to the <c>"png"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("png")]
    Png,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<SetWebLifecycleStateState>))]
public enum SetWebLifecycleStateState
{
    /// <summary>
    /// Corresponds to the <c>"frozen"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("frozen")]
    Frozen,
    /// <summary>
    /// Corresponds to the <c>"active"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("active")]
    Active,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<SetSPCTransactionModeMode>))]
public enum SetSPCTransactionModeMode
{
    /// <summary>
    /// Corresponds to the <c>"none"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("none")]
    None,
    /// <summary>
    /// Corresponds to the <c>"autoAccept"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("autoAccept")]
    AutoAccept,
    /// <summary>
    /// Corresponds to the <c>"autoChooseToAuthAnotherWay"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("autoChooseToAuthAnotherWay")]
    AutoChooseToAuthAnotherWay,
    /// <summary>
    /// Corresponds to the <c>"autoReject"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("autoReject")]
    AutoReject,
    /// <summary>
    /// Corresponds to the <c>"autoOptOut"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("autoOptOut")]
    AutoOptOut,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<SetRPHRegistrationModeMode>))]
public enum SetRPHRegistrationModeMode
{
    /// <summary>
    /// Corresponds to the <c>"none"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("none")]
    None,
    /// <summary>
    /// Corresponds to the <c>"autoAccept"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("autoAccept")]
    AutoAccept,
    /// <summary>
    /// Corresponds to the <c>"autoReject"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("autoReject")]
    AutoReject,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<FileChooserOpenedMode>))]
public enum FileChooserOpenedMode
{
    /// <summary>
    /// Corresponds to the <c>"selectSingle"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("selectSingle")]
    SelectSingle,
    /// <summary>
    /// Corresponds to the <c>"selectMultiple"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("selectMultiple")]
    SelectMultiple,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<FrameDetachedReason>))]
public enum FrameDetachedReason
{
    /// <summary>
    /// Corresponds to the <c>"remove"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("remove")]
    Remove,
    /// <summary>
    /// Corresponds to the <c>"swap"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("swap")]
    Swap,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<FrameStartedNavigatingNavigationType>))]
public enum FrameStartedNavigatingNavigationType
{
    /// <summary>
    /// Corresponds to the <c>"reload"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("reload")]
    Reload,
    /// <summary>
    /// Corresponds to the <c>"reloadBypassingCache"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("reloadBypassingCache")]
    ReloadBypassingCache,
    /// <summary>
    /// Corresponds to the <c>"restore"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("restore")]
    Restore,
    /// <summary>
    /// Corresponds to the <c>"restoreWithPost"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("restoreWithPost")]
    RestoreWithPost,
    /// <summary>
    /// Corresponds to the <c>"historySameDocument"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("historySameDocument")]
    HistorySameDocument,
    /// <summary>
    /// Corresponds to the <c>"historyDifferentDocument"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("historyDifferentDocument")]
    HistoryDifferentDocument,
    /// <summary>
    /// Corresponds to the <c>"sameDocument"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("sameDocument")]
    SameDocument,
    /// <summary>
    /// Corresponds to the <c>"differentDocument"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("differentDocument")]
    DifferentDocument,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<DownloadProgressState>))]
public enum DownloadProgressState
{
    /// <summary>
    /// Corresponds to the <c>"inProgress"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("inProgress")]
    InProgress,
    /// <summary>
    /// Corresponds to the <c>"completed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("completed")]
    Completed,
    /// <summary>
    /// Corresponds to the <c>"canceled"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("canceled")]
    Canceled,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<NavigatedWithinDocumentNavigationType>))]
public enum NavigatedWithinDocumentNavigationType
{
    /// <summary>
    /// Corresponds to the <c>"fragment"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("fragment")]
    Fragment,
    /// <summary>
    /// Corresponds to the <c>"historyApi"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("historyApi")]
    HistoryApi,
    /// <summary>
    /// Corresponds to the <c>"other"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("other")]
    Other,
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
[JsonSerializable(typeof(GetSubAppsCommandParameters), TypeInfoPropertyName = "GetSubAppsCommandParameters")]
[JsonSerializable(typeof(GetSubAppsResult), TypeInfoPropertyName = "GetSubAppsResult")]
[JsonSerializable(typeof(GetSiblingSubAppsCommandParameters), TypeInfoPropertyName = "GetSiblingSubAppsCommandParameters")]
[JsonSerializable(typeof(GetSiblingSubAppsResult), TypeInfoPropertyName = "GetSiblingSubAppsResult")]
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
[JsonSerializable(typeof(StartScreenRecordingCommandParameters), TypeInfoPropertyName = "StartScreenRecordingCommandParameters")]
[JsonSerializable(typeof(StartScreenRecordingResult), TypeInfoPropertyName = "StartScreenRecordingResult")]
[JsonSerializable(typeof(StopScreenRecordingCommandParameters), TypeInfoPropertyName = "StopScreenRecordingCommandParameters")]
[JsonSerializable(typeof(StopScreenRecordingResult), TypeInfoPropertyName = "StopScreenRecordingResult")]
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
[JsonSerializable(typeof(SubApp), TypeInfoPropertyName = "PageSubApp")]
[JsonSerializable(typeof(NavigationType), TypeInfoPropertyName = "PageNavigationType")]
[JsonSerializable(typeof(BackForwardCacheNotRestoredReason), TypeInfoPropertyName = "PageBackForwardCacheNotRestoredReason")]
[JsonSerializable(typeof(BackForwardCacheNotRestoredReasonType), TypeInfoPropertyName = "PageBackForwardCacheNotRestoredReasonType")]
[JsonSerializable(typeof(BackForwardCacheBlockingDetails), TypeInfoPropertyName = "PageBackForwardCacheBlockingDetails")]
[JsonSerializable(typeof(BackForwardCacheNotRestoredExplanation), TypeInfoPropertyName = "PageBackForwardCacheNotRestoredExplanation")]
[JsonSerializable(typeof(BackForwardCacheNotRestoredExplanationTree), TypeInfoPropertyName = "PageBackForwardCacheNotRestoredExplanationTree")]
[JsonSerializable(typeof(ImmutableArray<AppManifestError>), TypeInfoPropertyName = "ImmutableArrayPageAppManifestError")]
[JsonSerializable(typeof(ImmutableArray<InstallabilityError>), TypeInfoPropertyName = "ImmutableArrayPageInstallabilityError")]
[JsonSerializable(typeof(ImmutableArray<SubApp>), TypeInfoPropertyName = "ImmutableArrayPageSubApp")]
[JsonSerializable(typeof(ImmutableArray<NavigationEntry>), TypeInfoPropertyName = "ImmutableArrayPageNavigationEntry")]
[JsonSerializable(typeof(ImmutableArray<Debugger.SearchMatch>), TypeInfoPropertyName = "ImmutableArrayDebuggerSearchMatch")]
[JsonSerializable(typeof(ImmutableArray<PermissionsPolicyFeatureState>), TypeInfoPropertyName = "ImmutableArrayPagePermissionsPolicyFeatureState")]
[JsonSerializable(typeof(ImmutableArray<OriginTrial>), TypeInfoPropertyName = "ImmutableArrayPageOriginTrial")]
[JsonSerializable(typeof(ImmutableArray<ScriptFontFamilies>), TypeInfoPropertyName = "ImmutableArrayPageScriptFontFamilies")]
[JsonSerializable(typeof(ImmutableArray<CompilationCacheParams>), TypeInfoPropertyName = "ImmutableArrayPageCompilationCacheParams")]
[JsonSerializable(typeof(ImmutableArray<BackForwardCacheNotRestoredExplanation>), TypeInfoPropertyName = "ImmutableArrayPageBackForwardCacheNotRestoredExplanation")]
[JsonSerializable(typeof(ImmutableArray<AdFrameExplanation>), TypeInfoPropertyName = "ImmutableArrayPageAdFrameExplanation")]
[JsonSerializable(typeof(ImmutableArray<OriginTrialTokenWithStatus>), TypeInfoPropertyName = "ImmutableArrayPageOriginTrialTokenWithStatus")]
[JsonSerializable(typeof(ImmutableArray<GatedAPIFeatures>), TypeInfoPropertyName = "ImmutableArrayPageGatedAPIFeatures")]
[JsonSerializable(typeof(ImmutableArray<FrameResourceTree>), TypeInfoPropertyName = "ImmutableArrayPageFrameResourceTree")]
[JsonSerializable(typeof(ImmutableArray<FrameResource>), TypeInfoPropertyName = "ImmutableArrayPageFrameResource")]
[JsonSerializable(typeof(ImmutableArray<FrameTree>), TypeInfoPropertyName = "ImmutableArrayPageFrameTree")]
[JsonSerializable(typeof(ImmutableArray<InstallabilityErrorArgument>), TypeInfoPropertyName = "ImmutableArrayPageInstallabilityErrorArgument")]
[JsonSerializable(typeof(ImmutableArray<FileFilter>), TypeInfoPropertyName = "ImmutableArrayPageFileFilter")]
[JsonSerializable(typeof(ImmutableArray<FileHandler>), TypeInfoPropertyName = "ImmutableArrayPageFileHandler")]
[JsonSerializable(typeof(ImmutableArray<ImageResource>), TypeInfoPropertyName = "ImmutableArrayPageImageResource")]
[JsonSerializable(typeof(ImmutableArray<ProtocolHandler>), TypeInfoPropertyName = "ImmutableArrayPageProtocolHandler")]
[JsonSerializable(typeof(ImmutableArray<RelatedApplication>), TypeInfoPropertyName = "ImmutableArrayPageRelatedApplication")]
[JsonSerializable(typeof(ImmutableArray<ScopeExtension>), TypeInfoPropertyName = "ImmutableArrayPageScopeExtension")]
[JsonSerializable(typeof(ImmutableArray<Screenshot>), TypeInfoPropertyName = "ImmutableArrayPageScreenshot")]
[JsonSerializable(typeof(ImmutableArray<Shortcut>), TypeInfoPropertyName = "ImmutableArrayPageShortcut")]
[JsonSerializable(typeof(ImmutableArray<BackForwardCacheBlockingDetails>), TypeInfoPropertyName = "ImmutableArrayPageBackForwardCacheBlockingDetails")]
[JsonSerializable(typeof(ImmutableArray<BackForwardCacheNotRestoredExplanationTree>), TypeInfoPropertyName = "ImmutableArrayPageBackForwardCacheNotRestoredExplanationTree")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class PageJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="IPage"/>.
/// </summary>
public static class PageDomainEvent
{
    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DomContentEventFiredEventArgs>> DomContentEventFired =>
        _domContentEventFired ?? global::System.Threading.Interlocked.CompareExchange(ref _domContentEventFired, EventDescriptor<CdpEventArgs<DomContentEventFiredEventArgs>>.Create(
            "goog:cdp.Page.domContentEventFired",
            PageJsonSerializerContext.Default.DomContentEventFiredCdpEventArgs), null) ?? _domContentEventFired;
    private static EventDescriptor<CdpEventArgs<DomContentEventFiredEventArgs>>? _domContentEventFired;

    /// <summary>
    /// Emitted only when <b>page.interceptFileChooser</b> is enabled.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FileChooserOpenedEventArgs>> FileChooserOpened =>
        _fileChooserOpened ?? global::System.Threading.Interlocked.CompareExchange(ref _fileChooserOpened, EventDescriptor<CdpEventArgs<FileChooserOpenedEventArgs>>.Create(
            "goog:cdp.Page.fileChooserOpened",
            PageJsonSerializerContext.Default.FileChooserOpenedCdpEventArgs), null) ?? _fileChooserOpened;
    private static EventDescriptor<CdpEventArgs<FileChooserOpenedEventArgs>>? _fileChooserOpened;

    /// <summary>
    /// Fired when frame has been attached to its parent.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FrameAttachedEventArgs>> FrameAttached =>
        _frameAttached ?? global::System.Threading.Interlocked.CompareExchange(ref _frameAttached, EventDescriptor<CdpEventArgs<FrameAttachedEventArgs>>.Create(
            "goog:cdp.Page.frameAttached",
            PageJsonSerializerContext.Default.FrameAttachedCdpEventArgs), null) ?? _frameAttached;
    private static EventDescriptor<CdpEventArgs<FrameAttachedEventArgs>>? _frameAttached;

    /// <summary>
    /// Fired when frame no longer has a scheduled navigation.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FrameClearedScheduledNavigationEventArgs>> FrameClearedScheduledNavigation =>
        _frameClearedScheduledNavigation ?? global::System.Threading.Interlocked.CompareExchange(ref _frameClearedScheduledNavigation, EventDescriptor<CdpEventArgs<FrameClearedScheduledNavigationEventArgs>>.Create(
            "goog:cdp.Page.frameClearedScheduledNavigation",
            PageJsonSerializerContext.Default.FrameClearedScheduledNavigationCdpEventArgs), null) ?? _frameClearedScheduledNavigation;
    private static EventDescriptor<CdpEventArgs<FrameClearedScheduledNavigationEventArgs>>? _frameClearedScheduledNavigation;

    /// <summary>
    /// Fired when frame has been detached from its parent.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FrameDetachedEventArgs>> FrameDetached =>
        _frameDetached ?? global::System.Threading.Interlocked.CompareExchange(ref _frameDetached, EventDescriptor<CdpEventArgs<FrameDetachedEventArgs>>.Create(
            "goog:cdp.Page.frameDetached",
            PageJsonSerializerContext.Default.FrameDetachedCdpEventArgs), null) ?? _frameDetached;
    private static EventDescriptor<CdpEventArgs<FrameDetachedEventArgs>>? _frameDetached;

    /// <summary>
    /// Fired before frame subtree is detached. Emitted before any frame of the
    /// subtree is actually detached.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FrameSubtreeWillBeDetachedEventArgs>> FrameSubtreeWillBeDetached =>
        _frameSubtreeWillBeDetached ?? global::System.Threading.Interlocked.CompareExchange(ref _frameSubtreeWillBeDetached, EventDescriptor<CdpEventArgs<FrameSubtreeWillBeDetachedEventArgs>>.Create(
            "goog:cdp.Page.frameSubtreeWillBeDetached",
            PageJsonSerializerContext.Default.FrameSubtreeWillBeDetachedCdpEventArgs), null) ?? _frameSubtreeWillBeDetached;
    private static EventDescriptor<CdpEventArgs<FrameSubtreeWillBeDetachedEventArgs>>? _frameSubtreeWillBeDetached;

    /// <summary>
    /// Fired once navigation of the frame has completed. Frame is now associated with the new loader.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FrameNavigatedEventArgs>> FrameNavigated =>
        _frameNavigated ?? global::System.Threading.Interlocked.CompareExchange(ref _frameNavigated, EventDescriptor<CdpEventArgs<FrameNavigatedEventArgs>>.Create(
            "goog:cdp.Page.frameNavigated",
            PageJsonSerializerContext.Default.FrameNavigatedCdpEventArgs), null) ?? _frameNavigated;
    private static EventDescriptor<CdpEventArgs<FrameNavigatedEventArgs>>? _frameNavigated;

    /// <summary>
    /// Fired when opening document to write to.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DocumentOpenedEventArgs>> DocumentOpened =>
        _documentOpened ?? global::System.Threading.Interlocked.CompareExchange(ref _documentOpened, EventDescriptor<CdpEventArgs<DocumentOpenedEventArgs>>.Create(
            "goog:cdp.Page.documentOpened",
            PageJsonSerializerContext.Default.DocumentOpenedCdpEventArgs), null) ?? _documentOpened;
    private static EventDescriptor<CdpEventArgs<DocumentOpenedEventArgs>>? _documentOpened;

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FrameResizedEventArgs>> FrameResized =>
        _frameResized ?? global::System.Threading.Interlocked.CompareExchange(ref _frameResized, EventDescriptor<CdpEventArgs<FrameResizedEventArgs>>.Create(
            "goog:cdp.Page.frameResized",
            PageJsonSerializerContext.Default.FrameResizedCdpEventArgs), null) ?? _frameResized;
    private static EventDescriptor<CdpEventArgs<FrameResizedEventArgs>>? _frameResized;

    /// <summary>
    /// Fired when a navigation starts. This event is fired for both
    /// renderer-initiated and browser-initiated navigations. For renderer-initiated
    /// navigations, the event is fired after <b>frameRequestedNavigation</b>.
    /// Navigation may still be cancelled after the event is issued. Multiple events
    /// can be fired for a single navigation, for example, when a same-document
    /// navigation becomes a cross-document navigation (such as in the case of a
    /// frameset).
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FrameStartedNavigatingEventArgs>> FrameStartedNavigating =>
        _frameStartedNavigating ?? global::System.Threading.Interlocked.CompareExchange(ref _frameStartedNavigating, EventDescriptor<CdpEventArgs<FrameStartedNavigatingEventArgs>>.Create(
            "goog:cdp.Page.frameStartedNavigating",
            PageJsonSerializerContext.Default.FrameStartedNavigatingCdpEventArgs), null) ?? _frameStartedNavigating;
    private static EventDescriptor<CdpEventArgs<FrameStartedNavigatingEventArgs>>? _frameStartedNavigating;

    /// <summary>
    /// Fired when a renderer-initiated navigation is requested.
    /// Navigation may still be cancelled after the event is issued.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FrameRequestedNavigationEventArgs>> FrameRequestedNavigation =>
        _frameRequestedNavigation ?? global::System.Threading.Interlocked.CompareExchange(ref _frameRequestedNavigation, EventDescriptor<CdpEventArgs<FrameRequestedNavigationEventArgs>>.Create(
            "goog:cdp.Page.frameRequestedNavigation",
            PageJsonSerializerContext.Default.FrameRequestedNavigationCdpEventArgs), null) ?? _frameRequestedNavigation;
    private static EventDescriptor<CdpEventArgs<FrameRequestedNavigationEventArgs>>? _frameRequestedNavigation;

    /// <summary>
    /// Fired when frame schedules a potential navigation.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FrameScheduledNavigationEventArgs>> FrameScheduledNavigation =>
        _frameScheduledNavigation ?? global::System.Threading.Interlocked.CompareExchange(ref _frameScheduledNavigation, EventDescriptor<CdpEventArgs<FrameScheduledNavigationEventArgs>>.Create(
            "goog:cdp.Page.frameScheduledNavigation",
            PageJsonSerializerContext.Default.FrameScheduledNavigationCdpEventArgs), null) ?? _frameScheduledNavigation;
    private static EventDescriptor<CdpEventArgs<FrameScheduledNavigationEventArgs>>? _frameScheduledNavigation;

    /// <summary>
    /// Fired when frame has started loading.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FrameStartedLoadingEventArgs>> FrameStartedLoading =>
        _frameStartedLoading ?? global::System.Threading.Interlocked.CompareExchange(ref _frameStartedLoading, EventDescriptor<CdpEventArgs<FrameStartedLoadingEventArgs>>.Create(
            "goog:cdp.Page.frameStartedLoading",
            PageJsonSerializerContext.Default.FrameStartedLoadingCdpEventArgs), null) ?? _frameStartedLoading;
    private static EventDescriptor<CdpEventArgs<FrameStartedLoadingEventArgs>>? _frameStartedLoading;

    /// <summary>
    /// Fired when frame has stopped loading.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<FrameStoppedLoadingEventArgs>> FrameStoppedLoading =>
        _frameStoppedLoading ?? global::System.Threading.Interlocked.CompareExchange(ref _frameStoppedLoading, EventDescriptor<CdpEventArgs<FrameStoppedLoadingEventArgs>>.Create(
            "goog:cdp.Page.frameStoppedLoading",
            PageJsonSerializerContext.Default.FrameStoppedLoadingCdpEventArgs), null) ?? _frameStoppedLoading;
    private static EventDescriptor<CdpEventArgs<FrameStoppedLoadingEventArgs>>? _frameStoppedLoading;

    /// <summary>
    /// Fired when page is about to start a download.
    /// Deprecated. Use Browser.downloadWillBegin instead.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DownloadWillBeginEventArgs>> DownloadWillBegin =>
        _downloadWillBegin ?? global::System.Threading.Interlocked.CompareExchange(ref _downloadWillBegin, EventDescriptor<CdpEventArgs<DownloadWillBeginEventArgs>>.Create(
            "goog:cdp.Page.downloadWillBegin",
            PageJsonSerializerContext.Default.DownloadWillBeginCdpEventArgs), null) ?? _downloadWillBegin;
    private static EventDescriptor<CdpEventArgs<DownloadWillBeginEventArgs>>? _downloadWillBegin;

    /// <summary>
    /// Fired when download makes progress. Last call has |done| == true.
    /// Deprecated. Use Browser.downloadProgress instead.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DownloadProgressEventArgs>> DownloadProgress =>
        _downloadProgress ?? global::System.Threading.Interlocked.CompareExchange(ref _downloadProgress, EventDescriptor<CdpEventArgs<DownloadProgressEventArgs>>.Create(
            "goog:cdp.Page.downloadProgress",
            PageJsonSerializerContext.Default.DownloadProgressCdpEventArgs), null) ?? _downloadProgress;
    private static EventDescriptor<CdpEventArgs<DownloadProgressEventArgs>>? _downloadProgress;

    /// <summary>
    /// Fired when interstitial page was hidden
    /// </summary>
    public static EventDescriptor<CdpEventArgs<InterstitialHiddenEventArgs>> InterstitialHidden =>
        _interstitialHidden ?? global::System.Threading.Interlocked.CompareExchange(ref _interstitialHidden, EventDescriptor<CdpEventArgs<InterstitialHiddenEventArgs>>.Create(
            "goog:cdp.Page.interstitialHidden",
            PageJsonSerializerContext.Default.InterstitialHiddenCdpEventArgs), null) ?? _interstitialHidden;
    private static EventDescriptor<CdpEventArgs<InterstitialHiddenEventArgs>>? _interstitialHidden;

    /// <summary>
    /// Fired when interstitial page was shown
    /// </summary>
    public static EventDescriptor<CdpEventArgs<InterstitialShownEventArgs>> InterstitialShown =>
        _interstitialShown ?? global::System.Threading.Interlocked.CompareExchange(ref _interstitialShown, EventDescriptor<CdpEventArgs<InterstitialShownEventArgs>>.Create(
            "goog:cdp.Page.interstitialShown",
            PageJsonSerializerContext.Default.InterstitialShownCdpEventArgs), null) ?? _interstitialShown;
    private static EventDescriptor<CdpEventArgs<InterstitialShownEventArgs>>? _interstitialShown;

    /// <summary>
    /// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) has been
    /// closed.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<JavascriptDialogClosedEventArgs>> JavascriptDialogClosed =>
        _javascriptDialogClosed ?? global::System.Threading.Interlocked.CompareExchange(ref _javascriptDialogClosed, EventDescriptor<CdpEventArgs<JavascriptDialogClosedEventArgs>>.Create(
            "goog:cdp.Page.javascriptDialogClosed",
            PageJsonSerializerContext.Default.JavascriptDialogClosedCdpEventArgs), null) ?? _javascriptDialogClosed;
    private static EventDescriptor<CdpEventArgs<JavascriptDialogClosedEventArgs>>? _javascriptDialogClosed;

    /// <summary>
    /// Fired when a JavaScript initiated dialog (alert, confirm, prompt, or onbeforeunload) is about to
    /// open.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<JavascriptDialogOpeningEventArgs>> JavascriptDialogOpening =>
        _javascriptDialogOpening ?? global::System.Threading.Interlocked.CompareExchange(ref _javascriptDialogOpening, EventDescriptor<CdpEventArgs<JavascriptDialogOpeningEventArgs>>.Create(
            "goog:cdp.Page.javascriptDialogOpening",
            PageJsonSerializerContext.Default.JavascriptDialogOpeningCdpEventArgs), null) ?? _javascriptDialogOpening;
    private static EventDescriptor<CdpEventArgs<JavascriptDialogOpeningEventArgs>>? _javascriptDialogOpening;

    /// <summary>
    /// Fired for lifecycle events (navigation, load, paint, etc) in the current
    /// target (including local frames).
    /// </summary>
    public static EventDescriptor<CdpEventArgs<LifecycleEventEventArgs>> LifecycleEvent =>
        _lifecycleEvent ?? global::System.Threading.Interlocked.CompareExchange(ref _lifecycleEvent, EventDescriptor<CdpEventArgs<LifecycleEventEventArgs>>.Create(
            "goog:cdp.Page.lifecycleEvent",
            PageJsonSerializerContext.Default.LifecycleEventCdpEventArgs), null) ?? _lifecycleEvent;
    private static EventDescriptor<CdpEventArgs<LifecycleEventEventArgs>>? _lifecycleEvent;

    /// <summary>
    /// Fired for failed bfcache history navigations if BackForwardCache feature is enabled. Do
    /// not assume any ordering with the Page.frameNavigated event. This event is fired only for
    /// main-frame history navigation where the document changes (non-same-document navigations),
    /// when bfcache navigation fails.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<BackForwardCacheNotUsedEventArgs>> BackForwardCacheNotUsed =>
        _backForwardCacheNotUsed ?? global::System.Threading.Interlocked.CompareExchange(ref _backForwardCacheNotUsed, EventDescriptor<CdpEventArgs<BackForwardCacheNotUsedEventArgs>>.Create(
            "goog:cdp.Page.backForwardCacheNotUsed",
            PageJsonSerializerContext.Default.BackForwardCacheNotUsedCdpEventArgs), null) ?? _backForwardCacheNotUsed;
    private static EventDescriptor<CdpEventArgs<BackForwardCacheNotUsedEventArgs>>? _backForwardCacheNotUsed;

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<LoadEventFiredEventArgs>> LoadEventFired =>
        _loadEventFired ?? global::System.Threading.Interlocked.CompareExchange(ref _loadEventFired, EventDescriptor<CdpEventArgs<LoadEventFiredEventArgs>>.Create(
            "goog:cdp.Page.loadEventFired",
            PageJsonSerializerContext.Default.LoadEventFiredCdpEventArgs), null) ?? _loadEventFired;
    private static EventDescriptor<CdpEventArgs<LoadEventFiredEventArgs>>? _loadEventFired;

    /// <summary>
    /// Fired when same-document navigation happens, e.g. due to history API usage or anchor navigation.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<NavigatedWithinDocumentEventArgs>> NavigatedWithinDocument =>
        _navigatedWithinDocument ?? global::System.Threading.Interlocked.CompareExchange(ref _navigatedWithinDocument, EventDescriptor<CdpEventArgs<NavigatedWithinDocumentEventArgs>>.Create(
            "goog:cdp.Page.navigatedWithinDocument",
            PageJsonSerializerContext.Default.NavigatedWithinDocumentCdpEventArgs), null) ?? _navigatedWithinDocument;
    private static EventDescriptor<CdpEventArgs<NavigatedWithinDocumentEventArgs>>? _navigatedWithinDocument;

    /// <summary>
    /// Compressed image data requested by the <b>startScreencast</b>.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ScreencastFrameEventArgs>> ScreencastFrame =>
        _screencastFrame ?? global::System.Threading.Interlocked.CompareExchange(ref _screencastFrame, EventDescriptor<CdpEventArgs<ScreencastFrameEventArgs>>.Create(
            "goog:cdp.Page.screencastFrame",
            PageJsonSerializerContext.Default.ScreencastFrameCdpEventArgs), null) ?? _screencastFrame;
    private static EventDescriptor<CdpEventArgs<ScreencastFrameEventArgs>>? _screencastFrame;

    /// <summary>
    /// Fired when the page with currently enabled screencast was shown or hidden `.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ScreencastVisibilityChangedEventArgs>> ScreencastVisibilityChanged =>
        _screencastVisibilityChanged ?? global::System.Threading.Interlocked.CompareExchange(ref _screencastVisibilityChanged, EventDescriptor<CdpEventArgs<ScreencastVisibilityChangedEventArgs>>.Create(
            "goog:cdp.Page.screencastVisibilityChanged",
            PageJsonSerializerContext.Default.ScreencastVisibilityChangedCdpEventArgs), null) ?? _screencastVisibilityChanged;
    private static EventDescriptor<CdpEventArgs<ScreencastVisibilityChangedEventArgs>>? _screencastVisibilityChanged;

    /// <summary>
    /// Fired when a new window is going to be opened, via window.open(), link click, form submission,
    /// etc.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<WindowOpenEventArgs>> WindowOpen =>
        _windowOpen ?? global::System.Threading.Interlocked.CompareExchange(ref _windowOpen, EventDescriptor<CdpEventArgs<WindowOpenEventArgs>>.Create(
            "goog:cdp.Page.windowOpen",
            PageJsonSerializerContext.Default.WindowOpenCdpEventArgs), null) ?? _windowOpen;
    private static EventDescriptor<CdpEventArgs<WindowOpenEventArgs>>? _windowOpen;

    /// <summary>
    /// Issued for every compilation cache generated.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<CompilationCacheProducedEventArgs>> CompilationCacheProduced =>
        _compilationCacheProduced ?? global::System.Threading.Interlocked.CompareExchange(ref _compilationCacheProduced, EventDescriptor<CdpEventArgs<CompilationCacheProducedEventArgs>>.Create(
            "goog:cdp.Page.compilationCacheProduced",
            PageJsonSerializerContext.Default.CompilationCacheProducedCdpEventArgs), null) ?? _compilationCacheProduced;
    private static EventDescriptor<CdpEventArgs<CompilationCacheProducedEventArgs>>? _compilationCacheProduced;

}
