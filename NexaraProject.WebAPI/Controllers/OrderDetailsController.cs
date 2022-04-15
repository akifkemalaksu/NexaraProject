using Microsoft.AspNetCore.Mvc;
using NexaraProject.Business.Abstracts.Engines;

namespace NexaraProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IOrderDetailEngine _orderDetailEngine;

        public OrderDetailsController(IOrderDetailEngine orderDetailEngine)
        {
            _orderDetailEngine = orderDetailEngine;
        }

        [HttpGet("{orderId}")]
        public IActionResult Get(int orderId)
        {
            var result = _orderDetailEngine.GetOrderDetailsWithInfosByOrder(orderId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}