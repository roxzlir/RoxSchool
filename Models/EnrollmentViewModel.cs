namespace RoxSchool.Models
{
    public class EnrollmentViewModel
    {
        public Student Student { get; set; }
        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
        public StudentClass StudentClass { get; set; }
        public Enrollment Enrollment { get; set; }
    }
}
