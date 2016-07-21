using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD2015.Models
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public decimal Price { get; set; }
    }

    public class ProductStore : List<Products>
    {
        public ProductStore()
        {
            Add(new Products() { ProductId = 1, ProductName = "P1", Price = 3000 });
            Add(new Products() { ProductId = 2, ProductName = "P2", Price = 3100 });
            Add(new Products() { ProductId = 3, ProductName = "P3", Price = 3400 });
            Add(new Products() { ProductId = 4, ProductName = "P4", Price = 3700 });
            Add(new Products() { ProductId = 5, ProductName = "P5", Price = 4000 });
            Add(new Products() { ProductId = 6, ProductName = "P6", Price = 3200 });
        }
    }
}
