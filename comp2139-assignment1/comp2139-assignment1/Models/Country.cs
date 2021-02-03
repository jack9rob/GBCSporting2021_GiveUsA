using System;
using System.ComponentModel.DataAnnotations;

namespace comp2139_assignment1.Models
{
    public class Country
    {
        public string CountryId { get; set; }

        [Required(ErrorMessage = "Enter a valid country name")]
        public string Name { get; set; }
    }
}
