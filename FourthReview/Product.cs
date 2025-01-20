using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdReview
{
    internal class Product
    {
        public int PId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public List<Product> getProducts()
        {
            List<Product> products = new List<Product>()
            {
                new Product { PId = 1, Name = "Laptop", Category = "Elec", Price = 40, Quantity = 19 },
                new Product { PId = 2, Name = "Shirt", Category = "Clothing", Price = 5, Quantity = 30 },
                new Product { PId = 3, Name = "Mouse", Category = "Elec", Price = 10, Quantity = 9 },
                new Product { PId = 4, Name = "Table", Category = "Furniture", Price = 15, Quantity = 40 },
                new Product { PId = 5, Name = "Mobile", Category = "Elec", Price = 20, Quantity = 50 }
            };
            return products;
        }
    }
}
