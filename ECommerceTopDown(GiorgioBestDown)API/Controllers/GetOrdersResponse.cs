using System.Collections.Generic;

namespace ECommerceTopDown_GiorgioBestDown_API.Controllers
{
    public class GetOrdersResponse
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public User User { get; set; }
        public List<Product> Prdocuts { get; set; }
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }

    }
}
