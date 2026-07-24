#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Memory;

/// <summary>
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class MemoryDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static MemoryJsonSerializerContext JsonContext = MemoryJsonSerializerContext.Default;

    /// <summary>
    /// Retruns current DOM object counters.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetDOMCountersCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetDOMCountersResult"/>.
    /// </returns>
    public async Task<GetDOMCountersResult> GetDOMCountersAsync(GetDOMCountersCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetDOMCountersCommandParameters();
        return await ExecuteCommandAsync(GetDOMCountersCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetDOMCountersCommandParameters, GetDOMCountersResult> GetDOMCountersCommand = new("Memory.getDOMCounters", JsonContext.GetDOMCountersCommandParameters, JsonContext.GetDOMCountersResult);

    /// <summary>
    /// Retruns DOM object counters after preparing renderer for leak detection.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetDOMCountersForLeakDetectionCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetDOMCountersForLeakDetectionResult"/>.
    /// </returns>
    public async Task<GetDOMCountersForLeakDetectionResult> GetDOMCountersForLeakDetectionAsync(GetDOMCountersForLeakDetectionCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetDOMCountersForLeakDetectionCommandParameters();
        return await ExecuteCommandAsync(GetDOMCountersForLeakDetectionCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetDOMCountersForLeakDetectionCommandParameters, GetDOMCountersForLeakDetectionResult> GetDOMCountersForLeakDetectionCommand = new("Memory.getDOMCountersForLeakDetection", JsonContext.GetDOMCountersForLeakDetectionCommandParameters, JsonContext.GetDOMCountersForLeakDetectionResult);

    /// <summary>
    /// Prepares for leak detection by terminating workers, stopping spellcheckers,
    /// dropping non-essential internal caches, running garbage collections, etc.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="PrepareForLeakDetectionCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="PrepareForLeakDetectionResult"/>.
    /// </returns>
    public async Task<PrepareForLeakDetectionResult> PrepareForLeakDetectionAsync(PrepareForLeakDetectionCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new PrepareForLeakDetectionCommandParameters();
        return await ExecuteCommandAsync(PrepareForLeakDetectionCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<PrepareForLeakDetectionCommandParameters, PrepareForLeakDetectionResult> PrepareForLeakDetectionCommand = new("Memory.prepareForLeakDetection", JsonContext.PrepareForLeakDetectionCommandParameters, JsonContext.PrepareForLeakDetectionResult);

    /// <summary>
    /// Simulate OomIntervention by purging V8 memory.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="ForciblyPurgeJavaScriptMemoryCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ForciblyPurgeJavaScriptMemoryResult"/>.
    /// </returns>
    public async Task<ForciblyPurgeJavaScriptMemoryResult> ForciblyPurgeJavaScriptMemoryAsync(ForciblyPurgeJavaScriptMemoryCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ForciblyPurgeJavaScriptMemoryCommandParameters();
        return await ExecuteCommandAsync(ForciblyPurgeJavaScriptMemoryCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ForciblyPurgeJavaScriptMemoryCommandParameters, ForciblyPurgeJavaScriptMemoryResult> ForciblyPurgeJavaScriptMemoryCommand = new("Memory.forciblyPurgeJavaScriptMemory", JsonContext.ForciblyPurgeJavaScriptMemoryCommandParameters, JsonContext.ForciblyPurgeJavaScriptMemoryResult);

    /// <summary>
    /// Enable/disable suppressing memory pressure notifications in all processes.
    /// </summary>
    /// <param name="suppressed">
    /// If true, memory pressure notifications will be suppressed.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetPressureNotificationsSuppressedCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetPressureNotificationsSuppressedResult"/>.
    /// </returns>
    public async Task<SetPressureNotificationsSuppressedResult> SetPressureNotificationsSuppressedAsync(bool suppressed, SetPressureNotificationsSuppressedCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetPressureNotificationsSuppressedCommandParameters(Suppressed: suppressed);
        return await ExecuteCommandAsync(SetPressureNotificationsSuppressedCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetPressureNotificationsSuppressedCommandParameters, SetPressureNotificationsSuppressedResult> SetPressureNotificationsSuppressedCommand = new("Memory.setPressureNotificationsSuppressed", JsonContext.SetPressureNotificationsSuppressedCommandParameters, JsonContext.SetPressureNotificationsSuppressedResult);

    /// <summary>
    /// Simulate a memory pressure notification in all processes.
    /// </summary>
    /// <param name="level">
    /// Memory pressure level of the notification.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SimulatePressureNotificationCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SimulatePressureNotificationResult"/>.
    /// </returns>
    public async Task<SimulatePressureNotificationResult> SimulatePressureNotificationAsync(PressureLevel level, SimulatePressureNotificationCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SimulatePressureNotificationCommandParameters(Level: level);
        return await ExecuteCommandAsync(SimulatePressureNotificationCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SimulatePressureNotificationCommandParameters, SimulatePressureNotificationResult> SimulatePressureNotificationCommand = new("Memory.simulatePressureNotification", JsonContext.SimulatePressureNotificationCommandParameters, JsonContext.SimulatePressureNotificationResult);

    /// <summary>
    /// Start collecting native memory profile.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>SamplingInterval</b> - Average number of bytes between samples.</description></item>
    /// <item><description><b>SuppressRandomness</b> - Do not randomize intervals between samples.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="StartSamplingCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StartSamplingResult"/>.
    /// </returns>
    public async Task<StartSamplingResult> StartSamplingAsync(StartSamplingCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new StartSamplingCommandParameters(SamplingInterval: options?.SamplingInterval, SuppressRandomness: options?.SuppressRandomness);
        return await ExecuteCommandAsync(StartSamplingCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StartSamplingCommandParameters, StartSamplingResult> StartSamplingCommand = new("Memory.startSampling", JsonContext.StartSamplingCommandParameters, JsonContext.StartSamplingResult);

    /// <summary>
    /// Stop collecting native memory profile.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="StopSamplingCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StopSamplingResult"/>.
    /// </returns>
    public async Task<StopSamplingResult> StopSamplingAsync(StopSamplingCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new StopSamplingCommandParameters();
        return await ExecuteCommandAsync(StopSamplingCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StopSamplingCommandParameters, StopSamplingResult> StopSamplingCommand = new("Memory.stopSampling", JsonContext.StopSamplingCommandParameters, JsonContext.StopSamplingResult);

    /// <summary>
    /// Retrieve native memory allocations profile
    /// collected since renderer process startup.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetAllTimeSamplingProfileCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetAllTimeSamplingProfileResult"/>.
    /// </returns>
    public async Task<GetAllTimeSamplingProfileResult> GetAllTimeSamplingProfileAsync(GetAllTimeSamplingProfileCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetAllTimeSamplingProfileCommandParameters();
        return await ExecuteCommandAsync(GetAllTimeSamplingProfileCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetAllTimeSamplingProfileCommandParameters, GetAllTimeSamplingProfileResult> GetAllTimeSamplingProfileCommand = new("Memory.getAllTimeSamplingProfile", JsonContext.GetAllTimeSamplingProfileCommandParameters, JsonContext.GetAllTimeSamplingProfileResult);

    /// <summary>
    /// Retrieve native memory allocations profile
    /// collected since browser process startup.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetBrowserSamplingProfileCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetBrowserSamplingProfileResult"/>.
    /// </returns>
    public async Task<GetBrowserSamplingProfileResult> GetBrowserSamplingProfileAsync(GetBrowserSamplingProfileCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetBrowserSamplingProfileCommandParameters();
        return await ExecuteCommandAsync(GetBrowserSamplingProfileCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetBrowserSamplingProfileCommandParameters, GetBrowserSamplingProfileResult> GetBrowserSamplingProfileCommand = new("Memory.getBrowserSamplingProfile", JsonContext.GetBrowserSamplingProfileCommandParameters, JsonContext.GetBrowserSamplingProfileResult);

    /// <summary>
    /// Retrieve native memory allocations profile collected since last
    /// <b>startSampling</b> call.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetSamplingProfileCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetSamplingProfileResult"/>.
    /// </returns>
    public async Task<GetSamplingProfileResult> GetSamplingProfileAsync(GetSamplingProfileCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetSamplingProfileCommandParameters();
        return await ExecuteCommandAsync(GetSamplingProfileCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetSamplingProfileCommandParameters, GetSamplingProfileResult> GetSamplingProfileCommand = new("Memory.getSamplingProfile", JsonContext.GetSamplingProfileCommandParameters, JsonContext.GetSamplingProfileResult);

}

internal sealed record GetDOMCountersCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="MemoryDomain.GetDOMCountersAsync"/>.
/// </summary>
public sealed record GetDOMCountersCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Documents">
/// </param>
/// <param name="Nodes">
/// </param>
/// <param name="JsEventListeners">
/// </param>
public sealed record GetDOMCountersResult(long Documents, long Nodes, long JsEventListeners) : EmptyResult;


internal sealed record GetDOMCountersForLeakDetectionCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="MemoryDomain.GetDOMCountersForLeakDetectionAsync"/>.
/// </summary>
public sealed record GetDOMCountersForLeakDetectionCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Counters">
/// DOM object counters.
/// </param>
public sealed record GetDOMCountersForLeakDetectionResult(ImmutableArray<DOMCounter> Counters) : EmptyResult;


internal sealed record PrepareForLeakDetectionCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="MemoryDomain.PrepareForLeakDetectionAsync"/>.
/// </summary>
public sealed record PrepareForLeakDetectionCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record PrepareForLeakDetectionResult() : EmptyResult;


internal sealed record ForciblyPurgeJavaScriptMemoryCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="MemoryDomain.ForciblyPurgeJavaScriptMemoryAsync"/>.
/// </summary>
public sealed record ForciblyPurgeJavaScriptMemoryCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ForciblyPurgeJavaScriptMemoryResult() : EmptyResult;


internal sealed record SetPressureNotificationsSuppressedCommandParameters(bool Suppressed) : Parameters;

/// <summary>
/// Optional parameters for <see cref="MemoryDomain.SetPressureNotificationsSuppressedAsync"/>.
/// </summary>
public sealed record SetPressureNotificationsSuppressedCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetPressureNotificationsSuppressedResult() : EmptyResult;


internal sealed record SimulatePressureNotificationCommandParameters(PressureLevel Level) : Parameters;

/// <summary>
/// Optional parameters for <see cref="MemoryDomain.SimulatePressureNotificationAsync"/>.
/// </summary>
public sealed record SimulatePressureNotificationCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SimulatePressureNotificationResult() : EmptyResult;


internal sealed record StartSamplingCommandParameters(long? SamplingInterval, bool? SuppressRandomness) : Parameters;

/// <summary>
/// Optional parameters for <see cref="MemoryDomain.StartSamplingAsync"/>.
/// </summary>
public sealed record StartSamplingCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Average number of bytes between samples.
    /// </summary>
    public long? SamplingInterval { get; init; }

    /// <summary>
    /// Do not randomize intervals between samples.
    /// </summary>
    public bool? SuppressRandomness { get; init; }
}

/// <summary>
/// </summary>
public sealed record StartSamplingResult() : EmptyResult;


internal sealed record StopSamplingCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="MemoryDomain.StopSamplingAsync"/>.
/// </summary>
public sealed record StopSamplingCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record StopSamplingResult() : EmptyResult;


internal sealed record GetAllTimeSamplingProfileCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="MemoryDomain.GetAllTimeSamplingProfileAsync"/>.
/// </summary>
public sealed record GetAllTimeSamplingProfileCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Profile">
/// </param>
public sealed record GetAllTimeSamplingProfileResult(SamplingProfile Profile) : EmptyResult;


internal sealed record GetBrowserSamplingProfileCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="MemoryDomain.GetBrowserSamplingProfileAsync"/>.
/// </summary>
public sealed record GetBrowserSamplingProfileCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Profile">
/// </param>
public sealed record GetBrowserSamplingProfileResult(SamplingProfile Profile) : EmptyResult;


internal sealed record GetSamplingProfileCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="MemoryDomain.GetSamplingProfileAsync"/>.
/// </summary>
public sealed record GetSamplingProfileCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Profile">
/// </param>
public sealed record GetSamplingProfileResult(SamplingProfile Profile) : EmptyResult;


/// <summary>
/// Memory pressure level.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<PressureLevel>))]
public enum PressureLevel
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("moderate")]
    Moderate,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("critical")]
    Critical,
}

/// <summary>
/// Heap profile sample.
/// </summary>
/// <param name="Size">
/// Size of the sampled allocation.
/// </param>
/// <param name="Total">
/// Total bytes attributed to this sample.
/// </param>
/// <param name="Stack">
/// Execution stack at the point of allocation.
/// </param>
public sealed record SamplingProfileNode(double Size, double Total, ImmutableArray<string> Stack)
{
}

/// <summary>
/// Array of heap profile samples.
/// </summary>
/// <param name="Samples">
/// </param>
/// <param name="Modules">
/// </param>
public sealed record SamplingProfile(ImmutableArray<SamplingProfileNode> Samples, ImmutableArray<Module> Modules)
{
}

/// <summary>
/// Executable module information
/// </summary>
/// <param name="Name">
/// Name of the module.
/// </param>
/// <param name="Uuid">
/// UUID of the module.
/// </param>
/// <param name="BaseAddress">
/// Base address where the module is loaded into memory. Encoded as a decimal
/// or hexadecimal (0x prefixed) string.
/// </param>
/// <param name="Size">
/// Size of the module in bytes.
/// </param>
public sealed record Module(string Name, string Uuid, string BaseAddress, double Size)
{
}

/// <summary>
/// DOM object counter data.
/// </summary>
/// <param name="Name">
/// Object name. Note: object names should be presumed volatile and clients should not expect
/// the returned names to be consistent across runs.
/// </param>
/// <param name="Count">
/// Object count.
/// </param>
public sealed record DOMCounter(string Name, long Count)
{
}

[JsonSerializable(typeof(GetDOMCountersCommandParameters), TypeInfoPropertyName = "GetDOMCountersCommandParameters")]
[JsonSerializable(typeof(GetDOMCountersResult), TypeInfoPropertyName = "GetDOMCountersResult")]
[JsonSerializable(typeof(GetDOMCountersForLeakDetectionCommandParameters), TypeInfoPropertyName = "GetDOMCountersForLeakDetectionCommandParameters")]
[JsonSerializable(typeof(GetDOMCountersForLeakDetectionResult), TypeInfoPropertyName = "GetDOMCountersForLeakDetectionResult")]
[JsonSerializable(typeof(PrepareForLeakDetectionCommandParameters), TypeInfoPropertyName = "PrepareForLeakDetectionCommandParameters")]
[JsonSerializable(typeof(PrepareForLeakDetectionResult), TypeInfoPropertyName = "PrepareForLeakDetectionResult")]
[JsonSerializable(typeof(ForciblyPurgeJavaScriptMemoryCommandParameters), TypeInfoPropertyName = "ForciblyPurgeJavaScriptMemoryCommandParameters")]
[JsonSerializable(typeof(ForciblyPurgeJavaScriptMemoryResult), TypeInfoPropertyName = "ForciblyPurgeJavaScriptMemoryResult")]
[JsonSerializable(typeof(SetPressureNotificationsSuppressedCommandParameters), TypeInfoPropertyName = "SetPressureNotificationsSuppressedCommandParameters")]
[JsonSerializable(typeof(SetPressureNotificationsSuppressedResult), TypeInfoPropertyName = "SetPressureNotificationsSuppressedResult")]
[JsonSerializable(typeof(SimulatePressureNotificationCommandParameters), TypeInfoPropertyName = "SimulatePressureNotificationCommandParameters")]
[JsonSerializable(typeof(SimulatePressureNotificationResult), TypeInfoPropertyName = "SimulatePressureNotificationResult")]
[JsonSerializable(typeof(StartSamplingCommandParameters), TypeInfoPropertyName = "StartSamplingCommandParameters")]
[JsonSerializable(typeof(StartSamplingResult), TypeInfoPropertyName = "StartSamplingResult")]
[JsonSerializable(typeof(StopSamplingCommandParameters), TypeInfoPropertyName = "StopSamplingCommandParameters")]
[JsonSerializable(typeof(StopSamplingResult), TypeInfoPropertyName = "StopSamplingResult")]
[JsonSerializable(typeof(GetAllTimeSamplingProfileCommandParameters), TypeInfoPropertyName = "GetAllTimeSamplingProfileCommandParameters")]
[JsonSerializable(typeof(GetAllTimeSamplingProfileResult), TypeInfoPropertyName = "GetAllTimeSamplingProfileResult")]
[JsonSerializable(typeof(GetBrowserSamplingProfileCommandParameters), TypeInfoPropertyName = "GetBrowserSamplingProfileCommandParameters")]
[JsonSerializable(typeof(GetBrowserSamplingProfileResult), TypeInfoPropertyName = "GetBrowserSamplingProfileResult")]
[JsonSerializable(typeof(GetSamplingProfileCommandParameters), TypeInfoPropertyName = "GetSamplingProfileCommandParameters")]
[JsonSerializable(typeof(GetSamplingProfileResult), TypeInfoPropertyName = "GetSamplingProfileResult")]
[JsonSerializable(typeof(PressureLevel), TypeInfoPropertyName = "MemoryPressureLevel")]
[JsonSerializable(typeof(SamplingProfileNode), TypeInfoPropertyName = "MemorySamplingProfileNode")]
[JsonSerializable(typeof(SamplingProfile), TypeInfoPropertyName = "MemorySamplingProfile")]
[JsonSerializable(typeof(Module), TypeInfoPropertyName = "MemoryModule")]
[JsonSerializable(typeof(DOMCounter), TypeInfoPropertyName = "MemoryDOMCounter")]
[JsonSerializable(typeof(ImmutableArray<DOMCounter>), TypeInfoPropertyName = "ImmutableArrayMemoryDOMCounter")]
[JsonSerializable(typeof(ImmutableArray<SamplingProfileNode>), TypeInfoPropertyName = "ImmutableArrayMemorySamplingProfileNode")]
[JsonSerializable(typeof(ImmutableArray<Module>), TypeInfoPropertyName = "ImmutableArrayMemoryModule")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class MemoryJsonSerializerContext : JsonSerializerContext;

