using KingflixCore.Domain.DomainModel;
using KingflixCore.EF.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KingflixCore.EF.Configurations
{
    public class PaymentConfiguration : DbEntityConfiguration<Payment>
    {
        public override void Configure(EntityTypeBuilder<Payment> entity)
        {
            entity.HasKey(a => a.Id);
            entity.Property(a => a.Id)
                .ValueGeneratedOnAdd();
            entity.Property(a => a.Cover)
                .HasMaxLength(1000)
                .IsRequired(false);
            entity.Property(a => a.QRImage)
                .HasMaxLength(1000)
                .IsRequired(false);
            entity.Property(a => a.Status)
                .IsRequired();
            
        }
    }
}