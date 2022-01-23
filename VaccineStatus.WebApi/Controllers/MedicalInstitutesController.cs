using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaccineStatusWeb.Services.MedicalInstitutes;

namespace VaccineStatus.WebApi.Controllers
{
    [Route("api/[[MedicalInstitutes]]")]
    [ApiController]
    public class MedicalInstitutesController : ControllerBase
    {
        private readonly IMedicalInstituteRepository _mediicalInstituteService;

        public MedicalInstitutesController(IMedicalInstituteRepository repository)
        {
               _mediicalInstituteService = repository;
        }

        [HttpGet]
        public IActionResult GetMedicalInstitues()
        {
           var myMedicalInstitutes = _mediicalInstituteService?.AllMedicalInstitutes();
            return Ok(myMedicalInstitutes);
        }

        [HttpGet("{id?}")]
        public IActionResult GetMedicalInstitues(int? id)
        {
            var myMedicalInstitutes = _mediicalInstituteService?.AllMedicalInstitutes(); //.Where(i => i.Id == id)
            
            if (id is null) return Ok(myMedicalInstitutes);

            myMedicalInstitutes = myMedicalInstitutes?.Where(x => x.Id == id).ToList();
            return Ok(myMedicalInstitutes);
        }

        
        
    }
}

