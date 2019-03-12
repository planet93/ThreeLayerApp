using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Phoenix.Domain.Model.Base;
using PricingTool.DAL.Context;
using PricingTool.DAL.Interfaces;


namespace PricingTool.DAL.Repositories
{
    public class Repository<T>: IRepository<T> where T : BaseEntity
    {
        private readonly DataContext _db;
        private readonly DbSet<T> _dbSet;
        private bool _disposed;
        public Repository(DataContext db = null)
        {
            if (db == null)
            {
                db = new DataContext();
            }
            else
            {
                _db = db;
            }

            _dbSet = db.Set<T>();
        }
        /// <inheritdoc />
        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }
        public IQueryable<T> GetActive()
        {
            return GetAll().Where(s => s.Active);
        }
        public IQueryable<T> GetDeleted()
        {
            return GetAll().Where(s => s.Deleted);
        }
        public T Get(long id)
        {
            return id == 0 ? null : GetAll().FirstOrDefault(s => s.Id == id);
        }
        /// <inheritdoc />
        public T Get(Expression<Func<T, bool>> predicate)
        {
            return GetAll().FirstOrDefault(predicate);
        }
        /// <inheritdoc />
        public void Add(T item)
        {
            _dbSet.Add(item);
        }
        /// <inheritdoc />
        public void Edit(T item)
        {
            _db.Entry(item).State = EntityState.Modified;
        }
        /// <inheritdoc />
        public void Delete(int id)
        {
            var item = Get(id);
            if (item == null) return;
            item.Deleted = true;
            Edit(item);
        }

        public void Drop(T item)
        {
            _db.Entry(item).State = EntityState.Deleted;
        }
        /// <inheritdoc />
        public void Save()
        {
            _db.SaveChanges();
        }
        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            _disposed = true;
        }
        /// <inheritdoc />
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~Repository()
        {
            Dispose(false);
        }
    }
}
