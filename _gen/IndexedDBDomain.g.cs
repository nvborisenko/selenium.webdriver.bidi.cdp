#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.IndexedDB;

/// <summary>
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class IndexedDBDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static IndexedDBJsonSerializerContext JsonContext = IndexedDBJsonSerializerContext.Default;

    /// <summary>
    /// Clears all entries from an object store.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>SecurityOrigin</b> - At least and at most one of securityOrigin, storageKey, or storageBucket must be specified. Security origin.</description></item>
    /// <item><description><b>StorageKey</b> - Storage key.</description></item>
    /// <item><description><b>StorageBucket</b> - Storage bucket. If not specified, it uses the default bucket.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="databaseName">
    /// Database name.
    /// </param>
    /// <param name="objectStoreName">
    /// Object store name.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ClearObjectStoreCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearObjectStoreResult"/>.
    /// </returns>
    public async Task<ClearObjectStoreResult> ClearObjectStoreAsync(string databaseName, string objectStoreName, ClearObjectStoreCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearObjectStoreCommandParameters(SecurityOrigin: options?.SecurityOrigin, StorageKey: options?.StorageKey, StorageBucket: options?.StorageBucket, DatabaseName: databaseName, ObjectStoreName: objectStoreName);
        return await ExecuteCommandAsync(ClearObjectStoreCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearObjectStoreCommandParameters, ClearObjectStoreResult> ClearObjectStoreCommand = new("IndexedDB.clearObjectStore", JsonContext.ClearObjectStoreCommandParameters, JsonContext.ClearObjectStoreResult);

    /// <summary>
    /// Deletes a database.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>SecurityOrigin</b> - At least and at most one of securityOrigin, storageKey, or storageBucket must be specified. Security origin.</description></item>
    /// <item><description><b>StorageKey</b> - Storage key.</description></item>
    /// <item><description><b>StorageBucket</b> - Storage bucket. If not specified, it uses the default bucket.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="databaseName">
    /// Database name.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="DeleteDatabaseCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DeleteDatabaseResult"/>.
    /// </returns>
    public async Task<DeleteDatabaseResult> DeleteDatabaseAsync(string databaseName, DeleteDatabaseCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new DeleteDatabaseCommandParameters(SecurityOrigin: options?.SecurityOrigin, StorageKey: options?.StorageKey, StorageBucket: options?.StorageBucket, DatabaseName: databaseName);
        return await ExecuteCommandAsync(DeleteDatabaseCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DeleteDatabaseCommandParameters, DeleteDatabaseResult> DeleteDatabaseCommand = new("IndexedDB.deleteDatabase", JsonContext.DeleteDatabaseCommandParameters, JsonContext.DeleteDatabaseResult);

    /// <summary>
    /// Delete a range of entries from an object store
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>SecurityOrigin</b> - At least and at most one of securityOrigin, storageKey, or storageBucket must be specified. Security origin.</description></item>
    /// <item><description><b>StorageKey</b> - Storage key.</description></item>
    /// <item><description><b>StorageBucket</b> - Storage bucket. If not specified, it uses the default bucket.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="databaseName">
    /// </param>
    /// <param name="objectStoreName">
    /// </param>
    /// <param name="keyRange">
    /// Range of entry keys to delete
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="DeleteObjectStoreEntriesCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DeleteObjectStoreEntriesResult"/>.
    /// </returns>
    public async Task<DeleteObjectStoreEntriesResult> DeleteObjectStoreEntriesAsync(string databaseName, string objectStoreName, KeyRange keyRange, DeleteObjectStoreEntriesCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new DeleteObjectStoreEntriesCommandParameters(SecurityOrigin: options?.SecurityOrigin, StorageKey: options?.StorageKey, StorageBucket: options?.StorageBucket, DatabaseName: databaseName, ObjectStoreName: objectStoreName, KeyRange: keyRange);
        return await ExecuteCommandAsync(DeleteObjectStoreEntriesCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DeleteObjectStoreEntriesCommandParameters, DeleteObjectStoreEntriesResult> DeleteObjectStoreEntriesCommand = new("IndexedDB.deleteObjectStoreEntries", JsonContext.DeleteObjectStoreEntriesCommandParameters, JsonContext.DeleteObjectStoreEntriesResult);

    /// <summary>
    /// Disables events from backend.
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
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("IndexedDB.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Enables events from backend.
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
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("IndexedDB.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Requests data from object store or index.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>SecurityOrigin</b> - At least and at most one of securityOrigin, storageKey, or storageBucket must be specified. Security origin.</description></item>
    /// <item><description><b>StorageKey</b> - Storage key.</description></item>
    /// <item><description><b>StorageBucket</b> - Storage bucket. If not specified, it uses the default bucket.</description></item>
    /// <item><description><b>KeyRange</b> - Key range.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="databaseName">
    /// Database name.
    /// </param>
    /// <param name="objectStoreName">
    /// Object store name.
    /// </param>
    /// <param name="indexName">
    /// Index name, empty string for object store data requests.
    /// </param>
    /// <param name="skipCount">
    /// Number of records to skip.
    /// </param>
    /// <param name="pageSize">
    /// Number of records to fetch.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="RequestDataCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RequestDataResult"/>.
    /// </returns>
    public async Task<RequestDataResult> RequestDataAsync(string databaseName, string objectStoreName, string indexName, long skipCount, long pageSize, RequestDataCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new RequestDataCommandParameters(SecurityOrigin: options?.SecurityOrigin, StorageKey: options?.StorageKey, StorageBucket: options?.StorageBucket, DatabaseName: databaseName, ObjectStoreName: objectStoreName, IndexName: indexName, SkipCount: skipCount, PageSize: pageSize, KeyRange: options?.KeyRange);
        return await ExecuteCommandAsync(RequestDataCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RequestDataCommandParameters, RequestDataResult> RequestDataCommand = new("IndexedDB.requestData", JsonContext.RequestDataCommandParameters, JsonContext.RequestDataResult);

    /// <summary>
    /// Gets metadata of an object store.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>SecurityOrigin</b> - At least and at most one of securityOrigin, storageKey, or storageBucket must be specified. Security origin.</description></item>
    /// <item><description><b>StorageKey</b> - Storage key.</description></item>
    /// <item><description><b>StorageBucket</b> - Storage bucket. If not specified, it uses the default bucket.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="databaseName">
    /// Database name.
    /// </param>
    /// <param name="objectStoreName">
    /// Object store name.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetMetadataCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetMetadataResult"/>.
    /// </returns>
    public async Task<GetMetadataResult> GetMetadataAsync(string databaseName, string objectStoreName, GetMetadataCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetMetadataCommandParameters(SecurityOrigin: options?.SecurityOrigin, StorageKey: options?.StorageKey, StorageBucket: options?.StorageBucket, DatabaseName: databaseName, ObjectStoreName: objectStoreName);
        return await ExecuteCommandAsync(GetMetadataCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetMetadataCommandParameters, GetMetadataResult> GetMetadataCommand = new("IndexedDB.getMetadata", JsonContext.GetMetadataCommandParameters, JsonContext.GetMetadataResult);

    /// <summary>
    /// Requests database with given name in given frame.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>SecurityOrigin</b> - At least and at most one of securityOrigin, storageKey, or storageBucket must be specified. Security origin.</description></item>
    /// <item><description><b>StorageKey</b> - Storage key.</description></item>
    /// <item><description><b>StorageBucket</b> - Storage bucket. If not specified, it uses the default bucket.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="databaseName">
    /// Database name.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="RequestDatabaseCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RequestDatabaseResult"/>.
    /// </returns>
    public async Task<RequestDatabaseResult> RequestDatabaseAsync(string databaseName, RequestDatabaseCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new RequestDatabaseCommandParameters(SecurityOrigin: options?.SecurityOrigin, StorageKey: options?.StorageKey, StorageBucket: options?.StorageBucket, DatabaseName: databaseName);
        return await ExecuteCommandAsync(RequestDatabaseCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RequestDatabaseCommandParameters, RequestDatabaseResult> RequestDatabaseCommand = new("IndexedDB.requestDatabase", JsonContext.RequestDatabaseCommandParameters, JsonContext.RequestDatabaseResult);

    /// <summary>
    /// Requests database names for given security origin.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>SecurityOrigin</b> - At least and at most one of securityOrigin, storageKey, or storageBucket must be specified. Security origin.</description></item>
    /// <item><description><b>StorageKey</b> - Storage key.</description></item>
    /// <item><description><b>StorageBucket</b> - Storage bucket. If not specified, it uses the default bucket.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="options">
    /// Optional parameters. See <see cref="RequestDatabaseNamesCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RequestDatabaseNamesResult"/>.
    /// </returns>
    public async Task<RequestDatabaseNamesResult> RequestDatabaseNamesAsync(RequestDatabaseNamesCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new RequestDatabaseNamesCommandParameters(SecurityOrigin: options?.SecurityOrigin, StorageKey: options?.StorageKey, StorageBucket: options?.StorageBucket);
        return await ExecuteCommandAsync(RequestDatabaseNamesCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RequestDatabaseNamesCommandParameters, RequestDatabaseNamesResult> RequestDatabaseNamesCommand = new("IndexedDB.requestDatabaseNames", JsonContext.RequestDatabaseNamesCommandParameters, JsonContext.RequestDatabaseNamesResult);

}

internal sealed record ClearObjectStoreCommandParameters(string? SecurityOrigin, string? StorageKey, Storage.StorageBucket? StorageBucket, string DatabaseName, string ObjectStoreName) : Parameters;

/// <summary>
/// Optional parameters for <see cref="IndexedDBDomain.ClearObjectStoreAsync"/>.
/// </summary>
public sealed record ClearObjectStoreCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// At least and at most one of securityOrigin, storageKey, or storageBucket must be specified.
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
public sealed record ClearObjectStoreResult() : EmptyResult;


internal sealed record DeleteDatabaseCommandParameters(string? SecurityOrigin, string? StorageKey, Storage.StorageBucket? StorageBucket, string DatabaseName) : Parameters;

/// <summary>
/// Optional parameters for <see cref="IndexedDBDomain.DeleteDatabaseAsync"/>.
/// </summary>
public sealed record DeleteDatabaseCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// At least and at most one of securityOrigin, storageKey, or storageBucket must be specified.
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
public sealed record DeleteDatabaseResult() : EmptyResult;


internal sealed record DeleteObjectStoreEntriesCommandParameters(string? SecurityOrigin, string? StorageKey, Storage.StorageBucket? StorageBucket, string DatabaseName, string ObjectStoreName, KeyRange KeyRange) : Parameters;

/// <summary>
/// Optional parameters for <see cref="IndexedDBDomain.DeleteObjectStoreEntriesAsync"/>.
/// </summary>
public sealed record DeleteObjectStoreEntriesCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// At least and at most one of securityOrigin, storageKey, or storageBucket must be specified.
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
public sealed record DeleteObjectStoreEntriesResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="IndexedDBDomain.DisableAsync"/>.
/// </summary>
public sealed record DisableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="IndexedDBDomain.EnableAsync"/>.
/// </summary>
public sealed record EnableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record RequestDataCommandParameters(string? SecurityOrigin, string? StorageKey, Storage.StorageBucket? StorageBucket, string DatabaseName, string ObjectStoreName, string IndexName, long SkipCount, long PageSize, KeyRange? KeyRange) : Parameters;

/// <summary>
/// Optional parameters for <see cref="IndexedDBDomain.RequestDataAsync"/>.
/// </summary>
public sealed record RequestDataCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// At least and at most one of securityOrigin, storageKey, or storageBucket must be specified.
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

    /// <summary>
    /// Key range.
    /// </summary>
    public KeyRange? KeyRange { get; init; }
}

/// <summary>
/// </summary>
/// <param name="ObjectStoreDataEntries">
/// Array of object store data entries.
/// </param>
/// <param name="HasMore">
/// If true, there are more entries to fetch in the given range.
/// </param>
public sealed record RequestDataResult(IReadOnlyList<DataEntry> ObjectStoreDataEntries, bool HasMore) : EmptyResult;


internal sealed record GetMetadataCommandParameters(string? SecurityOrigin, string? StorageKey, Storage.StorageBucket? StorageBucket, string DatabaseName, string ObjectStoreName) : Parameters;

/// <summary>
/// Optional parameters for <see cref="IndexedDBDomain.GetMetadataAsync"/>.
/// </summary>
public sealed record GetMetadataCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// At least and at most one of securityOrigin, storageKey, or storageBucket must be specified.
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
/// <param name="EntriesCount">
/// the entries count
/// </param>
/// <param name="KeyGeneratorValue">
/// the current value of key generator, to become the next inserted
/// key into the object store. Valid if objectStore.autoIncrement
/// is true.
/// </param>
public sealed record GetMetadataResult(double EntriesCount, double KeyGeneratorValue) : EmptyResult;


internal sealed record RequestDatabaseCommandParameters(string? SecurityOrigin, string? StorageKey, Storage.StorageBucket? StorageBucket, string DatabaseName) : Parameters;

/// <summary>
/// Optional parameters for <see cref="IndexedDBDomain.RequestDatabaseAsync"/>.
/// </summary>
public sealed record RequestDatabaseCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// At least and at most one of securityOrigin, storageKey, or storageBucket must be specified.
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
/// <param name="DatabaseWithObjectStores">
/// Database with an array of object stores.
/// </param>
public sealed record RequestDatabaseResult(DatabaseWithObjectStores DatabaseWithObjectStores) : EmptyResult;


internal sealed record RequestDatabaseNamesCommandParameters(string? SecurityOrigin, string? StorageKey, Storage.StorageBucket? StorageBucket) : Parameters;

/// <summary>
/// Optional parameters for <see cref="IndexedDBDomain.RequestDatabaseNamesAsync"/>.
/// </summary>
public sealed record RequestDatabaseNamesCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// At least and at most one of securityOrigin, storageKey, or storageBucket must be specified.
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
/// <param name="DatabaseNames">
/// Database names for origin.
/// </param>
public sealed record RequestDatabaseNamesResult(IReadOnlyList<string> DatabaseNames) : EmptyResult;


/// <summary>
/// Database with an array of object stores.
/// </summary>
/// <param name="Name">
/// Database name.
/// </param>
/// <param name="Version">
/// Database version (type is not 'integer', as the standard
/// requires the version number to be 'unsigned long long')
/// </param>
/// <param name="ObjectStores">
/// Object stores in this database.
/// </param>
public sealed record DatabaseWithObjectStores(string Name, double Version, IReadOnlyList<ObjectStore> ObjectStores)
{
}

/// <summary>
/// Object store.
/// </summary>
/// <param name="Name">
/// Object store name.
/// </param>
/// <param name="KeyPath">
/// Object store key path.
/// </param>
/// <param name="AutoIncrement">
/// If true, object store has auto increment flag set.
/// </param>
/// <param name="Indexes">
/// Indexes in this object store.
/// </param>
public sealed record ObjectStore(string Name, KeyPath KeyPath, bool AutoIncrement, IReadOnlyList<ObjectStoreIndex> Indexes)
{
}

/// <summary>
/// Object store index.
/// </summary>
/// <param name="Name">
/// Index name.
/// </param>
/// <param name="KeyPath">
/// Index key path.
/// </param>
/// <param name="Unique">
/// If true, index is unique.
/// </param>
/// <param name="MultiEntry">
/// If true, index allows multiple entries for a key.
/// </param>
public sealed record ObjectStoreIndex(string Name, KeyPath KeyPath, bool Unique, bool MultiEntry)
{
}

/// <summary>
/// Key.
/// </summary>
/// <param name="Type">
/// Key type.
/// </param>
public sealed record Key(string Type)
{
    /// <summary>
    /// Number value.
    /// </summary>
    public double? Number { get; init; }

    /// <summary>
    /// String value.
    /// </summary>
    public string? String { get; init; }

    /// <summary>
    /// Date value.
    /// </summary>
    public double? Date { get; init; }

    /// <summary>
    /// Array value.
    /// </summary>
    public IReadOnlyList<Key>? Array { get; init; }
}

/// <summary>
/// Key range.
/// </summary>
/// <param name="LowerOpen">
/// If true lower bound is open.
/// </param>
/// <param name="UpperOpen">
/// If true upper bound is open.
/// </param>
public sealed record KeyRange(bool LowerOpen, bool UpperOpen)
{
    /// <summary>
    /// Lower bound.
    /// </summary>
    public Key? Lower { get; init; }

    /// <summary>
    /// Upper bound.
    /// </summary>
    public Key? Upper { get; init; }
}

/// <summary>
/// Data entry.
/// </summary>
/// <param name="Key">
/// Key object.
/// </param>
/// <param name="PrimaryKey">
/// Primary key object.
/// </param>
/// <param name="Value">
/// Value object.
/// </param>
public sealed record DataEntry(Runtime.RemoteObject Key, Runtime.RemoteObject PrimaryKey, Runtime.RemoteObject Value)
{
}

/// <summary>
/// Key path.
/// </summary>
/// <param name="Type">
/// Key path type.
/// </param>
public sealed record KeyPath(string Type)
{
    /// <summary>
    /// String value.
    /// </summary>
    public string? String { get; init; }

    /// <summary>
    /// Array value.
    /// </summary>
    public IReadOnlyList<string>? Array { get; init; }
}

[JsonSerializable(typeof(ClearObjectStoreCommandParameters), TypeInfoPropertyName = "ClearObjectStoreCommandParameters")]
[JsonSerializable(typeof(ClearObjectStoreResult), TypeInfoPropertyName = "ClearObjectStoreResult")]
[JsonSerializable(typeof(DeleteDatabaseCommandParameters), TypeInfoPropertyName = "DeleteDatabaseCommandParameters")]
[JsonSerializable(typeof(DeleteDatabaseResult), TypeInfoPropertyName = "DeleteDatabaseResult")]
[JsonSerializable(typeof(DeleteObjectStoreEntriesCommandParameters), TypeInfoPropertyName = "DeleteObjectStoreEntriesCommandParameters")]
[JsonSerializable(typeof(DeleteObjectStoreEntriesResult), TypeInfoPropertyName = "DeleteObjectStoreEntriesResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(RequestDataCommandParameters), TypeInfoPropertyName = "RequestDataCommandParameters")]
[JsonSerializable(typeof(RequestDataResult), TypeInfoPropertyName = "RequestDataResult")]
[JsonSerializable(typeof(GetMetadataCommandParameters), TypeInfoPropertyName = "GetMetadataCommandParameters")]
[JsonSerializable(typeof(GetMetadataResult), TypeInfoPropertyName = "GetMetadataResult")]
[JsonSerializable(typeof(RequestDatabaseCommandParameters), TypeInfoPropertyName = "RequestDatabaseCommandParameters")]
[JsonSerializable(typeof(RequestDatabaseResult), TypeInfoPropertyName = "RequestDatabaseResult")]
[JsonSerializable(typeof(RequestDatabaseNamesCommandParameters), TypeInfoPropertyName = "RequestDatabaseNamesCommandParameters")]
[JsonSerializable(typeof(RequestDatabaseNamesResult), TypeInfoPropertyName = "RequestDatabaseNamesResult")]
[JsonSerializable(typeof(DatabaseWithObjectStores), TypeInfoPropertyName = "IndexedDBDatabaseWithObjectStores")]
[JsonSerializable(typeof(ObjectStore), TypeInfoPropertyName = "IndexedDBObjectStore")]
[JsonSerializable(typeof(ObjectStoreIndex), TypeInfoPropertyName = "IndexedDBObjectStoreIndex")]
[JsonSerializable(typeof(Key), TypeInfoPropertyName = "IndexedDBKey")]
[JsonSerializable(typeof(KeyRange), TypeInfoPropertyName = "IndexedDBKeyRange")]
[JsonSerializable(typeof(DataEntry), TypeInfoPropertyName = "IndexedDBDataEntry")]
[JsonSerializable(typeof(KeyPath), TypeInfoPropertyName = "IndexedDBKeyPath")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<DataEntry>), TypeInfoPropertyName = "IReadOnlyListIndexedDBDataEntry")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<ObjectStore>), TypeInfoPropertyName = "IReadOnlyListIndexedDBObjectStore")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<ObjectStoreIndex>), TypeInfoPropertyName = "IReadOnlyListIndexedDBObjectStoreIndex")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<Key>), TypeInfoPropertyName = "IReadOnlyListIndexedDBKey")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class IndexedDBJsonSerializerContext : JsonSerializerContext;

