using MainMVCTask01.Data;
using MainMVCTask01.Models;
using System.Numerics;

namespace MainMVCTask01.SeedData
{
    public class Seeding
    {

        private readonly ApplicationDbContext _context;
        public Seeding (ApplicationDbContext context)
        {
            _context = context;
        }
      
        public void SeedData ()
        {
            //var Doctors = new List<Doctor>
            //{
            //new Doctor { Name = "Dr. John Smith", Specialization = "Cardiology", image = "doctor1.jpg" },
            //new Doctor { Name = "Dr. Sarah Johnson", Specialization = "Pediatrics", image = "doctor3.jpg" },
            //new Doctor { Name = "Dr. Emily Davis", Specialization = "Dermatology", image = "doctor5.jpg" },
            //new Doctor { Name = "Dr. Michael Lee", Specialization = "Orthopedics", image = "doctor2.jpg" },
            //new Doctor { Name = "Dr. William Clark", Specialization = "Neurology", image = "doctor4.jpg" },
            //};
            //foreach(var Doctor  in Doctors)
            //{
            //    if (!_context.Doctors.Any(d => d.Id == Doctor.Id))
            //    {
            //        _context.Doctors.Add(Doctor);
            //    }
            //}
            //_context.SaveChanges();
        }
    }
}
