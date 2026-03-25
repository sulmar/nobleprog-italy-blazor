# Blazor Application Development Training

## Introduction

Welcome to the course materials for **Blazor Application Development**. This training is hands-on: you will work toward building a **complete Blazor application**—from project structure and UI components to data, services, and deployment-minded patterns—so you leave with something that feels like a real product, not isolated snippets.

### What you can expect

- **Blazor fundamentals**: components, layouts, routing, and how the UI model fits together in .NET.
- **Full-app thinking**: organizing code, sharing logic, and wiring pages and features into a coherent whole.
- **Practical progression**: examples and exercises that stack toward the same application you will grow in later steps of the course.

Whether you are new to Blazor or moving from another web stack, the goal is the same: understand how to design and ship a maintainable Blazor app with confidence.

## Project Description

This repository contains a training solution that demonstrates a full Blazor ecosystem, not just a single app template. The `src/` solution includes:

- `BlazorServerApp` - a Blazor Server application using interactive server components.
- `BlazorWebAssemblyApp` - a Blazor WebAssembly frontend that consumes backend APIs (for example, `/api/customers`).
- `Api` - a minimal ASP.NET Core API that serves customer data from in-memory repositories seeded with fake data.
- `IdentityProvider.Api` - a minimal authentication API with sample users and JWT access-token generation via `/api/login`.
- `Domain` - shared domain models and repository abstractions used across the solution.
- `Infrastructure` - in-memory repository implementations and data fakers used by backend services.

Together, these projects provide a practical playground for learning UI composition, API integration, shared domain layers, and basic authentication flow in modern Blazor-based applications.

### Prerequisites

To follow along, install:

1. [.NET 10 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/10.0)

### Additional Learning Materials

- [Blazor Libraries: Practical Recommendations](docs/blazor-libraries.md)
- [MudBlazor](https://mudblazor.com/)
- [bUnit](https://bunit.dev)

## Setup
1. Clone the Git repository
```bash
git clone https://github.com/sulmar/nobleprog-italy-blazor
```

## Blazor Features Used (WebAssembly)
This quick index shows where the Blazor features demonstrated in this training are implemented inside `src/BlazorWebAssemblyApp`.

For a detailed checklist with direct "Where to look" links, see: [`docs/blazor-features-used.md`](docs/blazor-features-used.md).