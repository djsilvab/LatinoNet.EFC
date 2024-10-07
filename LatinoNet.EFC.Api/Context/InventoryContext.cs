using LatinoNet.EFC.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace LatinoNet.EFC.Api.Context;

public class InventoryContext(DbContextOptions<InventoryContext> options) : DbContext(options)
{
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Customer> Customers{ get; set; }
    public DbSet<Order> Orders { get; set; }
}

