using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorWebAssemblyApp;
using BlazorWebAssemblyApp.Services;
using BlazorWebAssemblyApp.Services.Auth;
using Microsoft.AspNetCore.Components.Authorization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var identityProviderBaseUrl = builder.Configuration["ApiEndpoints:IdentityProviderBaseUrl"]
    ?? throw new InvalidOperationException("Missing configuration key: ApiEndpoints:IdentityProviderBaseUrl");
var customerApiBaseUrl = builder.Configuration["ApiEndpoints:CustomerApiBaseUrl"]
    ?? throw new InvalidOperationException("Missing configuration key: ApiEndpoints:CustomerApiBaseUrl");

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<AuthenticationStateProvider, JwtAuthStateProvider>();
builder.Services.AddTransient<JwtHandler>();

builder.Services.AddHttpClient<JwtAuthService>(client =>
{
    client.BaseAddress = new Uri(identityProviderBaseUrl);
});

builder.Services.AddHttpClient<ICustomerService, ApiCustomerService>(client =>
{
    client.BaseAddress = new Uri(customerApiBaseUrl);
})
.AddHttpMessageHandler<JwtHandler>();

await builder.Build().RunAsync();
