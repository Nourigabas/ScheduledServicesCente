using AutoMapper;
using Domain.ModelForCreate;
using Domain.Models;

namespace Domain.MappingProfile
{
    public class CategoryServiceProfiles : Profile
    {
        public CategoryServiceProfiles()
        {
            CreateMap<CategoryService, CategoryServiceForCreate_Update>();
            CreateMap<CategoryServiceForCreate_Update, CategoryService>();
        }
    }
}