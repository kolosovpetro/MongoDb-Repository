using System;
using MongoDb.Interfaces;

namespace MongoDb
{
    public class Cars: IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}