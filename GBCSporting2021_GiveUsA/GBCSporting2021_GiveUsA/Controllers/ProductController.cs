using GBCSporting2021_GiveUsA.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Controllers
{
    public class ProductController : Controller
    {
        private TechnicalSupportContext context { get; set; }

        public ProductController(TechnicalSupportContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        [Route("products")]
        public IActionResult List()
        {
            var products = context.Products.OrderBy(p => p.ReleaseDate).ToList();
            return View(products);
        }

        [HttpGet]
        [Route("products/add")]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Product());
        }

        [HttpGet]
        [Route("products/edit/{id}/{slug}")]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var product = context.Products
                .FirstOrDefault(p => p.ProductId == id);
            return View(product);
        }

        [HttpPost]
        [Route("products/edit/{id}/{slug}")]
        public IActionResult Edit(Product product)
        {
            string action = (product.ProductId == 0) ? "Add" : "Edit";
            if (ModelState.IsValid)
            {
                if (action == "Add")
                {
                    context.Products.Add(product);
                    TempData["message"] = product.Name + " Added!";
                }
                else
                {
                    context.Products.Update(product);
                    TempData["message"] = product.Name + " Updated!";
                }
                context.SaveChanges();
                return RedirectToAction("List", "Product");
            }
            else
            {
                ViewBag.Action = action;
                return View(product);
            }
        }

        [HttpGet]
        [Route("products/delete/{id}/{slug}")]
        public IActionResult Delete(int id)
        {
            var product = context.Products.FirstOrDefault(p => p.ProductId == id);
            return View(product);
        }

        [HttpPost]
        [Route("products/delete/{id}/{slug}")]
        public IActionResult Delete(Product product)
        {
            context.Products.Remove(product);
            TempData["message"] = product.Name + " Deleted!";
            context.SaveChanges();
            return RedirectToAction("List", "Product");
        }
    }
}
