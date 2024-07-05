﻿namespace MainMVCTask01.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public string image {  get; set; }
        public ICollection<DoctorPatient> DoctorPatients { get; set; }

    }
}
