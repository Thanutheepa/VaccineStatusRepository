﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VaccineStatusWeb.DataAccess;

#nullable disable

namespace VaccineStatusWeb.DataAccess.Migrations
{
    [DbContext(typeof(MedicalInstituteDbContext))]
    [Migration("20220128093935_InitialDb")]
    partial class InitialDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("VaccineStatus.WebApi.Models.MedicalInstitute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedRemark")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("LastModifiedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OfficialContactNumber")
                        .HasColumnType("int");

                    b.Property<string>("OfficialContactPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VaccineDataId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VaccineDataId");

                    b.ToTable("MedicalInstitutes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "Adheera",
                            CreatedOn = new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5938),
                            DeletedBy = "none",
                            DeletedOn = new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5935),
                            DeletedRemark = "Not deleted",
                            Description = "LocatedInRatnapura",
                            IsActive = true,
                            IsDelete = false,
                            LastModifiedBy = "Not modified",
                            LastModifiedOn = new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5938),
                            Name = "PumbahinnaHospital - DB",
                            OfficialContactNumber = 12345678,
                            OfficialContactPerson = "Dr.Perera",
                            Status = 0,
                            UserId = 0,
                            UserName = "Dorin",
                            VaccineDataId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "Doily",
                            CreatedOn = new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5942),
                            DeletedBy = "none",
                            DeletedOn = new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5942),
                            DeletedRemark = "Not deleted",
                            Description = "LocatedInAnuradhapura",
                            IsActive = true,
                            IsDelete = false,
                            LastModifiedBy = "Not modified",
                            LastModifiedOn = new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5943),
                            Name = "AnuradhapuraHospital",
                            OfficialContactNumber = 12345678,
                            OfficialContactPerson = "Dr.Perera",
                            Status = 0,
                            UserId = 0,
                            UserName = "Dorin",
                            VaccineDataId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "John",
                            CreatedOn = new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5946),
                            DeletedBy = "none",
                            DeletedOn = new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5945),
                            DeletedRemark = "Not deleted",
                            Description = "LocatedInBadulla",
                            IsActive = true,
                            IsDelete = false,
                            LastModifiedBy = "Not modified",
                            LastModifiedOn = new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5946),
                            Name = "BadullaHospital",
                            OfficialContactNumber = 112258697,
                            OfficialContactPerson = "Dr.Saman",
                            Status = 0,
                            UserId = 0,
                            UserName = "Shara",
                            VaccineDataId = 2
                        });
                });

            modelBuilder.Entity("VaccineStatusWeb.Models.VaccineData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VaccineBatch")
                        .HasColumnType("int");

                    b.Property<string>("VaccineCentre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VaccineDatas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5818),
                            UserId = 1,
                            UserName = "Dorin",
                            VaccineBatch = 123,
                            VaccineCentre = "SUSL-MC"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5831),
                            UserId = 2,
                            UserName = "Shara",
                            VaccineBatch = 466,
                            VaccineCentre = "Pambahinna"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5832),
                            UserId = 4,
                            UserName = "Tom",
                            VaccineBatch = 789,
                            VaccineCentre = "Balangoda"
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2022, 1, 28, 15, 9, 34, 597, DateTimeKind.Local).AddTicks(5833),
                            UserId = 5,
                            UserName = "Sana",
                            VaccineBatch = 152,
                            VaccineCentre = "Ratnapura"
                        });
                });

            modelBuilder.Entity("VaccineStatus.WebApi.Models.MedicalInstitute", b =>
                {
                    b.HasOne("VaccineStatusWeb.Models.VaccineData", "VaccineDatas")
                        .WithMany("medicalInstitutes")
                        .HasForeignKey("VaccineDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VaccineDatas");
                });

            modelBuilder.Entity("VaccineStatusWeb.Models.VaccineData", b =>
                {
                    b.Navigation("medicalInstitutes");
                });
#pragma warning restore 612, 618
        }
    }
}
