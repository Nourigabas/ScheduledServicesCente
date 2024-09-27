using AutoMapper;
using Domain.ModelForCreate;
using Domain.Models;
using Microsoft.AspNetCore.JsonPatch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.RepositoryModels.M_User
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly IMapper mapper;
        private readonly DatabaseContext DatabaseContext;
        public UserRepository(DatabaseContext DatabaseContext, IMapper mapper) : base(DatabaseContext)
        {
            this.mapper = mapper;
            this.DatabaseContext = DatabaseContext;
        }

        public void CreateUser(User User)
        {
            Add(User);
            SaveChange();
        }

        public void DeleteUser(Guid UserId)
        {
            var respone = DatabaseContext.Users.FirstOrDefault(e => e.Id == UserId);
            respone.IsDeleted = true;
            SaveChange();
        }

        public List<User> GetUser()
        {
            var respone = All(new[]
            {
                    "Reservations"
            })
                        .Where(e => e.IsDeleted == false)
                        .ToList();
            return respone;
        }

        public User GetUser(Guid UserId)
        {
            var response = Get(e => e.Id == UserId && !e.IsDeleted, new[]
            {
                    "Reservation"
            });
            return response;
        }
 

        public void UpdateUser(Guid UserId, JsonPatchDocument<UserForCreate_Update> PatchDocument)
        {
            var User = GetUser(UserId);
            var UserToPatch = mapper.Map<UserForCreate_Update>(User);
            PatchDocument.ApplyTo(UserToPatch);
            mapper.Map(UserToPatch, User);
            SaveChange();
            return;
        }
    }
}
