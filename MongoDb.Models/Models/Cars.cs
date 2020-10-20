using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDb.Models.Interfaces;

namespace MongoDb.Models.Models
{
    public class Cars : IEntity
    {
        [BsonId] public ObjectId Id { get; set; }
        [BsonElement("name")] public string Name { get; set; }
        [BsonElement("price")] public double Price { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}";
        }
    }
}