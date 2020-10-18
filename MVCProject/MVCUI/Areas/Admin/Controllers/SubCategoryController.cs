using MODEL.Entities;
using SERVICE.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUI.Areas.Admin.Controllers
{
    public class SubCategoryController : Controller
    {
        SubCategoryService _subCategoryService = new SubCategoryService();
        public ActionResult Index()
        {
            return View(_subCategoryService.GetDefault(x=>x.Status==CORE.CoreEntity.Enums.Status.Active));
        }

        public ActionResult AddSubCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSubCategory(SubCategory model)
        {
            if (ModelState.IsValid)
                _subCategoryService.Add(model);
            TempData["Message"] = $"{model.SubCategoryName} adlı Altkategori veritabanına eklendi";
            return RedirectToAction("Index");
        }

        public ActionResult UpdateSubCategory(Guid id)
        {
            var updated = _subCategoryService.GetById(id);

            return View(updated);

        }

        [HttpPost]
        public ActionResult UpdateSubCategory(SubCategory model)
        {
            _subCategoryService.Update(model);
            TempData["Message"] = $"{model.SubCategoryName} adlı Altkategori güncellendi";
            return RedirectToAction("Index");

        }

        public ActionResult DeleteSubCategory(Guid id)
        {
            _subCategoryService.Remove(id);
            TempData["Message"] = $"{id} adlı Altkategori silindi";
            return RedirectToAction("Index");
        }


    }
}