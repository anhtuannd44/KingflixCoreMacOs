using System.Threading.Tasks;
using KingflixCore.EF.Interface;

namespace KingflixCore.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public EFUnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
