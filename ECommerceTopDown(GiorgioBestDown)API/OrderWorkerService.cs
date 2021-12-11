using ECommerceTopDown_GiorgioBestDown_API.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerceTopDown_GiorgioBestDown_API
{
    public class OrderWorkerService : IOrdersWorkerService
    {
        private readonly ERPDbContext _context;
        public OrderWorkerService(ERPDbContext context)
        {
            _context = _context;
        }

        public Task<List<GetOrdersResponse>> Get()
        {
            return _context.ToListAsync();
        }

        public Task Post()
        {
            throw new System.NotImplementedException();
        }
    }
}
