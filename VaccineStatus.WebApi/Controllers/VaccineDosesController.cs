using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaccineStatusWeb.Services.VaccineDoses;

namespace VaccineStatus.WebApi.Controllers
{
    [Route("api/[[VaccineDoses]]")]
    [ApiController]
    public class VaccineDosesController : ControllerBase
    {
        private readonly IVaccineDoseRepository _vaccineDoseService;
        public VaccineDosesController(IVaccineDoseRepository repository)
        {
            _vaccineDoseService = repository;
        }

        [HttpGet]
        public IActionResult GetVaccineDoses()
        {
            var myVaccineDoses = _vaccineDoseService.AllVaccineDoses();
            return Ok(myVaccineDoses);
        }

        [HttpGet("{id}")]
        public IActionResult GetVaccineDose(int id)
        {
            var VaccineDose = _vaccineDoseService.GetVaccineDose(id);

            if (VaccineDose == null)
            {
                return NotFound();
            }

            return Ok(VaccineDose);
        }
    }
}
