using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Models
{
    public class TechnicalSupportContext : DbContext
    {
        public TechnicalSupportContext(DbContextOptions<TechnicalSupportContext> options) : base(options) { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        public DbSet<Incident> Incidents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                    new Country { CountryId = "CAD", Name = "Canada"},
                    new Country { CountryId = "USA", Name = "United States of America"}, 
                    new Country { CountryId = "AUS", Name = "Australia"}
                );

            modelBuilder.Entity<Customer>().HasData(
                    new Customer { 
                        CustomerId = 1, 
                        Firstname = "Jack", 
                        Lastname = "Robinson",
                        Address = "123 Home Drive",
                        City = "Toronto",
                        Province = "Ontario",
                        Postalcode = "M4B 1G5",
                        Email = "jack.robinson@gmail.com",
                        Phone = "123-456-7899",
                        CountryId = "CAD"
                    }
                );

            modelBuilder.Entity<Product>().HasData(
                    new Product { 
                        ProductId = 1,
                        Code = "MAC-AIR-M1",
                        Name = "Macbook Air M1",
                        Price = 1200,
                        ReleaseDate = DateTime.Now
                    }
                );

            modelBuilder.Entity<Technician>().HasData(
                    new Technician {
                        TechnicianId = 1,
                        Name = "Alex Yoon",
                        Email = "Yoon@email.com",
                        Phone = "647-347-3345"
                    }
                );
            modelBuilder.Entity<Incident>().HasData(
                    new Incident {
                        IncidentId = 1,
                        Title = "Macbook broke",
                        Description = "Alex smashed by macbook because he was too jealous",
                        DateOpened = DateTime.Now,
                        CustomerId = 1,
                        ProductId = 1,
                        TechnicianId = 1
                    }
                );
        }
    }
}
