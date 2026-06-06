#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.PWA;

/// <summary>
/// This domain allows interacting with the browser to control PWAs.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class PWADomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static PWAJsonSerializerContext JsonContext = PWAJsonSerializerContext.Default;

    /// <summary>
    /// Returns the following OS state for the given manifest id.
    /// </summary>
    /// <param name="manifestId">
    /// The id from the webapp's manifest file, commonly it's the url of the
    /// site installing the webapp. See
    /// https://web.dev/learn/pwa/web-app-manifest.
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetOsAppStateCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetOsAppStateResult"/>.
    /// </returns>
    public async Task<GetOsAppStateResult> GetOsAppStateAsync(string manifestId, GetOsAppStateCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetOsAppStateCommandParameters(ManifestId: manifestId);
        return await ExecuteCommandAsync(GetOsAppStateCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetOsAppStateCommandParameters, GetOsAppStateResult> GetOsAppStateCommand = new("PWA.getOsAppState", JsonContext.GetOsAppStateCommandParameters, JsonContext.GetOsAppStateResult);

    /// <summary>
    /// Installs the given manifest identity, optionally using the given installUrlOrBundleUrl
    /// 
    /// IWA-specific install description:
    /// manifestId corresponds to isolated-app:// + web_package::SignedWebBundleId
    /// 
    /// File installation mode:
    /// The installUrlOrBundleUrl can be either file:// or http(s):// pointing
    /// to a signed web bundle (.swbn). In this case SignedWebBundleId must correspond to
    /// The .swbn file's signing key.
    /// 
    /// Dev proxy installation mode:
    /// installUrlOrBundleUrl must be http(s):// that serves dev mode IWA.
    /// web_package::SignedWebBundleId must be of type dev proxy.
    /// 
    /// The advantage of dev proxy mode is that all changes to IWA
    /// automatically will be reflected in the running app without
    /// reinstallation.
    /// 
    /// To generate bundle id for proxy mode:
    /// 1. Generate 32 random bytes.
    /// 2. Add a specific suffix 0x00 at the end.
    /// 3. Encode the entire sequence using Base32 without padding.
    /// 
    /// If Chrome is not in IWA dev
    /// mode, the installation will fail, regardless of the state of the allowlist.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>InstallUrlOrBundleUrl</b> - The location of the app or bundle overriding the one derived from the manifestId.</description></item>
    /// </list>
    /// </remarks>
    /// <param name="manifestId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="InstallCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="InstallResult"/>.
    /// </returns>
    public async Task<InstallResult> InstallAsync(string manifestId, InstallCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new InstallCommandParameters(ManifestId: manifestId, InstallUrlOrBundleUrl: options?.InstallUrlOrBundleUrl);
        return await ExecuteCommandAsync(InstallCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<InstallCommandParameters, InstallResult> InstallCommand = new("PWA.install", JsonContext.InstallCommandParameters, JsonContext.InstallResult);

    /// <summary>
    /// Uninstalls the given manifest_id and closes any opened app windows.
    /// </summary>
    /// <param name="manifestId">
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
    public async Task<UninstallResult> UninstallAsync(string manifestId, UninstallCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new UninstallCommandParameters(ManifestId: manifestId);
        return await ExecuteCommandAsync(UninstallCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<UninstallCommandParameters, UninstallResult> UninstallCommand = new("PWA.uninstall", JsonContext.UninstallCommandParameters, JsonContext.UninstallResult);

    /// <summary>
    /// Launches the installed web app, or an url in the same web app instead of the
    /// default start url if it is provided. Returns a page Target.TargetID which
    /// can be used to attach to via Target.attachToTarget or similar APIs.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Url</b></description></item>
    /// </list>
    /// </remarks>
    /// <param name="manifestId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="LaunchCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="LaunchResult"/>.
    /// </returns>
    public async Task<LaunchResult> LaunchAsync(string manifestId, LaunchCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new LaunchCommandParameters(ManifestId: manifestId, Url: options?.Url);
        return await ExecuteCommandAsync(LaunchCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<LaunchCommandParameters, LaunchResult> LaunchCommand = new("PWA.launch", JsonContext.LaunchCommandParameters, JsonContext.LaunchResult);

    /// <summary>
    /// Opens one or more local files from an installed web app identified by its
    /// manifestId. The web app needs to have file handlers registered to process
    /// the files. The API returns one or more page Target.TargetIDs which can be
    /// used to attach to via Target.attachToTarget or similar APIs.
    /// If some files in the parameters cannot be handled by the web app, they will
    /// be ignored. If none of the files can be handled, this API returns an error.
    /// If no files are provided as the parameter, this API also returns an error.
    /// 
    /// According to the definition of the file handlers in the manifest file, one
    /// Target.TargetID may represent a page handling one or more files. The order
    /// of the returned Target.TargetIDs is not guaranteed.
    /// 
    /// TODO(crbug.com/339454034): Check the existences of the input files.
    /// </summary>
    /// <param name="manifestId">
    /// </param>
    /// <param name="files">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="LaunchFilesInAppCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="LaunchFilesInAppResult"/>.
    /// </returns>
    public async Task<LaunchFilesInAppResult> LaunchFilesInAppAsync(string manifestId, IEnumerable<string> files, LaunchFilesInAppCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new LaunchFilesInAppCommandParameters(ManifestId: manifestId, Files: files);
        return await ExecuteCommandAsync(LaunchFilesInAppCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<LaunchFilesInAppCommandParameters, LaunchFilesInAppResult> LaunchFilesInAppCommand = new("PWA.launchFilesInApp", JsonContext.LaunchFilesInAppCommandParameters, JsonContext.LaunchFilesInAppResult);

    /// <summary>
    /// Opens the current page in its web app identified by the manifest id, needs
    /// to be called on a page target. This function returns immediately without
    /// waiting for the app to finish loading.
    /// </summary>
    /// <param name="manifestId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="OpenCurrentPageInAppCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="OpenCurrentPageInAppResult"/>.
    /// </returns>
    public async Task<OpenCurrentPageInAppResult> OpenCurrentPageInAppAsync(string manifestId, OpenCurrentPageInAppCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new OpenCurrentPageInAppCommandParameters(ManifestId: manifestId);
        return await ExecuteCommandAsync(OpenCurrentPageInAppCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<OpenCurrentPageInAppCommandParameters, OpenCurrentPageInAppResult> OpenCurrentPageInAppCommand = new("PWA.openCurrentPageInApp", JsonContext.OpenCurrentPageInAppCommandParameters, JsonContext.OpenCurrentPageInAppResult);

    /// <summary>
    /// Changes user settings of the web app identified by its manifestId. If the
    /// app was not installed, this command returns an error. Unset parameters will
    /// be ignored; unrecognized values will cause an error.
    /// 
    /// Unlike the ones defined in the manifest files of the web apps, these
    /// settings are provided by the browser and controlled by the users, they
    /// impact the way the browser handling the web apps.
    /// 
    /// See the comment of each parameter.
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>LinkCapturing</b> - If user allows the links clicked on by the user in the app's scope, or extended scope if the manifest has scope extensions and the flags <b>DesktopPWAsLinkCapturingWithScopeExtensions</b> and <b>WebAppEnableScopeExtensions</b> are enabled.  Note, the API does not support resetting the linkCapturing to the initial value, uninstalling and installing the web app again will reset it.  TODO(crbug.com/339453269): Setting this value on ChromeOS is not supported yet.</description></item>
    /// <item><description><b>DisplayMode</b></description></item>
    /// </list>
    /// </remarks>
    /// <param name="manifestId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ChangeAppUserSettingsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ChangeAppUserSettingsResult"/>.
    /// </returns>
    public async Task<ChangeAppUserSettingsResult> ChangeAppUserSettingsAsync(string manifestId, ChangeAppUserSettingsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ChangeAppUserSettingsCommandParameters(ManifestId: manifestId, LinkCapturing: options?.LinkCapturing, DisplayMode: options?.DisplayMode);
        return await ExecuteCommandAsync(ChangeAppUserSettingsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ChangeAppUserSettingsCommandParameters, ChangeAppUserSettingsResult> ChangeAppUserSettingsCommand = new("PWA.changeAppUserSettings", JsonContext.ChangeAppUserSettingsCommandParameters, JsonContext.ChangeAppUserSettingsResult);

}

internal sealed record GetOsAppStateCommandParameters(string ManifestId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PWADomain.GetOsAppStateAsync"/>.
/// </summary>
public sealed record GetOsAppStateCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="BadgeCount">
/// </param>
/// <param name="FileHandlers">
/// </param>
public sealed record GetOsAppStateResult(long BadgeCount, IReadOnlyList<FileHandler> FileHandlers) : EmptyResult;


internal sealed record InstallCommandParameters(string ManifestId, string? InstallUrlOrBundleUrl) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PWADomain.InstallAsync"/>.
/// </summary>
public sealed record InstallCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// The location of the app or bundle overriding the one derived from the
    /// manifestId.
    /// </summary>
    public string? InstallUrlOrBundleUrl { get; init; }
}

/// <summary>
/// </summary>
public sealed record InstallResult() : EmptyResult;


internal sealed record UninstallCommandParameters(string ManifestId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PWADomain.UninstallAsync"/>.
/// </summary>
public sealed record UninstallCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record UninstallResult() : EmptyResult;


internal sealed record LaunchCommandParameters(string ManifestId, string? Url) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PWADomain.LaunchAsync"/>.
/// </summary>
public sealed record LaunchCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// </summary>
    public string? Url { get; init; }
}

/// <summary>
/// </summary>
/// <param name="TargetId">
/// ID of the tab target created as a result.
/// </param>
public sealed record LaunchResult(Target.TargetID TargetId) : EmptyResult;


internal sealed record LaunchFilesInAppCommandParameters(string ManifestId, IEnumerable<string> Files) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PWADomain.LaunchFilesInAppAsync"/>.
/// </summary>
public sealed record LaunchFilesInAppCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="TargetIds">
/// IDs of the tab targets created as the result.
/// </param>
public sealed record LaunchFilesInAppResult(IReadOnlyList<Target.TargetID> TargetIds) : EmptyResult;


internal sealed record OpenCurrentPageInAppCommandParameters(string ManifestId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PWADomain.OpenCurrentPageInAppAsync"/>.
/// </summary>
public sealed record OpenCurrentPageInAppCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record OpenCurrentPageInAppResult() : EmptyResult;


internal sealed record ChangeAppUserSettingsCommandParameters(string ManifestId, bool? LinkCapturing, DisplayMode? DisplayMode) : Parameters;

/// <summary>
/// Optional parameters for <see cref="PWADomain.ChangeAppUserSettingsAsync"/>.
/// </summary>
public sealed record ChangeAppUserSettingsCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// If user allows the links clicked on by the user in the app's scope, or
    /// extended scope if the manifest has scope extensions and the flags
    /// <b>DesktopPWAsLinkCapturingWithScopeExtensions</b> and
    /// <b>WebAppEnableScopeExtensions</b> are enabled.
    /// 
    /// Note, the API does not support resetting the linkCapturing to the
    /// initial value, uninstalling and installing the web app again will reset
    /// it.
    /// 
    /// TODO(crbug.com/339453269): Setting this value on ChromeOS is not
    /// supported yet.
    /// </summary>
    public bool? LinkCapturing { get; init; }

    /// <summary>
    /// </summary>
    public DisplayMode? DisplayMode { get; init; }
}

/// <summary>
/// </summary>
public sealed record ChangeAppUserSettingsResult() : EmptyResult;


/// <summary>
/// The following types are the replica of
/// https://crsrc.org/c/chrome/browser/web_applications/proto/web_app_os_integration_state.proto;drc=9910d3be894c8f142c977ba1023f30a656bc13fc;l=67
/// </summary>
/// <param name="MediaType">
/// New name of the mimetype according to
/// https://www.iana.org/assignments/media-types/media-types.xhtml
/// </param>
/// <param name="FileExtensions">
/// </param>
public sealed record FileHandlerAccept(string MediaType, IReadOnlyList<string> FileExtensions)
{
}

/// <summary>
/// </summary>
/// <param name="Action">
/// </param>
/// <param name="Accepts">
/// </param>
/// <param name="DisplayName">
/// </param>
public sealed record FileHandler(string Action, IReadOnlyList<FileHandlerAccept> Accepts, string DisplayName)
{
}

/// <summary>
/// If user prefers opening the app in browser or an app window.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<DisplayMode>))]
public enum DisplayMode
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("standalone")]
    Standalone,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("browser")]
    Browser,
}

[JsonSerializable(typeof(GetOsAppStateCommandParameters), TypeInfoPropertyName = "GetOsAppStateCommandParameters")]
[JsonSerializable(typeof(GetOsAppStateResult), TypeInfoPropertyName = "GetOsAppStateResult")]
[JsonSerializable(typeof(InstallCommandParameters), TypeInfoPropertyName = "InstallCommandParameters")]
[JsonSerializable(typeof(InstallResult), TypeInfoPropertyName = "InstallResult")]
[JsonSerializable(typeof(UninstallCommandParameters), TypeInfoPropertyName = "UninstallCommandParameters")]
[JsonSerializable(typeof(UninstallResult), TypeInfoPropertyName = "UninstallResult")]
[JsonSerializable(typeof(LaunchCommandParameters), TypeInfoPropertyName = "LaunchCommandParameters")]
[JsonSerializable(typeof(LaunchResult), TypeInfoPropertyName = "LaunchResult")]
[JsonSerializable(typeof(LaunchFilesInAppCommandParameters), TypeInfoPropertyName = "LaunchFilesInAppCommandParameters")]
[JsonSerializable(typeof(LaunchFilesInAppResult), TypeInfoPropertyName = "LaunchFilesInAppResult")]
[JsonSerializable(typeof(OpenCurrentPageInAppCommandParameters), TypeInfoPropertyName = "OpenCurrentPageInAppCommandParameters")]
[JsonSerializable(typeof(OpenCurrentPageInAppResult), TypeInfoPropertyName = "OpenCurrentPageInAppResult")]
[JsonSerializable(typeof(ChangeAppUserSettingsCommandParameters), TypeInfoPropertyName = "ChangeAppUserSettingsCommandParameters")]
[JsonSerializable(typeof(ChangeAppUserSettingsResult), TypeInfoPropertyName = "ChangeAppUserSettingsResult")]
[JsonSerializable(typeof(FileHandlerAccept), TypeInfoPropertyName = "PWAFileHandlerAccept")]
[JsonSerializable(typeof(FileHandler), TypeInfoPropertyName = "PWAFileHandler")]
[JsonSerializable(typeof(DisplayMode), TypeInfoPropertyName = "PWADisplayMode")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<FileHandler>), TypeInfoPropertyName = "IReadOnlyListPWAFileHandler")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<Target.TargetID>), TypeInfoPropertyName = "IReadOnlyListTargetTargetID")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<FileHandlerAccept>), TypeInfoPropertyName = "IReadOnlyListPWAFileHandlerAccept")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class PWAJsonSerializerContext : JsonSerializerContext;

