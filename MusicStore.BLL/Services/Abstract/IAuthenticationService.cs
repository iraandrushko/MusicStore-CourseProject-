using MusicStore.DTO;
using MusicStore.DTO.Enum;
using System;

namespace MusicStore.BLL.Services
{
    public interface IAuthenticationService
    {
        bool Register(string firstName, string lastName, string email, string login, string password, GenderDto gender, string address, string phoneNumber, string secretWord, string cardNumber, DateTime creditCardExpirationDate, string bankName);
        bool ResetPassword(string login, string secretWord, string password);
        UserDto SignIn(string email, string password);
    }
}