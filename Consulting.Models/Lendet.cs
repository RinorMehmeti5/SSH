﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Consult.Models
{
    public class Lendet
    {
        [Key]
        public int Lid { get; set; }
        [Required]
        [DisplayName("Emri i lendes")]
        [MaxLength(40)]
        public string? Lname { get; set; }
        [Required]
        [DisplayName("Pershkrimi")]
        public string? Ldescription { get; set; }
        public int LPid { get; set; }
    }
}
