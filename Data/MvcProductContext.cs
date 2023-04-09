using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using shopping_cart_.Models;

namespace shopping_cart_.Data
{
    public class MvcProductContext : DbContext
    {
        public MvcProductContext (DbContextOptions<MvcProductContext> options)
            : base(options)
        {
        }
        public DbSet<shopping_cart_.Models.Product> Product { get; set; } = default!;
    }
}
