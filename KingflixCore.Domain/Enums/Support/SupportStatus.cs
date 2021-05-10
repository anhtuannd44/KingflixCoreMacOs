using System.ComponentModel.DataAnnotations;

namespace KingflixCore.Domain.Enums
{
    public enum SupportStatus
    {
        [Display(Name = "Hoàn tất")]
        Success = 0,
        [Display(Name = "Đang xử lý")]
        Pending = 1,
        [Display(Name = "Đã hủy")]
        Cancel = 2
    }
}
