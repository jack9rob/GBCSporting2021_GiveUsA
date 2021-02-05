using System;
using System.ComponentModel.DataAnnotations;

namespace GBCSporting2021_GiveUsA.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please enter a prouduct code")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Please enter a prouduct name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a prouduct price")]
        [Range(0.0, Double.MaxValue, ErrorMessage = "Product price must greater than or equal to 0")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Please enter a prouduct release date")]
        public DateTime ReleaseDate { get; set; }

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + ReleaseDate.ToString("dd-MM-yyyy");
    }
}
