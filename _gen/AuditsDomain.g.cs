#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Audits;

/// <summary>
/// Audits domain allows investigation of page violations and possible improvements.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public interface IAudits
{
    /// <summary>
    /// Returns the response body and size if it were re-encoded with the specified settings. Only
    /// applies to images.
    /// </summary>
    /// <param name="requestId">
    /// Identifier of the network request to get content for.
    /// </param>
    /// <param name="encoding">
    /// The encoding to use.
    /// </param>
    /// <param name="quality">
    /// The quality of the encoding (0-1). (defaults to 1)
    /// </param>
    /// <param name="sizeOnly">
    /// Whether to only return the size information (defaults to false).
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetEncodedResponseResult"/>.
    /// </returns>
    Task<GetEncodedResponseResult> GetEncodedResponseAsync(Network.RequestId requestId, GetEncodedResponseEncoding encoding, double? quality = null, bool? sizeOnly = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disables issues domain, prevents further issues from being reported to the client.
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
    /// Enables issues domain, sends the issues collected so far to the client by means of the
    /// <b>issueAdded</b> event.
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
    Task<EnableResult> EnableAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Runs the form issues check for the target page. Found issues are reported
    /// using Audits.issueAdded event.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CheckFormsIssuesResult"/>.
    /// </returns>
    Task<CheckFormsIssuesResult> CheckFormsIssuesAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="IssueAddedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Issue</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<IssueAddedEventArgs> IssueAdded { get; }

}

[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
internal sealed class AuditsDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), IAudits
{
    private static readonly AuditsJsonSerializerContext JsonContext = AuditsJsonSerializerContext.Default;

    public async Task<GetEncodedResponseResult> GetEncodedResponseAsync(Network.RequestId requestId, GetEncodedResponseEncoding encoding, double? quality = null, bool? sizeOnly = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetEncodedResponseCommandParameters(RequestId: requestId, Encoding: encoding, Quality: quality, SizeOnly: sizeOnly);
        return await ExecuteCommandAsync("Audits.getEncodedResponse", @params, JsonContext.GetEncodedResponseCommandParameters, JsonContext.GetEncodedResponseResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<DisableResult> DisableAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync("Audits.disable", @params, JsonContext.DisableCommandParameters, JsonContext.DisableResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<EnableResult> EnableAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters();
        return await ExecuteCommandAsync("Audits.enable", @params, JsonContext.EnableCommandParameters, JsonContext.EnableResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<CheckFormsIssuesResult> CheckFormsIssuesAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new CheckFormsIssuesCommandParameters();
        return await ExecuteCommandAsync("Audits.checkFormsIssues", @params, JsonContext.CheckFormsIssuesCommandParameters, JsonContext.CheckFormsIssuesResult, session, cancellationToken).ConfigureAwait(false);
    }

    public IEventSource<IssueAddedEventArgs> IssueAdded => CreateCdpEventSource(AuditsDomainEvent.IssueAdded);
}

internal sealed record GetEncodedResponseCommandParameters(Network.RequestId RequestId, GetEncodedResponseEncoding Encoding, double? Quality, bool? SizeOnly) : Parameters;

/// <summary>
/// Result of the <see cref="IAudits.GetEncodedResponseAsync"/> command.
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
/// Result of the <see cref="IAudits.DisableAsync"/> command.
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IAudits.EnableAsync"/> command.
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record CheckFormsIssuesCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IAudits.CheckFormsIssuesAsync"/> command.
/// </summary>
/// <param name="FormIssues">
/// </param>
public sealed record CheckFormsIssuesResult(ImmutableArray<GenericIssueDetails> FormIssues) : EmptyResult;


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
    /// Corresponds to the <c>"ExcludeSameSiteUnspecifiedTreatedAsLax"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ExcludeSameSiteUnspecifiedTreatedAsLax")]
    ExcludeSameSiteUnspecifiedTreatedAsLax,
    /// <summary>
    /// Corresponds to the <c>"ExcludeSameSiteNoneInsecure"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ExcludeSameSiteNoneInsecure")]
    ExcludeSameSiteNoneInsecure,
    /// <summary>
    /// Corresponds to the <c>"ExcludeSameSiteLax"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ExcludeSameSiteLax")]
    ExcludeSameSiteLax,
    /// <summary>
    /// Corresponds to the <c>"ExcludeSameSiteStrict"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ExcludeSameSiteStrict")]
    ExcludeSameSiteStrict,
    /// <summary>
    /// Corresponds to the <c>"ExcludeDomainNonASCII"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ExcludeDomainNonASCII")]
    ExcludeDomainNonASCII,
    /// <summary>
    /// Corresponds to the <c>"ExcludeThirdPartyPhaseout"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ExcludeThirdPartyPhaseout")]
    ExcludeThirdPartyPhaseout,
    /// <summary>
    /// Corresponds to the <c>"ExcludePortMismatch"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ExcludePortMismatch")]
    ExcludePortMismatch,
    /// <summary>
    /// Corresponds to the <c>"ExcludeSchemeMismatch"</c> wire value.
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
    /// Corresponds to the <c>"WarnSameSiteUnspecifiedCrossSiteContext"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnSameSiteUnspecifiedCrossSiteContext")]
    WarnSameSiteUnspecifiedCrossSiteContext,
    /// <summary>
    /// Corresponds to the <c>"WarnSameSiteNoneInsecure"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnSameSiteNoneInsecure")]
    WarnSameSiteNoneInsecure,
    /// <summary>
    /// Corresponds to the <c>"WarnSameSiteUnspecifiedLaxAllowUnsafe"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnSameSiteUnspecifiedLaxAllowUnsafe")]
    WarnSameSiteUnspecifiedLaxAllowUnsafe,
    /// <summary>
    /// Corresponds to the <c>"WarnSameSiteStrictLaxDowngradeStrict"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnSameSiteStrictLaxDowngradeStrict")]
    WarnSameSiteStrictLaxDowngradeStrict,
    /// <summary>
    /// Corresponds to the <c>"WarnSameSiteStrictCrossDowngradeStrict"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnSameSiteStrictCrossDowngradeStrict")]
    WarnSameSiteStrictCrossDowngradeStrict,
    /// <summary>
    /// Corresponds to the <c>"WarnSameSiteStrictCrossDowngradeLax"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnSameSiteStrictCrossDowngradeLax")]
    WarnSameSiteStrictCrossDowngradeLax,
    /// <summary>
    /// Corresponds to the <c>"WarnSameSiteLaxCrossDowngradeStrict"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnSameSiteLaxCrossDowngradeStrict")]
    WarnSameSiteLaxCrossDowngradeStrict,
    /// <summary>
    /// Corresponds to the <c>"WarnSameSiteLaxCrossDowngradeLax"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnSameSiteLaxCrossDowngradeLax")]
    WarnSameSiteLaxCrossDowngradeLax,
    /// <summary>
    /// Corresponds to the <c>"WarnAttributeValueExceedsMaxSize"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnAttributeValueExceedsMaxSize")]
    WarnAttributeValueExceedsMaxSize,
    /// <summary>
    /// Corresponds to the <c>"WarnDomainNonASCII"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnDomainNonASCII")]
    WarnDomainNonASCII,
    /// <summary>
    /// Corresponds to the <c>"WarnThirdPartyPhaseout"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnThirdPartyPhaseout")]
    WarnThirdPartyPhaseout,
    /// <summary>
    /// Corresponds to the <c>"WarnCrossSiteRedirectDowngradeChangesInclusion"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnCrossSiteRedirectDowngradeChangesInclusion")]
    WarnCrossSiteRedirectDowngradeChangesInclusion,
    /// <summary>
    /// Corresponds to the <c>"WarnDeprecationTrialMetadata"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnDeprecationTrialMetadata")]
    WarnDeprecationTrialMetadata,
    /// <summary>
    /// Corresponds to the <c>"WarnThirdPartyCookieHeuristic"</c> wire value.
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
    /// Corresponds to the <c>"SetCookie"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SetCookie")]
    SetCookie,
    /// <summary>
    /// Corresponds to the <c>"ReadCookie"</c> wire value.
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
    /// Corresponds to the <c>"GitHubResource"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("GitHubResource")]
    GitHubResource,
    /// <summary>
    /// Corresponds to the <c>"GracePeriod"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("GracePeriod")]
    GracePeriod,
    /// <summary>
    /// Corresponds to the <c>"Heuristics"</c> wire value.
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
public sealed record CookieIssueDetails(ImmutableArray<CookieWarningReason> CookieWarningReasons, ImmutableArray<CookieExclusionReason> CookieExclusionReasons, CookieOperation Operation)
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
    /// Corresponds to the <c>"DocumentCookie"</c> wire value.
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
    /// Corresponds to the <c>"MixedContentBlocked"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MixedContentBlocked")]
    MixedContentBlocked,
    /// <summary>
    /// Corresponds to the <c>"MixedContentAutomaticallyUpgraded"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MixedContentAutomaticallyUpgraded")]
    MixedContentAutomaticallyUpgraded,
    /// <summary>
    /// Corresponds to the <c>"MixedContentWarning"</c> wire value.
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
    /// Corresponds to the <c>"Audio"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Audio")]
    Audio,
    /// <summary>
    /// Corresponds to the <c>"Beacon"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Beacon")]
    Beacon,
    /// <summary>
    /// Corresponds to the <c>"CSPReport"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CSPReport")]
    CSPReport,
    /// <summary>
    /// Corresponds to the <c>"Download"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Download")]
    Download,
    /// <summary>
    /// Corresponds to the <c>"EventSource"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EventSource")]
    EventSource,
    /// <summary>
    /// Corresponds to the <c>"Favicon"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Favicon")]
    Favicon,
    /// <summary>
    /// Corresponds to the <c>"Font"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Font")]
    Font,
    /// <summary>
    /// Corresponds to the <c>"Form"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Form")]
    Form,
    /// <summary>
    /// Corresponds to the <c>"Frame"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Frame")]
    Frame,
    /// <summary>
    /// Corresponds to the <c>"Image"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Image")]
    Image,
    /// <summary>
    /// Corresponds to the <c>"Import"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Import")]
    Import,
    /// <summary>
    /// Corresponds to the <c>"JSON"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("JSON")]
    JSON,
    /// <summary>
    /// Corresponds to the <c>"Manifest"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Manifest")]
    Manifest,
    /// <summary>
    /// Corresponds to the <c>"Ping"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Ping")]
    Ping,
    /// <summary>
    /// Corresponds to the <c>"PluginData"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PluginData")]
    PluginData,
    /// <summary>
    /// Corresponds to the <c>"PluginResource"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PluginResource")]
    PluginResource,
    /// <summary>
    /// Corresponds to the <c>"Prefetch"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Prefetch")]
    Prefetch,
    /// <summary>
    /// Corresponds to the <c>"Resource"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Resource")]
    Resource,
    /// <summary>
    /// Corresponds to the <c>"Script"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Script")]
    Script,
    /// <summary>
    /// Corresponds to the <c>"ServiceWorker"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ServiceWorker")]
    ServiceWorker,
    /// <summary>
    /// Corresponds to the <c>"SharedWorker"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SharedWorker")]
    SharedWorker,
    /// <summary>
    /// Corresponds to the <c>"SpeculationRules"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SpeculationRules")]
    SpeculationRules,
    /// <summary>
    /// Corresponds to the <c>"Stylesheet"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Stylesheet")]
    Stylesheet,
    /// <summary>
    /// Corresponds to the <c>"Track"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Track")]
    Track,
    /// <summary>
    /// Corresponds to the <c>"Video"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Video")]
    Video,
    /// <summary>
    /// Corresponds to the <c>"Worker"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Worker")]
    Worker,
    /// <summary>
    /// Corresponds to the <c>"XMLHttpRequest"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("XMLHttpRequest")]
    XMLHttpRequest,
    /// <summary>
    /// Corresponds to the <c>"XSLT"</c> wire value.
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
    /// Corresponds to the <c>"CoepFrameResourceNeedsCoepHeader"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CoepFrameResourceNeedsCoepHeader")]
    CoepFrameResourceNeedsCoepHeader,
    /// <summary>
    /// Corresponds to the <c>"CoopSandboxedIFrameCannotNavigateToCoopPage"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CoopSandboxedIFrameCannotNavigateToCoopPage")]
    CoopSandboxedIFrameCannotNavigateToCoopPage,
    /// <summary>
    /// Corresponds to the <c>"CorpNotSameOrigin"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CorpNotSameOrigin")]
    CorpNotSameOrigin,
    /// <summary>
    /// Corresponds to the <c>"CorpNotSameOriginAfterDefaultedToSameOriginByCoep"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CorpNotSameOriginAfterDefaultedToSameOriginByCoep")]
    CorpNotSameOriginAfterDefaultedToSameOriginByCoep,
    /// <summary>
    /// Corresponds to the <c>"CorpNotSameOriginAfterDefaultedToSameOriginByDip"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CorpNotSameOriginAfterDefaultedToSameOriginByDip")]
    CorpNotSameOriginAfterDefaultedToSameOriginByDip,
    /// <summary>
    /// Corresponds to the <c>"CorpNotSameOriginAfterDefaultedToSameOriginByCoepAndDip"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CorpNotSameOriginAfterDefaultedToSameOriginByCoepAndDip")]
    CorpNotSameOriginAfterDefaultedToSameOriginByCoepAndDip,
    /// <summary>
    /// Corresponds to the <c>"CorpNotSameSite"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CorpNotSameSite")]
    CorpNotSameSite,
    /// <summary>
    /// Corresponds to the <c>"SRIMessageSignatureMismatch"</c> wire value.
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
    /// Corresponds to the <c>"HeavyAdBlocked"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("HeavyAdBlocked")]
    HeavyAdBlocked,
    /// <summary>
    /// Corresponds to the <c>"HeavyAdWarning"</c> wire value.
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
    /// Corresponds to the <c>"NetworkTotalLimit"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NetworkTotalLimit")]
    NetworkTotalLimit,
    /// <summary>
    /// Corresponds to the <c>"CpuTotalLimit"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CpuTotalLimit")]
    CpuTotalLimit,
    /// <summary>
    /// Corresponds to the <c>"CpuPeakLimit"</c> wire value.
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
    /// Corresponds to the <c>"kInlineViolation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("kInlineViolation")]
    KInlineViolation,
    /// <summary>
    /// Corresponds to the <c>"kEvalViolation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("kEvalViolation")]
    KEvalViolation,
    /// <summary>
    /// Corresponds to the <c>"kURLViolation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("kURLViolation")]
    KURLViolation,
    /// <summary>
    /// Corresponds to the <c>"kSRIViolation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("kSRIViolation")]
    KSRIViolation,
    /// <summary>
    /// Corresponds to the <c>"kTrustedTypesSinkViolation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("kTrustedTypesSinkViolation")]
    KTrustedTypesSinkViolation,
    /// <summary>
    /// Corresponds to the <c>"kTrustedTypesPolicyViolation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("kTrustedTypesPolicyViolation")]
    KTrustedTypesPolicyViolation,
    /// <summary>
    /// Corresponds to the <c>"kWasmEvalViolation"</c> wire value.
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
    /// Corresponds to the <c>"TransferIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TransferIssue")]
    TransferIssue,
    /// <summary>
    /// Corresponds to the <c>"CreationIssue"</c> wire value.
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
    /// Corresponds to the <c>"UseErrorCrossOriginNoCorsRequest"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UseErrorCrossOriginNoCorsRequest")]
    UseErrorCrossOriginNoCorsRequest,
    /// <summary>
    /// Corresponds to the <c>"UseErrorDictionaryLoadFailure"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UseErrorDictionaryLoadFailure")]
    UseErrorDictionaryLoadFailure,
    /// <summary>
    /// Corresponds to the <c>"UseErrorMatchingDictionaryNotUsed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UseErrorMatchingDictionaryNotUsed")]
    UseErrorMatchingDictionaryNotUsed,
    /// <summary>
    /// Corresponds to the <c>"UseErrorUnexpectedContentDictionaryHeader"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UseErrorUnexpectedContentDictionaryHeader")]
    UseErrorUnexpectedContentDictionaryHeader,
    /// <summary>
    /// Corresponds to the <c>"WriteErrorCossOriginNoCorsRequest"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorCossOriginNoCorsRequest")]
    WriteErrorCossOriginNoCorsRequest,
    /// <summary>
    /// Corresponds to the <c>"WriteErrorDisallowedBySettings"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorDisallowedBySettings")]
    WriteErrorDisallowedBySettings,
    /// <summary>
    /// Corresponds to the <c>"WriteErrorExpiredResponse"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorExpiredResponse")]
    WriteErrorExpiredResponse,
    /// <summary>
    /// Corresponds to the <c>"WriteErrorFeatureDisabled"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorFeatureDisabled")]
    WriteErrorFeatureDisabled,
    /// <summary>
    /// Corresponds to the <c>"WriteErrorInsufficientResources"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorInsufficientResources")]
    WriteErrorInsufficientResources,
    /// <summary>
    /// Corresponds to the <c>"WriteErrorInvalidMatchField"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorInvalidMatchField")]
    WriteErrorInvalidMatchField,
    /// <summary>
    /// Corresponds to the <c>"WriteErrorInvalidStructuredHeader"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorInvalidStructuredHeader")]
    WriteErrorInvalidStructuredHeader,
    /// <summary>
    /// Corresponds to the <c>"WriteErrorInvalidTTLField"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorInvalidTTLField")]
    WriteErrorInvalidTTLField,
    /// <summary>
    /// Corresponds to the <c>"WriteErrorNavigationRequest"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorNavigationRequest")]
    WriteErrorNavigationRequest,
    /// <summary>
    /// Corresponds to the <c>"WriteErrorNoMatchField"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorNoMatchField")]
    WriteErrorNoMatchField,
    /// <summary>
    /// Corresponds to the <c>"WriteErrorNonIntegerTTLField"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorNonIntegerTTLField")]
    WriteErrorNonIntegerTTLField,
    /// <summary>
    /// Corresponds to the <c>"WriteErrorNonListMatchDestField"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorNonListMatchDestField")]
    WriteErrorNonListMatchDestField,
    /// <summary>
    /// Corresponds to the <c>"WriteErrorNonSecureContext"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorNonSecureContext")]
    WriteErrorNonSecureContext,
    /// <summary>
    /// Corresponds to the <c>"WriteErrorNonStringIdField"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorNonStringIdField")]
    WriteErrorNonStringIdField,
    /// <summary>
    /// Corresponds to the <c>"WriteErrorNonStringInMatchDestList"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorNonStringInMatchDestList")]
    WriteErrorNonStringInMatchDestList,
    /// <summary>
    /// Corresponds to the <c>"WriteErrorInvalidMatchDestList"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorInvalidMatchDestList")]
    WriteErrorInvalidMatchDestList,
    /// <summary>
    /// Corresponds to the <c>"WriteErrorNonStringMatchField"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorNonStringMatchField")]
    WriteErrorNonStringMatchField,
    /// <summary>
    /// Corresponds to the <c>"WriteErrorNonTokenTypeField"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorNonTokenTypeField")]
    WriteErrorNonTokenTypeField,
    /// <summary>
    /// Corresponds to the <c>"WriteErrorRequestAborted"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorRequestAborted")]
    WriteErrorRequestAborted,
    /// <summary>
    /// Corresponds to the <c>"WriteErrorShuttingDown"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorShuttingDown")]
    WriteErrorShuttingDown,
    /// <summary>
    /// Corresponds to the <c>"WriteErrorTooLongIdField"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WriteErrorTooLongIdField")]
    WriteErrorTooLongIdField,
    /// <summary>
    /// Corresponds to the <c>"WriteErrorUnsupportedType"</c> wire value.
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
    /// Corresponds to the <c>"MissingSignatureHeader"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MissingSignatureHeader")]
    MissingSignatureHeader,
    /// <summary>
    /// Corresponds to the <c>"MissingSignatureInputHeader"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MissingSignatureInputHeader")]
    MissingSignatureInputHeader,
    /// <summary>
    /// Corresponds to the <c>"InvalidSignatureHeader"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidSignatureHeader")]
    InvalidSignatureHeader,
    /// <summary>
    /// Corresponds to the <c>"InvalidSignatureInputHeader"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidSignatureInputHeader")]
    InvalidSignatureInputHeader,
    /// <summary>
    /// Corresponds to the <c>"SignatureHeaderValueIsNotByteSequence"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureHeaderValueIsNotByteSequence")]
    SignatureHeaderValueIsNotByteSequence,
    /// <summary>
    /// Corresponds to the <c>"SignatureHeaderValueIsParameterized"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureHeaderValueIsParameterized")]
    SignatureHeaderValueIsParameterized,
    /// <summary>
    /// Corresponds to the <c>"SignatureHeaderValueIsIncorrectLength"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureHeaderValueIsIncorrectLength")]
    SignatureHeaderValueIsIncorrectLength,
    /// <summary>
    /// Corresponds to the <c>"SignatureInputHeaderMissingLabel"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureInputHeaderMissingLabel")]
    SignatureInputHeaderMissingLabel,
    /// <summary>
    /// Corresponds to the <c>"SignatureInputHeaderValueNotInnerList"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureInputHeaderValueNotInnerList")]
    SignatureInputHeaderValueNotInnerList,
    /// <summary>
    /// Corresponds to the <c>"SignatureInputHeaderValueMissingComponents"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureInputHeaderValueMissingComponents")]
    SignatureInputHeaderValueMissingComponents,
    /// <summary>
    /// Corresponds to the <c>"SignatureInputHeaderInvalidComponentType"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureInputHeaderInvalidComponentType")]
    SignatureInputHeaderInvalidComponentType,
    /// <summary>
    /// Corresponds to the <c>"SignatureInputHeaderInvalidComponentName"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureInputHeaderInvalidComponentName")]
    SignatureInputHeaderInvalidComponentName,
    /// <summary>
    /// Corresponds to the <c>"SignatureInputHeaderInvalidHeaderComponentParameter"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureInputHeaderInvalidHeaderComponentParameter")]
    SignatureInputHeaderInvalidHeaderComponentParameter,
    /// <summary>
    /// Corresponds to the <c>"SignatureInputHeaderInvalidDerivedComponentParameter"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureInputHeaderInvalidDerivedComponentParameter")]
    SignatureInputHeaderInvalidDerivedComponentParameter,
    /// <summary>
    /// Corresponds to the <c>"SignatureInputHeaderKeyIdLength"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureInputHeaderKeyIdLength")]
    SignatureInputHeaderKeyIdLength,
    /// <summary>
    /// Corresponds to the <c>"SignatureInputHeaderInvalidParameter"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureInputHeaderInvalidParameter")]
    SignatureInputHeaderInvalidParameter,
    /// <summary>
    /// Corresponds to the <c>"SignatureInputHeaderMissingRequiredParameters"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureInputHeaderMissingRequiredParameters")]
    SignatureInputHeaderMissingRequiredParameters,
    /// <summary>
    /// Corresponds to the <c>"ValidationFailedSignatureExpired"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ValidationFailedSignatureExpired")]
    ValidationFailedSignatureExpired,
    /// <summary>
    /// Corresponds to the <c>"ValidationFailedInvalidLength"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ValidationFailedInvalidLength")]
    ValidationFailedInvalidLength,
    /// <summary>
    /// Corresponds to the <c>"ValidationFailedSignatureMismatch"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ValidationFailedSignatureMismatch")]
    ValidationFailedSignatureMismatch,
    /// <summary>
    /// Corresponds to the <c>"ValidationFailedIntegrityMismatch"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ValidationFailedIntegrityMismatch")]
    ValidationFailedIntegrityMismatch,
    /// <summary>
    /// Corresponds to the <c>"SignatureBaseUnknownDerivedComponent"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureBaseUnknownDerivedComponent")]
    SignatureBaseUnknownDerivedComponent,
    /// <summary>
    /// Corresponds to the <c>"SignatureBaseMissingHeader"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureBaseMissingHeader")]
    SignatureBaseMissingHeader,
    /// <summary>
    /// Corresponds to the <c>"SignatureBaseInvalidUnencodedDigest"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignatureBaseInvalidUnencodedDigest")]
    SignatureBaseInvalidUnencodedDigest,
    /// <summary>
    /// Corresponds to the <c>"SignatureBaseUnsupportedComponent"</c> wire value.
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
    /// Corresponds to the <c>"MalformedDictionary"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MalformedDictionary")]
    MalformedDictionary,
    /// <summary>
    /// Corresponds to the <c>"UnknownAlgorithm"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UnknownAlgorithm")]
    UnknownAlgorithm,
    /// <summary>
    /// Corresponds to the <c>"IncorrectDigestType"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IncorrectDigestType")]
    IncorrectDigestType,
    /// <summary>
    /// Corresponds to the <c>"IncorrectDigestLength"</c> wire value.
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
    /// Corresponds to the <c>"InvalidHeader"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidHeader")]
    InvalidHeader,
    /// <summary>
    /// Corresponds to the <c>"MoreThanOneList"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MoreThanOneList")]
    MoreThanOneList,
    /// <summary>
    /// Corresponds to the <c>"ItemNotInnerList"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ItemNotInnerList")]
    ItemNotInnerList,
    /// <summary>
    /// Corresponds to the <c>"InvalidAllowlistItemType"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidAllowlistItemType")]
    InvalidAllowlistItemType,
    /// <summary>
    /// Corresponds to the <c>"ReportingEndpointNotToken"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ReportingEndpointNotToken")]
    ReportingEndpointNotToken,
    /// <summary>
    /// Corresponds to the <c>"InvalidUrlPattern"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidUrlPattern")]
    InvalidUrlPattern,
    /// <summary>
    /// Corresponds to the <c>"IFrameAttributeLoosensEmbeddingRequirement"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IFrameAttributeLoosensEmbeddingRequirement")]
    IFrameAttributeLoosensEmbeddingRequirement,
    /// <summary>
    /// Corresponds to the <c>"InvalidAllowConnectionAllowlistFrom"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidAllowConnectionAllowlistFrom")]
    InvalidAllowConnectionAllowlistFrom,
    /// <summary>
    /// Corresponds to the <c>"EmbeddingRequirementNotSatisfied"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbeddingRequirementNotSatisfied")]
    EmbeddingRequirementNotSatisfied,
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
public sealed record SRIMessageSignatureIssueDetails(SRIMessageSignatureError Error, string SignatureBase, ImmutableArray<string> IntegrityAssertions, AffectedRequest Request)
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
    /// Corresponds to the <c>"FormLabelForNameError"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormLabelForNameError")]
    FormLabelForNameError,
    /// <summary>
    /// Corresponds to the <c>"FormDuplicateIdForInputError"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormDuplicateIdForInputError")]
    FormDuplicateIdForInputError,
    /// <summary>
    /// Corresponds to the <c>"FormInputWithNoLabelError"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormInputWithNoLabelError")]
    FormInputWithNoLabelError,
    /// <summary>
    /// Corresponds to the <c>"FormAutocompleteAttributeEmptyError"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormAutocompleteAttributeEmptyError")]
    FormAutocompleteAttributeEmptyError,
    /// <summary>
    /// Corresponds to the <c>"FormEmptyIdAndNameAttributesForInputError"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormEmptyIdAndNameAttributesForInputError")]
    FormEmptyIdAndNameAttributesForInputError,
    /// <summary>
    /// Corresponds to the <c>"FormAriaLabelledByToNonExistingIdError"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormAriaLabelledByToNonExistingIdError")]
    FormAriaLabelledByToNonExistingIdError,
    /// <summary>
    /// Corresponds to the <c>"FormInputAssignedAutocompleteValueToIdOrNameAttributeError"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormInputAssignedAutocompleteValueToIdOrNameAttributeError")]
    FormInputAssignedAutocompleteValueToIdOrNameAttributeError,
    /// <summary>
    /// Corresponds to the <c>"FormLabelHasNeitherForNorNestedInputError"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormLabelHasNeitherForNorNestedInputError")]
    FormLabelHasNeitherForNorNestedInputError,
    /// <summary>
    /// Corresponds to the <c>"FormLabelForMatchesNonExistingIdError"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormLabelForMatchesNonExistingIdError")]
    FormLabelForMatchesNonExistingIdError,
    /// <summary>
    /// Corresponds to the <c>"FormInputHasWrongButWellIntendedAutocompleteValueError"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormInputHasWrongButWellIntendedAutocompleteValueError")]
    FormInputHasWrongButWellIntendedAutocompleteValueError,
    /// <summary>
    /// Corresponds to the <c>"ResponseWasBlockedByORB"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ResponseWasBlockedByORB")]
    ResponseWasBlockedByORB,
    /// <summary>
    /// Corresponds to the <c>"NavigationEntryMarkedSkippable"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NavigationEntryMarkedSkippable")]
    NavigationEntryMarkedSkippable,
    /// <summary>
    /// Corresponds to the <c>"BackUINavigationWouldSkipAd"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BackUINavigationWouldSkipAd")]
    BackUINavigationWouldSkipAd,
    /// <summary>
    /// Corresponds to the <c>"AutofillAndManualTextPolicyControlledFeaturesInfo"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AutofillAndManualTextPolicyControlledFeaturesInfo")]
    AutofillAndManualTextPolicyControlledFeaturesInfo,
    /// <summary>
    /// Corresponds to the <c>"AutofillPolicyControlledFeatureInfo"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AutofillPolicyControlledFeatureInfo")]
    AutofillPolicyControlledFeatureInfo,
    /// <summary>
    /// Corresponds to the <c>"ManualTextPolicyControlledFeatureInfo"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ManualTextPolicyControlledFeatureInfo")]
    ManualTextPolicyControlledFeatureInfo,
    /// <summary>
    /// Corresponds to the <c>"FormModelContextParameterMissingTitleAndDescription"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormModelContextParameterMissingTitleAndDescription")]
    FormModelContextParameterMissingTitleAndDescription,
    /// <summary>
    /// Corresponds to the <c>"FormModelContextMissingToolName"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormModelContextMissingToolName")]
    FormModelContextMissingToolName,
    /// <summary>
    /// Corresponds to the <c>"FormModelContextMissingToolDescription"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormModelContextMissingToolDescription")]
    FormModelContextMissingToolDescription,
    /// <summary>
    /// Corresponds to the <c>"FormModelContextRequiredParameterMissingName"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormModelContextRequiredParameterMissingName")]
    FormModelContextRequiredParameterMissingName,
    /// <summary>
    /// Corresponds to the <c>"FormModelContextParameterMissingName"</c> wire value.
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
public sealed record BounceTrackingIssueDetails(ImmutableArray<string> TrackingSites)
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
public sealed record CookieDeprecationMetadataIssueDetails(ImmutableArray<string> AllowedSites, double OptOutPercentage, bool IsOptOutTopLevel, CookieOperation Operation)
{
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ClientHintIssueReason>))]
public enum ClientHintIssueReason
{
    /// <summary>
    /// Corresponds to the <c>"MetaTagAllowListInvalidOrigin"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MetaTagAllowListInvalidOrigin")]
    MetaTagAllowListInvalidOrigin,
    /// <summary>
    /// Corresponds to the <c>"MetaTagModifiedHTML"</c> wire value.
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
    /// Corresponds to the <c>"ShouldEmbargo"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ShouldEmbargo")]
    ShouldEmbargo,
    /// <summary>
    /// Corresponds to the <c>"TooManyRequests"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TooManyRequests")]
    TooManyRequests,
    /// <summary>
    /// Corresponds to the <c>"WellKnownHttpNotFound"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownHttpNotFound")]
    WellKnownHttpNotFound,
    /// <summary>
    /// Corresponds to the <c>"WellKnownNoResponse"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownNoResponse")]
    WellKnownNoResponse,
    /// <summary>
    /// Corresponds to the <c>"WellKnownBlockedByConnectionAllowlist"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownBlockedByConnectionAllowlist")]
    WellKnownBlockedByConnectionAllowlist,
    /// <summary>
    /// Corresponds to the <c>"WellKnownInvalidResponse"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownInvalidResponse")]
    WellKnownInvalidResponse,
    /// <summary>
    /// Corresponds to the <c>"WellKnownListEmpty"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownListEmpty")]
    WellKnownListEmpty,
    /// <summary>
    /// Corresponds to the <c>"WellKnownInvalidContentType"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownInvalidContentType")]
    WellKnownInvalidContentType,
    /// <summary>
    /// Corresponds to the <c>"ConfigNotInWellKnown"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ConfigNotInWellKnown")]
    ConfigNotInWellKnown,
    /// <summary>
    /// Corresponds to the <c>"WellKnownTooBig"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownTooBig")]
    WellKnownTooBig,
    /// <summary>
    /// Corresponds to the <c>"ConfigHttpNotFound"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ConfigHttpNotFound")]
    ConfigHttpNotFound,
    /// <summary>
    /// Corresponds to the <c>"ConfigNoResponse"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ConfigNoResponse")]
    ConfigNoResponse,
    /// <summary>
    /// Corresponds to the <c>"ConfigBlockedByConnectionAllowlist"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ConfigBlockedByConnectionAllowlist")]
    ConfigBlockedByConnectionAllowlist,
    /// <summary>
    /// Corresponds to the <c>"ConfigInvalidResponse"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ConfigInvalidResponse")]
    ConfigInvalidResponse,
    /// <summary>
    /// Corresponds to the <c>"ConfigInvalidContentType"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ConfigInvalidContentType")]
    ConfigInvalidContentType,
    /// <summary>
    /// Corresponds to the <c>"IdpNotPotentiallyTrustworthy"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IdpNotPotentiallyTrustworthy")]
    IdpNotPotentiallyTrustworthy,
    /// <summary>
    /// Corresponds to the <c>"DisabledInSettings"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DisabledInSettings")]
    DisabledInSettings,
    /// <summary>
    /// Corresponds to the <c>"DisabledInFlags"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DisabledInFlags")]
    DisabledInFlags,
    /// <summary>
    /// Corresponds to the <c>"ErrorFetchingSignin"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ErrorFetchingSignin")]
    ErrorFetchingSignin,
    /// <summary>
    /// Corresponds to the <c>"InvalidSigninResponse"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidSigninResponse")]
    InvalidSigninResponse,
    /// <summary>
    /// Corresponds to the <c>"AccountsHttpNotFound"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AccountsHttpNotFound")]
    AccountsHttpNotFound,
    /// <summary>
    /// Corresponds to the <c>"AccountsNoResponse"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AccountsNoResponse")]
    AccountsNoResponse,
    /// <summary>
    /// Corresponds to the <c>"AccountsBlockedByConnectionAllowlist"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AccountsBlockedByConnectionAllowlist")]
    AccountsBlockedByConnectionAllowlist,
    /// <summary>
    /// Corresponds to the <c>"AccountsInvalidResponse"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AccountsInvalidResponse")]
    AccountsInvalidResponse,
    /// <summary>
    /// Corresponds to the <c>"AccountsListEmpty"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AccountsListEmpty")]
    AccountsListEmpty,
    /// <summary>
    /// Corresponds to the <c>"AccountsInvalidContentType"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AccountsInvalidContentType")]
    AccountsInvalidContentType,
    /// <summary>
    /// Corresponds to the <c>"IdTokenHttpNotFound"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IdTokenHttpNotFound")]
    IdTokenHttpNotFound,
    /// <summary>
    /// Corresponds to the <c>"IdTokenNoResponse"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IdTokenNoResponse")]
    IdTokenNoResponse,
    /// <summary>
    /// Corresponds to the <c>"IdTokenBlockedByConnectionAllowlist"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IdTokenBlockedByConnectionAllowlist")]
    IdTokenBlockedByConnectionAllowlist,
    /// <summary>
    /// Corresponds to the <c>"IdTokenInvalidResponse"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IdTokenInvalidResponse")]
    IdTokenInvalidResponse,
    /// <summary>
    /// Corresponds to the <c>"IdTokenIdpErrorResponse"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IdTokenIdpErrorResponse")]
    IdTokenIdpErrorResponse,
    /// <summary>
    /// Corresponds to the <c>"IdTokenCrossSiteIdpErrorResponse"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IdTokenCrossSiteIdpErrorResponse")]
    IdTokenCrossSiteIdpErrorResponse,
    /// <summary>
    /// Corresponds to the <c>"IdTokenInvalidRequest"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IdTokenInvalidRequest")]
    IdTokenInvalidRequest,
    /// <summary>
    /// Corresponds to the <c>"IdTokenInvalidContentType"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("IdTokenInvalidContentType")]
    IdTokenInvalidContentType,
    /// <summary>
    /// Corresponds to the <c>"ErrorIdToken"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ErrorIdToken")]
    ErrorIdToken,
    /// <summary>
    /// Corresponds to the <c>"Canceled"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Canceled")]
    Canceled,
    /// <summary>
    /// Corresponds to the <c>"RpPageNotVisible"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RpPageNotVisible")]
    RpPageNotVisible,
    /// <summary>
    /// Corresponds to the <c>"SilentMediationFailure"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SilentMediationFailure")]
    SilentMediationFailure,
    /// <summary>
    /// Corresponds to the <c>"NotSignedInWithIdp"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NotSignedInWithIdp")]
    NotSignedInWithIdp,
    /// <summary>
    /// Corresponds to the <c>"MissingTransientUserActivation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MissingTransientUserActivation")]
    MissingTransientUserActivation,
    /// <summary>
    /// Corresponds to the <c>"ReplacedByActiveMode"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ReplacedByActiveMode")]
    ReplacedByActiveMode,
    /// <summary>
    /// Corresponds to the <c>"RelyingPartyOriginIsOpaque"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RelyingPartyOriginIsOpaque")]
    RelyingPartyOriginIsOpaque,
    /// <summary>
    /// Corresponds to the <c>"TypeNotMatching"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TypeNotMatching")]
    TypeNotMatching,
    /// <summary>
    /// Corresponds to the <c>"UiDismissedNoEmbargo"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UiDismissedNoEmbargo")]
    UiDismissedNoEmbargo,
    /// <summary>
    /// Corresponds to the <c>"CorsError"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CorsError")]
    CorsError,
    /// <summary>
    /// Corresponds to the <c>"SuppressedBySegmentationPlatform"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SuppressedBySegmentationPlatform")]
    SuppressedBySegmentationPlatform,
    /// <summary>
    /// Corresponds to the <c>"PopupBlockedByConnectionAllowlist"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PopupBlockedByConnectionAllowlist")]
    PopupBlockedByConnectionAllowlist,
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
    /// Corresponds to the <c>"NotSameOrigin"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NotSameOrigin")]
    NotSameOrigin,
    /// <summary>
    /// Corresponds to the <c>"NotIframe"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NotIframe")]
    NotIframe,
    /// <summary>
    /// Corresponds to the <c>"NotPotentiallyTrustworthy"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NotPotentiallyTrustworthy")]
    NotPotentiallyTrustworthy,
    /// <summary>
    /// Corresponds to the <c>"NoApiPermission"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NoApiPermission")]
    NoApiPermission,
    /// <summary>
    /// Corresponds to the <c>"NotSignedInWithIdp"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NotSignedInWithIdp")]
    NotSignedInWithIdp,
    /// <summary>
    /// Corresponds to the <c>"NoAccountSharingPermission"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NoAccountSharingPermission")]
    NoAccountSharingPermission,
    /// <summary>
    /// Corresponds to the <c>"InvalidConfigOrWellKnown"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidConfigOrWellKnown")]
    InvalidConfigOrWellKnown,
    /// <summary>
    /// Corresponds to the <c>"InvalidAccountsResponse"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidAccountsResponse")]
    InvalidAccountsResponse,
    /// <summary>
    /// Corresponds to the <c>"NoReturningUserFromFetchedAccounts"</c> wire value.
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
    /// Corresponds to the <c>"InvalidEmail"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidEmail")]
    InvalidEmail,
    /// <summary>
    /// Corresponds to the <c>"DnsFetchFailed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DnsFetchFailed")]
    DnsFetchFailed,
    /// <summary>
    /// Corresponds to the <c>"DnsInvalidRecord"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DnsInvalidRecord")]
    DnsInvalidRecord,
    /// <summary>
    /// Corresponds to the <c>"WellKnownHttpNotFound"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownHttpNotFound")]
    WellKnownHttpNotFound,
    /// <summary>
    /// Corresponds to the <c>"WellKnownNoResponse"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownNoResponse")]
    WellKnownNoResponse,
    /// <summary>
    /// Corresponds to the <c>"WellKnownInvalidResponse"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownInvalidResponse")]
    WellKnownInvalidResponse,
    /// <summary>
    /// Corresponds to the <c>"WellKnownListEmpty"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownListEmpty")]
    WellKnownListEmpty,
    /// <summary>
    /// Corresponds to the <c>"WellKnownInvalidContentType"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownInvalidContentType")]
    WellKnownInvalidContentType,
    /// <summary>
    /// Corresponds to the <c>"WellKnownMissingIssuanceEndpoint"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownMissingIssuanceEndpoint")]
    WellKnownMissingIssuanceEndpoint,
    /// <summary>
    /// Corresponds to the <c>"WellKnownIssuanceEndpointCrossOrigin"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownIssuanceEndpointCrossOrigin")]
    WellKnownIssuanceEndpointCrossOrigin,
    /// <summary>
    /// Corresponds to the <c>"WellKnownUnsupportedSigningAlgorithm"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownUnsupportedSigningAlgorithm")]
    WellKnownUnsupportedSigningAlgorithm,
    /// <summary>
    /// Corresponds to the <c>"TokenHttpNotFound"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenHttpNotFound")]
    TokenHttpNotFound,
    /// <summary>
    /// Corresponds to the <c>"TokenNoResponse"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenNoResponse")]
    TokenNoResponse,
    /// <summary>
    /// Corresponds to the <c>"TokenInvalidResponse"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenInvalidResponse")]
    TokenInvalidResponse,
    /// <summary>
    /// Corresponds to the <c>"TokenInvalidContentType"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenInvalidContentType")]
    TokenInvalidContentType,
    /// <summary>
    /// Corresponds to the <c>"TokenMalformedSdJwt"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenMalformedSdJwt")]
    TokenMalformedSdJwt,
    /// <summary>
    /// Corresponds to the <c>"TokenInvalidSdJwt"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenInvalidSdJwt")]
    TokenInvalidSdJwt,
    /// <summary>
    /// Corresponds to the <c>"KeyBindingSigningFailed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("KeyBindingSigningFailed")]
    KeyBindingSigningFailed,
    /// <summary>
    /// Corresponds to the <c>"RpOriginIsOpaque"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RpOriginIsOpaque")]
    RpOriginIsOpaque,
    /// <summary>
    /// Corresponds to the <c>"WellKnownMissingAccountsEndpoint"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownMissingAccountsEndpoint")]
    WellKnownMissingAccountsEndpoint,
    /// <summary>
    /// Corresponds to the <c>"UserLoggedOut"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UserLoggedOut")]
    UserLoggedOut,
    /// <summary>
    /// Corresponds to the <c>"WellKnownAccountsEndpointCrossOrigin"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WellKnownAccountsEndpointCrossOrigin")]
    WellKnownAccountsEndpointCrossOrigin,
    /// <summary>
    /// Corresponds to the <c>"AccountsHttpNotFound"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AccountsHttpNotFound")]
    AccountsHttpNotFound,
    /// <summary>
    /// Corresponds to the <c>"AccountsNoResponse"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AccountsNoResponse")]
    AccountsNoResponse,
    /// <summary>
    /// Corresponds to the <c>"AccountsInvalidResponse"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AccountsInvalidResponse")]
    AccountsInvalidResponse,
    /// <summary>
    /// Corresponds to the <c>"AccountsInvalidContentType"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AccountsInvalidContentType")]
    AccountsInvalidContentType,
    /// <summary>
    /// Corresponds to the <c>"AccountsEmptyList"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AccountsEmptyList")]
    AccountsEmptyList,
    /// <summary>
    /// Corresponds to the <c>"EmailVerificationWellKnownHttpNotFound"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmailVerificationWellKnownHttpNotFound")]
    EmailVerificationWellKnownHttpNotFound,
    /// <summary>
    /// Corresponds to the <c>"EmailVerificationWellKnownNoResponse"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmailVerificationWellKnownNoResponse")]
    EmailVerificationWellKnownNoResponse,
    /// <summary>
    /// Corresponds to the <c>"EmailVerificationWellKnownInvalidResponse"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmailVerificationWellKnownInvalidResponse")]
    EmailVerificationWellKnownInvalidResponse,
    /// <summary>
    /// Corresponds to the <c>"EmailVerificationWellKnownInvalidContentType"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmailVerificationWellKnownInvalidContentType")]
    EmailVerificationWellKnownInvalidContentType,
    /// <summary>
    /// Corresponds to the <c>"JwksHttpNotFound"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("JwksHttpNotFound")]
    JwksHttpNotFound,
    /// <summary>
    /// Corresponds to the <c>"JwksInvalidResponse"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("JwksInvalidResponse")]
    JwksInvalidResponse,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationSdJwtUnsupportedHeaderAlg"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtUnsupportedHeaderAlg")]
    TokenVerificationSdJwtUnsupportedHeaderAlg,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationSdJwtInvalidTyp"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtInvalidTyp")]
    TokenVerificationSdJwtInvalidTyp,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationSdJwtMissingIss"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtMissingIss")]
    TokenVerificationSdJwtMissingIss,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationSdJwtMissingIat"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtMissingIat")]
    TokenVerificationSdJwtMissingIat,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationSdJwtMissingCnf"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtMissingCnf")]
    TokenVerificationSdJwtMissingCnf,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationSdJwtMissingEmail"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtMissingEmail")]
    TokenVerificationSdJwtMissingEmail,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationSdJwtInvalidIssuedAt"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtInvalidIssuedAt")]
    TokenVerificationSdJwtInvalidIssuedAt,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationSdJwtInvalidIssuer"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtInvalidIssuer")]
    TokenVerificationSdJwtInvalidIssuer,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationSdJwtJwksMissingKeys"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtJwksMissingKeys")]
    TokenVerificationSdJwtJwksMissingKeys,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationSdJwtSignatureFailed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtSignatureFailed")]
    TokenVerificationSdJwtSignatureFailed,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationSdJwtInvalidEmailVerified"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtInvalidEmailVerified")]
    TokenVerificationSdJwtInvalidEmailVerified,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationSdJwtInvalidEmail"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtInvalidEmail")]
    TokenVerificationSdJwtInvalidEmail,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationSdJwtInvalidHolderKey"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationSdJwtInvalidHolderKey")]
    TokenVerificationSdJwtInvalidHolderKey,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationKbInvalidTyp"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationKbInvalidTyp")]
    TokenVerificationKbInvalidTyp,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationKbMissingAud"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationKbMissingAud")]
    TokenVerificationKbMissingAud,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationKbMissingNonce"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationKbMissingNonce")]
    TokenVerificationKbMissingNonce,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationKbMissingIat"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationKbMissingIat")]
    TokenVerificationKbMissingIat,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationKbMissingSdHash"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationKbMissingSdHash")]
    TokenVerificationKbMissingSdHash,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationKbInvalidIssuedAt"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationKbInvalidIssuedAt")]
    TokenVerificationKbInvalidIssuedAt,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationKbInvalidAudience"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationKbInvalidAudience")]
    TokenVerificationKbInvalidAudience,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationKbInvalidNonce"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationKbInvalidNonce")]
    TokenVerificationKbInvalidNonce,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationKbInvalidSdHash"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationKbInvalidSdHash")]
    TokenVerificationKbInvalidSdHash,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationKbMissingCnf"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationKbMissingCnf")]
    TokenVerificationKbMissingCnf,
    /// <summary>
    /// Corresponds to the <c>"TokenVerificationKbSignatureFailed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TokenVerificationKbSignatureFailed")]
    TokenVerificationKbSignatureFailed,
    /// <summary>
    /// Corresponds to the <c>"CrossOriginIframeNotSupported"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CrossOriginIframeNotSupported")]
    CrossOriginIframeNotSupported,
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
    /// Corresponds to the <c>"BlockedCrossPartitionFetching"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BlockedCrossPartitionFetching")]
    BlockedCrossPartitionFetching,
    /// <summary>
    /// Corresponds to the <c>"EnforceNoopenerForNavigation"</c> wire value.
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
    /// Corresponds to the <c>"DisallowedSelectChild"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DisallowedSelectChild")]
    DisallowedSelectChild,
    /// <summary>
    /// Corresponds to the <c>"DisallowedOptGroupChild"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DisallowedOptGroupChild")]
    DisallowedOptGroupChild,
    /// <summary>
    /// Corresponds to the <c>"NonPhrasingContentOptionChild"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NonPhrasingContentOptionChild")]
    NonPhrasingContentOptionChild,
    /// <summary>
    /// Corresponds to the <c>"InteractiveContentOptionChild"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InteractiveContentOptionChild")]
    InteractiveContentOptionChild,
    /// <summary>
    /// Corresponds to the <c>"InteractiveContentLegendChild"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InteractiveContentLegendChild")]
    InteractiveContentLegendChild,
    /// <summary>
    /// Corresponds to the <c>"InteractiveContentSummaryDescendant"</c> wire value.
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
    /// Corresponds to the <c>"LateImportRule"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("LateImportRule")]
    LateImportRule,
    /// <summary>
    /// Corresponds to the <c>"RequestFailed"</c> wire value.
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
    /// Corresponds to the <c>"InvalidSyntax"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidSyntax")]
    InvalidSyntax,
    /// <summary>
    /// Corresponds to the <c>"InvalidInitialValue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidInitialValue")]
    InvalidInitialValue,
    /// <summary>
    /// Corresponds to the <c>"InvalidInherits"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidInherits")]
    InvalidInherits,
    /// <summary>
    /// Corresponds to the <c>"InvalidName"</c> wire value.
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
    /// Corresponds to the <c>"BlockedFrameNavigation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BlockedFrameNavigation")]
    BlockedFrameNavigation,
    /// <summary>
    /// Corresponds to the <c>"BlockedSubresource"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BlockedSubresource")]
    BlockedSubresource,
    /// <summary>
    /// Corresponds to the <c>"NoisedCanvasReadback"</c> wire value.
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
    /// Corresponds to the <c>"InvalidType"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidType")]
    InvalidType,
    /// <summary>
    /// Corresponds to the <c>"FencedFrameDisallowed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FencedFrameDisallowed")]
    FencedFrameDisallowed,
    /// <summary>
    /// Corresponds to the <c>"CspFrameAncestorsMissing"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CspFrameAncestorsMissing")]
    CspFrameAncestorsMissing,
    /// <summary>
    /// Corresponds to the <c>"PermissionsPolicyBlocked"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PermissionsPolicyBlocked")]
    PermissionsPolicyBlocked,
    /// <summary>
    /// Corresponds to the <c>"PaddingRightUnsupported"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PaddingRightUnsupported")]
    PaddingRightUnsupported,
    /// <summary>
    /// Corresponds to the <c>"PaddingBottomUnsupported"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PaddingBottomUnsupported")]
    PaddingBottomUnsupported,
    /// <summary>
    /// Corresponds to the <c>"InsetBoxShadowUnsupported"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InsetBoxShadowUnsupported")]
    InsetBoxShadowUnsupported,
    /// <summary>
    /// Corresponds to the <c>"RequestInProgress"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RequestInProgress")]
    RequestInProgress,
    /// <summary>
    /// Corresponds to the <c>"UntrustedEvent"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UntrustedEvent")]
    UntrustedEvent,
    /// <summary>
    /// Corresponds to the <c>"RegistrationFailed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RegistrationFailed")]
    RegistrationFailed,
    /// <summary>
    /// Corresponds to the <c>"TypeNotSupported"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TypeNotSupported")]
    TypeNotSupported,
    /// <summary>
    /// Corresponds to the <c>"InvalidTypeActivation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidTypeActivation")]
    InvalidTypeActivation,
    /// <summary>
    /// Corresponds to the <c>"SecurityChecksFailed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SecurityChecksFailed")]
    SecurityChecksFailed,
    /// <summary>
    /// Corresponds to the <c>"ActivationDisabled"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ActivationDisabled")]
    ActivationDisabled,
    /// <summary>
    /// Corresponds to the <c>"GeolocationDeprecated"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("GeolocationDeprecated")]
    GeolocationDeprecated,
    /// <summary>
    /// Corresponds to the <c>"InvalidDisplayStyle"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidDisplayStyle")]
    InvalidDisplayStyle,
    /// <summary>
    /// Corresponds to the <c>"NonOpaqueColor"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NonOpaqueColor")]
    NonOpaqueColor,
    /// <summary>
    /// Corresponds to the <c>"LowContrast"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("LowContrast")]
    LowContrast,
    /// <summary>
    /// Corresponds to the <c>"FontSizeTooSmall"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FontSizeTooSmall")]
    FontSizeTooSmall,
    /// <summary>
    /// Corresponds to the <c>"FontSizeTooLarge"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FontSizeTooLarge")]
    FontSizeTooLarge,
    /// <summary>
    /// Corresponds to the <c>"InvalidSizeValue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidSizeValue")]
    InvalidSizeValue,
    /// <summary>
    /// Corresponds to the <c>"NonSecureContext"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NonSecureContext")]
    NonSecureContext,
    /// <summary>
    /// Corresponds to the <c>"MissingTransientUserActivation"</c> wire value.
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
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<WebInstallIssueReason>))]
public enum WebInstallIssueReason
{
    /// <summary>
    /// Corresponds to the <c>"ManifestParsingOrNetworkError"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ManifestParsingOrNetworkError")]
    ManifestParsingOrNetworkError,
    /// <summary>
    /// Corresponds to the <c>"StartUrlInvalid"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("StartUrlInvalid")]
    StartUrlInvalid,
    /// <summary>
    /// Corresponds to the <c>"ManifestMissingNameOrShortName"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ManifestMissingNameOrShortName")]
    ManifestMissingNameOrShortName,
    /// <summary>
    /// Corresponds to the <c>"ManifestMissingId"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ManifestMissingId")]
    ManifestMissingId,
    /// <summary>
    /// Corresponds to the <c>"NoManifest"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NoManifest")]
    NoManifest,
}

/// <summary>
/// This issue reports a failure involving a web app manifest used by a Web
/// Install operation.
/// </summary>
/// <param name="Reason">
/// </param>
public sealed record WebInstallIssueDetails(WebInstallIssueReason Reason)
{
    /// <summary>
    /// </summary>
    public string? ManifestUrl { get; init; }
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
    /// Corresponds to the <c>"CookieIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CookieIssue")]
    CookieIssue,
    /// <summary>
    /// Corresponds to the <c>"MixedContentIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MixedContentIssue")]
    MixedContentIssue,
    /// <summary>
    /// Corresponds to the <c>"BlockedByResponseIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BlockedByResponseIssue")]
    BlockedByResponseIssue,
    /// <summary>
    /// Corresponds to the <c>"HeavyAdIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("HeavyAdIssue")]
    HeavyAdIssue,
    /// <summary>
    /// Corresponds to the <c>"ContentSecurityPolicyIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ContentSecurityPolicyIssue")]
    ContentSecurityPolicyIssue,
    /// <summary>
    /// Corresponds to the <c>"SharedArrayBufferIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SharedArrayBufferIssue")]
    SharedArrayBufferIssue,
    /// <summary>
    /// Corresponds to the <c>"CorsIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CorsIssue")]
    CorsIssue,
    /// <summary>
    /// Corresponds to the <c>"QuirksModeIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("QuirksModeIssue")]
    QuirksModeIssue,
    /// <summary>
    /// Corresponds to the <c>"PartitioningBlobURLIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PartitioningBlobURLIssue")]
    PartitioningBlobURLIssue,
    /// <summary>
    /// Corresponds to the <c>"NavigatorUserAgentIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NavigatorUserAgentIssue")]
    NavigatorUserAgentIssue,
    /// <summary>
    /// Corresponds to the <c>"GenericIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("GenericIssue")]
    GenericIssue,
    /// <summary>
    /// Corresponds to the <c>"DeprecationIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DeprecationIssue")]
    DeprecationIssue,
    /// <summary>
    /// Corresponds to the <c>"ClientHintIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ClientHintIssue")]
    ClientHintIssue,
    /// <summary>
    /// Corresponds to the <c>"FederatedAuthRequestIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FederatedAuthRequestIssue")]
    FederatedAuthRequestIssue,
    /// <summary>
    /// Corresponds to the <c>"BounceTrackingIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BounceTrackingIssue")]
    BounceTrackingIssue,
    /// <summary>
    /// Corresponds to the <c>"CookieDeprecationMetadataIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CookieDeprecationMetadataIssue")]
    CookieDeprecationMetadataIssue,
    /// <summary>
    /// Corresponds to the <c>"StylesheetLoadingIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("StylesheetLoadingIssue")]
    StylesheetLoadingIssue,
    /// <summary>
    /// Corresponds to the <c>"FederatedAuthUserInfoRequestIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FederatedAuthUserInfoRequestIssue")]
    FederatedAuthUserInfoRequestIssue,
    /// <summary>
    /// Corresponds to the <c>"PropertyRuleIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PropertyRuleIssue")]
    PropertyRuleIssue,
    /// <summary>
    /// Corresponds to the <c>"SharedDictionaryIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SharedDictionaryIssue")]
    SharedDictionaryIssue,
    /// <summary>
    /// Corresponds to the <c>"ElementAccessibilityIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ElementAccessibilityIssue")]
    ElementAccessibilityIssue,
    /// <summary>
    /// Corresponds to the <c>"SRIMessageSignatureIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SRIMessageSignatureIssue")]
    SRIMessageSignatureIssue,
    /// <summary>
    /// Corresponds to the <c>"UnencodedDigestIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UnencodedDigestIssue")]
    UnencodedDigestIssue,
    /// <summary>
    /// Corresponds to the <c>"ConnectionAllowlistIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ConnectionAllowlistIssue")]
    ConnectionAllowlistIssue,
    /// <summary>
    /// Corresponds to the <c>"UserReidentificationIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UserReidentificationIssue")]
    UserReidentificationIssue,
    /// <summary>
    /// Corresponds to the <c>"PermissionElementIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PermissionElementIssue")]
    PermissionElementIssue,
    /// <summary>
    /// Corresponds to the <c>"PerformanceIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PerformanceIssue")]
    PerformanceIssue,
    /// <summary>
    /// Corresponds to the <c>"SelectivePermissionsInterventionIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SelectivePermissionsInterventionIssue")]
    SelectivePermissionsInterventionIssue,
    /// <summary>
    /// Corresponds to the <c>"EmailVerificationRequestIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmailVerificationRequestIssue")]
    EmailVerificationRequestIssue,
    /// <summary>
    /// Corresponds to the <c>"LazyLoadImageIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("LazyLoadImageIssue")]
    LazyLoadImageIssue,
    /// <summary>
    /// Corresponds to the <c>"WebInstallIssue"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebInstallIssue")]
    WebInstallIssue,
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

    /// <summary>
    /// </summary>
    public WebInstallIssueDetails? WebInstallIssueDetails { get; init; }
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

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<GetEncodedResponseEncoding>))]
public enum GetEncodedResponseEncoding
{
    /// <summary>
    /// Corresponds to the <c>"webp"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("webp")]
    Webp,
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
[JsonSerializable(typeof(WebInstallIssueReason), TypeInfoPropertyName = "AuditsWebInstallIssueReason")]
[JsonSerializable(typeof(WebInstallIssueDetails), TypeInfoPropertyName = "AuditsWebInstallIssueDetails")]
[JsonSerializable(typeof(SelectivePermissionsInterventionIssueDetails), TypeInfoPropertyName = "AuditsSelectivePermissionsInterventionIssueDetails")]
[JsonSerializable(typeof(LazyLoadImageIssueDetails), TypeInfoPropertyName = "AuditsLazyLoadImageIssueDetails")]
[JsonSerializable(typeof(InspectorIssueCode), TypeInfoPropertyName = "AuditsInspectorIssueCode")]
[JsonSerializable(typeof(InspectorIssueDetails), TypeInfoPropertyName = "AuditsInspectorIssueDetails")]
[JsonSerializable(typeof(IssueId), TypeInfoPropertyName = "AuditsIssueId")]
[JsonSerializable(typeof(InspectorIssue), TypeInfoPropertyName = "AuditsInspectorIssue")]
[JsonSerializable(typeof(ImmutableArray<GenericIssueDetails>), TypeInfoPropertyName = "ImmutableArrayAuditsGenericIssueDetails")]
[JsonSerializable(typeof(ImmutableArray<CookieWarningReason>), TypeInfoPropertyName = "ImmutableArrayAuditsCookieWarningReason")]
[JsonSerializable(typeof(ImmutableArray<CookieExclusionReason>), TypeInfoPropertyName = "ImmutableArrayAuditsCookieExclusionReason")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class AuditsJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="IAudits"/>.
/// </summary>
public static class AuditsDomainEvent
{
    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<IssueAddedEventArgs>> IssueAdded =>
        _issueAdded ?? global::System.Threading.Interlocked.CompareExchange(ref _issueAdded, EventDescriptor<CdpEventArgs<IssueAddedEventArgs>>.Create(
            "goog:cdp.Audits.issueAdded",
            AuditsJsonSerializerContext.Default.IssueAddedCdpEventArgs), null) ?? _issueAdded;
    private static EventDescriptor<CdpEventArgs<IssueAddedEventArgs>>? _issueAdded;

}
