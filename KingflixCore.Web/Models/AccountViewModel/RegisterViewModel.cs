using System;
using System.ComponentModel.DataAnnotations;

namespace KingflixCore.Web.Models.AccountViewModel
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Họ và tên không được để trống", AllowEmptyStrings = false)]
        [Display(Name = "Họ và Tên")]
        public string FullName { set; get; }

        [Required(ErrorMessage = "Bạn chưa nhập Email")]
        [EmailAddress(ErrorMessage = "Chưa đúng định dạng Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập mật khẩu")]
        [MinLength(6, ErrorMessage = "{0} phải từ {1} ký tự trở lên")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Xác nhận mật khẩu")]
        [Required(ErrorMessage = "Bạn chưa xác nhận mật khẩu")]
        [Compare("Password", ErrorMessage = "Xác nhận mật khẩu chưa khớp")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Bạn chưa nhập số điện thoại")]
        [RegularExpression(@"(84|0[3|5|7|8|9])+([0-9]{8})\b", ErrorMessage = "Số điện thoại không đúng")]
        [DataType(DataType.Text)]
        public string PhoneNumber { set; get; }
    }
}
