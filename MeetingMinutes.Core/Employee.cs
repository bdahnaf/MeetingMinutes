namespace MeetingMinutes.Domain
{
    public class Employee : BaseEntity
    {
        // Properties
        public string? EmployeeId { get; set; } = string.Empty; // Unique Employee Id given from HR

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        // Foreign key to Department
        public int? DepartmentId { get; set; }

        // Navigation property for the related department
        public Department Department { get; set; }

        // Navigation property for related user accounts
        public User User { get; set; }

        // Navigation property for related projects (many-to-many relationship)
        public ICollection<ProjectAssignment> ProjectAssignments { get; set; } = new List<ProjectAssignment>();
    }
}
