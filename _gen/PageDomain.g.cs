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
    Task<AddScriptToEvaluateOnLoadResult> AddScriptToEvaluateOnLoadAsync(string scriptSource, string? session = default, CancellationToken cancellationToken = default);

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
    Task<AddScriptToEvaluateOnNewDocumentResult> AddScriptToEvaluateOnNewDocumentAsync(string source, string? worldName = default, bool? includeCommandLineAPI = default, bool? runImmediately = default, string? session = default, CancellationToken cancellationToken = default);

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
    Task<BringToFrontResult> BringToFrontAsync(string? session = default, CancellationToken cancellationToken = default);

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
    Task<CaptureScreenshotResult> CaptureScreenshotAsync(string? format = default, long? quality = default, Viewport? clip = default, bool? fromSurface = default, bool? captureBeyondViewport = default, bool? optimizeForSpeed = default, string? session = default, CancellationToken cancellationToken = default);

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
    Task<CaptureSnapshotResult> CaptureSnapshotAsync(string? format = default, string? session = default, CancellationToken cancellationToken = default);

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
    Task<ClearDeviceMetricsOverrideResult> ClearDeviceMetricsOverrideAsync(string? session = default, CancellationToken cancellationToken = default);

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
    Task<ClearDeviceOrientationOverrideResult> ClearDeviceOrientationOverrideAsync(string? session = default, CancellationToken cancellationToken = default);

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
    Task<ClearGeolocationOverrideResult> ClearGeolocationOverrideAsync(string? session = default, CancellationToken cancellationToken = default);

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
    Task<CreateIsolatedWorldResult> CreateIsolatedWorldAsync(FrameId frameId, string? worldName = default, bool? grantUniveralAccess = default, string? contentSecurityPolicy = default, string? session = default, CancellationToken cancellationToken = default);

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
    Task<DeleteCookieResult> DeleteCookieAsync(string cookieName, string url, string? session = default, CancellationToken cancellationToken = default);

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
    Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default);

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
    Task<EnableResult> EnableAsync(bool? enableFileChooserOpenedEvent = default, string? session = default, CancellationToken cancellationToken = default);

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
    Task<GetAppManifestResult> GetAppManifestAsync(string? manifestId = default, string? session = default, CancellationToken cancellationToken = default);

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
    Task<GetInstallabilityErrorsResult> GetInstallabilityErrorsAsync(string? session = default, CancellationToken cancellationToken = default);

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
    Task<GetManifestIconsResult> GetManifestIconsAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the unique (PWA) app id.
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
    Task<GetAppIdResult> GetAppIdAsync(string? session = default, CancellationToken cancellationToken = default);

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
    Task<GetAdScriptAncestryResult> GetAdScriptAncestryAsync(FrameId frameId, string? session = default, CancellationToken cancellationToken = default);

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
    Task<GetFrameTreeResult> GetFrameTreeAsync(string? session = default, CancellationToken cancellationToken = default);

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
    Task<GetLayoutMetricsResult> GetLayoutMetricsAsync(string? session = default, CancellationToken cancellationToken = default);

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
    Task<GetNavigationHistoryResult> GetNavigationHistoryAsync(string? session = default, CancellationToken cancellationToken = default);

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
    Task<ResetNavigationHistoryResult> ResetNavigationHistoryAsync(string? session = default, CancellationToken cancellationToken = default);

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
    Task<GetResourceContentResult> GetResourceContentAsync(FrameId frameId, string url, string? session = default, CancellationToken cancellationToken = default);

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
    Task<GetResourceTreeResult> GetResourceTreeAsync(string? session = default, CancellationToken cancellationToken = default);

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
    Task<HandleJavaScriptDialogResult> HandleJavaScriptDialogAsync(bool accept, string? promptText = default, string? session = default, CancellationToken cancellationToken = default);

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
    Task<NavigateResult> NavigateAsync(string url, string? referrer = default, TransitionType? transitionType = default, FrameId? frameId = default, ReferrerPolicy? referrerPolicy = default, string? session = default, CancellationToken cancellationToken = default);

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
    Task<NavigateToHistoryEntryResult> NavigateToHistoryEntryAsync(long entryId, string? session = default, CancellationToken cancellationToken = default);

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
    Task<PrintToPDFResult> PrintToPDFAsync(bool? landscape = default, bool? displayHeaderFooter = default, bool? printBackground = default, double? scale = default, double? paperWidth = default, double? paperHeight = default, double? marginTop = default, double? marginBottom = default, double? marginLeft = default, double? marginRight = default, string? pageRanges = default, string? headerTemplate = default, string? footerTemplate = default, bool? preferCSSPageSize = default, string? transferMode = default, bool? generateTaggedPDF = default, bool? generateDocumentOutline = default, string? session = default, CancellationToken cancellationToken = default);

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
    Task<ReloadResult> ReloadAsync(bool? ignoreCache = default, string? scriptToEvaluateOnLoad = default, Network.LoaderId? loaderId = default, string? session = default, CancellationToken cancellationToken = default);

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
    Task<RemoveScriptToEvaluateOnLoadResult> RemoveScriptToEvaluateOnLoadAsync(ScriptIdentifier identifier, string? session = default, CancellationToken cancellationToken = default);

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
    Task<RemoveScriptToEvaluateOnNewDocumentResult> RemoveScriptToEvaluateOnNewDocumentAsync(ScriptIdentifier identifier, string? session = default, CancellationToken cancellationToken = default);

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
    Task<ScreencastFrameAckResult> ScreencastFrameAckAsync(long sessionId, string? session = default, CancellationToken cancellationToken = default);

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
    Task<SearchInResourceResult> SearchInResourceAsync(FrameId frameId, string url, string query, bool? caseSensitive = default, bool? isRegex = default, string? session = default, CancellationToken cancellationToken = default);

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
    Task<SetAdBlockingEnabledResult> SetAdBlockingEnabledAsync(bool enabled, string? session = default, CancellationToken cancellationToken = default);

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
    Task<SetBypassCSPResult> SetBypassCSPAsync(bool enabled, string? session = default, CancellationToken cancellationToken = default);

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
    Task<GetPermissionsPolicyStateResult> GetPermissionsPolicyStateAsync(FrameId frameId, string? session = default, CancellationToken cancellationToken = default);

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
    Task<GetOriginTrialsResult> GetOriginTrialsAsync(FrameId frameId, string? session = default, CancellationToken cancellationToken = default);

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
    Task<SetDeviceMetricsOverrideResult> SetDeviceMetricsOverrideAsync(long width, long height, double deviceScaleFactor, bool mobile, double? scale = default, long? screenWidth = default, long? screenHeight = default, long? positionX = default, long? positionY = default, bool? dontSetVisibleSize = default, Emulation.ScreenOrientation? screenOrientation = default, Viewport? viewport = default, string? session = default, CancellationToken cancellationToken = default);

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
    Task<SetDeviceOrientationOverrideResult> SetDeviceOrientationOverrideAsync(double alpha, double beta, double gamma, string? session = default, CancellationToken cancellationToken = default);

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
    Task<SetFontFamiliesResult> SetFontFamiliesAsync(FontFamilies fontFamilies, ImmutableArray<ScriptFontFamilies>? forScripts = default, string? session = default, CancellationToken cancellationToken = default);

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
    Task<SetFontSizesResult> SetFontSizesAsync(FontSizes fontSizes, string? session = default, CancellationToken cancellationToken = default);

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
    Task<SetDocumentContentResult> SetDocumentContentAsync(FrameId frameId, string html, string? session = default, CancellationToken cancellationToken = default);

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
    Task<SetDownloadBehaviorResult> SetDownloadBehaviorAsync(string behavior, string? downloadPath = default, string? session = default, CancellationToken cancellationToken = default);

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
    Task<SetGeolocationOverrideResult> SetGeolocationOverrideAsync(double? latitude = default, double? longitude = default, double? accuracy = default, string? session = default, CancellationToken cancellationToken = default);

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
    Task<SetLifecycleEventsEnabledResult> SetLifecycleEventsEnabledAsync(bool enabled, string? session = default, CancellationToken cancellationToken = default);

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
    Task<SetTouchEmulationEnabledResult> SetTouchEmulationEnabledAsync(bool enabled, string? configuration = default, string? session = default, CancellationToken cancellationToken = default);

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
    /// Send every n-th frame.
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
    Task<StartScreencastResult> StartScreencastAsync(string? format = default, long? quality = default, long? maxWidth = default, long? maxHeight = default, long? everyNthFrame = default, string? session = default, CancellationToken cancellationToken = default);

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
    Task<StopLoadingResult> StopLoadingAsync(string? session = default, CancellationToken cancellationToken = default);

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
    Task<CrashResult> CrashAsync(string? session = default, CancellationToken cancellationToken = default);

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
    Task<CloseResult> CloseAsync(string? session = default, CancellationToken cancellationToken = default);

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
    Task<SetWebLifecycleStateResult> SetWebLifecycleStateAsync(string state, string? session = default, CancellationToken cancellationToken = default);

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
    Task<StopScreencastResult> StopScreencastAsync(string? session = default, CancellationToken cancellationToken = default);

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
    Task<ProduceCompilationCacheResult> ProduceCompilationCacheAsync(ImmutableArray<CompilationCacheParams> scripts, string? session = default, CancellationToken cancellationToken = default);

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
    Task<AddCompilationCacheResult> AddCompilationCacheAsync(string url, string data, string? session = default, CancellationToken cancellationToken = default);

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
    Task<ClearCompilationCacheResult> ClearCompilationCacheAsync(string? session = default, CancellationToken cancellationToken = default);

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
    Task<SetSPCTransactionModeResult> SetSPCTransactionModeAsync(string mode, string? session = default, CancellationToken cancellationToken = default);

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
    Task<SetRPHRegistrationModeResult> SetRPHRegistrationModeAsync(string mode, string? session = default, CancellationToken cancellationToken = default);

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
    Task<GenerateTestReportResult> GenerateTestReportAsync(string message, string? group = default, string? session = default, CancellationToken cancellationToken = default);

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
    Task<WaitForDebuggerResult> WaitForDebuggerAsync(string? session = default, CancellationToken cancellationToken = default);

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
    Task<SetInterceptFileChooserDialogResult> SetInterceptFileChooserDialogAsync(bool enabled, bool? cancel = default, string? session = default, CancellationToken cancellationToken = default);

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
    Task<SetPrerenderingAllowedResult> SetPrerenderingAllowedAsync(bool isAllowed, string? session = default, CancellationToken cancellationToken = default);

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
    Task<GetAnnotatedPageContentResult> GetAnnotatedPageContentAsync(bool? includeActionableInformation = default, string? session = default, CancellationToken cancellationToken = default);

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
    private static PageJsonSerializerContext JsonContext = PageJsonSerializerContext.Default;

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<AddScriptToEvaluateOnLoadResult> AddScriptToEvaluateOnLoadAsync(string scriptSource, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new AddScriptToEvaluateOnLoadCommandParameters(ScriptSource: scriptSource);
        return await ExecuteCommandAsync(AddScriptToEvaluateOnLoadCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AddScriptToEvaluateOnLoadCommandParameters, AddScriptToEvaluateOnLoadResult> AddScriptToEvaluateOnLoadCommand = new("Page.addScriptToEvaluateOnLoad", JsonContext.AddScriptToEvaluateOnLoadCommandParameters, JsonContext.AddScriptToEvaluateOnLoadResult);

    public async Task<AddScriptToEvaluateOnNewDocumentResult> AddScriptToEvaluateOnNewDocumentAsync(string source, string? worldName = default, bool? includeCommandLineAPI = default, bool? runImmediately = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new AddScriptToEvaluateOnNewDocumentCommandParameters(Source: source, WorldName: worldName, IncludeCommandLineAPI: includeCommandLineAPI, RunImmediately: runImmediately);
        return await ExecuteCommandAsync(AddScriptToEvaluateOnNewDocumentCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AddScriptToEvaluateOnNewDocumentCommandParameters, AddScriptToEvaluateOnNewDocumentResult> AddScriptToEvaluateOnNewDocumentCommand = new("Page.addScriptToEvaluateOnNewDocument", JsonContext.AddScriptToEvaluateOnNewDocumentCommandParameters, JsonContext.AddScriptToEvaluateOnNewDocumentResult);

    public async Task<BringToFrontResult> BringToFrontAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new BringToFrontCommandParameters();
        return await ExecuteCommandAsync(BringToFrontCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<BringToFrontCommandParameters, BringToFrontResult> BringToFrontCommand = new("Page.bringToFront", JsonContext.BringToFrontCommandParameters, JsonContext.BringToFrontResult);

    public async Task<CaptureScreenshotResult> CaptureScreenshotAsync(string? format = default, long? quality = default, Viewport? clip = default, bool? fromSurface = default, bool? captureBeyondViewport = default, bool? optimizeForSpeed = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CaptureScreenshotCommandParameters(Format: format, Quality: quality, Clip: clip, FromSurface: fromSurface, CaptureBeyondViewport: captureBeyondViewport, OptimizeForSpeed: optimizeForSpeed);
        return await ExecuteCommandAsync(CaptureScreenshotCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CaptureScreenshotCommandParameters, CaptureScreenshotResult> CaptureScreenshotCommand = new("Page.captureScreenshot", JsonContext.CaptureScreenshotCommandParameters, JsonContext.CaptureScreenshotResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<CaptureSnapshotResult> CaptureSnapshotAsync(string? format = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CaptureSnapshotCommandParameters(Format: format);
        return await ExecuteCommandAsync(CaptureSnapshotCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CaptureSnapshotCommandParameters, CaptureSnapshotResult> CaptureSnapshotCommand = new("Page.captureSnapshot", JsonContext.CaptureSnapshotCommandParameters, JsonContext.CaptureSnapshotResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<ClearDeviceMetricsOverrideResult> ClearDeviceMetricsOverrideAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearDeviceMetricsOverrideCommandParameters();
        return await ExecuteCommandAsync(ClearDeviceMetricsOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearDeviceMetricsOverrideCommandParameters, ClearDeviceMetricsOverrideResult> ClearDeviceMetricsOverrideCommand = new("Page.clearDeviceMetricsOverride", JsonContext.ClearDeviceMetricsOverrideCommandParameters, JsonContext.ClearDeviceMetricsOverrideResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<ClearDeviceOrientationOverrideResult> ClearDeviceOrientationOverrideAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearDeviceOrientationOverrideCommandParameters();
        return await ExecuteCommandAsync(ClearDeviceOrientationOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearDeviceOrientationOverrideCommandParameters, ClearDeviceOrientationOverrideResult> ClearDeviceOrientationOverrideCommand = new("Page.clearDeviceOrientationOverride", JsonContext.ClearDeviceOrientationOverrideCommandParameters, JsonContext.ClearDeviceOrientationOverrideResult);

    [global::System.Obsolete]
    public async Task<ClearGeolocationOverrideResult> ClearGeolocationOverrideAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearGeolocationOverrideCommandParameters();
        return await ExecuteCommandAsync(ClearGeolocationOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearGeolocationOverrideCommandParameters, ClearGeolocationOverrideResult> ClearGeolocationOverrideCommand = new("Page.clearGeolocationOverride", JsonContext.ClearGeolocationOverrideCommandParameters, JsonContext.ClearGeolocationOverrideResult);

    public async Task<CreateIsolatedWorldResult> CreateIsolatedWorldAsync(FrameId frameId, string? worldName = default, bool? grantUniveralAccess = default, string? contentSecurityPolicy = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CreateIsolatedWorldCommandParameters(FrameId: frameId, WorldName: worldName, GrantUniveralAccess: grantUniveralAccess, ContentSecurityPolicy: contentSecurityPolicy);
        return await ExecuteCommandAsync(CreateIsolatedWorldCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CreateIsolatedWorldCommandParameters, CreateIsolatedWorldResult> CreateIsolatedWorldCommand = new("Page.createIsolatedWorld", JsonContext.CreateIsolatedWorldCommandParameters, JsonContext.CreateIsolatedWorldResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<DeleteCookieResult> DeleteCookieAsync(string cookieName, string url, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DeleteCookieCommandParameters(CookieName: cookieName, Url: url);
        return await ExecuteCommandAsync(DeleteCookieCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DeleteCookieCommandParameters, DeleteCookieResult> DeleteCookieCommand = new("Page.deleteCookie", JsonContext.DeleteCookieCommandParameters, JsonContext.DeleteCookieResult);

    public async Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync(DisableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("Page.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    public async Task<EnableResult> EnableAsync(bool? enableFileChooserOpenedEvent = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters(EnableFileChooserOpenedEvent: enableFileChooserOpenedEvent);
        return await ExecuteCommandAsync(EnableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("Page.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    public async Task<GetAppManifestResult> GetAppManifestAsync(string? manifestId = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetAppManifestCommandParameters(ManifestId: manifestId);
        return await ExecuteCommandAsync(GetAppManifestCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetAppManifestCommandParameters, GetAppManifestResult> GetAppManifestCommand = new("Page.getAppManifest", JsonContext.GetAppManifestCommandParameters, JsonContext.GetAppManifestResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetInstallabilityErrorsResult> GetInstallabilityErrorsAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetInstallabilityErrorsCommandParameters();
        return await ExecuteCommandAsync(GetInstallabilityErrorsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetInstallabilityErrorsCommandParameters, GetInstallabilityErrorsResult> GetInstallabilityErrorsCommand = new("Page.getInstallabilityErrors", JsonContext.GetInstallabilityErrorsCommandParameters, JsonContext.GetInstallabilityErrorsResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<GetManifestIconsResult> GetManifestIconsAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetManifestIconsCommandParameters();
        return await ExecuteCommandAsync(GetManifestIconsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetManifestIconsCommandParameters, GetManifestIconsResult> GetManifestIconsCommand = new("Page.getManifestIcons", JsonContext.GetManifestIconsCommandParameters, JsonContext.GetManifestIconsResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetAppIdResult> GetAppIdAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetAppIdCommandParameters();
        return await ExecuteCommandAsync(GetAppIdCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetAppIdCommandParameters, GetAppIdResult> GetAppIdCommand = new("Page.getAppId", JsonContext.GetAppIdCommandParameters, JsonContext.GetAppIdResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetAdScriptAncestryResult> GetAdScriptAncestryAsync(FrameId frameId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetAdScriptAncestryCommandParameters(FrameId: frameId);
        return await ExecuteCommandAsync(GetAdScriptAncestryCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetAdScriptAncestryCommandParameters, GetAdScriptAncestryResult> GetAdScriptAncestryCommand = new("Page.getAdScriptAncestry", JsonContext.GetAdScriptAncestryCommandParameters, JsonContext.GetAdScriptAncestryResult);

    public async Task<GetFrameTreeResult> GetFrameTreeAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetFrameTreeCommandParameters();
        return await ExecuteCommandAsync(GetFrameTreeCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetFrameTreeCommandParameters, GetFrameTreeResult> GetFrameTreeCommand = new("Page.getFrameTree", JsonContext.GetFrameTreeCommandParameters, JsonContext.GetFrameTreeResult);

    public async Task<GetLayoutMetricsResult> GetLayoutMetricsAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetLayoutMetricsCommandParameters();
        return await ExecuteCommandAsync(GetLayoutMetricsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetLayoutMetricsCommandParameters, GetLayoutMetricsResult> GetLayoutMetricsCommand = new("Page.getLayoutMetrics", JsonContext.GetLayoutMetricsCommandParameters, JsonContext.GetLayoutMetricsResult);

    public async Task<GetNavigationHistoryResult> GetNavigationHistoryAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetNavigationHistoryCommandParameters();
        return await ExecuteCommandAsync(GetNavigationHistoryCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetNavigationHistoryCommandParameters, GetNavigationHistoryResult> GetNavigationHistoryCommand = new("Page.getNavigationHistory", JsonContext.GetNavigationHistoryCommandParameters, JsonContext.GetNavigationHistoryResult);

    public async Task<ResetNavigationHistoryResult> ResetNavigationHistoryAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ResetNavigationHistoryCommandParameters();
        return await ExecuteCommandAsync(ResetNavigationHistoryCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ResetNavigationHistoryCommandParameters, ResetNavigationHistoryResult> ResetNavigationHistoryCommand = new("Page.resetNavigationHistory", JsonContext.ResetNavigationHistoryCommandParameters, JsonContext.ResetNavigationHistoryResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetResourceContentResult> GetResourceContentAsync(FrameId frameId, string url, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetResourceContentCommandParameters(FrameId: frameId, Url: url);
        return await ExecuteCommandAsync(GetResourceContentCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetResourceContentCommandParameters, GetResourceContentResult> GetResourceContentCommand = new("Page.getResourceContent", JsonContext.GetResourceContentCommandParameters, JsonContext.GetResourceContentResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetResourceTreeResult> GetResourceTreeAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetResourceTreeCommandParameters();
        return await ExecuteCommandAsync(GetResourceTreeCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetResourceTreeCommandParameters, GetResourceTreeResult> GetResourceTreeCommand = new("Page.getResourceTree", JsonContext.GetResourceTreeCommandParameters, JsonContext.GetResourceTreeResult);

    public async Task<HandleJavaScriptDialogResult> HandleJavaScriptDialogAsync(bool accept, string? promptText = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new HandleJavaScriptDialogCommandParameters(Accept: accept, PromptText: promptText);
        return await ExecuteCommandAsync(HandleJavaScriptDialogCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<HandleJavaScriptDialogCommandParameters, HandleJavaScriptDialogResult> HandleJavaScriptDialogCommand = new("Page.handleJavaScriptDialog", JsonContext.HandleJavaScriptDialogCommandParameters, JsonContext.HandleJavaScriptDialogResult);

    public async Task<NavigateResult> NavigateAsync(string url, string? referrer = default, TransitionType? transitionType = default, FrameId? frameId = default, ReferrerPolicy? referrerPolicy = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new NavigateCommandParameters(Url: url, Referrer: referrer, TransitionType: transitionType, FrameId: frameId, ReferrerPolicy: referrerPolicy);
        return await ExecuteCommandAsync(NavigateCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<NavigateCommandParameters, NavigateResult> NavigateCommand = new("Page.navigate", JsonContext.NavigateCommandParameters, JsonContext.NavigateResult);

    public async Task<NavigateToHistoryEntryResult> NavigateToHistoryEntryAsync(long entryId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new NavigateToHistoryEntryCommandParameters(EntryId: entryId);
        return await ExecuteCommandAsync(NavigateToHistoryEntryCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<NavigateToHistoryEntryCommandParameters, NavigateToHistoryEntryResult> NavigateToHistoryEntryCommand = new("Page.navigateToHistoryEntry", JsonContext.NavigateToHistoryEntryCommandParameters, JsonContext.NavigateToHistoryEntryResult);

    public async Task<PrintToPDFResult> PrintToPDFAsync(bool? landscape = default, bool? displayHeaderFooter = default, bool? printBackground = default, double? scale = default, double? paperWidth = default, double? paperHeight = default, double? marginTop = default, double? marginBottom = default, double? marginLeft = default, double? marginRight = default, string? pageRanges = default, string? headerTemplate = default, string? footerTemplate = default, bool? preferCSSPageSize = default, string? transferMode = default, bool? generateTaggedPDF = default, bool? generateDocumentOutline = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new PrintToPDFCommandParameters(Landscape: landscape, DisplayHeaderFooter: displayHeaderFooter, PrintBackground: printBackground, Scale: scale, PaperWidth: paperWidth, PaperHeight: paperHeight, MarginTop: marginTop, MarginBottom: marginBottom, MarginLeft: marginLeft, MarginRight: marginRight, PageRanges: pageRanges, HeaderTemplate: headerTemplate, FooterTemplate: footerTemplate, PreferCSSPageSize: preferCSSPageSize, TransferMode: transferMode, GenerateTaggedPDF: generateTaggedPDF, GenerateDocumentOutline: generateDocumentOutline);
        return await ExecuteCommandAsync(PrintToPDFCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<PrintToPDFCommandParameters, PrintToPDFResult> PrintToPDFCommand = new("Page.printToPDF", JsonContext.PrintToPDFCommandParameters, JsonContext.PrintToPDFResult);

    public async Task<ReloadResult> ReloadAsync(bool? ignoreCache = default, string? scriptToEvaluateOnLoad = default, Network.LoaderId? loaderId = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ReloadCommandParameters(IgnoreCache: ignoreCache, ScriptToEvaluateOnLoad: scriptToEvaluateOnLoad, LoaderId: loaderId);
        return await ExecuteCommandAsync(ReloadCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ReloadCommandParameters, ReloadResult> ReloadCommand = new("Page.reload", JsonContext.ReloadCommandParameters, JsonContext.ReloadResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<RemoveScriptToEvaluateOnLoadResult> RemoveScriptToEvaluateOnLoadAsync(ScriptIdentifier identifier, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveScriptToEvaluateOnLoadCommandParameters(Identifier: identifier);
        return await ExecuteCommandAsync(RemoveScriptToEvaluateOnLoadCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RemoveScriptToEvaluateOnLoadCommandParameters, RemoveScriptToEvaluateOnLoadResult> RemoveScriptToEvaluateOnLoadCommand = new("Page.removeScriptToEvaluateOnLoad", JsonContext.RemoveScriptToEvaluateOnLoadCommandParameters, JsonContext.RemoveScriptToEvaluateOnLoadResult);

    public async Task<RemoveScriptToEvaluateOnNewDocumentResult> RemoveScriptToEvaluateOnNewDocumentAsync(ScriptIdentifier identifier, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveScriptToEvaluateOnNewDocumentCommandParameters(Identifier: identifier);
        return await ExecuteCommandAsync(RemoveScriptToEvaluateOnNewDocumentCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RemoveScriptToEvaluateOnNewDocumentCommandParameters, RemoveScriptToEvaluateOnNewDocumentResult> RemoveScriptToEvaluateOnNewDocumentCommand = new("Page.removeScriptToEvaluateOnNewDocument", JsonContext.RemoveScriptToEvaluateOnNewDocumentCommandParameters, JsonContext.RemoveScriptToEvaluateOnNewDocumentResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<ScreencastFrameAckResult> ScreencastFrameAckAsync(long sessionId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ScreencastFrameAckCommandParameters(SessionId: sessionId);
        return await ExecuteCommandAsync(ScreencastFrameAckCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ScreencastFrameAckCommandParameters, ScreencastFrameAckResult> ScreencastFrameAckCommand = new("Page.screencastFrameAck", JsonContext.ScreencastFrameAckCommandParameters, JsonContext.ScreencastFrameAckResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SearchInResourceResult> SearchInResourceAsync(FrameId frameId, string url, string query, bool? caseSensitive = default, bool? isRegex = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SearchInResourceCommandParameters(FrameId: frameId, Url: url, Query: query, CaseSensitive: caseSensitive, IsRegex: isRegex);
        return await ExecuteCommandAsync(SearchInResourceCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SearchInResourceCommandParameters, SearchInResourceResult> SearchInResourceCommand = new("Page.searchInResource", JsonContext.SearchInResourceCommandParameters, JsonContext.SearchInResourceResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetAdBlockingEnabledResult> SetAdBlockingEnabledAsync(bool enabled, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetAdBlockingEnabledCommandParameters(Enabled: enabled);
        return await ExecuteCommandAsync(SetAdBlockingEnabledCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetAdBlockingEnabledCommandParameters, SetAdBlockingEnabledResult> SetAdBlockingEnabledCommand = new("Page.setAdBlockingEnabled", JsonContext.SetAdBlockingEnabledCommandParameters, JsonContext.SetAdBlockingEnabledResult);

    public async Task<SetBypassCSPResult> SetBypassCSPAsync(bool enabled, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetBypassCSPCommandParameters(Enabled: enabled);
        return await ExecuteCommandAsync(SetBypassCSPCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetBypassCSPCommandParameters, SetBypassCSPResult> SetBypassCSPCommand = new("Page.setBypassCSP", JsonContext.SetBypassCSPCommandParameters, JsonContext.SetBypassCSPResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetPermissionsPolicyStateResult> GetPermissionsPolicyStateAsync(FrameId frameId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetPermissionsPolicyStateCommandParameters(FrameId: frameId);
        return await ExecuteCommandAsync(GetPermissionsPolicyStateCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetPermissionsPolicyStateCommandParameters, GetPermissionsPolicyStateResult> GetPermissionsPolicyStateCommand = new("Page.getPermissionsPolicyState", JsonContext.GetPermissionsPolicyStateCommandParameters, JsonContext.GetPermissionsPolicyStateResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetOriginTrialsResult> GetOriginTrialsAsync(FrameId frameId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetOriginTrialsCommandParameters(FrameId: frameId);
        return await ExecuteCommandAsync(GetOriginTrialsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetOriginTrialsCommandParameters, GetOriginTrialsResult> GetOriginTrialsCommand = new("Page.getOriginTrials", JsonContext.GetOriginTrialsCommandParameters, JsonContext.GetOriginTrialsResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<SetDeviceMetricsOverrideResult> SetDeviceMetricsOverrideAsync(long width, long height, double deviceScaleFactor, bool mobile, double? scale = default, long? screenWidth = default, long? screenHeight = default, long? positionX = default, long? positionY = default, bool? dontSetVisibleSize = default, Emulation.ScreenOrientation? screenOrientation = default, Viewport? viewport = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetDeviceMetricsOverrideCommandParameters(Width: width, Height: height, DeviceScaleFactor: deviceScaleFactor, Mobile: mobile, Scale: scale, ScreenWidth: screenWidth, ScreenHeight: screenHeight, PositionX: positionX, PositionY: positionY, DontSetVisibleSize: dontSetVisibleSize, ScreenOrientation: screenOrientation, Viewport: viewport);
        return await ExecuteCommandAsync(SetDeviceMetricsOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetDeviceMetricsOverrideCommandParameters, SetDeviceMetricsOverrideResult> SetDeviceMetricsOverrideCommand = new("Page.setDeviceMetricsOverride", JsonContext.SetDeviceMetricsOverrideCommandParameters, JsonContext.SetDeviceMetricsOverrideResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<SetDeviceOrientationOverrideResult> SetDeviceOrientationOverrideAsync(double alpha, double beta, double gamma, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetDeviceOrientationOverrideCommandParameters(Alpha: alpha, Beta: beta, Gamma: gamma);
        return await ExecuteCommandAsync(SetDeviceOrientationOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetDeviceOrientationOverrideCommandParameters, SetDeviceOrientationOverrideResult> SetDeviceOrientationOverrideCommand = new("Page.setDeviceOrientationOverride", JsonContext.SetDeviceOrientationOverrideCommandParameters, JsonContext.SetDeviceOrientationOverrideResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetFontFamiliesResult> SetFontFamiliesAsync(FontFamilies fontFamilies, ImmutableArray<ScriptFontFamilies>? forScripts = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetFontFamiliesCommandParameters(FontFamilies: fontFamilies, ForScripts: forScripts);
        return await ExecuteCommandAsync(SetFontFamiliesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetFontFamiliesCommandParameters, SetFontFamiliesResult> SetFontFamiliesCommand = new("Page.setFontFamilies", JsonContext.SetFontFamiliesCommandParameters, JsonContext.SetFontFamiliesResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetFontSizesResult> SetFontSizesAsync(FontSizes fontSizes, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetFontSizesCommandParameters(FontSizes: fontSizes);
        return await ExecuteCommandAsync(SetFontSizesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetFontSizesCommandParameters, SetFontSizesResult> SetFontSizesCommand = new("Page.setFontSizes", JsonContext.SetFontSizesCommandParameters, JsonContext.SetFontSizesResult);

    public async Task<SetDocumentContentResult> SetDocumentContentAsync(FrameId frameId, string html, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetDocumentContentCommandParameters(FrameId: frameId, Html: html);
        return await ExecuteCommandAsync(SetDocumentContentCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetDocumentContentCommandParameters, SetDocumentContentResult> SetDocumentContentCommand = new("Page.setDocumentContent", JsonContext.SetDocumentContentCommandParameters, JsonContext.SetDocumentContentResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<SetDownloadBehaviorResult> SetDownloadBehaviorAsync(string behavior, string? downloadPath = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetDownloadBehaviorCommandParameters(Behavior: behavior, DownloadPath: downloadPath);
        return await ExecuteCommandAsync(SetDownloadBehaviorCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetDownloadBehaviorCommandParameters, SetDownloadBehaviorResult> SetDownloadBehaviorCommand = new("Page.setDownloadBehavior", JsonContext.SetDownloadBehaviorCommandParameters, JsonContext.SetDownloadBehaviorResult);

    [global::System.Obsolete]
    public async Task<SetGeolocationOverrideResult> SetGeolocationOverrideAsync(double? latitude = default, double? longitude = default, double? accuracy = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetGeolocationOverrideCommandParameters(Latitude: latitude, Longitude: longitude, Accuracy: accuracy);
        return await ExecuteCommandAsync(SetGeolocationOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetGeolocationOverrideCommandParameters, SetGeolocationOverrideResult> SetGeolocationOverrideCommand = new("Page.setGeolocationOverride", JsonContext.SetGeolocationOverrideCommandParameters, JsonContext.SetGeolocationOverrideResult);

    public async Task<SetLifecycleEventsEnabledResult> SetLifecycleEventsEnabledAsync(bool enabled, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetLifecycleEventsEnabledCommandParameters(Enabled: enabled);
        return await ExecuteCommandAsync(SetLifecycleEventsEnabledCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetLifecycleEventsEnabledCommandParameters, SetLifecycleEventsEnabledResult> SetLifecycleEventsEnabledCommand = new("Page.setLifecycleEventsEnabled", JsonContext.SetLifecycleEventsEnabledCommandParameters, JsonContext.SetLifecycleEventsEnabledResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<SetTouchEmulationEnabledResult> SetTouchEmulationEnabledAsync(bool enabled, string? configuration = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetTouchEmulationEnabledCommandParameters(Enabled: enabled, Configuration: configuration);
        return await ExecuteCommandAsync(SetTouchEmulationEnabledCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetTouchEmulationEnabledCommandParameters, SetTouchEmulationEnabledResult> SetTouchEmulationEnabledCommand = new("Page.setTouchEmulationEnabled", JsonContext.SetTouchEmulationEnabledCommandParameters, JsonContext.SetTouchEmulationEnabledResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<StartScreencastResult> StartScreencastAsync(string? format = default, long? quality = default, long? maxWidth = default, long? maxHeight = default, long? everyNthFrame = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new StartScreencastCommandParameters(Format: format, Quality: quality, MaxWidth: maxWidth, MaxHeight: maxHeight, EveryNthFrame: everyNthFrame);
        return await ExecuteCommandAsync(StartScreencastCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StartScreencastCommandParameters, StartScreencastResult> StartScreencastCommand = new("Page.startScreencast", JsonContext.StartScreencastCommandParameters, JsonContext.StartScreencastResult);

    public async Task<StopLoadingResult> StopLoadingAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new StopLoadingCommandParameters();
        return await ExecuteCommandAsync(StopLoadingCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StopLoadingCommandParameters, StopLoadingResult> StopLoadingCommand = new("Page.stopLoading", JsonContext.StopLoadingCommandParameters, JsonContext.StopLoadingResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<CrashResult> CrashAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CrashCommandParameters();
        return await ExecuteCommandAsync(CrashCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CrashCommandParameters, CrashResult> CrashCommand = new("Page.crash", JsonContext.CrashCommandParameters, JsonContext.CrashResult);

    public async Task<CloseResult> CloseAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CloseCommandParameters();
        return await ExecuteCommandAsync(CloseCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CloseCommandParameters, CloseResult> CloseCommand = new("Page.close", JsonContext.CloseCommandParameters, JsonContext.CloseResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetWebLifecycleStateResult> SetWebLifecycleStateAsync(string state, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetWebLifecycleStateCommandParameters(State: state);
        return await ExecuteCommandAsync(SetWebLifecycleStateCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetWebLifecycleStateCommandParameters, SetWebLifecycleStateResult> SetWebLifecycleStateCommand = new("Page.setWebLifecycleState", JsonContext.SetWebLifecycleStateCommandParameters, JsonContext.SetWebLifecycleStateResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<StopScreencastResult> StopScreencastAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new StopScreencastCommandParameters();
        return await ExecuteCommandAsync(StopScreencastCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StopScreencastCommandParameters, StopScreencastResult> StopScreencastCommand = new("Page.stopScreencast", JsonContext.StopScreencastCommandParameters, JsonContext.StopScreencastResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<ProduceCompilationCacheResult> ProduceCompilationCacheAsync(ImmutableArray<CompilationCacheParams> scripts, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ProduceCompilationCacheCommandParameters(Scripts: scripts);
        return await ExecuteCommandAsync(ProduceCompilationCacheCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ProduceCompilationCacheCommandParameters, ProduceCompilationCacheResult> ProduceCompilationCacheCommand = new("Page.produceCompilationCache", JsonContext.ProduceCompilationCacheCommandParameters, JsonContext.ProduceCompilationCacheResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<AddCompilationCacheResult> AddCompilationCacheAsync(string url, string data, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new AddCompilationCacheCommandParameters(Url: url, Data: data);
        return await ExecuteCommandAsync(AddCompilationCacheCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AddCompilationCacheCommandParameters, AddCompilationCacheResult> AddCompilationCacheCommand = new("Page.addCompilationCache", JsonContext.AddCompilationCacheCommandParameters, JsonContext.AddCompilationCacheResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<ClearCompilationCacheResult> ClearCompilationCacheAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearCompilationCacheCommandParameters();
        return await ExecuteCommandAsync(ClearCompilationCacheCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearCompilationCacheCommandParameters, ClearCompilationCacheResult> ClearCompilationCacheCommand = new("Page.clearCompilationCache", JsonContext.ClearCompilationCacheCommandParameters, JsonContext.ClearCompilationCacheResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetSPCTransactionModeResult> SetSPCTransactionModeAsync(string mode, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetSPCTransactionModeCommandParameters(Mode: mode);
        return await ExecuteCommandAsync(SetSPCTransactionModeCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetSPCTransactionModeCommandParameters, SetSPCTransactionModeResult> SetSPCTransactionModeCommand = new("Page.setSPCTransactionMode", JsonContext.SetSPCTransactionModeCommandParameters, JsonContext.SetSPCTransactionModeResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetRPHRegistrationModeResult> SetRPHRegistrationModeAsync(string mode, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetRPHRegistrationModeCommandParameters(Mode: mode);
        return await ExecuteCommandAsync(SetRPHRegistrationModeCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetRPHRegistrationModeCommandParameters, SetRPHRegistrationModeResult> SetRPHRegistrationModeCommand = new("Page.setRPHRegistrationMode", JsonContext.SetRPHRegistrationModeCommandParameters, JsonContext.SetRPHRegistrationModeResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GenerateTestReportResult> GenerateTestReportAsync(string message, string? group = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GenerateTestReportCommandParameters(Message: message, Group: group);
        return await ExecuteCommandAsync(GenerateTestReportCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GenerateTestReportCommandParameters, GenerateTestReportResult> GenerateTestReportCommand = new("Page.generateTestReport", JsonContext.GenerateTestReportCommandParameters, JsonContext.GenerateTestReportResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<WaitForDebuggerResult> WaitForDebuggerAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new WaitForDebuggerCommandParameters();
        return await ExecuteCommandAsync(WaitForDebuggerCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<WaitForDebuggerCommandParameters, WaitForDebuggerResult> WaitForDebuggerCommand = new("Page.waitForDebugger", JsonContext.WaitForDebuggerCommandParameters, JsonContext.WaitForDebuggerResult);

    public async Task<SetInterceptFileChooserDialogResult> SetInterceptFileChooserDialogAsync(bool enabled, bool? cancel = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetInterceptFileChooserDialogCommandParameters(Enabled: enabled, Cancel: cancel);
        return await ExecuteCommandAsync(SetInterceptFileChooserDialogCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetInterceptFileChooserDialogCommandParameters, SetInterceptFileChooserDialogResult> SetInterceptFileChooserDialogCommand = new("Page.setInterceptFileChooserDialog", JsonContext.SetInterceptFileChooserDialogCommandParameters, JsonContext.SetInterceptFileChooserDialogResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetPrerenderingAllowedResult> SetPrerenderingAllowedAsync(bool isAllowed, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetPrerenderingAllowedCommandParameters(IsAllowed: isAllowed);
        return await ExecuteCommandAsync(SetPrerenderingAllowedCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetPrerenderingAllowedCommandParameters, SetPrerenderingAllowedResult> SetPrerenderingAllowedCommand = new("Page.setPrerenderingAllowed", JsonContext.SetPrerenderingAllowedCommandParameters, JsonContext.SetPrerenderingAllowedResult);

    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetAnnotatedPageContentResult> GetAnnotatedPageContentAsync(bool? includeActionableInformation = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetAnnotatedPageContentCommandParameters(IncludeActionableInformation: includeActionableInformation);
        return await ExecuteCommandAsync(GetAnnotatedPageContentCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetAnnotatedPageContentCommandParameters, GetAnnotatedPageContentResult> GetAnnotatedPageContentCommand = new("Page.getAnnotatedPageContent", JsonContext.GetAnnotatedPageContentCommandParameters, JsonContext.GetAnnotatedPageContentResult);

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
/// </summary>
/// <param name="Identifier">
/// Identifier of the added script.
/// </param>
public sealed record AddScriptToEvaluateOnLoadResult(ScriptIdentifier Identifier) : EmptyResult;


internal sealed record AddScriptToEvaluateOnNewDocumentCommandParameters(string Source, string? WorldName, bool? IncludeCommandLineAPI, bool? RunImmediately) : Parameters;

/// <summary>
/// </summary>
/// <param name="Identifier">
/// Identifier of the added script.
/// </param>
public sealed record AddScriptToEvaluateOnNewDocumentResult(ScriptIdentifier Identifier) : EmptyResult;


internal sealed record BringToFrontCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record BringToFrontResult() : EmptyResult;


internal sealed record CaptureScreenshotCommandParameters(string? Format, long? Quality, Viewport? Clip, bool? FromSurface, bool? CaptureBeyondViewport, bool? OptimizeForSpeed) : Parameters;

/// <summary>
/// </summary>
/// <param name="Data">
/// Base64-encoded image data. (Encoded as a base64 string when passed over JSON)
/// </param>
public sealed record CaptureScreenshotResult(string Data) : EmptyResult;


internal sealed record CaptureSnapshotCommandParameters(string? Format) : Parameters;

/// <summary>
/// </summary>
/// <param name="Data">
/// Serialized page data.
/// </param>
public sealed record CaptureSnapshotResult(string Data) : EmptyResult;


internal sealed record ClearDeviceMetricsOverrideCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record ClearDeviceMetricsOverrideResult() : EmptyResult;


internal sealed record ClearDeviceOrientationOverrideCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record ClearDeviceOrientationOverrideResult() : EmptyResult;


internal sealed record ClearGeolocationOverrideCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record ClearGeolocationOverrideResult() : EmptyResult;


internal sealed record CreateIsolatedWorldCommandParameters(FrameId FrameId, string? WorldName, bool? GrantUniveralAccess, string? ContentSecurityPolicy) : Parameters;

/// <summary>
/// </summary>
/// <param name="ExecutionContextId">
/// Execution context of the isolated world.
/// </param>
public sealed record CreateIsolatedWorldResult(Runtime.ExecutionContextId ExecutionContextId) : EmptyResult;


internal sealed record DeleteCookieCommandParameters(string CookieName, string Url) : Parameters;

/// <summary>
/// </summary>
public sealed record DeleteCookieResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters(bool? EnableFileChooserOpenedEvent) : Parameters;

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record GetAppManifestCommandParameters(string? ManifestId) : Parameters;

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
public sealed record GetAppManifestResult(string Url, ImmutableArray<AppManifestError> Errors, string? Data, AppManifestParsedProperties? Parsed, WebAppManifest Manifest) : EmptyResult;


internal sealed record GetInstallabilityErrorsCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="InstallabilityErrors">
/// </param>
public sealed record GetInstallabilityErrorsResult(ImmutableArray<InstallabilityError> InstallabilityErrors) : EmptyResult;


internal sealed record GetManifestIconsCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="PrimaryIcon">
/// </param>
public sealed record GetManifestIconsResult(string? PrimaryIcon) : EmptyResult;


internal sealed record GetAppIdCommandParameters() : Parameters;

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
/// </summary>
/// <param name="FrameTree">
/// Present frame tree structure.
/// </param>
public sealed record GetFrameTreeResult(FrameTree FrameTree) : EmptyResult;


internal sealed record GetLayoutMetricsCommandParameters() : Parameters;

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
/// </summary>
public sealed record ResetNavigationHistoryResult() : EmptyResult;


internal sealed record GetResourceContentCommandParameters(FrameId FrameId, string Url) : Parameters;

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
/// </summary>
/// <param name="FrameTree">
/// Present frame / resource tree structure.
/// </param>
public sealed record GetResourceTreeResult(FrameResourceTree FrameTree) : EmptyResult;


internal sealed record HandleJavaScriptDialogCommandParameters(bool Accept, string? PromptText) : Parameters;

/// <summary>
/// </summary>
public sealed record HandleJavaScriptDialogResult() : EmptyResult;


internal sealed record NavigateCommandParameters(string Url, string? Referrer, TransitionType? TransitionType, FrameId? FrameId, ReferrerPolicy? ReferrerPolicy) : Parameters;

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
/// </summary>
public sealed record NavigateToHistoryEntryResult() : EmptyResult;


internal sealed record PrintToPDFCommandParameters(bool? Landscape, bool? DisplayHeaderFooter, bool? PrintBackground, double? Scale, double? PaperWidth, double? PaperHeight, double? MarginTop, double? MarginBottom, double? MarginLeft, double? MarginRight, string? PageRanges, string? HeaderTemplate, string? FooterTemplate, bool? PreferCSSPageSize, string? TransferMode, bool? GenerateTaggedPDF, bool? GenerateDocumentOutline) : Parameters;

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
/// </summary>
public sealed record ReloadResult() : EmptyResult;


internal sealed record RemoveScriptToEvaluateOnLoadCommandParameters(ScriptIdentifier Identifier) : Parameters;

/// <summary>
/// </summary>
public sealed record RemoveScriptToEvaluateOnLoadResult() : EmptyResult;


internal sealed record RemoveScriptToEvaluateOnNewDocumentCommandParameters(ScriptIdentifier Identifier) : Parameters;

/// <summary>
/// </summary>
public sealed record RemoveScriptToEvaluateOnNewDocumentResult() : EmptyResult;


internal sealed record ScreencastFrameAckCommandParameters(long SessionId) : Parameters;

/// <summary>
/// </summary>
public sealed record ScreencastFrameAckResult() : EmptyResult;


internal sealed record SearchInResourceCommandParameters(FrameId FrameId, string Url, string Query, bool? CaseSensitive, bool? IsRegex) : Parameters;

/// <summary>
/// </summary>
/// <param name="Result">
/// List of search matches.
/// </param>
public sealed record SearchInResourceResult(ImmutableArray<Debugger.SearchMatch> Result) : EmptyResult;


internal sealed record SetAdBlockingEnabledCommandParameters(bool Enabled) : Parameters;

/// <summary>
/// </summary>
public sealed record SetAdBlockingEnabledResult() : EmptyResult;


internal sealed record SetBypassCSPCommandParameters(bool Enabled) : Parameters;

/// <summary>
/// </summary>
public sealed record SetBypassCSPResult() : EmptyResult;


internal sealed record GetPermissionsPolicyStateCommandParameters(FrameId FrameId) : Parameters;

/// <summary>
/// </summary>
/// <param name="States">
/// </param>
public sealed record GetPermissionsPolicyStateResult(ImmutableArray<PermissionsPolicyFeatureState> States) : EmptyResult;


internal sealed record GetOriginTrialsCommandParameters(FrameId FrameId) : Parameters;

/// <summary>
/// </summary>
/// <param name="OriginTrials">
/// </param>
public sealed record GetOriginTrialsResult(ImmutableArray<OriginTrial> OriginTrials) : EmptyResult;


internal sealed record SetDeviceMetricsOverrideCommandParameters(long Width, long Height, double DeviceScaleFactor, bool Mobile, double? Scale, long? ScreenWidth, long? ScreenHeight, long? PositionX, long? PositionY, bool? DontSetVisibleSize, Emulation.ScreenOrientation? ScreenOrientation, Viewport? Viewport) : Parameters;

/// <summary>
/// </summary>
public sealed record SetDeviceMetricsOverrideResult() : EmptyResult;


internal sealed record SetDeviceOrientationOverrideCommandParameters(double Alpha, double Beta, double Gamma) : Parameters;

/// <summary>
/// </summary>
public sealed record SetDeviceOrientationOverrideResult() : EmptyResult;


internal sealed record SetFontFamiliesCommandParameters(FontFamilies FontFamilies, ImmutableArray<ScriptFontFamilies>? ForScripts) : Parameters;

/// <summary>
/// </summary>
public sealed record SetFontFamiliesResult() : EmptyResult;


internal sealed record SetFontSizesCommandParameters(FontSizes FontSizes) : Parameters;

/// <summary>
/// </summary>
public sealed record SetFontSizesResult() : EmptyResult;


internal sealed record SetDocumentContentCommandParameters(FrameId FrameId, string Html) : Parameters;

/// <summary>
/// </summary>
public sealed record SetDocumentContentResult() : EmptyResult;


internal sealed record SetDownloadBehaviorCommandParameters(string Behavior, string? DownloadPath) : Parameters;

/// <summary>
/// </summary>
public sealed record SetDownloadBehaviorResult() : EmptyResult;


internal sealed record SetGeolocationOverrideCommandParameters(double? Latitude, double? Longitude, double? Accuracy) : Parameters;

/// <summary>
/// </summary>
public sealed record SetGeolocationOverrideResult() : EmptyResult;


internal sealed record SetLifecycleEventsEnabledCommandParameters(bool Enabled) : Parameters;

/// <summary>
/// </summary>
public sealed record SetLifecycleEventsEnabledResult() : EmptyResult;


internal sealed record SetTouchEmulationEnabledCommandParameters(bool Enabled, string? Configuration) : Parameters;

/// <summary>
/// </summary>
public sealed record SetTouchEmulationEnabledResult() : EmptyResult;


internal sealed record StartScreencastCommandParameters(string? Format, long? Quality, long? MaxWidth, long? MaxHeight, long? EveryNthFrame) : Parameters;

/// <summary>
/// </summary>
public sealed record StartScreencastResult() : EmptyResult;


internal sealed record StopLoadingCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record StopLoadingResult() : EmptyResult;


internal sealed record CrashCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record CrashResult() : EmptyResult;


internal sealed record CloseCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record CloseResult() : EmptyResult;


internal sealed record SetWebLifecycleStateCommandParameters(string State) : Parameters;

/// <summary>
/// </summary>
public sealed record SetWebLifecycleStateResult() : EmptyResult;


internal sealed record StopScreencastCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record StopScreencastResult() : EmptyResult;


internal sealed record ProduceCompilationCacheCommandParameters(ImmutableArray<CompilationCacheParams> Scripts) : Parameters;

/// <summary>
/// </summary>
public sealed record ProduceCompilationCacheResult() : EmptyResult;


internal sealed record AddCompilationCacheCommandParameters(string Url, string Data) : Parameters;

/// <summary>
/// </summary>
public sealed record AddCompilationCacheResult() : EmptyResult;


internal sealed record ClearCompilationCacheCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record ClearCompilationCacheResult() : EmptyResult;


internal sealed record SetSPCTransactionModeCommandParameters(string Mode) : Parameters;

/// <summary>
/// </summary>
public sealed record SetSPCTransactionModeResult() : EmptyResult;


internal sealed record SetRPHRegistrationModeCommandParameters(string Mode) : Parameters;

/// <summary>
/// </summary>
public sealed record SetRPHRegistrationModeResult() : EmptyResult;


internal sealed record GenerateTestReportCommandParameters(string Message, string? Group) : Parameters;

/// <summary>
/// </summary>
public sealed record GenerateTestReportResult() : EmptyResult;


internal sealed record WaitForDebuggerCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record WaitForDebuggerResult() : EmptyResult;


internal sealed record SetInterceptFileChooserDialogCommandParameters(bool Enabled, bool? Cancel) : Parameters;

/// <summary>
/// </summary>
public sealed record SetInterceptFileChooserDialogResult() : EmptyResult;


internal sealed record SetPrerenderingAllowedCommandParameters(bool IsAllowed) : Parameters;

/// <summary>
/// </summary>
public sealed record SetPrerenderingAllowedResult() : EmptyResult;


internal sealed record GetAnnotatedPageContentCommandParameters(bool? IncludeActionableInformation) : Parameters;

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
    public ImmutableArray<AdFrameExplanation>? Explanations { get; init; }
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
    /// </summary>
    public ImmutableArray<ImageResource>? Icons { get; init; }

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
[JsonSerializable(typeof(ImmutableArray<AppManifestError>), TypeInfoPropertyName = "ImmutableArrayPageAppManifestError")]
[JsonSerializable(typeof(ImmutableArray<InstallabilityError>), TypeInfoPropertyName = "ImmutableArrayPageInstallabilityError")]
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
[JsonSerializable(typeof(ImmutableArray<ImageResource>), TypeInfoPropertyName = "ImmutableArrayPageImageResource")]
[JsonSerializable(typeof(ImmutableArray<FileFilter>), TypeInfoPropertyName = "ImmutableArrayPageFileFilter")]
[JsonSerializable(typeof(ImmutableArray<FileHandler>), TypeInfoPropertyName = "ImmutableArrayPageFileHandler")]
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
