using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Models
{
    public class UnitOfWork : IDisposable
    {
        private TechnicalSupportContext context;
        private GenericRepository<Customer> customerRepository;
        private GenericRepository<Incident> incidentRepository;
        private GenericRepository<Product> productRepository;
        private GenericRepository<Registration> registrationRepository;
        private GenericRepository<Technician> technicianRepository;
        private GenericRepository<Country> countryRepository;

        public UnitOfWork(TechnicalSupportContext ctx)
        {
            this.context = ctx;
        }

        public GenericRepository<Customer> CustomerRepository
        {
            get
            {

                if (this.customerRepository == null)
                {
                    this.customerRepository = new GenericRepository<Customer>(context);
                }
                return customerRepository;
            }
        }

        public GenericRepository<Incident> IncidentRepository
        {
            get
            {

                if (this.incidentRepository == null)
                {
                    this.incidentRepository = new GenericRepository<Incident>(context);
                }
                return incidentRepository;
            }
        }

        public GenericRepository<Product> ProductRepository
        {
            get
            {

                if (this.productRepository == null)
                {
                    this.productRepository = new GenericRepository<Product>(context);
                }
                return productRepository;
            }
        }

        public GenericRepository<Registration> RegistrationRepository
        {
            get
            {

                if (this.registrationRepository == null)
                {
                    this.registrationRepository = new GenericRepository<Registration>(context);
                }
                return registrationRepository;
            }
        }

        public GenericRepository<Technician> TechnicianRepository
        {
            get
            {

                if (this.technicianRepository == null)
                {
                    this.technicianRepository = new GenericRepository<Technician>(context);
                }
                return technicianRepository;
            }
        }

        public GenericRepository<Country> CountryRepository
        {
            get
            {

                if (this.countryRepository == null)
                {
                    this.countryRepository = new GenericRepository<Country>(context);
                }
                return countryRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
