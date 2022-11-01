using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;

namespace ShopApp.DataAccess.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }
                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                }
                context.SaveChanges();
            }
        }

        private static Category[] Categories = {

           new Category(){Name = "Telefon" },
           new Category(){Name = "Bilgisayar" }
        };

        private static Product[] Products =
        {
            new Product(){Name = "S5", Price = 5000, ImageUrl = "1.jpg"},
            new Product(){Name = "S6", Price = 6000, ImageUrl = "2.jpg"},
            new Product(){Name = "S7", Price = 7000, ImageUrl = "3.jpg"},
            new Product(){Name = "S8", Price = 8000, ImageUrl = "4.jpg"},
            new Product(){Name = "S9", Price = 9000, ImageUrl = "5.jpg"},
            new Product(){Name = "Iphone 7", Price = 10000, ImageUrl = "6.jpg"},
            new Product(){Name = "Iphone 8", Price = 11000, ImageUrl = "7.jpg"}
        };
    }
}

