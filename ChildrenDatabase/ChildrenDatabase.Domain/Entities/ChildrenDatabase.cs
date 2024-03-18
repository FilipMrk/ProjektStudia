using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildrenDatabase.Domain.Entities
{
    public class ChildrenDatabase
    {
        public required int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Surname { get; set; } = default!;
        public int? Age { get; set; }
        public string? HealthInfo { get; set; }
        public string? Address { get; set; }
        public string? ParentPhoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
