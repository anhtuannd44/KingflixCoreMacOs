using System.ComponentModel.DataAnnotations;

namespace KingflixCore.Domain.Enums
{
    public enum OrderStatus
    {
        [Display(Name = "Hoàn tất")]
        Done = 0,
        [Display(Name = "Chưa thanh toán")]
        WaitingForPay = 1,
        [Display(Name = "Đang xử lý")]
        Paid = 2,
        [Display(Name = "Đã hủy")]
        Cancelled = 3,
    }
}
