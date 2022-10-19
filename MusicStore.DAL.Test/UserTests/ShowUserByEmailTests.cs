using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicStore.DAL.Repositories;
using MusicStore.DAL.Repositories.Abstract;
using MusicStore.DAL.Test.Common;

namespace MusicStore.DAL.Test.UserTests
{
    [TestClass]
    public class ShowUserByEmailTests : BaseTest
    {
        private IUserRepository repository;

        public ShowUserByEmailTests()
        {
            this.repository = new UserRepository(this.dbContext);
        }

        [TestMethod]
        public void ShowUserByEmail_ExistingEmail_ShouldReturnUser()
        {
            // Arrange
            var existingEmail = "kminchelle@qq.com";

            // Act
            var user = this.repository.GetUserByEmail(existingEmail);

            // Assert
            Assert.IsNotNull(user);
        }

        [TestMethod]
        public void ShowUserByEmail_UnexistingEmail_ShouldReturnUser()
        {
            // Arrange
            var EXISTINGEMAIL = "ajshdjasvjisavcjhvauh";

            // Act
            var user = this.repository.GetUserByEmail(EXISTINGEMAIL);

            // Assert
            Assert.IsNull(user);
        }
    }
}
