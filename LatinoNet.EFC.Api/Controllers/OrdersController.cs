using LatinoNet.EFC.Api.Context;
using LatinoNet.EFC.Api.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace LatinoNet.EFC.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly InventoryContext context;

        public OrdersController(InventoryContext context)
        {
            this.context = context;
        }

        [HttpGet(Name = "Orders")]
        public async Task<List<Dtos.Order>> GetOrders()
        {
            var ords = await context.Orders.Select(x => new Order
            {
                CustomerName = x.Customer.Name,
                ShippingAddress = x.ShippingAddress.Line1,
                BillingAddress = x.BillingAddress.Line1
            }).ToListAsync();

            return ords;
            
        }

    }
}
