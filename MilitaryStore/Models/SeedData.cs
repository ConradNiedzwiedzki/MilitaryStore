using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace MilitaryStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Knife",
                        Description = "A sharp knife that cuts everything",
                        Category = "Survival",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Reflective Vest",
                        Description = "Reflecting vest that protects you from being accidentally shot",
                        Category = "Hunting",
                        Price = 48.95m
                    },
                    new Product
                    {
                        Name = "Flashlight",
                        Description = "Flashlight with batteries",
                        Category = "Survival",
                        Price = 19.50m
                    },
                    new Product
                    {
                        Name = "Green Hat",
                        Description = "A warm, green hat",
                        Category = "Hunting",
                        Price = 34.95m
                    },
                    new Product
                    {
                        Name = "Helmet",
                        Description = "A kevlar helmet",
                        Category = "Army",
                        Price = 350
                    },
                    new Product
                    {
                        Name = "Bulletproof Vest",
                        Description = "A kevlar vest which can protect you from bullets",
                        Category = "Army",
                        Price = 1000
                    },
                    new Product
                    {
                        Name = "Hip-flask",
                        Description = "Perfect gift for a hunter",
                        Category = "Gifts",
                        Price = 29.95m
                    },
                    new Product
                    {
                        Name = "Glasses with animal drawings",
                        Description = "Nice glasses for hunter",
                        Category = "Gifts",
                        Price = 75
                    },
                    new Product
                    {
                        Name = "Tent",
                        Description = "Big, durable tent for 4 people",
                        Category = "Survival",
                        Price = 800
                    }
                );
                context.SaveChanges();
            }
        }
    }
}