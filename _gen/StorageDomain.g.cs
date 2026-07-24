#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Storage;

/// <summary>
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class StorageDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static StorageJsonSerializerContext JsonContext = StorageJsonSerializerContext.Default;

    /// <summary>
    /// Returns a storage key given a frame id.
    /// Deprecated. Please use Storage.getStorageKey instead.
    /// </summary>
    /// <param name="frameId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetStorageKeyForFrameCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetStorageKeyForFrameResult"/>.
    /// </returns>
    [global::System.Obsolete]
    public async Task<GetStorageKeyForFrameResult> GetStorageKeyForFrameAsync(Page.FrameId frameId, GetStorageKeyForFrameCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetStorageKeyForFrameCommandParameters(FrameId: frameId);
        return await ExecuteCommandAsync(GetStorageKeyForFrameCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetStorageKeyForFrameCommandParameters, GetStorageKeyForFrameResult> GetStorageKeyForFrameCommand = new("Storage.getStorageKeyForFrame", JsonContext.GetStorageKeyForFrameCommandParameters, JsonContext.GetStorageKeyForFrameResult);

    /// <summary>
    /// Returns storage key for the given frame. If no frame ID is provided,
    /// the storage key of the target executing this command is returned.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>FrameId</b></description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetStorageKeyCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetStorageKeyResult"/>.
    /// </returns>
    public async Task<GetStorageKeyResult> GetStorageKeyAsync(GetStorageKeyCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetStorageKeyCommandParameters(FrameId: options?.FrameId);
        return await ExecuteCommandAsync(GetStorageKeyCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetStorageKeyCommandParameters, GetStorageKeyResult> GetStorageKeyCommand = new("Storage.getStorageKey", JsonContext.GetStorageKeyCommandParameters, JsonContext.GetStorageKeyResult);

    /// <summary>
    /// Clears storage for origin.
    /// </summary>
    /// <param name="origin">
    /// Security origin.
    /// </param>
    /// <param name="storageTypes">
    /// Comma separated list of StorageType to clear.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ClearDataForOriginCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearDataForOriginResult"/>.
    /// </returns>
    public async Task<ClearDataForOriginResult> ClearDataForOriginAsync(string origin, string storageTypes, ClearDataForOriginCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearDataForOriginCommandParameters(Origin: origin, StorageTypes: storageTypes);
        return await ExecuteCommandAsync(ClearDataForOriginCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearDataForOriginCommandParameters, ClearDataForOriginResult> ClearDataForOriginCommand = new("Storage.clearDataForOrigin", JsonContext.ClearDataForOriginCommandParameters, JsonContext.ClearDataForOriginResult);

    /// <summary>
    /// Clears storage for storage key.
    /// </summary>
    /// <param name="storageKey">
    /// Storage key.
    /// </param>
    /// <param name="storageTypes">
    /// Comma separated list of StorageType to clear.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ClearDataForStorageKeyCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearDataForStorageKeyResult"/>.
    /// </returns>
    public async Task<ClearDataForStorageKeyResult> ClearDataForStorageKeyAsync(string storageKey, string storageTypes, ClearDataForStorageKeyCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearDataForStorageKeyCommandParameters(StorageKey: storageKey, StorageTypes: storageTypes);
        return await ExecuteCommandAsync(ClearDataForStorageKeyCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearDataForStorageKeyCommandParameters, ClearDataForStorageKeyResult> ClearDataForStorageKeyCommand = new("Storage.clearDataForStorageKey", JsonContext.ClearDataForStorageKeyCommandParameters, JsonContext.ClearDataForStorageKeyResult);

    /// <summary>
    /// Returns all browser cookies.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>BrowserContextId</b> - Browser context to use when called on the browser endpoint.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetCookiesCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetCookiesResult"/>.
    /// </returns>
    public async Task<GetCookiesResult> GetCookiesAsync(GetCookiesCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetCookiesCommandParameters(BrowserContextId: options?.BrowserContextId);
        return await ExecuteCommandAsync(GetCookiesCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetCookiesCommandParameters, GetCookiesResult> GetCookiesCommand = new("Storage.getCookies", JsonContext.GetCookiesCommandParameters, JsonContext.GetCookiesResult);

    /// <summary>
    /// Sets given cookies.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>BrowserContextId</b> - Browser context to use when called on the browser endpoint.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="cookies">
    /// Cookies to be set.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetCookiesCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetCookiesResult"/>.
    /// </returns>
    public async Task<SetCookiesResult> SetCookiesAsync(ImmutableArray<Network.CookieParam> cookies, SetCookiesCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetCookiesCommandParameters(Cookies: cookies, BrowserContextId: options?.BrowserContextId);
        return await ExecuteCommandAsync(SetCookiesCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetCookiesCommandParameters, SetCookiesResult> SetCookiesCommand = new("Storage.setCookies", JsonContext.SetCookiesCommandParameters, JsonContext.SetCookiesResult);

    /// <summary>
    /// Clears cookies.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>BrowserContextId</b> - Browser context to use when called on the browser endpoint.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="ClearCookiesCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearCookiesResult"/>.
    /// </returns>
    public async Task<ClearCookiesResult> ClearCookiesAsync(ClearCookiesCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearCookiesCommandParameters(BrowserContextId: options?.BrowserContextId);
        return await ExecuteCommandAsync(ClearCookiesCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearCookiesCommandParameters, ClearCookiesResult> ClearCookiesCommand = new("Storage.clearCookies", JsonContext.ClearCookiesCommandParameters, JsonContext.ClearCookiesResult);

    /// <summary>
    /// Returns usage and quota in bytes.
    /// </summary>
    /// <param name="origin">
    /// Security origin.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetUsageAndQuotaCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetUsageAndQuotaResult"/>.
    /// </returns>
    public async Task<GetUsageAndQuotaResult> GetUsageAndQuotaAsync(string origin, GetUsageAndQuotaCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetUsageAndQuotaCommandParameters(Origin: origin);
        return await ExecuteCommandAsync(GetUsageAndQuotaCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetUsageAndQuotaCommandParameters, GetUsageAndQuotaResult> GetUsageAndQuotaCommand = new("Storage.getUsageAndQuota", JsonContext.GetUsageAndQuotaCommandParameters, JsonContext.GetUsageAndQuotaResult);

    /// <summary>
    /// Override quota for the specified origin
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>QuotaSize</b> - The quota size (in bytes) to override the original quota with. If this is called multiple times, the overridden quota will be equal to the quotaSize provided in the final call. If this is called without specifying a quotaSize, the quota will be reset to the default value for the specified origin. If this is called multiple times with different origins, the override will be maintained for each origin until it is disabled (called without a quotaSize).</description></item>
    /// </list>
    /// </remarks>
    /// <param name="origin">
    /// Security origin.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="OverrideQuotaForOriginCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="OverrideQuotaForOriginResult"/>.
    /// </returns>
    public async Task<OverrideQuotaForOriginResult> OverrideQuotaForOriginAsync(string origin, OverrideQuotaForOriginCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new OverrideQuotaForOriginCommandParameters(Origin: origin, QuotaSize: options?.QuotaSize);
        return await ExecuteCommandAsync(OverrideQuotaForOriginCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<OverrideQuotaForOriginCommandParameters, OverrideQuotaForOriginResult> OverrideQuotaForOriginCommand = new("Storage.overrideQuotaForOrigin", JsonContext.OverrideQuotaForOriginCommandParameters, JsonContext.OverrideQuotaForOriginResult);

    /// <summary>
    /// Registers origin to be notified when an update occurs to its cache storage list.
    /// </summary>
    /// <param name="origin">
    /// Security origin.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="TrackCacheStorageForOriginCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="TrackCacheStorageForOriginResult"/>.
    /// </returns>
    public async Task<TrackCacheStorageForOriginResult> TrackCacheStorageForOriginAsync(string origin, TrackCacheStorageForOriginCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new TrackCacheStorageForOriginCommandParameters(Origin: origin);
        return await ExecuteCommandAsync(TrackCacheStorageForOriginCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<TrackCacheStorageForOriginCommandParameters, TrackCacheStorageForOriginResult> TrackCacheStorageForOriginCommand = new("Storage.trackCacheStorageForOrigin", JsonContext.TrackCacheStorageForOriginCommandParameters, JsonContext.TrackCacheStorageForOriginResult);

    /// <summary>
    /// Registers storage key to be notified when an update occurs to its cache storage list.
    /// </summary>
    /// <param name="storageKey">
    /// Storage key.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="TrackCacheStorageForStorageKeyCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="TrackCacheStorageForStorageKeyResult"/>.
    /// </returns>
    public async Task<TrackCacheStorageForStorageKeyResult> TrackCacheStorageForStorageKeyAsync(string storageKey, TrackCacheStorageForStorageKeyCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new TrackCacheStorageForStorageKeyCommandParameters(StorageKey: storageKey);
        return await ExecuteCommandAsync(TrackCacheStorageForStorageKeyCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<TrackCacheStorageForStorageKeyCommandParameters, TrackCacheStorageForStorageKeyResult> TrackCacheStorageForStorageKeyCommand = new("Storage.trackCacheStorageForStorageKey", JsonContext.TrackCacheStorageForStorageKeyCommandParameters, JsonContext.TrackCacheStorageForStorageKeyResult);

    /// <summary>
    /// Registers origin to be notified when an update occurs to its IndexedDB.
    /// </summary>
    /// <param name="origin">
    /// Security origin.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="TrackIndexedDBForOriginCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="TrackIndexedDBForOriginResult"/>.
    /// </returns>
    public async Task<TrackIndexedDBForOriginResult> TrackIndexedDBForOriginAsync(string origin, TrackIndexedDBForOriginCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new TrackIndexedDBForOriginCommandParameters(Origin: origin);
        return await ExecuteCommandAsync(TrackIndexedDBForOriginCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<TrackIndexedDBForOriginCommandParameters, TrackIndexedDBForOriginResult> TrackIndexedDBForOriginCommand = new("Storage.trackIndexedDBForOrigin", JsonContext.TrackIndexedDBForOriginCommandParameters, JsonContext.TrackIndexedDBForOriginResult);

    /// <summary>
    /// Registers storage key to be notified when an update occurs to its IndexedDB.
    /// </summary>
    /// <param name="storageKey">
    /// Storage key.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="TrackIndexedDBForStorageKeyCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="TrackIndexedDBForStorageKeyResult"/>.
    /// </returns>
    public async Task<TrackIndexedDBForStorageKeyResult> TrackIndexedDBForStorageKeyAsync(string storageKey, TrackIndexedDBForStorageKeyCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new TrackIndexedDBForStorageKeyCommandParameters(StorageKey: storageKey);
        return await ExecuteCommandAsync(TrackIndexedDBForStorageKeyCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<TrackIndexedDBForStorageKeyCommandParameters, TrackIndexedDBForStorageKeyResult> TrackIndexedDBForStorageKeyCommand = new("Storage.trackIndexedDBForStorageKey", JsonContext.TrackIndexedDBForStorageKeyCommandParameters, JsonContext.TrackIndexedDBForStorageKeyResult);

    /// <summary>
    /// Unregisters origin from receiving notifications for cache storage.
    /// </summary>
    /// <param name="origin">
    /// Security origin.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="UntrackCacheStorageForOriginCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="UntrackCacheStorageForOriginResult"/>.
    /// </returns>
    public async Task<UntrackCacheStorageForOriginResult> UntrackCacheStorageForOriginAsync(string origin, UntrackCacheStorageForOriginCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new UntrackCacheStorageForOriginCommandParameters(Origin: origin);
        return await ExecuteCommandAsync(UntrackCacheStorageForOriginCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<UntrackCacheStorageForOriginCommandParameters, UntrackCacheStorageForOriginResult> UntrackCacheStorageForOriginCommand = new("Storage.untrackCacheStorageForOrigin", JsonContext.UntrackCacheStorageForOriginCommandParameters, JsonContext.UntrackCacheStorageForOriginResult);

    /// <summary>
    /// Unregisters storage key from receiving notifications for cache storage.
    /// </summary>
    /// <param name="storageKey">
    /// Storage key.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="UntrackCacheStorageForStorageKeyCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="UntrackCacheStorageForStorageKeyResult"/>.
    /// </returns>
    public async Task<UntrackCacheStorageForStorageKeyResult> UntrackCacheStorageForStorageKeyAsync(string storageKey, UntrackCacheStorageForStorageKeyCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new UntrackCacheStorageForStorageKeyCommandParameters(StorageKey: storageKey);
        return await ExecuteCommandAsync(UntrackCacheStorageForStorageKeyCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<UntrackCacheStorageForStorageKeyCommandParameters, UntrackCacheStorageForStorageKeyResult> UntrackCacheStorageForStorageKeyCommand = new("Storage.untrackCacheStorageForStorageKey", JsonContext.UntrackCacheStorageForStorageKeyCommandParameters, JsonContext.UntrackCacheStorageForStorageKeyResult);

    /// <summary>
    /// Unregisters origin from receiving notifications for IndexedDB.
    /// </summary>
    /// <param name="origin">
    /// Security origin.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="UntrackIndexedDBForOriginCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="UntrackIndexedDBForOriginResult"/>.
    /// </returns>
    public async Task<UntrackIndexedDBForOriginResult> UntrackIndexedDBForOriginAsync(string origin, UntrackIndexedDBForOriginCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new UntrackIndexedDBForOriginCommandParameters(Origin: origin);
        return await ExecuteCommandAsync(UntrackIndexedDBForOriginCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<UntrackIndexedDBForOriginCommandParameters, UntrackIndexedDBForOriginResult> UntrackIndexedDBForOriginCommand = new("Storage.untrackIndexedDBForOrigin", JsonContext.UntrackIndexedDBForOriginCommandParameters, JsonContext.UntrackIndexedDBForOriginResult);

    /// <summary>
    /// Unregisters storage key from receiving notifications for IndexedDB.
    /// </summary>
    /// <param name="storageKey">
    /// Storage key.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="UntrackIndexedDBForStorageKeyCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="UntrackIndexedDBForStorageKeyResult"/>.
    /// </returns>
    public async Task<UntrackIndexedDBForStorageKeyResult> UntrackIndexedDBForStorageKeyAsync(string storageKey, UntrackIndexedDBForStorageKeyCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new UntrackIndexedDBForStorageKeyCommandParameters(StorageKey: storageKey);
        return await ExecuteCommandAsync(UntrackIndexedDBForStorageKeyCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<UntrackIndexedDBForStorageKeyCommandParameters, UntrackIndexedDBForStorageKeyResult> UntrackIndexedDBForStorageKeyCommand = new("Storage.untrackIndexedDBForStorageKey", JsonContext.UntrackIndexedDBForStorageKeyCommandParameters, JsonContext.UntrackIndexedDBForStorageKeyResult);

    /// <summary>
    /// Returns the number of stored Trust Tokens per issuer for the
    /// current browsing context.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetTrustTokensCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetTrustTokensResult"/>.
    /// </returns>
    public async Task<GetTrustTokensResult> GetTrustTokensAsync(GetTrustTokensCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetTrustTokensCommandParameters();
        return await ExecuteCommandAsync(GetTrustTokensCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetTrustTokensCommandParameters, GetTrustTokensResult> GetTrustTokensCommand = new("Storage.getTrustTokens", JsonContext.GetTrustTokensCommandParameters, JsonContext.GetTrustTokensResult);

    /// <summary>
    /// Removes all Trust Tokens issued by the provided issuerOrigin.
    /// Leaves other stored data, including the issuer's Redemption Records, intact.
    /// </summary>
    /// <param name="issuerOrigin">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ClearTrustTokensCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearTrustTokensResult"/>.
    /// </returns>
    public async Task<ClearTrustTokensResult> ClearTrustTokensAsync(string issuerOrigin, ClearTrustTokensCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearTrustTokensCommandParameters(IssuerOrigin: issuerOrigin);
        return await ExecuteCommandAsync(ClearTrustTokensCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearTrustTokensCommandParameters, ClearTrustTokensResult> ClearTrustTokensCommand = new("Storage.clearTrustTokens", JsonContext.ClearTrustTokensCommandParameters, JsonContext.ClearTrustTokensResult);

    /// <summary>
    /// Gets metadata for an origin's shared storage.
    /// </summary>
    /// <param name="ownerOrigin">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetSharedStorageMetadataCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetSharedStorageMetadataResult"/>.
    /// </returns>
    public async Task<GetSharedStorageMetadataResult> GetSharedStorageMetadataAsync(string ownerOrigin, GetSharedStorageMetadataCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetSharedStorageMetadataCommandParameters(OwnerOrigin: ownerOrigin);
        return await ExecuteCommandAsync(GetSharedStorageMetadataCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetSharedStorageMetadataCommandParameters, GetSharedStorageMetadataResult> GetSharedStorageMetadataCommand = new("Storage.getSharedStorageMetadata", JsonContext.GetSharedStorageMetadataCommandParameters, JsonContext.GetSharedStorageMetadataResult);

    /// <summary>
    /// Gets the entries in an given origin's shared storage.
    /// </summary>
    /// <param name="ownerOrigin">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetSharedStorageEntriesCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetSharedStorageEntriesResult"/>.
    /// </returns>
    public async Task<GetSharedStorageEntriesResult> GetSharedStorageEntriesAsync(string ownerOrigin, GetSharedStorageEntriesCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetSharedStorageEntriesCommandParameters(OwnerOrigin: ownerOrigin);
        return await ExecuteCommandAsync(GetSharedStorageEntriesCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetSharedStorageEntriesCommandParameters, GetSharedStorageEntriesResult> GetSharedStorageEntriesCommand = new("Storage.getSharedStorageEntries", JsonContext.GetSharedStorageEntriesCommandParameters, JsonContext.GetSharedStorageEntriesResult);

    /// <summary>
    /// Sets entry with <b>key</b> and <b>value</b> for a given origin's shared storage.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>IgnoreIfPresent</b> - If <b>ignoreIfPresent</b> is included and true, then only sets the entry if <b>key</b> doesn't already exist.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="ownerOrigin">
    /// </param>
    /// <param name="key">
    /// </param>
    /// <param name="value">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetSharedStorageEntryCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetSharedStorageEntryResult"/>.
    /// </returns>
    public async Task<SetSharedStorageEntryResult> SetSharedStorageEntryAsync(string ownerOrigin, string key, string value, SetSharedStorageEntryCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetSharedStorageEntryCommandParameters(OwnerOrigin: ownerOrigin, Key: key, Value: value, IgnoreIfPresent: options?.IgnoreIfPresent);
        return await ExecuteCommandAsync(SetSharedStorageEntryCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetSharedStorageEntryCommandParameters, SetSharedStorageEntryResult> SetSharedStorageEntryCommand = new("Storage.setSharedStorageEntry", JsonContext.SetSharedStorageEntryCommandParameters, JsonContext.SetSharedStorageEntryResult);

    /// <summary>
    /// Deletes entry for <b>key</b> (if it exists) for a given origin's shared storage.
    /// </summary>
    /// <param name="ownerOrigin">
    /// </param>
    /// <param name="key">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="DeleteSharedStorageEntryCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DeleteSharedStorageEntryResult"/>.
    /// </returns>
    public async Task<DeleteSharedStorageEntryResult> DeleteSharedStorageEntryAsync(string ownerOrigin, string key, DeleteSharedStorageEntryCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new DeleteSharedStorageEntryCommandParameters(OwnerOrigin: ownerOrigin, Key: key);
        return await ExecuteCommandAsync(DeleteSharedStorageEntryCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DeleteSharedStorageEntryCommandParameters, DeleteSharedStorageEntryResult> DeleteSharedStorageEntryCommand = new("Storage.deleteSharedStorageEntry", JsonContext.DeleteSharedStorageEntryCommandParameters, JsonContext.DeleteSharedStorageEntryResult);

    /// <summary>
    /// Clears all entries for a given origin's shared storage.
    /// </summary>
    /// <param name="ownerOrigin">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ClearSharedStorageEntriesCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearSharedStorageEntriesResult"/>.
    /// </returns>
    public async Task<ClearSharedStorageEntriesResult> ClearSharedStorageEntriesAsync(string ownerOrigin, ClearSharedStorageEntriesCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearSharedStorageEntriesCommandParameters(OwnerOrigin: ownerOrigin);
        return await ExecuteCommandAsync(ClearSharedStorageEntriesCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearSharedStorageEntriesCommandParameters, ClearSharedStorageEntriesResult> ClearSharedStorageEntriesCommand = new("Storage.clearSharedStorageEntries", JsonContext.ClearSharedStorageEntriesCommandParameters, JsonContext.ClearSharedStorageEntriesResult);

    /// <summary>
    /// Resets the budget for <b>ownerOrigin</b> by clearing all budget withdrawals.
    /// </summary>
    /// <param name="ownerOrigin">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ResetSharedStorageBudgetCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ResetSharedStorageBudgetResult"/>.
    /// </returns>
    public async Task<ResetSharedStorageBudgetResult> ResetSharedStorageBudgetAsync(string ownerOrigin, ResetSharedStorageBudgetCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ResetSharedStorageBudgetCommandParameters(OwnerOrigin: ownerOrigin);
        return await ExecuteCommandAsync(ResetSharedStorageBudgetCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ResetSharedStorageBudgetCommandParameters, ResetSharedStorageBudgetResult> ResetSharedStorageBudgetCommand = new("Storage.resetSharedStorageBudget", JsonContext.ResetSharedStorageBudgetCommandParameters, JsonContext.ResetSharedStorageBudgetResult);

    /// <summary>
    /// Enables/disables issuing of sharedStorageAccessed events.
    /// </summary>
    /// <param name="enable">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetSharedStorageTrackingCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetSharedStorageTrackingResult"/>.
    /// </returns>
    public async Task<SetSharedStorageTrackingResult> SetSharedStorageTrackingAsync(bool enable, SetSharedStorageTrackingCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetSharedStorageTrackingCommandParameters(Enable: enable);
        return await ExecuteCommandAsync(SetSharedStorageTrackingCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetSharedStorageTrackingCommandParameters, SetSharedStorageTrackingResult> SetSharedStorageTrackingCommand = new("Storage.setSharedStorageTracking", JsonContext.SetSharedStorageTrackingCommandParameters, JsonContext.SetSharedStorageTrackingResult);

    /// <summary>
    /// Set tracking for a storage key's buckets.
    /// </summary>
    /// <param name="storageKey">
    /// </param>
    /// <param name="enable">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="SetStorageBucketTrackingCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetStorageBucketTrackingResult"/>.
    /// </returns>
    public async Task<SetStorageBucketTrackingResult> SetStorageBucketTrackingAsync(string storageKey, bool enable, SetStorageBucketTrackingCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetStorageBucketTrackingCommandParameters(StorageKey: storageKey, Enable: enable);
        return await ExecuteCommandAsync(SetStorageBucketTrackingCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetStorageBucketTrackingCommandParameters, SetStorageBucketTrackingResult> SetStorageBucketTrackingCommand = new("Storage.setStorageBucketTracking", JsonContext.SetStorageBucketTrackingCommandParameters, JsonContext.SetStorageBucketTrackingResult);

    /// <summary>
    /// Deletes the Storage Bucket with the given storage key and bucket name.
    /// </summary>
    /// <param name="bucket">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="DeleteStorageBucketCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DeleteStorageBucketResult"/>.
    /// </returns>
    public async Task<DeleteStorageBucketResult> DeleteStorageBucketAsync(StorageBucket bucket, DeleteStorageBucketCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new DeleteStorageBucketCommandParameters(Bucket: bucket);
        return await ExecuteCommandAsync(DeleteStorageBucketCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DeleteStorageBucketCommandParameters, DeleteStorageBucketResult> DeleteStorageBucketCommand = new("Storage.deleteStorageBucket", JsonContext.DeleteStorageBucketCommandParameters, JsonContext.DeleteStorageBucketResult);

    /// <summary>
    /// Deletes state for sites identified as potential bounce trackers, immediately.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="RunBounceTrackingMitigationsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RunBounceTrackingMitigationsResult"/>.
    /// </returns>
    public async Task<RunBounceTrackingMitigationsResult> RunBounceTrackingMitigationsAsync(RunBounceTrackingMitigationsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new RunBounceTrackingMitigationsCommandParameters();
        return await ExecuteCommandAsync(RunBounceTrackingMitigationsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RunBounceTrackingMitigationsCommandParameters, RunBounceTrackingMitigationsResult> RunBounceTrackingMitigationsCommand = new("Storage.runBounceTrackingMitigations", JsonContext.RunBounceTrackingMitigationsCommandParameters, JsonContext.RunBounceTrackingMitigationsResult);

    /// <summary>
    /// Returns the effective Related Website Sets in use by this profile for the browser
    /// session. The effective Related Website Sets will not change during a browser session.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetRelatedWebsiteSetsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetRelatedWebsiteSetsResult"/>.
    /// </returns>
    public async Task<GetRelatedWebsiteSetsResult> GetRelatedWebsiteSetsAsync(GetRelatedWebsiteSetsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetRelatedWebsiteSetsCommandParameters();
        return await ExecuteCommandAsync(GetRelatedWebsiteSetsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetRelatedWebsiteSetsCommandParameters, GetRelatedWebsiteSetsResult> GetRelatedWebsiteSetsCommand = new("Storage.getRelatedWebsiteSets", JsonContext.GetRelatedWebsiteSetsCommandParameters, JsonContext.GetRelatedWebsiteSetsResult);

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
    public IEventSource<CacheStorageContentUpdatedEventArgs> CacheStorageContentUpdated => CreateCdpEventSource(StorageDomainEvent.CacheStorageContentUpdated);
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
    public IEventSource<CacheStorageListUpdatedEventArgs> CacheStorageListUpdated => CreateCdpEventSource(StorageDomainEvent.CacheStorageListUpdated);
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
    public IEventSource<IndexedDBContentUpdatedEventArgs> IndexedDBContentUpdated => CreateCdpEventSource(StorageDomainEvent.IndexedDBContentUpdated);
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
    public IEventSource<IndexedDBListUpdatedEventArgs> IndexedDBListUpdated => CreateCdpEventSource(StorageDomainEvent.IndexedDBListUpdated);
    /// <summary>
    /// Shared storage was accessed by the associated page.
    /// The following parameters are included in all events.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="SharedStorageAccessedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>AccessTime</b> - Time of the access.</description></item>
    /// <item><description><b>Scope</b> - Enum value indicating the access scope.</description></item>
    /// <item><description><b>Method</b> - Enum value indicating the Shared Storage API method invoked.</description></item>
    /// <item><description><b>MainFrameId</b> - DevTools Frame Token for the primary frame tree's root.</description></item>
    /// <item><description><b>OwnerOrigin</b> - Serialization of the origin owning the Shared Storage data.</description></item>
    /// <item><description><b>OwnerSite</b> - Serialization of the site owning the Shared Storage data.</description></item>
    /// <item><description><b>Params</b> - The sub-parameters wrapped by <b>params</b> are all optional and their presence/absence depends on <b>type</b>.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<SharedStorageAccessedEventArgs> SharedStorageAccessed => CreateCdpEventSource(StorageDomainEvent.SharedStorageAccessed);
    /// <summary>
    /// A shared storage run or selectURL operation finished its execution.
    /// The following parameters are included in all events.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="SharedStorageWorkletOperationExecutionFinishedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>FinishedTime</b> - Time that the operation finished.</description></item>
    /// <item><description><b>ExecutionTime</b> - Time, in microseconds, from start of shared storage JS API call until end of operation execution in the worklet.</description></item>
    /// <item><description><b>Method</b> - Enum value indicating the Shared Storage API method invoked.</description></item>
    /// <item><description><b>OperationId</b> - ID of the operation call.</description></item>
    /// <item><description><b>WorkletTargetId</b> - Hex representation of the DevTools token used as the TargetID for the associated shared storage worklet.</description></item>
    /// <item><description><b>MainFrameId</b> - DevTools Frame Token for the primary frame tree's root.</description></item>
    /// <item><description><b>OwnerOrigin</b> - Serialization of the origin owning the Shared Storage data.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<SharedStorageWorkletOperationExecutionFinishedEventArgs> SharedStorageWorkletOperationExecutionFinished => CreateCdpEventSource(StorageDomainEvent.SharedStorageWorkletOperationExecutionFinished);
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="StorageBucketCreatedOrUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>BucketInfo</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<StorageBucketCreatedOrUpdatedEventArgs> StorageBucketCreatedOrUpdated => CreateCdpEventSource(StorageDomainEvent.StorageBucketCreatedOrUpdated);
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="StorageBucketDeletedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>BucketId</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<StorageBucketDeletedEventArgs> StorageBucketDeleted => CreateCdpEventSource(StorageDomainEvent.StorageBucketDeleted);
}

internal sealed record GetStorageKeyForFrameCommandParameters(Page.FrameId FrameId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.GetStorageKeyForFrameAsync"/>.
/// </summary>
public sealed record GetStorageKeyForFrameCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="StorageKey">
/// </param>
public sealed record GetStorageKeyForFrameResult(SerializedStorageKey StorageKey) : EmptyResult;


internal sealed record GetStorageKeyCommandParameters(Page.FrameId? FrameId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.GetStorageKeyAsync"/>.
/// </summary>
public sealed record GetStorageKeyCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// </summary>
    public Page.FrameId? FrameId { get; init; }
}

/// <summary>
/// </summary>
/// <param name="StorageKey">
/// </param>
public sealed record GetStorageKeyResult(SerializedStorageKey StorageKey) : EmptyResult;


internal sealed record ClearDataForOriginCommandParameters(string Origin, string StorageTypes) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.ClearDataForOriginAsync"/>.
/// </summary>
public sealed record ClearDataForOriginCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ClearDataForOriginResult() : EmptyResult;


internal sealed record ClearDataForStorageKeyCommandParameters(string StorageKey, string StorageTypes) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.ClearDataForStorageKeyAsync"/>.
/// </summary>
public sealed record ClearDataForStorageKeyCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ClearDataForStorageKeyResult() : EmptyResult;


internal sealed record GetCookiesCommandParameters(Browser.BrowserContextID? BrowserContextId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.GetCookiesAsync"/>.
/// </summary>
public sealed record GetCookiesCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Browser context to use when called on the browser endpoint.
    /// </summary>
    public Browser.BrowserContextID? BrowserContextId { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Cookies">
/// Array of cookie objects.
/// </param>
public sealed record GetCookiesResult(IReadOnlyList<Network.Cookie> Cookies) : EmptyResult;


internal sealed record SetCookiesCommandParameters(ImmutableArray<Network.CookieParam> Cookies, Browser.BrowserContextID? BrowserContextId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.SetCookiesAsync"/>.
/// </summary>
public sealed record SetCookiesCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Browser context to use when called on the browser endpoint.
    /// </summary>
    public Browser.BrowserContextID? BrowserContextId { get; init; }
}

/// <summary>
/// </summary>
public sealed record SetCookiesResult() : EmptyResult;


internal sealed record ClearCookiesCommandParameters(Browser.BrowserContextID? BrowserContextId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.ClearCookiesAsync"/>.
/// </summary>
public sealed record ClearCookiesCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Browser context to use when called on the browser endpoint.
    /// </summary>
    public Browser.BrowserContextID? BrowserContextId { get; init; }
}

/// <summary>
/// </summary>
public sealed record ClearCookiesResult() : EmptyResult;


internal sealed record GetUsageAndQuotaCommandParameters(string Origin) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.GetUsageAndQuotaAsync"/>.
/// </summary>
public sealed record GetUsageAndQuotaCommandOptions : CdpCommandOptions
{
}

/// <summary>
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
public sealed record GetUsageAndQuotaResult(double Usage, double Quota, bool OverrideActive, IReadOnlyList<UsageForType> UsageBreakdown) : EmptyResult;


internal sealed record OverrideQuotaForOriginCommandParameters(string Origin, double? QuotaSize) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.OverrideQuotaForOriginAsync"/>.
/// </summary>
public sealed record OverrideQuotaForOriginCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// The quota size (in bytes) to override the original quota with.
    /// If this is called multiple times, the overridden quota will be equal to
    /// the quotaSize provided in the final call. If this is called without
    /// specifying a quotaSize, the quota will be reset to the default value for
    /// the specified origin. If this is called multiple times with different
    /// origins, the override will be maintained for each origin until it is
    /// disabled (called without a quotaSize).
    /// </summary>
    public double? QuotaSize { get; init; }
}

/// <summary>
/// </summary>
public sealed record OverrideQuotaForOriginResult() : EmptyResult;


internal sealed record TrackCacheStorageForOriginCommandParameters(string Origin) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.TrackCacheStorageForOriginAsync"/>.
/// </summary>
public sealed record TrackCacheStorageForOriginCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record TrackCacheStorageForOriginResult() : EmptyResult;


internal sealed record TrackCacheStorageForStorageKeyCommandParameters(string StorageKey) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.TrackCacheStorageForStorageKeyAsync"/>.
/// </summary>
public sealed record TrackCacheStorageForStorageKeyCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record TrackCacheStorageForStorageKeyResult() : EmptyResult;


internal sealed record TrackIndexedDBForOriginCommandParameters(string Origin) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.TrackIndexedDBForOriginAsync"/>.
/// </summary>
public sealed record TrackIndexedDBForOriginCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record TrackIndexedDBForOriginResult() : EmptyResult;


internal sealed record TrackIndexedDBForStorageKeyCommandParameters(string StorageKey) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.TrackIndexedDBForStorageKeyAsync"/>.
/// </summary>
public sealed record TrackIndexedDBForStorageKeyCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record TrackIndexedDBForStorageKeyResult() : EmptyResult;


internal sealed record UntrackCacheStorageForOriginCommandParameters(string Origin) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.UntrackCacheStorageForOriginAsync"/>.
/// </summary>
public sealed record UntrackCacheStorageForOriginCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record UntrackCacheStorageForOriginResult() : EmptyResult;


internal sealed record UntrackCacheStorageForStorageKeyCommandParameters(string StorageKey) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.UntrackCacheStorageForStorageKeyAsync"/>.
/// </summary>
public sealed record UntrackCacheStorageForStorageKeyCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record UntrackCacheStorageForStorageKeyResult() : EmptyResult;


internal sealed record UntrackIndexedDBForOriginCommandParameters(string Origin) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.UntrackIndexedDBForOriginAsync"/>.
/// </summary>
public sealed record UntrackIndexedDBForOriginCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record UntrackIndexedDBForOriginResult() : EmptyResult;


internal sealed record UntrackIndexedDBForStorageKeyCommandParameters(string StorageKey) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.UntrackIndexedDBForStorageKeyAsync"/>.
/// </summary>
public sealed record UntrackIndexedDBForStorageKeyCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record UntrackIndexedDBForStorageKeyResult() : EmptyResult;


internal sealed record GetTrustTokensCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.GetTrustTokensAsync"/>.
/// </summary>
public sealed record GetTrustTokensCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Tokens">
/// </param>
public sealed record GetTrustTokensResult(IReadOnlyList<TrustTokens> Tokens) : EmptyResult;


internal sealed record ClearTrustTokensCommandParameters(string IssuerOrigin) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.ClearTrustTokensAsync"/>.
/// </summary>
public sealed record ClearTrustTokensCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="DidDeleteTokens">
/// True if any tokens were deleted, false otherwise.
/// </param>
public sealed record ClearTrustTokensResult(bool DidDeleteTokens) : EmptyResult;


internal sealed record GetSharedStorageMetadataCommandParameters(string OwnerOrigin) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.GetSharedStorageMetadataAsync"/>.
/// </summary>
public sealed record GetSharedStorageMetadataCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Metadata">
/// </param>
public sealed record GetSharedStorageMetadataResult(SharedStorageMetadata Metadata) : EmptyResult;


internal sealed record GetSharedStorageEntriesCommandParameters(string OwnerOrigin) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.GetSharedStorageEntriesAsync"/>.
/// </summary>
public sealed record GetSharedStorageEntriesCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Entries">
/// </param>
public sealed record GetSharedStorageEntriesResult(IReadOnlyList<SharedStorageEntry> Entries) : EmptyResult;


internal sealed record SetSharedStorageEntryCommandParameters(string OwnerOrigin, string Key, string Value, bool? IgnoreIfPresent) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.SetSharedStorageEntryAsync"/>.
/// </summary>
public sealed record SetSharedStorageEntryCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// If <b>ignoreIfPresent</b> is included and true, then only sets the entry if
    /// <b>key</b> doesn't already exist.
    /// </summary>
    public bool? IgnoreIfPresent { get; init; }
}

/// <summary>
/// </summary>
public sealed record SetSharedStorageEntryResult() : EmptyResult;


internal sealed record DeleteSharedStorageEntryCommandParameters(string OwnerOrigin, string Key) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.DeleteSharedStorageEntryAsync"/>.
/// </summary>
public sealed record DeleteSharedStorageEntryCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DeleteSharedStorageEntryResult() : EmptyResult;


internal sealed record ClearSharedStorageEntriesCommandParameters(string OwnerOrigin) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.ClearSharedStorageEntriesAsync"/>.
/// </summary>
public sealed record ClearSharedStorageEntriesCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ClearSharedStorageEntriesResult() : EmptyResult;


internal sealed record ResetSharedStorageBudgetCommandParameters(string OwnerOrigin) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.ResetSharedStorageBudgetAsync"/>.
/// </summary>
public sealed record ResetSharedStorageBudgetCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ResetSharedStorageBudgetResult() : EmptyResult;


internal sealed record SetSharedStorageTrackingCommandParameters(bool Enable) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.SetSharedStorageTrackingAsync"/>.
/// </summary>
public sealed record SetSharedStorageTrackingCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetSharedStorageTrackingResult() : EmptyResult;


internal sealed record SetStorageBucketTrackingCommandParameters(string StorageKey, bool Enable) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.SetStorageBucketTrackingAsync"/>.
/// </summary>
public sealed record SetStorageBucketTrackingCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetStorageBucketTrackingResult() : EmptyResult;


internal sealed record DeleteStorageBucketCommandParameters(StorageBucket Bucket) : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.DeleteStorageBucketAsync"/>.
/// </summary>
public sealed record DeleteStorageBucketCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DeleteStorageBucketResult() : EmptyResult;


internal sealed record RunBounceTrackingMitigationsCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.RunBounceTrackingMitigationsAsync"/>.
/// </summary>
public sealed record RunBounceTrackingMitigationsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="DeletedSites">
/// </param>
public sealed record RunBounceTrackingMitigationsResult(IReadOnlyList<string> DeletedSites) : EmptyResult;


internal sealed record GetRelatedWebsiteSetsCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="StorageDomain.GetRelatedWebsiteSetsAsync"/>.
/// </summary>
public sealed record GetRelatedWebsiteSetsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Sets">
/// </param>
public sealed record GetRelatedWebsiteSetsResult(IReadOnlyList<RelatedWebsiteSet> Sets) : EmptyResult;


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
/// Shared storage was accessed by the associated page.
/// The following parameters are included in all events.
/// </summary>
/// <param name="AccessTime">
/// Time of the access.
/// </param>
/// <param name="Scope">
/// Enum value indicating the access scope.
/// </param>
/// <param name="Method">
/// Enum value indicating the Shared Storage API method invoked.
/// </param>
/// <param name="MainFrameId">
/// DevTools Frame Token for the primary frame tree's root.
/// </param>
/// <param name="OwnerOrigin">
/// Serialization of the origin owning the Shared Storage data.
/// </param>
/// <param name="OwnerSite">
/// Serialization of the site owning the Shared Storage data.
/// </param>
/// <param name="Params">
/// The sub-parameters wrapped by <b>params</b> are all optional and their
/// presence/absence depends on <b>type</b>.
/// </param>
public sealed record SharedStorageAccessedEventArgs(Network.TimeSinceEpoch AccessTime, SharedStorageAccessScope Scope, SharedStorageAccessMethod Method, Page.FrameId MainFrameId, string OwnerOrigin, string OwnerSite, SharedStorageAccessParams Params) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// A shared storage run or selectURL operation finished its execution.
/// The following parameters are included in all events.
/// </summary>
/// <param name="FinishedTime">
/// Time that the operation finished.
/// </param>
/// <param name="ExecutionTime">
/// Time, in microseconds, from start of shared storage JS API call until
/// end of operation execution in the worklet.
/// </param>
/// <param name="Method">
/// Enum value indicating the Shared Storage API method invoked.
/// </param>
/// <param name="OperationId">
/// ID of the operation call.
/// </param>
/// <param name="WorkletTargetId">
/// Hex representation of the DevTools token used as the TargetID for the
/// associated shared storage worklet.
/// </param>
/// <param name="MainFrameId">
/// DevTools Frame Token for the primary frame tree's root.
/// </param>
/// <param name="OwnerOrigin">
/// Serialization of the origin owning the Shared Storage data.
/// </param>
public sealed record SharedStorageWorkletOperationExecutionFinishedEventArgs(Network.TimeSinceEpoch FinishedTime, long ExecutionTime, SharedStorageAccessMethod Method, string OperationId, Target.TargetID WorkletTargetId, Page.FrameId MainFrameId, string OwnerOrigin) : OpenQA.Selenium.BiDi.EventArgs;

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
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("cookies")]
    Cookies,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("file_systems")]
    FileSystems,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("indexeddb")]
    Indexeddb,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("local_storage")]
    LocalStorage,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("shader_cache")]
    ShaderCache,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("websql")]
    Websql,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("service_workers")]
    ServiceWorkers,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("cache_storage")]
    CacheStorage,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("shared_storage")]
    SharedStorage,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("storage_buckets")]
    StorageBuckets,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("all")]
    All,
    /// <summary>
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
/// Enum of shared storage access scopes.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<SharedStorageAccessScope>))]
public enum SharedStorageAccessScope
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("window")]
    Window,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("sharedStorageWorklet")]
    SharedStorageWorklet,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("header")]
    Header,
}

/// <summary>
/// Enum of shared storage access methods.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<SharedStorageAccessMethod>))]
public enum SharedStorageAccessMethod
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("addModule")]
    AddModule,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("createWorklet")]
    CreateWorklet,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("selectURL")]
    SelectURL,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("run")]
    Run,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("batchUpdate")]
    BatchUpdate,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("set")]
    Set,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("append")]
    Append,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("delete")]
    Delete,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("clear")]
    Clear,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("get")]
    Get,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("keys")]
    Keys,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("values")]
    Values,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("entries")]
    Entries,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("length")]
    Length,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("remainingBudget")]
    RemainingBudget,
}

/// <summary>
/// Struct for a single key-value pair in an origin's shared storage.
/// </summary>
/// <param name="Key">
/// </param>
/// <param name="Value">
/// </param>
public sealed record SharedStorageEntry(string Key, string Value)
{
}

/// <summary>
/// Details for an origin's shared storage.
/// </summary>
/// <param name="CreationTime">
/// Time when the origin's shared storage was last created.
/// </param>
/// <param name="Length">
/// Number of key-value pairs stored in origin's shared storage.
/// </param>
/// <param name="RemainingBudget">
/// Current amount of bits of entropy remaining in the navigation budget.
/// </param>
/// <param name="BytesUsed">
/// Total number of bytes stored as key-value pairs in origin's shared
/// storage.
/// </param>
public sealed record SharedStorageMetadata(Network.TimeSinceEpoch CreationTime, long Length, double RemainingBudget, long BytesUsed)
{
}

/// <summary>
/// Represents a dictionary object passed in as privateAggregationConfig to
/// run or selectURL.
/// </summary>
/// <param name="FilteringIdMaxBytes">
/// Configures the maximum size allowed for filtering IDs.
/// </param>
public sealed record SharedStoragePrivateAggregationConfig(long FilteringIdMaxBytes)
{
    /// <summary>
    /// The chosen aggregation service deployment.
    /// </summary>
    public string? AggregationCoordinatorOrigin { get; init; }

    /// <summary>
    /// The context ID provided.
    /// </summary>
    public string? ContextId { get; init; }

    /// <summary>
    /// The limit on the number of contributions in the final report.
    /// </summary>
    public long? MaxContributions { get; init; }
}

/// <summary>
/// Pair of reporting metadata details for a candidate URL for <b>selectURL()</b>.
/// </summary>
/// <param name="EventType">
/// </param>
/// <param name="ReportingUrl">
/// </param>
public sealed record SharedStorageReportingMetadata(string EventType, string ReportingUrl)
{
}

/// <summary>
/// Bundles a candidate URL with its reporting metadata.
/// </summary>
/// <param name="Url">
/// Spec of candidate URL.
/// </param>
/// <param name="ReportingMetadata">
/// Any associated reporting metadata.
/// </param>
public sealed record SharedStorageUrlWithMetadata(string Url, IReadOnlyList<SharedStorageReportingMetadata> ReportingMetadata)
{
}

/// <summary>
/// Bundles the parameters for shared storage access events whose
/// presence/absence can vary according to SharedStorageAccessType.
/// </summary>
public sealed record SharedStorageAccessParams()
{
    /// <summary>
    /// Spec of the module script URL.
    /// Present only for SharedStorageAccessMethods: addModule and
    /// createWorklet.
    /// </summary>
    public string? ScriptSourceUrl { get; init; }

    /// <summary>
    /// String denoting "context-origin", "script-origin", or a custom
    /// origin to be used as the worklet's data origin.
    /// Present only for SharedStorageAccessMethod: createWorklet.
    /// </summary>
    public string? DataOrigin { get; init; }

    /// <summary>
    /// Name of the registered operation to be run.
    /// Present only for SharedStorageAccessMethods: run and selectURL.
    /// </summary>
    public string? OperationName { get; init; }

    /// <summary>
    /// ID of the operation call.
    /// Present only for SharedStorageAccessMethods: run and selectURL.
    /// </summary>
    public string? OperationId { get; init; }

    /// <summary>
    /// Whether or not to keep the worket alive for future run or selectURL
    /// calls.
    /// Present only for SharedStorageAccessMethods: run and selectURL.
    /// </summary>
    public bool? KeepAlive { get; init; }

    /// <summary>
    /// Configures the private aggregation options.
    /// Present only for SharedStorageAccessMethods: run and selectURL.
    /// </summary>
    public SharedStoragePrivateAggregationConfig? PrivateAggregationConfig { get; init; }

    /// <summary>
    /// The operation's serialized data in bytes (converted to a string).
    /// Present only for SharedStorageAccessMethods: run and selectURL.
    /// TODO(crbug.com/401011862): Consider updating this parameter to binary.
    /// </summary>
    public string? SerializedData { get; init; }

    /// <summary>
    /// Array of candidate URLs' specs, along with any associated metadata.
    /// Present only for SharedStorageAccessMethod: selectURL.
    /// </summary>
    public IReadOnlyList<SharedStorageUrlWithMetadata>? UrlsWithMetadata { get; init; }

    /// <summary>
    /// Spec of the URN:UUID generated for a selectURL call.
    /// Present only for SharedStorageAccessMethod: selectURL.
    /// </summary>
    public string? UrnUuid { get; init; }

    /// <summary>
    /// Key for a specific entry in an origin's shared storage.
    /// Present only for SharedStorageAccessMethods: set, append, delete, and
    /// get.
    /// </summary>
    public string? Key { get; init; }

    /// <summary>
    /// Value for a specific entry in an origin's shared storage.
    /// Present only for SharedStorageAccessMethods: set and append.
    /// </summary>
    public string? Value { get; init; }

    /// <summary>
    /// Whether or not to set an entry for a key if that key is already present.
    /// Present only for SharedStorageAccessMethod: set.
    /// </summary>
    public bool? IgnoreIfPresent { get; init; }

    /// <summary>
    /// A number denoting the (0-based) order of the worklet's
    /// creation relative to all other shared storage worklets created by
    /// documents using the current storage partition.
    /// Present only for SharedStorageAccessMethods: addModule, createWorklet.
    /// </summary>
    public long? WorkletOrdinal { get; init; }

    /// <summary>
    /// Hex representation of the DevTools token used as the TargetID for the
    /// associated shared storage worklet.
    /// Present only for SharedStorageAccessMethods: addModule, createWorklet,
    /// run, selectURL, and any other SharedStorageAccessMethod when the
    /// SharedStorageAccessScope is sharedStorageWorklet.
    /// </summary>
    public Target.TargetID? WorkletTargetId { get; init; }

    /// <summary>
    /// Name of the lock to be acquired, if present.
    /// Optionally present only for SharedStorageAccessMethods: batchUpdate,
    /// set, append, delete, and clear.
    /// </summary>
    public string? WithLock { get; init; }

    /// <summary>
    /// If the method has been called as part of a batchUpdate, then this
    /// number identifies the batch to which it belongs.
    /// Optionally present only for SharedStorageAccessMethods:
    /// batchUpdate (required), set, append, delete, and clear.
    /// </summary>
    public string? BatchUpdateId { get; init; }

    /// <summary>
    /// Number of modifier methods sent in batch.
    /// Present only for SharedStorageAccessMethod: batchUpdate.
    /// </summary>
    public long? BatchSize { get; init; }
}

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<StorageBucketsDurability>))]
public enum StorageBucketsDurability
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("relaxed")]
    Relaxed,
    /// <summary>
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

/// <summary>
/// A single Related Website Set object.
/// </summary>
/// <param name="PrimarySites">
/// The primary site of this set, along with the ccTLDs if there is any.
/// </param>
/// <param name="AssociatedSites">
/// The associated sites of this set, along with the ccTLDs if there is any.
/// </param>
/// <param name="ServiceSites">
/// The service sites of this set, along with the ccTLDs if there is any.
/// </param>
public sealed record RelatedWebsiteSet(IReadOnlyList<string> PrimarySites, IReadOnlyList<string> AssociatedSites, IReadOnlyList<string> ServiceSites)
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
[JsonSerializable(typeof(GetSharedStorageMetadataCommandParameters), TypeInfoPropertyName = "GetSharedStorageMetadataCommandParameters")]
[JsonSerializable(typeof(GetSharedStorageMetadataResult), TypeInfoPropertyName = "GetSharedStorageMetadataResult")]
[JsonSerializable(typeof(GetSharedStorageEntriesCommandParameters), TypeInfoPropertyName = "GetSharedStorageEntriesCommandParameters")]
[JsonSerializable(typeof(GetSharedStorageEntriesResult), TypeInfoPropertyName = "GetSharedStorageEntriesResult")]
[JsonSerializable(typeof(SetSharedStorageEntryCommandParameters), TypeInfoPropertyName = "SetSharedStorageEntryCommandParameters")]
[JsonSerializable(typeof(SetSharedStorageEntryResult), TypeInfoPropertyName = "SetSharedStorageEntryResult")]
[JsonSerializable(typeof(DeleteSharedStorageEntryCommandParameters), TypeInfoPropertyName = "DeleteSharedStorageEntryCommandParameters")]
[JsonSerializable(typeof(DeleteSharedStorageEntryResult), TypeInfoPropertyName = "DeleteSharedStorageEntryResult")]
[JsonSerializable(typeof(ClearSharedStorageEntriesCommandParameters), TypeInfoPropertyName = "ClearSharedStorageEntriesCommandParameters")]
[JsonSerializable(typeof(ClearSharedStorageEntriesResult), TypeInfoPropertyName = "ClearSharedStorageEntriesResult")]
[JsonSerializable(typeof(ResetSharedStorageBudgetCommandParameters), TypeInfoPropertyName = "ResetSharedStorageBudgetCommandParameters")]
[JsonSerializable(typeof(ResetSharedStorageBudgetResult), TypeInfoPropertyName = "ResetSharedStorageBudgetResult")]
[JsonSerializable(typeof(SetSharedStorageTrackingCommandParameters), TypeInfoPropertyName = "SetSharedStorageTrackingCommandParameters")]
[JsonSerializable(typeof(SetSharedStorageTrackingResult), TypeInfoPropertyName = "SetSharedStorageTrackingResult")]
[JsonSerializable(typeof(SetStorageBucketTrackingCommandParameters), TypeInfoPropertyName = "SetStorageBucketTrackingCommandParameters")]
[JsonSerializable(typeof(SetStorageBucketTrackingResult), TypeInfoPropertyName = "SetStorageBucketTrackingResult")]
[JsonSerializable(typeof(DeleteStorageBucketCommandParameters), TypeInfoPropertyName = "DeleteStorageBucketCommandParameters")]
[JsonSerializable(typeof(DeleteStorageBucketResult), TypeInfoPropertyName = "DeleteStorageBucketResult")]
[JsonSerializable(typeof(RunBounceTrackingMitigationsCommandParameters), TypeInfoPropertyName = "RunBounceTrackingMitigationsCommandParameters")]
[JsonSerializable(typeof(RunBounceTrackingMitigationsResult), TypeInfoPropertyName = "RunBounceTrackingMitigationsResult")]
[JsonSerializable(typeof(GetRelatedWebsiteSetsCommandParameters), TypeInfoPropertyName = "GetRelatedWebsiteSetsCommandParameters")]
[JsonSerializable(typeof(GetRelatedWebsiteSetsResult), TypeInfoPropertyName = "GetRelatedWebsiteSetsResult")]
[JsonSerializable(typeof(CdpEventArgs<CacheStorageContentUpdatedEventArgs>), TypeInfoPropertyName = "CacheStorageContentUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<CacheStorageListUpdatedEventArgs>), TypeInfoPropertyName = "CacheStorageListUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<IndexedDBContentUpdatedEventArgs>), TypeInfoPropertyName = "IndexedDBContentUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<IndexedDBListUpdatedEventArgs>), TypeInfoPropertyName = "IndexedDBListUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<SharedStorageAccessedEventArgs>), TypeInfoPropertyName = "SharedStorageAccessedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<SharedStorageWorkletOperationExecutionFinishedEventArgs>), TypeInfoPropertyName = "SharedStorageWorkletOperationExecutionFinishedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<StorageBucketCreatedOrUpdatedEventArgs>), TypeInfoPropertyName = "StorageBucketCreatedOrUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<StorageBucketDeletedEventArgs>), TypeInfoPropertyName = "StorageBucketDeletedCdpEventArgs")]
[JsonSerializable(typeof(SerializedStorageKey), TypeInfoPropertyName = "StorageSerializedStorageKey")]
[JsonSerializable(typeof(StorageType), TypeInfoPropertyName = "StorageStorageType")]
[JsonSerializable(typeof(UsageForType), TypeInfoPropertyName = "StorageUsageForType")]
[JsonSerializable(typeof(TrustTokens), TypeInfoPropertyName = "StorageTrustTokens")]
[JsonSerializable(typeof(SharedStorageAccessScope), TypeInfoPropertyName = "StorageSharedStorageAccessScope")]
[JsonSerializable(typeof(SharedStorageAccessMethod), TypeInfoPropertyName = "StorageSharedStorageAccessMethod")]
[JsonSerializable(typeof(SharedStorageEntry), TypeInfoPropertyName = "StorageSharedStorageEntry")]
[JsonSerializable(typeof(SharedStorageMetadata), TypeInfoPropertyName = "StorageSharedStorageMetadata")]
[JsonSerializable(typeof(SharedStoragePrivateAggregationConfig), TypeInfoPropertyName = "StorageSharedStoragePrivateAggregationConfig")]
[JsonSerializable(typeof(SharedStorageReportingMetadata), TypeInfoPropertyName = "StorageSharedStorageReportingMetadata")]
[JsonSerializable(typeof(SharedStorageUrlWithMetadata), TypeInfoPropertyName = "StorageSharedStorageUrlWithMetadata")]
[JsonSerializable(typeof(SharedStorageAccessParams), TypeInfoPropertyName = "StorageSharedStorageAccessParams")]
[JsonSerializable(typeof(StorageBucketsDurability), TypeInfoPropertyName = "StorageStorageBucketsDurability")]
[JsonSerializable(typeof(StorageBucket), TypeInfoPropertyName = "StorageStorageBucket")]
[JsonSerializable(typeof(StorageBucketInfo), TypeInfoPropertyName = "StorageStorageBucketInfo")]
[JsonSerializable(typeof(RelatedWebsiteSet), TypeInfoPropertyName = "StorageRelatedWebsiteSet")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<Network.Cookie>), TypeInfoPropertyName = "IReadOnlyListNetworkCookie")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<Network.CookieParam>), TypeInfoPropertyName = "IReadOnlyListNetworkCookieParam")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<UsageForType>), TypeInfoPropertyName = "IReadOnlyListStorageUsageForType")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<TrustTokens>), TypeInfoPropertyName = "IReadOnlyListStorageTrustTokens")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<SharedStorageEntry>), TypeInfoPropertyName = "IReadOnlyListStorageSharedStorageEntry")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<RelatedWebsiteSet>), TypeInfoPropertyName = "IReadOnlyListStorageRelatedWebsiteSet")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<SharedStorageReportingMetadata>), TypeInfoPropertyName = "IReadOnlyListStorageSharedStorageReportingMetadata")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<SharedStorageUrlWithMetadata>), TypeInfoPropertyName = "IReadOnlyListStorageSharedStorageUrlWithMetadata")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class StorageJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="StorageDomain"/>.
/// </summary>
public static class StorageDomainEvent
{
    /// <summary>
    /// A cache's contents have been modified.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<CacheStorageContentUpdatedEventArgs>> CacheStorageContentUpdated { get; } =
        EventDescriptor<CdpEventArgs<CacheStorageContentUpdatedEventArgs>>.Create(
            "goog:cdp.Storage.cacheStorageContentUpdated",
            StorageJsonSerializerContext.Default.CacheStorageContentUpdatedCdpEventArgs);

    /// <summary>
    /// A cache has been added/deleted.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<CacheStorageListUpdatedEventArgs>> CacheStorageListUpdated { get; } =
        EventDescriptor<CdpEventArgs<CacheStorageListUpdatedEventArgs>>.Create(
            "goog:cdp.Storage.cacheStorageListUpdated",
            StorageJsonSerializerContext.Default.CacheStorageListUpdatedCdpEventArgs);

    /// <summary>
    /// The origin's IndexedDB object store has been modified.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<IndexedDBContentUpdatedEventArgs>> IndexedDBContentUpdated { get; } =
        EventDescriptor<CdpEventArgs<IndexedDBContentUpdatedEventArgs>>.Create(
            "goog:cdp.Storage.indexedDBContentUpdated",
            StorageJsonSerializerContext.Default.IndexedDBContentUpdatedCdpEventArgs);

    /// <summary>
    /// The origin's IndexedDB database list has been modified.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<IndexedDBListUpdatedEventArgs>> IndexedDBListUpdated { get; } =
        EventDescriptor<CdpEventArgs<IndexedDBListUpdatedEventArgs>>.Create(
            "goog:cdp.Storage.indexedDBListUpdated",
            StorageJsonSerializerContext.Default.IndexedDBListUpdatedCdpEventArgs);

    /// <summary>
    /// Shared storage was accessed by the associated page.
    /// The following parameters are included in all events.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<SharedStorageAccessedEventArgs>> SharedStorageAccessed { get; } =
        EventDescriptor<CdpEventArgs<SharedStorageAccessedEventArgs>>.Create(
            "goog:cdp.Storage.sharedStorageAccessed",
            StorageJsonSerializerContext.Default.SharedStorageAccessedCdpEventArgs);

    /// <summary>
    /// A shared storage run or selectURL operation finished its execution.
    /// The following parameters are included in all events.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<SharedStorageWorkletOperationExecutionFinishedEventArgs>> SharedStorageWorkletOperationExecutionFinished { get; } =
        EventDescriptor<CdpEventArgs<SharedStorageWorkletOperationExecutionFinishedEventArgs>>.Create(
            "goog:cdp.Storage.sharedStorageWorkletOperationExecutionFinished",
            StorageJsonSerializerContext.Default.SharedStorageWorkletOperationExecutionFinishedCdpEventArgs);

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<StorageBucketCreatedOrUpdatedEventArgs>> StorageBucketCreatedOrUpdated { get; } =
        EventDescriptor<CdpEventArgs<StorageBucketCreatedOrUpdatedEventArgs>>.Create(
            "goog:cdp.Storage.storageBucketCreatedOrUpdated",
            StorageJsonSerializerContext.Default.StorageBucketCreatedOrUpdatedCdpEventArgs);

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<StorageBucketDeletedEventArgs>> StorageBucketDeleted { get; } =
        EventDescriptor<CdpEventArgs<StorageBucketDeletedEventArgs>>.Create(
            "goog:cdp.Storage.storageBucketDeleted",
            StorageJsonSerializerContext.Default.StorageBucketDeletedCdpEventArgs);

}
