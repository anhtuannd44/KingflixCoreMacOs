using System;
using System.IO;
using KingflixCore.Domain.DomainModel;
using KingflixCore.EF.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using KingflixCore.EF.Extensions;

namespace KingflixCore.EF
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public virtual DbSet<Blog> Blog { get; set;}
        public virtual DbSet<BlogCategory> BlogCategory { get; set;}
        public virtual DbSet<Category> Category { get; set;}
        public virtual DbSet<FlashSale> FlashSale { get; set;}
        public virtual DbSet<FlashSaleCategory> FlashSaleCategory { get; set;}
        public virtual DbSet<GiftCardOrder> GiftCardOrder { get; set;}
        public virtual DbSet<Order> Order { get; set;}
        public virtual DbSet<OrderDetails> OrderDetails { get; set;}
        public virtual DbSet<Payment> Payment { get; set;}
        public virtual DbSet<Price> Price { get; set;}
        public virtual DbSet<Product> Product { get; set;}
        public virtual DbSet<Profile> Profile { get; set;}
        public virtual DbSet<Support> Support { get; set;}
        public virtual DbSet<Voucher> Voucher { get; set;}
        public virtual DbSet<VoucherCategory> VoucherCategory { get; set;}
        public virtual DbSet<VoucherChild> VoucherChild { get; set;}
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region Identity Config

            builder.Entity<IdentityUserClaim<Guid>>()
                .ToTable("AppUserClaims")
                .HasKey(x => x.Id);

            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims")
                .HasKey(x => x.Id);

            builder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            builder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles")
                .HasKey(x => new { x.RoleId, x.UserId });

            builder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens")
               .HasKey(x => new { x.UserId });

            #endregion Identity Config
            builder.AddConfiguration(new BlogCategoryConfiguration());
            builder.AddConfiguration(new BlogConfiguration());
            builder.AddConfiguration(new CategoryConfiguration());
            builder.AddConfiguration(new FlashSaleCategoryConfiguration());
            builder.AddConfiguration(new FlashSaleConfiguration());
            builder.AddConfiguration(new GiftCardOrderConfiguration());
            builder.AddConfiguration(new OrderConfiguration());
            builder.AddConfiguration(new OrderDetailsConfiguration());
            builder.AddConfiguration(new PaymentConfiguration());
            builder.AddConfiguration(new PriceConfiguration());
            builder.AddConfiguration(new ProductConfiguration());
            builder.AddConfiguration(new ProfileConfiguration());
            builder.AddConfiguration(new SupportConfiguration());
            builder.AddConfiguration(new VoucherCategoryConfiguration());
            builder.AddConfiguration(new VoucherConfiguration());

        }
    }
    
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<AppDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlServer(connectionString);
            return new AppDbContext(builder.Options);
        }
    }
}
