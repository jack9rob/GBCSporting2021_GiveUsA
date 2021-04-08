using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Models.DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private TechnicalSupportContext context;
        private Repository<Customer> customerRepository;
        private Repository<Incident> incidentRepository;
        private Repository<Product> productRepository;
        private Repository<Registration> registrationRepository;
        private Repository<Technician> technicianRepository;
        private Repository<Country> countryRepository;

        public UnitOfWork(TechnicalSupportContext ctx)
        {
            this.context = ctx;
        }

        public Repository<Customer> CustomerRepository
        {
            get
            {
                if (this.customerRepository == null)
                {
                    this.customerRepository = new Repository<Customer>(context);
                }
                return customerRepository;
            }
        }

        public Repository<Incident> IncidentRepository
        {
            get
            {

                if (this.incidentRepository == null)
                {
                    this.incidentRepository = new Repository<Incident>(context);
                }
                return incidentRepository;
            }
        }

        public Repository<Product> ProductRepository
        {
            get
            {

                if (this.productRepository == null)
                {
                    this.productRepository = new Repository<Product>(context);
                }
                return productRepository;
            }
        }

        public Repository<Registration> RegistrationRepository
        {
            get
            {

                if (this.registrationRepository == null)
                {
                    this.registrationRepository = new Repository<Registration>(context);
                }
                return registrationRepository;
            }
        }

        public Repository<Technician> TechnicianRepository
        {
            get
            {
                if (this.technicianRepository == null)
                {
                    this.technicianRepository = new Repository<Technician>(context);
                }
                return technicianRepository;
            }
        }

        public Repository<Country> CountryRepository
        {
            get
            {
                if (this.countryRepository == null)
                {
                    this.countryRepository = new Repository<Country>(context);
                }
                return countryRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
