using GBCSporting2021_GiveUsA.Controllers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Models
{
    public class CustomerContext : DbContext
    {

        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country { CountryId = "CAD", Name = "Canada" },
                new Country { CountryId = "USA", Name = "United States of America" },
                new Country { CountryId = "KOR", Name = "Korea" },
                new Country { CountryId = "OTHER", Name = "Other" },
                new Country { CountryId = "AUS", Name = "Australia"},
                new Country { CountryId = "MEX", Name = "MEX"},
                new Country { CountryId = "UK", Name = "United Kingdom"}
            );

            _ = modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 8,
                    Firstname = "Bruce",
                    Lastname = "Wayne",
                    Address = "Bloor 87",
                    City = "Toronto",
                    Province = "Ontario",
                    Postalcode = "M4A Y2Y",
                    Email = "afafa82@gmail.com",
                    Phone = "416-123-4567",
                    CountryId = "CAD"
                },
                new Customer
                {
                    CustomerId = 15,
                    Firstname = "Youngil",
                    Lastname = "Kim",
                    Address = "Sariro 52",
                    City = "Seoul",
                    Province = "Seoul",
                    Postalcode = "213566",
                    Email = "afafa1234@gmail.com",
                    Phone = "647-689-5682",
                    CountryId = "KOR"
                },
                new Customer
                {
                    CustomerId = 10,
                    Firstname = "Haley",
                    Lastname = "Lee",
                    Address = "Query 58",
                    City = "Mexico City",
                    Province = "State of Mexico",
                    Postalcode = "H3E Y2H",
                    Email = "hana25@gmail.com",
                    Phone = "263-589-1254",
                    CountryId = "MAX"
                },
                new Customer
                {
                    CustomerId = 5,
                    Firstname = "Kelly",
                    Lastname = "Doll",
                    Address = "Bont 81",
                    City = "Tokyo",
                    Province = "Tokyo-to",
                    Postalcode = "215368",
                    Email = "kelly82@gmail.com",
                    Phone = "416-265-1478",
                    CountryId = "OTHER"
                },
                new Customer
                {
                    CustomerId = 13,
                    Firstname = "Payne",
                    Lastname = "Crue",
                    Address = "Bont 81",
                    City = "New York City",
                    Province = "New York",
                    Postalcode = "K9K H3M",
                    Email = "payne12@gmail.com",
                    Phone = "416-697-2145",
                    CountryId = "USA"
                }
            );
        }
    }
}
