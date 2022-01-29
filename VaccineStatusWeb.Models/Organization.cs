using VaccineStatusWeb.Models;

namespace VaccineStatus.WebApi.Models

{
    public class Organization
    {
        public int Id { get; set; }
        public Boolean IsActive { get; set; }
        public Boolean IsDelete { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public string DeletedRemark { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string ContactPerson { get; set; }
       
    }
}
