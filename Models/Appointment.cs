namespace adminnn.Models
{
	public class Appointment
	{
		public int Id { get; set; }

		// Nullable foreign keys to allow optional relationships if needed
		public int? PatientId { get; set; }
		public int? DoctorId { get; set; }
		public int? DepartmentId { get; set; }

		public DateTime AppointmentDate { get; set; }
		public TimeSpan AppointmentTime { get; set; }

		// Nullable navigation properties matching nullable foreign keys
		public Patient? Patient { get; set; }
		public Doctor? Doctor { get; set; }
		public Department? Department { get; set; }
	}
}
