// 24
using System;
using System.ComponentModel.DataAnnotations;

namespace KingflixCore.Web.Models.AccountViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Bạn chưa nhập Họ và Tên")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Chưa đúng định dạng Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập mật khẩu")]
        [DataType(DataType.Password, ErrorMessage = "Chưa đúng định dạng mật khẩu")]
        [Display(Name = "Mật khẩu")]
        public string Password { get; set; }

        [Display(Name = "Ghi nhớ đăng nhập")]
        public bool RememberMe { get; set; }
    }
}
