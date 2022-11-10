using MusicStore.Common;
using MusicStore.DTO;
using MusicStore.DTO.Enum;
using System;

namespace MusicStore.BLL.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUserService userService;

        public AuthenticationService(IUserService userService)
        {
            this.userService = userService;
        }

        public bool Register(
            string firstName,
            string lastName,
            string email,
            string login,
            string password,
            GenderDto gender,
            string address,
            string phoneNumber,
            string secretWord,
            string cardNumber,
            DateTime creditCardExpirationDate,
            string bankName)
        {
            var guid = Guid.NewGuid();

            var userDto = new UserDto
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Login = login,
                Password = Hashing.GetHashString(password, guid),
                PasswordSalt = guid,
                Gender = gender,
                Adress = address,
                PhoneNumber = phoneNumber,
                SecretWord = secretWord,
                CreditCard = new CreditCardDto 
                {
                    BankName = bankName,
                    Number = cardNumber,
                    ExpirationDate = creditCardExpirationDate
                }
            };

            try
            {
                this.userService.Create(userDto);
            }
            catch 
            {
                return false;
            }

            return true;
        }

        public UserDto SignIn(string login, string password)
        {
            var user = userService.GetUserByLogin(login);

            if (user != null) 
            {
                if (string.Equals(user.Password, Hashing.GetHashString(password, user.PasswordSalt)))
                {
                    return user;
                }
            }

            return null;
        }

        public bool ResetPassword(string login, string secretWord, string password) 
        {
            var user = userService.GetUserByLogin(login);
            if (user.SecretWord == secretWord)
            {
                var newPassword = Hashing.GetHashString(password, user.PasswordSalt);
                user.Password = newPassword;
                this.userService.Update(user.Id, user);
            }
            else
            {
                return false;
            }

            return true;
        }
    }
}
