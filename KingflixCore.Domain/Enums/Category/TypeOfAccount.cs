using System.ComponentModel.DataAnnotations;

namespace KingflixCore.Domain.Enums
{
    public enum TypeOfAccount
    {
        [Display(Name = "Cung cấp tài khoản")]
        KingflixAccount = 0,
        [Display(Name = "Tài khoản khách")]
        UserAccount = 1,

    }
}
