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
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var incident = context.Incidents
                .Include(i => i.Product)
                .Include(i => i.Customer)
                .Include(i => i.Technician)
                .FirstOrDefault(i => i.IncidentId == id);
            ViewBag.Customers = context.Customers.OrderBy(c => c.Firstname).ToList();
            ViewBag.Products = context.Products.OrderBy(p => p.Name).ToList();
            ViewBag.Technicians = context.Technicians.OrderBy(t => t.Name).ToList();
            return View(incident);
        }

        [HttpPost]
        public IActionResult Edit(IncidentViewModel vm)
        {

            string action = vm.Action;
            if (ModelState.IsValid)
            {
                if(action == "Add")
                {
                    vm.CurrentIncident.DateOpened = DateTime.Now;
                    context.Incidents.Add(vm.CurrentIncident);
                } else
                {
                    context.Incidents.Update(vm.CurrentIncident);
                }
                context.SaveChanges();
                return RedirectToAction("List", "Incident");
            } else
            {
                return View(vm);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var incident = context.Incidents.FirstOrDefault(i => i.IncidentId == id);
            return View(incident);
        }

        [HttpPost]
        public IActionResult Delete(Incident incident)
        {
            context.Incidents.Remove(incident);
            context.SaveChanges();
            return RedirectToAction("List", "Incident");
        }
    }
}
