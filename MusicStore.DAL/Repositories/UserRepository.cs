using Microsoft.EntityFrameworkCore;
using MusicStore.DAL.Models;
using MusicStore.DAL.Repositories.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

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

        public User GetUserByLogin(string login)
        {
            var user = Database.Users.Include(u => u.CreditCard).Where(u => u.Login == login).FirstOrDefault();
            return user;
        }

    }
}
