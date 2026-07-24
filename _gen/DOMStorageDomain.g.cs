#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.DOMStorage;

/// <summary>
/// Query and modify DOM storage.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public interface IDOMStorage
{
    /// <summary>
    /// </summary>
    /// <param name="storageId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearResult"/>.
    /// </returns>
    Task<ClearResult> ClearAsync(StorageId storageId, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disables storage tracking, prevents storage events from being sent to the client.
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
    Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Enables storage tracking, storage events will now be delivered to the client.
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
    Task<EnableResult> EnableAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <param name="storageId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetDOMStorageItemsResult"/>.
    /// </returns>
    Task<GetDOMStorageItemsResult> GetDOMStorageItemsAsync(StorageId storageId, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <param name="storageId">
    /// </param>
    /// <param name="key">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RemoveDOMStorageItemResult"/>.
    /// </returns>
    Task<RemoveDOMStorageItemResult> RemoveDOMStorageItemAsync(StorageId storageId, string key, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// </summary>
    /// <param name="storageId">
    /// </param>
    /// <param name="key">
    /// </param>
    /// <param name="value">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetDOMStorageItemResult"/>.
    /// </returns>
    Task<SetDOMStorageItemResult> SetDOMStorageItemAsync(StorageId storageId, string key, string value, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DomStorageItemAddedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>StorageId</b></description></item>
    /// <item><description><b>Key</b></description></item>
    /// <item><description><b>NewValue</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<DomStorageItemAddedEventArgs> DomStorageItemAdded { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DomStorageItemRemovedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>StorageId</b></description></item>
    /// <item><description><b>Key</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<DomStorageItemRemovedEventArgs> DomStorageItemRemoved { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DomStorageItemUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>StorageId</b></description></item>
    /// <item><description><b>Key</b></description></item>
    /// <item><description><b>OldValue</b></description></item>
    /// <item><description><b>NewValue</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<DomStorageItemUpdatedEventArgs> DomStorageItemUpdated { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DomStorageItemsClearedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>StorageId</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<DomStorageItemsClearedEventArgs> DomStorageItemsCleared { get; }

}

[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
internal sealed class DOMStorageDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), IDOMStorage
{
    private static DOMStorageJsonSerializerContext JsonContext = DOMStorageJsonSerializerContext.Default;

    public async Task<ClearResult> ClearAsync(StorageId storageId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearCommandParameters(StorageId: storageId);
        return await ExecuteCommandAsync(ClearCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearCommandParameters, ClearResult> ClearCommand = new("DOMStorage.clear", JsonContext.ClearCommandParameters, JsonContext.ClearResult);

    public async Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync(DisableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("DOMStorage.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    public async Task<EnableResult> EnableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters();
        return await ExecuteCommandAsync(EnableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("DOMStorage.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    public async Task<GetDOMStorageItemsResult> GetDOMStorageItemsAsync(StorageId storageId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetDOMStorageItemsCommandParameters(StorageId: storageId);
        return await ExecuteCommandAsync(GetDOMStorageItemsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetDOMStorageItemsCommandParameters, GetDOMStorageItemsResult> GetDOMStorageItemsCommand = new("DOMStorage.getDOMStorageItems", JsonContext.GetDOMStorageItemsCommandParameters, JsonContext.GetDOMStorageItemsResult);

    public async Task<RemoveDOMStorageItemResult> RemoveDOMStorageItemAsync(StorageId storageId, string key, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveDOMStorageItemCommandParameters(StorageId: storageId, Key: key);
        return await ExecuteCommandAsync(RemoveDOMStorageItemCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RemoveDOMStorageItemCommandParameters, RemoveDOMStorageItemResult> RemoveDOMStorageItemCommand = new("DOMStorage.removeDOMStorageItem", JsonContext.RemoveDOMStorageItemCommandParameters, JsonContext.RemoveDOMStorageItemResult);

    public async Task<SetDOMStorageItemResult> SetDOMStorageItemAsync(StorageId storageId, string key, string value, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetDOMStorageItemCommandParameters(StorageId: storageId, Key: key, Value: value);
        return await ExecuteCommandAsync(SetDOMStorageItemCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetDOMStorageItemCommandParameters, SetDOMStorageItemResult> SetDOMStorageItemCommand = new("DOMStorage.setDOMStorageItem", JsonContext.SetDOMStorageItemCommandParameters, JsonContext.SetDOMStorageItemResult);

    public IEventSource<DomStorageItemAddedEventArgs> DomStorageItemAdded => CreateCdpEventSource(DOMStorageDomainEvent.DomStorageItemAdded);
    public IEventSource<DomStorageItemRemovedEventArgs> DomStorageItemRemoved => CreateCdpEventSource(DOMStorageDomainEvent.DomStorageItemRemoved);
    public IEventSource<DomStorageItemUpdatedEventArgs> DomStorageItemUpdated => CreateCdpEventSource(DOMStorageDomainEvent.DomStorageItemUpdated);
    public IEventSource<DomStorageItemsClearedEventArgs> DomStorageItemsCleared => CreateCdpEventSource(DOMStorageDomainEvent.DomStorageItemsCleared);
}

internal sealed record ClearCommandParameters(StorageId StorageId) : Parameters;

/// <summary>
/// </summary>
public sealed record ClearResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record GetDOMStorageItemsCommandParameters(StorageId StorageId) : Parameters;

/// <summary>
/// </summary>
/// <param name="Entries">
/// </param>
public sealed record GetDOMStorageItemsResult(ImmutableArray<ImmutableArray<string>> Entries) : EmptyResult;


internal sealed record RemoveDOMStorageItemCommandParameters(StorageId StorageId, string Key) : Parameters;

/// <summary>
/// </summary>
public sealed record RemoveDOMStorageItemResult() : EmptyResult;


internal sealed record SetDOMStorageItemCommandParameters(StorageId StorageId, string Key, string Value) : Parameters;

/// <summary>
/// </summary>
public sealed record SetDOMStorageItemResult() : EmptyResult;


/// <summary>
/// </summary>
/// <param name="StorageId">
/// </param>
/// <param name="Key">
/// </param>
/// <param name="NewValue">
/// </param>
public sealed record DomStorageItemAddedEventArgs(StorageId StorageId, string Key, string NewValue) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
/// <param name="StorageId">
/// </param>
/// <param name="Key">
/// </param>
public sealed record DomStorageItemRemovedEventArgs(StorageId StorageId, string Key) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
/// <param name="StorageId">
/// </param>
/// <param name="Key">
/// </param>
/// <param name="OldValue">
/// </param>
/// <param name="NewValue">
/// </param>
public sealed record DomStorageItemUpdatedEventArgs(StorageId StorageId, string Key, string OldValue, string NewValue) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
/// <param name="StorageId">
/// </param>
public sealed record DomStorageItemsClearedEventArgs(StorageId StorageId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<SerializedStorageKey>))]
public record SerializedStorageKey : IStringRemoteId
{
    string IStringRemoteId.Id { get; init; } = null!;
}

/// <summary>
/// DOM Storage identifier.
/// </summary>
/// <param name="IsLocalStorage">
/// Whether the storage is local storage (not session storage).
/// </param>
public sealed record StorageId(bool IsLocalStorage)
{
    /// <summary>
    /// Security origin for the storage.
    /// </summary>
    public string? SecurityOrigin { get; init; }

    /// <summary>
    /// Represents a key by which DOM Storage keys its CachedStorageAreas
    /// </summary>
    public SerializedStorageKey? StorageKey { get; init; }
}

/// <summary>
/// DOM Storage item.
/// </summary>

[JsonSerializable(typeof(ClearCommandParameters), TypeInfoPropertyName = "ClearCommandParameters")]
[JsonSerializable(typeof(ClearResult), TypeInfoPropertyName = "ClearResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(GetDOMStorageItemsCommandParameters), TypeInfoPropertyName = "GetDOMStorageItemsCommandParameters")]
[JsonSerializable(typeof(GetDOMStorageItemsResult), TypeInfoPropertyName = "GetDOMStorageItemsResult")]
[JsonSerializable(typeof(RemoveDOMStorageItemCommandParameters), TypeInfoPropertyName = "RemoveDOMStorageItemCommandParameters")]
[JsonSerializable(typeof(RemoveDOMStorageItemResult), TypeInfoPropertyName = "RemoveDOMStorageItemResult")]
[JsonSerializable(typeof(SetDOMStorageItemCommandParameters), TypeInfoPropertyName = "SetDOMStorageItemCommandParameters")]
[JsonSerializable(typeof(SetDOMStorageItemResult), TypeInfoPropertyName = "SetDOMStorageItemResult")]
[JsonSerializable(typeof(CdpEventArgs<DomStorageItemAddedEventArgs>), TypeInfoPropertyName = "DomStorageItemAddedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DomStorageItemRemovedEventArgs>), TypeInfoPropertyName = "DomStorageItemRemovedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DomStorageItemUpdatedEventArgs>), TypeInfoPropertyName = "DomStorageItemUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DomStorageItemsClearedEventArgs>), TypeInfoPropertyName = "DomStorageItemsClearedCdpEventArgs")]
[JsonSerializable(typeof(SerializedStorageKey), TypeInfoPropertyName = "DOMStorageSerializedStorageKey")]
[JsonSerializable(typeof(StorageId), TypeInfoPropertyName = "DOMStorageStorageId")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class DOMStorageJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="IDOMStorage"/>.
/// </summary>
public static class DOMStorageDomainEvent
{
    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DomStorageItemAddedEventArgs>> DomStorageItemAdded { get; } =
        EventDescriptor<CdpEventArgs<DomStorageItemAddedEventArgs>>.Create(
            "goog:cdp.DOMStorage.domStorageItemAdded",
            DOMStorageJsonSerializerContext.Default.DomStorageItemAddedCdpEventArgs);

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DomStorageItemRemovedEventArgs>> DomStorageItemRemoved { get; } =
        EventDescriptor<CdpEventArgs<DomStorageItemRemovedEventArgs>>.Create(
            "goog:cdp.DOMStorage.domStorageItemRemoved",
            DOMStorageJsonSerializerContext.Default.DomStorageItemRemovedCdpEventArgs);

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DomStorageItemUpdatedEventArgs>> DomStorageItemUpdated { get; } =
        EventDescriptor<CdpEventArgs<DomStorageItemUpdatedEventArgs>>.Create(
            "goog:cdp.DOMStorage.domStorageItemUpdated",
            DOMStorageJsonSerializerContext.Default.DomStorageItemUpdatedCdpEventArgs);

    /// <summary>
    /// 
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DomStorageItemsClearedEventArgs>> DomStorageItemsCleared { get; } =
        EventDescriptor<CdpEventArgs<DomStorageItemsClearedEventArgs>>.Create(
            "goog:cdp.DOMStorage.domStorageItemsCleared",
            DOMStorageJsonSerializerContext.Default.DomStorageItemsClearedCdpEventArgs);

}
