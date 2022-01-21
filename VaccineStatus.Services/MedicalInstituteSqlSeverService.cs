using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineStatus.WebApi.Models;
using VaccineStatusWeb.DataAccess;

namespace VaccineStatusWeb.Services
{
    public class MedicalInstituteSqlSeverService : IMedicalInstituteRepository
    {
        private readonly MedicalInstituteDbContext context = new MedicalInstituteDbContext();
        public List<MedicalInstitute> AllMedicalInstitutes()
        {
            return context.MedicalInstitutes.ToList();
        }
    }
}
