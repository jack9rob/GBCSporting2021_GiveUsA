using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Models.SeedData
{
    public static class CountryModelBuilderExtension
    {
        public static void SeedCountry(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country { CountryId = "CAD", Name = "Canada" },
                new Country { CountryId = "USA", Name = "United States of America" },
                new Country { CountryId = "KOR", Name = "Korea" },
                new Country { CountryId = "OTHER", Name = "Other" },
                new Country { CountryId = "AUS", Name = "Australia" },
                new Country { CountryId = "MEX", Name = "Mexico" },
                new Country { CountryId = "UK", Name = "United Kingdom" }
            );
        }
    }
}
