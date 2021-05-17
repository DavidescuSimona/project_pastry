using Microsoft.EntityFrameworkCore;
using PASTRY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PASTRY.Data
{
    public class MvcDrinkContext : DbContext
    {
        public MvcDrinkContext(DbContextOptions<MvcDrinkContext> options)
            : base(options)
        {
        }

        public DbSet<Drink> Drink { get; set; }
    }
}
