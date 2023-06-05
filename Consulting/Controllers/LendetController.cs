using Consulting.Data;
using Consulting.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Consulting.Controllers
{
    public class LendetController : Controller
    {
        private readonly ApplicationDbContext _db;
        public LendetController(ApplicationDbContext db)
        {
            _db = db;
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
            //if (obj.Lname == obj.Ldescription.ToString())
            //{
            //    ModelState.AddModelError("Emri", "Emri i lendes dhe pershkrimi nuk mund te jene te njejta");
            //}
            if (ModelState.IsValid)
            {
                _db.Lendet.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();
        }
        public IActionResult Edit(int? Lid)
        {
            if (Lid == null || Lid == 0)
            {
                return NotFound();
            }
            Lendet? lendetprejdb = _db.Lendet.Find(Lid);
            //Lendet? lendetprejdb1 = _db.Lendet.FirstOrDefault(u=>u.Lid==Lid);
            //Lendet? lendetprejdb2 = _db.Lendet.Where(u=>u.Lid == Lid).FirstOrDefault();
            if (lendetprejdb == null) 
            {
                return NotFound(); 
            }
            return View(lendetprejdb);
        }
        [HttpPost]
        public IActionResult Edit(Lendet obj)
        {

            if (ModelState.IsValid)
            {
                _db.Lendet.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();
        }
        public IActionResult Delete(int? Lid)
        {
            if (Lid == null || Lid == 0)
            {
                return NotFound();
            }
            Lendet? lendetprejdb = _db.Lendet.Find(Lid);
            //Lendet? lendetprejdb1 = _db.Lendet.FirstOrDefault(u=>u.Lid==Lid);
            //Lendet? lendetprejdb2 = _db.Lendet.Where(u=>u.Lid == Lid).FirstOrDefault();
            if (lendetprejdb == null)
            {
                return NotFound();
            }
            return View(lendetprejdb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? Lid)
        {
            Lendet? obj =_db.Lendet.Find(Lid);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Lendet.Remove(obj); 
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
