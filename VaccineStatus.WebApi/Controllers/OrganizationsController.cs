using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VaccineStatus.WebApi.Models;
using VaccineStatusWeb.Services.Organizations;
using VaccineStatusWeb.Services.ViewModels;

namespace VaccineStatus.WebApi.Controllers
{
    [Route("api/[[Organizations]]")]
    [ApiController]
    public class OrganizationsController : ControllerBase
    {
        private readonly IOrganizationRespository _organizationService;
        private readonly IMapper _mapper;
        public OrganizationsController(IOrganizationRespository repository, IMapper mapper)
        {
            _organizationService = repository;
            _mapper = mapper;
        }


        [HttpGet]
        public ActionResult<ICollection<OrganizationDto>> GetOrganizations()
        {
            var myOrganizations = _organizationService.AllOrganizations();
            
            var mappedOrganizations = _mapper.Map<ICollection<OrganizationDto>>(myOrganizations);
            return Ok(mappedOrganizations);
        }

        [HttpGet("{id}", Name = "GetOrganization")]
        public IActionResult GetOrganization(int id)
        {
            var Organization = _organizationService.GetOrganization(id);

            if (Organization == null)
            {
                return NotFound();
            }

            var mappedOrganization = _mapper.Map<OrganizationDto>(Organization);

            return Ok(Organization);
        }

        [HttpPost]
        public ActionResult<OrganizationDto>CreateOrganization(CreateOrganizationDto organization)
        {
            var organizationEntity = _mapper.Map<Organization>(organization);

            var newOrganization = _organizationService.AddOrganization(organizationEntity);

            var OrganizationForReturn = _mapper.Map<OrganizationDto>(newOrganization);

            return CreatedAtRoute("GetOrganization", new {id = OrganizationForReturn.Id},
                OrganizationForReturn);
        }

        [HttpPut (template:"{organizationId}")]

        public ActionResult UpdateOrganization(int organizationId, UpdateOrganizationDto organization)
        {
            var updatingOrganization = _organizationService.GetOrganization(organizationId);
            if (updatingOrganization == null)
            {
                return NotFound();
            }

            _mapper.Map(organization, updatingOrganization);
            _organizationService.UpdateOrganization(updatingOrganization);

            return NoContent();
           
        }

        [HttpDelete (template:"{ogranizationId}")]

        public ActionResult DeleteOrganization(int organizationId)
        {
            var deletingOrganization = _organizationService.GetOrganization(organizationId);
            if (deletingOrganization == null)
            {
                return NotFound();
            }

            _organizationService.DeleteOrganization(deletingOrganization);
            return NoContent();
        }
    }
}
