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
            var get = new string[] { "Task 1", "Task 2", "Task 3", "Task 4" };
            return Ok(get);
        }

        [HttpPost("CreateMedicalInstitue")]
        public IActionResult Create()
        {
            return Ok();
        }

        [HttpPut("UpdateMedicalInstitue")]
        public IActionResult Update()
        {
            return Ok();
        }

        [HttpDelete("DeleteMedicalInstitue/{Id}")]
        public IActionResult Delete(int Id)
        {
            var somethingWentWrong = true;
            if (somethingWentWrong)
                return BadRequest();
            return Ok();
        }

        
    }
}

