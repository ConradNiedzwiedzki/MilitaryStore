﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MilitaryStore.Models
{
    public class FakeProductRepository /* : IProductRepository */
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product { Name = "Green T-shirt", Price = 25 },
            new Product { Name = "Scope", Price = 179 },
            new Product { Name = "Heavy shoes", Price = 95 }
        };
    }
}