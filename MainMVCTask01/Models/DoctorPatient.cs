﻿namespace MainMVCTask01.Models
{
    public class DoctorPatient
    {
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public  Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
    }
}
