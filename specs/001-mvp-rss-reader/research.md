# Research: MVP RSS reader

## Decision: ASP.NET Core Web API + Blazor WebAssembly
- Chosen for rapid MVP development, cross-platform support, and future extensibility.

## Rationale
- ASP.NET Core and Blazor WebAssembly are both modern, well-supported, and allow for a clean separation of backend and frontend.
- In-memory storage is simplest for MVP and aligns with project goals.
- No persistence or feed fetching in MVP keeps scope minimal and manageable.

## Alternatives considered
- Node.js + React: More setup, less alignment with C# code sharing.
- Python + Flask + JS frontend: Not as seamless for SPA and C# code sharing.
- Desktop app (WPF, Electron): Not cross-platform enough or overkill for MVP.

## Best Practices for ASP.NET Core + Blazor MVPs
- Keep backend and frontend in separate projects for clarity.
- Use dependency injection for testability.
- Write unit tests for all logic (xUnit, bUnit).
- Use simple DTOs for API contracts.
- Avoid over-engineering; focus on MVP scope.
- Document all endpoints and UI flows.

## Patterns for Subscription Management
- Store subscriptions as a simple in-memory list.
- Expose endpoints: AddSubscription, ListSubscriptions.
- UI: Input field for URL, Add button, List display.

## References
- StakeholderDocuments/ProjectGoals.md
- StakeholderDocuments/TechStack.md
