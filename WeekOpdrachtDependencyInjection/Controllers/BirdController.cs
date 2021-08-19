using Microsoft.AspNetCore.Mvc;
using WeekOpdrachtDependencyInjection.Business.Entities;

namespace WeekOpdrachtDependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BirdController : ControllerBase
    {
        [HttpGet]
        [Route("duck")]
        public IActionResult Duck()
        {
            return Ok(new Duck().Sound());
        }

        [HttpGet]
        [Route("goose")]
        public IActionResult Goose()
        {
            return Ok(new Goose().Sound());
        }

        [HttpGet]
        [Route("chicken")]
        public IActionResult Chicken()
        {
            return Ok(new Chicken().Sound());
        }
    }
}
