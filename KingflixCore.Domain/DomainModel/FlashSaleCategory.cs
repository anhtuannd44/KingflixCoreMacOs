using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KingflixCore.Domain.DomainModel
{
    [Table("FlashSaleCategory")]
    public class FlashSaleCategory
    {
        public FlashSaleCategory()
        {

        }

        [Key]
        [Column(Order = 0)]
        public int FlashSaleId { get; set; }
        [Key]
        [Column(Order = 1)]
        public string CategoryId { get; set; }
        [Key]
        [Column(Order = 2)]
        public double Month { get; set; }
        [Required]
        public double PriceSale { get; set; }

        public virtual Price Price { get; set; }
        public virtual FlashSale FlashSale { get; set; }

    }
}