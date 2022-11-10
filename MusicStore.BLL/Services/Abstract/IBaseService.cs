using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MusicStore.BLL.Services
{
    public interface IBaseService<TEntity, TDto>
    {
        void Create(TDto dto);
        IEnumerable<TDto> Get(Expression<Func<TEntity, bool>> filter = null);
        IEnumerable<TDto> GetAll();
        TDto GetById(int id);
        void Remove(int id);
        void Update(int id, TDto dto);
    }
}