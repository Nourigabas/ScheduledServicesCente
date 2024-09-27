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
    public class ReservationProfiles: Profile
    {
        public ReservationProfiles()
        {
            CreateMap<Reservation, ReservationForCreate>();
            CreateMap<ReservationForCreate, Reservation>();
        }
    }
}
