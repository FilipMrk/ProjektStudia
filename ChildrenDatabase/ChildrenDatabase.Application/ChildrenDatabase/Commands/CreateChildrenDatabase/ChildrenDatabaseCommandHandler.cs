using AutoMapper;
using ChildrenDatabase.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildrenDatabase.Application.ChildrenDatabase.Commands.CreateChildrenDatabase
{
    public class ChildrenDatabaseCommandHandler : IRequestHandler<CreateChildrenDatabaseCommand>
    {
        private readonly IChildrenDatabaseRepository _childrenDatabaseRepository;
        private readonly IMapper _mapper;

        public ChildrenDatabaseCommandHandler(IChildrenDatabaseRepository childrenDatabaseRepository, IMapper mapper) 
        {
            _childrenDatabaseRepository = childrenDatabaseRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(CreateChildrenDatabaseCommand request, CancellationToken cancellationToken)
        {
            var childrenDatabase = _mapper.Map<Domain.Entities.ChildrenDatabase>(request);

            await _childrenDatabaseRepository.Create(childrenDatabase);

            return Unit.Value;
        }
    }
}
