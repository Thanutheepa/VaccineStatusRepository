using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineStatusWeb.Models;
using VaccineStatusWeb.DataAccess;

namespace VaccineStatusWeb.Services.VaccineDatas
{
    public class VaccineDataSqlServerService : IVaccineDataRepository
    {
        private readonly MedicalInstituteDbContext _context = new MedicalInstituteDbContext();
        public List<VaccineData> GetAllVaccineDatas()
        {
           return _context.VaccineDatas.ToList();
        }

        public VaccineData GetVaccineData(int id)
        {
            return _context.VaccineDatas.Find(id);
        }
    }
}
