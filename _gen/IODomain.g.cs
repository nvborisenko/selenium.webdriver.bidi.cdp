#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.IO;

/// <summary>
/// Input/Output operations for streams produced by DevTools.
/// </summary>
public interface IIO
{
    /// <summary>
    /// Close the stream, discard any temporary backing storage.
    /// </summary>
    /// <param name="handle">
    /// Handle of the stream to close.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="CloseResult"/>.
    /// </returns>
    Task<CloseResult> CloseAsync(StreamHandle handle, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Read a chunk of the stream
    /// </summary>
    /// <param name="handle">
    /// Handle of the stream to read.
    /// </param>
    /// <param name="offset">
    /// Seek to the specified offset before reading (if not specified, proceed with offset
    /// following the last read). Some types of streams may only support sequential reads.
    /// </param>
    /// <param name="size">
    /// Maximum number of bytes to read (left upon the agent discretion if not specified).
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ReadResult"/>.
    /// </returns>
    Task<ReadResult> ReadAsync(StreamHandle handle, long? offset = default, long? size = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Return UUID of Blob object specified by a remote object id.
    /// </summary>
    /// <param name="objectId">
    /// Object id of a Blob object wrapper.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ResolveBlobResult"/>.
    /// </returns>
    Task<ResolveBlobResult> ResolveBlobAsync(Runtime.RemoteObjectId objectId, string? session = default, CancellationToken cancellationToken = default);

}

internal sealed class IODomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), IIO
{
    private static readonly IOJsonSerializerContext JsonContext = IOJsonSerializerContext.Default;

    public async Task<CloseResult> CloseAsync(StreamHandle handle, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new CloseCommandParameters(Handle: handle);
        var command = new CdpCommand<CloseCommandParameters, CloseResult>("IO.close", JsonContext.CloseCommandParameters, JsonContext.CloseResult);
        return await ExecuteCommandAsync(command, @params, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<ReadResult> ReadAsync(StreamHandle handle, long? offset = default, long? size = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ReadCommandParameters(Handle: handle, Offset: offset, Size: size);
        var command = new CdpCommand<ReadCommandParameters, ReadResult>("IO.read", JsonContext.ReadCommandParameters, JsonContext.ReadResult);
        return await ExecuteCommandAsync(command, @params, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<ResolveBlobResult> ResolveBlobAsync(Runtime.RemoteObjectId objectId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ResolveBlobCommandParameters(ObjectId: objectId);
        var command = new CdpCommand<ResolveBlobCommandParameters, ResolveBlobResult>("IO.resolveBlob", JsonContext.ResolveBlobCommandParameters, JsonContext.ResolveBlobResult);
        return await ExecuteCommandAsync(command, @params, session, cancellationToken).ConfigureAwait(false);
    }

}

internal sealed record CloseCommandParameters(StreamHandle Handle) : Parameters;

/// <summary>
/// </summary>
public sealed record CloseResult() : EmptyResult;


internal sealed record ReadCommandParameters(StreamHandle Handle, long? Offset, long? Size) : Parameters;

/// <summary>
/// </summary>
/// <param name="Base64Encoded">
/// Set if the data is base64-encoded
/// </param>
/// <param name="Data">
/// Data that were read.
/// </param>
/// <param name="Eof">
/// Set if the end-of-file condition occurred while reading.
/// </param>
public sealed record ReadResult(bool? Base64Encoded, string Data, bool Eof) : EmptyResult;


internal sealed record ResolveBlobCommandParameters(Runtime.RemoteObjectId ObjectId) : Parameters;

/// <summary>
/// </summary>
/// <param name="Uuid">
/// UUID of the specified Blob.
/// </param>
public sealed record ResolveBlobResult(string Uuid) : EmptyResult;


/// <summary>
/// This is either obtained from another method or specified as <b>blob:&lt;uuid&gt;</b> where
/// <b>&lt;uuid&gt;</b> is an UUID of a Blob.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<StreamHandle>))]
public record StreamHandle : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

[JsonSerializable(typeof(CloseCommandParameters), TypeInfoPropertyName = "CloseCommandParameters")]
[JsonSerializable(typeof(CloseResult), TypeInfoPropertyName = "CloseResult")]
[JsonSerializable(typeof(ReadCommandParameters), TypeInfoPropertyName = "ReadCommandParameters")]
[JsonSerializable(typeof(ReadResult), TypeInfoPropertyName = "ReadResult")]
[JsonSerializable(typeof(ResolveBlobCommandParameters), TypeInfoPropertyName = "ResolveBlobCommandParameters")]
[JsonSerializable(typeof(ResolveBlobResult), TypeInfoPropertyName = "ResolveBlobResult")]
[JsonSerializable(typeof(StreamHandle), TypeInfoPropertyName = "IOStreamHandle")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class IOJsonSerializerContext : JsonSerializerContext;

