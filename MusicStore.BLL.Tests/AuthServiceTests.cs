using Moq;
using MusicStore.BLL.Services;
using MusicStore.DTO;
using NUnit.Framework;

namespace MusicStore.BLL.Tests
{
    [TestFixture]
    public class AuthServiceTests
    {
        private Mock<IUserService> userService;
        private AuthenticationService authService;
        [SetUp]
        public void Setup()
        {
            userService = new Mock<IUserService>(MockBehavior.Strict);
            authService = new AuthenticationService(userService.Object);
        }

        [Test]
        public void LoginTest()
        {
            string login = "AnneHathaway";
            string password = "veryfamous";
            var r = userService.Setup(d => d.Login(login, password)).Returns(true);
            var res = authService.SignIn(login, password);
            Assert.AreEqual(res, r);
        }
    }
}