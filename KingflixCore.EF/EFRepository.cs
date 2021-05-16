using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using KingflixCore.EF.Interface;
using Microsoft.EntityFrameworkCore;

namespace KingflixCore.EF
{
    public class EFRepository<T> : IRepository<T>, IDisposable where T : class
    {
        private readonly AppDbContext _context;

        public EFRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(T entity)
        {
            await _context.AddAsync(entity);
        }
        public IQueryable<T> GetList(Expression<Func<T, bool>> predicate = null)
        {
            IQueryable<T> items = _context.Set<T>();
            if (predicate != null)
            {
                items = items.Where(predicate);
            }
            return items;
        }
        public IQueryable<T> GetList(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> items = _context.Set<T>();
            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties)
                {
                    items = items.Include(includeProperty);
                }
            }
            return items;
        }
        public IQueryable<T> GetList(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            return GetList(includeProperties).Where(predicate);
        }

        public async Task<T> FindByIdAsync(object id)
        {
            return await FindByIdAsync(id);
        }

        public void RemoveEntity(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public async Task RemoveByIdAsync(object id)
        {
            var entity = await FindByIdAsync(id);
            RemoveEntity(entity);
        }

        public void RemoveMultiple(List<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }
    }
}
