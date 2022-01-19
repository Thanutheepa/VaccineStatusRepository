﻿using VaccineStatus.WebApi.Models;

namespace VaccineStatus.WebApi.Services
{
    public class MedicalInstituteService
    {
        //Get MedicalInstitutes
        public List<MedicalInstitute> AllMedicalInstitutes()
        {
            var medicalInstitutes = new List<MedicalInstitute>();

            var medicalInstitute1 = new MedicalInstitute
            {
                Id = 1,
                Name = "PumbahinnaHospital",
                Description = "LocatedInRatnapura",
                CreatedBy = "Adheera",

            };
            medicalInstitutes.Add(medicalInstitute1);


            var medicalInstitute2 = new MedicalInstitute
            {
                Id = 2,
                Name = "AnuradhapuraHospital",
                Description = "LocatedInAnuradhapura",
                CreatedBy = "Doily",


            };
            medicalInstitutes.Add(medicalInstitute2);


            var medicalInstitute3 = new MedicalInstitute
            {
                Id = 3,
                Name = "BadullaHospital",
                Description = "LocatedInBadulla",
                CreatedBy = "John",

            };
            medicalInstitutes.Add(medicalInstitute3);

            return medicalInstitutes;
        }
    }
}