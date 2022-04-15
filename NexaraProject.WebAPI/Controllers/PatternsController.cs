using Microsoft.AspNetCore.Mvc;
using NexaraProject.Business.Abstracts.Engines;

namespace NexaraProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatternsController : ControllerBase
    {
        private readonly IPatternEngine _patternEngine;

        public PatternsController(IPatternEngine patternEngine)
        {
            _patternEngine = patternEngine;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _patternEngine.GetPatterns();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}