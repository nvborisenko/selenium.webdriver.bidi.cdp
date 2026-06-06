#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.PerformanceTimeline;

/// <summary>
/// Reporting of performance timeline events, as specified in
/// https://w3c.github.io/performance-timeline/#dom-performanceobserver.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class PerformanceTimelineDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static PerformanceTimelineJsonSerializerContext JsonContext = PerformanceTimelineJsonSerializerContext.Default;

    /// <summary>
    /// Previously buffered events would be reported before method returns.
    /// See also: timelineEventAdded
    /// </summary>
    /// <param name="eventTypes">
    /// The types of event to report, as specified in
    /// https://w3c.github.io/performance-timeline/#dom-performanceentry-entrytype
    /// The specified filter overrides any previous filters, passing empty
    /// filter disables recording.
    /// Note that not all types exposed to the web platform are currently supported.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="EnableCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="EnableResult"/>.
    /// </returns>
    public async Task<EnableResult> EnableAsync(IEnumerable<string> eventTypes, EnableCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters(EventTypes: eventTypes);
        return await ExecuteCommandAsync(EnableCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("PerformanceTimeline.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Sent when a performance timeline event is added. See reportPerformanceTimeline method.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="TimelineEventAddedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Event</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<TimelineEventAddedEventArgs> TimelineEventAdded => CreateCdpEventSource(PerformanceTimelineDomainEvent.TimelineEventAdded);
}

internal sealed record EnableCommandParameters(IEnumerable<string> EventTypes) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PerformanceTimelineDomain.EnableAsync"/>.
/// </summary>
public sealed record EnableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


/// <summary>
/// Sent when a performance timeline event is added. See reportPerformanceTimeline method.
/// </summary>
/// <param name="Event">
/// </param>
public sealed record TimelineEventAddedEventArgs(TimelineEvent Event) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// See https://github.com/WICG/LargestContentfulPaint and largest_contentful_paint.idl
/// </summary>
/// <param name="RenderTime">
/// </param>
/// <param name="LoadTime">
/// </param>
/// <param name="Size">
/// The number of pixels being painted.
/// </param>
public sealed record LargestContentfulPaint(Network.TimeSinceEpoch RenderTime, Network.TimeSinceEpoch LoadTime, double Size)
{
    /// <summary>
    /// The id attribute of the element, if available.
    /// </summary>
    public string? ElementId { get; init; }

    /// <summary>
    /// The URL of the image (may be trimmed).
    /// </summary>
    public string? Url { get; init; }

    /// <summary>
    /// </summary>
    public DOM.BackendNodeId? NodeId { get; init; }
}

/// <summary>
/// </summary>
/// <param name="PreviousRect">
/// </param>
/// <param name="CurrentRect">
/// </param>
public sealed record LayoutShiftAttribution(DOM.Rect PreviousRect, DOM.Rect CurrentRect)
{
    /// <summary>
    /// </summary>
    public DOM.BackendNodeId? NodeId { get; init; }
}

/// <summary>
/// See https://wicg.github.io/layout-instability/#sec-layout-shift and layout_shift.idl
/// </summary>
/// <param name="Value">
/// Score increment produced by this event.
/// </param>
/// <param name="HadRecentInput">
/// </param>
/// <param name="LastInputTime">
/// </param>
/// <param name="Sources">
/// </param>
public sealed record LayoutShift(double Value, bool HadRecentInput, Network.TimeSinceEpoch LastInputTime, IReadOnlyList<LayoutShiftAttribution> Sources)
{
}

/// <summary>
/// </summary>
/// <param name="FrameId">
/// Identifies the frame that this event is related to. Empty for non-frame targets.
/// </param>
/// <param name="Type">
/// The event type, as specified in https://w3c.github.io/performance-timeline/#dom-performanceentry-entrytype
/// This determines which of the optional "details" fields is present.
/// </param>
/// <param name="Name">
/// Name may be empty depending on the type.
/// </param>
/// <param name="Time">
/// Time in seconds since Epoch, monotonically increasing within document lifetime.
/// </param>
public sealed record TimelineEvent(Page.FrameId FrameId, string Type, string Name, Network.TimeSinceEpoch Time)
{
    /// <summary>
    /// Event duration, if applicable.
    /// </summary>
    public double? Duration { get; init; }

    /// <summary>
    /// </summary>
    public LargestContentfulPaint? LcpDetails { get; init; }

    /// <summary>
    /// </summary>
    public LayoutShift? LayoutShiftDetails { get; init; }
}

[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(CdpEventArgs<TimelineEventAddedEventArgs>), TypeInfoPropertyName = "TimelineEventAddedCdpEventArgs")]
[JsonSerializable(typeof(LargestContentfulPaint), TypeInfoPropertyName = "PerformanceTimelineLargestContentfulPaint")]
[JsonSerializable(typeof(LayoutShiftAttribution), TypeInfoPropertyName = "PerformanceTimelineLayoutShiftAttribution")]
[JsonSerializable(typeof(LayoutShift), TypeInfoPropertyName = "PerformanceTimelineLayoutShift")]
[JsonSerializable(typeof(TimelineEvent), TypeInfoPropertyName = "PerformanceTimelineTimelineEvent")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<LayoutShiftAttribution>), TypeInfoPropertyName = "IReadOnlyListPerformanceTimelineLayoutShiftAttribution")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class PerformanceTimelineJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="PerformanceTimelineDomain"/>.
/// </summary>
public static class PerformanceTimelineDomainEvent
{
    /// <summary>
    /// Sent when a performance timeline event is added. See reportPerformanceTimeline method.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<TimelineEventAddedEventArgs>> TimelineEventAdded { get; } =
        EventDescriptor<CdpEventArgs<TimelineEventAddedEventArgs>>.Create(
            "goog:cdp.PerformanceTimeline.timelineEventAdded",
            PerformanceTimelineJsonSerializerContext.Default.TimelineEventAddedCdpEventArgs);

}
