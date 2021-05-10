using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KingflixCore.Domain.DomainModel
{
    [Table("VoucherCategory")]
    public partial class VoucherCategory
    {
        public VoucherCategory()
        {

        }

        [Key, Column(Order = 0)]
        public string VoucherId { get; set; }

        [Key, Column(Order = 1)]
        public string CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Voucher Voucher { get; set; }
    }
}