using KingflixCore.Domain.DomainModel;
using KingflixCore.EF.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KingflixCore.EF.Configurations
{
    public class OrderConfiguration : DbEntityConfiguration<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> entity)
        {
            entity.HasKey(a => a.Id);
            entity.Property(a => a.Id)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(a => a.ApiOrderId)
                .IsRequired(false);
            entity.Property(a => a.DateConfirm)
                .IsRequired(false);
            entity.Property(a => a.DateCreated)
                .IsRequired();
            entity.Property(a => a.DateModified)
                .IsRequired(false);
            entity.Property(a => a.Total)
                .IsRequired();
            entity.Property(a => a.ImageConfirmPayment)
                .HasMaxLength(1000)
                .IsRequired(false);
            entity.Property(a => a.Type)
                .IsRequired();
            entity.Property(a => a.VoucherId)
                .IsRequired(false);
            entity.Property(a => a.UserId)
                .IsRequired(false);
            entity.Property(a => a.PaymentId)
                .IsRequired(false);
            entity.Property(a => a.UserUseGiftCode)
                .IsRequired(false);
            entity.Property(a => a.Status)
                .IsRequired();

            entity.HasOne(a => a.Payment)
                .WithMany(a => a.Orders)
                .HasForeignKey(a => a.PaymentId)
                .OnDelete(DeleteBehavior.SetNull);
            entity.HasOne(a => a.UserOrdered)
                .WithMany(a => a.Orders)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}