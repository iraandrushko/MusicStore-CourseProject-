using MusicStore.DAL.Models;
using MusicStore.DTO;
using System.Collections.Generic;

namespace MusicStore.BLL.Services
{
    public interface IUserService : IBaseService<User, UserDto>
    {
        IEnumerable<UserDto> GetAllUsersWithCards();
        UserDto GetUserByEmail(string email);
        UserDto GetUserByLogin(string login);
    }
}