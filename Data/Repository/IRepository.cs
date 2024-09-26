using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public interface IRepository<T>
    {
        T Add(T entity);
        T Update(T entity);
        T? Get(Expression<Func<T, bool>> match, string[] includes = null);
        IList<T> All(string[] includes = null);
        void SaveChange();
    }
}
