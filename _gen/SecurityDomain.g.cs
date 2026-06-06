#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Security;

/// <summary>
/// Security
/// </summary>
public sealed class SecurityDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static SecurityJsonSerializerContext JsonContext = SecurityJsonSerializerContext.Default;

    /// <summary>
    /// Disables tracking security state changes.
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
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("Security.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Enables tracking security state changes.
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
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("Security.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Enable/disable whether all certificate errors should be ignored.
    /// </summary>
    /// <param name="ignore">
    /// If true, all certificate errors will be ignored.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetIgnoreCertificateErrorsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetIgnoreCertificateErrorsResult"/>.
    /// </returns>
    public async Task<SetIgnoreCertificateErrorsResult> SetIgnoreCertificateErrorsAsync(bool ignore, SetIgnoreCertificateErrorsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetIgnoreCertificateErrorsCommandParameters(Ignore: ignore);
        return await ExecuteCommandAsync(SetIgnoreCertificateErrorsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetIgnoreCertificateErrorsCommandParameters, SetIgnoreCertificateErrorsResult> SetIgnoreCertificateErrorsCommand = new("Security.setIgnoreCertificateErrors", JsonContext.SetIgnoreCertificateErrorsCommandParameters, JsonContext.SetIgnoreCertificateErrorsResult);

    /// <summary>
    /// Handles a certificate error that fired a certificateError event.
    /// </summary>
    /// <param name="eventId">
    /// The ID of the event.
    /// </param>
    /// <param name="action">
    /// The action to take on the certificate error.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="HandleCertificateErrorCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="HandleCertificateErrorResult"/>.
    /// </returns>
    [global::System.Obsolete]
    public async Task<HandleCertificateErrorResult> HandleCertificateErrorAsync(long eventId, CertificateErrorAction action, HandleCertificateErrorCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new HandleCertificateErrorCommandParameters(EventId: eventId, Action: action);
        return await ExecuteCommandAsync(HandleCertificateErrorCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<HandleCertificateErrorCommandParameters, HandleCertificateErrorResult> HandleCertificateErrorCommand = new("Security.handleCertificateError", JsonContext.HandleCertificateErrorCommandParameters, JsonContext.HandleCertificateErrorResult);

    /// <summary>
    /// Enable/disable overriding certificate errors. If enabled, all certificate error events need to
    /// be handled by the DevTools client and should be answered with <b>handleCertificateError</b> commands.
    /// </summary>
    /// <param name="override">
    /// If true, certificate errors will be overridden.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetOverrideCertificateErrorsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetOverrideCertificateErrorsResult"/>.
    /// </returns>
    [global::System.Obsolete]
    public async Task<SetOverrideCertificateErrorsResult> SetOverrideCertificateErrorsAsync(bool @override, SetOverrideCertificateErrorsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetOverrideCertificateErrorsCommandParameters(Override: @override);
        return await ExecuteCommandAsync(SetOverrideCertificateErrorsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetOverrideCertificateErrorsCommandParameters, SetOverrideCertificateErrorsResult> SetOverrideCertificateErrorsCommand = new("Security.setOverrideCertificateErrors", JsonContext.SetOverrideCertificateErrorsCommandParameters, JsonContext.SetOverrideCertificateErrorsResult);

    /// <summary>
    /// There is a certificate error. If overriding certificate errors is enabled, then it should be
    /// handled with the <b>handleCertificateError</b> command. Note: this event does not fire if the
    /// certificate error has been allowed internally. Only one client per target should override
    /// certificate errors at the same time.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="CertificateErrorEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>EventId</b> - The ID of the event.</description></item>
    /// <item><description><b>ErrorType</b> - The type of the error.</description></item>
    /// <item><description><b>RequestURL</b> - The url that was requested.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Obsolete]
    public IEventSource<CertificateErrorEventArgs> CertificateError => CreateCdpEventSource(SecurityDomainEvent.CertificateError);
    /// <summary>
    /// The security state of the page changed.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="VisibleSecurityStateChangedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>VisibleSecurityState</b> - Security state information about the page.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<VisibleSecurityStateChangedEventArgs> VisibleSecurityStateChanged => CreateCdpEventSource(SecurityDomainEvent.VisibleSecurityStateChanged);
    /// <summary>
    /// The security state of the page changed. No longer being sent.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="SecurityStateChangedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>SecurityState</b> - Security state.</description></item>
    /// <item><description><b>SchemeIsCryptographic</b> - True if the page was loaded over cryptographic transport such as HTTPS.</description></item>
    /// <item><description><b>Explanations</b> - Previously a list of explanations for the security state. Now always empty.</description></item>
    /// <item><description><b>InsecureContentStatus</b> - Information about insecure content on the page.</description></item>
    /// <item><description><b>Summary</b> - Overrides user-visible description of the state. Always omitted.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Obsolete]
    public IEventSource<SecurityStateChangedEventArgs> SecurityStateChanged => CreateCdpEventSource(SecurityDomainEvent.SecurityStateChanged);
}

internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="SecurityDomain.DisableAsync"/>.
/// </summary>
public sealed record DisableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="SecurityDomain.EnableAsync"/>.
/// </summary>
public sealed record EnableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record SetIgnoreCertificateErrorsCommandParameters(bool Ignore) : Parameters;

/// <summary>
/// Optional parameters for <see cref="SecurityDomain.SetIgnoreCertificateErrorsAsync"/>.
/// </summary>
public sealed record SetIgnoreCertificateErrorsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetIgnoreCertificateErrorsResult() : EmptyResult;


internal sealed record HandleCertificateErrorCommandParameters(long EventId, CertificateErrorAction Action) : Parameters;

/// <summary>
/// Optional parameters for <see cref="SecurityDomain.HandleCertificateErrorAsync"/>.
/// </summary>
public sealed record HandleCertificateErrorCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record HandleCertificateErrorResult() : EmptyResult;


internal sealed record SetOverrideCertificateErrorsCommandParameters(bool Override) : Parameters;

/// <summary>
/// Optional parameters for <see cref="SecurityDomain.SetOverrideCertificateErrorsAsync"/>.
/// </summary>
public sealed record SetOverrideCertificateErrorsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetOverrideCertificateErrorsResult() : EmptyResult;


/// <summary>
/// There is a certificate error. If overriding certificate errors is enabled, then it should be
/// handled with the <b>handleCertificateError</b> command. Note: this event does not fire if the
/// certificate error has been allowed internally. Only one client per target should override
/// certificate errors at the same time.
/// </summary>
/// <param name="EventId">
/// The ID of the event.
/// </param>
/// <param name="ErrorType">
/// The type of the error.
/// </param>
/// <param name="RequestURL">
/// The url that was requested.
/// </param>
public sealed record CertificateErrorEventArgs(long EventId, string ErrorType, string RequestURL) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// The security state of the page changed.
/// </summary>
/// <param name="VisibleSecurityState">
/// Security state information about the page.
/// </param>
public sealed record VisibleSecurityStateChangedEventArgs(VisibleSecurityState VisibleSecurityState) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// The security state of the page changed. No longer being sent.
/// </summary>
/// <param name="SecurityState">
/// Security state.
/// </param>
/// <param name="SchemeIsCryptographic">
/// True if the page was loaded over cryptographic transport such as HTTPS.
/// </param>
/// <param name="Explanations">
/// Previously a list of explanations for the security state. Now always
/// empty.
/// </param>
/// <param name="InsecureContentStatus">
/// Information about insecure content on the page.
/// </param>
/// <param name="Summary">
/// Overrides user-visible description of the state. Always omitted.
/// </param>
public sealed record SecurityStateChangedEventArgs(SecurityState SecurityState, bool SchemeIsCryptographic, IEnumerable<SecurityStateExplanation> Explanations, InsecureContentStatus InsecureContentStatus, string? Summary = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// An internal certificate ID value.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.NumberRemoteIdConverter<CertificateId>))]
public record CertificateId : INumberRemoteId
{
    double INumberRemoteId.Id { get; init; }
}

/// <summary>
/// A description of mixed content (HTTP resources on HTTPS pages), as defined by
/// https://www.w3.org/TR/mixed-content/#categories
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<MixedContentType>))]
public enum MixedContentType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("blockable")]
    Blockable,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("optionally-blockable")]
    OptionallyBlockable,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("none")]
    None,
}

/// <summary>
/// The security level of a page or resource.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<SecurityState>))]
public enum SecurityState
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("unknown")]
    Unknown,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("neutral")]
    Neutral,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("insecure")]
    Insecure,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("secure")]
    Secure,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("info")]
    Info,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("insecure-broken")]
    InsecureBroken,
}

/// <summary>
/// Details about the security state of the page certificate.
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
/// <param name="Certificate">
/// Page certificate.
/// </param>
/// <param name="SubjectName">
/// Certificate subject name.
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
/// <param name="CertificateHasWeakSignature">
/// True if the certificate uses a weak signature algorithm.
/// </param>
/// <param name="CertificateHasSha1Signature">
/// True if the certificate has a SHA1 signature in the chain.
/// </param>
/// <param name="ModernSSL">
/// True if modern SSL
/// </param>
/// <param name="ObsoleteSslProtocol">
/// True if the connection is using an obsolete SSL protocol.
/// </param>
/// <param name="ObsoleteSslKeyExchange">
/// True if the connection is using an obsolete SSL key exchange.
/// </param>
/// <param name="ObsoleteSslCipher">
/// True if the connection is using an obsolete SSL cipher.
/// </param>
/// <param name="ObsoleteSslSignature">
/// True if the connection is using an obsolete SSL signature.
/// </param>
public sealed record CertificateSecurityState(string Protocol, string KeyExchange, string Cipher, IReadOnlyList<string> Certificate, string SubjectName, string Issuer, Network.TimeSinceEpoch ValidFrom, Network.TimeSinceEpoch ValidTo, bool CertificateHasWeakSignature, bool CertificateHasSha1Signature, bool ModernSSL, bool ObsoleteSslProtocol, bool ObsoleteSslKeyExchange, bool ObsoleteSslCipher, bool ObsoleteSslSignature)
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
    /// The highest priority network error code, if the certificate has an error.
    /// </summary>
    public string? CertificateNetworkError { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<SafetyTipStatus>))]
public enum SafetyTipStatus
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("badReputation")]
    BadReputation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("lookalike")]
    Lookalike,
}

/// <summary>
/// </summary>
/// <param name="SafetyTipStatus">
/// Describes whether the page triggers any safety tips or reputation warnings. Default is unknown.
/// </param>
public sealed record SafetyTipInfo(SafetyTipStatus SafetyTipStatus)
{
    /// <summary>
    /// The URL the safety tip suggested ("Did you mean?"). Only filled in for lookalike matches.
    /// </summary>
    public string? SafeUrl { get; init; }
}

/// <summary>
/// Security state information about the page.
/// </summary>
/// <param name="SecurityState">
/// The security level of the page.
/// </param>
/// <param name="SecurityStateIssueIds">
/// Array of security state issues ids.
/// </param>
public sealed record VisibleSecurityState(SecurityState SecurityState, IReadOnlyList<string> SecurityStateIssueIds)
{
    /// <summary>
    /// Security state details about the page certificate.
    /// </summary>
    public CertificateSecurityState? CertificateSecurityState { get; init; }

    /// <summary>
    /// The type of Safety Tip triggered on the page. Note that this field will be set even if the Safety Tip UI was not actually shown.
    /// </summary>
    public SafetyTipInfo? SafetyTipInfo { get; init; }
}

/// <summary>
/// An explanation of an factor contributing to the security state.
/// </summary>
/// <param name="SecurityState">
/// Security state representing the severity of the factor being explained.
/// </param>
/// <param name="Title">
/// Title describing the type of factor.
/// </param>
/// <param name="Summary">
/// Short phrase describing the type of factor.
/// </param>
/// <param name="Description">
/// Full text explanation of the factor.
/// </param>
/// <param name="MixedContentType">
/// The type of mixed content described by the explanation.
/// </param>
/// <param name="Certificate">
/// Page certificate.
/// </param>
public sealed record SecurityStateExplanation(SecurityState SecurityState, string Title, string Summary, string Description, MixedContentType MixedContentType, IReadOnlyList<string> Certificate)
{
    /// <summary>
    /// Recommendations to fix any issues.
    /// </summary>
    public IReadOnlyList<string>? Recommendations { get; init; }
}

/// <summary>
/// Information about insecure content on the page.
/// </summary>
/// <param name="RanMixedContent">
/// Always false.
/// </param>
/// <param name="DisplayedMixedContent">
/// Always false.
/// </param>
/// <param name="ContainedMixedForm">
/// Always false.
/// </param>
/// <param name="RanContentWithCertErrors">
/// Always false.
/// </param>
/// <param name="DisplayedContentWithCertErrors">
/// Always false.
/// </param>
/// <param name="RanInsecureContentStyle">
/// Always set to unknown.
/// </param>
/// <param name="DisplayedInsecureContentStyle">
/// Always set to unknown.
/// </param>
[global::System.Obsolete]
public sealed record InsecureContentStatus(bool RanMixedContent, bool DisplayedMixedContent, bool ContainedMixedForm, bool RanContentWithCertErrors, bool DisplayedContentWithCertErrors, SecurityState RanInsecureContentStyle, SecurityState DisplayedInsecureContentStyle)
{
}

/// <summary>
/// The action to take when a certificate error occurs. continue will continue processing the
/// request and cancel will cancel the request.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<CertificateErrorAction>))]
public enum CertificateErrorAction
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("continue")]
    Continue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("cancel")]
    Cancel,
}

[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(SetIgnoreCertificateErrorsCommandParameters), TypeInfoPropertyName = "SetIgnoreCertificateErrorsCommandParameters")]
[JsonSerializable(typeof(SetIgnoreCertificateErrorsResult), TypeInfoPropertyName = "SetIgnoreCertificateErrorsResult")]
[JsonSerializable(typeof(HandleCertificateErrorCommandParameters), TypeInfoPropertyName = "HandleCertificateErrorCommandParameters")]
[JsonSerializable(typeof(HandleCertificateErrorResult), TypeInfoPropertyName = "HandleCertificateErrorResult")]
[JsonSerializable(typeof(SetOverrideCertificateErrorsCommandParameters), TypeInfoPropertyName = "SetOverrideCertificateErrorsCommandParameters")]
[JsonSerializable(typeof(SetOverrideCertificateErrorsResult), TypeInfoPropertyName = "SetOverrideCertificateErrorsResult")]
[JsonSerializable(typeof(CdpEventArgs<CertificateErrorEventArgs>), TypeInfoPropertyName = "CertificateErrorCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<VisibleSecurityStateChangedEventArgs>), TypeInfoPropertyName = "VisibleSecurityStateChangedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<SecurityStateChangedEventArgs>), TypeInfoPropertyName = "SecurityStateChangedCdpEventArgs")]
[JsonSerializable(typeof(CertificateId), TypeInfoPropertyName = "SecurityCertificateId")]
[JsonSerializable(typeof(MixedContentType), TypeInfoPropertyName = "SecurityMixedContentType")]
[JsonSerializable(typeof(SecurityState), TypeInfoPropertyName = "SecuritySecurityState")]
[JsonSerializable(typeof(CertificateSecurityState), TypeInfoPropertyName = "SecurityCertificateSecurityState")]
[JsonSerializable(typeof(SafetyTipStatus), TypeInfoPropertyName = "SecuritySafetyTipStatus")]
[JsonSerializable(typeof(SafetyTipInfo), TypeInfoPropertyName = "SecuritySafetyTipInfo")]
[JsonSerializable(typeof(VisibleSecurityState), TypeInfoPropertyName = "SecurityVisibleSecurityState")]
[JsonSerializable(typeof(SecurityStateExplanation), TypeInfoPropertyName = "SecuritySecurityStateExplanation")]
[JsonSerializable(typeof(InsecureContentStatus), TypeInfoPropertyName = "SecurityInsecureContentStatus")]
[JsonSerializable(typeof(CertificateErrorAction), TypeInfoPropertyName = "SecurityCertificateErrorAction")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<SecurityStateExplanation>), TypeInfoPropertyName = "IReadOnlyListSecuritySecurityStateExplanation")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class SecurityJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="SecurityDomain"/>.
/// </summary>
public static class SecurityDomainEvent
{
    /// <summary>
    /// There is a certificate error. If overriding certificate errors is enabled, then it should be
    /// handled with the <b>handleCertificateError</b> command. Note: this event does not fire if the
    /// certificate error has been allowed internally. Only one client per target should override
    /// certificate errors at the same time.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<CertificateErrorEventArgs>> CertificateError { get; } =
        EventDescriptor<CdpEventArgs<CertificateErrorEventArgs>>.Create(
            "goog:cdp.Security.certificateError",
            SecurityJsonSerializerContext.Default.CertificateErrorCdpEventArgs);

    /// <summary>
    /// The security state of the page changed.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<VisibleSecurityStateChangedEventArgs>> VisibleSecurityStateChanged { get; } =
        EventDescriptor<CdpEventArgs<VisibleSecurityStateChangedEventArgs>>.Create(
            "goog:cdp.Security.visibleSecurityStateChanged",
            SecurityJsonSerializerContext.Default.VisibleSecurityStateChangedCdpEventArgs);

    /// <summary>
    /// The security state of the page changed. No longer being sent.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<SecurityStateChangedEventArgs>> SecurityStateChanged { get; } =
        EventDescriptor<CdpEventArgs<SecurityStateChangedEventArgs>>.Create(
            "goog:cdp.Security.securityStateChanged",
            SecurityJsonSerializerContext.Default.SecurityStateChangedCdpEventArgs);

}
