#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.WebAuthn;

/// <summary>
/// This domain allows configuring virtual authenticators to test the WebAuthn
/// API.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class WebAuthnDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static WebAuthnJsonSerializerContext JsonContext = WebAuthnJsonSerializerContext.Default;

    /// <summary>
    /// Enable the WebAuthn domain and start intercepting credential storage and
    /// retrieval with a virtual authenticator.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>EnableUI</b> - Whether to enable the WebAuthn user interface. Enabling the UI is recommended for debugging and demo purposes, as it is closer to the real experience. Disabling the UI is recommended for automated testing. Supported at the embedder's discretion if UI is available. Defaults to false.</description></item>
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
        var @params = new EnableCommandParameters(EnableUI: options?.EnableUI);
        return await ExecuteCommandAsync(EnableCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("WebAuthn.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Disable the WebAuthn domain.
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
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("WebAuthn.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Creates and adds a virtual authenticator.
    /// </summary>
    /// <param name="options">
    /// </param>
    /// <param name="addVirtualAuthenticatorOptions">
    /// Optional parameters. See <see cref="AddVirtualAuthenticatorCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AddVirtualAuthenticatorResult"/>.
    /// </returns>
    public async Task<AddVirtualAuthenticatorResult> AddVirtualAuthenticatorAsync(VirtualAuthenticatorOptions options, AddVirtualAuthenticatorCommandOptions? addVirtualAuthenticatorOptions = default, CancellationToken cancellationToken = default)
    {
        var @params = new AddVirtualAuthenticatorCommandParameters(Options: options);
        return await ExecuteCommandAsync(AddVirtualAuthenticatorCommand, @params, addVirtualAuthenticatorOptions, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AddVirtualAuthenticatorCommandParameters, AddVirtualAuthenticatorResult> AddVirtualAuthenticatorCommand = new("WebAuthn.addVirtualAuthenticator", JsonContext.AddVirtualAuthenticatorCommandParameters, JsonContext.AddVirtualAuthenticatorResult);

    /// <summary>
    /// Resets parameters isBogusSignature, isBadUV, isBadUP to false if they are not present.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>IsBogusSignature</b> - If isBogusSignature is set, overrides the signature in the authenticator response to be zero. Defaults to false.</description></item>
    /// <item><description><b>IsBadUV</b> - If isBadUV is set, overrides the UV bit in the flags in the authenticator response to be zero. Defaults to false.</description></item>
    /// <item><description><b>IsBadUP</b> - If isBadUP is set, overrides the UP bit in the flags in the authenticator response to be zero. Defaults to false.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="authenticatorId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetResponseOverrideBitsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetResponseOverrideBitsResult"/>.
    /// </returns>
    public async Task<SetResponseOverrideBitsResult> SetResponseOverrideBitsAsync(AuthenticatorId authenticatorId, SetResponseOverrideBitsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetResponseOverrideBitsCommandParameters(AuthenticatorId: authenticatorId, IsBogusSignature: options?.IsBogusSignature, IsBadUV: options?.IsBadUV, IsBadUP: options?.IsBadUP);
        return await ExecuteCommandAsync(SetResponseOverrideBitsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetResponseOverrideBitsCommandParameters, SetResponseOverrideBitsResult> SetResponseOverrideBitsCommand = new("WebAuthn.setResponseOverrideBits", JsonContext.SetResponseOverrideBitsCommandParameters, JsonContext.SetResponseOverrideBitsResult);

    /// <summary>
    /// Removes the given authenticator.
    /// </summary>
    /// <param name="authenticatorId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="RemoveVirtualAuthenticatorCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RemoveVirtualAuthenticatorResult"/>.
    /// </returns>
    public async Task<RemoveVirtualAuthenticatorResult> RemoveVirtualAuthenticatorAsync(AuthenticatorId authenticatorId, RemoveVirtualAuthenticatorCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveVirtualAuthenticatorCommandParameters(AuthenticatorId: authenticatorId);
        return await ExecuteCommandAsync(RemoveVirtualAuthenticatorCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RemoveVirtualAuthenticatorCommandParameters, RemoveVirtualAuthenticatorResult> RemoveVirtualAuthenticatorCommand = new("WebAuthn.removeVirtualAuthenticator", JsonContext.RemoveVirtualAuthenticatorCommandParameters, JsonContext.RemoveVirtualAuthenticatorResult);

    /// <summary>
    /// Adds the credential to the specified authenticator.
    /// </summary>
    /// <param name="authenticatorId">
    /// </param>
    /// <param name="credential">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="AddCredentialCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AddCredentialResult"/>.
    /// </returns>
    public async Task<AddCredentialResult> AddCredentialAsync(AuthenticatorId authenticatorId, Credential credential, AddCredentialCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new AddCredentialCommandParameters(AuthenticatorId: authenticatorId, Credential: credential);
        return await ExecuteCommandAsync(AddCredentialCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AddCredentialCommandParameters, AddCredentialResult> AddCredentialCommand = new("WebAuthn.addCredential", JsonContext.AddCredentialCommandParameters, JsonContext.AddCredentialResult);

    /// <summary>
    /// Returns a single credential stored in the given virtual authenticator that
    /// matches the credential ID.
    /// </summary>
    /// <param name="authenticatorId">
    /// </param>
    /// <param name="credentialId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetCredentialCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetCredentialResult"/>.
    /// </returns>
    public async Task<GetCredentialResult> GetCredentialAsync(AuthenticatorId authenticatorId, string credentialId, GetCredentialCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetCredentialCommandParameters(AuthenticatorId: authenticatorId, CredentialId: credentialId);
        return await ExecuteCommandAsync(GetCredentialCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetCredentialCommandParameters, GetCredentialResult> GetCredentialCommand = new("WebAuthn.getCredential", JsonContext.GetCredentialCommandParameters, JsonContext.GetCredentialResult);

    /// <summary>
    /// Returns all the credentials stored in the given virtual authenticator.
    /// </summary>
    /// <param name="authenticatorId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetCredentialsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetCredentialsResult"/>.
    /// </returns>
    public async Task<GetCredentialsResult> GetCredentialsAsync(AuthenticatorId authenticatorId, GetCredentialsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetCredentialsCommandParameters(AuthenticatorId: authenticatorId);
        return await ExecuteCommandAsync(GetCredentialsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetCredentialsCommandParameters, GetCredentialsResult> GetCredentialsCommand = new("WebAuthn.getCredentials", JsonContext.GetCredentialsCommandParameters, JsonContext.GetCredentialsResult);

    /// <summary>
    /// Removes a credential from the authenticator.
    /// </summary>
    /// <param name="authenticatorId">
    /// </param>
    /// <param name="credentialId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="RemoveCredentialCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RemoveCredentialResult"/>.
    /// </returns>
    public async Task<RemoveCredentialResult> RemoveCredentialAsync(AuthenticatorId authenticatorId, string credentialId, RemoveCredentialCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveCredentialCommandParameters(AuthenticatorId: authenticatorId, CredentialId: credentialId);
        return await ExecuteCommandAsync(RemoveCredentialCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RemoveCredentialCommandParameters, RemoveCredentialResult> RemoveCredentialCommand = new("WebAuthn.removeCredential", JsonContext.RemoveCredentialCommandParameters, JsonContext.RemoveCredentialResult);

    /// <summary>
    /// Clears all the credentials from the specified device.
    /// </summary>
    /// <param name="authenticatorId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ClearCredentialsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearCredentialsResult"/>.
    /// </returns>
    public async Task<ClearCredentialsResult> ClearCredentialsAsync(AuthenticatorId authenticatorId, ClearCredentialsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearCredentialsCommandParameters(AuthenticatorId: authenticatorId);
        return await ExecuteCommandAsync(ClearCredentialsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearCredentialsCommandParameters, ClearCredentialsResult> ClearCredentialsCommand = new("WebAuthn.clearCredentials", JsonContext.ClearCredentialsCommandParameters, JsonContext.ClearCredentialsResult);

    /// <summary>
    /// Sets whether User Verification succeeds or fails for an authenticator.
    /// The default is true.
    /// </summary>
    /// <param name="authenticatorId">
    /// </param>
    /// <param name="isUserVerified">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetUserVerifiedCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetUserVerifiedResult"/>.
    /// </returns>
    public async Task<SetUserVerifiedResult> SetUserVerifiedAsync(AuthenticatorId authenticatorId, bool isUserVerified, SetUserVerifiedCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetUserVerifiedCommandParameters(AuthenticatorId: authenticatorId, IsUserVerified: isUserVerified);
        return await ExecuteCommandAsync(SetUserVerifiedCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetUserVerifiedCommandParameters, SetUserVerifiedResult> SetUserVerifiedCommand = new("WebAuthn.setUserVerified", JsonContext.SetUserVerifiedCommandParameters, JsonContext.SetUserVerifiedResult);

    /// <summary>
    /// Sets whether tests of user presence will succeed immediately (if true) or fail to resolve (if false) for an authenticator.
    /// The default is true.
    /// </summary>
    /// <param name="authenticatorId">
    /// </param>
    /// <param name="enabled">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetAutomaticPresenceSimulationCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetAutomaticPresenceSimulationResult"/>.
    /// </returns>
    public async Task<SetAutomaticPresenceSimulationResult> SetAutomaticPresenceSimulationAsync(AuthenticatorId authenticatorId, bool enabled, SetAutomaticPresenceSimulationCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetAutomaticPresenceSimulationCommandParameters(AuthenticatorId: authenticatorId, Enabled: enabled);
        return await ExecuteCommandAsync(SetAutomaticPresenceSimulationCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetAutomaticPresenceSimulationCommandParameters, SetAutomaticPresenceSimulationResult> SetAutomaticPresenceSimulationCommand = new("WebAuthn.setAutomaticPresenceSimulation", JsonContext.SetAutomaticPresenceSimulationCommandParameters, JsonContext.SetAutomaticPresenceSimulationResult);

    /// <summary>
    /// Allows setting credential properties.
    /// https://w3c.github.io/webauthn/#sctn-automation-set-credential-properties
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>BackupEligibility</b></description></item>
    /// <item><description><b>BackupState</b></description></item>
    /// </list>
    /// </remarks>
    /// <param name="authenticatorId">
    /// </param>
    /// <param name="credentialId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetCredentialPropertiesCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetCredentialPropertiesResult"/>.
    /// </returns>
    public async Task<SetCredentialPropertiesResult> SetCredentialPropertiesAsync(AuthenticatorId authenticatorId, string credentialId, SetCredentialPropertiesCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetCredentialPropertiesCommandParameters(AuthenticatorId: authenticatorId, CredentialId: credentialId, BackupEligibility: options?.BackupEligibility, BackupState: options?.BackupState);
        return await ExecuteCommandAsync(SetCredentialPropertiesCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetCredentialPropertiesCommandParameters, SetCredentialPropertiesResult> SetCredentialPropertiesCommand = new("WebAuthn.setCredentialProperties", JsonContext.SetCredentialPropertiesCommandParameters, JsonContext.SetCredentialPropertiesResult);

    /// <summary>
    /// Triggered when a credential is added to an authenticator.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="CredentialAddedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>AuthenticatorId</b></description></item>
    /// <item><description><b>Credential</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<CredentialAddedEventArgs> CredentialAdded => CreateCdpEventSource(WebAuthnDomainEvent.CredentialAdded);
    /// <summary>
    /// Triggered when a credential is deleted, e.g. through
    /// PublicKeyCredential.signalUnknownCredential().
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="CredentialDeletedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>AuthenticatorId</b></description></item>
    /// <item><description><b>CredentialId</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<CredentialDeletedEventArgs> CredentialDeleted => CreateCdpEventSource(WebAuthnDomainEvent.CredentialDeleted);
    /// <summary>
    /// Triggered when a credential is updated, e.g. through
    /// PublicKeyCredential.signalCurrentUserDetails().
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="CredentialUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>AuthenticatorId</b></description></item>
    /// <item><description><b>Credential</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<CredentialUpdatedEventArgs> CredentialUpdated => CreateCdpEventSource(WebAuthnDomainEvent.CredentialUpdated);
    /// <summary>
    /// Triggered when a credential is used in a webauthn assertion.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="CredentialAssertedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>AuthenticatorId</b></description></item>
    /// <item><description><b>Credential</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<CredentialAssertedEventArgs> CredentialAsserted => CreateCdpEventSource(WebAuthnDomainEvent.CredentialAsserted);
}

internal sealed record EnableCommandParameters(bool? EnableUI) : Parameters;

/// <summary>
/// Optional parameters for <see cref="WebAuthnDomain.EnableAsync"/>.
/// </summary>
public sealed record EnableCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Whether to enable the WebAuthn user interface. Enabling the UI is
    /// recommended for debugging and demo purposes, as it is closer to the real
    /// experience. Disabling the UI is recommended for automated testing.
    /// Supported at the embedder's discretion if UI is available.
    /// Defaults to false.
    /// </summary>
    public bool? EnableUI { get; init; }
}

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="WebAuthnDomain.DisableAsync"/>.
/// </summary>
public sealed record DisableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record AddVirtualAuthenticatorCommandParameters(VirtualAuthenticatorOptions Options) : Parameters;

/// <summary>
/// Optional parameters for <see cref="WebAuthnDomain.AddVirtualAuthenticatorAsync"/>.
/// </summary>
public sealed record AddVirtualAuthenticatorCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="AuthenticatorId">
/// </param>
public sealed record AddVirtualAuthenticatorResult(AuthenticatorId AuthenticatorId) : EmptyResult;


internal sealed record SetResponseOverrideBitsCommandParameters(AuthenticatorId AuthenticatorId, bool? IsBogusSignature, bool? IsBadUV, bool? IsBadUP) : Parameters;

/// <summary>
/// Optional parameters for <see cref="WebAuthnDomain.SetResponseOverrideBitsAsync"/>.
/// </summary>
public sealed record SetResponseOverrideBitsCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// If isBogusSignature is set, overrides the signature in the authenticator response to be zero.
    /// Defaults to false.
    /// </summary>
    public bool? IsBogusSignature { get; init; }

    /// <summary>
    /// If isBadUV is set, overrides the UV bit in the flags in the authenticator response to
    /// be zero. Defaults to false.
    /// </summary>
    public bool? IsBadUV { get; init; }

    /// <summary>
    /// If isBadUP is set, overrides the UP bit in the flags in the authenticator response to
    /// be zero. Defaults to false.
    /// </summary>
    public bool? IsBadUP { get; init; }
}

/// <summary>
/// </summary>
public sealed record SetResponseOverrideBitsResult() : EmptyResult;


internal sealed record RemoveVirtualAuthenticatorCommandParameters(AuthenticatorId AuthenticatorId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="WebAuthnDomain.RemoveVirtualAuthenticatorAsync"/>.
/// </summary>
public sealed record RemoveVirtualAuthenticatorCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record RemoveVirtualAuthenticatorResult() : EmptyResult;


internal sealed record AddCredentialCommandParameters(AuthenticatorId AuthenticatorId, Credential Credential) : Parameters;

/// <summary>
/// Optional parameters for <see cref="WebAuthnDomain.AddCredentialAsync"/>.
/// </summary>
public sealed record AddCredentialCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record AddCredentialResult() : EmptyResult;


internal sealed record GetCredentialCommandParameters(AuthenticatorId AuthenticatorId, string CredentialId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="WebAuthnDomain.GetCredentialAsync"/>.
/// </summary>
public sealed record GetCredentialCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Credential">
/// </param>
public sealed record GetCredentialResult(Credential Credential) : EmptyResult;


internal sealed record GetCredentialsCommandParameters(AuthenticatorId AuthenticatorId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="WebAuthnDomain.GetCredentialsAsync"/>.
/// </summary>
public sealed record GetCredentialsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Credentials">
/// </param>
public sealed record GetCredentialsResult(IReadOnlyList<Credential> Credentials) : EmptyResult;


internal sealed record RemoveCredentialCommandParameters(AuthenticatorId AuthenticatorId, string CredentialId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="WebAuthnDomain.RemoveCredentialAsync"/>.
/// </summary>
public sealed record RemoveCredentialCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record RemoveCredentialResult() : EmptyResult;


internal sealed record ClearCredentialsCommandParameters(AuthenticatorId AuthenticatorId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="WebAuthnDomain.ClearCredentialsAsync"/>.
/// </summary>
public sealed record ClearCredentialsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ClearCredentialsResult() : EmptyResult;


internal sealed record SetUserVerifiedCommandParameters(AuthenticatorId AuthenticatorId, bool IsUserVerified) : Parameters;

/// <summary>
/// Optional parameters for <see cref="WebAuthnDomain.SetUserVerifiedAsync"/>.
/// </summary>
public sealed record SetUserVerifiedCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetUserVerifiedResult() : EmptyResult;


internal sealed record SetAutomaticPresenceSimulationCommandParameters(AuthenticatorId AuthenticatorId, bool Enabled) : Parameters;

/// <summary>
/// Optional parameters for <see cref="WebAuthnDomain.SetAutomaticPresenceSimulationAsync"/>.
/// </summary>
public sealed record SetAutomaticPresenceSimulationCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetAutomaticPresenceSimulationResult() : EmptyResult;


internal sealed record SetCredentialPropertiesCommandParameters(AuthenticatorId AuthenticatorId, string CredentialId, bool? BackupEligibility, bool? BackupState) : Parameters;

/// <summary>
/// Optional parameters for <see cref="WebAuthnDomain.SetCredentialPropertiesAsync"/>.
/// </summary>
public sealed record SetCredentialPropertiesCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// </summary>
    public bool? BackupEligibility { get; init; }

    /// <summary>
    /// </summary>
    public bool? BackupState { get; init; }
}

/// <summary>
/// </summary>
public sealed record SetCredentialPropertiesResult() : EmptyResult;


/// <summary>
/// Triggered when a credential is added to an authenticator.
/// </summary>
/// <param name="AuthenticatorId">
/// </param>
/// <param name="Credential">
/// </param>
public sealed record CredentialAddedEventArgs(AuthenticatorId AuthenticatorId, Credential Credential) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Triggered when a credential is deleted, e.g. through
/// PublicKeyCredential.signalUnknownCredential().
/// </summary>
/// <param name="AuthenticatorId">
/// </param>
/// <param name="CredentialId">
/// </param>
public sealed record CredentialDeletedEventArgs(AuthenticatorId AuthenticatorId, string CredentialId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Triggered when a credential is updated, e.g. through
/// PublicKeyCredential.signalCurrentUserDetails().
/// </summary>
/// <param name="AuthenticatorId">
/// </param>
/// <param name="Credential">
/// </param>
public sealed record CredentialUpdatedEventArgs(AuthenticatorId AuthenticatorId, Credential Credential) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Triggered when a credential is used in a webauthn assertion.
/// </summary>
/// <param name="AuthenticatorId">
/// </param>
/// <param name="Credential">
/// </param>
public sealed record CredentialAssertedEventArgs(AuthenticatorId AuthenticatorId, Credential Credential) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<AuthenticatorId>))]
public record AuthenticatorId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<AuthenticatorProtocol>))]
public enum AuthenticatorProtocol
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("u2f")]
    U2f,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ctap2")]
    Ctap2,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<Ctap2Version>))]
public enum Ctap2Version
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ctap2_0")]
    Ctap20,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ctap2_1")]
    Ctap21,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ctap2_2")]
    Ctap22,
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<AuthenticatorTransport>))]
public enum AuthenticatorTransport
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("usb")]
    Usb,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("nfc")]
    Nfc,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ble")]
    Ble,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("cable")]
    Cable,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("internal")]
    Internal,
}

/// <summary>
/// </summary>
/// <param name="Protocol">
/// </param>
/// <param name="Transport">
/// </param>
public sealed record VirtualAuthenticatorOptions(AuthenticatorProtocol Protocol, AuthenticatorTransport Transport)
{
    /// <summary>
    /// Defaults to ctap2_0. Ignored if |protocol| == u2f.
    /// </summary>
    public Ctap2Version? Ctap2Version { get; init; }

    /// <summary>
    /// Defaults to false.
    /// </summary>
    public bool? HasResidentKey { get; init; }

    /// <summary>
    /// Defaults to false.
    /// </summary>
    public bool? HasUserVerification { get; init; }

    /// <summary>
    /// If set to true, the authenticator will support the largeBlob extension.
    /// https://w3c.github.io/webauthn#largeBlob
    /// Defaults to false.
    /// </summary>
    public bool? HasLargeBlob { get; init; }

    /// <summary>
    /// If set to true, the authenticator will support the credBlob extension.
    /// https://fidoalliance.org/specs/fido-v2.1-rd-20201208/fido-client-to-authenticator-protocol-v2.1-rd-20201208.html#sctn-credBlob-extension
    /// Defaults to false.
    /// </summary>
    public bool? HasCredBlob { get; init; }

    /// <summary>
    /// If set to true, the authenticator will support the minPinLength extension.
    /// https://fidoalliance.org/specs/fido-v2.1-ps-20210615/fido-client-to-authenticator-protocol-v2.1-ps-20210615.html#sctn-minpinlength-extension
    /// Defaults to false.
    /// </summary>
    public bool? HasMinPinLength { get; init; }

    /// <summary>
    /// If set to true, the authenticator will support the prf extension.
    /// https://w3c.github.io/webauthn/#prf-extension
    /// Defaults to false.
    /// </summary>
    public bool? HasPrf { get; init; }

    /// <summary>
    /// If set to true, the authenticator will support the hmac-secret extension.
    /// https://fidoalliance.org/specs/fido-v2.1-ps-20210615/fido-client-to-authenticator-protocol-v2.1-ps-20210615.html#sctn-hmac-secret-extension
    /// Defaults to false.
    /// </summary>
    public bool? HasHmacSecret { get; init; }

    /// <summary>
    /// If set to true, the authenticator will support the hmac-secret-mc extension.
    /// https://fidoalliance.org/specs/fido-v2.2-rd-20241003/fido-client-to-authenticator-protocol-v2.2-rd-20241003.html#sctn-hmac-secret-make-cred-extension
    /// Defaults to false.
    /// </summary>
    public bool? HasHmacSecretMc { get; init; }

    /// <summary>
    /// If set to true, the authenticator will support the cmtgKey (Credential
    /// Manager Trust Group Key) extension.
    /// https://github.com/w3c/webauthn/pull/2377
    /// Defaults to false.
    /// </summary>
    public bool? HasCmtgKey { get; init; }

    /// <summary>
    /// If set to true, tests of user presence will succeed immediately.
    /// Otherwise, they will not be resolved. Defaults to true.
    /// </summary>
    public bool? AutomaticPresenceSimulation { get; init; }

    /// <summary>
    /// Sets whether User Verification succeeds or fails for an authenticator.
    /// Defaults to false.
    /// </summary>
    public bool? IsUserVerified { get; init; }

    /// <summary>
    /// Credentials created by this authenticator will have the backup
    /// eligibility (BE) flag set to this value. Defaults to false.
    /// https://w3c.github.io/webauthn/#sctn-credential-backup
    /// </summary>
    public bool? DefaultBackupEligibility { get; init; }

    /// <summary>
    /// Credentials created by this authenticator will have the backup state
    /// (BS) flag set to this value. Defaults to false.
    /// https://w3c.github.io/webauthn/#sctn-credential-backup
    /// </summary>
    public bool? DefaultBackupState { get; init; }
}

/// <summary>
/// </summary>
/// <param name="CredentialId">
/// </param>
/// <param name="IsResidentCredential">
/// </param>
/// <param name="PrivateKey">
/// The ECDSA P-256 private key in PKCS#8 format. (Encoded as a base64 string when passed over JSON)
/// </param>
/// <param name="SignCount">
/// Signature counter. This is incremented by one for each successful
/// assertion.
/// See https://w3c.github.io/webauthn/#signature-counter
/// </param>
public sealed record Credential(string CredentialId, bool IsResidentCredential, string PrivateKey, long SignCount)
{
    /// <summary>
    /// Relying Party ID the credential is scoped to. Must be set when adding a
    /// credential.
    /// </summary>
    public string? RpId { get; init; }

    /// <summary>
    /// An opaque byte sequence with a maximum size of 64 bytes mapping the
    /// credential to a specific user. (Encoded as a base64 string when passed over JSON)
    /// </summary>
    public string? UserHandle { get; init; }

    /// <summary>
    /// The large blob associated with the credential.
    /// See https://w3c.github.io/webauthn/#sctn-large-blob-extension (Encoded as a base64 string when passed over JSON)
    /// </summary>
    public string? LargeBlob { get; init; }

    /// <summary>
    /// Assertions returned by this credential will have the backup eligibility
    /// (BE) flag set to this value. Defaults to the authenticator's
    /// defaultBackupEligibility value.
    /// </summary>
    public bool? BackupEligibility { get; init; }

    /// <summary>
    /// Assertions returned by this credential will have the backup state (BS)
    /// flag set to this value. Defaults to the authenticator's
    /// defaultBackupState value.
    /// </summary>
    public bool? BackupState { get; init; }

    /// <summary>
    /// The credential's user.name property. Equivalent to empty if not set.
    /// https://w3c.github.io/webauthn/#dom-publickeycredentialentity-name
    /// </summary>
    public string? UserName { get; init; }

    /// <summary>
    /// The credential's user.displayName property. Equivalent to empty if
    /// not set.
    /// https://w3c.github.io/webauthn/#dom-publickeycredentialuserentity-displayname
    /// </summary>
    public string? UserDisplayName { get; init; }

    /// <summary>
    /// The CMTG keys associated with the credential.
    /// </summary>
    public IReadOnlyList<string>? CmtgKeys { get; init; }

    /// <summary>
    /// The 0-based index of the active key in cmtgKeys.
    /// </summary>
    public long? ActiveCmtgKeyIndex { get; init; }

    /// <summary>
    /// If true, the authenticator will generate a new CMTG key on the next operation.
    /// </summary>
    public bool? GenerateCmtgKeyOnNextOperation { get; init; }
}

[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(AddVirtualAuthenticatorCommandParameters), TypeInfoPropertyName = "AddVirtualAuthenticatorCommandParameters")]
[JsonSerializable(typeof(AddVirtualAuthenticatorResult), TypeInfoPropertyName = "AddVirtualAuthenticatorResult")]
[JsonSerializable(typeof(SetResponseOverrideBitsCommandParameters), TypeInfoPropertyName = "SetResponseOverrideBitsCommandParameters")]
[JsonSerializable(typeof(SetResponseOverrideBitsResult), TypeInfoPropertyName = "SetResponseOverrideBitsResult")]
[JsonSerializable(typeof(RemoveVirtualAuthenticatorCommandParameters), TypeInfoPropertyName = "RemoveVirtualAuthenticatorCommandParameters")]
[JsonSerializable(typeof(RemoveVirtualAuthenticatorResult), TypeInfoPropertyName = "RemoveVirtualAuthenticatorResult")]
[JsonSerializable(typeof(AddCredentialCommandParameters), TypeInfoPropertyName = "AddCredentialCommandParameters")]
[JsonSerializable(typeof(AddCredentialResult), TypeInfoPropertyName = "AddCredentialResult")]
[JsonSerializable(typeof(GetCredentialCommandParameters), TypeInfoPropertyName = "GetCredentialCommandParameters")]
[JsonSerializable(typeof(GetCredentialResult), TypeInfoPropertyName = "GetCredentialResult")]
[JsonSerializable(typeof(GetCredentialsCommandParameters), TypeInfoPropertyName = "GetCredentialsCommandParameters")]
[JsonSerializable(typeof(GetCredentialsResult), TypeInfoPropertyName = "GetCredentialsResult")]
[JsonSerializable(typeof(RemoveCredentialCommandParameters), TypeInfoPropertyName = "RemoveCredentialCommandParameters")]
[JsonSerializable(typeof(RemoveCredentialResult), TypeInfoPropertyName = "RemoveCredentialResult")]
[JsonSerializable(typeof(ClearCredentialsCommandParameters), TypeInfoPropertyName = "ClearCredentialsCommandParameters")]
[JsonSerializable(typeof(ClearCredentialsResult), TypeInfoPropertyName = "ClearCredentialsResult")]
[JsonSerializable(typeof(SetUserVerifiedCommandParameters), TypeInfoPropertyName = "SetUserVerifiedCommandParameters")]
[JsonSerializable(typeof(SetUserVerifiedResult), TypeInfoPropertyName = "SetUserVerifiedResult")]
[JsonSerializable(typeof(SetAutomaticPresenceSimulationCommandParameters), TypeInfoPropertyName = "SetAutomaticPresenceSimulationCommandParameters")]
[JsonSerializable(typeof(SetAutomaticPresenceSimulationResult), TypeInfoPropertyName = "SetAutomaticPresenceSimulationResult")]
[JsonSerializable(typeof(SetCredentialPropertiesCommandParameters), TypeInfoPropertyName = "SetCredentialPropertiesCommandParameters")]
[JsonSerializable(typeof(SetCredentialPropertiesResult), TypeInfoPropertyName = "SetCredentialPropertiesResult")]
[JsonSerializable(typeof(CdpEventArgs<CredentialAddedEventArgs>), TypeInfoPropertyName = "CredentialAddedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<CredentialDeletedEventArgs>), TypeInfoPropertyName = "CredentialDeletedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<CredentialUpdatedEventArgs>), TypeInfoPropertyName = "CredentialUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<CredentialAssertedEventArgs>), TypeInfoPropertyName = "CredentialAssertedCdpEventArgs")]
[JsonSerializable(typeof(AuthenticatorId), TypeInfoPropertyName = "WebAuthnAuthenticatorId")]
[JsonSerializable(typeof(AuthenticatorProtocol), TypeInfoPropertyName = "WebAuthnAuthenticatorProtocol")]
[JsonSerializable(typeof(Ctap2Version), TypeInfoPropertyName = "WebAuthnCtap2Version")]
[JsonSerializable(typeof(AuthenticatorTransport), TypeInfoPropertyName = "WebAuthnAuthenticatorTransport")]
[JsonSerializable(typeof(VirtualAuthenticatorOptions), TypeInfoPropertyName = "WebAuthnVirtualAuthenticatorOptions")]
[JsonSerializable(typeof(Credential), TypeInfoPropertyName = "WebAuthnCredential")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<Credential>), TypeInfoPropertyName = "IReadOnlyListWebAuthnCredential")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class WebAuthnJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="WebAuthnDomain"/>.
/// </summary>
public static class WebAuthnDomainEvent
{
    /// <summary>
    /// Triggered when a credential is added to an authenticator.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<CredentialAddedEventArgs>> CredentialAdded { get; } =
        EventDescriptor<CdpEventArgs<CredentialAddedEventArgs>>.Create(
            "goog:cdp.WebAuthn.credentialAdded",
            WebAuthnJsonSerializerContext.Default.CredentialAddedCdpEventArgs);

    /// <summary>
    /// Triggered when a credential is deleted, e.g. through
    /// PublicKeyCredential.signalUnknownCredential().
    /// </summary>
    public static EventDescriptor<CdpEventArgs<CredentialDeletedEventArgs>> CredentialDeleted { get; } =
        EventDescriptor<CdpEventArgs<CredentialDeletedEventArgs>>.Create(
            "goog:cdp.WebAuthn.credentialDeleted",
            WebAuthnJsonSerializerContext.Default.CredentialDeletedCdpEventArgs);

    /// <summary>
    /// Triggered when a credential is updated, e.g. through
    /// PublicKeyCredential.signalCurrentUserDetails().
    /// </summary>
    public static EventDescriptor<CdpEventArgs<CredentialUpdatedEventArgs>> CredentialUpdated { get; } =
        EventDescriptor<CdpEventArgs<CredentialUpdatedEventArgs>>.Create(
            "goog:cdp.WebAuthn.credentialUpdated",
            WebAuthnJsonSerializerContext.Default.CredentialUpdatedCdpEventArgs);

    /// <summary>
    /// Triggered when a credential is used in a webauthn assertion.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<CredentialAssertedEventArgs>> CredentialAsserted { get; } =
        EventDescriptor<CdpEventArgs<CredentialAssertedEventArgs>>.Create(
            "goog:cdp.WebAuthn.credentialAsserted",
            WebAuthnJsonSerializerContext.Default.CredentialAssertedCdpEventArgs);

}
