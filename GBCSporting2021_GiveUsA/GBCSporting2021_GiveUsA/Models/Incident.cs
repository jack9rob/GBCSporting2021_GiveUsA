using System;
using System.ComponentModel.DataAnnotations;

namespace GBCSporting2021_GiveUsA.Models
{
    public class Incident
    {
        public int IncidentId { get; set; }

        [Required(ErrorMessage = "Enter a valid title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Enter a valid description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Enter a valid date")]
        public DateTime DateOpened { get; set; }

        public DateTime? DateClosed { get; set; }

        // customer
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        // product
        public int ProductId { get; set; }
        public Product Product { get; set; }
        
        // technician
        public int TechnicianId { get; set; }
        public Technician Technician { get; set; }

        public string Slug => Title?.Replace(" ", "-").ToLower();
    }
}
