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
    [Migration("20220129200912_InitialDbAddVaccineDose1")]
    partial class InitialDbAddVaccineDose1
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

                    b.Property<DateTime?>("CreatedOn")
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
                            CreatedOn = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4331),
                            DeletedBy = "none",
                            DeletedOn = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4328),
                            DeletedRemark = "Not deleted",
                            Description = "LocatedInRatnapura",
                            IsActive = true,
                            IsDelete = false,
                            LastModifiedBy = "Not modified",
                            LastModifiedOn = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4331),
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
                            CreatedOn = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4335),
                            DeletedBy = "none",
                            DeletedOn = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4334),
                            DeletedRemark = "Not deleted",
                            Description = "LocatedInAnuradhapura",
                            IsActive = true,
                            IsDelete = false,
                            LastModifiedBy = "Not modified",
                            LastModifiedOn = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4335),
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
                            CreatedOn = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4337),
                            DeletedBy = "none",
                            DeletedOn = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4337),
                            DeletedRemark = "Not deleted",
                            Description = "LocatedInBadulla",
                            IsActive = true,
                            IsDelete = false,
                            LastModifiedBy = "Not modified",
                            LastModifiedOn = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4339),
                            Name = "BadullaHospital",
                            OfficialContactNumber = 112258697,
                            OfficialContactPerson = "Dr.Saman",
                            Status = 0,
                            UserId = 0,
                            UserName = "Shara",
                            VaccineDataId = 2
                        });
                });

            modelBuilder.Entity("VaccineStatus.WebApi.Models.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedRemark")
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

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Organizations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "BaselStreet,Balangoda,Ratnapura",
                            ContactPerson = "Dr.Silva",
                            CreatedBy = "Adhil",
                            CreatedOn = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4353),
                            DeletedBy = "none",
                            DeletedOn = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4352),
                            DeletedRemark = "Not deleted",
                            IsActive = true,
                            IsDelete = false,
                            LastModifiedBy = "Not modified",
                            LastModifiedOn = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4354),
                            Name = "Boston",
                            PhoneNumber = 123456781
                        },
                        new
                        {
                            Id = 2,
                            Address = "LiyanegeStreet,Badulla",
                            ContactPerson = "Dr.Isuru",
                            CreatedBy = "Perera",
                            CreatedOn = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4357),
                            DeletedBy = "none",
                            DeletedOn = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4356),
                            DeletedRemark = "Not deleted",
                            IsActive = true,
                            IsDelete = false,
                            LastModifiedBy = "Not modified",
                            LastModifiedOn = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4358),
                            Name = "Kiva",
                            PhoneNumber = 123456754
                        },
                        new
                        {
                            Id = 3,
                            Address = "NamalStreet,Colombo",
                            ContactPerson = "Dr.Kaliyawansa",
                            CreatedBy = "Munasinghe",
                            CreatedOn = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4362),
                            DeletedBy = "none",
                            DeletedOn = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4361),
                            DeletedRemark = "Not deleted",
                            IsActive = true,
                            IsDelete = false,
                            LastModifiedBy = "Not modified",
                            LastModifiedOn = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4362),
                            Name = "Goodwill",
                            PhoneNumber = 123456783
                        });
                });

            modelBuilder.Entity("VaccineStatusWeb.Models.Vaccine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VaccineName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vaccines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "China",
                            Type = "Inactivated",
                            VaccineName = "Sinopharm BIBP"
                        },
                        new
                        {
                            Id = 2,
                            Country = "Singapore",
                            Type = "TozinameranVaccineInjection",
                            VaccineName = "Pfizer–BioNTech"
                        },
                        new
                        {
                            Id = 3,
                            Country = "America",
                            Type = "mRNA",
                            VaccineName = "Moderna"
                        },
                        new
                        {
                            Id = 4,
                            Country = "Russia",
                            Type = "Viral vector",
                            VaccineName = "Sputnik V"
                        });
                });

            modelBuilder.Entity("VaccineStatusWeb.Models.VaccineBatch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BatchNumber")
                        .HasColumnType("int");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VaccineId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VaccineBatches");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BatchNumber = 456789,
                            Manufacturer = "Gamaleya Research",
                            Name = "FirstBatch",
                            VaccineId = 1
                        },
                        new
                        {
                            Id = 2,
                            BatchNumber = 456733,
                            Manufacturer = "Charles Research",
                            Name = "SecondBatch",
                            VaccineId = 2
                        },
                        new
                        {
                            Id = 3,
                            BatchNumber = 456789,
                            Manufacturer = " BIONTECH",
                            Name = "ThirdBatch",
                            VaccineId = 3
                        },
                        new
                        {
                            Id = 4,
                            BatchNumber = 456321,
                            Manufacturer = "Beijing Institute",
                            Name = "ForthBatch",
                            VaccineId = 4
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

                    b.Property<int>("VaccineBatchId")
                        .HasColumnType("int");

                    b.Property<int>("VaccineCentreId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VaccineDatas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4226),
                            UserId = 1,
                            UserName = "Dorin",
                            VaccineBatchId = 123,
                            VaccineCentreId = 12434
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4239),
                            UserId = 2,
                            UserName = "Shara",
                            VaccineBatchId = 466,
                            VaccineCentreId = 98765
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4240),
                            UserId = 4,
                            UserName = "Tom",
                            VaccineBatchId = 789,
                            VaccineCentreId = 98765
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4241),
                            UserId = 5,
                            UserName = "Sana",
                            VaccineBatchId = 152,
                            VaccineCentreId = 98762
                        });
                });

            modelBuilder.Entity("VaccineStatusWeb.Models.VaccineDose", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("HealthWorker")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RequiredCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("VaccinatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VaccineId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VaccineDoses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HealthWorker = "Designated vaccinator by MOH approved vaccination site",
                            RequiredCount = 0,
                            VaccinatedDate = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4436),
                            VaccineId = 1
                        },
                        new
                        {
                            Id = 2,
                            HealthWorker = "Designated vaccinator by MOH approved vaccination site",
                            RequiredCount = 1,
                            VaccinatedDate = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4438),
                            VaccineId = 2
                        },
                        new
                        {
                            Id = 3,
                            HealthWorker = "Designated vaccinator by MOH approved vaccination site",
                            RequiredCount = 2,
                            VaccinatedDate = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4439),
                            VaccineId = 3
                        },
                        new
                        {
                            Id = 4,
                            HealthWorker = "Designated vaccinator by MOH approved vaccination site",
                            RequiredCount = 3,
                            VaccinatedDate = new DateTime(2022, 1, 30, 1, 39, 11, 925, DateTimeKind.Local).AddTicks(4440),
                            VaccineId = 4
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