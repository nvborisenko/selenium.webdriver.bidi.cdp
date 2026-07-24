#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Tethering;

/// <summary>
/// The Tethering domain defines methods and events for browser port binding.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class TetheringDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static TetheringJsonSerializerContext JsonContext = TetheringJsonSerializerContext.Default;

    /// <summary>
    /// Request browser port binding.
    /// </summary>
    /// <param name="port">
    /// Port number to bind.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="BindResult"/>.
    /// </returns>
    public async Task<BindResult> BindAsync(long port, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new BindCommandParameters(Port: port);
        return await ExecuteCommandAsync(BindCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<BindCommandParameters, BindResult> BindCommand = new("Tethering.bind", JsonContext.BindCommandParameters, JsonContext.BindResult);

    /// <summary>
    /// Request browser port unbinding.
    /// </summary>
    /// <param name="port">
    /// Port number to unbind.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="UnbindResult"/>.
    /// </returns>
    public async Task<UnbindResult> UnbindAsync(long port, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new UnbindCommandParameters(Port: port);
        return await ExecuteCommandAsync(UnbindCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<UnbindCommandParameters, UnbindResult> UnbindCommand = new("Tethering.unbind", JsonContext.UnbindCommandParameters, JsonContext.UnbindResult);

    /// <summary>
    /// Informs that port was successfully bound and got a specified connection id.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="AcceptedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Port</b> - Port number that was successfully bound.</description></item>
    /// <item><description><b>ConnectionId</b> - Connection id to be used.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<AcceptedEventArgs> Accepted => CreateCdpEventSource(TetheringDomainEvent.Accepted);
}

internal sealed record BindCommandParameters(long Port) : Parameters;

/// <summary>
/// </summary>
public sealed record BindResult() : EmptyResult;


internal sealed record UnbindCommandParameters(long Port) : Parameters;

/// <summary>
/// </summary>
public sealed record UnbindResult() : EmptyResult;


/// <summary>
/// Informs that port was successfully bound and got a specified connection id.
/// </summary>
/// <param name="Port">
/// Port number that was successfully bound.
/// </param>
/// <param name="ConnectionId">
/// Connection id to be used.
/// </param>
public sealed record AcceptedEventArgs(long Port, string ConnectionId) : OpenQA.Selenium.BiDi.EventArgs;

[JsonSerializable(typeof(BindCommandParameters), TypeInfoPropertyName = "BindCommandParameters")]
[JsonSerializable(typeof(BindResult), TypeInfoPropertyName = "BindResult")]
[JsonSerializable(typeof(UnbindCommandParameters), TypeInfoPropertyName = "UnbindCommandParameters")]
[JsonSerializable(typeof(UnbindResult), TypeInfoPropertyName = "UnbindResult")]
[JsonSerializable(typeof(CdpEventArgs<AcceptedEventArgs>), TypeInfoPropertyName = "AcceptedCdpEventArgs")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class TetheringJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="TetheringDomain"/>.
/// </summary>
public static class TetheringDomainEvent
{
    /// <summary>
    /// Informs that port was successfully bound and got a specified connection id.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<AcceptedEventArgs>> Accepted { get; } =
        EventDescriptor<CdpEventArgs<AcceptedEventArgs>>.Create(
            "goog:cdp.Tethering.accepted",
            TetheringJsonSerializerContext.Default.AcceptedCdpEventArgs);

}
