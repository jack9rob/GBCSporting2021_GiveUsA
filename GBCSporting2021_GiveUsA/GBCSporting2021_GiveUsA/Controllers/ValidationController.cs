using GBCSporting2021_GiveUsA.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Controllers
{
    public class ValidationController : Controller
    {
        private TechnicalSupportContext context { get; set; }

        public ValidationController(TechnicalSupportContext ctx)
        {
            context = ctx;
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult CheckEmail(string email, int id)
        {
            bool result;
            var customerCheck = context.Customers.Where(c => c.Email == email && c.CustomerId != id && c.Email != null).FirstOrDefault();

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
