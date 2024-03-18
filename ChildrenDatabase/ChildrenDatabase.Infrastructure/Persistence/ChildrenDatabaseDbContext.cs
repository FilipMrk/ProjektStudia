using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildrenDatabase.Infrastructure.Persistence
{
    public class ChildrenDatabaseDbContext : DbContext
    {
        public ChildrenDatabaseDbContext(DbContextOptions<ChildrenDatabaseDbContext> options) : base(options)
        {

        }

        public DbSet<Domain.Entities.ChildrenDatabase> ChildrenDatabases { get; set; }


    }
}
