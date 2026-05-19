# Tasks: MVP RSS reader

**Input**: Design documents from `/specs/001-mvp-rss-reader/`

**Prerequisites**: plan.md (required), spec.md (required for user stories), research.md, data-model.md, contracts/

## Phase 1: Setup (Shared Infrastructure)

**Purpose**: Project initialization and basic structure

- [x] T001 Create backend/ and frontend/ directories per plan.md
- [x] T002 Initialize ASP.NET Core Web API project in backend/
- [x] T003 Initialize Blazor WebAssembly project in frontend/
- [x] T004 [P] Configure linting and formatting tools for C# in both projects
- [x] T005 [P] Add README files to backend/ and frontend/

---

## Phase 2: Foundational (Blocking Prerequisites)

**Purpose**: Core infrastructure that MUST be complete before ANY user story can be implemented

- [x] T006 Implement in-memory storage for subscriptions in backend/src/
- [x] T007 [P] Define Subscription entity in backend/src/Models/Subscription.cs
- [x] T008 [P] Implement API endpoints (Add, List) in backend/src/Controllers/SubscriptionsController.cs
- [x] T009 [P] Create DTOs for API contracts in backend/src/DTOs/
- [x] T010 [P] Add OpenAPI/Swagger support in backend/

---

## Phase 3: User Story 1 (P1) - Add Subscription

- [x] T011 [US1] Implement Add Subscription form in frontend/src/Components/AddSubscription.razor
- [x] T012 [P] [US1] Implement service to call Add Subscription API in frontend/src/Services/SubscriptionService.cs
- [x] T013 [P] [US1] Wire Add button to API call and update state in frontend/src/Components/AddSubscription.razor
- [x] T014 [US1] Display success/failure feedback in AddSubscription.razor

---

## Phase 4: User Story 2 (P2) - View Subscriptions

- [x] T015 [US2] Implement Subscription List component in frontend/src/Components/SubscriptionList.razor
- [x] T016 [P] [US2] Implement service to call List Subscriptions API in frontend/src/Services/SubscriptionService.cs
- [x] T017 [P] [US2] Bind SubscriptionList.razor to service and display list

---

## Final Phase: Polish & Cross-Cutting Concerns

- [x] T018 [P] Add basic unit tests for backend logic in backend/tests/
- [x] T019 [P] Add basic unit tests for frontend logic in frontend/tests/
- [x] T020 [P] Add comments and documentation to all public classes and methods
- [x] T021 [P] Review dependencies for security and license compliance
- [x] T022 [P] Update root README.md with build/run instructions

---

## Dependencies

- US1 must be completed before US2 can be fully tested
- Foundational phase must be completed before any user story phases

## Parallel Execution Examples

- T004, T005, T007, T009, T010 can be done in parallel
- T012, T013 can be done in parallel after T011
- T016, T017 can be done in parallel after T015
- T018, T019, T020, T021, T022 can be done in parallel after main features

## Implementation Strategy

- MVP-first: Deliver Add and View Subscription flows before any extra features
- Incremental: Each phase is independently testable and delivers user value
