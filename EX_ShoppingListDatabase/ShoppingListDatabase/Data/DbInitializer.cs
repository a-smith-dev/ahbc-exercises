using ShoppingListDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingListDatabase.Data
{
    public class DbInitializer
    {
        public static void Initialize(CartContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Products.Any())
            {
                context.Products.Add(new Product() { Name = "Earbuds", Price = 19.99 });
                context.Products.Add(new Product() { Name = "Headphones", Price = 99.99 });
                context.Products.Add(new Product() { Name = "VR Headset", Price = 299.99 });
                context.Products.Add(new Product() { Name = "VR Controller (Left)", Price = 39.99 });
                context.Products.Add(new Product() { Name = "VR Controller (Right)", Price = 39.99 });
                context.Products.Add(new Product() { Name = "HD Projector", Price = 249.99 });
                context.Products.Add(new Product() { Name = "Game Console", Price = 399.99 });
                context.Products.Add(new Product() { Name = "Game Controller", Price = 49.99 });
                context.Products.Add(new Product() { Name = "HDMI Cable (6ft)", Price = 6.49 });
                context.Products.Add(new Product() { Name = "Game Console v2", Price = 499.99 });
                context.Products.Add(new Product() { Name = "Game Controller v2", Price = 59.99 });
                context.SaveChanges();
            }
        }
    }
}
