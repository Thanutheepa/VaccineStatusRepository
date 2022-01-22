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
        public DbSet<MedicalInstitute>? MedicalInstitutes { get; set; }
        public DbSet<VaccineData>? VaccineDatas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server = (localdb)\mssqllocaldb; Database = myMedicalInstituteDb; Trusted_Connection = True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VaccineData>().HasData(new VaccineData[]
            {
                new VaccineData{ Id = 1, UserName = "Dorin"},
                new VaccineData{ Id = 2, UserName = "Shara"},
                new VaccineData{ Id = 3, UserName = "Tom"},
                new VaccineData{ Id = 4, UserName = "Sana"}
            });


            modelBuilder.Entity<MedicalInstitute>().HasData(new MedicalInstitute[]
            {
              new MedicalInstitute
                {
                    Id = 1,
                    Name = "PumbahinnaHospital - DB",
                    Description = "LocatedInRatnapura",
                    CreatedBy = "Adheera",
                    VaccineDataId = 1
                },

              new MedicalInstitute
                {
                    Id = 2,
                    Name = "AnuradhapuraHospital",
                    Description = "LocatedInAnuradhapura",
                    CreatedBy = "Doily",
                    VaccineDataId = 1
                },

              new MedicalInstitute
                { 
                    Id = 3,
                    Name = "BadullaHospital",
                    Description = "LocatedInBadulla",
                    CreatedBy = "John",
                    VaccineDataId = 2
                },
            });

        }
    }
}
