namespace MeetingMinutes.Domain
{
    /// <summary>
    /// Represents a single item of discussion within a meeting, such as an update or an action item.
    /// </summary>
    public class MeetingItem
    {
        // Properties
        public ItemType ItemType { get; set; }
        public string Description { get; set; } = string.Empty;
        public ItemStatus Status { get; set; } = ItemStatus.Open;
        public DateTime? DueDate { get; set; }

        // Relationships
        // The meeting this item belongs to
        public int MeetingId { get; set; }
        public Meeting Meeting { get; set; } = null!;

        // This is the link for the "chaining" feature
        public int? ParentMeetingItemId { get; set; }
        public MeetingItem? ParentMeetingItem { get; set; }

        // Navigation property for chained child items
        public ICollection<MeetingItem> ChildMeetingItems { get; set; } = new List<MeetingItem>();

        // The employees assigned to this item
        public ICollection<MeetingItemAssignee> MeetingItemAssignees { get; set; } = new List<MeetingItemAssignee>();
    }
}
