namespace MeetingMinutes.Domain
{
    public class Project : BaseEntity
    {
        // Properties
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        // Foreign key to Department
        public int DepartmentId { get; set; }

        // Navigation property for the related department
        public Department Department { get; set; } = null!;

        // Navigation property for related employees (many-to-many relationship)
        public ICollection<ProjectAssignment> ProjectAssignments { get; set; } = new List<ProjectAssignment>();

    }
}
