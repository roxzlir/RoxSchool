namespace RoxSchool.Models
{
    public class StudentWithTeachers
    {
        public string StudentName { get; set; }
        public IEnumerable<string> TeacherNames { get; set; }

    }
    //public class StudentWithTeachers
    //{
    //    public string StudentName { get; set; }
    //    public List<TeacherWithCourse> Teachers { get; set; }
    //}

    //public class TeacherWithCourse
    //{
    //    public string TeacherName { get; set; }
    //    public string CourseName { get; set; }
    //}

}
