﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SynthiMarkAPI.Persistence.Context;

#nullable disable

namespace SynthiMarkAPI.Persistence.Migrations
{
    [DbContext(typeof(SynthiMarkAPIDbContext))]
    [Migration("20231101150111_mig2")]
    partial class mig2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SynthiMarkAPI.Domain.Entities.Advertising", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AdvertisingTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserForegId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AdvertisingTypeId");

                    b.HasIndex("UserForegId");

                    b.ToTable("Advertisings");
                });

            modelBuilder.Entity("SynthiMarkAPI.Domain.Entities.AdvertisingType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserForegId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserForegId");

                    b.ToTable("AdvertisingTypes");
                });

            modelBuilder.Entity("SynthiMarkAPI.Domain.Entities.Blog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserForegId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserForegId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("SynthiMarkAPI.Domain.Entities.PostIdeas", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserForegId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserForegId");

                    b.ToTable("PostIdeas");
                });

            modelBuilder.Entity("SynthiMarkAPI.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Features")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserForegId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserForegId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SynthiMarkAPI.Domain.Entities.Seo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AuthorInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserForegId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserForegId");

                    b.ToTable("Seos");
                });

            modelBuilder.Entity("SynthiMarkAPI.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SynthiMarkAPI.Domain.Entities.Video", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TagList")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserForegId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserForegId");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("SynthiMarkAPI.Domain.Entities.VideoIdeas", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserForegId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserForegId");

                    b.ToTable("VideoIdeas");
                });

            modelBuilder.Entity("SynthiMarkAPI.Domain.Entities.Advertising", b =>
                {
                    b.HasOne("SynthiMarkAPI.Domain.Entities.AdvertisingType", "AdvertisingType")
                        .WithMany("Advertisings")
                        .HasForeignKey("AdvertisingTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SynthiMarkAPI.Domain.Entities.User", "UserForeg")
                        .WithMany("Advertisings")
                        .HasForeignKey("UserForegId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdvertisingType");

                    b.Navigation("UserForeg");
                });

            modelBuilder.Entity("SynthiMarkAPI.Domain.Entities.AdvertisingType", b =>
                {
                    b.HasOne("SynthiMarkAPI.Domain.Entities.User", "UserForeg")
                        .WithMany()
                        .HasForeignKey("UserForegId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserForeg");
                });

            modelBuilder.Entity("SynthiMarkAPI.Domain.Entities.Blog", b =>
                {
                    b.HasOne("SynthiMarkAPI.Domain.Entities.User", "UserForeg")
                        .WithMany("Blogs")
                        .HasForeignKey("UserForegId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserForeg");
                });

            modelBuilder.Entity("SynthiMarkAPI.Domain.Entities.PostIdeas", b =>
                {
                    b.HasOne("SynthiMarkAPI.Domain.Entities.User", "UserForeg")
                        .WithMany("PostIdeas")
                        .HasForeignKey("UserForegId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserForeg");
                });

            modelBuilder.Entity("SynthiMarkAPI.Domain.Entities.Product", b =>
                {
                    b.HasOne("SynthiMarkAPI.Domain.Entities.User", "UserForeg")
                        .WithMany("Products")
                        .HasForeignKey("UserForegId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserForeg");
                });

            modelBuilder.Entity("SynthiMarkAPI.Domain.Entities.Seo", b =>
                {
                    b.HasOne("SynthiMarkAPI.Domain.Entities.User", "UserForeg")
                        .WithMany()
                        .HasForeignKey("UserForegId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserForeg");
                });

            modelBuilder.Entity("SynthiMarkAPI.Domain.Entities.Video", b =>
                {
                    b.HasOne("SynthiMarkAPI.Domain.Entities.User", "UserForeg")
                        .WithMany()
                        .HasForeignKey("UserForegId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserForeg");
                });

            modelBuilder.Entity("SynthiMarkAPI.Domain.Entities.VideoIdeas", b =>
                {
                    b.HasOne("SynthiMarkAPI.Domain.Entities.User", "UserForeg")
                        .WithMany()
                        .HasForeignKey("UserForegId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserForeg");
                });

            modelBuilder.Entity("SynthiMarkAPI.Domain.Entities.AdvertisingType", b =>
                {
                    b.Navigation("Advertisings");
                });

            modelBuilder.Entity("SynthiMarkAPI.Domain.Entities.User", b =>
                {
                    b.Navigation("Advertisings");

                    b.Navigation("Blogs");

                    b.Navigation("PostIdeas");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
