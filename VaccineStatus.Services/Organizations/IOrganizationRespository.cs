using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineStatus.WebApi.Models;

namespace VaccineStatusWeb.Services.Organizations

{
    public interface IOrganizationRespository
    {
        public List<Organization> AllOrganizations();
        public Organization GetOrganization(int id);
        public Organization AddOrganization(Organization organization);
        public void UpdateOrganization(Organization organization);
        public void DeleteOrganization(Organization organization);
    }
}
