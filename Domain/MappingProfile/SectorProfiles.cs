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
    public class SectorProfiles: Profile
    {
        public SectorProfiles()
        {
            CreateMap<Sector, SectorForCreate>();
            CreateMap<SectorForCreate, Sector>();
        }
    }
}
