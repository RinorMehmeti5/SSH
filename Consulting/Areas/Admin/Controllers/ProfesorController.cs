using Consult.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Consulting.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class ProfesorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult _Form()
        {
            return PartialView();
        }
    }
}
