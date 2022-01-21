﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaccineStatusWeb.Models
{
    public class VaccineData
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public int VaccineBatch { get; set;}
        public DateTime Date { get; set; }
        public string? VaccineCentre { get; set; }
        public int UserId { get; set; }

    }
}
