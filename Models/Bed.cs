namespace adminnn.Models
{
    public class Bed
    {
        public int BedId { get; set; }

        public string RoomNumber { get; set; } = "";
        public string BedNumber { get; set; } = "";
        public string Status { get; set; } = "";
        public int? PatientId { get; set; }

        // Navigation property for the associated Patient
        public Patient? Patient { get; set; }

        // Foreign key to the Department table
        public int? DepartmentId { get; set; }

        // Navigation property for the associated Department
        public Department? Department { get; set; }

        public bool IsOccupied => Status == "Occupied";
    }
}
