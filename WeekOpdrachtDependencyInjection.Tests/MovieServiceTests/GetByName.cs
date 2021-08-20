using Xunit;
using WeekOpdrachtDependencyInjection.Business;
using System;
using Moq;
using WeekOpdrachtDependencyInjection.Business.Interfaces;
using Microsoft.EntityFrameworkCore;
using WeekOpdrachtDependencyInjection.Business.Context;
using WeekOpdrachtDependencyInjection.Business.Entities;
using System.Linq;

namespace WeekOpdrachtDependencyInjection.Tests.CalculatePiServiceTests
{
    public class GetByName
    {
        [Fact]
        public void ItShould_GetMovieByName()
        {
            string name = "Jaws";

            // Arrange
            var options = new DbContextOptionsBuilder<MoviesContext>()
                .UseInMemoryDatabase(databaseName: "MovieDB")
                .Options;

            using (var context = new MoviesContext(options))
            {
                context.Movies.Add(new Movie { Title = "Jaws", ReleaseDate = new DateTime(1975, 1, 1) });
                context.Movies.Add(new Movie { Title = "Luca", ReleaseDate = new DateTime(2021, 1, 1) });
                context.Movies.Add(new Movie { Title = "Kill Bill", ReleaseDate = new DateTime(2003, 1, 1) });
                context.SaveChanges();
            }

            using (var context = new MoviesContext(options))
            {
                Mock<IMovieRepository> repository = new Mock<IMovieRepository>();
                repository.Setup(x => x.GetByName(name)).Returns(context.Movies.FirstOrDefault(m => m.Title == name));

                MovieService service = new MovieService(repository.Object);

                // Act
                var movie = service.GetByName(name);

                Assert.Equal(name, movie.Title);
            }
        }
    }
}
