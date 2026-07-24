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
    /// <param name="databaseName">
    /// Database name.
    /// </param>
    /// <param name="objectStoreName">
    /// Object store name.
    /// </param>
    /// <param name="securityOrigin">
    /// At least and at most one of securityOrigin, storageKey, or storageBucket must be specified.
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
    /// A task representing the asynchronous operation, containing a <see cref="ClearObjectStoreResult"/>.
    /// </returns>
    public async Task<ClearObjectStoreResult> ClearObjectStoreAsync(string databaseName, string objectStoreName, string? securityOrigin = default, string? storageKey = default, Storage.StorageBucket? storageBucket = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearObjectStoreCommandParameters(SecurityOrigin: securityOrigin, StorageKey: storageKey, StorageBucket: storageBucket, DatabaseName: databaseName, ObjectStoreName: objectStoreName);
        return await ExecuteCommandAsync(ClearObjectStoreCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearObjectStoreCommandParameters, ClearObjectStoreResult> ClearObjectStoreCommand = new("IndexedDB.clearObjectStore", JsonContext.ClearObjectStoreCommandParameters, JsonContext.ClearObjectStoreResult);

    /// <summary>
    /// Deletes a database.
    /// </summary>
    /// <param name="databaseName">
    /// Database name.
    /// </param>
    /// <param name="securityOrigin">
    /// At least and at most one of securityOrigin, storageKey, or storageBucket must be specified.
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
    /// A task representing the asynchronous operation, containing a <see cref="DeleteDatabaseResult"/>.
    /// </returns>
    public async Task<DeleteDatabaseResult> DeleteDatabaseAsync(string databaseName, string? securityOrigin = default, string? storageKey = default, Storage.StorageBucket? storageBucket = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DeleteDatabaseCommandParameters(SecurityOrigin: securityOrigin, StorageKey: storageKey, StorageBucket: storageBucket, DatabaseName: databaseName);
        return await ExecuteCommandAsync(DeleteDatabaseCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DeleteDatabaseCommandParameters, DeleteDatabaseResult> DeleteDatabaseCommand = new("IndexedDB.deleteDatabase", JsonContext.DeleteDatabaseCommandParameters, JsonContext.DeleteDatabaseResult);

    /// <summary>
    /// Delete a range of entries from an object store
    /// </summary>
    /// <param name="databaseName">
    /// </param>
    /// <param name="objectStoreName">
    /// </param>
    /// <param name="keyRange">
    /// Range of entry keys to delete
    /// </param>
    /// <param name="securityOrigin">
    /// At least and at most one of securityOrigin, storageKey, or storageBucket must be specified.
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
    /// A task representing the asynchronous operation, containing a <see cref="DeleteObjectStoreEntriesResult"/>.
    /// </returns>
    public async Task<DeleteObjectStoreEntriesResult> DeleteObjectStoreEntriesAsync(string databaseName, string objectStoreName, KeyRange keyRange, string? securityOrigin = default, string? storageKey = default, Storage.StorageBucket? storageBucket = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DeleteObjectStoreEntriesCommandParameters(SecurityOrigin: securityOrigin, StorageKey: storageKey, StorageBucket: storageBucket, DatabaseName: databaseName, ObjectStoreName: objectStoreName, KeyRange: keyRange);
        return await ExecuteCommandAsync(DeleteObjectStoreEntriesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DeleteObjectStoreEntriesCommandParameters, DeleteObjectStoreEntriesResult> DeleteObjectStoreEntriesCommand = new("IndexedDB.deleteObjectStoreEntries", JsonContext.DeleteObjectStoreEntriesCommandParameters, JsonContext.DeleteObjectStoreEntriesResult);

    /// <summary>
    /// Disables events from backend.
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
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("IndexedDB.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Enables events from backend.
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
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("IndexedDB.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Requests data from object store or index.
    /// </summary>
    /// <param name="databaseName">
    /// Database name.
    /// </param>
    /// <param name="objectStoreName">
    /// Object store name.
    /// </param>
    /// <param name="skipCount">
    /// Number of records to skip.
    /// </param>
    /// <param name="pageSize">
    /// Number of records to fetch.
    /// </param>
    /// <param name="securityOrigin">
    /// At least and at most one of securityOrigin, storageKey, or storageBucket must be specified.
    /// Security origin.
    /// </param>
    /// <param name="storageKey">
    /// Storage key.
    /// </param>
    /// <param name="storageBucket">
    /// Storage bucket. If not specified, it uses the default bucket.
    /// </param>
    /// <param name="indexName">
    /// Index name. If not specified, it performs an object store data request.
    /// </param>
    /// <param name="keyRange">
    /// Key range.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RequestDataResult"/>.
    /// </returns>
    public async Task<RequestDataResult> RequestDataAsync(string databaseName, string objectStoreName, long skipCount, long pageSize, string? securityOrigin = default, string? storageKey = default, Storage.StorageBucket? storageBucket = default, string? indexName = default, KeyRange? keyRange = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RequestDataCommandParameters(SecurityOrigin: securityOrigin, StorageKey: storageKey, StorageBucket: storageBucket, DatabaseName: databaseName, ObjectStoreName: objectStoreName, IndexName: indexName, SkipCount: skipCount, PageSize: pageSize, KeyRange: keyRange);
        return await ExecuteCommandAsync(RequestDataCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RequestDataCommandParameters, RequestDataResult> RequestDataCommand = new("IndexedDB.requestData", JsonContext.RequestDataCommandParameters, JsonContext.RequestDataResult);

    /// <summary>
    /// Gets metadata of an object store.
    /// </summary>
    /// <param name="databaseName">
    /// Database name.
    /// </param>
    /// <param name="objectStoreName">
    /// Object store name.
    /// </param>
    /// <param name="securityOrigin">
    /// At least and at most one of securityOrigin, storageKey, or storageBucket must be specified.
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
    /// A task representing the asynchronous operation, containing a <see cref="GetMetadataResult"/>.
    /// </returns>
    public async Task<GetMetadataResult> GetMetadataAsync(string databaseName, string objectStoreName, string? securityOrigin = default, string? storageKey = default, Storage.StorageBucket? storageBucket = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetMetadataCommandParameters(SecurityOrigin: securityOrigin, StorageKey: storageKey, StorageBucket: storageBucket, DatabaseName: databaseName, ObjectStoreName: objectStoreName);
        return await ExecuteCommandAsync(GetMetadataCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetMetadataCommandParameters, GetMetadataResult> GetMetadataCommand = new("IndexedDB.getMetadata", JsonContext.GetMetadataCommandParameters, JsonContext.GetMetadataResult);

    /// <summary>
    /// Requests database with given name in given frame.
    /// </summary>
    /// <param name="databaseName">
    /// Database name.
    /// </param>
    /// <param name="securityOrigin">
    /// At least and at most one of securityOrigin, storageKey, or storageBucket must be specified.
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
    /// A task representing the asynchronous operation, containing a <see cref="RequestDatabaseResult"/>.
    /// </returns>
    public async Task<RequestDatabaseResult> RequestDatabaseAsync(string databaseName, string? securityOrigin = default, string? storageKey = default, Storage.StorageBucket? storageBucket = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RequestDatabaseCommandParameters(SecurityOrigin: securityOrigin, StorageKey: storageKey, StorageBucket: storageBucket, DatabaseName: databaseName);
        return await ExecuteCommandAsync(RequestDatabaseCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RequestDatabaseCommandParameters, RequestDatabaseResult> RequestDatabaseCommand = new("IndexedDB.requestDatabase", JsonContext.RequestDatabaseCommandParameters, JsonContext.RequestDatabaseResult);

    /// <summary>
    /// Requests database names for given security origin.
    /// </summary>
    /// <param name="securityOrigin">
    /// At least and at most one of securityOrigin, storageKey, or storageBucket must be specified.
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
    /// A task representing the asynchronous operation, containing a <see cref="RequestDatabaseNamesResult"/>.
    /// </returns>
    public async Task<RequestDatabaseNamesResult> RequestDatabaseNamesAsync(string? securityOrigin = default, string? storageKey = default, Storage.StorageBucket? storageBucket = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RequestDatabaseNamesCommandParameters(SecurityOrigin: securityOrigin, StorageKey: storageKey, StorageBucket: storageBucket);
        return await ExecuteCommandAsync(RequestDatabaseNamesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RequestDatabaseNamesCommandParameters, RequestDatabaseNamesResult> RequestDatabaseNamesCommand = new("IndexedDB.requestDatabaseNames", JsonContext.RequestDatabaseNamesCommandParameters, JsonContext.RequestDatabaseNamesResult);

}

internal sealed record ClearObjectStoreCommandParameters(string? SecurityOrigin, string? StorageKey, Storage.StorageBucket? StorageBucket, string DatabaseName, string ObjectStoreName) : Parameters;

/// <summary>
/// </summary>
public sealed record ClearObjectStoreResult() : EmptyResult;


internal sealed record DeleteDatabaseCommandParameters(string? SecurityOrigin, string? StorageKey, Storage.StorageBucket? StorageBucket, string DatabaseName) : Parameters;

/// <summary>
/// </summary>
public sealed record DeleteDatabaseResult() : EmptyResult;


internal sealed record DeleteObjectStoreEntriesCommandParameters(string? SecurityOrigin, string? StorageKey, Storage.StorageBucket? StorageBucket, string DatabaseName, string ObjectStoreName, KeyRange KeyRange) : Parameters;

/// <summary>
/// </summary>
public sealed record DeleteObjectStoreEntriesResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record RequestDataCommandParameters(string? SecurityOrigin, string? StorageKey, Storage.StorageBucket? StorageBucket, string DatabaseName, string ObjectStoreName, string? IndexName, long SkipCount, long PageSize, KeyRange? KeyRange) : Parameters;

/// <summary>
/// </summary>
/// <param name="ObjectStoreDataEntries">
/// Array of object store data entries.
/// </param>
/// <param name="HasMore">
/// If true, there are more entries to fetch in the given range.
/// </param>
public sealed record RequestDataResult(ImmutableArray<DataEntry> ObjectStoreDataEntries, bool HasMore) : EmptyResult;


internal sealed record GetMetadataCommandParameters(string? SecurityOrigin, string? StorageKey, Storage.StorageBucket? StorageBucket, string DatabaseName, string ObjectStoreName) : Parameters;

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
/// </summary>
/// <param name="DatabaseWithObjectStores">
/// Database with an array of object stores.
/// </param>
public sealed record RequestDatabaseResult(DatabaseWithObjectStores DatabaseWithObjectStores) : EmptyResult;


internal sealed record RequestDatabaseNamesCommandParameters(string? SecurityOrigin, string? StorageKey, Storage.StorageBucket? StorageBucket) : Parameters;

/// <summary>
/// </summary>
/// <param name="DatabaseNames">
/// Database names for origin.
/// </param>
public sealed record RequestDatabaseNamesResult(ImmutableArray<string> DatabaseNames) : EmptyResult;


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
public sealed record DatabaseWithObjectStores(string Name, double Version, ImmutableArray<ObjectStore> ObjectStores)
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
public sealed record ObjectStore(string Name, KeyPath KeyPath, bool AutoIncrement, ImmutableArray<ObjectStoreIndex> Indexes)
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
    public ImmutableArray<Key>? Array { get; init; }
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
    public ImmutableArray<string>? Array { get; init; }
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
[JsonSerializable(typeof(ImmutableArray<DataEntry>), TypeInfoPropertyName = "ImmutableArrayIndexedDBDataEntry")]
[JsonSerializable(typeof(ImmutableArray<ObjectStore>), TypeInfoPropertyName = "ImmutableArrayIndexedDBObjectStore")]
[JsonSerializable(typeof(ImmutableArray<ObjectStoreIndex>), TypeInfoPropertyName = "ImmutableArrayIndexedDBObjectStoreIndex")]
[JsonSerializable(typeof(ImmutableArray<Key>), TypeInfoPropertyName = "ImmutableArrayIndexedDBKey")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class IndexedDBJsonSerializerContext : JsonSerializerContext;

