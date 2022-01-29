using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineStatusWeb.Models;

namespace VaccineStatusWeb.Services.VaccineDoses
{
    public interface IVaccineDoseRepository
    {
        public List<VaccineDose> AllVaccineDoses();
        public VaccineDose GetVaccineDose(int id);
    }
}
