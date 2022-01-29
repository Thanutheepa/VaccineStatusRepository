using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineStatus.WebApi.Models;
using VaccineStatusWeb.Models;

namespace VaccineStatusWeb.Services.Vaccines
{
    public interface IVaccineRepository
    {
        public List<Vaccine> AllVaccines();
        public Vaccine GetVaccine(int id);
    }
}
