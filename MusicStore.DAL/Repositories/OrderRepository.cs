using Microsoft.EntityFrameworkCore;
using MusicStore.DAL.Models;
using MusicStore.DAL.Repositories.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace MusicStore.DAL.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository()
        {
        }

        public OrderRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Order> GetAllOrders()
        {
            var orders = Database.Orders.Include(o => o.Album).Include(o => o.User);

            return orders;
        }

        public IEnumerable<Order> GetOrdersByUser(int userId)
        {
            var order = Database.Orders.Include(o => o.Album).Include(o => o.User).Where(u => u.UserId == userId);
            return order;
        }
    }
}
