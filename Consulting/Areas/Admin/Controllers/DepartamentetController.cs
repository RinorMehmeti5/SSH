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
using System.Data;

namespace Consulting.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = SD.Role_Admin)]
    public class DepartamentetController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public DepartamentetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Departament> DepartamentetList = _unitOfWork.Departamentet.GetAll().ToList();
            return View(DepartamentetList);
        }

        public IActionResult Upsert(int? id)
        {
            if (id == null || id == 0)
            {
                //create
                return View(new Departament());
            }
            else
            {
                //update
                Departament DepartamentObj = _unitOfWork.Departamentet.Get(u => u.Id == id);
                return View(DepartamentObj);
            }
        }
        [HttpPost]
        public IActionResult Upsert(Departament departamentetObj)
        {
            //if (obj.Lname == obj.Ldescription.ToString())
            //{
            //    ModelState.AddModelError("Emri", "Emri i lendes dhe pershkrimi nuk mund te jene te njejta");
            //}
            if (ModelState.IsValid)
            {
                if (departamentetObj.Id == 0)
                {
                    _unitOfWork.Departamentet.Add(departamentetObj);
                }
                else
                {
                    _unitOfWork.Departamentet.Update(departamentetObj);

                }
                _unitOfWork.Save();
                TempData["success"] = "Departamenti eshte krijuar me sukses";
                return RedirectToAction("Index");

            }
            else
            {
                return View(departamentetObj);
            }
            
        }
        #region API Calls
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Departament> DepartamentetList = _unitOfWork.Departamentet.GetAll().ToList();
            return Json(new { data = DepartamentetList });
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var departamentetToBeDeleted = _unitOfWork.Departamentet.Get(u => u.Id == id);
            if (departamentetToBeDeleted == null)
            {
                return Json(new
                {
                    success = false,
                    message = "error while deleting"
                });
            }
            _unitOfWork.Departamentet.Remove(departamentetToBeDeleted);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });
        }

        #endregion
    }
}
