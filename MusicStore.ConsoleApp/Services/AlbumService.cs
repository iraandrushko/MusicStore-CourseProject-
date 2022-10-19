using MusicStore.DAL.Models;
using MusicStore.DAL.Repositories;
using MusicStore.DAL.Repositories.Abstract;
using MusicStore.DTO;

namespace MusicStore.ConsoleApp.Services
{
    public class AlbumService : BaseService<Album, AlbumDto>
    {
        public AlbumService() : this(new AlbumRepository())
        {
        }

        public AlbumService(IRepository<Album> repository) : base(repository)
        {
        }
    }
}