using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Models.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entity)
        {

            entity.HasData(
                    new Product
                    {
                        ProductId = 1,
                        Code = "MAC-AIR-M1",
                        Name = "Macbook Air M1",
                        Price = 1200,
                        ReleaseDate = DateTime.Now
                    },
                    new Product
                    {
                        ProductId = 2,
                        Code = "BLK-COF",
                        Name = "Black Coffee",
                        Price = 2.50,
                        ReleaseDate = DateTime.Now
                    },
                    new Product
                    {
                        ProductId = 3,
                        Code = "yoga-mat",
                        Name = "Yoga Mat",
                        Price = 10.00,
                        ReleaseDate = DateTime.Now
                    }
                );
        }
    }
}
