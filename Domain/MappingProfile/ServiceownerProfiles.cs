using AutoMapper;
using Domain.ModelForCreate;
using Domain.Models;

namespace Domain.MappingProfile
{
    public class ServiceownerProfiles : Profile
    {
        public ServiceownerProfiles()
        {
            CreateMap<ServiceOwnerForCreate_Update, ServiceOwner>();
            CreateMap<ServiceOwner, ServiceOwnerForCreate_Update>();
        }
    }
}