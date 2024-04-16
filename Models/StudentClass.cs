﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoxSchool.Models
{
    public class StudentClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentClassId { get; set; }
        [Required]
        [StringLength(15)]
        public string StudentClassName { get; set; }
        public ICollection<Student>? Students { get; set; }
    }
}
