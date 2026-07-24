using System.Text.Json.Serialization;
using OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.My;

/// <summary>
/// Example domain demonstrating hand-written CDP domain usage.
/// </summary>
internal sealed class MyDomain(CdpModule cdp) : Domain(cdp)
{
    private static readonly MyJsonSerializerContext JsonContext = MyJsonSerializerContext.Default;

    private static readonly CdpCommand<EnableParameters, EnableResult> EnableCommand = new("Network.enable", JsonContext.EnableParameters, JsonContext.EnableResult);

    /// <summary>
    /// Enables network tracking.
    /// </summary>
    public async Task<EnableResult> EnableAsync(
        int? maxTotalBufferSize = default,
        int? maxResourceBufferSize = default,
        int? postDataSizeLimit = default,
        string? session = default,
        CancellationToken cancellationToken = default)
    {
        var parameters = new EnableParameters(maxTotalBufferSize, maxResourceBufferSize, postDataSizeLimit);

        return await ExecuteCommandAsync(EnableCommand, parameters, session, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Fired when something happened.
    /// </summary>
    public IEventSource<SomethingHappenedEventArgs> SomethingHappened
        => CreateCdpEventSource(MyEvent.SomethingHappened);
}

internal record EnableParameters(int? MaxTotalBufferSize, int? MaxResourceBufferSize, int? PostDataSizeLimit) : Parameters;

/// <summary>
/// Result of <see cref="MyDomain.EnableAsync"/>.
/// </summary>
internal record EnableResult : EmptyResult;

/// <summary>
/// Event args for the <c>goog:cdp.Page.lifecycleEvent</c> event.
/// </summary>
/// <param name="FrameId">Frame identifier.</param>
/// <param name="LoaderId">Loader identifier.</param>
internal record SomethingHappenedEventArgs(string FrameId, string LoaderId) : OpenQA.Selenium.BiDi.EventArgs;

[JsonSerializable(typeof(EnableParameters))]
[JsonSerializable(typeof(EnableResult))]
[JsonSerializable(typeof(CdpEventArgs<SomethingHappenedEventArgs>), TypeInfoPropertyName = "SomethingHappenedCdpEventArgs")]

[JsonSourceGenerationOptions(
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class MyJsonSerializerContext : JsonSerializerContext;
