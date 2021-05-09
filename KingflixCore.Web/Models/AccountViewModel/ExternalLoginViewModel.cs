// 3
using System;
using System.ComponentModel.DataAnnotations;

namespace KingflixCore.Web.Models.AccountViewModel
{
    public class ExternalLoginViewModel
    {
        [Required(ErrorMessage = "Bạn chưa nhập Họ và tên")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Bạn chưa chọn ngày sinh")]
        public string DOB { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập Số điện thoại")]
        public string PhoneNumber { get; set; }
    }
}
