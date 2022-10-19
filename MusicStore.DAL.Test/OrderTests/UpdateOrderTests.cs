using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicStore.DAL.Repositories;
using MusicStore.DAL.Repositories.Abstract;
using MusicStore.DAL.Test.Common;

namespace MusicStore.DAL.Test.OrderTests
{
    [TestClass]
    public class UpdateOrderTests : BaseTest
    {
        private const int ORDER_TOUPDATE_ID = 7;
        private const int ORDER_TOUPDATE_OLDUSERID = 8;
        private const int ORDER_TOUPDATE_NEWUSERID = 5;

        private IOrderRepository repository;

        public UpdateOrderTests()
        {
            this.repository = new OrderRepository(this.dbContext);
        }

        [TestCleanup]
        public void OnTestCleanup()
        {
            try
            {
                var order = this.repository.GetById(ORDER_TOUPDATE_ID);
                if (order != null)
                {
                    order.UserId = ORDER_TOUPDATE_OLDUSERID;
                    this.repository.Update(order);
                }
            }
            catch { }
        }

        [TestMethod]
        public void Update_ValidUserId_ShouldUpdateOrder()
        {
            // Arrange & Act
            var order = this.repository.GetById(ORDER_TOUPDATE_ID);
            order.UserId = ORDER_TOUPDATE_NEWUSERID;
            repository.Update(order);

            var updatedOrder = this.repository.GetById(ORDER_TOUPDATE_ID);

            // Assert
            Assert.IsNotNull(updatedOrder);
            Assert.AreEqual(ORDER_TOUPDATE_NEWUSERID, updatedOrder.UserId);
        }
    }
}
