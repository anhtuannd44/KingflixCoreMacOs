using KingflixCore.Domain.DomainModel;
using KingflixCore.EF.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KingflixCore.EF.Configurations
{
    public class PriceConfiguration : DbEntityConfiguration<Price>
    {
        public override void Configure(EntityTypeBuilder<Price> entity)
        {
            entity.HasKey(a => new { a.CategoryId, a.Month });
            entity.Property(a => a.CategoryId)
                .IsRequired()
                .HasMaxLength(300);
            entity.Property(a => a.Month)
                .IsRequired();
            entity.Property(a => a.OrigPrice)
                .IsRequired();
            entity.Property(a => a.PromotionPrice)
                .IsRequired(false);
            entity.Property(a => a.TextFixed)
                .IsRequired(false);
            entity.Property(a => a.IsShow)
                .IsRequired();

            entity.HasOne(a => a.Category)
                .WithMany(a => a.Prices)
                .HasForeignKey(a => a.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}