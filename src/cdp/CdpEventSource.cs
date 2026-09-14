using System.Diagnostics;
using System.Runtime.CompilerServices;
using OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp;

internal sealed class CdpEventSource<TParams> : IEventSource<TParams>
    where TParams : OpenQA.Selenium.BiDi.EventArgs
{
    private readonly IEventSource<CdpEventArgs<TParams>> _inner;
    private readonly string _eventName;
    private readonly string? _session;

    internal CdpEventSource(IEventSource<CdpEventArgs<TParams>> inner, string eventName, string? session)
    {
        _inner = inner;
        _eventName = eventName;
        _session = session;
    }

    public Task<ISubscription> SubscribeAsync(Action<TParams> handler, CancellationToken cancellationToken = default)
        => _inner.SubscribeAsync(e =>
        {
            if (!IsForSession(e))
            {
                return;
            }

            using var activity = StartActivity();

            try
            {
                handler(e.Params);
            }
            catch (Exception ex)
            {
                activity?.SetStatus(ActivityStatusCode.Error, ex.Message);

                throw;
            }
        }, cancellationToken);

    public Task<ISubscription> SubscribeAsync(Func<TParams, Task> handler, CancellationToken cancellationToken = default)
        => _inner.SubscribeAsync(async e =>
        {
            if (!IsForSession(e))
            {
                return;
            }

            using var activity = StartActivity();

            try
            {
                await handler(e.Params).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                activity?.SetStatus(ActivityStatusCode.Error, ex.Message);

                throw;
            }
        }, cancellationToken);

    public async Task<IEventStream<TParams>> StreamAsync(CancellationToken cancellationToken = default)
    {
        var innerStream = await _inner.StreamAsync(cancellationToken).ConfigureAwait(false);
        return new CdpEventStream<TParams>(innerStream, _eventName, _session);
    }

    private bool IsForSession(CdpEventArgs<TParams> eventArgs)
        => _session is null || string.Equals(eventArgs.Session, _session, StringComparison.Ordinal);

    private Activity? StartActivity()
    {
        var activity = Domain.ActivitySource.StartActivity(_eventName, ActivityKind.Consumer);

        activity?.SetTag("cdp.event", _eventName);

        return activity;
    }
}

/// <summary>
/// An async stream of CDP event parameters.
/// </summary>
/// <typeparam name="TParams">The type of event parameters.</typeparam>
public sealed class CdpEventStream<TParams> : IEventStream<TParams>
    where TParams : OpenQA.Selenium.BiDi.EventArgs
{
    private readonly IEventStream<CdpEventArgs<TParams>> _inner;
    private readonly string _eventName;
    private readonly string? _session;

    internal CdpEventStream(IEventStream<CdpEventArgs<TParams>> inner, string eventName, string? session)
    {
        _inner = inner;
        _eventName = eventName;
        _session = session;
    }

    /// <inheritdoc/>
    public async IAsyncEnumerable<TParams> ReadAllAsync([EnumeratorCancellation] CancellationToken cancellationToken = default)
    {
        await foreach (var item in _inner.ReadAllAsync(cancellationToken).ConfigureAwait(false))
        {
            if (_session is not null && !string.Equals(item.Session, _session, StringComparison.Ordinal))
            {
                continue;
            }

            // The activity spans the consumer's processing of the item, until the next iteration.
            using var activity = Domain.ActivitySource.StartActivity(_eventName, ActivityKind.Consumer);

            activity?.SetTag("cdp.event", _eventName);

            yield return item.Params;
        }
    }

    /// <inheritdoc/>
    public ValueTask DisposeAsync() => _inner.DisposeAsync();
}
