using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GatewayAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        [HttpGet, Route("")]
        public IActionResult GetOrders()
        {
            var o1 = new Order("ID01", 200);
            var o2 = new Order("ID02", 400);
            return Ok(new List<Order> {o1, o2});
        }
    }

    public class Order
    {
        public string Id { get; set; }
        public decimal Amount { get; set; }

        public Order( string id, decimal amount)
        {
            Id = id;
            Amount = amount;
        }
    }
}