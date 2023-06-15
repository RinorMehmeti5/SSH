using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Consult.Models
{
    public class Konsultimet
    {
        [Key]
        public int Kid { get; set; }
        [Required]
        [DisplayName("Titulli i Konsultimit")]
        public string? Ktitle { get; set; }
        [DisplayName("Koha e fillimit")]

        [Required]
        public DateTime KkohaEFillimit { get; set; }
        [DisplayName("Koha e mbarimit")]

        public DateTime KkohaEMbarimit { get; set; }
        [DisplayName("Përshkrimi i konsultimit")]

        public string? Kpershkrimi { get; set; }

        [DisplayName("Lënda për konsultim")]
        public int KLid { get; set; }
        [ForeignKey("KLid")]
        [ValidateNever]
        public Lendet Lendet { get; set; }
        public string UserId { get; set; }
        [ForeignKey("Id")]
        [ValidateNever]
        public ApplicationUser? User{ get; set; }
    }
}
