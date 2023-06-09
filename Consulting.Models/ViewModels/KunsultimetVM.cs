using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consult.Models.ViewModels
{
    public class KunsultimetVM
    {
        public Konsultimet Konsultimet { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> LendList { get; set; }
    }
}
