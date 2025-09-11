namespace MeetingMinutes.Domain
{
    public class MeetingAttendee
    {
        // Properties
        public int MeetingId { get; set; }
        public int EmployeeId { get; set; }

        //Navigation properties
        public Meeting Meeting { get; set; } = null!;
        public Employee Employee { get; set; } = null!;
    }
}
