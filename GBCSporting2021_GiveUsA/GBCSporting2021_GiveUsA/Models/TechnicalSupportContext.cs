using GBCSporting2021_GiveUsA.Models.Config;
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

            modelBuilder.ApplyConfiguration(new CountryConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new IncidentConfig());
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new TechnicianConfig());
        }
    }
}
