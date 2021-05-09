// 12
using System;
using System.ComponentModel.DataAnnotations;

namespace KingflixCore.Web.Models.AccountViewModel
{
    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "Bạn chưa nhập Email")]
        [EmailAddress(ErrorMessage = "Định dạng Email chưa đúng")]
        public string Email { get; set; }
    }
}
