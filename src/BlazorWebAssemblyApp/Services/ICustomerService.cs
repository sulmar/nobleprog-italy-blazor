using Domain.Models;
using System.Net.Http.Json;

namespace BlazorWebAssemblyApp.Services;

public interface ICustomerService
{
    Task<IEnumerable<Customer>?> GetAll();
    Task<Customer?> Get(int id);
}



public class ApiCustomerService : ICustomerService
{
    private readonly HttpClient _client;

    public ApiCustomerService(HttpClient client)
    {
        _client = client;    
    }

    public Task<Customer?> Get(int id)
    {
        return _client.GetFromJsonAsync<Customer>($"api/customers/{id}");
    }

    public Task<IEnumerable<Customer>?> GetAll()
    {
        return _client.GetFromJsonAsync<IEnumerable<Customer>>("api/customers");
    }
}
