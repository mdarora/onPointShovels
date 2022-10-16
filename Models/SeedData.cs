using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnPointShovels.Data;
using System;
using System.Linq;

namespace OnPointShovels.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new OnPointShovelsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<OnPointShovelsContext>>()))
            {

                if (context.Shovel.Any())
                {
                    return;
                }

                context.Shovel.AddRange(
                    new Shovel
                    {
                        Title = "Snow king shovel",
                        Type = "Square Top",
                        Color = "Dark gray",
                        Weight = 3,
                        Height = 40,
                        Price = 34.99M,
                    },
                    new Shovel
                    {
                        Title = "RedCamp strong shovel",
                        Type = "Round point Top",
                        Color = "light green",
                        Weight = 2,
                        Height = 42,
                        Price = 22.99M,
                    },
                    new Shovel
                    {
                        Title = "Detachable snow shovel",
                        Type = "Square point Top",
                        Color = "Black & Blue",
                        Weight = 4,
                        Height = 50,
                        Price = 24.99M,
                    },
                    new Shovel
                    {
                        Title = "Poly Blade car shovel",
                        Type = "Square small Top",
                        Color = "Blue",
                        Weight = 4,
                        Height = 29,
                        Price = 23.49M,
                    },
                    new Shovel
                    {
                        Title = "Aluminium Alloy Snow shovel",
                        Type = "Square Top",
                        Color = "Black",
                        Weight = 4,
                        Height = 53,
                        Price = 29.99M,
                    },
                    new Shovel
                    {
                        Title = "Ergonomic pusher Snow shovel",
                        Type = "Square wide",
                        Color = "Fine Blue",
                        Weight = 2,
                        Height = 26,
                        Price = 56.89M,
                    },
                    new Shovel
                    {
                        Title = "Collapsible 3in1 shovel",
                        Type = "Round Point",
                        Color = "Red",
                        Weight = 2,
                        Height = 27,
                        Price = 27.99M,
                    },
                    new Shovel
                    {
                        Title = "Mini handle shovel",
                        Type = "Round sharp Top",
                        Color = "Silver",
                        Weight = 2,
                        Height = 22,
                        Price = 19.99M,
                    },
                    new Shovel
                    {
                        Title = "Survival shovel Axe",
                        Type = "Round Top Sharp Edge",
                        Color = "Shiny Silver",
                        Weight = 4,
                        Height = 34,
                        Price = 49.98M,
                    },
                    new Shovel
                    {
                        Title = "Camping Shovel",
                        Type = "Sharp Point",
                        Color = "Matt silver",
                        Weight = 2,
                        Height = 21,
                        Price = 51.99M,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}