namespace MeetingMinutes.Domain
{
    /// <summary>
    /// Represents a single, specific meeting instance.
    /// </summary>
    public class Meeting : BaseEntity
    {
        // Properties
        public string Title { get; set; } = string.Empty;
        public DateTime MeetingDateTime { get; set; }

        // Relationships
        // Foreign Key for MeetingSeries. It's nullable because a meeting can be a one-off event.
        public int? MeetingSeriesId { get; set; }

        // Navigation property for the series this meeting might belong to
        public MeetingSeries? MeetingSeries { get; set; }

        // A meeting can discuss multiple projects
        public ICollection<MeetingProject> MeetingProjects { get; set; } = new List<MeetingProject>();

        // A meeting has multiple attendees
        public ICollection<MeetingAttendee> MeetingAttendees { get; set; } = new List<MeetingAttendee>();

        // A meeting contains multiple agenda items or minutes
        public ICollection<MeetingItem> MeetingItems { get; set; } = new List<MeetingItem>();
    }
}
