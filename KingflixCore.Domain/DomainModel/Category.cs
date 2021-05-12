using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KingflixCore.Domain.Enums;

namespace KingflixCore.Domain.DomainModel
{
    [Table("Category")]
        public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
            Prices = new HashSet<Price>();
            OrderDetails = new HashSet<OrderDetails>();
            VoucherCategories = new HashSet<VoucherCategory>();
        }

        [Key]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Alias { get; set; }
        public TypeOfAccount ProductType { get; set; }
        public TypeOfCategory CategoryType { get; set; } //Type Of Category: Netflix/Upsale/Other
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string Details { get; set; }
        public string ServiceInfo { get; set; }
        public string PromotionInfo { get; set; }
        public string Cover { get; set; }
        public int? DateOrderAccept { get; set; }
        public int? DaysGuarantee { get; set; }
        public string GuaranteeInfo { get; set; }
        public double GuaranteePrice { get; set; }
        public string Color { get; set; }
        public string ColorHover { get; set; }
        public string ColorShadow { get; set; }
        public Status Status { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Price> Prices { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual ICollection<VoucherCategory> VoucherCategories { get; set; }
    }
}