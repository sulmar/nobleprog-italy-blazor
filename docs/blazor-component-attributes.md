# Blazor Component Attributes

| Attribute                | Description                                                                                               |
|--------------------------|-----------------------------------------------------------------------------------------------------------|
| `[Parameter]`            | Marks a public property as a component parameter that can be set by the parent component.                 |
| `[CascadingParameter]`   | Marks a property to receive a value from an ancestor component through cascading values.                  |
| `[SupplyParameterFromQuery]` | Allows a parameter to be bound from the query string in the URL.                                         |
| `[Inject]`               | Injects a service or dependency into the component from the dependency injection container.               |
| `[EventCallback]`        | Represents a delegate callback that can be invoked to notify the parent component of an event.            |

```csharp
using Microsoft.AspNetCore.Components;

public class ExampleComponent : ComponentBase
{
    [Parameter]
    public string Title { get; set; }

    [CascadingParameter]
    public string Theme { get; set; }

    [Parameter]
    [SupplyParameterFromQuery]
    public int PageNumber { get; set; }

    [Inject]
    public ILogger<ExampleComponent> Logger { get; set; }

    [Parameter]
    public EventCallback OnClicked { get; set; }

    private async Task HandleClick()
    {
        if (OnClicked.HasDelegate)
        {
            await OnClicked.InvokeAsync(null);
        }
    }
}
```

## Razor Directives in Components

| Directive   | Description                                                                    |
|-------------|--------------------------------------------------------------------------------|
| `@page`     | Declares a route template for a Razor component page.                         |
| `@using`    | Imports a namespace for use in the component.                                 |
| `@inject`   | Injects a service directly into a Razor component.                            |
| `@layout`   | Sets the layout component used to render the current Razor component.         |
| `@attribute`| Adds a .NET attribute to the generated component class.                       |
| `@typeparam`| Declares a generic type parameter for a Razor component.                      |
| `@inherits` | Specifies a base class for the component to inherit shared logic and members. |