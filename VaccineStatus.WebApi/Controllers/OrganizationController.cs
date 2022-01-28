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
            return Ok("Getting all  Organizations data.");
        }


        [HttpGet]
        [Route("api/Organization/id")]

        public IActionResult GetById(int id)
        {
            return Ok("Getting an Organization data #{id}.");
        }


        [HttpPost]
        [Route("api/Organization")]

        public IActionResult Post()
        {
            return Ok("Create an Organization.");
        }

        [HttpPut]
        [Route("api/Organization")]

        public IActionResult Put()
        {
            return Ok("Update an Organization.");
        }

        [HttpDelete]
        [Route("api/Organization/id")]

        public IActionResult Delete(int id)
        {
            return Ok("Delete an Organization.");
        }
    }
}
