using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MusicStore.DAL.Mappers;
using MusicStore.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace MusicStore.DAL.Repositories
{
    public abstract class BaseRepository<TEntity, TDto> where TEntity : BaseEntity
    {
        private readonly DbSet<TEntity> dbSet;
        protected readonly IMapper Mapper;
        protected readonly ApplicationDbContext Database;

        public BaseRepository()
        {
            this.Database = new ApplicationDbContext();
            this.Mapper = new Mapper(AutoMapperConfiguration.GetMapperConfiguration());
            this.dbSet = Database.Set<TEntity>();
        }

        public TDto GetById(int id) 
        {
            return Mapper.Map<TDto>(dbSet.Find(id));
        }

        public IEnumerable<TDto> GetAll() 
        {
            return Mapper.Map<List<TDto>>(dbSet.ToList());
        }

        public void Create(TDto dto)
        {
            var entity = Mapper.Map<TEntity>(dto);
            entity.CreatedDate = DateTime.Now;
            entity.UpdatedDate = DateTime.Now;
            dbSet.Add(entity);
            Database.SaveChanges();
        }

        public void Update(int id, TDto dto)
        {
            var model = Mapper.Map<TEntity>(dto);
            var entity = dbSet.Find(id);

            Mapper.Map<TEntity, TEntity>(model, entity);

            entity.Id = id;
            entity.UpdatedDate = DateTime.Now;

            dbSet.Update(entity);
            Database.SaveChanges();
        }

        public void Remove(int id)
        {
            var entity = dbSet.Find(id);

            dbSet.Remove(entity);

            Database.SaveChanges();
        }
    }
}
