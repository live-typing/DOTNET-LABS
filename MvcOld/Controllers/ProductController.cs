using MvcOld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOld.Controllers
{
    public class ProductsController : Controller
    {

        public static List<Product> products = new List<Product>();

        // GET: Products

        [Route("/getAll")]
        [HttpGet]
        public ActionResult GetAllProducts()
        {
            if (products.Count == 0)
            {
                products.Add(new Product() { Cost = 300, ItemCode = 1, Name = "Apples" });
            }
            return View(products);
        }

        [HttpGet]
        public ActionResult AddProduct()
        {
            return View(new Product());
        }

        [HttpPost]
        public ActionResult AddProduct(Product pProduct)
        {
            products.Add(pProduct);
            return View("GetAllProducts", products);
        }
        [HttpGet]
        public ActionResult AddAjaxProduct()
        {
            return View(new Product());
        }
        [HttpPost]
        public ActionResult AddAjaxProduct(Product pProduct)
        {
            products.Add(pProduct);
            return PartialView("GetAllProducts", products);
        }


        [HttpGet]
        public ActionResult Edit(int code)
        {
            Product found = products.Where(single => single.ItemCode == code).ToList().FirstOrDefault();
            return View(found);
        }
        [HttpPost]
        public ActionResult Edit(int code, Product updatedProduct)
        {
            Product found = products.Where(single => single.ItemCode == updatedProduct.ItemCode).ToList().FirstOrDefault();
            found.Name = updatedProduct.Name;
            found.Cost = updatedProduct.Cost;

            return View("GetAllProducts", products);
        }
        [HttpGet]
        public ActionResult ShowSomeView()
        {
            return View("SomeView", new Product() { ItemCode = 1001, Cost = 15000, Name = "Drone" });
        }


    }
}

