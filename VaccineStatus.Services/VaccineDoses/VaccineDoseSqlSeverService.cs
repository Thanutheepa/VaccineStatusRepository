using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineStatusWeb.DataAccess;
using VaccineStatusWeb.Models;

namespace VaccineStatusWeb.Services.VaccineDoses
{
    public class VaccineDoseSqlSeverService : IVaccineDoseRepository
    {
        private readonly MedicalInstituteDbContext _context = new MedicalInstituteDbContext();

        public List<VaccineDose> AllVaccineDoses()
        {
            return _context.VaccineDoses.ToList();
        }

        public VaccineDose GetVaccineDose(int id)
        {
            return _context.VaccineDoses.Find(id);
        }
    }
}
