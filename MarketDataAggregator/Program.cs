using MarketDataAggregator.Core;
using MarketDataAggregator.Ingestion;
using MarketDataAggregator.Infrastructure;
using MarketDataAggregator.SignalR;

var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddSingleton<MarketDataStore>();
builder.Services.AddSingleton<MarketDataFeed>();

builder.Services.AddSignalR();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();
app.MapHub<MarketHub>("/marketHub");

app.Run();
