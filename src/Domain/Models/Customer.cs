using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Customer : BaseEntity
{
    [Required, MinLength(3)]
    public required string Name { get; set; }
    [EmailAddress]
    public required string Email { get; set; }
    public Address HomeAddress { get; set; } = new Address();
    public Address ShippingAddress { get; set; } = new Address();
    public bool IsDeleted { get; set; }


}

public record Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string Country { get; set; }    
}