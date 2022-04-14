using NexaraProject.Core.Entities;
using System;
using System.Linq.Expressions;

namespace NexaraProject.Core.DataAccess
{
    public interface IRepository<TEntity, TKey> : IDisposable
       where TEntity : class, IEntity<TKey>, new()
       where TKey : struct
    {
        TEntity Add(TEntity entity);

        void Delete(TKey key);

        TEntity Update(TEntity entity);

        TEntity Get(TKey key);

        TEntity Get(Expression<Func<TEntity, bool>> expression);

        ICollection<TEntity> GetList(Expression<Func<TEntity, bool>> expression = null);

        void SaveChanges();
    }
}