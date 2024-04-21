namespace RoxSchool.Models
{
    public class CourseWithTeacherViewModel
    {
        public string SelectedCourse { get; set; }
        public IEnumerable<CourseWithTeacher> Teachers { get; set; }
        public IEnumerable<Course> Courses { get; set; }

    }
}
