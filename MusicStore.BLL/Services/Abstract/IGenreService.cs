using MusicStore.DAL.Models;
using MusicStore.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore.BLL.Services
{
    public interface IGenreService : IBaseService<Genre, GenreDto>
    {
    }
}
