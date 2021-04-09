using GBCSporting2021_GiveUsA.Models;
using GBCSporting2021_GiveUsA.Models.DataLayer;
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

        private UnitOfWork unitOfWork;

        public TechIncidentController(TechnicalSupportContext ctx)
        {
            unitOfWork = new UnitOfWork(ctx);
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

            var incidents = unitOfWork.IncidentRepository.Get(includeProperties: "Technician,Customer,Product").Where(i => i.TechnicianId == tid).
                Where(i => i.DateClosed == null).ToList();
            ViewBag.Name = unitOfWork.TechnicianRepository.Get(tid).Name;
            return View(incidents);
        }
        [Route("get-technician")]
        public IActionResult SelectTechnician()
        {
            var technicians = unitOfWork.TechnicianRepository.Get(orderBy: t => t.OrderBy(q => q.Name)).ToList();
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
            var incident = unitOfWork.IncidentRepository.Get(includeProperties: "Technician,Customer,Product").Where(i => i.IncidentId == id).FirstOrDefault();
            return View(incident);
        }

        [HttpPost]
        [Route("technician-incident/edit/{id}/{slug}")]
        public IActionResult Edit(Incident incident)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.IncidentRepository.Update(incident);
                unitOfWork.Save();
                return RedirectToAction("List", "TechIncident");
            }
            else
            {
                return View(incident);
            }
        }
    }
}
