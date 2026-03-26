# Blazor Features Used (WebAssembly)

This page is a quick "feature map" for course participants. It lists the Blazor features actually demonstrated in this repo's `src/BlazorWebAssemblyApp` and points you to the exact code to study.

## Features checklist (with where to look)


| Feature (what you learn)                                  | Short description                                       | Where to look                                                                                         | Example in this repo                                                 |
| --------------------------------------------------------- | ------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------- |
| Routing with `Router` / `RouteView`                       | Maps URL path to page components.                       | `src/BlazorWebAssemblyApp/App.razor`                                                                  | `<Router ...>` + `FocusOnNavigate`                                   |
| URL routes (`@page`)                                      | Declares route templates for page components.           | `src/BlazorWebAssemblyApp/Pages/*`                                                                    | `@page "/customers"`, `@page "/weather"`, `@page "/counter"`         |
| Layout composition (`@Body`)                              | Renders current page inside shared layout shell.        | `src/BlazorWebAssemblyApp/Layout/MainLayout.razor`                                                    | `@Body` inside the shared layout                                     |
| Shared navigation (`NavMenu`)                             | Reusable navigation with state and links.               | `src/BlazorWebAssemblyApp/Layout/NavMenu.razor`                                                       | `NavLink` + `@onclick="ToggleNavMenu"`                               |
| Components with code-behind (`@code`)                     | Keeps UI markup and component logic together.           | `src/BlazorWebAssemblyApp/**.razor`                                                                   | `@code { ... }` in `List.razor`, `Counter.razor`, `Weather.razor`    |
| Dependency injection in components (`@inject`)            | Injects registered services into Razor components.      | `src/BlazorWebAssemblyApp/Pages/Customers/List.razor`                                                 | `@inject ICustomerService Api`                                       |
| Service registration in startup (`AddScoped`)             | Registers app services with scoped lifetime.            | `src/BlazorWebAssemblyApp/Program.cs`                                                                 | `builder.Services.AddScoped<ICustomerService, ApiCustomerService>()` |
| HTTP calls                                                | Fetches JSON data from HTTP endpoints.                  | `src/BlazorWebAssemblyApp/Pages/Weather.razor`                                                        | `Http.GetFromJsonAsync<WeatherForecast[]>(...)`                      |
| HTTP calls via service abstraction                        | Hides HTTP details behind service interface.            | `src/BlazorWebAssemblyApp/Services/ICustomerService.cs`                                               | `ApiCustomerService.GetAll()` uses `GetFromJsonAsync`                |
| Async lifecycle (`OnInitializedAsync`)                    | Loads data during component initialization.             | `src/BlazorWebAssemblyApp/Pages/Customers/List.razor`                                                 | Loads customers on initialization                                    |
| Parameters (`[Parameter]`)                                | Parent passes values and templates to children.         | `src/BlazorWebAssemblyApp/Shared/*.razor`                                                             | `CustomerTable`, `EntityTable`, `AddressComponent`, `ProductTable`   |
| Render templates (`RenderFragment` / `RenderFragment<T>`) | Supports reusable generic UI with custom content slots. | `src/BlazorWebAssemblyApp/Shared/EntityTable.razor`                                                   | Generic table with `HeaderTemplate` + `RowTemplate`                  |
| Template composition in a page                            | Page provides template blocks to child component.       | `src/BlazorWebAssemblyApp/Pages/Customers/List.razor`                                                 | Passes `HeaderTemplate` and `RowTemplate` into `CustomerTable`       |
| Event handling (`@onclick`)                               | Binds browser events to C# methods.                     | `src/BlazorWebAssemblyApp/Pages/Counter.razor`, `src/BlazorWebAssemblyApp/Layout/NavMenu.razor`       | `IncrementCount()` + `ToggleNavMenu()`                               |
| Navigation links (`NavLink`)                              | Renders links with active-route styling.                | `src/BlazorWebAssemblyApp/Layout/NavMenu.razor`                                                       | `NavLink ... Match="NavLinkMatch.All"`                               |
| Conditional rendering (loading vs data)                   | Shows different UI based on component state.            | `src/BlazorWebAssemblyApp/Pages/Customers/List.razor`, `src/BlazorWebAssemblyApp/Pages/Weather.razor` | `if (customers == null)` / `if (forecasts == null)`                  |
| Page titles (`<PageTitle>`)                               | Sets browser/tab page title per route.                  | `src/BlazorWebAssemblyApp/Pages/*`                                                                    | `<PageTitle>Weather</PageTitle>`, `<PageTitle>Counter</PageTitle>`   |


## Component attributes and communication (current status)


| Feature                      | What it does                                                 | Current usage in this repo                                                                                       |
| ---------------------------- | ------------------------------------------------------------ | ---------------------------------------------------------------------------------------------------------------- |
| `[Parameter]`                | Defines values passed from parent to child components.       | Used in many WebAssembly shared components (`EntityTable`, `CustomerTable`, `ProductTable`, `AddressComponent`). |
| `[CascadingParameter]`       | Receives values provided by an ancestor (cascading context). | Used in server app: `src/BlazorServerApp/Components/Pages/Error.razor`.                                          |
| `EventCallback`              | Child component notifies parent about user actions/events.   | Not used yet in current codebase; good next step for parent-child event communication demos.                     |
| `[SupplyParameterFromQuery]` | Binds URL query-string values to component parameters.       | Not used yet in current codebase.                                                                                |


## What to start with (recommended reading order)

1. `src/BlazorWebAssemblyApp/App.razor` (routing entry point)
2. `src/BlazorWebAssemblyApp/Layout/MainLayout.razor` and `src/BlazorWebAssemblyApp/Layout/NavMenu.razor` (shared UI)
3. `src/BlazorWebAssemblyApp/Pages/Customers/List.razor` (DI + async loading + templates + parameters)
4. `src/BlazorWebAssemblyApp/Shared/EntityTable.razor` (generic reusable component pattern)
5. `src/BlazorWebAssemblyApp/Pages/Weather.razor` (HTTP + JSON)
6. `src/BlazorWebAssemblyApp/Pages/Counter.razor` (events)

