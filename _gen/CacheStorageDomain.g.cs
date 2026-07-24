#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.CacheStorage;

/// <summary>
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public interface ICacheStorage
{
    /// <summary>
    /// Deletes a cache.
    /// </summary>
    /// <param name="cacheId">
    /// Id of cache for deletion.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DeleteCacheResult"/>.
    /// </returns>
    Task<DeleteCacheResult> DeleteCacheAsync(CacheId cacheId, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a cache entry.
    /// </summary>
    /// <param name="cacheId">
    /// Id of cache where the entry will be deleted.
    /// </param>
    /// <param name="request">
    /// URL spec of the request.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DeleteEntryResult"/>.
    /// </returns>
    Task<DeleteEntryResult> DeleteEntryAsync(CacheId cacheId, string request, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Requests cache names.
    /// </summary>
    /// <param name="securityOrigin">
    /// At least and at most one of securityOrigin, storageKey, storageBucket must be specified.
    /// Security origin.
    /// </param>
    /// <param name="storageKey">
    /// Storage key.
    /// </param>
    /// <param name="storageBucket">
    /// Storage bucket. If not specified, it uses the default bucket.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RequestCacheNamesResult"/>.
    /// </returns>
    Task<RequestCacheNamesResult> RequestCacheNamesAsync(string? securityOrigin = default, string? storageKey = default, Storage.StorageBucket? storageBucket = default, string? session = default, CancellationToken cancellationToken = default);

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
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RequestCachedResponseResult"/>.
    /// </returns>
    Task<RequestCachedResponseResult> RequestCachedResponseAsync(CacheId cacheId, string requestURL, ImmutableArray<Header> requestHeaders, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Requests data from cache.
    /// </summary>
    /// <param name="cacheId">
    /// ID of cache to get entries from.
    /// </param>
    /// <param name="skipCount">
    /// Number of records to skip.
    /// </param>
    /// <param name="pageSize">
    /// Number of records to fetch.
    /// </param>
    /// <param name="pathFilter">
    /// If present, only return the entries containing this substring in the path
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RequestEntriesResult"/>.
    /// </returns>
    Task<RequestEntriesResult> RequestEntriesAsync(CacheId cacheId, long? skipCount = default, long? pageSize = default, string? pathFilter = default, string? session = default, CancellationToken cancellationToken = default);

}

[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
internal sealed class CacheStorageDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), ICacheStorage
{
    private static CacheStorageJsonSerializerContext JsonContext = CacheStorageJsonSerializerContext.Default;

    public async Task<DeleteCacheResult> DeleteCacheAsync(CacheId cacheId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DeleteCacheCommandParameters(CacheId: cacheId);
        return await ExecuteCommandAsync(DeleteCacheCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DeleteCacheCommandParameters, DeleteCacheResult> DeleteCacheCommand = new("CacheStorage.deleteCache", JsonContext.DeleteCacheCommandParameters, JsonContext.DeleteCacheResult);

    public async Task<DeleteEntryResult> DeleteEntryAsync(CacheId cacheId, string request, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DeleteEntryCommandParameters(CacheId: cacheId, Request: request);
        return await ExecuteCommandAsync(DeleteEntryCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DeleteEntryCommandParameters, DeleteEntryResult> DeleteEntryCommand = new("CacheStorage.deleteEntry", JsonContext.DeleteEntryCommandParameters, JsonContext.DeleteEntryResult);

    public async Task<RequestCacheNamesResult> RequestCacheNamesAsync(string? securityOrigin = default, string? storageKey = default, Storage.StorageBucket? storageBucket = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RequestCacheNamesCommandParameters(SecurityOrigin: securityOrigin, StorageKey: storageKey, StorageBucket: storageBucket);
        return await ExecuteCommandAsync(RequestCacheNamesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RequestCacheNamesCommandParameters, RequestCacheNamesResult> RequestCacheNamesCommand = new("CacheStorage.requestCacheNames", JsonContext.RequestCacheNamesCommandParameters, JsonContext.RequestCacheNamesResult);

    public async Task<RequestCachedResponseResult> RequestCachedResponseAsync(CacheId cacheId, string requestURL, ImmutableArray<Header> requestHeaders, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RequestCachedResponseCommandParameters(CacheId: cacheId, RequestURL: requestURL, RequestHeaders: requestHeaders);
        return await ExecuteCommandAsync(RequestCachedResponseCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RequestCachedResponseCommandParameters, RequestCachedResponseResult> RequestCachedResponseCommand = new("CacheStorage.requestCachedResponse", JsonContext.RequestCachedResponseCommandParameters, JsonContext.RequestCachedResponseResult);

    public async Task<RequestEntriesResult> RequestEntriesAsync(CacheId cacheId, long? skipCount = default, long? pageSize = default, string? pathFilter = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RequestEntriesCommandParameters(CacheId: cacheId, SkipCount: skipCount, PageSize: pageSize, PathFilter: pathFilter);
        return await ExecuteCommandAsync(RequestEntriesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RequestEntriesCommandParameters, RequestEntriesResult> RequestEntriesCommand = new("CacheStorage.requestEntries", JsonContext.RequestEntriesCommandParameters, JsonContext.RequestEntriesResult);

}

internal sealed record DeleteCacheCommandParameters(CacheId CacheId) : Parameters;

/// <summary>
/// </summary>
public sealed record DeleteCacheResult() : EmptyResult;


internal sealed record DeleteEntryCommandParameters(CacheId CacheId, string Request) : Parameters;

/// <summary>
/// </summary>
public sealed record DeleteEntryResult() : EmptyResult;


internal sealed record RequestCacheNamesCommandParameters(string? SecurityOrigin, string? StorageKey, Storage.StorageBucket? StorageBucket) : Parameters;

/// <summary>
/// </summary>
/// <param name="Caches">
/// Caches for the security origin.
/// </param>
public sealed record RequestCacheNamesResult(ImmutableArray<Cache> Caches) : EmptyResult;


internal sealed record RequestCachedResponseCommandParameters(CacheId CacheId, string RequestURL, ImmutableArray<Header> RequestHeaders) : Parameters;

/// <summary>
/// </summary>
/// <param name="Response">
/// Response read from the cache.
/// </param>
public sealed record RequestCachedResponseResult(CachedResponse Response) : EmptyResult;


internal sealed record RequestEntriesCommandParameters(CacheId CacheId, long? SkipCount, long? PageSize, string? PathFilter) : Parameters;

/// <summary>
/// </summary>
/// <param name="CacheDataEntries">
/// Array of object store data entries.
/// </param>
/// <param name="ReturnCount">
/// Count of returned entries from this storage. If pathFilter is empty, it
/// is the count of all entries from this storage.
/// </param>
public sealed record RequestEntriesResult(ImmutableArray<DataEntry> CacheDataEntries, double ReturnCount) : EmptyResult;


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
public sealed record DataEntry(string RequestURL, string RequestMethod, ImmutableArray<Header> RequestHeaders, double ResponseTime, long ResponseStatus, string ResponseStatusText, CachedResponseType ResponseType, ImmutableArray<Header> ResponseHeaders)
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
[JsonSerializable(typeof(ImmutableArray<Cache>), TypeInfoPropertyName = "ImmutableArrayCacheStorageCache")]
[JsonSerializable(typeof(ImmutableArray<Header>), TypeInfoPropertyName = "ImmutableArrayCacheStorageHeader")]
[JsonSerializable(typeof(ImmutableArray<DataEntry>), TypeInfoPropertyName = "ImmutableArrayCacheStorageDataEntry")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class CacheStorageJsonSerializerContext : JsonSerializerContext;

