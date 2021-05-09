// 6
using System;
using System.ComponentModel.DataAnnotations;

namespace KingflixCore.Web.Models.AccountViewModel
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Bạn chưa nhập Email")]
        [EmailAddress(ErrorMessage = "Định dạng Email chưa đúng")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập Mật khẩu")]
        [StringLength(100, ErrorMessage = "{0} phải từ {2} đến {1} ký tự.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Xác nhận Mật khẩu")]
        [Compare("Password", ErrorMessage = "Xác nhận Mật khẩu chưa chính xác.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }
}
