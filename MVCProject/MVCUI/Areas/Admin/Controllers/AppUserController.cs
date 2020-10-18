using COMMON;
using MODEL.Context;
using MODEL.Entities;
using SERVICE.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUI.Areas.Admin.Controllers
{
    public class AppUserController : Controller
    {
        
        AppUserService _appUserService = new AppUserService();
        public ActionResult Index()
        {
            return View(_appUserService.GetDefault(x => x.Status == CORE.CoreEntity.Enums.Status.Active));
            
        }
        
        public ActionResult AddAppUser()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult AddAppUser(AppUser model, HttpPostedFileBase imagePath)
        {
            model.ImagePath = ImageUploader.UploadImage("~/Content/images/user-images/", imagePath);
            _appUserService.Add(model);
            TempData["Message"] = $"{model.Name} adlı kişi veritabanına eklendi";
            return RedirectToAction("Index");
        }

        public ActionResult UpdateAppUser(Guid id)
        {
            var updated = _appUserService.GetById(id);

            return View(updated);

        }

        [HttpPost]
        public ActionResult UpdateAppUser(AppUser model)
        {
            _appUserService.Update(model);
            TempData["Message"] = $"{model.Name} adlı kişi güncellendi";
            return RedirectToAction("Index");
        }

        public ActionResult DeleteAppUser(Guid id)
        {
            _appUserService.Remove(id);
            TempData["Message"] = $"{id} no'lu kişi silindi";
            return RedirectToAction("Index");
        }

    }
}