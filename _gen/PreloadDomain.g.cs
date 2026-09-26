#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Preload;

/// <summary>
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public interface IPreload
{
    /// <summary>
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
    /// Upsert. Currently, it is only emitted when a rule set added.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="RuleSetUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RuleSet</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<RuleSetUpdatedEventArgs> RuleSetUpdated { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="RuleSetRemovedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Id</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<RuleSetRemovedEventArgs> RuleSetRemoved { get; }

    /// <summary>
    /// Fired when a preload enabled state is updated.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="PreloadEnabledStateUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>DisabledByPreference</b></description></item>
    /// <item><description><b>DisabledByDataSaver</b></description></item>
    /// <item><description><b>DisabledByBatterySaver</b></description></item>
    /// <item><description><b>DisabledByHoldbackPrefetchSpeculationRules</b></description></item>
    /// <item><description><b>DisabledByHoldbackPrerenderSpeculationRules</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<PreloadEnabledStateUpdatedEventArgs> PreloadEnabledStateUpdated { get; }

    /// <summary>
    /// Fired when a prefetch attempt is updated.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="PrefetchStatusUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Key</b></description></item>
    /// <item><description><b>PipelineId</b></description></item>
    /// <item><description><b>InitiatingFrameId</b> - The frame id of the frame initiating prefetch.</description></item>
    /// <item><description><b>PrefetchUrl</b></description></item>
    /// <item><description><b>Status</b></description></item>
    /// <item><description><b>PrefetchStatus</b></description></item>
    /// <item><description><b>RequestId</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<PrefetchStatusUpdatedEventArgs> PrefetchStatusUpdated { get; }

    /// <summary>
    /// Fired when a prerender attempt is updated.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="PrerenderStatusUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Key</b></description></item>
    /// <item><description><b>PipelineId</b></description></item>
    /// <item><description><b>Status</b></description></item>
    /// <item><description><b>EffectiveAction</b> - The action currently performed by this attempt. This differs from <b>key.action</b> after a prerender-until-script attempt is upgraded in place to a full prerender.</description></item>
    /// <item><description><b>PrerenderStatus</b></description></item>
    /// <item><description><b>DisallowedMojoInterface</b> - This is used to give users more information about the name of Mojo interface that is incompatible with prerender and has caused the cancellation of the attempt.</description></item>
    /// <item><description><b>MismatchedHeaders</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<PrerenderStatusUpdatedEventArgs> PrerenderStatusUpdated { get; }

    /// <summary>
    /// Send a list of sources for all preloading attempts in a document.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="PreloadingAttemptSourcesUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>LoaderId</b></description></item>
    /// <item><description><b>PreloadingAttemptSources</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<PreloadingAttemptSourcesUpdatedEventArgs> PreloadingAttemptSourcesUpdated { get; }

}

[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
internal sealed class PreloadDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), IPreload
{
    private static readonly PreloadJsonSerializerContext JsonContext = PreloadJsonSerializerContext.Default;

    public async Task<EnableResult> EnableAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters();
        return await ExecuteCommandAsync("Preload.enable", @params, JsonContext.EnableCommandParameters, JsonContext.EnableResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<DisableResult> DisableAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync("Preload.disable", @params, JsonContext.DisableCommandParameters, JsonContext.DisableResult, session, cancellationToken).ConfigureAwait(false);
    }

    public IEventSource<RuleSetUpdatedEventArgs> RuleSetUpdated => CreateCdpEventSource(PreloadDomainEvent.RuleSetUpdated);
    public IEventSource<RuleSetRemovedEventArgs> RuleSetRemoved => CreateCdpEventSource(PreloadDomainEvent.RuleSetRemoved);
    public IEventSource<PreloadEnabledStateUpdatedEventArgs> PreloadEnabledStateUpdated => CreateCdpEventSource(PreloadDomainEvent.PreloadEnabledStateUpdated);
    public IEventSource<PrefetchStatusUpdatedEventArgs> PrefetchStatusUpdated => CreateCdpEventSource(PreloadDomainEvent.PrefetchStatusUpdated);
    public IEventSource<PrerenderStatusUpdatedEventArgs> PrerenderStatusUpdated => CreateCdpEventSource(PreloadDomainEvent.PrerenderStatusUpdated);
    public IEventSource<PreloadingAttemptSourcesUpdatedEventArgs> PreloadingAttemptSourcesUpdated => CreateCdpEventSource(PreloadDomainEvent.PreloadingAttemptSourcesUpdated);
}

internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IPreload.EnableAsync"/> command.
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IPreload.DisableAsync"/> command.
/// </summary>
public sealed record DisableResult() : EmptyResult;


/// <summary>
/// Upsert. Currently, it is only emitted when a rule set added.
/// </summary>
/// <param name="RuleSet">
/// </param>
public sealed record RuleSetUpdatedEventArgs(RuleSet RuleSet) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
/// <param name="Id">
/// </param>
public sealed record RuleSetRemovedEventArgs(RuleSetId Id) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when a preload enabled state is updated.
/// </summary>
/// <param name="DisabledByPreference">
/// </param>
/// <param name="DisabledByDataSaver">
/// </param>
/// <param name="DisabledByBatterySaver">
/// </param>
/// <param name="DisabledByHoldbackPrefetchSpeculationRules">
/// </param>
/// <param name="DisabledByHoldbackPrerenderSpeculationRules">
/// </param>
public sealed record PreloadEnabledStateUpdatedEventArgs(bool DisabledByPreference, bool DisabledByDataSaver, bool DisabledByBatterySaver, bool DisabledByHoldbackPrefetchSpeculationRules, bool DisabledByHoldbackPrerenderSpeculationRules) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when a prefetch attempt is updated.
/// </summary>
/// <param name="Key">
/// </param>
/// <param name="PipelineId">
/// </param>
/// <param name="InitiatingFrameId">
/// The frame id of the frame initiating prefetch.
/// </param>
/// <param name="PrefetchUrl">
/// </param>
/// <param name="Status">
/// </param>
/// <param name="PrefetchStatus">
/// </param>
/// <param name="RequestId">
/// </param>
public sealed record PrefetchStatusUpdatedEventArgs(PreloadingAttemptKey Key, PreloadPipelineId PipelineId, Page.FrameId InitiatingFrameId, string PrefetchUrl, PreloadingStatus Status, PrefetchStatus PrefetchStatus, Network.RequestId RequestId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when a prerender attempt is updated.
/// </summary>
/// <param name="Key">
/// </param>
/// <param name="PipelineId">
/// </param>
/// <param name="Status">
/// </param>
/// <param name="EffectiveAction">
/// The action currently performed by this attempt. This differs from
/// <b>key.action</b> after a prerender-until-script attempt is upgraded in place
/// to a full prerender.
/// </param>
/// <param name="PrerenderStatus">
/// </param>
/// <param name="DisallowedMojoInterface">
/// This is used to give users more information about the name of Mojo interface
/// that is incompatible with prerender and has caused the cancellation of the attempt.
/// </param>
/// <param name="MismatchedHeaders">
/// </param>
public sealed record PrerenderStatusUpdatedEventArgs(PreloadingAttemptKey Key, PreloadPipelineId PipelineId, PreloadingStatus Status, SpeculationAction? EffectiveAction = null, PrerenderFinalStatus? PrerenderStatus = null, string? DisallowedMojoInterface = null, ImmutableArray<PrerenderMismatchedHeaders>? MismatchedHeaders = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Send a list of sources for all preloading attempts in a document.
/// </summary>
/// <param name="LoaderId">
/// </param>
/// <param name="PreloadingAttemptSources">
/// </param>
public sealed record PreloadingAttemptSourcesUpdatedEventArgs(Network.LoaderId LoaderId, ImmutableArray<PreloadingAttemptSource> PreloadingAttemptSources) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Unique id
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<RuleSetId>))]
public record RuleSetId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Corresponds to SpeculationRuleSet
/// </summary>
/// <param name="Id">
/// </param>
/// <param name="LoaderId">
/// Identifies a document which the rule set is associated with.
/// </param>
/// <param name="SourceText">
/// Source text of JSON representing the rule set. If it comes from
/// <b>&lt;script&gt;</b> tag, it is the textContent of the node. Note that it is
/// a JSON for valid case.
/// 
/// See also:
/// - https://wicg.github.io/nav-speculation/speculation-rules.html
/// - https://github.com/WICG/nav-speculation/blob/main/triggers.md
/// </param>
public sealed record RuleSet(RuleSetId Id, Network.LoaderId LoaderId, string SourceText)
{
    /// <summary>
    /// A speculation rule set is either added through an inline
    /// <b>&lt;script&gt;</b> tag or through an external resource via the
    /// 'Speculation-Rules' HTTP header. For the first case, we include
    /// the BackendNodeId of the relevant <b>&lt;script&gt;</b> tag. For the second
    /// case, we include the external URL where the rule set was loaded
    /// from, and also RequestId if Network domain is enabled.
    /// 
    /// See also:
    /// - https://wicg.github.io/nav-speculation/speculation-rules.html#speculation-rules-script
    /// - https://wicg.github.io/nav-speculation/speculation-rules.html#speculation-rules-header
    /// </summary>
    public DOM.BackendNodeId? BackendNodeId { get; init; }

    /// <summary>
    /// </summary>
    public string? Url { get; init; }

    /// <summary>
    /// </summary>
    public Network.RequestId? RequestId { get; init; }

    /// <summary>
    /// Error information
    /// <b>errorMessage</b> is null iff <b>errorType</b> is null.
    /// </summary>
    public RuleSetErrorType? ErrorType { get; init; }

    /// <summary>
    /// TODO(https://crbug.com/1425354): Replace this property with structured error.
    /// </summary>
    [global::System.Obsolete]
    public string? ErrorMessage { get; init; }

    /// <summary>
    /// For more details, see:
    /// https://github.com/WICG/nav-speculation/blob/main/speculation-rules-tags.md
    /// </summary>
    public string? Tag { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<RuleSetErrorType>))]
public enum RuleSetErrorType
{
    /// <summary>
    /// Corresponds to the <c>"SourceIsNotJsonObject"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SourceIsNotJsonObject")]
    SourceIsNotJsonObject,
    /// <summary>
    /// Corresponds to the <c>"InvalidRulesSkipped"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidRulesSkipped")]
    InvalidRulesSkipped,
    /// <summary>
    /// Corresponds to the <c>"InvalidRulesetLevelTag"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidRulesetLevelTag")]
    InvalidRulesetLevelTag,
}

/// <summary>
/// The type of preloading attempted. It corresponds to
/// mojom::SpeculationAction (although PrefetchWithSubresources is omitted as it
/// isn't being used by clients).
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<SpeculationAction>))]
public enum SpeculationAction
{
    /// <summary>
    /// Corresponds to the <c>"Prefetch"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Prefetch")]
    Prefetch,
    /// <summary>
    /// Corresponds to the <c>"Prerender"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Prerender")]
    Prerender,
    /// <summary>
    /// Corresponds to the <c>"PrerenderUntilScript"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrerenderUntilScript")]
    PrerenderUntilScript,
}

/// <summary>
/// Corresponds to mojom::SpeculationTargetHint.
/// See https://github.com/WICG/nav-speculation/blob/main/triggers.md#window-name-targeting-hints
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<SpeculationTargetHint>))]
public enum SpeculationTargetHint
{
    /// <summary>
    /// Corresponds to the <c>"Blank"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Blank")]
    Blank,
    /// <summary>
    /// Corresponds to the <c>"Self"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Self")]
    Self,
}

/// <summary>
/// A key that identifies a preloading attempt.
/// 
/// The url used is the url specified by the trigger (i.e. the initial URL), and
/// not the final url that is navigated to. For example, prerendering allows
/// same-origin main frame navigations during the attempt, but the attempt is
/// still keyed with the initial URL.
/// </summary>
/// <param name="LoaderId">
/// </param>
/// <param name="Action">
/// </param>
/// <param name="Url">
/// </param>
public sealed record PreloadingAttemptKey(Network.LoaderId LoaderId, SpeculationAction Action, string Url)
{
    /// <summary>
    /// </summary>
    public bool? FormSubmission { get; init; }

    /// <summary>
    /// </summary>
    public SpeculationTargetHint? TargetHint { get; init; }
}

/// <summary>
/// Lists sources for a preloading attempt, specifically the ids of rule sets
/// that had a speculation rule that triggered the attempt, and the
/// BackendNodeIds of &lt;a href&gt; or &lt;area href&gt; elements that triggered the
/// attempt (in the case of attempts triggered by a document rule). It is
/// possible for multiple rule sets and links to trigger a single attempt.
/// </summary>
/// <param name="Key">
/// </param>
/// <param name="RuleSetIds">
/// </param>
/// <param name="NodeIds">
/// </param>
public sealed record PreloadingAttemptSource(PreloadingAttemptKey Key, ImmutableArray<RuleSetId> RuleSetIds, ImmutableArray<DOM.BackendNodeId> NodeIds)
{
}

/// <summary>
/// Chrome manages different types of preloads together using a
/// concept of preloading pipeline. For example, if a site uses a
/// SpeculationRules for prerender, Chrome first starts a prefetch and
/// then upgrades it to prerender.
/// 
/// CDP events for them are emitted separately but they share
/// <b>PreloadPipelineId</b>.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<PreloadPipelineId>))]
public record PreloadPipelineId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// List of FinalStatus reasons for Prerender2.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<PrerenderFinalStatus>))]
public enum PrerenderFinalStatus
{
    /// <summary>
    /// Corresponds to the <c>"Activated"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Activated")]
    Activated,
    /// <summary>
    /// Corresponds to the <c>"Destroyed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Destroyed")]
    Destroyed,
    /// <summary>
    /// Corresponds to the <c>"LowEndDevice"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("LowEndDevice")]
    LowEndDevice,
    /// <summary>
    /// Corresponds to the <c>"InvalidSchemeRedirect"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidSchemeRedirect")]
    InvalidSchemeRedirect,
    /// <summary>
    /// Corresponds to the <c>"InvalidSchemeNavigation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidSchemeNavigation")]
    InvalidSchemeNavigation,
    /// <summary>
    /// Corresponds to the <c>"NavigationRequestBlockedByCsp"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NavigationRequestBlockedByCsp")]
    NavigationRequestBlockedByCsp,
    /// <summary>
    /// Corresponds to the <c>"MojoBinderPolicy"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MojoBinderPolicy")]
    MojoBinderPolicy,
    /// <summary>
    /// Corresponds to the <c>"RendererProcessCrashed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RendererProcessCrashed")]
    RendererProcessCrashed,
    /// <summary>
    /// Corresponds to the <c>"RendererProcessKilled"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RendererProcessKilled")]
    RendererProcessKilled,
    /// <summary>
    /// Corresponds to the <c>"Download"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Download")]
    Download,
    /// <summary>
    /// Corresponds to the <c>"TriggerDestroyed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TriggerDestroyed")]
    TriggerDestroyed,
    /// <summary>
    /// Corresponds to the <c>"NavigationNotCommitted"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NavigationNotCommitted")]
    NavigationNotCommitted,
    /// <summary>
    /// Corresponds to the <c>"NavigationBadHttpStatus"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NavigationBadHttpStatus")]
    NavigationBadHttpStatus,
    /// <summary>
    /// Corresponds to the <c>"ClientCertRequested"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ClientCertRequested")]
    ClientCertRequested,
    /// <summary>
    /// Corresponds to the <c>"NavigationRequestNetworkError"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NavigationRequestNetworkError")]
    NavigationRequestNetworkError,
    /// <summary>
    /// Corresponds to the <c>"CancelAllHostsForTesting"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CancelAllHostsForTesting")]
    CancelAllHostsForTesting,
    /// <summary>
    /// Corresponds to the <c>"DidFailLoad"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DidFailLoad")]
    DidFailLoad,
    /// <summary>
    /// Corresponds to the <c>"Stop"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Stop")]
    Stop,
    /// <summary>
    /// Corresponds to the <c>"SslCertificateError"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SslCertificateError")]
    SslCertificateError,
    /// <summary>
    /// Corresponds to the <c>"LoginAuthRequested"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("LoginAuthRequested")]
    LoginAuthRequested,
    /// <summary>
    /// Corresponds to the <c>"UaChangeRequiresReload"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UaChangeRequiresReload")]
    UaChangeRequiresReload,
    /// <summary>
    /// Corresponds to the <c>"BlockedByClient"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BlockedByClient")]
    BlockedByClient,
    /// <summary>
    /// Corresponds to the <c>"AudioOutputDeviceRequested"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AudioOutputDeviceRequested")]
    AudioOutputDeviceRequested,
    /// <summary>
    /// Corresponds to the <c>"MixedContent"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MixedContent")]
    MixedContent,
    /// <summary>
    /// Corresponds to the <c>"TriggerBackgrounded"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TriggerBackgrounded")]
    TriggerBackgrounded,
    /// <summary>
    /// Corresponds to the <c>"MemoryLimitExceeded"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MemoryLimitExceeded")]
    MemoryLimitExceeded,
    /// <summary>
    /// Corresponds to the <c>"DataSaverEnabled"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DataSaverEnabled")]
    DataSaverEnabled,
    /// <summary>
    /// Corresponds to the <c>"TriggerUrlHasEffectiveUrl"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TriggerUrlHasEffectiveUrl")]
    TriggerUrlHasEffectiveUrl,
    /// <summary>
    /// Corresponds to the <c>"ActivatedBeforeStarted"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ActivatedBeforeStarted")]
    ActivatedBeforeStarted,
    /// <summary>
    /// Corresponds to the <c>"InactivePageRestriction"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InactivePageRestriction")]
    InactivePageRestriction,
    /// <summary>
    /// Corresponds to the <c>"StartFailed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("StartFailed")]
    StartFailed,
    /// <summary>
    /// Corresponds to the <c>"TimeoutBackgrounded"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TimeoutBackgrounded")]
    TimeoutBackgrounded,
    /// <summary>
    /// Corresponds to the <c>"CrossSiteRedirectInInitialNavigation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CrossSiteRedirectInInitialNavigation")]
    CrossSiteRedirectInInitialNavigation,
    /// <summary>
    /// Corresponds to the <c>"CrossSiteNavigationInInitialNavigation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CrossSiteNavigationInInitialNavigation")]
    CrossSiteNavigationInInitialNavigation,
    /// <summary>
    /// Corresponds to the <c>"SameSiteCrossOriginRedirectNotOptInInInitialNavigation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SameSiteCrossOriginRedirectNotOptInInInitialNavigation")]
    SameSiteCrossOriginRedirectNotOptInInInitialNavigation,
    /// <summary>
    /// Corresponds to the <c>"SameSiteCrossOriginNavigationNotOptInInInitialNavigation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SameSiteCrossOriginNavigationNotOptInInInitialNavigation")]
    SameSiteCrossOriginNavigationNotOptInInInitialNavigation,
    /// <summary>
    /// Corresponds to the <c>"ActivationNavigationParameterMismatch"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ActivationNavigationParameterMismatch")]
    ActivationNavigationParameterMismatch,
    /// <summary>
    /// Corresponds to the <c>"ActivatedInBackground"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ActivatedInBackground")]
    ActivatedInBackground,
    /// <summary>
    /// Corresponds to the <c>"EmbedderHostDisallowed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderHostDisallowed")]
    EmbedderHostDisallowed,
    /// <summary>
    /// Corresponds to the <c>"ActivationNavigationDestroyedBeforeSuccess"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ActivationNavigationDestroyedBeforeSuccess")]
    ActivationNavigationDestroyedBeforeSuccess,
    /// <summary>
    /// Corresponds to the <c>"TabClosedByUserGesture"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TabClosedByUserGesture")]
    TabClosedByUserGesture,
    /// <summary>
    /// Corresponds to the <c>"TabClosedWithoutUserGesture"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TabClosedWithoutUserGesture")]
    TabClosedWithoutUserGesture,
    /// <summary>
    /// Corresponds to the <c>"PrimaryMainFrameRendererProcessCrashed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrimaryMainFrameRendererProcessCrashed")]
    PrimaryMainFrameRendererProcessCrashed,
    /// <summary>
    /// Corresponds to the <c>"PrimaryMainFrameRendererProcessKilled"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrimaryMainFrameRendererProcessKilled")]
    PrimaryMainFrameRendererProcessKilled,
    /// <summary>
    /// Corresponds to the <c>"ActivationFramePolicyNotCompatible"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ActivationFramePolicyNotCompatible")]
    ActivationFramePolicyNotCompatible,
    /// <summary>
    /// Corresponds to the <c>"PreloadingDisabled"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PreloadingDisabled")]
    PreloadingDisabled,
    /// <summary>
    /// Corresponds to the <c>"BatterySaverEnabled"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BatterySaverEnabled")]
    BatterySaverEnabled,
    /// <summary>
    /// Corresponds to the <c>"ActivatedDuringMainFrameNavigation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ActivatedDuringMainFrameNavigation")]
    ActivatedDuringMainFrameNavigation,
    /// <summary>
    /// Corresponds to the <c>"PreloadingUnsupportedByWebContents"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PreloadingUnsupportedByWebContents")]
    PreloadingUnsupportedByWebContents,
    /// <summary>
    /// Corresponds to the <c>"CrossSiteRedirectInMainFrameNavigation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CrossSiteRedirectInMainFrameNavigation")]
    CrossSiteRedirectInMainFrameNavigation,
    /// <summary>
    /// Corresponds to the <c>"CrossSiteNavigationInMainFrameNavigation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CrossSiteNavigationInMainFrameNavigation")]
    CrossSiteNavigationInMainFrameNavigation,
    /// <summary>
    /// Corresponds to the <c>"SameSiteCrossOriginRedirectNotOptInInMainFrameNavigation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SameSiteCrossOriginRedirectNotOptInInMainFrameNavigation")]
    SameSiteCrossOriginRedirectNotOptInInMainFrameNavigation,
    /// <summary>
    /// Corresponds to the <c>"SameSiteCrossOriginNavigationNotOptInInMainFrameNavigation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SameSiteCrossOriginNavigationNotOptInInMainFrameNavigation")]
    SameSiteCrossOriginNavigationNotOptInInMainFrameNavigation,
    /// <summary>
    /// Corresponds to the <c>"MemoryPressureOnTrigger"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MemoryPressureOnTrigger")]
    MemoryPressureOnTrigger,
    /// <summary>
    /// Corresponds to the <c>"MemoryPressureAfterTriggered"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MemoryPressureAfterTriggered")]
    MemoryPressureAfterTriggered,
    /// <summary>
    /// Corresponds to the <c>"PrerenderingDisabledByDevTools"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrerenderingDisabledByDevTools")]
    PrerenderingDisabledByDevTools,
    /// <summary>
    /// Corresponds to the <c>"SpeculationRuleRemoved"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SpeculationRuleRemoved")]
    SpeculationRuleRemoved,
    /// <summary>
    /// Corresponds to the <c>"ActivatedWithAuxiliaryBrowsingContexts"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ActivatedWithAuxiliaryBrowsingContexts")]
    ActivatedWithAuxiliaryBrowsingContexts,
    /// <summary>
    /// Corresponds to the <c>"MaxNumOfRunningEagerPrerendersExceeded"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MaxNumOfRunningEagerPrerendersExceeded")]
    MaxNumOfRunningEagerPrerendersExceeded,
    /// <summary>
    /// Corresponds to the <c>"MaxNumOfRunningNonEagerPrerendersExceeded"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MaxNumOfRunningNonEagerPrerendersExceeded")]
    MaxNumOfRunningNonEagerPrerendersExceeded,
    /// <summary>
    /// Corresponds to the <c>"MaxNumOfRunningEmbedderPrerendersExceeded"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MaxNumOfRunningEmbedderPrerendersExceeded")]
    MaxNumOfRunningEmbedderPrerendersExceeded,
    /// <summary>
    /// Corresponds to the <c>"PrerenderingUrlHasEffectiveUrl"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrerenderingUrlHasEffectiveUrl")]
    PrerenderingUrlHasEffectiveUrl,
    /// <summary>
    /// Corresponds to the <c>"RedirectedPrerenderingUrlHasEffectiveUrl"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RedirectedPrerenderingUrlHasEffectiveUrl")]
    RedirectedPrerenderingUrlHasEffectiveUrl,
    /// <summary>
    /// Corresponds to the <c>"ActivationUrlHasEffectiveUrl"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ActivationUrlHasEffectiveUrl")]
    ActivationUrlHasEffectiveUrl,
    /// <summary>
    /// Corresponds to the <c>"JavaScriptInterfaceAdded"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("JavaScriptInterfaceAdded")]
    JavaScriptInterfaceAdded,
    /// <summary>
    /// Corresponds to the <c>"JavaScriptInterfaceRemoved"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("JavaScriptInterfaceRemoved")]
    JavaScriptInterfaceRemoved,
    /// <summary>
    /// Corresponds to the <c>"AllPrerenderingCanceled"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AllPrerenderingCanceled")]
    AllPrerenderingCanceled,
    /// <summary>
    /// Corresponds to the <c>"WindowClosed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WindowClosed")]
    WindowClosed,
    /// <summary>
    /// Corresponds to the <c>"SlowNetwork"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SlowNetwork")]
    SlowNetwork,
    /// <summary>
    /// Corresponds to the <c>"OtherPrerenderedPageActivated"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("OtherPrerenderedPageActivated")]
    OtherPrerenderedPageActivated,
    /// <summary>
    /// Corresponds to the <c>"V8OptimizerDisabled"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("V8OptimizerDisabled")]
    V8OptimizerDisabled,
    /// <summary>
    /// Corresponds to the <c>"PrerenderFailedDuringPrefetch"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrerenderFailedDuringPrefetch")]
    PrerenderFailedDuringPrefetch,
    /// <summary>
    /// Corresponds to the <c>"BrowsingDataRemoved"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BrowsingDataRemoved")]
    BrowsingDataRemoved,
    /// <summary>
    /// Corresponds to the <c>"PrerenderHostReused"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrerenderHostReused")]
    PrerenderHostReused,
    /// <summary>
    /// Corresponds to the <c>"FormSubmitWhenPrerendering"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FormSubmitWhenPrerendering")]
    FormSubmitWhenPrerendering,
    /// <summary>
    /// Corresponds to the <c>"CrossDocumentRestart"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CrossDocumentRestart")]
    CrossDocumentRestart,
}

/// <summary>
/// Preloading status values, see also PreloadingTriggeringOutcome. This
/// status is shared by prefetchStatusUpdated and prerenderStatusUpdated.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<PreloadingStatus>))]
public enum PreloadingStatus
{
    /// <summary>
    /// Corresponds to the <c>"Pending"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Pending")]
    Pending,
    /// <summary>
    /// Corresponds to the <c>"Running"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Running")]
    Running,
    /// <summary>
    /// Corresponds to the <c>"Ready"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Ready")]
    Ready,
    /// <summary>
    /// Corresponds to the <c>"Success"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Success")]
    Success,
    /// <summary>
    /// Corresponds to the <c>"Failure"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Failure")]
    Failure,
    /// <summary>
    /// Corresponds to the <c>"NotSupported"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NotSupported")]
    NotSupported,
}

/// <summary>
/// TODO(https://crbug.com/1384419): revisit the list of PrefetchStatus and
/// filter out the ones that aren't necessary to the developers.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<PrefetchStatus>))]
public enum PrefetchStatus
{
    /// <summary>
    /// Corresponds to the <c>"PrefetchAllowed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchAllowed")]
    PrefetchAllowed,
    /// <summary>
    /// Corresponds to the <c>"PrefetchFailedIneligibleRedirect"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchFailedIneligibleRedirect")]
    PrefetchFailedIneligibleRedirect,
    /// <summary>
    /// Corresponds to the <c>"PrefetchFailedInvalidRedirect"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchFailedInvalidRedirect")]
    PrefetchFailedInvalidRedirect,
    /// <summary>
    /// Corresponds to the <c>"PrefetchFailedMIMENotSupported"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchFailedMIMENotSupported")]
    PrefetchFailedMIMENotSupported,
    /// <summary>
    /// Corresponds to the <c>"PrefetchFailedNetError"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchFailedNetError")]
    PrefetchFailedNetError,
    /// <summary>
    /// Corresponds to the <c>"PrefetchFailedNon2XX"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchFailedNon2XX")]
    PrefetchFailedNon2XX,
    /// <summary>
    /// Corresponds to the <c>"PrefetchEvictedAfterBrowsingDataRemoved"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchEvictedAfterBrowsingDataRemoved")]
    PrefetchEvictedAfterBrowsingDataRemoved,
    /// <summary>
    /// Corresponds to the <c>"PrefetchEvictedAfterCandidateRemoved"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchEvictedAfterCandidateRemoved")]
    PrefetchEvictedAfterCandidateRemoved,
    /// <summary>
    /// Corresponds to the <c>"PrefetchEvictedForNewerPrefetch"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchEvictedForNewerPrefetch")]
    PrefetchEvictedForNewerPrefetch,
    /// <summary>
    /// Corresponds to the <c>"PrefetchHeldback"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchHeldback")]
    PrefetchHeldback,
    /// <summary>
    /// Corresponds to the <c>"PrefetchIneligibleRetryAfter"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchIneligibleRetryAfter")]
    PrefetchIneligibleRetryAfter,
    /// <summary>
    /// Corresponds to the <c>"PrefetchIsPrivacyDecoy"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchIsPrivacyDecoy")]
    PrefetchIsPrivacyDecoy,
    /// <summary>
    /// Corresponds to the <c>"PrefetchIsStale"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchIsStale")]
    PrefetchIsStale,
    /// <summary>
    /// Corresponds to the <c>"PrefetchNotEligibleBlockedByConnectionAllowlist"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleBlockedByConnectionAllowlist")]
    PrefetchNotEligibleBlockedByConnectionAllowlist,
    /// <summary>
    /// Corresponds to the <c>"PrefetchNotEligibleBrowserContextOffTheRecord"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleBrowserContextOffTheRecord")]
    PrefetchNotEligibleBrowserContextOffTheRecord,
    /// <summary>
    /// Corresponds to the <c>"PrefetchNotEligibleCrossOrigin"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleCrossOrigin")]
    PrefetchNotEligibleCrossOrigin,
    /// <summary>
    /// Corresponds to the <c>"PrefetchNotEligibleDataSaverEnabled"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleDataSaverEnabled")]
    PrefetchNotEligibleDataSaverEnabled,
    /// <summary>
    /// Corresponds to the <c>"PrefetchNotEligibleExistingProxy"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleExistingProxy")]
    PrefetchNotEligibleExistingProxy,
    /// <summary>
    /// Corresponds to the <c>"PrefetchNotEligibleHostIsNonUnique"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleHostIsNonUnique")]
    PrefetchNotEligibleHostIsNonUnique,
    /// <summary>
    /// Corresponds to the <c>"PrefetchNotEligibleNonDefaultStoragePartition"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleNonDefaultStoragePartition")]
    PrefetchNotEligibleNonDefaultStoragePartition,
    /// <summary>
    /// Corresponds to the <c>"PrefetchNotEligibleSameSiteCrossOriginPrefetchRequiredProxy"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleSameSiteCrossOriginPrefetchRequiredProxy")]
    PrefetchNotEligibleSameSiteCrossOriginPrefetchRequiredProxy,
    /// <summary>
    /// Corresponds to the <c>"PrefetchNotEligibleSchemeIsNotHttps"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleSchemeIsNotHttps")]
    PrefetchNotEligibleSchemeIsNotHttps,
    /// <summary>
    /// Corresponds to the <c>"PrefetchNotEligibleUserHasCookies"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleUserHasCookies")]
    PrefetchNotEligibleUserHasCookies,
    /// <summary>
    /// Corresponds to the <c>"PrefetchNotEligibleUserHasServiceWorker"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleUserHasServiceWorker")]
    PrefetchNotEligibleUserHasServiceWorker,
    /// <summary>
    /// Corresponds to the <c>"PrefetchNotEligibleUserHasServiceWorkerNoFetchHandler"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleUserHasServiceWorkerNoFetchHandler")]
    PrefetchNotEligibleUserHasServiceWorkerNoFetchHandler,
    /// <summary>
    /// Corresponds to the <c>"PrefetchNotEligibleRedirectFromServiceWorker"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleRedirectFromServiceWorker")]
    PrefetchNotEligibleRedirectFromServiceWorker,
    /// <summary>
    /// Corresponds to the <c>"PrefetchNotEligibleRedirectToServiceWorker"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleRedirectToServiceWorker")]
    PrefetchNotEligibleRedirectToServiceWorker,
    /// <summary>
    /// Corresponds to the <c>"PrefetchNotEligibleBatterySaverEnabled"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleBatterySaverEnabled")]
    PrefetchNotEligibleBatterySaverEnabled,
    /// <summary>
    /// Corresponds to the <c>"PrefetchNotEligiblePreloadingDisabled"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligiblePreloadingDisabled")]
    PrefetchNotEligiblePreloadingDisabled,
    /// <summary>
    /// Corresponds to the <c>"PrefetchNotFinishedInTime"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotFinishedInTime")]
    PrefetchNotFinishedInTime,
    /// <summary>
    /// Corresponds to the <c>"PrefetchNotStarted"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotStarted")]
    PrefetchNotStarted,
    /// <summary>
    /// Corresponds to the <c>"PrefetchNotUsedCookiesChanged"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotUsedCookiesChanged")]
    PrefetchNotUsedCookiesChanged,
    /// <summary>
    /// Corresponds to the <c>"PrefetchProxyNotAvailable"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchProxyNotAvailable")]
    PrefetchProxyNotAvailable,
    /// <summary>
    /// Corresponds to the <c>"PrefetchResponseUsed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchResponseUsed")]
    PrefetchResponseUsed,
    /// <summary>
    /// Corresponds to the <c>"PrefetchSuccessfulButNotUsed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchSuccessfulButNotUsed")]
    PrefetchSuccessfulButNotUsed,
    /// <summary>
    /// Corresponds to the <c>"PrefetchNotUsedProbeFailed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotUsedProbeFailed")]
    PrefetchNotUsedProbeFailed,
    /// <summary>
    /// Corresponds to the <c>"PrefetchCancelledOnUserNavigation"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchCancelledOnUserNavigation")]
    PrefetchCancelledOnUserNavigation,
}

/// <summary>
/// Information of headers to be displayed when the header mismatch occurred.
/// </summary>
/// <param name="HeaderName">
/// </param>
public sealed record PrerenderMismatchedHeaders(string HeaderName)
{
    /// <summary>
    /// </summary>
    public string? InitialValue { get; init; }

    /// <summary>
    /// </summary>
    public string? ActivationValue { get; init; }
}

[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(CdpEventArgs<RuleSetUpdatedEventArgs>), TypeInfoPropertyName = "RuleSetUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<RuleSetRemovedEventArgs>), TypeInfoPropertyName = "RuleSetRemovedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<PreloadEnabledStateUpdatedEventArgs>), TypeInfoPropertyName = "PreloadEnabledStateUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<PrefetchStatusUpdatedEventArgs>), TypeInfoPropertyName = "PrefetchStatusUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<PrerenderStatusUpdatedEventArgs>), TypeInfoPropertyName = "PrerenderStatusUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<PreloadingAttemptSourcesUpdatedEventArgs>), TypeInfoPropertyName = "PreloadingAttemptSourcesUpdatedCdpEventArgs")]
[JsonSerializable(typeof(RuleSetId), TypeInfoPropertyName = "PreloadRuleSetId")]
[JsonSerializable(typeof(RuleSet), TypeInfoPropertyName = "PreloadRuleSet")]
[JsonSerializable(typeof(RuleSetErrorType), TypeInfoPropertyName = "PreloadRuleSetErrorType")]
[JsonSerializable(typeof(SpeculationAction), TypeInfoPropertyName = "PreloadSpeculationAction")]
[JsonSerializable(typeof(SpeculationTargetHint), TypeInfoPropertyName = "PreloadSpeculationTargetHint")]
[JsonSerializable(typeof(PreloadingAttemptKey), TypeInfoPropertyName = "PreloadPreloadingAttemptKey")]
[JsonSerializable(typeof(PreloadingAttemptSource), TypeInfoPropertyName = "PreloadPreloadingAttemptSource")]
[JsonSerializable(typeof(PreloadPipelineId), TypeInfoPropertyName = "PreloadPreloadPipelineId")]
[JsonSerializable(typeof(PrerenderFinalStatus), TypeInfoPropertyName = "PreloadPrerenderFinalStatus")]
[JsonSerializable(typeof(PreloadingStatus), TypeInfoPropertyName = "PreloadPreloadingStatus")]
[JsonSerializable(typeof(PrefetchStatus), TypeInfoPropertyName = "PreloadPrefetchStatus")]
[JsonSerializable(typeof(PrerenderMismatchedHeaders), TypeInfoPropertyName = "PreloadPrerenderMismatchedHeaders")]
[JsonSerializable(typeof(ImmutableArray<PrerenderMismatchedHeaders>), TypeInfoPropertyName = "ImmutableArrayPreloadPrerenderMismatchedHeaders")]
[JsonSerializable(typeof(ImmutableArray<PreloadingAttemptSource>), TypeInfoPropertyName = "ImmutableArrayPreloadPreloadingAttemptSource")]
[JsonSerializable(typeof(ImmutableArray<RuleSetId>), TypeInfoPropertyName = "ImmutableArrayPreloadRuleSetId")]
[JsonSerializable(typeof(ImmutableArray<DOM.BackendNodeId>), TypeInfoPropertyName = "ImmutableArrayDOMBackendNodeId")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class PreloadJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="IPreload"/>.
/// </summary>
public static class PreloadDomainEvent
{
    /// <summary>
    /// Upsert. Currently, it is only emitted when a rule set added.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<RuleSetUpdatedEventArgs>> RuleSetUpdated =>
        _ruleSetUpdated ?? global::System.Threading.Interlocked.CompareExchange(ref _ruleSetUpdated, EventDescriptor<CdpEventArgs<RuleSetUpdatedEventArgs>>.Create(
            "goog:cdp.Preload.ruleSetUpdated",
            PreloadJsonSerializerContext.Default.RuleSetUpdatedCdpEventArgs), null) ?? _ruleSetUpdated;
    private static EventDescriptor<CdpEventArgs<RuleSetUpdatedEventArgs>>? _ruleSetUpdated;

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<RuleSetRemovedEventArgs>> RuleSetRemoved =>
        _ruleSetRemoved ?? global::System.Threading.Interlocked.CompareExchange(ref _ruleSetRemoved, EventDescriptor<CdpEventArgs<RuleSetRemovedEventArgs>>.Create(
            "goog:cdp.Preload.ruleSetRemoved",
            PreloadJsonSerializerContext.Default.RuleSetRemovedCdpEventArgs), null) ?? _ruleSetRemoved;
    private static EventDescriptor<CdpEventArgs<RuleSetRemovedEventArgs>>? _ruleSetRemoved;

    /// <summary>
    /// Fired when a preload enabled state is updated.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<PreloadEnabledStateUpdatedEventArgs>> PreloadEnabledStateUpdated =>
        _preloadEnabledStateUpdated ?? global::System.Threading.Interlocked.CompareExchange(ref _preloadEnabledStateUpdated, EventDescriptor<CdpEventArgs<PreloadEnabledStateUpdatedEventArgs>>.Create(
            "goog:cdp.Preload.preloadEnabledStateUpdated",
            PreloadJsonSerializerContext.Default.PreloadEnabledStateUpdatedCdpEventArgs), null) ?? _preloadEnabledStateUpdated;
    private static EventDescriptor<CdpEventArgs<PreloadEnabledStateUpdatedEventArgs>>? _preloadEnabledStateUpdated;

    /// <summary>
    /// Fired when a prefetch attempt is updated.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<PrefetchStatusUpdatedEventArgs>> PrefetchStatusUpdated =>
        _prefetchStatusUpdated ?? global::System.Threading.Interlocked.CompareExchange(ref _prefetchStatusUpdated, EventDescriptor<CdpEventArgs<PrefetchStatusUpdatedEventArgs>>.Create(
            "goog:cdp.Preload.prefetchStatusUpdated",
            PreloadJsonSerializerContext.Default.PrefetchStatusUpdatedCdpEventArgs), null) ?? _prefetchStatusUpdated;
    private static EventDescriptor<CdpEventArgs<PrefetchStatusUpdatedEventArgs>>? _prefetchStatusUpdated;

    /// <summary>
    /// Fired when a prerender attempt is updated.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<PrerenderStatusUpdatedEventArgs>> PrerenderStatusUpdated =>
        _prerenderStatusUpdated ?? global::System.Threading.Interlocked.CompareExchange(ref _prerenderStatusUpdated, EventDescriptor<CdpEventArgs<PrerenderStatusUpdatedEventArgs>>.Create(
            "goog:cdp.Preload.prerenderStatusUpdated",
            PreloadJsonSerializerContext.Default.PrerenderStatusUpdatedCdpEventArgs), null) ?? _prerenderStatusUpdated;
    private static EventDescriptor<CdpEventArgs<PrerenderStatusUpdatedEventArgs>>? _prerenderStatusUpdated;

    /// <summary>
    /// Send a list of sources for all preloading attempts in a document.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<PreloadingAttemptSourcesUpdatedEventArgs>> PreloadingAttemptSourcesUpdated =>
        _preloadingAttemptSourcesUpdated ?? global::System.Threading.Interlocked.CompareExchange(ref _preloadingAttemptSourcesUpdated, EventDescriptor<CdpEventArgs<PreloadingAttemptSourcesUpdatedEventArgs>>.Create(
            "goog:cdp.Preload.preloadingAttemptSourcesUpdated",
            PreloadJsonSerializerContext.Default.PreloadingAttemptSourcesUpdatedCdpEventArgs), null) ?? _preloadingAttemptSourcesUpdated;
    private static EventDescriptor<CdpEventArgs<PreloadingAttemptSourcesUpdatedEventArgs>>? _preloadingAttemptSourcesUpdated;

}
