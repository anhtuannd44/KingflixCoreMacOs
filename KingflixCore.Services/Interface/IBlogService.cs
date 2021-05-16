using System.Collections.Generic;
using System.Threading.Tasks;
using KingflixCore.Domain.Enums;
using KingflixCore.Services.Models.Blog;
using KingflixCore.Utilities.DTOs;

namespace KingflixCore.Services.Interface
{
    public interface IBlogService
    {
        Task AddAsync(BlogViewModel blog);
        Task UpdateAsync(BlogViewModel blog);
        Task RemoveAsync(int id);
        Task<BlogViewModel> GetByIdAsync(int id);
        Task<BlogViewModel> GetByAliasAsync(string alias);
        Task<List<BlogViewModel>> GetListAsync(Status? status = null);
        Task<PagedResult<BlogViewModel>> GetAllPagingAsync(int? categoryId, string keyword, int page, int pageSize);
    }
}