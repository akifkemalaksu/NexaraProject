using Microsoft.EntityFrameworkCore;
using NexaraProject.Core.Entities;
using System;
using System.Linq.Expressions;

namespace NexaraProject.Core.DataAccess.EntityFramework
{
    public class EntityFrameworkRepositoryBase<TContext, TEntity, TKey> : IRepository<TEntity, TKey>
    where TContext : DbContext, new()
    where TEntity : class, IEntity<TKey>, new()
    where TKey : struct
    {
        protected readonly TContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;
        private bool _disposed = false;

        public EntityFrameworkRepositoryBase(TContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        #region IRepository members

        public TEntity Add(TEntity entity)
        {
            entity.CreateDate = DateTime.Now;
            _dbSet.Add(entity);
            return entity;
        }

        public void Delete(TKey key)
        {
            var entity = Get(key);
            Delete(entity);
        }

        public TEntity Get(TKey key)
        {
            return _dbSet.Find(key);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> expression)
        {
            return _dbSet.Where(expression).FirstOrDefault();
        }

        public ICollection<TEntity> GetList(Expression<Func<TEntity, bool>> expression = null)
        {
            return expression is null ?
                _dbSet.ToList() :
                _dbSet.Where(expression).ToList();
        }

        public TEntity Update(TEntity entity)
        {
            entity.EditDate = DateTime.Now;
            _dbContext.ChangeTracker.Clear();
            _dbSet.Update(entity);
            return entity;
        }

        private void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        #endregion IRepository members

        #region IDisposable members

        ~EntityFrameworkRepositoryBase()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && !_disposed)
            {
                _dbContext.Dispose();
            }

            _disposed = true;
        }

        #endregion IDisposable members
    }
}