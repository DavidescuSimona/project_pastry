using Microsoft.EntityFrameworkCore;
using PASTRY.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PASTRY.Data
{
    public class MvcCakeContext : DbContext
    {
        public MvcCakeContext(DbContextOptions<MvcCakeContext> options)
            : base(options)
        {
        }

        public DbSet<Cake> Cake { get; set; }
    }
}
