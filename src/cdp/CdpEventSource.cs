using OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp;

internal sealed class CdpEventSource<TParams> : IEventSource<TParams>
    where TParams : OpenQA.Selenium.BiDi.EventArgs
{
    private readonly IEventSource<CdpEventArgs<TParams>> _inner;

    internal CdpEventSource(IEventSource<CdpEventArgs<TParams>> inner)
    {
        _inner = inner;
    }

    public Task<ISubscription> SubscribeAsync(Action<TParams> handler, CancellationToken cancellationToken = default)
        => _inner.SubscribeAsync(e => handler(e.Params), cancellationToken);

    public Task<ISubscription> SubscribeAsync(Func<TParams, Task> handler, CancellationToken cancellationToken = default)
        => _inner.SubscribeAsync(e => handler(e.Params), cancellationToken);

    public async Task<IEventStream<TParams>> StreamAsync(CancellationToken cancellationToken = default)
    {
        var innerStream = await _inner.StreamAsync(cancellationToken).ConfigureAwait(false);
        return new CdpEventStream<TParams>(innerStream);
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

    internal CdpEventStream(IEventStream<CdpEventArgs<TParams>> inner)
    {
        _inner = inner;
    }

    /// <inheritdoc/>
    public async IAsyncEnumerator<TParams> GetAsyncEnumerator(CancellationToken cancellationToken = default)
    {
        await foreach (var item in _inner.WithCancellation(cancellationToken))
        {
            yield return item.Params;
        }
    }

    /// <inheritdoc/>
    public ValueTask DisposeAsync() => _inner.DisposeAsync();
}
