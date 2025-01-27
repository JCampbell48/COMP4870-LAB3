﻿// <auto-generated />
using CommunityApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CommunityApp.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("CommunityApp.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Population")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProvinceCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CityId");

                    b.HasIndex("ProvinceCode");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            CityName = "Vancouver",
                            Population = 675000,
                            ProvinceCode = "BC"
                        },
                        new
                        {
                            CityId = 2,
                            CityName = "Surrey",
                            Population = 517000,
                            ProvinceCode = "BC"
                        },
                        new
                        {
                            CityId = 3,
                            CityName = "Burnaby",
                            Population = 249000,
                            ProvinceCode = "BC"
                        },
                        new
                        {
                            CityId = 4,
                            CityName = "Toronto",
                            Population = 2730000,
                            ProvinceCode = "ON"
                        },
                        new
                        {
                            CityId = 5,
                            CityName = "Ottawa",
                            Population = 934000,
                            ProvinceCode = "ON"
                        },
                        new
                        {
                            CityId = 6,
                            CityName = "Mississauga",
                            Population = 721000,
                            ProvinceCode = "ON"
                        },
                        new
                        {
                            CityId = 7,
                            CityName = "Montreal",
                            Population = 1705000,
                            ProvinceCode = "QC"
                        },
                        new
                        {
                            CityId = 8,
                            CityName = "Quebec City",
                            Population = 542000,
                            ProvinceCode = "QC"
                        },
                        new
                        {
                            CityId = 9,
                            CityName = "Laval",
                            Population = 438000,
                            ProvinceCode = "QC"
                        });
                });

            modelBuilder.Entity("CommunityApp.Models.Province", b =>
                {
                    b.Property<string>("ProvinceCode")
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProvinceName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("ProvinceCode");

                    b.ToTable("Provinces");

                    b.HasData(
                        new
                        {
                            ProvinceCode = "BC",
                            ProvinceName = "British Columbia"
                        },
                        new
                        {
                            ProvinceCode = "ON",
                            ProvinceName = "Ontario"
                        },
                        new
                        {
                            ProvinceCode = "QC",
                            ProvinceName = "Quebec"
                        });
                });

            modelBuilder.Entity("CommunityApp.Models.City", b =>
                {
                    b.HasOne("CommunityApp.Models.Province", "Province")
                        .WithMany("Cities")
                        .HasForeignKey("ProvinceCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Province");
                });

            modelBuilder.Entity("CommunityApp.Models.Province", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
