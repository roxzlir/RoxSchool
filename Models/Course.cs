﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RoxSchool.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        [Required]
        [StringLength(20)]
        public string CourseName { get; set; }
        [StringLength(200)]
        public string? CourseDescription { get; set; }
        [ForeignKey("Teacher")]
        public int FkTeacherId { get; set; }
        public Teacher? Teacher { get; set; }
        public IList<Enrollment>? Enrollments { get; set; }
    }
}
