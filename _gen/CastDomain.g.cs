#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Cast;

/// <summary>
/// A domain for interacting with Cast, Presentation API, and Remote Playback API
/// functionalities.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class CastDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static CastJsonSerializerContext JsonContext = CastJsonSerializerContext.Default;

    /// <summary>
    /// Starts observing for sinks that can be used for tab mirroring, and if set,
    /// sinks compatible with |presentationUrl| as well. When sinks are found, a
    /// |sinksUpdated| event is fired.
    /// Also starts observing for issue messages. When an issue is added or removed,
    /// an |issueUpdated| event is fired.
    /// </summary>
    /// <param name="presentationUrl">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="EnableResult"/>.
    /// </returns>
    public async Task<EnableResult> EnableAsync(string? presentationUrl = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters(PresentationUrl: presentationUrl);
        return await ExecuteCommandAsync(EnableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("Cast.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Stops observing for sinks and issues.
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
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("Cast.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Sets a sink to be used when the web page requests the browser to choose a
    /// sink via Presentation API, Remote Playback API, or Cast SDK.
    /// </summary>
    /// <param name="sinkName">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetSinkToUseResult"/>.
    /// </returns>
    public async Task<SetSinkToUseResult> SetSinkToUseAsync(string sinkName, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetSinkToUseCommandParameters(SinkName: sinkName);
        return await ExecuteCommandAsync(SetSinkToUseCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetSinkToUseCommandParameters, SetSinkToUseResult> SetSinkToUseCommand = new("Cast.setSinkToUse", JsonContext.SetSinkToUseCommandParameters, JsonContext.SetSinkToUseResult);

    /// <summary>
    /// Starts mirroring the desktop to the sink.
    /// </summary>
    /// <param name="sinkName">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StartDesktopMirroringResult"/>.
    /// </returns>
    public async Task<StartDesktopMirroringResult> StartDesktopMirroringAsync(string sinkName, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new StartDesktopMirroringCommandParameters(SinkName: sinkName);
        return await ExecuteCommandAsync(StartDesktopMirroringCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StartDesktopMirroringCommandParameters, StartDesktopMirroringResult> StartDesktopMirroringCommand = new("Cast.startDesktopMirroring", JsonContext.StartDesktopMirroringCommandParameters, JsonContext.StartDesktopMirroringResult);

    /// <summary>
    /// Starts mirroring the tab to the sink.
    /// </summary>
    /// <param name="sinkName">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StartTabMirroringResult"/>.
    /// </returns>
    public async Task<StartTabMirroringResult> StartTabMirroringAsync(string sinkName, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new StartTabMirroringCommandParameters(SinkName: sinkName);
        return await ExecuteCommandAsync(StartTabMirroringCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StartTabMirroringCommandParameters, StartTabMirroringResult> StartTabMirroringCommand = new("Cast.startTabMirroring", JsonContext.StartTabMirroringCommandParameters, JsonContext.StartTabMirroringResult);

    /// <summary>
    /// Stops the active Cast session on the sink.
    /// </summary>
    /// <param name="sinkName">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="StopCastingResult"/>.
    /// </returns>
    public async Task<StopCastingResult> StopCastingAsync(string sinkName, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new StopCastingCommandParameters(SinkName: sinkName);
        return await ExecuteCommandAsync(StopCastingCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<StopCastingCommandParameters, StopCastingResult> StopCastingCommand = new("Cast.stopCasting", JsonContext.StopCastingCommandParameters, JsonContext.StopCastingResult);

    /// <summary>
    /// This is fired whenever the list of available sinks changes. A sink is a
    /// device or a software surface that you can cast to.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="SinksUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Sinks</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<SinksUpdatedEventArgs> SinksUpdated => CreateCdpEventSource(CastDomainEvent.SinksUpdated);
    /// <summary>
    /// This is fired whenever the outstanding issue/error message changes.
    /// |issueMessage| is empty if there is no issue.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="IssueUpdatedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>IssueMessage</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<IssueUpdatedEventArgs> IssueUpdated => CreateCdpEventSource(CastDomainEvent.IssueUpdated);
}

internal sealed record EnableCommandParameters(string? PresentationUrl) : Parameters;

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record SetSinkToUseCommandParameters(string SinkName) : Parameters;

/// <summary>
/// </summary>
public sealed record SetSinkToUseResult() : EmptyResult;


internal sealed record StartDesktopMirroringCommandParameters(string SinkName) : Parameters;

/// <summary>
/// </summary>
public sealed record StartDesktopMirroringResult() : EmptyResult;


internal sealed record StartTabMirroringCommandParameters(string SinkName) : Parameters;

/// <summary>
/// </summary>
public sealed record StartTabMirroringResult() : EmptyResult;


internal sealed record StopCastingCommandParameters(string SinkName) : Parameters;

/// <summary>
/// </summary>
public sealed record StopCastingResult() : EmptyResult;


/// <summary>
/// This is fired whenever the list of available sinks changes. A sink is a
/// device or a software surface that you can cast to.
/// </summary>
/// <param name="Sinks">
/// </param>
public sealed record SinksUpdatedEventArgs(ImmutableArray<Sink> Sinks) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// This is fired whenever the outstanding issue/error message changes.
/// |issueMessage| is empty if there is no issue.
/// </summary>
/// <param name="IssueMessage">
/// </param>
public sealed record IssueUpdatedEventArgs(string IssueMessage) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
/// <param name="Name">
/// </param>
/// <param name="Id">
/// </param>
public sealed record Sink(string Name, string Id)
{
    /// <summary>
    /// Text describing the current session. Present only if there is an active
    /// session on the sink.
    /// </summary>
    public string? Session { get; init; }
}

[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(SetSinkToUseCommandParameters), TypeInfoPropertyName = "SetSinkToUseCommandParameters")]
[JsonSerializable(typeof(SetSinkToUseResult), TypeInfoPropertyName = "SetSinkToUseResult")]
[JsonSerializable(typeof(StartDesktopMirroringCommandParameters), TypeInfoPropertyName = "StartDesktopMirroringCommandParameters")]
[JsonSerializable(typeof(StartDesktopMirroringResult), TypeInfoPropertyName = "StartDesktopMirroringResult")]
[JsonSerializable(typeof(StartTabMirroringCommandParameters), TypeInfoPropertyName = "StartTabMirroringCommandParameters")]
[JsonSerializable(typeof(StartTabMirroringResult), TypeInfoPropertyName = "StartTabMirroringResult")]
[JsonSerializable(typeof(StopCastingCommandParameters), TypeInfoPropertyName = "StopCastingCommandParameters")]
[JsonSerializable(typeof(StopCastingResult), TypeInfoPropertyName = "StopCastingResult")]
[JsonSerializable(typeof(CdpEventArgs<SinksUpdatedEventArgs>), TypeInfoPropertyName = "SinksUpdatedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<IssueUpdatedEventArgs>), TypeInfoPropertyName = "IssueUpdatedCdpEventArgs")]
[JsonSerializable(typeof(Sink), TypeInfoPropertyName = "CastSink")]
[JsonSerializable(typeof(ImmutableArray<Sink>), TypeInfoPropertyName = "ImmutableArrayCastSink")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class CastJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="CastDomain"/>.
/// </summary>
public static class CastDomainEvent
{
    /// <summary>
    /// This is fired whenever the list of available sinks changes. A sink is a
    /// device or a software surface that you can cast to.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<SinksUpdatedEventArgs>> SinksUpdated { get; } =
        EventDescriptor<CdpEventArgs<SinksUpdatedEventArgs>>.Create(
            "goog:cdp.Cast.sinksUpdated",
            CastJsonSerializerContext.Default.SinksUpdatedCdpEventArgs);

    /// <summary>
    /// This is fired whenever the outstanding issue/error message changes.
    /// |issueMessage| is empty if there is no issue.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<IssueUpdatedEventArgs>> IssueUpdated { get; } =
        EventDescriptor<CdpEventArgs<IssueUpdatedEventArgs>>.Create(
            "goog:cdp.Cast.issueUpdated",
            CastJsonSerializerContext.Default.IssueUpdatedCdpEventArgs);

}
