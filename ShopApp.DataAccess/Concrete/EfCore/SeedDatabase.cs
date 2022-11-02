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
                    context.AddRange(ProductCategory);
               }
                context.SaveChanges();
           }
        }

        private static Category[] Categories = {

           new Category(){Name = "Telefon" },
           new Category(){Name = "Bilgisayar" },
           new Category(){Name = "Elektronik" }
        };

        private static Product[] Products =
        {
            new Product(){Name = "S5", Price = 5000, ImageUrl = "1.png",Description = "<p>Samsung S5 - 3 renk olarak satın alabilirsiniz</p>"},
            new Product(){Name = "S6", Price = 6000, ImageUrl = "2.png",Description = "<p>Samsung S6 - 3 renk olarak satın alabilirsiniz</p>"},
            new Product(){Name = "S7", Price = 7000, ImageUrl = "3.png",Description = "<p>Samsung S7 - 3 renk olarak satın alabilirsiniz</p>"},
            new Product(){Name = "S8", Price = 8000, ImageUrl = "4.png",Description = "<p>Samsung S8 - 3 renk olarak satın alabilirsiniz</p>"},
            new Product(){Name = "S9", Price = 9000, ImageUrl = "5.png",Description = "<p>Samsung S9 - 3 renk olarak satın alabilirsiniz</p>"},
            new Product(){Name = "Iphone 7", Price = 10000, ImageUrl = "6.png",Description = "<p>Iphone 7 - 3 renk olarak satın alabilirsiniz</p>"},
            new Product(){Name = "Iphone 8", Price = 11000, ImageUrl = "7.png",Description = "<p>Iphone 8 - 3 renk olarak satın alabilirsiniz</p>"}
        };

        private static ProductCategory[] ProductCategory =
        {
            new ProductCategory() {Product = Products[0], Category = Categories[0]},
            new ProductCategory() {Product = Products[0], Category = Categories[2]},
            new ProductCategory() {Product = Products[1], Category = Categories[0]},
            new ProductCategory() {Product = Products[1], Category = Categories[1]},
            new ProductCategory() {Product = Products[2], Category = Categories[0]},
            new ProductCategory() {Product = Products[2], Category = Categories[2]},
            new ProductCategory() {Product = Products[3], Category = Categories[1]}
        };
    }
}

