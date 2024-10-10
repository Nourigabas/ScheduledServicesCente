using AutoMapper;
using Domain.ModelForCreate;
using Domain.Models;

namespace Domain.MappingProfile
{
    public class ReservationProfiles : Profile
    {
        public ReservationProfiles()
        {
            CreateMap<Reservation, ReservationForCreate_Update>();
            CreateMap<ReservationForCreate_Update, Reservation>();
        }
    }
}