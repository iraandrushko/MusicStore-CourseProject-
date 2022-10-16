using MusicStore.DTO;
using MusicStore.DTO.Enum;

namespace MusicStore.DTO
{
    public class UserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public GenderDto Gender { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public virtual CreditCardDto CreditCard { get; set; }
    }
}
