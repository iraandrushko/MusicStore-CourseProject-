using MusicStore.DAL.Models;
using MusicStore.DTO;
using System.Collections.Generic;

namespace MusicStore.BLL.Services
{
    public interface IAlbumService : IBaseService<Album, AlbumDto>
    {
        IEnumerable<AlbumDto> GetAlbumsWithArtists();
    }
}
