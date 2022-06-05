using Microsoft.EntityFrameworkCore;
using ProductMicroService.Model;
using System.Reflection.Emit;

namespace ProductMicroService.DBContexts
{
    public class ProductsContext : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

       /*
       protected override void onModelCreating(ModelBuilder modelbuilder)
        {
            ModuleBuilder.Entity<Product>().HasNoData()
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory
                {
                    ProductCategoryId = 1,
                    Name = "Electronics",
                    Description = "Electronic Items",
                    
                },
                new ProductCategory
                {
                    ProductCategoryId = 2,
                    Name = "Clothes",
                    Description = "Dresses",
                },
                new ProductCategory
                {
                    ProductCategoryId = 3,
                    Name = "Grocery",
                    Description = "Grocery Items",
                }
            );
        }

    }
}

    