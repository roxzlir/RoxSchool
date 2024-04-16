using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RoxSchool.Models
{
    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnrollmentId { get; set; }

        [ForeignKey("StudentId")]
        public int FkStudentId { get; set; }
        public Student Student { get; set; }
        [ForeignKey("CourseId")]
        public int FkCourseId { get; set; }
        public Course Course { get; set; }
        
    }
}
