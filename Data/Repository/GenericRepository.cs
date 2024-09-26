using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly DatabaseContext DBContext;

        public GenericRepository(DatabaseContext DBContext)
        {
            this.DBContext = DBContext;
        }
        
        public T Add(T entity)
        {

            var newentity = DBContext.Add(entity);
            return newentity.Entity;
        }

        public IList<T> All(string[] includes = null)
        {
            IQueryable<T> query = DBContext.Set<T>();

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            return query.ToList();
        }

        public T? Get(Expression<Func<T, bool>> match, string[] includes = null)
        {
            IQueryable<T> query = DBContext.Set<T>();
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }
            return query.SingleOrDefault(match);
        }


        public T Update(T entity)
        {
            return DBContext.Update(entity).Entity;
        }

        public void SaveChange()
        {
            DBContext.SaveChanges();
        }

    }
}
