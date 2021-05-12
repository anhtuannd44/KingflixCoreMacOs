using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KingflixCore.Domain.DomainModel
{
    [Table("FlashSale")]
    public class FlashSale
    {
        public FlashSale()
        {
            FlashSaleCategories = new HashSet<FlashSaleCategory>();
        }
        public string Id { get; set; }
        public string Title { get; set; }
        public string Cover { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public virtual ICollection<FlashSaleCategory> FlashSaleCategories { get; set; }
    }
}