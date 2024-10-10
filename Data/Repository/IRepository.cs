using System.Linq.Expressions;

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