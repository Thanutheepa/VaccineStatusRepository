using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineStatusWeb.Models;

namespace VaccineStatusWeb.Models
{
    public class VaccineDose
    {
        public int Id { get; set; }
        public int VaccineId { get; set; }
        public int RequiredCount { get; set; }
        public DateTime? VaccinatedDate { get; set; }
        public string HealthWorker { get; set; } 
    }
}
