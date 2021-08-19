using Microsoft.AspNetCore.Mvc;
using WeekOpdrachtDependencyInjection.Business.Entities;
using WeekOpdrachtDependencyInjection.Business.Interfaces;

namespace WeekOpdrachtDependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BirdController : ControllerBase
    {
        private readonly IBirdService _birdService;
        public BirdController (IBirdService birdService)
        {
            _birdService = birdService;
        }
        [HttpGet]
        [Route("{birdname}")]
        public IActionResult GetBirdSound(string birdname)
        {
            try
            {
                return Ok(_birdService.GetBirdByType(birdname).Sound());
            }
            catch (System.Exception)
            {
                return BadRequest();
            }
        }
    }
}
