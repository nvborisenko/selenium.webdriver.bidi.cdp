#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Tracing;

/// <summary>
/// </summary>
public sealed class TracingDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static TracingJsonSerializerContext JsonContext = TracingJsonSerializerContext.Default;

    /// <summary>
    /// Stop trace events collection.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="EndResult"/>.
    /// </returns>
    public async Task<EndResult> EndAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EndCommandParameters();
        return await ExecuteCommandAsync(EndCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EndCommandParameters, EndResult> EndCommand = new("Tracing.end", JsonContext.EndCommandParameters, JsonContext.EndResult);

    /// <summary>
    /// Gets supported tracing categories.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetCategoriesResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetCategoriesResult> GetCategoriesAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetCategoriesCommandParameters();
        return await ExecuteCommandAsync(GetCategoriesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetCategoriesCommandParameters, GetCategoriesResult> GetCategoriesCommand = new("Tracing.getCategories", JsonContext.GetCategoriesCommandParameters, JsonContext.GetCategoriesResult);

    /// <summary>
    /// Return a descriptor for all available tracing categories.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetTrackEventDescriptorResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<GetTrackEventDescriptorResult> GetTrackEventDescriptorAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetTrackEventDescriptorCommandParameters();
        return await ExecuteCommandAsync(GetTrackEventDescriptorCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetTrackEventDescriptorCommandParameters, GetTrackEventDescriptorResult> GetTrackEventDescriptorCommand = new("Tracing.getTrackEventDescriptor", JsonContext.GetTrackEventDescriptorCommandParameters, JsonContext.GetTrackEventDescriptorResult);

    /// <summary>
    /// Record a clock sync marker in the trace.
    /// </summary>
    /// <param name="syncId">
    /// The ID of this clock sync marker
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RecordClockSyncMarkerResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<RecordClockSyncMarkerResult> RecordClockSyncMarkerAsync(string syncId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RecordClockSyncMarkerCommandParameters(SyncId: syncId);
        return await ExecuteCommandAsync(RecordClockSyncMarkerCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RecordClockSyncMarkerCommandParameters, RecordClockSyncMarkerResult> RecordClockSyncMarkerCommand = new("Tracing.recordClockSyncMarker", JsonContext.RecordClockSyncMarkerCommandParameters, JsonContext.RecordClockSyncMarkerResult);

    /// <summary>
    /// Request a global memory dump.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>Deterministic</b> - Enables more deterministic results by forcing garbage collection</description></item>
    /// <item><description><b>LevelOfDetail</b> - Specifies level of details in memory dump. Defaults to "detailed".</description></item>
    /// </list>
    /// </remarks>
    /// <param name="deterministic">
    /// Enables more deterministic results by forcing garbage collection
    /// </param>
    /// <param name="levelOfDetail">
    /// Specifies level of details in memory dump. Defaults to "detailed".
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RequestMemoryDumpResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public async Task<RequestMemoryDumpResult> RequestMemoryDumpAsync(bool? deterministic = default, MemoryDumpLevelOfDetail? levelOfDetail = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RequestMemoryDumpCommandParameters(Deterministic: deterministic, LevelOfDetail: levelOfDetail);
        return await ExecuteCommandAsync(RequestMemoryDumpCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RequestMemoryDumpCommandParameters, RequestMemoryDumpResult> RequestMemoryDumpCommand = new("Tracing.requestMemoryDump", JsonContext.RequestMemoryDumpCommandParameters, JsonContext.RequestMemoryDumpResult);

    /// <summary>
    /// Start trace events collection.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>Categories</b> - Category/tag filter</description></item>
    /// <item><description><b>Options</b> - Tracing options</description></item>
    /// <item><description><b>BufferUsageReportingInterval</b> - If set, the agent will issue bufferUsage events at this interval, specified in milliseconds</description></item>
    /// <item><description><b>TransferMode</b> - Whether to report trace events as series of dataCollected events or to save trace to a stream (defaults to <b>ReportEvents</b>).</description></item>
    /// <item><description><b>StreamFormat</b> - Trace data format to use. This only applies when using <b>ReturnAsStream</b> transfer mode (defaults to <b>json</b>).</description></item>
    /// <item><description><b>StreamCompression</b> - Compression format to use. This only applies when using <b>ReturnAsStream</b> transfer mode (defaults to <b>none</b>)</description></item>
    /// <item><description><b>TraceConfig</b></description></item>
    /// <item><description><b>PerfettoConfig</b> - Base64-encoded serialized perfetto.protos.TraceConfig protobuf message When specified, the parameters <b>categories</b>, <b>options</b>, <b>traceConfig</b> are ignored. (Encoded as a base64 string when passed over JSON)</description></item>
    /// <item><description><b>TracingBackend</b> - Backend type (defaults to <b>auto</b>)</description></item>
    /// <item><description><b>ScreenshotMaxSize</b> - Maximum width and height (in pixels) of each captured screenshot. Only used when the <b>disabled-by-default-devtools.screenshot</b> category is enabled. Defaults to 500. The combined memory footprint of screenshots (<b>screenshotMaxSize</b> * <b>screenshotMaxSize</b> * 4 * <b>screenshotMaxCount</b>) is clamped to the existing per-session budget.</description></item>
    /// <item><description><b>ScreenshotMaxCount</b> - Maximum number of screenshots captured during a single tracing session. Only used when the <b>disabled-by-default-devtools.screenshot</b> category is enabled. Defaults to 450. Clamped together with <b>screenshotMaxSize</b> to stay within the per-session screenshot memory budget.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="categories">
    /// Category/tag filter
    /// </param>
    /// <param name="options">
    /// Tracing options
    /// </param>
    /// <param name="bufferUsageReportingInterval">
    /// If set, the agent will issue bufferUsage events at this interval, specified in milliseconds
    /// </param>
    /// <param name="transferMode">
    /// Whether to report trace events as series of dataCollected events or to save trace to a
    /// stream (defaults to <b>ReportEvents</b>).
    /// </param>
    /// <param name="streamFormat">
    /// Trace data format to use. This only applies when using <b>ReturnAsStream</b>
    /// transfer mode (defaults to <b>json</b>).
    /// </param>
    /// <param name="streamCompression">
    /// Compression format to use. This only applies when using <b>ReturnAsStream</b>
    /// transfer mode (defaults to <b>none</b>)
    /// </param>
    /// <param name="traceConfig">
    /// </param>
    /// <param name="perfettoConfig">
    /// Base64-encoded serialized perfetto.protos.TraceConfig protobuf message
    /// When specified, the parameters <b>categories</b>, <b>options</b>, <b>traceConfig</b>
    /// are ignored. (Encoded as a base64 string when passed over JSON)
    /// </param>
    /// <param name="tracingBackend">
    /// Backend type (defaults to <b>auto</b>)
    /// </param>
    /// <param name="screenshotMaxSize">
    /// Maximum width and height (in pixels) of each captured screenshot.
    /// Only used when the <b>disabled-by-default-devtools.screenshot</b> category is
    /// enabled. Defaults to 500. The combined memory footprint of screenshots
    /// (<b>screenshotMaxSize</b> * <b>screenshotMaxSize</b> * 4 * <b>screenshotMaxCount</b>)
    /// is clamped to the existing per-session budget.
    /// </param>
    /// <param name="screenshotMaxCount">
    /// Maximum number of screenshots captured during a single tracing session.
    /// Only used when the <b>disabled-by-default-devtools.screenshot</b> category is
    /// enabled. Defaults to 450. Clamped together with <b>screenshotMaxSize</b> to
    /// stay within the per-session screenshot memory budget.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StartResult"/>.
    /// </returns>
    public async Task<StartResult> StartAsync(string? categories = default, string? options = default, double? bufferUsageReportingInterval = default, string? transferMode = default, StreamFormat? streamFormat = default, StreamCompression? streamCompression = default, TraceConfig? traceConfig = default, string? perfettoConfig = default, TracingBackend? tracingBackend = default, long? screenshotMaxSize = default, long? screenshotMaxCount = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new StartCommandParameters(Categories: categories, Options: options, BufferUsageReportingInterval: bufferUsageReportingInterval, TransferMode: transferMode, StreamFormat: streamFormat, StreamCompression: streamCompression, TraceConfig: traceConfig, PerfettoConfig: perfettoConfig, TracingBackend: tracingBackend, ScreenshotMaxSize: screenshotMaxSize, ScreenshotMaxCount: screenshotMaxCount);
        return await ExecuteCommandAsync(StartCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StartCommandParameters, StartResult> StartCommand = new("Tracing.start", JsonContext.StartCommandParameters, JsonContext.StartResult);

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="BufferUsageEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>PercentFull</b> - A number in range [0..1] that indicates the used size of event buffer as a fraction of its total size.</description></item>
    /// <item><description><b>EventCount</b> - An approximate number of events in the trace log.</description></item>
    /// <item><description><b>Value</b> - A number in range [0..1] that indicates the used size of event buffer as a fraction of its total size.</description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<BufferUsageEventArgs> BufferUsage => CreateCdpEventSource(TracingDomainEvent.BufferUsage);
    /// <summary>
    /// Contains a bucket of collected trace events. When tracing is stopped collected events will be
    /// sent as a sequence of dataCollected events followed by tracingComplete event.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DataCollectedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Value</b></description></item>
    /// </list>
    /// </remarks>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    public IEventSource<DataCollectedEventArgs> DataCollected => CreateCdpEventSource(TracingDomainEvent.DataCollected);
    /// <summary>
    /// Signals that tracing is stopped and there is no trace buffers pending flush, all data were
    /// delivered via dataCollected events.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="TracingCompleteEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>DataLossOccurred</b> - Indicates whether some trace data is known to have been lost, e.g. because the trace ring buffer wrapped around.</description></item>
    /// <item><description><b>Stream</b> - A handle of the stream that holds resulting trace data.</description></item>
    /// <item><description><b>TraceFormat</b> - Trace data format of returned stream.</description></item>
    /// <item><description><b>StreamCompression</b> - Compression format of returned stream.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<TracingCompleteEventArgs> TracingComplete => CreateCdpEventSource(TracingDomainEvent.TracingComplete);
}

internal sealed record EndCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record EndResult() : EmptyResult;


internal sealed record GetCategoriesCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="Categories">
/// A list of supported tracing categories.
/// </param>
public sealed record GetCategoriesResult(ImmutableArray<string> Categories) : EmptyResult;


internal sealed record GetTrackEventDescriptorCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="Descriptor">
/// Base64-encoded serialized perfetto.protos.TrackEventDescriptor protobuf message. (Encoded as a base64 string when passed over JSON)
/// </param>
public sealed record GetTrackEventDescriptorResult(string Descriptor) : EmptyResult;


internal sealed record RecordClockSyncMarkerCommandParameters(string SyncId) : Parameters;

/// <summary>
/// </summary>
public sealed record RecordClockSyncMarkerResult() : EmptyResult;


internal sealed record RequestMemoryDumpCommandParameters(bool? Deterministic, MemoryDumpLevelOfDetail? LevelOfDetail) : Parameters;

/// <summary>
/// </summary>
/// <param name="DumpGuid">
/// GUID of the resulting global memory dump.
/// </param>
/// <param name="Success">
/// True iff the global memory dump succeeded.
/// </param>
public sealed record RequestMemoryDumpResult(string DumpGuid, bool Success) : EmptyResult;


internal sealed record StartCommandParameters(string? Categories, string? Options, double? BufferUsageReportingInterval, string? TransferMode, StreamFormat? StreamFormat, StreamCompression? StreamCompression, TraceConfig? TraceConfig, string? PerfettoConfig, TracingBackend? TracingBackend, long? ScreenshotMaxSize, long? ScreenshotMaxCount) : Parameters;

/// <summary>
/// </summary>
public sealed record StartResult() : EmptyResult;


/// <summary>
/// </summary>
/// <param name="PercentFull">
/// A number in range [0..1] that indicates the used size of event buffer as a fraction of its
/// total size.
/// </param>
/// <param name="EventCount">
/// An approximate number of events in the trace log.
/// </param>
/// <param name="Value">
/// A number in range [0..1] that indicates the used size of event buffer as a fraction of its
/// total size.
/// </param>
public sealed record BufferUsageEventArgs(double? PercentFull = null, double? EventCount = null, double? Value = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Contains a bucket of collected trace events. When tracing is stopped collected events will be
/// sent as a sequence of dataCollected events followed by tracingComplete event.
/// </summary>
/// <param name="Value">
/// </param>
public sealed record DataCollectedEventArgs(ImmutableArray<global::System.Text.Json.JsonElement> Value) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Signals that tracing is stopped and there is no trace buffers pending flush, all data were
/// delivered via dataCollected events.
/// </summary>
/// <param name="DataLossOccurred">
/// Indicates whether some trace data is known to have been lost, e.g. because the trace ring
/// buffer wrapped around.
/// </param>
/// <param name="Stream">
/// A handle of the stream that holds resulting trace data.
/// </param>
/// <param name="TraceFormat">
/// Trace data format of returned stream.
/// </param>
/// <param name="StreamCompression">
/// Compression format of returned stream.
/// </param>
public sealed record TracingCompleteEventArgs(bool DataLossOccurred, IO.StreamHandle? Stream = null, StreamFormat? TraceFormat = null, StreamCompression? StreamCompression = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Configuration for memory dump. Used only when "memory-infra" category is enabled.
/// </summary>

/// <summary>
/// </summary>
public sealed record TraceConfig()
{
    /// <summary>
    /// Controls how the trace buffer stores data. The default is <b>recordUntilFull</b>.
    /// </summary>
    public string? RecordMode { get; init; }

    /// <summary>
    /// Size of the trace buffer in kilobytes. If not specified or zero is passed, a default value
    /// of 200 MB would be used.
    /// </summary>
    public double? TraceBufferSizeInKb { get; init; }

    /// <summary>
    /// Turns on JavaScript stack sampling.
    /// </summary>
    public bool? EnableSampling { get; init; }

    /// <summary>
    /// Turns on system tracing.
    /// </summary>
    public bool? EnableSystrace { get; init; }

    /// <summary>
    /// Turns on argument filter.
    /// </summary>
    public bool? EnableArgumentFilter { get; init; }

    /// <summary>
    /// Included category filters.
    /// </summary>
    public ImmutableArray<string>? IncludedCategories { get; init; }

    /// <summary>
    /// Excluded category filters.
    /// </summary>
    public ImmutableArray<string>? ExcludedCategories { get; init; }

    /// <summary>
    /// Configuration to synthesize the delays in tracing.
    /// </summary>
    public ImmutableArray<string>? SyntheticDelays { get; init; }

    /// <summary>
    /// Configuration for memory dump triggers. Used only when "memory-infra" category is enabled.
    /// </summary>
    public global::System.Collections.Generic.IReadOnlyDictionary<string, string>? MemoryDumpConfig { get; init; }
}

/// <summary>
/// Data format of a trace. Can be either the legacy JSON format or the
/// protocol buffer format. Note that the JSON format will be deprecated soon.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<StreamFormat>))]
public enum StreamFormat
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("json")]
    Json,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("proto")]
    Proto,
}

/// <summary>
/// Compression type to use for traces returned via streams.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<StreamCompression>))]
public enum StreamCompression
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("none")]
    None,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("gzip")]
    Gzip,
}

/// <summary>
/// Details exposed when memory request explicitly declared.
/// Keep consistent with memory_dump_request_args.h and
/// memory_instrumentation.mojom
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<MemoryDumpLevelOfDetail>))]
public enum MemoryDumpLevelOfDetail
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("background")]
    Background,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("light")]
    Light,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("detailed")]
    Detailed,
}

/// <summary>
/// Backend type to use for tracing. <b>chrome</b> uses the Chrome-integrated
/// tracing service and is supported on all platforms. <b>system</b> is only
/// supported on Chrome OS and uses the Perfetto system tracing service.
/// <b>auto</b> chooses <b>system</b> when the perfettoConfig provided to Tracing.start
/// specifies at least one non-Chrome data source; otherwise uses <b>chrome</b>.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<TracingBackend>))]
public enum TracingBackend
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("auto")]
    Auto,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("chrome")]
    Chrome,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("system")]
    System,
}

[JsonSerializable(typeof(EndCommandParameters), TypeInfoPropertyName = "EndCommandParameters")]
[JsonSerializable(typeof(EndResult), TypeInfoPropertyName = "EndResult")]
[JsonSerializable(typeof(GetCategoriesCommandParameters), TypeInfoPropertyName = "GetCategoriesCommandParameters")]
[JsonSerializable(typeof(GetCategoriesResult), TypeInfoPropertyName = "GetCategoriesResult")]
[JsonSerializable(typeof(GetTrackEventDescriptorCommandParameters), TypeInfoPropertyName = "GetTrackEventDescriptorCommandParameters")]
[JsonSerializable(typeof(GetTrackEventDescriptorResult), TypeInfoPropertyName = "GetTrackEventDescriptorResult")]
[JsonSerializable(typeof(RecordClockSyncMarkerCommandParameters), TypeInfoPropertyName = "RecordClockSyncMarkerCommandParameters")]
[JsonSerializable(typeof(RecordClockSyncMarkerResult), TypeInfoPropertyName = "RecordClockSyncMarkerResult")]
[JsonSerializable(typeof(RequestMemoryDumpCommandParameters), TypeInfoPropertyName = "RequestMemoryDumpCommandParameters")]
[JsonSerializable(typeof(RequestMemoryDumpResult), TypeInfoPropertyName = "RequestMemoryDumpResult")]
[JsonSerializable(typeof(StartCommandParameters), TypeInfoPropertyName = "StartCommandParameters")]
[JsonSerializable(typeof(StartResult), TypeInfoPropertyName = "StartResult")]
[JsonSerializable(typeof(CdpEventArgs<BufferUsageEventArgs>), TypeInfoPropertyName = "BufferUsageCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DataCollectedEventArgs>), TypeInfoPropertyName = "DataCollectedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<TracingCompleteEventArgs>), TypeInfoPropertyName = "TracingCompleteCdpEventArgs")]
[JsonSerializable(typeof(TraceConfig), TypeInfoPropertyName = "TracingTraceConfig")]
[JsonSerializable(typeof(StreamFormat), TypeInfoPropertyName = "TracingStreamFormat")]
[JsonSerializable(typeof(StreamCompression), TypeInfoPropertyName = "TracingStreamCompression")]
[JsonSerializable(typeof(MemoryDumpLevelOfDetail), TypeInfoPropertyName = "TracingMemoryDumpLevelOfDetail")]
[JsonSerializable(typeof(TracingBackend), TypeInfoPropertyName = "TracingTracingBackend")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class TracingJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="TracingDomain"/>.
/// </summary>
public static class TracingDomainEvent
{
    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<BufferUsageEventArgs>> BufferUsage { get; } =
        EventDescriptor<CdpEventArgs<BufferUsageEventArgs>>.Create(
            "goog:cdp.Tracing.bufferUsage",
            TracingJsonSerializerContext.Default.BufferUsageCdpEventArgs);

    /// <summary>
    /// Contains a bucket of collected trace events. When tracing is stopped collected events will be
    /// sent as a sequence of dataCollected events followed by tracingComplete event.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DataCollectedEventArgs>> DataCollected { get; } =
        EventDescriptor<CdpEventArgs<DataCollectedEventArgs>>.Create(
            "goog:cdp.Tracing.dataCollected",
            TracingJsonSerializerContext.Default.DataCollectedCdpEventArgs);

    /// <summary>
    /// Signals that tracing is stopped and there is no trace buffers pending flush, all data were
    /// delivered via dataCollected events.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<TracingCompleteEventArgs>> TracingComplete { get; } =
        EventDescriptor<CdpEventArgs<TracingCompleteEventArgs>>.Create(
            "goog:cdp.Tracing.tracingComplete",
            TracingJsonSerializerContext.Default.TracingCompleteCdpEventArgs);

}
