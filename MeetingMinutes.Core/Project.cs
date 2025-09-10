using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingMinutes.Domain
{
    public class Project
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        // Foreign key to Department
        public int DepartmentId { get; set; }

        // Navigation property for the related department
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        // Navigation property for related employees (many-to-many relationship)
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
