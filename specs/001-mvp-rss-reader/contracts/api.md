# API Contracts: MVP RSS reader

## Endpoint: Add Subscription
- **POST** `/api/subscriptions`
- **Request Body**: `{ "url": "string" }`
- **Response**: `201 Created`, `{ "id": "guid", "url": "string" }`

## Endpoint: List Subscriptions
- **GET** `/api/subscriptions`
- **Response**: `200 OK`, `[ { "id": "guid", "url": "string" }, ... ]`

## Notes
- No validation or error handling in MVP
- No authentication required
- Data is stored in memory only
