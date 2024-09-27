using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.RepositoryModels.M_User
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly DatabaseContext DatabaseContext;
        public UserRepository(DatabaseContext DatabaseContext) : base(DatabaseContext)
        {
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

        public void UpdateUser(Guid UserId)
        {
            throw new NotImplementedException();
        }
    }
}
