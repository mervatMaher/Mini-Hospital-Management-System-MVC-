
using MainMVCTask01.Models;
using Microsoft.EntityFrameworkCore;

namespace MainMVCTask01.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<DoctorPatient> DoctorPatients { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options) {
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DoctorPatient>().HasKey(dp => new {dp.PatientId, dp.DoctorId});

            modelBuilder.Entity<DoctorPatient>().HasOne(d=>d.Doctor).WithMany(d=>d.DoctorPatients).
                HasForeignKey(d => d.DoctorId);

            modelBuilder.Entity<DoctorPatient>().HasOne(dp => dp.Patient).WithMany(p => p.DoctorPatients)
                .HasForeignKey(p => p.PatientId);






        }

    }
}
