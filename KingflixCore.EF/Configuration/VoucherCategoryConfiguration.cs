using KingflixCore.Domain.DomainModel;
using KingflixCore.EF.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KingflixCore.EF.Configurations
{
    public class VoucherCategoryConfiguration : DbEntityConfiguration<VoucherCategory>
    {
        public override void Configure(EntityTypeBuilder<VoucherCategory> entity)
        {
            entity.HasKey(a => new { a.VoucherId, a.CategoryId});

            entity.HasOne(a => a.Category)
                .WithMany(a => a.VoucherCategories)
                .HasForeignKey(a => a.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
            entity.HasOne(a => a.Voucher)
                .WithMany(a => a.VoucherCategories)
                .HasForeignKey(a => a.VoucherId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}