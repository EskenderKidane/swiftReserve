namespace adminnn.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UsernameOrEmail { get; set; }
        public string Specialization { get; set; }
        public string Contact { get; set; }
        public string Status { get; set; }
        public string Password { get; set; }
        public DayOfWeek? DayOff { get; set; }  // Nullable in case no day off is set

        // Add this new property:
        public string ShiftTime { get; set; }  // Example: "09:00-17:00"
    }

}
