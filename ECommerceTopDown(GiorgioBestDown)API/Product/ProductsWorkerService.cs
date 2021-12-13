using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceTopDown_GiorgioBestDown_API.Product
{
    public class ProductsWorkerService
    {
        private readonly ECommerceDbContext _context;
        public ProductsWorkerService(ECommerceDbContext context)
        {
            _context = context;
        }

        public async Task<GetAllProductsResponse> Get()
        {
            return _context.Products.ToListAsync();
        }
    }
}
