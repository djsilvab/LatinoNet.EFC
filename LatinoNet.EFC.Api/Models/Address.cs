namespace LatinoNet.EFC.Api.Models;

public class Address
{
    public int AddressId { get; set; }
    public required string Line1{ get; set; }
    public required string Line2 { get; set; }
    public required string City { get; set; }
    public required string Country { get; set; }
    public required string PostCode { get; set; }
}

