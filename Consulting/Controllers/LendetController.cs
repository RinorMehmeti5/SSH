using Consult.DataAcess.Data;
using Consult.Models;
using Microsoft.AspNetCore.Mvc;

namespace Consult.Controllers
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
                TempData["success"] = "Lenda eshte krijuar me sukses";
                return RedirectToAction("Index");

            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Lendet? lendetprejdb = _db.Lendet.Find(id);
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
                TempData["success"] = "Lenda eshte edituar me sukses";
                return RedirectToAction("Index");

            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Lendet? lendetprejdb = _db.Lendet.Find(id);
            //Lendet? lendetprejdb1 = _db.Lendet.FirstOrDefault(u=>u.Lid==Lid);
            //Lendet? lendetprejdb2 = _db.Lendet.Where(u=>u.Lid == Lid).FirstOrDefault();
            if (lendetprejdb == null)
            {
                return NotFound();
            }
            return View(lendetprejdb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Lendet? obj =_db.Lendet.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Lendet.Remove(obj); 
            _db.SaveChanges();
            TempData["success"] = "Lenda eshte fshire me sukses";
            return RedirectToAction("Index");
        }
    }
}
