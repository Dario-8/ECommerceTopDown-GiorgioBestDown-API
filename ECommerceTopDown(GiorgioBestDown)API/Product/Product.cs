using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceTopDown_GiorgioBestDown_API.Product
{
    
    public class Product
    {
        static private readonly int CONST = 5;
        public int Id { get; set; }
        public string Name { get; set; }
        public double InitialPrice { get; set; }
        public double ActualPrice
        {
            get => InitialPrice * CONST;
        }
        public string Producer { get; set; }
        public string Category { get; set; }
    }
}
