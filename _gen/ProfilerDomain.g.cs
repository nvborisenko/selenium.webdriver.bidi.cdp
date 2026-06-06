#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Profiler;

/// <summary>
/// </summary>
public sealed class ProfilerDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static ProfilerJsonSerializerContext JsonContext = ProfilerJsonSerializerContext.Default;

    /// <summary>
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
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("Profiler.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
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
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("Profiler.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Collect coverage data for the current isolate. The coverage data may be incomplete due to
    /// garbage collection.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetBestEffortCoverageCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetBestEffortCoverageResult"/>.
    /// </returns>
    public async Task<GetBestEffortCoverageResult> GetBestEffortCoverageAsync(GetBestEffortCoverageCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetBestEffortCoverageCommandParameters();
        return await ExecuteCommandAsync(GetBestEffortCoverageCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetBestEffortCoverageCommandParameters, GetBestEffortCoverageResult> GetBestEffortCoverageCommand = new("Profiler.getBestEffortCoverage", JsonContext.GetBestEffortCoverageCommandParameters, JsonContext.GetBestEffortCoverageResult);

    /// <summary>
    /// Changes CPU profiler sampling interval. Must be called before CPU profiles recording started.
    /// </summary>
    /// <param name="interval">
    /// New sampling interval in microseconds.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetSamplingIntervalCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetSamplingIntervalResult"/>.
    /// </returns>
    public async Task<SetSamplingIntervalResult> SetSamplingIntervalAsync(long interval, SetSamplingIntervalCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetSamplingIntervalCommandParameters(Interval: interval);
        return await ExecuteCommandAsync(SetSamplingIntervalCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetSamplingIntervalCommandParameters, SetSamplingIntervalResult> SetSamplingIntervalCommand = new("Profiler.setSamplingInterval", JsonContext.SetSamplingIntervalCommandParameters, JsonContext.SetSamplingIntervalResult);

    /// <summary>
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="StartCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StartResult"/>.
    /// </returns>
    public async Task<StartResult> StartAsync(StartCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new StartCommandParameters();
        return await ExecuteCommandAsync(StartCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StartCommandParameters, StartResult> StartCommand = new("Profiler.start", JsonContext.StartCommandParameters, JsonContext.StartResult);

    /// <summary>
    /// Enable precise code coverage. Coverage data for JavaScript executed before enabling precise code
    /// coverage may be incomplete. Enabling prevents running optimized code and resets execution
    /// counters.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>CallCount</b> - Collect accurate call counts beyond simple 'covered' or 'not covered'.</description></item>
    /// <item><description><b>Detailed</b> - Collect block-based coverage.</description></item>
    /// <item><description><b>AllowTriggeredUpdates</b> - Allow the backend to send updates on its own initiative</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="StartPreciseCoverageCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StartPreciseCoverageResult"/>.
    /// </returns>
    public async Task<StartPreciseCoverageResult> StartPreciseCoverageAsync(StartPreciseCoverageCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new StartPreciseCoverageCommandParameters(CallCount: options?.CallCount, Detailed: options?.Detailed, AllowTriggeredUpdates: options?.AllowTriggeredUpdates);
        return await ExecuteCommandAsync(StartPreciseCoverageCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StartPreciseCoverageCommandParameters, StartPreciseCoverageResult> StartPreciseCoverageCommand = new("Profiler.startPreciseCoverage", JsonContext.StartPreciseCoverageCommandParameters, JsonContext.StartPreciseCoverageResult);

    /// <summary>
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="StopCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StopResult"/>.
    /// </returns>
    public async Task<StopResult> StopAsync(StopCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new StopCommandParameters();
        return await ExecuteCommandAsync(StopCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StopCommandParameters, StopResult> StopCommand = new("Profiler.stop", JsonContext.StopCommandParameters, JsonContext.StopResult);

    /// <summary>
    /// Disable precise code coverage. Disabling releases unnecessary execution count records and allows
    /// executing optimized code.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="StopPreciseCoverageCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StopPreciseCoverageResult"/>.
    /// </returns>
    public async Task<StopPreciseCoverageResult> StopPreciseCoverageAsync(StopPreciseCoverageCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new StopPreciseCoverageCommandParameters();
        return await ExecuteCommandAsync(StopPreciseCoverageCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StopPreciseCoverageCommandParameters, StopPreciseCoverageResult> StopPreciseCoverageCommand = new("Profiler.stopPreciseCoverage", JsonContext.StopPreciseCoverageCommandParameters, JsonContext.StopPreciseCoverageResult);

    /// <summary>
    /// Collect coverage data for the current isolate, and resets execution counters. Precise code
    /// coverage needs to have started.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="TakePreciseCoverageCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="TakePreciseCoverageResult"/>.
    /// </returns>
    public async Task<TakePreciseCoverageResult> TakePreciseCoverageAsync(TakePreciseCoverageCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new TakePreciseCoverageCommandParameters();
        return await ExecuteCommandAsync(TakePreciseCoverageCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<TakePreciseCoverageCommandParameters, TakePreciseCoverageResult> TakePreciseCoverageCommand = new("Profiler.takePreciseCoverage", JsonContext.TakePreciseCoverageCommandParameters, JsonContext.TakePreciseCoverageResult);

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ConsoleProfileFinishedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Id</b></description></item>
    /// <item><description><b>Location</b> - Location of console.profileEnd().</description></item>
    /// <item><description><b>Profile</b></description></item>
    /// <item><description><b>Title</b> - Profile title passed as an argument to console.profile().</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ConsoleProfileFinishedEventArgs> ConsoleProfileFinished => CreateCdpEventSource(ProfilerDomainEvent.ConsoleProfileFinished);
    /// <summary>
    /// Sent when new profile recording is started using console.profile() call.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ConsoleProfileStartedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Id</b></description></item>
    /// <item><description><b>Location</b> - Location of console.profile().</description></item>
    /// <item><description><b>Title</b> - Profile title passed as an argument to console.profile().</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ConsoleProfileStartedEventArgs> ConsoleProfileStarted => CreateCdpEventSource(ProfilerDomainEvent.ConsoleProfileStarted);
    /// <summary>
    /// Reports coverage delta since the last poll (either from an event like this, or from
    /// <b>takePreciseCoverage</b> for the current isolate. May only be sent if precise code
    /// coverage has been started. This event can be trigged by the embedder to, for example,
    /// trigger collection of coverage data immediately at a certain point in time.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="PreciseCoverageDeltaUpdateEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Timestamp</b> - Monotonically increasing time (in seconds) when the coverage update was taken in the backend.</description></item>
    /// <item><description><b>Occasion</b> - Identifier for distinguishing coverage events.</description></item>
    /// <item><description><b>Result</b> - Coverage data for the current isolate.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<PreciseCoverageDeltaUpdateEventArgs> PreciseCoverageDeltaUpdate => CreateCdpEventSource(ProfilerDomainEvent.PreciseCoverageDeltaUpdate);
}

internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="ProfilerDomain.DisableAsync"/>.
/// </summary>
public sealed record DisableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="ProfilerDomain.EnableAsync"/>.
/// </summary>
public sealed record EnableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record GetBestEffortCoverageCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="ProfilerDomain.GetBestEffortCoverageAsync"/>.
/// </summary>
public sealed record GetBestEffortCoverageCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Result">
/// Coverage data for the current isolate.
/// </param>
public sealed record GetBestEffortCoverageResult(IReadOnlyList<ScriptCoverage> Result) : EmptyResult;


internal sealed record SetSamplingIntervalCommandParameters(long Interval) : Parameters;

/// <summary>
/// Optional parameters for <see cref="ProfilerDomain.SetSamplingIntervalAsync"/>.
/// </summary>
public sealed record SetSamplingIntervalCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetSamplingIntervalResult() : EmptyResult;


internal sealed record StartCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="ProfilerDomain.StartAsync"/>.
/// </summary>
public sealed record StartCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record StartResult() : EmptyResult;


internal sealed record StartPreciseCoverageCommandParameters(bool? CallCount, bool? Detailed, bool? AllowTriggeredUpdates) : Parameters;

/// <summary>
/// Optional parameters for <see cref="ProfilerDomain.StartPreciseCoverageAsync"/>.
/// </summary>
public sealed record StartPreciseCoverageCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Collect accurate call counts beyond simple 'covered' or 'not covered'.
    /// </summary>
    public bool? CallCount { get; init; }

    /// <summary>
    /// Collect block-based coverage.
    /// </summary>
    public bool? Detailed { get; init; }

    /// <summary>
    /// Allow the backend to send updates on its own initiative
    /// </summary>
    public bool? AllowTriggeredUpdates { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Timestamp">
/// Monotonically increasing time (in seconds) when the coverage update was taken in the backend.
/// </param>
public sealed record StartPreciseCoverageResult(double Timestamp) : EmptyResult;


internal sealed record StopCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="ProfilerDomain.StopAsync"/>.
/// </summary>
public sealed record StopCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Profile">
/// Recorded profile.
/// </param>
public sealed record StopResult(Profile Profile) : EmptyResult;


internal sealed record StopPreciseCoverageCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="ProfilerDomain.StopPreciseCoverageAsync"/>.
/// </summary>
public sealed record StopPreciseCoverageCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record StopPreciseCoverageResult() : EmptyResult;


internal sealed record TakePreciseCoverageCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="ProfilerDomain.TakePreciseCoverageAsync"/>.
/// </summary>
public sealed record TakePreciseCoverageCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Result">
/// Coverage data for the current isolate.
/// </param>
/// <param name="Timestamp">
/// Monotonically increasing time (in seconds) when the coverage update was taken in the backend.
/// </param>
public sealed record TakePreciseCoverageResult(IReadOnlyList<ScriptCoverage> Result, double Timestamp) : EmptyResult;


/// <summary>
/// </summary>
/// <param name="Id">
/// </param>
/// <param name="Location">
/// Location of console.profileEnd().
/// </param>
/// <param name="Profile">
/// </param>
/// <param name="Title">
/// Profile title passed as an argument to console.profile().
/// </param>
public sealed record ConsoleProfileFinishedEventArgs(string Id, Debugger.Location Location, Profile Profile, string? Title = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Sent when new profile recording is started using console.profile() call.
/// </summary>
/// <param name="Id">
/// </param>
/// <param name="Location">
/// Location of console.profile().
/// </param>
/// <param name="Title">
/// Profile title passed as an argument to console.profile().
/// </param>
public sealed record ConsoleProfileStartedEventArgs(string Id, Debugger.Location Location, string? Title = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Reports coverage delta since the last poll (either from an event like this, or from
/// <b>takePreciseCoverage</b> for the current isolate. May only be sent if precise code
/// coverage has been started. This event can be trigged by the embedder to, for example,
/// trigger collection of coverage data immediately at a certain point in time.
/// </summary>
/// <param name="Timestamp">
/// Monotonically increasing time (in seconds) when the coverage update was taken in the backend.
/// </param>
/// <param name="Occasion">
/// Identifier for distinguishing coverage events.
/// </param>
/// <param name="Result">
/// Coverage data for the current isolate.
/// </param>
public sealed record PreciseCoverageDeltaUpdateEventArgs(double Timestamp, string Occasion, IEnumerable<ScriptCoverage> Result) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Profile node. Holds callsite information, execution statistics and child nodes.
/// </summary>
/// <param name="Id">
/// Unique id of the node.
/// </param>
/// <param name="CallFrame">
/// Function location.
/// </param>
public sealed record ProfileNode(long Id, Runtime.CallFrame CallFrame)
{
    /// <summary>
    /// Number of samples where this node was on top of the call stack.
    /// </summary>
    public long? HitCount { get; init; }

    /// <summary>
    /// Child node ids.
    /// </summary>
    public IReadOnlyList<long>? Children { get; init; }

    /// <summary>
    /// The reason of being not optimized. The function may be deoptimized or marked as don't
    /// optimize.
    /// </summary>
    public string? DeoptReason { get; init; }

    /// <summary>
    /// An array of source position ticks.
    /// </summary>
    public IReadOnlyList<PositionTickInfo>? PositionTicks { get; init; }
}

/// <summary>
/// Profile.
/// </summary>
/// <param name="Nodes">
/// The list of profile nodes. First item is the root node.
/// </param>
/// <param name="StartTime">
/// Profiling start timestamp in microseconds.
/// </param>
/// <param name="EndTime">
/// Profiling end timestamp in microseconds.
/// </param>
public sealed record Profile(IReadOnlyList<ProfileNode> Nodes, double StartTime, double EndTime)
{
    /// <summary>
    /// Ids of samples top nodes.
    /// </summary>
    public IReadOnlyList<long>? Samples { get; init; }

    /// <summary>
    /// Time intervals between adjacent samples in microseconds. The first delta is relative to the
    /// profile startTime.
    /// </summary>
    public IReadOnlyList<long>? TimeDeltas { get; init; }
}

/// <summary>
/// Specifies a number of samples attributed to a certain source position.
/// </summary>
/// <param name="Line">
/// Source line number (1-based).
/// </param>
/// <param name="Ticks">
/// Number of samples attributed to the source line.
/// </param>
public sealed record PositionTickInfo(long Line, long Ticks)
{
}

/// <summary>
/// Coverage data for a source range.
/// </summary>
/// <param name="StartOffset">
/// JavaScript script source offset for the range start.
/// </param>
/// <param name="EndOffset">
/// JavaScript script source offset for the range end.
/// </param>
/// <param name="Count">
/// Collected execution count of the source range.
/// </param>
public sealed record CoverageRange(long StartOffset, long EndOffset, long Count)
{
}

/// <summary>
/// Coverage data for a JavaScript function.
/// </summary>
/// <param name="FunctionName">
/// JavaScript function name.
/// </param>
/// <param name="Ranges">
/// Source ranges inside the function with coverage data.
/// </param>
/// <param name="IsBlockCoverage">
/// Whether coverage data for this function has block granularity.
/// </param>
public sealed record FunctionCoverage(string FunctionName, IReadOnlyList<CoverageRange> Ranges, bool IsBlockCoverage)
{
}

/// <summary>
/// Coverage data for a JavaScript script.
/// </summary>
/// <param name="ScriptId">
/// JavaScript script id.
/// </param>
/// <param name="Url">
/// JavaScript script name or url.
/// </param>
/// <param name="Functions">
/// Functions contained in the script that has coverage data.
/// </param>
public sealed record ScriptCoverage(Runtime.ScriptId ScriptId, string Url, IReadOnlyList<FunctionCoverage> Functions)
{
}

[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(GetBestEffortCoverageCommandParameters), TypeInfoPropertyName = "GetBestEffortCoverageCommandParameters")]
[JsonSerializable(typeof(GetBestEffortCoverageResult), TypeInfoPropertyName = "GetBestEffortCoverageResult")]
[JsonSerializable(typeof(SetSamplingIntervalCommandParameters), TypeInfoPropertyName = "SetSamplingIntervalCommandParameters")]
[JsonSerializable(typeof(SetSamplingIntervalResult), TypeInfoPropertyName = "SetSamplingIntervalResult")]
[JsonSerializable(typeof(StartCommandParameters), TypeInfoPropertyName = "StartCommandParameters")]
[JsonSerializable(typeof(StartResult), TypeInfoPropertyName = "StartResult")]
[JsonSerializable(typeof(StartPreciseCoverageCommandParameters), TypeInfoPropertyName = "StartPreciseCoverageCommandParameters")]
[JsonSerializable(typeof(StartPreciseCoverageResult), TypeInfoPropertyName = "StartPreciseCoverageResult")]
[JsonSerializable(typeof(StopCommandParameters), TypeInfoPropertyName = "StopCommandParameters")]
[JsonSerializable(typeof(StopResult), TypeInfoPropertyName = "StopResult")]
[JsonSerializable(typeof(StopPreciseCoverageCommandParameters), TypeInfoPropertyName = "StopPreciseCoverageCommandParameters")]
[JsonSerializable(typeof(StopPreciseCoverageResult), TypeInfoPropertyName = "StopPreciseCoverageResult")]
[JsonSerializable(typeof(TakePreciseCoverageCommandParameters), TypeInfoPropertyName = "TakePreciseCoverageCommandParameters")]
[JsonSerializable(typeof(TakePreciseCoverageResult), TypeInfoPropertyName = "TakePreciseCoverageResult")]
[JsonSerializable(typeof(CdpEventArgs<ConsoleProfileFinishedEventArgs>), TypeInfoPropertyName = "ConsoleProfileFinishedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ConsoleProfileStartedEventArgs>), TypeInfoPropertyName = "ConsoleProfileStartedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<PreciseCoverageDeltaUpdateEventArgs>), TypeInfoPropertyName = "PreciseCoverageDeltaUpdateCdpEventArgs")]
[JsonSerializable(typeof(ProfileNode), TypeInfoPropertyName = "ProfilerProfileNode")]
[JsonSerializable(typeof(Profile), TypeInfoPropertyName = "ProfilerProfile")]
[JsonSerializable(typeof(PositionTickInfo), TypeInfoPropertyName = "ProfilerPositionTickInfo")]
[JsonSerializable(typeof(CoverageRange), TypeInfoPropertyName = "ProfilerCoverageRange")]
[JsonSerializable(typeof(FunctionCoverage), TypeInfoPropertyName = "ProfilerFunctionCoverage")]
[JsonSerializable(typeof(ScriptCoverage), TypeInfoPropertyName = "ProfilerScriptCoverage")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<ScriptCoverage>), TypeInfoPropertyName = "IReadOnlyListProfilerScriptCoverage")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<PositionTickInfo>), TypeInfoPropertyName = "IReadOnlyListProfilerPositionTickInfo")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<ProfileNode>), TypeInfoPropertyName = "IReadOnlyListProfilerProfileNode")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<CoverageRange>), TypeInfoPropertyName = "IReadOnlyListProfilerCoverageRange")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<FunctionCoverage>), TypeInfoPropertyName = "IReadOnlyListProfilerFunctionCoverage")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class ProfilerJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="ProfilerDomain"/>.
/// </summary>
public static class ProfilerDomainEvent
{
    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ConsoleProfileFinishedEventArgs>> ConsoleProfileFinished { get; } =
        EventDescriptor<CdpEventArgs<ConsoleProfileFinishedEventArgs>>.Create(
            "goog:cdp.Profiler.consoleProfileFinished",
            ProfilerJsonSerializerContext.Default.ConsoleProfileFinishedCdpEventArgs);

    /// <summary>
    /// Sent when new profile recording is started using console.profile() call.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ConsoleProfileStartedEventArgs>> ConsoleProfileStarted { get; } =
        EventDescriptor<CdpEventArgs<ConsoleProfileStartedEventArgs>>.Create(
            "goog:cdp.Profiler.consoleProfileStarted",
            ProfilerJsonSerializerContext.Default.ConsoleProfileStartedCdpEventArgs);

    /// <summary>
    /// Reports coverage delta since the last poll (either from an event like this, or from
    /// <b>takePreciseCoverage</b> for the current isolate. May only be sent if precise code
    /// coverage has been started. This event can be trigged by the embedder to, for example,
    /// trigger collection of coverage data immediately at a certain point in time.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<PreciseCoverageDeltaUpdateEventArgs>> PreciseCoverageDeltaUpdate { get; } =
        EventDescriptor<CdpEventArgs<PreciseCoverageDeltaUpdateEventArgs>>.Create(
            "goog:cdp.Profiler.preciseCoverageDeltaUpdate",
            ProfilerJsonSerializerContext.Default.PreciseCoverageDeltaUpdateCdpEventArgs);

}
