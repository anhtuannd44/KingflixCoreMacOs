using System.ComponentModel.DataAnnotations;

namespace KingflixCore.Domain.Enums
{
    public enum VoucherFor
    {
        [Display(Name = "Bình thường")]
        Normal = 0,
        [Display(Name = "Hệ thống")]
        System = 1,
    }
}
