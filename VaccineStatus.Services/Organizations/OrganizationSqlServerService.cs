﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineStatus.WebApi.Models;
using VaccineStatusWeb.DataAccess;


namespace VaccineStatusWeb.Services.Organizations
{
    public class OrganizationSqlServerService : IOrganizationRespository
    {
        private readonly MedicalInstituteDbContext _context = new MedicalInstituteDbContext();

        public List<Organization> AllOrganizations()
        {
            return _context.Organizations.ToList();
        }

       

        public Organization GetOrganization(int id)
        {

            return _context.Organizations.Find(id);
        }
    }
}
