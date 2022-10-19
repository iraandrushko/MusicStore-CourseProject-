using MusicStore.DAL.Models;
using MusicStore.DAL.Repositories.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace MusicStore.DAL.Repositories
{
    public class ArtistRepository : BaseRepository<Artist>, IArtistRepository
    {
        public ArtistRepository()
        {
        }

        public ArtistRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public Artist GetArtistByName(string artistName)
        {
            var artist = Database.Artists.Where(t => t.Name == artistName).FirstOrDefault();
            return artist;
        }

        public IEnumerable<Album> GetAlbums(int artistId)
        {
            var artistAlbums = Database.Albums.Where(a => a.Artist.Id == artistId);
            return artistAlbums;
        }
    }
}
