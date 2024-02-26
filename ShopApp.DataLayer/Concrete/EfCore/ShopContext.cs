using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.DataLayer.Concrete.EfCore
{
    public class ShopContext:DbContext
    {
        public DbSet<Product> Products{ get; set; }
        public DbSet<Category>Categories{ get; set; }
        //public DbSet<Product> Products{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=HALIL;Initial Catalog=ShopDB;Integrated Security=True;MultipleActiveResultsets=True;TrustServerCertificate=True;");

            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasKey(c => new { c.CategoryId, c.ProductId });
            //base.OnModelCreating(modelBuilder);
        }
    }
}
