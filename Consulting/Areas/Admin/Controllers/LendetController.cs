using Consult.DataAcess.Data;
using Consult.Models;
using Consult.Models.ViewModels;
using Consult.Utility;
using Cunsult.DataAcess.Repository;
using Cunsult.DataAcess.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Consulting.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
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
            LendetVM obj = new LendetVM();

            obj.DepartamentList = _unitOfWork.Departamentet.GetAll().Select(u => new SelectListItem
            {
                Text = u.Name,
                Value = u.Id.ToString(),
            });

            obj.VitiList = _unitOfWork.Viti.GetAll().Select(u => new SelectListItem
            {
                Text = u.VitiName,
                Value = u.Vid.ToString(),
            });

            return View(obj);
        }

        [HttpPost]
        public IActionResult Create(LendetVM obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Lendet.Add(obj.Lendet);
                _unitOfWork.Save();

                TempData["success"] = "Lenda eshte krijuar me sukses";
                return RedirectToAction("Index");
            }

            // Only populate these lists if ModelState is not valid.
            //obj.DepartamentList = _unitOfWork.Departamentet.GetAll().Select(u => new SelectListItem
            //{
            //    Text = u.Name,
            //    Value = u.Id.ToString(),
            //});

            //obj.VitiList = _unitOfWork.Viti.GetAll().Select(u => new SelectListItem
            //{
            //    Text = u.VitiName,
            //    Value = u.Vid.ToString(),
            //});

            return View(obj);
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
