using AutoMapper;
using Data.Repository.EncryptionRepository;
using Domain.ModelForCreate;
using Domain.Models;
using Microsoft.AspNetCore.JsonPatch;

namespace Data.Repository.RepositoryModels.M_User
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
     
        private readonly IMapper mapper;
        private readonly IEncryptionRepository Encryption;
        private readonly DatabaseContext DatabaseContext;
        public UserRepository(DatabaseContext DatabaseContext, IMapper mapper, IEncryptionRepository Encryption) : base(DatabaseContext)
        {
            this.mapper = mapper;
            this.Encryption = Encryption;
            this.DatabaseContext = DatabaseContext;
        }

        public void CreateUser(User User)
        {
            User.Password = Encryption.Encryption(User.Password);
            Add(User);
            SaveChange();
        }

        public void DeleteUser(Guid UserId)
        {
            var respone = DatabaseContext.Users.FirstOrDefault(e => e.Id == UserId);
            respone.IsDeleted = true;
            SaveChange();
        }

        public List<User> GetUsers()
        {
            var respone = All(new[]
            {
                    "Evaluation",
                    "ServiceOwner",
                    "Reservations"

            })
                        .Where(e => e.IsDeleted == false)
                        .ToList();
            foreach (var temp in respone)
                temp.Password = Encryption.Decryption(temp.Password);
            return respone;
        }

        public User GetUser(Guid UserId)
        {
            var response = Get(e => e.Id == UserId && !e.IsDeleted, new[]
            {
                    "Reservation"
            });
            response.Password = Encryption.Decryption(response.Password);
            return response;
        }

        public void UpdateUser(Guid UserId, JsonPatchDocument<UserForCreate_Update> PatchDocument)
        {
            var User = GetUser(UserId);
            var UserToPatch = mapper.Map<UserForCreate_Update>(User);
            PatchDocument.ApplyTo(UserToPatch);
            mapper.Map(UserToPatch, User);
            if (User.Password is not null)
                User.Password = Encryption.Encryption(User.Password);
            SaveChange();
            return;
        }
    }
}