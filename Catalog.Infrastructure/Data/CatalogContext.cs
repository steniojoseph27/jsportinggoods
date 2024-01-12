using Catalog.Core.Entities;
using Catalog.Core.Interfaces;
using Catalog.Infrastructure.Data.Config;
using Microsoft.EntityFrameworkCore;


namespace Catalog.Infrastructure.Data;

public class CatalogContext : DbContext, ICatalogContext
{
    public CatalogContext(DbContextOptions<CatalogContext> options) : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductBrand> ProductBrands { get; set; }
    public DbSet<ProductType> ProductTypes { get; set; }

    public async Task<int> SaveChangesAsync() => await base.SaveChangesAsync();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        modelBuilder.ApplyConfiguration(new ProductBrandConfiguration());
        modelBuilder.ApplyConfiguration(new ProductTypeConfiguration());
    }
}