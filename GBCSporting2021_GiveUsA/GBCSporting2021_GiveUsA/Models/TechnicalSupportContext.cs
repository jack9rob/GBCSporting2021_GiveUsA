using Microsoft.EntityFrameworkCore;
using System;

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
                    new Country { CountryId = "AUS", Name = "Australia"},
                    new Country { CountryId = "MEX", Name = "MEX"},
                    new Country { CountryId = "UK", Name = "United Kingdom"}
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
                    },
                    new Customer
                    {
                        CustomerId = 2,
                        Firstname = "Fatih",
                        Lastname = "Com",
                        Address = "123 Home Drive",
                        City = "Toronto",
                        Province = "Ontario",
                        Postalcode = "M4B 1G5",
                        Email = "fatih@gmail.com",
                        Phone = "123-456-7899",
                        CountryId = "MEX"
                    },
                    new Customer
                    {
                        CustomerId = 3,
                        Firstname = "Young-il",
                        Lastname = "Kim",
                        Address = "123 Home Drive",
                        City = "Toronto",
                        Province = "Ontario",
                        Postalcode = "M4B 1G5",
                        Email = "jack.robinson@gmail.com",
                        Phone = "123-456-7899",
                        CountryId = "AUS"
                    }
                );

            modelBuilder.Entity<Product>().HasData(
                    new Product { 
                        ProductId = 1,
                        Code = "MAC-AIR-M1",
                        Name = "Macbook Air M1",
                        Price = 1200,
                        ReleaseDate = DateTime.Now
                    },
                    new Product { 
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

            modelBuilder.Entity<Technician>().HasData(
                    new Technician {
                        TechnicianId = 1,
                        Name = "Alex Yoon",
                        Email = "Yoon@email.com",
                        Phone = "647-347-3345"
                    },
                    new Technician {
                        TechnicianId = 2,
                        Name = "John Doe",
                        Email = "doe@hotmail.com",
                        Phone = "416-774-5412"
                    },
                    new Technician { 
                        TechnicianId = 3,
                        Name = "Jane Doe",
                        Email = "janster@gmail.com",
                        Phone = "122-458-4775"
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
                    },
                    new Incident {
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
