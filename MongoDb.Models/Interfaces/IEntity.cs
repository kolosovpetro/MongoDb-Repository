using MongoDB.Bson;

namespace MongoDb.Models.Interfaces
{
    public interface IEntity
    {
        public ObjectId Id { get; set; }
    }
}