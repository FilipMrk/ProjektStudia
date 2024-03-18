using ChildrenDatabase.Application.ChildrenDatabase.Commands.CreateChildrenDatabase;
using ChildrenDatabase.Application.Mappings;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChildrenDatabase.Application.ChildrenDatabase.Commands.CreateChildrenDatabase;

namespace ChildrenDatabase.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplication(this IServiceCollection services) 
        {
         services.AddMediatR(typeof(CreateChildrenDatabaseCommand));

         services.AddAutoMapper(typeof(ChildrenDatabaseMappingProfile));
        }
    }
}
