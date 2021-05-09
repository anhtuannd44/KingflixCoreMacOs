// 52
using System.ComponentModel.DataAnnotations;

namespace KingflixCore.Web.Models.AccountViewModel
{
    public class LoginWith2faViewModel
    {
        [Required]
        [StringLength(7, ErrorMessage = "{0} phải từ {2} đến {1} ký tự.", MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "Authenticator code")]
        public string TwoFactorCode { get; set; }

        [Display(Name = "Ghi nhớ thiết bị này")]
        public bool RememberMachine { get; set; }

        public bool RememberMe { get; set; }
    }
}
