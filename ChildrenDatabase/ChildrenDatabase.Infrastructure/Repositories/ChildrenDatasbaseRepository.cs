using ChildrenDatabase.Domain.Interfaces;
using ChildrenDatabase.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ChildrenDatabase.Infrastructure.Repositories
{
    internal class ChildrenDatasbaseRepository : IChildrenDatabaseRepository
    {
        private readonly ChildrenDatabaseDbContext _dbContext;

        public ChildrenDatasbaseRepository(ChildrenDatabaseDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Create(Domain.Entities.ChildrenDatabase childrenDatabase)
        {
           _dbContext.Add(childrenDatabase);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Domain.Entities.ChildrenDatabase>> GetAll()
        => await _dbContext.ChildrenDatabases.ToListAsync();
          

    
    }
}
