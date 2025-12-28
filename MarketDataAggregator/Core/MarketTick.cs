namespace MarketDataAggregator.Core;

public record MarketTick(
    string Symbol,
    decimal Price,
    DateTime Timestamp
);
