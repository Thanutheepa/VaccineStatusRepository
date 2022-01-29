using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaccineStatusWeb.Services.Vaccines;

namespace VaccineStatus.WebApi.Controllers
{
    [Route("api/[[Vaccines]]")]
    [ApiController]
    public class VaccinesController : ControllerBase
    {
        private readonly IVaccineRepository _vaccineService;
        public VaccinesController(IVaccineRepository repository)
        {
            _vaccineService = repository;
        }


        [HttpGet]
        public IActionResult GetVaccines()
        {
            var myVaccines = _vaccineService.AllVaccines();
            return Ok(myVaccines);
        }

        [HttpGet("{id}")]
        public IActionResult GetVaccine(int id)
        {
            var Vaccine = _vaccineService.GetVaccine(id);

            if (Vaccine == null)
            {
                return NotFound();
            }

            return Ok(Vaccine);
        }

    }
}
