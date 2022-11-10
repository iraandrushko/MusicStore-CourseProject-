using MusicStore.DAL.Models;
using System.Collections.Generic;

namespace MusicStore.DAL.Repositories.Abstract
{
    public interface IAlbumRepository : IRepository<Album>
    {
        IEnumerable<Album> GetAlbumsWithArtists();
    }
}
