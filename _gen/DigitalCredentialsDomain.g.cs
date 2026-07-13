#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.DigitalCredentials;

/// <summary>
/// This domain allows interacting with the Digital Credentials API for automation.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class DigitalCredentialsDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static DigitalCredentialsJsonSerializerContext JsonContext = DigitalCredentialsJsonSerializerContext.Default;

    /// <summary>
    /// Sets the behavior of the virtual wallet for digital credential requests
    /// issued from this frame.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Protocol</b> - The protocol identifier (e.g. "openid4vp"). Required when |action| is "respond", forbidden otherwise.</description></item>
    /// <item><description><b>Response</b> - The response data object returned by the wallet. Required when |action| is "respond", forbidden otherwise.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="action">
    /// The action of the virtual wallet.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetVirtualWalletBehaviorCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetVirtualWalletBehaviorResult"/>.
    /// </returns>
    public async Task<SetVirtualWalletBehaviorResult> SetVirtualWalletBehaviorAsync(VirtualWalletAction action, SetVirtualWalletBehaviorCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetVirtualWalletBehaviorCommandParameters(Action: action, Protocol: options?.Protocol, Response: options?.Response);
        return await ExecuteCommandAsync(SetVirtualWalletBehaviorCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetVirtualWalletBehaviorCommandParameters, SetVirtualWalletBehaviorResult> SetVirtualWalletBehaviorCommand = new("DigitalCredentials.setVirtualWalletBehavior", JsonContext.SetVirtualWalletBehaviorCommandParameters, JsonContext.SetVirtualWalletBehaviorResult);

}

internal sealed record SetVirtualWalletBehaviorCommandParameters(VirtualWalletAction Action, string? Protocol, global::System.Text.Json.JsonElement? Response) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DigitalCredentialsDomain.SetVirtualWalletBehaviorAsync"/>.
/// </summary>
public sealed record SetVirtualWalletBehaviorCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// The protocol identifier (e.g. "openid4vp"). Required when |action| is
    /// "respond", forbidden otherwise.
    /// </summary>
    public string? Protocol { get; init; }

    /// <summary>
    /// The response data object returned by the wallet.
    /// Required when |action| is "respond", forbidden otherwise.
    /// </summary>
    public global::System.Text.Json.JsonElement? Response { get; init; }
}

/// <summary>
/// </summary>
public sealed record SetVirtualWalletBehaviorResult() : EmptyResult;


/// <summary>
/// The type of virtual wallet action.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<VirtualWalletAction>))]
public enum VirtualWalletAction
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("respond")]
    Respond,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("decline")]
    Decline,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("wait")]
    Wait,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("clear")]
    Clear,
}

[JsonSerializable(typeof(SetVirtualWalletBehaviorCommandParameters), TypeInfoPropertyName = "SetVirtualWalletBehaviorCommandParameters")]
[JsonSerializable(typeof(SetVirtualWalletBehaviorResult), TypeInfoPropertyName = "SetVirtualWalletBehaviorResult")]
[JsonSerializable(typeof(VirtualWalletAction), TypeInfoPropertyName = "DigitalCredentialsVirtualWalletAction")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class DigitalCredentialsJsonSerializerContext : JsonSerializerContext;

