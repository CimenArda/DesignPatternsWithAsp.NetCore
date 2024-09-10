﻿using DesignPattern.Facade.DAL;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Facade.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();

        [HttpGet]
        public IActionResult AddNewProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewProduct(Product Product)
        {
            context.Products.Add(Product);
            context.SaveChanges();
            return RedirectToAction("ProductList");
        }
        public IActionResult ProductList()
        {
            var values = context.Products.ToList();
            return View(values);
        }
    }
}
