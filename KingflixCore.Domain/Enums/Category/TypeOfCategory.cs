using System.ComponentModel.DataAnnotations;

namespace KingflixCore.Domain.Enums
{
    public enum TypeOfCategory
    {
        [Display(Name = "NETFLIX")]
        Netflix = 0,
        [Display(Name = "Bán kèm Netflix")]
        Upsale = 1,
        [Display(Name = "Khác")]
        Orther = 2,
    }
}
