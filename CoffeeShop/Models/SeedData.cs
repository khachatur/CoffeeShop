using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using System;
using CoffeeShop.Data;

namespace CoffeeShop.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IServiceProvider services)
        {
            ApplicationDbContext context = services.GetRequiredService<ApplicationDbContext>();
            //context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Latino Cafe",
                        Description = "Vietnam and Indonesian robusta coffee",
                        Category = "Packed",
                        Price = 0.74m
                    },
                    new Product
                    {
                        Name = "Le Cafe de Paris N1",
                        Description = "100% robusta.",
                        Category = "Packed",
                        Price = 0.87m
                    },
                    new Product
                    {
                        Name = "Nescafe Classic",
                        Description = "Start your day with Nescafe Classic bracing odour. This is a coffee with fine, strong, rich taste and delightful aroma.",
                        Category = "Instant coffee",
                        Price = 2.66m
                    },
                    new Product
                    {
                        Name = "Tchibo Exclusive",
                        Description = "Coffee, instant, sublimated.",
                        Category = "Instant coffee",
                        Price = 3.19m
                    },
                    new Product
                    {
                        Name = "Jacobs Monarch",
                        Description = "Instant coffee.",
                        Category = "Instant coffee",
                        Price = 3.24m
                    },
                    new Product
                    {
                        Name = "Carte Noire",
                        Description = " Instant coffee, 3 in 1, extra arabica",
                        Category = "3 in one",
                        Price = 0.21m
                    },
                    new Product
                    {
                        Name = "Nescafe Classic",
                        Description = "Start your day with Nescafe Classic bracing odour. This is a coffee with fine, strong, rich taste and delightful aroma.",
                        Category = "3 in one",
                        Price = 0.12m
                    },
                    new Product
                    {
                        Name = "Jacobs 3 in 1",
                        Description = "Instant coffee, original",
                        Category = "3 in one",
                        Price = 0.14m
                    },
                    new Product
                    {
                        Name = "Mac Coffee",
                        Description = " Instant coffee with Caramel flavour, 3 in one.",
                        Category = "3 in one",
                        Price = 0.14m
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
