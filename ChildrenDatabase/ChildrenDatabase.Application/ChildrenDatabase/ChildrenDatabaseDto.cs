using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildrenDatabase.Application.ChildrenDatabase
{
    public class ChildrenDatabaseDto
    {
        [Required]
        [StringLength (20, MinimumLength =2)]
        public string? Name { get; set; }
        [StringLength(40, MinimumLength = 2)]
        public string? Surname { get; set; } 
        public string? Age { get; set; }
        public string? HealthInfo { get; set; }
        public string? Address { get; set; }
        [StringLength(12, MinimumLength = 9)]
        public string? ParentPhoneNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
