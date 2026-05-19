# Data Model: MVP RSS reader

## Entity: Subscription
- **id**: Guid (generated in backend)
- **url**: string (RSS/Atom feed URL)

## Relationships
- None (flat list, MVP only)

## Validation Rules
- No validation in MVP (assume user provides valid URLs)

## State Transitions
- Add: User submits a URL, new Subscription is created and added to the list
- List: All current subscriptions are returned

## Notes
- Data is stored in memory only (lost on app close)
- No removal or update in MVP
