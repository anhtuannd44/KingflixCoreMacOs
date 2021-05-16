using System;
using System.ComponentModel.DataAnnotations;
using KingflixCore.Domain.Enums;

namespace KingflixCore.Services.Models.Blog
{
    public class BlogViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập tiêu đề")]
        [Display(Name = "Tiêu đề")]
        public string Title { set; get; }
        [Display(Name = "Đường dẫn tĩnh")]
        public string Alias { set; get; }
        [Display(Name = "Hình Cover")]
        public string Cover { set; get; }
        [Display(Name = "Mô tả ngắn")]
        public string Description { set; get; }
        [Display(Name = "Nội dung")]
        public string Content { set; get; }
        [Display(Name = "Thời gian tạo")]
        public DateTime DateCreated { set; get; }
        [Display(Name = "Chỉnh sửa lần cuối")]
        private DateTime? DateModified { get; set; }
        [Display(Name = "Từ khóa SEO")]
        public string SeoKeywords { set; get; }
        [Display(Name = "Mô tả ngắn SEO")]
        public string SeoDescription { set; get; }
        [Display(Name = "Trạng thái")]
        public Status Status { set; get; }
        public int BlogCategoryId { get; set; }
        public virtual BlogCategoryViewModel BlogCategory { get; set; }
    }
}