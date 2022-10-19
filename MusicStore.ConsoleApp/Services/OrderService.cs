using MusicStore.DAL.Models;
using MusicStore.DAL.Repositories;
using MusicStore.DAL.Repositories.Abstract;
using MusicStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicStore.ConsoleApp.Services
{
    public class OrderService : BaseService<Order, OrderDto>
    {
        private readonly IOrderRepository repository;

        public OrderService() : this(new OrderRepository())
        {
        }

        public OrderService(IOrderRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        public IEnumerable<OrderDto> GetOrdersByUser(int userId)
        {
            var orders = repository.GetOrdersByUser(userId).ToList();
            return Mapper.Map<List<OrderDto>>(orders);
        }
    }
}