using ECommerceTopDown_GiorgioBestDown_API.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceTopDown_GiorgioBestDown_API.Controllers
{
    private readonly ProductsWorkerService _service;
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(ProductsWorkerService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.Get());
        }

        [HttpPost]
        public async Task<IActionResult> Post(PostProductRequest productRequest)
        {
            var productResponse = await _service.Post();
        }
    }
}
