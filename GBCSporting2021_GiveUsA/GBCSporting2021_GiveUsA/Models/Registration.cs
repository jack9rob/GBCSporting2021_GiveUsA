using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Models
{
    public class Registration
    {
        public int RegistrationId { get; set; }

        [Required(ErrorMessage = "Customer is Required")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required(ErrorMessage = "Product is Required")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
