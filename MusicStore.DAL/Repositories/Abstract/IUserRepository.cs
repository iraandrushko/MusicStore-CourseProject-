using MusicStore.DAL.Models;
using System.Collections.Generic;

namespace MusicStore.DAL.Repositories.Abstract
{
    public interface IUserRepository : IRepository<User>
    {
        User GetUserByEmail(string email);
        IEnumerable<User> GetAllUsersWithCards();
        User GetUserByLogin(string login);
    }
}
