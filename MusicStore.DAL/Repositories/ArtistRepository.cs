using Microsoft.EntityFrameworkCore;
using MusicStore.DAL.Models;
using MusicStore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicStore.DAL.Repositories
{
    public class ArtistRepository : BaseRepository<Artist, ArtistDto>
    {
        public ArtistDto GetArtistByName(string artistName)
        {
            var artist = Database.Artists.Where(t => t.Name == artistName).FirstOrDefault();
            return Mapper.Map<ArtistDto>(artist);
        }

        public IEnumerable<AlbumDto> GetAlbums(int artistId)
        {
            var artist = Database.Artists.Include(a => a.Albums).Where(a => a.Id == artistId).FirstOrDefault();
            var artistAlbums = artist.Albums;
            return Mapper.Map<IEnumerable<AlbumDto>>(artistAlbums);
        }
    }
}
