#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.LayerTree;

/// <summary>
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class LayerTreeDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static LayerTreeJsonSerializerContext JsonContext = LayerTreeJsonSerializerContext.Default;

    /// <summary>
    /// Provides the reasons why the given layer was composited.
    /// </summary>
    /// <param name="layerId">
    /// The id of the layer for which we want to get the reasons it was composited.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CompositingReasonsResult"/>.
    /// </returns>
    public async Task<CompositingReasonsResult> CompositingReasonsAsync(LayerId layerId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CompositingReasonsCommandParameters(LayerId: layerId);
        return await ExecuteCommandAsync(CompositingReasonsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CompositingReasonsCommandParameters, CompositingReasonsResult> CompositingReasonsCommand = new("LayerTree.compositingReasons", JsonContext.CompositingReasonsCommandParameters, JsonContext.CompositingReasonsResult);

    /// <summary>
    /// Disables compositing tree inspection.
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
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("LayerTree.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Enables compositing tree inspection.
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
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("LayerTree.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Returns the snapshot identifier.
    /// </summary>
    /// <param name="tiles">
    /// An array of tiles composing the snapshot.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="LoadSnapshotResult"/>.
    /// </returns>
    public async Task<LoadSnapshotResult> LoadSnapshotAsync(ImmutableArray<PictureTile> tiles, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new LoadSnapshotCommandParameters(Tiles: tiles);
        return await ExecuteCommandAsync(LoadSnapshotCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<LoadSnapshotCommandParameters, LoadSnapshotResult> LoadSnapshotCommand = new("LayerTree.loadSnapshot", JsonContext.LoadSnapshotCommandParameters, JsonContext.LoadSnapshotResult);

    /// <summary>
    /// Returns the layer snapshot identifier.
    /// </summary>
    /// <param name="layerId">
    /// The id of the layer.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="MakeSnapshotResult"/>.
    /// </returns>
    public async Task<MakeSnapshotResult> MakeSnapshotAsync(LayerId layerId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new MakeSnapshotCommandParameters(LayerId: layerId);
        return await ExecuteCommandAsync(MakeSnapshotCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<MakeSnapshotCommandParameters, MakeSnapshotResult> MakeSnapshotCommand = new("LayerTree.makeSnapshot", JsonContext.MakeSnapshotCommandParameters, JsonContext.MakeSnapshotResult);

    /// <summary>
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>MinRepeatCount</b> - The maximum number of times to replay the snapshot (1, if not specified).</description></item>
    /// <item><description><b>MinDuration</b> - The minimum duration (in seconds) to replay the snapshot.</description></item>
    /// <item><description><b>ClipRect</b> - The clip rectangle to apply when replaying the snapshot.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="snapshotId">
    /// The id of the layer snapshot.
    /// </param>
    /// <param name="minRepeatCount">
    /// The maximum number of times to replay the snapshot (1, if not specified).
    /// </param>
    /// <param name="minDuration">
    /// The minimum duration (in seconds) to replay the snapshot.
    /// </param>
    /// <param name="clipRect">
    /// The clip rectangle to apply when replaying the snapshot.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ProfileSnapshotResult"/>.
    /// </returns>
    public async Task<ProfileSnapshotResult> ProfileSnapshotAsync(SnapshotId snapshotId, long? minRepeatCount = default, double? minDuration = default, DOM.Rect? clipRect = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ProfileSnapshotCommandParameters(SnapshotId: snapshotId, MinRepeatCount: minRepeatCount, MinDuration: minDuration, ClipRect: clipRect);
        return await ExecuteCommandAsync(ProfileSnapshotCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ProfileSnapshotCommandParameters, ProfileSnapshotResult> ProfileSnapshotCommand = new("LayerTree.profileSnapshot", JsonContext.ProfileSnapshotCommandParameters, JsonContext.ProfileSnapshotResult);

    /// <summary>
    /// Releases layer snapshot captured by the back-end.
    /// </summary>
    /// <param name="snapshotId">
    /// The id of the layer snapshot.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ReleaseSnapshotResult"/>.
    /// </returns>
    public async Task<ReleaseSnapshotResult> ReleaseSnapshotAsync(SnapshotId snapshotId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ReleaseSnapshotCommandParameters(SnapshotId: snapshotId);
        return await ExecuteCommandAsync(ReleaseSnapshotCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ReleaseSnapshotCommandParameters, ReleaseSnapshotResult> ReleaseSnapshotCommand = new("LayerTree.releaseSnapshot", JsonContext.ReleaseSnapshotCommandParameters, JsonContext.ReleaseSnapshotResult);

    /// <summary>
    /// Replays the layer snapshot and returns the resulting bitmap.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>FromStep</b> - The first step to replay from (replay from the very start if not specified).</description></item>
    /// <item><description><b>ToStep</b> - The last step to replay to (replay till the end if not specified).</description></item>
    /// <item><description><b>Scale</b> - The scale to apply while replaying (defaults to 1).</description></item>
    /// </list>
    /// </remarks>
    /// <param name="snapshotId">
    /// The id of the layer snapshot.
    /// </param>
    /// <param name="fromStep">
    /// The first step to replay from (replay from the very start if not specified).
    /// </param>
    /// <param name="toStep">
    /// The last step to replay to (replay till the end if not specified).
    /// </param>
    /// <param name="scale">
    /// The scale to apply while replaying (defaults to 1).
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ReplaySnapshotResult"/>.
    /// </returns>
    public async Task<ReplaySnapshotResult> ReplaySnapshotAsync(SnapshotId snapshotId, long? fromStep = default, long? toStep = default, double? scale = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ReplaySnapshotCommandParameters(SnapshotId: snapshotId, FromStep: fromStep, ToStep: toStep, Scale: scale);
        return await ExecuteCommandAsync(ReplaySnapshotCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ReplaySnapshotCommandParameters, ReplaySnapshotResult> ReplaySnapshotCommand = new("LayerTree.replaySnapshot", JsonContext.ReplaySnapshotCommandParameters, JsonContext.ReplaySnapshotResult);

    /// <summary>
    /// Replays the layer snapshot and returns canvas log.
    /// </summary>
    /// <param name="snapshotId">
    /// The id of the layer snapshot.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SnapshotCommandLogResult"/>.
    /// </returns>
    public async Task<SnapshotCommandLogResult> SnapshotCommandLogAsync(SnapshotId snapshotId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SnapshotCommandLogCommandParameters(SnapshotId: snapshotId);
        return await ExecuteCommandAsync(SnapshotCommandLogCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SnapshotCommandLogCommandParameters, SnapshotCommandLogResult> SnapshotCommandLogCommand = new("LayerTree.snapshotCommandLog", JsonContext.SnapshotCommandLogCommandParameters, JsonContext.SnapshotCommandLogResult);

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="LayerPaintedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>LayerId</b> - The id of the painted layer.</description></item>
    /// <item><description><b>Clip</b> - Clip rectangle.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<LayerPaintedEventArgs> LayerPainted => CreateCdpEventSource(LayerTreeDomainEvent.LayerPainted);
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="LayerTreeDidChangeEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Layers</b> - Layer tree, absent if not in the compositing mode.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<LayerTreeDidChangeEventArgs> LayerTreeDidChange => CreateCdpEventSource(LayerTreeDomainEvent.LayerTreeDidChange);
}

internal sealed record CompositingReasonsCommandParameters(LayerId LayerId) : Parameters;

/// <summary>
/// </summary>
/// <param name="CompositingReasons">
/// A list of strings specifying reasons for the given layer to become composited.
/// </param>
/// <param name="CompositingReasonIds">
/// A list of strings specifying reason IDs for the given layer to become composited.
/// </param>
public sealed record CompositingReasonsResult(ImmutableArray<string> CompositingReasons, ImmutableArray<string> CompositingReasonIds) : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record LoadSnapshotCommandParameters(ImmutableArray<PictureTile> Tiles) : Parameters;

/// <summary>
/// </summary>
/// <param name="SnapshotId">
/// The id of the snapshot.
/// </param>
public sealed record LoadSnapshotResult(SnapshotId SnapshotId) : EmptyResult;


internal sealed record MakeSnapshotCommandParameters(LayerId LayerId) : Parameters;

/// <summary>
/// </summary>
/// <param name="SnapshotId">
/// The id of the layer snapshot.
/// </param>
public sealed record MakeSnapshotResult(SnapshotId SnapshotId) : EmptyResult;


internal sealed record ProfileSnapshotCommandParameters(SnapshotId SnapshotId, long? MinRepeatCount, double? MinDuration, DOM.Rect? ClipRect) : Parameters;

/// <summary>
/// </summary>
/// <param name="Timings">
/// The array of paint profiles, one per run.
/// </param>
public sealed record ProfileSnapshotResult(ImmutableArray<ImmutableArray<double>> Timings) : EmptyResult;


internal sealed record ReleaseSnapshotCommandParameters(SnapshotId SnapshotId) : Parameters;

/// <summary>
/// </summary>
public sealed record ReleaseSnapshotResult() : EmptyResult;


internal sealed record ReplaySnapshotCommandParameters(SnapshotId SnapshotId, long? FromStep, long? ToStep, double? Scale) : Parameters;

/// <summary>
/// </summary>
/// <param name="DataURL">
/// A data: URL for resulting image.
/// </param>
public sealed record ReplaySnapshotResult(string DataURL) : EmptyResult;


internal sealed record SnapshotCommandLogCommandParameters(SnapshotId SnapshotId) : Parameters;

/// <summary>
/// </summary>
/// <param name="CommandLog">
/// The array of canvas function calls.
/// </param>
public sealed record SnapshotCommandLogResult(ImmutableArray<global::System.Text.Json.JsonElement> CommandLog) : EmptyResult;


/// <summary>
/// </summary>
/// <param name="LayerId">
/// The id of the painted layer.
/// </param>
/// <param name="Clip">
/// Clip rectangle.
/// </param>
public sealed record LayerPaintedEventArgs(LayerId LayerId, DOM.Rect Clip) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
/// <param name="Layers">
/// Layer tree, absent if not in the compositing mode.
/// </param>
public sealed record LayerTreeDidChangeEventArgs(ImmutableArray<Layer>? Layers = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Unique Layer identifier.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<LayerId>))]
public record LayerId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Unique snapshot identifier.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<SnapshotId>))]
public record SnapshotId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Rectangle where scrolling happens on the main thread.
/// </summary>
/// <param name="Rect">
/// Rectangle itself.
/// </param>
/// <param name="Type">
/// Reason for rectangle to force scrolling on the main thread
/// </param>
public sealed record ScrollRect(DOM.Rect Rect, string Type)
{
}

/// <summary>
/// Sticky position constraints.
/// </summary>
/// <param name="StickyBoxRect">
/// Layout rectangle of the sticky element before being shifted
/// </param>
/// <param name="ContainingBlockRect">
/// Layout rectangle of the containing block of the sticky element
/// </param>
public sealed record StickyPositionConstraint(DOM.Rect StickyBoxRect, DOM.Rect ContainingBlockRect)
{
    /// <summary>
    /// The nearest sticky layer that shifts the sticky box
    /// </summary>
    public LayerId? NearestLayerShiftingStickyBox { get; init; }

    /// <summary>
    /// The nearest sticky layer that shifts the containing block
    /// </summary>
    public LayerId? NearestLayerShiftingContainingBlock { get; init; }
}

/// <summary>
/// Serialized fragment of layer picture along with its offset within the layer.
/// </summary>
/// <param name="X">
/// Offset from owning layer left boundary
/// </param>
/// <param name="Y">
/// Offset from owning layer top boundary
/// </param>
/// <param name="Picture">
/// Base64-encoded snapshot data. (Encoded as a base64 string when passed over JSON)
/// </param>
public sealed record PictureTile(double X, double Y, string Picture)
{
}

/// <summary>
/// Information about a compositing layer.
/// </summary>
/// <param name="LayerId">
/// The unique id for this layer.
/// </param>
/// <param name="OffsetX">
/// Offset from parent layer, X coordinate.
/// </param>
/// <param name="OffsetY">
/// Offset from parent layer, Y coordinate.
/// </param>
/// <param name="Width">
/// Layer width.
/// </param>
/// <param name="Height">
/// Layer height.
/// </param>
/// <param name="PaintCount">
/// Indicates how many time this layer has painted.
/// </param>
/// <param name="DrawsContent">
/// Indicates whether this layer hosts any content, rather than being used for
/// transform/scrolling purposes only.
/// </param>
public sealed record Layer(LayerId LayerId, double OffsetX, double OffsetY, double Width, double Height, long PaintCount, bool DrawsContent)
{
    /// <summary>
    /// The id of parent (not present for root).
    /// </summary>
    public LayerId? ParentLayerId { get; init; }

    /// <summary>
    /// The backend id for the node associated with this layer.
    /// </summary>
    public DOM.BackendNodeId? BackendNodeId { get; init; }

    /// <summary>
    /// Transformation matrix for layer, default is identity matrix
    /// </summary>
    public ImmutableArray<double>? Transform { get; init; }

    /// <summary>
    /// Transform anchor point X, absent if no transform specified
    /// </summary>
    public double? AnchorX { get; init; }

    /// <summary>
    /// Transform anchor point Y, absent if no transform specified
    /// </summary>
    public double? AnchorY { get; init; }

    /// <summary>
    /// Transform anchor point Z, absent if no transform specified
    /// </summary>
    public double? AnchorZ { get; init; }

    /// <summary>
    /// Set if layer is not visible.
    /// </summary>
    public bool? Invisible { get; init; }

    /// <summary>
    /// Rectangles scrolling on main thread only.
    /// </summary>
    public ImmutableArray<ScrollRect>? ScrollRects { get; init; }

    /// <summary>
    /// Sticky position constraint information
    /// </summary>
    public StickyPositionConstraint? StickyPositionConstraint { get; init; }
}

/// <summary>
/// Array of timings, one per paint step.
/// </summary>

[JsonSerializable(typeof(CompositingReasonsCommandParameters), TypeInfoPropertyName = "CompositingReasonsCommandParameters")]
[JsonSerializable(typeof(CompositingReasonsResult), TypeInfoPropertyName = "CompositingReasonsResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(LoadSnapshotCommandParameters), TypeInfoPropertyName = "LoadSnapshotCommandParameters")]
[JsonSerializable(typeof(LoadSnapshotResult), TypeInfoPropertyName = "LoadSnapshotResult")]
[JsonSerializable(typeof(MakeSnapshotCommandParameters), TypeInfoPropertyName = "MakeSnapshotCommandParameters")]
[JsonSerializable(typeof(MakeSnapshotResult), TypeInfoPropertyName = "MakeSnapshotResult")]
[JsonSerializable(typeof(ProfileSnapshotCommandParameters), TypeInfoPropertyName = "ProfileSnapshotCommandParameters")]
[JsonSerializable(typeof(ProfileSnapshotResult), TypeInfoPropertyName = "ProfileSnapshotResult")]
[JsonSerializable(typeof(ReleaseSnapshotCommandParameters), TypeInfoPropertyName = "ReleaseSnapshotCommandParameters")]
[JsonSerializable(typeof(ReleaseSnapshotResult), TypeInfoPropertyName = "ReleaseSnapshotResult")]
[JsonSerializable(typeof(ReplaySnapshotCommandParameters), TypeInfoPropertyName = "ReplaySnapshotCommandParameters")]
[JsonSerializable(typeof(ReplaySnapshotResult), TypeInfoPropertyName = "ReplaySnapshotResult")]
[JsonSerializable(typeof(SnapshotCommandLogCommandParameters), TypeInfoPropertyName = "SnapshotCommandLogCommandParameters")]
[JsonSerializable(typeof(SnapshotCommandLogResult), TypeInfoPropertyName = "SnapshotCommandLogResult")]
[JsonSerializable(typeof(CdpEventArgs<LayerPaintedEventArgs>), TypeInfoPropertyName = "LayerPaintedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<LayerTreeDidChangeEventArgs>), TypeInfoPropertyName = "LayerTreeDidChangeCdpEventArgs")]
[JsonSerializable(typeof(LayerId), TypeInfoPropertyName = "LayerTreeLayerId")]
[JsonSerializable(typeof(SnapshotId), TypeInfoPropertyName = "LayerTreeSnapshotId")]
[JsonSerializable(typeof(ScrollRect), TypeInfoPropertyName = "LayerTreeScrollRect")]
[JsonSerializable(typeof(StickyPositionConstraint), TypeInfoPropertyName = "LayerTreeStickyPositionConstraint")]
[JsonSerializable(typeof(PictureTile), TypeInfoPropertyName = "LayerTreePictureTile")]
[JsonSerializable(typeof(Layer), TypeInfoPropertyName = "LayerTreeLayer")]
[JsonSerializable(typeof(ImmutableArray<PictureTile>), TypeInfoPropertyName = "ImmutableArrayLayerTreePictureTile")]
[JsonSerializable(typeof(ImmutableArray<Layer>), TypeInfoPropertyName = "ImmutableArrayLayerTreeLayer")]
[JsonSerializable(typeof(ImmutableArray<ScrollRect>), TypeInfoPropertyName = "ImmutableArrayLayerTreeScrollRect")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class LayerTreeJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="LayerTreeDomain"/>.
/// </summary>
public static class LayerTreeDomainEvent
{
    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<LayerPaintedEventArgs>> LayerPainted { get; } =
        EventDescriptor<CdpEventArgs<LayerPaintedEventArgs>>.Create(
            "goog:cdp.LayerTree.layerPainted",
            LayerTreeJsonSerializerContext.Default.LayerPaintedCdpEventArgs);

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<LayerTreeDidChangeEventArgs>> LayerTreeDidChange { get; } =
        EventDescriptor<CdpEventArgs<LayerTreeDidChangeEventArgs>>.Create(
            "goog:cdp.LayerTree.layerTreeDidChange",
            LayerTreeJsonSerializerContext.Default.LayerTreeDidChangeCdpEventArgs);

}
