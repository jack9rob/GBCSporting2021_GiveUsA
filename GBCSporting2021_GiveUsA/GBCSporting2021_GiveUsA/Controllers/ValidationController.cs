using GBCSporting2021_GiveUsA.Models;
using GBCSporting2021_GiveUsA.Models.DataLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Controllers
{
    public class ValidationController : Controller
    {
        private UnitOfWork unitOfWork;

        public ValidationController(TechnicalSupportContext ctx)
        {
            unitOfWork = new UnitOfWork(ctx);
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult CheckEmail(string email, int id)
        {
            bool result;
            var customerCheck = unitOfWork.CustomerRepository.Get().Where(c => c.Email == email && c.CustomerId != id && c.Email != null).FirstOrDefault();

            if (customerCheck != null)
            {
                result = false;
            } else
            {
                result = true;
            }
            return Json(result);
        }
    }
}
