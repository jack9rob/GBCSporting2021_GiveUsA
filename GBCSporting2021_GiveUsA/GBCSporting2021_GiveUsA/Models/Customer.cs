﻿using GBCSporting2021_GiveUsA.Models.Validation;
using Microsoft.AspNetCore.Mvc;
using System;
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

        [Required(ErrorMessage = "Enter a valid state")]
        public string Province { get; set; }

        [Required(ErrorMessage = "Enter a valid postal code")]
        public string Postalcode { get; set; }

        
        [Required(ErrorMessage = "Select a country")]
        [GreaterThan(0, ErrorMessage ="Please Select a Country")]
        public string CountryId { get; set; } // foreign key
        public Country Country { get; set; } // property

        [DataType(DataType.EmailAddress)]
        [Remote("CheckEmail", "Validation", AdditionalFields = "CustomerId", ErrorMessage = "Email already in use")]
        public string Email { get; set; } // optional

        public string Phone { get; set; } // optional

        public string Slug => Firstname?.Replace(" ", "-").ToLower() + "-" + Lastname?.Replace(" ", "-").ToLower();


    }
}
