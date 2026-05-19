# RSSFeedReader.Client - Frontend

Blazor WebAssembly frontend for RSS/Atom feed subscription management.

## Prerequisites

- .NET 6 SDK or newer
- A running instance of RSSFeedReader.API backend

## Build

```sh
dotnet build
```

## Run

```sh
dotnet run
```

The frontend will be available at `https://localhost:5001` or `http://localhost:5000` (depending on configuration).

## Project Structure

```
RSSFeedReader.Client/
├── Components/       # Razor components (UI)
├── Services/        # API client services
├── Pages/           # Page components
├── Shared/          # Shared layout and components
└── wwwroot/         # Static assets
```

## Key Components

- **AddSubscription.razor**: Form to add new feed subscriptions
- **SubscriptionList.razor**: Display list of subscriptions

## API Integration

The frontend communicates with the backend API via HTTP requests using an injected `HttpClient`.

## Testing

```sh
dotnet test
```

## Notes

- MVP fetches subscriptions from in-memory backend storage
- No persistence in MVP (data lost on restart)
- Simple, functional UI without heavy styling
