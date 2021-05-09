// 13
using System;
using System.ComponentModel.DataAnnotations;

namespace KingflixCore.Web.Models.AccountViewModel
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Họ và tên không được để trống", AllowEmptyStrings = false)]
        [Display(Name = "Họ và Tên")]
        public string FullName { set; get; }

        [Display(Name = "Ngày sinh")]
        public DateTime? BirthDay { set; get; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} phải từ {2} đến {1} ký tự.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Xác nhận mật khẩu")]
        [Compare("Password", ErrorMessage = "Xác nhận mật khẩu chưa khớp.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }

        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { set; get; }

        [Display(Name = "Hình đại diện")]
        public string Avatar { get; set; }
    }
}
