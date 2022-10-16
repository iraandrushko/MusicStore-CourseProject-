using Microsoft.EntityFrameworkCore;
using MusicStore.DAL.Models;
using MusicStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicStore.DAL.Repositories
{
    public class OrderRepository : BaseRepository<Order, OrderDto>
    {
        public IEnumerable<OrderDto> GetAllOrders()
        {
            var orders = Database.Orders.Include(o => o.Album).Include(o => o.User);

            return Mapper.Map<IEnumerable<OrderDto>>(orders);
        }

        public OrderDto GetOrderByUser(int userId)
        {
            var order = Database.Orders.Include(o => o.Album).Include(o => o.User).Where(u => u.Id == userId).FirstOrDefault();
            return Mapper.Map<OrderDto>(order);
        }
    }
}
