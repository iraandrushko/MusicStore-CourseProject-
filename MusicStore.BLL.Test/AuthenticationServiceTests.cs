using Moq;
using MusicStore.BLL.Services;
using MusicStore.Common;
using NUnit.Framework;
using System;

namespace MusicStore.BLL.Test
{
    public class AuthenticationServiceTests
    {
        private IAuthenticationService authenticationService;
        private Mock<IUserService> userServiceMock;

        [SetUp]
        public void Setup()
        {
            userServiceMock = new Mock<IUserService>(MockBehavior.Strict);
        }

        [Test]
        public void IAuthenticationService_SignIn_ShouldReturnUser()
        {
            // Arrange
            const string userLogin = "test";
            const string userPassword = "9uQFF1Lh";
            const string salt = "7C7EA1B2-9DB8-4E44-B2DD-4D9E5EED3E27";

            var guidSalt = Guid.Parse(salt);
            var dbUserHashedPassword = Hashing.GetHashString(userPassword, guidSalt);// "631CB2CB9C536EBC9443C1D993CEA3B16F54B048949BDA4863CDC3DABD80D90DD2029B02B38474DEB66C5A16C60779C4306F66D5ADC34770AD57EE88199308BC";

            userServiceMock.Setup(us => us.GetUserByLogin(userLogin)).Returns(new DTO.UserDto 
            {
                Login = userLogin,
                FirstName = "John",
                LastName = "Simpson",
                Password = dbUserHashedPassword,
                PasswordSalt = guidSalt
            });

            authenticationService = new AuthenticationService(userServiceMock.Object);

            // Act
            var user = authenticationService.SignIn(userLogin, userPassword);

            // Assert
            Assert.NotNull(user);
            Assert.AreEqual(userLogin, user.Login);
        }
    }
}