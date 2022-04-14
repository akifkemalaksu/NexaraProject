using Microsoft.AspNetCore.Mvc;
using NexaraProject.Business.Abstracts.Engines;
using NexaraProject.Entities.RequestModels;

namespace NexaraProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderEngine _orderEngine;

        public OrderController(IOrderEngine orderEngine)
        {
            _orderEngine = orderEngine;
        }

        [HttpPost]
        public IActionResult Post(AddOrderModel addOrder)
        {
            var result = _orderEngine.AddOrder(addOrder);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}