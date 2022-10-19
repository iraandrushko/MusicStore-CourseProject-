using MusicStore.DAL.Models;

namespace MusicStore.DAL.Repositories
{
    public class GenreRepository : BaseRepository<Genre>
    {
        public GenreRepository()
        {
        }

        public GenreRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
