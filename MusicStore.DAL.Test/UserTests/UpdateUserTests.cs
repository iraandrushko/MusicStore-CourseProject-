using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicStore.DAL.Repositories;
using MusicStore.DAL.Repositories.Abstract;
using MusicStore.DAL.Test.Common;

namespace MusicStore.DAL.Test.UserTests
{
    [TestClass]
    public class UpdateUserTests : BaseTest
    {
        private const string USER_TOUPDATE_EMAIL = "dpierrof@vimeo.com";
        private const string USER_TOUPDATE_OLDFIRSTNAME = "Trycia";
        private const string USER_TOUPDATE_NEWFIRSTNAME = "Antonina";

        private IUserRepository repository;

        public UpdateUserTests()
        {
            this.repository = new UserRepository(this.dbContext);
        }

        [TestCleanup]
        public void OnTestCleanup()
        {
            try
            {
                var user = this.repository.GetUserByEmail(USER_TOUPDATE_EMAIL);
                if (user != null)
                {
                    user.FirstName = USER_TOUPDATE_OLDFIRSTNAME;
                    this.repository.Update(user);
                }
            }
            catch { }
        }

        [TestMethod]
        public void Update_ValidFirstName_ShouldUpdateUser()
        {
            // Arrange & Act
            var user = this.repository.GetUserByEmail(USER_TOUPDATE_EMAIL);
            user.FirstName = USER_TOUPDATE_NEWFIRSTNAME;
            repository.Update(user);

            var updatedUser = this.repository.GetUserByEmail(USER_TOUPDATE_EMAIL);

            // Assert
            Assert.IsNotNull(updatedUser);
            Assert.AreEqual(USER_TOUPDATE_NEWFIRSTNAME, updatedUser.FirstName);
        }
    }
}
