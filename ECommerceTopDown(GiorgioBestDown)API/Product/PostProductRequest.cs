using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceTopDown_GiorgioBestDown_API.Product
{
    public class PostProductRequest
    {
        public string Name { get; set; }
        public double InitialPrice { get; set; }
        public string Producer { get; set; }
        public string Category { get; set; }
    }
}
