#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.DeviceAccess;

/// <summary>
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class DeviceAccessDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static DeviceAccessJsonSerializerContext JsonContext = DeviceAccessJsonSerializerContext.Default;

    /// <summary>
    /// Enable events in this domain.
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
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("DeviceAccess.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Disable events in this domain.
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
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("DeviceAccess.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Select a device in response to a DeviceAccess.deviceRequestPrompted event.
    /// </summary>
    /// <param name="id">
    /// </param>
    /// <param name="deviceId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SelectPromptCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SelectPromptResult"/>.
    /// </returns>
    public async Task<SelectPromptResult> SelectPromptAsync(RequestId id, DeviceId deviceId, SelectPromptCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SelectPromptCommandParameters(Id: id, DeviceId: deviceId);
        return await ExecuteCommandAsync(SelectPromptCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SelectPromptCommandParameters, SelectPromptResult> SelectPromptCommand = new("DeviceAccess.selectPrompt", JsonContext.SelectPromptCommandParameters, JsonContext.SelectPromptResult);

    /// <summary>
    /// Cancel a prompt in response to a DeviceAccess.deviceRequestPrompted event.
    /// </summary>
    /// <param name="id">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="CancelPromptCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CancelPromptResult"/>.
    /// </returns>
    public async Task<CancelPromptResult> CancelPromptAsync(RequestId id, CancelPromptCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new CancelPromptCommandParameters(Id: id);
        return await ExecuteCommandAsync(CancelPromptCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CancelPromptCommandParameters, CancelPromptResult> CancelPromptCommand = new("DeviceAccess.cancelPrompt", JsonContext.CancelPromptCommandParameters, JsonContext.CancelPromptResult);

    /// <summary>
    /// A device request opened a user prompt to select a device. Respond with the
    /// selectPrompt or cancelPrompt command.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DeviceRequestPromptedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Id</b></description></item>
    /// <item><description><b>Devices</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<DeviceRequestPromptedEventArgs> DeviceRequestPrompted => CreateCdpEventSource(DeviceAccessDomainEvent.DeviceRequestPrompted);
}

internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="DeviceAccessDomain.EnableAsync"/>.
/// </summary>
public sealed record EnableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="DeviceAccessDomain.DisableAsync"/>.
/// </summary>
public sealed record DisableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record SelectPromptCommandParameters(RequestId Id, DeviceId DeviceId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DeviceAccessDomain.SelectPromptAsync"/>.
/// </summary>
public sealed record SelectPromptCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SelectPromptResult() : EmptyResult;


internal sealed record CancelPromptCommandParameters(RequestId Id) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DeviceAccessDomain.CancelPromptAsync"/>.
/// </summary>
public sealed record CancelPromptCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record CancelPromptResult() : EmptyResult;


/// <summary>
/// A device request opened a user prompt to select a device. Respond with the
/// selectPrompt or cancelPrompt command.
/// </summary>
/// <param name="Id">
/// </param>
/// <param name="Devices">
/// </param>
public sealed record DeviceRequestPromptedEventArgs(RequestId Id, ImmutableArray<PromptDevice> Devices) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Device request id.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<RequestId>))]
public record RequestId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// A device id.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<DeviceId>))]
public record DeviceId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Device information displayed in a user prompt to select a device.
/// </summary>
/// <param name="Id">
/// </param>
/// <param name="Name">
/// Display name as it appears in a device request user prompt.
/// </param>
public sealed record PromptDevice(DeviceId Id, string Name)
{
}

[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(SelectPromptCommandParameters), TypeInfoPropertyName = "SelectPromptCommandParameters")]
[JsonSerializable(typeof(SelectPromptResult), TypeInfoPropertyName = "SelectPromptResult")]
[JsonSerializable(typeof(CancelPromptCommandParameters), TypeInfoPropertyName = "CancelPromptCommandParameters")]
[JsonSerializable(typeof(CancelPromptResult), TypeInfoPropertyName = "CancelPromptResult")]
[JsonSerializable(typeof(CdpEventArgs<DeviceRequestPromptedEventArgs>), TypeInfoPropertyName = "DeviceRequestPromptedCdpEventArgs")]
[JsonSerializable(typeof(RequestId), TypeInfoPropertyName = "DeviceAccessRequestId")]
[JsonSerializable(typeof(DeviceId), TypeInfoPropertyName = "DeviceAccessDeviceId")]
[JsonSerializable(typeof(PromptDevice), TypeInfoPropertyName = "DeviceAccessPromptDevice")]
[JsonSerializable(typeof(ImmutableArray<PromptDevice>), TypeInfoPropertyName = "ImmutableArrayDeviceAccessPromptDevice")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class DeviceAccessJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="DeviceAccessDomain"/>.
/// </summary>
public static class DeviceAccessDomainEvent
{
    /// <summary>
    /// A device request opened a user prompt to select a device. Respond with the
    /// selectPrompt or cancelPrompt command.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DeviceRequestPromptedEventArgs>> DeviceRequestPrompted { get; } =
        EventDescriptor<CdpEventArgs<DeviceRequestPromptedEventArgs>>.Create(
            "goog:cdp.DeviceAccess.deviceRequestPrompted",
            DeviceAccessJsonSerializerContext.Default.DeviceRequestPromptedCdpEventArgs);

}
