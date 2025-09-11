namespace MeetingMinutes.Domain
{
    /// <summary>
    /// Junction entity linking a MeetingItem to an Employee it is assigned to.
    /// </summary>
    public class MeetingItemAssignee
    {
        // Properties
        public int MeetingItemId { get; set; }
        public int EmployeeId { get; set; }

        // Navigation properties
        public MeetingItem MeetingItem { get; set; } = null!;
        public Employee Employee { get; set; } = null!;
    }
}
