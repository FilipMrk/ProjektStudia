using MediatR;

namespace ChildrenDatabase.Application.ChildrenDatabase.Queries.GetAllChildrenDatabases
{
    public class GetAllChildrenDatabasesQuery : IRequest<IEnumerable<ChildrenDatabaseDto>>
    {
    }
}
