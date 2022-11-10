using Microsoft.EntityFrameworkCore;
using MusicStore.DAL.Models;
using MusicStore.DAL.Repositories.Abstract;
using System.Collections.Generic;

namespace MusicStore.DAL.Repositories
{
    public class AlbumRepository : BaseRepository<Album>, IAlbumRepository
    {
        public AlbumRepository()
        {
        }

        public AlbumRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Album> GetAlbumsWithArtists()
        {
            return Database.Albums.Include(a => a.Artist);
        }
    }
}
