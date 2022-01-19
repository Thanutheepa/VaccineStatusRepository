using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaccineStatus.WebApi.Models;

namespace VaccineStatus.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
       


        [HttpGet]
        [Route("api/Organization")]

        public IActionResult Get()
        {
            return Ok("Getting all the Medical Institute data.");
        }


        [HttpGet]
        [Route("api/Organization/id")]

        public IActionResult GetById(int id)
        {
            return Ok("Getting one Medical Institute data #{id}.");
        }


        [HttpPost]
        [Route("api/Organization")]

        public IActionResult Post()
        {
            return Ok("Create Medical Institute.");
        }

        [HttpPut]
        [Route("api/Organization")]

        public IActionResult Put()
        {
            return Ok("Update Medical Institute.");
        }

        [HttpDelete]
        [Route("api/Organization/id")]

        public IActionResult Delete(int id)
        {
            return Ok("Delete Medical Institute.");
        }
    }
}
