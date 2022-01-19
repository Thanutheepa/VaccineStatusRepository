using Microsoft.EntityFrameworkCore;

namespace VaccineStatus.WebApi.Data
{
    public class db_a7f2ac_vaccinestatus001Context :DbContext
    {
        public db_a7f2ac_vaccinestatus001Context(DbContextOptions<db_a7f2ac_vaccinestatus001Context> options):base(options)
        {
                
        }
        public DbSet<MedicalInstituteA> MedicalInstituteA { get; set; }
    }
}
