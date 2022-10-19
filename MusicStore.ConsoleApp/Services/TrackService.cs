using MusicStore.DAL.Models;
using MusicStore.DAL.Repositories;
using MusicStore.DAL.Repositories.Abstract;
using MusicStore.DTO;
using System.Collections.Generic;

namespace MusicStore.ConsoleApp.Services
{
    public class TrackService : BaseService<Track, TrackDto>
    {
        private readonly ITrackRepository trackRepository;

        public TrackService() : this(new TrackRepository())
        {
        }

        public TrackService(ITrackRepository trackRepository) : base(trackRepository)
        {
            this.trackRepository = trackRepository;
        }

        public IEnumerable<TrackDto> GetTracksFromAlbum(int albumId)
        {
            var tracks = trackRepository.GetTracksFromAlbum(albumId);
            return this.Mapper.Map<IEnumerable<TrackDto>>(tracks); 
        }

        public IEnumerable<TrackDto> GetTracksByArtist(int artistId)
        {
            var tracks = trackRepository.GetTracksByArtist(artistId);
            return this.Mapper.Map<IEnumerable<TrackDto>>(tracks);
        }
    }
}