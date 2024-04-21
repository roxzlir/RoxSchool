using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RoxSchool.Models
{
    public class Enrollment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EnrollmentId { get; set; }

        [ForeignKey("Student")]
        public int FkStudentId { get; set; }
        public Student? Student { get; set; }
        [ForeignKey("Course")]
        
        public int FkCourseId { get; set; }
        public Course? Course { get; set; }
        

    }
}
