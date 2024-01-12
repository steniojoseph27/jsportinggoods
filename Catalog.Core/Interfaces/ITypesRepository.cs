using Catalog.Core.Entities;
using Catalog.Core.Specs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Core.Repositories
{
    public interface ITypesRepository
    {
        Task<IEnumerable<ProductType>> GetTypesAsync();
    }
}
