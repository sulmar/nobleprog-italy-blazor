using Bogus;
using Domain.Models;

namespace Infrastructure.Fakers;

// dotnet add package Bogus
public sealed class CustomerFaker : Faker<Customer>
{
    // Dependency Injection
    public CustomerFaker(Faker<Address> addressFaker)
    {
        UseSeed(1);
        RuleFor(p => p.Id, f => f.IndexFaker);
        RuleFor(p => p.Name, f => f.Company.CompanyName());
        RuleFor(p => p.Email, f => f.Internet.Email());
        RuleFor(p => p.IsDeleted, f => f.Random.Bool(0.3f)); // Adjusted probability distribution: 30% chance of being true
        RuleFor(p => p.HomeAddress, f => addressFaker.Generate());
        RuleFor(p => p.ShippingAddress, f => addressFaker.Generate());

    }
}

public sealed class AddressFaker : Faker<Address>
{
    public AddressFaker()
    {
        UseSeed(1);
        RuleFor(p => p.Street, f => f.Address.StreetName());
        RuleFor(p => p.City, f => f.Address.City());
        RuleFor(p => p.Country, f => f.Address.Country());
    }
}
