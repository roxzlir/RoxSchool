using System.ComponentModel;
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
        [DisplayName("Name")]
        public string StudentName { get; set; }
        [Required]
        [StringLength(150)]
        [DisplayName("Email")]
        public string StudentEmail { get; set;}
        [Required]
        [StringLength(20)]
        [DisplayName("Phone")]
        public string StudentPhone { get; set;}
        [Required]
        [DisplayName("Date of birth")]
        public int StudentDoB { get; set; }
        [ForeignKey("StudentClass")]
        public int FkStudentClassId { get; set; }
        public StudentClass? StudentClass { get; set; }
        public IList<Enrollment>? Enrollments { get; set; }
    }
}
