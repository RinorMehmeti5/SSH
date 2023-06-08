using Consult.DataAcess.Data;
using Consult.Models;
using Consult.Models.ViewModels;
using Cunsult.DataAcess.Repository;
using Cunsult.DataAcess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Consulting.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class KonsultimetController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public KonsultimetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Konsultimet> KonsultimetList = _unitOfWork.Konsultimet.GetAll().ToList();
            return View(KonsultimetList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            KunsultimetVM KunsultimetVM = new()
            {
                LendList = _unitOfWork.Lendet
                .GetAll().Select(u => new SelectListItem
                    {
                         Text = u.Lname,
                         Value = u.Lid.ToString(),
                    }),
                Konsultimet = new Konsultimet()
            };
            return View(KunsultimetVM);
        }
        [HttpPost]
        public IActionResult Create(Konsultimet obj)
        {
            //if (obj.Lname == obj.Ldescription.ToString())
            //{
            //    ModelState.AddModelError("Emri", "Emri i lendes dhe pershkrimi nuk mund te jene te njejta");
            //}
            if (ModelState.IsValid)
            {
                _unitOfWork.Konsultimet.Add(obj);
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
            Konsultimet? konsultimetprejdb = _unitOfWork.Konsultimet.Get(u => u.Kid == id);
            //Konsultimet? konsultimetprejdb1 = _db.Konsultimet.FirstOrDefault(u=>u.Lid==Lid);
            //Konsultimet? konsultimetprejdb2 = _db.Konsultimet.Where(u=>u.Lid == Lid).FirstOrDefault();
            if (konsultimetprejdb == null)
            {
                return NotFound();
            }
            return View(konsultimetprejdb);
        }
        [HttpPost]
        public IActionResult Edit(Konsultimet obj)
        {

            if (ModelState.IsValid)
            {
                _unitOfWork.Konsultimet.Update(obj);
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
            Konsultimet? konsultimetprejdb = _unitOfWork.Konsultimet.Get(u => u.Kid == id);
            //Konsultimet? konsultimetprejdb1 = _db.Konsultimet.FirstOrDefault(u=>u.Lid==Lid);
            //Konsultimet? konsultimetprejdb2 = _db.Konsultimet.Where(u=>u.Lid == Lid).FirstOrDefault();
            if (konsultimetprejdb == null)
            {
                return NotFound();
            }
            return View(konsultimetprejdb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Konsultimet? obj = _unitOfWork.Konsultimet.Get(u => u.Kid == id);
            if (obj == null)
            {
                return NotFound();
            }
            _unitOfWork.Konsultimet.Remove(obj);
            _unitOfWork.Save();
            TempData["success"] = "Lenda eshte fshire me sukses";
            return RedirectToAction("Index");
        }
    }
}
