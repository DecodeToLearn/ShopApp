﻿using System;
using System.Collections.Generic;

namespace ShopApp.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}

