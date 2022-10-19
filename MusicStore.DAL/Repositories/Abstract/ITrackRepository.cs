using MusicStore.DAL.Models;
using System.Collections.Generic;

namespace MusicStore.DAL.Repositories.Abstract
{
    public interface ITrackRepository: IRepository<Track>
    {
        IEnumerable<Track> GetTracksFromAlbum(int albumId);
        IEnumerable<Track> GetTracksByArtist(int artistId);
    }
}
