using Consult.Models;
using Cunsult.DataAcess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Diagnostics;

namespace Consulting.Areas.Student.Controllers
{
    [Area("Student")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Konsultimet> konsultimetList = _unitOfWork.Konsultimet.GetAll(includeProperties: "Lendet");
            return View(konsultimetList);
        }

        public IActionResult Details(int id)
        {
            Konsultimet konsultimet = _unitOfWork.Konsultimet.Get(u=>u.Kid==id, includeProperties: "Lendet");
            return View(konsultimet);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}