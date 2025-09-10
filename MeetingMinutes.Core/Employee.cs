using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingMinutes.Core
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string EmployeeId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // Foreign key to Department
        public int? DepartmentId { get; set; }

        // Navigation property for the related department
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        // Navigation property for related user accounts
        public User User { get; set; }

        // Navigation property for related projects (many-to-many relationship)
        public ICollection<Project> Projects { get; set; } = new List<Project>();

    }
}
