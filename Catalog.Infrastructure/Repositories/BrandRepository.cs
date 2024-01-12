using Catalog.Core.Entities;
using Catalog.Core.Interfaces;
using Catalog.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly ICatalogContext _context;

        public BrandRepository(ICatalogContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductBrand>> GetBrandsAsync()
        {
            return await _context.ProductBrands.ToListAsync();
        }
    }
}
