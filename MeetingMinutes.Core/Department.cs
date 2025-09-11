using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingMinutes.Domain
{
    public class Department
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(10)]
        public string Code { get; set; }

        // Navigation property for related projects
        public ICollection<Project> Projects { get; set; } = new List<Project>();

        // Navigation property for related employees
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
