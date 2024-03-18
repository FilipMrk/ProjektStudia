using ChildrenDatabase.Domain.Interfaces;
using ChildrenDatabase.Infrastructure.Persistence;
using ChildrenDatabase.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildrenDatabase.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ChildrenDatabaseDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("ChildrenDatabase")));

            services.AddScoped<IChildrenDatabaseRepository, ChildrenDatasbaseRepository>();
        }
    }
}
