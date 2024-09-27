using AutoMapper;
using Domain.ModelForCreate;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.MappingProfile
{
    public class ServiceProfiles: Profile
    {
        public ServiceProfiles()
        {
        CreateMap<Service, ServiceForCreate>();
        CreateMap<ServiceForCreate, Service>();
        }
    }
}
