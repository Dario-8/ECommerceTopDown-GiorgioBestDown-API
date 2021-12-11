using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ECommerceTopDown_GiorgioBestDown_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersControlloer : ControllerBase
    {
        private readonly IOrdersWorkerService _service;

        public OrdersControlloer(IOrdersWorkerService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var order = await _service.Get();
            return Ok(order);
        }
    }
}
