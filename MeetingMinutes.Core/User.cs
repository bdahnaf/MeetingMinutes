using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetingMinutes.Domain
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLogin { get; set; }

        // Foreign key to Employee
        public int EmployeeId { get; set; }
        // Navigation property for the related employee
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; } = null!;
    }
}
