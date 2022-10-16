using MusicStore.DTO;
using MusicStore.DAL.Models;
using System.Collections.Generic;
using AutoMapper;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MusicStore.DAL.Repositories
{
    public class TrackRepository : BaseRepository<Track, TrackDto>
    {

        public IEnumerable<TrackDto> GetTracksFromAlbum(int albumId)
        {
            var tracks = Database.Tracks.Include(t => t.Album).Include(t => t.Genre).Where(t => t.Album.Id == albumId);
            return Mapper.Map<IEnumerable<TrackDto>>(tracks);
        }
        public IEnumerable<TrackDto> GetTracksByArtist(int artistId)
        {
            var tracks = Database.Tracks.Where(t => t.Album.Artist.Id == artistId);
            return Mapper.Map<IEnumerable<TrackDto>>(tracks); ;
        }

    }
}
