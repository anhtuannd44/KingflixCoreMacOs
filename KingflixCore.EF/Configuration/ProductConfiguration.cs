using KingflixCore.Domain.DomainModel;
using KingflixCore.EF.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KingflixCore.EF.Configurations
{
    public class ProductConfiguration : DbEntityConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> entity)
        {
            entity.HasKey(a => a.Id);
            entity.Property(a => a.Id)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(a => a.Password)
                .HasMaxLength(50)
                .IsRequired();
            entity.Property(a => a.DateEnd)
                .IsRequired();
            entity.Property(a => a.DateCreated)
                .IsRequired();
            entity.Property(a => a.DateModified)
                .IsRequired(false);
            entity.Property(a => a.Cycle)
                .IsRequired();
            entity.Property(a => a.Cover)
                .HasMaxLength(1000)
                .IsRequired(false);
            entity.Property(a => a.Status)
                .IsRequired();

            entity.HasOne(a => a.Category)
                .WithMany(a => a.Products)
                .HasForeignKey(a => a.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}