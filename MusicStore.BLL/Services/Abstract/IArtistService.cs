using MusicStore.DAL.Models;
using MusicStore.DTO;
using System.Collections.Generic;

namespace MusicStore.BLL.Services
{
    public interface IArtistService : IBaseService<Artist, ArtistDto>
    {
        IEnumerable<AlbumDto> GetAlbums(int artistId);
        ArtistDto GetArtistByName(string artistName);
    }
}