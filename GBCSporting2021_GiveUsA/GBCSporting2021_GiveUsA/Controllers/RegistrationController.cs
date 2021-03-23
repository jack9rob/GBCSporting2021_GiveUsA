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
            ViewBag.Products = context.Products.OrderBy(p => p.Code).ToList();
            ViewBag.Registrations = context.Registrations.OrderBy(r => r.Product.Name).ToList();


            return View(customer);
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
            var product = context.Products.FirstOrDefault(p => p.ProductId == id);
            var customer = context.Customers.FirstOrDefault(c => c.CustomerId == cid);
            return View();
        }
        
    }
}
