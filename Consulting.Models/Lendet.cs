using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Consult.Models
{
    public class Lendet
    {
        [Key]
        public int Lid { get; set; }
        [Required]
        [DisplayName("Emri i lendes")]
        [MaxLength(100)]
        public string? Lname { get; set; }
        public string? UserId { get; set; }
        [ForeignKey("UserId")]
        [ValidateNever]
        public ApplicationUser? User { get; set; }

        public int DepartamentId{ get; set; }
        [ForeignKey("DepartamentId")]
        [ValidateNever]
        public Departament? Departament { get; set; }
        public int? VitiID { get; set; }
        [ForeignKey("VitiID")]
        [ValidateNever]
        public Viti? Viti { get; set; }
    }
}
