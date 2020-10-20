using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace MongoDb.Interfaces
{
    public interface IRepository<TEntity>
    {
        Task Insert(TEntity entity);
        Task<bool> UpdateUser(ObjectId id, string updateFieldName, string updateFieldValue);
        Task<bool> DeleteUserById(ObjectId id);
        Task<long> DeleteAllUsers();
        Task<IList<TEntity>> Get(Func<TEntity, bool> predicate);
        Task<IList<TEntity>> GetAll();
        Task<IList<TEntity>> GetByFieldValue(string field, string value);
    }
}