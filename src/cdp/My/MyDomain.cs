using System.Text.Json.Serialization;
using OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.My;

/// <summary>
/// Example domain demonstrating hand-written CDP domain usage.
/// </summary>
public sealed class MyDomain(CdpModule cdp) : Domain(cdp)
{
    private static readonly MyJsonSerializerContext JsonContext = MyJsonSerializerContext.Default;

    private static readonly CdpCommand<EnableParameters, EnableResult> EnableCommand = new("Network.enable", JsonContext.EnableParameters, JsonContext.EnableResult);

    /// <summary>
    /// Enables network tracking.
    /// </summary>
    public async Task<EnableResult> EnableAsync(EnableOptions? options = null, CancellationToken cancellationToken = default)
    {
        var parameters = new EnableParameters(options?.MaxTotalBufferSize, options?.MaxResourceBufferSize, options?.PostDataSizeLimit);

        return await ExecuteCommandAsync(EnableCommand, parameters, options, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Fired when something happened.
    /// </summary>
    public IEventSource<SomethingHappenedEventArgs> SomethingHappened
        => CreateCdpEventSource(MyEvent.SomethingHappened);
}

internal record EnableParameters(int? MaxTotalBufferSize, int? MaxResourceBufferSize, int? PostDataSizeLimit) : Parameters;

/// <summary>
/// Optional parameters for <see cref="MyDomain.EnableAsync"/>.
/// </summary>
public record EnableOptions : CdpCommandOptions
{
    /// <summary>Maximum total buffer size.</summary>
    public int? MaxTotalBufferSize { get; set; }

    /// <summary>Maximum resource buffer size.</summary>
    public int? MaxResourceBufferSize { get; set; }

    /// <summary>Post data size limit.</summary>
    public int? PostDataSizeLimit { get; set; }
}

/// <summary>
/// Result of <see cref="MyDomain.EnableAsync"/>.
/// </summary>
public record EnableResult : EmptyResult;

/// <summary>
/// Event args for the <c>goog:cdp.Page.lifecycleEvent</c> event.
/// </summary>
/// <param name="FrameId">Frame identifier.</param>
/// <param name="LoaderId">Loader identifier.</param>
public record SomethingHappenedEventArgs(string FrameId, string LoaderId) : OpenQA.Selenium.BiDi.EventArgs;

[JsonSerializable(typeof(EnableParameters))]
[JsonSerializable(typeof(EnableResult))]
[JsonSerializable(typeof(CdpEventArgs<SomethingHappenedEventArgs>), TypeInfoPropertyName = "SomethingHappenedCdpEventArgs")]

[JsonSourceGenerationOptions(
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class MyJsonSerializerContext : JsonSerializerContext;
