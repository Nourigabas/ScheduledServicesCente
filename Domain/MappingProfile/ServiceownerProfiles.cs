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
    public class ServiceownerProfiles: Profile
    {
        public ServiceownerProfiles()
        {
            CreateMap<ServiceOwnerForCreate_Update, ServiceOwner>();
            CreateMap<ServiceOwner, ServiceOwnerForCreate_Update>();
        }
    }
}
