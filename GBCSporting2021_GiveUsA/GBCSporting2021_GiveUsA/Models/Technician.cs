using System;
using System.ComponentModel.DataAnnotations;


namespace GBCSporting2021_GiveUsA.Models
{
    public class Technician
    {
        public int TechnicianId { get; set; }

        [Required(ErrorMessage = "Enter a valid name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter a valid phone number")]
        public string Phone { get; set; }
        public string Slug => Name?.Replace(" ", "-").ToLower() + "-" + Email?.Replace(" ", "-").ToLower();

    }
}
