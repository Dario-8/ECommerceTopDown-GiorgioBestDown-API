using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceTopDown_GiorgioBestDown_.DAL
{
    public class Order
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public User User { get; set; }  
        public string BillingAddress { get; set; }
        public string ShippingAddress { get; set; }
        public List<Product> Products { get; set; }
    }
}
