using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerceTopDown_GiorgioBestDown_API.Controllers
{
    public interface IOrdersWorkerService
    {
        public Task<List<GetOrdersResponse>>Get();
        public Task Post();
    }
}
