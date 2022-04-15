using Microsoft.AspNetCore.Mvc;
using NexaraProject.Business.Abstracts.Engines;

namespace NexaraProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SizeSetsController : ControllerBase
    {
        private readonly ISizeSetEngine _sizeSetEngine;

        public SizeSetsController(ISizeSetEngine sizeSetEngine)
        {
            _sizeSetEngine = sizeSetEngine;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _sizeSetEngine.GetSizeSets();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}