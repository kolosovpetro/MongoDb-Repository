using System;

namespace MongoDb.Interfaces
{
    public interface IEntity
    {
        public Guid Id { get; set; }
    }
}