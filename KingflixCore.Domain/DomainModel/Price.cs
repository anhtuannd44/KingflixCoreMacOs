using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KingflixCore.Domain.DomainModel
{
    [Table("Price")]
    public class Price
    {

        public Price()
        {
            FlashSaleCategories = new HashSet<FlashSaleCategory>();
        }

        [Key]
        [Column(Order = 0)]
        public string CategoryId { get; set; }

        [Key]
        [Column(Order = 1)]
        public double Month { get; set; }

        //Giá gốc
        public double OrigPrice { get; set; }

        //Giá khuyến mãi (bé hơn giá gốc)
        public double? PromotionPrice { get; set; }

        public string TextFixed { get; set; }

        public bool IsShow { get; set; }

        public virtual Category Categories { get; set; }

        [NotMapped]
        public double? PercentSale
        {
            get
            {
                return PromotionPrice ?? Math.Round(100 - PromotionPrice.Value / OrigPrice * 100);
            }
        }
        public virtual ICollection<FlashSaleCategory> FlashSaleCategories { get; set; }
    }
}