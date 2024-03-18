using AutoMapper;
using ChildrenDatabase.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildrenDatabase.Application.ChildrenDatabase.Queries.GetAllChildrenDatabases
{
    internal class GetAllChildrenDatabasesQueryHandler : IRequestHandler<GetAllChildrenDatabasesQuery, IEnumerable<ChildrenDatabaseDto>>
    {
        private readonly IChildrenDatabaseRepository _childrenDatabaseRepository;
        private readonly IMapper _mapper;

        public GetAllChildrenDatabasesQueryHandler(IChildrenDatabaseRepository childrenDatabaseRepository, IMapper mapper)
        {
           _childrenDatabaseRepository = childrenDatabaseRepository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ChildrenDatabaseDto>> Handle(GetAllChildrenDatabasesQuery request, CancellationToken cancellationToken)
        {
            var childrenDatabases = await _childrenDatabaseRepository.GetAll();
            var dtos = _mapper.Map<IEnumerable<ChildrenDatabaseDto>>(childrenDatabases);

            return dtos;
        }
    }
}
    