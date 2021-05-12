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

        public string VoucherId { get; set; }
        public string CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Voucher Voucher { get; set; }
    }
}