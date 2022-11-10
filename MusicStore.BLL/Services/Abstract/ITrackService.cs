using MusicStore.DAL.Models;
using MusicStore.DTO;
using System.Collections.Generic;

namespace MusicStore.BLL.Services
{
    public interface ITrackService: IBaseService<Track, TrackDto>
    {
        IEnumerable<TrackDto> GetTracksByArtist(int artistId);
        IEnumerable<TrackDto> GetTracksFromAlbum(int albumId);
    }
}