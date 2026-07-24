#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.CacheStorage;

/// <summary>
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class CacheStorageDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static CacheStorageJsonSerializerContext JsonContext = CacheStorageJsonSerializerContext.Default;

    /// <summary>
    /// Deletes a cache.
    /// </summary>
    /// <param name="cacheId">
    /// Id of cache for deletion.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="DeleteCacheCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DeleteCacheResult"/>.
    /// </returns>
    public async Task<DeleteCacheResult> DeleteCacheAsync(CacheId cacheId, DeleteCacheCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new DeleteCacheCommandParameters(CacheId: cacheId);
        return await ExecuteCommandAsync(DeleteCacheCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DeleteCacheCommandParameters, DeleteCacheResult> DeleteCacheCommand = new("CacheStorage.deleteCache", JsonContext.DeleteCacheCommandParameters, JsonContext.DeleteCacheResult);

    /// <summary>
    /// Deletes a cache entry.
    /// </summary>
    /// <param name="cacheId">
    /// Id of cache where the entry will be deleted.
    /// </param>
    /// <param name="request">
    /// URL spec of the request.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="DeleteEntryCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DeleteEntryResult"/>.
    /// </returns>
    public async Task<DeleteEntryResult> DeleteEntryAsync(CacheId cacheId, string request, DeleteEntryCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new DeleteEntryCommandParameters(CacheId: cacheId, Request: request);
        return await ExecuteCommandAsync(DeleteEntryCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DeleteEntryCommandParameters, DeleteEntryResult> DeleteEntryCommand = new("CacheStorage.deleteEntry", JsonContext.DeleteEntryCommandParameters, JsonContext.DeleteEntryResult);

    /// <summary>
    /// Requests cache names.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>SecurityOrigin</b> - At least and at most one of securityOrigin, storageKey, storageBucket must be specified. Security origin.</description></item>
    /// <item><description><b>StorageKey</b> - Storage key.</description></item>
    /// <item><description><b>StorageBucket</b> - Storage bucket. If not specified, it uses the default bucket.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="RequestCacheNamesCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RequestCacheNamesResult"/>.
    /// </returns>
    public async Task<RequestCacheNamesResult> RequestCacheNamesAsync(RequestCacheNamesCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new RequestCacheNamesCommandParameters(SecurityOrigin: options?.SecurityOrigin, StorageKey: options?.StorageKey, StorageBucket: options?.StorageBucket);
        return await ExecuteCommandAsync(RequestCacheNamesCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RequestCacheNamesCommandParameters, RequestCacheNamesResult> RequestCacheNamesCommand = new("CacheStorage.requestCacheNames", JsonContext.RequestCacheNamesCommandParameters, JsonContext.RequestCacheNamesResult);

    /// <summary>
    /// Fetches cache entry.
    /// </summary>
    /// <param name="cacheId">
    /// Id of cache that contains the entry.
    /// </param>
    /// <param name="requestURL">
    /// URL spec of the request.
    /// </param>
    /// <param name="requestHeaders">
    /// headers of the request.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="RequestCachedResponseCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RequestCachedResponseResult"/>.
    /// </returns>
    public async Task<RequestCachedResponseResult> RequestCachedResponseAsync(CacheId cacheId, string requestURL, ImmutableArray<Header> requestHeaders, RequestCachedResponseCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new RequestCachedResponseCommandParameters(CacheId: cacheId, RequestURL: requestURL, RequestHeaders: requestHeaders);
        return await ExecuteCommandAsync(RequestCachedResponseCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RequestCachedResponseCommandParameters, RequestCachedResponseResult> RequestCachedResponseCommand = new("CacheStorage.requestCachedResponse", JsonContext.RequestCachedResponseCommandParameters, JsonContext.RequestCachedResponseResult);

    /// <summary>
    /// Requests data from cache.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>SkipCount</b> - Number of records to skip.</description></item>
    /// <item><description><b>PageSize</b> - Number of records to fetch.</description></item>
    /// <item><description><b>PathFilter</b> - If present, only return the entries containing this substring in the path</description></item>
    /// </list>
    /// </remarks>
    /// <param name="cacheId">
    /// ID of cache to get entries from.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="RequestEntriesCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RequestEntriesResult"/>.
    /// </returns>
    public async Task<RequestEntriesResult> RequestEntriesAsync(CacheId cacheId, RequestEntriesCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new RequestEntriesCommandParameters(CacheId: cacheId, SkipCount: options?.SkipCount, PageSize: options?.PageSize, PathFilter: options?.PathFilter);
        return await ExecuteCommandAsync(RequestEntriesCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RequestEntriesCommandParameters, RequestEntriesResult> RequestEntriesCommand = new("CacheStorage.requestEntries", JsonContext.RequestEntriesCommandParameters, JsonContext.RequestEntriesResult);

}

internal sealed record DeleteCacheCommandParameters(CacheId CacheId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="CacheStorageDomain.DeleteCacheAsync"/>.
/// </summary>
public sealed record DeleteCacheCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DeleteCacheResult() : EmptyResult;


internal sealed record DeleteEntryCommandParameters(CacheId CacheId, string Request) : Parameters;

/// <summary>
/// Optional parameters for <see cref="CacheStorageDomain.DeleteEntryAsync"/>.
/// </summary>
public sealed record DeleteEntryCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DeleteEntryResult() : EmptyResult;


internal sealed record RequestCacheNamesCommandParameters(string? SecurityOrigin, string? StorageKey, Storage.StorageBucket? StorageBucket) : Parameters;

/// <summary>
/// Optional parameters for <see cref="CacheStorageDomain.RequestCacheNamesAsync"/>.
/// </summary>
public sealed record RequestCacheNamesCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// At least and at most one of securityOrigin, storageKey, storageBucket must be specified.
    /// Security origin.
    /// </summary>
    public string? SecurityOrigin { get; init; }

    /// <summary>
    /// Storage key.
    /// </summary>
    public string? StorageKey { get; init; }

    /// <summary>
    /// Storage bucket. If not specified, it uses the default bucket.
    /// </summary>
    public Storage.StorageBucket? StorageBucket { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Caches">
/// Caches for the security origin.
/// </param>
public sealed record RequestCacheNamesResult(IReadOnlyList<Cache> Caches) : EmptyResult;


internal sealed record RequestCachedResponseCommandParameters(CacheId CacheId, string RequestURL, ImmutableArray<Header> RequestHeaders) : Parameters;

/// <summary>
/// Optional parameters for <see cref="CacheStorageDomain.RequestCachedResponseAsync"/>.
/// </summary>
public sealed record RequestCachedResponseCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Response">
/// Response read from the cache.
/// </param>
public sealed record RequestCachedResponseResult(CachedResponse Response) : EmptyResult;


internal sealed record RequestEntriesCommandParameters(CacheId CacheId, long? SkipCount, long? PageSize, string? PathFilter) : Parameters;

/// <summary>
/// Optional parameters for <see cref="CacheStorageDomain.RequestEntriesAsync"/>.
/// </summary>
public sealed record RequestEntriesCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Number of records to skip.
    /// </summary>
    public long? SkipCount { get; init; }

    /// <summary>
    /// Number of records to fetch.
    /// </summary>
    public long? PageSize { get; init; }

    /// <summary>
    /// If present, only return the entries containing this substring in the path
    /// </summary>
    public string? PathFilter { get; init; }
}

/// <summary>
/// </summary>
/// <param name="CacheDataEntries">
/// Array of object store data entries.
/// </param>
/// <param name="ReturnCount">
/// Count of returned entries from this storage. If pathFilter is empty, it
/// is the count of all entries from this storage.
/// </param>
public sealed record RequestEntriesResult(IReadOnlyList<DataEntry> CacheDataEntries, double ReturnCount) : EmptyResult;


/// <summary>
/// Unique identifier of the Cache object.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<CacheId>))]
public record CacheId : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// type of HTTP response cached
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<CachedResponseType>))]
public enum CachedResponseType
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("basic")]
    Basic,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("cors")]
    Cors,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("default")]
    Default,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("error")]
    Error,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("opaqueResponse")]
    OpaqueResponse,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("opaqueRedirect")]
    OpaqueRedirect,
}

/// <summary>
/// Data entry.
/// </summary>
/// <param name="RequestURL">
/// Request URL.
/// </param>
/// <param name="RequestMethod">
/// Request method.
/// </param>
/// <param name="RequestHeaders">
/// Request headers
/// </param>
/// <param name="ResponseTime">
/// Number of seconds since epoch.
/// </param>
/// <param name="ResponseStatus">
/// HTTP response status code.
/// </param>
/// <param name="ResponseStatusText">
/// HTTP response status text.
/// </param>
/// <param name="ResponseType">
/// HTTP response type
/// </param>
/// <param name="ResponseHeaders">
/// Response headers
/// </param>
public sealed record DataEntry(string RequestURL, string RequestMethod, IReadOnlyList<Header> RequestHeaders, double ResponseTime, long ResponseStatus, string ResponseStatusText, CachedResponseType ResponseType, IReadOnlyList<Header> ResponseHeaders)
{
}

/// <summary>
/// Cache identifier.
/// </summary>
/// <param name="CacheId">
/// An opaque unique id of the cache.
/// </param>
/// <param name="SecurityOrigin">
/// Security origin of the cache.
/// </param>
/// <param name="StorageKey">
/// Storage key of the cache.
/// </param>
/// <param name="CacheName">
/// The name of the cache.
/// </param>
public sealed record Cache(CacheId CacheId, string SecurityOrigin, string StorageKey, string CacheName)
{
    /// <summary>
    /// Storage bucket of the cache.
    /// </summary>
    public Storage.StorageBucket? StorageBucket { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Name">
/// </param>
/// <param name="Value">
/// </param>
public sealed record Header(string Name, string Value)
{
}

/// <summary>
/// Cached response
/// </summary>
/// <param name="Body">
/// Entry content, base64-encoded. (Encoded as a base64 string when passed over JSON)
/// </param>
public sealed record CachedResponse(string Body)
{
}

[JsonSerializable(typeof(DeleteCacheCommandParameters), TypeInfoPropertyName = "DeleteCacheCommandParameters")]
[JsonSerializable(typeof(DeleteCacheResult), TypeInfoPropertyName = "DeleteCacheResult")]
[JsonSerializable(typeof(DeleteEntryCommandParameters), TypeInfoPropertyName = "DeleteEntryCommandParameters")]
[JsonSerializable(typeof(DeleteEntryResult), TypeInfoPropertyName = "DeleteEntryResult")]
[JsonSerializable(typeof(RequestCacheNamesCommandParameters), TypeInfoPropertyName = "RequestCacheNamesCommandParameters")]
[JsonSerializable(typeof(RequestCacheNamesResult), TypeInfoPropertyName = "RequestCacheNamesResult")]
[JsonSerializable(typeof(RequestCachedResponseCommandParameters), TypeInfoPropertyName = "RequestCachedResponseCommandParameters")]
[JsonSerializable(typeof(RequestCachedResponseResult), TypeInfoPropertyName = "RequestCachedResponseResult")]
[JsonSerializable(typeof(RequestEntriesCommandParameters), TypeInfoPropertyName = "RequestEntriesCommandParameters")]
[JsonSerializable(typeof(RequestEntriesResult), TypeInfoPropertyName = "RequestEntriesResult")]
[JsonSerializable(typeof(CacheId), TypeInfoPropertyName = "CacheStorageCacheId")]
[JsonSerializable(typeof(CachedResponseType), TypeInfoPropertyName = "CacheStorageCachedResponseType")]
[JsonSerializable(typeof(DataEntry), TypeInfoPropertyName = "CacheStorageDataEntry")]
[JsonSerializable(typeof(Cache), TypeInfoPropertyName = "CacheStorageCache")]
[JsonSerializable(typeof(Header), TypeInfoPropertyName = "CacheStorageHeader")]
[JsonSerializable(typeof(CachedResponse), TypeInfoPropertyName = "CacheStorageCachedResponse")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<Cache>), TypeInfoPropertyName = "IReadOnlyListCacheStorageCache")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<Header>), TypeInfoPropertyName = "IReadOnlyListCacheStorageHeader")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<DataEntry>), TypeInfoPropertyName = "IReadOnlyListCacheStorageDataEntry")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class CacheStorageJsonSerializerContext : JsonSerializerContext;

