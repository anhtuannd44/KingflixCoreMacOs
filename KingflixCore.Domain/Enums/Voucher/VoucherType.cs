using System.ComponentModel.DataAnnotations;

namespace KingflixCore.Domain.Enums
{
    public enum VoucherType
    {
        [Display(Name = "Giảm số tiền (VNĐ)")]
        Money = 0,
        [Display(Name = "Giảm phần trăm (%)")]
        Percent = 1,
        [Display(Name = "Cả 2")]
        Both = 2,
    }
}
