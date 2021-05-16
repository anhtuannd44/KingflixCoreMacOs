using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using KingflixCore.Domain.Enums;

namespace KingflixCore.Services.Models.Blog
{
    public class BlogCategoryViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập tiêu đề")]
        [Display(Name = "Tiêu đề")]
        public string Title { set; get; }
        [Display(Name = "Đường dẫn tĩnh")]
        public string Alias { set; get; }
        [Display(Name = "Ngày khởi tạo")]
        public DateTime DateCreated { set; get; }
        [Display(Name = "Chỉnh sửa lần cuối")]
        public DateTime? DateModified { set; get; }
        [Display(Name = "Từ khóa SEO, cách nhau bằng dấu phẩy")]
        public string SeoKeywords { set; get; }
        [Display(Name = "Mô tả ngắn SEO")]
        public string SeoDescription { set; get; }
        [Display(Name = "Trạng thái")]
        public Status Status { get; set; }
        public virtual ICollection<BlogViewModel> Blogs { set; get; }
    }
}