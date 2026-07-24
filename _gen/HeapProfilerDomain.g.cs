#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.HeapProfiler;

/// <summary>
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class HeapProfilerDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static HeapProfilerJsonSerializerContext JsonContext = HeapProfilerJsonSerializerContext.Default;

    /// <summary>
    /// Enables console to refer to the node with given id via $x (see Command Line API for more details
    /// $x functions).
    /// </summary>
    /// <param name="heapObjectId">
    /// Heap snapshot object id to be accessible by means of $x command line API.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AddInspectedHeapObjectResult"/>.
    /// </returns>
    public async Task<AddInspectedHeapObjectResult> AddInspectedHeapObjectAsync(HeapSnapshotObjectId heapObjectId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new AddInspectedHeapObjectCommandParameters(HeapObjectId: heapObjectId);
        return await ExecuteCommandAsync(AddInspectedHeapObjectCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AddInspectedHeapObjectCommandParameters, AddInspectedHeapObjectResult> AddInspectedHeapObjectCommand = new("HeapProfiler.addInspectedHeapObject", JsonContext.AddInspectedHeapObjectCommandParameters, JsonContext.AddInspectedHeapObjectResult);

    /// <summary>
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CollectGarbageResult"/>.
    /// </returns>
    public async Task<CollectGarbageResult> CollectGarbageAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CollectGarbageCommandParameters();
        return await ExecuteCommandAsync(CollectGarbageCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CollectGarbageCommandParameters, CollectGarbageResult> CollectGarbageCommand = new("HeapProfiler.collectGarbage", JsonContext.CollectGarbageCommandParameters, JsonContext.CollectGarbageResult);

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
    public async Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync(DisableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("HeapProfiler.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
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
    public async Task<EnableResult> EnableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters();
        return await ExecuteCommandAsync(EnableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("HeapProfiler.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// </summary>
    /// <param name="objectId">
    /// Identifier of the object to get heap object id for.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetHeapObjectIdResult"/>.
    /// </returns>
    public async Task<GetHeapObjectIdResult> GetHeapObjectIdAsync(Runtime.RemoteObjectId objectId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetHeapObjectIdCommandParameters(ObjectId: objectId);
        return await ExecuteCommandAsync(GetHeapObjectIdCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetHeapObjectIdCommandParameters, GetHeapObjectIdResult> GetHeapObjectIdCommand = new("HeapProfiler.getHeapObjectId", JsonContext.GetHeapObjectIdCommandParameters, JsonContext.GetHeapObjectIdResult);

    /// <summary>
    /// </summary>
    /// <param name="objectId">
    /// </param>
    /// <param name="objectGroup">
    /// Symbolic group name that can be used to release multiple objects.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetObjectByHeapObjectIdResult"/>.
    /// </returns>
    public async Task<GetObjectByHeapObjectIdResult> GetObjectByHeapObjectIdAsync(HeapSnapshotObjectId objectId, string? objectGroup = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetObjectByHeapObjectIdCommandParameters(ObjectId: objectId, ObjectGroup: objectGroup);
        return await ExecuteCommandAsync(GetObjectByHeapObjectIdCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetObjectByHeapObjectIdCommandParameters, GetObjectByHeapObjectIdResult> GetObjectByHeapObjectIdCommand = new("HeapProfiler.getObjectByHeapObjectId", JsonContext.GetObjectByHeapObjectIdCommandParameters, JsonContext.GetObjectByHeapObjectIdResult);

    /// <summary>
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetSamplingProfileResult"/>.
    /// </returns>
    public async Task<GetSamplingProfileResult> GetSamplingProfileAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetSamplingProfileCommandParameters();
        return await ExecuteCommandAsync(GetSamplingProfileCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetSamplingProfileCommandParameters, GetSamplingProfileResult> GetSamplingProfileCommand = new("HeapProfiler.getSamplingProfile", JsonContext.GetSamplingProfileCommandParameters, JsonContext.GetSamplingProfileResult);

    /// <summary>
    /// </summary>
    /// <param name="samplingInterval">
    /// Average sample interval in bytes. Poisson distribution is used for the intervals. The
    /// default value is 32768 bytes.
    /// </param>
    /// <param name="stackDepth">
    /// Maximum stack depth. The default value is 128.
    /// </param>
    /// <param name="includeObjectsCollectedByMajorGC">
    /// By default, the sampling heap profiler reports only objects which are
    /// still alive when the profile is returned via getSamplingProfile or
    /// stopSampling, which is useful for determining what functions contribute
    /// the most to steady-state memory usage. This flag instructs the sampling
    /// heap profiler to also include information about objects discarded by
    /// major GC, which will show which functions cause large temporary memory
    /// usage or long GC pauses.
    /// </param>
    /// <param name="includeObjectsCollectedByMinorGC">
    /// By default, the sampling heap profiler reports only objects which are
    /// still alive when the profile is returned via getSamplingProfile or
    /// stopSampling, which is useful for determining what functions contribute
    /// the most to steady-state memory usage. This flag instructs the sampling
    /// heap profiler to also include information about objects discarded by
    /// minor GC, which is useful when tuning a latency-sensitive application
    /// for minimal GC activity.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StartSamplingResult"/>.
    /// </returns>
    public async Task<StartSamplingResult> StartSamplingAsync(double? samplingInterval = default, double? stackDepth = default, bool? includeObjectsCollectedByMajorGC = default, bool? includeObjectsCollectedByMinorGC = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new StartSamplingCommandParameters(SamplingInterval: samplingInterval, StackDepth: stackDepth, IncludeObjectsCollectedByMajorGC: includeObjectsCollectedByMajorGC, IncludeObjectsCollectedByMinorGC: includeObjectsCollectedByMinorGC);
        return await ExecuteCommandAsync(StartSamplingCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StartSamplingCommandParameters, StartSamplingResult> StartSamplingCommand = new("HeapProfiler.startSampling", JsonContext.StartSamplingCommandParameters, JsonContext.StartSamplingResult);

    /// <summary>
    /// </summary>
    /// <param name="trackAllocations">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StartTrackingHeapObjectsResult"/>.
    /// </returns>
    public async Task<StartTrackingHeapObjectsResult> StartTrackingHeapObjectsAsync(bool? trackAllocations = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new StartTrackingHeapObjectsCommandParameters(TrackAllocations: trackAllocations);
        return await ExecuteCommandAsync(StartTrackingHeapObjectsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StartTrackingHeapObjectsCommandParameters, StartTrackingHeapObjectsResult> StartTrackingHeapObjectsCommand = new("HeapProfiler.startTrackingHeapObjects", JsonContext.StartTrackingHeapObjectsCommandParameters, JsonContext.StartTrackingHeapObjectsResult);

    /// <summary>
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StopSamplingResult"/>.
    /// </returns>
    public async Task<StopSamplingResult> StopSamplingAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new StopSamplingCommandParameters();
        return await ExecuteCommandAsync(StopSamplingCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StopSamplingCommandParameters, StopSamplingResult> StopSamplingCommand = new("HeapProfiler.stopSampling", JsonContext.StopSamplingCommandParameters, JsonContext.StopSamplingResult);

    /// <summary>
    /// </summary>
    /// <param name="reportProgress">
    /// If true 'reportHeapSnapshotProgress' events will be generated while snapshot is being taken
    /// when the tracking is stopped.
    /// </param>
    /// <param name="treatGlobalObjectsAsRoots">
    /// Deprecated in favor of <b>exposeInternals</b>.
    /// </param>
    /// <param name="captureNumericValue">
    /// If true, numerical values are included in the snapshot
    /// </param>
    /// <param name="exposeInternals">
    /// If true, exposes internals of the snapshot.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StopTrackingHeapObjectsResult"/>.
    /// </returns>
    public async Task<StopTrackingHeapObjectsResult> StopTrackingHeapObjectsAsync(bool? reportProgress = default, bool? treatGlobalObjectsAsRoots = default, bool? captureNumericValue = default, bool? exposeInternals = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new StopTrackingHeapObjectsCommandParameters(ReportProgress: reportProgress, TreatGlobalObjectsAsRoots: treatGlobalObjectsAsRoots, CaptureNumericValue: captureNumericValue, ExposeInternals: exposeInternals);
        return await ExecuteCommandAsync(StopTrackingHeapObjectsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StopTrackingHeapObjectsCommandParameters, StopTrackingHeapObjectsResult> StopTrackingHeapObjectsCommand = new("HeapProfiler.stopTrackingHeapObjects", JsonContext.StopTrackingHeapObjectsCommandParameters, JsonContext.StopTrackingHeapObjectsResult);

    /// <summary>
    /// </summary>
    /// <param name="reportProgress">
    /// If true 'reportHeapSnapshotProgress' events will be generated while snapshot is being taken.
    /// </param>
    /// <param name="treatGlobalObjectsAsRoots">
    /// If true, a raw snapshot without artificial roots will be generated.
    /// Deprecated in favor of <b>exposeInternals</b>.
    /// </param>
    /// <param name="captureNumericValue">
    /// If true, numerical values are included in the snapshot
    /// </param>
    /// <param name="exposeInternals">
    /// If true, exposes internals of the snapshot.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="TakeHeapSnapshotResult"/>.
    /// </returns>
    public async Task<TakeHeapSnapshotResult> TakeHeapSnapshotAsync(bool? reportProgress = default, bool? treatGlobalObjectsAsRoots = default, bool? captureNumericValue = default, bool? exposeInternals = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new TakeHeapSnapshotCommandParameters(ReportProgress: reportProgress, TreatGlobalObjectsAsRoots: treatGlobalObjectsAsRoots, CaptureNumericValue: captureNumericValue, ExposeInternals: exposeInternals);
        return await ExecuteCommandAsync(TakeHeapSnapshotCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<TakeHeapSnapshotCommandParameters, TakeHeapSnapshotResult> TakeHeapSnapshotCommand = new("HeapProfiler.takeHeapSnapshot", JsonContext.TakeHeapSnapshotCommandParameters, JsonContext.TakeHeapSnapshotResult);

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="AddHeapSnapshotChunkEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Chunk</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<AddHeapSnapshotChunkEventArgs> AddHeapSnapshotChunk => CreateCdpEventSource(HeapProfilerDomainEvent.AddHeapSnapshotChunk);
    /// <summary>
    /// If heap objects tracking has been started then backend may send update for one or more fragments
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="HeapStatsUpdateEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>StatsUpdate</b> - An array of triplets. Each triplet describes a fragment. The first integer is the fragment index, the second integer is a total count of objects for the fragment, the third integer is a total size of the objects for the fragment.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<HeapStatsUpdateEventArgs> HeapStatsUpdate => CreateCdpEventSource(HeapProfilerDomainEvent.HeapStatsUpdate);
    /// <summary>
    /// If heap objects tracking has been started then backend regularly sends a current value for last
    /// seen object id and corresponding timestamp. If the were changes in the heap since last event
    /// then one or more heapStatsUpdate events will be sent before a new lastSeenObjectId event.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="LastSeenObjectIdEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>LastSeenObjectId</b></description></item>
    /// <item><description><b>Timestamp</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<LastSeenObjectIdEventArgs> LastSeenObjectId => CreateCdpEventSource(HeapProfilerDomainEvent.LastSeenObjectId);
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ReportHeapSnapshotProgressEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Done</b></description></item>
    /// <item><description><b>Total</b></description></item>
    /// <item><description><b>Finished</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ReportHeapSnapshotProgressEventArgs> ReportHeapSnapshotProgress => CreateCdpEventSource(HeapProfilerDomainEvent.ReportHeapSnapshotProgress);
    /// <summary>
    /// 
    /// </summary>
    public IEventSource<ResetProfilesEventArgs> ResetProfiles => CreateCdpEventSource(HeapProfilerDomainEvent.ResetProfiles);
}

internal sealed record AddInspectedHeapObjectCommandParameters(HeapSnapshotObjectId HeapObjectId) : Parameters;

/// <summary>
/// </summary>
public sealed record AddInspectedHeapObjectResult() : EmptyResult;


internal sealed record CollectGarbageCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record CollectGarbageResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record GetHeapObjectIdCommandParameters(Runtime.RemoteObjectId ObjectId) : Parameters;

/// <summary>
/// </summary>
/// <param name="HeapSnapshotObjectId">
/// Id of the heap snapshot object corresponding to the passed remote object id.
/// </param>
public sealed record GetHeapObjectIdResult(HeapSnapshotObjectId HeapSnapshotObjectId) : EmptyResult;


internal sealed record GetObjectByHeapObjectIdCommandParameters(HeapSnapshotObjectId ObjectId, string? ObjectGroup) : Parameters;

/// <summary>
/// </summary>
/// <param name="Result">
/// Evaluation result.
/// </param>
public sealed record GetObjectByHeapObjectIdResult(Runtime.RemoteObject Result) : EmptyResult;


internal sealed record GetSamplingProfileCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="Profile">
/// Return the sampling profile being collected.
/// </param>
public sealed record GetSamplingProfileResult(SamplingHeapProfile Profile) : EmptyResult;


internal sealed record StartSamplingCommandParameters(double? SamplingInterval, double? StackDepth, bool? IncludeObjectsCollectedByMajorGC, bool? IncludeObjectsCollectedByMinorGC) : Parameters;

/// <summary>
/// </summary>
public sealed record StartSamplingResult() : EmptyResult;


internal sealed record StartTrackingHeapObjectsCommandParameters(bool? TrackAllocations) : Parameters;

/// <summary>
/// </summary>
public sealed record StartTrackingHeapObjectsResult() : EmptyResult;


internal sealed record StopSamplingCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="Profile">
/// Recorded sampling heap profile.
/// </param>
public sealed record StopSamplingResult(SamplingHeapProfile Profile) : EmptyResult;


internal sealed record StopTrackingHeapObjectsCommandParameters(bool? ReportProgress, bool? TreatGlobalObjectsAsRoots, bool? CaptureNumericValue, bool? ExposeInternals) : Parameters;

/// <summary>
/// </summary>
public sealed record StopTrackingHeapObjectsResult() : EmptyResult;


internal sealed record TakeHeapSnapshotCommandParameters(bool? ReportProgress, bool? TreatGlobalObjectsAsRoots, bool? CaptureNumericValue, bool? ExposeInternals) : Parameters;

/// <summary>
/// </summary>
public sealed record TakeHeapSnapshotResult() : EmptyResult;


/// <summary>
/// </summary>
/// <param name="Chunk">
/// </param>
public sealed record AddHeapSnapshotChunkEventArgs(string Chunk) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// If heap objects tracking has been started then backend may send update for one or more fragments
/// </summary>
/// <param name="StatsUpdate">
/// An array of triplets. Each triplet describes a fragment. The first integer is the fragment
/// index, the second integer is a total count of objects for the fragment, the third integer is
/// a total size of the objects for the fragment.
/// </param>
public sealed record HeapStatsUpdateEventArgs(ImmutableArray<long> StatsUpdate) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// If heap objects tracking has been started then backend regularly sends a current value for last
/// seen object id and corresponding timestamp. If the were changes in the heap since last event
/// then one or more heapStatsUpdate events will be sent before a new lastSeenObjectId event.
/// </summary>
/// <param name="LastSeenObjectId">
/// </param>
/// <param name="Timestamp">
/// </param>
public sealed record LastSeenObjectIdEventArgs(long LastSeenObjectId, double Timestamp) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
/// <param name="Done">
/// </param>
/// <param name="Total">
/// </param>
/// <param name="Finished">
/// </param>
public sealed record ReportHeapSnapshotProgressEventArgs(long Done, long Total, bool? Finished = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
public sealed record ResetProfilesEventArgs() : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Heap snapshot object id.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<HeapSnapshotObjectId>))]
public record HeapSnapshotObjectId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Sampling Heap Profile node. Holds callsite information, allocation statistics and child nodes.
/// </summary>
/// <param name="CallFrame">
/// Function location.
/// </param>
/// <param name="SelfSize">
/// Allocations size in bytes for the node excluding children.
/// </param>
/// <param name="Id">
/// Node id. Ids are unique across all profiles collected between startSampling and stopSampling.
/// </param>
/// <param name="Children">
/// Child nodes.
/// </param>
public sealed record SamplingHeapProfileNode(Runtime.CallFrame CallFrame, double SelfSize, long Id, ImmutableArray<SamplingHeapProfileNode> Children)
{
}

/// <summary>
/// A single sample from a sampling profile.
/// </summary>
/// <param name="Size">
/// Allocation size in bytes attributed to the sample.
/// </param>
/// <param name="NodeId">
/// Id of the corresponding profile tree node.
/// </param>
/// <param name="Ordinal">
/// Time-ordered sample ordinal number. It is unique across all profiles retrieved
/// between startSampling and stopSampling.
/// </param>
public sealed record SamplingHeapProfileSample(double Size, long NodeId, double Ordinal)
{
}

/// <summary>
/// Sampling profile.
/// </summary>
/// <param name="Head">
/// </param>
/// <param name="Samples">
/// </param>
public sealed record SamplingHeapProfile(SamplingHeapProfileNode Head, ImmutableArray<SamplingHeapProfileSample> Samples)
{
}

[JsonSerializable(typeof(AddInspectedHeapObjectCommandParameters), TypeInfoPropertyName = "AddInspectedHeapObjectCommandParameters")]
[JsonSerializable(typeof(AddInspectedHeapObjectResult), TypeInfoPropertyName = "AddInspectedHeapObjectResult")]
[JsonSerializable(typeof(CollectGarbageCommandParameters), TypeInfoPropertyName = "CollectGarbageCommandParameters")]
[JsonSerializable(typeof(CollectGarbageResult), TypeInfoPropertyName = "CollectGarbageResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(GetHeapObjectIdCommandParameters), TypeInfoPropertyName = "GetHeapObjectIdCommandParameters")]
[JsonSerializable(typeof(GetHeapObjectIdResult), TypeInfoPropertyName = "GetHeapObjectIdResult")]
[JsonSerializable(typeof(GetObjectByHeapObjectIdCommandParameters), TypeInfoPropertyName = "GetObjectByHeapObjectIdCommandParameters")]
[JsonSerializable(typeof(GetObjectByHeapObjectIdResult), TypeInfoPropertyName = "GetObjectByHeapObjectIdResult")]
[JsonSerializable(typeof(GetSamplingProfileCommandParameters), TypeInfoPropertyName = "GetSamplingProfileCommandParameters")]
[JsonSerializable(typeof(GetSamplingProfileResult), TypeInfoPropertyName = "GetSamplingProfileResult")]
[JsonSerializable(typeof(StartSamplingCommandParameters), TypeInfoPropertyName = "StartSamplingCommandParameters")]
[JsonSerializable(typeof(StartSamplingResult), TypeInfoPropertyName = "StartSamplingResult")]
[JsonSerializable(typeof(StartTrackingHeapObjectsCommandParameters), TypeInfoPropertyName = "StartTrackingHeapObjectsCommandParameters")]
[JsonSerializable(typeof(StartTrackingHeapObjectsResult), TypeInfoPropertyName = "StartTrackingHeapObjectsResult")]
[JsonSerializable(typeof(StopSamplingCommandParameters), TypeInfoPropertyName = "StopSamplingCommandParameters")]
[JsonSerializable(typeof(StopSamplingResult), TypeInfoPropertyName = "StopSamplingResult")]
[JsonSerializable(typeof(StopTrackingHeapObjectsCommandParameters), TypeInfoPropertyName = "StopTrackingHeapObjectsCommandParameters")]
[JsonSerializable(typeof(StopTrackingHeapObjectsResult), TypeInfoPropertyName = "StopTrackingHeapObjectsResult")]
[JsonSerializable(typeof(TakeHeapSnapshotCommandParameters), TypeInfoPropertyName = "TakeHeapSnapshotCommandParameters")]
[JsonSerializable(typeof(TakeHeapSnapshotResult), TypeInfoPropertyName = "TakeHeapSnapshotResult")]
[JsonSerializable(typeof(CdpEventArgs<AddHeapSnapshotChunkEventArgs>), TypeInfoPropertyName = "AddHeapSnapshotChunkCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<HeapStatsUpdateEventArgs>), TypeInfoPropertyName = "HeapStatsUpdateCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<LastSeenObjectIdEventArgs>), TypeInfoPropertyName = "LastSeenObjectIdCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ReportHeapSnapshotProgressEventArgs>), TypeInfoPropertyName = "ReportHeapSnapshotProgressCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ResetProfilesEventArgs>), TypeInfoPropertyName = "ResetProfilesCdpEventArgs")]
[JsonSerializable(typeof(HeapSnapshotObjectId), TypeInfoPropertyName = "HeapProfilerHeapSnapshotObjectId")]
[JsonSerializable(typeof(SamplingHeapProfileNode), TypeInfoPropertyName = "HeapProfilerSamplingHeapProfileNode")]
[JsonSerializable(typeof(SamplingHeapProfileSample), TypeInfoPropertyName = "HeapProfilerSamplingHeapProfileSample")]
[JsonSerializable(typeof(SamplingHeapProfile), TypeInfoPropertyName = "HeapProfilerSamplingHeapProfile")]
[JsonSerializable(typeof(ImmutableArray<SamplingHeapProfileNode>), TypeInfoPropertyName = "ImmutableArrayHeapProfilerSamplingHeapProfileNode")]
[JsonSerializable(typeof(ImmutableArray<SamplingHeapProfileSample>), TypeInfoPropertyName = "ImmutableArrayHeapProfilerSamplingHeapProfileSample")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class HeapProfilerJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="HeapProfilerDomain"/>.
/// </summary>
public static class HeapProfilerDomainEvent
{
    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<AddHeapSnapshotChunkEventArgs>> AddHeapSnapshotChunk { get; } =
        EventDescriptor<CdpEventArgs<AddHeapSnapshotChunkEventArgs>>.Create(
            "goog:cdp.HeapProfiler.addHeapSnapshotChunk",
            HeapProfilerJsonSerializerContext.Default.AddHeapSnapshotChunkCdpEventArgs);

    /// <summary>
    /// If heap objects tracking has been started then backend may send update for one or more fragments
    /// </summary>
    public static EventDescriptor<CdpEventArgs<HeapStatsUpdateEventArgs>> HeapStatsUpdate { get; } =
        EventDescriptor<CdpEventArgs<HeapStatsUpdateEventArgs>>.Create(
            "goog:cdp.HeapProfiler.heapStatsUpdate",
            HeapProfilerJsonSerializerContext.Default.HeapStatsUpdateCdpEventArgs);

    /// <summary>
    /// If heap objects tracking has been started then backend regularly sends a current value for last
    /// seen object id and corresponding timestamp. If the were changes in the heap since last event
    /// then one or more heapStatsUpdate events will be sent before a new lastSeenObjectId event.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<LastSeenObjectIdEventArgs>> LastSeenObjectId { get; } =
        EventDescriptor<CdpEventArgs<LastSeenObjectIdEventArgs>>.Create(
            "goog:cdp.HeapProfiler.lastSeenObjectId",
            HeapProfilerJsonSerializerContext.Default.LastSeenObjectIdCdpEventArgs);

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ReportHeapSnapshotProgressEventArgs>> ReportHeapSnapshotProgress { get; } =
        EventDescriptor<CdpEventArgs<ReportHeapSnapshotProgressEventArgs>>.Create(
            "goog:cdp.HeapProfiler.reportHeapSnapshotProgress",
            HeapProfilerJsonSerializerContext.Default.ReportHeapSnapshotProgressCdpEventArgs);

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ResetProfilesEventArgs>> ResetProfiles { get; } =
        EventDescriptor<CdpEventArgs<ResetProfilesEventArgs>>.Create(
            "goog:cdp.HeapProfiler.resetProfiles",
            HeapProfilerJsonSerializerContext.Default.ResetProfilesCdpEventArgs);

}
