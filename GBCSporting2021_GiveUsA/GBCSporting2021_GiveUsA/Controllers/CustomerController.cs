using GBCSporting2021_GiveUsA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GBCSporting2021_GiveUsA.Controllers
{
    public class CustomerController : Controller
    {
        public TechnicalSupportContext context { get; set; }
        public CustomerController(TechnicalSupportContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        [Route("customers/add")]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Countries = context.Countries.OrderBy(c => c.Name).ToList();
            return View("Edit", new Customer());
        }
        [HttpGet]
        [Route("customers/edit/{id}/{slug}")]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Countries = context.Countries.OrderBy(c => c.Name).ToList();
            var customer = context.Customers.Include(c => c.Country).FirstOrDefault(c => c.CustomerId == id);
            return View(customer);
        }

        [HttpPost]
        [Route("customers/edit/{id}/{slug}")]
        public IActionResult Edit(Customer customer)
        {
            /*
            string key = nameof(Customer.Email);
            
            if(ModelState.GetValidationState(key) == ModelValidationState.Valid)
            {
                var customerCheck = context.Customers.Where(c => c.Email == customer.Email && c.CustomerId != customer.CustomerId && c.Email != null).FirstOrDefault();
                if (customerCheck != null)
                {
                    ModelState.AddModelError(key, "Email alreay is use");
                }
            }
            */

            if (ModelState.IsValid)
            {
                if(customer.CustomerId == 0)
                {
                    context.Customers.Add(customer);
                    TempData["message"] = customer.Firstname + " " + customer.Lastname + " Added!";
                }  
                else
                {
                    context.Customers.Update(customer);
                    TempData["message"] = customer.Firstname + " " + customer.Lastname + " Edited!";
                }                    
                context.SaveChanges();
                return RedirectToAction("List", "Customer");
                
            }
            else
            {
                ViewBag.Action = (customer.CustomerId == 0) ? "Add" : "Edit";
                ViewBag.Countries = context.Countries.OrderBy(c => c.Name).ToList();
                return View(customer);
            }
        }
        [HttpGet]
        [Route("customers/delete/{id}/{slug}")]
        public IActionResult Delete(int id)
        {
            var customer = context.Customers.Find(id);
            return View(customer);
        }
        [HttpPost]
        [Route("customers/delete/{id}/{slug}")]
        public IActionResult Delete(Customer customer)
        {
            TempData["message"] = customer.Firstname + " " + customer.Lastname + " Deleted!";
            context.Customers.Remove(customer);
            context.SaveChanges();
            return RedirectToAction("List", "Customer");
        }
        [Route("customers")]
        public IActionResult List()
        {
            var customers = context.Customers
                .Include(c => c.Country)
                .ToList();
            return View(customers);
        }
    }
}
