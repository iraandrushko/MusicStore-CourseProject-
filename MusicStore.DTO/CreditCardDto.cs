using System;

namespace MusicStore.DTO
{
    public class CreditCardDto
    {
        public string Number { get; set; }
        public string BankName { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int UserId { get; set; }
    }
}
