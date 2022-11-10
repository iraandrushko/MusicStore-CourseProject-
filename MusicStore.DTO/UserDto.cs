using MusicStore.DTO;
using MusicStore.DTO.Enum;
using System;

namespace MusicStore.DTO
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Guid PasswordSalt { get; set; }
        public GenderDto Gender { get; set; }
        public string SecretWord { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public CreditCardDto CreditCard { get; set; }
    }
}
