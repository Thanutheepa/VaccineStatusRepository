using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineStatusWeb.Models;
using VaccineStatusWeb.DataAccess;


namespace VaccineStatusWeb.Services.Vaccines
{
    public class VaccineSqlSeverService : IVaccineRepository
    {
        private readonly MedicalInstituteDbContext _context = new MedicalInstituteDbContext();
        public List<Vaccine> AllVaccines()
        {
            return _context.Vaccines.ToList();
        }

        public Vaccine GetVaccine(int id)
        {
            return _context.Vaccines.Find(id);
        }
    }
}
