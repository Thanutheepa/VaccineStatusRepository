using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineStatusWeb.Models;


namespace VaccineStatusWeb.Models
{
    public class VaccineBatch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int VaccineId { get; set; }
        public int BatchNumber { get; set; }
        public string Manufacturer { get; set; }
    }
}
