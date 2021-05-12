using KingflixCore.Domain.DomainModel;
using KingflixCore.EF.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KingflixCore.EF.Configurations
{
    public class VoucherConfiguration : DbEntityConfiguration<Voucher>
    {
        public override void Configure(EntityTypeBuilder<Voucher> entity)
        {
            entity.HasKey(a => a.Id);
            entity.Property(a => a.Id)
                .HasMaxLength(50)
                .IsRequired();
            entity.Property(a => a.Title)
                .HasMaxLength(500)
                .IsRequired(true);
            entity.Property(a => a.PolicyContent)
                .IsRequired();
            entity.Property(a => a.Value)
                .IsRequired();
            entity.Property(a => a.MaxMoney)
                .IsRequired(false);
            entity.Property(a => a.DateCreated)
                .IsRequired();
            entity.Property(a => a.DateEnd)
                .IsRequired();
            entity.Property(a => a.DateModified)
                .IsRequired();
            entity.Property(a => a.Type)
                .IsRequired();
            entity.Property(a => a.VoucherFor)
                .IsRequired();
            entity.Property(a => a.Status)
                .IsRequired();
        }
    }
}