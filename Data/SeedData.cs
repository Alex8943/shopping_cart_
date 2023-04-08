using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using shopping_cart_.Data;
using System;
using System.Linq;

namespace shopping_cart_.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcProductContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcProductContext>>()))
        {
            // Look for any products.
            if (context.Product.Any())
            {
                return;   // DB has been seeded
            }
        
            context.Product.AddRange(
                new Product
                {
                    Name = "Eagle Tower Shiraz",
                    Origin = DateTime.Parse("1989-2-12"),
                    Description = "Australian Wine",
                    Price = 7.99M
                }, 
                new Product
                {
                    Name = "The Full Dozen Cabernet Sauvignon",
                    Origin = DateTime.Parse("1984-3-13"),
                    Description = "California Wine",
                    Price = 8.99M
                },
                new Product
                {
                    Name = "Yellow Tail Shiraz",
                    Origin = DateTime.Parse("1986-2-23"),
                    Description = "Australian Wine",
                    Price = 9.99M
                },
                new Product
                {
                    Name = "Yellow Tail Merlot",
                    Origin = DateTime.Parse("1985-1-11"),
                    Description = "Australian Wine",
                    Price = 9.99M
                }
            );
            context.SaveChanges();
        }
    }
}