using BlazorWebAssemblyApp.Models;
using Domain.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorWebAssemblyApp.Pages.Customers;

public partial class List
{
    // This is equivalent to: @inject ICustomerService Api (declared at the top of this .razor file).
    // [Inject]
    // public ICustomerService Api { get; set; }

    [CascadingParameter]
    public Theme Theme { get; set; }


    private bool isLoading => customers is null;

    private IEnumerable<Customer>? customers;
    

    protected override async Task OnInitializedAsync()
    {
        customers = await Api.GetAll();
    }
}
