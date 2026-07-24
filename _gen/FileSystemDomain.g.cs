#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.FileSystem;

/// <summary>
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class FileSystemDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static FileSystemJsonSerializerContext JsonContext = FileSystemJsonSerializerContext.Default;

    /// <summary>
    /// </summary>
    /// <param name="bucketFileSystemLocator">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetDirectoryCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetDirectoryResult"/>.
    /// </returns>
    public async Task<GetDirectoryResult> GetDirectoryAsync(BucketFileSystemLocator bucketFileSystemLocator, GetDirectoryCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetDirectoryCommandParameters(BucketFileSystemLocator: bucketFileSystemLocator);
        return await ExecuteCommandAsync(GetDirectoryCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetDirectoryCommandParameters, GetDirectoryResult> GetDirectoryCommand = new("FileSystem.getDirectory", JsonContext.GetDirectoryCommandParameters, JsonContext.GetDirectoryResult);

}

internal sealed record GetDirectoryCommandParameters(BucketFileSystemLocator BucketFileSystemLocator) : Parameters;

/// <summary>
/// Optional parameters for <see cref="FileSystemDomain.GetDirectoryAsync"/>.
/// </summary>
public sealed record GetDirectoryCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Directory">
/// Returns the directory object at the path.
/// </param>
public sealed record GetDirectoryResult(Directory Directory) : EmptyResult;


/// <summary>
/// </summary>
/// <param name="Name">
/// </param>
/// <param name="LastModified">
/// Timestamp
/// </param>
/// <param name="Size">
/// Size in bytes
/// </param>
/// <param name="Type">
/// </param>
public sealed record File(string Name, Network.TimeSinceEpoch LastModified, double Size, string Type)
{
}

/// <summary>
/// </summary>
/// <param name="Name">
/// </param>
/// <param name="NestedDirectories">
/// </param>
/// <param name="NestedFiles">
/// Files that are directly nested under this directory.
/// </param>
public sealed record Directory(string Name, ImmutableArray<string> NestedDirectories, ImmutableArray<File> NestedFiles)
{
}

/// <summary>
/// </summary>
/// <param name="StorageKey">
/// Storage key
/// </param>
/// <param name="PathComponents">
/// Path to the directory using each path component as an array item.
/// </param>
public sealed record BucketFileSystemLocator(Storage.SerializedStorageKey StorageKey, ImmutableArray<string> PathComponents)
{
    /// <summary>
    /// Bucket name. Not passing a <b>bucketName</b> will retrieve the default Bucket. (https://developer.mozilla.org/en-US/docs/Web/API/Storage_API#storage_buckets)
    /// </summary>
    public string? BucketName { get; init; }
}

[JsonSerializable(typeof(GetDirectoryCommandParameters), TypeInfoPropertyName = "GetDirectoryCommandParameters")]
[JsonSerializable(typeof(GetDirectoryResult), TypeInfoPropertyName = "GetDirectoryResult")]
[JsonSerializable(typeof(File), TypeInfoPropertyName = "FileSystemFile")]
[JsonSerializable(typeof(Directory), TypeInfoPropertyName = "FileSystemDirectory")]
[JsonSerializable(typeof(BucketFileSystemLocator), TypeInfoPropertyName = "FileSystemBucketFileSystemLocator")]
[JsonSerializable(typeof(ImmutableArray<File>), TypeInfoPropertyName = "ImmutableArrayFileSystemFile")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class FileSystemJsonSerializerContext : JsonSerializerContext;

