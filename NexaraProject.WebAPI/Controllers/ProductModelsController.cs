using Microsoft.AspNetCore.Mvc;
using NexaraProject.Business.Abstracts.Engines;

namespace NexaraProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductModelsController : ControllerBase
    {
        private readonly IProductModelEngine _productModelEngine;

        public ProductModelsController(IProductModelEngine productModelEngine)
        {
            _productModelEngine = productModelEngine;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _productModelEngine.GetProductModels();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}