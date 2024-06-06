﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreManagement.Models;

#nullable disable

namespace StoreManagement.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20240525133241_foreignkeyadded")]
    partial class foreignkeyadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StoreManagement.Models.Carousel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("carousel_status")
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("created_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("folder_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("img_url")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<int?>("updated_by")
                        .HasColumnType("int");

                    b.Property<DateTime?>("updated_date")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("carousel");
                });

            modelBuilder.Entity("StoreManagement.Models.Cart", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("created_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("is_add_to_cart")
                        .HasColumnType("bit");

                    b.Property<bool>("notification")
                        .HasColumnType("bit");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<int>("totall_price")
                        .HasColumnType("int");

                    b.Property<int?>("updated_by")
                        .HasColumnType("int");

                    b.Property<DateTime?>("updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("product_id");

                    b.HasIndex("user_id");

                    b.ToTable("carts");
                });

            modelBuilder.Entity("StoreManagement.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("cat_code")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("cat_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("created_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("product_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<int?>("updated_by")
                        .HasColumnType("int");

                    b.Property<DateTime?>("updated_date")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("categorys");
                });

            modelBuilder.Entity("StoreManagement.Models.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("created_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("order_status")
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<int?>("updated_by")
                        .HasColumnType("int");

                    b.Property<DateTime?>("updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("product_id");

                    b.HasIndex("user_id");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("StoreManagement.Models.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("category_id")
                        .HasColumnType("int");

                    b.Property<int>("created_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("img_url")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("item_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("product_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("seller_id")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<int?>("updated_by")
                        .HasColumnType("int");

                    b.Property<DateTime?>("updated_date")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("category_id");

                    b.HasIndex("seller_id");

                    b.ToTable("products");
                });

            modelBuilder.Entity("StoreManagement.Models.Role", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("created_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("role_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("role_status")
                        .HasColumnType("bit");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<int?>("updated_by")
                        .HasColumnType("int");

                    b.Property<DateTime?>("updated_date")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("StoreManagement.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("activation_code")
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("created_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("is_active")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("phone_number")
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("role_id")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<string>("token")
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("updated_by")
                        .HasColumnType("int");

                    b.Property<DateTime?>("updated_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("id");

                    b.HasIndex("role_id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("StoreManagement.Models.Wishlist", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int>("created_by")
                        .HasColumnType("int");

                    b.Property<DateTime>("created_date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("is_add_to_wishlist")
                        .HasColumnType("bit");

                    b.Property<bool>("notification")
                        .HasColumnType("bit");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<int?>("updated_by")
                        .HasColumnType("int");

                    b.Property<DateTime?>("updated_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("product_id");

                    b.HasIndex("user_id");

                    b.ToTable("wishlists");
                });

            modelBuilder.Entity("StoreManagement.Models.Cart", b =>
                {
                    b.HasOne("StoreManagement.Models.Product", "cartProduct")
                        .WithMany("cart")
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreManagement.Models.User", "cartUser")
                        .WithMany("cart")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cartProduct");

                    b.Navigation("cartUser");
                });

            modelBuilder.Entity("StoreManagement.Models.Order", b =>
                {
                    b.HasOne("StoreManagement.Models.Product", "orderProduct")
                        .WithMany("order")
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreManagement.Models.User", "orderUser")
                        .WithMany("order")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("orderProduct");

                    b.Navigation("orderUser");
                });

            modelBuilder.Entity("StoreManagement.Models.Product", b =>
                {
                    b.HasOne("StoreManagement.Models.Category", "category")
                        .WithMany("product")
                        .HasForeignKey("category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreManagement.Models.User", "seller")
                        .WithMany("product")
                        .HasForeignKey("seller_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");

                    b.Navigation("seller");
                });

            modelBuilder.Entity("StoreManagement.Models.User", b =>
                {
                    b.HasOne("StoreManagement.Models.Role", "role")
                        .WithMany("user")
                        .HasForeignKey("role_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("role");
                });

            modelBuilder.Entity("StoreManagement.Models.Wishlist", b =>
                {
                    b.HasOne("StoreManagement.Models.Product", "wishlistProduct")
                        .WithMany("wishlist")
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreManagement.Models.User", "wishlistUser")
                        .WithMany("wishlist")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("wishlistProduct");

                    b.Navigation("wishlistUser");
                });

            modelBuilder.Entity("StoreManagement.Models.Category", b =>
                {
                    b.Navigation("product");
                });

            modelBuilder.Entity("StoreManagement.Models.Product", b =>
                {
                    b.Navigation("cart");

                    b.Navigation("order");

                    b.Navigation("wishlist");
                });

            modelBuilder.Entity("StoreManagement.Models.Role", b =>
                {
                    b.Navigation("user");
                });

            modelBuilder.Entity("StoreManagement.Models.User", b =>
                {
                    b.Navigation("cart");

                    b.Navigation("order");

                    b.Navigation("product");

                    b.Navigation("wishlist");
                });
#pragma warning restore 612, 618
        }
    }
}
