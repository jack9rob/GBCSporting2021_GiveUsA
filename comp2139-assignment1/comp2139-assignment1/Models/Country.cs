using System;
using System.ComponentModel.DataAnnotations;

namespace GBCSporting2021_GiveUsA.Models
{
    public class Country
    {
        public string CountryId { get; set; }

        [Required(ErrorMessage = "Enter a valid country name")]
        public string Name { get; set; }
    }
}
