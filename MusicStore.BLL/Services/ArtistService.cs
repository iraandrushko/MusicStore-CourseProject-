using MusicStore.DAL.Models;
using MusicStore.DAL.Repositories;
using MusicStore.DAL.Repositories.Abstract;
using MusicStore.DTO;
using System.Collections.Generic;

namespace MusicStore.BLL.Services
{
    public class ArtistService : BaseService<Artist, ArtistDto>, IArtistService
    {
        private readonly IArtistRepository artistRepository;
        public ArtistService() : this(new ArtistRepository())
        {
        }

        public ArtistService(IArtistRepository artistRepository) : base(artistRepository)
        {
            this.artistRepository = artistRepository;
        }

        public ArtistDto GetArtistByName(string artistName)
        {
            var artist = artistRepository.GetArtistByName(artistName);
            return this.Mapper.Map<ArtistDto>(artist);
        }

        public IEnumerable<AlbumDto> GetAlbums(int artistId)
        {
            var artistAlbums = artistRepository.GetAlbums(artistId);
            return this.Mapper.Map<IEnumerable<AlbumDto>>(artistAlbums);
        }
    }
}