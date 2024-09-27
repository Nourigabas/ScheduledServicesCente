using AutoMapper;
using Domain.ModelForCreate;
using Domain.Models;
using Domain.ModelsForCreateAndUpdate;
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
            CreateMap<Sector, SectorForCreate_Update>();
            CreateMap<SectorForCreate_Update, Sector>();
        }
    }
}
