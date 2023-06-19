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

        public int Kid { get; set; }
        [ForeignKey("Kid")]
        [ValidateNever]
        public Konsultimet Konsultimet { get; set; }

        public bool Attending { get; set; }

        public string UserId { get; set; } // New user ID property
        [ForeignKey("UserId")] // New foreign key attribute
        [ValidateNever]
        public ApplicationUser? User { get; set; } // New User property
    }


}
