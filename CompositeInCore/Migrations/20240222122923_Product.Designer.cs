﻿// <auto-generated />
using System;
using CompositeInCore.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CompositeInCore.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20240222122923_Product")]
    partial class Product
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CompositeInCore.Models.Entities.CategoryComponent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("categoryComponents");

                    b.HasDiscriminator<string>("Discriminator").HasValue("CategoryComponent");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("CompositeInCore.Models.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("categoryItemId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("categoryItemId");

                    b.ToTable("products");
                });

            modelBuilder.Entity("CompositeInCore.Models.Entities.Category", b =>
                {
                    b.HasBaseType("CompositeInCore.Models.Entities.CategoryComponent");

                    b.HasDiscriminator().HasValue("Category");
                });

            modelBuilder.Entity("CompositeInCore.Models.Entities.CategoryItem", b =>
                {
                    b.HasBaseType("CompositeInCore.Models.Entities.CategoryComponent");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("CategoryItem");
                });

            modelBuilder.Entity("CompositeInCore.Models.Entities.CategoryComponent", b =>
                {
                    b.HasOne("CompositeInCore.Models.Entities.Category", null)
                        .WithMany("MenuComponents")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("CompositeInCore.Models.Entities.Product", b =>
                {
                    b.HasOne("CompositeInCore.Models.Entities.CategoryItem", "categoryItem")
                        .WithMany()
                        .HasForeignKey("categoryItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("categoryItem");
                });

            modelBuilder.Entity("CompositeInCore.Models.Entities.Category", b =>
                {
                    b.Navigation("MenuComponents");
                });
#pragma warning restore 612, 618
        }
    }
}
