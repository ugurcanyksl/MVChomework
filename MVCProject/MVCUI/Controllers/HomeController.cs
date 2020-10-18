using SERVICE.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUI.Controllers
{
    public class HomeController : Controller
    {
        CategoryService _categoryService = new CategoryService();
        public ActionResult Index()
        {
           
            return View(_categoryService.GetAll());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}