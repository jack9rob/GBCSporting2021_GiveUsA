using GBCSporting2021_GiveUsA.Models;
using GBCSporting2021_GiveUsA.Models.DataLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Controllers
{
    public class ProductController : Controller
    {
        private Repository<Product> repository;

        public ProductController(TechnicalSupportContext ctx)
        {
            repository = new Repository<Product>(ctx);
        }

        [HttpGet]
        [Route("products")]
        public IActionResult List()
        {
            var products = repository.Get(orderBy: p => p.OrderBy(q => q.ReleaseDate)).ToList();
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
            var product = repository.Get(id);
            return View(product);
        }

        [HttpPost]
        [Route("products/edit/{id?}/{slug?}")]
        public IActionResult Edit(Product product)
        {
            string action = (product.ProductId == 0) ? "Add" : "Edit";
            if (ModelState.IsValid)
            {
                if (action == "Add")
                {
                    repository.Insert(product);
                    TempData["message"] = product.Name + " Added!";
                }
                else
                {
                    repository.Update(product);
                    TempData["message"] = product.Name + " Updated!";
                }
                repository.Save();
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
            var product = repository.Get(id);
            return View(product);
        }

        [HttpPost]
        [Route("products/delete/{id}/{slug}")]
        public IActionResult Delete(Product product)
        {
            repository.Delete(product);
            TempData["message"] = product.Name + " Deleted!";
            repository.Save();
            return RedirectToAction("List", "Product");
        }
    }
}
