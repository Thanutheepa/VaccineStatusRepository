using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaccineStatusWeb.Services.Organizations;

namespace VaccineStatus.WebApi.Controllers
{
    [Route("api/[[Organizations]]")]
    [ApiController]
    public class OrganizationsController : ControllerBase
    {
        private readonly IOrganizationRespository _organizationService;
        public OrganizationsController(IOrganizationRespository repository)
        {
            _organizationService = repository;
        }


        [HttpGet]
        public IActionResult GetOrganizations()
        {
            var myOrganizations = _organizationService.AllOrganizations();
            return Ok(myOrganizations);
        }

        [HttpGet("{id}")]
        public IActionResult GetOrganization(int id)
        {
            var Organization = _organizationService.GetOrganization(id);

            if (Organization == null)
            {
                return NotFound();
            }

            return Ok(Organization);
        }
    }
}
