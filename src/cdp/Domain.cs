using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp;

/// <summary>
/// Base class for CDP domain implementations, providing infrastructure for executing commands and subscribing to events.
/// </summary>
internal abstract class Domain(CdpModule cdp)
{
    /// <summary>
    /// The <see cref="System.Diagnostics.ActivitySource"/> used to trace CDP command execution.
    /// </summary>
    internal static readonly ActivitySource ActivitySource = new("Selenium.WebDriver.BiDi.Cdp", typeof(Domain).Assembly.GetName().Version?.ToString() ?? "");

    /// <summary>
    /// Executes a CDP command with the specified parameters and returns the result.
    /// </summary>
    /// <typeparam name="TParameters">The type of the command parameters.</typeparam>
    /// <typeparam name="TResult">The type of the command result.</typeparam>
    /// <param name="method">The CDP method name.</param>
    /// <param name="parameters">The command parameters to serialize and send.</param>
    /// <param name="parametersTypeInfo">Serialization metadata for the command parameters.</param>
    /// <param name="resultTypeInfo">Serialization metadata for the command result.</param>
    /// <param name="session">Optional CDP session override.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>The deserialized command result.</returns>
    private protected async Task<TResult> ExecuteCommandAsync<TParameters, TResult>(string method, TParameters parameters, JsonTypeInfo<TParameters> parametersTypeInfo, JsonTypeInfo<TResult> resultTypeInfo, string? session, CancellationToken cancellationToken)
        where TParameters : Parameters
        where TResult : EmptyResult
    {
        using var activity = ActivitySource.StartActivity(method, ActivityKind.Client);

        activity?.SetTag("cdp.method", method);

        try
        {
            var @params = SerializeParameters(parameters, parametersTypeInfo);

            var sendResult = await cdp.SendCommandAsync(method, @params, session, cancellationToken).ConfigureAwait(false);

            return sendResult.Result.Deserialize(resultTypeInfo)!;
        }
        catch (Exception ex)
        {
            activity?.SetStatus(ActivityStatusCode.Error, ex.Message);

            throw;
        }
    }

    private static JsonElement SerializeParameters<TParameters>(TParameters parameters, JsonTypeInfo<TParameters> parametersTypeInfo)
        where TParameters : Parameters
    {
#if NET8_0_OR_GREATER
        return JsonSerializer.SerializeToElement(parameters, parametersTypeInfo);
#else
        var utf8Json = JsonSerializer.SerializeToUtf8Bytes(parameters, parametersTypeInfo);
        using var json = JsonDocument.Parse(utf8Json);
        return json.RootElement.Clone();
#endif
    }

    /// <summary>
    /// Creates an event source for subscribing to a specific CDP event.
    /// </summary>
    /// <typeparam name="TParams">The type of event arguments.</typeparam>
    /// <param name="descriptor">The event descriptor defining the CDP event.</param>
    /// <returns>An event source that can be used to subscribe to the event.</returns>
    private protected IEventSource<TParams> CreateCdpEventSource<TParams>(EventDescriptor<CdpEventArgs<TParams>> descriptor)
        where TParams : OpenQA.Selenium.BiDi.EventArgs
    {
        return cdp.CreateCdpEventSource(descriptor);
    }
}
