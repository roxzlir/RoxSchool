using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RoxSchool.Models
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherId { get; set; }
        [Required]
        [StringLength(70)]
        public string TeacherName { get; set; }
        [Required]
        [StringLength(150)]
        public string TeacherEmail { get; set; }
        [Required]
        [StringLength(20)]
        public string TeacherPhone { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }
    }
}
