using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        [MaxLength(200)]
        public string? Lname { get; set; }
        public string? UserId { get; set; }
        [ForeignKey("UserId")]
        [ValidateNever]
        public ApplicationUser? User { get; set; }

        [DisplayName("Departamenti")]
        public int DepartamentId{ get; set; }
        [ForeignKey("DepartamentId")]
        [ValidateNever]
        public Departament? Departament { get; set; }
        
        [DisplayName("Viti")]
        public int? VitiID { get; set; }
        [ForeignKey("VitiID")]
        [ValidateNever]
        public Viti? Viti { get; set; }
    }
}
