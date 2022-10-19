using MusicStore.DAL.Models;
using MusicStore.DAL.Repositories;
using MusicStore.DAL.Repositories.Abstract;
using MusicStore.DTO;

namespace MusicStore.ConsoleApp.Services
{
    public class CreditCardService : BaseService<CreditCard, CreditCardDto>
    {
        public CreditCardService() : this(new CreditCardRepository())
        {
        }

        public CreditCardService(IRepository<CreditCard> repository) : base(repository)
        {
        }
    }
}