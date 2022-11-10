using MusicStore.DAL.Models;
using MusicStore.DAL.Repositories;
using MusicStore.DAL.Repositories.Abstract;
using MusicStore.DTO;

namespace MusicStore.BLL.Services
{
    public class CreditCardService : BaseService<CreditCard, CreditCardDto>, ICreditCardService
    {
        public CreditCardService() : this(new CreditCardRepository())
        {
        }

        public CreditCardService(IRepository<CreditCard> repository) : base(repository)
        {
        }
    }
}