﻿// <auto-generated />
using System;
using KingflixCore.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KingflixCore.EF.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210512191210_CreatDB")]
    partial class CreatDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppRoles");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Balance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("BlogCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cover")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("SeoDescription")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("SeoKeywords")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Alias");

                    b.HasIndex("BlogCategoryId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.BlogCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("SeoDescription")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("SeoKeywords")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Alias")
                        .IsUnique();

                    b.ToTable("BlogCategory");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("CategoryType")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorHover")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ColorShadow")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cover")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DateOrderAccept")
                        .HasColumnType("int");

                    b.Property<int?>("DaysGuarantee")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GuaranteeInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("GuaranteePrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.Property<int>("ProductType")
                        .HasColumnType("int");

                    b.Property<string>("PromotionInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Alias")
                        .IsUnique();

                    b.ToTable("Category");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.FlashSale", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Cover")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FlashSale");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.FlashSaleCategory", b =>
                {
                    b.Property<int>("FlashSaleId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryId")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<double>("Month")
                        .HasColumnType("float");

                    b.Property<string>("FlashSaleId1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("PriceSale")
                        .HasColumnType("float");

                    b.HasKey("FlashSaleId", "CategoryId", "Month");

                    b.HasIndex("FlashSaleId1");

                    b.HasIndex("CategoryId", "Month");

                    b.ToTable("FlashSaleCategory");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.GiftCardOrder", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("CardTemplate")
                        .HasColumnType("int");

                    b.Property<string>("DeliveryAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryPhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeliveryTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDelivery")
                        .HasColumnType("bit");

                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GiftCardOrder");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ApiOrderId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CancelNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateConfirm")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageConfirmPayment")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("PaymentId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserUseGiftCode")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("VoucherId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PaymentId");

                    b.HasIndex("UserId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.OrderDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("ImageId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsGuarantee")
                        .HasColumnType("bit");

                    b.Property<bool>("IsKingflixAccount")
                        .HasColumnType("bit");

                    b.Property<double>("Month")
                        .HasColumnType("float");

                    b.Property<string>("OrderId")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AccountAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cover")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QRImage")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.Price", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<double>("Month")
                        .HasColumnType("float");

                    b.Property<bool>("IsShow")
                        .HasColumnType("bit");

                    b.Property<double>("OrigPrice")
                        .HasColumnType("float");

                    b.Property<double?>("PromotionPrice")
                        .HasColumnType("float");

                    b.Property<string>("TextFixed")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId", "Month");

                    b.ToTable("Price");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Cover")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("Cycle")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ReplaceProductId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PinCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.Support", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductId")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Reply")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Support");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.Voucher", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<double?>("MaxMoney")
                        .HasColumnType("float");

                    b.Property<string>("PolicyContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.Property<int>("VoucherFor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Voucher");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.VoucherCategory", b =>
                {
                    b.Property<string>("VoucherId")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("VoucherId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("VoucherCategory");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.VoucherChild", b =>
                {
                    b.Property<string>("VoucherChildId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("VoucherId")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("VoucherChildId");

                    b.HasIndex("VoucherId");

                    b.ToTable("VoucherChild");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoleId", "UserId");

                    b.ToTable("AppUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.Blog", b =>
                {
                    b.HasOne("KingflixCore.Domain.DomainModel.BlogCategory", "BlogCategory")
                        .WithMany("Blogs")
                        .HasForeignKey("BlogCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BlogCategory");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.FlashSaleCategory", b =>
                {
                    b.HasOne("KingflixCore.Domain.DomainModel.FlashSale", "FlashSale")
                        .WithMany("FlashSaleCategories")
                        .HasForeignKey("FlashSaleId1")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KingflixCore.Domain.DomainModel.Price", "Price")
                        .WithMany("FlashSaleCategories")
                        .HasForeignKey("CategoryId", "Month")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FlashSale");

                    b.Navigation("Price");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.GiftCardOrder", b =>
                {
                    b.HasOne("KingflixCore.Domain.DomainModel.Order", "Order")
                        .WithOne("GiftCardOrder")
                        .HasForeignKey("KingflixCore.Domain.DomainModel.GiftCardOrder", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.Order", b =>
                {
                    b.HasOne("KingflixCore.Domain.DomainModel.Payment", "Payment")
                        .WithMany("Orders")
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("KingflixCore.Domain.DomainModel.AppUser", "UserOrdered")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Payment");

                    b.Navigation("UserOrdered");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.OrderDetails", b =>
                {
                    b.HasOne("KingflixCore.Domain.DomainModel.Category", "Category")
                        .WithMany("OrderDetails")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("KingflixCore.Domain.DomainModel.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.Price", b =>
                {
                    b.HasOne("KingflixCore.Domain.DomainModel.Category", "Category")
                        .WithMany("Prices")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.Product", b =>
                {
                    b.HasOne("KingflixCore.Domain.DomainModel.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Category");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.Profile", b =>
                {
                    b.HasOne("KingflixCore.Domain.DomainModel.Product", "Product")
                        .WithMany("Profiles")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KingflixCore.Domain.DomainModel.AppUser", "UserInformation")
                        .WithMany("Profiles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Product");

                    b.Navigation("UserInformation");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.Support", b =>
                {
                    b.HasOne("KingflixCore.Domain.DomainModel.Product", "Product")
                        .WithMany("Supports")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KingflixCore.Domain.DomainModel.AppUser", "UserInformation")
                        .WithMany("Supports")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("UserInformation");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.VoucherCategory", b =>
                {
                    b.HasOne("KingflixCore.Domain.DomainModel.Category", "Category")
                        .WithMany("VoucherCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KingflixCore.Domain.DomainModel.Voucher", "Voucher")
                        .WithMany("VoucherCategories")
                        .HasForeignKey("VoucherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Voucher");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.VoucherChild", b =>
                {
                    b.HasOne("KingflixCore.Domain.DomainModel.Voucher", "Vouchers")
                        .WithMany("VoucherChilds")
                        .HasForeignKey("VoucherId");

                    b.Navigation("Vouchers");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.AppUser", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Profiles");

                    b.Navigation("Supports");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.BlogCategory", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.Category", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("Prices");

                    b.Navigation("Products");

                    b.Navigation("VoucherCategories");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.FlashSale", b =>
                {
                    b.Navigation("FlashSaleCategories");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.Order", b =>
                {
                    b.Navigation("GiftCardOrder");

                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.Payment", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.Price", b =>
                {
                    b.Navigation("FlashSaleCategories");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.Product", b =>
                {
                    b.Navigation("Profiles");

                    b.Navigation("Supports");
                });

            modelBuilder.Entity("KingflixCore.Domain.DomainModel.Voucher", b =>
                {
                    b.Navigation("VoucherCategories");

                    b.Navigation("VoucherChilds");
                });
#pragma warning restore 612, 618
        }
    }
}
