using Consult.DataAcess.Data;
using Consult.Models;
using Cunsult.DataAcess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Consult.Controllers
{
    public class LendetController : Controller
    {
        private readonly ILendetRepository _lendetrep;
        public LendetController(ILendetRepository db)
        {
            _lendetrep = db;
        }
        public IActionResult Index()
        {
            List<Lendet> LendetList = _lendetrep.GetAll().ToList();
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
                _lendetrep.Add(obj);
                _lendetrep.Save();
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
            Lendet? lendetprejdb = _lendetrep.Get(u => u.Lid == id);
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
                _lendetrep.Update(obj);
                _lendetrep.Save();
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
            Lendet? lendetprejdb = _lendetrep.Get(u => u.Lid == id);
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
            Lendet? obj = _lendetrep.Get(u => u.Lid == id);
            if (obj == null)
            {
                return NotFound();
            }
            _lendetrep.Remove(obj);
            _lendetrep.Save();
            TempData["success"] = "Lenda eshte fshire me sukses";
            return RedirectToAction("Index");
        }
    }
}
