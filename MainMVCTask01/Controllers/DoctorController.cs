using MainMVCTask01.Data;
using MainMVCTask01.Models;
using MainMVCTask01.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace MainMVCTask01.Controllers
{
    public class DoctorController : Controller
    {
        private ApplicationDbContext _context;

        public DoctorController (ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Doctors()
        {
            var result = _context.Doctors.ToList();
            return View(result);
        }

        public IActionResult BookAppointment(int DoctorId)
        {
            var doctor = _context.Doctors.Find(DoctorId); 
            if (doctor == null)
            {
                return NotFound();
            }
            ViewBag.DoctorId = DoctorId;
            return View(doctor);
        }

        public IActionResult SubmitAppoinment (PatientModel patientModel)
        {
            if (ModelState.IsValid)
            {
                DateTime appoinmentDateTime;

                if (DateTime.TryParse(patientModel.AppointmentDate.ToString("yyyy-MM-dd") + " " + patientModel.AppointmentTime, out appoinmentDateTime))
                {
                    var patient = new Patient
                    {
                        Name = patientModel.PatientName,
                        AppoinmentDate = appoinmentDateTime
                    };

                    if (!_context.Patients.Any(p => p.Name == patient.Name && p.AppoinmentDate == patient.AppoinmentDate ))
                    {
                        _context.Patients.Add(patient);
                        _context.SaveChanges();
                    }

                    var DoctorPatient = new DoctorPatient
                    {
                        DoctorId = patientModel.DoctorId,
                        PatientId = patient.Id
                    };

                    _context.DoctorPatients.Add(DoctorPatient);
                    _context.SaveChanges();
                }
            }
         var Doctors = _context.Doctors.ToList();
            return View("Doctors", Doctors);
        }
    }
}
