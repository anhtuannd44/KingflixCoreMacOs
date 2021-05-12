using System.ComponentModel.DataAnnotations;

namespace KingflixCore.Domain.Enums
{
    public enum OrderStatus
    {
        [Display(Name = "Hoàn tất")]
        Done = 0,

        [Display(Name = "Chưa thanh toán")]
        WaitingForPay = 1,

        [Display(Name = "Đã xác nhận")]
        Confirmed = 2,

        [Display(Name = "Đã hủy")]
        Cancelled = 3,
    }
}
