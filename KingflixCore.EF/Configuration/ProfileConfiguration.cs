using KingflixCore.Domain.DomainModel;
using KingflixCore.EF.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KingflixCore.EF.Configurations
{
    public class ProfileConfiguration : DbEntityConfiguration<Profile>
    {
        public override void Configure(EntityTypeBuilder<Profile> entity)
        {
            entity.HasKey(a => a.Id);
            entity.Property(a => a.Id)
                .ValueGeneratedOnAdd();
            entity.Property(a => a.Title)
                .HasMaxLength(300)
                .IsRequired();
            entity.Property(a => a.PinCode)
                .IsRequired();
            entity.Property(a => a.DateCreated)
                .IsRequired();
            entity.Property(a => a.DateModified)
                .IsRequired(false);
            entity.Property(a => a.DateEnd)
                .IsRequired();
            entity.Property(a => a.ProductId)
                .IsRequired();
            entity.Property(a => a.UserId)
                .IsRequired(false);

            entity.HasOne(a => a.Product)
                .WithMany(a => a.Profiles)
                .HasForeignKey(a => a.ProductId)
                .OnDelete(DeleteBehavior.Cascade);
            entity.HasOne(a => a.UserInformation)
                .WithMany(a => a.Profiles)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}