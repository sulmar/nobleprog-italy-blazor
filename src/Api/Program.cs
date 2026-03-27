using Bogus;
using Domain.Abstractions;
using Domain.Models;
using Infrastructure.Fakers;
using Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<ICustomerRepository, InMemoryCustomerRepository>();
builder.Services.AddSingleton<Faker<Customer>, CustomerFaker>();
builder.Services.AddSingleton<IEnumerable<Customer>>(sp =>
{
    var faker = sp.GetService<Faker<Customer>>();

    return faker.Generate(10);

});

builder.Services.AddSingleton<Faker<Address>, AddressFaker>();

builder.Services.AddCors(options => options.AddDefaultPolicy(policy=>
{
    policy.AllowAnyOrigin();
    policy.AllowAnyMethod();
    policy.AllowAnyHeader();
}));


var app = builder.Build();

app.UseCors();

app.MapGet("/", () => "Hello Api!");

// Security best practice: protect production API endpoints with authentication/authorization instead of exposing them publicly.
app.MapGet("/api/customers", async (ICustomerRepository repository) => await repository.GetAllAsync());
app.MapGet("/api/customers/{id}", async (ICustomerRepository repository, int id) => await repository.GetByIdAsync(id));


app.Run();
