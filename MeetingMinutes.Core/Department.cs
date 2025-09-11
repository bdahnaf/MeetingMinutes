namespace MeetingMinutes.Domain
{
    public class Department : BaseEntity
    {
        // Properties
        public string Name { get; set; } = string.Empty;
        public string ShortCode { get; set; } = string.Empty;

        // Navigation property for related projects
        public ICollection<Project> Projects { get; set; } = new List<Project>();

        // Navigation property for related employees
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
