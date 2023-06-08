using Consult.DataAcess.Data;
using Consult.Models;
using Cunsult.DataAcess.Repository;
using Cunsult.DataAcess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Consulting.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LendetController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public LendetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Lendet> LendetList = _unitOfWork.Lendet.GetAll().ToList();
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
                _unitOfWork.Lendet.Add(obj);
                _unitOfWork.Save();
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
            Lendet? lendetprejdb = _unitOfWork.Lendet.Get(u => u.Lid == id);
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
                _unitOfWork.Lendet.Update(obj);
                _unitOfWork.Save();
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
            Lendet? lendetprejdb = _unitOfWork.Lendet.Get(u => u.Lid == id);
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
            Lendet? obj = _unitOfWork.Lendet.Get(u => u.Lid == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.Lendet.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Lenda eshte fshire me sukses";
            return RedirectToAction("Index");
        }
    }
}
