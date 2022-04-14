using Microsoft.AspNetCore.Mvc;
using NexaraProject.Business.Abstracts.Engines;

namespace NexaraProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizeController : ControllerBase
    {
        private readonly ISizeEngine _sizeEngine;

        public SizeController(ISizeEngine sizeEngine)
        {
            _sizeEngine = sizeEngine;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _sizeEngine.GetSizes();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetSizesBySizeSet/{sizeSetId}")]
        public IActionResult GetSizesBySizeSet(int sizeSetId)
        {
            var result = _sizeEngine.GetSizesBySizeSet(sizeSetId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}