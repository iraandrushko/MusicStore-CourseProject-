using MusicStore.DAL.Models;

namespace MusicStore.DAL.Repositories
{
    public class AlbumRepository : BaseRepository<Album>
    {
        public AlbumRepository()
        {
        }

        public AlbumRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
