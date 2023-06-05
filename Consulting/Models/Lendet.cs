using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Consulting.Models
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
    }
}
