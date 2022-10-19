using MusicStore.DAL.Models;
using System.Collections.Generic;

namespace MusicStore.DAL.Repositories.Abstract
{
    public interface IArtistRepository : IRepository<Artist>
    {
        Artist GetArtistByName(string artistName);
        IEnumerable<Album> GetAlbums(int artistId);
    }
}
