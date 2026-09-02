#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.DeviceAccess;

/// <summary>
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public interface IDeviceAccess
{
    /// <summary>
    /// Enable events in this domain.
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
    Task<EnableResult> EnableAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disable events in this domain.
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
    /// Select a device in response to a DeviceAccess.deviceRequestPrompted event.
    /// </summary>
    /// <param name="id">
    /// </param>
    /// <param name="deviceId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SelectPromptResult"/>.
    /// </returns>
    Task<SelectPromptResult> SelectPromptAsync(RequestId id, DeviceId deviceId, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Cancel a prompt in response to a DeviceAccess.deviceRequestPrompted event.
    /// </summary>
    /// <param name="id">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CancelPromptResult"/>.
    /// </returns>
    Task<CancelPromptResult> CancelPromptAsync(RequestId id, string? session = default, CancellationToken cancellationToken = default);

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
    IEventSource<DeviceRequestPromptedEventArgs> DeviceRequestPrompted { get; }

}

[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
internal sealed class DeviceAccessDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), IDeviceAccess
{
    private static readonly DeviceAccessJsonSerializerContext JsonContext = DeviceAccessJsonSerializerContext.Default;

    public async Task<EnableResult> EnableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters();
        var command = new CdpCommand<EnableCommandParameters, EnableResult>("DeviceAccess.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);
        return await ExecuteCommandAsync(command, @params, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        var command = new CdpCommand<DisableCommandParameters, DisableResult>("DeviceAccess.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);
        return await ExecuteCommandAsync(command, @params, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<SelectPromptResult> SelectPromptAsync(RequestId id, DeviceId deviceId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SelectPromptCommandParameters(Id: id, DeviceId: deviceId);
        var command = new CdpCommand<SelectPromptCommandParameters, SelectPromptResult>("DeviceAccess.selectPrompt", JsonContext.SelectPromptCommandParameters, JsonContext.SelectPromptResult);
        return await ExecuteCommandAsync(command, @params, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<CancelPromptResult> CancelPromptAsync(RequestId id, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CancelPromptCommandParameters(Id: id);
        var command = new CdpCommand<CancelPromptCommandParameters, CancelPromptResult>("DeviceAccess.cancelPrompt", JsonContext.CancelPromptCommandParameters, JsonContext.CancelPromptResult);
        return await ExecuteCommandAsync(command, @params, session, cancellationToken).ConfigureAwait(false);
    }

    public IEventSource<DeviceRequestPromptedEventArgs> DeviceRequestPrompted => CreateCdpEventSource(DeviceAccessDomainEvent.DeviceRequestPrompted);
}

internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record SelectPromptCommandParameters(RequestId Id, DeviceId DeviceId) : Parameters;

/// <summary>
/// </summary>
public sealed record SelectPromptResult() : EmptyResult;


internal sealed record CancelPromptCommandParameters(RequestId Id) : Parameters;

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
/// Provides static event descriptors for the <see cref="IDeviceAccess"/>.
/// </summary>
public static class DeviceAccessDomainEvent
{
    /// <summary>
    /// A device request opened a user prompt to select a device. Respond with the
    /// selectPrompt or cancelPrompt command.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DeviceRequestPromptedEventArgs>> DeviceRequestPrompted =>
        _deviceRequestPrompted ?? global::System.Threading.Interlocked.CompareExchange(ref _deviceRequestPrompted, EventDescriptor<CdpEventArgs<DeviceRequestPromptedEventArgs>>.Create(
            "goog:cdp.DeviceAccess.deviceRequestPrompted",
            DeviceAccessJsonSerializerContext.Default.DeviceRequestPromptedCdpEventArgs), null) ?? _deviceRequestPrompted;
    private static EventDescriptor<CdpEventArgs<DeviceRequestPromptedEventArgs>>? _deviceRequestPrompted;

}
