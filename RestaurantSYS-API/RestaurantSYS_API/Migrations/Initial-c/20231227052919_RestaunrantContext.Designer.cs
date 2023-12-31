﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace RestaurantSYS_API.Migrations.Initialc
{
    [DbContext(typeof(RestaurantContext))]
    [Migration("20231227052919_RestaunrantContext")]
    partial class RestaunrantContext
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Dish", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("Menu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Availability")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<string>("PriceRange")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Validity")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("MenuDish", b =>
                {
                    b.Property<int>("DishID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MenuID")
                        .HasColumnType("INTEGER");

                    b.HasKey("DishID", "MenuID");

                    b.HasIndex("MenuID");

                    b.ToTable("MenuDishes");
                });

            modelBuilder.Entity("Dish", b =>
                {
                    b.HasOne("Category", "Category")
                        .WithMany("Dishes")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("MenuDish", b =>
                {
                    b.HasOne("Dish", "Dish")
                        .WithMany("MenuDishes")
                        .HasForeignKey("DishID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Menu", "Menu")
                        .WithMany("MenuDishes")
                        .HasForeignKey("MenuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("Category", b =>
                {
                    b.Navigation("Dishes");
                });

            modelBuilder.Entity("Dish", b =>
                {
                    b.Navigation("MenuDishes");
                });

            modelBuilder.Entity("Menu", b =>
                {
                    b.Navigation("MenuDishes");
                });
#pragma warning restore 612, 618
        }
    }
}
