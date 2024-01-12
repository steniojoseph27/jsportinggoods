using Catalog.Core.Interfaces;
using Catalog.Core.Repositories;
using Catalog.Infrastructure.Data;
using Catalog.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Infrastructure.Extensions
{
    public static class InfraServices
    {
        public static IServiceCollection AddInfraServices(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<CatalogContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("CatalogConnection")));
            serviceCollection.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            serviceCollection.AddScoped<IProductRepository, ProductRepository>();
            return serviceCollection; 
        }
    }
}
