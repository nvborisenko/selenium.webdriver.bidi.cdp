using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using OpenQA.Selenium.BiDi;
using OpenQA.Selenium.BiDi.BrowsingContext;

namespace Selenium.WebDriver.BiDi.Cdp;

/// <summary>
/// Provides access to the Chrome DevTools Protocol (CDP) over BiDi.
/// </summary>
public partial class CdpModule : Module
{
    private static readonly CdpJsonSerializerContext JsonContext = CdpJsonSerializerContext.Default;
    internal string? Session { get; set; }

    private static readonly Command<GetSessionParameters, GetSessionResult> GetSessionCommand = new("goog:cdp.getSession", JsonContext.GetSessionParameters, JsonContext.GetSessionResult);
    private static readonly Command<SendCommandParameters, SendCommandResult> SendCommandCommand = new("goog:cdp.sendCommand", JsonContext.SendCommandParameters, JsonContext.SendCommandResult);

    /// <summary>
    /// Gets the CDP session identifier for the specified browsing context.
    /// </summary>
    /// <param name="context">The browsing context to get the session for.</param>
    /// <param name="options">Optional command options.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>The session result containing the CDP session identifier.</returns>
    public async Task<GetSessionResult> GetSessionAsync(BrowsingContext context, GetSessionOptions? options = null, CancellationToken cancellationToken = default)
    {
        var @params = new GetSessionParameters(context);

        return await ExecuteAsync(GetSessionCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Sends a CDP command with the specified method and parameters.
    /// </summary>
    /// <param name="method">The CDP method name (e.g. "Page.navigate").</param>
    /// <param name="parameters">The JSON parameters for the command.</param>
    /// <param name="options">Optional command options including session override.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>The raw command result.</returns>
    public async Task<SendCommandResult> SendCommandAsync(string method, JsonObject parameters, SendCommandOptions? options = null, CancellationToken cancellationToken = default)
    {
        var session = options?.Session ?? Session;

        var @params = new SendCommandParameters(method, parameters, session);

        return await ExecuteAsync(SendCommandCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }

    internal IEventSource<TParams> CreateCdpEventSource<TParams>(EventDescriptor<CdpEventArgs<TParams>> descriptor)
        where TParams : OpenQA.Selenium.BiDi.EventArgs
    {
        return new CdpEventSource<TParams>(CreateEventSource(descriptor));
    }

    /// <summary>
    /// Provides access to domain instances scoped to this CDP module.
    /// </summary>
    public My.MyDomain My => new(this);
}

[JsonSerializable(typeof(GetSessionParameters))]
[JsonSerializable(typeof(GetSessionResult))]
[JsonSerializable(typeof(SendCommandParameters))]
[JsonSerializable(typeof(SendCommandResult))]

[JsonSourceGenerationOptions(
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
internal partial class CdpJsonSerializerContext : JsonSerializerContext;
