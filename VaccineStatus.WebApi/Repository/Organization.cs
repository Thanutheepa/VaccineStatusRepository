namespace VaccineStatus.WebApi.Repository
{
    public interface IOrganization
    {
        public IEnumerable<IOrganization>GetOrganizations();
        public IOrganization GetOrganization(string organizationId);
        public void CreateOrganization(IOrganization organization);
        public void UpdateOrganization(string organizationId, string name);
        public void DeleteOrganization(string organizationId);

    }
}
