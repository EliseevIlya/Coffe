using Coffe.dto;
using Coffe.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe.service.Impl
{
    internal class OrderServiceImpl : IOrderService
    {
        private readonly IRepository<Order> _repository;

        public OrderServiceImpl(IRepository<Order> repository)
        {
            _repository = repository;
        }

        public void DeleteOrder(int id)
        {
            _repository.DeleteById(id);
        }

        public Order? GetOrderById(int id)
        {
            return _repository.GetById(id);
        }

        public List<Order> GetAllOrders()
        {
            return _repository.GetAll();
        }

        public void AddOrder(OrderCreateDTO createDTO)
        {
            var order = new Order();
            order.Drinks = createDTO.Drinks;
            order.CustomerName = createDTO.CustomerName;
            order.OrderPrice = createDTO.Drinks.Sum(x => x.Price);
            _repository.Add(order);
        }
    }
}
