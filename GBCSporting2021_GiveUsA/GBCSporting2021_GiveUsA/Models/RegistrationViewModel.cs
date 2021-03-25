using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Models
{
    public class RegistrationViewModel
    {
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
        public List<Registration> Registrations { get; set; }
    }
}
