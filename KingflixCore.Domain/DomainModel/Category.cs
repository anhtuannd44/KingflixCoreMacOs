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
        public string CategoryId { get; set; }

        [Required(ErrorMessage = "Mục này không được để trống")]
        [StringLength(300)]
        [Display(Name = "Tên gói")]
        public string Name { get; set; }
        public TypeOfAccount TypeOfAccount { get; set; }
        public TypeOfCategory Type { get; set; } //Type Of Category: Netflix/Upsale/Orther
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string Details { get; set; }
        public string Service { get; set; }
        public string PromotionInfo { get; set; }
        public string Cover { get; set; }
        public int? DateOrderAccept { get; set; }
        public int? DaysGuarantee { get; set; }
        public string Guarantee { get; set; }
        public double GuaranteePrice { get; set; }
        public string Color { get; set; }
        public string ColorSecondary { get; set; }
        public string ColorShadow { get; set; }
        public Status Status { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Price> Prices { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual ICollection<VoucherCategory> VoucherCategories { get; set; }
    }
}