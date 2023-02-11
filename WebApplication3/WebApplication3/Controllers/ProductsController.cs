using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        // URI /Products
        public static List<Product> List = new List<Product>();
        public ActionResult Index()
        {
            return View(List);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product obj)
        {
            Random objRandom = new Random();
            int numriRandom = objRandom.Next(1, 77);
            obj.Quantity = new Quantity(numriRandom, "Copë");
            List.Add(obj);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Search()
        {
            return View("SearchByBarcode");
        }
        [HttpPost]
        public ActionResult Search(string bar)
        {
            Product findedProduct = new Product();
            foreach (Product item in List)
            {
                if (item.Barcode == bar)
                {
                    findedProduct = item;
                }
            }
            return View(findedProduct);
        }
    }
}