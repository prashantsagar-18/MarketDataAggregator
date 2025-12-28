# Market Data Aggregator

A real-time market data aggregation platform built using C# and .NET, designed to ingest, normalize, store, and stream financial market data from multiple sources with low latency.

This project demonstrates enterprise-grade backend engineering, real-time data handling, and clean architectural practices.
---

## Key Features

- Real-time market data ingestion via REST and WebSocket (simulated exchange feed)
- Asynchronous, non-blocking processing using `async/await`
- Thread-safe in-memory caching using concurrent collections
- Unified domain model for heterogeneous market data
- Real-time streaming to consumers using **SignalR**
- Historical data storage ready (in-memory, extendable to SQL Server)
- Clean, layered architecture following enterprise best practices

---

## Architecture Overview
Market Data Providers (REST / WebSocket)
│
▼
Data Ingestion Layer
│
▼
Normalization & Validation
│
▼
In-Memory Cache / Persistence
│
┌──────┴────────┐
▼ ▼
Real-Time Stream Historical Data
(SignalR) Store


---

## Tech Stack

- **C#**
- **.NET 8**
- ASP.NET Core Minimal APIs
- SignalR
- Task Parallel Library (TPL)
- Concurrent Collections
- Serilog (pluggable)
- Git / GitHub

---





