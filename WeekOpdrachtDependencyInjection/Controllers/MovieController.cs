using Microsoft.AspNetCore.Mvc;
using WeekOpdrachtDependencyInjection.Business;

namespace WeekOpdrachtDependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieService movieService;

        public MovieController()
        {
            movieService = new MovieService();
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
    }
}
