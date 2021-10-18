using System;
using System.ComponentModel.DataAnnotations;

namespace LTC1070.Models
{
    public class Teacher
    {
        [Key]
        [Required]
        [StringLength(20)]
        public string TeacherId { get; set; }
        [Required]
        [StringLength(20)]
        public string TeacherName { get; set; }

        
    }
}