using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaccineStatusWeb.Services.VaccineBatches;

namespace VaccineStatus.WebApi.Controllers
{
    [Route("api/[[VaccineBatches]]")]
    [ApiController]
    public class VaccineBatchesController : ControllerBase
    {
        private readonly IVaccineBatchRepository _vaccineBatchService;
        public VaccineBatchesController(IVaccineBatchRepository repository)
        {
            _vaccineBatchService = repository;
        }

        [HttpGet]
        public IActionResult GetVaccineBatches()
        {
            var myVaccineBatches = _vaccineBatchService.AllVaccineBatches();
            return Ok(myVaccineBatches);
        }

        [HttpGet("{id}")]
        public IActionResult GetVaccineBatch(int id)
        {
            var VaccineBatch = _vaccineBatchService.GetVaccineBatch(id);

            if (VaccineBatch == null)
            {
                return NotFound();
            }

            return Ok(VaccineBatch);
        }
    }
}
