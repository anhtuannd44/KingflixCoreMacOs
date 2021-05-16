using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KingflixCore.Services.Interface;

namespace KingflixCore.Areas.Admin.Controllers
{
    public class BlogController : AdminBaseController
    {
        private readonly ILogger<BlogController> _logger;
        private readonly IBlogService _blogService;

        public BlogController(ILogger<BlogController> logger,
            IBlogService blogService
        )
        {
            _logger = logger;
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAll()
        {
            var model = _blogService.GetListAsync();
            return new OkObjectResult(model);
        }
        [HttpGet]
        public IActionResult GetAllPaging(int? categoryId, string keyword, int page, int pageSize)
        {
            var model = _blogService.GetAllPagingAsync(categoryId, keyword, page, pageSize);
            return new OkObjectResult(model);
        }
    }
}
