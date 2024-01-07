using Catalog.Core.Entities;
using Catalog.Infrastructure.Data.Config;
using Microsoft.EntityFrameworkCore;


namespace Catalog.Infrastructure.Data;

public class CatalogContext : DbContext
{
    public CatalogContext(DbContextOptions<CatalogContext> options)
    {
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<ProductBrand> ProductBrands { get; set; }
    public DbSet<ProductType> ProductTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new ProductBrandConfiguration());
        modelBuilder.ApplyConfiguration(new ProductTypeConfiguration());
    }
}