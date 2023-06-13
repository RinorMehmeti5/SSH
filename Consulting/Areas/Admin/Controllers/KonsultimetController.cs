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
    [Authorize(Roles = SD.Role_Admin)]
    public class KonsultimetController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public KonsultimetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Konsultimet> KonsultimetList = _unitOfWork.Konsultimet.GetAll(includeProperties:"Lid").ToList();
            return View(KonsultimetList);
        }
        
        public IActionResult Upsert(int? id)
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
            if (id==null || id==0)
            {
                //create
                return View(KunsultimetVM);
            } else{
                //update
                KunsultimetVM.Konsultimet = _unitOfWork.Konsultimet.Get(u=>u.Kid==id);
                return View(KunsultimetVM);
            }
        }
        [HttpPost]
        public IActionResult Upsert(KunsultimetVM konsultimetVM)
        {
            //if (obj.Lname == obj.Ldescription.ToString())
            //{
            //    ModelState.AddModelError("Emri", "Emri i lendes dhe pershkrimi nuk mund te jene te njejta");
            //}
            if (ModelState.IsValid)
            {
                if(konsultimetVM.Konsultimet.Kid == 0)
                {
                    _unitOfWork.Konsultimet.Add(konsultimetVM.Konsultimet);
                }
                else
                {
                    _unitOfWork.Konsultimet.Update(konsultimetVM.Konsultimet);
                    TempData["success"] = "Lenda eshte krijuar me sukses";
                }
                _unitOfWork.Save();
                return RedirectToAction("Index");

            }
            return View();
        }
        #region API Calls
        [HttpGet]
        public IActionResult GetAll() {
            List<Konsultimet> KonsultimetList = _unitOfWork.Konsultimet.GetAll(includeProperties: "Lid").ToList();
            return Json(new {data =  KonsultimetList});
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var konsultimetToBeDeleted = _unitOfWork.Konsultimet.Get(u=> u.Kid == id);
            if(konsultimetToBeDeleted == null)
            {
                return Json(new
                {
                    success = false,
                    message = "error while deleting"
                });
            }
            _unitOfWork.Konsultimet.Remove(konsultimetToBeDeleted); 
            _unitOfWork.Save();
            return Json(new { success= true, message = "Delete successful"});
        }

        #endregion
    }
}
