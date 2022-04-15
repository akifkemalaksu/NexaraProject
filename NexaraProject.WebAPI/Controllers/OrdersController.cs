using Microsoft.AspNetCore.Mvc;
using NexaraProject.Business.Abstracts.Engines;
using NexaraProject.Entities.RequestModels;

namespace NexaraProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderEngine _orderEngine;

        public OrdersController(IOrderEngine orderEngine)
        {
            _orderEngine = orderEngine;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _orderEngine.GetOrdersWithInfos();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
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

        [HttpDelete("{orderId}")]
        public IActionResult Delete(int orderId)
        {
            var result = _orderEngine.DeleteOrder(orderId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}