#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.FedCm;

/// <summary>
/// This domain allows interacting with the FedCM dialog.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public interface IFedCm
{
    /// <summary>
    /// </summary>
    /// <param name="disableRejectionDelay">
    /// Allows callers to disable the promise rejection delay that would
    /// normally happen, if this is unimportant to what's being tested.
    /// (step 4 of https://fedidcg.github.io/FedCM/#browser-api-rp-sign-in)
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
    Task<EnableResult> EnableAsync(bool? disableRejectionDelay = default, string? session = default, CancellationToken cancellationToken = default);

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
    Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <param name="dialogId">
    /// </param>
    /// <param name="accountIndex">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SelectAccountResult"/>.
    /// </returns>
    Task<SelectAccountResult> SelectAccountAsync(string dialogId, long accountIndex, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <param name="dialogId">
    /// </param>
    /// <param name="dialogButton">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClickDialogButtonResult"/>.
    /// </returns>
    Task<ClickDialogButtonResult> ClickDialogButtonAsync(string dialogId, DialogButton dialogButton, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <param name="dialogId">
    /// </param>
    /// <param name="accountIndex">
    /// </param>
    /// <param name="accountUrlType">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="OpenUrlResult"/>.
    /// </returns>
    Task<OpenUrlResult> OpenUrlAsync(string dialogId, long accountIndex, AccountUrlType accountUrlType, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <param name="dialogId">
    /// </param>
    /// <param name="triggerCooldown">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DismissDialogResult"/>.
    /// </returns>
    Task<DismissDialogResult> DismissDialogAsync(string dialogId, bool? triggerCooldown = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Resets the cooldown time, if any, to allow the next FedCM call to show
    /// a dialog even if one was recently dismissed by the user.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ResetCooldownResult"/>.
    /// </returns>
    Task<ResetCooldownResult> ResetCooldownAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DialogShownEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>DialogId</b></description></item>
    /// <item><description><b>DialogType</b></description></item>
    /// <item><description><b>Accounts</b></description></item>
    /// <item><description><b>Title</b> - These exist primarily so that the caller can verify the RP context was used appropriately.</description></item>
    /// <item><description><b>Subtitle</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<DialogShownEventArgs> DialogShown { get; }

    /// <summary>
    /// Triggered when a dialog is closed, either by user action, JS abort,
    /// or a command below.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DialogClosedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>DialogId</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<DialogClosedEventArgs> DialogClosed { get; }

}

[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
internal sealed class FedCmDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), IFedCm
{
    private static FedCmJsonSerializerContext JsonContext = FedCmJsonSerializerContext.Default;

    public async Task<EnableResult> EnableAsync(bool? disableRejectionDelay = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters(DisableRejectionDelay: disableRejectionDelay);
        return await ExecuteCommandAsync(EnableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("FedCm.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    public async Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync(DisableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("FedCm.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    public async Task<SelectAccountResult> SelectAccountAsync(string dialogId, long accountIndex, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SelectAccountCommandParameters(DialogId: dialogId, AccountIndex: accountIndex);
        return await ExecuteCommandAsync(SelectAccountCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SelectAccountCommandParameters, SelectAccountResult> SelectAccountCommand = new("FedCm.selectAccount", JsonContext.SelectAccountCommandParameters, JsonContext.SelectAccountResult);

    public async Task<ClickDialogButtonResult> ClickDialogButtonAsync(string dialogId, DialogButton dialogButton, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClickDialogButtonCommandParameters(DialogId: dialogId, DialogButton: dialogButton);
        return await ExecuteCommandAsync(ClickDialogButtonCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClickDialogButtonCommandParameters, ClickDialogButtonResult> ClickDialogButtonCommand = new("FedCm.clickDialogButton", JsonContext.ClickDialogButtonCommandParameters, JsonContext.ClickDialogButtonResult);

    public async Task<OpenUrlResult> OpenUrlAsync(string dialogId, long accountIndex, AccountUrlType accountUrlType, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new OpenUrlCommandParameters(DialogId: dialogId, AccountIndex: accountIndex, AccountUrlType: accountUrlType);
        return await ExecuteCommandAsync(OpenUrlCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<OpenUrlCommandParameters, OpenUrlResult> OpenUrlCommand = new("FedCm.openUrl", JsonContext.OpenUrlCommandParameters, JsonContext.OpenUrlResult);

    public async Task<DismissDialogResult> DismissDialogAsync(string dialogId, bool? triggerCooldown = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DismissDialogCommandParameters(DialogId: dialogId, TriggerCooldown: triggerCooldown);
        return await ExecuteCommandAsync(DismissDialogCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DismissDialogCommandParameters, DismissDialogResult> DismissDialogCommand = new("FedCm.dismissDialog", JsonContext.DismissDialogCommandParameters, JsonContext.DismissDialogResult);

    public async Task<ResetCooldownResult> ResetCooldownAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ResetCooldownCommandParameters();
        return await ExecuteCommandAsync(ResetCooldownCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ResetCooldownCommandParameters, ResetCooldownResult> ResetCooldownCommand = new("FedCm.resetCooldown", JsonContext.ResetCooldownCommandParameters, JsonContext.ResetCooldownResult);

    public IEventSource<DialogShownEventArgs> DialogShown => CreateCdpEventSource(FedCmDomainEvent.DialogShown);
    public IEventSource<DialogClosedEventArgs> DialogClosed => CreateCdpEventSource(FedCmDomainEvent.DialogClosed);
}

internal sealed record EnableCommandParameters(bool? DisableRejectionDelay) : Parameters;

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record SelectAccountCommandParameters(string DialogId, long AccountIndex) : Parameters;

/// <summary>
/// </summary>
public sealed record SelectAccountResult() : EmptyResult;


internal sealed record ClickDialogButtonCommandParameters(string DialogId, DialogButton DialogButton) : Parameters;

/// <summary>
/// </summary>
public sealed record ClickDialogButtonResult() : EmptyResult;


internal sealed record OpenUrlCommandParameters(string DialogId, long AccountIndex, AccountUrlType AccountUrlType) : Parameters;

/// <summary>
/// </summary>
public sealed record OpenUrlResult() : EmptyResult;


internal sealed record DismissDialogCommandParameters(string DialogId, bool? TriggerCooldown) : Parameters;

/// <summary>
/// </summary>
public sealed record DismissDialogResult() : EmptyResult;


internal sealed record ResetCooldownCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record ResetCooldownResult() : EmptyResult;


/// <summary>
/// </summary>
/// <param name="DialogId">
/// </param>
/// <param name="DialogType">
/// </param>
/// <param name="Accounts">
/// </param>
/// <param name="Title">
/// These exist primarily so that the caller can verify the
/// RP context was used appropriately.
/// </param>
/// <param name="Subtitle">
/// </param>
public sealed record DialogShownEventArgs(string DialogId, DialogType DialogType, ImmutableArray<Account> Accounts, string Title, string? Subtitle = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Triggered when a dialog is closed, either by user action, JS abort,
/// or a command below.
/// </summary>
/// <param name="DialogId">
/// </param>
public sealed record DialogClosedEventArgs(string DialogId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Whether this is a sign-up or sign-in action for this account, i.e.
/// whether this account has ever been used to sign in to this RP before.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<LoginState>))]
public enum LoginState
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignIn")]
    SignIn,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("SignUp")]
    SignUp,
}

/// <summary>
/// The types of FedCM dialogs.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<DialogType>))]
public enum DialogType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AccountChooser")]
    AccountChooser,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("AutoReauthn")]
    AutoReauthn,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ConfirmIdpLogin")]
    ConfirmIdpLogin,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("Error")]
    Error,
}

/// <summary>
/// The buttons on the FedCM dialog.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<DialogButton>))]
public enum DialogButton
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ConfirmIdpLoginContinue")]
    ConfirmIdpLoginContinue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ErrorGotIt")]
    ErrorGotIt,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("ErrorMoreDetails")]
    ErrorMoreDetails,
}

/// <summary>
/// The URLs that each account has
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<AccountUrlType>))]
public enum AccountUrlType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("TermsOfService")]
    TermsOfService,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("PrivacyPolicy")]
    PrivacyPolicy,
}

/// <summary>
/// Corresponds to IdentityRequestAccount
/// </summary>
/// <param name="AccountId">
/// </param>
/// <param name="Email">
/// </param>
/// <param name="Name">
/// </param>
/// <param name="GivenName">
/// </param>
/// <param name="PictureUrl">
/// </param>
/// <param name="IdpConfigUrl">
/// </param>
/// <param name="IdpLoginUrl">
/// </param>
/// <param name="LoginState">
/// </param>
public sealed record Account(string AccountId, string Email, string Name, string GivenName, string PictureUrl, string IdpConfigUrl, string IdpLoginUrl, LoginState LoginState)
{
    /// <summary>
    /// These two are only set if the loginState is signUp
    /// </summary>
    public string? TermsOfServiceUrl { get; init; }

    /// <summary>
    /// </summary>
    public string? PrivacyPolicyUrl { get; init; }
}

[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(SelectAccountCommandParameters), TypeInfoPropertyName = "SelectAccountCommandParameters")]
[JsonSerializable(typeof(SelectAccountResult), TypeInfoPropertyName = "SelectAccountResult")]
[JsonSerializable(typeof(ClickDialogButtonCommandParameters), TypeInfoPropertyName = "ClickDialogButtonCommandParameters")]
[JsonSerializable(typeof(ClickDialogButtonResult), TypeInfoPropertyName = "ClickDialogButtonResult")]
[JsonSerializable(typeof(OpenUrlCommandParameters), TypeInfoPropertyName = "OpenUrlCommandParameters")]
[JsonSerializable(typeof(OpenUrlResult), TypeInfoPropertyName = "OpenUrlResult")]
[JsonSerializable(typeof(DismissDialogCommandParameters), TypeInfoPropertyName = "DismissDialogCommandParameters")]
[JsonSerializable(typeof(DismissDialogResult), TypeInfoPropertyName = "DismissDialogResult")]
[JsonSerializable(typeof(ResetCooldownCommandParameters), TypeInfoPropertyName = "ResetCooldownCommandParameters")]
[JsonSerializable(typeof(ResetCooldownResult), TypeInfoPropertyName = "ResetCooldownResult")]
[JsonSerializable(typeof(CdpEventArgs<DialogShownEventArgs>), TypeInfoPropertyName = "DialogShownCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DialogClosedEventArgs>), TypeInfoPropertyName = "DialogClosedCdpEventArgs")]
[JsonSerializable(typeof(LoginState), TypeInfoPropertyName = "FedCmLoginState")]
[JsonSerializable(typeof(DialogType), TypeInfoPropertyName = "FedCmDialogType")]
[JsonSerializable(typeof(DialogButton), TypeInfoPropertyName = "FedCmDialogButton")]
[JsonSerializable(typeof(AccountUrlType), TypeInfoPropertyName = "FedCmAccountUrlType")]
[JsonSerializable(typeof(Account), TypeInfoPropertyName = "FedCmAccount")]
[JsonSerializable(typeof(ImmutableArray<Account>), TypeInfoPropertyName = "ImmutableArrayFedCmAccount")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class FedCmJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="IFedCm"/>.
/// </summary>
public static class FedCmDomainEvent
{
    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DialogShownEventArgs>> DialogShown { get; } =
        EventDescriptor<CdpEventArgs<DialogShownEventArgs>>.Create(
            "goog:cdp.FedCm.dialogShown",
            FedCmJsonSerializerContext.Default.DialogShownCdpEventArgs);

    /// <summary>
    /// Triggered when a dialog is closed, either by user action, JS abort,
    /// or a command below.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DialogClosedEventArgs>> DialogClosed { get; } =
        EventDescriptor<CdpEventArgs<DialogClosedEventArgs>>.Create(
            "goog:cdp.FedCm.dialogClosed",
            FedCmJsonSerializerContext.Default.DialogClosedCdpEventArgs);

}
