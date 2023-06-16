using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consult.Models
{
    public class KonsultimAttend
    {
        [Key]
        public int KAid { get; set; }

        public int UKid { get; set; }
        [ForeignKey("UKid")]
        [ValidateNever]
        public UserKonsultimet UserKonsultimet { get; set; }

        public bool Attending { get; set; }
    }
}
