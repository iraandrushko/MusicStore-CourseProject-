using MusicStore.DAL.Models;

namespace MusicStore.DAL.Repositories
{
    public class CreditCardRepository : BaseRepository<CreditCard>
    {
        public CreditCardRepository()
        {
        }

        public CreditCardRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
