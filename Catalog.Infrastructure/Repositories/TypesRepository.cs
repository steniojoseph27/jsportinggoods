using Catalog.Core.Entities;
using Catalog.Core.Repositories;
using Catalog.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Infrastructure.Repositories
{
    public class TypesRepository : ITypesRepository
    {
        private readonly ICatalogContext _context;

        public TypesRepository(ICatalogContext context)
        {
            _context = context;
        }
    
        public async Task<IEnumerable<ProductType>> GetTypesAsync()
        {
            return await _context.ProductTypes.ToListAsync();
        }
    }
}
