#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Audits;

/// <summary>
/// Audits domain allows investigation of page violations and possible improvements.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class AuditsDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static AuditsJsonSerializerContext JsonContext = AuditsJsonSerializerContext.Default;

    /// <summary>
    /// Returns the response body and size if it were re-encoded with the specified settings. Only
    /// applies to images.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Quality</b> - The quality of the encoding (0-1). (defaults to 1)</description></item>
    /// <item><description><b>SizeOnly</b> - Whether to only return the size information (defaults to false).</description></item>
    /// </list>
    /// </remarks>
    /// <param name="requestId">
    /// Identifier of the network request to get content for.
    /// </param>
    /// <param name="encoding">
    /// The encoding to use.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetEncodedResponseCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetEncodedResponseResult"/>.
    /// </returns>
    public async Task<GetEncodedResponseResult> GetEncodedResponseAsync(Network.RequestId requestId, string encoding, GetEncodedResponseCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetEncodedResponseCommandParameters(RequestId: requestId, Encoding: encoding, Quality: options?.Quality, SizeOnly: options?.SizeOnly);
        return await ExecuteCommandAsync(GetEncodedResponseCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetEncodedResponseCommandParameters, GetEncodedResponseResult> GetEncodedResponseCommand = new("Audits.getEncodedResponse", JsonContext.GetEncodedResponseCommandParameters, JsonContext.GetEncodedResponseResult);

    /// <summary>
    /// Disables issues domain, prevents further issues from being reported to the client.
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
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("Audits.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Enables issues domain, sends the issues collected so far to the client by means of the
    /// <b>issueAdded</b> event.
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
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("Audits.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Runs the form issues check for the target page. Found issues are reported
    /// using Audits.issueAdded event.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="CheckFormsIssuesCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CheckFormsIssuesResult"/>.
    /// </returns>
    public async Task<CheckFormsIssuesResult> CheckFormsIssuesAsync(CheckFormsIssuesCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new CheckFormsIssuesCommandParameters();
        return await ExecuteCommandAsync(CheckFormsIssuesCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CheckFormsIssuesCommandParameters, CheckFormsIssuesResult> CheckFormsIssuesCommand = new("Audits.checkFormsIssues", JsonContext.CheckFormsIssuesCommandParameters, JsonContext.CheckFormsIssuesResult);

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="IssueAddedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Issue</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<IssueAddedEventArgs> IssueAdded => CreateCdpEventSource(AuditsDomainEvent.IssueAdded);
}

internal sealed record GetEncodedResponseCommandParameters(Network.RequestId RequestId, string Encoding, double? Quality, bool? SizeOnly) : Parameters;

/// <summary>
/// Optional parameters for <see cref="AuditsDomain.GetEncodedResponseAsync"/>.
/// </summary>
public sealed record GetEncodedResponseCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// The quality of the encoding (0-1). (defaults to 1)
    /// </summary>
    public double? Quality { get; init; }

    /// <summary>
    /// Whether to only return the size information (defaults to false).
    /// </summary>
    public bool? SizeOnly { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Body">
/// The encoded body as a base64 string. Omitted if sizeOnly is true. (Encoded as a base64 string when passed over JSON)
/// </param>
/// <param name="OriginalSize">
/// Size before re-encoding.
/// </param>
/// <param name="EncodedSize">
/// Size after re-encoding.
/// </param>
public sealed record GetEncodedResponseResult(string? Body, long OriginalSize, long EncodedSize) : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="AuditsDomain.DisableAsync"/>.
/// </summary>
public sealed record DisableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="AuditsDomain.EnableAsync"/>.
/// </summary>
public sealed record EnableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record CheckFormsIssuesCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="AuditsDomain.CheckFormsIssuesAsync"/>.
/// </summary>
public sealed record CheckFormsIssuesCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="FormIssues">
/// </param>
public sealed record CheckFormsIssuesResult(IReadOnlyList<GenericIssueDetails> FormIssues) : EmptyResult;


/// <summary>
/// </summary>
/// <param name="Issue">
/// </param>
public sealed record IssueAddedEventArgs(InspectorIssue Issue) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Information about a cookie that is affected by an inspector issue.
/// </summary>
/// <param name="Name">
/// The following three properties uniquely identify a cookie
/// </param>
/// <param name="Path">
/// </param>
/// <param name="Domain">
/// </param>
public sealed record AffectedCookie(string Name, string Path, string Domain)
{
}

/// <summary>
/// Information about a request that is affected by an inspector issue.
/// </summary>
/// <param name="Url">
/// </param>
public sealed record AffectedRequest(string Url)
{
    /// <summary>
    /// The unique request id.
    /// </summary>
    public Network.RequestId? RequestId { get; init; }
}

/// <summary>
/// Information about the frame affected by an inspector issue.
/// </summary>
/// <param name="FrameId">
/// </param>
public sealed record AffectedFrame(Page.FrameId FrameId)
{
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<CookieExclusionReason>))]
public enum CookieExclusionReason
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ExcludeSameSiteUnspecifiedTreatedAsLax")]
    ExcludeSameSiteUnspecifiedTreatedAsLax,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ExcludeSameSiteNoneInsecure")]
    ExcludeSameSiteNoneInsecure,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ExcludeSameSiteLax")]
    ExcludeSameSiteLax,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ExcludeSameSiteStrict")]
    ExcludeSameSiteStrict,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ExcludeDomainNonASCII")]
    ExcludeDomainNonASCII,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ExcludeThirdPartyCookieBlockedInFirstPartySet")]
    ExcludeThirdPartyCookieBlockedInFirstPartySet,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ExcludeThirdPartyPhaseout")]
    ExcludeThirdPartyPhaseout,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ExcludePortMismatch")]
    ExcludePortMismatch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ExcludeSchemeMismatch")]
    ExcludeSchemeMismatch,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<CookieWarningReason>))]
public enum CookieWarningReason
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnSameSiteUnspecifiedCrossSiteContext")]
    WarnSameSiteUnspecifiedCrossSiteContext,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnSameSiteNoneInsecure")]
    WarnSameSiteNoneInsecure,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnSameSiteUnspecifiedLaxAllowUnsafe")]
    WarnSameSiteUnspecifiedLaxAllowUnsafe,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnSameSiteStrictLaxDowngradeStrict")]
    WarnSameSiteStrictLaxDowngradeStrict,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnSameSiteStrictCrossDowngradeStrict")]
    WarnSameSiteStrictCrossDowngradeStrict,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnSameSiteStrictCrossDowngradeLax")]
    WarnSameSiteStrictCrossDowngradeLax,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnSameSiteLaxCrossDowngradeStrict")]
    WarnSameSiteLaxCrossDowngradeStrict,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnSameSiteLaxCrossDowngradeLax")]
    WarnSameSiteLaxCrossDowngradeLax,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnAttributeValueExceedsMaxSize")]
    WarnAttributeValueExceedsMaxSize,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnDomainNonASCII")]
    WarnDomainNonASCII,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnThirdPartyPhaseout")]
    WarnThirdPartyPhaseout,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnCrossSiteRedirectDowngradeChangesInclusion")]
    WarnCrossSiteRedirectDowngradeChangesInclusion,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnDeprecationTrialMetadata")]
    WarnDeprecationTrialMetadata,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnThirdPartyCookieHeuristic")]
    WarnThirdPartyCookieHeuristic,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<CookieOperation>))]
public enum CookieOperation
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SetCookie")]
    SetCookie,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ReadCookie")]
    ReadCookie,
}

/// <summary>
/// Represents the category of insight that a cookie issue falls under.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<InsightType>))]
public enum InsightType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("GitHubResource")]
    GitHubResource,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("GracePeriod")]
    GracePeriod,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Heuristics")]
    Heuristics,
}

/// <summary>
/// Information about the suggested solution to a cookie issue.
/// </summary>
/// <param name="Type">
/// </param>
public sealed record CookieIssueInsight(InsightType Type)
{
    /// <summary>
    /// Link to table entry in third-party cookie migration readiness list.
    /// </summary>
    public string? TableEntryUrl { get; init; }
}

/// <summary>
/// This information is currently necessary, as the front-end has a difficult
/// time finding a specific cookie. With this, we can convey specific error
/// information without the cookie.
/// </summary>
/// <param name="CookieWarningReasons">
/// </param>
/// <param name="CookieExclusionReasons">
/// </param>
/// <param name="Operation">
/// Optionally identifies the site-for-cookies and the cookie url, which
/// may be used by the front-end as additional context.
/// </param>
public sealed record CookieIssueDetails(IReadOnlyList<CookieWarningReason> CookieWarningReasons, IReadOnlyList<CookieExclusionReason> CookieExclusionReasons, CookieOperation Operation)
{
    /// <summary>
    /// If AffectedCookie is not set then rawCookieLine contains the raw
    /// Set-Cookie header string. This hints at a problem where the
    /// cookie line is syntactically or semantically malformed in a way
    /// that no valid cookie could be created.
    /// </summary>
    public AffectedCookie? Cookie { get; init; }

    /// <summary>
    /// </summary>
    public string? RawCookieLine { get; init; }

    /// <summary>
    /// </summary>
    public string? SiteForCookies { get; init; }

    /// <summary>
    /// </summary>
    public string? CookieUrl { get; init; }

    /// <summary>
    /// </summary>
    public AffectedRequest? Request { get; init; }

    /// <summary>
    /// The recommended solution to the issue.
    /// </summary>
    public CookieIssueInsight? Insight { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<PerformanceIssueType>))]
public enum PerformanceIssueType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DocumentCookie")]
    DocumentCookie,
}

/// <summary>
/// Details for a performance issue.
/// </summary>
/// <param name="PerformanceIssueType">
/// </param>
public sealed record PerformanceIssueDetails(PerformanceIssueType PerformanceIssueType)
{
    /// <summary>
    /// </summary>
    public SourceCodeLocation? SourceCodeLocation { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<MixedContentResolutionStatus>))]
public enum MixedContentResolutionStatus
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MixedContentBlocked")]
    MixedContentBlocked,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MixedContentAutomaticallyUpgraded")]
    MixedContentAutomaticallyUpgraded,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MixedContentWarning")]
    MixedContentWarning,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<MixedContentResourceType>))]
public enum MixedContentResourceType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Audio")]
    Audio,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Beacon")]
    Beacon,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CSPReport")]
    CSPReport,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Download")]
    Download,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EventSource")]
    EventSource,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Favicon")]
    Favicon,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Font")]
    Font,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Form")]
    Form,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Frame")]
    Frame,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Image")]
    Image,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Import")]
    Import,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("JSON")]
    JSON,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Manifest")]
    Manifest,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Ping")]
    Ping,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PluginData")]
    PluginData,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PluginResource")]
    PluginResource,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Prefetch")]
    Prefetch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Resource")]
    Resource,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Script")]
    Script,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ServiceWorker")]
    ServiceWorker,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SharedWorker")]
    SharedWorker,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SpeculationRules")]
    SpeculationRules,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Stylesheet")]
    Stylesheet,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Track")]
    Track,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Video")]
    Video,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Worker")]
    Worker,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("XMLHttpRequest")]
    XMLHttpRequest,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("XSLT")]
    XSLT,
}

/// <summary>
/// </summary>
/// <param name="ResolutionStatus">
/// The way the mixed content issue is being resolved.
/// </param>
/// <param name="InsecureURL">
/// The unsafe http url causing the mixed content issue.
/// </param>
/// <param name="MainResourceURL">
/// The url responsible for the call to an unsafe url.
/// </param>
public sealed record MixedContentIssueDetails(MixedContentResolutionStatus ResolutionStatus, string InsecureURL, string MainResourceURL)
{
    /// <summary>
    /// The type of resource causing the mixed content issue (css, js, iframe,
    /// form,...). Marked as optional because it is mapped to from
    /// blink::mojom::RequestContextType, which will be replaced
    /// by network::mojom::RequestDestination
    /// </summary>
    public MixedContentResourceType? ResourceType { get; init; }

    /// <summary>
    /// The mixed content request.
    /// Does not always exist (e.g. for unsafe form submission urls).
    /// </summary>
    public AffectedRequest? Request { get; init; }

    /// <summary>
    /// Optional because not every mixed content issue is necessarily linked to a frame.
    /// </summary>
    public AffectedFrame? Frame { get; init; }
}

/// <summary>
/// Enum indicating the reason a response has been blocked. These reasons are
/// refinements of the net error BLOCKED_BY_RESPONSE.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<BlockedByResponseReason>))]
public enum BlockedByResponseReason
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CoepFrameResourceNeedsCoepHeader")]
    CoepFrameResourceNeedsCoepHeader,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CoopSandboxedIFrameCannotNavigateToCoopPage")]
    CoopSandboxedIFrameCannotNavigateToCoopPage,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CorpNotSameOrigin")]
    CorpNotSameOrigin,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CorpNotSameOriginAfterDefaultedToSameOriginByCoep")]
    CorpNotSameOriginAfterDefaultedToSameOriginByCoep,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CorpNotSameOriginAfterDefaultedToSameOriginByDip")]
    CorpNotSameOriginAfterDefaultedToSameOriginByDip,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CorpNotSameOriginAfterDefaultedToSameOriginByCoepAndDip")]
    CorpNotSameOriginAfterDefaultedToSameOriginByCoepAndDip,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CorpNotSameSite")]
    CorpNotSameSite,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SRIMessageSignatureMismatch")]
    SRIMessageSignatureMismatch,
}

/// <summary>
/// Details for a request that has been blocked with the BLOCKED_BY_RESPONSE
/// code. Currently only used for COEP/COOP, but may be extended to include
/// some CSP errors in the future.
/// </summary>
/// <param name="Request">
/// </param>
/// <param name="Reason">
/// </param>
public sealed record BlockedByResponseIssueDetails(AffectedRequest Request, BlockedByResponseReason Reason)
{
    /// <summary>
    /// </summary>
    public AffectedFrame? ParentFrame { get; init; }

    /// <summary>
    /// </summary>
    public AffectedFrame? BlockedFrame { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<HeavyAdResolutionStatus>))]
public enum HeavyAdResolutionStatus
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("HeavyAdBlocked")]
    HeavyAdBlocked,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("HeavyAdWarning")]
    HeavyAdWarning,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<HeavyAdReason>))]
public enum HeavyAdReason
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NetworkTotalLimit")]
    NetworkTotalLimit,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CpuTotalLimit")]
    CpuTotalLimit,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CpuPeakLimit")]
    CpuPeakLimit,
}

/// <summary>
/// </summary>
/// <param name="Resolution">
/// The resolution status, either blocking the content or warning.
/// </param>
/// <param name="Reason">
/// The reason the ad was blocked, total network or cpu or peak cpu.
/// </param>
/// <param name="Frame">
/// The frame that was blocked.
/// </param>
public sealed record HeavyAdIssueDetails(HeavyAdResolutionStatus Resolution, HeavyAdReason Reason, AffectedFrame Frame)
{
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ContentSecurityPolicyViolationType>))]
public enum ContentSecurityPolicyViolationType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("kInlineViolation")]
    KInlineViolation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("kEvalViolation")]
    KEvalViolation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("kURLViolation")]
    KURLViolation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("kSRIViolation")]
    KSRIViolation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("kTrustedTypesSinkViolation")]
    KTrustedTypesSinkViolation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("kTrustedTypesPolicyViolation")]
    KTrustedTypesPolicyViolation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("kWasmEvalViolation")]
    KWasmEvalViolation,
}

/// <summary>
/// </summary>
/// <param name="Url">
/// </param>
/// <param name="LineNumber">
/// </param>
/// <param name="ColumnNumber">
/// </param>
public sealed record SourceCodeLocation(string Url, long LineNumber, long ColumnNumber)
{
    /// <summary>
    /// </summary>
    public Runtime.ScriptId? ScriptId { get; init; }
}

/// <summary>
/// </summary>
/// <param name="ViolatedDirective">
/// Specific directive that is violated, causing the CSP issue.
/// </param>
/// <param name="IsReportOnly">
/// </param>
/// <param name="ContentSecurityPolicyViolationType">
/// </param>
public sealed record ContentSecurityPolicyIssueDetails(string ViolatedDirective, bool IsReportOnly, ContentSecurityPolicyViolationType ContentSecurityPolicyViolationType)
{
    /// <summary>
    /// The url not included in allowed sources.
    /// </summary>
    public string? BlockedURL { get; init; }

    /// <summary>
    /// </summary>
    public AffectedFrame? FrameAncestor { get; init; }

    /// <summary>
    /// </summary>
    public SourceCodeLocation? SourceCodeLocation { get; init; }

    /// <summary>
    /// </summary>
    public DOM.BackendNodeId? ViolatingNodeId { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<SharedArrayBufferIssueType>))]
public enum SharedArrayBufferIssueType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TransferIssue")]
    TransferIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CreationIssue")]
    CreationIssue,
}

/// <summary>
/// Details for a issue arising from an SAB being instantiated in, or
/// transferred to a context that is not cross-origin isolated.
/// </summary>
/// <param name="SourceCodeLocation">
/// </param>
/// <param name="IsWarning">
/// </param>
/// <param name="Type">
/// </param>
public sealed record SharedArrayBufferIssueDetails(SourceCodeLocation SourceCodeLocation, bool IsWarning, SharedArrayBufferIssueType Type)
{
}

/// <summary>
/// Details for a CORS related issue, e.g. a warning or error related to
/// CORS RFC1918 enforcement.
/// </summary>
/// <param name="CorsErrorStatus">
/// </param>
/// <param name="IsWarning">
/// </param>
/// <param name="Request">
/// </param>
public sealed record CorsIssueDetails(Network.CorsErrorStatus CorsErrorStatus, bool IsWarning, AffectedRequest Request)
{
    /// <summary>
    /// </summary>
    public SourceCodeLocation? Location { get; init; }

    /// <summary>
    /// </summary>
    public string? InitiatorOrigin { get; init; }

    /// <summary>
    /// </summary>
    public Network.IPAddressSpace? ResourceIPAddressSpace { get; init; }

    /// <summary>
    /// </summary>
    public Network.ClientSecurityState? ClientSecurityState { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<SharedDictionaryError>))]
public enum SharedDictionaryError
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UseErrorCrossOriginNoCorsRequest")]
    UseErrorCrossOriginNoCorsRequest,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UseErrorDictionaryLoadFailure")]
    UseErrorDictionaryLoadFailure,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UseErrorMatchingDictionaryNotUsed")]
    UseErrorMatchingDictionaryNotUsed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UseErrorUnexpectedContentDictionaryHeader")]
    UseErrorUnexpectedContentDictionaryHeader,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorCossOriginNoCorsRequest")]
    WriteErrorCossOriginNoCorsRequest,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorDisallowedBySettings")]
    WriteErrorDisallowedBySettings,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorExpiredResponse")]
    WriteErrorExpiredResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorFeatureDisabled")]
    WriteErrorFeatureDisabled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorInsufficientResources")]
    WriteErrorInsufficientResources,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorInvalidMatchField")]
    WriteErrorInvalidMatchField,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorInvalidStructuredHeader")]
    WriteErrorInvalidStructuredHeader,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorInvalidTTLField")]
    WriteErrorInvalidTTLField,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorNavigationRequest")]
    WriteErrorNavigationRequest,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorNoMatchField")]
    WriteErrorNoMatchField,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorNonIntegerTTLField")]
    WriteErrorNonIntegerTTLField,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorNonListMatchDestField")]
    WriteErrorNonListMatchDestField,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorNonSecureContext")]
    WriteErrorNonSecureContext,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorNonStringIdField")]
    WriteErrorNonStringIdField,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorNonStringInMatchDestList")]
    WriteErrorNonStringInMatchDestList,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorInvalidMatchDestList")]
    WriteErrorInvalidMatchDestList,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorNonStringMatchField")]
    WriteErrorNonStringMatchField,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorNonTokenTypeField")]
    WriteErrorNonTokenTypeField,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorRequestAborted")]
    WriteErrorRequestAborted,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorShuttingDown")]
    WriteErrorShuttingDown,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorTooLongIdField")]
    WriteErrorTooLongIdField,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorUnsupportedType")]
    WriteErrorUnsupportedType,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<SRIMessageSignatureError>))]
public enum SRIMessageSignatureError
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MissingSignatureHeader")]
    MissingSignatureHeader,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MissingSignatureInputHeader")]
    MissingSignatureInputHeader,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidSignatureHeader")]
    InvalidSignatureHeader,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidSignatureInputHeader")]
    InvalidSignatureInputHeader,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureHeaderValueIsNotByteSequence")]
    SignatureHeaderValueIsNotByteSequence,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureHeaderValueIsParameterized")]
    SignatureHeaderValueIsParameterized,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureHeaderValueIsIncorrectLength")]
    SignatureHeaderValueIsIncorrectLength,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureInputHeaderMissingLabel")]
    SignatureInputHeaderMissingLabel,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureInputHeaderValueNotInnerList")]
    SignatureInputHeaderValueNotInnerList,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureInputHeaderValueMissingComponents")]
    SignatureInputHeaderValueMissingComponents,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureInputHeaderInvalidComponentType")]
    SignatureInputHeaderInvalidComponentType,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureInputHeaderInvalidComponentName")]
    SignatureInputHeaderInvalidComponentName,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureInputHeaderInvalidHeaderComponentParameter")]
    SignatureInputHeaderInvalidHeaderComponentParameter,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureInputHeaderInvalidDerivedComponentParameter")]
    SignatureInputHeaderInvalidDerivedComponentParameter,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureInputHeaderKeyIdLength")]
    SignatureInputHeaderKeyIdLength,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureInputHeaderInvalidParameter")]
    SignatureInputHeaderInvalidParameter,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureInputHeaderMissingRequiredParameters")]
    SignatureInputHeaderMissingRequiredParameters,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ValidationFailedSignatureExpired")]
    ValidationFailedSignatureExpired,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ValidationFailedInvalidLength")]
    ValidationFailedInvalidLength,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ValidationFailedSignatureMismatch")]
    ValidationFailedSignatureMismatch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ValidationFailedIntegrityMismatch")]
    ValidationFailedIntegrityMismatch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureBaseUnknownDerivedComponent")]
    SignatureBaseUnknownDerivedComponent,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureBaseMissingHeader")]
    SignatureBaseMissingHeader,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureBaseInvalidUnencodedDigest")]
    SignatureBaseInvalidUnencodedDigest,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureBaseUnsupportedComponent")]
    SignatureBaseUnsupportedComponent,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<UnencodedDigestError>))]
public enum UnencodedDigestError
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MalformedDictionary")]
    MalformedDictionary,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UnknownAlgorithm")]
    UnknownAlgorithm,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IncorrectDigestType")]
    IncorrectDigestType,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IncorrectDigestLength")]
    IncorrectDigestLength,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ConnectionAllowlistError>))]
public enum ConnectionAllowlistError
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidHeader")]
    InvalidHeader,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MoreThanOneList")]
    MoreThanOneList,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ItemNotInnerList")]
    ItemNotInnerList,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidAllowlistItemType")]
    InvalidAllowlistItemType,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ReportingEndpointNotToken")]
    ReportingEndpointNotToken,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidUrlPattern")]
    InvalidUrlPattern,
}

/// <summary>
/// Details for issues about documents in Quirks Mode
/// or Limited Quirks Mode that affects page layouting.
/// </summary>
/// <param name="IsLimitedQuirksMode">
/// If false, it means the document's mode is "quirks"
/// instead of "limited-quirks".
/// </param>
/// <param name="DocumentNodeId">
/// </param>
/// <param name="Url">
/// </param>
/// <param name="FrameId">
/// </param>
/// <param name="LoaderId">
/// </param>
public sealed record QuirksModeIssueDetails(bool IsLimitedQuirksMode, DOM.BackendNodeId DocumentNodeId, string Url, Page.FrameId FrameId, Network.LoaderId LoaderId)
{
}

/// <summary>
/// </summary>
/// <param name="Url">
/// </param>
[global::System.Obsolete]
public sealed record NavigatorUserAgentIssueDetails(string Url)
{
    /// <summary>
    /// </summary>
    public SourceCodeLocation? Location { get; init; }
}

/// <summary>
/// </summary>
/// <param name="SharedDictionaryError">
/// </param>
/// <param name="Request">
/// </param>
public sealed record SharedDictionaryIssueDetails(SharedDictionaryError SharedDictionaryError, AffectedRequest Request)
{
}

/// <summary>
/// </summary>
/// <param name="Error">
/// </param>
/// <param name="SignatureBase">
/// </param>
/// <param name="IntegrityAssertions">
/// </param>
/// <param name="Request">
/// </param>
public sealed record SRIMessageSignatureIssueDetails(SRIMessageSignatureError Error, string SignatureBase, IReadOnlyList<string> IntegrityAssertions, AffectedRequest Request)
{
}

/// <summary>
/// </summary>
/// <param name="Error">
/// </param>
/// <param name="Request">
/// </param>
public sealed record UnencodedDigestIssueDetails(UnencodedDigestError Error, AffectedRequest Request)
{
}

/// <summary>
/// </summary>
/// <param name="Error">
/// </param>
/// <param name="Request">
/// </param>
public sealed record ConnectionAllowlistIssueDetails(ConnectionAllowlistError Error, AffectedRequest Request)
{
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<GenericIssueErrorType>))]
public enum GenericIssueErrorType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormLabelForNameError")]
    FormLabelForNameError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormDuplicateIdForInputError")]
    FormDuplicateIdForInputError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormInputWithNoLabelError")]
    FormInputWithNoLabelError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormAutocompleteAttributeEmptyError")]
    FormAutocompleteAttributeEmptyError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormEmptyIdAndNameAttributesForInputError")]
    FormEmptyIdAndNameAttributesForInputError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormAriaLabelledByToNonExistingIdError")]
    FormAriaLabelledByToNonExistingIdError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormInputAssignedAutocompleteValueToIdOrNameAttributeError")]
    FormInputAssignedAutocompleteValueToIdOrNameAttributeError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormLabelHasNeitherForNorNestedInputError")]
    FormLabelHasNeitherForNorNestedInputError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormLabelForMatchesNonExistingIdError")]
    FormLabelForMatchesNonExistingIdError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormInputHasWrongButWellIntendedAutocompleteValueError")]
    FormInputHasWrongButWellIntendedAutocompleteValueError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ResponseWasBlockedByORB")]
    ResponseWasBlockedByORB,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NavigationEntryMarkedSkippable")]
    NavigationEntryMarkedSkippable,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BackUINavigationWouldSkipAd")]
    BackUINavigationWouldSkipAd,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AutofillAndManualTextPolicyControlledFeaturesInfo")]
    AutofillAndManualTextPolicyControlledFeaturesInfo,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AutofillPolicyControlledFeatureInfo")]
    AutofillPolicyControlledFeatureInfo,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ManualTextPolicyControlledFeatureInfo")]
    ManualTextPolicyControlledFeatureInfo,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormModelContextParameterMissingTitleAndDescription")]
    FormModelContextParameterMissingTitleAndDescription,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormModelContextMissingToolName")]
    FormModelContextMissingToolName,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormModelContextMissingToolDescription")]
    FormModelContextMissingToolDescription,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormModelContextRequiredParameterMissingName")]
    FormModelContextRequiredParameterMissingName,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormModelContextParameterMissingName")]
    FormModelContextParameterMissingName,
}

/// <summary>
/// Depending on the concrete errorType, different properties are set.
/// </summary>
/// <param name="ErrorType">
/// Issues with the same errorType are aggregated in the frontend.
/// </param>
public sealed record GenericIssueDetails(GenericIssueErrorType ErrorType)
{
    /// <summary>
    /// </summary>
    public Page.FrameId? FrameId { get; init; }

    /// <summary>
    /// </summary>
    public DOM.BackendNodeId? ViolatingNodeId { get; init; }

    /// <summary>
    /// </summary>
    public string? ViolatingNodeAttribute { get; init; }

    /// <summary>
    /// </summary>
    public AffectedRequest? Request { get; init; }
}

/// <summary>
/// This issue tracks information needed to print a deprecation message.
/// https://source.chromium.org/chromium/chromium/src/+/main:third_party/blink/renderer/core/frame/third_party/blink/renderer/core/frame/deprecation/README.md
/// </summary>
/// <param name="SourceCodeLocation">
/// </param>
/// <param name="Type">
/// One of the deprecation names from third_party/blink/renderer/core/frame/deprecation/deprecation.json5
/// </param>
public sealed record DeprecationIssueDetails(SourceCodeLocation SourceCodeLocation, string Type)
{
    /// <summary>
    /// </summary>
    public AffectedFrame? AffectedFrame { get; init; }
}

/// <summary>
/// This issue warns about sites in the redirect chain of a finished navigation
/// that may be flagged as trackers and have their state cleared if they don't
/// receive a user interaction. Note that in this context 'site' means eTLD+1.
/// For example, if the URL <b>https://example.test:80/bounce</b> was in the
/// redirect chain, the site reported would be <b>example.test</b>.
/// </summary>
/// <param name="TrackingSites">
/// </param>
public sealed record BounceTrackingIssueDetails(IReadOnlyList<string> TrackingSites)
{
}

/// <summary>
/// This issue warns about third-party sites that are accessing cookies on the
/// current page, and have been permitted due to having a global metadata grant.
/// Note that in this context 'site' means eTLD+1. For example, if the URL
/// <b>https://example.test:80/web_page</b> was accessing cookies, the site reported
/// would be <b>example.test</b>.
/// </summary>
/// <param name="AllowedSites">
/// </param>
/// <param name="OptOutPercentage">
/// </param>
/// <param name="IsOptOutTopLevel">
/// </param>
/// <param name="Operation">
/// </param>
public sealed record CookieDeprecationMetadataIssueDetails(IReadOnlyList<string> AllowedSites, double OptOutPercentage, bool IsOptOutTopLevel, CookieOperation Operation)
{
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ClientHintIssueReason>))]
public enum ClientHintIssueReason
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MetaTagAllowListInvalidOrigin")]
    MetaTagAllowListInvalidOrigin,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MetaTagModifiedHTML")]
    MetaTagModifiedHTML,
}

/// <summary>
/// </summary>
/// <param name="FederatedAuthRequestIssueReason">
/// </param>
public sealed record FederatedAuthRequestIssueDetails(FederatedAuthRequestIssueReason FederatedAuthRequestIssueReason)
{
}

/// <summary>
/// Represents the failure reason when a federated authentication reason fails.
/// Should be updated alongside RequestIdTokenStatus in
/// third_party/blink/public/mojom/devtools/inspector_issue.mojom to include
/// all cases except for success.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<FederatedAuthRequestIssueReason>))]
public enum FederatedAuthRequestIssueReason
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ShouldEmbargo")]
    ShouldEmbargo,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TooManyRequests")]
    TooManyRequests,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownHttpNotFound")]
    WellKnownHttpNotFound,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownNoResponse")]
    WellKnownNoResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownInvalidResponse")]
    WellKnownInvalidResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownListEmpty")]
    WellKnownListEmpty,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownInvalidContentType")]
    WellKnownInvalidContentType,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ConfigNotInWellKnown")]
    ConfigNotInWellKnown,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownTooBig")]
    WellKnownTooBig,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ConfigHttpNotFound")]
    ConfigHttpNotFound,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ConfigNoResponse")]
    ConfigNoResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ConfigInvalidResponse")]
    ConfigInvalidResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ConfigInvalidContentType")]
    ConfigInvalidContentType,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IdpNotPotentiallyTrustworthy")]
    IdpNotPotentiallyTrustworthy,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DisabledInSettings")]
    DisabledInSettings,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DisabledInFlags")]
    DisabledInFlags,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ErrorFetchingSignin")]
    ErrorFetchingSignin,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidSigninResponse")]
    InvalidSigninResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AccountsHttpNotFound")]
    AccountsHttpNotFound,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AccountsNoResponse")]
    AccountsNoResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AccountsInvalidResponse")]
    AccountsInvalidResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AccountsListEmpty")]
    AccountsListEmpty,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AccountsInvalidContentType")]
    AccountsInvalidContentType,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IdTokenHttpNotFound")]
    IdTokenHttpNotFound,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IdTokenNoResponse")]
    IdTokenNoResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IdTokenInvalidResponse")]
    IdTokenInvalidResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IdTokenIdpErrorResponse")]
    IdTokenIdpErrorResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IdTokenCrossSiteIdpErrorResponse")]
    IdTokenCrossSiteIdpErrorResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IdTokenInvalidRequest")]
    IdTokenInvalidRequest,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IdTokenInvalidContentType")]
    IdTokenInvalidContentType,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ErrorIdToken")]
    ErrorIdToken,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Canceled")]
    Canceled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RpPageNotVisible")]
    RpPageNotVisible,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SilentMediationFailure")]
    SilentMediationFailure,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NotSignedInWithIdp")]
    NotSignedInWithIdp,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MissingTransientUserActivation")]
    MissingTransientUserActivation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ReplacedByActiveMode")]
    ReplacedByActiveMode,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RelyingPartyOriginIsOpaque")]
    RelyingPartyOriginIsOpaque,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TypeNotMatching")]
    TypeNotMatching,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UiDismissedNoEmbargo")]
    UiDismissedNoEmbargo,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CorsError")]
    CorsError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SuppressedBySegmentationPlatform")]
    SuppressedBySegmentationPlatform,
}

/// <summary>
/// </summary>
/// <param name="FederatedAuthUserInfoRequestIssueReason">
/// </param>
public sealed record FederatedAuthUserInfoRequestIssueDetails(FederatedAuthUserInfoRequestIssueReason FederatedAuthUserInfoRequestIssueReason)
{
}

/// <summary>
/// Represents the failure reason when a getUserInfo() call fails.
/// Should be updated alongside FederatedAuthUserInfoRequestResult in
/// third_party/blink/public/mojom/devtools/inspector_issue.mojom.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<FederatedAuthUserInfoRequestIssueReason>))]
public enum FederatedAuthUserInfoRequestIssueReason
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NotSameOrigin")]
    NotSameOrigin,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NotIframe")]
    NotIframe,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NotPotentiallyTrustworthy")]
    NotPotentiallyTrustworthy,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NoApiPermission")]
    NoApiPermission,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NotSignedInWithIdp")]
    NotSignedInWithIdp,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NoAccountSharingPermission")]
    NoAccountSharingPermission,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidConfigOrWellKnown")]
    InvalidConfigOrWellKnown,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidAccountsResponse")]
    InvalidAccountsResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NoReturningUserFromFetchedAccounts")]
    NoReturningUserFromFetchedAccounts,
}

/// <summary>
/// </summary>
/// <param name="EmailVerificationRequestIssueReason">
/// </param>
public sealed record EmailVerificationRequestIssueDetails(EmailVerificationRequestIssueReason EmailVerificationRequestIssueReason)
{
}

/// <summary>
/// Represents the failure reason when an email verification request fails.
/// Should be updated alongside EmailVerificationRequestResult in
/// third_party/blink/public/mojom/devtools/inspector_issue.mojom.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<EmailVerificationRequestIssueReason>))]
public enum EmailVerificationRequestIssueReason
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidEmail")]
    InvalidEmail,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DnsFetchFailed")]
    DnsFetchFailed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DnsInvalidRecord")]
    DnsInvalidRecord,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownHttpNotFound")]
    WellKnownHttpNotFound,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownNoResponse")]
    WellKnownNoResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownInvalidResponse")]
    WellKnownInvalidResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownListEmpty")]
    WellKnownListEmpty,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownInvalidContentType")]
    WellKnownInvalidContentType,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownMissingIssuanceEndpoint")]
    WellKnownMissingIssuanceEndpoint,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownIssuanceEndpointCrossOrigin")]
    WellKnownIssuanceEndpointCrossOrigin,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownUnsupportedSigningAlgorithm")]
    WellKnownUnsupportedSigningAlgorithm,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenHttpNotFound")]
    TokenHttpNotFound,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenNoResponse")]
    TokenNoResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenInvalidResponse")]
    TokenInvalidResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenInvalidContentType")]
    TokenInvalidContentType,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenMalformedSdJwt")]
    TokenMalformedSdJwt,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenInvalidSdJwt")]
    TokenInvalidSdJwt,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("KeyBindingSigningFailed")]
    KeyBindingSigningFailed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RpOriginIsOpaque")]
    RpOriginIsOpaque,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownMissingAccountsEndpoint")]
    WellKnownMissingAccountsEndpoint,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UserLoggedOut")]
    UserLoggedOut,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownAccountsEndpointCrossOrigin")]
    WellKnownAccountsEndpointCrossOrigin,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AccountsHttpNotFound")]
    AccountsHttpNotFound,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AccountsNoResponse")]
    AccountsNoResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AccountsInvalidResponse")]
    AccountsInvalidResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AccountsInvalidContentType")]
    AccountsInvalidContentType,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AccountsEmptyList")]
    AccountsEmptyList,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmailVerificationWellKnownHttpNotFound")]
    EmailVerificationWellKnownHttpNotFound,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmailVerificationWellKnownNoResponse")]
    EmailVerificationWellKnownNoResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmailVerificationWellKnownInvalidResponse")]
    EmailVerificationWellKnownInvalidResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmailVerificationWellKnownInvalidContentType")]
    EmailVerificationWellKnownInvalidContentType,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("JwksHttpNotFound")]
    JwksHttpNotFound,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("JwksInvalidResponse")]
    JwksInvalidResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtUnsupportedHeaderAlg")]
    TokenVerificationSdJwtUnsupportedHeaderAlg,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtInvalidTyp")]
    TokenVerificationSdJwtInvalidTyp,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtMissingIss")]
    TokenVerificationSdJwtMissingIss,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtMissingIat")]
    TokenVerificationSdJwtMissingIat,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtMissingCnf")]
    TokenVerificationSdJwtMissingCnf,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtMissingEmail")]
    TokenVerificationSdJwtMissingEmail,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtInvalidIssuedAt")]
    TokenVerificationSdJwtInvalidIssuedAt,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtInvalidIssuer")]
    TokenVerificationSdJwtInvalidIssuer,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtJwksMissingKeys")]
    TokenVerificationSdJwtJwksMissingKeys,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtSignatureFailed")]
    TokenVerificationSdJwtSignatureFailed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtInvalidEmailVerified")]
    TokenVerificationSdJwtInvalidEmailVerified,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtInvalidEmail")]
    TokenVerificationSdJwtInvalidEmail,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtInvalidHolderKey")]
    TokenVerificationSdJwtInvalidHolderKey,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationKbInvalidTyp")]
    TokenVerificationKbInvalidTyp,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationKbMissingAud")]
    TokenVerificationKbMissingAud,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationKbMissingNonce")]
    TokenVerificationKbMissingNonce,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationKbMissingIat")]
    TokenVerificationKbMissingIat,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationKbMissingSdHash")]
    TokenVerificationKbMissingSdHash,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationKbInvalidIssuedAt")]
    TokenVerificationKbInvalidIssuedAt,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationKbInvalidAudience")]
    TokenVerificationKbInvalidAudience,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationKbInvalidNonce")]
    TokenVerificationKbInvalidNonce,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationKbInvalidSdHash")]
    TokenVerificationKbInvalidSdHash,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationKbMissingCnf")]
    TokenVerificationKbMissingCnf,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationKbSignatureFailed")]
    TokenVerificationKbSignatureFailed,
}

/// <summary>
/// This issue tracks client hints related issues. It's used to deprecate old
/// features, encourage the use of new ones, and provide general guidance.
/// </summary>
/// <param name="SourceCodeLocation">
/// </param>
/// <param name="ClientHintIssueReason">
/// </param>
public sealed record ClientHintIssueDetails(SourceCodeLocation SourceCodeLocation, ClientHintIssueReason ClientHintIssueReason)
{
}

/// <summary>
/// </summary>
/// <param name="Url">
/// The URL that failed to load.
/// </param>
/// <param name="FailureMessage">
/// The failure message for the failed request.
/// </param>
public sealed record FailedRequestInfo(string Url, string FailureMessage)
{
    /// <summary>
    /// </summary>
    public Network.RequestId? RequestId { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<PartitioningBlobURLInfo>))]
public enum PartitioningBlobURLInfo
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BlockedCrossPartitionFetching")]
    BlockedCrossPartitionFetching,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EnforceNoopenerForNavigation")]
    EnforceNoopenerForNavigation,
}

/// <summary>
/// </summary>
/// <param name="Url">
/// The BlobURL that failed to load.
/// </param>
/// <param name="PartitioningBlobURLInfo">
/// Additional information about the Partitioning Blob URL issue.
/// </param>
public sealed record PartitioningBlobURLIssueDetails(string Url, PartitioningBlobURLInfo PartitioningBlobURLInfo)
{
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ElementAccessibilityIssueReason>))]
public enum ElementAccessibilityIssueReason
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DisallowedSelectChild")]
    DisallowedSelectChild,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DisallowedOptGroupChild")]
    DisallowedOptGroupChild,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NonPhrasingContentOptionChild")]
    NonPhrasingContentOptionChild,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InteractiveContentOptionChild")]
    InteractiveContentOptionChild,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InteractiveContentLegendChild")]
    InteractiveContentLegendChild,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InteractiveContentSummaryDescendant")]
    InteractiveContentSummaryDescendant,
}

/// <summary>
/// This issue warns about errors in the select or summary element content model.
/// </summary>
/// <param name="NodeId">
/// </param>
/// <param name="ElementAccessibilityIssueReason">
/// </param>
/// <param name="HasDisallowedAttributes">
/// </param>
public sealed record ElementAccessibilityIssueDetails(DOM.BackendNodeId NodeId, ElementAccessibilityIssueReason ElementAccessibilityIssueReason, bool HasDisallowedAttributes)
{
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<StyleSheetLoadingIssueReason>))]
public enum StyleSheetLoadingIssueReason
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("LateImportRule")]
    LateImportRule,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RequestFailed")]
    RequestFailed,
}

/// <summary>
/// This issue warns when a referenced stylesheet couldn't be loaded.
/// </summary>
/// <param name="SourceCodeLocation">
/// Source code position that referenced the failing stylesheet.
/// </param>
/// <param name="StyleSheetLoadingIssueReason">
/// Reason why the stylesheet couldn't be loaded.
/// </param>
public sealed record StylesheetLoadingIssueDetails(SourceCodeLocation SourceCodeLocation, StyleSheetLoadingIssueReason StyleSheetLoadingIssueReason)
{
    /// <summary>
    /// Contains additional info when the failure was due to a request.
    /// </summary>
    public FailedRequestInfo? FailedRequestInfo { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<PropertyRuleIssueReason>))]
public enum PropertyRuleIssueReason
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidSyntax")]
    InvalidSyntax,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidInitialValue")]
    InvalidInitialValue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidInherits")]
    InvalidInherits,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidName")]
    InvalidName,
}

/// <summary>
/// This issue warns about errors in property rules that lead to property
/// registrations being ignored.
/// </summary>
/// <param name="SourceCodeLocation">
/// Source code position of the property rule.
/// </param>
/// <param name="PropertyRuleIssueReason">
/// Reason why the property rule was discarded.
/// </param>
public sealed record PropertyRuleIssueDetails(SourceCodeLocation SourceCodeLocation, PropertyRuleIssueReason PropertyRuleIssueReason)
{
    /// <summary>
    /// The value of the property rule property that failed to parse
    /// </summary>
    public string? PropertyValue { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<UserReidentificationIssueType>))]
public enum UserReidentificationIssueType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BlockedFrameNavigation")]
    BlockedFrameNavigation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BlockedSubresource")]
    BlockedSubresource,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NoisedCanvasReadback")]
    NoisedCanvasReadback,
}

/// <summary>
/// This issue warns about uses of APIs that may be considered misuse to
/// re-identify users.
/// </summary>
/// <param name="Type">
/// </param>
public sealed record UserReidentificationIssueDetails(UserReidentificationIssueType Type)
{
    /// <summary>
    /// Applies to BlockedFrameNavigation and BlockedSubresource issue types.
    /// </summary>
    public AffectedRequest? Request { get; init; }

    /// <summary>
    /// Applies to NoisedCanvasReadback issue type.
    /// </summary>
    public SourceCodeLocation? SourceCodeLocation { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<PermissionElementIssueType>))]
public enum PermissionElementIssueType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidType")]
    InvalidType,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FencedFrameDisallowed")]
    FencedFrameDisallowed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CspFrameAncestorsMissing")]
    CspFrameAncestorsMissing,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PermissionsPolicyBlocked")]
    PermissionsPolicyBlocked,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PaddingRightUnsupported")]
    PaddingRightUnsupported,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PaddingBottomUnsupported")]
    PaddingBottomUnsupported,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InsetBoxShadowUnsupported")]
    InsetBoxShadowUnsupported,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RequestInProgress")]
    RequestInProgress,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UntrustedEvent")]
    UntrustedEvent,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RegistrationFailed")]
    RegistrationFailed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TypeNotSupported")]
    TypeNotSupported,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidTypeActivation")]
    InvalidTypeActivation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SecurityChecksFailed")]
    SecurityChecksFailed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ActivationDisabled")]
    ActivationDisabled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("GeolocationDeprecated")]
    GeolocationDeprecated,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidDisplayStyle")]
    InvalidDisplayStyle,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NonOpaqueColor")]
    NonOpaqueColor,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("LowContrast")]
    LowContrast,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FontSizeTooSmall")]
    FontSizeTooSmall,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FontSizeTooLarge")]
    FontSizeTooLarge,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidSizeValue")]
    InvalidSizeValue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NonSecureContext")]
    NonSecureContext,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MissingTransientUserActivation")]
    MissingTransientUserActivation,
}

/// <summary>
/// This issue warns about improper usage of the &lt;permission&gt; element.
/// </summary>
/// <param name="IssueType">
/// </param>
public sealed record PermissionElementIssueDetails(PermissionElementIssueType IssueType)
{
    /// <summary>
    /// The value of the type attribute.
    /// </summary>
    public string? Type { get; init; }

    /// <summary>
    /// The node ID of the &lt;permission&gt; element.
    /// </summary>
    public DOM.BackendNodeId? NodeId { get; init; }

    /// <summary>
    /// True if the issue is a warning, false if it is an error.
    /// </summary>
    public bool? IsWarning { get; init; }

    /// <summary>
    /// Fields for message construction:
    /// Used for messages that reference a specific permission name
    /// </summary>
    public string? PermissionName { get; init; }

    /// <summary>
    /// Used for messages about occlusion
    /// </summary>
    public string? OccluderNodeInfo { get; init; }

    /// <summary>
    /// Used for messages about occluder's parent
    /// </summary>
    public string? OccluderParentNodeInfo { get; init; }

    /// <summary>
    /// Used for messages about activation disabled reason
    /// </summary>
    public string? DisableReason { get; init; }
}

/// <summary>
/// The issue warns about blocked calls to privacy sensitive APIs via the
/// Selective Permissions Intervention.
/// </summary>
/// <param name="ApiName">
/// Which API was intervened on.
/// </param>
/// <param name="AdAncestry">
/// Why the ad script using the API is considered an ad.
/// </param>
public sealed record SelectivePermissionsInterventionIssueDetails(string ApiName, Network.AdAncestry AdAncestry)
{
    /// <summary>
    /// The stack trace at the time of the intervention.
    /// </summary>
    public Runtime.StackTrace? StackTrace { get; init; }
}

/// <summary>
/// Details for issues about lazy-loaded images without explicit dimensions.
/// </summary>
/// <param name="NodeId">
/// DOM node of the problematic HTMLImageElement.
/// </param>
/// <param name="Url">
/// URL or src attribute of the image.
/// </param>
/// <param name="FrameId">
/// Frame containing the image.
/// </param>
public sealed record LazyLoadImageIssueDetails(DOM.BackendNodeId NodeId, string Url, Page.FrameId FrameId)
{
}

/// <summary>
/// A unique identifier for the type of issue. Each type may use one of the
/// optional fields in InspectorIssueDetails to convey more specific
/// information about the kind of issue.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<InspectorIssueCode>))]
public enum InspectorIssueCode
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CookieIssue")]
    CookieIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MixedContentIssue")]
    MixedContentIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BlockedByResponseIssue")]
    BlockedByResponseIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("HeavyAdIssue")]
    HeavyAdIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentSecurityPolicyIssue")]
    ContentSecurityPolicyIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SharedArrayBufferIssue")]
    SharedArrayBufferIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CorsIssue")]
    CorsIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("QuirksModeIssue")]
    QuirksModeIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PartitioningBlobURLIssue")]
    PartitioningBlobURLIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NavigatorUserAgentIssue")]
    NavigatorUserAgentIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("GenericIssue")]
    GenericIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DeprecationIssue")]
    DeprecationIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ClientHintIssue")]
    ClientHintIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FederatedAuthRequestIssue")]
    FederatedAuthRequestIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BounceTrackingIssue")]
    BounceTrackingIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CookieDeprecationMetadataIssue")]
    CookieDeprecationMetadataIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("StylesheetLoadingIssue")]
    StylesheetLoadingIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FederatedAuthUserInfoRequestIssue")]
    FederatedAuthUserInfoRequestIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PropertyRuleIssue")]
    PropertyRuleIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SharedDictionaryIssue")]
    SharedDictionaryIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ElementAccessibilityIssue")]
    ElementAccessibilityIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SRIMessageSignatureIssue")]
    SRIMessageSignatureIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UnencodedDigestIssue")]
    UnencodedDigestIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ConnectionAllowlistIssue")]
    ConnectionAllowlistIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UserReidentificationIssue")]
    UserReidentificationIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PermissionElementIssue")]
    PermissionElementIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PerformanceIssue")]
    PerformanceIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SelectivePermissionsInterventionIssue")]
    SelectivePermissionsInterventionIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmailVerificationRequestIssue")]
    EmailVerificationRequestIssue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("LazyLoadImageIssue")]
    LazyLoadImageIssue,
}

/// <summary>
/// This struct holds a list of optional fields with additional information
/// specific to the kind of issue. When adding a new issue code, please also
/// add a new optional field to this type.
/// </summary>
public sealed record InspectorIssueDetails()
{
    /// <summary>
    /// </summary>
    public CookieIssueDetails? CookieIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public MixedContentIssueDetails? MixedContentIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public BlockedByResponseIssueDetails? BlockedByResponseIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public HeavyAdIssueDetails? HeavyAdIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public ContentSecurityPolicyIssueDetails? ContentSecurityPolicyIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public SharedArrayBufferIssueDetails? SharedArrayBufferIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public CorsIssueDetails? CorsIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public QuirksModeIssueDetails? QuirksModeIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public PartitioningBlobURLIssueDetails? PartitioningBlobURLIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    [global::System.Obsolete]
    public NavigatorUserAgentIssueDetails? NavigatorUserAgentIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public GenericIssueDetails? GenericIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public DeprecationIssueDetails? DeprecationIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public ClientHintIssueDetails? ClientHintIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public FederatedAuthRequestIssueDetails? FederatedAuthRequestIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public BounceTrackingIssueDetails? BounceTrackingIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public CookieDeprecationMetadataIssueDetails? CookieDeprecationMetadataIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public StylesheetLoadingIssueDetails? StylesheetLoadingIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public PropertyRuleIssueDetails? PropertyRuleIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public FederatedAuthUserInfoRequestIssueDetails? FederatedAuthUserInfoRequestIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public SharedDictionaryIssueDetails? SharedDictionaryIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public ElementAccessibilityIssueDetails? ElementAccessibilityIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public SRIMessageSignatureIssueDetails? SriMessageSignatureIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public UnencodedDigestIssueDetails? UnencodedDigestIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public ConnectionAllowlistIssueDetails? ConnectionAllowlistIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public UserReidentificationIssueDetails? UserReidentificationIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public PermissionElementIssueDetails? PermissionElementIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public PerformanceIssueDetails? PerformanceIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public SelectivePermissionsInterventionIssueDetails? SelectivePermissionsInterventionIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public EmailVerificationRequestIssueDetails? EmailVerificationRequestIssueDetails { get; init; }

    /// <summary>
    /// </summary>
    public LazyLoadImageIssueDetails? LazyLoadImageIssueDetails { get; init; }
}

/// <summary>
/// A unique id for a DevTools inspector issue. Allows other entities (e.g.
/// exceptions, CDP message, console messages, etc.) to reference an issue.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<IssueId>))]
public record IssueId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// An inspector issue reported from the back-end.
/// </summary>
/// <param name="Code">
/// </param>
/// <param name="Details">
/// </param>
public sealed record InspectorIssue(InspectorIssueCode Code, InspectorIssueDetails Details)
{
    /// <summary>
    /// A unique id for this issue. May be omitted if no other entity (e.g.
    /// exception, CDP message, etc.) is referencing this issue.
    /// </summary>
    public IssueId? IssueId { get; init; }
}

[JsonSerializable(typeof(GetEncodedResponseCommandParameters), TypeInfoPropertyName = "GetEncodedResponseCommandParameters")]
[JsonSerializable(typeof(GetEncodedResponseResult), TypeInfoPropertyName = "GetEncodedResponseResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(CheckFormsIssuesCommandParameters), TypeInfoPropertyName = "CheckFormsIssuesCommandParameters")]
[JsonSerializable(typeof(CheckFormsIssuesResult), TypeInfoPropertyName = "CheckFormsIssuesResult")]
[JsonSerializable(typeof(CdpEventArgs<IssueAddedEventArgs>), TypeInfoPropertyName = "IssueAddedCdpEventArgs")]
[JsonSerializable(typeof(AffectedCookie), TypeInfoPropertyName = "AuditsAffectedCookie")]
[JsonSerializable(typeof(AffectedRequest), TypeInfoPropertyName = "AuditsAffectedRequest")]
[JsonSerializable(typeof(AffectedFrame), TypeInfoPropertyName = "AuditsAffectedFrame")]
[JsonSerializable(typeof(CookieExclusionReason), TypeInfoPropertyName = "AuditsCookieExclusionReason")]
[JsonSerializable(typeof(CookieWarningReason), TypeInfoPropertyName = "AuditsCookieWarningReason")]
[JsonSerializable(typeof(CookieOperation), TypeInfoPropertyName = "AuditsCookieOperation")]
[JsonSerializable(typeof(InsightType), TypeInfoPropertyName = "AuditsInsightType")]
[JsonSerializable(typeof(CookieIssueInsight), TypeInfoPropertyName = "AuditsCookieIssueInsight")]
[JsonSerializable(typeof(CookieIssueDetails), TypeInfoPropertyName = "AuditsCookieIssueDetails")]
[JsonSerializable(typeof(PerformanceIssueType), TypeInfoPropertyName = "AuditsPerformanceIssueType")]
[JsonSerializable(typeof(PerformanceIssueDetails), TypeInfoPropertyName = "AuditsPerformanceIssueDetails")]
[JsonSerializable(typeof(MixedContentResolutionStatus), TypeInfoPropertyName = "AuditsMixedContentResolutionStatus")]
[JsonSerializable(typeof(MixedContentResourceType), TypeInfoPropertyName = "AuditsMixedContentResourceType")]
[JsonSerializable(typeof(MixedContentIssueDetails), TypeInfoPropertyName = "AuditsMixedContentIssueDetails")]
[JsonSerializable(typeof(BlockedByResponseReason), TypeInfoPropertyName = "AuditsBlockedByResponseReason")]
[JsonSerializable(typeof(BlockedByResponseIssueDetails), TypeInfoPropertyName = "AuditsBlockedByResponseIssueDetails")]
[JsonSerializable(typeof(HeavyAdResolutionStatus), TypeInfoPropertyName = "AuditsHeavyAdResolutionStatus")]
[JsonSerializable(typeof(HeavyAdReason), TypeInfoPropertyName = "AuditsHeavyAdReason")]
[JsonSerializable(typeof(HeavyAdIssueDetails), TypeInfoPropertyName = "AuditsHeavyAdIssueDetails")]
[JsonSerializable(typeof(ContentSecurityPolicyViolationType), TypeInfoPropertyName = "AuditsContentSecurityPolicyViolationType")]
[JsonSerializable(typeof(SourceCodeLocation), TypeInfoPropertyName = "AuditsSourceCodeLocation")]
[JsonSerializable(typeof(ContentSecurityPolicyIssueDetails), TypeInfoPropertyName = "AuditsContentSecurityPolicyIssueDetails")]
[JsonSerializable(typeof(SharedArrayBufferIssueType), TypeInfoPropertyName = "AuditsSharedArrayBufferIssueType")]
[JsonSerializable(typeof(SharedArrayBufferIssueDetails), TypeInfoPropertyName = "AuditsSharedArrayBufferIssueDetails")]
[JsonSerializable(typeof(CorsIssueDetails), TypeInfoPropertyName = "AuditsCorsIssueDetails")]
[JsonSerializable(typeof(SharedDictionaryError), TypeInfoPropertyName = "AuditsSharedDictionaryError")]
[JsonSerializable(typeof(SRIMessageSignatureError), TypeInfoPropertyName = "AuditsSRIMessageSignatureError")]
[JsonSerializable(typeof(UnencodedDigestError), TypeInfoPropertyName = "AuditsUnencodedDigestError")]
[JsonSerializable(typeof(ConnectionAllowlistError), TypeInfoPropertyName = "AuditsConnectionAllowlistError")]
[JsonSerializable(typeof(QuirksModeIssueDetails), TypeInfoPropertyName = "AuditsQuirksModeIssueDetails")]
[JsonSerializable(typeof(NavigatorUserAgentIssueDetails), TypeInfoPropertyName = "AuditsNavigatorUserAgentIssueDetails")]
[JsonSerializable(typeof(SharedDictionaryIssueDetails), TypeInfoPropertyName = "AuditsSharedDictionaryIssueDetails")]
[JsonSerializable(typeof(SRIMessageSignatureIssueDetails), TypeInfoPropertyName = "AuditsSRIMessageSignatureIssueDetails")]
[JsonSerializable(typeof(UnencodedDigestIssueDetails), TypeInfoPropertyName = "AuditsUnencodedDigestIssueDetails")]
[JsonSerializable(typeof(ConnectionAllowlistIssueDetails), TypeInfoPropertyName = "AuditsConnectionAllowlistIssueDetails")]
[JsonSerializable(typeof(GenericIssueErrorType), TypeInfoPropertyName = "AuditsGenericIssueErrorType")]
[JsonSerializable(typeof(GenericIssueDetails), TypeInfoPropertyName = "AuditsGenericIssueDetails")]
[JsonSerializable(typeof(DeprecationIssueDetails), TypeInfoPropertyName = "AuditsDeprecationIssueDetails")]
[JsonSerializable(typeof(BounceTrackingIssueDetails), TypeInfoPropertyName = "AuditsBounceTrackingIssueDetails")]
[JsonSerializable(typeof(CookieDeprecationMetadataIssueDetails), TypeInfoPropertyName = "AuditsCookieDeprecationMetadataIssueDetails")]
[JsonSerializable(typeof(ClientHintIssueReason), TypeInfoPropertyName = "AuditsClientHintIssueReason")]
[JsonSerializable(typeof(FederatedAuthRequestIssueDetails), TypeInfoPropertyName = "AuditsFederatedAuthRequestIssueDetails")]
[JsonSerializable(typeof(FederatedAuthRequestIssueReason), TypeInfoPropertyName = "AuditsFederatedAuthRequestIssueReason")]
[JsonSerializable(typeof(FederatedAuthUserInfoRequestIssueDetails), TypeInfoPropertyName = "AuditsFederatedAuthUserInfoRequestIssueDetails")]
[JsonSerializable(typeof(FederatedAuthUserInfoRequestIssueReason), TypeInfoPropertyName = "AuditsFederatedAuthUserInfoRequestIssueReason")]
[JsonSerializable(typeof(EmailVerificationRequestIssueDetails), TypeInfoPropertyName = "AuditsEmailVerificationRequestIssueDetails")]
[JsonSerializable(typeof(EmailVerificationRequestIssueReason), TypeInfoPropertyName = "AuditsEmailVerificationRequestIssueReason")]
[JsonSerializable(typeof(ClientHintIssueDetails), TypeInfoPropertyName = "AuditsClientHintIssueDetails")]
[JsonSerializable(typeof(FailedRequestInfo), TypeInfoPropertyName = "AuditsFailedRequestInfo")]
[JsonSerializable(typeof(PartitioningBlobURLInfo), TypeInfoPropertyName = "AuditsPartitioningBlobURLInfo")]
[JsonSerializable(typeof(PartitioningBlobURLIssueDetails), TypeInfoPropertyName = "AuditsPartitioningBlobURLIssueDetails")]
[JsonSerializable(typeof(ElementAccessibilityIssueReason), TypeInfoPropertyName = "AuditsElementAccessibilityIssueReason")]
[JsonSerializable(typeof(ElementAccessibilityIssueDetails), TypeInfoPropertyName = "AuditsElementAccessibilityIssueDetails")]
[JsonSerializable(typeof(StyleSheetLoadingIssueReason), TypeInfoPropertyName = "AuditsStyleSheetLoadingIssueReason")]
[JsonSerializable(typeof(StylesheetLoadingIssueDetails), TypeInfoPropertyName = "AuditsStylesheetLoadingIssueDetails")]
[JsonSerializable(typeof(PropertyRuleIssueReason), TypeInfoPropertyName = "AuditsPropertyRuleIssueReason")]
[JsonSerializable(typeof(PropertyRuleIssueDetails), TypeInfoPropertyName = "AuditsPropertyRuleIssueDetails")]
[JsonSerializable(typeof(UserReidentificationIssueType), TypeInfoPropertyName = "AuditsUserReidentificationIssueType")]
[JsonSerializable(typeof(UserReidentificationIssueDetails), TypeInfoPropertyName = "AuditsUserReidentificationIssueDetails")]
[JsonSerializable(typeof(PermissionElementIssueType), TypeInfoPropertyName = "AuditsPermissionElementIssueType")]
[JsonSerializable(typeof(PermissionElementIssueDetails), TypeInfoPropertyName = "AuditsPermissionElementIssueDetails")]
[JsonSerializable(typeof(SelectivePermissionsInterventionIssueDetails), TypeInfoPropertyName = "AuditsSelectivePermissionsInterventionIssueDetails")]
[JsonSerializable(typeof(LazyLoadImageIssueDetails), TypeInfoPropertyName = "AuditsLazyLoadImageIssueDetails")]
[JsonSerializable(typeof(InspectorIssueCode), TypeInfoPropertyName = "AuditsInspectorIssueCode")]
[JsonSerializable(typeof(InspectorIssueDetails), TypeInfoPropertyName = "AuditsInspectorIssueDetails")]
[JsonSerializable(typeof(IssueId), TypeInfoPropertyName = "AuditsIssueId")]
[JsonSerializable(typeof(InspectorIssue), TypeInfoPropertyName = "AuditsInspectorIssue")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<GenericIssueDetails>), TypeInfoPropertyName = "IReadOnlyListAuditsGenericIssueDetails")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<CookieWarningReason>), TypeInfoPropertyName = "IReadOnlyListAuditsCookieWarningReason")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<CookieExclusionReason>), TypeInfoPropertyName = "IReadOnlyListAuditsCookieExclusionReason")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class AuditsJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="AuditsDomain"/>.
/// </summary>
public static class AuditsDomainEvent
{
    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<IssueAddedEventArgs>> IssueAdded { get; } =
        EventDescriptor<CdpEventArgs<IssueAddedEventArgs>>.Create(
            "goog:cdp.Audits.issueAdded",
            AuditsJsonSerializerContext.Default.IssueAddedCdpEventArgs);

}
