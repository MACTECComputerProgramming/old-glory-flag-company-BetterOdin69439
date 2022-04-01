#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Old_Glory.Models;

namespace Old_Glory.Data
{
    public class Old_GloryContext : DbContext
    {
        public Old_GloryContext (DbContextOptions<Old_GloryContext> options)
            : base(options)
        {
        }

        public DbSet<Old_Glory.Models.Customer> Customer { get; set; }

        public DbSet<Old_Glory.Models.Order> Order { get; set; }

        public DbSet<Old_Glory.Models.Product> Product { get; set; }
    }
}
