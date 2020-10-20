using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDb.ConnectionStrings;
using MongoDB.Driver;
using MongoDb.Interfaces;
using MongoDb.Models.Interfaces;

namespace MongoDb.BaseRepository
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        private readonly IMongoCollection<TEntity> _collection;

        public BaseRepository()
        {
            var client = new MongoClient(ConnectionString.Localhost);
            var database = client.GetDatabase(typeof(TEntity).Name);
            _collection = database.GetCollection<TEntity>(typeof(TEntity).Name);
        }


        public async Task Insert(TEntity entity)
        {
            await _collection.InsertOneAsync(entity);
        }

        public async Task<bool> UpdateUser(ObjectId id, string updateFieldName, string updateFieldValue)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteUserById(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public async Task<long> DeleteAllUsers()
        {
            throw new NotImplementedException();
        }

        public async Task<IList<TEntity>> Get(Func<TEntity, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<TEntity>> GetAll()
        {
            return await _collection.Find(new BsonDocument()).ToListAsync();
        }

        public async Task<IList<TEntity>> GetByFieldValue(string field, string value)
        {
            throw new NotImplementedException();
        }
    }
}