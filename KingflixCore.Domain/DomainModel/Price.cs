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
        public string CategoryId { get; set; }
        public double Month { get; set; }
        public double OrigPrice { get; set; }
        public double? PromotionPrice { get; set; }
        public string TextFixed { get; set; }
        public bool IsShow { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<FlashSaleCategory> FlashSaleCategories { get; set; }
    }
}