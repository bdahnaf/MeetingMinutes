namespace MeetingMinutes.Domain
{
    // This is the junction entity for the many-to-many relationship
    // between Project and Employee.
    public class ProjectAssignment
    {
        // Foreign Key for Project
        public int ProjectId { get; set; }
        // Foreign Key for Employee
        public int EmployeeId { get; set; }

        public Project Project { get; set; } = null!;
        public Employee Employee { get; set; } = null!;
    }
}
