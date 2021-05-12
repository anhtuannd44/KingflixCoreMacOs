using KingflixCore.Domain.DomainModel;
using KingflixCore.EF.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KingflixCore.EF.Configurations
{
    public class SupportConfiguration : DbEntityConfiguration<Support>
    {
        public override void Configure(EntityTypeBuilder<Support> entity)
        {
            entity.HasKey(a => a.Id);
            entity.Property(a => a.Id)
                .ValueGeneratedOnAdd();
            entity.Property(a => a.Title)
                .HasMaxLength(300)
                .IsRequired();
            entity.Property(a => a.Content)
                .IsRequired();
            entity.Property(a => a.Reply)
                .IsRequired();
            entity.Property(a => a.DateModified)
                .IsRequired();
            entity.Property(a => a.DateModified)
                .IsRequired(false);
            entity.Property(a => a.ProductId)
                .IsRequired();
            entity.Property(a => a.UserId)
                .IsRequired();
            entity.Property(a => a.Status)
                .IsRequired();

            entity.HasOne(a => a.UserInformation)
                .WithMany(a => a.Supports)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            entity.HasOne(a => a.Product)
                .WithMany(a => a.Supports)
                .HasForeignKey(a => a.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}