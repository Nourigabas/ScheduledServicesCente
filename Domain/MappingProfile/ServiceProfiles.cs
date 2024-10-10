using AutoMapper;
using Domain.ModelForCreate;
using Domain.Models;

namespace Domain.MappingProfile
{
    public class ServiceProfiles : Profile
    {
        public ServiceProfiles()
        {
            CreateMap<Service, ServiceForCreate_Update>();
            CreateMap<ServiceForCreate_Update, Service>();
        }
    }
}