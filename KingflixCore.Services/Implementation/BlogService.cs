using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using KingflixCore.Domain.DomainModel;
using KingflixCore.Domain.Enums;
using KingflixCore.EF.Interface;
using KingflixCore.Services.Interface;
using KingflixCore.Services.Models.Blog;
using KingflixCore.Utilities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace KingflixCore.Services.Implementation
{
    public class BlogService : IBlogService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Blog> _blogRepository;
        private readonly IRepository<BlogCategory> _blogCategoryRepository;
        private readonly IUnitOfWork _unitOfWork;
        public BlogService(
                IMapper mapper,
                IRepository<Blog> blogRepository,
                IRepository<BlogCategory> blogCategoryRepository,
                IUnitOfWork unitOfWork
            )
        {
            _mapper = mapper;
            _blogRepository = blogRepository;
            _blogCategoryRepository = blogCategoryRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task AddAsync(BlogViewModel blog)
        {
            var item = _mapper.Map<BlogViewModel, Blog>(blog);
            await _blogRepository.AddAsync(item);
        }
        public async Task UpdateAsync(BlogViewModel blog)
        {
            var item = _mapper.Map<BlogViewModel, Blog>(blog);
            _blogRepository.Update(item);
            await _unitOfWork.SaveChangesAsync();
        }
        public async Task RemoveAsync(int id)
        {
            await _blogRepository.RemoveByIdAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }
        public async Task<BlogViewModel> GetByIdAsync(int id)
        {
            return _mapper.Map<Blog, BlogViewModel>(await _blogRepository.FindByIdAsync(id));
        }
        public async Task<BlogViewModel> GetByAliasAsync(string alias)
        {
            var item = await _blogRepository.GetList(a => a.Alias == alias, b => b.BlogCategory).FirstOrDefaultAsync();
            return _mapper.Map<Blog, BlogViewModel>(item);
        }
        public async Task<List<BlogViewModel>> GetListAsync(Status? status = null)
        {
            Expression<Func<Blog, bool>> whereProperties = null;
            if (status != null)
            {
                whereProperties = a => a.Status == status;
            }
            var items = _blogRepository.GetList(whereProperties, a=>a.BlogCategory).AsQueryable();
            return await _mapper.ProjectTo<BlogViewModel>(items).ToListAsync();
        }
        public async Task<PagedResult<BlogViewModel>> GetAllPagingAsync(int? categoryId, string keyword, int page, int pageSize)
        {
            var query = _blogRepository.GetList();
            if (!string.IsNullOrEmpty(keyword))
                query = query.Where(x => x.Title.Contains(keyword));

            int totalRow = query.Count();
            var data = query.OrderByDescending(x => x.DateCreated)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            var paginationSet = new PagedResult<BlogViewModel>()
            {
                Results = await _mapper.ProjectTo<BlogViewModel>(data).ToListAsync(),
                CurrentPage = page,
                RowCount = totalRow,
                PageSize = pageSize,
            };

            return paginationSet;
        }
    }
}