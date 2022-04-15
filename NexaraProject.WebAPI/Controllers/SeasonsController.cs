using Microsoft.AspNetCore.Mvc;
using NexaraProject.Business.Abstracts.Engines;

namespace NexaraProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeasonsController : ControllerBase
    {
        private readonly ISeasonEngine _seasonEngine;

        public SeasonsController(ISeasonEngine seasonEngine)
        {
            _seasonEngine = seasonEngine;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _seasonEngine.GetSeasons();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}