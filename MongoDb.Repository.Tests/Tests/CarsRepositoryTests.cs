using System.Linq;
using FluentAssertions;
using MongoDb.Repositories;
using NUnit.Framework;

namespace MongoDb.Repository.Tests.Tests
{
    [TestFixture]
    public class CarsRepositoryTests
    {
        [Test]
        public void Get_By_Name_Test()
        {
            var repository = new CarsRepository();
        }
    }
}