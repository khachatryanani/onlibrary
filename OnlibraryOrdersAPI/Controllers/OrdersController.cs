using Microsoft.AspNetCore.Mvc;
using OnlibraryOrdersDataAccess.BaseClasses;
using OnlibraryOrdersDataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlibraryOrdersDataAccess;

namespace OnlibraryOrdersAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : Controller
    {
        private readonly IOrdersDataAccess dataAccess;

        public OrdersController(IOrdersDataAccess dataAcc)
        {
            dataAccess = dataAcc;
        }

        [HttpPost]
        public int CreateOrder([FromBody]Order order)
        {
            order.OrderDate = DateTime.Now;
            order.Address = "User Address Here";
            order.Country = 1;
            var orderId = dataAccess.CreateOrder(order);

            return orderId;
        }

        [HttpGet("{id}")]
        public IEnumerable<OrderBase> GetOrders(string id)
        {
            var orders = dataAccess.GetOrders(id);
            return orders;
        }
    }
}
