using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
               new Customer
               {
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
                   Email = "youngil@gmail.com",
                   Phone = "123-456-7899",
                   CountryId = "AUS"
               },
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
                   CountryId = "MEX"
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


            modelBuilder.Entity<Technician>().HasData(
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
            modelBuilder.Entity<Incident>().HasData(
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
