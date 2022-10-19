using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicStore.DAL.Enums;
using MusicStore.DAL.Models;
using MusicStore.DAL.Repositories;
using MusicStore.DAL.Repositories.Abstract;
using MusicStore.DAL.Test.Common;
using MusicStore.DAL.Tests.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.DAL.Test.UserTests
{
    [TestClass]
    public class CreateDeleteUserTests : BaseTest
    {
        private const string CREATE_USER_EMAIL = "j.statham@gmail.com";

        private IUserRepository repository;

        public CreateDeleteUserTests()
        {
            this.repository = new UserRepository(this.dbContext);
        }

        [TestCleanup]
        public void OnTestCleanup() 
        {
            try
            {
                var user = this.repository.GetUserByEmail(CREATE_USER_EMAIL);
                if (user != null)
                {
                    this.repository.Remove(user.Id);
                }
            }
            catch { }
        }

        [TestMethod]
        public void Create_ValidEntity_ShouldCreateUser()
        {
            // Arrange
            var user = new User
            {
                FirstName = "Jason",
                LastName = "Statham",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Email = CREATE_USER_EMAIL,
                Login = "jason228",
                Password = "LalalaJasonInDaHouse11",
                PasswordSalt = "gafshdas_duytdvsa",
                Adress = "366 Shevchenka Street",
                Gender = Gender.Male,
                PhoneNumber = "380954989755",
                CreditCard = new CreditCard
                {
                    BankName = "AlfaBank",
                    ExpirationDate = DateTime.Now.AddDays(365),
                    Number = "5435 8787 9988 1245",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                }
            };

            // Act
            this.repository.Create(user);

            var insertedUser = this.repository.GetById(user.Id);

            // Assert
            Assert.IsNotNull(insertedUser);
            Assert.AreEqual("j.statham@gmail.com", insertedUser.Email);
            Assert.AreEqual("jason228", insertedUser.Login);
        }


        [TestMethod]
        [ExpectedException(typeof(DbUpdateException))]
        public void Create_InvalidEntityWithNoLogin_ShouldNotCreateUser()
        {
            // Arrange & Act & Assert
            this.repository.Create(new User
            {
                FirstName = "Jason",
                LastName = "Statham",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Email = CREATE_USER_EMAIL,
                Password = "LalalaJasonInDaHouse11",
                PasswordSalt = "gafshdas_duytdvsa",
                Adress = "366 Shevchenka Street",
                Gender = Gender.Male,
                PhoneNumber = "380954989755",
                CreditCard = new CreditCard
                {
                    BankName = "AlfaBank",
                    ExpirationDate = DateTime.Now.AddDays(365),
                    Number = "5435 8787 9988 1245",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                }
            });
        }
    }
}
