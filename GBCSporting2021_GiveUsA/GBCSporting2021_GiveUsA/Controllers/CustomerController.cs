using GBCSporting2021_GiveUsA.Models;
using GBCSporting2021_GiveUsA.Models.DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GBCSporting2021_GiveUsA.Controllers
{
    public class CustomerController : Controller
    {
        public UnitOfWork unitOfWork;
        
        public CustomerController(TechnicalSupportContext ctx)
        {
            unitOfWork = new UnitOfWork(ctx);
        }
        

        [HttpGet]
        [Route("customers/add")]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Countries = unitOfWork.CountryRepository.Get().ToList();
            return View("Edit", new Customer());
        }
        [HttpGet]
        [Route("customers/edit/{id}/{slug}")]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Countries = unitOfWork.CountryRepository.Get().ToList();
            var customer = unitOfWork.CustomerRepository.Get(includeProperties: "Country").FirstOrDefault(c => c.CustomerId == id);
            return View(customer);
        }

        [HttpPost]
        [Route("customers/edit/{id?}/{slug?}")]
        public IActionResult Edit(Customer customer)
        {
            
            string key = nameof(Customer.Email);
            
            if(ModelState.GetValidationState(key) == ModelValidationState.Valid)
            {
                var customerCheck = unitOfWork.CustomerRepository.Get(c => c.Email == customer.Email && c.CustomerId != customer.CustomerId && c.Email != null).FirstOrDefault();
                if (customerCheck != null)
                {
                    ModelState.AddModelError(key, "Email alreay is use");
                }
            }
            

            if (ModelState.IsValid)
            {
                if(customer.CustomerId == 0)
                {
                    unitOfWork.CustomerRepository.Insert(customer);
                    TempData["message"] = customer.Firstname + " " + customer.Lastname + " Added!";
                }  
                else
                {
                    unitOfWork.CustomerRepository.Update(customer);
                    TempData["message"] = customer.Firstname + " " + customer.Lastname + " Edited!";
                }
                unitOfWork.Save();
                return RedirectToAction("List", "Customer");
                
            }
            else
            {
                ViewBag.Action = (customer.CustomerId == 0) ? "Add" : "Edit";
                ViewBag.Countries = unitOfWork.CountryRepository.Get().ToList();
                return View(customer);
            }
        }
        [HttpGet]
        [Route("customers/delete/{id}/{slug}")]
        public IActionResult Delete(int id)
        {
            var customer = unitOfWork.CustomerRepository.Get(id);
            return View(customer);
        }
        [HttpPost]
        [Route("customers/delete/{id}/{slug}")]
        public IActionResult Delete(Customer customer)
        {
            TempData["message"] = customer.Firstname + " " + customer.Lastname + " Deleted!";
            unitOfWork.CustomerRepository.Delete(customer);
            unitOfWork.Save();
            return RedirectToAction("List", "Customer");
        }
        [Route("customers")]
        public IActionResult List()
        {
            var customers = unitOfWork.CustomerRepository.Get(includeProperties: "Country").ToList();
            return View(customers);
        }
    }
}
