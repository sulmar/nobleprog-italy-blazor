using System.Net.Http.Json;
using Microsoft.JSInterop;

namespace BlazorWebAssemblyApp.Services.Auth;

public class JwtAuthService
{
    private const string TokenKey = "authToken";
    private const string LoginEndpoint = "api/login";

    private readonly HttpClient _http;
    private readonly IJSRuntime _js;

    public JwtAuthService(HttpClient http, IJSRuntime js)
    {
        _http = http;
        _js = js;
    }

    public async Task<bool> Login(string username, string password)
    {
        var response = await _http.PostAsJsonAsync(LoginEndpoint, new
        {
            username,
            password
        });

        if (!response.IsSuccessStatusCode)
        {
            return false;
        }

        var result = await response.Content.ReadFromJsonAsync<LoginResponse>();
        if (result is null || string.IsNullOrWhiteSpace(result.AccessToken))
        {
            return false;
        }

        await _js.InvokeVoidAsync("localStorage.setItem", TokenKey, result.AccessToken);
        return true;
    }

    public async Task Logout()
    {
        await _js.InvokeVoidAsync("localStorage.removeItem", TokenKey);
    }

    public async Task<string?> GetTokenAsync()
    {
        return await _js.InvokeAsync<string?>("localStorage.getItem", TokenKey);
    }
}

public class LoginResponse
{
    public string AccessToken { get; set; } = string.Empty;
}
