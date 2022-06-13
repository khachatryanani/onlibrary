using OnlibraryOrdersDataAccess.BaseClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlibraryOrdersDataAccess
{
    public interface IOrdersDataAccess
    {
        public int CreateOrder(OrderBase order);

        public IEnumerable<OrderBase> GetOrders(string userId);
    }
}
