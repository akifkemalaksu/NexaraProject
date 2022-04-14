using Microsoft.AspNetCore.Mvc;
using NexaraProject.Business.Abstracts.Engines;

namespace NexaraProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductModelController : ControllerBase
    {
        private readonly IProductModelEngine _productModelEngine;

        public ProductModelController(IProductModelEngine productModelEngine)
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