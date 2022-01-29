using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineStatusWeb.DataAccess;
using VaccineStatusWeb.Models;

namespace VaccineStatusWeb.Services.VaccineBatches
{
    public class VaccineBatchSqlSeverService :IVaccineBatchRepository
    {
        private readonly MedicalInstituteDbContext _context = new MedicalInstituteDbContext();

        public List<VaccineBatch> AllVaccineBatches()
        {
            return _context.VaccineBatches.ToList();
        }

        public VaccineBatch GetVaccineBatch(int id)
        {
            return _context.VaccineBatches.Find(id);
        }
    }
}
