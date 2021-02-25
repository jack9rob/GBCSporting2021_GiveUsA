using GBCSporting2021_GiveUsA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GBCSporting2021_GiveUsA.Controllers
{
    public class TechnicianController : Controller
    {
        public TechnicalSupportContext context { get; set; }
        public TechnicianController(TechnicalSupportContext ctx)
        {
            context = ctx;
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Technician());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Countries = context.Countries.OrderBy(c => c.Name).ToList();
            var technician = context.Technicians.FirstOrDefault(c => c.TechnicianId == id);
            return View(technician);
        }
        [HttpPost]
        public IActionResult Edit(Technician technician)
        {
            if (ModelState.IsValid)
            {
                if (technician.TechnicianId == 0)
                    context.Technicians.Add(technician);
                else
                    context.Technicians.Update(technician);
                context.SaveChanges();
                return RedirectToAction("List", "Technician");

            }
            else
            {
                ViewBag.Action = (technician.TechnicianId == 0) ? "Add" : "Edit";
                return View(technician);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var Technician = context.Technicians.Find(id);
            return View(Technician);
        }
        [HttpPost]
        public IActionResult Delete(Technician technician)
        {
            context.Technicians.Remove(technician);
            context.SaveChanges();
            return RedirectToAction("List", "Technician");
        }
        public IActionResult List()
        {
            var technician = context.Technicians.ToList();
            return View(technician);
        }
    }
}
