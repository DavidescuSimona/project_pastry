using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PASTRY.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PASTRY.Models
{
    public class SeedDrinks
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcDrinkContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcDrinkContext>>()))
            {
                if (context.Drink.Any())
                {
                    return;   
                }

                context.Drink.AddRange(
                    new Drink
                    {
                        IdImage = 1,
                        Name = "Cappuccino",
                        Price = 7.00M,
                        ImageDrink = "~/images/Drink.png",
                    },
                    new Drink
                    {
                        IdImage = 2,
                        Name = "Hot Chocolate",
                        Price = 9.99M,
                        ImageDrink = "~/images/Drink.png",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
