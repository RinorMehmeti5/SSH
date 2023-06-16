using Microsoft.AspNetCore.Identity;
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
    public class ApplicationUser:IdentityUser
    {
        [Required]
        public string? Name { get; set; }
        public string? StreetAdress { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public string? Country { get; set; }
        public string? FKID { get; set; }
        public int? DepartamentID { get; set; }
        [ForeignKey("Id")]
        [ValidateNever]
        public Departament? Departament { get; set; }
        public int? VitiID { get; set; }
        [ForeignKey("VitiID")]
        [ValidateNever]
        public Viti? Viti{ get; set; }
    }
}
