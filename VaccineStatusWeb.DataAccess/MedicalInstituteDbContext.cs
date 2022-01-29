using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VaccineStatus.WebApi.Models;
using VaccineStatusWeb.Models;


namespace VaccineStatusWeb.DataAccess
{
    public class MedicalInstituteDbContext : DbContext
    {
        public DbSet<MedicalInstitute> MedicalInstitutes { get; set; }
        public DbSet<VaccineData> VaccineDatas { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Vaccine> Vaccines { get; set; }
        public DbSet<VaccineBatch> VaccineBatches { get; set; }
        public DbSet<VaccineDose> VaccineDoses { get; set; }

       



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server = (localdb)\mssqllocaldb; Database = myVaccineDb; Trusted_Connection = True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VaccineData>().HasData(new VaccineData[]
            {
                new VaccineData{ Id = 1, UserName = "Dorin",VaccineBatchId=123,Date=DateTime.Now,VaccineCentreId=12434,UserId=1},
                new VaccineData{ Id = 2, UserName = "Shara",VaccineBatchId=466,Date=DateTime.Now,VaccineCentreId=98765,UserId=2},
                new VaccineData{ Id = 3, UserName = "Tom",VaccineBatchId=789,Date=DateTime.Now,VaccineCentreId=098765,UserId=4},
                new VaccineData{ Id = 4, UserName = "Sana",VaccineBatchId=152,Date=DateTime.Now,VaccineCentreId=98762,UserId=5}
            });


            modelBuilder.Entity<MedicalInstitute>().HasData(new MedicalInstitute[]
            {
              new MedicalInstitute
              {
                    Id = 1, 
                    IsActive = true,
                    IsDelete = false,
                    DeletedBy ="none",
                    DeletedOn =DateTime.Now,
                    DeletedRemark="Not deleted",
                    CreatedBy = "Adheera",
                    CreatedOn =DateTime.Now,
                    LastModifiedOn=DateTime.Now,
                    LastModifiedBy="Not modified",
                    Name = "PumbahinnaHospital - DB",
                    Description ="LocatedInRatnapura",
                    OfficialContactNumber =012345678,
                    OfficialContactPerson ="Dr.Perera",
                    Status =MedicalInstituteStatus.New,
                    VaccineDataId = 1,
                    UserName = "Dorin"

              },

              new MedicalInstitute
              {
                    Id = 2,                                                                    
                    IsActive = true,
                    IsDelete = false,
                    DeletedBy ="none",
                    DeletedOn =DateTime.Now,
                    DeletedRemark="Not deleted",
                    CreatedBy = "Doily",
                    CreatedOn =DateTime.Now,
                    LastModifiedOn=DateTime.Now,
                    LastModifiedBy="Not modified",
                    Name = "AnuradhapuraHospital",
                    Description = "LocatedInAnuradhapura",
                    OfficialContactNumber =012345678,
                    OfficialContactPerson ="Dr.Perera",
                    Status =MedicalInstituteStatus.New,
                    VaccineDataId = 1,
                    UserName="Dorin"
              },

              new MedicalInstitute
              { 
                    Id = 3,                
                    IsActive = true,
                    IsDelete = false,
                    DeletedBy ="none",
                    DeletedOn =DateTime.Now,
                    DeletedRemark="Not deleted",
                    CreatedBy = "John",
                    CreatedOn =DateTime.Now,
                    LastModifiedOn=DateTime.Now,
                    LastModifiedBy="Not modified",
                    Name = "BadullaHospital",
                    Description = "LocatedInBadulla",
                    OfficialContactNumber =0112258697,
                    OfficialContactPerson ="Dr.Saman",
                    Status =MedicalInstituteStatus.New,
                    VaccineDataId = 2 ,
                    UserName = "Shara"

              }
            });

            
        

            modelBuilder.Entity<Organization>().HasData(new Organization[]
            {
              new Organization
              {
                    Id = 1,
                    IsActive = true,
                    IsDelete = false,
                    DeletedBy ="none",
                    DeletedOn =DateTime.Now,
                    DeletedRemark="Not deleted",
                    CreatedBy = "Adhil",
                    CreatedOn =DateTime.Now,
                    LastModifiedOn=DateTime.Now,
                    LastModifiedBy="Not modified",
                    Name = "Boston",
                    Address ="BaselStreet,Balangoda,Ratnapura",
                    PhoneNumber =0123456781,
                    ContactPerson ="Dr.Silva",
              },

              new Organization
              {
                    Id = 2,
                    IsActive = true,
                    IsDelete = false,
                    DeletedBy ="none",
                    DeletedOn =DateTime.Now,
                    DeletedRemark="Not deleted",
                    CreatedBy = "Perera",
                    CreatedOn =DateTime.Now,
                    LastModifiedOn=DateTime.Now,
                    LastModifiedBy="Not modified",
                    Name = "Kiva",
                    Address ="LiyanegeStreet,Badulla",
                    PhoneNumber =0123456754,
                    ContactPerson ="Dr.Isuru",
              },

              new Organization
              {
                    Id = 3,
                    IsActive = true,
                    IsDelete = false,
                    DeletedBy ="none",
                    DeletedOn =DateTime.Now,
                    DeletedRemark="Not deleted",
                    CreatedBy = "Munasinghe",
                    CreatedOn =DateTime.Now,
                    LastModifiedOn=DateTime.Now,
                    LastModifiedBy="Not modified",
                    Name = "Goodwill",
                    Address ="NamalStreet,Colombo",
                    PhoneNumber =0123456783,
                    ContactPerson ="Dr.Kaliyawansa",
              },
            });


            modelBuilder.Entity<Vaccine>().HasData(new Vaccine[]
            {
                new Vaccine
                {
                    Id =1,
                    VaccineName ="Sinopharm BIBP",
                    Type ="Inactivated",
                    Country ="China" 
                },

                new Vaccine
                {
                     Id =2,
                    VaccineName ="Pfizer–BioNTech",
                    Type ="TozinameranVaccineInjection",
                    Country ="Singapore"
                },

                new Vaccine
                {
                     Id =3,
                    VaccineName ="Moderna",
                    Type ="mRNA",
                    Country ="America"
                },


                 new Vaccine
                {
                     Id =4,
                    VaccineName ="Sputnik V",
                    Type ="Viral vector",
                    Country ="Russia"
                },

            });

            modelBuilder.Entity<VaccineBatch>().HasData(new VaccineBatch[]
            {
                new VaccineBatch
                {
                    Id =1,
                    Name ="FirstBatch",
                    VaccineId=1,
                    BatchNumber=456789,
                    Manufacturer="Gamaleya Research"
                },

                new VaccineBatch
                {
                    Id =2,
                    Name ="SecondBatch",
                    VaccineId=2,
                    BatchNumber=456733,
                    Manufacturer="Charles Research"
                },

                new VaccineBatch
                {
                    Id =3,
                    Name ="ThirdBatch",
                    VaccineId=3,
                    BatchNumber=456789,
                    Manufacturer=" BIONTECH"
                },

                new VaccineBatch
                {
                    Id =4,
                    Name ="ForthBatch",
                    VaccineId=4,
                    BatchNumber=456321,
                    Manufacturer="Beijing Institute"
                }
            });


            modelBuilder.Entity<VaccineDose>().HasData(new VaccineDose[]
            {
                new VaccineDose
                {
                    Id = 1,
                    VaccineId = 1,
                    RequiredCount = 0,
                    VaccinatedDate = DateTime.Now,
                    HealthWorker = "Designated vaccinator by MOH approved vaccination site"
                },

                new VaccineDose
                {
                    Id = 2,
                    VaccineId = 2,
                    RequiredCount = 1,
                    VaccinatedDate = DateTime.Now,
                    HealthWorker = "Designated vaccinator by MOH approved vaccination site"
                },

                new VaccineDose
                {
                    Id = 3,
                    VaccineId = 3,
                    RequiredCount = 2,
                    VaccinatedDate = DateTime.Now,
                    HealthWorker = "Designated vaccinator by MOH approved vaccination site"
                },

                new VaccineDose
                {
                    Id = 4,
                    VaccineId = 4,
                    RequiredCount = 3,
                    VaccinatedDate = DateTime.Now,
                    HealthWorker = "Designated vaccinator by MOH approved vaccination site"
                }
            }) ;

        }
    }
}

