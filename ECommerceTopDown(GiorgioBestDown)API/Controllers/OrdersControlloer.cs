using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]InsertOrderRequest request)
        {

            var PostOrderResponse =  _service.Post(request);
            return await CreatedAtAction(
                nameof(GetOne),
                new { Id = request.Id },
                request);
        }
    }

    private object GetOne()
    {
        throw new NotImplementedException();
    }
}
