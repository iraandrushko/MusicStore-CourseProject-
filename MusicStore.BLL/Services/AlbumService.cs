using MusicStore.DAL.Models;
using MusicStore.DAL.Repositories;
using MusicStore.DAL.Repositories.Abstract;
using MusicStore.DTO;
using System.Collections.Generic;

namespace MusicStore.BLL.Services
{
    public class AlbumService : BaseService<Album, AlbumDto>, IAlbumService
    {
        private readonly IAlbumRepository repository;

        public AlbumService() : this(new AlbumRepository())
        {
        }

        public AlbumService(IAlbumRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        public IEnumerable<AlbumDto> GetAlbumsWithArtists() 
        {
            return Mapper.Map<List<AlbumDto>>(repository.GetAlbumsWithArtists());
        }
    }
}