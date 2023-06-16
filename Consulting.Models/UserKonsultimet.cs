using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consult.Models
{
    public class UserKonsultimet
    {
        [Key]
        public int UKid { get; set; }

        public int KonsultimId { get; set; }
        [ForeignKey("KonsultimId")]
        [ValidateNever]
        public Konsultimet Konsultimet { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        [ValidateNever]
        public ApplicationUser User { get; set; }
    }
}
