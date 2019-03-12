using System;
using System.Linq;
using System.Linq.Expressions;

namespace PricingTool.DAL.Interfaces
{
    public interface IRepository<T>: IDisposable
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetActive();
        IQueryable<T> GetDeleted();
        T Get(long id);
        T Get(Expression<Func<T, bool>> predicate);
        void Add(T item);
        void Edit(T item);
        void Delete(int id);
        void Save();
    }
}
