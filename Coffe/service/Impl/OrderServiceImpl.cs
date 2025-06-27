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
        private readonly IDiscountService _discountService;

        public OrderServiceImpl(IRepository<Order> repository, DiscountServiceImpl discountService)
        {
            _repository = repository;
            _discountService = discountService;
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
            double totalPrice = createDTO.Drinks.Sum(x => x.Price);
            double finalPrice = _discountService.ApplyDiscount(totalPrice, DateTime.Now);
            order.OrderPrice = finalPrice;
            _repository.Add(order);
        }
    }
}
