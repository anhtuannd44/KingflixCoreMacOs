using KingflixCore.Domain.DomainModel;
using KingflixCore.EF.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KingflixCore.EF.Configurations
{
    public class CategoryConfiguration : DbEntityConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> entity)
        {
            entity.HasKey(a => a.Id);
            entity.Property(a => a.Id)
                .IsRequired()
                .HasMaxLength(300);
            entity.Property(a => a.Title)
                .IsRequired()
                .HasMaxLength(256);
            entity.HasIndex(a => a.Alias)
                .IsUnique();
            entity.Property(a => a.Alias)
                .IsRequired()
                .HasMaxLength(256);
            entity.Property(a => a.ProductType)
                .IsRequired();
            entity.Property(a => a.CategoryType)
                .IsRequired();
            entity.Property(a => a.DateCreated)
                .IsRequired();
            entity.Property(a => a.DateModified)
                .IsRequired(false);
            entity.Property(a => a.Cover)
                .HasMaxLength(1000)
                .IsRequired(false);
            entity.Property(a => a.GuaranteePrice)
                .HasDefaultValue(0);
            entity.Property(a => a.Status)
                .IsRequired();
        }
    }
}