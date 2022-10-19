using MusicStore.DAL.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using MusicStore.DAL.Repositories.Abstract;

namespace MusicStore.DAL.Repositories
{
    public class TrackRepository : BaseRepository<Track>, ITrackRepository
    {
        public TrackRepository()
        {
        }

        public TrackRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<Track> GetTracksFromAlbum(int albumId)
        {
            var tracks = Database.Tracks.Include(t => t.Album).Include(t => t.Genre).Where(t => t.Album.Id == albumId);
            return tracks;
        }
        public IEnumerable<Track> GetTracksByArtist(int artistId)
        {
            var tracks = Database.Tracks.Where(t => t.Album.Artist.Id == artistId);
            return tracks;
        }

    }
}
