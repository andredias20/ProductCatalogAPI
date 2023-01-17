using Microsoft.EntityFrameworkCore;
using ProductCatalogAPI.Entities;

namespace ProductCatalogAPI.Database { 
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options){}
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDepartment> ProductDepartments { get; set; }

    }
}
