
# ✅ Overview of `dotnet new` commands for Blazor (.NET 8+)

| Application Type                               | `dotnet new` Command                            | Description                                                                              |
| ---------------------------------------------- | ----------------------------------------------- | ---------------------------------------------------------------------------------------- |
| **Blazor Web App – Interactive (Auto)**        | `dotnet new blazor --interactivity Auto`        | Default option – interactivity is matched to the environment (SSR + optionally WASM/Server)|
| **Blazor Web App – Non-interactive (SSR)**     | `dotnet new blazor --interactivity None`        | Server-side prerendering only (e.g., for HTMX), no interactive components                |
| **Blazor Web App – Server**                    | `dotnet new blazor --interactivity Server`      | Interactivity provided via SignalR (like Blazor Server)                                  |
| **Blazor Web App – WebAssembly**               | `dotnet new blazor --interactivity WebAssembly` | All components are rendered and run on the client side using WebAssembly                 |
| **Blazor WebAssembly Standalone**              | `dotnet new blazorwasm`                         | Classic Blazor WASM without a backend                                                    |
| **Blazor WebAssembly Hosted**                  | `dotnet new blazorwasm --hosted`                | Frontend and backend combined in a single solution                                       |
