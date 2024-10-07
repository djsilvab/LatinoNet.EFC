namespace LatinoNet.EFC.Api.Models;

public class Customer
{
    public int CustomerId { get; set; }
    public required string Name { get; set; }
    public required Address Address { get; set; }
    public List<Order> Orders { get; set; }
}

