using GBCSporting2021_GiveUsA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GBCSporting2021_GiveUsA.Models.DataLayer;

namespace GBCSporting2021_GiveUsA.Controllers
{
    public class IncidentController : Controller
    {
        UnitOfWork unitOfWork;

        public IncidentController(TechnicalSupportContext ctx)
        {
            unitOfWork = new UnitOfWork(ctx);
        }

        [HttpGet]
        [Route("incidents/{filter?}")]
        public IActionResult List(string filter = "all")
        {
            var incidents = unitOfWork.IncidentRepository.Get(includeProperties: "Product,Customer,Technician");
            if(filter == "unassigned")
            {
                incidents = incidents.Where(i => i.TechnicianId == null);
            } else if(filter == "open")
            {
                incidents = incidents.Where(i => i.DateClosed == null);
            }

            var vm = new IncidentViewModel { Incidents = incidents.ToList(), Filter = filter };
            return View(vm);
        }

        [HttpGet]
        [Route("incidents/add")]
        public IActionResult Add()
        {
            string action = "Add";
            List<Customer> customers = unitOfWork.CustomerRepository.Get(orderBy: c => c.OrderBy(q => q.Firstname)).ToList();
            List<Product> products = unitOfWork.ProductRepository.Get(orderBy: p => p.OrderBy(q => q.Name)).ToList();
            List<Technician> technicians = unitOfWork.TechnicianRepository.Get(orderBy: t => t.OrderBy(q => q.Name)).ToList();

            IncidentViewModel vm = new IncidentViewModel
            {
                Customers = customers,
                Products = products,
                Technicians = technicians,
                CurrentIncident = new Incident { DateOpened = DateTime.Now },
                Action = action
            };
            return View("Edit", vm);
        }

        [HttpGet]
        [Route("incidents/edit/{id}/{slug}")]
        public IActionResult Edit(int id)
        {
            var incident = unitOfWork.IncidentRepository.Get(includeProperties: "Product,Customer,Technician").FirstOrDefault(i => i.IncidentId == id);

            List<Customer> customers = unitOfWork.CustomerRepository.Get(orderBy: c => c.OrderBy(q => q.Firstname)).ToList();
            List<Product> products = unitOfWork.ProductRepository.Get(orderBy: p => p.OrderBy(q => q.Name)).ToList();
            List<Technician> technicians = unitOfWork.TechnicianRepository.Get(orderBy: t => t.OrderBy(q => q.Name)).ToList();

            IncidentViewModel vm = new IncidentViewModel
            {
                Customers = customers,
                Products = products,
                Technicians = technicians,
                CurrentIncident = incident,
                Action = "Edit"
            };
            return View(vm);
        }

        [HttpPost]
        [Route("incidents/edit/{id?}/{slug?}")]
        public IActionResult Edit(IncidentViewModel vm)
        {

            string action = vm.Action;
            if (ModelState.IsValid)
            {
                if(action == "Add")
                {
                    unitOfWork.IncidentRepository.Insert(vm.CurrentIncident);
                    TempData["message"] = vm.CurrentIncident.Title + " Added!";
                } else
                {
                    unitOfWork.IncidentRepository.Update(vm.CurrentIncident);
                    TempData["message"] = vm.CurrentIncident.Title + " Updated!";
                }
                unitOfWork.Save();
                return RedirectToAction("List", "Incident");
            }else
            {
                vm.Customers = unitOfWork.CustomerRepository.Get(orderBy: c => c.OrderBy(q => q.Firstname)).ToList();
                vm.Products = unitOfWork.ProductRepository.Get(orderBy: p => p.OrderBy(q => q.Name)).ToList();
                vm.Technicians = unitOfWork.TechnicianRepository.Get(orderBy: t => t.OrderBy(q => q.Name)).ToList();
                return View(vm);
            }    
        }

        [HttpGet]
        [Route("incidents/delete/{id}/{slug}")]
        public IActionResult Delete(int id)
        {
            var incident = unitOfWork.IncidentRepository.Get(id);
            IncidentViewModel vm = new IncidentViewModel { CurrentIncident = incident, Action = "Delete" };
            return View(vm);
        }

        [HttpPost]
        [Route("incidents/delete/{id}/{slug}")]
        public IActionResult Delete(IncidentViewModel vm)
        {
            unitOfWork.IncidentRepository.Delete(vm.CurrentIncident);
            TempData["message"] = vm.CurrentIncident.Title + " Deleted!";
            unitOfWork.Save();
            return RedirectToAction("List", "Incident");
        }
    }
}
