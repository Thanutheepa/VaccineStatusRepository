using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaccineStatus.WebApi.Models;

namespace VaccineStatus.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalInstituteController : ControllerBase
    {
        public List<MedicalInstitute> GetMedicalInstitutes()
        {
            MedicalInstitute medicalInstitute = new MedicalInstitute()
            {
                Id = 1,
                Name = "PambahinnaHospital",
                Description = "Null",
                OfficialContactNumber = 0774532168,
                ContactPerson = "Alice"
            };
            return 

                new List<MedicalInstitute>()
            { medicalInstitute
            };
        }


    }
}
