using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineStatus.WebApi.Models;

namespace VaccineStatusWeb.Models
{
    public class VaccineData
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public int VaccineCentreId { get; set; }
        public int UserId { get; set; }


        public int VaccineBatchId { get; set; }
        public VaccineBatch VaccineBatches { get; set; }


        public ICollection<MedicalInstitute> medicalInstitutes { get; set; }

    }
}
