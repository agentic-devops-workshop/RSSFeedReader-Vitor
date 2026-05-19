
# RSSFeedReader-Vitor Constitution

## Core Principles

### I. Security by Design
All code must be written with security as a primary concern. Validate all user input, avoid unsafe deserialization, and never store sensitive data in plaintext. Regularly review dependencies for vulnerabilities.

### II. Maintainability First
Code must be clear, well-documented, and modular. Favor readability over cleverness. All features should be independently testable and easy to refactor. Use consistent naming and structure across backend and frontend.

### III. Code Quality and Testing
All code must be covered by automated tests (unit and integration where applicable). Follow TDD where practical. Code reviews are mandatory before merging. Linting and formatting tools must be enforced in CI.

### IV. Minimal Viable Product Focus
Build the simplest version that delivers user value. Defer non-essential features to later phases. MVP must allow adding and listing RSS subscriptions; no feed fetching or persistence in MVP.

### V. Technology Alignment
Use ASP.NET Core Web API for backend and Blazor WebAssembly for frontend. Store data in memory for MVP. Ensure cross-platform compatibility (Windows, macOS, Linux).

## Additional Constraints

- Only accept valid RSS/Atom URLs for subscriptions in future phases (Extended-MVP).
- No persistence or network operations in MVP; all data is in-memory and lost on restart.
- UI must be simple, functional, and accessible.
- All dependencies must be reviewed for security and license compliance before use.

## Development Workflow & Quality Gates

- All changes must be peer-reviewed before merging.
- CI must run lint, format, and test checks on every PR.
- No code is merged without passing all tests and reviews.
- Amendments to this constitution require stakeholder approval and documentation.

## Governance

This constitution supersedes all other practices for this project. All PRs and reviews must verify compliance. Amendments require documentation, stakeholder approval, and a migration plan if needed.

**Version**: 1.0.0 | **Ratified**: 2026-05-19 | **Last Amended**: 2026-05-19

## Core Principles

### [PRINCIPLE_1_NAME]
<!-- Example: I. Library-First -->
[PRINCIPLE_1_DESCRIPTION]
<!-- Example: Every feature starts as a standalone library; Libraries must be self-contained, independently testable, documented; Clear purpose required - no organizational-only libraries -->

### [PRINCIPLE_2_NAME]
<!-- Example: II. CLI Interface -->
[PRINCIPLE_2_DESCRIPTION]
<!-- Example: Every library exposes functionality via CLI; Text in/out protocol: stdin/args → stdout, errors → stderr; Support JSON + human-readable formats -->

### [PRINCIPLE_3_NAME]
<!-- Example: III. Test-First (NON-NEGOTIABLE) -->
[PRINCIPLE_3_DESCRIPTION]
<!-- Example: TDD mandatory: Tests written → User approved → Tests fail → Then implement; Red-Green-Refactor cycle strictly enforced -->

### [PRINCIPLE_4_NAME]
<!-- Example: IV. Integration Testing -->
[PRINCIPLE_4_DESCRIPTION]
<!-- Example: Focus areas requiring integration tests: New library contract tests, Contract changes, Inter-service communication, Shared schemas -->

### [PRINCIPLE_5_NAME]
<!-- Example: V. Observability, VI. Versioning & Breaking Changes, VII. Simplicity -->
[PRINCIPLE_5_DESCRIPTION]
<!-- Example: Text I/O ensures debuggability; Structured logging required; Or: MAJOR.MINOR.BUILD format; Or: Start simple, YAGNI principles -->

## [SECTION_2_NAME]
<!-- Example: Additional Constraints, Security Requirements, Performance Standards, etc. -->

[SECTION_2_CONTENT]
<!-- Example: Technology stack requirements, compliance standards, deployment policies, etc. -->

## [SECTION_3_NAME]
<!-- Example: Development Workflow, Review Process, Quality Gates, etc. -->

[SECTION_3_CONTENT]
<!-- Example: Code review requirements, testing gates, deployment approval process, etc. -->

## Governance
<!-- Example: Constitution supersedes all other practices; Amendments require documentation, approval, migration plan -->

[GOVERNANCE_RULES]
<!-- Example: All PRs/reviews must verify compliance; Complexity must be justified; Use [GUIDANCE_FILE] for runtime development guidance -->

**Version**: [CONSTITUTION_VERSION] | **Ratified**: [RATIFICATION_DATE] | **Last Amended**: [LAST_AMENDED_DATE]
<!-- Example: Version: 2.1.1 | Ratified: 2025-06-13 | Last Amended: 2025-07-16 -->
