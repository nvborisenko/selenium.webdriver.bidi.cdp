using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp;

/// <summary>
/// Base class for CDP domain implementations, providing infrastructure for executing commands and subscribing to events.
/// </summary>
public abstract class Domain(CdpModule cdp)
{
    /// <summary>
    /// Executes a CDP command with the specified parameters and returns the result.
    /// </summary>
    /// <typeparam name="TParameters">The type of the command parameters.</typeparam>
    /// <typeparam name="TResult">The type of the command result.</typeparam>
    /// <param name="command">The CDP command descriptor.</param>
    /// <param name="parameters">The command parameters to serialize and send.</param>
    /// <param name="options">Optional command options.</param>
    /// <param name="cancellationToken">A token to cancel the asynchronous operation.</param>
    /// <returns>The deserialized command result.</returns>
    private protected async Task<TResult> ExecuteCommandAsync<TParameters, TResult>(CdpCommand<TParameters, TResult> command, TParameters parameters, CdpCommandOptions? options, CancellationToken cancellationToken)
        where TParameters : Parameters
        where TResult : EmptyResult
    {
        var @params = SerializeParameters(parameters, command.ParametersTypeInfo);

        var sendResult = await cdp.SendCommandAsync(command.Method, @params, options, cancellationToken);

        return sendResult.Result.Deserialize(command.ResultTypeInfo)!;
    }

    private static JsonElement SerializeParameters<TParameters>(TParameters parameters, JsonTypeInfo<TParameters> parametersTypeInfo)
        where TParameters : Parameters
    {
#if NET8_0_OR_GREATER
        return JsonSerializer.SerializeToElement(parameters, parametersTypeInfo);
#else
        using var json = JsonDocument.Parse(JsonSerializer.Serialize(parameters, parametersTypeInfo));
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

internal readonly record struct CdpCommand<TParameters, TResult>(string Method, JsonTypeInfo<TParameters> ParametersTypeInfo, JsonTypeInfo<TResult> ResultTypeInfo)
    where TParameters : Parameters
    where TResult : EmptyResult;

/// <summary>
/// Options for CDP command execution.
/// </summary>
public record CdpCommandOptions : SendCommandOptions;
