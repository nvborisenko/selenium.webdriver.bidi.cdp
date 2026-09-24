#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Storage;

/// <summary>
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public interface IStorage
{
    /// <summary>
    /// Returns a storage key given a frame id.
    /// Deprecated. Please use Storage.getStorageKey instead.
    /// </summary>
    /// <param name="frameId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetStorageKeyForFrameResult"/>.
    /// </returns>
    [global::System.Obsolete]
    Task<GetStorageKeyForFrameResult> GetStorageKeyForFrameAsync(Page.FrameId frameId, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns storage key for the given frame. If no frame ID is provided,
    /// the storage key of the target executing this command is returned.
    /// </summary>
    /// <param name="frameId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetStorageKeyResult"/>.
    /// </returns>
    Task<GetStorageKeyResult> GetStorageKeyAsync(Page.FrameId? frameId = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Clears storage for origin.
    /// </summary>
    /// <param name="origin">
    /// Security origin.
    /// </param>
    /// <param name="storageTypes">
    /// Comma separated list of StorageType to clear.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearDataForOriginResult"/>.
    /// </returns>
    Task<ClearDataForOriginResult> ClearDataForOriginAsync(string origin, string storageTypes, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Clears storage for storage key.
    /// </summary>
    /// <param name="storageKey">
    /// Storage key.
    /// </param>
    /// <param name="storageTypes">
    /// Comma separated list of StorageType to clear.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearDataForStorageKeyResult"/>.
    /// </returns>
    Task<ClearDataForStorageKeyResult> ClearDataForStorageKeyAsync(string storageKey, string storageTypes, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns all browser cookies.
    /// </summary>
    /// <param name="browserContextId">
    /// Browser context to use when called on the browser endpoint.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetCookiesResult"/>.
    /// </returns>
    Task<GetCookiesResult> GetCookiesAsync(Browser.BrowserContextID? browserContextId = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Sets given cookies.
    /// </summary>
    /// <param name="cookies">
    /// Cookies to be set.
    /// </param>
    /// <param name="browserContextId">
    /// Browser context to use when called on the browser endpoint.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetCookiesResult"/>.
    /// </returns>
    Task<SetCookiesResult> SetCookiesAsync(ImmutableArray<Network.CookieParam> cookies, Browser.BrowserContextID? browserContextId = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Clears cookies.
    /// </summary>
    /// <param name="browserContextId">
    /// Browser context to use when called on the browser endpoint.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearCookiesResult"/>.
    /// </returns>
    Task<ClearCookiesResult> ClearCookiesAsync(Browser.BrowserContextID? browserContextId = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns usage and quota in bytes.
    /// </summary>
    /// <param name="origin">
    /// Security origin.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetUsageAndQuotaResult"/>.
    /// </returns>
    Task<GetUsageAndQuotaResult> GetUsageAndQuotaAsync(string origin, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Override quota for the specified origin
    /// </summary>
    /// <param name="origin">
    /// Security origin.
    /// </param>
    /// <param name="quotaSize">
    /// The quota size (in bytes) to override the original quota with.
    /// If this is called multiple times, the overridden quota will be equal to
    /// the quotaSize provided in the final call. If this is called without
    /// specifying a quotaSize, the quota will be reset to the default value for
    /// the specified origin. If this is called multiple times with different
    /// origins, the override will be maintained for each origin until it is
    /// disabled (called without a quotaSize).
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="OverrideQuotaForOriginResult"/>.
    /// </returns>
    Task<OverrideQuotaForOriginResult> OverrideQuotaForOriginAsync(string origin, double? quotaSize = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Registers origin to be notified when an update occurs to its cache storage list.
    /// </summary>
    /// <param name="origin">
    /// Security origin.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="TrackCacheStorageForOriginResult"/>.
    /// </returns>
    Task<TrackCacheStorageForOriginResult> TrackCacheStorageForOriginAsync(string origin, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Registers storage key to be notified when an update occurs to its cache storage list.
    /// </summary>
    /// <param name="storageKey">
    /// Storage key.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="TrackCacheStorageForStorageKeyResult"/>.
    /// </returns>
    Task<TrackCacheStorageForStorageKeyResult> TrackCacheStorageForStorageKeyAsync(string storageKey, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Registers origin to be notified when an update occurs to its IndexedDB.
    /// </summary>
    /// <param name="origin">
    /// Security origin.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="TrackIndexedDBForOriginResult"/>.
    /// </returns>
    Task<TrackIndexedDBForOriginResult> TrackIndexedDBForOriginAsync(string origin, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Registers storage key to be notified when an update occurs to its IndexedDB.
    /// </summary>
    /// <param name="storageKey">
    /// Storage key.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="TrackIndexedDBForStorageKeyResult"/>.
    /// </returns>
    Task<TrackIndexedDBForStorageKeyResult> TrackIndexedDBForStorageKeyAsync(string storageKey, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Unregisters origin from receiving notifications for cache storage.
    /// </summary>
    /// <param name="origin">
    /// Security origin.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="UntrackCacheStorageForOriginResult"/>.
    /// </returns>
    Task<UntrackCacheStorageForOriginResult> UntrackCacheStorageForOriginAsync(string origin, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Unregisters storage key from receiving notifications for cache storage.
    /// </summary>
    /// <param name="storageKey">
    /// Storage key.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="UntrackCacheStorageForStorageKeyResult"/>.
    /// </returns>
    Task<UntrackCacheStorageForStorageKeyResult> UntrackCacheStorageForStorageKeyAsync(string storageKey, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Unregisters origin from receiving notifications for IndexedDB.
    /// </summary>
    /// <param name="origin">
    /// Security origin.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="UntrackIndexedDBForOriginResult"/>.
    /// </returns>
    Task<UntrackIndexedDBForOriginResult> UntrackIndexedDBForOriginAsync(string origin, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Unregisters storage key from receiving notifications for IndexedDB.
    /// </summary>
    /// <param name="storageKey">
    /// Storage key.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="UntrackIndexedDBForStorageKeyResult"/>.
    /// </returns>
    Task<UntrackIndexedDBForStorageKeyResult> UntrackIndexedDBForStorageKeyAsync(string storageKey, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the number of stored Trust Tokens per issuer for the
    /// current browsing context.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetTrustTokensResult"/>.
    /// </returns>
    Task<GetTrustTokensResult> GetTrustTokensAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Removes all Trust Tokens issued by the provided issuerOrigin.
    /// Leaves other stored data, including the issuer's Redemption Records, intact.
    /// </summary>
    /// <param name="issuerOrigin">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearTrustTokensResult"/>.
    /// </returns>
    Task<ClearTrustTokensResult> ClearTrustTokensAsync(string issuerOrigin, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns all stored Private Verification Tokens for the current browsing
    /// context.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetPrivateVerificationTokensResult"/>.
    /// </returns>
    Task<GetPrivateVerificationTokensResult> GetPrivateVerificationTokensAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns the configured Private Verification Tokens issuers and their redeemer
    /// origins.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetPrivateVerificationTokensIssuerConfigsResult"/>.
    /// </returns>
    Task<GetPrivateVerificationTokensIssuerConfigsResult> GetPrivateVerificationTokensIssuerConfigsAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Removes all Private Verification Tokens issued by the provided issuerOrigin.
    /// </summary>
    /// <param name="issuerOrigin">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearPrivateVerificationTokensResult"/>.
    /// </returns>
    Task<ClearPrivateVerificationTokensResult> ClearPrivateVerificationTokensAsync(string issuerOrigin, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Removes a specific Private Verification Token by its ID.
    /// </summary>
    /// <param name="tokenId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DeletePrivateVerificationTokenResult"/>.
    /// </returns>
    Task<DeletePrivateVerificationTokenResult> DeletePrivateVerificationTokenAsync(string tokenId, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Set tracking for Private Verification Tokens.
    /// </summary>
    /// <param name="enable">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetPrivateVerificationTokensTrackingResult"/>.
    /// </returns>
    Task<SetPrivateVerificationTokensTrackingResult> SetPrivateVerificationTokensTrackingAsync(bool enable, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Set tracking for a storage key's buckets.
    /// </summary>
    /// <param name="storageKey">
    /// </param>
    /// <param name="enable">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetStorageBucketTrackingResult"/>.
    /// </returns>
    Task<SetStorageBucketTrackingResult> SetStorageBucketTrackingAsync(string storageKey, bool enable, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes the Storage Bucket with the given storage key and bucket name.
    /// </summary>
    /// <param name="bucket">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DeleteStorageBucketResult"/>.
    /// </returns>
    Task<DeleteStorageBucketResult> DeleteStorageBucketAsync(StorageBucket bucket, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes state for sites identified as potential bounce trackers, immediately.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RunBounceTrackingMitigationsResult"/>.
    /// </returns>
    Task<RunBounceTrackingMitigationsResult> RunBounceTrackingMitigationsAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// A cache's contents have been modified.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="CacheStorageContentUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Origin</b> - Origin to update.</description></item>
    /// <item><description><b>StorageKey</b> - Storage key to update.</description></item>
    /// <item><description><b>BucketId</b> - Storage bucket to update.</description></item>
    /// <item><description><b>CacheName</b> - Name of cache in origin.</description></item>
    /// </list>
    /// </remarks>
    IEventSource<CacheStorageContentUpdatedEventArgs> CacheStorageContentUpdated { get; }

    /// <summary>
    /// A cache has been added/deleted.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="CacheStorageListUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Origin</b> - Origin to update.</description></item>
    /// <item><description><b>StorageKey</b> - Storage key to update.</description></item>
    /// <item><description><b>BucketId</b> - Storage bucket to update.</description></item>
    /// </list>
    /// </remarks>
    IEventSource<CacheStorageListUpdatedEventArgs> CacheStorageListUpdated { get; }

    /// <summary>
    /// The origin's IndexedDB object store has been modified.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="IndexedDBContentUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Origin</b> - Origin to update.</description></item>
    /// <item><description><b>StorageKey</b> - Storage key to update.</description></item>
    /// <item><description><b>BucketId</b> - Storage bucket to update.</description></item>
    /// <item><description><b>DatabaseName</b> - Database to update.</description></item>
    /// <item><description><b>ObjectStoreName</b> - ObjectStore to update.</description></item>
    /// </list>
    /// </remarks>
    IEventSource<IndexedDBContentUpdatedEventArgs> IndexedDBContentUpdated { get; }

    /// <summary>
    /// The origin's IndexedDB database list has been modified.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="IndexedDBListUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Origin</b> - Origin to update.</description></item>
    /// <item><description><b>StorageKey</b> - Storage key to update.</description></item>
    /// <item><description><b>BucketId</b> - Storage bucket to update.</description></item>
    /// </list>
    /// </remarks>
    IEventSource<IndexedDBListUpdatedEventArgs> IndexedDBListUpdated { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="StorageBucketCreatedOrUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>BucketInfo</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<StorageBucketCreatedOrUpdatedEventArgs> StorageBucketCreatedOrUpdated { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="StorageBucketDeletedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>BucketId</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<StorageBucketDeletedEventArgs> StorageBucketDeleted { get; }

    /// <summary>
    /// Private Verification Tokens have been stored or deleted.
    /// </summary>
    IEventSource<PrivateVerificationTokensUpdatedEventArgs> PrivateVerificationTokensUpdated { get; }

}

[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
internal sealed class StorageDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), IStorage
{
    private static readonly StorageJsonSerializerContext JsonContext = StorageJsonSerializerContext.Default;

    [global::System.Obsolete]
    public async Task<GetStorageKeyForFrameResult> GetStorageKeyForFrameAsync(Page.FrameId frameId, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetStorageKeyForFrameCommandParameters(FrameId: frameId);
        return await ExecuteCommandAsync("Storage.getStorageKeyForFrame", @params, JsonContext.GetStorageKeyForFrameCommandParameters, JsonContext.GetStorageKeyForFrameResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<GetStorageKeyResult> GetStorageKeyAsync(Page.FrameId? frameId = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetStorageKeyCommandParameters(FrameId: frameId);
        return await ExecuteCommandAsync("Storage.getStorageKey", @params, JsonContext.GetStorageKeyCommandParameters, JsonContext.GetStorageKeyResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<ClearDataForOriginResult> ClearDataForOriginAsync(string origin, string storageTypes, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new ClearDataForOriginCommandParameters(Origin: origin, StorageTypes: storageTypes);
        return await ExecuteCommandAsync("Storage.clearDataForOrigin", @params, JsonContext.ClearDataForOriginCommandParameters, JsonContext.ClearDataForOriginResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<ClearDataForStorageKeyResult> ClearDataForStorageKeyAsync(string storageKey, string storageTypes, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new ClearDataForStorageKeyCommandParameters(StorageKey: storageKey, StorageTypes: storageTypes);
        return await ExecuteCommandAsync("Storage.clearDataForStorageKey", @params, JsonContext.ClearDataForStorageKeyCommandParameters, JsonContext.ClearDataForStorageKeyResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<GetCookiesResult> GetCookiesAsync(Browser.BrowserContextID? browserContextId = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetCookiesCommandParameters(BrowserContextId: browserContextId);
        return await ExecuteCommandAsync("Storage.getCookies", @params, JsonContext.GetCookiesCommandParameters, JsonContext.GetCookiesResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<SetCookiesResult> SetCookiesAsync(ImmutableArray<Network.CookieParam> cookies, Browser.BrowserContextID? browserContextId = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SetCookiesCommandParameters(Cookies: cookies, BrowserContextId: browserContextId);
        return await ExecuteCommandAsync("Storage.setCookies", @params, JsonContext.SetCookiesCommandParameters, JsonContext.SetCookiesResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<ClearCookiesResult> ClearCookiesAsync(Browser.BrowserContextID? browserContextId = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new ClearCookiesCommandParameters(BrowserContextId: browserContextId);
        return await ExecuteCommandAsync("Storage.clearCookies", @params, JsonContext.ClearCookiesCommandParameters, JsonContext.ClearCookiesResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<GetUsageAndQuotaResult> GetUsageAndQuotaAsync(string origin, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetUsageAndQuotaCommandParameters(Origin: origin);
        return await ExecuteCommandAsync("Storage.getUsageAndQuota", @params, JsonContext.GetUsageAndQuotaCommandParameters, JsonContext.GetUsageAndQuotaResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<OverrideQuotaForOriginResult> OverrideQuotaForOriginAsync(string origin, double? quotaSize = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new OverrideQuotaForOriginCommandParameters(Origin: origin, QuotaSize: quotaSize);
        return await ExecuteCommandAsync("Storage.overrideQuotaForOrigin", @params, JsonContext.OverrideQuotaForOriginCommandParameters, JsonContext.OverrideQuotaForOriginResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<TrackCacheStorageForOriginResult> TrackCacheStorageForOriginAsync(string origin, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new TrackCacheStorageForOriginCommandParameters(Origin: origin);
        return await ExecuteCommandAsync("Storage.trackCacheStorageForOrigin", @params, JsonContext.TrackCacheStorageForOriginCommandParameters, JsonContext.TrackCacheStorageForOriginResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<TrackCacheStorageForStorageKeyResult> TrackCacheStorageForStorageKeyAsync(string storageKey, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new TrackCacheStorageForStorageKeyCommandParameters(StorageKey: storageKey);
        return await ExecuteCommandAsync("Storage.trackCacheStorageForStorageKey", @params, JsonContext.TrackCacheStorageForStorageKeyCommandParameters, JsonContext.TrackCacheStorageForStorageKeyResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<TrackIndexedDBForOriginResult> TrackIndexedDBForOriginAsync(string origin, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new TrackIndexedDBForOriginCommandParameters(Origin: origin);
        return await ExecuteCommandAsync("Storage.trackIndexedDBForOrigin", @params, JsonContext.TrackIndexedDBForOriginCommandParameters, JsonContext.TrackIndexedDBForOriginResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<TrackIndexedDBForStorageKeyResult> TrackIndexedDBForStorageKeyAsync(string storageKey, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new TrackIndexedDBForStorageKeyCommandParameters(StorageKey: storageKey);
        return await ExecuteCommandAsync("Storage.trackIndexedDBForStorageKey", @params, JsonContext.TrackIndexedDBForStorageKeyCommandParameters, JsonContext.TrackIndexedDBForStorageKeyResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<UntrackCacheStorageForOriginResult> UntrackCacheStorageForOriginAsync(string origin, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new UntrackCacheStorageForOriginCommandParameters(Origin: origin);
        return await ExecuteCommandAsync("Storage.untrackCacheStorageForOrigin", @params, JsonContext.UntrackCacheStorageForOriginCommandParameters, JsonContext.UntrackCacheStorageForOriginResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<UntrackCacheStorageForStorageKeyResult> UntrackCacheStorageForStorageKeyAsync(string storageKey, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new UntrackCacheStorageForStorageKeyCommandParameters(StorageKey: storageKey);
        return await ExecuteCommandAsync("Storage.untrackCacheStorageForStorageKey", @params, JsonContext.UntrackCacheStorageForStorageKeyCommandParameters, JsonContext.UntrackCacheStorageForStorageKeyResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<UntrackIndexedDBForOriginResult> UntrackIndexedDBForOriginAsync(string origin, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new UntrackIndexedDBForOriginCommandParameters(Origin: origin);
        return await ExecuteCommandAsync("Storage.untrackIndexedDBForOrigin", @params, JsonContext.UntrackIndexedDBForOriginCommandParameters, JsonContext.UntrackIndexedDBForOriginResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<UntrackIndexedDBForStorageKeyResult> UntrackIndexedDBForStorageKeyAsync(string storageKey, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new UntrackIndexedDBForStorageKeyCommandParameters(StorageKey: storageKey);
        return await ExecuteCommandAsync("Storage.untrackIndexedDBForStorageKey", @params, JsonContext.UntrackIndexedDBForStorageKeyCommandParameters, JsonContext.UntrackIndexedDBForStorageKeyResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<GetTrustTokensResult> GetTrustTokensAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetTrustTokensCommandParameters();
        return await ExecuteCommandAsync("Storage.getTrustTokens", @params, JsonContext.GetTrustTokensCommandParameters, JsonContext.GetTrustTokensResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<ClearTrustTokensResult> ClearTrustTokensAsync(string issuerOrigin, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new ClearTrustTokensCommandParameters(IssuerOrigin: issuerOrigin);
        return await ExecuteCommandAsync("Storage.clearTrustTokens", @params, JsonContext.ClearTrustTokensCommandParameters, JsonContext.ClearTrustTokensResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<GetPrivateVerificationTokensResult> GetPrivateVerificationTokensAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetPrivateVerificationTokensCommandParameters();
        return await ExecuteCommandAsync("Storage.getPrivateVerificationTokens", @params, JsonContext.GetPrivateVerificationTokensCommandParameters, JsonContext.GetPrivateVerificationTokensResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<GetPrivateVerificationTokensIssuerConfigsResult> GetPrivateVerificationTokensIssuerConfigsAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetPrivateVerificationTokensIssuerConfigsCommandParameters();
        return await ExecuteCommandAsync("Storage.getPrivateVerificationTokensIssuerConfigs", @params, JsonContext.GetPrivateVerificationTokensIssuerConfigsCommandParameters, JsonContext.GetPrivateVerificationTokensIssuerConfigsResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<ClearPrivateVerificationTokensResult> ClearPrivateVerificationTokensAsync(string issuerOrigin, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new ClearPrivateVerificationTokensCommandParameters(IssuerOrigin: issuerOrigin);
        return await ExecuteCommandAsync("Storage.clearPrivateVerificationTokens", @params, JsonContext.ClearPrivateVerificationTokensCommandParameters, JsonContext.ClearPrivateVerificationTokensResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<DeletePrivateVerificationTokenResult> DeletePrivateVerificationTokenAsync(string tokenId, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new DeletePrivateVerificationTokenCommandParameters(TokenId: tokenId);
        return await ExecuteCommandAsync("Storage.deletePrivateVerificationToken", @params, JsonContext.DeletePrivateVerificationTokenCommandParameters, JsonContext.DeletePrivateVerificationTokenResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<SetPrivateVerificationTokensTrackingResult> SetPrivateVerificationTokensTrackingAsync(bool enable, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SetPrivateVerificationTokensTrackingCommandParameters(Enable: enable);
        return await ExecuteCommandAsync("Storage.setPrivateVerificationTokensTracking", @params, JsonContext.SetPrivateVerificationTokensTrackingCommandParameters, JsonContext.SetPrivateVerificationTokensTrackingResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<SetStorageBucketTrackingResult> SetStorageBucketTrackingAsync(string storageKey, bool enable, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SetStorageBucketTrackingCommandParameters(StorageKey: storageKey, Enable: enable);
        return await ExecuteCommandAsync("Storage.setStorageBucketTracking", @params, JsonContext.SetStorageBucketTrackingCommandParameters, JsonContext.SetStorageBucketTrackingResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<DeleteStorageBucketResult> DeleteStorageBucketAsync(StorageBucket bucket, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new DeleteStorageBucketCommandParameters(Bucket: bucket);
        return await ExecuteCommandAsync("Storage.deleteStorageBucket", @params, JsonContext.DeleteStorageBucketCommandParameters, JsonContext.DeleteStorageBucketResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<RunBounceTrackingMitigationsResult> RunBounceTrackingMitigationsAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new RunBounceTrackingMitigationsCommandParameters();
        return await ExecuteCommandAsync("Storage.runBounceTrackingMitigations", @params, JsonContext.RunBounceTrackingMitigationsCommandParameters, JsonContext.RunBounceTrackingMitigationsResult, session, cancellationToken).ConfigureAwait(false);
    }

    public IEventSource<CacheStorageContentUpdatedEventArgs> CacheStorageContentUpdated => CreateCdpEventSource(StorageDomainEvent.CacheStorageContentUpdated);
    public IEventSource<CacheStorageListUpdatedEventArgs> CacheStorageListUpdated => CreateCdpEventSource(StorageDomainEvent.CacheStorageListUpdated);
    public IEventSource<IndexedDBContentUpdatedEventArgs> IndexedDBContentUpdated => CreateCdpEventSource(StorageDomainEvent.IndexedDBContentUpdated);
    public IEventSource<IndexedDBListUpdatedEventArgs> IndexedDBListUpdated => CreateCdpEventSource(StorageDomainEvent.IndexedDBListUpdated);
    public IEventSource<StorageBucketCreatedOrUpdatedEventArgs> StorageBucketCreatedOrUpdated => CreateCdpEventSource(StorageDomainEvent.StorageBucketCreatedOrUpdated);
    public IEventSource<StorageBucketDeletedEventArgs> StorageBucketDeleted => CreateCdpEventSource(StorageDomainEvent.StorageBucketDeleted);
    public IEventSource<PrivateVerificationTokensUpdatedEventArgs> PrivateVerificationTokensUpdated => CreateCdpEventSource(StorageDomainEvent.PrivateVerificationTokensUpdated);
}

internal sealed record GetStorageKeyForFrameCommandParameters(Page.FrameId FrameId) : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.GetStorageKeyForFrameAsync"/> command.
/// </summary>
/// <param name="StorageKey">
/// </param>
public sealed record GetStorageKeyForFrameResult(SerializedStorageKey StorageKey) : EmptyResult;


internal sealed record GetStorageKeyCommandParameters(Page.FrameId? FrameId) : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.GetStorageKeyAsync"/> command.
/// </summary>
/// <param name="StorageKey">
/// </param>
public sealed record GetStorageKeyResult(SerializedStorageKey StorageKey) : EmptyResult;


internal sealed record ClearDataForOriginCommandParameters(string Origin, string StorageTypes) : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.ClearDataForOriginAsync"/> command.
/// </summary>
public sealed record ClearDataForOriginResult() : EmptyResult;


internal sealed record ClearDataForStorageKeyCommandParameters(string StorageKey, string StorageTypes) : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.ClearDataForStorageKeyAsync"/> command.
/// </summary>
public sealed record ClearDataForStorageKeyResult() : EmptyResult;


internal sealed record GetCookiesCommandParameters(Browser.BrowserContextID? BrowserContextId) : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.GetCookiesAsync"/> command.
/// </summary>
/// <param name="Cookies">
/// Array of cookie objects.
/// </param>
public sealed record GetCookiesResult(ImmutableArray<Network.Cookie> Cookies) : EmptyResult;


internal sealed record SetCookiesCommandParameters(ImmutableArray<Network.CookieParam> Cookies, Browser.BrowserContextID? BrowserContextId) : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.SetCookiesAsync"/> command.
/// </summary>
public sealed record SetCookiesResult() : EmptyResult;


internal sealed record ClearCookiesCommandParameters(Browser.BrowserContextID? BrowserContextId) : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.ClearCookiesAsync"/> command.
/// </summary>
public sealed record ClearCookiesResult() : EmptyResult;


internal sealed record GetUsageAndQuotaCommandParameters(string Origin) : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.GetUsageAndQuotaAsync"/> command.
/// </summary>
/// <param name="Usage">
/// Storage usage (bytes).
/// </param>
/// <param name="Quota">
/// Storage quota (bytes).
/// </param>
/// <param name="OverrideActive">
/// Whether or not the origin has an active storage quota override
/// </param>
/// <param name="UsageBreakdown">
/// Storage usage per type (bytes).
/// </param>
public sealed record GetUsageAndQuotaResult(double Usage, double Quota, bool OverrideActive, ImmutableArray<UsageForType> UsageBreakdown) : EmptyResult;


internal sealed record OverrideQuotaForOriginCommandParameters(string Origin, double? QuotaSize) : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.OverrideQuotaForOriginAsync"/> command.
/// </summary>
public sealed record OverrideQuotaForOriginResult() : EmptyResult;


internal sealed record TrackCacheStorageForOriginCommandParameters(string Origin) : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.TrackCacheStorageForOriginAsync"/> command.
/// </summary>
public sealed record TrackCacheStorageForOriginResult() : EmptyResult;


internal sealed record TrackCacheStorageForStorageKeyCommandParameters(string StorageKey) : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.TrackCacheStorageForStorageKeyAsync"/> command.
/// </summary>
public sealed record TrackCacheStorageForStorageKeyResult() : EmptyResult;


internal sealed record TrackIndexedDBForOriginCommandParameters(string Origin) : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.TrackIndexedDBForOriginAsync"/> command.
/// </summary>
public sealed record TrackIndexedDBForOriginResult() : EmptyResult;


internal sealed record TrackIndexedDBForStorageKeyCommandParameters(string StorageKey) : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.TrackIndexedDBForStorageKeyAsync"/> command.
/// </summary>
public sealed record TrackIndexedDBForStorageKeyResult() : EmptyResult;


internal sealed record UntrackCacheStorageForOriginCommandParameters(string Origin) : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.UntrackCacheStorageForOriginAsync"/> command.
/// </summary>
public sealed record UntrackCacheStorageForOriginResult() : EmptyResult;


internal sealed record UntrackCacheStorageForStorageKeyCommandParameters(string StorageKey) : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.UntrackCacheStorageForStorageKeyAsync"/> command.
/// </summary>
public sealed record UntrackCacheStorageForStorageKeyResult() : EmptyResult;


internal sealed record UntrackIndexedDBForOriginCommandParameters(string Origin) : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.UntrackIndexedDBForOriginAsync"/> command.
/// </summary>
public sealed record UntrackIndexedDBForOriginResult() : EmptyResult;


internal sealed record UntrackIndexedDBForStorageKeyCommandParameters(string StorageKey) : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.UntrackIndexedDBForStorageKeyAsync"/> command.
/// </summary>
public sealed record UntrackIndexedDBForStorageKeyResult() : EmptyResult;


internal sealed record GetTrustTokensCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.GetTrustTokensAsync"/> command.
/// </summary>
/// <param name="Tokens">
/// </param>
public sealed record GetTrustTokensResult(ImmutableArray<TrustTokens> Tokens) : EmptyResult;


internal sealed record ClearTrustTokensCommandParameters(string IssuerOrigin) : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.ClearTrustTokensAsync"/> command.
/// </summary>
/// <param name="DidDeleteTokens">
/// True if any tokens were deleted, false otherwise.
/// </param>
public sealed record ClearTrustTokensResult(bool DidDeleteTokens) : EmptyResult;


internal sealed record GetPrivateVerificationTokensCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.GetPrivateVerificationTokensAsync"/> command.
/// </summary>
/// <param name="Tokens">
/// </param>
public sealed record GetPrivateVerificationTokensResult(ImmutableArray<PrivateVerificationToken> Tokens) : EmptyResult;


internal sealed record GetPrivateVerificationTokensIssuerConfigsCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.GetPrivateVerificationTokensIssuerConfigsAsync"/> command.
/// </summary>
/// <param name="Configs">
/// </param>
public sealed record GetPrivateVerificationTokensIssuerConfigsResult(ImmutableArray<PrivateVerificationTokensIssuerConfig> Configs) : EmptyResult;


internal sealed record ClearPrivateVerificationTokensCommandParameters(string IssuerOrigin) : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.ClearPrivateVerificationTokensAsync"/> command.
/// </summary>
public sealed record ClearPrivateVerificationTokensResult() : EmptyResult;


internal sealed record DeletePrivateVerificationTokenCommandParameters(string TokenId) : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.DeletePrivateVerificationTokenAsync"/> command.
/// </summary>
public sealed record DeletePrivateVerificationTokenResult() : EmptyResult;


internal sealed record SetPrivateVerificationTokensTrackingCommandParameters(bool Enable) : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.SetPrivateVerificationTokensTrackingAsync"/> command.
/// </summary>
public sealed record SetPrivateVerificationTokensTrackingResult() : EmptyResult;


internal sealed record SetStorageBucketTrackingCommandParameters(string StorageKey, bool Enable) : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.SetStorageBucketTrackingAsync"/> command.
/// </summary>
public sealed record SetStorageBucketTrackingResult() : EmptyResult;


internal sealed record DeleteStorageBucketCommandParameters(StorageBucket Bucket) : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.DeleteStorageBucketAsync"/> command.
/// </summary>
public sealed record DeleteStorageBucketResult() : EmptyResult;


internal sealed record RunBounceTrackingMitigationsCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IStorage.RunBounceTrackingMitigationsAsync"/> command.
/// </summary>
/// <param name="DeletedSites">
/// </param>
public sealed record RunBounceTrackingMitigationsResult(ImmutableArray<string> DeletedSites) : EmptyResult;


/// <summary>
/// A cache's contents have been modified.
/// </summary>
/// <param name="Origin">
/// Origin to update.
/// </param>
/// <param name="StorageKey">
/// Storage key to update.
/// </param>
/// <param name="BucketId">
/// Storage bucket to update.
/// </param>
/// <param name="CacheName">
/// Name of cache in origin.
/// </param>
public sealed record CacheStorageContentUpdatedEventArgs(string Origin, string StorageKey, string BucketId, string CacheName) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// A cache has been added/deleted.
/// </summary>
/// <param name="Origin">
/// Origin to update.
/// </param>
/// <param name="StorageKey">
/// Storage key to update.
/// </param>
/// <param name="BucketId">
/// Storage bucket to update.
/// </param>
public sealed record CacheStorageListUpdatedEventArgs(string Origin, string StorageKey, string BucketId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// The origin's IndexedDB object store has been modified.
/// </summary>
/// <param name="Origin">
/// Origin to update.
/// </param>
/// <param name="StorageKey">
/// Storage key to update.
/// </param>
/// <param name="BucketId">
/// Storage bucket to update.
/// </param>
/// <param name="DatabaseName">
/// Database to update.
/// </param>
/// <param name="ObjectStoreName">
/// ObjectStore to update.
/// </param>
public sealed record IndexedDBContentUpdatedEventArgs(string Origin, string StorageKey, string BucketId, string DatabaseName, string ObjectStoreName) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// The origin's IndexedDB database list has been modified.
/// </summary>
/// <param name="Origin">
/// Origin to update.
/// </param>
/// <param name="StorageKey">
/// Storage key to update.
/// </param>
/// <param name="BucketId">
/// Storage bucket to update.
/// </param>
public sealed record IndexedDBListUpdatedEventArgs(string Origin, string StorageKey, string BucketId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
/// <param name="BucketInfo">
/// </param>
public sealed record StorageBucketCreatedOrUpdatedEventArgs(StorageBucketInfo BucketInfo) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
/// <param name="BucketId">
/// </param>
public sealed record StorageBucketDeletedEventArgs(string BucketId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Private Verification Tokens have been stored or deleted.
/// </summary>
public sealed record PrivateVerificationTokensUpdatedEventArgs() : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<SerializedStorageKey>))]
public record SerializedStorageKey : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// Enum of possible storage types.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<StorageType>))]
public enum StorageType
{
    /// <summary>
    /// Corresponds to the <c>"cookies"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("cookies")]
    Cookies,
    /// <summary>
    /// Corresponds to the <c>"file_systems"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("file_systems")]
    FileSystems,
    /// <summary>
    /// Corresponds to the <c>"indexeddb"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("indexeddb")]
    Indexeddb,
    /// <summary>
    /// Corresponds to the <c>"local_storage"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("local_storage")]
    LocalStorage,
    /// <summary>
    /// Corresponds to the <c>"shader_cache"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("shader_cache")]
    ShaderCache,
    /// <summary>
    /// Corresponds to the <c>"websql"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("websql")]
    Websql,
    /// <summary>
    /// Corresponds to the <c>"service_workers"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("service_workers")]
    ServiceWorkers,
    /// <summary>
    /// Corresponds to the <c>"cache_storage"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("cache_storage")]
    CacheStorage,
    /// <summary>
    /// Corresponds to the <c>"storage_buckets"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("storage_buckets")]
    StorageBuckets,
    /// <summary>
    /// Corresponds to the <c>"all"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("all")]
    All,
    /// <summary>
    /// Corresponds to the <c>"other"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("other")]
    Other,
}

/// <summary>
/// Usage for a storage type.
/// </summary>
/// <param name="StorageType">
/// Name of storage type.
/// </param>
/// <param name="Usage">
/// Storage usage (bytes).
/// </param>
public sealed record UsageForType(StorageType StorageType, double Usage)
{
}

/// <summary>
/// Pair of issuer origin and number of available (signed, but not used) Trust
/// Tokens from that issuer.
/// </summary>
/// <param name="IssuerOrigin">
/// </param>
/// <param name="Count">
/// </param>
public sealed record TrustTokens(string IssuerOrigin, double Count)
{
}

/// <summary>
/// Details of a stored Private Verification Token.
/// </summary>
/// <param name="Id">
/// Unique identifier of the token in the database.
/// </param>
/// <param name="IssuerOrigin">
/// Origin of the token issuer.
/// </param>
/// <param name="KeyId">
/// Public key ID used to issue the token.
/// </param>
/// <param name="Expiration">
/// Expiration timestamp in seconds since the epoch.
/// </param>
/// <param name="CreationTime">
/// Token creation timestamp in seconds since the epoch.
/// </param>
/// <param name="Version">
/// Token protocol version.
/// </param>
/// <param name="Token">
/// Base64-encoded serialized token.
/// </param>
public sealed record PrivateVerificationToken(string Id, string IssuerOrigin, long KeyId, Network.TimeSinceEpoch Expiration, Network.TimeSinceEpoch CreationTime, long Version, string Token)
{
}

/// <summary>
/// Configuration for a Private Verification Tokens issuer.
/// </summary>
/// <param name="IssuerOrigin">
/// Origin of the token issuer.
/// </param>
/// <param name="RedeemerOrigins">
/// Origins authorized to redeem tokens from this issuer.
/// </param>
public sealed record PrivateVerificationTokensIssuerConfig(string IssuerOrigin, ImmutableArray<string> RedeemerOrigins)
{
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<StorageBucketsDurability>))]
public enum StorageBucketsDurability
{
    /// <summary>
    /// Corresponds to the <c>"relaxed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("relaxed")]
    Relaxed,
    /// <summary>
    /// Corresponds to the <c>"strict"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("strict")]
    Strict,
}

/// <summary>
/// </summary>
/// <param name="StorageKey">
/// </param>
public sealed record StorageBucket(SerializedStorageKey StorageKey)
{
    /// <summary>
    /// If not specified, it is the default bucket of the storageKey.
    /// </summary>
    public string? Name { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Bucket">
/// </param>
/// <param name="Id">
/// </param>
/// <param name="Expiration">
/// </param>
/// <param name="Quota">
/// Storage quota (bytes).
/// </param>
/// <param name="Persistent">
/// </param>
/// <param name="Durability">
/// </param>
public sealed record StorageBucketInfo(StorageBucket Bucket, string Id, Network.TimeSinceEpoch Expiration, double Quota, bool Persistent, StorageBucketsDurability Durability)
{
}

[JsonSerializable(typeof(GetStorageKeyForFrameCommandParameters), TypeInfoPropertyName = "GetStorageKeyForFrameCommandParameters")]
[JsonSerializable(typeof(GetStorageKeyForFrameResult), TypeInfoPropertyName = "GetStorageKeyForFrameResult")]
[JsonSerializable(typeof(GetStorageKeyCommandParameters), TypeInfoPropertyName = "GetStorageKeyCommandParameters")]
[JsonSerializable(typeof(GetStorageKeyResult), TypeInfoPropertyName = "GetStorageKeyResult")]
[JsonSerializable(typeof(ClearDataForOriginCommandParameters), TypeInfoPropertyName = "ClearDataForOriginCommandParameters")]
[JsonSerializable(typeof(ClearDataForOriginResult), TypeInfoPropertyName = "ClearDataForOriginResult")]
[JsonSerializable(typeof(ClearDataForStorageKeyCommandParameters), TypeInfoPropertyName = "ClearDataForStorageKeyCommandParameters")]
[JsonSerializable(typeof(ClearDataForStorageKeyResult), TypeInfoPropertyName = "ClearDataForStorageKeyResult")]
[JsonSerializable(typeof(GetCookiesCommandParameters), TypeInfoPropertyName = "GetCookiesCommandParameters")]
[JsonSerializable(typeof(GetCookiesResult), TypeInfoPropertyName = "GetCookiesResult")]
[JsonSerializable(typeof(SetCookiesCommandParameters), TypeInfoPropertyName = "SetCookiesCommandParameters")]
[JsonSerializable(typeof(SetCookiesResult), TypeInfoPropertyName = "SetCookiesResult")]
[JsonSerializable(typeof(ClearCookiesCommandParameters), TypeInfoPropertyName = "ClearCookiesCommandParameters")]
[JsonSerializable(typeof(ClearCookiesResult), TypeInfoPropertyName = "ClearCookiesResult")]
[JsonSerializable(typeof(GetUsageAndQuotaCommandParameters), TypeInfoPropertyName = "GetUsageAndQuotaCommandParameters")]
[JsonSerializable(typeof(GetUsageAndQuotaResult), TypeInfoPropertyName = "GetUsageAndQuotaResult")]
[JsonSerializable(typeof(OverrideQuotaForOriginCommandParameters), TypeInfoPropertyName = "OverrideQuotaForOriginCommandParameters")]
[JsonSerializable(typeof(OverrideQuotaForOriginResult), TypeInfoPropertyName = "OverrideQuotaForOriginResult")]
[JsonSerializable(typeof(TrackCacheStorageForOriginCommandParameters), TypeInfoPropertyName = "TrackCacheStorageForOriginCommandParameters")]
[JsonSerializable(typeof(TrackCacheStorageForOriginResult), TypeInfoPropertyName = "TrackCacheStorageForOriginResult")]
[JsonSerializable(typeof(TrackCacheStorageForStorageKeyCommandParameters), TypeInfoPropertyName = "TrackCacheStorageForStorageKeyCommandParameters")]
[JsonSerializable(typeof(TrackCacheStorageForStorageKeyResult), TypeInfoPropertyName = "TrackCacheStorageForStorageKeyResult")]
[JsonSerializable(typeof(TrackIndexedDBForOriginCommandParameters), TypeInfoPropertyName = "TrackIndexedDBForOriginCommandParameters")]
[JsonSerializable(typeof(TrackIndexedDBForOriginResult), TypeInfoPropertyName = "TrackIndexedDBForOriginResult")]
[JsonSerializable(typeof(TrackIndexedDBForStorageKeyCommandParameters), TypeInfoPropertyName = "TrackIndexedDBForStorageKeyCommandParameters")]
[JsonSerializable(typeof(TrackIndexedDBForStorageKeyResult), TypeInfoPropertyName = "TrackIndexedDBForStorageKeyResult")]
[JsonSerializable(typeof(UntrackCacheStorageForOriginCommandParameters), TypeInfoPropertyName = "UntrackCacheStorageForOriginCommandParameters")]
[JsonSerializable(typeof(UntrackCacheStorageForOriginResult), TypeInfoPropertyName = "UntrackCacheStorageForOriginResult")]
[JsonSerializable(typeof(UntrackCacheStorageForStorageKeyCommandParameters), TypeInfoPropertyName = "UntrackCacheStorageForStorageKeyCommandParameters")]
[JsonSerializable(typeof(UntrackCacheStorageForStorageKeyResult), TypeInfoPropertyName = "UntrackCacheStorageForStorageKeyResult")]
[JsonSerializable(typeof(UntrackIndexedDBForOriginCommandParameters), TypeInfoPropertyName = "UntrackIndexedDBForOriginCommandParameters")]
[JsonSerializable(typeof(UntrackIndexedDBForOriginResult), TypeInfoPropertyName = "UntrackIndexedDBForOriginResult")]
[JsonSerializable(typeof(UntrackIndexedDBForStorageKeyCommandParameters), TypeInfoPropertyName = "UntrackIndexedDBForStorageKeyCommandParameters")]
[JsonSerializable(typeof(UntrackIndexedDBForStorageKeyResult), TypeInfoPropertyName = "UntrackIndexedDBForStorageKeyResult")]
[JsonSerializable(typeof(GetTrustTokensCommandParameters), TypeInfoPropertyName = "GetTrustTokensCommandParameters")]
[JsonSerializable(typeof(GetTrustTokensResult), TypeInfoPropertyName = "GetTrustTokensResult")]
[JsonSerializable(typeof(ClearTrustTokensCommandParameters), TypeInfoPropertyName = "ClearTrustTokensCommandParameters")]
[JsonSerializable(typeof(ClearTrustTokensResult), TypeInfoPropertyName = "ClearTrustTokensResult")]
[JsonSerializable(typeof(GetPrivateVerificationTokensCommandParameters), TypeInfoPropertyName = "GetPrivateVerificationTokensCommandParameters")]
[JsonSerializable(typeof(GetPrivateVerificationTokensResult), TypeInfoPropertyName = "GetPrivateVerificationTokensResult")]
[JsonSerializable(typeof(GetPrivateVerificationTokensIssuerConfigsCommandParameters), TypeInfoPropertyName = "GetPrivateVerificationTokensIssuerConfigsCommandParameters")]
[JsonSerializable(typeof(GetPrivateVerificationTokensIssuerConfigsResult), TypeInfoPropertyName = "GetPrivateVerificationTokensIssuerConfigsResult")]
[JsonSerializable(typeof(ClearPrivateVerificationTokensCommandParameters), TypeInfoPropertyName = "ClearPrivateVerificationTokensCommandParameters")]
[JsonSerializable(typeof(ClearPrivateVerificationTokensResult), TypeInfoPropertyName = "ClearPrivateVerificationTokensResult")]
[JsonSerializable(typeof(DeletePrivateVerificationTokenCommandParameters), TypeInfoPropertyName = "DeletePrivateVerificationTokenCommandParameters")]
[JsonSerializable(typeof(DeletePrivateVerificationTokenResult), TypeInfoPropertyName = "DeletePrivateVerificationTokenResult")]
[JsonSerializable(typeof(SetPrivateVerificationTokensTrackingCommandParameters), TypeInfoPropertyName = "SetPrivateVerificationTokensTrackingCommandParameters")]
[JsonSerializable(typeof(SetPrivateVerificationTokensTrackingResult), TypeInfoPropertyName = "SetPrivateVerificationTokensTrackingResult")]
[JsonSerializable(typeof(SetStorageBucketTrackingCommandParameters), TypeInfoPropertyName = "SetStorageBucketTrackingCommandParameters")]
[JsonSerializable(typeof(SetStorageBucketTrackingResult), TypeInfoPropertyName = "SetStorageBucketTrackingResult")]
[JsonSerializable(typeof(DeleteStorageBucketCommandParameters), TypeInfoPropertyName = "DeleteStorageBucketCommandParameters")]
[JsonSerializable(typeof(DeleteStorageBucketResult), TypeInfoPropertyName = "DeleteStorageBucketResult")]
[JsonSerializable(typeof(RunBounceTrackingMitigationsCommandParameters), TypeInfoPropertyName = "RunBounceTrackingMitigationsCommandParameters")]
[JsonSerializable(typeof(RunBounceTrackingMitigationsResult), TypeInfoPropertyName = "RunBounceTrackingMitigationsResult")]
[JsonSerializable(typeof(CdpEventArgs<CacheStorageContentUpdatedEventArgs>), TypeInfoPropertyName = "CacheStorageContentUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<CacheStorageListUpdatedEventArgs>), TypeInfoPropertyName = "CacheStorageListUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<IndexedDBContentUpdatedEventArgs>), TypeInfoPropertyName = "IndexedDBContentUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<IndexedDBListUpdatedEventArgs>), TypeInfoPropertyName = "IndexedDBListUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<StorageBucketCreatedOrUpdatedEventArgs>), TypeInfoPropertyName = "StorageBucketCreatedOrUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<StorageBucketDeletedEventArgs>), TypeInfoPropertyName = "StorageBucketDeletedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<PrivateVerificationTokensUpdatedEventArgs>), TypeInfoPropertyName = "PrivateVerificationTokensUpdatedCdpEventArgs")]
[JsonSerializable(typeof(SerializedStorageKey), TypeInfoPropertyName = "StorageSerializedStorageKey")]
[JsonSerializable(typeof(StorageType), TypeInfoPropertyName = "StorageStorageType")]
[JsonSerializable(typeof(UsageForType), TypeInfoPropertyName = "StorageUsageForType")]
[JsonSerializable(typeof(TrustTokens), TypeInfoPropertyName = "StorageTrustTokens")]
[JsonSerializable(typeof(PrivateVerificationToken), TypeInfoPropertyName = "StoragePrivateVerificationToken")]
[JsonSerializable(typeof(PrivateVerificationTokensIssuerConfig), TypeInfoPropertyName = "StoragePrivateVerificationTokensIssuerConfig")]
[JsonSerializable(typeof(StorageBucketsDurability), TypeInfoPropertyName = "StorageStorageBucketsDurability")]
[JsonSerializable(typeof(StorageBucket), TypeInfoPropertyName = "StorageStorageBucket")]
[JsonSerializable(typeof(StorageBucketInfo), TypeInfoPropertyName = "StorageStorageBucketInfo")]
[JsonSerializable(typeof(ImmutableArray<Network.Cookie>), TypeInfoPropertyName = "ImmutableArrayNetworkCookie")]
[JsonSerializable(typeof(ImmutableArray<Network.CookieParam>), TypeInfoPropertyName = "ImmutableArrayNetworkCookieParam")]
[JsonSerializable(typeof(ImmutableArray<UsageForType>), TypeInfoPropertyName = "ImmutableArrayStorageUsageForType")]
[JsonSerializable(typeof(ImmutableArray<TrustTokens>), TypeInfoPropertyName = "ImmutableArrayStorageTrustTokens")]
[JsonSerializable(typeof(ImmutableArray<PrivateVerificationToken>), TypeInfoPropertyName = "ImmutableArrayStoragePrivateVerificationToken")]
[JsonSerializable(typeof(ImmutableArray<PrivateVerificationTokensIssuerConfig>), TypeInfoPropertyName = "ImmutableArrayStoragePrivateVerificationTokensIssuerConfig")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class StorageJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="IStorage"/>.
/// </summary>
public static class StorageDomainEvent
{
    /// <summary>
    /// A cache's contents have been modified.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<CacheStorageContentUpdatedEventArgs>> CacheStorageContentUpdated =>
        _cacheStorageContentUpdated ?? global::System.Threading.Interlocked.CompareExchange(ref _cacheStorageContentUpdated, EventDescriptor<CdpEventArgs<CacheStorageContentUpdatedEventArgs>>.Create(
            "goog:cdp.Storage.cacheStorageContentUpdated",
            StorageJsonSerializerContext.Default.CacheStorageContentUpdatedCdpEventArgs), null) ?? _cacheStorageContentUpdated;
    private static EventDescriptor<CdpEventArgs<CacheStorageContentUpdatedEventArgs>>? _cacheStorageContentUpdated;

    /// <summary>
    /// A cache has been added/deleted.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<CacheStorageListUpdatedEventArgs>> CacheStorageListUpdated =>
        _cacheStorageListUpdated ?? global::System.Threading.Interlocked.CompareExchange(ref _cacheStorageListUpdated, EventDescriptor<CdpEventArgs<CacheStorageListUpdatedEventArgs>>.Create(
            "goog:cdp.Storage.cacheStorageListUpdated",
            StorageJsonSerializerContext.Default.CacheStorageListUpdatedCdpEventArgs), null) ?? _cacheStorageListUpdated;
    private static EventDescriptor<CdpEventArgs<CacheStorageListUpdatedEventArgs>>? _cacheStorageListUpdated;

    /// <summary>
    /// The origin's IndexedDB object store has been modified.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<IndexedDBContentUpdatedEventArgs>> IndexedDBContentUpdated =>
        _indexedDBContentUpdated ?? global::System.Threading.Interlocked.CompareExchange(ref _indexedDBContentUpdated, EventDescriptor<CdpEventArgs<IndexedDBContentUpdatedEventArgs>>.Create(
            "goog:cdp.Storage.indexedDBContentUpdated",
            StorageJsonSerializerContext.Default.IndexedDBContentUpdatedCdpEventArgs), null) ?? _indexedDBContentUpdated;
    private static EventDescriptor<CdpEventArgs<IndexedDBContentUpdatedEventArgs>>? _indexedDBContentUpdated;

    /// <summary>
    /// The origin's IndexedDB database list has been modified.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<IndexedDBListUpdatedEventArgs>> IndexedDBListUpdated =>
        _indexedDBListUpdated ?? global::System.Threading.Interlocked.CompareExchange(ref _indexedDBListUpdated, EventDescriptor<CdpEventArgs<IndexedDBListUpdatedEventArgs>>.Create(
            "goog:cdp.Storage.indexedDBListUpdated",
            StorageJsonSerializerContext.Default.IndexedDBListUpdatedCdpEventArgs), null) ?? _indexedDBListUpdated;
    private static EventDescriptor<CdpEventArgs<IndexedDBListUpdatedEventArgs>>? _indexedDBListUpdated;

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<StorageBucketCreatedOrUpdatedEventArgs>> StorageBucketCreatedOrUpdated =>
        _storageBucketCreatedOrUpdated ?? global::System.Threading.Interlocked.CompareExchange(ref _storageBucketCreatedOrUpdated, EventDescriptor<CdpEventArgs<StorageBucketCreatedOrUpdatedEventArgs>>.Create(
            "goog:cdp.Storage.storageBucketCreatedOrUpdated",
            StorageJsonSerializerContext.Default.StorageBucketCreatedOrUpdatedCdpEventArgs), null) ?? _storageBucketCreatedOrUpdated;
    private static EventDescriptor<CdpEventArgs<StorageBucketCreatedOrUpdatedEventArgs>>? _storageBucketCreatedOrUpdated;

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<StorageBucketDeletedEventArgs>> StorageBucketDeleted =>
        _storageBucketDeleted ?? global::System.Threading.Interlocked.CompareExchange(ref _storageBucketDeleted, EventDescriptor<CdpEventArgs<StorageBucketDeletedEventArgs>>.Create(
            "goog:cdp.Storage.storageBucketDeleted",
            StorageJsonSerializerContext.Default.StorageBucketDeletedCdpEventArgs), null) ?? _storageBucketDeleted;
    private static EventDescriptor<CdpEventArgs<StorageBucketDeletedEventArgs>>? _storageBucketDeleted;

    /// <summary>
    /// Private Verification Tokens have been stored or deleted.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<PrivateVerificationTokensUpdatedEventArgs>> PrivateVerificationTokensUpdated =>
        _privateVerificationTokensUpdated ?? global::System.Threading.Interlocked.CompareExchange(ref _privateVerificationTokensUpdated, EventDescriptor<CdpEventArgs<PrivateVerificationTokensUpdatedEventArgs>>.Create(
            "goog:cdp.Storage.privateVerificationTokensUpdated",
            StorageJsonSerializerContext.Default.PrivateVerificationTokensUpdatedCdpEventArgs), null) ?? _privateVerificationTokensUpdated;
    private static EventDescriptor<CdpEventArgs<PrivateVerificationTokensUpdatedEventArgs>>? _privateVerificationTokensUpdated;

}
