# RSSFeedReader.API - Backend

ASP.NET Core Web API for RSS/Atom feed subscription management.

## Prerequisites

- .NET 6 SDK or newer
- Visual Studio Code or Visual Studio 2022 (optional)

## Build

```sh
dotnet build
```

## Run

```sh
dotnet run
```

The API will be available at `https://localhost:5001` (HTTPS) or `http://localhost:5000` (HTTP).

API documentation is available at `/swagger` when running in development mode.

## Project Structure

```
RSSFeedReader.API/
├── Controllers/       # API endpoints
├── Models/           # Domain entities
├── DTOs/             # Data transfer objects
├── Services/         # Business logic
└── Program.cs        # Startup configuration
```

## API Endpoints

### Add Subscription
- **POST** `/api/subscriptions`
- Request: `{ "url": "string" }`
- Response: `201 Created`, `{ "id": "guid", "url": "string" }`

### List Subscriptions
- **GET** `/api/subscriptions`
- Response: `200 OK`, `[ { "id": "guid", "url": "string" }, ... ]`

## Testing

```sh
dotnet test
```

## Notes

- MVP stores subscriptions in memory only (data is lost on restart)
- No feed fetching or parsing in MVP
- No authentication required in MVP
