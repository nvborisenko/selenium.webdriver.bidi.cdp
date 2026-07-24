#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.SystemInfo;

/// <summary>
/// The SystemInfo domain defines methods and events for querying low-level system information.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class SystemInfoDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static SystemInfoJsonSerializerContext JsonContext = SystemInfoJsonSerializerContext.Default;

    /// <summary>
    /// Returns information about the system.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetInfoCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetInfoResult"/>.
    /// </returns>
    public async Task<GetInfoResult> GetInfoAsync(GetInfoCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetInfoCommandParameters();
        return await ExecuteCommandAsync(GetInfoCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetInfoCommandParameters, GetInfoResult> GetInfoCommand = new("SystemInfo.getInfo", JsonContext.GetInfoCommandParameters, JsonContext.GetInfoResult);

    /// <summary>
    /// Returns information about the feature state.
    /// </summary>
    /// <param name="featureState">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetFeatureStateCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetFeatureStateResult"/>.
    /// </returns>
    public async Task<GetFeatureStateResult> GetFeatureStateAsync(string featureState, GetFeatureStateCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetFeatureStateCommandParameters(FeatureState: featureState);
        return await ExecuteCommandAsync(GetFeatureStateCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetFeatureStateCommandParameters, GetFeatureStateResult> GetFeatureStateCommand = new("SystemInfo.getFeatureState", JsonContext.GetFeatureStateCommandParameters, JsonContext.GetFeatureStateResult);

    /// <summary>
    /// Returns information about all running processes.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetProcessInfoCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetProcessInfoResult"/>.
    /// </returns>
    public async Task<GetProcessInfoResult> GetProcessInfoAsync(GetProcessInfoCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetProcessInfoCommandParameters();
        return await ExecuteCommandAsync(GetProcessInfoCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetProcessInfoCommandParameters, GetProcessInfoResult> GetProcessInfoCommand = new("SystemInfo.getProcessInfo", JsonContext.GetProcessInfoCommandParameters, JsonContext.GetProcessInfoResult);

}

internal sealed record GetInfoCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="SystemInfoDomain.GetInfoAsync"/>.
/// </summary>
public sealed record GetInfoCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Gpu">
/// Information about the GPUs on the system.
/// </param>
/// <param name="ModelName">
/// A platform-dependent description of the model of the machine. On Mac OS, this is, for
/// example, 'MacBookPro'. Will be the empty string if not supported.
/// </param>
/// <param name="ModelVersion">
/// A platform-dependent description of the version of the machine. On Mac OS, this is, for
/// example, '10.1'. Will be the empty string if not supported.
/// </param>
/// <param name="CommandLine">
/// The command line string used to launch the browser. Will be the empty string if not
/// supported.
/// </param>
public sealed record GetInfoResult(GPUInfo Gpu, string ModelName, string ModelVersion, string CommandLine) : EmptyResult;


internal sealed record GetFeatureStateCommandParameters(string FeatureState) : Parameters;

/// <summary>
/// Optional parameters for <see cref="SystemInfoDomain.GetFeatureStateAsync"/>.
/// </summary>
public sealed record GetFeatureStateCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="FeatureEnabled">
/// </param>
public sealed record GetFeatureStateResult(bool FeatureEnabled) : EmptyResult;


internal sealed record GetProcessInfoCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="SystemInfoDomain.GetProcessInfoAsync"/>.
/// </summary>
public sealed record GetProcessInfoCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="ProcessInfo">
/// An array of process info blocks.
/// </param>
public sealed record GetProcessInfoResult(ImmutableArray<ProcessInfo> ProcessInfo) : EmptyResult;


/// <summary>
/// Describes a single graphics processor (GPU).
/// </summary>
/// <param name="VendorId">
/// PCI ID of the GPU vendor, if available; 0 otherwise.
/// </param>
/// <param name="DeviceId">
/// PCI ID of the GPU device, if available; 0 otherwise.
/// </param>
/// <param name="VendorString">
/// String description of the GPU vendor, if the PCI ID is not available.
/// </param>
/// <param name="DeviceString">
/// String description of the GPU device, if the PCI ID is not available.
/// </param>
/// <param name="DriverVendor">
/// String description of the GPU driver vendor.
/// </param>
/// <param name="DriverVersion">
/// String description of the GPU driver version.
/// </param>
public sealed record GPUDevice(double VendorId, double DeviceId, string VendorString, string DeviceString, string DriverVendor, string DriverVersion)
{
    /// <summary>
    /// Sub sys ID of the GPU, only available on Windows.
    /// </summary>
    public double? SubSysId { get; init; }

    /// <summary>
    /// Revision of the GPU, only available on Windows.
    /// </summary>
    public double? Revision { get; init; }
}

/// <summary>
/// Describes the width and height dimensions of an entity.
/// </summary>
/// <param name="Width">
/// Width in pixels.
/// </param>
/// <param name="Height">
/// Height in pixels.
/// </param>
public sealed record Size(long Width, long Height)
{
}

/// <summary>
/// Describes a supported video decoding profile with its associated minimum and
/// maximum resolutions.
/// </summary>
/// <param name="Profile">
/// Video codec profile that is supported, e.g. VP9 Profile 2.
/// </param>
/// <param name="MaxResolution">
/// Maximum video dimensions in pixels supported for this |profile|.
/// </param>
/// <param name="MinResolution">
/// Minimum video dimensions in pixels supported for this |profile|.
/// </param>
public sealed record VideoDecodeAcceleratorCapability(string Profile, Size MaxResolution, Size MinResolution)
{
}

/// <summary>
/// Describes a supported video encoding profile with its associated maximum
/// resolution and maximum framerate.
/// </summary>
/// <param name="Profile">
/// Video codec profile that is supported, e.g H264 Main.
/// </param>
/// <param name="MaxResolution">
/// Maximum video dimensions in pixels supported for this |profile|.
/// </param>
/// <param name="MaxFramerateNumerator">
/// Maximum encoding framerate in frames per second supported for this
/// |profile|, as fraction's numerator and denominator, e.g. 24/1 fps,
/// 24000/1001 fps, etc.
/// </param>
/// <param name="MaxFramerateDenominator">
/// </param>
public sealed record VideoEncodeAcceleratorCapability(string Profile, Size MaxResolution, long MaxFramerateNumerator, long MaxFramerateDenominator)
{
}

/// <summary>
/// YUV subsampling type of the pixels of a given image.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<SubsamplingFormat>))]
public enum SubsamplingFormat
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("yuv420")]
    Yuv420,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("yuv422")]
    Yuv422,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("yuv444")]
    Yuv444,
}

/// <summary>
/// Image format of a given image.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ImageType>))]
public enum ImageType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("jpeg")]
    Jpeg,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("webp")]
    Webp,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("unknown")]
    Unknown,
}

/// <summary>
/// Provides information about the GPU(s) on the system.
/// </summary>
/// <param name="Devices">
/// The graphics devices on the system. Element 0 is the primary GPU.
/// </param>
/// <param name="DriverBugWorkarounds">
/// An optional array of GPU driver bug workarounds.
/// </param>
/// <param name="VideoDecoding">
/// Supported accelerated video decoding capabilities.
/// </param>
/// <param name="VideoEncoding">
/// Supported accelerated video encoding capabilities.
/// </param>
public sealed record GPUInfo(ImmutableArray<GPUDevice> Devices, ImmutableArray<string> DriverBugWorkarounds, ImmutableArray<VideoDecodeAcceleratorCapability> VideoDecoding, ImmutableArray<VideoEncodeAcceleratorCapability> VideoEncoding)
{
    /// <summary>
    /// An optional dictionary of additional GPU related attributes.
    /// </summary>
    public global::System.Text.Json.JsonElement? AuxAttributes { get; init; }

    /// <summary>
    /// An optional dictionary of graphics features and their status.
    /// </summary>
    public global::System.Text.Json.JsonElement? FeatureStatus { get; init; }
}

/// <summary>
/// Represents process info.
/// </summary>
/// <param name="Type">
/// Specifies process type.
/// </param>
/// <param name="Id">
/// Specifies process id.
/// </param>
/// <param name="CpuTime">
/// Specifies cumulative CPU usage in seconds across all threads of the
/// process since the process start.
/// </param>
public sealed record ProcessInfo(string Type, long Id, double CpuTime)
{
}

[JsonSerializable(typeof(GetInfoCommandParameters), TypeInfoPropertyName = "GetInfoCommandParameters")]
[JsonSerializable(typeof(GetInfoResult), TypeInfoPropertyName = "GetInfoResult")]
[JsonSerializable(typeof(GetFeatureStateCommandParameters), TypeInfoPropertyName = "GetFeatureStateCommandParameters")]
[JsonSerializable(typeof(GetFeatureStateResult), TypeInfoPropertyName = "GetFeatureStateResult")]
[JsonSerializable(typeof(GetProcessInfoCommandParameters), TypeInfoPropertyName = "GetProcessInfoCommandParameters")]
[JsonSerializable(typeof(GetProcessInfoResult), TypeInfoPropertyName = "GetProcessInfoResult")]
[JsonSerializable(typeof(GPUDevice), TypeInfoPropertyName = "SystemInfoGPUDevice")]
[JsonSerializable(typeof(Size), TypeInfoPropertyName = "SystemInfoSize")]
[JsonSerializable(typeof(VideoDecodeAcceleratorCapability), TypeInfoPropertyName = "SystemInfoVideoDecodeAcceleratorCapability")]
[JsonSerializable(typeof(VideoEncodeAcceleratorCapability), TypeInfoPropertyName = "SystemInfoVideoEncodeAcceleratorCapability")]
[JsonSerializable(typeof(SubsamplingFormat), TypeInfoPropertyName = "SystemInfoSubsamplingFormat")]
[JsonSerializable(typeof(ImageType), TypeInfoPropertyName = "SystemInfoImageType")]
[JsonSerializable(typeof(GPUInfo), TypeInfoPropertyName = "SystemInfoGPUInfo")]
[JsonSerializable(typeof(ProcessInfo), TypeInfoPropertyName = "SystemInfoProcessInfo")]
[JsonSerializable(typeof(ImmutableArray<ProcessInfo>), TypeInfoPropertyName = "ImmutableArraySystemInfoProcessInfo")]
[JsonSerializable(typeof(ImmutableArray<GPUDevice>), TypeInfoPropertyName = "ImmutableArraySystemInfoGPUDevice")]
[JsonSerializable(typeof(ImmutableArray<VideoDecodeAcceleratorCapability>), TypeInfoPropertyName = "ImmutableArraySystemInfoVideoDecodeAcceleratorCapability")]
[JsonSerializable(typeof(ImmutableArray<VideoEncodeAcceleratorCapability>), TypeInfoPropertyName = "ImmutableArraySystemInfoVideoEncodeAcceleratorCapability")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class SystemInfoJsonSerializerContext : JsonSerializerContext;

