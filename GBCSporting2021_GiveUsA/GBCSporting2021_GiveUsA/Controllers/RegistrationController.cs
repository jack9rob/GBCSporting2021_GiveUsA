using GBCSporting2021_GiveUsA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;
using GBCSporting2021_GiveUsA.Models.DataLayer;

namespace GBCSporting2021_GiveUsA.Controllers
{
    public class RegistrationController : Controller
    {
        private UnitOfWork unitOfWork;

        public RegistrationController(TechnicalSupportContext ctx)
        {
            unitOfWork = new UnitOfWork(ctx);
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
            
            var customer = unitOfWork.CustomerRepository.Get(cid);
            var products = unitOfWork.ProductRepository.Get(orderBy: p => p.OrderBy(q => q.Name)).ToList();
            var registrations = unitOfWork.RegistrationRepository.Get().Where(r => r.CustomerId == cid).ToList();

            var viewModel = new RegistrationViewModel { Customer = customer, Products = products, Registrations = registrations};

            return View(viewModel);
        }

        [Route("getcustomer")]
        public IActionResult GetCustomer()
        {
            ViewBag.Customers = unitOfWork.CustomerRepository.Get(orderBy: c => c.OrderBy(q => q.Lastname)).ToList();
            return View();
        }

        [Route("setregistration")]
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
            string name = unitOfWork.ProductRepository.Get(id).Name;

            if (ModelState.IsValid)
            {
                // check if product is already registered
                if(unitOfWork.RegistrationRepository.Get().Where(r => r.ProductId == id).Where(r => r.CustomerId == cid).ToList().Count() != 0)
                {
                    TempData["message"] = name + " already registered";
                } else
                {
                    unitOfWork.RegistrationRepository.Insert(new Registration { CustomerId = cid, ProductId = id });
                    unitOfWork.RegistrationRepository.Save();
                    TempData["message"] = name + " Added!";
                }
            }
            return RedirectToAction("Registrations");
        }

        [HttpGet]
        [Route("deleteregistration/{id}")]
        public IActionResult Delete(int id)
        {
            var registration = unitOfWork.RegistrationRepository.Get(includeProperties: "Product").FirstOrDefault(registration => registration.RegistrationId == id);
            return View(registration);
        }

        [HttpPost]
        [Route("deleteregistration/{id?}")]
        public IActionResult Delete(Registration registration)
        {
            unitOfWork.RegistrationRepository.Delete(registration);
            unitOfWork.RegistrationRepository.Save();
            return RedirectToAction("Registrations");
        }
    }
}
