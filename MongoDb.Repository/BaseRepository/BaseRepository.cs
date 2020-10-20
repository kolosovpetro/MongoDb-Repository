using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using MongoDB.Bson;
using MongoDb.ConnectionStrings;
using MongoDB.Driver;
using MongoDb.Interfaces;

namespace MongoDb.BaseRepository
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<TEntity> _collection;

        public BaseRepository()
        {
            var client = new MongoClient(ConnectionString.Localhost);
            _database = client.GetDatabase(typeof(TEntity).Name);
            _collection = _database.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        public bool Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> SearchFor(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> GetAll()
        {
            return _collection.Find(new BsonDocument()).ToList();
        }

        public TEntity GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}