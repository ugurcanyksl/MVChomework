using MODEL.Entities;
using SERVICE.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUI.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
       
        CategoryService _categoryService = new CategoryService();
        public ActionResult Index()
        {
            return View(_categoryService.GetDefault(x=>x.Status==CORE.CoreEntity.Enums.Status.Active));
        }

        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category model)
        {
            if(ModelState.IsValid)
                _categoryService.Add(model);
            TempData["Message"] = $"{model.CategoryName} adlı kategori veritabanına eklendi";
            return RedirectToAction("Index");
        }

        public ActionResult UpdateCategory(Guid id)
        {
            var updated = _categoryService.GetById(id);
           
            return View(updated);

        }
        [HttpPost]
        public ActionResult UpdateCategory(Category model)
        {
             _categoryService.Update(model);
            TempData["Message"] = $"{model.CategoryName} adlı kategori güncellendi";
            return RedirectToAction("Index");

        }

        public ActionResult DeleteCategory(Guid id)
        {
            _categoryService.Remove(id);
            TempData["Message"] = $"{id} adlı kategori silindi";
            return RedirectToAction("Index");
        }
    }
}