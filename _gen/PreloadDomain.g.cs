#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Preload;

/// <summary>
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class PreloadDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static PreloadJsonSerializerContext JsonContext = PreloadJsonSerializerContext.Default;

    /// <summary>
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
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("Preload.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
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
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("Preload.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Upsert. Currently, it is only emitted when a rule set added.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="RuleSetUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RuleSet</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<RuleSetUpdatedEventArgs> RuleSetUpdated => CreateCdpEventSource(PreloadDomainEvent.RuleSetUpdated);
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="RuleSetRemovedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Id</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<RuleSetRemovedEventArgs> RuleSetRemoved => CreateCdpEventSource(PreloadDomainEvent.RuleSetRemoved);
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
    public IEventSource<PreloadEnabledStateUpdatedEventArgs> PreloadEnabledStateUpdated => CreateCdpEventSource(PreloadDomainEvent.PreloadEnabledStateUpdated);
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
    public IEventSource<PrefetchStatusUpdatedEventArgs> PrefetchStatusUpdated => CreateCdpEventSource(PreloadDomainEvent.PrefetchStatusUpdated);
    /// <summary>
    /// Fired when a prerender attempt is updated.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="PrerenderStatusUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Key</b></description></item>
    /// <item><description><b>PipelineId</b></description></item>
    /// <item><description><b>Status</b></description></item>
    /// <item><description><b>PrerenderStatus</b></description></item>
    /// <item><description><b>DisallowedMojoInterface</b> - This is used to give users more information about the name of Mojo interface that is incompatible with prerender and has caused the cancellation of the attempt.</description></item>
    /// <item><description><b>MismatchedHeaders</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<PrerenderStatusUpdatedEventArgs> PrerenderStatusUpdated => CreateCdpEventSource(PreloadDomainEvent.PrerenderStatusUpdated);
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
    public IEventSource<PreloadingAttemptSourcesUpdatedEventArgs> PreloadingAttemptSourcesUpdated => CreateCdpEventSource(PreloadDomainEvent.PreloadingAttemptSourcesUpdated);
}

internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="PreloadDomain.EnableAsync"/>.
/// </summary>
public sealed record EnableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="PreloadDomain.DisableAsync"/>.
/// </summary>
public sealed record DisableCommandOptions : CdpCommandOptions
{
}

/// <summary>
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
/// <param name="PrerenderStatus">
/// </param>
/// <param name="DisallowedMojoInterface">
/// This is used to give users more information about the name of Mojo interface
/// that is incompatible with prerender and has caused the cancellation of the attempt.
/// </param>
/// <param name="MismatchedHeaders">
/// </param>
public sealed record PrerenderStatusUpdatedEventArgs(PreloadingAttemptKey Key, PreloadPipelineId PipelineId, PreloadingStatus Status, PrerenderFinalStatus? PrerenderStatus = null, string? DisallowedMojoInterface = null, IEnumerable<PrerenderMismatchedHeaders>? MismatchedHeaders = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Send a list of sources for all preloading attempts in a document.
/// </summary>
/// <param name="LoaderId">
/// </param>
/// <param name="PreloadingAttemptSources">
/// </param>
public sealed record PreloadingAttemptSourcesUpdatedEventArgs(Network.LoaderId LoaderId, IEnumerable<PreloadingAttemptSource> PreloadingAttemptSources) : OpenQA.Selenium.BiDi.EventArgs;

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
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<RuleSetErrorType>))]
public enum RuleSetErrorType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SourceIsNotJsonObject")]
    SourceIsNotJsonObject,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidRulesSkipped")]
    InvalidRulesSkipped,
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
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Prefetch")]
    Prefetch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Prerender")]
    Prerender,
}

/// <summary>
/// Corresponds to mojom::SpeculationTargetHint.
/// See https://github.com/WICG/nav-speculation/blob/main/triggers.md#window-name-targeting-hints
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<SpeculationTargetHint>))]
public enum SpeculationTargetHint
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Blank")]
    Blank,
    /// <summary>
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
public sealed record PreloadingAttemptSource(PreloadingAttemptKey Key, IReadOnlyList<RuleSetId> RuleSetIds, IReadOnlyList<DOM.BackendNodeId> NodeIds)
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
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Activated")]
    Activated,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Destroyed")]
    Destroyed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("LowEndDevice")]
    LowEndDevice,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidSchemeRedirect")]
    InvalidSchemeRedirect,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidSchemeNavigation")]
    InvalidSchemeNavigation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NavigationRequestBlockedByCsp")]
    NavigationRequestBlockedByCsp,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MojoBinderPolicy")]
    MojoBinderPolicy,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RendererProcessCrashed")]
    RendererProcessCrashed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RendererProcessKilled")]
    RendererProcessKilled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Download")]
    Download,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TriggerDestroyed")]
    TriggerDestroyed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NavigationNotCommitted")]
    NavigationNotCommitted,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NavigationBadHttpStatus")]
    NavigationBadHttpStatus,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ClientCertRequested")]
    ClientCertRequested,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NavigationRequestNetworkError")]
    NavigationRequestNetworkError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CancelAllHostsForTesting")]
    CancelAllHostsForTesting,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DidFailLoad")]
    DidFailLoad,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Stop")]
    Stop,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SslCertificateError")]
    SslCertificateError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("LoginAuthRequested")]
    LoginAuthRequested,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UaChangeRequiresReload")]
    UaChangeRequiresReload,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BlockedByClient")]
    BlockedByClient,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AudioOutputDeviceRequested")]
    AudioOutputDeviceRequested,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MixedContent")]
    MixedContent,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TriggerBackgrounded")]
    TriggerBackgrounded,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MemoryLimitExceeded")]
    MemoryLimitExceeded,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DataSaverEnabled")]
    DataSaverEnabled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TriggerUrlHasEffectiveUrl")]
    TriggerUrlHasEffectiveUrl,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ActivatedBeforeStarted")]
    ActivatedBeforeStarted,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InactivePageRestriction")]
    InactivePageRestriction,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("StartFailed")]
    StartFailed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TimeoutBackgrounded")]
    TimeoutBackgrounded,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CrossSiteRedirectInInitialNavigation")]
    CrossSiteRedirectInInitialNavigation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CrossSiteNavigationInInitialNavigation")]
    CrossSiteNavigationInInitialNavigation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SameSiteCrossOriginRedirectNotOptInInInitialNavigation")]
    SameSiteCrossOriginRedirectNotOptInInInitialNavigation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SameSiteCrossOriginNavigationNotOptInInInitialNavigation")]
    SameSiteCrossOriginNavigationNotOptInInInitialNavigation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ActivationNavigationParameterMismatch")]
    ActivationNavigationParameterMismatch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ActivatedInBackground")]
    ActivatedInBackground,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmbedderHostDisallowed")]
    EmbedderHostDisallowed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ActivationNavigationDestroyedBeforeSuccess")]
    ActivationNavigationDestroyedBeforeSuccess,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TabClosedByUserGesture")]
    TabClosedByUserGesture,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TabClosedWithoutUserGesture")]
    TabClosedWithoutUserGesture,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrimaryMainFrameRendererProcessCrashed")]
    PrimaryMainFrameRendererProcessCrashed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrimaryMainFrameRendererProcessKilled")]
    PrimaryMainFrameRendererProcessKilled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ActivationFramePolicyNotCompatible")]
    ActivationFramePolicyNotCompatible,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PreloadingDisabled")]
    PreloadingDisabled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BatterySaverEnabled")]
    BatterySaverEnabled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ActivatedDuringMainFrameNavigation")]
    ActivatedDuringMainFrameNavigation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PreloadingUnsupportedByWebContents")]
    PreloadingUnsupportedByWebContents,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CrossSiteRedirectInMainFrameNavigation")]
    CrossSiteRedirectInMainFrameNavigation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CrossSiteNavigationInMainFrameNavigation")]
    CrossSiteNavigationInMainFrameNavigation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SameSiteCrossOriginRedirectNotOptInInMainFrameNavigation")]
    SameSiteCrossOriginRedirectNotOptInInMainFrameNavigation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SameSiteCrossOriginNavigationNotOptInInMainFrameNavigation")]
    SameSiteCrossOriginNavigationNotOptInInMainFrameNavigation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MemoryPressureOnTrigger")]
    MemoryPressureOnTrigger,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MemoryPressureAfterTriggered")]
    MemoryPressureAfterTriggered,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrerenderingDisabledByDevTools")]
    PrerenderingDisabledByDevTools,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SpeculationRuleRemoved")]
    SpeculationRuleRemoved,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ActivatedWithAuxiliaryBrowsingContexts")]
    ActivatedWithAuxiliaryBrowsingContexts,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MaxNumOfRunningEagerPrerendersExceeded")]
    MaxNumOfRunningEagerPrerendersExceeded,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MaxNumOfRunningNonEagerPrerendersExceeded")]
    MaxNumOfRunningNonEagerPrerendersExceeded,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MaxNumOfRunningEmbedderPrerendersExceeded")]
    MaxNumOfRunningEmbedderPrerendersExceeded,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrerenderingUrlHasEffectiveUrl")]
    PrerenderingUrlHasEffectiveUrl,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RedirectedPrerenderingUrlHasEffectiveUrl")]
    RedirectedPrerenderingUrlHasEffectiveUrl,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ActivationUrlHasEffectiveUrl")]
    ActivationUrlHasEffectiveUrl,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("JavaScriptInterfaceAdded")]
    JavaScriptInterfaceAdded,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("JavaScriptInterfaceRemoved")]
    JavaScriptInterfaceRemoved,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AllPrerenderingCanceled")]
    AllPrerenderingCanceled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WindowClosed")]
    WindowClosed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SlowNetwork")]
    SlowNetwork,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("OtherPrerenderedPageActivated")]
    OtherPrerenderedPageActivated,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("V8OptimizerDisabled")]
    V8OptimizerDisabled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrerenderFailedDuringPrefetch")]
    PrerenderFailedDuringPrefetch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BrowsingDataRemoved")]
    BrowsingDataRemoved,
}

/// <summary>
/// Preloading status values, see also PreloadingTriggeringOutcome. This
/// status is shared by prefetchStatusUpdated and prerenderStatusUpdated.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<PreloadingStatus>))]
public enum PreloadingStatus
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Pending")]
    Pending,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Running")]
    Running,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Ready")]
    Ready,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Success")]
    Success,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Failure")]
    Failure,
    /// <summary>
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
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchAllowed")]
    PrefetchAllowed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchFailedIneligibleRedirect")]
    PrefetchFailedIneligibleRedirect,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchFailedInvalidRedirect")]
    PrefetchFailedInvalidRedirect,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchFailedMIMENotSupported")]
    PrefetchFailedMIMENotSupported,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchFailedNetError")]
    PrefetchFailedNetError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchFailedNon2XX")]
    PrefetchFailedNon2XX,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchEvictedAfterBrowsingDataRemoved")]
    PrefetchEvictedAfterBrowsingDataRemoved,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchEvictedAfterCandidateRemoved")]
    PrefetchEvictedAfterCandidateRemoved,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchEvictedForNewerPrefetch")]
    PrefetchEvictedForNewerPrefetch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchHeldback")]
    PrefetchHeldback,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchIneligibleRetryAfter")]
    PrefetchIneligibleRetryAfter,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchIsPrivacyDecoy")]
    PrefetchIsPrivacyDecoy,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchIsStale")]
    PrefetchIsStale,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleBrowserContextOffTheRecord")]
    PrefetchNotEligibleBrowserContextOffTheRecord,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleDataSaverEnabled")]
    PrefetchNotEligibleDataSaverEnabled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleExistingProxy")]
    PrefetchNotEligibleExistingProxy,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleHostIsNonUnique")]
    PrefetchNotEligibleHostIsNonUnique,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleNonDefaultStoragePartition")]
    PrefetchNotEligibleNonDefaultStoragePartition,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleSameSiteCrossOriginPrefetchRequiredProxy")]
    PrefetchNotEligibleSameSiteCrossOriginPrefetchRequiredProxy,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleSchemeIsNotHttps")]
    PrefetchNotEligibleSchemeIsNotHttps,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleUserHasCookies")]
    PrefetchNotEligibleUserHasCookies,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleUserHasServiceWorker")]
    PrefetchNotEligibleUserHasServiceWorker,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleUserHasServiceWorkerNoFetchHandler")]
    PrefetchNotEligibleUserHasServiceWorkerNoFetchHandler,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleRedirectFromServiceWorker")]
    PrefetchNotEligibleRedirectFromServiceWorker,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleRedirectToServiceWorker")]
    PrefetchNotEligibleRedirectToServiceWorker,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligibleBatterySaverEnabled")]
    PrefetchNotEligibleBatterySaverEnabled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotEligiblePreloadingDisabled")]
    PrefetchNotEligiblePreloadingDisabled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotFinishedInTime")]
    PrefetchNotFinishedInTime,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotStarted")]
    PrefetchNotStarted,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotUsedCookiesChanged")]
    PrefetchNotUsedCookiesChanged,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchProxyNotAvailable")]
    PrefetchProxyNotAvailable,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchResponseUsed")]
    PrefetchResponseUsed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchSuccessfulButNotUsed")]
    PrefetchSuccessfulButNotUsed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrefetchNotUsedProbeFailed")]
    PrefetchNotUsedProbeFailed,
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
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<PrerenderMismatchedHeaders>), TypeInfoPropertyName = "IReadOnlyListPreloadPrerenderMismatchedHeaders")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<PreloadingAttemptSource>), TypeInfoPropertyName = "IReadOnlyListPreloadPreloadingAttemptSource")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<RuleSetId>), TypeInfoPropertyName = "IReadOnlyListPreloadRuleSetId")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<DOM.BackendNodeId>), TypeInfoPropertyName = "IReadOnlyListDOMBackendNodeId")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class PreloadJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="PreloadDomain"/>.
/// </summary>
public static class PreloadDomainEvent
{
    /// <summary>
    /// Upsert. Currently, it is only emitted when a rule set added.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<RuleSetUpdatedEventArgs>> RuleSetUpdated { get; } =
        EventDescriptor<CdpEventArgs<RuleSetUpdatedEventArgs>>.Create(
            "goog:cdp.Preload.ruleSetUpdated",
            PreloadJsonSerializerContext.Default.RuleSetUpdatedCdpEventArgs);

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<RuleSetRemovedEventArgs>> RuleSetRemoved { get; } =
        EventDescriptor<CdpEventArgs<RuleSetRemovedEventArgs>>.Create(
            "goog:cdp.Preload.ruleSetRemoved",
            PreloadJsonSerializerContext.Default.RuleSetRemovedCdpEventArgs);

    /// <summary>
    /// Fired when a preload enabled state is updated.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<PreloadEnabledStateUpdatedEventArgs>> PreloadEnabledStateUpdated { get; } =
        EventDescriptor<CdpEventArgs<PreloadEnabledStateUpdatedEventArgs>>.Create(
            "goog:cdp.Preload.preloadEnabledStateUpdated",
            PreloadJsonSerializerContext.Default.PreloadEnabledStateUpdatedCdpEventArgs);

    /// <summary>
    /// Fired when a prefetch attempt is updated.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<PrefetchStatusUpdatedEventArgs>> PrefetchStatusUpdated { get; } =
        EventDescriptor<CdpEventArgs<PrefetchStatusUpdatedEventArgs>>.Create(
            "goog:cdp.Preload.prefetchStatusUpdated",
            PreloadJsonSerializerContext.Default.PrefetchStatusUpdatedCdpEventArgs);

    /// <summary>
    /// Fired when a prerender attempt is updated.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<PrerenderStatusUpdatedEventArgs>> PrerenderStatusUpdated { get; } =
        EventDescriptor<CdpEventArgs<PrerenderStatusUpdatedEventArgs>>.Create(
            "goog:cdp.Preload.prerenderStatusUpdated",
            PreloadJsonSerializerContext.Default.PrerenderStatusUpdatedCdpEventArgs);

    /// <summary>
    /// Send a list of sources for all preloading attempts in a document.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<PreloadingAttemptSourcesUpdatedEventArgs>> PreloadingAttemptSourcesUpdated { get; } =
        EventDescriptor<CdpEventArgs<PreloadingAttemptSourcesUpdatedEventArgs>>.Create(
            "goog:cdp.Preload.preloadingAttemptSourcesUpdated",
            PreloadJsonSerializerContext.Default.PreloadingAttemptSourcesUpdatedCdpEventArgs);

}
