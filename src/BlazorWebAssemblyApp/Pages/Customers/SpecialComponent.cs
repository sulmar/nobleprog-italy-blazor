using BlazorWebAssemblyApp.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyApp.Pages.Customers;

public class SpecialComponent : ComponentBase
{

    [CascadingParameter]
    public Theme Theme {  get; set; }
}
