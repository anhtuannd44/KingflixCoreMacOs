using KingflixCore.Domain.DomainModel;
using KingflixCore.EF.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KingflixCore.EF.Configurations
{
    public class FlashSaleConfiguration : DbEntityConfiguration<FlashSale>
    {
        public override void Configure(EntityTypeBuilder<FlashSale> entity)
        {
            entity.HasKey(a => a.Id);
            entity.Property(a => a.Id)
                .ValueGeneratedOnAdd();
            entity.Property(a => a.Title)
                .IsRequired();
            entity.Property(a => a.Cover)
                .IsRequired(false);
            entity.Property(a => a.TimeStart)
                .IsRequired();
            entity.Property(a => a.TimeEnd)
                .IsRequired();
        }
    }
}