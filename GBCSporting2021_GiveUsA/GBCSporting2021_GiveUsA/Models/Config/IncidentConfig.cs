using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Models.Config
{
    public class IncidentConfig : IEntityTypeConfiguration<Incident>
    {
        public void Configure(EntityTypeBuilder<Incident> entity)
        {
            entity.HasData(
                new Incident
                {
                    IncidentId = 1,
                    Title = "Macbook broke",
                    Description = "Alex smashed by macbook because he was too jealous",
                    DateOpened = DateTime.Now,
                    CustomerId = 1,
                    ProductId = 1,
                    TechnicianId = 1
                },
                new Incident
                {
                    IncidentId = 2,
                    Title = "Coffe spill",
                    Description = "Coffee spilled all over me",
                    DateOpened = DateTime.Now,
                    CustomerId = 2,
                    ProductId = 2,
                    TechnicianId = 3
                },
                new Incident
                {
                    IncidentId = 3,
                    Title = "Yoga mat is wrong colour",
                    Description = "Wrong yoga mat was delivered to me",
                    DateOpened = DateTime.Now,
                    CustomerId = 3,
                    ProductId = 3,
                    TechnicianId = 3
                }
            );
        }
    }
}
