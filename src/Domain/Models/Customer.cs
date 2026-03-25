namespace Domain.Models;

public class Customer : BaseEntity
{
    public required string Name { get; set; }
    public required string Email { get; set; }
    public Address HomeAddress { get; set; }
    public Address ShippingAddress { get; set; }
    public bool IsDeleted { get; set; }
}

public record Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string Country { get; set; }    
}