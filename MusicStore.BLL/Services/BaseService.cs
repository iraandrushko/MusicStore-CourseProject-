using AutoMapper;
using MusicStore.BLL.Mappers;
using MusicStore.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MusicStore.BLL.Services
{
    public abstract class BaseService<TEntity, TDto> : IBaseService<TEntity, TDto>
    {
        protected readonly IMapper Mapper;
        private readonly IRepository<TEntity> repository;

        public BaseService(IRepository<TEntity> repository)
        {
            this.repository = repository;
            this.Mapper = new Mapper(AutoMapperConfiguration.GetMapperConfiguration());
        }

        public IEnumerable<TDto> Get(Expression<Func<TEntity, bool>> filter = null)
        {
            return Mapper.Map<List<TDto>>(repository.Get(filter).ToList());
        }

        public IEnumerable<TDto> GetAll()
        {
            return Mapper.Map<List<TDto>>(repository.GetAll().ToList());
        }

        public virtual void Create(TDto dto)
        {
            var entity = Mapper.Map<TEntity>(dto);
            repository.Create(entity);
        }

        public virtual TDto GetById(int id)
        {
            var entity = repository.GetById(id);
            return this.Mapper.Map<TDto>(entity);
        }

        public virtual void Update(int id, TDto dto)
        {
            var model = Mapper.Map<TEntity>(dto);
            var entity = repository.GetById(id);
            Mapper.Map(model, entity);

            repository.Update(entity);
        }

        public virtual void Remove(int id)
        {
            repository.Remove(id);
        }
    }
}
