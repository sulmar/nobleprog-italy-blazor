using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorWebAssemblyApp;
using BlazorWebAssemblyApp.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// TODO: please don't use hardcoded address
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7058") });

builder.Services.AddScoped<ICustomerService, ApiCustomerService>();

await builder.Build().RunAsync();
