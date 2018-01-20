using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WadCW.Models;

namespace WadCW.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Product = "Smartphone";

            var model = new ProductViewModel()
            {
                Name = "Iphone",
                Price = 9999
            };
            return View(model);
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            return View(new ProductViewModel());
        }
        [HttpPost]
        public ActionResult AddProduct(ProductViewModel model)
        {
            if (ModelState.IsValid)
                ViewBag.Result = "Product was added successfully";
            return View(new ProductViewModel());
        }
    }
}