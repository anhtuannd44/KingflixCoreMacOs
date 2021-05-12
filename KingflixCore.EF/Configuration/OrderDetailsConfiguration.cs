using KingflixCore.Domain.DomainModel;
using KingflixCore.EF.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KingflixCore.EF.Configurations
{
    public class OrderDetailsConfiguration : DbEntityConfiguration<OrderDetails>
    {
        public override void Configure(EntityTypeBuilder<OrderDetails> entity)
        {
            entity.HasKey(a => a.Id);
            entity.Property(a => a.Id)
                .ValueGeneratedOnAdd();
            entity.Property(a => a.CategoryName)
                .HasMaxLength(1000)
                .IsRequired(true);
            entity.Property(a => a.Month)
                .IsRequired();
            entity.Property(a => a.Count)
                .IsRequired();
            entity.Property(a => a.UserAccount)
                .IsRequired(false);
            entity.Property(a => a.UserPassword)
                .IsRequired(false);
            entity.Property(a => a.IsGuarantee)
                .IsRequired();
            entity.Property(a => a.IsKingflixAccount)
                .IsRequired();
            entity.Property(a => a.CategoryId)
                .IsRequired(false);
            entity.Property(a => a.OrderId)
                .IsRequired();
            entity.Property(a => a.Price)
                .IsRequired();
           
            entity.HasOne(a => a.Order)
                .WithMany(a => a.OrderDetails)
                .HasForeignKey(a => a.OrderId)
                .OnDelete(DeleteBehavior.Cascade);
            entity.HasOne(a => a.Category)
                .WithMany(a => a.OrderDetails)
                .HasForeignKey(a => a.CategoryId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}