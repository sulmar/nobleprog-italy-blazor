# ✅ Razor Directives Reference

| Directive       | Description                                                                                  | Example Usage                                                                 |
|-----------------|----------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------|
| `@inject`       | Used to inject dependencies (e.g., services) into components or pages.                       | `@inject NavigationManager Navigation`                                        |
| `@attribute`    | Used to assign attributes to a Blazor component.                                              | `@attribute [Authorize]`                                                      |
| `@page`         | Defines the URL route for a Blazor page.                                                     | `@page "/home"`                                                               |
| `@bind`         | Used to bind a property to a form element, enabling automatic value updates.                  | `<input @bind="inputValue" />`                                                |
| `@code`         | Allows embedding a block of C# code inside a Razor component.                                | `@code { private string inputValue; }`                                        |
| `@if`           | Used for conditional rendering of content in a component.                                    | `@if (isLoggedIn) { <h1>Welcome!</h1> }`                                      |
| `@else`         | Used with `@if` to define what to display when the condition is false.                       | `@if (isLoggedIn) { <h1>Welcome!</h1> } @else { <h1>Please log in!</h1> }`    |
| `@foreach`      | Used to render a collection or array in a loop.                                              | `@foreach (var item in items) { <p>@item</p> }`                               |
| `@while`        | Used to render content inside a `while` loop in a component.                                 | `@while (counter < 10) { <p>@counter</p> counter++; }`                        |
| `@ref`          | Allows assigning a reference to a DOM element or component, enabling direct access in C#.    | `<input @ref="myInput" />`                                                    |
| `@inherits`     | Allows a Blazor component to inherit from another class, extending base functionality.       | `@inherits MyBaseComponent`                                                   |
| `@layout`       | Specifies the layout to be used by a component, enabling a shared layout across the app.     | `@layout MainLayout`                                                          |

---

### Explanation:

- **`@inject`**: Enables injecting services or other dependencies into Blazor components.  
  Example: `NavigationManager` allows navigation inside the app.  

- **`@attribute`**: Allows assigning attributes to a Blazor component, e.g., `[Authorize]` for authorization.  

- **`@page`**: Defines the URL under which the page will be accessible (required for Blazor pages).  

- **`@bind`**: Enables two-way binding between a property and a form element (e.g., a text field).  

- **`@code`**: Embeds C# logic inside a Razor component.  

- **`@if` / `@else`**: Used for conditional rendering of content.  

- **`@foreach`**: Renders a collection of elements dynamically.  

- **`@while`**: Allows rendering content in a `while` loop.  

- **`@ref`**: Assigns a reference to a DOM element or component for later access in C#.  

- **`@inherits`**: Allows extending a component from a base class.  

- **`@layout`**: Specifies the layout that should be applied to a component.  

## Razor Example

```razor
@page "/products"
@inject NavigationManager Navigation
@attribute [Authorize]

<h3>Product List</h3>

<input @bind="searchTerm" placeholder="Search products..." />

@if (FilteredProducts.Any())
{
    <ul>
        @foreach (var product in FilteredProducts)
        {
            <li>@product.Name - @product.Price.ToString("C")</li>
        }
    </ul>
}
else
{
    <p>No products found.</p>
}

<button @onclick="GoToHome">Go to Home</button>

@code {
    private string searchTerm = string.Empty;

    private List<Product> Products = new List<Product>
    {
        new Product { Name = "Laptop", Price = 999.99m },
        new Product { Name = "Smartphone", Price = 499.99m },
        new Product { Name = "Tablet", Price = 299.99m }
    };

    private IEnumerable<Product> FilteredProducts =>
        Products.Where(p => string.IsNullOrWhiteSpace(searchTerm) || p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase));

    private void GoToHome()
    {
        Navigation.NavigateTo("/");
    }

    private class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
```