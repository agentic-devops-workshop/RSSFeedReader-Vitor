# RSSFeedReader - MVP

A minimal RSS/Atom feed reader demonstrating subscription management.

## Project Overview

This MVP application demonstrates the core capability of adding and viewing RSS/Atom feed subscriptions. The architecture uses ASP.NET Core Web API for the backend and Blazor WebAssembly for the frontend.

## Project Structure

```
RSSFeedReader-Vitor/
├── backend/                      # ASP.NET Core Web API
│   ├── RSSFeedReader.API/
│   │   ├── Controllers/          # API endpoints
│   │   ├── Models/               # Domain entities
│   │   ├── DTOs/                 # Data transfer objects
│   │   ├── Services/             # Business logic & storage
│   │   └── Program.cs            # Startup configuration
│   └── RSSFeedReader.API.Tests/  # Backend unit tests (xUnit)
├── frontend/                     # Blazor WebAssembly SPA
│   ├── RSSFeedReader.Client/
│   │   ├── Pages/                # Blazor pages/components
│   │   ├── Components/           # Reusable components
│   │   ├── Services/             # API client services
│   │   └── Program.cs            # Blazor startup
│   └── RSSFeedReader.Client.Tests/  # Frontend tests (bUnit)
├── specs/                        # Feature specifications and planning
└── README.md                     # This file
```

## Technology Stack

- **Backend**: ASP.NET Core 6+ Web API
- **Frontend**: Blazor WebAssembly
- **Testing**: xUnit (backend), bUnit (frontend)
- **Language**: C# 10
- **Platform**: Cross-platform (Windows, macOS, Linux)

## Getting Started

### Prerequisites

- .NET 6 SDK or newer
- A terminal/command prompt

### Build

```bash
# Build entire solution
cd backend && dotnet build
cd ../frontend && dotnet build
cd ..
```

### Run

**Terminal 1 - Backend API:**
```bash
cd backend/RSSFeedReader.API
dotnet run
```

API will be available at:
- HTTPS: https://localhost:5001
- HTTP: http://localhost:5000
- Swagger UI: https://localhost:5001/swagger

**Terminal 2 - Frontend:**
```bash
cd frontend/RSSFeedReader.Client
dotnet run
```

Frontend will be available at:
- HTTPS: https://localhost:5001
- HTTP: http://localhost:5000

### Usage

1. Open the frontend in your browser
2. Click "Add New Subscription" button
3. Enter a valid RSS/Atom feed URL (e.g., https://devblogs.microsoft.com/dotnet/feed/)
4. Click "Add Subscription"
5. View your subscriptions on the home page

## Testing

### Backend Tests

```bash
cd backend/RSSFeedReader.API.Tests
dotnet test
```

### Frontend Tests

```bash
cd frontend/RSSFeedReader.Client.Tests
dotnet test
```

## API Documentation

When running the backend in development mode, visit `/swagger` for interactive API documentation.

### Endpoints

- **POST** `/api/subscriptions` - Add a new subscription
- **GET** `/api/subscriptions` - List all subscriptions

## MVP Features

✅ Add RSS/Atom feed subscriptions by URL
✅ View list of subscriptions
✅ Simple, functional UI
✅ Cross-platform support

## Not Included in MVP

- Feed fetching and parsing
- Feed item display
- Data persistence (in-memory only)
- URL validation
- Subscription removal
- Error handling
- Authentication

## Notes

- All data is stored in memory and will be lost when the application restarts
- No validation is performed on feed URLs; assume users provide valid URLs
- The MVP demonstrates the core functionality without production-ready features

## Future Enhancements

See `specs/001-mvp-rss-reader/` for planned Extended-MVP and post-MVP features.

## Contributing

This is an MVP demonstration project. For modifications, follow the coding standards in `.editorconfig`.

## Security

- No sensitive data is stored in this MVP
- Dependencies are reviewed for known vulnerabilities before use
- CORS is configured to allow frontend-backend communication
