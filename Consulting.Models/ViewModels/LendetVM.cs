using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consult.Models.ViewModels
{
    public class LendetVM
    {
        public Lendet Lendet { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> DepartamentList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> VitiList { get; set; }
    }
}
