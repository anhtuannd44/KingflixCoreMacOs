using KingflixCore.Domain.DomainModel;
using KingflixCore.EF.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KingflixCore.EF.Configurations
{
    public class FlashSaleCategoryConfiguration : DbEntityConfiguration<FlashSaleCategory>
    {
        public override void Configure(EntityTypeBuilder<FlashSaleCategory> entity)
        {
            entity.HasKey(a => new { a.FlashSaleId, a.CategoryId, a.Month });
            entity.Property(a => a.FlashSaleId)
                .IsRequired();
            entity.Property(a => a.CategoryId)
                .IsRequired()
                .HasMaxLength(300);
            entity.Property(a => a.Month)
                .IsRequired();
            
            entity.HasOne(a => a.Price)
                .WithMany(a => a.FlashSaleCategories)
                .HasForeignKey(a => new {a.CategoryId, a.Month})
                .OnDelete(DeleteBehavior.Cascade);
            entity.HasOne(a => a.FlashSale)
                .WithMany(a => a.FlashSaleCategories)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}