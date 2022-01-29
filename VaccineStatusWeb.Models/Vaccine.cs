using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineStatusWeb.Models;

namespace VaccineStatusWeb.Models
{
    public class Vaccine
    {
        public int Id { get; set; }
        public string VaccineName { get; set; }
        public string Type { get; set; }
        public string Country { get; set; }
    }
}
