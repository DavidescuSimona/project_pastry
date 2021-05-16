using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PASTRY.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PASTRY.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCakeContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcCakeContext>>()))
            {
                // Look for any movies.
                if (context.Cake.Any())
                {
                    return;   // DB has been seeded
                }

                context.Cake.AddRange(
                    new Cake
                    {
                       IdImage=1,
                        Name = "Tiramisu",
                        Price = 7.99M,
                        Weight = 500,
                    },
                    new Cake
                    {
                        IdImage = 2,
                        Name = "Amandina",
                        Price = 9.99M,
                        Weight = 400,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
