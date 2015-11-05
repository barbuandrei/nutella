using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_learning.Infrastructure
{
    public class UnitOfWork<TContext> where TContext : DbContext, new()
    {
        private readonly DbContext _ctx;
        private readonly Dictionary<Type, object> _repositories;
        private bool _disposed;

        public UnitOfWork()
        {
            _ctx = new TContext();
            _repositories = new Dictionary<Type, object>();
            _disposed = false;
        }

        public GenericRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if (_repositories.Keys.Contains(typeof(TEntity)))
                return _repositories[typeof(TEntity)] as GenericRepository<TEntity>;

            var repository = new GenericRepository<TEntity>(_ctx);
            _repositories.Add(typeof(TEntity), repository);
            return repository;
        }

        public void Save()
        {
            _ctx.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _ctx.Dispose();
                }

                this._disposed = true;
            }
        }
    }
}