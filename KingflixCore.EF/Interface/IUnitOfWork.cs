// 14
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace KingflixCore.EF.Interface
{
    public interface IRepository<T, K> where T : class
    {
        Task<T> FindByIdAsync(K id, params Expression<Func<T, object>>[] includeProperties);

        Task<T> FindSingleAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

        IQueryable<T> FindAll(params Expression<Func<T, object>>[] includeProperties);

        IQueryable<T> FindAll(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

        Task AddAsync(T entity);

        void Update(T entity);

        void RemoveEntity(T entity);

        Task RemoveByIdAsync(K id);

        void RemoveMultiple(List<T> entities);
    }
}
