using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VaccineStatus.WebApi.Models;

namespace VaccineStatusWeb.DataAccess
{
    public class MedicalInstituteDbContext : DbContext
    {
        public DbSet<MedicalInstitute>? MedicalInstitutes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server = localhost; Database = myMedicalInstituteDb; Trusted_Connection = True";
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
