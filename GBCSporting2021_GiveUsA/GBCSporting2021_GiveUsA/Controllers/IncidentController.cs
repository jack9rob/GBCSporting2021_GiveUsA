using GBCSporting2021_GiveUsA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Controllers
{
    public class IncidentController : Controller
    {
        private TechnicalSupportContext context { get; set; }

        public IncidentController(TechnicalSupportContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        [Route("incidents/{filter?}")]
        public IActionResult List(string filter = "all")
        {
            IQueryable<Incident> incidents = context.Incidents
                .Include(i => i.Product)
                .Include(i => i.Customer)
                .Include(i => i.Technician);
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
            List<Customer> customers = context.Customers.OrderBy(c => c.Firstname).ToList();
            List<Product> products = context.Products.OrderBy(p => p.Name).ToList();
            List<Technician> technicians = context.Technicians.OrderBy(t => t.Name).ToList();

            IncidentViewModel vm = new IncidentViewModel
            {
                Customers = customers,
                Products = products,
                Technicians = technicians,
                CurrentIncident = new Incident(),
                Action = action
            };
            return View("Edit", vm);
        }

        [HttpGet]
        [Route("incidents/edit/{id}/{slug}")]
        public IActionResult Edit(int id)
        {
            var incident = context.Incidents
                .Include(i => i.Product)
                .Include(i => i.Customer)
                .Include(i => i.Technician)
                .FirstOrDefault(i => i.IncidentId == id);

            var customers = context.Customers.OrderBy(c => c.Firstname).ToList();
            var products = context.Products.OrderBy(p => p.Name).ToList();
            var technicians = context.Technicians.OrderBy(t => t.Name).ToList();

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
        [Route("incidents/edit/{id}/{slug}")]
        public IActionResult Edit(IncidentViewModel vm)
        {

            string action = vm.Action;
            if (ModelState.IsValid)
            {
                if(action == "Add")
                {
                    vm.CurrentIncident.DateOpened = DateTime.Now;
                    context.Incidents.Add(vm.CurrentIncident);
                    TempData["message"] = vm.CurrentIncident.Title + " Added!";
                } else
                {
                    context.Incidents.Update(vm.CurrentIncident);
                    TempData["message"] = vm.CurrentIncident.Title + " Updated!";
                }
                context.SaveChanges();
                return RedirectToAction("List", "Incident");
            }else
            {
                return View(vm);
            }    
        }

        [HttpGet]
        [Route("incidents/delete/{id}/{slug}")]
        public IActionResult Delete(int id)
        {
            var incident = context.Incidents.FirstOrDefault(i => i.IncidentId == id);
            IncidentViewModel vm = new IncidentViewModel { CurrentIncident = incident, Action = "Delete" };
            return View(vm);
        }

        [HttpPost]
        [Route("incidents/delete/{id}/{slug}")]
        public IActionResult Delete(IncidentViewModel vm)
        {
            context.Incidents.Remove(vm.CurrentIncident);
            TempData["message"] = vm.CurrentIncident.Title + " Deleted!";
            context.SaveChanges();
            return RedirectToAction("List", "Incident");
        }
    }
}
