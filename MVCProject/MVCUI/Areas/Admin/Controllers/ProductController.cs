using COMMON;
using MODEL.Entities;
using SERVICE.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUI.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        // GET: Admin/Product
        ProductService _productService = new ProductService();
        public ActionResult Index()
        {
            var revenue = _productService.ProductRevenue();
            return View(_productService.GetDefault(x => x.Status == CORE.CoreEntity.Enums.Status.Active));
            //return View(_productService.GetAll());
        }

        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product model, HttpPostedFileBase imagePath)
        {

            if (ModelState.IsValid)
            model.ImagePath = ImageUploader.UploadImage("~/Content/images/user-images/", imagePath);
            _productService.Add(model);
            TempData["Message"] = $"{model.ProductName} adlı ürün veritabanına eklendi";
            return View();
        }

        public ActionResult UpdateProduct(Guid id)
        {
            var updated = _productService.GetById(id);
            return View(updated);
        }

        [HttpPost]
        public ActionResult UpdateProduct(Product model)
        {
            _productService.Update(model);
            TempData["Message"] = $"{model.ProductName} adlı ürün güncellendi";
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProduct(Guid id)
        {
            _productService.Remove(id);
            TempData["Message"] = $"{id} adlı ürün güncellendi";
            return RedirectToAction("Index");
        }

    }
}