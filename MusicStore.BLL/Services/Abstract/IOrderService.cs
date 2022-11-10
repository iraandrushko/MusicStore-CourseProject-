using MusicStore.DAL.Models;
using MusicStore.DTO;
using System.Collections.Generic;

namespace MusicStore.BLL.Services
{
    public interface IOrderService : IBaseService<Order, OrderDto>
    {
        IEnumerable<OrderDto> GetOrdersByUser(int userId);
    }
}