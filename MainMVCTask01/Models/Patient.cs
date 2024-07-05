namespace MainMVCTask01.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime AppoinmentDate { get; set; }
        public ICollection<DoctorPatient> DoctorPatients { get; set; }
    }
}
