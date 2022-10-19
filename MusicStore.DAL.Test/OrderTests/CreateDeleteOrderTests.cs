using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicStore.DAL.Models;
using MusicStore.DAL.Repositories;
using MusicStore.DAL.Repositories.Abstract;
using MusicStore.DAL.Test.Common;
using MusicStore.DAL.Tests.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.DAL.Test.OrderTests
{
    [TestClass]
    public class CreateDeleteOrderTests : BaseTest
    {
        private IOrderRepository repository;
        private int createdOrderId;

        public CreateDeleteOrderTests()
        {
            this.repository = new OrderRepository(this.dbContext);
        }

        [TestCleanup]
        public void OnTestCleanup()
        {
            try
            {
                var order = this.repository.GetById(this.createdOrderId);
                if (order != null)
                {
                    this.repository.Remove(order.Id);
                }
            }
            catch { }
        }

        [TestMethod]
        public void Create_ValidEntity_ShouldCreateOrder()
        {
            // Arrange
            const int USER_ID = 5;
            const int ALBUM_ID = 5;

            var order = new Order
            {
                UserId = USER_ID,
                AlbumId = ALBUM_ID,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            };

            // Act
            this.repository.Create(order);
            this.createdOrderId = order.Id;

            var insertedOrder = this.repository.GetById(order.Id);

            // Assert
            Assert.IsNotNull(insertedOrder);
            Assert.AreEqual(ALBUM_ID, insertedOrder.AlbumId);
            Assert.AreEqual(USER_ID, insertedOrder.UserId);
        }


        [TestMethod]
        [ExpectedException(typeof(DbUpdateException))]
        public void Create_InvalidEntity_ShouldNotCreateOrder()
        {
            // Arrange & Act & Assert
            this.repository.Create(new Order
            {
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
            });
        }
    }
}
