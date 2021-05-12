using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using KingflixCore.Domain.Enums;

namespace KingflixCore.Domain.DomainModel
{
    [Table("Voucher")]
    public partial class Voucher
    {
        public Voucher()
        {
            VoucherChilds = new HashSet<VoucherChild>();
            VoucherCategories = new HashSet<VoucherCategory>();
        }
        public string Id { get; set; }
        public string Title { get; set; }
        public string PolicyContent { get; set; }
        public double Value { get; set; }
        public double? MaxMoney { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public VoucherType Type { get; set; }
        public VoucherFor VoucherFor { get; set; }
        public Status Status { get; set; }
        public virtual ICollection<VoucherChild> VoucherChilds { get; set; }
        public virtual ICollection<VoucherCategory> VoucherCategories { get; set; }
    }
}