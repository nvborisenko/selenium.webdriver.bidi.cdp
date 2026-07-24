#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.DeviceOrientation;

/// <summary>
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public interface IDeviceOrientation
{
    /// <summary>
    /// Clears the overridden Device Orientation.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearDeviceOrientationOverrideResult"/>.
    /// </returns>
    Task<ClearDeviceOrientationOverrideResult> ClearDeviceOrientationOverrideAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Overrides the Device Orientation.
    /// </summary>
    /// <param name="alpha">
    /// Mock alpha
    /// </param>
    /// <param name="beta">
    /// Mock beta
    /// </param>
    /// <param name="gamma">
    /// Mock gamma
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetDeviceOrientationOverrideResult"/>.
    /// </returns>
    Task<SetDeviceOrientationOverrideResult> SetDeviceOrientationOverrideAsync(double alpha, double beta, double gamma, string? session = default, CancellationToken cancellationToken = default);

}

[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
internal sealed class DeviceOrientationDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), IDeviceOrientation
{
    private static DeviceOrientationJsonSerializerContext JsonContext = DeviceOrientationJsonSerializerContext.Default;

    public async Task<ClearDeviceOrientationOverrideResult> ClearDeviceOrientationOverrideAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearDeviceOrientationOverrideCommandParameters();
        return await ExecuteCommandAsync(ClearDeviceOrientationOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearDeviceOrientationOverrideCommandParameters, ClearDeviceOrientationOverrideResult> ClearDeviceOrientationOverrideCommand = new("DeviceOrientation.clearDeviceOrientationOverride", JsonContext.ClearDeviceOrientationOverrideCommandParameters, JsonContext.ClearDeviceOrientationOverrideResult);

    public async Task<SetDeviceOrientationOverrideResult> SetDeviceOrientationOverrideAsync(double alpha, double beta, double gamma, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetDeviceOrientationOverrideCommandParameters(Alpha: alpha, Beta: beta, Gamma: gamma);
        return await ExecuteCommandAsync(SetDeviceOrientationOverrideCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetDeviceOrientationOverrideCommandParameters, SetDeviceOrientationOverrideResult> SetDeviceOrientationOverrideCommand = new("DeviceOrientation.setDeviceOrientationOverride", JsonContext.SetDeviceOrientationOverrideCommandParameters, JsonContext.SetDeviceOrientationOverrideResult);

}

internal sealed record ClearDeviceOrientationOverrideCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record ClearDeviceOrientationOverrideResult() : EmptyResult;


internal sealed record SetDeviceOrientationOverrideCommandParameters(double Alpha, double Beta, double Gamma) : Parameters;

/// <summary>
/// </summary>
public sealed record SetDeviceOrientationOverrideResult() : EmptyResult;


[JsonSerializable(typeof(ClearDeviceOrientationOverrideCommandParameters), TypeInfoPropertyName = "ClearDeviceOrientationOverrideCommandParameters")]
[JsonSerializable(typeof(ClearDeviceOrientationOverrideResult), TypeInfoPropertyName = "ClearDeviceOrientationOverrideResult")]
[JsonSerializable(typeof(SetDeviceOrientationOverrideCommandParameters), TypeInfoPropertyName = "SetDeviceOrientationOverrideCommandParameters")]
[JsonSerializable(typeof(SetDeviceOrientationOverrideResult), TypeInfoPropertyName = "SetDeviceOrientationOverrideResult")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class DeviceOrientationJsonSerializerContext : JsonSerializerContext;

