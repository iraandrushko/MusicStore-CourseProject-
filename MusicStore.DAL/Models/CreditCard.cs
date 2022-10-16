using System;
using System.ComponentModel.DataAnnotations;

namespace MusicStore.DAL.Models
{
    public class CreditCard : BaseEntity
    {
        [Required, StringLength(50)]
        public string Number { get; set; }

        [Required, StringLength(50)]
        public string BankName { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }

        public virtual User User { get; set; }
    }
}