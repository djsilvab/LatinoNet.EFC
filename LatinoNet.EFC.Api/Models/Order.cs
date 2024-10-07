using Microsoft.EntityFrameworkCore;
using System.Net;

namespace LatinoNet.EFC.Api.Models;

public class Order
{
    public int OrderId { get; set; }
    public required string Contents { get; set; }
    [DeleteBehavior(DeleteBehavior.ClientCascade)]
    public required Address ShippingAddress { get; set; }
    [DeleteBehavior(DeleteBehavior.ClientCascade)]
    public required Address BillingAddress { get; set; }
    public Customer Customer { get; set; }
}

