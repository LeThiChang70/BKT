using System;
using System.ComponentModel.DataAnnotations;

namespace LTC1070.Models
{
    public class LTC070
    {
        [Key]
        [Required]
        [StringLength(20)]
        public string LTCId { get; set; }
        [Required]
        [StringLength(20)]
        public string LTCName { get; set; }

        
    }
}