# Copilot Instructions

## General Guidelines
- Prefer genuinely async methods (e.g., FindAllAsync, GetByIdAsync) instead of fake async patterns like Task.FromResult wrapping synchronous calls.