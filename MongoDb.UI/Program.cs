using System;
using System.Linq;
using MongoDb.BaseRepository;
using MongoDb.Models.Models;

namespace MongoDb.UI
{
    public static class Program
    {
        private static void Main()
        {
            var repo = new BaseRepository<Cars>();
            var allCars = repo.GetAll();
            allCars.Result.ToList().ForEach(Console.WriteLine);
        }
    }
}