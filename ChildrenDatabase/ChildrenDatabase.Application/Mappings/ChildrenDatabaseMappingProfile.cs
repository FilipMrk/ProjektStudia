using AutoMapper;
using ChildrenDatabase.Application.ChildrenDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildrenDatabase.Application.Mappings
{
    public class ChildrenDatabaseMappingProfile : Profile
    {
        public ChildrenDatabaseMappingProfile() 
        {
            CreateMap<ChildrenDatabaseDto, Domain.Entities.ChildrenDatabase>();

            CreateMap<Domain.Entities.ChildrenDatabase, ChildrenDatabaseDto>();
           

        }
    }
}
