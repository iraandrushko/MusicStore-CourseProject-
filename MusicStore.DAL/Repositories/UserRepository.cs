using Microsoft.EntityFrameworkCore;
using MusicStore.DAL.Models;
using MusicStore.DAL.Repositories.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace MusicStore.DAL.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository()
        {
        }

        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public User GetUserByEmail(string email)
        {
            var user = Database.Users.Include(u => u.CreditCard).Where(u => u.Email == email).FirstOrDefault();
            return user;
        }

        public IEnumerable<User> GetAllUsersWithCards()
        {
            var users = Database.Users.Include(u => u.CreditCard);
            return users;
        }

        //public dynamic GetTestUser() 
        //{
        //    var user1 = Database.Users.Find(9);

        //    var filtered1 = Database.Users.Include(u => u.CreditCard).Where(u => u.FirstName.Length > 4);
        //    var filtered2 = filtered1.Where(u => u.Email.Contains("au")).ToList();
        //    //var filtered2 = filtered1.Where(u => CustomFilter1(u.Email)).ToList(); //exception
        //    var selected1 = filtered2.Select(u => new
        //    {
        //        FullName = u.FirstName + " " + u.LastName,
        //        UserEmail = u.Email,
        //        BankName = u.CreditCard.BankName
        //    });

        //    var user = selected1.FirstOrDefault();

        //    return user1;
        //}

        //public bool CustomFilter1(string input)
        //{
        //    return input.Contains("a");
        //}

    }
}
