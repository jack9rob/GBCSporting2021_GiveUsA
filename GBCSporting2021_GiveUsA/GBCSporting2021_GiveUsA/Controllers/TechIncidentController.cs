using GBCSporting2021_GiveUsA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Controllers
{
    public class TechIncidentController : Controller
    {

        public TechnicalSupportContext context { get; set; }

        public TechIncidentController(TechnicalSupportContext ctx)
        {
            context = ctx;
        }

        [Route("tech_incident")]
        public IActionResult List()
        {
            var session = new TechnicianSession(HttpContext.Session);
            var tid = session.GetId();
            if(tid == -1)
            {
                return RedirectToAction("SelectTechnician");
            }

            var incidents = context.Incidents.
                Include(i => i.Technician).
                Include(i => i.Customer).
                Include(i => i.Product).
                Where(i => i.TechnicianId == tid).
                Where(i => i.DateClosed == null).
                ToList();
            return View(incidents);
        }
        [Route("get-technician")]
        public IActionResult SelectTechnician()
        {
            var technicians = context.Technicians.OrderBy(t => t.Name).ToList();
            return View(technicians);
        }

        [HttpPost]
        [Route("set-technician")]
        public IActionResult SetTechnician(int id)
        {
            var session = new TechnicianSession(HttpContext.Session);
            session.SetId(id);
            return RedirectToAction("List");
        }

        [HttpGet]
        [Route("technician-incident/edit/{id}/{slug}")]
        public IActionResult Edit(int id)
        {
            var incident = context.Incidents.
                Include(i => i.Technician).
                Include(i => i.Customer).
                Include(i => i.Product).
                Where(i => i.IncidentId == id).FirstOrDefault();
            return View(incident);
        }

        [HttpPost]
        [Route("technician-incident/edit/{id}/{slug}")]
        public IActionResult Edit(Incident incident)
        {
            if (ModelState.IsValid)
            {
                context.Incidents.Update(incident);
                context.SaveChanges();
                return RedirectToAction("List", "TechIncident");
            }
            else
            {
                return View(incident);
            }
        }
    }
}
