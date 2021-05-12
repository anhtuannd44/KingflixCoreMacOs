using System.ComponentModel.DataAnnotations;

namespace KingflixCore.Domain.Enums
{
    public enum PaymentType
    {
        [Display(Name = "Ví Bảo Kim API")]
        BaoKim = 0,
        [Display(Name = "ATM các thẻ ngân hàng API")]
        InternetBanking = 1,
        [Display(Name = "Visa/MasterCard API")]
        Visa = 2,
        [Display(Name = "QR Code API")]
        QRCode = 3,
        [Display(Name = "QR Ví điện tử API")]
        QRVidientu = 4,
        [Display(Name = "Card API")]
        Card = 5,
        [Display(Name = "Ví điện tử (Thủ công)")]
        EWallet = 6,
        [Display(Name = "Chuyển khoản (Thủ công)")]
        Bank = 7,
        [Display(Name = "Khác")]
        Other = 8
    }
}
