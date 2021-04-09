using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Models.Config
{
    public class TechnicianConfig : IEntityTypeConfiguration<Technician>
    {
        public void Configure(EntityTypeBuilder<Technician> entity)
        {
            entity.HasData(
                new Technician
                {
                    TechnicianId = 1,
                    Name = "Alex Yoon",
                    Email = "Yoon@email.com",
                    Phone = "647-347-3345"
                },
                new Technician
                {
                    TechnicianId = 2,
                    Name = "John Doe",
                    Email = "doe@hotmail.com",
                    Phone = "416-774-5412"
                },
                new Technician
                {
                    TechnicianId = 3,
                    Name = "Jane Doe",
                    Email = "janster@gmail.com",
                    Phone = "122-458-4775"
                }
            );
        }
    }
}
