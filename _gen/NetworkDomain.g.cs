#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Network;

/// <summary>
/// Network domain allows tracking network activities of the page. It exposes information about http,
/// file, data and other requests and responses, their headers, bodies, timing, etc.
/// </summary>
public sealed class NetworkDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static NetworkJsonSerializerContext JsonContext = NetworkJsonSerializerContext.Default;

    /// <summary>
    /// Sets a list of content encodings that will be accepted. Empty list means no encoding is accepted.
    /// </summary>
    /// <param name="encodings">
    /// List of accepted content encodings.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetAcceptedEncodingsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetAcceptedEncodingsResult> SetAcceptedEncodingsAsync(ImmutableArray<ContentEncoding> encodings, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetAcceptedEncodingsCommandParameters(Encodings: encodings);
        return await ExecuteCommandAsync(SetAcceptedEncodingsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetAcceptedEncodingsCommandParameters, SetAcceptedEncodingsResult> SetAcceptedEncodingsCommand = new("Network.setAcceptedEncodings", JsonContext.SetAcceptedEncodingsCommandParameters, JsonContext.SetAcceptedEncodingsResult);

    /// <summary>
    /// Clears accepted encodings set by setAcceptedEncodings
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearAcceptedEncodingsOverrideResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<ClearAcceptedEncodingsOverrideResult> ClearAcceptedEncodingsOverrideAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearAcceptedEncodingsOverrideCommandParameters();
        return await ExecuteCommandAsync(ClearAcceptedEncodingsOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearAcceptedEncodingsOverrideCommandParameters, ClearAcceptedEncodingsOverrideResult> ClearAcceptedEncodingsOverrideCommand = new("Network.clearAcceptedEncodingsOverride", JsonContext.ClearAcceptedEncodingsOverrideCommandParameters, JsonContext.ClearAcceptedEncodingsOverrideResult);

    /// <summary>
    /// Tells whether clearing browser cache is supported.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CanClearBrowserCacheResult"/>.
    /// </returns>
    [global::System.Obsolete]
    public async Task<CanClearBrowserCacheResult> CanClearBrowserCacheAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CanClearBrowserCacheCommandParameters();
        return await ExecuteCommandAsync(CanClearBrowserCacheCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CanClearBrowserCacheCommandParameters, CanClearBrowserCacheResult> CanClearBrowserCacheCommand = new("Network.canClearBrowserCache", JsonContext.CanClearBrowserCacheCommandParameters, JsonContext.CanClearBrowserCacheResult);

    /// <summary>
    /// Tells whether clearing browser cookies is supported.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CanClearBrowserCookiesResult"/>.
    /// </returns>
    [global::System.Obsolete]
    public async Task<CanClearBrowserCookiesResult> CanClearBrowserCookiesAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CanClearBrowserCookiesCommandParameters();
        return await ExecuteCommandAsync(CanClearBrowserCookiesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CanClearBrowserCookiesCommandParameters, CanClearBrowserCookiesResult> CanClearBrowserCookiesCommand = new("Network.canClearBrowserCookies", JsonContext.CanClearBrowserCookiesCommandParameters, JsonContext.CanClearBrowserCookiesResult);

    /// <summary>
    /// Tells whether emulation of network conditions is supported.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CanEmulateNetworkConditionsResult"/>.
    /// </returns>
    [global::System.Obsolete]
    public async Task<CanEmulateNetworkConditionsResult> CanEmulateNetworkConditionsAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CanEmulateNetworkConditionsCommandParameters();
        return await ExecuteCommandAsync(CanEmulateNetworkConditionsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CanEmulateNetworkConditionsCommandParameters, CanEmulateNetworkConditionsResult> CanEmulateNetworkConditionsCommand = new("Network.canEmulateNetworkConditions", JsonContext.CanEmulateNetworkConditionsCommandParameters, JsonContext.CanEmulateNetworkConditionsResult);

    /// <summary>
    /// Clears browser cache.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearBrowserCacheResult"/>.
    /// </returns>
    public async Task<ClearBrowserCacheResult> ClearBrowserCacheAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearBrowserCacheCommandParameters();
        return await ExecuteCommandAsync(ClearBrowserCacheCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearBrowserCacheCommandParameters, ClearBrowserCacheResult> ClearBrowserCacheCommand = new("Network.clearBrowserCache", JsonContext.ClearBrowserCacheCommandParameters, JsonContext.ClearBrowserCacheResult);

    /// <summary>
    /// Clears browser cookies.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearBrowserCookiesResult"/>.
    /// </returns>
    public async Task<ClearBrowserCookiesResult> ClearBrowserCookiesAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearBrowserCookiesCommandParameters();
        return await ExecuteCommandAsync(ClearBrowserCookiesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearBrowserCookiesCommandParameters, ClearBrowserCookiesResult> ClearBrowserCookiesCommand = new("Network.clearBrowserCookies", JsonContext.ClearBrowserCookiesCommandParameters, JsonContext.ClearBrowserCookiesResult);

    /// <summary>
    /// Response to Network.requestIntercepted which either modifies the request to continue with any
    /// modifications, or blocks it, or completes it with the provided response bytes. If a network
    /// fetch occurs as a result which encounters a redirect an additional Network.requestIntercepted
    /// event will be sent with the same InterceptionId.
    /// Deprecated, use Fetch.continueRequest, Fetch.fulfillRequest and Fetch.failRequest instead.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>ErrorReason</b> - If set this causes the request to fail with the given reason. Passing <b>Aborted</b> for requests marked with <b>isNavigationRequest</b> also cancels the navigation. Must not be set in response to an authChallenge.</description></item>
    /// <item><description><b>RawResponse</b> - If set the requests completes using with the provided base64 encoded raw response, including HTTP status line and headers etc... Must not be set in response to an authChallenge. (Encoded as a base64 string when passed over JSON)</description></item>
    /// <item><description><b>Url</b> - If set the request url will be modified in a way that's not observable by page. Must not be set in response to an authChallenge.</description></item>
    /// <item><description><b>Method</b> - If set this allows the request method to be overridden. Must not be set in response to an authChallenge.</description></item>
    /// <item><description><b>PostData</b> - If set this allows postData to be set. Must not be set in response to an authChallenge.</description></item>
    /// <item><description><b>Headers</b> - If set this allows the request headers to be changed. Must not be set in response to an authChallenge.</description></item>
    /// <item><description><b>AuthChallengeResponse</b> - Response to a requestIntercepted with an authChallenge. Must not be set otherwise.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="interceptionId">
    /// </param>
    /// <param name="errorReason">
    /// If set this causes the request to fail with the given reason. Passing <b>Aborted</b> for requests
    /// marked with <b>isNavigationRequest</b> also cancels the navigation. Must not be set in response
    /// to an authChallenge.
    /// </param>
    /// <param name="rawResponse">
    /// If set the requests completes using with the provided base64 encoded raw response, including
    /// HTTP status line and headers etc... Must not be set in response to an authChallenge. (Encoded as a base64 string when passed over JSON)
    /// </param>
    /// <param name="url">
    /// If set the request url will be modified in a way that's not observable by page. Must not be
    /// set in response to an authChallenge.
    /// </param>
    /// <param name="method">
    /// If set this allows the request method to be overridden. Must not be set in response to an
    /// authChallenge.
    /// </param>
    /// <param name="postData">
    /// If set this allows postData to be set. Must not be set in response to an authChallenge.
    /// </param>
    /// <param name="headers">
    /// If set this allows the request headers to be changed. Must not be set in response to an
    /// authChallenge.
    /// </param>
    /// <param name="authChallengeResponse">
    /// Response to a requestIntercepted with an authChallenge. Must not be set otherwise.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ContinueInterceptedRequestResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<ContinueInterceptedRequestResult> ContinueInterceptedRequestAsync(InterceptionId interceptionId, ErrorReason? errorReason = default, string? rawResponse = default, string? url = default, string? method = default, string? postData = default, global::System.Collections.Generic.IReadOnlyDictionary<string, string>? headers = default, AuthChallengeResponse? authChallengeResponse = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ContinueInterceptedRequestCommandParameters(InterceptionId: interceptionId, ErrorReason: errorReason, RawResponse: rawResponse, Url: url, Method: method, PostData: postData, Headers: headers, AuthChallengeResponse: authChallengeResponse);
        return await ExecuteCommandAsync(ContinueInterceptedRequestCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ContinueInterceptedRequestCommandParameters, ContinueInterceptedRequestResult> ContinueInterceptedRequestCommand = new("Network.continueInterceptedRequest", JsonContext.ContinueInterceptedRequestCommandParameters, JsonContext.ContinueInterceptedRequestResult);

    /// <summary>
    /// Deletes browser cookies with matching name and url or domain/path/partitionKey pair.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>Url</b> - If specified, deletes all the cookies with the given name where domain and path match provided URL.</description></item>
    /// <item><description><b>Domain</b> - If specified, deletes only cookies with the exact domain.</description></item>
    /// <item><description><b>Path</b> - If specified, deletes only cookies with the exact path.</description></item>
    /// <item><description><b>PartitionKey</b> - If specified, deletes only cookies with the the given name and partitionKey where all partition key attributes match the cookie partition key attribute.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="name">
    /// Name of the cookies to remove.
    /// </param>
    /// <param name="url">
    /// If specified, deletes all the cookies with the given name where domain and path match
    /// provided URL.
    /// </param>
    /// <param name="domain">
    /// If specified, deletes only cookies with the exact domain.
    /// </param>
    /// <param name="path">
    /// If specified, deletes only cookies with the exact path.
    /// </param>
    /// <param name="partitionKey">
    /// If specified, deletes only cookies with the the given name and partitionKey where
    /// all partition key attributes match the cookie partition key attribute.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DeleteCookiesResult"/>.
    /// </returns>
    public async Task<DeleteCookiesResult> DeleteCookiesAsync(string name, string? url = default, string? domain = default, string? path = default, CookiePartitionKey? partitionKey = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DeleteCookiesCommandParameters(Name: name, Url: url, Domain: domain, Path: path, PartitionKey: partitionKey);
        return await ExecuteCommandAsync(DeleteCookiesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DeleteCookiesCommandParameters, DeleteCookiesResult> DeleteCookiesCommand = new("Network.deleteCookies", JsonContext.DeleteCookiesCommandParameters, JsonContext.DeleteCookiesResult);

    /// <summary>
    /// Disables network tracking, prevents network events from being sent to the client.
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
    public async Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync(DisableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("Network.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Activates emulation of network conditions. This command is deprecated in favor of the emulateNetworkConditionsByRule
    /// and overrideNetworkState commands, which can be used together to the same effect.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>ConnectionType</b> - Connection type if known.</description></item>
    /// <item><description><b>PacketLoss</b> - WebRTC packet loss (percent, 0-100). 0 disables packet loss emulation, 100 drops all the packets.</description></item>
    /// <item><description><b>PacketQueueLength</b> - WebRTC packet queue length (packet). 0 removes any queue length limitations.</description></item>
    /// <item><description><b>PacketReordering</b> - WebRTC packetReordering feature.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="offline">
    /// True to emulate internet disconnection.
    /// </param>
    /// <param name="latency">
    /// Minimum latency from request sent to response headers received (ms).
    /// </param>
    /// <param name="downloadThroughput">
    /// Maximal aggregated download throughput (bytes/sec). -1 disables download throttling.
    /// </param>
    /// <param name="uploadThroughput">
    /// Maximal aggregated upload throughput (bytes/sec).  -1 disables upload throttling.
    /// </param>
    /// <param name="connectionType">
    /// Connection type if known.
    /// </param>
    /// <param name="packetLoss">
    /// WebRTC packet loss (percent, 0-100). 0 disables packet loss emulation, 100 drops all the packets.
    /// </param>
    /// <param name="packetQueueLength">
    /// WebRTC packet queue length (packet). 0 removes any queue length limitations.
    /// </param>
    /// <param name="packetReordering">
    /// WebRTC packetReordering feature.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="EmulateNetworkConditionsResult"/>.
    /// </returns>
    [global::System.Obsolete]
    public async Task<EmulateNetworkConditionsResult> EmulateNetworkConditionsAsync(bool offline, double latency, double downloadThroughput, double uploadThroughput, ConnectionType? connectionType = default, double? packetLoss = default, long? packetQueueLength = default, bool? packetReordering = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EmulateNetworkConditionsCommandParameters(Offline: offline, Latency: latency, DownloadThroughput: downloadThroughput, UploadThroughput: uploadThroughput, ConnectionType: connectionType, PacketLoss: packetLoss, PacketQueueLength: packetQueueLength, PacketReordering: packetReordering);
        return await ExecuteCommandAsync(EmulateNetworkConditionsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EmulateNetworkConditionsCommandParameters, EmulateNetworkConditionsResult> EmulateNetworkConditionsCommand = new("Network.emulateNetworkConditions", JsonContext.EmulateNetworkConditionsCommandParameters, JsonContext.EmulateNetworkConditionsResult);

    /// <summary>
    /// Activates emulation of network conditions for individual requests using URL match patterns. Unlike the deprecated
    /// Network.emulateNetworkConditions this method does not affect <b>navigator</b> state. Use Network.overrideNetworkState to
    /// explicitly modify <b>navigator</b> behavior.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>Offline</b> - True to emulate internet disconnection. Deprecated, use the offline property in matchedNetworkConditions or emulateOfflineServiceWorker instead.</description></item>
    /// <item><description><b>EmulateOfflineServiceWorker</b> - True to emulate offline service worker.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="matchedNetworkConditions">
    /// Configure conditions for matching requests. If multiple entries match a request, the first entry wins.  Global
    /// conditions can be configured by leaving the urlPattern for the conditions empty. These global conditions are
    /// also applied for throttling of p2p connections.
    /// </param>
    /// <param name="offline">
    /// True to emulate internet disconnection. Deprecated, use the offline property in matchedNetworkConditions
    /// or emulateOfflineServiceWorker instead.
    /// </param>
    /// <param name="emulateOfflineServiceWorker">
    /// True to emulate offline service worker.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="EmulateNetworkConditionsByRuleResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<EmulateNetworkConditionsByRuleResult> EmulateNetworkConditionsByRuleAsync(ImmutableArray<NetworkConditions> matchedNetworkConditions, bool? offline = default, bool? emulateOfflineServiceWorker = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EmulateNetworkConditionsByRuleCommandParameters(Offline: offline, EmulateOfflineServiceWorker: emulateOfflineServiceWorker, MatchedNetworkConditions: matchedNetworkConditions);
        return await ExecuteCommandAsync(EmulateNetworkConditionsByRuleCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EmulateNetworkConditionsByRuleCommandParameters, EmulateNetworkConditionsByRuleResult> EmulateNetworkConditionsByRuleCommand = new("Network.emulateNetworkConditionsByRule", JsonContext.EmulateNetworkConditionsByRuleCommandParameters, JsonContext.EmulateNetworkConditionsByRuleResult);

    /// <summary>
    /// Override the state of navigator.onLine and navigator.connection.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>ConnectionType</b> - Connection type if known.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="offline">
    /// True to emulate internet disconnection.
    /// </param>
    /// <param name="latency">
    /// Minimum latency from request sent to response headers received (ms).
    /// </param>
    /// <param name="downloadThroughput">
    /// Maximal aggregated download throughput (bytes/sec). -1 disables download throttling.
    /// </param>
    /// <param name="uploadThroughput">
    /// Maximal aggregated upload throughput (bytes/sec).  -1 disables upload throttling.
    /// </param>
    /// <param name="connectionType">
    /// Connection type if known.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="OverrideNetworkStateResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<OverrideNetworkStateResult> OverrideNetworkStateAsync(bool offline, double latency, double downloadThroughput, double uploadThroughput, ConnectionType? connectionType = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new OverrideNetworkStateCommandParameters(Offline: offline, Latency: latency, DownloadThroughput: downloadThroughput, UploadThroughput: uploadThroughput, ConnectionType: connectionType);
        return await ExecuteCommandAsync(OverrideNetworkStateCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<OverrideNetworkStateCommandParameters, OverrideNetworkStateResult> OverrideNetworkStateCommand = new("Network.overrideNetworkState", JsonContext.OverrideNetworkStateCommandParameters, JsonContext.OverrideNetworkStateResult);

    /// <summary>
    /// Enables network tracking, network events will now be delivered to the client.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>MaxTotalBufferSize</b> - Buffer size in bytes to use when preserving network payloads (XHRs, etc). This is the maximum number of bytes that will be collected by this DevTools session.</description></item>
    /// <item><description><b>MaxResourceBufferSize</b> - Per-resource buffer size in bytes to use when preserving network payloads (XHRs, etc).</description></item>
    /// <item><description><b>MaxPostDataSize</b> - Longest post body size (in bytes) that would be included in requestWillBeSent notification</description></item>
    /// <item><description><b>ReportDirectSocketTraffic</b> - Whether DirectSocket chunk send/receive events should be reported.</description></item>
    /// <item><description><b>EnableDurableMessages</b> - Enable storing response bodies outside of renderer, so that these survive a cross-process navigation. Requires maxTotalBufferSize to be set. Currently defaults to false. This field is being deprecated in favor of the dedicated configureDurableMessages command, due to the possibility of deadlocks when awaiting Network.enable before issuing Runtime.runIfWaitingForDebugger.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="maxTotalBufferSize">
    /// Buffer size in bytes to use when preserving network payloads (XHRs, etc).
    /// This is the maximum number of bytes that will be collected by this
    /// DevTools session.
    /// </param>
    /// <param name="maxResourceBufferSize">
    /// Per-resource buffer size in bytes to use when preserving network payloads (XHRs, etc).
    /// </param>
    /// <param name="maxPostDataSize">
    /// Longest post body size (in bytes) that would be included in requestWillBeSent notification
    /// </param>
    /// <param name="reportDirectSocketTraffic">
    /// Whether DirectSocket chunk send/receive events should be reported.
    /// </param>
    /// <param name="enableDurableMessages">
    /// Enable storing response bodies outside of renderer, so that these survive
    /// a cross-process navigation. Requires maxTotalBufferSize to be set.
    /// Currently defaults to false. This field is being deprecated in favor of the dedicated
    /// configureDurableMessages command, due to the possibility of deadlocks when awaiting
    /// Network.enable before issuing Runtime.runIfWaitingForDebugger.
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
    public async Task<EnableResult> EnableAsync(long? maxTotalBufferSize = default, long? maxResourceBufferSize = default, long? maxPostDataSize = default, bool? reportDirectSocketTraffic = default, bool? enableDurableMessages = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters(MaxTotalBufferSize: maxTotalBufferSize, MaxResourceBufferSize: maxResourceBufferSize, MaxPostDataSize: maxPostDataSize, ReportDirectSocketTraffic: reportDirectSocketTraffic, EnableDurableMessages: enableDurableMessages);
        return await ExecuteCommandAsync(EnableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("Network.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Configures storing response bodies outside of renderer, so that these survive
    /// a cross-process navigation.
    /// If maxTotalBufferSize is not set, durable messages are disabled.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>MaxTotalBufferSize</b> - Buffer size in bytes to use when preserving network payloads (XHRs, etc).</description></item>
    /// <item><description><b>MaxResourceBufferSize</b> - Per-resource buffer size in bytes to use when preserving network payloads (XHRs, etc).</description></item>
    /// </list>
    /// </remarks>
    /// <param name="maxTotalBufferSize">
    /// Buffer size in bytes to use when preserving network payloads (XHRs, etc).
    /// </param>
    /// <param name="maxResourceBufferSize">
    /// Per-resource buffer size in bytes to use when preserving network payloads (XHRs, etc).
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ConfigureDurableMessagesResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<ConfigureDurableMessagesResult> ConfigureDurableMessagesAsync(long? maxTotalBufferSize = default, long? maxResourceBufferSize = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ConfigureDurableMessagesCommandParameters(MaxTotalBufferSize: maxTotalBufferSize, MaxResourceBufferSize: maxResourceBufferSize);
        return await ExecuteCommandAsync(ConfigureDurableMessagesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ConfigureDurableMessagesCommandParameters, ConfigureDurableMessagesResult> ConfigureDurableMessagesCommand = new("Network.configureDurableMessages", JsonContext.ConfigureDurableMessagesCommandParameters, JsonContext.ConfigureDurableMessagesResult);

    /// <summary>
    /// Returns all browser cookies. Depending on the backend support, will return detailed cookie
    /// information in the <b>cookies</b> field.
    /// Deprecated. Use Storage.getCookies instead.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetAllCookiesResult"/>.
    /// </returns>
    [global::System.Obsolete]
    public async Task<GetAllCookiesResult> GetAllCookiesAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetAllCookiesCommandParameters();
        return await ExecuteCommandAsync(GetAllCookiesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetAllCookiesCommandParameters, GetAllCookiesResult> GetAllCookiesCommand = new("Network.getAllCookies", JsonContext.GetAllCookiesCommandParameters, JsonContext.GetAllCookiesResult);

    /// <summary>
    /// Returns the DER-encoded certificate.
    /// </summary>
    /// <param name="origin">
    /// Origin to get certificate for.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetCertificateResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetCertificateResult> GetCertificateAsync(string origin, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetCertificateCommandParameters(Origin: origin);
        return await ExecuteCommandAsync(GetCertificateCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetCertificateCommandParameters, GetCertificateResult> GetCertificateCommand = new("Network.getCertificate", JsonContext.GetCertificateCommandParameters, JsonContext.GetCertificateResult);

    /// <summary>
    /// Returns all browser cookies for the current URL. Depending on the backend support, will return
    /// detailed cookie information in the <b>cookies</b> field.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>Urls</b> - The list of URLs for which applicable cookies will be fetched. If not specified, it's assumed to be set to the list containing the URLs of the page and all of its subframes.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="urls">
    /// The list of URLs for which applicable cookies will be fetched.
    /// If not specified, it's assumed to be set to the list containing
    /// the URLs of the page and all of its subframes.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetCookiesResult"/>.
    /// </returns>
    public async Task<GetCookiesResult> GetCookiesAsync(ImmutableArray<string>? urls = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetCookiesCommandParameters(Urls: urls);
        return await ExecuteCommandAsync(GetCookiesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetCookiesCommandParameters, GetCookiesResult> GetCookiesCommand = new("Network.getCookies", JsonContext.GetCookiesCommandParameters, JsonContext.GetCookiesResult);

    /// <summary>
    /// Returns content served for the given request.
    /// </summary>
    /// <param name="requestId">
    /// Identifier of the network request to get content for.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetResponseBodyResult"/>.
    /// </returns>
    public async Task<GetResponseBodyResult> GetResponseBodyAsync(RequestId requestId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetResponseBodyCommandParameters(RequestId: requestId);
        return await ExecuteCommandAsync(GetResponseBodyCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetResponseBodyCommandParameters, GetResponseBodyResult> GetResponseBodyCommand = new("Network.getResponseBody", JsonContext.GetResponseBodyCommandParameters, JsonContext.GetResponseBodyResult);

    /// <summary>
    /// Returns post data sent with the request. Returns an error when no data was sent with the request.
    /// </summary>
    /// <param name="requestId">
    /// Identifier of the network request to get content for.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetRequestPostDataResult"/>.
    /// </returns>
    public async Task<GetRequestPostDataResult> GetRequestPostDataAsync(RequestId requestId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetRequestPostDataCommandParameters(RequestId: requestId);
        return await ExecuteCommandAsync(GetRequestPostDataCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetRequestPostDataCommandParameters, GetRequestPostDataResult> GetRequestPostDataCommand = new("Network.getRequestPostData", JsonContext.GetRequestPostDataCommandParameters, JsonContext.GetRequestPostDataResult);

    /// <summary>
    /// Returns content served for the given currently intercepted request.
    /// </summary>
    /// <param name="interceptionId">
    /// Identifier for the intercepted request to get body for.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetResponseBodyForInterceptionResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetResponseBodyForInterceptionResult> GetResponseBodyForInterceptionAsync(InterceptionId interceptionId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetResponseBodyForInterceptionCommandParameters(InterceptionId: interceptionId);
        return await ExecuteCommandAsync(GetResponseBodyForInterceptionCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetResponseBodyForInterceptionCommandParameters, GetResponseBodyForInterceptionResult> GetResponseBodyForInterceptionCommand = new("Network.getResponseBodyForInterception", JsonContext.GetResponseBodyForInterceptionCommandParameters, JsonContext.GetResponseBodyForInterceptionResult);

    /// <summary>
    /// Returns a handle to the stream representing the response body. Note that after this command,
    /// the intercepted request can't be continued as is -- you either need to cancel it or to provide
    /// the response body. The stream only supports sequential read, IO.read will fail if the position
    /// is specified.
    /// </summary>
    /// <param name="interceptionId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="TakeResponseBodyForInterceptionAsStreamResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<TakeResponseBodyForInterceptionAsStreamResult> TakeResponseBodyForInterceptionAsStreamAsync(InterceptionId interceptionId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new TakeResponseBodyForInterceptionAsStreamCommandParameters(InterceptionId: interceptionId);
        return await ExecuteCommandAsync(TakeResponseBodyForInterceptionAsStreamCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<TakeResponseBodyForInterceptionAsStreamCommandParameters, TakeResponseBodyForInterceptionAsStreamResult> TakeResponseBodyForInterceptionAsStreamCommand = new("Network.takeResponseBodyForInterceptionAsStream", JsonContext.TakeResponseBodyForInterceptionAsStreamCommandParameters, JsonContext.TakeResponseBodyForInterceptionAsStreamResult);

    /// <summary>
    /// This method sends a new XMLHttpRequest which is identical to the original one. The following
    /// parameters should be identical: method, url, async, request body, extra headers, withCredentials
    /// attribute, user, password.
    /// </summary>
    /// <param name="requestId">
    /// Identifier of XHR to replay.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ReplayXHRResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<ReplayXHRResult> ReplayXHRAsync(RequestId requestId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ReplayXHRCommandParameters(RequestId: requestId);
        return await ExecuteCommandAsync(ReplayXHRCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ReplayXHRCommandParameters, ReplayXHRResult> ReplayXHRCommand = new("Network.replayXHR", JsonContext.ReplayXHRCommandParameters, JsonContext.ReplayXHRResult);

    /// <summary>
    /// Searches for given string in response content.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>CaseSensitive</b> - If true, search is case sensitive.</description></item>
    /// <item><description><b>IsRegex</b> - If true, treats string parameter as regex.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="requestId">
    /// Identifier of the network response to search.
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
    /// A task representing the asynchronous operation, containing a <see cref="SearchInResponseBodyResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SearchInResponseBodyResult> SearchInResponseBodyAsync(RequestId requestId, string query, bool? caseSensitive = default, bool? isRegex = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SearchInResponseBodyCommandParameters(RequestId: requestId, Query: query, CaseSensitive: caseSensitive, IsRegex: isRegex);
        return await ExecuteCommandAsync(SearchInResponseBodyCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SearchInResponseBodyCommandParameters, SearchInResponseBodyResult> SearchInResponseBodyCommand = new("Network.searchInResponseBody", JsonContext.SearchInResponseBodyCommandParameters, JsonContext.SearchInResponseBodyResult);

    /// <summary>
    /// Blocks URLs from loading.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>UrlPatterns</b> - Patterns to match in the order in which they are given. These patterns also take precedence over any wildcard patterns defined in <b>urls</b>.</description></item>
    /// <item><description><b>Urls</b> - URL patterns to block. Wildcards ('*') are allowed.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="urlPatterns">
    /// Patterns to match in the order in which they are given. These patterns
    /// also take precedence over any wildcard patterns defined in <b>urls</b>.
    /// </param>
    /// <param name="urls">
    /// URL patterns to block. Wildcards ('*') are allowed.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetBlockedURLsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetBlockedURLsResult> SetBlockedURLsAsync(ImmutableArray<BlockPattern>? urlPatterns = default, ImmutableArray<string>? urls = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetBlockedURLsCommandParameters(UrlPatterns: urlPatterns, Urls: urls);
        return await ExecuteCommandAsync(SetBlockedURLsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetBlockedURLsCommandParameters, SetBlockedURLsResult> SetBlockedURLsCommand = new("Network.setBlockedURLs", JsonContext.SetBlockedURLsCommandParameters, JsonContext.SetBlockedURLsResult);

    /// <summary>
    /// Toggles ignoring of service worker for each request.
    /// </summary>
    /// <param name="bypass">
    /// Bypass service worker and load from network.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetBypassServiceWorkerResult"/>.
    /// </returns>
    public async Task<SetBypassServiceWorkerResult> SetBypassServiceWorkerAsync(bool bypass, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetBypassServiceWorkerCommandParameters(Bypass: bypass);
        return await ExecuteCommandAsync(SetBypassServiceWorkerCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetBypassServiceWorkerCommandParameters, SetBypassServiceWorkerResult> SetBypassServiceWorkerCommand = new("Network.setBypassServiceWorker", JsonContext.SetBypassServiceWorkerCommandParameters, JsonContext.SetBypassServiceWorkerResult);

    /// <summary>
    /// Toggles ignoring cache for each request. If <b>true</b>, cache will not be used.
    /// </summary>
    /// <param name="cacheDisabled">
    /// Cache disabled state.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetCacheDisabledResult"/>.
    /// </returns>
    public async Task<SetCacheDisabledResult> SetCacheDisabledAsync(bool cacheDisabled, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetCacheDisabledCommandParameters(CacheDisabled: cacheDisabled);
        return await ExecuteCommandAsync(SetCacheDisabledCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetCacheDisabledCommandParameters, SetCacheDisabledResult> SetCacheDisabledCommand = new("Network.setCacheDisabled", JsonContext.SetCacheDisabledCommandParameters, JsonContext.SetCacheDisabledResult);

    /// <summary>
    /// Sets a cookie with the given cookie data; may overwrite equivalent cookies if they exist.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>Url</b> - The request-URI to associate with the setting of the cookie. This value can affect the default domain, path, source port, and source scheme values of the created cookie.</description></item>
    /// <item><description><b>Domain</b> - Cookie domain.</description></item>
    /// <item><description><b>Path</b> - Cookie path.</description></item>
    /// <item><description><b>Secure</b> - True if cookie is secure.</description></item>
    /// <item><description><b>HttpOnly</b> - True if cookie is http-only.</description></item>
    /// <item><description><b>SameSite</b> - Cookie SameSite type.</description></item>
    /// <item><description><b>Expires</b> - Cookie expiration date, session cookie if not set</description></item>
    /// <item><description><b>Priority</b> - Cookie Priority type.</description></item>
    /// <item><description><b>SourceScheme</b> - Cookie source scheme type.</description></item>
    /// <item><description><b>SourcePort</b> - Cookie source port. Valid values are {-1, [1, 65535]}, -1 indicates an unspecified port. An unspecified port value allows protocol clients to emulate legacy cookie scope for the port. This is a temporary ability and it will be removed in the future.</description></item>
    /// <item><description><b>PartitionKey</b> - Cookie partition key. If not set, the cookie will be set as not partitioned.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="name">
    /// Cookie name.
    /// </param>
    /// <param name="value">
    /// Cookie value.
    /// </param>
    /// <param name="url">
    /// The request-URI to associate with the setting of the cookie. This value can affect the
    /// default domain, path, source port, and source scheme values of the created cookie.
    /// </param>
    /// <param name="domain">
    /// Cookie domain.
    /// </param>
    /// <param name="path">
    /// Cookie path.
    /// </param>
    /// <param name="secure">
    /// True if cookie is secure.
    /// </param>
    /// <param name="httpOnly">
    /// True if cookie is http-only.
    /// </param>
    /// <param name="sameSite">
    /// Cookie SameSite type.
    /// </param>
    /// <param name="expires">
    /// Cookie expiration date, session cookie if not set
    /// </param>
    /// <param name="priority">
    /// Cookie Priority type.
    /// </param>
    /// <param name="sourceScheme">
    /// Cookie source scheme type.
    /// </param>
    /// <param name="sourcePort">
    /// Cookie source port. Valid values are {-1, [1, 65535]}, -1 indicates an unspecified port.
    /// An unspecified port value allows protocol clients to emulate legacy cookie scope for the port.
    /// This is a temporary ability and it will be removed in the future.
    /// </param>
    /// <param name="partitionKey">
    /// Cookie partition key. If not set, the cookie will be set as not partitioned.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetCookieResult"/>.
    /// </returns>
    public async Task<SetCookieResult> SetCookieAsync(string name, string value, string? url = default, string? domain = default, string? path = default, bool? secure = default, bool? httpOnly = default, CookieSameSite? sameSite = default, TimeSinceEpoch? expires = default, CookiePriority? priority = default, CookieSourceScheme? sourceScheme = default, long? sourcePort = default, CookiePartitionKey? partitionKey = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetCookieCommandParameters(Name: name, Value: value, Url: url, Domain: domain, Path: path, Secure: secure, HttpOnly: httpOnly, SameSite: sameSite, Expires: expires, Priority: priority, SourceScheme: sourceScheme, SourcePort: sourcePort, PartitionKey: partitionKey);
        return await ExecuteCommandAsync(SetCookieCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetCookieCommandParameters, SetCookieResult> SetCookieCommand = new("Network.setCookie", JsonContext.SetCookieCommandParameters, JsonContext.SetCookieResult);

    /// <summary>
    /// Sets given cookies.
    /// </summary>
    /// <param name="cookies">
    /// Cookies to be set.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetCookiesResult"/>.
    /// </returns>
    public async Task<SetCookiesResult> SetCookiesAsync(ImmutableArray<CookieParam> cookies, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetCookiesCommandParameters(Cookies: cookies);
        return await ExecuteCommandAsync(SetCookiesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetCookiesCommandParameters, SetCookiesResult> SetCookiesCommand = new("Network.setCookies", JsonContext.SetCookiesCommandParameters, JsonContext.SetCookiesResult);

    /// <summary>
    /// Specifies whether to always send extra HTTP headers with the requests from this page.
    /// </summary>
    /// <param name="headers">
    /// Map with extra HTTP headers.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetExtraHTTPHeadersResult"/>.
    /// </returns>
    public async Task<SetExtraHTTPHeadersResult> SetExtraHTTPHeadersAsync(global::System.Collections.Generic.IReadOnlyDictionary<string, string> headers, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetExtraHTTPHeadersCommandParameters(Headers: headers);
        return await ExecuteCommandAsync(SetExtraHTTPHeadersCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetExtraHTTPHeadersCommandParameters, SetExtraHTTPHeadersResult> SetExtraHTTPHeadersCommand = new("Network.setExtraHTTPHeaders", JsonContext.SetExtraHTTPHeadersCommandParameters, JsonContext.SetExtraHTTPHeadersResult);

    /// <summary>
    /// Specifies whether to attach a page script stack id in requests
    /// </summary>
    /// <param name="enabled">
    /// Whether to attach a page script stack for debugging purpose.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetAttachDebugStackResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetAttachDebugStackResult> SetAttachDebugStackAsync(bool enabled, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetAttachDebugStackCommandParameters(Enabled: enabled);
        return await ExecuteCommandAsync(SetAttachDebugStackCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetAttachDebugStackCommandParameters, SetAttachDebugStackResult> SetAttachDebugStackCommand = new("Network.setAttachDebugStack", JsonContext.SetAttachDebugStackCommandParameters, JsonContext.SetAttachDebugStackResult);

    /// <summary>
    /// Sets the requests to intercept that match the provided patterns and optionally resource types.
    /// Deprecated, please use Fetch.enable instead.
    /// </summary>
    /// <param name="patterns">
    /// Requests matching any of these patterns will be forwarded and wait for the corresponding
    /// continueInterceptedRequest call.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetRequestInterceptionResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<SetRequestInterceptionResult> SetRequestInterceptionAsync(ImmutableArray<RequestPattern> patterns, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetRequestInterceptionCommandParameters(Patterns: patterns);
        return await ExecuteCommandAsync(SetRequestInterceptionCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetRequestInterceptionCommandParameters, SetRequestInterceptionResult> SetRequestInterceptionCommand = new("Network.setRequestInterception", JsonContext.SetRequestInterceptionCommandParameters, JsonContext.SetRequestInterceptionResult);

    /// <summary>
    /// Allows overriding user agent with the given string.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>AcceptLanguage</b> - Browser language to emulate.</description></item>
    /// <item><description><b>Platform</b> - The platform navigator.platform should return.</description></item>
    /// <item><description><b>UserAgentMetadata</b> - To be sent in Sec-CH-UA-* headers and returned in navigator.userAgentData</description></item>
    /// </list>
    /// </remarks>
    /// <param name="userAgent">
    /// User agent to use.
    /// </param>
    /// <param name="acceptLanguage">
    /// Browser language to emulate.
    /// </param>
    /// <param name="platform">
    /// The platform navigator.platform should return.
    /// </param>
    /// <param name="userAgentMetadata">
    /// To be sent in Sec-CH-UA-* headers and returned in navigator.userAgentData
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetUserAgentOverrideResult"/>.
    /// </returns>
    public async Task<SetUserAgentOverrideResult> SetUserAgentOverrideAsync(string userAgent, string? acceptLanguage = default, string? platform = default, Emulation.UserAgentMetadata? userAgentMetadata = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetUserAgentOverrideCommandParameters(UserAgent: userAgent, AcceptLanguage: acceptLanguage, Platform: platform, UserAgentMetadata: userAgentMetadata);
        return await ExecuteCommandAsync(SetUserAgentOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetUserAgentOverrideCommandParameters, SetUserAgentOverrideResult> SetUserAgentOverrideCommand = new("Network.setUserAgentOverride", JsonContext.SetUserAgentOverrideCommandParameters, JsonContext.SetUserAgentOverrideResult);

    /// <summary>
    /// Enables streaming of the response for the given requestId.
    /// If enabled, the dataReceived event contains the data that was received during streaming.
    /// </summary>
    /// <param name="requestId">
    /// Identifier of the request to stream.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StreamResourceContentResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<StreamResourceContentResult> StreamResourceContentAsync(RequestId requestId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new StreamResourceContentCommandParameters(RequestId: requestId);
        return await ExecuteCommandAsync(StreamResourceContentCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StreamResourceContentCommandParameters, StreamResourceContentResult> StreamResourceContentCommand = new("Network.streamResourceContent", JsonContext.StreamResourceContentCommandParameters, JsonContext.StreamResourceContentResult);

    /// <summary>
    /// Returns information about the COEP/COOP isolation status.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>FrameId</b> - If no frameId is provided, the status of the target is provided.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="frameId">
    /// If no frameId is provided, the status of the target is provided.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetSecurityIsolationStatusResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetSecurityIsolationStatusResult> GetSecurityIsolationStatusAsync(Page.FrameId? frameId = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetSecurityIsolationStatusCommandParameters(FrameId: frameId);
        return await ExecuteCommandAsync(GetSecurityIsolationStatusCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetSecurityIsolationStatusCommandParameters, GetSecurityIsolationStatusResult> GetSecurityIsolationStatusCommand = new("Network.getSecurityIsolationStatus", JsonContext.GetSecurityIsolationStatusCommandParameters, JsonContext.GetSecurityIsolationStatusResult);

    /// <summary>
    /// Enables tracking for the Reporting API, events generated by the Reporting API will now be delivered to the client.
    /// Enabling triggers 'reportingApiReportAdded' for all existing reports.
    /// </summary>
    /// <param name="enable">
    /// Whether to enable or disable events for the Reporting API
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="EnableReportingApiResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<EnableReportingApiResult> EnableReportingApiAsync(bool enable, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableReportingApiCommandParameters(Enable: enable);
        return await ExecuteCommandAsync(EnableReportingApiCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableReportingApiCommandParameters, EnableReportingApiResult> EnableReportingApiCommand = new("Network.enableReportingApi", JsonContext.EnableReportingApiCommandParameters, JsonContext.EnableReportingApiResult);

    /// <summary>
    /// Sets up tracking device bound sessions and fetching of initial set of sessions.
    /// </summary>
    /// <param name="enable">
    /// Whether to enable or disable events.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="EnableDeviceBoundSessionsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<EnableDeviceBoundSessionsResult> EnableDeviceBoundSessionsAsync(bool enable, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableDeviceBoundSessionsCommandParameters(Enable: enable);
        return await ExecuteCommandAsync(EnableDeviceBoundSessionsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableDeviceBoundSessionsCommandParameters, EnableDeviceBoundSessionsResult> EnableDeviceBoundSessionsCommand = new("Network.enableDeviceBoundSessions", JsonContext.EnableDeviceBoundSessionsCommandParameters, JsonContext.EnableDeviceBoundSessionsResult);

    /// <summary>
    /// Deletes a device bound session.
    /// </summary>
    /// <param name="key">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DeleteDeviceBoundSessionResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<DeleteDeviceBoundSessionResult> DeleteDeviceBoundSessionAsync(DeviceBoundSessionKey key, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DeleteDeviceBoundSessionCommandParameters(Key: key);
        return await ExecuteCommandAsync(DeleteDeviceBoundSessionCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DeleteDeviceBoundSessionCommandParameters, DeleteDeviceBoundSessionResult> DeleteDeviceBoundSessionCommand = new("Network.deleteDeviceBoundSession", JsonContext.DeleteDeviceBoundSessionCommandParameters, JsonContext.DeleteDeviceBoundSessionResult);

    /// <summary>
    /// Fetches the schemeful site for a specific origin.
    /// </summary>
    /// <param name="origin">
    /// The URL origin.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="FetchSchemefulSiteResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<FetchSchemefulSiteResult> FetchSchemefulSiteAsync(string origin, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new FetchSchemefulSiteCommandParameters(Origin: origin);
        return await ExecuteCommandAsync(FetchSchemefulSiteCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<FetchSchemefulSiteCommandParameters, FetchSchemefulSiteResult> FetchSchemefulSiteCommand = new("Network.fetchSchemefulSite", JsonContext.FetchSchemefulSiteCommandParameters, JsonContext.FetchSchemefulSiteResult);

    /// <summary>
    /// Fetches the resource and returns the content.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>FrameId</b> - Frame id to get the resource for. Mandatory for frame targets, and should be omitted for worker targets.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="url">
    /// URL of the resource to get content for.
    /// </param>
    /// <param name="options">
    /// Options for the request.
    /// </param>
    /// <param name="frameId">
    /// Frame id to get the resource for. Mandatory for frame targets, and
    /// should be omitted for worker targets.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="LoadNetworkResourceResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<LoadNetworkResourceResult> LoadNetworkResourceAsync(string url, LoadNetworkResourceOptions options, Page.FrameId? frameId = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new LoadNetworkResourceCommandParameters(FrameId: frameId, Url: url, Options: options);
        return await ExecuteCommandAsync(LoadNetworkResourceCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<LoadNetworkResourceCommandParameters, LoadNetworkResourceResult> LoadNetworkResourceCommand = new("Network.loadNetworkResource", JsonContext.LoadNetworkResourceCommandParameters, JsonContext.LoadNetworkResourceResult);

    /// <summary>
    /// Sets Controls for third-party cookie access
    /// Page reload is required before the new cookie behavior will be observed
    /// </summary>
    /// <param name="enableThirdPartyCookieRestriction">
    /// Whether 3pc restriction is enabled.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetCookieControlsResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<SetCookieControlsResult> SetCookieControlsAsync(bool enableThirdPartyCookieRestriction, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetCookieControlsCommandParameters(EnableThirdPartyCookieRestriction: enableThirdPartyCookieRestriction);
        return await ExecuteCommandAsync(SetCookieControlsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetCookieControlsCommandParameters, SetCookieControlsResult> SetCookieControlsCommand = new("Network.setCookieControls", JsonContext.SetCookieControlsCommandParameters, JsonContext.SetCookieControlsResult);

    /// <summary>
    /// Fired when data chunk was received over the network.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DataReceivedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b> - Request identifier.</description></item>
    /// <item><description><b>Timestamp</b> - Timestamp.</description></item>
    /// <item><description><b>DataLength</b> - Data chunk length.</description></item>
    /// <item><description><b>EncodedDataLength</b> - Actual bytes received (might be less than dataLength for compressed encodings).</description></item>
    /// <item><description><b>Data</b> - Data that was received. (Encoded as a base64 string when passed over JSON)</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<DataReceivedEventArgs> DataReceived => CreateCdpEventSource(NetworkDomainEvent.DataReceived);
    /// <summary>
    /// Fired when EventSource message is received.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="EventSourceMessageReceivedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b> - Request identifier.</description></item>
    /// <item><description><b>Timestamp</b> - Timestamp.</description></item>
    /// <item><description><b>EventName</b> - Message type.</description></item>
    /// <item><description><b>EventId</b> - Message identifier.</description></item>
    /// <item><description><b>Data</b> - Message content.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<EventSourceMessageReceivedEventArgs> EventSourceMessageReceived => CreateCdpEventSource(NetworkDomainEvent.EventSourceMessageReceived);
    /// <summary>
    /// Fired when HTTP request has failed to load.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="LoadingFailedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b> - Request identifier.</description></item>
    /// <item><description><b>Timestamp</b> - Timestamp.</description></item>
    /// <item><description><b>Type</b> - Resource type.</description></item>
    /// <item><description><b>ErrorText</b> - Error message. List of network errors: https://cs.chromium.org/chromium/src/net/base/net_error_list.h</description></item>
    /// <item><description><b>Canceled</b> - True if loading was canceled.</description></item>
    /// <item><description><b>BlockedReason</b> - The reason why loading was blocked, if any.</description></item>
    /// <item><description><b>CorsErrorStatus</b> - The reason why loading was blocked by CORS, if any.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<LoadingFailedEventArgs> LoadingFailed => CreateCdpEventSource(NetworkDomainEvent.LoadingFailed);
    /// <summary>
    /// Fired when HTTP request has finished loading.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="LoadingFinishedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b> - Request identifier.</description></item>
    /// <item><description><b>Timestamp</b> - Timestamp.</description></item>
    /// <item><description><b>EncodedDataLength</b> - Total number of bytes received for this request.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<LoadingFinishedEventArgs> LoadingFinished => CreateCdpEventSource(NetworkDomainEvent.LoadingFinished);
    /// <summary>
    /// Details of an intercepted HTTP request, which must be either allowed, blocked, modified or
    /// mocked.
    /// Deprecated, use Fetch.requestPaused instead.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="RequestInterceptedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>InterceptionId</b> - Each request the page makes will have a unique id, however if any redirects are encountered while processing that fetch, they will be reported with the same id as the original fetch. Likewise if HTTP authentication is needed then the same fetch id will be used.</description></item>
    /// <item><description><b>Request</b></description></item>
    /// <item><description><b>FrameId</b> - The id of the frame that initiated the request.</description></item>
    /// <item><description><b>ResourceType</b> - How the requested resource will be used.</description></item>
    /// <item><description><b>IsNavigationRequest</b> - Whether this is a navigation request, which can abort the navigation completely.</description></item>
    /// <item><description><b>IsDownload</b> - Set if the request is a navigation that will result in a download. Only present after response is received from the server (i.e. HeadersReceived stage).</description></item>
    /// <item><description><b>RedirectUrl</b> - Redirect location, only sent if a redirect was intercepted.</description></item>
    /// <item><description><b>AuthChallenge</b> - Details of the Authorization Challenge encountered. If this is set then continueInterceptedRequest must contain an authChallengeResponse.</description></item>
    /// <item><description><b>ResponseErrorReason</b> - Response error if intercepted at response stage or if redirect occurred while intercepting request.</description></item>
    /// <item><description><b>ResponseStatusCode</b> - Response code if intercepted at response stage or if redirect occurred while intercepting request or auth retry occurred.</description></item>
    /// <item><description><b>ResponseHeaders</b> - Response headers if intercepted at the response stage or if redirect occurred while intercepting request or auth retry occurred.</description></item>
    /// <item><description><b>RequestId</b> - If the intercepted request had a corresponding requestWillBeSent event fired for it, then this requestId will be the same as the requestId present in the requestWillBeSent event.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public IEventSource<RequestInterceptedEventArgs> RequestIntercepted => CreateCdpEventSource(NetworkDomainEvent.RequestIntercepted);
    /// <summary>
    /// Fired if request ended up loading from cache.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="RequestServedFromCacheEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b> - Request identifier.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<RequestServedFromCacheEventArgs> RequestServedFromCache => CreateCdpEventSource(NetworkDomainEvent.RequestServedFromCache);
    /// <summary>
    /// Fired when page is about to send HTTP request.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="RequestWillBeSentEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b> - Request identifier.</description></item>
    /// <item><description><b>LoaderId</b> - Loader identifier. Empty string if the request is fetched from worker.</description></item>
    /// <item><description><b>DocumentURL</b> - URL of the document this request is loaded for.</description></item>
    /// <item><description><b>Request</b> - Request data.</description></item>
    /// <item><description><b>Timestamp</b> - Timestamp.</description></item>
    /// <item><description><b>WallTime</b> - Timestamp.</description></item>
    /// <item><description><b>Initiator</b> - Request initiator.</description></item>
    /// <item><description><b>RedirectHasExtraInfo</b> - In the case that redirectResponse is populated, this flag indicates whether requestWillBeSentExtraInfo and responseReceivedExtraInfo events will be or were emitted for the request which was just redirected.</description></item>
    /// <item><description><b>RedirectResponse</b> - Redirect response data.</description></item>
    /// <item><description><b>Type</b> - Type of this resource.</description></item>
    /// <item><description><b>FrameId</b> - Frame identifier.</description></item>
    /// <item><description><b>HasUserGesture</b> - Whether the request is initiated by a user gesture. Defaults to false.</description></item>
    /// <item><description><b>RenderBlockingBehavior</b> - The render-blocking behavior of the request.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<RequestWillBeSentEventArgs> RequestWillBeSent => CreateCdpEventSource(NetworkDomainEvent.RequestWillBeSent);
    /// <summary>
    /// Fired when resource loading priority is changed
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ResourceChangedPriorityEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b> - Request identifier.</description></item>
    /// <item><description><b>NewPriority</b> - New priority</description></item>
    /// <item><description><b>Timestamp</b> - Timestamp.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<ResourceChangedPriorityEventArgs> ResourceChangedPriority => CreateCdpEventSource(NetworkDomainEvent.ResourceChangedPriority);
    /// <summary>
    /// Fired when a signed exchange was received over the network
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="SignedExchangeReceivedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b> - Request identifier.</description></item>
    /// <item><description><b>Info</b> - Information about the signed exchange response.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<SignedExchangeReceivedEventArgs> SignedExchangeReceived => CreateCdpEventSource(NetworkDomainEvent.SignedExchangeReceived);
    /// <summary>
    /// Fired when HTTP response is available.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ResponseReceivedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b> - Request identifier.</description></item>
    /// <item><description><b>LoaderId</b> - Loader identifier. Empty string if the request is fetched from worker.</description></item>
    /// <item><description><b>Timestamp</b> - Timestamp.</description></item>
    /// <item><description><b>Type</b> - Resource type.</description></item>
    /// <item><description><b>Response</b> - Response data.</description></item>
    /// <item><description><b>HasExtraInfo</b> - Indicates whether requestWillBeSentExtraInfo and responseReceivedExtraInfo events will be or were emitted for this request.</description></item>
    /// <item><description><b>FrameId</b> - Frame identifier.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ResponseReceivedEventArgs> ResponseReceived => CreateCdpEventSource(NetworkDomainEvent.ResponseReceived);
    /// <summary>
    /// Fired when WebSocket is closed.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="WebSocketClosedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b> - Request identifier.</description></item>
    /// <item><description><b>Timestamp</b> - Timestamp.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<WebSocketClosedEventArgs> WebSocketClosed => CreateCdpEventSource(NetworkDomainEvent.WebSocketClosed);
    /// <summary>
    /// Fired upon WebSocket creation.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="WebSocketCreatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b> - Request identifier.</description></item>
    /// <item><description><b>Url</b> - WebSocket request URL.</description></item>
    /// <item><description><b>Initiator</b> - Request initiator.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<WebSocketCreatedEventArgs> WebSocketCreated => CreateCdpEventSource(NetworkDomainEvent.WebSocketCreated);
    /// <summary>
    /// Fired when WebSocket message error occurs.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="WebSocketFrameErrorEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b> - Request identifier.</description></item>
    /// <item><description><b>Timestamp</b> - Timestamp.</description></item>
    /// <item><description><b>ErrorMessage</b> - WebSocket error message.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<WebSocketFrameErrorEventArgs> WebSocketFrameError => CreateCdpEventSource(NetworkDomainEvent.WebSocketFrameError);
    /// <summary>
    /// Fired when WebSocket message is received.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="WebSocketFrameReceivedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b> - Request identifier.</description></item>
    /// <item><description><b>Timestamp</b> - Timestamp.</description></item>
    /// <item><description><b>Response</b> - WebSocket response data.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<WebSocketFrameReceivedEventArgs> WebSocketFrameReceived => CreateCdpEventSource(NetworkDomainEvent.WebSocketFrameReceived);
    /// <summary>
    /// Fired when WebSocket message is sent.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="WebSocketFrameSentEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b> - Request identifier.</description></item>
    /// <item><description><b>Timestamp</b> - Timestamp.</description></item>
    /// <item><description><b>Response</b> - WebSocket response data.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<WebSocketFrameSentEventArgs> WebSocketFrameSent => CreateCdpEventSource(NetworkDomainEvent.WebSocketFrameSent);
    /// <summary>
    /// Fired when WebSocket handshake response becomes available.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="WebSocketHandshakeResponseReceivedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b> - Request identifier.</description></item>
    /// <item><description><b>Timestamp</b> - Timestamp.</description></item>
    /// <item><description><b>Response</b> - WebSocket response data.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<WebSocketHandshakeResponseReceivedEventArgs> WebSocketHandshakeResponseReceived => CreateCdpEventSource(NetworkDomainEvent.WebSocketHandshakeResponseReceived);
    /// <summary>
    /// Fired when WebSocket is about to initiate handshake.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="WebSocketWillSendHandshakeRequestEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b> - Request identifier.</description></item>
    /// <item><description><b>Timestamp</b> - Timestamp.</description></item>
    /// <item><description><b>WallTime</b> - UTC Timestamp.</description></item>
    /// <item><description><b>Request</b> - WebSocket request data.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<WebSocketWillSendHandshakeRequestEventArgs> WebSocketWillSendHandshakeRequest => CreateCdpEventSource(NetworkDomainEvent.WebSocketWillSendHandshakeRequest);
    /// <summary>
    /// Fired upon WebTransport creation.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="WebTransportCreatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>TransportId</b> - WebTransport identifier.</description></item>
    /// <item><description><b>Url</b> - WebTransport request URL.</description></item>
    /// <item><description><b>Timestamp</b> - Timestamp.</description></item>
    /// <item><description><b>Initiator</b> - Request initiator.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<WebTransportCreatedEventArgs> WebTransportCreated => CreateCdpEventSource(NetworkDomainEvent.WebTransportCreated);
    /// <summary>
    /// Fired when WebTransport handshake is finished.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="WebTransportConnectionEstablishedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>TransportId</b> - WebTransport identifier.</description></item>
    /// <item><description><b>Timestamp</b> - Timestamp.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<WebTransportConnectionEstablishedEventArgs> WebTransportConnectionEstablished => CreateCdpEventSource(NetworkDomainEvent.WebTransportConnectionEstablished);
    /// <summary>
    /// Fired when WebTransport is disposed.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="WebTransportClosedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>TransportId</b> - WebTransport identifier.</description></item>
    /// <item><description><b>Timestamp</b> - Timestamp.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<WebTransportClosedEventArgs> WebTransportClosed => CreateCdpEventSource(NetworkDomainEvent.WebTransportClosed);
    /// <summary>
    /// Fired upon direct_socket.TCPSocket creation.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DirectTCPSocketCreatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Identifier</b></description></item>
    /// <item><description><b>RemoteAddr</b></description></item>
    /// <item><description><b>RemotePort</b> - Unsigned int 16.</description></item>
    /// <item><description><b>Options</b></description></item>
    /// <item><description><b>Timestamp</b></description></item>
    /// <item><description><b>Initiator</b></description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DirectTCPSocketCreatedEventArgs> DirectTCPSocketCreated => CreateCdpEventSource(NetworkDomainEvent.DirectTCPSocketCreated);
    /// <summary>
    /// Fired when direct_socket.TCPSocket connection is opened.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DirectTCPSocketOpenedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Identifier</b></description></item>
    /// <item><description><b>RemoteAddr</b></description></item>
    /// <item><description><b>RemotePort</b> - Expected to be unsigned integer.</description></item>
    /// <item><description><b>Timestamp</b></description></item>
    /// <item><description><b>LocalAddr</b></description></item>
    /// <item><description><b>LocalPort</b> - Expected to be unsigned integer.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DirectTCPSocketOpenedEventArgs> DirectTCPSocketOpened => CreateCdpEventSource(NetworkDomainEvent.DirectTCPSocketOpened);
    /// <summary>
    /// Fired when direct_socket.TCPSocket is aborted.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DirectTCPSocketAbortedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Identifier</b></description></item>
    /// <item><description><b>ErrorMessage</b></description></item>
    /// <item><description><b>Timestamp</b></description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DirectTCPSocketAbortedEventArgs> DirectTCPSocketAborted => CreateCdpEventSource(NetworkDomainEvent.DirectTCPSocketAborted);
    /// <summary>
    /// Fired when direct_socket.TCPSocket is closed.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DirectTCPSocketClosedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Identifier</b></description></item>
    /// <item><description><b>Timestamp</b></description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DirectTCPSocketClosedEventArgs> DirectTCPSocketClosed => CreateCdpEventSource(NetworkDomainEvent.DirectTCPSocketClosed);
    /// <summary>
    /// Fired when data is sent to tcp direct socket stream.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DirectTCPSocketChunkSentEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Identifier</b></description></item>
    /// <item><description><b>Data</b></description></item>
    /// <item><description><b>Timestamp</b></description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DirectTCPSocketChunkSentEventArgs> DirectTCPSocketChunkSent => CreateCdpEventSource(NetworkDomainEvent.DirectTCPSocketChunkSent);
    /// <summary>
    /// Fired when data is received from tcp direct socket stream.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DirectTCPSocketChunkReceivedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Identifier</b></description></item>
    /// <item><description><b>Data</b></description></item>
    /// <item><description><b>Timestamp</b></description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DirectTCPSocketChunkReceivedEventArgs> DirectTCPSocketChunkReceived => CreateCdpEventSource(NetworkDomainEvent.DirectTCPSocketChunkReceived);
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DirectUDPSocketJoinedMulticastGroupEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Identifier</b></description></item>
    /// <item><description><b>IPAddress</b></description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DirectUDPSocketJoinedMulticastGroupEventArgs> DirectUDPSocketJoinedMulticastGroup => CreateCdpEventSource(NetworkDomainEvent.DirectUDPSocketJoinedMulticastGroup);
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DirectUDPSocketLeftMulticastGroupEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Identifier</b></description></item>
    /// <item><description><b>IPAddress</b></description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DirectUDPSocketLeftMulticastGroupEventArgs> DirectUDPSocketLeftMulticastGroup => CreateCdpEventSource(NetworkDomainEvent.DirectUDPSocketLeftMulticastGroup);
    /// <summary>
    /// Fired upon direct_socket.UDPSocket creation.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DirectUDPSocketCreatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Identifier</b></description></item>
    /// <item><description><b>Options</b></description></item>
    /// <item><description><b>Timestamp</b></description></item>
    /// <item><description><b>Initiator</b></description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DirectUDPSocketCreatedEventArgs> DirectUDPSocketCreated => CreateCdpEventSource(NetworkDomainEvent.DirectUDPSocketCreated);
    /// <summary>
    /// Fired when direct_socket.UDPSocket connection is opened.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DirectUDPSocketOpenedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Identifier</b></description></item>
    /// <item><description><b>LocalAddr</b></description></item>
    /// <item><description><b>LocalPort</b> - Expected to be unsigned integer.</description></item>
    /// <item><description><b>Timestamp</b></description></item>
    /// <item><description><b>RemoteAddr</b></description></item>
    /// <item><description><b>RemotePort</b> - Expected to be unsigned integer.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DirectUDPSocketOpenedEventArgs> DirectUDPSocketOpened => CreateCdpEventSource(NetworkDomainEvent.DirectUDPSocketOpened);
    /// <summary>
    /// Fired when direct_socket.UDPSocket is aborted.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DirectUDPSocketAbortedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Identifier</b></description></item>
    /// <item><description><b>ErrorMessage</b></description></item>
    /// <item><description><b>Timestamp</b></description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DirectUDPSocketAbortedEventArgs> DirectUDPSocketAborted => CreateCdpEventSource(NetworkDomainEvent.DirectUDPSocketAborted);
    /// <summary>
    /// Fired when direct_socket.UDPSocket is closed.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DirectUDPSocketClosedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Identifier</b></description></item>
    /// <item><description><b>Timestamp</b></description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DirectUDPSocketClosedEventArgs> DirectUDPSocketClosed => CreateCdpEventSource(NetworkDomainEvent.DirectUDPSocketClosed);
    /// <summary>
    /// Fired when message is sent to udp direct socket stream.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DirectUDPSocketChunkSentEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Identifier</b></description></item>
    /// <item><description><b>Message</b></description></item>
    /// <item><description><b>Timestamp</b></description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DirectUDPSocketChunkSentEventArgs> DirectUDPSocketChunkSent => CreateCdpEventSource(NetworkDomainEvent.DirectUDPSocketChunkSent);
    /// <summary>
    /// Fired when message is received from udp direct socket stream.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DirectUDPSocketChunkReceivedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Identifier</b></description></item>
    /// <item><description><b>Message</b></description></item>
    /// <item><description><b>Timestamp</b></description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DirectUDPSocketChunkReceivedEventArgs> DirectUDPSocketChunkReceived => CreateCdpEventSource(NetworkDomainEvent.DirectUDPSocketChunkReceived);
    /// <summary>
    /// Fired when additional information about a requestWillBeSent event is available from the
    /// network stack. Not every requestWillBeSent event will have an additional
    /// requestWillBeSentExtraInfo fired for it, and there is no guarantee whether requestWillBeSent
    /// or requestWillBeSentExtraInfo will be fired first for the same request.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="RequestWillBeSentExtraInfoEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b> - Request identifier. Used to match this information to an existing requestWillBeSent event.</description></item>
    /// <item><description><b>AssociatedCookies</b> - A list of cookies potentially associated to the requested URL. This includes both cookies sent with the request and the ones not sent; the latter are distinguished by having blockedReasons field set.</description></item>
    /// <item><description><b>Headers</b> - Raw request headers as they will be sent over the wire.</description></item>
    /// <item><description><b>ConnectTiming</b> - Connection timing information for the request.</description></item>
    /// <item><description><b>DeviceBoundSessionUsages</b> - How the request site's device bound sessions were used during this request.</description></item>
    /// <item><description><b>ClientSecurityState</b> - The client security state set for the request.</description></item>
    /// <item><description><b>SiteHasCookieInOtherPartition</b> - Whether the site has partitioned cookies stored in a partition different than the current one.</description></item>
    /// <item><description><b>AppliedNetworkConditionsId</b> - The network conditions id if this request was affected by network conditions configured via emulateNetworkConditionsByRule.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<RequestWillBeSentExtraInfoEventArgs> RequestWillBeSentExtraInfo => CreateCdpEventSource(NetworkDomainEvent.RequestWillBeSentExtraInfo);
    /// <summary>
    /// Fired when additional information about a responseReceived event is available from the network
    /// stack. Not every responseReceived event will have an additional responseReceivedExtraInfo for
    /// it, and responseReceivedExtraInfo may be fired before or after responseReceived.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ResponseReceivedExtraInfoEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b> - Request identifier. Used to match this information to another responseReceived event.</description></item>
    /// <item><description><b>BlockedCookies</b> - A list of cookies which were not stored from the response along with the corresponding reasons for blocking. The cookies here may not be valid due to syntax errors, which are represented by the invalid cookie line string instead of a proper cookie.</description></item>
    /// <item><description><b>Headers</b> - Raw response headers as they were received over the wire. Duplicate headers in the response are represented as a single key with their values concatentated using <b>\n</b> as the separator. See also <b>headersText</b> that contains verbatim text for HTTP/1.*.</description></item>
    /// <item><description><b>ResourceIPAddressSpace</b> - The IP address space of the resource. The address space can only be determined once the transport established the connection, so we can't send it in <b>requestWillBeSentExtraInfo</b>.</description></item>
    /// <item><description><b>StatusCode</b> - The status code of the response. This is useful in cases the request failed and no responseReceived event is triggered, which is the case for, e.g., CORS errors. This is also the correct status code for cached requests, where the status in responseReceived is a 200 and this will be 304.</description></item>
    /// <item><description><b>HeadersText</b> - Raw response header text as it was received over the wire. The raw text may not always be available, such as in the case of HTTP/2 or QUIC.</description></item>
    /// <item><description><b>CookiePartitionKey</b> - The cookie partition key that will be used to store partitioned cookies set in this response. Only sent when partitioned cookies are enabled.</description></item>
    /// <item><description><b>CookiePartitionKeyOpaque</b> - True if partitioned cookies are enabled, but the partition key is not serializable to string.</description></item>
    /// <item><description><b>ExemptedCookies</b> - A list of cookies which should have been blocked by 3PCD but are exempted and stored from the response with the corresponding reason.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<ResponseReceivedExtraInfoEventArgs> ResponseReceivedExtraInfo => CreateCdpEventSource(NetworkDomainEvent.ResponseReceivedExtraInfo);
    /// <summary>
    /// Fired when 103 Early Hints headers is received in addition to the common response.
    /// Not every responseReceived event will have an responseReceivedEarlyHints fired.
    /// Only one responseReceivedEarlyHints may be fired for eached responseReceived event.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ResponseReceivedEarlyHintsEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b> - Request identifier. Used to match this information to another responseReceived event.</description></item>
    /// <item><description><b>Headers</b> - Raw response headers as they were received over the wire. Duplicate headers in the response are represented as a single key with their values concatentated using <b>\n</b> as the separator. See also <b>headersText</b> that contains verbatim text for HTTP/1.*.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<ResponseReceivedEarlyHintsEventArgs> ResponseReceivedEarlyHints => CreateCdpEventSource(NetworkDomainEvent.ResponseReceivedEarlyHints);
    /// <summary>
    /// Fired exactly once for each Trust Token operation. Depending on
    /// the type of the operation and whether the operation succeeded or
    /// failed, the event is fired before the corresponding request was sent
    /// or after the response was received.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="TrustTokenOperationDoneEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Status</b> - Detailed success or error status of the operation. 'AlreadyExists' also signifies a successful operation, as the result of the operation already exists und thus, the operation was abort preemptively (e.g. a cache hit).</description></item>
    /// <item><description><b>Type</b></description></item>
    /// <item><description><b>RequestId</b></description></item>
    /// <item><description><b>TopLevelOrigin</b> - Top level origin. The context in which the operation was attempted.</description></item>
    /// <item><description><b>IssuerOrigin</b> - Origin of the issuer in case of a "Issuance" or "Redemption" operation.</description></item>
    /// <item><description><b>IssuedTokenCount</b> - The number of obtained Trust Tokens on a successful "Issuance" operation.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<TrustTokenOperationDoneEventArgs> TrustTokenOperationDone => CreateCdpEventSource(NetworkDomainEvent.TrustTokenOperationDone);
    /// <summary>
    /// Fired once security policy has been updated.
    /// </summary>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<PolicyUpdatedEventArgs> PolicyUpdated => CreateCdpEventSource(NetworkDomainEvent.PolicyUpdated);
    /// <summary>
    /// Is sent whenever a new report is added.
    /// And after 'enableReportingApi' for all existing reports.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ReportingApiReportAddedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Report</b></description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<ReportingApiReportAddedEventArgs> ReportingApiReportAdded => CreateCdpEventSource(NetworkDomainEvent.ReportingApiReportAdded);
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ReportingApiReportUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Report</b></description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<ReportingApiReportUpdatedEventArgs> ReportingApiReportUpdated => CreateCdpEventSource(NetworkDomainEvent.ReportingApiReportUpdated);
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ReportingApiEndpointsChangedForOriginEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Origin</b> - Origin of the document(s) which configured the endpoints.</description></item>
    /// <item><description><b>Endpoints</b></description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<ReportingApiEndpointsChangedForOriginEventArgs> ReportingApiEndpointsChangedForOrigin => CreateCdpEventSource(NetworkDomainEvent.ReportingApiEndpointsChangedForOrigin);
    /// <summary>
    /// Triggered when the initial set of device bound sessions is added.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DeviceBoundSessionsAddedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Sessions</b> - The device bound sessions.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DeviceBoundSessionsAddedEventArgs> DeviceBoundSessionsAdded => CreateCdpEventSource(NetworkDomainEvent.DeviceBoundSessionsAdded);
    /// <summary>
    /// Triggered when a device bound session event occurs.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DeviceBoundSessionEventOccurredEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>EventId</b> - A unique identifier for this session event.</description></item>
    /// <item><description><b>Site</b> - The site this session event is associated with.</description></item>
    /// <item><description><b>Succeeded</b> - Whether this event was considered successful.</description></item>
    /// <item><description><b>SessionId</b> - The session ID this event is associated with. May not be populated for failed events.</description></item>
    /// <item><description><b>CreationEventDetails</b> - The below are the different session event type details. Exactly one is populated.</description></item>
    /// <item><description><b>RefreshEventDetails</b></description></item>
    /// <item><description><b>TerminationEventDetails</b></description></item>
    /// <item><description><b>ChallengeEventDetails</b></description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DeviceBoundSessionEventOccurredEventArgs> DeviceBoundSessionEventOccurred => CreateCdpEventSource(NetworkDomainEvent.DeviceBoundSessionEventOccurred);
}

internal sealed record SetAcceptedEncodingsCommandParameters(ImmutableArray<ContentEncoding> Encodings) : Parameters;

/// <summary>
/// </summary>
public sealed record SetAcceptedEncodingsResult() : EmptyResult;


internal sealed record ClearAcceptedEncodingsOverrideCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record ClearAcceptedEncodingsOverrideResult() : EmptyResult;


internal sealed record CanClearBrowserCacheCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="Result">
/// True if browser cache can be cleared.
/// </param>
public sealed record CanClearBrowserCacheResult(bool Result) : EmptyResult;


internal sealed record CanClearBrowserCookiesCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="Result">
/// True if browser cookies can be cleared.
/// </param>
public sealed record CanClearBrowserCookiesResult(bool Result) : EmptyResult;


internal sealed record CanEmulateNetworkConditionsCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="Result">
/// True if emulation of network conditions is supported.
/// </param>
public sealed record CanEmulateNetworkConditionsResult(bool Result) : EmptyResult;


internal sealed record ClearBrowserCacheCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record ClearBrowserCacheResult() : EmptyResult;


internal sealed record ClearBrowserCookiesCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record ClearBrowserCookiesResult() : EmptyResult;


internal sealed record ContinueInterceptedRequestCommandParameters(InterceptionId InterceptionId, ErrorReason? ErrorReason, string? RawResponse, string? Url, string? Method, string? PostData, global::System.Collections.Generic.IReadOnlyDictionary<string, string>? Headers, AuthChallengeResponse? AuthChallengeResponse) : Parameters;

/// <summary>
/// </summary>
public sealed record ContinueInterceptedRequestResult() : EmptyResult;


internal sealed record DeleteCookiesCommandParameters(string Name, string? Url, string? Domain, string? Path, CookiePartitionKey? PartitionKey) : Parameters;

/// <summary>
/// </summary>
public sealed record DeleteCookiesResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EmulateNetworkConditionsCommandParameters(bool Offline, double Latency, double DownloadThroughput, double UploadThroughput, ConnectionType? ConnectionType, double? PacketLoss, long? PacketQueueLength, bool? PacketReordering) : Parameters;

/// <summary>
/// </summary>
public sealed record EmulateNetworkConditionsResult() : EmptyResult;


internal sealed record EmulateNetworkConditionsByRuleCommandParameters(bool? Offline, bool? EmulateOfflineServiceWorker, ImmutableArray<NetworkConditions> MatchedNetworkConditions) : Parameters;

/// <summary>
/// </summary>
/// <param name="RuleIds">
/// An id for each entry in matchedNetworkConditions. The id will be included in the requestWillBeSentExtraInfo for
/// requests affected by a rule.
/// </param>
public sealed record EmulateNetworkConditionsByRuleResult(ImmutableArray<string> RuleIds) : EmptyResult;


internal sealed record OverrideNetworkStateCommandParameters(bool Offline, double Latency, double DownloadThroughput, double UploadThroughput, ConnectionType? ConnectionType) : Parameters;

/// <summary>
/// </summary>
public sealed record OverrideNetworkStateResult() : EmptyResult;


internal sealed record EnableCommandParameters(long? MaxTotalBufferSize, long? MaxResourceBufferSize, long? MaxPostDataSize, bool? ReportDirectSocketTraffic, bool? EnableDurableMessages) : Parameters;

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record ConfigureDurableMessagesCommandParameters(long? MaxTotalBufferSize, long? MaxResourceBufferSize) : Parameters;

/// <summary>
/// </summary>
public sealed record ConfigureDurableMessagesResult() : EmptyResult;


internal sealed record GetAllCookiesCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="Cookies">
/// Array of cookie objects.
/// </param>
public sealed record GetAllCookiesResult(ImmutableArray<Cookie> Cookies) : EmptyResult;


internal sealed record GetCertificateCommandParameters(string Origin) : Parameters;

/// <summary>
/// </summary>
/// <param name="TableNames">
/// </param>
public sealed record GetCertificateResult(ImmutableArray<string> TableNames) : EmptyResult;


internal sealed record GetCookiesCommandParameters(ImmutableArray<string>? Urls) : Parameters;

/// <summary>
/// </summary>
/// <param name="Cookies">
/// Array of cookie objects.
/// </param>
public sealed record GetCookiesResult(ImmutableArray<Cookie> Cookies) : EmptyResult;


internal sealed record GetResponseBodyCommandParameters(RequestId RequestId) : Parameters;

/// <summary>
/// </summary>
/// <param name="Body">
/// Response body.
/// </param>
/// <param name="Base64Encoded">
/// True, if content was sent as base64.
/// </param>
public sealed record GetResponseBodyResult(string Body, bool Base64Encoded) : EmptyResult;


internal sealed record GetRequestPostDataCommandParameters(RequestId RequestId) : Parameters;

/// <summary>
/// </summary>
/// <param name="PostData">
/// Request body string, omitting files from multipart requests
/// </param>
/// <param name="Base64Encoded">
/// True, if content was sent as base64.
/// </param>
public sealed record GetRequestPostDataResult(string PostData, bool Base64Encoded) : EmptyResult;


internal sealed record GetResponseBodyForInterceptionCommandParameters(InterceptionId InterceptionId) : Parameters;

/// <summary>
/// </summary>
/// <param name="Body">
/// Response body.
/// </param>
/// <param name="Base64Encoded">
/// True, if content was sent as base64.
/// </param>
public sealed record GetResponseBodyForInterceptionResult(string Body, bool Base64Encoded) : EmptyResult;


internal sealed record TakeResponseBodyForInterceptionAsStreamCommandParameters(InterceptionId InterceptionId) : Parameters;

/// <summary>
/// </summary>
/// <param name="Stream">
/// </param>
public sealed record TakeResponseBodyForInterceptionAsStreamResult(IO.StreamHandle Stream) : EmptyResult;


internal sealed record ReplayXHRCommandParameters(RequestId RequestId) : Parameters;

/// <summary>
/// </summary>
public sealed record ReplayXHRResult() : EmptyResult;


internal sealed record SearchInResponseBodyCommandParameters(RequestId RequestId, string Query, bool? CaseSensitive, bool? IsRegex) : Parameters;

/// <summary>
/// </summary>
/// <param name="Result">
/// List of search matches.
/// </param>
public sealed record SearchInResponseBodyResult(ImmutableArray<Debugger.SearchMatch> Result) : EmptyResult;


internal sealed record SetBlockedURLsCommandParameters(ImmutableArray<BlockPattern>? UrlPatterns, ImmutableArray<string>? Urls) : Parameters;

/// <summary>
/// </summary>
public sealed record SetBlockedURLsResult() : EmptyResult;


internal sealed record SetBypassServiceWorkerCommandParameters(bool Bypass) : Parameters;

/// <summary>
/// </summary>
public sealed record SetBypassServiceWorkerResult() : EmptyResult;


internal sealed record SetCacheDisabledCommandParameters(bool CacheDisabled) : Parameters;

/// <summary>
/// </summary>
public sealed record SetCacheDisabledResult() : EmptyResult;


internal sealed record SetCookieCommandParameters(string Name, string Value, string? Url, string? Domain, string? Path, bool? Secure, bool? HttpOnly, CookieSameSite? SameSite, TimeSinceEpoch? Expires, CookiePriority? Priority, CookieSourceScheme? SourceScheme, long? SourcePort, CookiePartitionKey? PartitionKey) : Parameters;

/// <summary>
/// </summary>
/// <param name="Success">
/// Always set to true. If an error occurs, the response indicates protocol error.
/// </param>
public sealed record SetCookieResult(bool Success) : EmptyResult;


internal sealed record SetCookiesCommandParameters(ImmutableArray<CookieParam> Cookies) : Parameters;

/// <summary>
/// </summary>
public sealed record SetCookiesResult() : EmptyResult;


internal sealed record SetExtraHTTPHeadersCommandParameters(global::System.Collections.Generic.IReadOnlyDictionary<string, string> Headers) : Parameters;

/// <summary>
/// </summary>
public sealed record SetExtraHTTPHeadersResult() : EmptyResult;


internal sealed record SetAttachDebugStackCommandParameters(bool Enabled) : Parameters;

/// <summary>
/// </summary>
public sealed record SetAttachDebugStackResult() : EmptyResult;


internal sealed record SetRequestInterceptionCommandParameters(ImmutableArray<RequestPattern> Patterns) : Parameters;

/// <summary>
/// </summary>
public sealed record SetRequestInterceptionResult() : EmptyResult;


internal sealed record SetUserAgentOverrideCommandParameters(string UserAgent, string? AcceptLanguage, string? Platform, Emulation.UserAgentMetadata? UserAgentMetadata) : Parameters;

/// <summary>
/// </summary>
public sealed record SetUserAgentOverrideResult() : EmptyResult;


internal sealed record StreamResourceContentCommandParameters(RequestId RequestId) : Parameters;

/// <summary>
/// </summary>
/// <param name="BufferedData">
/// Data that has been buffered until streaming is enabled. (Encoded as a base64 string when passed over JSON)
/// </param>
public sealed record StreamResourceContentResult(string BufferedData) : EmptyResult;


internal sealed record GetSecurityIsolationStatusCommandParameters(Page.FrameId? FrameId) : Parameters;

/// <summary>
/// </summary>
/// <param name="Status">
/// </param>
public sealed record GetSecurityIsolationStatusResult(SecurityIsolationStatus Status) : EmptyResult;


internal sealed record EnableReportingApiCommandParameters(bool Enable) : Parameters;

/// <summary>
/// </summary>
public sealed record EnableReportingApiResult() : EmptyResult;


internal sealed record EnableDeviceBoundSessionsCommandParameters(bool Enable) : Parameters;

/// <summary>
/// </summary>
public sealed record EnableDeviceBoundSessionsResult() : EmptyResult;


internal sealed record DeleteDeviceBoundSessionCommandParameters(DeviceBoundSessionKey Key) : Parameters;

/// <summary>
/// </summary>
public sealed record DeleteDeviceBoundSessionResult() : EmptyResult;


internal sealed record FetchSchemefulSiteCommandParameters(string Origin) : Parameters;

/// <summary>
/// </summary>
/// <param name="SchemefulSite">
/// The corresponding schemeful site.
/// </param>
public sealed record FetchSchemefulSiteResult(string SchemefulSite) : EmptyResult;


internal sealed record LoadNetworkResourceCommandParameters(Page.FrameId? FrameId, string Url, LoadNetworkResourceOptions Options) : Parameters;

/// <summary>
/// </summary>
/// <param name="Resource">
/// </param>
public sealed record LoadNetworkResourceResult(LoadNetworkResourcePageResult Resource) : EmptyResult;


internal sealed record SetCookieControlsCommandParameters(bool EnableThirdPartyCookieRestriction) : Parameters;

/// <summary>
/// </summary>
public sealed record SetCookieControlsResult() : EmptyResult;


/// <summary>
/// Fired when data chunk was received over the network.
/// </summary>
/// <param name="RequestId">
/// Request identifier.
/// </param>
/// <param name="Timestamp">
/// Timestamp.
/// </param>
/// <param name="DataLength">
/// Data chunk length.
/// </param>
/// <param name="EncodedDataLength">
/// Actual bytes received (might be less than dataLength for compressed encodings).
/// </param>
/// <param name="Data">
/// Data that was received. (Encoded as a base64 string when passed over JSON)
/// </param>
public sealed record DataReceivedEventArgs(RequestId RequestId, MonotonicTime Timestamp, long DataLength, long EncodedDataLength, string? Data = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when EventSource message is received.
/// </summary>
/// <param name="RequestId">
/// Request identifier.
/// </param>
/// <param name="Timestamp">
/// Timestamp.
/// </param>
/// <param name="EventName">
/// Message type.
/// </param>
/// <param name="EventId">
/// Message identifier.
/// </param>
/// <param name="Data">
/// Message content.
/// </param>
public sealed record EventSourceMessageReceivedEventArgs(RequestId RequestId, MonotonicTime Timestamp, string EventName, string EventId, string Data) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when HTTP request has failed to load.
/// </summary>
/// <param name="RequestId">
/// Request identifier.
/// </param>
/// <param name="Timestamp">
/// Timestamp.
/// </param>
/// <param name="Type">
/// Resource type.
/// </param>
/// <param name="ErrorText">
/// Error message. List of network errors: https://cs.chromium.org/chromium/src/net/base/net_error_list.h
/// </param>
/// <param name="Canceled">
/// True if loading was canceled.
/// </param>
/// <param name="BlockedReason">
/// The reason why loading was blocked, if any.
/// </param>
/// <param name="CorsErrorStatus">
/// The reason why loading was blocked by CORS, if any.
/// </param>
public sealed record LoadingFailedEventArgs(RequestId RequestId, MonotonicTime Timestamp, ResourceType Type, string ErrorText, bool? Canceled = null, BlockedReason? BlockedReason = null, CorsErrorStatus? CorsErrorStatus = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when HTTP request has finished loading.
/// </summary>
/// <param name="RequestId">
/// Request identifier.
/// </param>
/// <param name="Timestamp">
/// Timestamp.
/// </param>
/// <param name="EncodedDataLength">
/// Total number of bytes received for this request.
/// </param>
public sealed record LoadingFinishedEventArgs(RequestId RequestId, MonotonicTime Timestamp, double EncodedDataLength) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Details of an intercepted HTTP request, which must be either allowed, blocked, modified or
/// mocked.
/// Deprecated, use Fetch.requestPaused instead.
/// </summary>
/// <param name="InterceptionId">
/// Each request the page makes will have a unique id, however if any redirects are encountered
/// while processing that fetch, they will be reported with the same id as the original fetch.
/// Likewise if HTTP authentication is needed then the same fetch id will be used.
/// </param>
/// <param name="Request">
/// </param>
/// <param name="FrameId">
/// The id of the frame that initiated the request.
/// </param>
/// <param name="ResourceType">
/// How the requested resource will be used.
/// </param>
/// <param name="IsNavigationRequest">
/// Whether this is a navigation request, which can abort the navigation completely.
/// </param>
/// <param name="IsDownload">
/// Set if the request is a navigation that will result in a download.
/// Only present after response is received from the server (i.e. HeadersReceived stage).
/// </param>
/// <param name="RedirectUrl">
/// Redirect location, only sent if a redirect was intercepted.
/// </param>
/// <param name="AuthChallenge">
/// Details of the Authorization Challenge encountered. If this is set then
/// continueInterceptedRequest must contain an authChallengeResponse.
/// </param>
/// <param name="ResponseErrorReason">
/// Response error if intercepted at response stage or if redirect occurred while intercepting
/// request.
/// </param>
/// <param name="ResponseStatusCode">
/// Response code if intercepted at response stage or if redirect occurred while intercepting
/// request or auth retry occurred.
/// </param>
/// <param name="ResponseHeaders">
/// Response headers if intercepted at the response stage or if redirect occurred while
/// intercepting request or auth retry occurred.
/// </param>
/// <param name="RequestId">
/// If the intercepted request had a corresponding requestWillBeSent event fired for it, then
/// this requestId will be the same as the requestId present in the requestWillBeSent event.
/// </param>
public sealed record RequestInterceptedEventArgs(InterceptionId InterceptionId, Request Request, Page.FrameId FrameId, ResourceType ResourceType, bool IsNavigationRequest, bool? IsDownload = null, string? RedirectUrl = null, AuthChallenge? AuthChallenge = null, ErrorReason? ResponseErrorReason = null, long? ResponseStatusCode = null, global::System.Collections.Generic.IReadOnlyDictionary<string, string>? ResponseHeaders = null, RequestId? RequestId = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired if request ended up loading from cache.
/// </summary>
/// <param name="RequestId">
/// Request identifier.
/// </param>
public sealed record RequestServedFromCacheEventArgs(RequestId RequestId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when page is about to send HTTP request.
/// </summary>
/// <param name="RequestId">
/// Request identifier.
/// </param>
/// <param name="LoaderId">
/// Loader identifier. Empty string if the request is fetched from worker.
/// </param>
/// <param name="DocumentURL">
/// URL of the document this request is loaded for.
/// </param>
/// <param name="Request">
/// Request data.
/// </param>
/// <param name="Timestamp">
/// Timestamp.
/// </param>
/// <param name="WallTime">
/// Timestamp.
/// </param>
/// <param name="Initiator">
/// Request initiator.
/// </param>
/// <param name="RedirectHasExtraInfo">
/// In the case that redirectResponse is populated, this flag indicates whether
/// requestWillBeSentExtraInfo and responseReceivedExtraInfo events will be or were emitted
/// for the request which was just redirected.
/// </param>
/// <param name="RedirectResponse">
/// Redirect response data.
/// </param>
/// <param name="Type">
/// Type of this resource.
/// </param>
/// <param name="FrameId">
/// Frame identifier.
/// </param>
/// <param name="HasUserGesture">
/// Whether the request is initiated by a user gesture. Defaults to false.
/// </param>
/// <param name="RenderBlockingBehavior">
/// The render-blocking behavior of the request.
/// </param>
public sealed record RequestWillBeSentEventArgs(RequestId RequestId, LoaderId LoaderId, string DocumentURL, Request Request, MonotonicTime Timestamp, TimeSinceEpoch WallTime, Initiator Initiator, bool RedirectHasExtraInfo, Response? RedirectResponse = null, ResourceType? Type = null, Page.FrameId? FrameId = null, bool? HasUserGesture = null, RenderBlockingBehavior? RenderBlockingBehavior = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when resource loading priority is changed
/// </summary>
/// <param name="RequestId">
/// Request identifier.
/// </param>
/// <param name="NewPriority">
/// New priority
/// </param>
/// <param name="Timestamp">
/// Timestamp.
/// </param>
public sealed record ResourceChangedPriorityEventArgs(RequestId RequestId, ResourcePriority NewPriority, MonotonicTime Timestamp) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when a signed exchange was received over the network
/// </summary>
/// <param name="RequestId">
/// Request identifier.
/// </param>
/// <param name="Info">
/// Information about the signed exchange response.
/// </param>
public sealed record SignedExchangeReceivedEventArgs(RequestId RequestId, SignedExchangeInfo Info) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when HTTP response is available.
/// </summary>
/// <param name="RequestId">
/// Request identifier.
/// </param>
/// <param name="LoaderId">
/// Loader identifier. Empty string if the request is fetched from worker.
/// </param>
/// <param name="Timestamp">
/// Timestamp.
/// </param>
/// <param name="Type">
/// Resource type.
/// </param>
/// <param name="Response">
/// Response data.
/// </param>
/// <param name="HasExtraInfo">
/// Indicates whether requestWillBeSentExtraInfo and responseReceivedExtraInfo events will be
/// or were emitted for this request.
/// </param>
/// <param name="FrameId">
/// Frame identifier.
/// </param>
public sealed record ResponseReceivedEventArgs(RequestId RequestId, LoaderId LoaderId, MonotonicTime Timestamp, ResourceType Type, Response Response, bool HasExtraInfo, Page.FrameId? FrameId = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when WebSocket is closed.
/// </summary>
/// <param name="RequestId">
/// Request identifier.
/// </param>
/// <param name="Timestamp">
/// Timestamp.
/// </param>
public sealed record WebSocketClosedEventArgs(RequestId RequestId, MonotonicTime Timestamp) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired upon WebSocket creation.
/// </summary>
/// <param name="RequestId">
/// Request identifier.
/// </param>
/// <param name="Url">
/// WebSocket request URL.
/// </param>
/// <param name="Initiator">
/// Request initiator.
/// </param>
public sealed record WebSocketCreatedEventArgs(RequestId RequestId, string Url, Initiator? Initiator = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when WebSocket message error occurs.
/// </summary>
/// <param name="RequestId">
/// Request identifier.
/// </param>
/// <param name="Timestamp">
/// Timestamp.
/// </param>
/// <param name="ErrorMessage">
/// WebSocket error message.
/// </param>
public sealed record WebSocketFrameErrorEventArgs(RequestId RequestId, MonotonicTime Timestamp, string ErrorMessage) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when WebSocket message is received.
/// </summary>
/// <param name="RequestId">
/// Request identifier.
/// </param>
/// <param name="Timestamp">
/// Timestamp.
/// </param>
/// <param name="Response">
/// WebSocket response data.
/// </param>
public sealed record WebSocketFrameReceivedEventArgs(RequestId RequestId, MonotonicTime Timestamp, WebSocketFrame Response) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when WebSocket message is sent.
/// </summary>
/// <param name="RequestId">
/// Request identifier.
/// </param>
/// <param name="Timestamp">
/// Timestamp.
/// </param>
/// <param name="Response">
/// WebSocket response data.
/// </param>
public sealed record WebSocketFrameSentEventArgs(RequestId RequestId, MonotonicTime Timestamp, WebSocketFrame Response) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when WebSocket handshake response becomes available.
/// </summary>
/// <param name="RequestId">
/// Request identifier.
/// </param>
/// <param name="Timestamp">
/// Timestamp.
/// </param>
/// <param name="Response">
/// WebSocket response data.
/// </param>
public sealed record WebSocketHandshakeResponseReceivedEventArgs(RequestId RequestId, MonotonicTime Timestamp, WebSocketResponse Response) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when WebSocket is about to initiate handshake.
/// </summary>
/// <param name="RequestId">
/// Request identifier.
/// </param>
/// <param name="Timestamp">
/// Timestamp.
/// </param>
/// <param name="WallTime">
/// UTC Timestamp.
/// </param>
/// <param name="Request">
/// WebSocket request data.
/// </param>
public sealed record WebSocketWillSendHandshakeRequestEventArgs(RequestId RequestId, MonotonicTime Timestamp, TimeSinceEpoch WallTime, WebSocketRequest Request) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired upon WebTransport creation.
/// </summary>
/// <param name="TransportId">
/// WebTransport identifier.
/// </param>
/// <param name="Url">
/// WebTransport request URL.
/// </param>
/// <param name="Timestamp">
/// Timestamp.
/// </param>
/// <param name="Initiator">
/// Request initiator.
/// </param>
public sealed record WebTransportCreatedEventArgs(RequestId TransportId, string Url, MonotonicTime Timestamp, Initiator? Initiator = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when WebTransport handshake is finished.
/// </summary>
/// <param name="TransportId">
/// WebTransport identifier.
/// </param>
/// <param name="Timestamp">
/// Timestamp.
/// </param>
public sealed record WebTransportConnectionEstablishedEventArgs(RequestId TransportId, MonotonicTime Timestamp) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when WebTransport is disposed.
/// </summary>
/// <param name="TransportId">
/// WebTransport identifier.
/// </param>
/// <param name="Timestamp">
/// Timestamp.
/// </param>
public sealed record WebTransportClosedEventArgs(RequestId TransportId, MonotonicTime Timestamp) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired upon direct_socket.TCPSocket creation.
/// </summary>
/// <param name="Identifier">
/// </param>
/// <param name="RemoteAddr">
/// </param>
/// <param name="RemotePort">
/// Unsigned int 16.
/// </param>
/// <param name="Options">
/// </param>
/// <param name="Timestamp">
/// </param>
/// <param name="Initiator">
/// </param>
public sealed record DirectTCPSocketCreatedEventArgs(RequestId Identifier, string RemoteAddr, long RemotePort, DirectTCPSocketOptions Options, MonotonicTime Timestamp, Initiator? Initiator = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when direct_socket.TCPSocket connection is opened.
/// </summary>
/// <param name="Identifier">
/// </param>
/// <param name="RemoteAddr">
/// </param>
/// <param name="RemotePort">
/// Expected to be unsigned integer.
/// </param>
/// <param name="Timestamp">
/// </param>
/// <param name="LocalAddr">
/// </param>
/// <param name="LocalPort">
/// Expected to be unsigned integer.
/// </param>
public sealed record DirectTCPSocketOpenedEventArgs(RequestId Identifier, string RemoteAddr, long RemotePort, MonotonicTime Timestamp, string? LocalAddr = null, long? LocalPort = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when direct_socket.TCPSocket is aborted.
/// </summary>
/// <param name="Identifier">
/// </param>
/// <param name="ErrorMessage">
/// </param>
/// <param name="Timestamp">
/// </param>
public sealed record DirectTCPSocketAbortedEventArgs(RequestId Identifier, string ErrorMessage, MonotonicTime Timestamp) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when direct_socket.TCPSocket is closed.
/// </summary>
/// <param name="Identifier">
/// </param>
/// <param name="Timestamp">
/// </param>
public sealed record DirectTCPSocketClosedEventArgs(RequestId Identifier, MonotonicTime Timestamp) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when data is sent to tcp direct socket stream.
/// </summary>
/// <param name="Identifier">
/// </param>
/// <param name="Data">
/// </param>
/// <param name="Timestamp">
/// </param>
public sealed record DirectTCPSocketChunkSentEventArgs(RequestId Identifier, string Data, MonotonicTime Timestamp) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when data is received from tcp direct socket stream.
/// </summary>
/// <param name="Identifier">
/// </param>
/// <param name="Data">
/// </param>
/// <param name="Timestamp">
/// </param>
public sealed record DirectTCPSocketChunkReceivedEventArgs(RequestId Identifier, string Data, MonotonicTime Timestamp) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
/// <param name="Identifier">
/// </param>
/// <param name="IPAddress">
/// </param>
public sealed record DirectUDPSocketJoinedMulticastGroupEventArgs(RequestId Identifier, string IPAddress) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
/// <param name="Identifier">
/// </param>
/// <param name="IPAddress">
/// </param>
public sealed record DirectUDPSocketLeftMulticastGroupEventArgs(RequestId Identifier, string IPAddress) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired upon direct_socket.UDPSocket creation.
/// </summary>
/// <param name="Identifier">
/// </param>
/// <param name="Options">
/// </param>
/// <param name="Timestamp">
/// </param>
/// <param name="Initiator">
/// </param>
public sealed record DirectUDPSocketCreatedEventArgs(RequestId Identifier, DirectUDPSocketOptions Options, MonotonicTime Timestamp, Initiator? Initiator = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when direct_socket.UDPSocket connection is opened.
/// </summary>
/// <param name="Identifier">
/// </param>
/// <param name="LocalAddr">
/// </param>
/// <param name="LocalPort">
/// Expected to be unsigned integer.
/// </param>
/// <param name="Timestamp">
/// </param>
/// <param name="RemoteAddr">
/// </param>
/// <param name="RemotePort">
/// Expected to be unsigned integer.
/// </param>
public sealed record DirectUDPSocketOpenedEventArgs(RequestId Identifier, string LocalAddr, long LocalPort, MonotonicTime Timestamp, string? RemoteAddr = null, long? RemotePort = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when direct_socket.UDPSocket is aborted.
/// </summary>
/// <param name="Identifier">
/// </param>
/// <param name="ErrorMessage">
/// </param>
/// <param name="Timestamp">
/// </param>
public sealed record DirectUDPSocketAbortedEventArgs(RequestId Identifier, string ErrorMessage, MonotonicTime Timestamp) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when direct_socket.UDPSocket is closed.
/// </summary>
/// <param name="Identifier">
/// </param>
/// <param name="Timestamp">
/// </param>
public sealed record DirectUDPSocketClosedEventArgs(RequestId Identifier, MonotonicTime Timestamp) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when message is sent to udp direct socket stream.
/// </summary>
/// <param name="Identifier">
/// </param>
/// <param name="Message">
/// </param>
/// <param name="Timestamp">
/// </param>
public sealed record DirectUDPSocketChunkSentEventArgs(RequestId Identifier, DirectUDPMessage Message, MonotonicTime Timestamp) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when message is received from udp direct socket stream.
/// </summary>
/// <param name="Identifier">
/// </param>
/// <param name="Message">
/// </param>
/// <param name="Timestamp">
/// </param>
public sealed record DirectUDPSocketChunkReceivedEventArgs(RequestId Identifier, DirectUDPMessage Message, MonotonicTime Timestamp) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when additional information about a requestWillBeSent event is available from the
/// network stack. Not every requestWillBeSent event will have an additional
/// requestWillBeSentExtraInfo fired for it, and there is no guarantee whether requestWillBeSent
/// or requestWillBeSentExtraInfo will be fired first for the same request.
/// </summary>
/// <param name="RequestId">
/// Request identifier. Used to match this information to an existing requestWillBeSent event.
/// </param>
/// <param name="AssociatedCookies">
/// A list of cookies potentially associated to the requested URL. This includes both cookies sent with
/// the request and the ones not sent; the latter are distinguished by having blockedReasons field set.
/// </param>
/// <param name="Headers">
/// Raw request headers as they will be sent over the wire.
/// </param>
/// <param name="ConnectTiming">
/// Connection timing information for the request.
/// </param>
/// <param name="DeviceBoundSessionUsages">
/// How the request site's device bound sessions were used during this request.
/// </param>
/// <param name="ClientSecurityState">
/// The client security state set for the request.
/// </param>
/// <param name="SiteHasCookieInOtherPartition">
/// Whether the site has partitioned cookies stored in a partition different than the current one.
/// </param>
/// <param name="AppliedNetworkConditionsId">
/// The network conditions id if this request was affected by network conditions configured via
/// emulateNetworkConditionsByRule.
/// </param>
public sealed record RequestWillBeSentExtraInfoEventArgs(RequestId RequestId, ImmutableArray<AssociatedCookie> AssociatedCookies, global::System.Collections.Generic.IReadOnlyDictionary<string, string> Headers, ConnectTiming ConnectTiming, ImmutableArray<DeviceBoundSessionWithUsage>? DeviceBoundSessionUsages = null, ClientSecurityState? ClientSecurityState = null, bool? SiteHasCookieInOtherPartition = null, string? AppliedNetworkConditionsId = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when additional information about a responseReceived event is available from the network
/// stack. Not every responseReceived event will have an additional responseReceivedExtraInfo for
/// it, and responseReceivedExtraInfo may be fired before or after responseReceived.
/// </summary>
/// <param name="RequestId">
/// Request identifier. Used to match this information to another responseReceived event.
/// </param>
/// <param name="BlockedCookies">
/// A list of cookies which were not stored from the response along with the corresponding
/// reasons for blocking. The cookies here may not be valid due to syntax errors, which
/// are represented by the invalid cookie line string instead of a proper cookie.
/// </param>
/// <param name="Headers">
/// Raw response headers as they were received over the wire.
/// Duplicate headers in the response are represented as a single key with their values
/// concatentated using <b>\n</b> as the separator.
/// See also <b>headersText</b> that contains verbatim text for HTTP/1.*.
/// </param>
/// <param name="ResourceIPAddressSpace">
/// The IP address space of the resource. The address space can only be determined once the transport
/// established the connection, so we can't send it in <b>requestWillBeSentExtraInfo</b>.
/// </param>
/// <param name="StatusCode">
/// The status code of the response. This is useful in cases the request failed and no responseReceived
/// event is triggered, which is the case for, e.g., CORS errors. This is also the correct status code
/// for cached requests, where the status in responseReceived is a 200 and this will be 304.
/// </param>
/// <param name="HeadersText">
/// Raw response header text as it was received over the wire. The raw text may not always be
/// available, such as in the case of HTTP/2 or QUIC.
/// </param>
/// <param name="CookiePartitionKey">
/// The cookie partition key that will be used to store partitioned cookies set in this response.
/// Only sent when partitioned cookies are enabled.
/// </param>
/// <param name="CookiePartitionKeyOpaque">
/// True if partitioned cookies are enabled, but the partition key is not serializable to string.
/// </param>
/// <param name="ExemptedCookies">
/// A list of cookies which should have been blocked by 3PCD but are exempted and stored from
/// the response with the corresponding reason.
/// </param>
public sealed record ResponseReceivedExtraInfoEventArgs(RequestId RequestId, ImmutableArray<BlockedSetCookieWithReason> BlockedCookies, global::System.Collections.Generic.IReadOnlyDictionary<string, string> Headers, IPAddressSpace ResourceIPAddressSpace, long StatusCode, string? HeadersText = null, CookiePartitionKey? CookiePartitionKey = null, bool? CookiePartitionKeyOpaque = null, ImmutableArray<ExemptedSetCookieWithReason>? ExemptedCookies = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when 103 Early Hints headers is received in addition to the common response.
/// Not every responseReceived event will have an responseReceivedEarlyHints fired.
/// Only one responseReceivedEarlyHints may be fired for eached responseReceived event.
/// </summary>
/// <param name="RequestId">
/// Request identifier. Used to match this information to another responseReceived event.
/// </param>
/// <param name="Headers">
/// Raw response headers as they were received over the wire.
/// Duplicate headers in the response are represented as a single key with their values
/// concatentated using <b>\n</b> as the separator.
/// See also <b>headersText</b> that contains verbatim text for HTTP/1.*.
/// </param>
public sealed record ResponseReceivedEarlyHintsEventArgs(RequestId RequestId, global::System.Collections.Generic.IReadOnlyDictionary<string, string> Headers) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired exactly once for each Trust Token operation. Depending on
/// the type of the operation and whether the operation succeeded or
/// failed, the event is fired before the corresponding request was sent
/// or after the response was received.
/// </summary>
/// <param name="Status">
/// Detailed success or error status of the operation.
/// 'AlreadyExists' also signifies a successful operation, as the result
/// of the operation already exists und thus, the operation was abort
/// preemptively (e.g. a cache hit).
/// </param>
/// <param name="Type">
/// </param>
/// <param name="RequestId">
/// </param>
/// <param name="TopLevelOrigin">
/// Top level origin. The context in which the operation was attempted.
/// </param>
/// <param name="IssuerOrigin">
/// Origin of the issuer in case of a "Issuance" or "Redemption" operation.
/// </param>
/// <param name="IssuedTokenCount">
/// The number of obtained Trust Tokens on a successful "Issuance" operation.
/// </param>
public sealed record TrustTokenOperationDoneEventArgs(string Status, TrustTokenOperationType Type, RequestId RequestId, string? TopLevelOrigin = null, string? IssuerOrigin = null, long? IssuedTokenCount = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired once security policy has been updated.
/// </summary>
public sealed record PolicyUpdatedEventArgs() : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Is sent whenever a new report is added.
/// And after 'enableReportingApi' for all existing reports.
/// </summary>
/// <param name="Report">
/// </param>
public sealed record ReportingApiReportAddedEventArgs(ReportingApiReport Report) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
/// <param name="Report">
/// </param>
public sealed record ReportingApiReportUpdatedEventArgs(ReportingApiReport Report) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
/// <param name="Origin">
/// Origin of the document(s) which configured the endpoints.
/// </param>
/// <param name="Endpoints">
/// </param>
public sealed record ReportingApiEndpointsChangedForOriginEventArgs(string Origin, ImmutableArray<ReportingApiEndpoint> Endpoints) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Triggered when the initial set of device bound sessions is added.
/// </summary>
/// <param name="Sessions">
/// The device bound sessions.
/// </param>
public sealed record DeviceBoundSessionsAddedEventArgs(ImmutableArray<DeviceBoundSession> Sessions) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Triggered when a device bound session event occurs.
/// </summary>
/// <param name="EventId">
/// A unique identifier for this session event.
/// </param>
/// <param name="Site">
/// The site this session event is associated with.
/// </param>
/// <param name="Succeeded">
/// Whether this event was considered successful.
/// </param>
/// <param name="SessionId">
/// The session ID this event is associated with. May not be populated for
/// failed events.
/// </param>
/// <param name="CreationEventDetails">
/// The below are the different session event type details. Exactly one is populated.
/// </param>
/// <param name="RefreshEventDetails">
/// </param>
/// <param name="TerminationEventDetails">
/// </param>
/// <param name="ChallengeEventDetails">
/// </param>
public sealed record DeviceBoundSessionEventOccurredEventArgs(DeviceBoundSessionEventId EventId, string Site, bool Succeeded, string? SessionId = null, CreationEventDetails? CreationEventDetails = null, RefreshEventDetails? RefreshEventDetails = null, TerminationEventDetails? TerminationEventDetails = null, ChallengeEventDetails? ChallengeEventDetails = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Resource type as it was perceived by the rendering engine.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ResourceType>))]
public enum ResourceType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Document")]
    Document,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Stylesheet")]
    Stylesheet,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Image")]
    Image,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Media")]
    Media,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Font")]
    Font,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Script")]
    Script,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TextTrack")]
    TextTrack,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("XHR")]
    XHR,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Fetch")]
    Fetch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Prefetch")]
    Prefetch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EventSource")]
    EventSource,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WebSocket")]
    WebSocket,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Manifest")]
    Manifest,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignedExchange")]
    SignedExchange,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Ping")]
    Ping,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CSPViolationReport")]
    CSPViolationReport,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Preflight")]
    Preflight,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FedCM")]
    FedCM,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Other")]
    Other,
}

/// <summary>
/// Unique loader identifier.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<LoaderId>))]
public record LoaderId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Unique network request identifier.
/// Note that this does not identify individual HTTP requests that are part of
/// a network request.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<RequestId>))]
public record RequestId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Unique intercepted request identifier.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<InterceptionId>))]
public record InterceptionId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Network level fetch failure reason.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ErrorReason>))]
public enum ErrorReason
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Failed")]
    Failed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Aborted")]
    Aborted,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TimedOut")]
    TimedOut,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AccessDenied")]
    AccessDenied,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ConnectionClosed")]
    ConnectionClosed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ConnectionReset")]
    ConnectionReset,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ConnectionRefused")]
    ConnectionRefused,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ConnectionAborted")]
    ConnectionAborted,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ConnectionFailed")]
    ConnectionFailed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NameNotResolved")]
    NameNotResolved,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InternetDisconnected")]
    InternetDisconnected,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AddressUnreachable")]
    AddressUnreachable,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BlockedByClient")]
    BlockedByClient,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BlockedByResponse")]
    BlockedByResponse,
}

/// <summary>
/// UTC time in seconds, counted from January 1, 1970.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.NumberRemoteIdConverter<TimeSinceEpoch>))]
public record TimeSinceEpoch : INumberRemoteId
{
    double INumberRemoteId.Id { get; init; }
}

/// <summary>
/// Monotonically increasing time in seconds since an arbitrary point in the past.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.NumberRemoteIdConverter<MonotonicTime>))]
public record MonotonicTime : INumberRemoteId
{
    double INumberRemoteId.Id { get; init; }
}

/// <summary>
/// Request / response headers as keys / values of JSON object.
/// </summary>

/// <summary>
/// The underlying connection technology that the browser is supposedly using.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ConnectionType>))]
public enum ConnectionType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("none")]
    None,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("cellular2g")]
    Cellular2g,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("cellular3g")]
    Cellular3g,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("cellular4g")]
    Cellular4g,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("bluetooth")]
    Bluetooth,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ethernet")]
    Ethernet,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("wifi")]
    Wifi,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("wimax")]
    Wimax,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("other")]
    Other,
}

/// <summary>
/// Represents the cookie's 'SameSite' status:
/// https://tools.ietf.org/html/draft-west-first-party-cookies
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<CookieSameSite>))]
public enum CookieSameSite
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Strict")]
    Strict,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Lax")]
    Lax,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("None")]
    None,
}

/// <summary>
/// Represents the cookie's 'Priority' status:
/// https://tools.ietf.org/html/draft-west-cookie-priority-00
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<CookiePriority>))]
public enum CookiePriority
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Low")]
    Low,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Medium")]
    Medium,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("High")]
    High,
}

/// <summary>
/// Represents the source scheme of the origin that originally set the cookie.
/// A value of "Unset" allows protocol clients to emulate legacy cookie scope for the scheme.
/// This is a temporary ability and it will be removed in the future.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<CookieSourceScheme>))]
public enum CookieSourceScheme
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Unset")]
    Unset,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NonSecure")]
    NonSecure,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Secure")]
    Secure,
}

/// <summary>
/// Timing information for the request.
/// </summary>
/// <param name="RequestTime">
/// Timing's requestTime is a baseline in seconds, while the other numbers are ticks in
/// milliseconds relatively to this requestTime.
/// </param>
/// <param name="ProxyStart">
/// Started resolving proxy.
/// </param>
/// <param name="ProxyEnd">
/// Finished resolving proxy.
/// </param>
/// <param name="DnsStart">
/// Started DNS address resolve.
/// </param>
/// <param name="DnsEnd">
/// Finished DNS address resolve.
/// </param>
/// <param name="ConnectStart">
/// Started connecting to the remote host.
/// </param>
/// <param name="ConnectEnd">
/// Connected to the remote host.
/// </param>
/// <param name="SslStart">
/// Started SSL handshake.
/// </param>
/// <param name="SslEnd">
/// Finished SSL handshake.
/// </param>
/// <param name="WorkerStart">
/// Started running ServiceWorker.
/// </param>
/// <param name="WorkerReady">
/// Finished Starting ServiceWorker.
/// </param>
/// <param name="WorkerFetchStart">
/// Started fetch event.
/// </param>
/// <param name="WorkerRespondWithSettled">
/// Settled fetch event respondWith promise.
/// </param>
/// <param name="SendStart">
/// Started sending request.
/// </param>
/// <param name="SendEnd">
/// Finished sending request.
/// </param>
/// <param name="PushStart">
/// Time the server started pushing request.
/// </param>
/// <param name="PushEnd">
/// Time the server finished pushing request.
/// </param>
/// <param name="ReceiveHeadersStart">
/// Started receiving response headers.
/// </param>
/// <param name="ReceiveHeadersEnd">
/// Finished receiving response headers.
/// </param>
public sealed record ResourceTiming(double RequestTime, double ProxyStart, double ProxyEnd, double DnsStart, double DnsEnd, double ConnectStart, double ConnectEnd, double SslStart, double SslEnd, double WorkerStart, double WorkerReady, double WorkerFetchStart, double WorkerRespondWithSettled, double SendStart, double SendEnd, double PushStart, double PushEnd, double ReceiveHeadersStart, double ReceiveHeadersEnd)
{
    /// <summary>
    /// Started ServiceWorker static routing source evaluation.
    /// </summary>
    public double? WorkerRouterEvaluationStart { get; init; }

    /// <summary>
    /// Started cache lookup when the source was evaluated to <b>cache</b>.
    /// </summary>
    public double? WorkerCacheLookupStart { get; init; }
}

/// <summary>
/// Loading priority of a resource request.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ResourcePriority>))]
public enum ResourcePriority
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("VeryLow")]
    VeryLow,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Low")]
    Low,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Medium")]
    Medium,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("High")]
    High,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("VeryHigh")]
    VeryHigh,
}

/// <summary>
/// The render-blocking behavior of a resource request.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<RenderBlockingBehavior>))]
public enum RenderBlockingBehavior
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Blocking")]
    Blocking,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InBodyParserBlocking")]
    InBodyParserBlocking,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NonBlocking")]
    NonBlocking,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NonBlockingDynamic")]
    NonBlockingDynamic,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PotentiallyBlocking")]
    PotentiallyBlocking,
}

/// <summary>
/// Post data entry for HTTP request
/// </summary>
public sealed record PostDataEntry()
{
    /// <summary>
    /// </summary>
    public string? Bytes { get; init; }
}

/// <summary>
/// HTTP request data.
/// </summary>
/// <param name="Url">
/// Request URL (without fragment).
/// </param>
/// <param name="Method">
/// HTTP request method.
/// </param>
/// <param name="Headers">
/// HTTP request headers.
/// </param>
/// <param name="InitialPriority">
/// Priority of the resource request at the time request is sent.
/// </param>
/// <param name="ReferrerPolicy">
/// The referrer policy of the request, as defined in https://www.w3.org/TR/referrer-policy/
/// </param>
public sealed record Request(string Url, string Method, global::System.Collections.Generic.IReadOnlyDictionary<string, string> Headers, ResourcePriority InitialPriority, string ReferrerPolicy)
{
    /// <summary>
    /// Fragment of the requested URL starting with hash, if present.
    /// </summary>
    public string? UrlFragment { get; init; }

    /// <summary>
    /// HTTP POST request data.
    /// Use postDataEntries instead.
    /// </summary>
    [global::System.Obsolete]
    public string? PostData { get; init; }

    /// <summary>
    /// True when the request has POST data. Note that postData might still be omitted when this flag is true when the data is too long.
    /// </summary>
    public bool? HasPostData { get; init; }

    /// <summary>
    /// Request body elements (post data broken into individual entries).
    /// </summary>
    public ImmutableArray<PostDataEntry>? PostDataEntries { get; init; }

    /// <summary>
    /// The mixed content type of the request.
    /// </summary>
    public Security.MixedContentType? MixedContentType { get; init; }

    /// <summary>
    /// Whether is loaded via link preload.
    /// </summary>
    public bool? IsLinkPreload { get; init; }

    /// <summary>
    /// Set for requests when the TrustToken API is used. Contains the parameters
    /// passed by the developer (e.g. via "fetch") as understood by the backend.
    /// </summary>
    public TrustTokenParams? TrustTokenParams { get; init; }

    /// <summary>
    /// True if this resource request is considered to be the 'same site' as the
    /// request corresponding to the main frame.
    /// </summary>
    public bool? IsSameSite { get; init; }

    /// <summary>
    /// True when the resource request is ad-related.
    /// </summary>
    public bool? IsAdRelated { get; init; }
}

/// <summary>
/// Details of a signed certificate timestamp (SCT).
/// </summary>
/// <param name="Status">
/// Validation status.
/// </param>
/// <param name="Origin">
/// Origin.
/// </param>
/// <param name="LogDescription">
/// Log name / description.
/// </param>
/// <param name="LogId">
/// Log ID.
/// </param>
/// <param name="Timestamp">
/// Issuance date. Unlike TimeSinceEpoch, this contains the number of
/// milliseconds since January 1, 1970, UTC, not the number of seconds.
/// </param>
/// <param name="HashAlgorithm">
/// Hash algorithm.
/// </param>
/// <param name="SignatureAlgorithm">
/// Signature algorithm.
/// </param>
/// <param name="SignatureData">
/// Signature data.
/// </param>
public sealed record SignedCertificateTimestamp(string Status, string Origin, string LogDescription, string LogId, double Timestamp, string HashAlgorithm, string SignatureAlgorithm, string SignatureData)
{
}

/// <summary>
/// Security details about a request.
/// </summary>
/// <param name="Protocol">
/// Protocol name (e.g. "TLS 1.2" or "QUIC").
/// </param>
/// <param name="KeyExchange">
/// Key Exchange used by the connection, or the empty string if not applicable.
/// </param>
/// <param name="Cipher">
/// Cipher name.
/// </param>
/// <param name="CertificateId">
/// Certificate ID value.
/// </param>
/// <param name="SubjectName">
/// Certificate subject name.
/// </param>
/// <param name="SanList">
/// Subject Alternative Name (SAN) DNS names and IP addresses.
/// </param>
/// <param name="Issuer">
/// Name of the issuing CA.
/// </param>
/// <param name="ValidFrom">
/// Certificate valid from date.
/// </param>
/// <param name="ValidTo">
/// Certificate valid to (expiration) date
/// </param>
/// <param name="SignedCertificateTimestampList">
/// List of signed certificate timestamps (SCTs).
/// </param>
/// <param name="CertificateTransparencyCompliance">
/// Whether the request complied with Certificate Transparency policy
/// </param>
/// <param name="EncryptedClientHello">
/// Whether the connection used Encrypted ClientHello
/// </param>
public sealed record SecurityDetails(string Protocol, string KeyExchange, string Cipher, Security.CertificateId CertificateId, string SubjectName, ImmutableArray<string> SanList, string Issuer, TimeSinceEpoch ValidFrom, TimeSinceEpoch ValidTo, ImmutableArray<SignedCertificateTimestamp> SignedCertificateTimestampList, CertificateTransparencyCompliance CertificateTransparencyCompliance, bool EncryptedClientHello)
{
    /// <summary>
    /// (EC)DH group used by the connection, if applicable.
    /// </summary>
    public string? KeyExchangeGroup { get; init; }

    /// <summary>
    /// TLS MAC. Note that AEAD ciphers do not have separate MACs.
    /// </summary>
    public string? Mac { get; init; }

    /// <summary>
    /// The signature algorithm used by the server in the TLS server signature,
    /// represented as a TLS SignatureScheme code point. Omitted if not
    /// applicable or not known.
    /// </summary>
    public long? ServerSignatureAlgorithm { get; init; }
}

/// <summary>
/// Whether the request complied with Certificate Transparency policy.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<CertificateTransparencyCompliance>))]
public enum CertificateTransparencyCompliance
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("unknown")]
    Unknown,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("not-compliant")]
    NotCompliant,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("compliant")]
    Compliant,
}

/// <summary>
/// The reason why request was blocked.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<BlockedReason>))]
public enum BlockedReason
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("other")]
    Other,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("csp")]
    Csp,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("mixed-content")]
    MixedContent,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("origin")]
    Origin,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("inspector")]
    Inspector,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("integrity")]
    Integrity,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("subresource-filter")]
    SubresourceFilter,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("content-type")]
    ContentType,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("coep-frame-resource-needs-coep-header")]
    CoepFrameResourceNeedsCoepHeader,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("coop-sandboxed-iframe-cannot-navigate-to-coop-page")]
    CoopSandboxedIframeCannotNavigateToCoopPage,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("corp-not-same-origin")]
    CorpNotSameOrigin,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("corp-not-same-origin-after-defaulted-to-same-origin-by-coep")]
    CorpNotSameOriginAfterDefaultedToSameOriginByCoep,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("corp-not-same-origin-after-defaulted-to-same-origin-by-dip")]
    CorpNotSameOriginAfterDefaultedToSameOriginByDip,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("corp-not-same-origin-after-defaulted-to-same-origin-by-coep-and-dip")]
    CorpNotSameOriginAfterDefaultedToSameOriginByCoepAndDip,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("corp-not-same-site")]
    CorpNotSameSite,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("sri-message-signature-mismatch")]
    SriMessageSignatureMismatch,
}

/// <summary>
/// The reason why request was blocked.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<CorsError>))]
public enum CorsError
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DisallowedByMode")]
    DisallowedByMode,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidResponse")]
    InvalidResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WildcardOriginNotAllowed")]
    WildcardOriginNotAllowed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MissingAllowOriginHeader")]
    MissingAllowOriginHeader,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MultipleAllowOriginValues")]
    MultipleAllowOriginValues,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidAllowOriginValue")]
    InvalidAllowOriginValue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AllowOriginMismatch")]
    AllowOriginMismatch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidAllowCredentials")]
    InvalidAllowCredentials,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CorsDisabledScheme")]
    CorsDisabledScheme,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PreflightInvalidStatus")]
    PreflightInvalidStatus,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PreflightDisallowedRedirect")]
    PreflightDisallowedRedirect,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PreflightWildcardOriginNotAllowed")]
    PreflightWildcardOriginNotAllowed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PreflightMissingAllowOriginHeader")]
    PreflightMissingAllowOriginHeader,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PreflightMultipleAllowOriginValues")]
    PreflightMultipleAllowOriginValues,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PreflightInvalidAllowOriginValue")]
    PreflightInvalidAllowOriginValue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PreflightAllowOriginMismatch")]
    PreflightAllowOriginMismatch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PreflightInvalidAllowCredentials")]
    PreflightInvalidAllowCredentials,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PreflightMissingAllowExternal")]
    PreflightMissingAllowExternal,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PreflightInvalidAllowExternal")]
    PreflightInvalidAllowExternal,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidAllowMethodsPreflightResponse")]
    InvalidAllowMethodsPreflightResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidAllowHeadersPreflightResponse")]
    InvalidAllowHeadersPreflightResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MethodDisallowedByPreflightResponse")]
    MethodDisallowedByPreflightResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("HeaderDisallowedByPreflightResponse")]
    HeaderDisallowedByPreflightResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RedirectContainsCredentials")]
    RedirectContainsCredentials,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InsecureLocalNetwork")]
    InsecureLocalNetwork,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidLocalNetworkAccess")]
    InvalidLocalNetworkAccess,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NoCorsRedirectModeNotFollow")]
    NoCorsRedirectModeNotFollow,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("LocalNetworkAccessPermissionDenied")]
    LocalNetworkAccessPermissionDenied,
}

/// <summary>
/// </summary>
/// <param name="CorsError">
/// </param>
/// <param name="FailedParameter">
/// </param>
public sealed record CorsErrorStatus(CorsError CorsError, string FailedParameter)
{
}

/// <summary>
/// Source of serviceworker response.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ServiceWorkerResponseSource>))]
public enum ServiceWorkerResponseSource
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("cache-storage")]
    CacheStorage,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("http-cache")]
    HttpCache,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("fallback-code")]
    FallbackCode,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("network")]
    Network,
}

/// <summary>
/// Determines what type of Trust Token operation is executed and
/// depending on the type, some additional parameters. The values
/// are specified in third_party/blink/renderer/core/fetch/trust_token.idl.
/// </summary>
/// <param name="Operation">
/// </param>
/// <param name="RefreshPolicy">
/// Only set for "token-redemption" operation and determine whether
/// to request a fresh SRR or use a still valid cached SRR.
/// </param>
public sealed record TrustTokenParams(TrustTokenOperationType Operation, string RefreshPolicy)
{
    /// <summary>
    /// Origins of issuers from whom to request tokens or redemption
    /// records.
    /// </summary>
    public ImmutableArray<string>? Issuers { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<TrustTokenOperationType>))]
public enum TrustTokenOperationType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Issuance")]
    Issuance,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Redemption")]
    Redemption,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Signing")]
    Signing,
}

/// <summary>
/// The reason why Chrome uses a specific transport protocol for HTTP semantics.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<AlternateProtocolUsage>))]
public enum AlternateProtocolUsage
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("alternativeJobWonWithoutRace")]
    AlternativeJobWonWithoutRace,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("alternativeJobWonRace")]
    AlternativeJobWonRace,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("mainJobWonRace")]
    MainJobWonRace,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("mappingMissing")]
    MappingMissing,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("broken")]
    Broken,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("dnsAlpnH3JobWonWithoutRace")]
    DnsAlpnH3JobWonWithoutRace,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("dnsAlpnH3JobWonRace")]
    DnsAlpnH3JobWonRace,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("unspecifiedReason")]
    UnspecifiedReason,
}

/// <summary>
/// Source of service worker router.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ServiceWorkerRouterSource>))]
public enum ServiceWorkerRouterSource
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("network")]
    Network,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("cache")]
    Cache,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("fetch-event")]
    FetchEvent,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("race-network-and-fetch-handler")]
    RaceNetworkAndFetchHandler,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("race-network-and-cache")]
    RaceNetworkAndCache,
}

/// <summary>
/// </summary>
public sealed record ServiceWorkerRouterInfo()
{
    /// <summary>
    /// ID of the rule matched. If there is a matched rule, this field will
    /// be set, otherwiser no value will be set.
    /// </summary>
    public long? RuleIdMatched { get; init; }

    /// <summary>
    /// The router source of the matched rule. If there is a matched rule, this
    /// field will be set, otherwise no value will be set.
    /// </summary>
    public ServiceWorkerRouterSource? MatchedSourceType { get; init; }

    /// <summary>
    /// The actual router source used.
    /// </summary>
    public ServiceWorkerRouterSource? ActualSourceType { get; init; }
}

/// <summary>
/// HTTP response data.
/// </summary>
/// <param name="Url">
/// Response URL. This URL can be different from CachedResource.url in case of redirect.
/// </param>
/// <param name="Status">
/// HTTP response status code.
/// </param>
/// <param name="StatusText">
/// HTTP response status text.
/// </param>
/// <param name="Headers">
/// HTTP response headers.
/// </param>
/// <param name="MimeType">
/// Resource mimeType as determined by the browser.
/// </param>
/// <param name="Charset">
/// Resource charset as determined by the browser (if applicable).
/// </param>
/// <param name="ConnectionReused">
/// Specifies whether physical connection was actually reused for this request.
/// </param>
/// <param name="ConnectionId">
/// Physical connection id that was actually used for this request.
/// </param>
/// <param name="EncodedDataLength">
/// Total number of bytes received for this request so far.
/// </param>
/// <param name="SecurityState">
/// Security state of the request resource.
/// </param>
public sealed record Response(string Url, long Status, string StatusText, global::System.Collections.Generic.IReadOnlyDictionary<string, string> Headers, string MimeType, string Charset, bool ConnectionReused, double ConnectionId, double EncodedDataLength, Security.SecurityState SecurityState)
{
    /// <summary>
    /// HTTP response headers text. This has been replaced by the headers in Network.responseReceivedExtraInfo.
    /// </summary>
    [global::System.Obsolete]
    public string? HeadersText { get; init; }

    /// <summary>
    /// Refined HTTP request headers that were actually transmitted over the network.
    /// </summary>
    public global::System.Collections.Generic.IReadOnlyDictionary<string, string>? RequestHeaders { get; init; }

    /// <summary>
    /// HTTP request headers text. This has been replaced by the headers in Network.requestWillBeSentExtraInfo.
    /// </summary>
    [global::System.Obsolete]
    public string? RequestHeadersText { get; init; }

    /// <summary>
    /// Remote IP address.
    /// </summary>
    public string? RemoteIPAddress { get; init; }

    /// <summary>
    /// Remote port.
    /// </summary>
    public long? RemotePort { get; init; }

    /// <summary>
    /// Specifies that the request was served from the disk cache.
    /// </summary>
    public bool? FromDiskCache { get; init; }

    /// <summary>
    /// Specifies that the request was served from the ServiceWorker.
    /// </summary>
    public bool? FromServiceWorker { get; init; }

    /// <summary>
    /// Specifies that the request was served from the prefetch cache.
    /// </summary>
    public bool? FromPrefetchCache { get; init; }

    /// <summary>
    /// Specifies that the request was served from the prefetch cache.
    /// </summary>
    public bool? FromEarlyHints { get; init; }

    /// <summary>
    /// Information about how ServiceWorker Static Router API was used. If this
    /// field is set with <b>matchedSourceType</b> field, a matching rule is found.
    /// If this field is set without <b>matchedSource</b>, no matching rule is found.
    /// Otherwise, the API is not used.
    /// </summary>
    public ServiceWorkerRouterInfo? ServiceWorkerRouterInfo { get; init; }

    /// <summary>
    /// Timing information for the given request.
    /// </summary>
    public ResourceTiming? Timing { get; init; }

    /// <summary>
    /// Response source of response from ServiceWorker.
    /// </summary>
    public ServiceWorkerResponseSource? ServiceWorkerResponseSource { get; init; }

    /// <summary>
    /// The time at which the returned response was generated.
    /// </summary>
    public TimeSinceEpoch? ResponseTime { get; init; }

    /// <summary>
    /// Cache Storage Cache Name.
    /// </summary>
    public string? CacheStorageCacheName { get; init; }

    /// <summary>
    /// Protocol used to fetch this request.
    /// </summary>
    public string? Protocol { get; init; }

    /// <summary>
    /// The reason why Chrome uses a specific transport protocol for HTTP semantics.
    /// </summary>
    public AlternateProtocolUsage? AlternateProtocolUsage { get; init; }

    /// <summary>
    /// Security details for the request.
    /// </summary>
    public SecurityDetails? SecurityDetails { get; init; }
}

/// <summary>
/// WebSocket request data.
/// </summary>
/// <param name="Headers">
/// HTTP request headers.
/// </param>
public sealed record WebSocketRequest(global::System.Collections.Generic.IReadOnlyDictionary<string, string> Headers)
{
}

/// <summary>
/// WebSocket response data.
/// </summary>
/// <param name="Status">
/// HTTP response status code.
/// </param>
/// <param name="StatusText">
/// HTTP response status text.
/// </param>
/// <param name="Headers">
/// HTTP response headers.
/// </param>
public sealed record WebSocketResponse(long Status, string StatusText, global::System.Collections.Generic.IReadOnlyDictionary<string, string> Headers)
{
    /// <summary>
    /// HTTP response headers text.
    /// </summary>
    public string? HeadersText { get; init; }

    /// <summary>
    /// HTTP request headers.
    /// </summary>
    public global::System.Collections.Generic.IReadOnlyDictionary<string, string>? RequestHeaders { get; init; }

    /// <summary>
    /// HTTP request headers text.
    /// </summary>
    public string? RequestHeadersText { get; init; }
}

/// <summary>
/// WebSocket message data. This represents an entire WebSocket message, not just a fragmented frame as the name suggests.
/// </summary>
/// <param name="Opcode">
/// WebSocket message opcode.
/// </param>
/// <param name="Mask">
/// WebSocket message mask.
/// </param>
/// <param name="PayloadData">
/// WebSocket message payload data.
/// If the opcode is 1, this is a text message and payloadData is a UTF-8 string.
/// If the opcode isn't 1, then payloadData is a base64 encoded string representing binary data.
/// </param>
public sealed record WebSocketFrame(double Opcode, bool Mask, string PayloadData)
{
}

/// <summary>
/// Information about the cached resource.
/// </summary>
/// <param name="Url">
/// Resource URL. This is the url of the original network request.
/// </param>
/// <param name="Type">
/// Type of this resource.
/// </param>
/// <param name="BodySize">
/// Cached response body size.
/// </param>
public sealed record CachedResource(string Url, ResourceType Type, double BodySize)
{
    /// <summary>
    /// Cached response data.
    /// </summary>
    public Response? Response { get; init; }
}

/// <summary>
/// Information about the request initiator.
/// </summary>
/// <param name="Type">
/// Type of this initiator.
/// </param>
public sealed record Initiator(string Type)
{
    /// <summary>
    /// Initiator JavaScript stack trace, set for Script only.
    /// Requires the Debugger domain to be enabled.
    /// </summary>
    public Runtime.StackTrace? Stack { get; init; }

    /// <summary>
    /// Initiator URL, set for Parser type or for Script type (when script is importing module) or for SignedExchange type.
    /// </summary>
    public string? Url { get; init; }

    /// <summary>
    /// Initiator line number, set for Parser type or for Script type (when script is importing
    /// module) (0-based).
    /// </summary>
    public double? LineNumber { get; init; }

    /// <summary>
    /// Initiator column number, set for Parser type or for Script type (when script is importing
    /// module) (0-based).
    /// </summary>
    public double? ColumnNumber { get; init; }

    /// <summary>
    /// Set if another request triggered this request (e.g. preflight).
    /// </summary>
    public RequestId? RequestId { get; init; }
}

/// <summary>
/// cookiePartitionKey object
/// The representation of the components of the key that are created by the cookiePartitionKey class contained in net/cookies/cookie_partition_key.h.
/// </summary>
/// <param name="TopLevelSite">
/// The site of the top-level URL the browser was visiting at the start
/// of the request to the endpoint that set the cookie.
/// </param>
/// <param name="HasCrossSiteAncestor">
/// Indicates if the cookie has any ancestors that are cross-site to the topLevelSite.
/// </param>
public sealed record CookiePartitionKey(string TopLevelSite, bool HasCrossSiteAncestor)
{
}

/// <summary>
/// Cookie object
/// </summary>
/// <param name="Name">
/// Cookie name.
/// </param>
/// <param name="Value">
/// Cookie value.
/// </param>
/// <param name="Domain">
/// Cookie domain.
/// </param>
/// <param name="Path">
/// Cookie path.
/// </param>
/// <param name="Expires">
/// Cookie expiration date as the number of seconds since the UNIX epoch.
/// The value is set to -1 if the expiry date is not set.
/// The value can be null for values that cannot be represented in
/// JSON (±Inf).
/// </param>
/// <param name="Size">
/// Cookie size.
/// </param>
/// <param name="HttpOnly">
/// True if cookie is http-only.
/// </param>
/// <param name="Secure">
/// True if cookie is secure.
/// </param>
/// <param name="Session">
/// True in case of session cookie.
/// </param>
/// <param name="Priority">
/// Cookie Priority
/// </param>
/// <param name="SourceScheme">
/// Cookie source scheme type.
/// </param>
/// <param name="SourcePort">
/// Cookie source port. Valid values are {-1, [1, 65535]}, -1 indicates an unspecified port.
/// An unspecified port value allows protocol clients to emulate legacy cookie scope for the port.
/// This is a temporary ability and it will be removed in the future.
/// </param>
public sealed record Cookie(string Name, string Value, string Domain, string Path, double Expires, long Size, bool HttpOnly, bool Secure, bool Session, CookiePriority Priority, CookieSourceScheme SourceScheme, long SourcePort)
{
    /// <summary>
    /// Cookie SameSite type.
    /// </summary>
    public CookieSameSite? SameSite { get; init; }

    /// <summary>
    /// Cookie partition key.
    /// </summary>
    public CookiePartitionKey? PartitionKey { get; init; }

    /// <summary>
    /// True if cookie partition key is opaque.
    /// </summary>
    public bool? PartitionKeyOpaque { get; init; }
}

/// <summary>
/// Types of reasons why a cookie may not be stored from a response.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<SetCookieBlockedReason>))]
public enum SetCookieBlockedReason
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SecureOnly")]
    SecureOnly,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SameSiteStrict")]
    SameSiteStrict,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SameSiteLax")]
    SameSiteLax,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SameSiteUnspecifiedTreatedAsLax")]
    SameSiteUnspecifiedTreatedAsLax,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SameSiteNoneInsecure")]
    SameSiteNoneInsecure,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UserPreferences")]
    UserPreferences,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ThirdPartyPhaseout")]
    ThirdPartyPhaseout,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ThirdPartyBlockedInFirstPartySet")]
    ThirdPartyBlockedInFirstPartySet,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SyntaxError")]
    SyntaxError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SchemeNotSupported")]
    SchemeNotSupported,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("OverwriteSecure")]
    OverwriteSecure,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidDomain")]
    InvalidDomain,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidPrefix")]
    InvalidPrefix,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UnknownError")]
    UnknownError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SchemefulSameSiteStrict")]
    SchemefulSameSiteStrict,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SchemefulSameSiteLax")]
    SchemefulSameSiteLax,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SchemefulSameSiteUnspecifiedTreatedAsLax")]
    SchemefulSameSiteUnspecifiedTreatedAsLax,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NameValuePairExceedsMaxSize")]
    NameValuePairExceedsMaxSize,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DisallowedCharacter")]
    DisallowedCharacter,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NoCookieContent")]
    NoCookieContent,
}

/// <summary>
/// Types of reasons why a cookie may not be sent with a request.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<CookieBlockedReason>))]
public enum CookieBlockedReason
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SecureOnly")]
    SecureOnly,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NotOnPath")]
    NotOnPath,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("DomainMismatch")]
    DomainMismatch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SameSiteStrict")]
    SameSiteStrict,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SameSiteLax")]
    SameSiteLax,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SameSiteUnspecifiedTreatedAsLax")]
    SameSiteUnspecifiedTreatedAsLax,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SameSiteNoneInsecure")]
    SameSiteNoneInsecure,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UserPreferences")]
    UserPreferences,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ThirdPartyPhaseout")]
    ThirdPartyPhaseout,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ThirdPartyBlockedInFirstPartySet")]
    ThirdPartyBlockedInFirstPartySet,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UnknownError")]
    UnknownError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SchemefulSameSiteStrict")]
    SchemefulSameSiteStrict,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SchemefulSameSiteLax")]
    SchemefulSameSiteLax,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SchemefulSameSiteUnspecifiedTreatedAsLax")]
    SchemefulSameSiteUnspecifiedTreatedAsLax,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NameValuePairExceedsMaxSize")]
    NameValuePairExceedsMaxSize,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PortMismatch")]
    PortMismatch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SchemeMismatch")]
    SchemeMismatch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AnonymousContext")]
    AnonymousContext,
}

/// <summary>
/// Types of reasons why a cookie should have been blocked by 3PCD but is exempted for the request.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<CookieExemptionReason>))]
public enum CookieExemptionReason
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("None")]
    None,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UserSetting")]
    UserSetting,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EnterprisePolicy")]
    EnterprisePolicy,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("StorageAccess")]
    StorageAccess,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TopLevelStorageAccess")]
    TopLevelStorageAccess,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Scheme")]
    Scheme,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SameSiteNoneCookiesInSandbox")]
    SameSiteNoneCookiesInSandbox,
}

/// <summary>
/// A cookie which was not stored from a response with the corresponding reason.
/// </summary>
/// <param name="BlockedReasons">
/// The reason(s) this cookie was blocked.
/// </param>
/// <param name="CookieLine">
/// The string representing this individual cookie as it would appear in the header.
/// This is not the entire "cookie" or "set-cookie" header which could have multiple cookies.
/// </param>
public sealed record BlockedSetCookieWithReason(ImmutableArray<SetCookieBlockedReason> BlockedReasons, string CookieLine)
{
    /// <summary>
    /// The cookie object which represents the cookie which was not stored. It is optional because
    /// sometimes complete cookie information is not available, such as in the case of parsing
    /// errors.
    /// </summary>
    public Cookie? Cookie { get; init; }
}

/// <summary>
/// A cookie should have been blocked by 3PCD but is exempted and stored from a response with the
/// corresponding reason. A cookie could only have at most one exemption reason.
/// </summary>
/// <param name="ExemptionReason">
/// The reason the cookie was exempted.
/// </param>
/// <param name="CookieLine">
/// The string representing this individual cookie as it would appear in the header.
/// </param>
/// <param name="Cookie">
/// The cookie object representing the cookie.
/// </param>
public sealed record ExemptedSetCookieWithReason(CookieExemptionReason ExemptionReason, string CookieLine, Cookie Cookie)
{
}

/// <summary>
/// A cookie associated with the request which may or may not be sent with it.
/// Includes the cookies itself and reasons for blocking or exemption.
/// </summary>
/// <param name="Cookie">
/// The cookie object representing the cookie which was not sent.
/// </param>
/// <param name="BlockedReasons">
/// The reason(s) the cookie was blocked. If empty means the cookie is included.
/// </param>
public sealed record AssociatedCookie(Cookie Cookie, ImmutableArray<CookieBlockedReason> BlockedReasons)
{
    /// <summary>
    /// The reason the cookie should have been blocked by 3PCD but is exempted. A cookie could
    /// only have at most one exemption reason.
    /// </summary>
    public CookieExemptionReason? ExemptionReason { get; init; }
}

/// <summary>
/// Cookie parameter object
/// </summary>
/// <param name="Name">
/// Cookie name.
/// </param>
/// <param name="Value">
/// Cookie value.
/// </param>
public sealed record CookieParam(string Name, string Value)
{
    /// <summary>
    /// The request-URI to associate with the setting of the cookie. This value can affect the
    /// default domain, path, source port, and source scheme values of the created cookie.
    /// </summary>
    public string? Url { get; init; }

    /// <summary>
    /// Cookie domain.
    /// </summary>
    public string? Domain { get; init; }

    /// <summary>
    /// Cookie path.
    /// </summary>
    public string? Path { get; init; }

    /// <summary>
    /// True if cookie is secure.
    /// </summary>
    public bool? Secure { get; init; }

    /// <summary>
    /// True if cookie is http-only.
    /// </summary>
    public bool? HttpOnly { get; init; }

    /// <summary>
    /// Cookie SameSite type.
    /// </summary>
    public CookieSameSite? SameSite { get; init; }

    /// <summary>
    /// Cookie expiration date, session cookie if not set
    /// </summary>
    public TimeSinceEpoch? Expires { get; init; }

    /// <summary>
    /// Cookie Priority.
    /// </summary>
    public CookiePriority? Priority { get; init; }

    /// <summary>
    /// Cookie source scheme type.
    /// </summary>
    public CookieSourceScheme? SourceScheme { get; init; }

    /// <summary>
    /// Cookie source port. Valid values are {-1, [1, 65535]}, -1 indicates an unspecified port.
    /// An unspecified port value allows protocol clients to emulate legacy cookie scope for the port.
    /// This is a temporary ability and it will be removed in the future.
    /// </summary>
    public long? SourcePort { get; init; }

    /// <summary>
    /// Cookie partition key. If not set, the cookie will be set as not partitioned.
    /// </summary>
    public CookiePartitionKey? PartitionKey { get; init; }
}

/// <summary>
/// Authorization challenge for HTTP status code 401 or 407.
/// </summary>
/// <param name="Origin">
/// Origin of the challenger.
/// </param>
/// <param name="Scheme">
/// The authentication scheme used, such as basic or digest
/// </param>
/// <param name="Realm">
/// The realm of the challenge. May be empty.
/// </param>
public sealed record AuthChallenge(string Origin, string Scheme, string Realm)
{
    /// <summary>
    /// Source of the authentication challenge.
    /// </summary>
    public string? Source { get; init; }
}

/// <summary>
/// Response to an AuthChallenge.
/// </summary>
/// <param name="Response">
/// The decision on what to do in response to the authorization challenge.  Default means
/// deferring to the default behavior of the net stack, which will likely either the Cancel
/// authentication or display a popup dialog box.
/// </param>
public sealed record AuthChallengeResponse(string Response)
{
    /// <summary>
    /// The username to provide, possibly empty. Should only be set if response is
    /// ProvideCredentials.
    /// </summary>
    public string? Username { get; init; }

    /// <summary>
    /// The password to provide, possibly empty. Should only be set if response is
    /// ProvideCredentials.
    /// </summary>
    public string? Password { get; init; }
}

/// <summary>
/// Stages of the interception to begin intercepting. Request will intercept before the request is
/// sent. Response will intercept after the response is received.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<InterceptionStage>))]
public enum InterceptionStage
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Request")]
    Request,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("HeadersReceived")]
    HeadersReceived,
}

/// <summary>
/// Request pattern for interception.
/// </summary>
public sealed record RequestPattern()
{
    /// <summary>
    /// Wildcards (<b>'*'</b> -&gt; zero or more, <b>'?'</b> -&gt; exactly one) are allowed. Escape character is
    /// backslash. Omitting is equivalent to <b>"*"</b>.
    /// </summary>
    public string? UrlPattern { get; init; }

    /// <summary>
    /// If set, only requests for matching resource types will be intercepted.
    /// </summary>
    public ResourceType? ResourceType { get; init; }

    /// <summary>
    /// Stage at which to begin intercepting requests. Default is Request.
    /// </summary>
    public InterceptionStage? InterceptionStage { get; init; }
}

/// <summary>
/// Information about a signed exchange signature.
/// https://wicg.github.io/webpackage/draft-yasskin-httpbis-origin-signed-exchanges-impl.html#rfc.section.3.1
/// </summary>
/// <param name="Label">
/// Signed exchange signature label.
/// </param>
/// <param name="Signature">
/// The hex string of signed exchange signature.
/// </param>
/// <param name="Integrity">
/// Signed exchange signature integrity.
/// </param>
/// <param name="ValidityUrl">
/// Signed exchange signature validity Url.
/// </param>
/// <param name="Date">
/// Signed exchange signature date.
/// </param>
/// <param name="Expires">
/// Signed exchange signature expires.
/// </param>
public sealed record SignedExchangeSignature(string Label, string Signature, string Integrity, string ValidityUrl, long Date, long Expires)
{
    /// <summary>
    /// Signed exchange signature cert Url.
    /// </summary>
    public string? CertUrl { get; init; }

    /// <summary>
    /// The hex string of signed exchange signature cert sha256.
    /// </summary>
    public string? CertSha256 { get; init; }

    /// <summary>
    /// The encoded certificates.
    /// </summary>
    public ImmutableArray<string>? Certificates { get; init; }
}

/// <summary>
/// Information about a signed exchange header.
/// https://wicg.github.io/webpackage/draft-yasskin-httpbis-origin-signed-exchanges-impl.html#cbor-representation
/// </summary>
/// <param name="RequestUrl">
/// Signed exchange request URL.
/// </param>
/// <param name="ResponseCode">
/// Signed exchange response code.
/// </param>
/// <param name="ResponseHeaders">
/// Signed exchange response headers.
/// </param>
/// <param name="Signatures">
/// Signed exchange response signature.
/// </param>
/// <param name="HeaderIntegrity">
/// Signed exchange header integrity hash in the form of <b>sha256-&lt;base64-hash-value&gt;</b>.
/// </param>
public sealed record SignedExchangeHeader(string RequestUrl, long ResponseCode, global::System.Collections.Generic.IReadOnlyDictionary<string, string> ResponseHeaders, ImmutableArray<SignedExchangeSignature> Signatures, string HeaderIntegrity)
{
}

/// <summary>
/// Field type for a signed exchange related error.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<SignedExchangeErrorField>))]
public enum SignedExchangeErrorField
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("signatureSig")]
    SignatureSig,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("signatureIntegrity")]
    SignatureIntegrity,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("signatureCertUrl")]
    SignatureCertUrl,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("signatureCertSha256")]
    SignatureCertSha256,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("signatureValidityUrl")]
    SignatureValidityUrl,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("signatureTimestamps")]
    SignatureTimestamps,
}

/// <summary>
/// Information about a signed exchange response.
/// </summary>
/// <param name="Message">
/// Error message.
/// </param>
public sealed record SignedExchangeError(string Message)
{
    /// <summary>
    /// The index of the signature which caused the error.
    /// </summary>
    public long? SignatureIndex { get; init; }

    /// <summary>
    /// The field which caused the error.
    /// </summary>
    public SignedExchangeErrorField? ErrorField { get; init; }
}

/// <summary>
/// Information about a signed exchange response.
/// </summary>
/// <param name="OuterResponse">
/// The outer response of signed HTTP exchange which was received from network.
/// </param>
/// <param name="HasExtraInfo">
/// Whether network response for the signed exchange was accompanied by
/// extra headers.
/// </param>
public sealed record SignedExchangeInfo(Response OuterResponse, bool HasExtraInfo)
{
    /// <summary>
    /// Information about the signed exchange header.
    /// </summary>
    public SignedExchangeHeader? Header { get; init; }

    /// <summary>
    /// Security details for the signed exchange header.
    /// </summary>
    public SecurityDetails? SecurityDetails { get; init; }

    /// <summary>
    /// Errors occurred while handling the signed exchange.
    /// </summary>
    public ImmutableArray<SignedExchangeError>? Errors { get; init; }
}

/// <summary>
/// List of content encodings supported by the backend.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ContentEncoding>))]
public enum ContentEncoding
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("deflate")]
    Deflate,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("gzip")]
    Gzip,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("br")]
    Br,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("zstd")]
    Zstd,
}

/// <summary>
/// </summary>
/// <param name="UrlPattern">
/// Only matching requests will be affected by these conditions. Patterns use the URLPattern constructor string
/// syntax (https://urlpattern.spec.whatwg.org/) and must be absolute. If the pattern is empty, all requests are
/// matched (including p2p connections).
/// </param>
/// <param name="Latency">
/// Minimum latency from request sent to response headers received (ms).
/// </param>
/// <param name="DownloadThroughput">
/// Maximal aggregated download throughput (bytes/sec). -1 disables download throttling.
/// </param>
/// <param name="UploadThroughput">
/// Maximal aggregated upload throughput (bytes/sec).  -1 disables upload throttling.
/// </param>
public sealed record NetworkConditions(string UrlPattern, double Latency, double DownloadThroughput, double UploadThroughput)
{
    /// <summary>
    /// Connection type if known.
    /// </summary>
    public ConnectionType? ConnectionType { get; init; }

    /// <summary>
    /// WebRTC packet loss (percent, 0-100). 0 disables packet loss emulation, 100 drops all the packets.
    /// </summary>
    public double? PacketLoss { get; init; }

    /// <summary>
    /// WebRTC packet queue length (packet). 0 removes any queue length limitations.
    /// </summary>
    public long? PacketQueueLength { get; init; }

    /// <summary>
    /// WebRTC packetReordering feature.
    /// </summary>
    public bool? PacketReordering { get; init; }

    /// <summary>
    /// True to emulate internet disconnection.
    /// </summary>
    public bool? Offline { get; init; }
}

/// <summary>
/// </summary>
/// <param name="UrlPattern">
/// URL pattern to match. Patterns use the URLPattern constructor string syntax
/// (https://urlpattern.spec.whatwg.org/) and must be absolute. Example: <b>*://*:*/*.css</b>.
/// </param>
/// <param name="Block">
/// Whether or not to block the pattern. If false, a matching request will not be blocked even if it matches a later
/// <b>BlockPattern</b>.
/// </param>
public sealed record BlockPattern(string UrlPattern, bool Block)
{
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<DirectSocketDnsQueryType>))]
public enum DirectSocketDnsQueryType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ipv4")]
    Ipv4,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ipv6")]
    Ipv6,
}

/// <summary>
/// </summary>
/// <param name="NoDelay">
/// TCP_NODELAY option
/// </param>
public sealed record DirectTCPSocketOptions(bool NoDelay)
{
    /// <summary>
    /// Expected to be unsigned integer.
    /// </summary>
    public double? KeepAliveDelay { get; init; }

    /// <summary>
    /// Expected to be unsigned integer.
    /// </summary>
    public double? SendBufferSize { get; init; }

    /// <summary>
    /// Expected to be unsigned integer.
    /// </summary>
    public double? ReceiveBufferSize { get; init; }

    /// <summary>
    /// </summary>
    public DirectSocketDnsQueryType? DnsQueryType { get; init; }
}

/// <summary>
/// </summary>
public sealed record DirectUDPSocketOptions()
{
    /// <summary>
    /// </summary>
    public string? RemoteAddr { get; init; }

    /// <summary>
    /// Unsigned int 16.
    /// </summary>
    public long? RemotePort { get; init; }

    /// <summary>
    /// </summary>
    public string? LocalAddr { get; init; }

    /// <summary>
    /// Unsigned int 16.
    /// </summary>
    public long? LocalPort { get; init; }

    /// <summary>
    /// </summary>
    public DirectSocketDnsQueryType? DnsQueryType { get; init; }

    /// <summary>
    /// Expected to be unsigned integer.
    /// </summary>
    public double? SendBufferSize { get; init; }

    /// <summary>
    /// Expected to be unsigned integer.
    /// </summary>
    public double? ReceiveBufferSize { get; init; }

    /// <summary>
    /// </summary>
    public bool? MulticastLoopback { get; init; }

    /// <summary>
    /// Unsigned int 8.
    /// </summary>
    public long? MulticastTimeToLive { get; init; }

    /// <summary>
    /// </summary>
    public bool? MulticastAllowAddressSharing { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Data">
/// </param>
public sealed record DirectUDPMessage(string Data)
{
    /// <summary>
    /// Null for connected mode.
    /// </summary>
    public string? RemoteAddr { get; init; }

    /// <summary>
    /// Null for connected mode.
    /// Expected to be unsigned integer.
    /// </summary>
    public long? RemotePort { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<LocalNetworkAccessRequestPolicy>))]
public enum LocalNetworkAccessRequestPolicy
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Allow")]
    Allow,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BlockFromInsecureToMorePrivate")]
    BlockFromInsecureToMorePrivate,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("WarnFromInsecureToMorePrivate")]
    WarnFromInsecureToMorePrivate,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PermissionBlock")]
    PermissionBlock,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PermissionWarn")]
    PermissionWarn,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<IPAddressSpace>))]
public enum IPAddressSpace
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Loopback")]
    Loopback,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Local")]
    Local,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Public")]
    Public,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Unknown")]
    Unknown,
}

/// <summary>
/// </summary>
/// <param name="RequestTime">
/// Timing's requestTime is a baseline in seconds, while the other numbers are ticks in
/// milliseconds relatively to this requestTime. Matches ResourceTiming's requestTime for
/// the same request (but not for redirected requests).
/// </param>
public sealed record ConnectTiming(double RequestTime)
{
}

/// <summary>
/// </summary>
/// <param name="InitiatorIsSecureContext">
/// </param>
/// <param name="InitiatorIPAddressSpace">
/// </param>
/// <param name="LocalNetworkAccessRequestPolicy">
/// </param>
public sealed record ClientSecurityState(bool InitiatorIsSecureContext, IPAddressSpace InitiatorIPAddressSpace, LocalNetworkAccessRequestPolicy LocalNetworkAccessRequestPolicy)
{
}

/// <summary>
/// Identifies the script on the stack that caused a resource or element to be
/// labeled as an ad. For resources, this indicates the context that triggered
/// the fetch. For elements, this indicates the context that caused the element
/// to be appended to the DOM.
/// </summary>
/// <param name="ScriptId">
/// The script's V8 identifier.
/// </param>
/// <param name="DebuggerId">
/// V8's debugging ID for the v8::Context.
/// </param>
/// <param name="Name">
/// The script's url (or generated name based on id if inline script).
/// </param>
public sealed record AdScriptIdentifier(Runtime.ScriptId ScriptId, Runtime.UniqueDebuggerId DebuggerId, string Name)
{
}

/// <summary>
/// Encapsulates the script ancestry and the root script filter list rule that
/// caused the resource or element to be labeled as an ad.
/// </summary>
/// <param name="AncestryChain">
/// A chain of <b>AdScriptIdentifier</b>s representing the ancestry of an ad
/// script that led to the creation of a resource or element. The chain is
/// ordered from the script itself (lowest level) up to its root ancestor
/// that was flagged by a filter list.
/// </param>
public sealed record AdAncestry(ImmutableArray<AdScriptIdentifier> AncestryChain)
{
    /// <summary>
    /// The filter list rule that caused the root (last) script in
    /// <b>ancestryChain</b> to be tagged as an ad.
    /// </summary>
    public string? RootScriptFilterlistRule { get; init; }
}

/// <summary>
/// Represents the provenance of an ad resource or element. Only one of
/// <b>filterlistRule</b> or <b>adScriptAncestry</b> can be set. If <b>filterlistRule</b>
/// is provided, the resource URL directly matches a filter list rule. If
/// <b>adScriptAncestry</b> is provided, an ad script initiated the resource fetch or
/// appended the element to the DOM. If neither is provided, the entity is
/// known to be an ad, but provenance tracking information is unavailable.
/// </summary>
public sealed record AdProvenance()
{
    /// <summary>
    /// The filterlist rule that matched, if any.
    /// </summary>
    public string? FilterlistRule { get; init; }

    /// <summary>
    /// The script ancestry that created the ad, if any.
    /// </summary>
    public AdAncestry? AdScriptAncestry { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<CrossOriginOpenerPolicyValue>))]
public enum CrossOriginOpenerPolicyValue
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SameOrigin")]
    SameOrigin,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SameOriginAllowPopups")]
    SameOriginAllowPopups,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RestrictProperties")]
    RestrictProperties,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("UnsafeNone")]
    UnsafeNone,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SameOriginPlusCoep")]
    SameOriginPlusCoep,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RestrictPropertiesPlusCoep")]
    RestrictPropertiesPlusCoep,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NoopenerAllowPopups")]
    NoopenerAllowPopups,
}

/// <summary>
/// </summary>
/// <param name="Value">
/// </param>
/// <param name="ReportOnlyValue">
/// </param>
public sealed record CrossOriginOpenerPolicyStatus(CrossOriginOpenerPolicyValue Value, CrossOriginOpenerPolicyValue ReportOnlyValue)
{
    /// <summary>
    /// </summary>
    public string? ReportingEndpoint { get; init; }

    /// <summary>
    /// </summary>
    public string? ReportOnlyReportingEndpoint { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<CrossOriginEmbedderPolicyValue>))]
public enum CrossOriginEmbedderPolicyValue
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("None")]
    None,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Credentialless")]
    Credentialless,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RequireCorp")]
    RequireCorp,
}

/// <summary>
/// </summary>
/// <param name="Value">
/// </param>
/// <param name="ReportOnlyValue">
/// </param>
public sealed record CrossOriginEmbedderPolicyStatus(CrossOriginEmbedderPolicyValue Value, CrossOriginEmbedderPolicyValue ReportOnlyValue)
{
    /// <summary>
    /// </summary>
    public string? ReportingEndpoint { get; init; }

    /// <summary>
    /// </summary>
    public string? ReportOnlyReportingEndpoint { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ContentSecurityPolicySource>))]
public enum ContentSecurityPolicySource
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("HTTP")]
    HTTP,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Meta")]
    Meta,
}

/// <summary>
/// </summary>
/// <param name="EffectiveDirectives">
/// </param>
/// <param name="IsEnforced">
/// </param>
/// <param name="Source">
/// </param>
public sealed record ContentSecurityPolicyStatus(string EffectiveDirectives, bool IsEnforced, ContentSecurityPolicySource Source)
{
}

/// <summary>
/// </summary>
public sealed record SecurityIsolationStatus()
{
    /// <summary>
    /// </summary>
    public CrossOriginOpenerPolicyStatus? Coop { get; init; }

    /// <summary>
    /// </summary>
    public CrossOriginEmbedderPolicyStatus? Coep { get; init; }

    /// <summary>
    /// </summary>
    public ImmutableArray<ContentSecurityPolicyStatus>? Csp { get; init; }
}

/// <summary>
/// The status of a Reporting API report.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ReportStatus>))]
public enum ReportStatus
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Queued")]
    Queued,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Pending")]
    Pending,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MarkedForRemoval")]
    MarkedForRemoval,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Success")]
    Success,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<ReportId>))]
public record ReportId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// An object representing a report generated by the Reporting API.
/// </summary>
/// <param name="Id">
/// </param>
/// <param name="InitiatorUrl">
/// The URL of the document that triggered the report.
/// </param>
/// <param name="Destination">
/// The name of the endpoint group that should be used to deliver the report.
/// </param>
/// <param name="Type">
/// The type of the report (specifies the set of data that is contained in the report body).
/// </param>
/// <param name="Timestamp">
/// When the report was generated.
/// </param>
/// <param name="Depth">
/// How many uploads deep the related request was.
/// </param>
/// <param name="CompletedAttempts">
/// The number of delivery attempts made so far, not including an active attempt.
/// </param>
/// <param name="Body">
/// </param>
/// <param name="Status">
/// </param>
public sealed record ReportingApiReport(ReportId Id, string InitiatorUrl, string Destination, string Type, Network.TimeSinceEpoch Timestamp, long Depth, long CompletedAttempts, global::System.Text.Json.JsonElement Body, ReportStatus Status)
{
}

/// <summary>
/// </summary>
/// <param name="Url">
/// The URL of the endpoint to which reports may be delivered.
/// </param>
/// <param name="GroupName">
/// Name of the endpoint group.
/// </param>
public sealed record ReportingApiEndpoint(string Url, string GroupName)
{
}

/// <summary>
/// Unique identifier for a device bound session.
/// </summary>
/// <param name="Site">
/// The site the session is set up for.
/// </param>
/// <param name="Id">
/// The id of the session.
/// </param>
public sealed record DeviceBoundSessionKey(string Site, string Id)
{
}

/// <summary>
/// How a device bound session was used during a request.
/// </summary>
/// <param name="SessionKey">
/// The key for the session.
/// </param>
/// <param name="Usage">
/// How the session was used (or not used).
/// </param>
public sealed record DeviceBoundSessionWithUsage(DeviceBoundSessionKey SessionKey, string Usage)
{
}

/// <summary>
/// A device bound session's cookie craving.
/// </summary>
/// <param name="Name">
/// The name of the craving.
/// </param>
/// <param name="Domain">
/// The domain of the craving.
/// </param>
/// <param name="Path">
/// The path of the craving.
/// </param>
/// <param name="Secure">
/// The <b>Secure</b> attribute of the craving attributes.
/// </param>
/// <param name="HttpOnly">
/// The <b>HttpOnly</b> attribute of the craving attributes.
/// </param>
public sealed record DeviceBoundSessionCookieCraving(string Name, string Domain, string Path, bool Secure, bool HttpOnly)
{
    /// <summary>
    /// The <b>SameSite</b> attribute of the craving attributes.
    /// </summary>
    public CookieSameSite? SameSite { get; init; }
}

/// <summary>
/// A device bound session's inclusion URL rule.
/// </summary>
/// <param name="RuleType">
/// See comments on <b>net::device_bound_sessions::SessionInclusionRules::UrlRule::rule_type</b>.
/// </param>
/// <param name="HostPattern">
/// See comments on <b>net::device_bound_sessions::SessionInclusionRules::UrlRule::host_pattern</b>.
/// </param>
/// <param name="PathPrefix">
/// See comments on <b>net::device_bound_sessions::SessionInclusionRules::UrlRule::path_prefix</b>.
/// </param>
public sealed record DeviceBoundSessionUrlRule(string RuleType, string HostPattern, string PathPrefix)
{
}

/// <summary>
/// A device bound session's inclusion rules.
/// </summary>
/// <param name="Origin">
/// See comments on <b>net::device_bound_sessions::SessionInclusionRules::origin_</b>.
/// </param>
/// <param name="IncludeSite">
/// Whether the whole site is included. See comments on
/// <b>net::device_bound_sessions::SessionInclusionRules::include_site_</b> for more
/// details; this boolean is true if that value is populated.
/// </param>
/// <param name="UrlRules">
/// See comments on <b>net::device_bound_sessions::SessionInclusionRules::url_rules_</b>.
/// </param>
public sealed record DeviceBoundSessionInclusionRules(string Origin, bool IncludeSite, ImmutableArray<DeviceBoundSessionUrlRule> UrlRules)
{
}

/// <summary>
/// A device bound session.
/// </summary>
/// <param name="Key">
/// The site and session ID of the session.
/// </param>
/// <param name="RefreshUrl">
/// See comments on <b>net::device_bound_sessions::Session::refresh_url_</b>.
/// </param>
/// <param name="InclusionRules">
/// See comments on <b>net::device_bound_sessions::Session::inclusion_rules_</b>.
/// </param>
/// <param name="CookieCravings">
/// See comments on <b>net::device_bound_sessions::Session::cookie_cravings_</b>.
/// </param>
/// <param name="ExpiryDate">
/// See comments on <b>net::device_bound_sessions::Session::expiry_date_</b>.
/// </param>
/// <param name="AllowedRefreshInitiators">
/// See comments on <b>net::device_bound_sessions::Session::allowed_refresh_initiators_</b>.
/// </param>
public sealed record DeviceBoundSession(DeviceBoundSessionKey Key, string RefreshUrl, DeviceBoundSessionInclusionRules InclusionRules, ImmutableArray<DeviceBoundSessionCookieCraving> CookieCravings, Network.TimeSinceEpoch ExpiryDate, ImmutableArray<string> AllowedRefreshInitiators)
{
    /// <summary>
    /// See comments on <b>net::device_bound_sessions::Session::cached_challenge__</b>.
    /// </summary>
    public string? CachedChallenge { get; init; }
}

/// <summary>
/// A unique identifier for a device bound session event.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<DeviceBoundSessionEventId>))]
public record DeviceBoundSessionEventId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// A fetch result for a device bound session creation or refresh.
/// LINT.IfChange(DeviceBoundSessionFetchResult)
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<DeviceBoundSessionFetchResult>))]
public enum DeviceBoundSessionFetchResult
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Success")]
    Success,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SigningKeyGenerationError")]
    SigningKeyGenerationError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AttestationKeyGenerationError")]
    AttestationKeyGenerationError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SigningError")]
    SigningError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TransientSigningError")]
    TransientSigningError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ServerRequestedTermination")]
    ServerRequestedTermination,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidSessionId")]
    InvalidSessionId,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidChallenge")]
    InvalidChallenge,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TooManyChallenges")]
    TooManyChallenges,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidFetcherUrl")]
    InvalidFetcherUrl,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidRefreshUrl")]
    InvalidRefreshUrl,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TransientHttpError")]
    TransientHttpError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ScopeOriginSameSiteMismatch")]
    ScopeOriginSameSiteMismatch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RefreshUrlSameSiteMismatch")]
    RefreshUrlSameSiteMismatch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MismatchedSessionId")]
    MismatchedSessionId,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MissingScope")]
    MissingScope,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NoCredentials")]
    NoCredentials,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SubdomainRegistrationWellKnownUnavailable")]
    SubdomainRegistrationWellKnownUnavailable,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SubdomainRegistrationUnauthorized")]
    SubdomainRegistrationUnauthorized,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SubdomainRegistrationWellKnownMalformed")]
    SubdomainRegistrationWellKnownMalformed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SessionProviderWellKnownUnavailable")]
    SessionProviderWellKnownUnavailable,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RelyingPartyWellKnownUnavailable")]
    RelyingPartyWellKnownUnavailable,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FederatedKeyThumbprintMismatch")]
    FederatedKeyThumbprintMismatch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidFederatedSessionUrl")]
    InvalidFederatedSessionUrl,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidFederatedKey")]
    InvalidFederatedKey,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TooManyRelyingOriginLabels")]
    TooManyRelyingOriginLabels,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("BoundCookieSetForbidden")]
    BoundCookieSetForbidden,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("NetError")]
    NetError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ProxyError")]
    ProxyError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmptySessionConfig")]
    EmptySessionConfig,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidCredentialsConfig")]
    InvalidCredentialsConfig,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidCredentialsType")]
    InvalidCredentialsType,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidCredentialsEmptyName")]
    InvalidCredentialsEmptyName,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidCredentialsCookie")]
    InvalidCredentialsCookie,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PersistentHttpError")]
    PersistentHttpError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RegistrationAttemptedChallenge")]
    RegistrationAttemptedChallenge,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidScopeOrigin")]
    InvalidScopeOrigin,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ScopeOriginContainsPath")]
    ScopeOriginContainsPath,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RefreshInitiatorNotString")]
    RefreshInitiatorNotString,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RefreshInitiatorInvalidHostPattern")]
    RefreshInitiatorInvalidHostPattern,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidScopeSpecification")]
    InvalidScopeSpecification,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MissingScopeSpecificationType")]
    MissingScopeSpecificationType,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmptyScopeSpecificationDomain")]
    EmptyScopeSpecificationDomain,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("EmptyScopeSpecificationPath")]
    EmptyScopeSpecificationPath,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidScopeSpecificationType")]
    InvalidScopeSpecificationType,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidScopeIncludeSite")]
    InvalidScopeIncludeSite,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("MissingScopeIncludeSite")]
    MissingScopeIncludeSite,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FederatedNotAuthorizedByProvider")]
    FederatedNotAuthorizedByProvider,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FederatedNotAuthorizedByRelyingParty")]
    FederatedNotAuthorizedByRelyingParty,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SessionProviderWellKnownMalformed")]
    SessionProviderWellKnownMalformed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SessionProviderWellKnownHasProviderOrigin")]
    SessionProviderWellKnownHasProviderOrigin,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RelyingPartyWellKnownMalformed")]
    RelyingPartyWellKnownMalformed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("RelyingPartyWellKnownHasRelyingOrigins")]
    RelyingPartyWellKnownHasRelyingOrigins,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidFederatedSessionProviderSessionMissing")]
    InvalidFederatedSessionProviderSessionMissing,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidFederatedSessionWrongProviderOrigin")]
    InvalidFederatedSessionWrongProviderOrigin,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidCredentialsCookieCreationTime")]
    InvalidCredentialsCookieCreationTime,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidCredentialsCookieName")]
    InvalidCredentialsCookieName,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidCredentialsCookieParsing")]
    InvalidCredentialsCookieParsing,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidCredentialsCookieUnpermittedAttribute")]
    InvalidCredentialsCookieUnpermittedAttribute,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidCredentialsCookieInvalidDomain")]
    InvalidCredentialsCookieInvalidDomain,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidCredentialsCookiePrefix")]
    InvalidCredentialsCookiePrefix,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidScopeRulePath")]
    InvalidScopeRulePath,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidScopeRuleHostPattern")]
    InvalidScopeRuleHostPattern,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ScopeRuleOriginScopedHostPatternMismatch")]
    ScopeRuleOriginScopedHostPatternMismatch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ScopeRuleSiteScopedHostPatternMismatch")]
    ScopeRuleSiteScopedHostPatternMismatch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SigningQuotaExceeded")]
    SigningQuotaExceeded,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidConfigJson")]
    InvalidConfigJson,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidFederatedSessionProviderFailedToRestoreKey")]
    InvalidFederatedSessionProviderFailedToRestoreKey,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("FailedToUnwrapKey")]
    FailedToUnwrapKey,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SessionDeletedDuringRefresh")]
    SessionDeletedDuringRefresh,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("CrossOriginRegistrationSiteNotIncluded")]
    CrossOriginRegistrationSiteNotIncluded,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("InvalidPreProvisionedKeyInitiatorMissing")]
    InvalidPreProvisionedKeyInitiatorMissing,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PreProvisionedKeyAccessNotGranted")]
    PreProvisionedKeyAccessNotGranted,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PreProvisionedKeyNotFound")]
    PreProvisionedKeyNotFound,
}

/// <summary>
/// Details about a failed device bound session network request.
/// </summary>
/// <param name="RequestUrl">
/// The failed request URL.
/// </param>
public sealed record DeviceBoundSessionFailedRequest(string RequestUrl)
{
    /// <summary>
    /// The net error of the response if it was not OK.
    /// </summary>
    public string? NetError { get; init; }

    /// <summary>
    /// The response code if the net error was OK and the response code was not
    /// 200.
    /// </summary>
    public long? ResponseError { get; init; }

    /// <summary>
    /// The body of the response if the net error was OK, the response code was
    /// not 200, and the response body was not empty.
    /// </summary>
    public string? ResponseErrorBody { get; init; }
}

/// <summary>
/// Session event details specific to creation.
/// </summary>
/// <param name="FetchResult">
/// The result of the fetch attempt.
/// </param>
public sealed record CreationEventDetails(DeviceBoundSessionFetchResult FetchResult)
{
    /// <summary>
    /// The session if there was a newly created session. This is populated for
    /// all successful creation events.
    /// </summary>
    public DeviceBoundSession? NewSession { get; init; }

    /// <summary>
    /// Details about a failed device bound session network request if there was
    /// one.
    /// </summary>
    public DeviceBoundSessionFailedRequest? FailedRequest { get; init; }
}

/// <summary>
/// Session event details specific to refresh.
/// </summary>
/// <param name="RefreshResult">
/// The result of a refresh.
/// </param>
/// <param name="WasFullyProactiveRefresh">
/// See comments on <b>net::device_bound_sessions::RefreshEventResult::was_fully_proactive_refresh</b>.
/// </param>
public sealed record RefreshEventDetails(string RefreshResult, bool WasFullyProactiveRefresh)
{
    /// <summary>
    /// If there was a fetch attempt, the result of that.
    /// </summary>
    public DeviceBoundSessionFetchResult? FetchResult { get; init; }

    /// <summary>
    /// The session display if there was a newly created session. This is populated
    /// for any refresh event that modifies the session config.
    /// </summary>
    public DeviceBoundSession? NewSession { get; init; }

    /// <summary>
    /// Details about a failed device bound session network request if there was
    /// one.
    /// </summary>
    public DeviceBoundSessionFailedRequest? FailedRequest { get; init; }
}

/// <summary>
/// Session event details specific to termination.
/// </summary>
/// <param name="DeletionReason">
/// The reason for a session being deleted.
/// </param>
public sealed record TerminationEventDetails(string DeletionReason)
{
}

/// <summary>
/// Session event details specific to challenges.
/// </summary>
/// <param name="ChallengeResult">
/// The result of a challenge.
/// </param>
/// <param name="Challenge">
/// The challenge set.
/// </param>
public sealed record ChallengeEventDetails(string ChallengeResult, string Challenge)
{
}

/// <summary>
/// An object providing the result of a network resource load.
/// </summary>
/// <param name="Success">
/// </param>
public sealed record LoadNetworkResourcePageResult(bool Success)
{
    /// <summary>
    /// Optional values used for error reporting.
    /// </summary>
    public double? NetError { get; init; }

    /// <summary>
    /// </summary>
    public string? NetErrorName { get; init; }

    /// <summary>
    /// </summary>
    public double? HttpStatusCode { get; init; }

    /// <summary>
    /// If successful, one of the following two fields holds the result.
    /// </summary>
    public IO.StreamHandle? Stream { get; init; }

    /// <summary>
    /// Response headers.
    /// </summary>
    public global::System.Collections.Generic.IReadOnlyDictionary<string, string>? Headers { get; init; }
}

/// <summary>
/// An options object that may be extended later to better support CORS,
/// CORB and streaming.
/// </summary>
/// <param name="DisableCache">
/// </param>
/// <param name="IncludeCredentials">
/// </param>
public sealed record LoadNetworkResourceOptions(bool DisableCache, bool IncludeCredentials)
{
}

[JsonSerializable(typeof(SetAcceptedEncodingsCommandParameters), TypeInfoPropertyName = "SetAcceptedEncodingsCommandParameters")]
[JsonSerializable(typeof(SetAcceptedEncodingsResult), TypeInfoPropertyName = "SetAcceptedEncodingsResult")]
[JsonSerializable(typeof(ClearAcceptedEncodingsOverrideCommandParameters), TypeInfoPropertyName = "ClearAcceptedEncodingsOverrideCommandParameters")]
[JsonSerializable(typeof(ClearAcceptedEncodingsOverrideResult), TypeInfoPropertyName = "ClearAcceptedEncodingsOverrideResult")]
[JsonSerializable(typeof(CanClearBrowserCacheCommandParameters), TypeInfoPropertyName = "CanClearBrowserCacheCommandParameters")]
[JsonSerializable(typeof(CanClearBrowserCacheResult), TypeInfoPropertyName = "CanClearBrowserCacheResult")]
[JsonSerializable(typeof(CanClearBrowserCookiesCommandParameters), TypeInfoPropertyName = "CanClearBrowserCookiesCommandParameters")]
[JsonSerializable(typeof(CanClearBrowserCookiesResult), TypeInfoPropertyName = "CanClearBrowserCookiesResult")]
[JsonSerializable(typeof(CanEmulateNetworkConditionsCommandParameters), TypeInfoPropertyName = "CanEmulateNetworkConditionsCommandParameters")]
[JsonSerializable(typeof(CanEmulateNetworkConditionsResult), TypeInfoPropertyName = "CanEmulateNetworkConditionsResult")]
[JsonSerializable(typeof(ClearBrowserCacheCommandParameters), TypeInfoPropertyName = "ClearBrowserCacheCommandParameters")]
[JsonSerializable(typeof(ClearBrowserCacheResult), TypeInfoPropertyName = "ClearBrowserCacheResult")]
[JsonSerializable(typeof(ClearBrowserCookiesCommandParameters), TypeInfoPropertyName = "ClearBrowserCookiesCommandParameters")]
[JsonSerializable(typeof(ClearBrowserCookiesResult), TypeInfoPropertyName = "ClearBrowserCookiesResult")]
[JsonSerializable(typeof(ContinueInterceptedRequestCommandParameters), TypeInfoPropertyName = "ContinueInterceptedRequestCommandParameters")]
[JsonSerializable(typeof(ContinueInterceptedRequestResult), TypeInfoPropertyName = "ContinueInterceptedRequestResult")]
[JsonSerializable(typeof(DeleteCookiesCommandParameters), TypeInfoPropertyName = "DeleteCookiesCommandParameters")]
[JsonSerializable(typeof(DeleteCookiesResult), TypeInfoPropertyName = "DeleteCookiesResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(EmulateNetworkConditionsCommandParameters), TypeInfoPropertyName = "EmulateNetworkConditionsCommandParameters")]
[JsonSerializable(typeof(EmulateNetworkConditionsResult), TypeInfoPropertyName = "EmulateNetworkConditionsResult")]
[JsonSerializable(typeof(EmulateNetworkConditionsByRuleCommandParameters), TypeInfoPropertyName = "EmulateNetworkConditionsByRuleCommandParameters")]
[JsonSerializable(typeof(EmulateNetworkConditionsByRuleResult), TypeInfoPropertyName = "EmulateNetworkConditionsByRuleResult")]
[JsonSerializable(typeof(OverrideNetworkStateCommandParameters), TypeInfoPropertyName = "OverrideNetworkStateCommandParameters")]
[JsonSerializable(typeof(OverrideNetworkStateResult), TypeInfoPropertyName = "OverrideNetworkStateResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(ConfigureDurableMessagesCommandParameters), TypeInfoPropertyName = "ConfigureDurableMessagesCommandParameters")]
[JsonSerializable(typeof(ConfigureDurableMessagesResult), TypeInfoPropertyName = "ConfigureDurableMessagesResult")]
[JsonSerializable(typeof(GetAllCookiesCommandParameters), TypeInfoPropertyName = "GetAllCookiesCommandParameters")]
[JsonSerializable(typeof(GetAllCookiesResult), TypeInfoPropertyName = "GetAllCookiesResult")]
[JsonSerializable(typeof(GetCertificateCommandParameters), TypeInfoPropertyName = "GetCertificateCommandParameters")]
[JsonSerializable(typeof(GetCertificateResult), TypeInfoPropertyName = "GetCertificateResult")]
[JsonSerializable(typeof(GetCookiesCommandParameters), TypeInfoPropertyName = "GetCookiesCommandParameters")]
[JsonSerializable(typeof(GetCookiesResult), TypeInfoPropertyName = "GetCookiesResult")]
[JsonSerializable(typeof(GetResponseBodyCommandParameters), TypeInfoPropertyName = "GetResponseBodyCommandParameters")]
[JsonSerializable(typeof(GetResponseBodyResult), TypeInfoPropertyName = "GetResponseBodyResult")]
[JsonSerializable(typeof(GetRequestPostDataCommandParameters), TypeInfoPropertyName = "GetRequestPostDataCommandParameters")]
[JsonSerializable(typeof(GetRequestPostDataResult), TypeInfoPropertyName = "GetRequestPostDataResult")]
[JsonSerializable(typeof(GetResponseBodyForInterceptionCommandParameters), TypeInfoPropertyName = "GetResponseBodyForInterceptionCommandParameters")]
[JsonSerializable(typeof(GetResponseBodyForInterceptionResult), TypeInfoPropertyName = "GetResponseBodyForInterceptionResult")]
[JsonSerializable(typeof(TakeResponseBodyForInterceptionAsStreamCommandParameters), TypeInfoPropertyName = "TakeResponseBodyForInterceptionAsStreamCommandParameters")]
[JsonSerializable(typeof(TakeResponseBodyForInterceptionAsStreamResult), TypeInfoPropertyName = "TakeResponseBodyForInterceptionAsStreamResult")]
[JsonSerializable(typeof(ReplayXHRCommandParameters), TypeInfoPropertyName = "ReplayXHRCommandParameters")]
[JsonSerializable(typeof(ReplayXHRResult), TypeInfoPropertyName = "ReplayXHRResult")]
[JsonSerializable(typeof(SearchInResponseBodyCommandParameters), TypeInfoPropertyName = "SearchInResponseBodyCommandParameters")]
[JsonSerializable(typeof(SearchInResponseBodyResult), TypeInfoPropertyName = "SearchInResponseBodyResult")]
[JsonSerializable(typeof(SetBlockedURLsCommandParameters), TypeInfoPropertyName = "SetBlockedURLsCommandParameters")]
[JsonSerializable(typeof(SetBlockedURLsResult), TypeInfoPropertyName = "SetBlockedURLsResult")]
[JsonSerializable(typeof(SetBypassServiceWorkerCommandParameters), TypeInfoPropertyName = "SetBypassServiceWorkerCommandParameters")]
[JsonSerializable(typeof(SetBypassServiceWorkerResult), TypeInfoPropertyName = "SetBypassServiceWorkerResult")]
[JsonSerializable(typeof(SetCacheDisabledCommandParameters), TypeInfoPropertyName = "SetCacheDisabledCommandParameters")]
[JsonSerializable(typeof(SetCacheDisabledResult), TypeInfoPropertyName = "SetCacheDisabledResult")]
[JsonSerializable(typeof(SetCookieCommandParameters), TypeInfoPropertyName = "SetCookieCommandParameters")]
[JsonSerializable(typeof(SetCookieResult), TypeInfoPropertyName = "SetCookieResult")]
[JsonSerializable(typeof(SetCookiesCommandParameters), TypeInfoPropertyName = "SetCookiesCommandParameters")]
[JsonSerializable(typeof(SetCookiesResult), TypeInfoPropertyName = "SetCookiesResult")]
[JsonSerializable(typeof(SetExtraHTTPHeadersCommandParameters), TypeInfoPropertyName = "SetExtraHTTPHeadersCommandParameters")]
[JsonSerializable(typeof(SetExtraHTTPHeadersResult), TypeInfoPropertyName = "SetExtraHTTPHeadersResult")]
[JsonSerializable(typeof(SetAttachDebugStackCommandParameters), TypeInfoPropertyName = "SetAttachDebugStackCommandParameters")]
[JsonSerializable(typeof(SetAttachDebugStackResult), TypeInfoPropertyName = "SetAttachDebugStackResult")]
[JsonSerializable(typeof(SetRequestInterceptionCommandParameters), TypeInfoPropertyName = "SetRequestInterceptionCommandParameters")]
[JsonSerializable(typeof(SetRequestInterceptionResult), TypeInfoPropertyName = "SetRequestInterceptionResult")]
[JsonSerializable(typeof(SetUserAgentOverrideCommandParameters), TypeInfoPropertyName = "SetUserAgentOverrideCommandParameters")]
[JsonSerializable(typeof(SetUserAgentOverrideResult), TypeInfoPropertyName = "SetUserAgentOverrideResult")]
[JsonSerializable(typeof(StreamResourceContentCommandParameters), TypeInfoPropertyName = "StreamResourceContentCommandParameters")]
[JsonSerializable(typeof(StreamResourceContentResult), TypeInfoPropertyName = "StreamResourceContentResult")]
[JsonSerializable(typeof(GetSecurityIsolationStatusCommandParameters), TypeInfoPropertyName = "GetSecurityIsolationStatusCommandParameters")]
[JsonSerializable(typeof(GetSecurityIsolationStatusResult), TypeInfoPropertyName = "GetSecurityIsolationStatusResult")]
[JsonSerializable(typeof(EnableReportingApiCommandParameters), TypeInfoPropertyName = "EnableReportingApiCommandParameters")]
[JsonSerializable(typeof(EnableReportingApiResult), TypeInfoPropertyName = "EnableReportingApiResult")]
[JsonSerializable(typeof(EnableDeviceBoundSessionsCommandParameters), TypeInfoPropertyName = "EnableDeviceBoundSessionsCommandParameters")]
[JsonSerializable(typeof(EnableDeviceBoundSessionsResult), TypeInfoPropertyName = "EnableDeviceBoundSessionsResult")]
[JsonSerializable(typeof(DeleteDeviceBoundSessionCommandParameters), TypeInfoPropertyName = "DeleteDeviceBoundSessionCommandParameters")]
[JsonSerializable(typeof(DeleteDeviceBoundSessionResult), TypeInfoPropertyName = "DeleteDeviceBoundSessionResult")]
[JsonSerializable(typeof(FetchSchemefulSiteCommandParameters), TypeInfoPropertyName = "FetchSchemefulSiteCommandParameters")]
[JsonSerializable(typeof(FetchSchemefulSiteResult), TypeInfoPropertyName = "FetchSchemefulSiteResult")]
[JsonSerializable(typeof(LoadNetworkResourceCommandParameters), TypeInfoPropertyName = "LoadNetworkResourceCommandParameters")]
[JsonSerializable(typeof(LoadNetworkResourceResult), TypeInfoPropertyName = "LoadNetworkResourceResult")]
[JsonSerializable(typeof(SetCookieControlsCommandParameters), TypeInfoPropertyName = "SetCookieControlsCommandParameters")]
[JsonSerializable(typeof(SetCookieControlsResult), TypeInfoPropertyName = "SetCookieControlsResult")]
[JsonSerializable(typeof(CdpEventArgs<DataReceivedEventArgs>), TypeInfoPropertyName = "DataReceivedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<EventSourceMessageReceivedEventArgs>), TypeInfoPropertyName = "EventSourceMessageReceivedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<LoadingFailedEventArgs>), TypeInfoPropertyName = "LoadingFailedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<LoadingFinishedEventArgs>), TypeInfoPropertyName = "LoadingFinishedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<RequestInterceptedEventArgs>), TypeInfoPropertyName = "RequestInterceptedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<RequestServedFromCacheEventArgs>), TypeInfoPropertyName = "RequestServedFromCacheCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<RequestWillBeSentEventArgs>), TypeInfoPropertyName = "RequestWillBeSentCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ResourceChangedPriorityEventArgs>), TypeInfoPropertyName = "ResourceChangedPriorityCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<SignedExchangeReceivedEventArgs>), TypeInfoPropertyName = "SignedExchangeReceivedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ResponseReceivedEventArgs>), TypeInfoPropertyName = "ResponseReceivedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<WebSocketClosedEventArgs>), TypeInfoPropertyName = "WebSocketClosedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<WebSocketCreatedEventArgs>), TypeInfoPropertyName = "WebSocketCreatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<WebSocketFrameErrorEventArgs>), TypeInfoPropertyName = "WebSocketFrameErrorCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<WebSocketFrameReceivedEventArgs>), TypeInfoPropertyName = "WebSocketFrameReceivedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<WebSocketFrameSentEventArgs>), TypeInfoPropertyName = "WebSocketFrameSentCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<WebSocketHandshakeResponseReceivedEventArgs>), TypeInfoPropertyName = "WebSocketHandshakeResponseReceivedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<WebSocketWillSendHandshakeRequestEventArgs>), TypeInfoPropertyName = "WebSocketWillSendHandshakeRequestCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<WebTransportCreatedEventArgs>), TypeInfoPropertyName = "WebTransportCreatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<WebTransportConnectionEstablishedEventArgs>), TypeInfoPropertyName = "WebTransportConnectionEstablishedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<WebTransportClosedEventArgs>), TypeInfoPropertyName = "WebTransportClosedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DirectTCPSocketCreatedEventArgs>), TypeInfoPropertyName = "DirectTCPSocketCreatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DirectTCPSocketOpenedEventArgs>), TypeInfoPropertyName = "DirectTCPSocketOpenedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DirectTCPSocketAbortedEventArgs>), TypeInfoPropertyName = "DirectTCPSocketAbortedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DirectTCPSocketClosedEventArgs>), TypeInfoPropertyName = "DirectTCPSocketClosedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DirectTCPSocketChunkSentEventArgs>), TypeInfoPropertyName = "DirectTCPSocketChunkSentCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DirectTCPSocketChunkReceivedEventArgs>), TypeInfoPropertyName = "DirectTCPSocketChunkReceivedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DirectUDPSocketJoinedMulticastGroupEventArgs>), TypeInfoPropertyName = "DirectUDPSocketJoinedMulticastGroupCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DirectUDPSocketLeftMulticastGroupEventArgs>), TypeInfoPropertyName = "DirectUDPSocketLeftMulticastGroupCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DirectUDPSocketCreatedEventArgs>), TypeInfoPropertyName = "DirectUDPSocketCreatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DirectUDPSocketOpenedEventArgs>), TypeInfoPropertyName = "DirectUDPSocketOpenedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DirectUDPSocketAbortedEventArgs>), TypeInfoPropertyName = "DirectUDPSocketAbortedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DirectUDPSocketClosedEventArgs>), TypeInfoPropertyName = "DirectUDPSocketClosedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DirectUDPSocketChunkSentEventArgs>), TypeInfoPropertyName = "DirectUDPSocketChunkSentCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DirectUDPSocketChunkReceivedEventArgs>), TypeInfoPropertyName = "DirectUDPSocketChunkReceivedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<RequestWillBeSentExtraInfoEventArgs>), TypeInfoPropertyName = "RequestWillBeSentExtraInfoCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ResponseReceivedExtraInfoEventArgs>), TypeInfoPropertyName = "ResponseReceivedExtraInfoCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ResponseReceivedEarlyHintsEventArgs>), TypeInfoPropertyName = "ResponseReceivedEarlyHintsCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<TrustTokenOperationDoneEventArgs>), TypeInfoPropertyName = "TrustTokenOperationDoneCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<PolicyUpdatedEventArgs>), TypeInfoPropertyName = "PolicyUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ReportingApiReportAddedEventArgs>), TypeInfoPropertyName = "ReportingApiReportAddedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ReportingApiReportUpdatedEventArgs>), TypeInfoPropertyName = "ReportingApiReportUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ReportingApiEndpointsChangedForOriginEventArgs>), TypeInfoPropertyName = "ReportingApiEndpointsChangedForOriginCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DeviceBoundSessionsAddedEventArgs>), TypeInfoPropertyName = "DeviceBoundSessionsAddedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DeviceBoundSessionEventOccurredEventArgs>), TypeInfoPropertyName = "DeviceBoundSessionEventOccurredCdpEventArgs")]
[JsonSerializable(typeof(ResourceType), TypeInfoPropertyName = "NetworkResourceType")]
[JsonSerializable(typeof(LoaderId), TypeInfoPropertyName = "NetworkLoaderId")]
[JsonSerializable(typeof(RequestId), TypeInfoPropertyName = "NetworkRequestId")]
[JsonSerializable(typeof(InterceptionId), TypeInfoPropertyName = "NetworkInterceptionId")]
[JsonSerializable(typeof(ErrorReason), TypeInfoPropertyName = "NetworkErrorReason")]
[JsonSerializable(typeof(TimeSinceEpoch), TypeInfoPropertyName = "NetworkTimeSinceEpoch")]
[JsonSerializable(typeof(MonotonicTime), TypeInfoPropertyName = "NetworkMonotonicTime")]
[JsonSerializable(typeof(ConnectionType), TypeInfoPropertyName = "NetworkConnectionType")]
[JsonSerializable(typeof(CookieSameSite), TypeInfoPropertyName = "NetworkCookieSameSite")]
[JsonSerializable(typeof(CookiePriority), TypeInfoPropertyName = "NetworkCookiePriority")]
[JsonSerializable(typeof(CookieSourceScheme), TypeInfoPropertyName = "NetworkCookieSourceScheme")]
[JsonSerializable(typeof(ResourceTiming), TypeInfoPropertyName = "NetworkResourceTiming")]
[JsonSerializable(typeof(ResourcePriority), TypeInfoPropertyName = "NetworkResourcePriority")]
[JsonSerializable(typeof(RenderBlockingBehavior), TypeInfoPropertyName = "NetworkRenderBlockingBehavior")]
[JsonSerializable(typeof(PostDataEntry), TypeInfoPropertyName = "NetworkPostDataEntry")]
[JsonSerializable(typeof(Request), TypeInfoPropertyName = "NetworkRequest")]
[JsonSerializable(typeof(SignedCertificateTimestamp), TypeInfoPropertyName = "NetworkSignedCertificateTimestamp")]
[JsonSerializable(typeof(SecurityDetails), TypeInfoPropertyName = "NetworkSecurityDetails")]
[JsonSerializable(typeof(CertificateTransparencyCompliance), TypeInfoPropertyName = "NetworkCertificateTransparencyCompliance")]
[JsonSerializable(typeof(BlockedReason), TypeInfoPropertyName = "NetworkBlockedReason")]
[JsonSerializable(typeof(CorsError), TypeInfoPropertyName = "NetworkCorsError")]
[JsonSerializable(typeof(CorsErrorStatus), TypeInfoPropertyName = "NetworkCorsErrorStatus")]
[JsonSerializable(typeof(ServiceWorkerResponseSource), TypeInfoPropertyName = "NetworkServiceWorkerResponseSource")]
[JsonSerializable(typeof(TrustTokenParams), TypeInfoPropertyName = "NetworkTrustTokenParams")]
[JsonSerializable(typeof(TrustTokenOperationType), TypeInfoPropertyName = "NetworkTrustTokenOperationType")]
[JsonSerializable(typeof(AlternateProtocolUsage), TypeInfoPropertyName = "NetworkAlternateProtocolUsage")]
[JsonSerializable(typeof(ServiceWorkerRouterSource), TypeInfoPropertyName = "NetworkServiceWorkerRouterSource")]
[JsonSerializable(typeof(ServiceWorkerRouterInfo), TypeInfoPropertyName = "NetworkServiceWorkerRouterInfo")]
[JsonSerializable(typeof(Response), TypeInfoPropertyName = "NetworkResponse")]
[JsonSerializable(typeof(WebSocketRequest), TypeInfoPropertyName = "NetworkWebSocketRequest")]
[JsonSerializable(typeof(WebSocketResponse), TypeInfoPropertyName = "NetworkWebSocketResponse")]
[JsonSerializable(typeof(WebSocketFrame), TypeInfoPropertyName = "NetworkWebSocketFrame")]
[JsonSerializable(typeof(CachedResource), TypeInfoPropertyName = "NetworkCachedResource")]
[JsonSerializable(typeof(Initiator), TypeInfoPropertyName = "NetworkInitiator")]
[JsonSerializable(typeof(CookiePartitionKey), TypeInfoPropertyName = "NetworkCookiePartitionKey")]
[JsonSerializable(typeof(Cookie), TypeInfoPropertyName = "NetworkCookie")]
[JsonSerializable(typeof(SetCookieBlockedReason), TypeInfoPropertyName = "NetworkSetCookieBlockedReason")]
[JsonSerializable(typeof(CookieBlockedReason), TypeInfoPropertyName = "NetworkCookieBlockedReason")]
[JsonSerializable(typeof(CookieExemptionReason), TypeInfoPropertyName = "NetworkCookieExemptionReason")]
[JsonSerializable(typeof(BlockedSetCookieWithReason), TypeInfoPropertyName = "NetworkBlockedSetCookieWithReason")]
[JsonSerializable(typeof(ExemptedSetCookieWithReason), TypeInfoPropertyName = "NetworkExemptedSetCookieWithReason")]
[JsonSerializable(typeof(AssociatedCookie), TypeInfoPropertyName = "NetworkAssociatedCookie")]
[JsonSerializable(typeof(CookieParam), TypeInfoPropertyName = "NetworkCookieParam")]
[JsonSerializable(typeof(AuthChallenge), TypeInfoPropertyName = "NetworkAuthChallenge")]
[JsonSerializable(typeof(AuthChallengeResponse), TypeInfoPropertyName = "NetworkAuthChallengeResponse")]
[JsonSerializable(typeof(InterceptionStage), TypeInfoPropertyName = "NetworkInterceptionStage")]
[JsonSerializable(typeof(RequestPattern), TypeInfoPropertyName = "NetworkRequestPattern")]
[JsonSerializable(typeof(SignedExchangeSignature), TypeInfoPropertyName = "NetworkSignedExchangeSignature")]
[JsonSerializable(typeof(SignedExchangeHeader), TypeInfoPropertyName = "NetworkSignedExchangeHeader")]
[JsonSerializable(typeof(SignedExchangeErrorField), TypeInfoPropertyName = "NetworkSignedExchangeErrorField")]
[JsonSerializable(typeof(SignedExchangeError), TypeInfoPropertyName = "NetworkSignedExchangeError")]
[JsonSerializable(typeof(SignedExchangeInfo), TypeInfoPropertyName = "NetworkSignedExchangeInfo")]
[JsonSerializable(typeof(ContentEncoding), TypeInfoPropertyName = "NetworkContentEncoding")]
[JsonSerializable(typeof(NetworkConditions), TypeInfoPropertyName = "NetworkNetworkConditions")]
[JsonSerializable(typeof(BlockPattern), TypeInfoPropertyName = "NetworkBlockPattern")]
[JsonSerializable(typeof(DirectSocketDnsQueryType), TypeInfoPropertyName = "NetworkDirectSocketDnsQueryType")]
[JsonSerializable(typeof(DirectTCPSocketOptions), TypeInfoPropertyName = "NetworkDirectTCPSocketOptions")]
[JsonSerializable(typeof(DirectUDPSocketOptions), TypeInfoPropertyName = "NetworkDirectUDPSocketOptions")]
[JsonSerializable(typeof(DirectUDPMessage), TypeInfoPropertyName = "NetworkDirectUDPMessage")]
[JsonSerializable(typeof(LocalNetworkAccessRequestPolicy), TypeInfoPropertyName = "NetworkLocalNetworkAccessRequestPolicy")]
[JsonSerializable(typeof(IPAddressSpace), TypeInfoPropertyName = "NetworkIPAddressSpace")]
[JsonSerializable(typeof(ConnectTiming), TypeInfoPropertyName = "NetworkConnectTiming")]
[JsonSerializable(typeof(ClientSecurityState), TypeInfoPropertyName = "NetworkClientSecurityState")]
[JsonSerializable(typeof(AdScriptIdentifier), TypeInfoPropertyName = "NetworkAdScriptIdentifier")]
[JsonSerializable(typeof(AdAncestry), TypeInfoPropertyName = "NetworkAdAncestry")]
[JsonSerializable(typeof(AdProvenance), TypeInfoPropertyName = "NetworkAdProvenance")]
[JsonSerializable(typeof(CrossOriginOpenerPolicyValue), TypeInfoPropertyName = "NetworkCrossOriginOpenerPolicyValue")]
[JsonSerializable(typeof(CrossOriginOpenerPolicyStatus), TypeInfoPropertyName = "NetworkCrossOriginOpenerPolicyStatus")]
[JsonSerializable(typeof(CrossOriginEmbedderPolicyValue), TypeInfoPropertyName = "NetworkCrossOriginEmbedderPolicyValue")]
[JsonSerializable(typeof(CrossOriginEmbedderPolicyStatus), TypeInfoPropertyName = "NetworkCrossOriginEmbedderPolicyStatus")]
[JsonSerializable(typeof(ContentSecurityPolicySource), TypeInfoPropertyName = "NetworkContentSecurityPolicySource")]
[JsonSerializable(typeof(ContentSecurityPolicyStatus), TypeInfoPropertyName = "NetworkContentSecurityPolicyStatus")]
[JsonSerializable(typeof(SecurityIsolationStatus), TypeInfoPropertyName = "NetworkSecurityIsolationStatus")]
[JsonSerializable(typeof(ReportStatus), TypeInfoPropertyName = "NetworkReportStatus")]
[JsonSerializable(typeof(ReportId), TypeInfoPropertyName = "NetworkReportId")]
[JsonSerializable(typeof(ReportingApiReport), TypeInfoPropertyName = "NetworkReportingApiReport")]
[JsonSerializable(typeof(ReportingApiEndpoint), TypeInfoPropertyName = "NetworkReportingApiEndpoint")]
[JsonSerializable(typeof(DeviceBoundSessionKey), TypeInfoPropertyName = "NetworkDeviceBoundSessionKey")]
[JsonSerializable(typeof(DeviceBoundSessionWithUsage), TypeInfoPropertyName = "NetworkDeviceBoundSessionWithUsage")]
[JsonSerializable(typeof(DeviceBoundSessionCookieCraving), TypeInfoPropertyName = "NetworkDeviceBoundSessionCookieCraving")]
[JsonSerializable(typeof(DeviceBoundSessionUrlRule), TypeInfoPropertyName = "NetworkDeviceBoundSessionUrlRule")]
[JsonSerializable(typeof(DeviceBoundSessionInclusionRules), TypeInfoPropertyName = "NetworkDeviceBoundSessionInclusionRules")]
[JsonSerializable(typeof(DeviceBoundSession), TypeInfoPropertyName = "NetworkDeviceBoundSession")]
[JsonSerializable(typeof(DeviceBoundSessionEventId), TypeInfoPropertyName = "NetworkDeviceBoundSessionEventId")]
[JsonSerializable(typeof(DeviceBoundSessionFetchResult), TypeInfoPropertyName = "NetworkDeviceBoundSessionFetchResult")]
[JsonSerializable(typeof(DeviceBoundSessionFailedRequest), TypeInfoPropertyName = "NetworkDeviceBoundSessionFailedRequest")]
[JsonSerializable(typeof(CreationEventDetails), TypeInfoPropertyName = "NetworkCreationEventDetails")]
[JsonSerializable(typeof(RefreshEventDetails), TypeInfoPropertyName = "NetworkRefreshEventDetails")]
[JsonSerializable(typeof(TerminationEventDetails), TypeInfoPropertyName = "NetworkTerminationEventDetails")]
[JsonSerializable(typeof(ChallengeEventDetails), TypeInfoPropertyName = "NetworkChallengeEventDetails")]
[JsonSerializable(typeof(LoadNetworkResourcePageResult), TypeInfoPropertyName = "NetworkLoadNetworkResourcePageResult")]
[JsonSerializable(typeof(LoadNetworkResourceOptions), TypeInfoPropertyName = "NetworkLoadNetworkResourceOptions")]
[JsonSerializable(typeof(ImmutableArray<ContentEncoding>), TypeInfoPropertyName = "ImmutableArrayNetworkContentEncoding")]
[JsonSerializable(typeof(ImmutableArray<NetworkConditions>), TypeInfoPropertyName = "ImmutableArrayNetworkNetworkConditions")]
[JsonSerializable(typeof(ImmutableArray<Cookie>), TypeInfoPropertyName = "ImmutableArrayNetworkCookie")]
[JsonSerializable(typeof(ImmutableArray<Debugger.SearchMatch>), TypeInfoPropertyName = "ImmutableArrayDebuggerSearchMatch")]
[JsonSerializable(typeof(ImmutableArray<BlockPattern>), TypeInfoPropertyName = "ImmutableArrayNetworkBlockPattern")]
[JsonSerializable(typeof(ImmutableArray<CookieParam>), TypeInfoPropertyName = "ImmutableArrayNetworkCookieParam")]
[JsonSerializable(typeof(ImmutableArray<RequestPattern>), TypeInfoPropertyName = "ImmutableArrayNetworkRequestPattern")]
[JsonSerializable(typeof(ImmutableArray<AssociatedCookie>), TypeInfoPropertyName = "ImmutableArrayNetworkAssociatedCookie")]
[JsonSerializable(typeof(ImmutableArray<DeviceBoundSessionWithUsage>), TypeInfoPropertyName = "ImmutableArrayNetworkDeviceBoundSessionWithUsage")]
[JsonSerializable(typeof(ImmutableArray<BlockedSetCookieWithReason>), TypeInfoPropertyName = "ImmutableArrayNetworkBlockedSetCookieWithReason")]
[JsonSerializable(typeof(ImmutableArray<ExemptedSetCookieWithReason>), TypeInfoPropertyName = "ImmutableArrayNetworkExemptedSetCookieWithReason")]
[JsonSerializable(typeof(ImmutableArray<ReportingApiEndpoint>), TypeInfoPropertyName = "ImmutableArrayNetworkReportingApiEndpoint")]
[JsonSerializable(typeof(ImmutableArray<DeviceBoundSession>), TypeInfoPropertyName = "ImmutableArrayNetworkDeviceBoundSession")]
[JsonSerializable(typeof(ImmutableArray<PostDataEntry>), TypeInfoPropertyName = "ImmutableArrayNetworkPostDataEntry")]
[JsonSerializable(typeof(ImmutableArray<SignedCertificateTimestamp>), TypeInfoPropertyName = "ImmutableArrayNetworkSignedCertificateTimestamp")]
[JsonSerializable(typeof(ImmutableArray<SetCookieBlockedReason>), TypeInfoPropertyName = "ImmutableArrayNetworkSetCookieBlockedReason")]
[JsonSerializable(typeof(ImmutableArray<CookieBlockedReason>), TypeInfoPropertyName = "ImmutableArrayNetworkCookieBlockedReason")]
[JsonSerializable(typeof(ImmutableArray<SignedExchangeSignature>), TypeInfoPropertyName = "ImmutableArrayNetworkSignedExchangeSignature")]
[JsonSerializable(typeof(ImmutableArray<SignedExchangeError>), TypeInfoPropertyName = "ImmutableArrayNetworkSignedExchangeError")]
[JsonSerializable(typeof(ImmutableArray<AdScriptIdentifier>), TypeInfoPropertyName = "ImmutableArrayNetworkAdScriptIdentifier")]
[JsonSerializable(typeof(ImmutableArray<ContentSecurityPolicyStatus>), TypeInfoPropertyName = "ImmutableArrayNetworkContentSecurityPolicyStatus")]
[JsonSerializable(typeof(ImmutableArray<DeviceBoundSessionUrlRule>), TypeInfoPropertyName = "ImmutableArrayNetworkDeviceBoundSessionUrlRule")]
[JsonSerializable(typeof(ImmutableArray<DeviceBoundSessionCookieCraving>), TypeInfoPropertyName = "ImmutableArrayNetworkDeviceBoundSessionCookieCraving")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class NetworkJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="NetworkDomain"/>.
/// </summary>
public static class NetworkDomainEvent
{
    /// <summary>
    /// Fired when data chunk was received over the network.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DataReceivedEventArgs>> DataReceived { get; } =
        EventDescriptor<CdpEventArgs<DataReceivedEventArgs>>.Create(
            "goog:cdp.Network.dataReceived",
            NetworkJsonSerializerContext.Default.DataReceivedCdpEventArgs);

    /// <summary>
    /// Fired when EventSource message is received.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<EventSourceMessageReceivedEventArgs>> EventSourceMessageReceived { get; } =
        EventDescriptor<CdpEventArgs<EventSourceMessageReceivedEventArgs>>.Create(
            "goog:cdp.Network.eventSourceMessageReceived",
            NetworkJsonSerializerContext.Default.EventSourceMessageReceivedCdpEventArgs);

    /// <summary>
    /// Fired when HTTP request has failed to load.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<LoadingFailedEventArgs>> LoadingFailed { get; } =
        EventDescriptor<CdpEventArgs<LoadingFailedEventArgs>>.Create(
            "goog:cdp.Network.loadingFailed",
            NetworkJsonSerializerContext.Default.LoadingFailedCdpEventArgs);

    /// <summary>
    /// Fired when HTTP request has finished loading.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<LoadingFinishedEventArgs>> LoadingFinished { get; } =
        EventDescriptor<CdpEventArgs<LoadingFinishedEventArgs>>.Create(
            "goog:cdp.Network.loadingFinished",
            NetworkJsonSerializerContext.Default.LoadingFinishedCdpEventArgs);

    /// <summary>
    /// Details of an intercepted HTTP request, which must be either allowed, blocked, modified or
    /// mocked.
    /// Deprecated, use Fetch.requestPaused instead.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<RequestInterceptedEventArgs>> RequestIntercepted { get; } =
        EventDescriptor<CdpEventArgs<RequestInterceptedEventArgs>>.Create(
            "goog:cdp.Network.requestIntercepted",
            NetworkJsonSerializerContext.Default.RequestInterceptedCdpEventArgs);

    /// <summary>
    /// Fired if request ended up loading from cache.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<RequestServedFromCacheEventArgs>> RequestServedFromCache { get; } =
        EventDescriptor<CdpEventArgs<RequestServedFromCacheEventArgs>>.Create(
            "goog:cdp.Network.requestServedFromCache",
            NetworkJsonSerializerContext.Default.RequestServedFromCacheCdpEventArgs);

    /// <summary>
    /// Fired when page is about to send HTTP request.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<RequestWillBeSentEventArgs>> RequestWillBeSent { get; } =
        EventDescriptor<CdpEventArgs<RequestWillBeSentEventArgs>>.Create(
            "goog:cdp.Network.requestWillBeSent",
            NetworkJsonSerializerContext.Default.RequestWillBeSentCdpEventArgs);

    /// <summary>
    /// Fired when resource loading priority is changed
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ResourceChangedPriorityEventArgs>> ResourceChangedPriority { get; } =
        EventDescriptor<CdpEventArgs<ResourceChangedPriorityEventArgs>>.Create(
            "goog:cdp.Network.resourceChangedPriority",
            NetworkJsonSerializerContext.Default.ResourceChangedPriorityCdpEventArgs);

    /// <summary>
    /// Fired when a signed exchange was received over the network
    /// </summary>
    public static EventDescriptor<CdpEventArgs<SignedExchangeReceivedEventArgs>> SignedExchangeReceived { get; } =
        EventDescriptor<CdpEventArgs<SignedExchangeReceivedEventArgs>>.Create(
            "goog:cdp.Network.signedExchangeReceived",
            NetworkJsonSerializerContext.Default.SignedExchangeReceivedCdpEventArgs);

    /// <summary>
    /// Fired when HTTP response is available.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ResponseReceivedEventArgs>> ResponseReceived { get; } =
        EventDescriptor<CdpEventArgs<ResponseReceivedEventArgs>>.Create(
            "goog:cdp.Network.responseReceived",
            NetworkJsonSerializerContext.Default.ResponseReceivedCdpEventArgs);

    /// <summary>
    /// Fired when WebSocket is closed.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<WebSocketClosedEventArgs>> WebSocketClosed { get; } =
        EventDescriptor<CdpEventArgs<WebSocketClosedEventArgs>>.Create(
            "goog:cdp.Network.webSocketClosed",
            NetworkJsonSerializerContext.Default.WebSocketClosedCdpEventArgs);

    /// <summary>
    /// Fired upon WebSocket creation.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<WebSocketCreatedEventArgs>> WebSocketCreated { get; } =
        EventDescriptor<CdpEventArgs<WebSocketCreatedEventArgs>>.Create(
            "goog:cdp.Network.webSocketCreated",
            NetworkJsonSerializerContext.Default.WebSocketCreatedCdpEventArgs);

    /// <summary>
    /// Fired when WebSocket message error occurs.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<WebSocketFrameErrorEventArgs>> WebSocketFrameError { get; } =
        EventDescriptor<CdpEventArgs<WebSocketFrameErrorEventArgs>>.Create(
            "goog:cdp.Network.webSocketFrameError",
            NetworkJsonSerializerContext.Default.WebSocketFrameErrorCdpEventArgs);

    /// <summary>
    /// Fired when WebSocket message is received.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<WebSocketFrameReceivedEventArgs>> WebSocketFrameReceived { get; } =
        EventDescriptor<CdpEventArgs<WebSocketFrameReceivedEventArgs>>.Create(
            "goog:cdp.Network.webSocketFrameReceived",
            NetworkJsonSerializerContext.Default.WebSocketFrameReceivedCdpEventArgs);

    /// <summary>
    /// Fired when WebSocket message is sent.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<WebSocketFrameSentEventArgs>> WebSocketFrameSent { get; } =
        EventDescriptor<CdpEventArgs<WebSocketFrameSentEventArgs>>.Create(
            "goog:cdp.Network.webSocketFrameSent",
            NetworkJsonSerializerContext.Default.WebSocketFrameSentCdpEventArgs);

    /// <summary>
    /// Fired when WebSocket handshake response becomes available.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<WebSocketHandshakeResponseReceivedEventArgs>> WebSocketHandshakeResponseReceived { get; } =
        EventDescriptor<CdpEventArgs<WebSocketHandshakeResponseReceivedEventArgs>>.Create(
            "goog:cdp.Network.webSocketHandshakeResponseReceived",
            NetworkJsonSerializerContext.Default.WebSocketHandshakeResponseReceivedCdpEventArgs);

    /// <summary>
    /// Fired when WebSocket is about to initiate handshake.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<WebSocketWillSendHandshakeRequestEventArgs>> WebSocketWillSendHandshakeRequest { get; } =
        EventDescriptor<CdpEventArgs<WebSocketWillSendHandshakeRequestEventArgs>>.Create(
            "goog:cdp.Network.webSocketWillSendHandshakeRequest",
            NetworkJsonSerializerContext.Default.WebSocketWillSendHandshakeRequestCdpEventArgs);

    /// <summary>
    /// Fired upon WebTransport creation.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<WebTransportCreatedEventArgs>> WebTransportCreated { get; } =
        EventDescriptor<CdpEventArgs<WebTransportCreatedEventArgs>>.Create(
            "goog:cdp.Network.webTransportCreated",
            NetworkJsonSerializerContext.Default.WebTransportCreatedCdpEventArgs);

    /// <summary>
    /// Fired when WebTransport handshake is finished.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<WebTransportConnectionEstablishedEventArgs>> WebTransportConnectionEstablished { get; } =
        EventDescriptor<CdpEventArgs<WebTransportConnectionEstablishedEventArgs>>.Create(
            "goog:cdp.Network.webTransportConnectionEstablished",
            NetworkJsonSerializerContext.Default.WebTransportConnectionEstablishedCdpEventArgs);

    /// <summary>
    /// Fired when WebTransport is disposed.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<WebTransportClosedEventArgs>> WebTransportClosed { get; } =
        EventDescriptor<CdpEventArgs<WebTransportClosedEventArgs>>.Create(
            "goog:cdp.Network.webTransportClosed",
            NetworkJsonSerializerContext.Default.WebTransportClosedCdpEventArgs);

    /// <summary>
    /// Fired upon direct_socket.TCPSocket creation.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DirectTCPSocketCreatedEventArgs>> DirectTCPSocketCreated { get; } =
        EventDescriptor<CdpEventArgs<DirectTCPSocketCreatedEventArgs>>.Create(
            "goog:cdp.Network.directTCPSocketCreated",
            NetworkJsonSerializerContext.Default.DirectTCPSocketCreatedCdpEventArgs);

    /// <summary>
    /// Fired when direct_socket.TCPSocket connection is opened.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DirectTCPSocketOpenedEventArgs>> DirectTCPSocketOpened { get; } =
        EventDescriptor<CdpEventArgs<DirectTCPSocketOpenedEventArgs>>.Create(
            "goog:cdp.Network.directTCPSocketOpened",
            NetworkJsonSerializerContext.Default.DirectTCPSocketOpenedCdpEventArgs);

    /// <summary>
    /// Fired when direct_socket.TCPSocket is aborted.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DirectTCPSocketAbortedEventArgs>> DirectTCPSocketAborted { get; } =
        EventDescriptor<CdpEventArgs<DirectTCPSocketAbortedEventArgs>>.Create(
            "goog:cdp.Network.directTCPSocketAborted",
            NetworkJsonSerializerContext.Default.DirectTCPSocketAbortedCdpEventArgs);

    /// <summary>
    /// Fired when direct_socket.TCPSocket is closed.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DirectTCPSocketClosedEventArgs>> DirectTCPSocketClosed { get; } =
        EventDescriptor<CdpEventArgs<DirectTCPSocketClosedEventArgs>>.Create(
            "goog:cdp.Network.directTCPSocketClosed",
            NetworkJsonSerializerContext.Default.DirectTCPSocketClosedCdpEventArgs);

    /// <summary>
    /// Fired when data is sent to tcp direct socket stream.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DirectTCPSocketChunkSentEventArgs>> DirectTCPSocketChunkSent { get; } =
        EventDescriptor<CdpEventArgs<DirectTCPSocketChunkSentEventArgs>>.Create(
            "goog:cdp.Network.directTCPSocketChunkSent",
            NetworkJsonSerializerContext.Default.DirectTCPSocketChunkSentCdpEventArgs);

    /// <summary>
    /// Fired when data is received from tcp direct socket stream.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DirectTCPSocketChunkReceivedEventArgs>> DirectTCPSocketChunkReceived { get; } =
        EventDescriptor<CdpEventArgs<DirectTCPSocketChunkReceivedEventArgs>>.Create(
            "goog:cdp.Network.directTCPSocketChunkReceived",
            NetworkJsonSerializerContext.Default.DirectTCPSocketChunkReceivedCdpEventArgs);

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DirectUDPSocketJoinedMulticastGroupEventArgs>> DirectUDPSocketJoinedMulticastGroup { get; } =
        EventDescriptor<CdpEventArgs<DirectUDPSocketJoinedMulticastGroupEventArgs>>.Create(
            "goog:cdp.Network.directUDPSocketJoinedMulticastGroup",
            NetworkJsonSerializerContext.Default.DirectUDPSocketJoinedMulticastGroupCdpEventArgs);

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DirectUDPSocketLeftMulticastGroupEventArgs>> DirectUDPSocketLeftMulticastGroup { get; } =
        EventDescriptor<CdpEventArgs<DirectUDPSocketLeftMulticastGroupEventArgs>>.Create(
            "goog:cdp.Network.directUDPSocketLeftMulticastGroup",
            NetworkJsonSerializerContext.Default.DirectUDPSocketLeftMulticastGroupCdpEventArgs);

    /// <summary>
    /// Fired upon direct_socket.UDPSocket creation.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DirectUDPSocketCreatedEventArgs>> DirectUDPSocketCreated { get; } =
        EventDescriptor<CdpEventArgs<DirectUDPSocketCreatedEventArgs>>.Create(
            "goog:cdp.Network.directUDPSocketCreated",
            NetworkJsonSerializerContext.Default.DirectUDPSocketCreatedCdpEventArgs);

    /// <summary>
    /// Fired when direct_socket.UDPSocket connection is opened.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DirectUDPSocketOpenedEventArgs>> DirectUDPSocketOpened { get; } =
        EventDescriptor<CdpEventArgs<DirectUDPSocketOpenedEventArgs>>.Create(
            "goog:cdp.Network.directUDPSocketOpened",
            NetworkJsonSerializerContext.Default.DirectUDPSocketOpenedCdpEventArgs);

    /// <summary>
    /// Fired when direct_socket.UDPSocket is aborted.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DirectUDPSocketAbortedEventArgs>> DirectUDPSocketAborted { get; } =
        EventDescriptor<CdpEventArgs<DirectUDPSocketAbortedEventArgs>>.Create(
            "goog:cdp.Network.directUDPSocketAborted",
            NetworkJsonSerializerContext.Default.DirectUDPSocketAbortedCdpEventArgs);

    /// <summary>
    /// Fired when direct_socket.UDPSocket is closed.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DirectUDPSocketClosedEventArgs>> DirectUDPSocketClosed { get; } =
        EventDescriptor<CdpEventArgs<DirectUDPSocketClosedEventArgs>>.Create(
            "goog:cdp.Network.directUDPSocketClosed",
            NetworkJsonSerializerContext.Default.DirectUDPSocketClosedCdpEventArgs);

    /// <summary>
    /// Fired when message is sent to udp direct socket stream.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DirectUDPSocketChunkSentEventArgs>> DirectUDPSocketChunkSent { get; } =
        EventDescriptor<CdpEventArgs<DirectUDPSocketChunkSentEventArgs>>.Create(
            "goog:cdp.Network.directUDPSocketChunkSent",
            NetworkJsonSerializerContext.Default.DirectUDPSocketChunkSentCdpEventArgs);

    /// <summary>
    /// Fired when message is received from udp direct socket stream.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DirectUDPSocketChunkReceivedEventArgs>> DirectUDPSocketChunkReceived { get; } =
        EventDescriptor<CdpEventArgs<DirectUDPSocketChunkReceivedEventArgs>>.Create(
            "goog:cdp.Network.directUDPSocketChunkReceived",
            NetworkJsonSerializerContext.Default.DirectUDPSocketChunkReceivedCdpEventArgs);

    /// <summary>
    /// Fired when additional information about a requestWillBeSent event is available from the
    /// network stack. Not every requestWillBeSent event will have an additional
    /// requestWillBeSentExtraInfo fired for it, and there is no guarantee whether requestWillBeSent
    /// or requestWillBeSentExtraInfo will be fired first for the same request.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<RequestWillBeSentExtraInfoEventArgs>> RequestWillBeSentExtraInfo { get; } =
        EventDescriptor<CdpEventArgs<RequestWillBeSentExtraInfoEventArgs>>.Create(
            "goog:cdp.Network.requestWillBeSentExtraInfo",
            NetworkJsonSerializerContext.Default.RequestWillBeSentExtraInfoCdpEventArgs);

    /// <summary>
    /// Fired when additional information about a responseReceived event is available from the network
    /// stack. Not every responseReceived event will have an additional responseReceivedExtraInfo for
    /// it, and responseReceivedExtraInfo may be fired before or after responseReceived.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ResponseReceivedExtraInfoEventArgs>> ResponseReceivedExtraInfo { get; } =
        EventDescriptor<CdpEventArgs<ResponseReceivedExtraInfoEventArgs>>.Create(
            "goog:cdp.Network.responseReceivedExtraInfo",
            NetworkJsonSerializerContext.Default.ResponseReceivedExtraInfoCdpEventArgs);

    /// <summary>
    /// Fired when 103 Early Hints headers is received in addition to the common response.
    /// Not every responseReceived event will have an responseReceivedEarlyHints fired.
    /// Only one responseReceivedEarlyHints may be fired for eached responseReceived event.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ResponseReceivedEarlyHintsEventArgs>> ResponseReceivedEarlyHints { get; } =
        EventDescriptor<CdpEventArgs<ResponseReceivedEarlyHintsEventArgs>>.Create(
            "goog:cdp.Network.responseReceivedEarlyHints",
            NetworkJsonSerializerContext.Default.ResponseReceivedEarlyHintsCdpEventArgs);

    /// <summary>
    /// Fired exactly once for each Trust Token operation. Depending on
    /// the type of the operation and whether the operation succeeded or
    /// failed, the event is fired before the corresponding request was sent
    /// or after the response was received.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<TrustTokenOperationDoneEventArgs>> TrustTokenOperationDone { get; } =
        EventDescriptor<CdpEventArgs<TrustTokenOperationDoneEventArgs>>.Create(
            "goog:cdp.Network.trustTokenOperationDone",
            NetworkJsonSerializerContext.Default.TrustTokenOperationDoneCdpEventArgs);

    /// <summary>
    /// Fired once security policy has been updated.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<PolicyUpdatedEventArgs>> PolicyUpdated { get; } =
        EventDescriptor<CdpEventArgs<PolicyUpdatedEventArgs>>.Create(
            "goog:cdp.Network.policyUpdated",
            NetworkJsonSerializerContext.Default.PolicyUpdatedCdpEventArgs);

    /// <summary>
    /// Is sent whenever a new report is added.
    /// And after 'enableReportingApi' for all existing reports.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ReportingApiReportAddedEventArgs>> ReportingApiReportAdded { get; } =
        EventDescriptor<CdpEventArgs<ReportingApiReportAddedEventArgs>>.Create(
            "goog:cdp.Network.reportingApiReportAdded",
            NetworkJsonSerializerContext.Default.ReportingApiReportAddedCdpEventArgs);

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ReportingApiReportUpdatedEventArgs>> ReportingApiReportUpdated { get; } =
        EventDescriptor<CdpEventArgs<ReportingApiReportUpdatedEventArgs>>.Create(
            "goog:cdp.Network.reportingApiReportUpdated",
            NetworkJsonSerializerContext.Default.ReportingApiReportUpdatedCdpEventArgs);

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ReportingApiEndpointsChangedForOriginEventArgs>> ReportingApiEndpointsChangedForOrigin { get; } =
        EventDescriptor<CdpEventArgs<ReportingApiEndpointsChangedForOriginEventArgs>>.Create(
            "goog:cdp.Network.reportingApiEndpointsChangedForOrigin",
            NetworkJsonSerializerContext.Default.ReportingApiEndpointsChangedForOriginCdpEventArgs);

    /// <summary>
    /// Triggered when the initial set of device bound sessions is added.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DeviceBoundSessionsAddedEventArgs>> DeviceBoundSessionsAdded { get; } =
        EventDescriptor<CdpEventArgs<DeviceBoundSessionsAddedEventArgs>>.Create(
            "goog:cdp.Network.deviceBoundSessionsAdded",
            NetworkJsonSerializerContext.Default.DeviceBoundSessionsAddedCdpEventArgs);

    /// <summary>
    /// Triggered when a device bound session event occurs.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DeviceBoundSessionEventOccurredEventArgs>> DeviceBoundSessionEventOccurred { get; } =
        EventDescriptor<CdpEventArgs<DeviceBoundSessionEventOccurredEventArgs>>.Create(
            "goog:cdp.Network.deviceBoundSessionEventOccurred",
            NetworkJsonSerializerContext.Default.DeviceBoundSessionEventOccurredCdpEventArgs);

}
