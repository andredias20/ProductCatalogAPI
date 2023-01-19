using Microsoft.EntityFrameworkCore;
using ProductCatalogAPI.Entities;

namespace ProductCatalogAPI.Database.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDepartment> ProductDepartments { get; set; }

    }
}
