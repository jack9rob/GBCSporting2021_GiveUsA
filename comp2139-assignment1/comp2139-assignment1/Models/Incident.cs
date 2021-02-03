using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comp2139_assignment1.Models
{
    public class Incident
    {
        public int IncidentId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateOpened { get; set; }

        public DateTime DateClose { get; set; } // can be null, forget the syntax used, check slides

        // add product, customer, and technician
    }
}
