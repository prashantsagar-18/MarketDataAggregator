using MarketDataAggregator.Core;
using System.Collections.Concurrent;

namespace MarketDataAggregator.Infrastructure;

public class MarketDataStore
{
    private readonly ConcurrentBag<MarketTick> _ticks = new();

    public void Add(MarketTick tick) => _ticks.Add(tick);

    public IEnumerable<MarketTick> GetAll() => _ticks;
}
