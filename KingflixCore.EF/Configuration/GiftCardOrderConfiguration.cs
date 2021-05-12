using KingflixCore.Domain.DomainModel;
using KingflixCore.EF.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KingflixCore.EF.Configurations
{
    public class GiftCardOrderConfiguration : DbEntityConfiguration<GiftCardOrder>
    {
        public override void Configure(EntityTypeBuilder<GiftCardOrder> entity)
        {
            entity.HasKey(a => a.Id);
            entity.Property(a => a.Id)
                .IsRequired();

            entity.HasOne(a => a.Order)
                .WithOne(a => a.GiftCardOrder)
                .HasForeignKey<GiftCardOrder>(a => a.Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}