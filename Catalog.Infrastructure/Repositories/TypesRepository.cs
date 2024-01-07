using Catalog.Core.Entities;
using Catalog.Core.Repositories;
using Catalog.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infrastructure.Repositories
{
    public class TypesRepository : ITypesRepository
    {
        private readonly CatalogContext _context;

        public TypesRepository(CatalogContext context)
        {
            _context = context;
        }
    
        public async Task<IEnumerable<ProductType>> GetTypesAsync()
        {
            return await _context.ProductTypes.ToListAsync();
        }
    }
}
