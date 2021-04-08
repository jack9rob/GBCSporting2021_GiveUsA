using GBCSporting2021_GiveUsA.Models.SeedData;
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
        public DbSet<Registration> Registrations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedCountry();
            modelBuilder.Seed();            
        }
    }
}
