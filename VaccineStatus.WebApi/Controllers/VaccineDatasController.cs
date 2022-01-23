using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaccineStatusWeb.Services.VaccineDatas;

namespace VaccineStatus.WebApi.Controllers
{
    [Route("api/[[VaccineDatas]]")]
    [ApiController]
    public class VaccineDatasController : ControllerBase
    {
        private readonly IVaccineDataRepository _service;
        public VaccineDatasController(IVaccineDataRepository service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetVaccineDatas()
        {
            var VaccineDatas = _service.GetAllVaccineDatas();
            return Ok(VaccineDatas);
        }

        [HttpGet("{id}")]
        public IActionResult GetVaccineData(int id)
        {
            var VaccineData = _service.GetVaccineData(id);

            if (VaccineData == null)
            {
                return NotFound();
            }

            return Ok(VaccineData);
        }
    }
}
