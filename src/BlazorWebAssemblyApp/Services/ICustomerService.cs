using Domain.Models;
using System.Net.Http.Json;

namespace BlazorWebAssemblyApp.Services;

public interface ICustomerService
{
    Task<IEnumerable<Customer>?> GetAll();
}



public class ApiCustomerService : ICustomerService
{
    private readonly HttpClient _client;

    public ApiCustomerService(HttpClient client)
    {
        _client = client;    
    }

    public Task<IEnumerable<Customer>?> GetAll()
    {
        return _client.GetFromJsonAsync<IEnumerable<Customer>>("api/customers");
    }
}
