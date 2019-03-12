﻿using PricingTool.DAL.Context;
using PricingTool.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingTool.DAL.Repositories
{
    public class UnitOfWork : IDisposable
    {
        private bool _disposed;
        private readonly DataContext _db;
        private Repository<ClassifierType> _classifierType;
        private Repository<Classifier> _classifier;
        public UnitOfWork(DataContext db = null)
        {
            _db = db ?? new DataContext();
        }
        public Repository<ClassifierType> ClassifierType => _classifierType ?? (_classifierType = new Repository<ClassifierType>(_db));
        public Repository<Classifier> Classifier => _classifier ?? (_classifier = new Repository<Classifier>(_db));

        #region Dispose
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {

                _classifierType?.Dispose();
                _classifier?.Dispose();

                _db?.Dispose();

            }

            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~UnitOfWork()
        {
            Dispose(false);
        }
        #endregion
    }
}
