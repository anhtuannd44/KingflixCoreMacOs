using System.ComponentModel.DataAnnotations;

namespace KingflixCore.Domain.Enums
{
    public enum Cycle
    {
        [Display(Name = "King (Chu kỳ 1)")]
        King = 0,
        [Display(Name = "Avenger (Chu kỳ 2)")]
        Avenger = 1,
        [Display(Name = "Mouse (Chu kỳ 3)")]
        Mouse = 2,
    }
}
