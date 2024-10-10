using AutoMapper;
using Domain.Models;
using Domain.ModelsForCreateAndUpdate;

namespace Domain.MappingProfile
{
    public class SectorProfiles : Profile
    {
        public SectorProfiles()
        {
            CreateMap<Sector, SectorForCreate_Update>();
            CreateMap<SectorForCreate_Update, Sector>();
        }
    }
}