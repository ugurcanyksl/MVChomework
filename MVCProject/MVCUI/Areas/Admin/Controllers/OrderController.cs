using MODEL.Entities;
using SERVICE.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUI.Areas.Admin.Controllers
{
    public class OrderController : Controller
    {
        
        OrderService _OrderService = new OrderService();
        // GET: Admin/Order
        public ActionResult Index()
        {
            return View(_OrderService.GetDefault(x => x.Status == CORE.CoreEntity.Enums.Status.Active));
        }

        public ActionResult AddOrder()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddOrder(Order model)
        {
            if (ModelState.IsValid)
                _OrderService.Add(model);
            TempData["Message"] = $"{model.OrderDate} tarihli sipariş veritabanına eklendi";
            return RedirectToAction("Index");
        }

        public ActionResult UpdateOrder(Guid id)
        {
            var updated = _OrderService.GetById(id);

            return View(updated);

        }

        [HttpPost]
        public ActionResult UpdateOrder(Order model)
        {
            _OrderService.Update(model);
            TempData["Message"] = $"{model.OrderDate} tarihli sipariş güncellendi";
            return RedirectToAction("Index");

        }

        public ActionResult DeleteOrder(Guid id)
        {
            _OrderService.Remove(id);
            TempData["Message"] = $"{id} nolu sipariş silindi";
            return RedirectToAction("Index");
        }



    }
}