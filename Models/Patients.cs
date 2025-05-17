namespace adminnn.Models
{
    public class Patient
    {
        public int PatientId { get; set; }

        // Store names separately for better DB design
        public string FirstName { get; set; } = "";
        public string Surname { get; set; } = "";

        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; } = "";

        // Make Password nullable to handle NULL values in DB
        public string? Password { get; set; }

        public string Gender { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public string MedicalHistory { get; set; } = "";

        // Computed property for UI convenience (not stored in DB)
        public string FullName => $"{FirstName} {Surname}";

        // Calculate age from DateOfBirth
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - DateOfBirth.Year;
                if (DateOfBirth.Date > today.AddYears(-age)) age--;
                return age;
            }
        }

        public Patient Clone() => (Patient)this.MemberwiseClone();
    }
}
