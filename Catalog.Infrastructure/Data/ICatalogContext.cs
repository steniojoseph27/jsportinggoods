using Catalog.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infrastructure.Data
{
    public interface ICatalogContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<ProductBrand> ProductBrands { get; set; }
        DbSet<ProductType> ProductTypes { get; set; }

        Task<int> SaveChangesAsync();
    }
}
