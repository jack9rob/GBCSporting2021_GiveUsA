using GBCSporting2021_GiveUsA.Models;
using GBCSporting2021_GiveUsA.Models.DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GBCSporting2021_GiveUsA.Controllers
{
    public class TechnicianController : Controller
    {
        private Repository<Technician> repository;
        public TechnicianController(TechnicalSupportContext ctx)
        {
            repository = new Repository<Technician>(ctx);
        }
        [HttpGet]
        [Route("technicians/add/")]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Technician());
        }
        [HttpGet]
        [Route("technicians/edit/{id}/{slug}")]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var technician = repository.Get(id);
            return View(technician);
        }
        [HttpPost]
        [Route("technicians/edit/{id?}/{slug?}")]
        public IActionResult Edit(Technician technician)
        {
            if (ModelState.IsValid)
            {
                if (technician.TechnicianId == 0)
                {
                    repository.Insert(technician);
                    TempData["message"] = technician.Name + " Added!";
                }

                else
                {
                    repository.Update(technician);
                    TempData["message"] = technician.Name + " Updated!";
                }
                repository.Save();
                return RedirectToAction("List", "Technician");
            }
            else
            {
                ViewBag.Action = (technician.TechnicianId == 0) ? "Add" : "Edit";
                return View(technician);
            }
        }
        [HttpGet]
        [Route("technicians/delete/{id}/{slug}")]
        public IActionResult Delete(int id)
        {
            var Technician = repository.Get(id);
            return View(Technician);
        }
        [HttpPost]
        [Route("technicians/delete/{id}/{slug}")]
        public IActionResult Delete(Technician technician)
        {
            repository.Delete(technician);
            TempData["message"] = technician.Name + " Deleted!";
            repository.Save();
            return RedirectToAction("List", "Technician");
        }
        [Route("technicians")]
        public IActionResult List()
        {
            var technician = repository.Get(orderBy: t => t.OrderBy(q => q.Name)).ToList();
            return View(technician);
        }
    }
}
