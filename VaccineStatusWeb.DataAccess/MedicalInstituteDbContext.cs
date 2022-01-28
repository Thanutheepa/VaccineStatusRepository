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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server = (localdb)\mssqllocaldb; Database = myVaccineDb; Trusted_Connection = True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VaccineData>().HasData(new VaccineData[]
            {
                new VaccineData{ Id = 1, UserName = "Dorin",VaccineBatch=123,Date=DateTime.Now,VaccineCentre="SUSL-MC",UserId=1},
                new VaccineData{ Id = 2, UserName = "Shara",VaccineBatch=466,Date=DateTime.Now,VaccineCentre="Pambahinna",UserId=2},
                new VaccineData{ Id = 3, UserName = "Tom",VaccineBatch=789,Date=DateTime.Now,VaccineCentre="Balangoda",UserId=4},
                new VaccineData{ Id = 4, UserName = "Sana",VaccineBatch=152,Date=DateTime.Now,VaccineCentre="Ratnapura",UserId=5}
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

        }
    }
}
