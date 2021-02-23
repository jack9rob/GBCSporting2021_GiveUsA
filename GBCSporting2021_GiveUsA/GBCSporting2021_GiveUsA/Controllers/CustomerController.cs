using GBCSporting2021_GiveUsA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GBCSporting2021_GiveUsA.Controllers
{
    public class CustomerController : Controller
    {
        public CustomerContext cusContext { get; set; }
        public CustomerController(CustomerContext ctx)
        {
            cusContext = ctx;
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Country = cusContext.Countries.OrderBy(c => c.Name).ToList();
            return View("Edit", new Customer());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Country = cusContext.Countries.OrderBy(c => c.Name).ToList();
            var country = cusContext.Countries.Find(id);
            return View(country);
        }
        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                if(customer.CustomerId == 0)
                    cusContext.Customers.Add(customer);
                else
                    cusContext.Customers.Update(customer);
                    cusContext.SaveChanges();
                    return RedirectToAction("Index", "Customer");
                
            }
            else
            {
                ViewBag.Action = (customer.CustomerId == 0) ? "Add" : "Edit";
                ViewBag.Countries = cusContext.Countries.OrderBy(c => c.Name).ToList();
                return View(customer);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var customer = cusContext.Customers.Find(id);
            return View(customer);
        }
        [HttpPost]
        public IActionResult Delete(Customer customer)
        {
            cusContext.Customers.Remove(customer);
            cusContext.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }
        public IActionResult Index()
        {
            var customers = cusContext.Customers
                .Include(c => c.Country)
                .ToList();
            return View(customers);
        }
    }
}
