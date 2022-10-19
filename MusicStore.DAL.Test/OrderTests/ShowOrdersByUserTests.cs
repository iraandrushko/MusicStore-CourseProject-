using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicStore.DAL.Repositories;
using MusicStore.DAL.Repositories.Abstract;
using MusicStore.DAL.Test.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicStore.DAL.Test.OrderTests
{
    [TestClass]
    public class ShowOrdersByOrdersTests : BaseTest
    {
        private IOrderRepository repository;

        public ShowOrdersByOrdersTests()
        {
            this.repository = new OrderRepository(this.dbContext);
        }

        [TestMethod]
        public void ShowOrdersByUser_ExistingEmail_ShouldReturnOrders()
        {
            // Arrange
            const int EXISTING_USERID = 8;

            // Act
            var orders = this.repository.GetOrdersByUser(EXISTING_USERID);

            // Assert
            Assert.IsNotNull(orders);
            Assert.IsTrue(orders.Any());
        }

        [TestMethod]
        public void ShowOrdersByUser_UnExistingUserId_ShouldNotReturnOrders()
        {
            // Arrange
            var UNEXISTING_USERID = 99;

            // Act
            var orders = this.repository.GetOrdersByUser(UNEXISTING_USERID).ToList();

            // Assert
            Assert.AreEqual(0, orders.Count);
        }
    }
}
