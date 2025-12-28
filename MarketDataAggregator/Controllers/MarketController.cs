using Microsoft.AspNetCore.Mvc;
using MarketDataAggregator.Infrastructure;

namespace MarketDataAggregator.Controllers;

[ApiController]
[Route("api/market")]
public class MarketController : ControllerBase
{
    private readonly MarketDataStore _store;

    public MarketController(MarketDataStore store)
    {
        _store = store;
    }

    [HttpGet("ticks")]
    public IActionResult GetTicks()
    {
        return Ok(_store.GetAll());
    }
}
