using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace KingflixCore.EF.Interface
{
    public interface IRepository<T> where T : class
    {
        Task<T> FindByIdAsync(object id);
        IQueryable<T> GetList(Expression<Func<T, bool>> predicate = null);

        IQueryable<T> GetList(params Expression<Func<T, object>>[] includeProperties);
        IQueryable<T> GetList(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);

        Task AddAsync(T entity);

        void Update(T entity);

        void RemoveEntity(T entity);

        Task RemoveByIdAsync(object id);

        void RemoveMultiple(List<T> entities);
    }
}
