using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineStatusWeb.Models;

namespace VaccineStatusWeb.Services.VaccineDatas
{
    public interface IVaccineDataRepository
    {
        public List<VaccineData> GetAllVaccineDatas();
        public VaccineData GetVaccineData(int id);
    }
}
