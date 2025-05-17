using Microsoft.EntityFrameworkCore;
using adminnn.Models;  

public class AppDbContext : DbContext
{
    public DbSet<Department> Departments { get; set; } 
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Bed> Beds { get; set; }
    public DbSet<Appointment> Appointments { get; set; }


    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Bed>()
            .HasOne(b => b.Patient)      // A Bed can have one Patient
            .WithMany()                  
            .HasForeignKey(b => b.PatientId) 
            .OnDelete(DeleteBehavior.SetNull); 
    }


}

