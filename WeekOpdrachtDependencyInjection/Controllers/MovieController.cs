using Microsoft.AspNetCore.Mvc;
using WeekOpdrachtDependencyInjection.Business;
using WeekOpdrachtDependencyInjection.Business.Interfaces;
using WeekOpdrachtDependencyInjection.Business.Repositories;

namespace WeekOpdrachtDependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieService movieService;
        private readonly IMovieRepository _repository;

        public MovieController(IMovieRepository repository)
        {
            _repository = repository;
            movieService = new MovieService(_repository);
        }

        [HttpGet]
        [Route("id/{id}")]
        public IActionResult Get(int id)
        {
            var movie = movieService.GetById(id);
            return Ok(movie);
        }

        [HttpGet]
        [Route("name/{name}")]
        public IActionResult Get(string name)
        {
            var movie = movieService.GetByName(name);
            return Ok(movie);
        }

        [HttpGet]
        [Route("seed")]
        public IActionResult Seed()
        {
            movieService.SeedDatabase();
            return Ok();
        }
    }
}
