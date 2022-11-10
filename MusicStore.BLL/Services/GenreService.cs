using MusicStore.DAL.Models;
using MusicStore.DAL.Repositories;
using MusicStore.DAL.Repositories.Abstract;
using MusicStore.DTO;

namespace MusicStore.BLL.Services
{
    public class GenreService : BaseService<Genre, GenreDto>, IGenreService
    {
        public GenreService() : this(new GenreRepository())
        {
        }

        public GenreService(IRepository<Genre> repository) : base(repository)
        {
        }
    }
}