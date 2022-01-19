namespace VaccineStatus.WebApi.Models
{
    public class MedicalInstitueA
    {
        public int Id { get; set; }
        public Boolean  IsActive { get; set; }
        public Boolean IsDelete { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set;}
        public string? DeletedRemark { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int OfficialContactNumber { get; set; }
        public string? OfficialContactPerson { get; set; }
        public int UserId { get; set; }
        public int VaccineDataId { get; set; }
        public string? LastName { get; set; }
    }
}
