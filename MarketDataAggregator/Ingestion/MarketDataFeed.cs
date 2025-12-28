using MarketDataAggregator.Core;
using MarketDataAggregator.Infrastructure;
using Microsoft.AspNetCore.SignalR;
using MarketDataAggregator.SignalR;

namespace MarketDataAggregator.Ingestion;

public class MarketDataFeed
{
    private readonly MarketDataStore _store;
    private readonly IHubContext<MarketHub> _hub;
    private readonly Random _random = new();

    public MarketDataFeed(MarketDataStore store, IHubContext<MarketHub> hub)
    {
        _store = store;
        _hub = hub;
        StartFeed();
    }

    private void StartFeed()
    {
        Task.Run(async () =>
        {
            while (true)
            {
                var tick = new MarketTick(
                    "LSEG",
                    100 + (decimal)_random.NextDouble() * 10,
                    DateTime.UtcNow
                );

                _store.Add(tick);
                await _hub.Clients.All.SendAsync("Tick", tick);

                await Task.Delay(1000);
            }
        });
    }
}
