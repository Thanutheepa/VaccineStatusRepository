using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaccineStatus.WebApi.Models;

namespace VaccineStatus.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalInstituteAController : ControllerBase
    {
        [HttpGet("GetMedicalInstitues")]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost("CreateMedicalInstitue")]
        public IActionResult Create([FromBody] MedicalInstitueA request)
        {
            return Ok();
        }

        [HttpPut("UpdateMedicalInstitue")]
        public IActionResult Update([FromBody] MedicalInstitueA request)
        {
            return Ok();
        }

        [HttpDelete("DeleteMedicalInstitue/{Id}")]
        public IActionResult Delete(int Id)
        {
            return Ok();
        }

        
    }
}

