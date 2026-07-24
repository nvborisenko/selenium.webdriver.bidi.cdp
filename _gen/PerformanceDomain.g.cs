#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Performance;

/// <summary>
/// </summary>
public sealed class PerformanceDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static PerformanceJsonSerializerContext JsonContext = PerformanceJsonSerializerContext.Default;

    /// <summary>
    /// Disable collecting and reporting metrics.
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
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("Performance.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Enable collecting and reporting metrics.
    /// </summary>
    /// <param name="timeDomain">
    /// Time domain to use for collecting and reporting duration metrics.
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
    public async Task<EnableResult> EnableAsync(string? timeDomain = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters(TimeDomain: timeDomain);
        return await ExecuteCommandAsync(EnableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("Performance.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Sets time domain to use for collecting and reporting duration metrics.
    /// Note that this must be called before enabling metrics collection. Calling
    /// this method while metrics collection is enabled returns an error.
    /// </summary>
    /// <param name="timeDomain">
    /// Time domain
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetTimeDomainResult"/>.
    /// </returns>
    [global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
    [global::System.Obsolete]
    public async Task<SetTimeDomainResult> SetTimeDomainAsync(string timeDomain, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetTimeDomainCommandParameters(TimeDomain: timeDomain);
        return await ExecuteCommandAsync(SetTimeDomainCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetTimeDomainCommandParameters, SetTimeDomainResult> SetTimeDomainCommand = new("Performance.setTimeDomain", JsonContext.SetTimeDomainCommandParameters, JsonContext.SetTimeDomainResult);

    /// <summary>
    /// Retrieve current values of run-time metrics.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetMetricsResult"/>.
    /// </returns>
    public async Task<GetMetricsResult> GetMetricsAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetMetricsCommandParameters();
        return await ExecuteCommandAsync(GetMetricsCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetMetricsCommandParameters, GetMetricsResult> GetMetricsCommand = new("Performance.getMetrics", JsonContext.GetMetricsCommandParameters, JsonContext.GetMetricsResult);

    /// <summary>
    /// Current values of the metrics.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="MetricsEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Metrics</b> - Current values of the metrics.</description></item>
    /// <item><description><b>Title</b> - Timestamp title.</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<MetricsEventArgs> Metrics => CreateCdpEventSource(PerformanceDomainEvent.Metrics);
}

internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters(string? TimeDomain) : Parameters;

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record SetTimeDomainCommandParameters(string TimeDomain) : Parameters;

/// <summary>
/// </summary>
public sealed record SetTimeDomainResult() : EmptyResult;


internal sealed record GetMetricsCommandParameters() : Parameters;

/// <summary>
/// </summary>
/// <param name="Metrics">
/// Current values for run-time metrics.
/// </param>
public sealed record GetMetricsResult(ImmutableArray<Metric> Metrics) : EmptyResult;


/// <summary>
/// Current values of the metrics.
/// </summary>
/// <param name="Metrics">
/// Current values of the metrics.
/// </param>
/// <param name="Title">
/// Timestamp title.
/// </param>
public sealed record MetricsEventArgs(ImmutableArray<Metric> Metrics, string Title) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Run-time execution metric.
/// </summary>
/// <param name="Name">
/// Metric name.
/// </param>
/// <param name="Value">
/// Metric value.
/// </param>
public sealed record Metric(string Name, double Value)
{
}

[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(SetTimeDomainCommandParameters), TypeInfoPropertyName = "SetTimeDomainCommandParameters")]
[JsonSerializable(typeof(SetTimeDomainResult), TypeInfoPropertyName = "SetTimeDomainResult")]
[JsonSerializable(typeof(GetMetricsCommandParameters), TypeInfoPropertyName = "GetMetricsCommandParameters")]
[JsonSerializable(typeof(GetMetricsResult), TypeInfoPropertyName = "GetMetricsResult")]
[JsonSerializable(typeof(CdpEventArgs<MetricsEventArgs>), TypeInfoPropertyName = "MetricsCdpEventArgs")]
[JsonSerializable(typeof(Metric), TypeInfoPropertyName = "PerformanceMetric")]
[JsonSerializable(typeof(ImmutableArray<Metric>), TypeInfoPropertyName = "ImmutableArrayPerformanceMetric")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class PerformanceJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="PerformanceDomain"/>.
/// </summary>
public static class PerformanceDomainEvent
{
    /// <summary>
    /// Current values of the metrics.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<MetricsEventArgs>> Metrics { get; } =
        EventDescriptor<CdpEventArgs<MetricsEventArgs>>.Create(
            "goog:cdp.Performance.metrics",
            PerformanceJsonSerializerContext.Default.MetricsCdpEventArgs);

}
