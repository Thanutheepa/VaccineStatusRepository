using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineStatus.WebApi.Models;
using VaccineStatusWeb.DataAccess;

namespace VaccineStatusWeb.Services.MedicalInstitutes
{
    public class MedicalInstituteSqlSeverService : IMedicalInstituteRepository
    {
        private readonly MedicalInstituteDbContext _context = new MedicalInstituteDbContext();
        public List<MedicalInstitute> AllMedicalInstitutes()
        {
            return _context.MedicalInstitutes.ToList();
        }

        public MedicalInstitute GetMedicalInstitute(int id)
        {
            return _context.MedicalInstitutes.Find(id);
        }
    }
}
