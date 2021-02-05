﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Models
{
    public class Customer
    {
        public int CustomerId { get; set; } // automatically generated by the EF and database

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string Postalcode { get; set; }

        public string Email { get; set; } // optional

        public string Phone { get; set; } // optional

        public string CountryId { get; set; } // foreign key

        public Country Country { get; set; } // property
    }
}
