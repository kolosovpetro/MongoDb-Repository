using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace MongoDb.Interfaces
{
    public interface IRepository<TEntity>
    {
        Task Insert(TEntity entity);
        Task<bool> Update(ObjectId id, string updateFieldName, string updateFieldValue);
        Task<bool> Delete(ObjectId id);
        Task<IList<TEntity>> GetAll();
        Task<IList<TEntity>> GetByFieldValue(string field, string value);
    }
}