using Coffe.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe.service
{
    internal interface IOrderService
    {
        Order? GetOrderById(int id);
        List<Order> GetAllOrders();
        void DeleteOrder(int id);
    }
}
