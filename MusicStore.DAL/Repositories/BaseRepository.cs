using Microsoft.EntityFrameworkCore;
using MusicStore.DAL.Models;
using MusicStore.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MusicStore.DAL.Repositories
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly DbSet<TEntity> dbSet;
        protected readonly ApplicationDbContext Database;

        public BaseRepository() : this(new ApplicationDbContext())
        {
        }

        public BaseRepository(ApplicationDbContext dbContext)
        {
            this.Database = dbContext;
            this.dbSet = Database.Set<TEntity>();
        }

        public TEntity GetById(int id) 
        {
            return dbSet.Find(id);
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null) 
        {
            if (filter != null) 
            {
                return dbSet.Where(filter);
            }

            return GetAll();
        }

        public IEnumerable<TEntity> GetAll() 
        {
            return dbSet;
        }

        public void Create(TEntity entity)
        {
            entity.CreatedDate = DateTime.Now;
            entity.UpdatedDate = DateTime.Now;

            dbSet.Add(entity);
            Database.SaveChanges();
        }

        public void Update(TEntity entity)
        {
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
