using KingflixCore.Domain.DomainModel;
using KingflixCore.EF.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KingflixCore.EF.Configurations
{
    public class BlogConfiguration : DbEntityConfiguration<Blog>
    {
        public override void Configure(EntityTypeBuilder<Blog> entity)
        {
            entity.HasKey(a => a.Id);
            entity.Property(a => a.Id)
                .ValueGeneratedOnAdd();
            entity.Property(a => a.Title)
                .IsRequired()
                .HasMaxLength(256);
            entity.HasIndex(a => a.Alias);
            entity.Property(a => a.Alias)
                .IsRequired().HasMaxLength(256);
            entity.Property(a => a.Cover)
                .HasMaxLength(1000).IsRequired(false);
            entity.Property(a => a.Description)
                .HasMaxLength(1000)
                .IsRequired(false);
            entity.Property(a => a.Content)
                .IsRequired(false);
            entity.Property(a => a.DateCreated)
                .IsRequired();
            entity.Property(a => a.DateModified)
                .IsRequired(false);
            entity.Property(a => a.SeoKeywords)
                .HasMaxLength(256)
                .IsRequired(false);
            entity.Property(a => a.SeoDescription)
                .HasMaxLength(1000)
                .IsRequired();
            entity.Property(a => a.Status)
                .IsRequired();
            entity.HasOne(a => a.BlogCategory)
                .WithMany(a => a.Blogs)
                .HasForeignKey(a => a.BlogCategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}