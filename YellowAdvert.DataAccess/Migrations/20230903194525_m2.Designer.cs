﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YellowAdvert.DataAccess.Concrete.EntityFramework;

#nullable disable

namespace YellowAdvert.DataAccess.Migrations
{
    [DbContext(typeof(YellowAdvertEfContext))]
    [Migration("20230903194525_m2")]
    partial class m2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("YellowAdvert.Entities.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreateDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<bool>("HasSubCategory")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LastUpdateDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("LastUpdateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("YellowAdvert.Entities.Models.CategoryAttributeValues", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryAttributeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreateDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LastUpdateDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("LastUpdateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductAttributesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryAttributeId");

                    b.HasIndex("ProductAttributesId");

                    b.ToTable("CategoryAttributeValues");
                });

            modelBuilder.Entity("YellowAdvert.Entities.Models.CategoryAttributes", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreateDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsCustom")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRequired")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LastUpdateDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("LastUpdateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Type")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryAttributes");
                });

            modelBuilder.Entity("YellowAdvert.Entities.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreateDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LastUpdateDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("LastUpdateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("YellowAdvert.Entities.Models.ProductAttributes", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryAttributeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CategoryAttributeValueId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreateDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CustomCategoryAttributeValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LastUpdateDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid?>("LastUpdateUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductAttributes");
                });

            modelBuilder.Entity("YellowAdvert.Entities.Models.CategoryAttributeValues", b =>
                {
                    b.HasOne("YellowAdvert.Entities.Models.CategoryAttributes", "CategoryAttributes")
                        .WithMany("CategoryAttributeValues")
                        .HasForeignKey("CategoryAttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("YellowAdvert.Entities.Models.ProductAttributes", null)
                        .WithMany("CategoryAttributeValues")
                        .HasForeignKey("ProductAttributesId");

                    b.Navigation("CategoryAttributes");
                });

            modelBuilder.Entity("YellowAdvert.Entities.Models.CategoryAttributes", b =>
                {
                    b.HasOne("YellowAdvert.Entities.Models.Category", "Category")
                        .WithMany("CategoryAttributes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("YellowAdvert.Entities.Models.Product", b =>
                {
                    b.HasOne("YellowAdvert.Entities.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("YellowAdvert.Entities.Models.ProductAttributes", b =>
                {
                    b.HasOne("YellowAdvert.Entities.Models.Product", "Product")
                        .WithMany("ProductAttributes")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("YellowAdvert.Entities.Models.Category", b =>
                {
                    b.Navigation("CategoryAttributes");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("YellowAdvert.Entities.Models.CategoryAttributes", b =>
                {
                    b.Navigation("CategoryAttributeValues");
                });

            modelBuilder.Entity("YellowAdvert.Entities.Models.Product", b =>
                {
                    b.Navigation("ProductAttributes");
                });

            modelBuilder.Entity("YellowAdvert.Entities.Models.ProductAttributes", b =>
                {
                    b.Navigation("CategoryAttributeValues");
                });
#pragma warning restore 612, 618
        }
    }
}
