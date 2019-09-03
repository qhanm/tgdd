using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TGDD.Infrastructure.Interfaces;
using TGDD.Infrastructure.SharedKernel;

namespace TGDD.Data.EF
{
    public class EFRepositoty<T, K> : IReponsitory<T, K>, IDisposable where T : DomainEntity<K> 
    {
        private readonly AppDbContext _context;

        public EFRepositoty(AppDbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
        }

        public void Dispose()
        {
            if(_context != null)
            {
                _context.Dispose();
            }
        }

        public IQueryable<T> FindAll(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> items = _context.Set<T>();

            if(includeProperties != null)
            {
                foreach(var include in includeProperties)
                {
                    items = items.Include(include);
                }
            }

            return items;

        }

        public IQueryable<T> FindAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> items = _context.Set<T>();

            if(includeProperties != null)
            {
                foreach (var include in includeProperties)
                {
                    items = items.Include(include);
                }
            }

            return items.Where(predicate);
        }

        public T FindById(K id, params Expression<Func<T, object>>[] includeProperties)
        {
            return FindAll(includeProperties).SingleOrDefault(x => x.Id.Equals(id));
        }

        public T FindSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            return FindAll(includeProperties).SingleOrDefault(predicate);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Remove(K id)
        {
            var entity = FindById(id);
            Remove(entity);
        }

        public void RemoveMultiple(List<T> entity)
        {
            _context.Set<T>().RemoveRange(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
