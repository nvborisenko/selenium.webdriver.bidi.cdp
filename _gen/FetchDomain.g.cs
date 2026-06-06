#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Fetch;

/// <summary>
/// A domain for letting clients substitute browser's network layer with client code.
/// </summary>
public sealed class FetchDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static FetchJsonSerializerContext JsonContext = FetchJsonSerializerContext.Default;

    /// <summary>
    /// Disables the fetch domain.
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
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("Fetch.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Enables issuing of requestPaused events. A request will be paused until client
    /// calls one of failRequest, fulfillRequest or continueRequest/continueWithAuth.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Patterns</b> - If specified, only requests matching any of these patterns will produce fetchRequested event and will be paused until clients response. If not set, all requests will be affected.</description></item>
    /// <item><description><b>HandleAuthRequests</b> - If true, authRequired events will be issued and requests will be paused expecting a call to continueWithAuth.</description></item>
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
        var @params = new EnableCommandParameters(Patterns: options?.Patterns, HandleAuthRequests: options?.HandleAuthRequests);
        return await ExecuteCommandAsync(EnableCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("Fetch.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Causes the request to fail with specified reason.
    /// </summary>
    /// <param name="requestId">
    /// An id the client received in requestPaused event.
    /// </param>
    /// <param name="errorReason">
    /// Causes the request to fail with the given reason.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="FailRequestCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="FailRequestResult"/>.
    /// </returns>
    public async Task<FailRequestResult> FailRequestAsync(RequestId requestId, Network.ErrorReason errorReason, FailRequestCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new FailRequestCommandParameters(RequestId: requestId, ErrorReason: errorReason);
        return await ExecuteCommandAsync(FailRequestCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<FailRequestCommandParameters, FailRequestResult> FailRequestCommand = new("Fetch.failRequest", JsonContext.FailRequestCommandParameters, JsonContext.FailRequestResult);

    /// <summary>
    /// Provides response to the request.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>ResponseHeaders</b> - Response headers.</description></item>
    /// <item><description><b>BinaryResponseHeaders</b> - Alternative way of specifying response headers as a \0-separated series of name: value pairs. Prefer the above method unless you need to represent some non-UTF8 values that can't be transmitted over the protocol as text. (Encoded as a base64 string when passed over JSON)</description></item>
    /// <item><description><b>Body</b> - A response body. If absent, original response body will be used if the request is intercepted at the response stage and empty body will be used if the request is intercepted at the request stage. (Encoded as a base64 string when passed over JSON)</description></item>
    /// <item><description><b>ResponsePhrase</b> - A textual representation of responseCode. If absent, a standard phrase matching responseCode is used.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="requestId">
    /// An id the client received in requestPaused event.
    /// </param>
    /// <param name="responseCode">
    /// An HTTP response code.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="FulfillRequestCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="FulfillRequestResult"/>.
    /// </returns>
    public async Task<FulfillRequestResult> FulfillRequestAsync(RequestId requestId, long responseCode, FulfillRequestCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new FulfillRequestCommandParameters(RequestId: requestId, ResponseCode: responseCode, ResponseHeaders: options?.ResponseHeaders, BinaryResponseHeaders: options?.BinaryResponseHeaders, Body: options?.Body, ResponsePhrase: options?.ResponsePhrase);
        return await ExecuteCommandAsync(FulfillRequestCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<FulfillRequestCommandParameters, FulfillRequestResult> FulfillRequestCommand = new("Fetch.fulfillRequest", JsonContext.FulfillRequestCommandParameters, JsonContext.FulfillRequestResult);

    /// <summary>
    /// Continues the request, optionally modifying some of its parameters.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Url</b> - If set, the request url will be modified in a way that's not observable by page.</description></item>
    /// <item><description><b>Method</b> - If set, the request method is overridden.</description></item>
    /// <item><description><b>PostData</b> - If set, overrides the post data in the request. (Encoded as a base64 string when passed over JSON)</description></item>
    /// <item><description><b>Headers</b> - If set, overrides the request headers. Note that the overrides do not extend to subsequent redirect hops, if a redirect happens. Another override may be applied to a different request produced by a redirect.</description></item>
    /// <item><description><b>InterceptResponse</b> - If set, overrides response interception behavior for this request.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="requestId">
    /// An id the client received in requestPaused event.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ContinueRequestCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ContinueRequestResult"/>.
    /// </returns>
    public async Task<ContinueRequestResult> ContinueRequestAsync(RequestId requestId, ContinueRequestCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ContinueRequestCommandParameters(RequestId: requestId, Url: options?.Url, Method: options?.Method, PostData: options?.PostData, Headers: options?.Headers, InterceptResponse: options?.InterceptResponse);
        return await ExecuteCommandAsync(ContinueRequestCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ContinueRequestCommandParameters, ContinueRequestResult> ContinueRequestCommand = new("Fetch.continueRequest", JsonContext.ContinueRequestCommandParameters, JsonContext.ContinueRequestResult);

    /// <summary>
    /// Continues a request supplying authChallengeResponse following authRequired event.
    /// </summary>
    /// <param name="requestId">
    /// An id the client received in authRequired event.
    /// </param>
    /// <param name="authChallengeResponse">
    /// Response to  with an authChallenge.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ContinueWithAuthCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ContinueWithAuthResult"/>.
    /// </returns>
    public async Task<ContinueWithAuthResult> ContinueWithAuthAsync(RequestId requestId, AuthChallengeResponse authChallengeResponse, ContinueWithAuthCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ContinueWithAuthCommandParameters(RequestId: requestId, AuthChallengeResponse: authChallengeResponse);
        return await ExecuteCommandAsync(ContinueWithAuthCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ContinueWithAuthCommandParameters, ContinueWithAuthResult> ContinueWithAuthCommand = new("Fetch.continueWithAuth", JsonContext.ContinueWithAuthCommandParameters, JsonContext.ContinueWithAuthResult);

    /// <summary>
    /// Continues loading of the paused response, optionally modifying the
    /// response headers. If either responseCode or headers are modified, all of them
    /// must be present.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>ResponseCode</b> - An HTTP response code. If absent, original response code will be used.</description></item>
    /// <item><description><b>ResponsePhrase</b> - A textual representation of responseCode. If absent, a standard phrase matching responseCode is used.</description></item>
    /// <item><description><b>ResponseHeaders</b> - Response headers. If absent, original response headers will be used.</description></item>
    /// <item><description><b>BinaryResponseHeaders</b> - Alternative way of specifying response headers as a \0-separated series of name: value pairs. Prefer the above method unless you need to represent some non-UTF8 values that can't be transmitted over the protocol as text. (Encoded as a base64 string when passed over JSON)</description></item>
    /// </list>
    /// </remarks>
    /// <param name="requestId">
    /// An id the client received in requestPaused event.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ContinueResponseCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ContinueResponseResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<ContinueResponseResult> ContinueResponseAsync(RequestId requestId, ContinueResponseCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ContinueResponseCommandParameters(RequestId: requestId, ResponseCode: options?.ResponseCode, ResponsePhrase: options?.ResponsePhrase, ResponseHeaders: options?.ResponseHeaders, BinaryResponseHeaders: options?.BinaryResponseHeaders);
        return await ExecuteCommandAsync(ContinueResponseCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ContinueResponseCommandParameters, ContinueResponseResult> ContinueResponseCommand = new("Fetch.continueResponse", JsonContext.ContinueResponseCommandParameters, JsonContext.ContinueResponseResult);

    /// <summary>
    /// Causes the body of the response to be received from the server and
    /// returned as a single string. May only be issued for a request that
    /// is paused in the Response stage and is mutually exclusive with
    /// takeResponseBodyForInterceptionAsStream. Calling other methods that
    /// affect the request or disabling fetch domain before body is received
    /// results in an undefined behavior.
    /// Note that the response body is not available for redirects. Requests
    /// paused in the _redirect received_ state may be differentiated by
    /// <b>responseCode</b> and presence of <b>location</b> response header, see
    /// comments to <b>requestPaused</b> for details.
    /// </summary>
    /// <param name="requestId">
    /// Identifier for the intercepted request to get body for.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetResponseBodyCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetResponseBodyResult"/>.
    /// </returns>
    public async Task<GetResponseBodyResult> GetResponseBodyAsync(RequestId requestId, GetResponseBodyCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetResponseBodyCommandParameters(RequestId: requestId);
        return await ExecuteCommandAsync(GetResponseBodyCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetResponseBodyCommandParameters, GetResponseBodyResult> GetResponseBodyCommand = new("Fetch.getResponseBody", JsonContext.GetResponseBodyCommandParameters, JsonContext.GetResponseBodyResult);

    /// <summary>
    /// Returns a handle to the stream representing the response body.
    /// The request must be paused in the HeadersReceived stage.
    /// Note that after this command the request can't be continued
    /// as is -- client either needs to cancel it or to provide the
    /// response body.
    /// The stream only supports sequential read, IO.read will fail if the position
    /// is specified.
    /// This method is mutually exclusive with getResponseBody.
    /// Calling other methods that affect the request or disabling fetch
    /// domain before body is received results in an undefined behavior.
    /// </summary>
    /// <param name="requestId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="TakeResponseBodyAsStreamCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="TakeResponseBodyAsStreamResult"/>.
    /// </returns>
    public async Task<TakeResponseBodyAsStreamResult> TakeResponseBodyAsStreamAsync(RequestId requestId, TakeResponseBodyAsStreamCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new TakeResponseBodyAsStreamCommandParameters(RequestId: requestId);
        return await ExecuteCommandAsync(TakeResponseBodyAsStreamCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<TakeResponseBodyAsStreamCommandParameters, TakeResponseBodyAsStreamResult> TakeResponseBodyAsStreamCommand = new("Fetch.takeResponseBodyAsStream", JsonContext.TakeResponseBodyAsStreamCommandParameters, JsonContext.TakeResponseBodyAsStreamResult);

    /// <summary>
    /// Issued when the domain is enabled and the request URL matches the
    /// specified filter. The request is paused until the client responds
    /// with one of continueRequest, failRequest or fulfillRequest.
    /// The stage of the request can be determined by presence of responseErrorReason
    /// and responseStatusCode -- the request is at the response stage if either
    /// of these fields is present and in the request stage otherwise.
    /// Redirect responses and subsequent requests are reported similarly to regular
    /// responses and requests. Redirect responses may be distinguished by the value
    /// of <b>responseStatusCode</b> (which is one of 301, 302, 303, 307, 308) along with
    /// presence of the <b>location</b> header. Requests resulting from a redirect will
    /// have <b>redirectedRequestId</b> field set.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="RequestPausedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b> - Each request the page makes will have a unique id.</description></item>
    /// <item><description><b>Request</b> - The details of the request.</description></item>
    /// <item><description><b>FrameId</b> - The id of the frame that initiated the request.</description></item>
    /// <item><description><b>ResourceType</b> - How the requested resource will be used.</description></item>
    /// <item><description><b>ResponseErrorReason</b> - Response error if intercepted at response stage.</description></item>
    /// <item><description><b>ResponseStatusCode</b> - Response code if intercepted at response stage.</description></item>
    /// <item><description><b>ResponseStatusText</b> - Response status text if intercepted at response stage.</description></item>
    /// <item><description><b>ResponseHeaders</b> - Response headers if intercepted at the response stage.</description></item>
    /// <item><description><b>NetworkId</b> - If the intercepted request had a corresponding Network.requestWillBeSent event fired for it, then this networkId will be the same as the requestId present in the requestWillBeSent event.</description></item>
    /// <item><description><b>RedirectedRequestId</b> - If the request is due to a redirect response from the server, the id of the request that has caused the redirect.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<RequestPausedEventArgs> RequestPaused => CreateCdpEventSource(FetchDomainEvent.RequestPaused);
    /// <summary>
    /// Issued when the domain is enabled with handleAuthRequests set to true.
    /// The request is paused until client responds with continueWithAuth.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="AuthRequiredEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b> - Each request the page makes will have a unique id.</description></item>
    /// <item><description><b>Request</b> - The details of the request.</description></item>
    /// <item><description><b>FrameId</b> - The id of the frame that initiated the request.</description></item>
    /// <item><description><b>ResourceType</b> - How the requested resource will be used.</description></item>
    /// <item><description><b>AuthChallenge</b> - Details of the Authorization Challenge encountered. If this is set, client should respond with continueRequest that contains AuthChallengeResponse.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<AuthRequiredEventArgs> AuthRequired => CreateCdpEventSource(FetchDomainEvent.AuthRequired);
}

internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="FetchDomain.DisableAsync"/>.
/// </summary>
public sealed record DisableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters(IEnumerable<RequestPattern>? Patterns, bool? HandleAuthRequests) : Parameters;

/// <summary>
/// Optional parameters for <see cref="FetchDomain.EnableAsync"/>.
/// </summary>
public sealed record EnableCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// If specified, only requests matching any of these patterns will produce
    /// fetchRequested event and will be paused until clients response. If not set,
    /// all requests will be affected.
    /// </summary>
    public IEnumerable<RequestPattern>? Patterns { get; init; }

    /// <summary>
    /// If true, authRequired events will be issued and requests will be paused
    /// expecting a call to continueWithAuth.
    /// </summary>
    public bool? HandleAuthRequests { get; init; }
}

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record FailRequestCommandParameters(RequestId RequestId, Network.ErrorReason ErrorReason) : Parameters;

/// <summary>
/// Optional parameters for <see cref="FetchDomain.FailRequestAsync"/>.
/// </summary>
public sealed record FailRequestCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record FailRequestResult() : EmptyResult;


internal sealed record FulfillRequestCommandParameters(RequestId RequestId, long ResponseCode, IEnumerable<HeaderEntry>? ResponseHeaders, string? BinaryResponseHeaders, string? Body, string? ResponsePhrase) : Parameters;

/// <summary>
/// Optional parameters for <see cref="FetchDomain.FulfillRequestAsync"/>.
/// </summary>
public sealed record FulfillRequestCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Response headers.
    /// </summary>
    public IEnumerable<HeaderEntry>? ResponseHeaders { get; init; }

    /// <summary>
    /// Alternative way of specifying response headers as a \0-separated
    /// series of name: value pairs. Prefer the above method unless you
    /// need to represent some non-UTF8 values that can't be transmitted
    /// over the protocol as text. (Encoded as a base64 string when passed over JSON)
    /// </summary>
    public string? BinaryResponseHeaders { get; init; }

    /// <summary>
    /// A response body. If absent, original response body will be used if
    /// the request is intercepted at the response stage and empty body
    /// will be used if the request is intercepted at the request stage. (Encoded as a base64 string when passed over JSON)
    /// </summary>
    public string? Body { get; init; }

    /// <summary>
    /// A textual representation of responseCode.
    /// If absent, a standard phrase matching responseCode is used.
    /// </summary>
    public string? ResponsePhrase { get; init; }
}

/// <summary>
/// </summary>
public sealed record FulfillRequestResult() : EmptyResult;


internal sealed record ContinueRequestCommandParameters(RequestId RequestId, string? Url, string? Method, string? PostData, IEnumerable<HeaderEntry>? Headers, bool? InterceptResponse) : Parameters;

/// <summary>
/// Optional parameters for <see cref="FetchDomain.ContinueRequestAsync"/>.
/// </summary>
public sealed record ContinueRequestCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// If set, the request url will be modified in a way that's not observable by page.
    /// </summary>
    public string? Url { get; init; }

    /// <summary>
    /// If set, the request method is overridden.
    /// </summary>
    public string? Method { get; init; }

    /// <summary>
    /// If set, overrides the post data in the request. (Encoded as a base64 string when passed over JSON)
    /// </summary>
    public string? PostData { get; init; }

    /// <summary>
    /// If set, overrides the request headers. Note that the overrides do not
    /// extend to subsequent redirect hops, if a redirect happens. Another override
    /// may be applied to a different request produced by a redirect.
    /// </summary>
    public IEnumerable<HeaderEntry>? Headers { get; init; }

    /// <summary>
    /// If set, overrides response interception behavior for this request.
    /// </summary>
    public bool? InterceptResponse { get; init; }
}

/// <summary>
/// </summary>
public sealed record ContinueRequestResult() : EmptyResult;


internal sealed record ContinueWithAuthCommandParameters(RequestId RequestId, AuthChallengeResponse AuthChallengeResponse) : Parameters;

/// <summary>
/// Optional parameters for <see cref="FetchDomain.ContinueWithAuthAsync"/>.
/// </summary>
public sealed record ContinueWithAuthCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ContinueWithAuthResult() : EmptyResult;


internal sealed record ContinueResponseCommandParameters(RequestId RequestId, long? ResponseCode, string? ResponsePhrase, IEnumerable<HeaderEntry>? ResponseHeaders, string? BinaryResponseHeaders) : Parameters;

/// <summary>
/// Optional parameters for <see cref="FetchDomain.ContinueResponseAsync"/>.
/// </summary>
public sealed record ContinueResponseCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// An HTTP response code. If absent, original response code will be used.
    /// </summary>
    public long? ResponseCode { get; init; }

    /// <summary>
    /// A textual representation of responseCode.
    /// If absent, a standard phrase matching responseCode is used.
    /// </summary>
    public string? ResponsePhrase { get; init; }

    /// <summary>
    /// Response headers. If absent, original response headers will be used.
    /// </summary>
    public IEnumerable<HeaderEntry>? ResponseHeaders { get; init; }

    /// <summary>
    /// Alternative way of specifying response headers as a \0-separated
    /// series of name: value pairs. Prefer the above method unless you
    /// need to represent some non-UTF8 values that can't be transmitted
    /// over the protocol as text. (Encoded as a base64 string when passed over JSON)
    /// </summary>
    public string? BinaryResponseHeaders { get; init; }
}

/// <summary>
/// </summary>
public sealed record ContinueResponseResult() : EmptyResult;


internal sealed record GetResponseBodyCommandParameters(RequestId RequestId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="FetchDomain.GetResponseBodyAsync"/>.
/// </summary>
public sealed record GetResponseBodyCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Body">
/// Response body.
/// </param>
/// <param name="Base64Encoded">
/// True, if content was sent as base64.
/// </param>
public sealed record GetResponseBodyResult(string Body, bool Base64Encoded) : EmptyResult;


internal sealed record TakeResponseBodyAsStreamCommandParameters(RequestId RequestId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="FetchDomain.TakeResponseBodyAsStreamAsync"/>.
/// </summary>
public sealed record TakeResponseBodyAsStreamCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Stream">
/// </param>
public sealed record TakeResponseBodyAsStreamResult(IO.StreamHandle Stream) : EmptyResult;


/// <summary>
/// Issued when the domain is enabled and the request URL matches the
/// specified filter. The request is paused until the client responds
/// with one of continueRequest, failRequest or fulfillRequest.
/// The stage of the request can be determined by presence of responseErrorReason
/// and responseStatusCode -- the request is at the response stage if either
/// of these fields is present and in the request stage otherwise.
/// Redirect responses and subsequent requests are reported similarly to regular
/// responses and requests. Redirect responses may be distinguished by the value
/// of <b>responseStatusCode</b> (which is one of 301, 302, 303, 307, 308) along with
/// presence of the <b>location</b> header. Requests resulting from a redirect will
/// have <b>redirectedRequestId</b> field set.
/// </summary>
/// <param name="RequestId">
/// Each request the page makes will have a unique id.
/// </param>
/// <param name="Request">
/// The details of the request.
/// </param>
/// <param name="FrameId">
/// The id of the frame that initiated the request.
/// </param>
/// <param name="ResourceType">
/// How the requested resource will be used.
/// </param>
/// <param name="ResponseErrorReason">
/// Response error if intercepted at response stage.
/// </param>
/// <param name="ResponseStatusCode">
/// Response code if intercepted at response stage.
/// </param>
/// <param name="ResponseStatusText">
/// Response status text if intercepted at response stage.
/// </param>
/// <param name="ResponseHeaders">
/// Response headers if intercepted at the response stage.
/// </param>
/// <param name="NetworkId">
/// If the intercepted request had a corresponding Network.requestWillBeSent event fired for it,
/// then this networkId will be the same as the requestId present in the requestWillBeSent event.
/// </param>
/// <param name="RedirectedRequestId">
/// If the request is due to a redirect response from the server, the id of the request that
/// has caused the redirect.
/// </param>
public sealed record RequestPausedEventArgs(RequestId RequestId, Network.Request Request, Page.FrameId FrameId, Network.ResourceType ResourceType, Network.ErrorReason? ResponseErrorReason = null, long? ResponseStatusCode = null, string? ResponseStatusText = null, IEnumerable<HeaderEntry>? ResponseHeaders = null, Network.RequestId? NetworkId = null, RequestId? RedirectedRequestId = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Issued when the domain is enabled with handleAuthRequests set to true.
/// The request is paused until client responds with continueWithAuth.
/// </summary>
/// <param name="RequestId">
/// Each request the page makes will have a unique id.
/// </param>
/// <param name="Request">
/// The details of the request.
/// </param>
/// <param name="FrameId">
/// The id of the frame that initiated the request.
/// </param>
/// <param name="ResourceType">
/// How the requested resource will be used.
/// </param>
/// <param name="AuthChallenge">
/// Details of the Authorization Challenge encountered.
/// If this is set, client should respond with continueRequest that
/// contains AuthChallengeResponse.
/// </param>
public sealed record AuthRequiredEventArgs(RequestId RequestId, Network.Request Request, Page.FrameId FrameId, Network.ResourceType ResourceType, AuthChallenge AuthChallenge) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Unique request identifier.
/// Note that this does not identify individual HTTP requests that are part of
/// a network request.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<RequestId>))]
public record RequestId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Stages of the request to handle. Request will intercept before the request is
/// sent. Response will intercept after the response is received (but before response
/// body is received).
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<RequestStage>))]
public enum RequestStage
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Request")]
    Request,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Response")]
    Response,
}

/// <summary>
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
    public Network.ResourceType? ResourceType { get; init; }

    /// <summary>
    /// Stage at which to begin intercepting requests. Default is Request.
    /// </summary>
    public RequestStage? RequestStage { get; init; }
}

/// <summary>
/// Response HTTP header entry
/// </summary>
/// <param name="Name">
/// </param>
/// <param name="Value">
/// </param>
public sealed record HeaderEntry(string Name, string Value)
{
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

[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(FailRequestCommandParameters), TypeInfoPropertyName = "FailRequestCommandParameters")]
[JsonSerializable(typeof(FailRequestResult), TypeInfoPropertyName = "FailRequestResult")]
[JsonSerializable(typeof(FulfillRequestCommandParameters), TypeInfoPropertyName = "FulfillRequestCommandParameters")]
[JsonSerializable(typeof(FulfillRequestResult), TypeInfoPropertyName = "FulfillRequestResult")]
[JsonSerializable(typeof(ContinueRequestCommandParameters), TypeInfoPropertyName = "ContinueRequestCommandParameters")]
[JsonSerializable(typeof(ContinueRequestResult), TypeInfoPropertyName = "ContinueRequestResult")]
[JsonSerializable(typeof(ContinueWithAuthCommandParameters), TypeInfoPropertyName = "ContinueWithAuthCommandParameters")]
[JsonSerializable(typeof(ContinueWithAuthResult), TypeInfoPropertyName = "ContinueWithAuthResult")]
[JsonSerializable(typeof(ContinueResponseCommandParameters), TypeInfoPropertyName = "ContinueResponseCommandParameters")]
[JsonSerializable(typeof(ContinueResponseResult), TypeInfoPropertyName = "ContinueResponseResult")]
[JsonSerializable(typeof(GetResponseBodyCommandParameters), TypeInfoPropertyName = "GetResponseBodyCommandParameters")]
[JsonSerializable(typeof(GetResponseBodyResult), TypeInfoPropertyName = "GetResponseBodyResult")]
[JsonSerializable(typeof(TakeResponseBodyAsStreamCommandParameters), TypeInfoPropertyName = "TakeResponseBodyAsStreamCommandParameters")]
[JsonSerializable(typeof(TakeResponseBodyAsStreamResult), TypeInfoPropertyName = "TakeResponseBodyAsStreamResult")]
[JsonSerializable(typeof(CdpEventArgs<RequestPausedEventArgs>), TypeInfoPropertyName = "RequestPausedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<AuthRequiredEventArgs>), TypeInfoPropertyName = "AuthRequiredCdpEventArgs")]
[JsonSerializable(typeof(RequestId), TypeInfoPropertyName = "FetchRequestId")]
[JsonSerializable(typeof(RequestStage), TypeInfoPropertyName = "FetchRequestStage")]
[JsonSerializable(typeof(RequestPattern), TypeInfoPropertyName = "FetchRequestPattern")]
[JsonSerializable(typeof(HeaderEntry), TypeInfoPropertyName = "FetchHeaderEntry")]
[JsonSerializable(typeof(AuthChallenge), TypeInfoPropertyName = "FetchAuthChallenge")]
[JsonSerializable(typeof(AuthChallengeResponse), TypeInfoPropertyName = "FetchAuthChallengeResponse")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<RequestPattern>), TypeInfoPropertyName = "IReadOnlyListFetchRequestPattern")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<HeaderEntry>), TypeInfoPropertyName = "IReadOnlyListFetchHeaderEntry")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class FetchJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="FetchDomain"/>.
/// </summary>
public static class FetchDomainEvent
{
    /// <summary>
    /// Issued when the domain is enabled and the request URL matches the
    /// specified filter. The request is paused until the client responds
    /// with one of continueRequest, failRequest or fulfillRequest.
    /// The stage of the request can be determined by presence of responseErrorReason
    /// and responseStatusCode -- the request is at the response stage if either
    /// of these fields is present and in the request stage otherwise.
    /// Redirect responses and subsequent requests are reported similarly to regular
    /// responses and requests. Redirect responses may be distinguished by the value
    /// of <b>responseStatusCode</b> (which is one of 301, 302, 303, 307, 308) along with
    /// presence of the <b>location</b> header. Requests resulting from a redirect will
    /// have <b>redirectedRequestId</b> field set.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<RequestPausedEventArgs>> RequestPaused { get; } =
        EventDescriptor<CdpEventArgs<RequestPausedEventArgs>>.Create(
            "goog:cdp.Fetch.requestPaused",
            FetchJsonSerializerContext.Default.RequestPausedCdpEventArgs);

    /// <summary>
    /// Issued when the domain is enabled with handleAuthRequests set to true.
    /// The request is paused until client responds with continueWithAuth.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<AuthRequiredEventArgs>> AuthRequired { get; } =
        EventDescriptor<CdpEventArgs<AuthRequiredEventArgs>>.Create(
            "goog:cdp.Fetch.authRequired",
            FetchJsonSerializerContext.Default.AuthRequiredCdpEventArgs);

}
