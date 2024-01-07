using Catalog.Core.Entities;
using Catalog.Core.Repositories;
using Catalog.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly CatalogContext _context;

        public BrandRepository(CatalogContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductBrand>> GetBrandsAsync()
        {
            return await _context.ProductBrands.ToListAsync();
        }
    }
}
