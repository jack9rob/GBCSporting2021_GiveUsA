using Microsoft.Azure.Devices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GBCSporting2021_GiveUsA.Models.DataLayer
{
    public class Repository<T>: IRepository<T> where T : class
    {
        internal TechnicalSupportContext context;
        internal DbSet<T> dbset;

        public Repository(TechnicalSupportContext context)
        {
            this.context = context;
            this.dbset = context.Set<T>();
        }

        public virtual IEnumerable<T> Get(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<T> query = dbset;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }
        /*
        public virtual IEnumerable<T> List(QueryOptions<T> options)
        {
            IQueryable<T> query = dbset;
            foreach (string include in options.GetIncludes())
            {
                query = query.Include(include);
            }
            if (options.HasWhere)
                query = query.Where(options.Where);
            if (options.HasOrderBy)
                query = query.OrderBy(options.OrderBy);
            if (options.HasPaging)
                query = query.PageBy(options.PageNumber, options.PageSize);
            return query.ToList();
        }
        
        */
        public virtual T Get(int id) => dbset.Find(id);
        

        public virtual void Insert(T entity) => dbset.Add(entity);
       

        public virtual void Delete(T entity) => dbset.Remove(entity);

        public virtual void Update(T entity) => dbset.Update(entity);


        public virtual void Save() => context.SaveChanges();
    }
}
