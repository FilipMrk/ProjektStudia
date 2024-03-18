using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildrenDatabase.Domain.Interfaces
{
    public  interface IChildrenDatabaseRepository
    {
        Task Create (Domain.Entities.ChildrenDatabase childrenDatabase);
       
        Task<IEnumerable<Domain.Entities.ChildrenDatabase>> GetAll ();
    }
}
