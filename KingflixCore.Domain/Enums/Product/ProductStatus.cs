using System.ComponentModel.DataAnnotations;

namespace KingflixCore.Domain.Enums
{
    public enum ProductStatus
    {
        [Display(Name = "Đang hoạt động")]
        Active = 0,
        [Display(Name = "Chưa hoạt động")]
        Private = 1,
        [Display(Name = "Tài khoản thay thế")]
        Replace = 2
    }
}
