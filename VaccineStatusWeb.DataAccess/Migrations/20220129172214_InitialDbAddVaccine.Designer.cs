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
    [Migration("20220129172214_InitialDbAddVaccine")]
    partial class InitialDbAddVaccine
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
                            CreatedOn = new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9133),
                            DeletedBy = "none",
                            DeletedOn = new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9130),
                            DeletedRemark = "Not deleted",
                            Description = "LocatedInRatnapura",
                            IsActive = true,
                            IsDelete = false,
                            LastModifiedBy = "Not modified",
                            LastModifiedOn = new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9134),
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
                            CreatedOn = new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9138),
                            DeletedBy = "none",
                            DeletedOn = new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9138),
                            DeletedRemark = "Not deleted",
                            Description = "LocatedInAnuradhapura",
                            IsActive = true,
                            IsDelete = false,
                            LastModifiedBy = "Not modified",
                            LastModifiedOn = new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9139),
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
                            CreatedOn = new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9141),
                            DeletedBy = "none",
                            DeletedOn = new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9141),
                            DeletedRemark = "Not deleted",
                            Description = "LocatedInBadulla",
                            IsActive = true,
                            IsDelete = false,
                            LastModifiedBy = "Not modified",
                            LastModifiedOn = new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9142),
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
                            CreatedOn = new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9157),
                            DeletedBy = "none",
                            DeletedOn = new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9156),
                            DeletedRemark = "Not deleted",
                            IsActive = true,
                            IsDelete = false,
                            LastModifiedBy = "Not modified",
                            LastModifiedOn = new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9158),
                            Name = "Boston",
                            PhoneNumber = 123456781
                        },
                        new
                        {
                            Id = 2,
                            Address = "LiyanegeStreet,Badulla",
                            ContactPerson = "Dr.Isuru",
                            CreatedBy = "Perera",
                            CreatedOn = new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9162),
                            DeletedBy = "none",
                            DeletedOn = new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9161),
                            DeletedRemark = "Not deleted",
                            IsActive = true,
                            IsDelete = false,
                            LastModifiedBy = "Not modified",
                            LastModifiedOn = new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9162),
                            Name = "Kiva",
                            PhoneNumber = 123456754
                        },
                        new
                        {
                            Id = 3,
                            Address = "NamalStreet,Colombo",
                            ContactPerson = "Dr.Kaliyawansa",
                            CreatedBy = "Munasinghe",
                            CreatedOn = new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9164),
                            DeletedBy = "none",
                            DeletedOn = new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9164),
                            DeletedRemark = "Not deleted",
                            IsActive = true,
                            IsDelete = false,
                            LastModifiedBy = "Not modified",
                            LastModifiedOn = new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9165),
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
                            Date = new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9034),
                            UserId = 1,
                            UserName = "Dorin",
                            VaccineBatchId = 123,
                            VaccineCentreId = 12434
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9048),
                            UserId = 2,
                            UserName = "Shara",
                            VaccineBatchId = 466,
                            VaccineCentreId = 98765
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9049),
                            UserId = 4,
                            UserName = "Tom",
                            VaccineBatchId = 789,
                            VaccineCentreId = 98765
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2022, 1, 29, 22, 52, 14, 265, DateTimeKind.Local).AddTicks(9050),
                            UserId = 5,
                            UserName = "Sana",
                            VaccineBatchId = 152,
                            VaccineCentreId = 98762
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
