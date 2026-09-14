#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Extensions;

/// <summary>
/// Defines commands and events for browser extensions.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public interface IExtensions
{
    /// <summary>
    /// Runs an extension default action.
    /// </summary>
    /// <param name="id">
    /// Extension id.
    /// </param>
    /// <param name="targetId">
    /// A tab target ID to trigger the default extension action on.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="TriggerActionResult"/>.
    /// </returns>
    Task<TriggerActionResult> TriggerActionAsync(string id, string targetId, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Installs an unpacked extension from the filesystem similar to
    /// --load-extension CLI flags. Returns extension ID once the extension
    /// has been installed.
    /// </summary>
    /// <param name="path">
    /// Absolute file path.
    /// </param>
    /// <param name="enableInIncognito">
    /// Enable the extension in incognito
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="LoadUnpackedResult"/>.
    /// </returns>
    Task<LoadUnpackedResult> LoadUnpackedAsync(string path, bool? enableInIncognito = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a list of all unpacked extensions.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetExtensionsResult"/>.
    /// </returns>
    Task<GetExtensionsResult> GetExtensionsAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Uninstalls an unpacked extension (others not supported) from the profile.
    /// </summary>
    /// <param name="id">
    /// Extension id.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="UninstallResult"/>.
    /// </returns>
    Task<UninstallResult> UninstallAsync(string id, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets data from extension storage in the given <b>storageArea</b>. If <b>keys</b> is
    /// specified, these are used to filter the result.
    /// </summary>
    /// <param name="id">
    /// ID of extension.
    /// </param>
    /// <param name="storageArea">
    /// StorageArea to retrieve data from.
    /// </param>
    /// <param name="keys">
    /// Keys to retrieve.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetStorageItemsResult"/>.
    /// </returns>
    Task<GetStorageItemsResult> GetStorageItemsAsync(string id, StorageArea storageArea, ImmutableArray<string>? keys = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Removes <b>keys</b> from extension storage in the given <b>storageArea</b>.
    /// </summary>
    /// <param name="id">
    /// ID of extension.
    /// </param>
    /// <param name="storageArea">
    /// StorageArea to remove data from.
    /// </param>
    /// <param name="keys">
    /// Keys to remove.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RemoveStorageItemsResult"/>.
    /// </returns>
    Task<RemoveStorageItemsResult> RemoveStorageItemsAsync(string id, StorageArea storageArea, ImmutableArray<string> keys, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Clears extension storage in the given <b>storageArea</b>.
    /// </summary>
    /// <param name="id">
    /// ID of extension.
    /// </param>
    /// <param name="storageArea">
    /// StorageArea to remove data from.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearStorageItemsResult"/>.
    /// </returns>
    Task<ClearStorageItemsResult> ClearStorageItemsAsync(string id, StorageArea storageArea, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Sets <b>values</b> in extension storage in the given <b>storageArea</b>. The provided <b>values</b>
    /// will be merged with existing values in the storage area.
    /// </summary>
    /// <param name="id">
    /// ID of extension.
    /// </param>
    /// <param name="storageArea">
    /// StorageArea to set data in.
    /// </param>
    /// <param name="values">
    /// Values to set.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetStorageItemsResult"/>.
    /// </returns>
    Task<SetStorageItemsResult> SetStorageItemsAsync(string id, StorageArea storageArea, global::System.Text.Json.JsonElement values, string? session = null, CancellationToken cancellationToken = default);

}

[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
internal sealed class ExtensionsDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), IExtensions
{
    private static readonly ExtensionsJsonSerializerContext JsonContext = ExtensionsJsonSerializerContext.Default;

    public async Task<TriggerActionResult> TriggerActionAsync(string id, string targetId, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new TriggerActionCommandParameters(Id: id, TargetId: targetId);
        return await ExecuteCommandAsync("Extensions.triggerAction", @params, JsonContext.TriggerActionCommandParameters, JsonContext.TriggerActionResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<LoadUnpackedResult> LoadUnpackedAsync(string path, bool? enableInIncognito = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new LoadUnpackedCommandParameters(Path: path, EnableInIncognito: enableInIncognito);
        return await ExecuteCommandAsync("Extensions.loadUnpacked", @params, JsonContext.LoadUnpackedCommandParameters, JsonContext.LoadUnpackedResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<GetExtensionsResult> GetExtensionsAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetExtensionsCommandParameters();
        return await ExecuteCommandAsync("Extensions.getExtensions", @params, JsonContext.GetExtensionsCommandParameters, JsonContext.GetExtensionsResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<UninstallResult> UninstallAsync(string id, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new UninstallCommandParameters(Id: id);
        return await ExecuteCommandAsync("Extensions.uninstall", @params, JsonContext.UninstallCommandParameters, JsonContext.UninstallResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<GetStorageItemsResult> GetStorageItemsAsync(string id, StorageArea storageArea, ImmutableArray<string>? keys = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetStorageItemsCommandParameters(Id: id, StorageArea: storageArea, Keys: keys);
        return await ExecuteCommandAsync("Extensions.getStorageItems", @params, JsonContext.GetStorageItemsCommandParameters, JsonContext.GetStorageItemsResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<RemoveStorageItemsResult> RemoveStorageItemsAsync(string id, StorageArea storageArea, ImmutableArray<string> keys, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveStorageItemsCommandParameters(Id: id, StorageArea: storageArea, Keys: keys);
        return await ExecuteCommandAsync("Extensions.removeStorageItems", @params, JsonContext.RemoveStorageItemsCommandParameters, JsonContext.RemoveStorageItemsResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<ClearStorageItemsResult> ClearStorageItemsAsync(string id, StorageArea storageArea, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new ClearStorageItemsCommandParameters(Id: id, StorageArea: storageArea);
        return await ExecuteCommandAsync("Extensions.clearStorageItems", @params, JsonContext.ClearStorageItemsCommandParameters, JsonContext.ClearStorageItemsResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<SetStorageItemsResult> SetStorageItemsAsync(string id, StorageArea storageArea, global::System.Text.Json.JsonElement values, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SetStorageItemsCommandParameters(Id: id, StorageArea: storageArea, Values: values);
        return await ExecuteCommandAsync("Extensions.setStorageItems", @params, JsonContext.SetStorageItemsCommandParameters, JsonContext.SetStorageItemsResult, session, cancellationToken).ConfigureAwait(false);
    }

}

internal sealed record TriggerActionCommandParameters(string Id, string TargetId) : Parameters;

/// <summary>
/// Result of the <see cref="IExtensions.TriggerActionAsync"/> command.
/// </summary>
public sealed record TriggerActionResult() : EmptyResult;


internal sealed record LoadUnpackedCommandParameters(string Path, bool? EnableInIncognito) : Parameters;

/// <summary>
/// Result of the <see cref="IExtensions.LoadUnpackedAsync"/> command.
/// </summary>
/// <param name="Id">
/// Extension id.
/// </param>
public sealed record LoadUnpackedResult(string Id) : EmptyResult;


internal sealed record GetExtensionsCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IExtensions.GetExtensionsAsync"/> command.
/// </summary>
/// <param name="Extensions">
/// </param>
public sealed record GetExtensionsResult(ImmutableArray<ExtensionInfo> Extensions) : EmptyResult;


internal sealed record UninstallCommandParameters(string Id) : Parameters;

/// <summary>
/// Result of the <see cref="IExtensions.UninstallAsync"/> command.
/// </summary>
public sealed record UninstallResult() : EmptyResult;


internal sealed record GetStorageItemsCommandParameters(string Id, StorageArea StorageArea, ImmutableArray<string>? Keys) : Parameters;

/// <summary>
/// Result of the <see cref="IExtensions.GetStorageItemsAsync"/> command.
/// </summary>
/// <param name="Data">
/// </param>
public sealed record GetStorageItemsResult(global::System.Text.Json.JsonElement Data) : EmptyResult;


internal sealed record RemoveStorageItemsCommandParameters(string Id, StorageArea StorageArea, ImmutableArray<string> Keys) : Parameters;

/// <summary>
/// Result of the <see cref="IExtensions.RemoveStorageItemsAsync"/> command.
/// </summary>
public sealed record RemoveStorageItemsResult() : EmptyResult;


internal sealed record ClearStorageItemsCommandParameters(string Id, StorageArea StorageArea) : Parameters;

/// <summary>
/// Result of the <see cref="IExtensions.ClearStorageItemsAsync"/> command.
/// </summary>
public sealed record ClearStorageItemsResult() : EmptyResult;


internal sealed record SetStorageItemsCommandParameters(string Id, StorageArea StorageArea, global::System.Text.Json.JsonElement Values) : Parameters;

/// <summary>
/// Result of the <see cref="IExtensions.SetStorageItemsAsync"/> command.
/// </summary>
public sealed record SetStorageItemsResult() : EmptyResult;


/// <summary>
/// Storage areas.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<StorageArea>))]
public enum StorageArea
{
    /// <summary>
    /// Corresponds to the <c>"session"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("session")]
    Session,
    /// <summary>
    /// Corresponds to the <c>"local"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("local")]
    Local,
    /// <summary>
    /// Corresponds to the <c>"sync"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("sync")]
    Sync,
    /// <summary>
    /// Corresponds to the <c>"managed"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("managed")]
    Managed,
}

/// <summary>
/// Detailed information about an extension.
/// </summary>
/// <param name="Id">
/// Extension id.
/// </param>
/// <param name="Name">
/// Extension name.
/// </param>
/// <param name="Version">
/// Extension version.
/// </param>
/// <param name="Path">
/// The path from which the extension was loaded.
/// </param>
/// <param name="Enabled">
/// Extension enabled status.
/// </param>
public sealed record ExtensionInfo(string Id, string Name, string Version, string Path, bool Enabled)
{
}

[JsonSerializable(typeof(TriggerActionCommandParameters), TypeInfoPropertyName = "TriggerActionCommandParameters")]
[JsonSerializable(typeof(TriggerActionResult), TypeInfoPropertyName = "TriggerActionResult")]
[JsonSerializable(typeof(LoadUnpackedCommandParameters), TypeInfoPropertyName = "LoadUnpackedCommandParameters")]
[JsonSerializable(typeof(LoadUnpackedResult), TypeInfoPropertyName = "LoadUnpackedResult")]
[JsonSerializable(typeof(GetExtensionsCommandParameters), TypeInfoPropertyName = "GetExtensionsCommandParameters")]
[JsonSerializable(typeof(GetExtensionsResult), TypeInfoPropertyName = "GetExtensionsResult")]
[JsonSerializable(typeof(UninstallCommandParameters), TypeInfoPropertyName = "UninstallCommandParameters")]
[JsonSerializable(typeof(UninstallResult), TypeInfoPropertyName = "UninstallResult")]
[JsonSerializable(typeof(GetStorageItemsCommandParameters), TypeInfoPropertyName = "GetStorageItemsCommandParameters")]
[JsonSerializable(typeof(GetStorageItemsResult), TypeInfoPropertyName = "GetStorageItemsResult")]
[JsonSerializable(typeof(RemoveStorageItemsCommandParameters), TypeInfoPropertyName = "RemoveStorageItemsCommandParameters")]
[JsonSerializable(typeof(RemoveStorageItemsResult), TypeInfoPropertyName = "RemoveStorageItemsResult")]
[JsonSerializable(typeof(ClearStorageItemsCommandParameters), TypeInfoPropertyName = "ClearStorageItemsCommandParameters")]
[JsonSerializable(typeof(ClearStorageItemsResult), TypeInfoPropertyName = "ClearStorageItemsResult")]
[JsonSerializable(typeof(SetStorageItemsCommandParameters), TypeInfoPropertyName = "SetStorageItemsCommandParameters")]
[JsonSerializable(typeof(SetStorageItemsResult), TypeInfoPropertyName = "SetStorageItemsResult")]
[JsonSerializable(typeof(StorageArea), TypeInfoPropertyName = "ExtensionsStorageArea")]
[JsonSerializable(typeof(ExtensionInfo), TypeInfoPropertyName = "ExtensionsExtensionInfo")]
[JsonSerializable(typeof(ImmutableArray<ExtensionInfo>), TypeInfoPropertyName = "ImmutableArrayExtensionsExtensionInfo")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class ExtensionsJsonSerializerContext : JsonSerializerContext;

