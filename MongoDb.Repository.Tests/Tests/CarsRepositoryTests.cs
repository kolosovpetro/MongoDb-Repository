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
            var hummer = repository
                .GetByFieldValue("name", "Hummer")
                .Result.First();
            hummer.Name.Should().Be("Hummer");
            hummer.Price.Should().Be(41400);
        }

        [Test]
        public void Get_All_Test()
        {
            var repository = new CarsRepository();
            var all = repository.GetAll().Result;
            all.Count.Should().Be(8);
        }
    }
}