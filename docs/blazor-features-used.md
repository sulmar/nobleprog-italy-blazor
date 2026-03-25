# Blazor Features Used (WebAssembly)

This page is a quick "feature map" for course participants. It lists the Blazor features actually demonstrated in this repo's `src/BlazorWebAssemblyApp` and points you to the exact code to study.

## Features checklist (with where to look)

| Feature (what you learn) | Where to look | Example in this repo |
|---|---|---|
| Routing with `Router` / `RouteView` | `src/BlazorWebAssemblyApp/App.razor` | `<Router ...>` + `FocusOnNavigate` |
| URL routes (`@page`) | `src/BlazorWebAssemblyApp/Pages/*` | `@page "/customers"`, `@page "/weather"`, `@page "/counter"` |
| Layout composition (`@Body`) | `src/BlazorWebAssemblyApp/Layout/MainLayout.razor` | `@Body` inside the shared layout |
| Shared navigation (`NavMenu`) | `src/BlazorWebAssemblyApp/Layout/NavMenu.razor` | `NavLink` + `@onclick="ToggleNavMenu"` |
| Components with code-behind (`@code`) | `src/BlazorWebAssemblyApp/**.razor` | `@code { ... }` in `List.razor`, `Counter.razor`, `Weather.razor` |
| Dependency injection in components (`@inject`) | `src/BlazorWebAssemblyApp/Pages/Customers/List.razor` | `@inject ICustomerService Api` |
| Service registration in startup (`AddScoped`) | `src/BlazorWebAssemblyApp/Program.cs` | `builder.Services.AddScoped<ICustomerService, ApiCustomerService>()` |
| HTTP calls | `src/BlazorWebAssemblyApp/Pages/Weather.razor` | `Http.GetFromJsonAsync<WeatherForecast[]>(...)` |
| HTTP calls via service abstraction | `src/BlazorWebAssemblyApp/Services/ICustomerService.cs` | `ApiCustomerService.GetAll()` uses `GetFromJsonAsync` |
| Async lifecycle (`OnInitializedAsync`) | `src/BlazorWebAssemblyApp/Pages/Customers/List.razor` | Loads customers on initialization |
| Parameters (`[Parameter]`) | `src/BlazorWebAssemblyApp/Shared/*.razor` | `CustomerTable`, `EntityTable`, `AddressComponent` |
| Render templates (`RenderFragment` / `RenderFragment<T>`) | `src/BlazorWebAssemblyApp/Shared/EntityTable.razor` | Generic table with `HeaderTemplate` + `RowTemplate` |
| Template composition in a page | `src/BlazorWebAssemblyApp/Pages/Customers/List.razor` | Passes `HeaderTemplate` and `RowTemplate` into `CustomerTable` |
| Event handling (`@onclick`) | `src/BlazorWebAssemblyApp/Pages/Counter.razor`, `src/BlazorWebAssemblyApp/Layout/NavMenu.razor` | `IncrementCount()` + `ToggleNavMenu()` |
| Navigation links (`NavLink`) | `src/BlazorWebAssemblyApp/Layout/NavMenu.razor` | `NavLink ... Match="NavLinkMatch.All"` |
| Conditional rendering (loading vs data) | `src/BlazorWebAssemblyApp/Pages/Customers/List.razor`, `src/BlazorWebAssemblyApp/Pages/Weather.razor` | `if (customers == null)` / `if (forecasts == null)` |
| Page titles (`<PageTitle>`) | `src/BlazorWebAssemblyApp/Pages/*` | `<PageTitle>Weather</PageTitle>`, `<PageTitle>Counter</PageTitle>` |

## What to start with (recommended reading order)

1. `src/BlazorWebAssemblyApp/App.razor` (routing entry point)
2. `src/BlazorWebAssemblyApp/Layout/MainLayout.razor` and `src/BlazorWebAssemblyApp/Layout/NavMenu.razor` (shared UI)
3. `src/BlazorWebAssemblyApp/Pages/Customers/List.razor` (DI + async loading + templates + parameters)
4. `src/BlazorWebAssemblyApp/Shared/EntityTable.razor` (generic reusable component pattern)
5. `src/BlazorWebAssemblyApp/Pages/Weather.razor` (HTTP + JSON)
6. `src/BlazorWebAssemblyApp/Pages/Counter.razor` (events)

