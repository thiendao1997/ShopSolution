using Microsoft.EntityFrameworkCore;
using ShopSolution.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.EF
{
    public class ShopSolutionDbContext : DbContext
    {
        public ShopSolutionDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { set; get; }
        public DbSet<Catagory> Catagories { set; get; }
    }
}
