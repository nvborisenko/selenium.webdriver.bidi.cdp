#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.DeviceOrientation;

/// <summary>
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class DeviceOrientationDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static DeviceOrientationJsonSerializerContext JsonContext = DeviceOrientationJsonSerializerContext.Default;

    /// <summary>
    /// Clears the overridden Device Orientation.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="ClearDeviceOrientationOverrideCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearDeviceOrientationOverrideResult"/>.
    /// </returns>
    public async Task<ClearDeviceOrientationOverrideResult> ClearDeviceOrientationOverrideAsync(ClearDeviceOrientationOverrideCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearDeviceOrientationOverrideCommandParameters();
        return await ExecuteCommandAsync(ClearDeviceOrientationOverrideCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearDeviceOrientationOverrideCommandParameters, ClearDeviceOrientationOverrideResult> ClearDeviceOrientationOverrideCommand = new("DeviceOrientation.clearDeviceOrientationOverride", JsonContext.ClearDeviceOrientationOverrideCommandParameters, JsonContext.ClearDeviceOrientationOverrideResult);

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
    /// <param name="options">
    /// Optional parameters. See <see cref="SetDeviceOrientationOverrideCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetDeviceOrientationOverrideResult"/>.
    /// </returns>
    public async Task<SetDeviceOrientationOverrideResult> SetDeviceOrientationOverrideAsync(double alpha, double beta, double gamma, SetDeviceOrientationOverrideCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetDeviceOrientationOverrideCommandParameters(Alpha: alpha, Beta: beta, Gamma: gamma);
        return await ExecuteCommandAsync(SetDeviceOrientationOverrideCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetDeviceOrientationOverrideCommandParameters, SetDeviceOrientationOverrideResult> SetDeviceOrientationOverrideCommand = new("DeviceOrientation.setDeviceOrientationOverride", JsonContext.SetDeviceOrientationOverrideCommandParameters, JsonContext.SetDeviceOrientationOverrideResult);

}

internal sealed record ClearDeviceOrientationOverrideCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="DeviceOrientationDomain.ClearDeviceOrientationOverrideAsync"/>.
/// </summary>
public sealed record ClearDeviceOrientationOverrideCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ClearDeviceOrientationOverrideResult() : EmptyResult;


internal sealed record SetDeviceOrientationOverrideCommandParameters(double Alpha, double Beta, double Gamma) : Parameters;

/// <summary>
/// Optional parameters for <see cref="DeviceOrientationDomain.SetDeviceOrientationOverrideAsync"/>.
/// </summary>
public sealed record SetDeviceOrientationOverrideCommandOptions : CdpCommandOptions
{
}

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

