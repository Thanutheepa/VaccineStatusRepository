using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineStatus.WebApi.Models;

namespace VaccineStatusWeb.Services.MedicalInstitutes
{
    public interface IMedicalInstituteRepository
    {
        public List<MedicalInstitute> AllMedicalInstitutes();
        public MedicalInstitute GetMedicalInstitute(int id);
    }
}
