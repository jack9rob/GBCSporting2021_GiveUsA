﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Models
{
    public class Customer
    {
        public int CustomerId { get; set; } // automatically generated by the EF and database

        [Required(ErrorMessage = "Enter a valid first name")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Enter a valid last name")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Enter a valid address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Enter a valid city")]
        public string City { get; set; }

        [Required(ErrorMessage = "Enter a valid province")]
        public string Province { get; set; }

        [Required(ErrorMessage = "Enter a valid postal code")]
        public string Postalcode { get; set; }

        public string Email { get; set; } // optional

        public string Phone { get; set; } // optional

        public string CountryId { get; set; } // foreign key

        public Country Country { get; set; } // property
    }
}