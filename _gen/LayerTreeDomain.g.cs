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
    /// <param name="options">
    /// Optional parameters. See <see cref="CompositingReasonsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CompositingReasonsResult"/>.
    /// </returns>
    public async Task<CompositingReasonsResult> CompositingReasonsAsync(LayerId layerId, CompositingReasonsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new CompositingReasonsCommandParameters(LayerId: layerId);
        return await ExecuteCommandAsync(CompositingReasonsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<CompositingReasonsCommandParameters, CompositingReasonsResult> CompositingReasonsCommand = new("LayerTree.compositingReasons", JsonContext.CompositingReasonsCommandParameters, JsonContext.CompositingReasonsResult);

    /// <summary>
    /// Disables compositing tree inspection.
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
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("LayerTree.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Enables compositing tree inspection.
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
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("LayerTree.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Returns the snapshot identifier.
    /// </summary>
    /// <param name="tiles">
    /// An array of tiles composing the snapshot.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="LoadSnapshotCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="LoadSnapshotResult"/>.
    /// </returns>
    public async Task<LoadSnapshotResult> LoadSnapshotAsync(ImmutableArray<PictureTile> tiles, LoadSnapshotCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new LoadSnapshotCommandParameters(Tiles: tiles);
        return await ExecuteCommandAsync(LoadSnapshotCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<LoadSnapshotCommandParameters, LoadSnapshotResult> LoadSnapshotCommand = new("LayerTree.loadSnapshot", JsonContext.LoadSnapshotCommandParameters, JsonContext.LoadSnapshotResult);

    /// <summary>
    /// Returns the layer snapshot identifier.
    /// </summary>
    /// <param name="layerId">
    /// The id of the layer.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="MakeSnapshotCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="MakeSnapshotResult"/>.
    /// </returns>
    public async Task<MakeSnapshotResult> MakeSnapshotAsync(LayerId layerId, MakeSnapshotCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new MakeSnapshotCommandParameters(LayerId: layerId);
        return await ExecuteCommandAsync(MakeSnapshotCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<MakeSnapshotCommandParameters, MakeSnapshotResult> MakeSnapshotCommand = new("LayerTree.makeSnapshot", JsonContext.MakeSnapshotCommandParameters, JsonContext.MakeSnapshotResult);

    /// <summary>
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>MinRepeatCount</b> - The maximum number of times to replay the snapshot (1, if not specified).</description></item>
    /// <item><description><b>MinDuration</b> - The minimum duration (in seconds) to replay the snapshot.</description></item>
    /// <item><description><b>ClipRect</b> - The clip rectangle to apply when replaying the snapshot.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="snapshotId">
    /// The id of the layer snapshot.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ProfileSnapshotCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ProfileSnapshotResult"/>.
    /// </returns>
    public async Task<ProfileSnapshotResult> ProfileSnapshotAsync(SnapshotId snapshotId, ProfileSnapshotCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ProfileSnapshotCommandParameters(SnapshotId: snapshotId, MinRepeatCount: options?.MinRepeatCount, MinDuration: options?.MinDuration, ClipRect: options?.ClipRect);
        return await ExecuteCommandAsync(ProfileSnapshotCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ProfileSnapshotCommandParameters, ProfileSnapshotResult> ProfileSnapshotCommand = new("LayerTree.profileSnapshot", JsonContext.ProfileSnapshotCommandParameters, JsonContext.ProfileSnapshotResult);

    /// <summary>
    /// Releases layer snapshot captured by the back-end.
    /// </summary>
    /// <param name="snapshotId">
    /// The id of the layer snapshot.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ReleaseSnapshotCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ReleaseSnapshotResult"/>.
    /// </returns>
    public async Task<ReleaseSnapshotResult> ReleaseSnapshotAsync(SnapshotId snapshotId, ReleaseSnapshotCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ReleaseSnapshotCommandParameters(SnapshotId: snapshotId);
        return await ExecuteCommandAsync(ReleaseSnapshotCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ReleaseSnapshotCommandParameters, ReleaseSnapshotResult> ReleaseSnapshotCommand = new("LayerTree.releaseSnapshot", JsonContext.ReleaseSnapshotCommandParameters, JsonContext.ReleaseSnapshotResult);

    /// <summary>
    /// Replays the layer snapshot and returns the resulting bitmap.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>FromStep</b> - The first step to replay from (replay from the very start if not specified).</description></item>
    /// <item><description><b>ToStep</b> - The last step to replay to (replay till the end if not specified).</description></item>
    /// <item><description><b>Scale</b> - The scale to apply while replaying (defaults to 1).</description></item>
    /// </list>
    /// </remarks>
    /// <param name="snapshotId">
    /// The id of the layer snapshot.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ReplaySnapshotCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ReplaySnapshotResult"/>.
    /// </returns>
    public async Task<ReplaySnapshotResult> ReplaySnapshotAsync(SnapshotId snapshotId, ReplaySnapshotCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ReplaySnapshotCommandParameters(SnapshotId: snapshotId, FromStep: options?.FromStep, ToStep: options?.ToStep, Scale: options?.Scale);
        return await ExecuteCommandAsync(ReplaySnapshotCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ReplaySnapshotCommandParameters, ReplaySnapshotResult> ReplaySnapshotCommand = new("LayerTree.replaySnapshot", JsonContext.ReplaySnapshotCommandParameters, JsonContext.ReplaySnapshotResult);

    /// <summary>
    /// Replays the layer snapshot and returns canvas log.
    /// </summary>
    /// <param name="snapshotId">
    /// The id of the layer snapshot.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SnapshotCommandLogCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SnapshotCommandLogResult"/>.
    /// </returns>
    public async Task<SnapshotCommandLogResult> SnapshotCommandLogAsync(SnapshotId snapshotId, SnapshotCommandLogCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SnapshotCommandLogCommandParameters(SnapshotId: snapshotId);
        return await ExecuteCommandAsync(SnapshotCommandLogCommand, @params, options, cancellationToken).ConfigureAwait(false);
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
/// Optional parameters for <see cref="LayerTreeDomain.CompositingReasonsAsync"/>.
/// </summary>
public sealed record CompositingReasonsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="CompositingReasons">
/// A list of strings specifying reasons for the given layer to become composited.
/// </param>
/// <param name="CompositingReasonIds">
/// A list of strings specifying reason IDs for the given layer to become composited.
/// </param>
public sealed record CompositingReasonsResult(IReadOnlyList<string> CompositingReasons, IReadOnlyList<string> CompositingReasonIds) : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="LayerTreeDomain.DisableAsync"/>.
/// </summary>
public sealed record DisableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="LayerTreeDomain.EnableAsync"/>.
/// </summary>
public sealed record EnableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record LoadSnapshotCommandParameters(ImmutableArray<PictureTile> Tiles) : Parameters;

/// <summary>
/// Optional parameters for <see cref="LayerTreeDomain.LoadSnapshotAsync"/>.
/// </summary>
public sealed record LoadSnapshotCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="SnapshotId">
/// The id of the snapshot.
/// </param>
public sealed record LoadSnapshotResult(SnapshotId SnapshotId) : EmptyResult;


internal sealed record MakeSnapshotCommandParameters(LayerId LayerId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="LayerTreeDomain.MakeSnapshotAsync"/>.
/// </summary>
public sealed record MakeSnapshotCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="SnapshotId">
/// The id of the layer snapshot.
/// </param>
public sealed record MakeSnapshotResult(SnapshotId SnapshotId) : EmptyResult;


internal sealed record ProfileSnapshotCommandParameters(SnapshotId SnapshotId, long? MinRepeatCount, double? MinDuration, DOM.Rect? ClipRect) : Parameters;

/// <summary>
/// Optional parameters for <see cref="LayerTreeDomain.ProfileSnapshotAsync"/>.
/// </summary>
public sealed record ProfileSnapshotCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// The maximum number of times to replay the snapshot (1, if not specified).
    /// </summary>
    public long? MinRepeatCount { get; init; }

    /// <summary>
    /// The minimum duration (in seconds) to replay the snapshot.
    /// </summary>
    public double? MinDuration { get; init; }

    /// <summary>
    /// The clip rectangle to apply when replaying the snapshot.
    /// </summary>
    public DOM.Rect? ClipRect { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Timings">
/// The array of paint profiles, one per run.
/// </param>
public sealed record ProfileSnapshotResult(IReadOnlyList<IReadOnlyList<double>> Timings) : EmptyResult;


internal sealed record ReleaseSnapshotCommandParameters(SnapshotId SnapshotId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="LayerTreeDomain.ReleaseSnapshotAsync"/>.
/// </summary>
public sealed record ReleaseSnapshotCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ReleaseSnapshotResult() : EmptyResult;


internal sealed record ReplaySnapshotCommandParameters(SnapshotId SnapshotId, long? FromStep, long? ToStep, double? Scale) : Parameters;

/// <summary>
/// Optional parameters for <see cref="LayerTreeDomain.ReplaySnapshotAsync"/>.
/// </summary>
public sealed record ReplaySnapshotCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// The first step to replay from (replay from the very start if not specified).
    /// </summary>
    public long? FromStep { get; init; }

    /// <summary>
    /// The last step to replay to (replay till the end if not specified).
    /// </summary>
    public long? ToStep { get; init; }

    /// <summary>
    /// The scale to apply while replaying (defaults to 1).
    /// </summary>
    public double? Scale { get; init; }
}

/// <summary>
/// </summary>
/// <param name="DataURL">
/// A data: URL for resulting image.
/// </param>
public sealed record ReplaySnapshotResult(string DataURL) : EmptyResult;


internal sealed record SnapshotCommandLogCommandParameters(SnapshotId SnapshotId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="LayerTreeDomain.SnapshotCommandLogAsync"/>.
/// </summary>
public sealed record SnapshotCommandLogCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="CommandLog">
/// The array of canvas function calls.
/// </param>
public sealed record SnapshotCommandLogResult(IReadOnlyList<global::System.Text.Json.JsonElement> CommandLog) : EmptyResult;


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
    public IReadOnlyList<double>? Transform { get; init; }

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
    public IReadOnlyList<ScrollRect>? ScrollRects { get; init; }

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
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<PictureTile>), TypeInfoPropertyName = "IReadOnlyListLayerTreePictureTile")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<Layer>), TypeInfoPropertyName = "IReadOnlyListLayerTreeLayer")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<ScrollRect>), TypeInfoPropertyName = "IReadOnlyListLayerTreeScrollRect")]
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
