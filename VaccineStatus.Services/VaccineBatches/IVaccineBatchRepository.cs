using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineStatusWeb.Models;

namespace VaccineStatusWeb.Services.VaccineBatches
{
    public interface IVaccineBatchRepository
    {
        public List<VaccineBatch> AllVaccineBatches();
        public VaccineBatch GetVaccineBatch(int id);
    }
}
