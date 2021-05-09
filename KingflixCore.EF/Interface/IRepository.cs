// 14
using System;
using System.Threading.Tasks;

namespace KingflixCore.EF.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Call save change from db context
        /// </summary>
        Task SaveChangeAsync();
    }
}
