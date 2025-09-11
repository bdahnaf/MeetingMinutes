namespace MeetingMinutes.Domain
{
    /// <summary>
    /// Represents a template or type of recurring meeting (e.g., "Weekly Standup").
    /// </summary>
    public class MeetingSeries : BaseEntity
    {
        // Properties
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Relationships
        // Foreign Key for Department
        public int DepartmentId { get; set; }
        // Navigation property for the Department that owns this meeting series
        public Department Department { get; set; } = null!;

        // A MeetingSeries can have many actual Meeting instances
        public ICollection<Meeting> Meetings { get; set; } = new List<Meeting>();
    }
}
