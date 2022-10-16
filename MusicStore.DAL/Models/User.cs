using MusicStore.DAL.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.DAL.Models
{
    public class User : BaseEntity
    {
        [Required, StringLength(50)]
        public string FirstName { get; set; }

        [Required, StringLength(50)]
        public string LastName { get; set; }

        [Required, StringLength(50)]
        public string Email { get; set; }

        [Required, StringLength(50)]
        public string Login { get; set; }

        [Required, StringLength(50)]
        public string Password { get; set; }

        [Required, StringLength(50)]
        public string PasswordSalt { get; set; }
        
        [Required]
        public Gender Gender { get; set; }

        [Required, StringLength(50)]
        public string Adress { get; set; }
        
        [Required, StringLength(25)]
        public string PhoneNumber { get; set; }

        [Required]
        public virtual CreditCard CreditCard { get; set; }
        public int CreditCardId { get; set; }

    }
}
