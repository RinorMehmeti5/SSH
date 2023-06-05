using Consulting.Data;
using Consulting.Models;
using Microsoft.AspNetCore.Mvc;

namespace Consulting.Controllers
{
    public class LendetController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LendetController(ApplicationDbContext db)
        {
            _db= db;
        }
        public IActionResult Index()
        {
            List<Lendet> LendetList = _db.Lendet.ToList(); 
            return View(LendetList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Lendet obj)
        {
             if (ModelState.IsValid)
            {
                _db.Lendet.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
             return View();
        }
    }
}
