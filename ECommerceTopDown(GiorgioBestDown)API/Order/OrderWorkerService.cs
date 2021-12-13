using ECommerceTopDown_GiorgioBestDown_API.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerceTopDown_GiorgioBestDown_API
{
    public class OrderWorkerService : IOrdersWorkerService
    {
        private readonly ECommerceDbContext _context;
        public OrderWorkerService(ECommerceDbContext context)
        {
            _context = context;
        }

        public Task<List<GetOrdersResponse>> Get()
        {
            return _context.ToListAsync();
        }

        public async Task<InsertOrderResponse> Post(InsertOrderRequest request)
        {
            var order = await ToOrderAsync(request);
        }

        private Task<Order> ToOrderAsync(InsertOrderRequest request) =>
            new Order()
            {
                Status = request.Status,
                BillingAddress = request.BillingAddress,
                UserId = request.UserId,
                ShippingAddress = request.ShippingAddress,
                Prdocuts = _context.??;
                
            };
    }
}

