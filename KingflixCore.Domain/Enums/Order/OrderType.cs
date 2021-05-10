using System.ComponentModel.DataAnnotations;

namespace KingflixCore.Domain.Enums
{
    public enum OrderType
    {
        [Display(Name = "Order")]
        Order = 0,
        [Display(Name = "Extend")]
        Extend = 1,
        [Display(Name = "GiftCode")]
        GiftCode = 2,
    }
}
