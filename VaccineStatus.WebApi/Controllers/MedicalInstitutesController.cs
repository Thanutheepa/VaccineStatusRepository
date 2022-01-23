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
        public IActionResult GetMedicalInstitue(int id)
        {
            var MedicalInstitute = _mediicalInstituteService?.GetMedicalInstitute(id);       

            if (MedicalInstitute == null)
            {
                return NotFound();
            }

            return Ok(MedicalInstitute);
        }

        
        
    }
}

