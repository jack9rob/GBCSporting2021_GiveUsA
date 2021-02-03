using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comp2139_assignment1.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string PostalCode { get; set; }

        public string CountryId { get; set; }

        //public Country Country {get; set;} // don't know if this is needed


    }
}
