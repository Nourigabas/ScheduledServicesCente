using AutoMapper;
using Domain.ModelForCreate;
using Domain.Models;

namespace Domain.MappingProfile
{
    public class AppointmentProfiles : Profile
    {
        public AppointmentProfiles()
        {
            CreateMap<Appointment, AppointmentForCreate_Update>();
            CreateMap<AppointmentForCreate_Update, Appointment>();
        }
    }
}