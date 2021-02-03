using System;
using System.ComponentModel.DataAnnotations;

namespace comp2139_assignment1.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Enter a product code")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Enter a product name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter a product price")] // make it have a range?
        public double Price { get; set; }

        [Required(ErrorMessage = "Enter a product release date")] // make it have a range?
        public DateTime ReleaseDate { get; set; }
    }
}
