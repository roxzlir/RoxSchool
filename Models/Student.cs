using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoxSchool.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        [Required]
        [StringLength(70)]
        public string StudentName { get; set; }
        [Required]
        [StringLength(150)]
        public string StudentEmail { get; set;}
        [Required]
        [StringLength(20)]
        public string StudentPhone { get; set;}
        [Required]
        public int StudentDoB { get; set; }
        [ForeignKey("StudentClass")]
        public int FkStudentClassId { get; set; }
        public IList<Enrollment>? Enrollments { get; set; }
    }
}
