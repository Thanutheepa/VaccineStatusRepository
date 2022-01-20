namespace VaccineStatus.WebApi.Models
{
    public class Organization
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int OfficialContactNumber { get; set; }

        public string Address { get; set; }
    }
}
