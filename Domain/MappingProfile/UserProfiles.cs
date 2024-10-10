using AutoMapper;
using Domain.ModelForCreate;
using Domain.Models;

namespace Domain.MappingProfile
{
    public class UserProfiles : Profile
    {
        public UserProfiles()
        {
            CreateMap<User, UserForCreate_Update>();
            CreateMap<UserForCreate_Update, User>();
        }
    }
}