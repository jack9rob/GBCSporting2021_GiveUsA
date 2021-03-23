using GBCSporting2021_GiveUsA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace GBCSporting2021_GiveUsA.Controllers
{
    public class RegistrationController : Controller
    {
        public TechnicalSupportContext context { get; set; }

        public RegistrationController(TechnicalSupportContext ctx)
        {
            context = ctx;
        }

        [Route("registrations")]
        public IActionResult Registrations()
        {
            var session = new RegistrationSession(HttpContext.Session);
            var cid = session.GetId();
            if(cid == -1)
            {
                return RedirectToAction("GetCustomer");
            } 
            
            var customer = context.Customers.FirstOrDefault(c => c.CustomerId == cid);
            var products = context.Products.OrderBy(p => p.Code).ToList();
            var registrations = context.Registrations.Where(r => r.CustomerId == cid).ToList();

            var viewModel = new RegistrationViewModel { Customer = customer, Products = products, Registrations = registrations, NewRegistration = new Registration() };

            return View(viewModel);
        }


        public IActionResult GetCustomer()
        {
            ViewBag.Customers = context.Customers.OrderBy(c => c.Lastname).ToList();
            return View();
        }

        [Route("setregistration/{id?}")]
        public IActionResult SetRegistration(string id)
        {
            Int32.TryParse(id, out int cid);
            var session = new RegistrationSession(HttpContext.Session);
            session.SetId(cid);
            return RedirectToAction("Registrations");
        }

        
        public IActionResult AddRegistration(int id)
        {
            var session = new RegistrationSession(HttpContext.Session);
            var cid = session.GetId();
            string name = context.Products.FirstOrDefault(p => p.ProductId == id).Name;
            if (ModelState.IsValid)
            {
                // check if product is already registered
                if(context.Registrations.Where(r => r.ProductId == id).ToList().Count() != 0)
                {
                    TempData["message"] = name + " already registered";
                } else
                {
                    context.Registrations.Add(new Registration { CustomerId = cid, ProductId = id });
                    context.SaveChanges();
                    TempData["message"] = name + " Added!";
                }

            }
            return RedirectToAction("Registrations");
            
        }
        
    }
}
