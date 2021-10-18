using System;
using System.ComponentModel.DataAnnotations;

namespace LTC1070.Models
{
    public class Movie
    {
        [Key]
        [Required]
        [StringLength(20)]
        public string PersonId { get; set; }
        [Required]
        [StringLength(20)]
        public string PersonName { get; set; }

        
    }
}