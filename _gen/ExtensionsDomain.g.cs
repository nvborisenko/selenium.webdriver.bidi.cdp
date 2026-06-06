#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Extensions;

/// <summary>
/// Defines commands and events for browser extensions.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class ExtensionsDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static ExtensionsJsonSerializerContext JsonContext = ExtensionsJsonSerializerContext.Default;

    /// <summary>
    /// Installs an unpacked extension from the filesystem similar to
    /// --load-extension CLI flags. Returns extension ID once the extension
    /// has been installed. Available if the client is connected using the
    /// --remote-debugging-pipe flag and the --enable-unsafe-extension-debugging
    /// flag is set.
    /// </summary>
    /// <param name="path">
    /// Absolute file path.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="LoadUnpackedCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="LoadUnpackedResult"/>.
    /// </returns>
    public async Task<LoadUnpackedResult> LoadUnpackedAsync(string path, LoadUnpackedCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new LoadUnpackedCommandParameters(Path: path);
        return await ExecuteCommandAsync(LoadUnpackedCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<LoadUnpackedCommandParameters, LoadUnpackedResult> LoadUnpackedCommand = new("Extensions.loadUnpacked", JsonContext.LoadUnpackedCommandParameters, JsonContext.LoadUnpackedResult);

    /// <summary>
    /// Uninstalls an unpacked extension (others not supported) from the profile.
    /// Available if the client is connected using the --remote-debugging-pipe flag
    /// and the --enable-unsafe-extension-debugging.
    /// </summary>
    /// <param name="id">
    /// Extension id.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="UninstallCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="UninstallResult"/>.
    /// </returns>
    public async Task<UninstallResult> UninstallAsync(string id, UninstallCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new UninstallCommandParameters(Id: id);
        return await ExecuteCommandAsync(UninstallCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<UninstallCommandParameters, UninstallResult> UninstallCommand = new("Extensions.uninstall", JsonContext.UninstallCommandParameters, JsonContext.UninstallResult);

    /// <summary>
    /// Gets data from extension storage in the given <b>storageArea</b>. If <b>keys</b> is
    /// specified, these are used to filter the result.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Keys</b> - Keys to retrieve.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="id">
    /// ID of extension.
    /// </param>
    /// <param name="storageArea">
    /// StorageArea to retrieve data from.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetStorageItemsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetStorageItemsResult"/>.
    /// </returns>
    public async Task<GetStorageItemsResult> GetStorageItemsAsync(string id, StorageArea storageArea, GetStorageItemsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetStorageItemsCommandParameters(Id: id, StorageArea: storageArea, Keys: options?.Keys);
        return await ExecuteCommandAsync(GetStorageItemsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetStorageItemsCommandParameters, GetStorageItemsResult> GetStorageItemsCommand = new("Extensions.getStorageItems", JsonContext.GetStorageItemsCommandParameters, JsonContext.GetStorageItemsResult);

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
    /// <param name="options">
    /// Optional parameters. See <see cref="RemoveStorageItemsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RemoveStorageItemsResult"/>.
    /// </returns>
    public async Task<RemoveStorageItemsResult> RemoveStorageItemsAsync(string id, StorageArea storageArea, IEnumerable<string> keys, RemoveStorageItemsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveStorageItemsCommandParameters(Id: id, StorageArea: storageArea, Keys: keys);
        return await ExecuteCommandAsync(RemoveStorageItemsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RemoveStorageItemsCommandParameters, RemoveStorageItemsResult> RemoveStorageItemsCommand = new("Extensions.removeStorageItems", JsonContext.RemoveStorageItemsCommandParameters, JsonContext.RemoveStorageItemsResult);

    /// <summary>
    /// Clears extension storage in the given <b>storageArea</b>.
    /// </summary>
    /// <param name="id">
    /// ID of extension.
    /// </param>
    /// <param name="storageArea">
    /// StorageArea to remove data from.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ClearStorageItemsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ClearStorageItemsResult"/>.
    /// </returns>
    public async Task<ClearStorageItemsResult> ClearStorageItemsAsync(string id, StorageArea storageArea, ClearStorageItemsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ClearStorageItemsCommandParameters(Id: id, StorageArea: storageArea);
        return await ExecuteCommandAsync(ClearStorageItemsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ClearStorageItemsCommandParameters, ClearStorageItemsResult> ClearStorageItemsCommand = new("Extensions.clearStorageItems", JsonContext.ClearStorageItemsCommandParameters, JsonContext.ClearStorageItemsResult);

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
    /// <param name="options">
    /// Optional parameters. See <see cref="SetStorageItemsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetStorageItemsResult"/>.
    /// </returns>
    public async Task<SetStorageItemsResult> SetStorageItemsAsync(string id, StorageArea storageArea, global::System.Text.Json.JsonElement values, SetStorageItemsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetStorageItemsCommandParameters(Id: id, StorageArea: storageArea, Values: values);
        return await ExecuteCommandAsync(SetStorageItemsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetStorageItemsCommandParameters, SetStorageItemsResult> SetStorageItemsCommand = new("Extensions.setStorageItems", JsonContext.SetStorageItemsCommandParameters, JsonContext.SetStorageItemsResult);

}

internal sealed record LoadUnpackedCommandParameters(string Path) : Parameters;

/// <summary>
/// Optional parameters for <see cref="ExtensionsDomain.LoadUnpackedAsync"/>.
/// </summary>
public sealed record LoadUnpackedCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Id">
/// Extension id.
/// </param>
public sealed record LoadUnpackedResult(string Id) : EmptyResult;


internal sealed record UninstallCommandParameters(string Id) : Parameters;

/// <summary>
/// Optional parameters for <see cref="ExtensionsDomain.UninstallAsync"/>.
/// </summary>
public sealed record UninstallCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record UninstallResult() : EmptyResult;


internal sealed record GetStorageItemsCommandParameters(string Id, StorageArea StorageArea, IEnumerable<string>? Keys) : Parameters;

/// <summary>
/// Optional parameters for <see cref="ExtensionsDomain.GetStorageItemsAsync"/>.
/// </summary>
public sealed record GetStorageItemsCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// Keys to retrieve.
    /// </summary>
    public IEnumerable<string>? Keys { get; init; }
}

/// <summary>
/// </summary>
/// <param name="Data">
/// </param>
public sealed record GetStorageItemsResult(global::System.Text.Json.JsonElement Data) : EmptyResult;


internal sealed record RemoveStorageItemsCommandParameters(string Id, StorageArea StorageArea, IEnumerable<string> Keys) : Parameters;

/// <summary>
/// Optional parameters for <see cref="ExtensionsDomain.RemoveStorageItemsAsync"/>.
/// </summary>
public sealed record RemoveStorageItemsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record RemoveStorageItemsResult() : EmptyResult;


internal sealed record ClearStorageItemsCommandParameters(string Id, StorageArea StorageArea) : Parameters;

/// <summary>
/// Optional parameters for <see cref="ExtensionsDomain.ClearStorageItemsAsync"/>.
/// </summary>
public sealed record ClearStorageItemsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ClearStorageItemsResult() : EmptyResult;


internal sealed record SetStorageItemsCommandParameters(string Id, StorageArea StorageArea, global::System.Text.Json.JsonElement Values) : Parameters;

/// <summary>
/// Optional parameters for <see cref="ExtensionsDomain.SetStorageItemsAsync"/>.
/// </summary>
public sealed record SetStorageItemsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record SetStorageItemsResult() : EmptyResult;


/// <summary>
/// Storage areas.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<StorageArea>))]
public enum StorageArea
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("session")]
    Session,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("local")]
    Local,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("sync")]
    Sync,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("managed")]
    Managed,
}

[JsonSerializable(typeof(LoadUnpackedCommandParameters), TypeInfoPropertyName = "LoadUnpackedCommandParameters")]
[JsonSerializable(typeof(LoadUnpackedResult), TypeInfoPropertyName = "LoadUnpackedResult")]
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
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class ExtensionsJsonSerializerContext : JsonSerializerContext;

