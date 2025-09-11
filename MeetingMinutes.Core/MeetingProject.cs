namespace MeetingMinutes.Domain
{
    /// <summary>
    /// Junction entity linking a Meeting to a Project that was discussed.
    /// </summary>
    public class MeetingProject
    {
        // Properties
        public int MeetingId { get; set; }
        public int ProjectId { get; set; }

        // Navigation properties
        public Meeting Meeting { get; set; } = null!;
        public Project Project { get; set; } = null!;

    }
}
