using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MongoDb.Interfaces
{
    public interface IRepository<TEntity>
    {
        bool Insert(TEntity entity);  
        bool Update(TEntity entity);  
        bool Delete(TEntity entity);  
        IList<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate);  
        IList<TEntity> GetAll();  
        TEntity GetById(Guid id);  
    }
}