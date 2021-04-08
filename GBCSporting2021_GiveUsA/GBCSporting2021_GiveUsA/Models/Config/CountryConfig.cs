using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Models.Config

{
    internal class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> entity)
        {
            entity.HasData(
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
