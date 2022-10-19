using MusicStore.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.DAL.Repositories.Abstract
{
    public interface IOrderRepository : IRepository<Order>
    {
        IEnumerable<Order> GetOrdersByUser(int userId);
    }
}
