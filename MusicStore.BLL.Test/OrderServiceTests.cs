using Moq;
using MusicStore.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using MusicStore.BLL.Services;
using MusicStore.DAL.Models;
using System.Linq;

namespace MusicStore.BLL.Test
{
    public class OrderServiceTests
    {
        private Mock<IOrderRepository> orderRepoMock;

        [SetUp]
        public void Setup()
        {
            orderRepoMock = new Mock<IOrderRepository>(MockBehavior.Strict);
        }

        [Test]
        public void OrderServiceTests_GetOrdersByUser_ShouldReturnOrders()
        {
            // Arrange
            var userId = 1;
            var userOrders = new List<Order>
            {
                new Order
                {
                    Id = 1,
                    UserId = userId,
                    AlbumId = 8
                },
                new Order
                {
                    Id = 2,
                    UserId = userId,
                    AlbumId = 5
                }
            };

            orderRepoMock.Setup(r => r.GetOrdersByUser(userId)).Returns(userOrders);
            var orderService = new OrderService(orderRepoMock.Object);

            // Act
            var orders = orderService.GetOrdersByUser(userId).ToList();

            // Assert
            Assert.NotNull(orders);
            Assert.AreEqual(userOrders.Count, orders.Count);
        }
    }
}
