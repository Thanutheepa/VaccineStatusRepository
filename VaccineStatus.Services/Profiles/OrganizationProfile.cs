using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaccineStatus.WebApi.Models;
using VaccineStatusWeb.Services.ViewModels;

namespace VaccineStatusWeb.Services.Profiles
{
    public class OrganizationProfile : Profile
    {
        public OrganizationProfile()
        {
            CreateMap<Organization, OrganizationDto>();
            CreateMap<CreateOrganizationDto, Organization>();
            CreateMap<UpdateOrganizationDto, Organization>();
            
        }
    }
}
