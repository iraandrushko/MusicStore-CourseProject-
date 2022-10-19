using MusicStore.DAL.Models;
using MusicStore.DAL.Repositories;
using MusicStore.DAL.Repositories.Abstract;
using MusicStore.DTO;
using System;
using System.Collections.Generic;

namespace MusicStore.ConsoleApp.Services
{
    public class UserService : BaseService<User, UserDto>
    {
        private readonly IUserRepository userRepository;

        public UserService() : this(new UserRepository())
        {
        }

        public UserService(IUserRepository userRepository) : base(userRepository)
        {
            this.userRepository = userRepository;
        }

        public UserDto GetUserByEmail(string email) 
        {
            if (!email.Contains("@")) 
            {
                throw new ArgumentException("Invalid email passed");
            }
            var user = userRepository.GetUserByEmail(email);
            return this.Mapper.Map<UserDto>(user);
        }

        public IEnumerable<UserDto> GetAllUsersWithCards()
        {
            var users = userRepository.GetAllUsersWithCards();
            return this.Mapper.Map<IEnumerable<UserDto>>(users);
        }
    }
}
